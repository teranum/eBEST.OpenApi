namespace eBEST.OpenApi.Events
{
    public class EBestOnRealtimeEventArgs(string TrCode, string Key, object RealtimeData) : EventArgs
    {
        public string TrCode { get; } = TrCode;
        public string Key { get; } = Key;
        public object RealtimeData { get; } = RealtimeData;
    }
}
