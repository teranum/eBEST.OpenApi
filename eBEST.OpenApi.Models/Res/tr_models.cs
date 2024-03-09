// [2024-03-09 오후 11:44:23]
// 이 파일은 ResToModel 에 의해 자동으로 만들어졌습니다.
// XingAPI Res폴더의 .res 파일에서 변환되었습니다.
namespace eBEST.OpenApi.Models;

/// <summary>
/// 계좌 거래내역: CDPCQ04700
/// </summary>
[Path("/stock/accno", Description = "계좌 거래내역", Headtype = "B")]
public class CDPCQ04700 : TrBase
{
    // InBlock
    public CDPCQ04700InBlock1? CDPCQ04700InBlock1 { get; set; }

    // OutBlock
    public CDPCQ04700OutBlock1? CDPCQ04700OutBlock1 { get; set; }
    public CDPCQ04700OutBlock2? CDPCQ04700OutBlock2 { get; set; }
    public CDPCQ04700OutBlock3[]? CDPCQ04700OutBlock3 { get; set; }
    public CDPCQ04700OutBlock4? CDPCQ04700OutBlock4 { get; set; }
    public CDPCQ04700OutBlock5? CDPCQ04700OutBlock5 { get; set; }
}


/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100
/// </summary>
[Path("/futureoption/accno", Description = "유렉스 주문체결내역조회", Headtype = "B")]
public class CEXAQ21100 : TrBase
{
    // InBlock
    public CEXAQ21100InBlock1? CEXAQ21100InBlock1 { get; set; }

    // OutBlock
    public CEXAQ21100OutBlock1? CEXAQ21100OutBlock1 { get; set; }
    public CEXAQ21100OutBlock2? CEXAQ21100OutBlock2 { get; set; }
    public CEXAQ21100OutBlock3[]? CEXAQ21100OutBlock3 { get; set; }
}


/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200
/// </summary>
[Path("/futureoption/accno", Description = "유렉스 주문가능 수량/금액 조회", Headtype = "B")]
public class CEXAQ21200 : TrBase
{
    // InBlock
    public CEXAQ21200InBlock1? CEXAQ21200InBlock1 { get; set; }

    // OutBlock
    public CEXAQ21200OutBlock1? CEXAQ21200OutBlock1 { get; set; }
    public CEXAQ21200OutBlock2? CEXAQ21200OutBlock2 { get; set; }
}


/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100
/// </summary>
[Path("/futureoption/accno", Description = "유렉스 야간장잔고및 평가현황", Headtype = "B")]
public class CEXAQ31100 : TrBase
{
    // InBlock
    public CEXAQ31100InBlock1? CEXAQ31100InBlock1 { get; set; }

    // OutBlock
    public CEXAQ31100OutBlock1? CEXAQ31100OutBlock1 { get; set; }
    public CEXAQ31100OutBlock2? CEXAQ31100OutBlock2 { get; set; }
    public CEXAQ31100OutBlock3[]? CEXAQ31100OutBlock3 { get; set; }
}


/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200
/// </summary>
[Path("/futureoption/accno", Description = "유렉스 예탁금 및 통합잔고조회", Headtype = "B")]
public class CEXAQ31200 : TrBase
{
    // InBlock
    public CEXAQ31200InBlock1? CEXAQ31200InBlock1 { get; set; }

    // OutBlock
    public CEXAQ31200OutBlock1? CEXAQ31200OutBlock1 { get; set; }
    public CEXAQ31200OutBlock2? CEXAQ31200OutBlock2 { get; set; }
    public CEXAQ31200OutBlock3[]? CEXAQ31200OutBlock3 { get; set; }
}


/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 야간옵션 기간주문체결조회", Headtype = "B")]
public class CEXAQ44200 : TrBase
{
    // InBlock
    public CEXAQ44200InBlock1? CEXAQ44200InBlock1 { get; set; }

    // OutBlock
    public CEXAQ44200OutBlock1? CEXAQ44200OutBlock1 { get; set; }
    public CEXAQ44200OutBlock2? CEXAQ44200OutBlock2 { get; set; }
    public CEXAQ44200OutBlock3[]? CEXAQ44200OutBlock3 { get; set; }
}


/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100
/// </summary>
[Path("/futureoption/order", Description = "유렉스 매수/매도주문", Headtype = "B")]
public class CEXAT11100 : TrBase
{
    // InBlock
    public CEXAT11100InBlock1? CEXAT11100InBlock1 { get; set; }

    // OutBlock
    public CEXAT11100OutBlock1? CEXAT11100OutBlock1 { get; set; }
    public CEXAT11100OutBlock2? CEXAT11100OutBlock2 { get; set; }
}


/// <summary>
/// 유렉스 정정주문: CEXAT11200
/// </summary>
[Path("/futureoption/order", Description = "유렉스 정정주문", Headtype = "B")]
public class CEXAT11200 : TrBase
{
    // InBlock
    public CEXAT11200InBlock1? CEXAT11200InBlock1 { get; set; }

    // OutBlock
    public CEXAT11200OutBlock1? CEXAT11200OutBlock1 { get; set; }
    public CEXAT11200OutBlock2? CEXAT11200OutBlock2 { get; set; }
}


/// <summary>
/// 유렉스 취소주문: CEXAT11300
/// </summary>
[Path("/futureoption/order", Description = "유렉스 취소주문", Headtype = "B")]
public class CEXAT11300 : TrBase
{
    // InBlock
    public CEXAT11300InBlock1? CEXAT11300InBlock1 { get; set; }

    // OutBlock
    public CEXAT11300OutBlock1? CEXAT11300OutBlock1 { get; set; }
    public CEXAT11300OutBlock2? CEXAT11300OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 계좌주문체결내역조회", Headtype = "B")]
public class CFOAQ00600 : TrBase
{
    // InBlock
    public CFOAQ00600InBlock1? CFOAQ00600InBlock1 { get; set; }

    // OutBlock
    public CFOAQ00600OutBlock1? CFOAQ00600OutBlock1 { get; set; }
    public CFOAQ00600OutBlock2? CFOAQ00600OutBlock2 { get; set; }
    public CFOAQ00600OutBlock3[]? CFOAQ00600OutBlock3 { get; set; }
}


/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 주문가능수량조회", Headtype = "B")]
public class CFOAQ10100 : TrBase
{
    // InBlock
    public CFOAQ10100InBlock1? CFOAQ10100InBlock1 { get; set; }

    // OutBlock
    public CFOAQ10100OutBlock1? CFOAQ10100OutBlock1 { get; set; }
    public CFOAQ10100OutBlock2? CFOAQ10100OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 정상주문: CFOAT00100
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 정상주문", Headtype = "B")]
public class CFOAT00100 : TrBase
{
    // InBlock
    public CFOAT00100InBlock1? CFOAT00100InBlock1 { get; set; }

    // OutBlock
    public CFOAT00100OutBlock1? CFOAT00100OutBlock1 { get; set; }
    public CFOAT00100OutBlock2? CFOAT00100OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 정정주문: CFOAT00200
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 정정주문", Headtype = "B")]
public class CFOAT00200 : TrBase
{
    // InBlock
    public CFOAT00200InBlock1? CFOAT00200InBlock1 { get; set; }

    // OutBlock
    public CFOAT00200OutBlock1? CFOAT00200OutBlock1 { get; set; }
    public CFOAT00200OutBlock2? CFOAT00200OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 취소주문: CFOAT00300
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 취소주문", Headtype = "B")]
public class CFOAT00300 : TrBase
{
    // InBlock
    public CFOAT00300InBlock1? CFOAT00300InBlock1 { get; set; }

    // OutBlock
    public CFOAT00300OutBlock1? CFOAT00300OutBlock1 { get; set; }
    public CFOAT00300OutBlock2? CFOAT00300OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 계좌예탁금증거금조회", Headtype = "B")]
public class CFOBQ10500 : TrBase
{
    // InBlock
    public CFOBQ10500InBlock1? CFOBQ10500InBlock1 { get; set; }

    // OutBlock
    public CFOBQ10500OutBlock1? CFOBQ10500OutBlock1 { get; set; }
    public CFOBQ10500OutBlock2? CFOBQ10500OutBlock2 { get; set; }
    public CFOBQ10500OutBlock3[]? CFOBQ10500OutBlock3 { get; set; }
}


/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 옵션매도시 주문증거금조회", Headtype = "B")]
public class CFOBQ10800 : TrBase
{
    // InBlock
    public CFOBQ10800InBlock1? CFOBQ10800InBlock1 { get; set; }

    // OutBlock
    public CFOBQ10800OutBlock1? CFOBQ10800OutBlock1 { get; set; }
    public CFOBQ10800OutBlock2[]? CFOBQ10800OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션가정산예탁금상세", Headtype = "B")]
public class CFOEQ11100 : TrBase
{
    // InBlock
    public CFOEQ11100InBlock1? CFOEQ11100InBlock1 { get; set; }

    // OutBlock
    public CFOEQ11100OutBlock1? CFOEQ11100OutBlock1 { get; set; }
    public CFOEQ11100OutBlock2? CFOEQ11100OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 일별 계좌손익내역", Headtype = "B")]
public class CFOEQ82600 : TrBase
{
    // InBlock
    public CFOEQ82600InBlock1? CFOEQ82600InBlock1 { get; set; }

    // OutBlock
    public CFOEQ82600OutBlock1? CFOEQ82600OutBlock1 { get; set; }
    public CFOEQ82600OutBlock2? CFOEQ82600OutBlock2 { get; set; }
    public CFOEQ82600OutBlock3[]? CFOEQ82600OutBlock3 { get; set; }
}


/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
/// </summary>
[Path("/futureoption/accno", Description = "계좌 미결제 약정현황(평균가)", Headtype = "B")]
public class CFOFQ02400 : TrBase
{
    // InBlock
    public CFOFQ02400InBlock1? CFOFQ02400InBlock1 { get; set; }

    // OutBlock
    public CFOFQ02400OutBlock1? CFOFQ02400OutBlock1 { get; set; }
    public CFOFQ02400OutBlock2? CFOFQ02400OutBlock2 { get; set; }
    public CFOFQ02400OutBlock3[]? CFOFQ02400OutBlock3 { get; set; }
    public CFOFQ02400OutBlock4[]? CFOFQ02400OutBlock4 { get; set; }
}


/// <summary>
/// 챠트엑셀데이터조회: CHARTEXCEL
/// </summary>
[Path("", Description = "챠트엑셀데이터조회", Headtype = "B")]
public class CHARTEXCEL : TrBase
{
    // InBlock
    public ChartExcelInBlock? ChartExcelInBlock { get; set; }

    // OutBlock
    public ChartExcelOutBlock? ChartExcelOutBlock { get; set; }
    public ChartExcelOutBlock1[]? ChartExcelOutBlock1 { get; set; }
}


/// <summary>
/// 챠트지표데이터조회: CHARTINDEX
/// </summary>
[Path("", Description = "챠트지표데이터조회", Headtype = "B")]
public class CHARTINDEX : TrBase
{
    // InBlock
    public ChartIndexInBlock? ChartIndexInBlock { get; set; }

    // OutBlock
    public ChartIndexOutBlock? ChartIndexOutBlock { get; set; }
    public ChartIndexOutBlock1[]? ChartIndexOutBlock1 { get; set; }
}


/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 체결내역개별 조회", Headtype = "B")]
public class CIDBQ01400 : TrBase
{
    // InBlock
    public CIDBQ01400InBlock1? CIDBQ01400InBlock1 { get; set; }

    // OutBlock
    public CIDBQ01400OutBlock1? CIDBQ01400OutBlock1 { get; set; }
    public CIDBQ01400OutBlock2? CIDBQ01400OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 미결제 잔고내역", Headtype = "B")]
public class CIDBQ01500 : TrBase
{
    // InBlock
    public CIDBQ01500InBlock1? CIDBQ01500InBlock1 { get; set; }

    // OutBlock
    public CIDBQ01500OutBlock1? CIDBQ01500OutBlock1 { get; set; }
    public CIDBQ01500OutBlock2[]? CIDBQ01500OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 주문체결내역 조회", Headtype = "B")]
public class CIDBQ01800 : TrBase
{
    // InBlock
    public CIDBQ01800InBlock1? CIDBQ01800InBlock1 { get; set; }

    // OutBlock
    public CIDBQ01800OutBlock1? CIDBQ01800OutBlock1 { get; set; }
    public CIDBQ01800OutBlock2[]? CIDBQ01800OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 주문체결내역 상세 조회", Headtype = "B")]
public class CIDBQ02400 : TrBase
{
    // InBlock
    public CIDBQ02400InBlock1? CIDBQ02400InBlock1 { get; set; }

    // OutBlock
    public CIDBQ02400OutBlock1? CIDBQ02400OutBlock1 { get; set; }
    public CIDBQ02400OutBlock2[]? CIDBQ02400OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 예수금/잔고현황", Headtype = "B")]
public class CIDBQ03000 : TrBase
{
    // InBlock
    public CIDBQ03000InBlock1? CIDBQ03000InBlock1 { get; set; }

    // OutBlock
    public CIDBQ03000OutBlock1? CIDBQ03000OutBlock1 { get; set; }
    public CIDBQ03000OutBlock2[]? CIDBQ03000OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 계좌예탁자산조회", Headtype = "B")]
public class CIDBQ05300 : TrBase
{
    // InBlock
    public CIDBQ05300InBlock1? CIDBQ05300InBlock1 { get; set; }

    // OutBlock
    public CIDBQ05300OutBlock1? CIDBQ05300OutBlock1 { get; set; }
    public CIDBQ05300OutBlock2[]? CIDBQ05300OutBlock2 { get; set; }
    public CIDBQ05300OutBlock3? CIDBQ05300OutBlock3 { get; set; }
}


/// <summary>
/// 해외선물신규주문: CIDBT00100
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물신규주문", Headtype = "B")]
public class CIDBT00100 : TrBase
{
    // InBlock
    public CIDBT00100InBlock1? CIDBT00100InBlock1 { get; set; }

    // OutBlock
    public CIDBT00100OutBlock1? CIDBT00100OutBlock1 { get; set; }
    public CIDBT00100OutBlock2? CIDBT00100OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물정정주문: CIDBT00900
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물정정주문", Headtype = "B")]
public class CIDBT00900 : TrBase
{
    // InBlock
    public CIDBT00900InBlock1? CIDBT00900InBlock1 { get; set; }

    // OutBlock
    public CIDBT00900OutBlock1? CIDBT00900OutBlock1 { get; set; }
    public CIDBT00900OutBlock2? CIDBT00900OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물취소주문: CIDBT01000
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물취소주문", Headtype = "B")]
public class CIDBT01000 : TrBase
{
    // InBlock
    public CIDBT01000InBlock1? CIDBT01000InBlock1 { get; set; }

    // OutBlock
    public CIDBT01000OutBlock1? CIDBT01000OutBlock1 { get; set; }
    public CIDBT01000OutBlock2? CIDBT01000OutBlock2 { get; set; }
}


/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800
/// </summary>
[Path("/overseas-futureoption/accno", Description = "일자별 미결제 잔고내역", Headtype = "B")]
public class CIDEQ00800 : TrBase
{
    // InBlock
    public CIDEQ00800InBlock1? CIDEQ00800InBlock1 { get; set; }

    // OutBlock
    public CIDEQ00800OutBlock1? CIDEQ00800OutBlock1 { get; set; }
    public CIDEQ00800OutBlock2[]? CIDEQ00800OutBlock2 { get; set; }
}


/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100
/// </summary>
[Path("/stock/etc", Description = "예탁담보융자가능종목현황조회", Headtype = "B")]
public class CLNAQ00100 : TrBase
{
    // InBlock
    public CLNAQ00100InBlock1? CLNAQ00100InBlock1 { get; set; }

    // OutBlock
    public CLNAQ00100OutBlock1? CLNAQ00100OutBlock1 { get; set; }
    public CLNAQ00100OutBlock2[]? CLNAQ00100OutBlock2 { get; set; }
    public CLNAQ00100OutBlock3? CLNAQ00100OutBlock3 { get; set; }
}


/// <summary>
/// 계좌별신용한도조회: CSPAQ00600
/// </summary>
[Path("/stock/accno", Description = "계좌별신용한도조회", Headtype = "B")]
public class CSPAQ00600 : TrBase
{
    // InBlock
    public CSPAQ00600InBlock1? CSPAQ00600InBlock1 { get; set; }

    // OutBlock
    public CSPAQ00600OutBlock1? CSPAQ00600OutBlock1 { get; set; }
    public CSPAQ00600OutBlock2? CSPAQ00600OutBlock2 { get; set; }
}


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200
/// </summary>
[Path("/stock/accno", Description = "현물계좌예수금 주문가능금액 총평가 조회", Headtype = "B")]
public class CSPAQ12200 : TrBase
{
    // InBlock
    public CSPAQ12200InBlock1? CSPAQ12200InBlock1 { get; set; }

    // OutBlock
    public CSPAQ12200OutBlock1? CSPAQ12200OutBlock1 { get; set; }
    public CSPAQ12200OutBlock2? CSPAQ12200OutBlock2 { get; set; }
}


/// <summary>
/// BEP단가조회: CSPAQ12300
/// </summary>
[Path("/stock/accno", Description = "BEP단가조회", Headtype = "B")]
public class CSPAQ12300 : TrBase
{
    // InBlock
    public CSPAQ12300InBlock1? CSPAQ12300InBlock1 { get; set; }

    // OutBlock
    public CSPAQ12300OutBlock1? CSPAQ12300OutBlock1 { get; set; }
    public CSPAQ12300OutBlock2? CSPAQ12300OutBlock2 { get; set; }
    public CSPAQ12300OutBlock3[]? CSPAQ12300OutBlock3 { get; set; }
}


/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700
/// </summary>
[Path("/stock/accno", Description = "현물계좌주문체결내역조회", Headtype = "B")]
public class CSPAQ13700 : TrBase
{
    // InBlock
    public CSPAQ13700InBlock1? CSPAQ13700InBlock1 { get; set; }

    // OutBlock
    public CSPAQ13700OutBlock1? CSPAQ13700OutBlock1 { get; set; }
    public CSPAQ13700OutBlock2? CSPAQ13700OutBlock2 { get; set; }
    public CSPAQ13700OutBlock3[]? CSPAQ13700OutBlock3 { get; set; }
}


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200
/// </summary>
[Path("/stock/accno", Description = "현물계좌예수금 주문가능금액 총평가2", Headtype = "B")]
public class CSPAQ22200 : TrBase
{
    // InBlock
    public CSPAQ22200InBlock1? CSPAQ22200InBlock1 { get; set; }

    // OutBlock
    public CSPAQ22200OutBlock1? CSPAQ22200OutBlock1 { get; set; }
    public CSPAQ22200OutBlock2? CSPAQ22200OutBlock2 { get; set; }
}


/// <summary>
/// 현물주문: CSPAT00600
/// </summary>
[Path("", Description = "현물주문", Headtype = "B")]
public class CSPAT00600 : TrBase
{
    // InBlock
    public CSPAT00600InBlock1? CSPAT00600InBlock1 { get; set; }

    // OutBlock
    public CSPAT00600OutBlock1? CSPAT00600OutBlock1 { get; set; }
    public CSPAT00600OutBlock2? CSPAT00600OutBlock2 { get; set; }
}


/// <summary>
/// 현물정정주문: CSPAT00700
/// </summary>
[Path("", Description = "현물정정주문", Headtype = "B")]
public class CSPAT00700 : TrBase
{
    // InBlock
    public CSPAT00700InBlock1? CSPAT00700InBlock1 { get; set; }

    // OutBlock
    public CSPAT00700OutBlock1? CSPAT00700OutBlock1 { get; set; }
    public CSPAT00700OutBlock2? CSPAT00700OutBlock2 { get; set; }
}


/// <summary>
/// 현물취소주문: CSPAT00800
/// </summary>
[Path("", Description = "현물취소주문", Headtype = "B")]
public class CSPAT00800 : TrBase
{
    // InBlock
    public CSPAT00800InBlock1? CSPAT00800InBlock1 { get; set; }

    // OutBlock
    public CSPAT00800OutBlock1? CSPAT00800OutBlock1 { get; set; }
    public CSPAT00800OutBlock2? CSPAT00800OutBlock2 { get; set; }
}


/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200
/// </summary>
[Path("/stock/accno", Description = "현물계좌증거금률별주문가능수량조회", Headtype = "B")]
public class CSPBQ00200 : TrBase
{
    // InBlock
    public CSPBQ00200InBlock1? CSPBQ00200InBlock1 { get; set; }

    // OutBlock
    public CSPBQ00200OutBlock1? CSPBQ00200OutBlock1 { get; set; }
    public CSPBQ00200OutBlock2? CSPBQ00200OutBlock2 { get; set; }
}


/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600
/// </summary>
[Path("/stock/accno", Description = "주식계좌 기간별수익률 상세", Headtype = "B")]
public class FOCCQ33600 : TrBase
{
    // InBlock
    public FOCCQ33600InBlock1? FOCCQ33600InBlock1 { get; set; }

    // OutBlock
    public FOCCQ33600OutBlock1? FOCCQ33600OutBlock1 { get; set; }
    public FOCCQ33600OutBlock2? FOCCQ33600OutBlock2 { get; set; }
    public FOCCQ33600OutBlock3[]? FOCCQ33600OutBlock3 { get; set; }
}


/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 기간별 계좌 수익률 현황", Headtype = "B")]
public class FOCCQ33700 : TrBase
{
    // InBlock
    public FOCCQ33700InBlock1? FOCCQ33700InBlock1 { get; set; }

    // OutBlock
    public FOCCQ33700OutBlock1? FOCCQ33700OutBlock1 { get; set; }
    public FOCCQ33700OutBlock2? FOCCQ33700OutBlock2 { get; set; }
    public FOCCQ33700OutBlock3[]? FOCCQ33700OutBlock3 { get; set; }
}


/// <summary>
/// 파생상품증거금율조회: MMDAQ91200
/// </summary>
[Path("/futureoption/etc", Description = "파생상품증거금율조회", Headtype = "B")]
public class MMDAQ91200 : TrBase
{
    // InBlock
    public MMDAQ91200InBlock1? MMDAQ91200InBlock1 { get; set; }

    // OutBlock
    public MMDAQ91200OutBlock1? MMDAQ91200OutBlock1 { get; set; }
    public MMDAQ91200OutBlock2[]? MMDAQ91200OutBlock2 { get; set; }
}


/// <summary>
/// 해외선물마스터조회-API용: o3101
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물마스터조회-API용", Attr = true, Headtype = "A")]
public class o3101 : TrBase
{
    // InBlock
    public o3101InBlock? o3101InBlock { get; set; }

    // OutBlock
    public o3101OutBlock[]? o3101OutBlock { get; set; }
}


/// <summary>
/// 해외선물차트(분)-API용: o3103
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물차트(분)-API용", Attr = true, Headtype = "A")]
public class o3103 : TrBase
{
    // InBlock
    public o3103InBlock? o3103InBlock { get; set; }

    // OutBlock
    public o3103OutBlock? o3103OutBlock { get; set; }
    public o3103OutBlock1[]? o3103OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물일별체결조회-API용: o3104
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물일별체결조회-API용", Attr = true, Headtype = "A")]
public class o3104 : TrBase
{
    // InBlock
    public o3104InBlock? o3104InBlock { get; set; }

    // OutBlock
    public o3104OutBlock1[]? o3104OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물현재가(종목정보)조회-API용: o3105
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물현재가(종목정보)조회-API용", Attr = true, Headtype = "A")]
public class o3105 : TrBase
{
    // InBlock
    public o3105InBlock? o3105InBlock { get; set; }

    // OutBlock
    public o3105OutBlock? o3105OutBlock { get; set; }
}


/// <summary>
/// 해외선물현재가호가조회-API용: o3106
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물현재가호가조회-API용", Attr = true, Headtype = "A")]
public class o3106 : TrBase
{
    // InBlock
    public o3106InBlock? o3106InBlock { get; set; }

    // OutBlock
    public o3106OutBlock? o3106OutBlock { get; set; }
}


/// <summary>
/// 해외선물관심종목조회-API용: o3107
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물관심종목조회-API용", Attr = true, Headtype = "A")]
public class o3107 : TrBase
{
    // InBlock
    public o3107InBlock[]? o3107InBlock { get; set; }

    // OutBlock
    public o3107OutBlock[]? o3107OutBlock { get; set; }
}


/// <summary>
/// 해외선물차트(일주월)-API용: o3108
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물차트(일주월)-API용", Attr = true, Headtype = "A")]
public class o3108 : TrBase
{
    // InBlock
    public o3108InBlock? o3108InBlock { get; set; }

    // OutBlock
    public o3108OutBlock? o3108OutBlock { get; set; }
    public o3108OutBlock1[]? o3108OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물시간대별(Tick)체결-API용: o3116
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물시간대별(Tick)체결-API용", Attr = true, Headtype = "A")]
public class o3116 : TrBase
{
    // InBlock
    public o3116InBlock? o3116InBlock { get; set; }

    // OutBlock
    public o3116OutBlock? o3116OutBlock { get; set; }
    public o3116OutBlock1[]? o3116OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물차트용NTick-API용: o3117
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물차트용NTick-API용", Attr = true, Headtype = "A")]
public class o3117 : TrBase
{
    // InBlock
    public o3117InBlock? o3117InBlock { get; set; }

    // OutBlock
    public o3117OutBlock? o3117OutBlock { get; set; }
    public o3117OutBlock1[]? o3117OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물옵션마스터조회-API용: o3121
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션마스터조회-API용", Attr = true, Headtype = "A")]
public class o3121 : TrBase
{
    // InBlock
    public o3121InBlock? o3121InBlock { get; set; }

    // OutBlock
    public o3121OutBlock[]? o3121OutBlock { get; set; }
}


/// <summary>
/// 해외선물옵션차트(분)-API용: o3123
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션차트(분)-API용", Attr = true, Headtype = "A")]
public class o3123 : TrBase
{
    // InBlock
    public o3123InBlock? o3123InBlock { get; set; }

    // OutBlock
    public o3123OutBlock? o3123OutBlock { get; set; }
    public o3123OutBlock1[]? o3123OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물옵션현재가(종목정보)조회-API용: o3125
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션현재가(종목정보)조회-API용", Attr = true, Headtype = "A")]
public class o3125 : TrBase
{
    // InBlock
    public o3125InBlock? o3125InBlock { get; set; }

    // OutBlock
    public o3125OutBlock? o3125OutBlock { get; set; }
}


/// <summary>
/// 해외선물옵션현재가호가조회-API용: o3126
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션현재가호가조회-API용", Attr = true, Headtype = "A")]
public class o3126 : TrBase
{
    // InBlock
    public o3126InBlock? o3126InBlock { get; set; }

    // OutBlock
    public o3126OutBlock? o3126OutBlock { get; set; }
}


/// <summary>
/// 해외선물옵션관심종목조회-API용: o3127
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션관심종목조회-API용", Attr = true, Headtype = "A")]
public class o3127 : TrBase
{
    // InBlock
    public o3127InBlock? o3127InBlock { get; set; }
    public o3127InBlock1[]? o3127InBlock1 { get; set; }

    // OutBlock
    public o3127OutBlock[]? o3127OutBlock { get; set; }
}


/// <summary>
/// 해외선물옵션차트일주월-API용: o3128
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션차트일주월-API용", Attr = true, Headtype = "A")]
public class o3128 : TrBase
{
    // InBlock
    public o3128InBlock? o3128InBlock { get; set; }

    // OutBlock
    public o3128OutBlock? o3128OutBlock { get; set; }
    public o3128OutBlock1[]? o3128OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물옵션시간대별(Tick)체결-API용: o3136
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션시간대별(Tick)체결-API용", Attr = true, Headtype = "A")]
public class o3136 : TrBase
{
    // InBlock
    public o3136InBlock? o3136InBlock { get; set; }

    // OutBlock
    public o3136OutBlock? o3136OutBlock { get; set; }
    public o3136OutBlock1[]? o3136OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물옵션차트용NTick-API용: o3137
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션차트용NTick-API용", Attr = true, Headtype = "A")]
public class o3137 : TrBase
{
    // InBlock
    public o3137InBlock? o3137InBlock { get; set; }

    // OutBlock
    public o3137OutBlock? o3137OutBlock { get; set; }
    public o3137OutBlock1[]? o3137OutBlock1 { get; set; }
}


/// <summary>
/// 해외선물옵션차트용NTick(고정형)-API용: o3139
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물옵션차트용NTick(고정형)-API용", Attr = true, Headtype = "A")]
public class o3139 : TrBase
{
    // InBlock
    public o3139InBlock? o3139InBlock { get; set; }

    // OutBlock
    public o3139OutBlock? o3139OutBlock { get; set; }
    public o3139OutBlock1[]? o3139OutBlock1 { get; set; }
}


/// <summary>
/// 주식당일매매일지/수수료: t0150
/// </summary>
[Path("/stock/accno", Description = "주식당일매매일지/수수료", Headtype = "C")]
public class t0150 : TrBase
{
    // InBlock
    public t0150InBlock? t0150InBlock { get; set; }

    // OutBlock
    public t0150OutBlock? t0150OutBlock { get; set; }
    public t0150OutBlock1[]? t0150OutBlock1 { get; set; }
}


/// <summary>
/// 주식당일매매일지/수수료(전일): t0151
/// </summary>
[Path("/stock/accno", Description = "주식당일매매일지/수수료(전일)", Headtype = "C")]
public class t0151 : TrBase
{
    // InBlock
    public t0151InBlock? t0151InBlock { get; set; }

    // OutBlock
    public t0151OutBlock? t0151OutBlock { get; set; }
    public t0151OutBlock1[]? t0151OutBlock1 { get; set; }
}


/// <summary>
/// 서버시간조회: t0167
/// </summary>
[Path("/etc/time-search", Description = "서버시간조회", Headtype = "A")]
public class t0167 : TrBase
{
    // InBlock
    public t0167InBlock? t0167InBlock { get; set; }

    // OutBlock
    public t0167OutBlock? t0167OutBlock { get; set; }
}


/// <summary>
/// 주식잔고2: t0424
/// </summary>
[Path("/stock/accno", Description = "주식잔고2", Attr = true, Headtype = "D")]
public class t0424 : TrBase
{
    // InBlock
    public t0424InBlock? t0424InBlock { get; set; }

    // OutBlock
    public t0424OutBlock? t0424OutBlock { get; set; }
    public t0424OutBlock1[]? t0424OutBlock1 { get; set; }
}


/// <summary>
/// 주식체결/미체결: t0425
/// </summary>
[Path("/stock/accno", Description = "주식체결/미체결", Attr = true, Headtype = "D")]
public class t0425 : TrBase
{
    // InBlock
    public t0425InBlock? t0425InBlock { get; set; }

    // OutBlock
    public t0425OutBlock? t0425OutBlock { get; set; }
    public t0425OutBlock1[]? t0425OutBlock1 { get; set; }
}


/// <summary>
/// 선물/옵션체결/미체결: t0434
/// </summary>
[Path("/futureoption/accno", Description = "선물/옵션체결/미체결", Headtype = "D")]
public class t0434 : TrBase
{
    // InBlock
    public t0434InBlock? t0434InBlock { get; set; }

    // OutBlock
    public t0434OutBlock? t0434OutBlock { get; set; }
    public t0434OutBlock1[]? t0434OutBlock1 { get; set; }
}


/// <summary>
/// 선물/옵션잔고평가(이동평균): t0441
/// </summary>
[Path("/futureoption/accno", Description = "선물/옵션잔고평가(이동평균)", Attr = true, Headtype = "D")]
public class t0441 : TrBase
{
    // InBlock
    public t0441InBlock? t0441InBlock { get; set; }

    // OutBlock
    public t0441OutBlock? t0441OutBlock { get; set; }
    public t0441OutBlock1[]? t0441OutBlock1 { get; set; }
}


/// <summary>
/// 주식현재가호가조회: t1101
/// </summary>
[Path("/stock/market-data", Description = "주식현재가호가조회", Attr = true, Headtype = "A")]
public class t1101 : TrBase
{
    // InBlock
    public t1101InBlock? t1101InBlock { get; set; }

    // OutBlock
    public t1101OutBlock? t1101OutBlock { get; set; }
}


/// <summary>
/// 주식현재가(시세)조회: t1102
/// </summary>
[Path("/stock/market-data", Description = "주식현재가(시세)조회", Attr = true, Headtype = "A")]
public class t1102 : TrBase
{
    // InBlock
    public t1102InBlock? t1102InBlock { get; set; }

    // OutBlock
    public t1102OutBlock? t1102OutBlock { get; set; }
}


/// <summary>
/// 주식현재가시세메모: t1104
/// </summary>
[Path("/stock/market-data", Description = "주식현재가시세메모", Headtype = "A")]
public class t1104 : TrBase
{
    // InBlock
    public t1104InBlock? t1104InBlock { get; set; }
    public t1104InBlock1[]? t1104InBlock1 { get; set; }

    // OutBlock
    public t1104OutBlock? t1104OutBlock { get; set; }
    public t1104OutBlock1[]? t1104OutBlock1 { get; set; }
}


/// <summary>
/// 주식피못/디마크조회: t1105
/// </summary>
[Path("/stock/market-data", Description = "주식피못/디마크조회", Attr = true, Headtype = "A")]
public class t1105 : TrBase
{
    // InBlock
    public t1105InBlock? t1105InBlock { get; set; }

    // OutBlock
    public t1105OutBlock? t1105OutBlock { get; set; }
}


/// <summary>
/// 시간외체결량: t1109
/// </summary>
[Path("/stock/market-data", Description = "시간외체결량", Attr = true, Headtype = "A")]
public class t1109 : TrBase
{
    // InBlock
    public t1109InBlock? t1109InBlock { get; set; }

    // OutBlock
    public t1109OutBlock? t1109OutBlock { get; set; }
    public t1109OutBlock1[]? t1109OutBlock1 { get; set; }
}


/// <summary>
/// 주식시간대별체결조회: t1301
/// </summary>
[Path("/stock/market-data", Description = "주식시간대별체결조회", Attr = true, Headtype = "A")]
public class t1301 : TrBase
{
    // InBlock
    public t1301InBlock? t1301InBlock { get; set; }

    // OutBlock
    public t1301OutBlock? t1301OutBlock { get; set; }
    public t1301OutBlock1[]? t1301OutBlock1 { get; set; }
}


/// <summary>
/// 주식분별주가조회: t1302
/// </summary>
[Path("/stock/market-data", Description = "주식분별주가조회", Attr = true, Headtype = "A")]
public class t1302 : TrBase
{
    // InBlock
    public t1302InBlock? t1302InBlock { get; set; }

    // OutBlock
    public t1302OutBlock? t1302OutBlock { get; set; }
    public t1302OutBlock1[]? t1302OutBlock1 { get; set; }
}


/// <summary>
/// 기간별주가: t1305
/// </summary>
[Path("/stock/market-data", Description = "기간별주가", Attr = true, Headtype = "A")]
public class t1305 : TrBase
{
    // InBlock
    public t1305InBlock? t1305InBlock { get; set; }

    // OutBlock
    public t1305OutBlock? t1305OutBlock { get; set; }
    public t1305OutBlock1[]? t1305OutBlock1 { get; set; }
}


/// <summary>
/// 주식시간대별체결조회챠트: t1308
/// </summary>
[Path("/stock/market-data", Description = "주식시간대별체결조회챠트", Attr = true, Headtype = "A")]
public class t1308 : TrBase
{
    // InBlock
    public t1308InBlock? t1308InBlock { get; set; }

    // OutBlock
    public t1308OutBlock1[]? t1308OutBlock1 { get; set; }
}


/// <summary>
/// 주식당일전일분틱조회: t1310
/// </summary>
[Path("/stock/market-data", Description = "주식당일전일분틱조회", Attr = true, Headtype = "A")]
public class t1310 : TrBase
{
    // InBlock
    public t1310InBlock? t1310InBlock { get; set; }

    // OutBlock
    public t1310OutBlock? t1310OutBlock { get; set; }
    public t1310OutBlock1[]? t1310OutBlock1 { get; set; }
}


/// <summary>
/// 신규상장종목조회: t1403
/// </summary>
[Path("/stock/etc", Description = "신규상장종목조회", Attr = true, Headtype = "A")]
public class t1403 : TrBase
{
    // InBlock
    public t1403InBlock? t1403InBlock { get; set; }

    // OutBlock
    public t1403OutBlock? t1403OutBlock { get; set; }
    public t1403OutBlock1[]? t1403OutBlock1 { get; set; }
}


/// <summary>
/// 관리/불성실/투자유의조회: t1404
/// </summary>
[Path("/stock/market-data", Description = "관리/불성실/투자유의조회", Attr = true, Headtype = "A")]
public class t1404 : TrBase
{
    // InBlock
    public t1404InBlock? t1404InBlock { get; set; }

    // OutBlock
    public t1404OutBlock? t1404OutBlock { get; set; }
    public t1404OutBlock1[]? t1404OutBlock1 { get; set; }
}


/// <summary>
/// 투자경고/매매정지/정리매매조회: t1405
/// </summary>
[Path("/stock/market-data", Description = "투자경고/매매정지/정리매매조회", Attr = true, Headtype = "A")]
public class t1405 : TrBase
{
    // InBlock
    public t1405InBlock? t1405InBlock { get; set; }

    // OutBlock
    public t1405OutBlock? t1405OutBlock { get; set; }
    public t1405OutBlock1[]? t1405OutBlock1 { get; set; }
}


/// <summary>
/// 초저유동성조회: t1410
/// </summary>
[Path("/stock/market-data", Description = "초저유동성조회", Attr = true, Headtype = "A")]
public class t1410 : TrBase
{
    // InBlock
    public t1410InBlock? t1410InBlock { get; set; }

    // OutBlock
    public t1410OutBlock? t1410OutBlock { get; set; }
    public t1410OutBlock1[]? t1410OutBlock1 { get; set; }
}


/// <summary>
/// 증거금율별종목조회: t1411
/// </summary>
[Path("/stock/etc", Description = "증거금율별종목조회", Attr = true, Headtype = "A")]
public class t1411 : TrBase
{
    // InBlock
    public t1411InBlock? t1411InBlock { get; set; }

    // OutBlock
    public t1411OutBlock? t1411OutBlock { get; set; }
    public t1411OutBlock1[]? t1411OutBlock1 { get; set; }
}


/// <summary>
/// 상/하한: t1422
/// </summary>
[Path("/stock/market-data", Description = "상/하한", Attr = true, Headtype = "A")]
public class t1422 : TrBase
{
    // InBlock
    public t1422InBlock? t1422InBlock { get; set; }

    // OutBlock
    public t1422OutBlock? t1422OutBlock { get; set; }
    public t1422OutBlock1[]? t1422OutBlock1 { get; set; }
}


/// <summary>
/// 상/하한가직전: t1427
/// </summary>
[Path("/stock/market-data", Description = "상/하한가직전", Attr = true, Headtype = "A")]
public class t1427 : TrBase
{
    // InBlock
    public t1427InBlock? t1427InBlock { get; set; }

    // OutBlock
    public t1427OutBlock? t1427OutBlock { get; set; }
    public t1427OutBlock1[]? t1427OutBlock1 { get; set; }
}


/// <summary>
/// 등락율상위: t1441
/// </summary>
[Path("/stock/high-item", Description = "등락율상위", Attr = true, Headtype = "A")]
public class t1441 : TrBase
{
    // InBlock
    public t1441InBlock? t1441InBlock { get; set; }

    // OutBlock
    public t1441OutBlock? t1441OutBlock { get; set; }
    public t1441OutBlock1[]? t1441OutBlock1 { get; set; }
}


/// <summary>
/// 신고/신저가: t1442
/// </summary>
[Path("/stock/market-data", Description = "신고/신저가", Attr = true, Headtype = "A")]
public class t1442 : TrBase
{
    // InBlock
    public t1442InBlock? t1442InBlock { get; set; }

    // OutBlock
    public t1442OutBlock? t1442OutBlock { get; set; }
    public t1442OutBlock1[]? t1442OutBlock1 { get; set; }
}


/// <summary>
/// 시가총액상위: t1444
/// </summary>
[Path("/stock/high-item", Description = "시가총액상위", Attr = true, Headtype = "A")]
public class t1444 : TrBase
{
    // InBlock
    public t1444InBlock? t1444InBlock { get; set; }

    // OutBlock
    public t1444OutBlock? t1444OutBlock { get; set; }
    public t1444OutBlock1[]? t1444OutBlock1 { get; set; }
}


/// <summary>
/// 가격대별매매비중조회: t1449
/// </summary>
[Path("/stock/market-data", Description = "가격대별매매비중조회", Attr = true, Headtype = "A")]
public class t1449 : TrBase
{
    // InBlock
    public t1449InBlock? t1449InBlock { get; set; }

    // OutBlock
    public t1449OutBlock? t1449OutBlock { get; set; }
    public t1449OutBlock1[]? t1449OutBlock1 { get; set; }
}


/// <summary>
/// 거래량상위: t1452
/// </summary>
[Path("/stock/high-item", Description = "거래량상위", Attr = true, Headtype = "A")]
public class t1452 : TrBase
{
    // InBlock
    public t1452InBlock? t1452InBlock { get; set; }

    // OutBlock
    public t1452OutBlock? t1452OutBlock { get; set; }
    public t1452OutBlock1[]? t1452OutBlock1 { get; set; }
}


/// <summary>
/// 거래대금상위: t1463
/// </summary>
[Path("/stock/high-item", Description = "거래대금상위", Attr = true, Headtype = "A")]
public class t1463 : TrBase
{
    // InBlock
    public t1463InBlock? t1463InBlock { get; set; }

    // OutBlock
    public t1463OutBlock? t1463OutBlock { get; set; }
    public t1463OutBlock1[]? t1463OutBlock1 { get; set; }
}


/// <summary>
/// 전일동시간대비거래급증: t1466
/// </summary>
[Path("/stock/high-item", Description = "전일동시간대비거래급증", Attr = true, Headtype = "A")]
public class t1466 : TrBase
{
    // InBlock
    public t1466InBlock? t1466InBlock { get; set; }

    // OutBlock
    public t1466OutBlock? t1466OutBlock { get; set; }
    public t1466OutBlock1[]? t1466OutBlock1 { get; set; }
}


/// <summary>
/// 시간대별호가잔량추이: t1471
/// </summary>
[Path("/stock/market-data", Description = "시간대별호가잔량추이", Attr = true, Headtype = "A")]
public class t1471 : TrBase
{
    // InBlock
    public t1471InBlock? t1471InBlock { get; set; }

    // OutBlock
    public t1471OutBlock? t1471OutBlock { get; set; }
    public t1471OutBlock1[]? t1471OutBlock1 { get; set; }
}


/// <summary>
/// 체결강도추이: t1475
/// </summary>
[Path("/stock/market-data", Description = "체결강도추이", Attr = true, Headtype = "A")]
public class t1475 : TrBase
{
    // InBlock
    public t1475InBlock? t1475InBlock { get; set; }

    // OutBlock
    public t1475OutBlock? t1475OutBlock { get; set; }
    public t1475OutBlock1[]? t1475OutBlock1 { get; set; }
}


/// <summary>
/// 시간외등락율상위: t1481
/// </summary>
[Path("/stock/high-item", Description = "시간외등락율상위", Attr = true, Headtype = "A")]
public class t1481 : TrBase
{
    // InBlock
    public t1481InBlock? t1481InBlock { get; set; }

    // OutBlock
    public t1481OutBlock? t1481OutBlock { get; set; }
    public t1481OutBlock1[]? t1481OutBlock1 { get; set; }
}


/// <summary>
/// 시간외거래량상위: t1482
/// </summary>
[Path("/stock/high-item", Description = "시간외거래량상위", Attr = true, Headtype = "A")]
public class t1482 : TrBase
{
    // InBlock
    public t1482InBlock? t1482InBlock { get; set; }

    // OutBlock
    public t1482OutBlock? t1482OutBlock { get; set; }
    public t1482OutBlock1[]? t1482OutBlock1 { get; set; }
}


/// <summary>
/// 예상지수: t1485
/// </summary>
[Path("/indtp/market-data", Description = "예상지수", Attr = true, Headtype = "A")]
public class t1485 : TrBase
{
    // InBlock
    public t1485InBlock? t1485InBlock { get; set; }

    // OutBlock
    public t1485OutBlock? t1485OutBlock { get; set; }
    public t1485OutBlock1[]? t1485OutBlock1 { get; set; }
}


/// <summary>
/// 시간별예상체결가: t1486
/// </summary>
[Path("/stock/market-data", Description = "시간별예상체결가", Attr = true, Headtype = "A")]
public class t1486 : TrBase
{
    // InBlock
    public t1486InBlock? t1486InBlock { get; set; }

    // OutBlock
    public t1486OutBlock? t1486OutBlock { get; set; }
    public t1486OutBlock1[]? t1486OutBlock1 { get; set; }
}


/// <summary>
/// 예상체결가등락율상위조회: t1488
/// </summary>
[Path("/stock/market-data", Description = "예상체결가등락율상위조회", Attr = true, Headtype = "A")]
public class t1488 : TrBase
{
    // InBlock
    public t1488InBlock? t1488InBlock { get; set; }

    // OutBlock
    public t1488OutBlock? t1488OutBlock { get; set; }
    public t1488OutBlock1[]? t1488OutBlock1 { get; set; }
}


/// <summary>
/// 예상체결량상위조회: t1489
/// </summary>
[Path("/stock/high-item", Description = "예상체결량상위조회", Attr = true, Headtype = "A")]
public class t1489 : TrBase
{
    // InBlock
    public t1489InBlock? t1489InBlock { get; set; }

    // OutBlock
    public t1489OutBlock? t1489OutBlock { get; set; }
    public t1489OutBlock1[]? t1489OutBlock1 { get; set; }
}


/// <summary>
/// 단일가예상등락율상위: t1492
/// </summary>
[Path("/stock/high-item", Description = "단일가예상등락율상위", Attr = true, Headtype = "A")]
public class t1492 : TrBase
{
    // InBlock
    public t1492InBlock? t1492InBlock { get; set; }

    // OutBlock
    public t1492OutBlock? t1492OutBlock { get; set; }
    public t1492OutBlock1[]? t1492OutBlock1 { get; set; }
}


/// <summary>
/// 업종현재가: t1511
/// </summary>
[Path("/indtp/market-data", Description = "업종현재가", Attr = true, Headtype = "A")]
public class t1511 : TrBase
{
    // InBlock
    public t1511InBlock? t1511InBlock { get; set; }

    // OutBlock
    public t1511OutBlock? t1511OutBlock { get; set; }
}


/// <summary>
/// 업종기간별추이: t1514
/// </summary>
[Path("/indtp/market-data", Description = "업종기간별추이", Attr = true, Headtype = "A")]
public class t1514 : TrBase
{
    // InBlock
    public t1514InBlock? t1514InBlock { get; set; }

    // OutBlock
    public t1514OutBlock? t1514OutBlock { get; set; }
    public t1514OutBlock1[]? t1514OutBlock1 { get; set; }
}


/// <summary>
/// 업종별종목시세: t1516
/// </summary>
[Path("/indtp/market-data", Description = "업종별종목시세", Attr = true, Headtype = "A")]
public class t1516 : TrBase
{
    // InBlock
    public t1516InBlock? t1516InBlock { get; set; }

    // OutBlock
    public t1516OutBlock? t1516OutBlock { get; set; }
    public t1516OutBlock1[]? t1516OutBlock1 { get; set; }
}


/// <summary>
/// 테마별종목: t1531
/// </summary>
[Path("/stock/sector", Description = "테마별종목", Attr = true, Headtype = "A")]
public class t1531 : TrBase
{
    // InBlock
    public t1531InBlock? t1531InBlock { get; set; }

    // OutBlock
    public t1531OutBlock[]? t1531OutBlock { get; set; }
}


/// <summary>
/// 종목별테마: t1532
/// </summary>
[Path("/stock/sector", Description = "종목별테마", Attr = true, Headtype = "A")]
public class t1532 : TrBase
{
    // InBlock
    public t1532InBlock? t1532InBlock { get; set; }

    // OutBlock
    public t1532OutBlock[]? t1532OutBlock { get; set; }
}


/// <summary>
/// 특이테마: t1533
/// </summary>
[Path("/stock/sector", Description = "특이테마", Attr = true, Headtype = "A")]
public class t1533 : TrBase
{
    // InBlock
    public t1533InBlock? t1533InBlock { get; set; }

    // OutBlock
    public t1533OutBlock? t1533OutBlock { get; set; }
    public t1533OutBlock1[]? t1533OutBlock1 { get; set; }
}


/// <summary>
/// 테마종목별시세조회: t1537
/// </summary>
[Path("/stock/sector", Description = "테마종목별시세조회", Attr = true, Headtype = "A")]
public class t1537 : TrBase
{
    // InBlock
    public t1537InBlock? t1537InBlock { get; set; }

    // OutBlock
    public t1537OutBlock? t1537OutBlock { get; set; }
    public t1537OutBlock1[]? t1537OutBlock1 { get; set; }
}


/// <summary>
/// 투자자별종합: t1601
/// </summary>
[Path("/stock/investor", Description = "투자자별종합", Attr = true, Headtype = "A")]
public class t1601 : TrBase
{
    // InBlock
    public t1601InBlock? t1601InBlock { get; set; }

    // OutBlock
    public t1601OutBlock1? t1601OutBlock1 { get; set; }
    public t1601OutBlock2? t1601OutBlock2 { get; set; }
    public t1601OutBlock3? t1601OutBlock3 { get; set; }
    public t1601OutBlock4? t1601OutBlock4 { get; set; }
    public t1601OutBlock5? t1601OutBlock5 { get; set; }
    public t1601OutBlock6? t1601OutBlock6 { get; set; }
}


/// <summary>
/// 시간대별투자자매매추이: t1602
/// </summary>
[Path("/stock/investor", Description = "시간대별투자자매매추이", Attr = true, Headtype = "A")]
public class t1602 : TrBase
{
    // InBlock
    public t1602InBlock? t1602InBlock { get; set; }

    // OutBlock
    public t1602OutBlock? t1602OutBlock { get; set; }
    public t1602OutBlock1[]? t1602OutBlock1 { get; set; }
}


/// <summary>
/// 시간대별투자자매매추이상세: t1603
/// </summary>
[Path("/stock/investor", Description = "시간대별투자자매매추이상세", Attr = true, Headtype = "A")]
public class t1603 : TrBase
{
    // InBlock
    public t1603InBlock? t1603InBlock { get; set; }

    // OutBlock
    public t1603OutBlock? t1603OutBlock { get; set; }
    public t1603OutBlock1[]? t1603OutBlock1 { get; set; }
}


/// <summary>
/// 투자자매매종합1: t1615
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합1", Attr = true, Headtype = "A")]
public class t1615 : TrBase
{
    // InBlock
    public t1615InBlock? t1615InBlock { get; set; }

    // OutBlock
    public t1615OutBlock? t1615OutBlock { get; set; }
    public t1615OutBlock1[]? t1615OutBlock1 { get; set; }
}


/// <summary>
/// 투자자매매종합2: t1617
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합2", Attr = true, Headtype = "A")]
public class t1617 : TrBase
{
    // InBlock
    public t1617InBlock? t1617InBlock { get; set; }

    // OutBlock
    public t1617OutBlock? t1617OutBlock { get; set; }
    public t1617OutBlock1[]? t1617OutBlock1 { get; set; }
}


/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621
/// </summary>
[Path("/stock/investor", Description = "업종별분별투자자매매동향(챠트용)", Attr = true, Headtype = "A")]
public class t1621 : TrBase
{
    // InBlock
    public t1621InBlock? t1621InBlock { get; set; }

    // OutBlock
    public t1621OutBlock? t1621OutBlock { get; set; }
    public t1621OutBlock1[]? t1621OutBlock1 { get; set; }
}


/// <summary>
/// 프로그램매매종합조회: t1631
/// </summary>
[Path("/stock/program", Description = "프로그램매매종합조회", Attr = true, Headtype = "A")]
public class t1631 : TrBase
{
    // InBlock
    public t1631InBlock? t1631InBlock { get; set; }

    // OutBlock
    public t1631OutBlock? t1631OutBlock { get; set; }
    public t1631OutBlock1[]? t1631OutBlock1 { get; set; }
}


/// <summary>
/// 시간대별프로그램매매추이: t1632
/// </summary>
[Path("/stock/program", Description = "시간대별프로그램매매추이", Attr = true, Headtype = "A")]
public class t1632 : TrBase
{
    // InBlock
    public t1632InBlock? t1632InBlock { get; set; }

    // OutBlock
    public t1632OutBlock? t1632OutBlock { get; set; }
    public t1632OutBlock1[]? t1632OutBlock1 { get; set; }
}


/// <summary>
/// 기간별프로그램매매추이: t1633
/// </summary>
[Path("/stock/program", Description = "기간별프로그램매매추이", Attr = true, Headtype = "A")]
public class t1633 : TrBase
{
    // InBlock
    public t1633InBlock? t1633InBlock { get; set; }

    // OutBlock
    public t1633OutBlock? t1633OutBlock { get; set; }
    public t1633OutBlock1[]? t1633OutBlock1 { get; set; }
}


/// <summary>
/// 종목별프로그램매매동향: t1636
/// </summary>
[Path("/stock/program", Description = "종목별프로그램매매동향", Attr = true, Headtype = "A")]
public class t1636 : TrBase
{
    // InBlock
    public t1636InBlock? t1636InBlock { get; set; }

    // OutBlock
    public t1636OutBlock? t1636OutBlock { get; set; }
    public t1636OutBlock1[]? t1636OutBlock1 { get; set; }
}


/// <summary>
/// 종목별프로그램매매추이: t1637
/// </summary>
[Path("/stock/program", Description = "종목별프로그램매매추이", Attr = true, Headtype = "A")]
public class t1637 : TrBase
{
    // InBlock
    public t1637InBlock? t1637InBlock { get; set; }

    // OutBlock
    public t1637OutBlock? t1637OutBlock { get; set; }
    public t1637OutBlock1[]? t1637OutBlock1 { get; set; }
}


/// <summary>
/// 종목별잔량/사전공시: t1638
/// </summary>
[Path("/stock/etc", Description = "종목별잔량/사전공시", Attr = true, Headtype = "A")]
public class t1638 : TrBase
{
    // InBlock
    public t1638InBlock? t1638InBlock { get; set; }

    // OutBlock
    public t1638OutBlock[]? t1638OutBlock { get; set; }
}


/// <summary>
/// 프로그램매매종합조회(미니): t1640
/// </summary>
[Path("/stock/program", Description = "프로그램매매종합조회(미니)", Attr = true, Headtype = "A")]
public class t1640 : TrBase
{
    // InBlock
    public t1640InBlock? t1640InBlock { get; set; }

    // OutBlock
    public t1640OutBlock? t1640OutBlock { get; set; }
}


/// <summary>
/// 시간대별프로그램매매추이(차트): t1662
/// </summary>
[Path("/stock/program", Description = "시간대별프로그램매매추이(차트)", Attr = true, Headtype = "A")]
public class t1662 : TrBase
{
    // InBlock
    public t1662InBlock? t1662InBlock { get; set; }

    // OutBlock
    public t1662OutBlock[]? t1662OutBlock { get; set; }
}


/// <summary>
/// 투자자매매종합(챠트): t1664
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합(챠트)", Attr = true, Headtype = "A")]
public class t1664 : TrBase
{
    // InBlock
    public t1664InBlock? t1664InBlock { get; set; }

    // OutBlock
    public t1664OutBlock1[]? t1664OutBlock1 { get; set; }
}


/// <summary>
/// 기간별투자자매매추이(챠트): t1665
/// </summary>
[Path("/stock/chart", Description = "기간별투자자매매추이(챠트)", Attr = true, Headtype = "A")]
public class t1665 : TrBase
{
    // InBlock
    public t1665InBlock? t1665InBlock { get; set; }

    // OutBlock
    public t1665OutBlock? t1665OutBlock { get; set; }
    public t1665OutBlock1[]? t1665OutBlock1 { get; set; }
}


/// <summary>
/// 외인기관종목별동향: t1702
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향", Attr = true, Headtype = "A")]
public class t1702 : TrBase
{
    // InBlock
    public t1702InBlock? t1702InBlock { get; set; }

    // OutBlock
    public t1702OutBlock? t1702OutBlock { get; set; }
    public t1702OutBlock1[]? t1702OutBlock1 { get; set; }
}


/// <summary>
/// 외인기관종목별동향: t1716
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향", Attr = true, Headtype = "A")]
public class t1716 : TrBase
{
    // InBlock
    public t1716InBlock? t1716InBlock { get; set; }

    // OutBlock
    public t1716OutBlock[]? t1716OutBlock { get; set; }
}


/// <summary>
/// 외인기관종목별동향: t1717
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향", Attr = true, Headtype = "A")]
public class t1717 : TrBase
{
    // InBlock
    public t1717InBlock? t1717InBlock { get; set; }

    // OutBlock
    public t1717OutBlock[]? t1717OutBlock { get; set; }
}


/// <summary>
/// 종목별상위회원사: t1752
/// </summary>
[Path("/stock/exchange", Description = "종목별상위회원사", Attr = true, Headtype = "A")]
public class t1752 : TrBase
{
    // InBlock
    public t1752InBlock? t1752InBlock { get; set; }

    // OutBlock
    public t1752OutBlock? t1752OutBlock { get; set; }
    public t1752OutBlock1[]? t1752OutBlock1 { get; set; }
}


/// <summary>
/// 회원사리스트: t1764
/// </summary>
[Path("/stock/exchange", Description = "회원사리스트", Attr = true, Headtype = "A")]
public class t1764 : TrBase
{
    // InBlock
    public t1764InBlock? t1764InBlock { get; set; }

    // OutBlock
    public t1764OutBlock[]? t1764OutBlock { get; set; }
}


/// <summary>
/// 종목별회원사추이: t1771
/// </summary>
[Path("/stock/exchange", Description = "종목별회원사추이", Attr = true, Headtype = "A")]
public class t1771 : TrBase
{
    // InBlock
    public t1771InBlock? t1771InBlock { get; set; }

    // OutBlock
    public t1771OutBlock? t1771OutBlock { get; set; }
    public t1771OutBlock2[]? t1771OutBlock2 { get; set; }
}


/// <summary>
/// 신호조회: t1809
/// </summary>
[Path("/stock/item-search", Description = "신호조회", Headtype = "A")]
public class t1809 : TrBase
{
    // InBlock
    public t1809InBlock? t1809InBlock { get; set; }

    // OutBlock
    public t1809OutBlock? t1809OutBlock { get; set; }
    public t1809OutBlock1[]? t1809OutBlock1 { get; set; }
}


/// <summary>
/// 종목Q클릭검색(씽큐스마트): t1825
/// </summary>
[Path("/stock/item-search", Description = "종목Q클릭검색(씽큐스마트)", Attr = true, Headtype = "A")]
public class t1825 : TrBase
{
    // InBlock
    public t1825InBlock? t1825InBlock { get; set; }

    // OutBlock
    public t1825OutBlock? t1825OutBlock { get; set; }
    public t1825OutBlock1[]? t1825OutBlock1 { get; set; }
}


/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트): t1826
/// </summary>
[Path("/stock/item-search", Description = "종목Q클릭검색리스트조회(씽큐스마트)", Headtype = "A")]
public class t1826 : TrBase
{
    // InBlock
    public t1826InBlock? t1826InBlock { get; set; }

    // OutBlock
    public t1826OutBlock[]? t1826OutBlock { get; set; }
}


/// <summary>
/// e종목검색(신버전API용): t1857
/// </summary>
[Path("", Description = "e종목검색(신버전API용)", Attr = true, Headtype = "A")]
public class t1857 : TrBase
{
    // InBlock
    public t1857InBlock? t1857InBlock { get; set; }

    // OutBlock
    public t1857OutBlock? t1857OutBlock { get; set; }
    public t1857OutBlock1[]? t1857OutBlock1 { get; set; }
}


/// <summary>
/// 서버저장조건리스트조회(API): t1866
/// </summary>
[Path("/stock/item-search", Description = "서버저장조건리스트조회(API)", Headtype = "A")]
public class t1866 : TrBase
{
    // InBlock
    public t1866InBlock? t1866InBlock { get; set; }

    // OutBlock
    public t1866OutBlock? t1866OutBlock { get; set; }
    public t1866OutBlock1[]? t1866OutBlock1 { get; set; }
}


/// <summary>
/// ETF현재가(시세)조회: t1901
/// </summary>
[Path("/stock/etf", Description = "ETF현재가(시세)조회", Attr = true, Headtype = "A")]
public class t1901 : TrBase
{
    // InBlock
    public t1901InBlock? t1901InBlock { get; set; }

    // OutBlock
    public t1901OutBlock? t1901OutBlock { get; set; }
}


/// <summary>
/// ETF시간별추이: t1902
/// </summary>
[Path("/stock/etf", Description = "ETF시간별추이", Attr = true, Headtype = "A")]
public class t1902 : TrBase
{
    // InBlock
    public t1902InBlock? t1902InBlock { get; set; }

    // OutBlock
    public t1902OutBlock? t1902OutBlock { get; set; }
    public t1902OutBlock1[]? t1902OutBlock1 { get; set; }
}


/// <summary>
/// ETF일별추이: t1903
/// </summary>
[Path("/stock/etf", Description = "ETF일별추이", Attr = true, Headtype = "A")]
public class t1903 : TrBase
{
    // InBlock
    public t1903InBlock? t1903InBlock { get; set; }

    // OutBlock
    public t1903OutBlock? t1903OutBlock { get; set; }
    public t1903OutBlock1[]? t1903OutBlock1 { get; set; }
}


/// <summary>
/// ETF구성종목조회: t1904
/// </summary>
[Path("/stock/etf", Description = "ETF구성종목조회", Attr = true, Headtype = "A")]
public class t1904 : TrBase
{
    // InBlock
    public t1904InBlock? t1904InBlock { get; set; }

    // OutBlock
    public t1904OutBlock? t1904OutBlock { get; set; }
    public t1904OutBlock1[]? t1904OutBlock1 { get; set; }
}


/// <summary>
/// ETFLP호가: t1906
/// </summary>
[Path("/stock/etf", Description = "ETFLP호가", Attr = true, Headtype = "A")]
public class t1906 : TrBase
{
    // InBlock
    public t1906InBlock? t1906InBlock { get; set; }

    // OutBlock
    public t1906OutBlock? t1906OutBlock { get; set; }
}


/// <summary>
/// 신용거래동향: t1921
/// </summary>
[Path("/stock/etc", Description = "신용거래동향", Attr = true, Headtype = "A")]
public class t1921 : TrBase
{
    // InBlock
    public t1921InBlock? t1921InBlock { get; set; }

    // OutBlock
    public t1921OutBlock? t1921OutBlock { get; set; }
    public t1921OutBlock1[]? t1921OutBlock1 { get; set; }
}


/// <summary>
/// 종목별신용정보: t1926
/// </summary>
[Path("/stock/etc", Description = "종목별신용정보", Attr = true, Headtype = "A")]
public class t1926 : TrBase
{
    // InBlock
    public t1926InBlock? t1926InBlock { get; set; }

    // OutBlock
    public t1926OutBlock? t1926OutBlock { get; set; }
}


/// <summary>
/// 공매도일별추이: t1927
/// </summary>
[Path("/stock/etc", Description = "공매도일별추이", Attr = true, Headtype = "A")]
public class t1927 : TrBase
{
    // InBlock
    public t1927InBlock? t1927InBlock { get; set; }

    // OutBlock
    public t1927OutBlock? t1927OutBlock { get; set; }
    public t1927OutBlock1[]? t1927OutBlock1 { get; set; }
}


/// <summary>
/// 종목별대차거래일간추이: t1941
/// </summary>
[Path("/stock/etc", Description = "종목별대차거래일간추이", Attr = true, Headtype = "A")]
public class t1941 : TrBase
{
    // InBlock
    public t1941InBlock? t1941InBlock { get; set; }

    // OutBlock
    public t1941OutBlock1[]? t1941OutBlock1 { get; set; }
}


/// <summary>
/// ELW현재가(시세)조회: t1950
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(시세)조회", Attr = true, Headtype = "A")]
public class t1950 : TrBase
{
    // InBlock
    public t1950InBlock? t1950InBlock { get; set; }

    // OutBlock
    public t1950OutBlock? t1950OutBlock { get; set; }
    public t1950OutBlock1[]? t1950OutBlock1 { get; set; }
}


/// <summary>
/// ELW시간대별체결조회: t1951
/// </summary>
[Path("/stock/elw", Description = "ELW시간대별체결조회", Attr = true, Headtype = "A")]
public class t1951 : TrBase
{
    // InBlock
    public t1951InBlock? t1951InBlock { get; set; }

    // OutBlock
    public t1951OutBlock? t1951OutBlock { get; set; }
    public t1951OutBlock1[]? t1951OutBlock1 { get; set; }
}


/// <summary>
/// ELW일별주가: t1954
/// </summary>
[Path("/stock/elw", Description = "ELW일별주가", Attr = true, Headtype = "A")]
public class t1954 : TrBase
{
    // InBlock
    public t1954InBlock? t1954InBlock { get; set; }

    // OutBlock
    public t1954OutBlock? t1954OutBlock { get; set; }
    public t1954OutBlock1[]? t1954OutBlock1 { get; set; }
}


/// <summary>
/// ELW현재가(확정지급액)조회: t1956
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(확정지급액)조회", Attr = true, Headtype = "A")]
public class t1956 : TrBase
{
    // InBlock
    public t1956InBlock? t1956InBlock { get; set; }

    // OutBlock
    public t1956OutBlock? t1956OutBlock { get; set; }
    public t1956OutBlock1[]? t1956OutBlock1 { get; set; }
}


/// <summary>
/// ELW종목비교: t1958
/// </summary>
[Path("/stock/elw", Description = "ELW종목비교", Attr = true, Headtype = "A")]
public class t1958 : TrBase
{
    // InBlock
    public t1958InBlock? t1958InBlock { get; set; }

    // OutBlock
    public t1958OutBlock? t1958OutBlock { get; set; }
    public t1958OutBlock1? t1958OutBlock1 { get; set; }
    public t1958OutBlock2? t1958OutBlock2 { get; set; }
}


/// <summary>
/// LP대상종목정보조회: t1959
/// </summary>
[Path("/stock/elw", Description = "LP대상종목정보조회", Attr = true, Headtype = "A")]
public class t1959 : TrBase
{
    // InBlock
    public t1959InBlock? t1959InBlock { get; set; }

    // OutBlock
    public t1959OutBlock1[]? t1959OutBlock1 { get; set; }
}


/// <summary>
/// ELW등락율상위: t1960
/// </summary>
[Path("/stock/elw", Description = "ELW등락율상위", Attr = true, Headtype = "A")]
public class t1960 : TrBase
{
    // InBlock
    public t1960InBlock? t1960InBlock { get; set; }

    // OutBlock
    public t1960OutBlock? t1960OutBlock { get; set; }
    public t1960OutBlock1[]? t1960OutBlock1 { get; set; }
}


/// <summary>
/// ELW거래량상위: t1961
/// </summary>
[Path("/stock/elw", Description = "ELW거래량상위", Attr = true, Headtype = "A")]
public class t1961 : TrBase
{
    // InBlock
    public t1961InBlock? t1961InBlock { get; set; }

    // OutBlock
    public t1961OutBlock? t1961OutBlock { get; set; }
    public t1961OutBlock1[]? t1961OutBlock1 { get; set; }
}


/// <summary>
/// ELW전광판: t1964
/// </summary>
[Path("/stock/elw", Description = "ELW전광판", Attr = true, Headtype = "A")]
public class t1964 : TrBase
{
    // InBlock
    public t1964InBlock? t1964InBlock { get; set; }

    // OutBlock
    public t1964OutBlock1[]? t1964OutBlock1 { get; set; }
}


/// <summary>
/// ELW거래대금상위: t1966
/// </summary>
[Path("/stock/elw", Description = "ELW거래대금상위", Attr = true, Headtype = "A")]
public class t1966 : TrBase
{
    // InBlock
    public t1966InBlock? t1966InBlock { get; set; }

    // OutBlock
    public t1966OutBlock? t1966OutBlock { get; set; }
    public t1966OutBlock1[]? t1966OutBlock1 { get; set; }
}


/// <summary>
/// ELW지표검색: t1969
/// </summary>
[Path("/stock/elw", Description = "ELW지표검색", Attr = true, Headtype = "A")]
public class t1969 : TrBase
{
    // InBlock
    public t1969InBlock? t1969InBlock { get; set; }

    // OutBlock
    public t1969OutBlock? t1969OutBlock { get; set; }
    public t1969OutBlock1[]? t1969OutBlock1 { get; set; }
}


/// <summary>
/// ELW현재가호가조회: t1971
/// </summary>
[Path("/stock/elw", Description = "ELW현재가호가조회", Attr = true, Headtype = "A")]
public class t1971 : TrBase
{
    // InBlock
    public t1971InBlock? t1971InBlock { get; set; }

    // OutBlock
    public t1971OutBlock? t1971OutBlock { get; set; }
}


/// <summary>
/// ELW현재가(거래원)조회: t1972
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(거래원)조회", Attr = true, Headtype = "A")]
public class t1972 : TrBase
{
    // InBlock
    public t1972InBlock? t1972InBlock { get; set; }

    // OutBlock
    public t1972OutBlock? t1972OutBlock { get; set; }
}


/// <summary>
/// ELW시간대별예상체결조회: t1973
/// </summary>
[Path("/stock/elw", Description = "ELW시간대별예상체결조회", Attr = true, Headtype = "A")]
public class t1973 : TrBase
{
    // InBlock
    public t1973InBlock? t1973InBlock { get; set; }

    // OutBlock
    public t1973OutBlock? t1973OutBlock { get; set; }
    public t1973OutBlock1[]? t1973OutBlock1 { get; set; }
}


/// <summary>
/// ELW기초자산동일종목: t1974
/// </summary>
[Path("/stock/elw", Description = "ELW기초자산동일종목", Attr = true, Headtype = "A")]
public class t1974 : TrBase
{
    // InBlock
    public t1974InBlock? t1974InBlock { get; set; }

    // OutBlock
    public t1974OutBlock? t1974OutBlock { get; set; }
    public t1974OutBlock1[]? t1974OutBlock1 { get; set; }
}


/// <summary>
/// 기초자산리스트조회: t1988
/// </summary>
[Path("/stock/elw", Description = "기초자산리스트조회", Attr = true, Headtype = "A")]
public class t1988 : TrBase
{
    // InBlock
    public t1988InBlock? t1988InBlock { get; set; }

    // OutBlock
    public t1988OutBlock? t1988OutBlock { get; set; }
    public t1988OutBlock1[]? t1988OutBlock1 { get; set; }
}


/// <summary>
/// 선물/옵션현재가(시세)조회: t2101
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가(시세)조회", Attr = true, Headtype = "A")]
public class t2101 : TrBase
{
    // InBlock
    public t2101InBlock? t2101InBlock { get; set; }

    // OutBlock
    public t2101OutBlock? t2101OutBlock { get; set; }
}


/// <summary>
/// 선물/옵션현재가호가조회: t2105
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가호가조회", Attr = true, Headtype = "A")]
public class t2105 : TrBase
{
    // InBlock
    public t2105InBlock? t2105InBlock { get; set; }

    // OutBlock
    public t2105OutBlock? t2105OutBlock { get; set; }
}


/// <summary>
/// 선물/옵션현재가시세메모: t2106
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가시세메모", Headtype = "A")]
public class t2106 : TrBase
{
    // InBlock
    public t2106InBlock? t2106InBlock { get; set; }
    public t2106InBlock1[]? t2106InBlock1 { get; set; }

    // OutBlock
    public t2106OutBlock? t2106OutBlock { get; set; }
    public t2106OutBlock1[]? t2106OutBlock1 { get; set; }
}


/// <summary>
/// 선물옵션시간대별체결조회: t2201
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션시간대별체결조회", Attr = true, Headtype = "A")]
public class t2201 : TrBase
{
    // InBlock
    public t2201InBlock? t2201InBlock { get; set; }

    // OutBlock
    public t2201OutBlock? t2201OutBlock { get; set; }
    public t2201OutBlock1[]? t2201OutBlock1 { get; set; }
}


/// <summary>
/// 기간별주가: t2203
/// </summary>
[Path("/futureoption/market-data", Description = "기간별주가", Attr = true, Headtype = "A")]
public class t2203 : TrBase
{
    // InBlock
    public t2203InBlock? t2203InBlock { get; set; }

    // OutBlock
    public t2203OutBlock? t2203OutBlock { get; set; }
    public t2203OutBlock1[]? t2203OutBlock1 { get; set; }
}


/// <summary>
/// 선물옵션틱분별체결조회챠트: t2209
/// </summary>
[Path("/futureoption/chart", Description = "선물옵션틱분별체결조회챠트", Attr = true, Headtype = "A")]
public class t2209 : TrBase
{
    // InBlock
    public t2209InBlock? t2209InBlock { get; set; }

    // OutBlock
    public t2209OutBlock1[]? t2209OutBlock1 { get; set; }
}


/// <summary>
/// 선물옵션시간대별체결조회(단일출력용): t2210
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션시간대별체결조회(단일출력용)", Attr = true, Headtype = "A")]
public class t2210 : TrBase
{
    // InBlock
    public t2210InBlock? t2210InBlock { get; set; }

    // OutBlock
    public t2210OutBlock? t2210OutBlock { get; set; }
}


/// <summary>
/// 옵션전광판: t2301
/// </summary>
[Path("/futureoption/market-data", Description = "옵션전광판", Attr = true, Headtype = "A")]
public class t2301 : TrBase
{
    // InBlock
    public t2301InBlock? t2301InBlock { get; set; }

    // OutBlock
    public t2301OutBlock? t2301OutBlock { get; set; }
    public t2301OutBlock1[]? t2301OutBlock1 { get; set; }
    public t2301OutBlock2[]? t2301OutBlock2 { get; set; }
}


/// <summary>
/// 선물옵션호가잔량비율챠트: t2405
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션호가잔량비율챠트", Attr = true, Headtype = "A")]
public class t2405 : TrBase
{
    // InBlock
    public t2405InBlock? t2405InBlock { get; set; }

    // OutBlock
    public t2405OutBlock? t2405OutBlock { get; set; }
    public t2405OutBlock1[]? t2405OutBlock1 { get; set; }
}


/// <summary>
/// 미결제약정추이: t2421
/// </summary>
[Path("/futureoption/market-data", Description = "미결제약정추이", Attr = true, Headtype = "A")]
public class t2421 : TrBase
{
    // InBlock
    public t2421InBlock? t2421InBlock { get; set; }

    // OutBlock
    public t2421OutBlock? t2421OutBlock { get; set; }
    public t2421OutBlock1[]? t2421OutBlock1 { get; set; }
}


/// <summary>
/// 상품선물투자자매매동향(실시간): t2541
/// </summary>
[Path("/futureoption/investor", Description = "상품선물투자자매매동향(실시간)", Attr = true, Headtype = "A")]
public class t2541 : TrBase
{
    // InBlock
    public t2541InBlock? t2541InBlock { get; set; }

    // OutBlock
    public t2541OutBlock? t2541OutBlock { get; set; }
    public t2541OutBlock1[]? t2541OutBlock1 { get; set; }
}


/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545
/// </summary>
[Path("/futureoption/investor", Description = "상품선물투자자매매동향(챠트용)", Attr = true, Headtype = "A")]
public class t2545 : TrBase
{
    // InBlock
    public t2545InBlock? t2545InBlock { get; set; }

    // OutBlock
    public t2545OutBlock? t2545OutBlock { get; set; }
    public t2545OutBlock1[]? t2545OutBlock1 { get; set; }
}


/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회: t2830
/// </summary>
[Path("/futureoption/market-data", Description = "EUREXKOSPI200옵션선물현재가(시세)조회", Attr = true, Headtype = "A")]
public class t2830 : TrBase
{
    // InBlock
    public t2830InBlock? t2830InBlock { get; set; }

    // OutBlock
    public t2830OutBlock? t2830OutBlock { get; set; }
}


/// <summary>
/// EUREXKOSPI200옵션선물호가조회: t2831
/// </summary>
[Path("/futureoption/market-data", Description = "EUREXKOSPI200옵션선물호가조회", Attr = true, Headtype = "A")]
public class t2831 : TrBase
{
    // InBlock
    public t2831InBlock? t2831InBlock { get; set; }

    // OutBlock
    public t2831OutBlock? t2831OutBlock { get; set; }
}


/// <summary>
/// EUREX야간옵션선물시간대별체결조회: t2832
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX야간옵션선물시간대별체결조회", Attr = true, Headtype = "A")]
public class t2832 : TrBase
{
    // InBlock
    public t2832InBlock? t2832InBlock { get; set; }

    // OutBlock
    public t2832OutBlock? t2832OutBlock { get; set; }
    public t2832OutBlock1[]? t2832OutBlock1 { get; set; }
}


/// <summary>
/// EUREX야간옵션선물기간별추이: t2833
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX야간옵션선물기간별추이", Attr = true, Headtype = "A")]
public class t2833 : TrBase
{
    // InBlock
    public t2833InBlock? t2833InBlock { get; set; }

    // OutBlock
    public t2833OutBlock? t2833OutBlock { get; set; }
    public t2833OutBlock1[]? t2833OutBlock1 { get; set; }
}


/// <summary>
/// EUREX옵션선물시세전광판: t2835
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX옵션선물시세전광판", Attr = true, Headtype = "A")]
public class t2835 : TrBase
{
    // InBlock
    public t2835InBlock? t2835InBlock { get; set; }

    // OutBlock
    public t2835OutBlock? t2835OutBlock { get; set; }
    public t2835OutBlock1[]? t2835OutBlock1 { get; set; }
    public t2835OutBlock2[]? t2835OutBlock2 { get; set; }
}


/// <summary>
/// 뉴스본문: t3102
/// </summary>
[Path("/stock/investinfo", Description = "뉴스본문", Headtype = "A")]
public class t3102 : TrBase
{
    // InBlock
    public t3102InBlock? t3102InBlock { get; set; }

    // OutBlock
    public t3102OutBlock[]? t3102OutBlock { get; set; }
    public t3102OutBlock1[]? t3102OutBlock1 { get; set; }
    public t3102OutBlock2? t3102OutBlock2 { get; set; }
}


/// <summary>
/// 종목별증시일정: t3202
/// </summary>
[Path("/stock/investinfo", Description = "종목별증시일정", Attr = true, Headtype = "A")]
public class t3202 : TrBase
{
    // InBlock
    public t3202InBlock? t3202InBlock { get; set; }

    // OutBlock
    public t3202OutBlock[]? t3202OutBlock { get; set; }
}


/// <summary>
/// FNG_요약: t3320
/// </summary>
[Path("/stock/investinfo", Description = "FNG_요약", Attr = true, Headtype = "A")]
public class t3320 : TrBase
{
    // InBlock
    public t3320InBlock? t3320InBlock { get; set; }

    // OutBlock
    public t3320OutBlock? t3320OutBlock { get; set; }
    public t3320OutBlock1? t3320OutBlock1 { get; set; }
}


/// <summary>
/// 재무순위종합: t3341
/// </summary>
[Path("/stock/investinfo", Description = "재무순위종합", Attr = true, Headtype = "A")]
public class t3341 : TrBase
{
    // InBlock
    public t3341InBlock? t3341InBlock { get; set; }

    // OutBlock
    public t3341OutBlock? t3341OutBlock { get; set; }
    public t3341OutBlock1[]? t3341OutBlock1 { get; set; }
}


/// <summary>
/// 투자의견: t3401
/// </summary>
[Path("/stock/investinfo", Description = "투자의견", Attr = true, Headtype = "A")]
public class t3401 : TrBase
{
    // InBlock
    public t3401InBlock? t3401InBlock { get; set; }

    // OutBlock
    public t3401OutBlock? t3401OutBlock { get; set; }
    public t3401OutBlock1[]? t3401OutBlock1 { get; set; }
}


/// <summary>
/// 해외실시간지수: t3518
/// </summary>
[Path("/stock/investinfo", Description = "해외실시간지수", Attr = true, Headtype = "A")]
public class t3518 : TrBase
{
    // InBlock
    public t3518InBlock? t3518InBlock { get; set; }

    // OutBlock
    public t3518OutBlock? t3518OutBlock { get; set; }
    public t3518OutBlock1[]? t3518OutBlock1 { get; set; }
}


/// <summary>
/// 해외지수조회(API용): t3521
/// </summary>
[Path("/stock/investinfo", Description = "해외지수조회(API용)", Attr = true, Headtype = "A")]
public class t3521 : TrBase
{
    // InBlock
    public t3521InBlock? t3521InBlock { get; set; }

    // OutBlock
    public t3521OutBlock? t3521OutBlock { get; set; }
}


/// <summary>
/// 업종챠트(종합): t4203
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(종합)", Attr = true, Headtype = "A")]
public class t4203 : TrBase
{
    // InBlock
    public t4203InBlock? t4203InBlock { get; set; }

    // OutBlock
    public t4203OutBlock? t4203OutBlock { get; set; }
    public t4203OutBlock1[]? t4203OutBlock1 { get; set; }
}


/// <summary>
/// 주식선물마스터조회(API용): t8401
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물마스터조회(API용)", Headtype = "A")]
public class t8401 : TrBase
{
    // InBlock
    public t8401InBlock? t8401InBlock { get; set; }

    // OutBlock
    public t8401OutBlock[]? t8401OutBlock { get; set; }
}


/// <summary>
/// 주식선물현재가조회(API용): t8402
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물현재가조회(API용)", Attr = true, Headtype = "A")]
public class t8402 : TrBase
{
    // InBlock
    public t8402InBlock? t8402InBlock { get; set; }

    // OutBlock
    public t8402OutBlock? t8402OutBlock { get; set; }
}


/// <summary>
/// 주식선물호가조회(API용): t8403
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물호가조회(API용)", Attr = true, Headtype = "A")]
public class t8403 : TrBase
{
    // InBlock
    public t8403InBlock? t8403InBlock { get; set; }

    // OutBlock
    public t8403OutBlock? t8403OutBlock { get; set; }
}


/// <summary>
/// 주식선물시간대별체결조회(API용): t8404
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물시간대별체결조회(API용)", Attr = true, Headtype = "A")]
public class t8404 : TrBase
{
    // InBlock
    public t8404InBlock? t8404InBlock { get; set; }

    // OutBlock
    public t8404OutBlock? t8404OutBlock { get; set; }
    public t8404OutBlock1[]? t8404OutBlock1 { get; set; }
}


/// <summary>
/// 주식선물기간별주가(API용): t8405
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물기간별주가(API용)", Attr = true, Headtype = "A")]
public class t8405 : TrBase
{
    // InBlock
    public t8405InBlock? t8405InBlock { get; set; }

    // OutBlock
    public t8405OutBlock? t8405OutBlock { get; set; }
    public t8405OutBlock1[]? t8405OutBlock1 { get; set; }
}


/// <summary>
/// 주식선물틱분별체결조회(API용): t8406
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물틱분별체결조회(API용)", Attr = true, Headtype = "A")]
public class t8406 : TrBase
{
    // InBlock
    public t8406InBlock? t8406InBlock { get; set; }

    // OutBlock
    public t8406OutBlock1[]? t8406OutBlock1 { get; set; }
}


/// <summary>
/// API용주식멀티현재가조회: t8407
/// </summary>
[Path("/stock/market-data", Description = "API용주식멀티현재가조회", Attr = true, Headtype = "A")]
public class t8407 : TrBase
{
    // InBlock
    public t8407InBlock? t8407InBlock { get; set; }

    // OutBlock
    public t8407OutBlock1[]? t8407OutBlock1 { get; set; }
}


/// <summary>
/// API전용주식챠트(일주월년): t8410
/// </summary>
[Path("/stock/chart", Description = "API전용주식챠트(일주월년)", Attr = true, Headtype = "A")]
public class t8410 : TrBase
{
    // InBlock
    public t8410InBlock? t8410InBlock { get; set; }

    // OutBlock
    public t8410OutBlock? t8410OutBlock { get; set; }
    public t8410OutBlock1[]? t8410OutBlock1 { get; set; }
}


/// <summary>
/// 주식챠트(틱/n틱): t8411
/// </summary>
[Path("/stock/chart", Description = "주식챠트(틱/n틱)", Attr = true, Headtype = "A")]
public class t8411 : TrBase
{
    // InBlock
    public t8411InBlock? t8411InBlock { get; set; }

    // OutBlock
    public t8411OutBlock? t8411OutBlock { get; set; }
    public t8411OutBlock1[]? t8411OutBlock1 { get; set; }
}


/// <summary>
/// 주식챠트(N분): t8412
/// </summary>
[Path("/stock/chart", Description = "주식챠트(N분)", Attr = true, Headtype = "A")]
public class t8412 : TrBase
{
    // InBlock
    public t8412InBlock? t8412InBlock { get; set; }

    // OutBlock
    public t8412OutBlock? t8412OutBlock { get; set; }
    public t8412OutBlock1[]? t8412OutBlock1 { get; set; }
}


/// <summary>
/// 선물옵션차트(틱/n틱): t8414
/// </summary>
[Path("/futureoption/chart", Description = "선물옵션차트(틱/n틱)", Attr = true, Headtype = "A")]
public class t8414 : TrBase
{
    // InBlock
    public t8414InBlock? t8414InBlock { get; set; }

    // OutBlock
    public t8414OutBlock? t8414OutBlock { get; set; }
    public t8414OutBlock1[]? t8414OutBlock1 { get; set; }
}


/// <summary>
/// 선물/옵션챠트(N분): t8415
/// </summary>
[Path("/futureoption/chart", Description = "선물/옵션챠트(N분)", Attr = true, Headtype = "A")]
public class t8415 : TrBase
{
    // InBlock
    public t8415InBlock? t8415InBlock { get; set; }

    // OutBlock
    public t8415OutBlock? t8415OutBlock { get; set; }
    public t8415OutBlock1[]? t8415OutBlock1 { get; set; }
}


/// <summary>
/// 선물/옵션챠트(일주월): t8416
/// </summary>
[Path("/futureoption/chart", Description = "선물/옵션챠트(일주월)", Attr = true, Headtype = "A")]
public class t8416 : TrBase
{
    // InBlock
    public t8416InBlock? t8416InBlock { get; set; }

    // OutBlock
    public t8416OutBlock? t8416OutBlock { get; set; }
    public t8416OutBlock1[]? t8416OutBlock1 { get; set; }
}


/// <summary>
/// 업종차트(틱/n틱): t8417
/// </summary>
[Path("/indtp/chart", Description = "업종차트(틱/n틱)", Attr = true, Headtype = "A")]
public class t8417 : TrBase
{
    // InBlock
    public t8417InBlock? t8417InBlock { get; set; }

    // OutBlock
    public t8417OutBlock? t8417OutBlock { get; set; }
    public t8417OutBlock1[]? t8417OutBlock1 { get; set; }
}


/// <summary>
/// 업종챠트(N분): t8418
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(N분)", Attr = true, Headtype = "A")]
public class t8418 : TrBase
{
    // InBlock
    public t8418InBlock? t8418InBlock { get; set; }

    // OutBlock
    public t8418OutBlock? t8418OutBlock { get; set; }
    public t8418OutBlock1[]? t8418OutBlock1 { get; set; }
}


/// <summary>
/// 업종챠트(일주월): t8419
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(일주월)", Attr = true, Headtype = "A")]
public class t8419 : TrBase
{
    // InBlock
    public t8419InBlock? t8419InBlock { get; set; }

    // OutBlock
    public t8419OutBlock? t8419OutBlock { get; set; }
    public t8419OutBlock1[]? t8419OutBlock1 { get; set; }
}


/// <summary>
/// 전체업종: t8424
/// </summary>
[Path("/indtp/market-data", Description = "전체업종", Attr = true, Headtype = "A")]
public class t8424 : TrBase
{
    // InBlock
    public t8424InBlock? t8424InBlock { get; set; }

    // OutBlock
    public t8424OutBlock[]? t8424OutBlock { get; set; }
}


/// <summary>
/// 전체테마: t8425
/// </summary>
[Path("/stock/sector", Description = "전체테마", Attr = true, Headtype = "A")]
public class t8425 : TrBase
{
    // InBlock
    public t8425InBlock? t8425InBlock { get; set; }

    // OutBlock
    public t8425OutBlock[]? t8425OutBlock { get; set; }
}


/// <summary>
/// 상품선물마스터조회(API용): t8426
/// </summary>
[Path("/futureoption/market-data", Description = "상품선물마스터조회(API용)", Headtype = "A")]
public class t8426 : TrBase
{
    // InBlock
    public t8426InBlock? t8426InBlock { get; set; }

    // OutBlock
    public t8426OutBlock[]? t8426OutBlock { get; set; }
}


/// <summary>
/// 과거데이터시간대별조회: t8427
/// </summary>
[Path("/futureoption/market-data", Description = "과거데이터시간대별조회", Attr = true, Headtype = "A")]
public class t8427 : TrBase
{
    // InBlock
    public t8427InBlock? t8427InBlock { get; set; }

    // OutBlock
    public t8427OutBlock? t8427OutBlock { get; set; }
    public t8427OutBlock1[]? t8427OutBlock1 { get; set; }
}


/// <summary>
/// 증시주변자금추이: t8428
/// </summary>
[Path("/stock/investinfo", Description = "증시주변자금추이", Attr = true, Headtype = "A")]
public class t8428 : TrBase
{
    // InBlock
    public t8428InBlock? t8428InBlock { get; set; }

    // OutBlock
    public t8428OutBlock? t8428OutBlock { get; set; }
    public t8428OutBlock1[]? t8428OutBlock1 { get; set; }
}


/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트: t8429
/// </summary>
[Path("/futureoption/chart", Description = "EUREX야간옵션선물틱분별체결조회챠트", Attr = true, Headtype = "A")]
public class t8429 : TrBase
{
    // InBlock
    public t8429InBlock? t8429InBlock { get; set; }

    // OutBlock
    public t8429OutBlock1[]? t8429OutBlock1 { get; set; }
}


/// <summary>
/// 주식종목조회: t8430
/// </summary>
[Path("/stock/etc", Description = "주식종목조회", Headtype = "A")]
public class t8430 : TrBase
{
    // InBlock
    public t8430InBlock? t8430InBlock { get; set; }

    // OutBlock
    public t8430OutBlock[]? t8430OutBlock { get; set; }
}


/// <summary>
/// ELW종목조회: t8431
/// </summary>
[Path("/stock/elw", Description = "ELW종목조회", Headtype = "A")]
public class t8431 : TrBase
{
    // InBlock
    public t8431InBlock? t8431InBlock { get; set; }

    // OutBlock
    public t8431OutBlock[]? t8431OutBlock { get; set; }
}


/// <summary>
/// 지수선물마스터조회API용: t8432
/// </summary>
[Path("/futureoption/market-data", Description = "지수선물마스터조회API용", Headtype = "A")]
public class t8432 : TrBase
{
    // InBlock
    public t8432InBlock? t8432InBlock { get; set; }

    // OutBlock
    public t8432OutBlock[]? t8432OutBlock { get; set; }
}


/// <summary>
/// 지수옵션마스터조회API용: t8433
/// </summary>
[Path("/futureoption/market-data", Description = "지수옵션마스터조회API용", Headtype = "A")]
public class t8433 : TrBase
{
    // InBlock
    public t8433InBlock? t8433InBlock { get; set; }

    // OutBlock
    public t8433OutBlock[]? t8433OutBlock { get; set; }
}


/// <summary>
/// 선물/옵션멀티현재가조회: t8434
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션멀티현재가조회", Attr = true, Headtype = "A")]
public class t8434 : TrBase
{
    // InBlock
    public t8434InBlock? t8434InBlock { get; set; }

    // OutBlock
    public t8434OutBlock1[]? t8434OutBlock1 { get; set; }
}


/// <summary>
/// 파생종목마스터조회API용: t8435
/// </summary>
[Path("/futureoption/market-data", Description = "파생종목마스터조회API용", Headtype = "A")]
public class t8435 : TrBase
{
    // InBlock
    public t8435InBlock? t8435InBlock { get; set; }

    // OutBlock
    public t8435OutBlock[]? t8435OutBlock { get; set; }
}


/// <summary>
/// 주식종목조회 API용: t8436
/// </summary>
[Path("/stock/etc", Description = "주식종목조회 API용", Headtype = "A")]
public class t8436 : TrBase
{
    // InBlock
    public t8436InBlock? t8436InBlock { get; set; }

    // OutBlock
    public t8436OutBlock[]? t8436OutBlock { get; set; }
}


/// <summary>
/// CME/EUREX마스터조회(API용): t8437
/// </summary>
[Path("/futureoption/market-data", Description = "CME/EUREX마스터조회(API용)", Headtype = "A")]
public class t8437 : TrBase
{
    // InBlock
    public t8437InBlock? t8437InBlock { get; set; }

    // OutBlock
    public t8437OutBlock[]? t8437OutBlock { get; set; }
}


/// <summary>
/// 기초자산리스트조회: t9905
/// </summary>
[Path("/stock/elw", Description = "기초자산리스트조회", Headtype = "A")]
public class t9905 : TrBase
{
    // InBlock
    public t9905InBlock? t9905InBlock { get; set; }

    // OutBlock
    public t9905OutBlock1[]? t9905OutBlock1 { get; set; }
}


/// <summary>
/// 만기월조회: t9907
/// </summary>
[Path("/stock/elw", Description = "만기월조회", Headtype = "A")]
public class t9907 : TrBase
{
    // InBlock
    public t9907InBlock? t9907InBlock { get; set; }

    // OutBlock
    public t9907OutBlock1[]? t9907OutBlock1 { get; set; }
}


/// <summary>
/// ELW마스터조회API용: t9942
/// </summary>
[Path("/stock/elw", Description = "ELW마스터조회API용", Headtype = "A")]
public class t9942 : TrBase
{
    // InBlock
    public t9942InBlock? t9942InBlock { get; set; }

    // OutBlock
    public t9942OutBlock[]? t9942OutBlock { get; set; }
}


/// <summary>
/// 지수선물마스터조회API용: t9943
/// </summary>
[Path("/futureoption/market-data", Description = "지수선물마스터조회API용", Headtype = "A")]
public class t9943 : TrBase
{
    // InBlock
    public t9943InBlock? t9943InBlock { get; set; }

    // OutBlock
    public t9943OutBlock[]? t9943OutBlock { get; set; }
}


/// <summary>
/// 지수옵션마스터조회API용: t9944
/// </summary>
[Path("/futureoption/market-data", Description = "지수옵션마스터조회API용", Headtype = "A")]
public class t9944 : TrBase
{
    // InBlock
    public t9944InBlock? t9944InBlock { get; set; }

    // OutBlock
    public t9944OutBlock[]? t9944OutBlock { get; set; }
}


/// <summary>
/// 주식마스터조회API용-종목명40bytes: t9945
/// </summary>
[Path("/stock/market-data", Description = "주식마스터조회API용-종목명40bytes", Headtype = "A")]
public class t9945 : TrBase
{
    // InBlock
    public t9945InBlock? t9945InBlock { get; set; }

    // OutBlock
    public t9945OutBlock[]? t9945OutBlock { get; set; }
}


