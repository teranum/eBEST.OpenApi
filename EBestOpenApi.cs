
using eBEST.OpenApi.Events;
using eBEST.OpenApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ebest.OpenApi
{
    public class EBestOpenApi
    {
        private readonly string _baseUrl = "https://openapi.ebestsec.co.kr:8080";
        private readonly HttpClient _httpClient;
        private string _errorMessage = string.Empty;
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
        public EBestOpenApi()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
            };
        }

        public async ValueTask ConnectAsync(bool isSimulation, string appKey, string appSecretKey)
        {
            // OAuth 인증키 가져오기
            OAuth? oAuth = await PostAsyncUrlEncodedAsync<OAuth>("/oauth2/token",
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
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authorization);
                OnConnectEvent?.Invoke(this, new(Ok: true, string.Empty));
            }
            else
                OnConnectEvent?.Invoke(this, new(Ok: false, _errorMessage));
        }
        public async ValueTask<T?> PostAsyncUrlEncodedAsync<T>(string path, IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
            try
            {
                var response = await _httpClient.PostAsync(path, new FormUrlEncodedContent(nameValueCollection)).ConfigureAwait(false);
                if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var text = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonSerializer.Deserialize<T>(text);
                }
            }
            catch (Exception ex)
            {
                _errorMessage = ex.Message;
            }
            return default;
        }
    }
}
