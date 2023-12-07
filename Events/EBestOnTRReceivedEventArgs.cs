namespace eBEST.OpenApi.Events
{
    public class EBestOnTRReceivedEventArgs(string TrCode, string TrData) : EventArgs
    {
        public string TrCode { get; } = TrCode;
        public string TrData { get; } = TrData;
    }
}
