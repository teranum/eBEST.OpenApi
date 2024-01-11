using System.Text.Json;

namespace eBEST.OpenApi.Events
{
    /// <summary>
    /// 실시간 웹소켓 이벤트
    /// </summary>
    /// <param name="TrCode">Tr코드</param>
    /// <param name="Key">키</param>
    /// <param name="RealtimeBody">실시간응잡(JsonElement)</param>
    public class EBestOnRealtimeEventArgs(string TrCode, string Key, JsonElement RealtimeBody) : EventArgs
    {
        public string TrCode { get; } = TrCode;
        public string Key { get; } = Key;
        public JsonElement RealtimeBody { get; } = RealtimeBody;
    }
}
