namespace eBEST.OpenApi.Events
{
    /// <summary>
    /// 서버 메시지 이벤트
    /// </summary>
    /// <param name="Message">메시지</param>
    public class EBestOnMessageEventArgs(string Message) : EventArgs
    {
        public string Message { get; } = Message;
    }
}
