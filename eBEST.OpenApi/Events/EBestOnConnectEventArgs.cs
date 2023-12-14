namespace eBEST.OpenApi.Events
{
    public class EBestOnConnectEventArgs(bool Ok, string Msg) : EventArgs
    {
        public bool Ok { get; } = Ok;
        public string Msg { get; } = Msg;
    }
}
