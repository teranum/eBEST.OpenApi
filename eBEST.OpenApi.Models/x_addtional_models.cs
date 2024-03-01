/**************************************************************/
// XingAPI에 없는 TR 6개
// CSPAT00601
// CSPAT00701
// CSPAT00801
// t1859
// t1860
// AFR
/**************************************************************/

namespace eBEST.OpenApi.Models;

/// <summary>
/// 현물주문: CSPAT00601
/// </summary>
[Path("/stock/order", Description = "현물주문")]
public class CSPAT00601 : TrBase
{
    // InBlock
    public CSPAT00601InBlock1? CSPAT00601InBlock1 { get; set; }

    // OutBlock
    public CSPAT00601OutBlock1? CSPAT00601OutBlock1 { get; set; }
    public CSPAT00601OutBlock2? CSPAT00601OutBlock2 { get; set; }
}

/// <summary>
/// 현물정정주문: CSPAT00701
/// </summary>
[Path("/stock/order", Description = "현물정정주문")]
public class CSPAT00701 : TrBase
{
    // InBlock
    public CSPAT00701InBlock1? CSPAT00701InBlock1 { get; set; }

    // OutBlock
    public CSPAT00701OutBlock1? CSPAT00701OutBlock1 { get; set; }
    public CSPAT00701OutBlock2? CSPAT00701OutBlock2 { get; set; }
}

/// <summary>
/// 현물취소주문: CSPAT00801
/// </summary>
[Path("/stock/order", Description = "현물취소주문")]
public class CSPAT00801 : TrBase
{
    // InBlock
    public CSPAT00801InBlock1? CSPAT00801InBlock1 { get; set; }

    // OutBlock
    public CSPAT00801OutBlock1? CSPAT00801OutBlock1 { get; set; }
    public CSPAT00801OutBlock2? CSPAT00801OutBlock2 { get; set; }
}

/// <summary>
/// 서버저장조건 조건검색
/// </summary>
[Path("/stock/item-search", Description = "서버저장조건 조건검색")]
public class t1859 : TrBase
{
    /// 요청
    public t1859InBlock? t1859InBlock { get; set; }

    // 응답
    public t1859OutBlock? t1859OutBlock { get; set; }
    public t1859OutBlock1[]? t1859OutBlock1 { get; set; }
}

/// <summary>
/// 서버저장조건 실시간검색
/// </summary>
[Path("/stock/item-search", Description = "서버저장조건 실시간검색")]
public class t1860 : TrBase
{
    /// 요청
    public t1860InBlock? t1860InBlock { get; set; }

    // 응답
    public t1860OutBlock? t1860OutBlock { get; set; }
}

/// <summary>
/// API사용자조건검색실시간: Ys3
/// </summary>
[Path("/websocket/stock", Description = "API사용자조건검색실시간")]
public class AFR : TrBase
{
    //요청
    public AFRInBlock? AFRInBlock { get; set; }

    //응답
    public AFROutBlock? AFROutBlock { get; set; }
}
