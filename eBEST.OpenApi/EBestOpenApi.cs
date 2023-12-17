using eBEST.OpenApi.Events;
using eBEST.OpenApi.Models;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable MA0004

namespace eBEST.OpenApi
{
    public class EBestOpenApi
    {
        public enum SERVER_TYPE
        {
            실투자,
            모의투자,
        }

        private readonly string _baseUrl = "https://openapi.ebestsec.co.kr:8080";
        private readonly string _wssUrlReal = "wss://openapi.ebestsec.co.kr:9443/websocket";
        private readonly string _wssUrlSimulation = "wss://openapi.ebestsec.co.kr:29443/websocket";
        private readonly HttpClient _httpClient;
        private readonly ClientWebSocket _wssClient;
        private string _authorization = string.Empty;
        private string _macAddress = string.Empty;
        private long _expires_in;

        public event EventHandler<EBestOnConnectEventArgs>? OnConnectEvent;
        public event EventHandler<EBestOnMessageEventArgs>? OnMessageEvent;
        public event EventHandler<EBestOnRealtimeEventArgs>? OnRealtimeEvent;

        public EBestOpenApi()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
            };

            _wssClient = new ClientWebSocket();
        }

        public SERVER_TYPE ServerType { get; private set; }
        public bool Connected { get; private set; }
        public string LastErrorMessage = string.Empty;
        // 법인인 경우 필수 세팅
        public void SetMacAdress(string macAddress) => _macAddress = macAddress;
        public long GetExpires() => _expires_in;

        //protected double 주문가능금액;

        public async Task ConnectAsync(string appKey, string appSecretKey)
        {
            if (Connected)
            {
                LastErrorMessage = "Aleady connected";
                return;
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

            if (oAuth != null) // 인증성공
            {
                _authorization = oAuth.access_token;
                _expires_in = oAuth.expires_in;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(oAuth.token_type, _authorization);

                // 모의투자인지 실투자인지 구분한다
                Simple_CSPAQ12300 더미조회 = new()
                {
                    CSPAQ12300InBlock1 = new("0", "0", "0", "0"),
                };
                await GetTRData(더미조회).ConfigureAwait(true);
                if (더미조회.rsp_msg is not null && 더미조회.rsp_msg.StartsWith("모의투자", StringComparison.Ordinal))
                {
                    ServerType = SERVER_TYPE.모의투자;
                }

                // 실시간 웹소켓 연결
                Uri wssUri = new(ServerType == SERVER_TYPE.실투자 ? _wssUrlReal : _wssUrlSimulation);
                if (_wssClient.ConnectAsync(wssUri, CancellationToken.None).Wait(2000))
                {
                    Connected = true;
                    _ = WebsocketListen(_wssClient);

                    //// 장운영정보 실시간 시세 등록
                    //_ = AddRealtimeRequest("JIF", "0");
                    OnConnectEvent?.Invoke(this, new(Ok: true, $"{ServerType} 연결 성공"));
                    return;
                }

                OnConnectEvent?.Invoke(this, new(Ok: false, "연결 실패: Websocket서버 응답 없습니다"));
            }
            else
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
        }

        public Task AddAccountRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "1"), new(tr_cd, tr_key)));
        public Task RemoveAccountRealtimeRequest(string tr_cd) => RealtimeRequest<WssRequest>(new(new(_authorization, "2"), new(tr_cd, string.Empty)));
        public Task AddRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "3"), new(tr_cd, tr_key)));
        public Task RemoveRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "4"), new(tr_cd, tr_key)));

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

                    await ms.WriteAsync(buffer.Array!, buffer.Offset, result.Count);
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
                OnConnectEvent?.Invoke(this, new(Ok: false, message));
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
                        //if (response.header.tr_cd.Equals("JIF"))
                        //{

                        //}

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

        protected async Task RealtimeRequest<T>(T request)
        {
            try
            {
                string jsonbody = JsonSerializer.Serialize(request);
                await _wssClient.SendAsync(Encoding.UTF8.GetBytes(jsonbody), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
        }

        protected async ValueTask<T?> PostUrlEncodedAsync<T>(string path, IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
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


        // For Models

        public async Task GetTRData(TrBase request)
        {
            try
            {
                Type TType = request.GetType();
                PathAttribute? pathAttribute = TType.GetCustomAttribute<PathAttribute>()
                        ?? throw new Exception("Path Attribute is undefined");
                string path = pathAttribute.Path;

                // 속성 이름중 InBlock 이 포함된 속성들을 모두 찾는다
                var inBlockProperties = TType.GetProperties().Where(m => m.Name.Contains("InBlock"));
                if (!inBlockProperties.Any())
                    throw new Exception("InBlock is undefined");

                var prop = inBlockProperties.First();
                var sss = prop.GetValue(request);

                Dictionary<string, object?> nameValueCollection = [];
                foreach (var p in inBlockProperties)
                {
                    nameValueCollection.Add(p.Name, p.GetValue(request));
                }
                string jsonbody = JsonSerializer.Serialize(nameValueCollection);

                var content = new StringContent(jsonbody, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };


                httpRequestMessage.Headers.Add("tr_cd", pathAttribute.TRCode.Length > 0 ? pathAttribute.TRCode : TType.Name);
                httpRequestMessage.Headers.Add("tr_cont", request.tr_cont);
                httpRequestMessage.Headers.Add("tr_cont_key", request.tr_cont_key);
                if (_macAddress.Length > 0) httpRequestMessage.Headers.Add("mac_address", _macAddress);

                var responseMsg = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

                var jsonOptions = new JsonSerializerOptions()
                {
                    NumberHandling = JsonNumberHandling.AllowReadingFromString
                };

                //var stringResult = await responseMsg.Content.ReadAsStringAsync().ConfigureAwait(false);
                //var response = JsonSerializer.Deserialize(stringResult, TType, jsonOptions);

                var contentStream = await responseMsg.Content.ReadAsStreamAsync().ConfigureAwait(false);
                await using (contentStream.ConfigureAwait(false))
                {
                    var response = await JsonSerializer.DeserializeAsync(contentStream, TType, jsonOptions).ConfigureAwait(false);
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

                    // TrBase 의 베이스 속성들을 찾는다    
                    request.rsp_cd = TType.GetProperty("rsp_cd")!.GetValue(response) as string ?? string.Empty;
                    request.rsp_msg = TType.GetProperty("rsp_msg")!.GetValue(response) as string ?? string.Empty;
                    if (responseMsg.Headers.TryGetValues("tr_cont", out IEnumerable<string>? tr_cont))
                        request.tr_cont = tr_cont.First();
                    if (responseMsg.Headers.TryGetValues("tr_cont_key", out IEnumerable<string>? tr_cont_key))
                        request.tr_cont_key = tr_cont_key.First();
                }
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
        }

        public async ValueTask<string> GetDataWithText(string path, string tr_cd, string jsonRequest)
        {
            try
            {
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };

                httpRequestMessage.Headers.Add("tr_cd", tr_cd);
                httpRequestMessage.Headers.Add("tr_cont", "N");
                httpRequestMessage.Headers.Add("tr_cont_key", "");
                if (_macAddress.Length > 0) httpRequestMessage.Headers.Add("mac_address", _macAddress);

                var responseMsg = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

                var stringResult = await responseMsg.Content.ReadAsStringAsync().ConfigureAwait(false);
                return stringResult;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
            return string.Empty;
        }

        record CSPAQ12300InBlock1(string BalCreTp, string CmsnAppTpCode, string D2balBaseQryTp, string UprcTpCode);

        /// <summary>
        /// BEP단가조회
        /// </summary>
        [Path("/stock/accno", TRCode = "CSPAQ12300")]
        class Simple_CSPAQ12300 : TrBase
        {
            /// 요청
            public CSPAQ12300InBlock1? CSPAQ12300InBlock1 { get; set; }
        }

    }
}
