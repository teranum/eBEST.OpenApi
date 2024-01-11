namespace eBEST.OpenApi.Events
{
    /// <summary>
    /// 서버연결 이벤트
    /// </summary>
    /// <param name="Ok">연결성공여부</param>
    /// <param name="Msg">메시지</param>
    public class EBestOnConnectEventArgs(bool Ok, string Msg) : EventArgs
    {
        public bool Ok { get; } = Ok;
        public string Msg { get; } = Msg;
    }
}
