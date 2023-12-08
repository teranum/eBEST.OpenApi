using eBEST.OpenApi.Events;
using eBEST.OpenApi.TRModels;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace eBEST.OpenApi
{
    public class EBestOpenApi
    {
        public enum ACC_TYPE
        {
            주식,
            선물옵션,
            해외선물,
        }

        public enum SERVER_TYPE
        {
            모의투자,
            실투자,
        }

        private readonly string _baseUrl = "https://openapi.ebestsec.co.kr:8080";
        private readonly HttpClient _httpClient;
        private readonly ACC_TYPE _accType;
        private readonly SERVER_TYPE _serverType;
        public string LastErrorMessage = string.Empty;
        private string _authorization = string.Empty;
        private long _expires_in;

        public event EventHandler<EBestOnConnectEventArgs>? OnConnectEvent;
        public event EventHandler<EBestOnRealtimeEventArgs>? OnRealtimeEvent;
        public event EventHandler<EBestOnTRReceivedEventArgs>? OnTRReceivedEvent;

        protected enum LOGIN_STATE
        {
            NONE,
            LOGINED,
            LOGIN_FAILED,
        }
        public EBestOpenApi(ACC_TYPE accType, SERVER_TYPE serverType)
        {
            _accType = accType;
            _serverType = serverType;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
            };
        }

        public async Task ConnectAsync(string appKey, string appSecretKey)
        {
            LastErrorMessage = string.Empty;

            // OAuth 인증키 가져오기
            OAuth? oAuth = await PostUrlEncodedAsync<OAuth>("/oauth2/token",
                [
                    new("grant_type", "client_credentials"),
                    new("appkey", appKey),
                    new("appsecretkey", appSecretKey),
                    new("scope", "oob"),
                ]).ConfigureAwait(true);

            if (oAuth != null)
            {
                _authorization = oAuth.access_token;
                _expires_in = oAuth.expires_in;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(oAuth.token_type, _authorization);

                // 계좌정보 가져온다

                OnConnectEvent?.Invoke(this, new(Ok: true, string.Empty));
            }
            else
                OnConnectEvent?.Invoke(this, new(Ok: false, LastErrorMessage));
        }
        public async ValueTask<T?> PostUrlEncodedAsync<T>(string path, IEnumerable<KeyValuePair<string, string>> nameValueCollection)
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

        public ValueTask<object?> PostRequestClassAsync<T>(string path, object requestBody) => PostRequestClassAsync(path, requestBody, typeof(T));
        public async ValueTask<object?> PostRequestClassAsync(string path, object requestBody, Type TType)
        {
            try
            {
                Type requestType = TType.Assembly.GetType($"{TType.FullName}+Request") 
                    ?? throw new Exception("requestType is unknown");
                Type responseType = TType.Assembly.GetType($"{TType.FullName}+Response")
                    ?? throw new Exception("responseType is unknown");

                string jsonbody = JsonSerializer.Serialize(requestBody, requestType);

                var content = new StringContent(jsonbody, Encoding.UTF8, "application/json");
                HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, path)
                {
                    Content = content,
                };

                httpRequestMessage.Headers.Add("tr_cd", TType.Name);
                httpRequestMessage.Headers.Add("tr_cont", "N");

                var response = await _httpClient.SendAsync(httpRequestMessage).ConfigureAwait(false);
                var contentStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                await using (contentStream.ConfigureAwait(false))
                {
                    return await JsonSerializer.DeserializeAsync(contentStream, responseType).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
            }
            return default;
        }
    }


}
