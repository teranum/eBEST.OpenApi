using System.Text.Json;

namespace eBEST.OpenApi.Events
{
    public class EBestOnRealtimeEventArgs(string TrCode, string Key, JsonElement RealtimeBody) : EventArgs
    {
        public string TrCode { get; } = TrCode;
        public string Key { get; } = Key;
        public JsonElement RealtimeBody { get; } = RealtimeBody;
    }
}
