using eBEST.OpenApi.Events;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable MA0004

#if !NETCOREAPP
namespace System.Runtime.CompilerServices { internal class IsExternalInit { } }
#endif

namespace eBEST.OpenApi
{
    public class EBestOpenApi
    {
        /// <summary>
        /// 로그인 서버 타입
        /// </summary>
        public enum SERVER_TYPE
        {
            실투자,
            모의투자,
        }

        //private readonly string _baseUrl = "https://openapi.ebestsec.co.kr:8080";
        //private readonly string _wssUrlReal = "wss://openapi.ebestsec.co.kr:9443";
        //private readonly string _wssUrlSimulation = "wss://openapi.ebestsec.co.kr:29443";

        /// <summary>
        /// 2024.06.01 이베스트증권 -> LS증권으로 변경
        /// </summary>
        const string BaseUrl = "https://openapi.ls-sec.co.kr:8080";
        const string WssUrlReal = "wss://openapi.ls-sec.co.kr:9443";
        const string WssUrlSimulation = "wss://openapi.ls-sec.co.kr:29443";

        private readonly HttpClient _httpClient;
        private ClientWebSocket? _wssClient;
        private string _authorization = string.Empty;
        private string _macAddress = string.Empty;
        private long _expires_in;
        private readonly JsonSerializerOptions _jsonOptions;

        /// <summary>
        /// 서버연결 이벤트
        /// </summary>
        public event EventHandler<EBestOnConnectEventArgs>? OnConnectEvent;

        /// <summary>
        /// 서버 메시지 이벤트
        /// </summary>
        public event EventHandler<EBestOnMessageEventArgs>? OnMessageEvent;

        /// <summary>
        /// 실시간 웹소켓 이벤트
        /// </summary>
        public event EventHandler<EBestOnRealtimeEventArgs>? OnRealtimeEvent;

        public EBestOpenApi()
        {
            _jsonOptions = new()
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
            };

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl),
            };
        }

        /// <summary>
        /// 로그인 서버 타입 (실투자, 모의투자)
        /// </summary>
        public SERVER_TYPE ServerType { get; private set; }

        /// <summary>
        /// 로그인 된 경우 true
        /// </summary>
        public bool Connected { get; private set; }

        /// <summary>
        /// 마지막 에러 메시지
        /// </summary>
        public string LastErrorMessage = string.Empty;

        /// <summary>
        /// MAC 주소, 법인 경우 필수
        /// </summary>
        /// <param name="macAddress">macAddress</param>
        [Obsolete("use MacAddress Property")]
        public void SetMacAdress(string macAddress) => _macAddress = macAddress;

        /// <summary>
        /// MAC 주소 (법인 경우 필수 세팅)
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set => _macAddress = value;
        }

        /// <summary>
        /// 접근토큰 유효기간(초)
        /// </summary>
        /// <returns></returns>
        public long GetExpires() => _expires_in;

        /// <summary>
        /// 연결 요청
        /// </summary>
        /// <param name="appKey">포탈에서 발급된 고객의 앱Key</param>
        /// <param name="appSecretKey">포탈에서 발급된 고객의 앱 비밀Key</param>
        /// <returns>true: 연결성공, false: 연결실패</returns>
        public async ValueTask<bool> ConnectAsync(string appKey, string appSecretKey)
        {
            if (Connected)
            {
                LastErrorMessage = "Aleady connected";
                return true;
            }
            LastErrorMessage = string.Empty;

            // OAuth 인증키 가져오기
            OAuth? oAuth = await PostUrlEncodedAsync<OAuth>("/oauth2/token",
                [
                    new("grant_type", "client_credentials"),
                    new("appkey", appKey),
                    new("appsecretkey", appSecretKey),
                    new("scope", "oob"),
                ]).ConfigureAwait(true);

            if (oAuth == null)
            {
                LastErrorMessage = "인증키 가져오기 실패";
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
                return false;
            }

            // 인증성공
            _authorization = oAuth.access_token;
            _expires_in = oAuth.expires_in;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(oAuth.token_type, _authorization);

            // 모의투자인지 실투자인지 구분하기 위해 FOCCQ33600 더미조회, 모의투자시 응답메시지에 '모의투자' 있음
            Dummy_FOCCQ33600 더미조회 = new()
            {
                FOCCQ33600InBlock1 = null,
            };
            await GetTRData(더미조회).ConfigureAwait(true);
            if (더미조회.rsp_msg is not null && 더미조회.rsp_msg.StartsWith("모의투자", StringComparison.Ordinal))
            {
                ServerType = SERVER_TYPE.모의투자;
            }

            // 실시간 웹소켓 연결
            Uri wssUri = new((ServerType == SERVER_TYPE.실투자 ? WssUrlReal : WssUrlSimulation) + "/websocket");
            try
            {

                _wssClient = new ClientWebSocket();
                if (_wssClient.ConnectAsync(wssUri, CancellationToken.None).Wait(2000))
                {
                    Connected = true;
                    _ = WebsocketListen(_wssClient);

                    OnConnectEvent?.Invoke(this, new(Ok: true, $"{ServerType} 연결 성공"));
                    return true;
                }
            }
            catch (Exception)
            {
                _wssClient = null;
                LastErrorMessage = "Websocket서버 연결 응답 없습니다";
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
                return false;
            }

            return false;
        }

        /// <summary>
        /// 연결 해제
        /// </summary>
        /// <returns></returns>
        public async Task CloseAsync()
        {
            if (!Connected || _wssClient == null)
            {
                LastErrorMessage = "Aleady disconnected";
                return;
            }

            Connected = false;

            try
            {
                await _wssClient.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye^^", CancellationToken.None).ConfigureAwait(false);
                LastErrorMessage = "Success disconnected";
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
            return;
        }

        /// <summary>
        /// 계좌 실시간 등록
        /// </summary>
        /// <param name="tr_cd">이베스트증권 거래코드</param>
        /// <returns>true: 요청성공, false: 요청실패</returns>
        public ValueTask<bool> AddAccountRealtimeRequest(string tr_cd) => RealtimeRequest<WssRequest>(new(new(_authorization, "1"), new(tr_cd, string.Empty)));

        /// <summary>
        /// 계좌 실시간 해제
        /// </summary>
        /// <param name="tr_cd">이베스트증권 거래코드</param>
        /// <returns>true: 요청성공, false: 요청실패</returns>
        public ValueTask<bool> RemoveAccountRealtimeRequest(string tr_cd) => RealtimeRequest<WssRequest>(new(new(_authorization, "2"), new(tr_cd, string.Empty)));

        /// <summary>
        /// 실시간 시세등록
        /// </summary>
        /// <param name="tr_cd">이베스트증권 거래코드</param>
        /// <param name="tr_key">단축코드 6자리 또는 8자리 (단건, 연속)</param>
        /// <returns>true: 요청성공, false: 요청실패</returns>
        public ValueTask<bool> AddRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "3"), new(tr_cd, tr_key)));

        /// <summary>
        /// 실시간 시세해제
        /// </summary>
        /// <param name="tr_cd">이베스트증권 거래코드</param>
        /// <param name="tr_key">단축코드 6자리 또는 8자리 (단건, 연속)</param>
        /// <returns>true: 요청성공, false: 요청실패</returns>
        public ValueTask<bool> RemoveRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "4"), new(tr_cd, tr_key)));

        private async Task WebsocketListen(ClientWebSocket webSocket)
        {
            ArraySegment<byte> buffer = new(new byte[1024]);
            while (webSocket.State == WebSocketState.Open)
            {
                using var ms = new MemoryStream();
                WebSocketReceiveResult? result;
                do
                {
                    result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                        OnWssClosed(result.CloseStatusDescription ?? "WebSocket Closed");
                        return;
                    }

#if NETCOREAPP
                    await ms.WriteAsync(buffer.AsMemory(0, result.Count), CancellationToken.None);
#else
                    await ms.WriteAsync(buffer.Array, 0, result.Count, CancellationToken.None);
#endif
                }
                while (!result.EndOfMessage);

                ms.Seek(0, SeekOrigin.Begin);

                if (result.MessageType == WebSocketMessageType.Text)
                {
                    using var reader = new StreamReader(ms, Encoding.UTF8);
                    OnWssReceive(await reader.ReadToEndAsync());
                }
            }
        }
        private void OnWssClosed(string message)
        {
            if (Connected)
            {
                Connected = false;
                LastErrorMessage = message;
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
            }
        }
        private void OnWssReceive(string stringData)
        {
            try
            {
                RealtimeResponseModel? response = JsonSerializer.Deserialize<RealtimeResponseModel>(stringData);
                if (response != null && response.header != null)
                {
                    if (!string.IsNullOrEmpty(response.header.rsp_msg))
                    {
                        OnMessageEvent?.Invoke(this, new($"{response.header.tr_cd}({response.header.tr_type}) : {response.header.rsp_msg}"));
                    }

                    if (response.body is JsonElement jsonElement)
                    {
                        OnRealtimeEvent?.Invoke(this, new(response.header.tr_cd, response.header.tr_key, jsonElement));
                    }
                }
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                OnMessageEvent?.Invoke(this, new(ex.Message));
            }
        }

        protected async ValueTask<bool> RealtimeRequest<T>(T request)
        {
            if (!Connected || _wssClient == null)
            {
                LastErrorMessage = "Not connected";
                return false;
            }

            LastErrorMessage = string.Empty;
            try
            {
                string jsonbody = JsonSerializer.Serialize(request);
#if NETCOREAPP
                await _wssClient.SendAsync(Encoding.UTF8.GetBytes(jsonbody), WebSocketMessageType.Text, true, CancellationToken.None);
#else
                await _wssClient.SendAsync(new(Encoding.UTF8.GetBytes(jsonbody)), WebSocketMessageType.Text, true, CancellationToken.None);
#endif
                return true;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                return false;
            }
        }

        protected async ValueTask<T?> PostUrlEncodedAsync<T>(string path, IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
            LastErrorMessage = string.Empty;
            try
            {
                var response = await _httpClient.PostAsync(path, new FormUrlEncodedContent(nameValueCollection)).ConfigureAwait(false);
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                    }
                    LastErrorMessage = await response.Content.ReadAsStringAsync().ConfigureAwait(false) ?? response.StatusCode.ToString();
                }
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
            return default;
        }

        record OAuth(string access_token, string scope, string token_type, long expires_in);
        record WssRequest(WssRequest.Header header, WssRequest.Body body)
        {
            public record Header(string token, string tr_type);
            public record Body(string tr_cd, string tr_key);
        }
        record RealtimeResponseModel(RealtimeResponseModel.Header header, object body)
        {
            public record Header(string tr_type, string rsp_cd, string rsp_msg, string tr_cd, string tr_key);
        }


        /// <summary>
        /// TR 비동기 요청
        /// </summary>
        /// <param name="request">요청 데이터</param>
        /// <returns>true: 요청성공, false: 요청실패</returns>
        public async ValueTask<bool> GetTRData(TrBase request)
        {
            LastErrorMessage = string.Empty;
            try
            {
                Type TType = request.GetType();
                PathAttribute? pathAttribute = TType.GetCustomAttribute<PathAttribute>()
                        ?? throw new Exception("Path Attribute is not defined");
                string path = pathAttribute.Path;

                // 속성 이름중 InBlock 이 포함된 속성들을 모두 찾는다
                var inBlockProperties = TType.GetProperties().Where(m => m.Name.Contains("InBlock"));
                if (!inBlockProperties.Any())
                    throw new Exception("InBlock is not defined");

                Dictionary<string, object?> nameValueCollection = [];
                foreach (var p in inBlockProperties)
                {
                    nameValueCollection.Add(p.Name, p.GetValue(request));
                }
                string jsonbody = JsonSerializer.Serialize(nameValueCollection);

                // 요청 전문을 만든다
                var content = new StringContent(jsonbody, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };

                httpRequestMessage.Headers.Add("tr_cd", pathAttribute.TRCode.Length > 0 ? pathAttribute.TRCode : TType.Name);
                httpRequestMessage.Headers.Add("tr_cont", request.tr_cont);
                httpRequestMessage.Headers.Add("tr_cont_key", request.tr_cont_key);

                // 법인 경우 mac_address 필수
                if (_macAddress.Length > 0) httpRequestMessage.Headers.Add("mac_address", _macAddress);

                // 요청을 보낸다
                var responseMsg = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

                // 응답을 받는다
                //var contentStream = await responseMsg.Content.ReadAsStreamAsync().ConfigureAwait(false);
                ////await using (contentStream.ConfigureAwait(false))
                ////{
                //var response = await JsonSerializer.DeserializeAsync(contentStream, TType, _jsonOptions).ConfigureAwait(false);


                var jsonResponse = await responseMsg.Content.ReadAsStringAsync().ConfigureAwait(false);
                var response = JsonSerializer.Deserialize(jsonResponse, TType, _jsonOptions);

                // OutBlock 속성을 찾는다
                var outBlockProperties = TType.GetProperties().Where(m => m.Name.Contains("OutBlock"));
                if (outBlockProperties.Any())
                {
                    foreach (var p in outBlockProperties)
                    {
                        var Property = TType.GetProperty(p.Name)!;
                        Property.SetValue(request, Property.GetValue(response));
                    }
                }

                // TrBase 의 베이스 속성값 설정한다    
                request.rsp_cd = TType.GetProperty("rsp_cd")!.GetValue(response) as string ?? string.Empty;
                request.rsp_msg = TType.GetProperty("rsp_msg")!.GetValue(response) as string ?? string.Empty;
                if (responseMsg.Headers.TryGetValues("tr_cont", out IEnumerable<string>? tr_cont))
                    request.tr_cont = tr_cont.First();
                if (responseMsg.Headers.TryGetValues("tr_cont_key", out IEnumerable<string>? tr_cont_key))
                    request.tr_cont_key = tr_cont_key.First();

                return true;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// JSON 요청
        /// </summary>
        /// <param name="path">URL경로</param>
        /// <param name="tr_cd">이베스트증권 거래코드</param>
        /// <param name="tr_cont">연속거래 여부(Y:연속○, N:연속×)</param>
        /// <param name="tr_cont_key">연속일 경우 그전에 내려온 연속키 값 올림</param>
        /// <param name="jsonRequest">요청 전문</param>
        /// <returns></returns>
        public async ValueTask<(string tr_cd, string tr_cont, string tr_cont_key, string jsonResponse)> GetDataWithJsonString(string path, string tr_cd, string tr_cont, string tr_cont_key, string jsonRequest)
        {
            try
            {
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };

                httpRequestMessage.Headers.Add("tr_cd", tr_cd);
                httpRequestMessage.Headers.Add("tr_cont", tr_cont);
                httpRequestMessage.Headers.Add("tr_cont_key", tr_cont_key);
                if (_macAddress.Length > 0) httpRequestMessage.Headers.Add("mac_address", _macAddress);

                var responseMsg = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

                string out_tr_cd = string.Empty;
                string out_tr_cont = string.Empty;
                string out_tr_cont_key = string.Empty;
                var jsonResponse = await responseMsg.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (responseMsg.Headers.TryGetValues("tr_cd", out IEnumerable<string>? list_tr_cd))
                    out_tr_cd = list_tr_cd.First();
                if (responseMsg.Headers.TryGetValues("tr_cont", out IEnumerable<string>? list_tr_cont))
                    out_tr_cont = list_tr_cont.First();
                if (responseMsg.Headers.TryGetValues("tr_cont_key", out IEnumerable<string>? list_tr_cont_key))
                    out_tr_cont_key = list_tr_cont_key.First();
                return (out_tr_cd, out_tr_cont, out_tr_cont_key, jsonResponse);
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
            return (string.Empty, string.Empty, string.Empty, string.Empty);
        }

        /// <summary>
        /// FOCCQ33600 더미조회 (웹소켓 주소확정을 위한 실투자/모의투자 여부 판단)
        /// 메시지 응답에 '모의투자' 있으면 모의투자로 판단
        /// </summary>
        [Path("/stock/accno", TRCode = "FOCCQ33600")]
        class Dummy_FOCCQ33600 : TrBase
        {
            /// 요청
            public object? FOCCQ33600InBlock1 { get; set; }
        }

    }
}
