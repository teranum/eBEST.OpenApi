namespace eBEST.OpenApi.Events
{
    public class EBestOnRealtimeEventArgs(string Code, string RealData) : EventArgs
    {
        public string Code { get; } = Code;
        public string RealData { get; } = RealData;
    }
}
