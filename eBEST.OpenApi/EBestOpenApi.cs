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
        /// �α��� ���� Ÿ��
        /// </summary>
        public enum SERVER_TYPE
        {
            ������,
            ��������,
        }

        //private readonly string _baseUrl = "https://openapi.ebestsec.co.kr:8080";
        //private readonly string _wssUrlReal = "wss://openapi.ebestsec.co.kr:9443";
        //private readonly string _wssUrlSimulation = "wss://openapi.ebestsec.co.kr:29443";

        /// <summary>
        /// 2024.06.01 �̺���Ʈ���� -> LS�������� ����
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
        /// �������� �̺�Ʈ
        /// </summary>
        public event EventHandler<EBestOnConnectEventArgs>? OnConnectEvent;

        /// <summary>
        /// ���� �޽��� �̺�Ʈ
        /// </summary>
        public event EventHandler<EBestOnMessageEventArgs>? OnMessageEvent;

        /// <summary>
        /// �ǽð� ������ �̺�Ʈ
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
        /// �α��� ���� Ÿ�� (������, ��������)
        /// </summary>
        public SERVER_TYPE ServerType { get; private set; }

        /// <summary>
        /// �α��� �� ��� true
        /// </summary>
        public bool Connected { get; private set; }

        /// <summary>
        /// ������ ���� �޽���
        /// </summary>
        public string LastErrorMessage = string.Empty;

        /// <summary>
        /// MAC �ּ�, ���� ��� �ʼ�
        /// </summary>
        /// <param name="macAddress">macAddress</param>
        [Obsolete("use MacAddress Property")]
        public void SetMacAdress(string macAddress) => _macAddress = macAddress;

        /// <summary>
        /// MAC �ּ� (���� ��� �ʼ� ����)
        /// </summary>
        public string MacAddress
        {
            get => _macAddress;
            set => _macAddress = value;
        }

        /// <summary>
        /// ������ū ��ȿ�Ⱓ(��)
        /// </summary>
        /// <returns></returns>
        public long GetExpires() => _expires_in;

        /// <summary>
        /// ���� ��û
        /// </summary>
        /// <param name="appKey">��Ż���� �߱޵� ���� ��Key</param>
        /// <param name="appSecretKey">��Ż���� �߱޵� ���� �� ���Key</param>
        /// <returns>true: ���Ἲ��, false: �������</returns>
        public async ValueTask<bool> ConnectAsync(string appKey, string appSecretKey)
        {
            if (Connected)
            {
                LastErrorMessage = "Aleady connected";
                return true;
            }
            LastErrorMessage = string.Empty;

            // OAuth ����Ű ��������
            OAuth? oAuth = await PostUrlEncodedAsync<OAuth>("/oauth2/token",
                [
                    new("grant_type", "client_credentials"),
                    new("appkey", appKey),
                    new("appsecretkey", appSecretKey),
                    new("scope", "oob"),
                ]).ConfigureAwait(true);

            if (oAuth == null)
            {
                LastErrorMessage = "����Ű �������� ����";
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
                return false;
            }

            // ��������
            _authorization = oAuth.access_token;
            _expires_in = oAuth.expires_in;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(oAuth.token_type, _authorization);

            // ������������ ���������� �����ϱ� ���� FOCCQ33600 ������ȸ, �������ڽ� ����޽����� '��������' ����
            Dummy_FOCCQ33600 ������ȸ = new()
            {
                FOCCQ33600InBlock1 = null,
            };
            await GetTRData(������ȸ).ConfigureAwait(true);
            if (������ȸ.rsp_msg is not null && ������ȸ.rsp_msg.StartsWith("��������", StringComparison.Ordinal))
            {
                ServerType = SERVER_TYPE.��������;
            }

            // �ǽð� ������ ����
            Uri wssUri = new((ServerType == SERVER_TYPE.������ ? WssUrlReal : WssUrlSimulation) + "/websocket");
            try
            {

                _wssClient = new ClientWebSocket();
                if (_wssClient.ConnectAsync(wssUri, CancellationToken.None).Wait(2000))
                {
                    Connected = true;
                    _ = WebsocketListen(_wssClient);

                    OnConnectEvent?.Invoke(this, new(Ok: true, $"{ServerType} ���� ����"));
                    return true;
                }
            }
            catch (Exception)
            {
                _wssClient = null;
                LastErrorMessage = "Websocket���� ���� ���� �����ϴ�";
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
                return false;
            }

            return false;
        }

        /// <summary>
        /// ���� ����
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
        /// ���� �ǽð� ���
        /// </summary>
        /// <param name="tr_cd">�̺���Ʈ���� �ŷ��ڵ�</param>
        /// <returns>true: ��û����, false: ��û����</returns>
        public ValueTask<bool> AddAccountRealtimeRequest(string tr_cd) => RealtimeRequest<WssRequest>(new(new(_authorization, "1"), new(tr_cd, string.Empty)));

        /// <summary>
        /// ���� �ǽð� ����
        /// </summary>
        /// <param name="tr_cd">�̺���Ʈ���� �ŷ��ڵ�</param>
        /// <returns>true: ��û����, false: ��û����</returns>
        public ValueTask<bool> RemoveAccountRealtimeRequest(string tr_cd) => RealtimeRequest<WssRequest>(new(new(_authorization, "2"), new(tr_cd, string.Empty)));

        /// <summary>
        /// �ǽð� �ü����
        /// </summary>
        /// <param name="tr_cd">�̺���Ʈ���� �ŷ��ڵ�</param>
        /// <param name="tr_key">�����ڵ� 6�ڸ� �Ǵ� 8�ڸ� (�ܰ�, ����)</param>
        /// <returns>true: ��û����, false: ��û����</returns>
        public ValueTask<bool> AddRealtimeRequest(string tr_cd, string tr_key) => RealtimeRequest<WssRequest>(new(new(_authorization, "3"), new(tr_cd, tr_key)));

        /// <summary>
        /// �ǽð� �ü�����
        /// </summary>
        /// <param name="tr_cd">�̺���Ʈ���� �ŷ��ڵ�</param>
        /// <param name="tr_key">�����ڵ� 6�ڸ� �Ǵ� 8�ڸ� (�ܰ�, ����)</param>
        /// <returns>true: ��û����, false: ��û����</returns>
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
        /// TR �񵿱� ��û
        /// </summary>
        /// <param name="request">��û ������</param>
        /// <returns>true: ��û����, false: ��û����</returns>
        public async ValueTask<bool> GetTRData(TrBase request)
        {
            LastErrorMessage = string.Empty;
            try
            {
                Type TType = request.GetType();
                PathAttribute? pathAttribute = TType.GetCustomAttribute<PathAttribute>()
                        ?? throw new Exception("Path Attribute is not defined");
                string path = pathAttribute.Path;

                // �Ӽ� �̸��� InBlock �� ���Ե� �Ӽ����� ��� ã�´�
                var inBlockProperties = TType.GetProperties().Where(m => m.Name.Contains("InBlock"));
                if (!inBlockProperties.Any())
                    throw new Exception("InBlock is not defined");

                Dictionary<string, object?> nameValueCollection = [];
                foreach (var p in inBlockProperties)
                {
                    nameValueCollection.Add(p.Name, p.GetValue(request));
                }
                string jsonbody = JsonSerializer.Serialize(nameValueCollection);

                // ��û ������ �����
                var content = new StringContent(jsonbody, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };

                httpRequestMessage.Headers.Add("tr_cd", pathAttribute.TRCode.Length > 0 ? pathAttribute.TRCode : TType.Name);
                httpRequestMessage.Headers.Add("tr_cont", request.tr_cont);
                httpRequestMessage.Headers.Add("tr_cont_key", request.tr_cont_key);

                // ���� ��� mac_address �ʼ�
                if (_macAddress.Length > 0) httpRequestMessage.Headers.Add("mac_address", _macAddress);

                // ��û�� ������
                var responseMsg = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);

                // ������ �޴´�
                //var contentStream = await responseMsg.Content.ReadAsStreamAsync().ConfigureAwait(false);
                ////await using (contentStream.ConfigureAwait(false))
                ////{
                //var response = await JsonSerializer.DeserializeAsync(contentStream, TType, _jsonOptions).ConfigureAwait(false);


                var jsonResponse = await responseMsg.Content.ReadAsStringAsync().ConfigureAwait(false);
                var response = JsonSerializer.Deserialize(jsonResponse, TType, _jsonOptions);

                // OutBlock �Ӽ��� ã�´�
                var outBlockProperties = TType.GetProperties().Where(m => m.Name.Contains("OutBlock"));
                if (outBlockProperties.Any())
                {
                    foreach (var p in outBlockProperties)
                    {
                        var Property = TType.GetProperty(p.Name)!;
                        Property.SetValue(request, Property.GetValue(response));
                    }
                }

                // TrBase �� ���̽� �Ӽ��� �����Ѵ�    
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
        /// JSON ��û
        /// </summary>
        /// <param name="path">URL���</param>
        /// <param name="tr_cd">�̺���Ʈ���� �ŷ��ڵ�</param>
        /// <param name="tr_cont">���Ӱŷ� ����(Y:���ӡ�, N:���ӡ�)</param>
        /// <param name="tr_cont_key">������ ��� ������ ������ ����Ű �� �ø�</param>
        /// <param name="jsonRequest">��û ����</param>
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
        /// FOCCQ33600 ������ȸ (������ �ּ�Ȯ���� ���� ������/�������� ���� �Ǵ�)
        /// �޽��� ���信 '��������' ������ �������ڷ� �Ǵ�
        /// </summary>
        [Path("/stock/accno", TRCode = "FOCCQ33600")]
        class Dummy_FOCCQ33600 : TrBase
        {
            /// ��û
            public object? FOCCQ33600InBlock1 { get; set; }
        }

    }
}
