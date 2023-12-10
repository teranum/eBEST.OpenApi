namespace eBEST.OpenApi.Events
{
    public class EBestOnMessageEventArgs(string Message) : EventArgs
    {
        public string Message { get; } = Message;
    }
}
