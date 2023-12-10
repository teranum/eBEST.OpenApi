namespace eBEST.OpenApi.Models
{
    /// <summary>
    /// 시간조회
    /// </summary>
    [Path("/etc/time-search")]
    public class t0167
    {
        public record InBlock(string id);
        public record Request(InBlock t0167InBlock);
        public record t0167OutBlock(string dt, string time);
        public record Response(string rsp_cd, string rsp_msg,
            t0167OutBlock t0167OutBlock
            );
    }
}
