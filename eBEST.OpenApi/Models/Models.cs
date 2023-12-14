using eBEST.OpenApi.Blocks;

namespace eBEST.OpenApi.Models;


[Path("/etc/time-search")]
public class t0167 : TrBase
{
    public t0167InBlock? t0167InBlock { get; set; }
    public t0167OutBlock? t0167OutBlock { get; set; }
}

[Path("/indtp/market-data")]
public class t1514 : TrBase
{
    /// 요청
    public t1514InBlock? t1514InBlock { get; set; }

    // 응답
    public t1514OutBlock? t1514OutBlock { get; set; }
    public t1514OutBlock1[]? t1514OutBlock1 { get; set; }
}
