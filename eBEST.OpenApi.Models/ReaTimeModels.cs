// [2023-12-17 오후 3:11:48]
// 이 파일은 BlockMaker에 의해 자동으로 만들어졌습니다.
// XingAPI res폴더의 TR파일에서 변환되었습니다.
using eBEST.OpenApi.Blocks;

namespace eBEST.OpenApi.Models;

/// <summary>
/// ETF호가잔량: B7_
/// </summary>
[Path("/websocket/stock", Description = "ETF호가잔량")]
public class B7_
{
    //요청
    public B7_InBlock? B7_InBlock { get; set; }

    //응답
    public B7_OutBlock? B7_OutBlock { get; set; }
}

/// <summary>
/// 시간대별투자자매매추이: BMT
/// </summary>
[Path("/websocket/investinfo", Description = "시간대별투자자매매추이")]
public class BMT
{
    //요청
    public BMTInBlock? BMTInBlock { get; set; }

    //응답
    public BMTOutBlock? BMTOutBlock { get; set; }
}

/// <summary>
/// 업종별투자자별매매현황: BM_
/// </summary>
[Path("/websocket/indtp", Description = "업종별투자자별매매현황")]
public class BM_
{
    //요청
    public BM_InBlock? BM_InBlock { get; set; }

    //응답
    public BM_OutBlock? BM_OutBlock { get; set; }
}

/// <summary>
/// 선물주문체결: C01
/// </summary>
[Path("/websocket/futureoption", Description = "선물주문체결", Key = "account")]
public class C01
{
    //요청
    public C01InBlock? C01InBlock { get; set; }

    //응답
    public C01OutBlock? C01OutBlock { get; set; }
}

/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
[Path("/websocket/futureoption", Description = "상품선물실시간상하한가(D0)")]
public class CD0
{
    //요청
    public CD0InBlock? CD0InBlock { get; set; }

    //응답
    public CD0OutBlock? CD0OutBlock { get; set; }
}

/// <summary>
/// 현물정보 USD 실시간: CUR
/// </summary>
[Path("/websocket/investinfo", Description = "현물정보 USD 실시간")]
public class CUR
{
    //요청
    public CURInBlock? CURInBlock { get; set; }

    //응답
    public CUROutBlock? CUROutBlock { get; set; }
}

/// <summary>
/// KOSPI시간외단일가호가잔량: DH1
/// </summary>
[Path("/websocket/stock", Description = "KOSPI시간외단일가호가잔량")]
public class DH1
{
    //요청
    public DH1InBlock? DH1InBlock { get; set; }

    //응답
    public DH1OutBlock? DH1OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ시간외단일가호가잔량: DHA
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ시간외단일가호가잔량")]
public class DHA
{
    //요청
    public DHAInBlock? DHAInBlock { get; set; }

    //응답
    public DHAOutBlock? DHAOutBlock { get; set; }
}

/// <summary>
/// KOSDAQ시간외단일가체결: DK3
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ시간외단일가체결")]
public class DK3
{
    //요청
    public DK3InBlock? DK3InBlock { get; set; }

    //응답
    public DK3OutBlock? DK3OutBlock { get; set; }
}

/// <summary>
/// KOSPI시간외단일가체결: DS3
/// </summary>
[Path("/websocket/stock", Description = "KOSPI시간외단일가체결")]
public class DS3
{
    //요청
    public DS3InBlock? DS3InBlock { get; set; }

    //응답
    public DS3OutBlock? DS3OutBlock { get; set; }
}

/// <summary>
/// 시간외단일가VI발동해제: DVI
/// </summary>
[Path("/websocket/stock", Description = "시간외단일가VI발동해제")]
public class DVI
{
    //요청
    public DVIInBlock? DVIInBlock { get; set; }

    //응답
    public DVIOutBlock? DVIOutBlock { get; set; }
}

/// <summary>
/// EUREX연계KP200지수옵션선물체결: EC0
/// </summary>
[Path("/websocket/futureoption", Description = "EUREX연계KP200지수옵션선물체결")]
public class EC0
{
    //요청
    public EC0InBlock? EC0InBlock { get; set; }

    //응답
    public EC0OutBlock? EC0OutBlock { get; set; }
}

/// <summary>
/// EUREX연계KP200지수옵션선물호가: EH0
/// </summary>
[Path("/websocket/futureoption", Description = "EUREX연계KP200지수옵션선물호가")]
public class EH0
{
    //요청
    public EH0InBlock? EH0InBlock { get; set; }

    //응답
    public EH0OutBlock? EH0OutBlock { get; set; }
}

/// <summary>
/// 뉴ELW투자지표민감도: ESN
/// </summary>
[Path("/websocket/elw", Description = "뉴ELW투자지표민감도")]
public class ESN
{
    //요청
    public ESNInBlock? ESNInBlock { get; set; }

    //응답
    public ESNOutBlock? ESNOutBlock { get; set; }
}

/// <summary>
/// EUX접수: EU0
/// </summary>
[Path("/websocket/futureoption", Description = "EUX접수", Key = "account")]
public class EU0
{
    //요청
    public EU0InBlock? EU0InBlock { get; set; }

    //응답
    public EU0OutBlock? EU0OutBlock { get; set; }
}

/// <summary>
/// EUX체결: EU1
/// </summary>
[Path("/websocket/futureoption", Description = "EUX체결", Key = "account")]
public class EU1
{
    //요청
    public EU1InBlock? EU1InBlock { get; set; }

    //응답
    public EU1OutBlock? EU1OutBlock { get; set; }
}

/// <summary>
/// EUX확인: EU2
/// </summary>
[Path("/websocket/futureoption", Description = "EUX확인", Key = "account")]
public class EU2
{
    //요청
    public EU2InBlock? EU2InBlock { get; set; }

    //응답
    public EU2OutBlock? EU2OutBlock { get; set; }
}

/// <summary>
/// KOSPI200선물체결(C0): FC0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물체결(C0)")]
public class FC0
{
    //요청
    public FC0InBlock? FC0InBlock { get; set; }

    //응답
    public FC0OutBlock? FC0OutBlock { get; set; }
}

/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물실시간상하한가(D0)")]
public class FD0
{
    //요청
    public FD0InBlock? FD0InBlock { get; set; }

    //응답
    public FD0OutBlock? FD0OutBlock { get; set; }
}

/// <summary>
/// KOSPI200선물호가(H0): FH0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물호가(H0)")]
public class FH0
{
    //요청
    public FH0InBlock? FH0InBlock { get; set; }

    //응답
    public FH0OutBlock? FH0OutBlock { get; set; }
}

/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물가격제한폭확대(X0)")]
public class FX0
{
    //요청
    public FX0InBlock? FX0InBlock { get; set; }

    //응답
    public FX0OutBlock? FX0OutBlock { get; set; }
}

/// <summary>
/// 선물주문정정취소: H01
/// </summary>
[Path("/websocket/futureoption", Description = "선물주문정정취소", Key = "account")]
public class H01
{
    //요청
    public H01InBlock? H01InBlock { get; set; }

    //응답
    public H01OutBlock? H01OutBlock { get; set; }
}

/// <summary>
/// KOSPI호가잔량: H1_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI호가잔량")]
public class H1_
{
    //요청
    public H1_InBlock? H1_InBlock { get; set; }

    //응답
    public H1_OutBlock? H1_OutBlock { get; set; }
}

/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI장전시간외호가잔량")]
public class H2_
{
    //요청
    public H2_InBlock? H2_InBlock { get; set; }

    //응답
    public H2_OutBlock? H2_OutBlock { get; set; }
}

/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
[Path("/websocket/elw", Description = "ELW장전시간외호가잔량")]
public class h2_
{
    //요청
    public h2_InBlock? h2_InBlock { get; set; }

    //응답
    public h2_OutBlock? h2_OutBlock { get; set; }
}

/// <summary>
/// ELW호가잔량: h3_
/// </summary>
[Path("/websocket/elw", Description = "ELW호가잔량")]
public class h3_
{
    //요청
    public h3_InBlock? h3_InBlock { get; set; }

    //응답
    public h3_OutBlock? h3_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ호가잔량: HA_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ호가잔량")]
public class HA_
{
    //요청
    public HA_InBlock? HA_InBlock { get; set; }

    //응답
    public HA_OutBlock? HA_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ장전시간외호가잔량")]
public class HB_
{
    //요청
    public HB_InBlock? HB_InBlock { get; set; }

    //응답
    public HB_OutBlock? HB_OutBlock { get; set; }
}

/// <summary>
/// 코스피ETF종목실시간NAV: I5_
/// </summary>
[Path("/websocket/stock", Description = "코스피ETF종목실시간NAV")]
public class I5_
{
    //요청
    public I5_InBlock? I5_InBlock { get; set; }

    //응답
    public I5_OutBlock? I5_OutBlock { get; set; }
}

/// <summary>
/// 지수: IJ_
/// </summary>
[Path("/websocket/stock", Description = "지수")]
public class IJ_
{
    //요청
    public IJ_InBlock? IJ_InBlock { get; set; }

    //응답
    public IJ_OutBlock? IJ_OutBlock { get; set; }
}

/// <summary>
/// 주식선물체결: JC0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물체결")]
public class JC0
{
    //요청
    public JC0InBlock? JC0InBlock { get; set; }

    //응답
    public JC0OutBlock? JC0OutBlock { get; set; }
}

/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물실시간상하한가")]
public class JD0
{
    //요청
    public JD0InBlock? JD0InBlock { get; set; }

    //응답
    public JD0OutBlock? JD0OutBlock { get; set; }
}

/// <summary>
/// 주식선물호가: JH0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물호가")]
public class JH0
{
    //요청
    public JH0InBlock? JH0InBlock { get; set; }

    //응답
    public JH0OutBlock? JH0OutBlock { get; set; }
}

/// <summary>
/// 장운영정보: JIF
/// </summary>
[Path("/websocket/etc", Description = "장운영정보")]
public class JIF
{
    //요청
    public JIFInBlock? JIFInBlock { get; set; }

    //응답
    public JIFOutBlock? JIFOutBlock { get; set; }
}

/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물가격제한폭확대")]
public class JX0
{
    //요청
    public JX0InBlock? JX0InBlock { get; set; }

    //응답
    public JX0OutBlock? JX0OutBlock { get; set; }
}

/// <summary>
/// KOSPI거래원: K1_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI거래원")]
public class K1_
{
    //요청
    public K1_InBlock? K1_InBlock { get; set; }

    //응답
    public K1_OutBlock? K1_OutBlock { get; set; }
}

/// <summary>
/// ELW거래원: k1_
/// </summary>
[Path("/websocket/elw", Description = "ELW거래원")]
public class k1_
{
    //요청
    public k1_InBlock? k1_InBlock { get; set; }

    //응답
    public k1_OutBlock? k1_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ체결: K3_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ체결")]
public class K3_
{
    //요청
    public K3_InBlock? K3_InBlock { get; set; }

    //응답
    public K3_OutBlock? K3_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ프로그램매매종목별: KH_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ프로그램매매종목별")]
public class KH_
{
    //요청
    public KH_InBlock? KH_InBlock { get; set; }

    //응답
    public KH_OutBlock? KH_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ프로그램매매전체집계: KM_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ프로그램매매전체집계")]
public class KM_
{
    //요청
    public KM_InBlock? KM_InBlock { get; set; }

    //응답
    public KM_OutBlock? KM_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ우선호가")]
public class KS_
{
    //요청
    public KS_InBlock? KS_InBlock { get; set; }

    //응답
    public KS_OutBlock? KS_OutBlock { get; set; }
}

/// <summary>
/// US지수: MK2
/// </summary>
[Path("/websocket/investinfo", Description = "US지수")]
public class MK2
{
    //요청
    public MK2InBlock? MK2InBlock { get; set; }

    //응답
    public MK2OutBlock? MK2OutBlock { get; set; }
}

/// <summary>
/// 실시간 뉴스 제목 패킷: NWS
/// </summary>
[Path("/websocket/etc", Description = "실시간 뉴스 제목 패킷")]
public class NWS
{
    //요청
    public NWSInBlock? NWSInBlock { get; set; }

    //응답
    public NWSOutBlock? NWSOutBlock { get; set; }
}

/// <summary>
/// 선물접수: O01
/// </summary>
[Path("/websocket/futureoption", Description = "선물접수", Key = "account")]
public class O01
{
    //요청
    public O01InBlock? O01InBlock { get; set; }

    //응답
    public O01OutBlock? O01OutBlock { get; set; }
}

/// <summary>
/// KOSPI200옵션체결(C0): OC0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션체결(C0)")]
public class OC0
{
    //요청
    public OC0InBlock? OC0InBlock { get; set; }

    //응답
    public OC0OutBlock? OC0OutBlock { get; set; }
}

/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션실시간상하한가(D0)")]
public class OD0
{
    //요청
    public OD0InBlock? OD0InBlock { get; set; }

    //응답
    public OD0OutBlock? OD0OutBlock { get; set; }
}

/// <summary>
/// KOSPI200옵션호가(H0): OH0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션호가(H0)")]
public class OH0
{
    //요청
    public OH0InBlock? OH0InBlock { get; set; }

    //응답
    public OH0OutBlock? OH0OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ거래원: OK_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ거래원")]
public class OK_
{
    //요청
    public OK_InBlock? OK_InBlock { get; set; }

    //응답
    public OK_OutBlock? OK_OutBlock { get; set; }
}

/// <summary>
/// KOSPI200옵션민감도(MG): OMG
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션민감도(MG)")]
public class OMG
{
    //요청
    public OMGInBlock? OMGInBlock { get; set; }

    //응답
    public OMGOutBlock? OMGOutBlock { get; set; }
}

/// <summary>
/// 해외선물 현재가체결: OVC
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물 현재가체결")]
public class OVC
{
    //요청
    public OVCInBlock? OVCInBlock { get; set; }

    //응답
    public OVCOutBlock? OVCOutBlock { get; set; }
}

/// <summary>
/// 해외선물 호가: OVH
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물 호가")]
public class OVH
{
    //요청
    public OVHInBlock? OVHInBlock { get; set; }

    //응답
    public OVHOutBlock? OVHOutBlock { get; set; }
}

/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션가격제한폭확대(X0)")]
public class OX0
{
    //요청
    public OX0InBlock? OX0InBlock { get; set; }

    //응답
    public OX0OutBlock? OX0OutBlock { get; set; }
}

/// <summary>
/// KOSPI프로그램매매종목별: PH_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI프로그램매매종목별")]
public class PH_
{
    //요청
    public PH_InBlock? PH_InBlock { get; set; }

    //응답
    public PH_OutBlock? PH_OutBlock { get; set; }
}

/// <summary>
/// KOSPI프로그램매매전체집계: PM_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI프로그램매매전체집계")]
public class PM_
{
    //요청
    public PM_InBlock? PM_InBlock { get; set; }

    //응답
    public PM_OutBlock? PM_OutBlock { get; set; }
}

/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI우선호가")]
public class S2_
{
    //요청
    public S2_InBlock? S2_InBlock { get; set; }

    //응답
    public S2_OutBlock? S2_OutBlock { get; set; }
}

/// <summary>
/// ELW우선호가: s2_
/// </summary>
[Path("/websocket/elw", Description = "ELW우선호가")]
public class s2_
{
    //요청
    public s2_InBlock? s2_InBlock { get; set; }

    //응답
    public s2_OutBlock? s2_OutBlock { get; set; }
}

/// <summary>
/// KOSPI체결: S3_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI체결")]
public class S3_
{
    //요청
    public S3_InBlock? S3_InBlock { get; set; }

    //응답
    public S3_OutBlock? S3_OutBlock { get; set; }
}

/// <summary>
/// ELW체결: s3_
/// </summary>
[Path("/websocket/elw", Description = "ELW체결")]
public class s3_
{
    //요청
    public s3_InBlock? s3_InBlock { get; set; }

    //응답
    public s3_OutBlock? s3_OutBlock { get; set; }
}

/// <summary>
/// KOSPI기세: S4_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI기세")]
public class S4_
{
    //요청
    public S4_InBlock? S4_InBlock { get; set; }

    //응답
    public S4_OutBlock? S4_OutBlock { get; set; }
}

/// <summary>
/// ELW기세: s4_
/// </summary>
[Path("/websocket/elw", Description = "ELW기세")]
public class s4_
{
    //요청
    public s4_InBlock? s4_InBlock { get; set; }

    //응답
    public s4_OutBlock? s4_OutBlock { get; set; }
}

/// <summary>
/// 주식주문접수: SC0
/// </summary>
[Path("/websocket/stock", Description = "주식주문접수", Key = "account")]
public class SC0
{
    //요청
    public SC0InBlock? SC0InBlock { get; set; }

    //응답
    public SC0OutBlock? SC0OutBlock { get; set; }
}

/// <summary>
/// 주식주문체결: SC1
/// </summary>
[Path("/websocket/stock", Description = "주식주문체결", Key = "account")]
public class SC1
{
    //요청
    public SC1InBlock? SC1InBlock { get; set; }

    //응답
    public SC1OutBlock? SC1OutBlock { get; set; }
}

/// <summary>
/// 주식주문정정: SC2
/// </summary>
[Path("/websocket/stock", Description = "주식주문정정", Key = "account")]
public class SC2
{
    //요청
    public SC2InBlock? SC2InBlock { get; set; }

    //응답
    public SC2OutBlock? SC2OutBlock { get; set; }
}

/// <summary>
/// 주식주문취소: SC3
/// </summary>
[Path("/websocket/stock", Description = "주식주문취소", Key = "account")]
public class SC3
{
    //요청
    public SC3InBlock? SC3InBlock { get; set; }

    //응답
    public SC3OutBlock? SC3OutBlock { get; set; }
}

/// <summary>
/// 주식주문거부: SC4
/// </summary>
[Path("/websocket/stock", Description = "주식주문거부", Key = "account")]
public class SC4
{
    //요청
    public SC4InBlock? SC4InBlock { get; set; }

    //응답
    public SC4OutBlock? SC4OutBlock { get; set; }
}

/// <summary>
/// 상/하한가근접진입: SHC
/// </summary>
[Path("/websocket/stock", Description = "상/하한가근접진입")]
public class SHC
{
    //요청
    public SHCInBlock? SHCInBlock { get; set; }

    //응답
    public SHCOutBlock? SHCOutBlock { get; set; }
}

/// <summary>
/// 상/하한가근접이탈: SHD
/// </summary>
[Path("/websocket/stock", Description = "상/하한가근접이탈")]
public class SHD
{
    //요청
    public SHDInBlock? SHDInBlock { get; set; }

    //응답
    public SHDOutBlock? SHDOutBlock { get; set; }
}

/// <summary>
/// 상/하한가진입: SHI
/// </summary>
[Path("/websocket/stock", Description = "상/하한가진입")]
public class SHI
{
    //요청
    public SHIInBlock? SHIInBlock { get; set; }

    //응답
    public SHIOutBlock? SHIOutBlock { get; set; }
}

/// <summary>
/// 상/하한가이탈: SHO
/// </summary>
[Path("/websocket/stock", Description = "상/하한가이탈")]
public class SHO
{
    //요청
    public SHOInBlock? SHOInBlock { get; set; }

    //응답
    public SHOOutBlock? SHOOutBlock { get; set; }
}

/// <summary>
/// 해외선물주문: TC1
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물주문", Key = "account")]
public class TC1
{
    //요청
    public TC1InBlock? TC1InBlock { get; set; }

    //응답
    public TC1OutBlock? TC1OutBlock { get; set; }
}

/// <summary>
/// 해외선물응답: TC2
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물응답", Key = "account")]
public class TC2
{
    //요청
    public TC2InBlock? TC2InBlock { get; set; }

    //응답
    public TC2OutBlock? TC2OutBlock { get; set; }
}

/// <summary>
/// 해외선물체결: TC3
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물체결", Key = "account")]
public class TC3
{
    //요청
    public TC3InBlock? TC3InBlock { get; set; }

    //응답
    public TC3OutBlock? TC3OutBlock { get; set; }
}

/// <summary>
/// VI발동해제: VI_
/// </summary>
[Path("/websocket/stock", Description = "VI발동해제")]
public class VI_
{
    //요청
    public VI_InBlock? VI_InBlock { get; set; }

    //응답
    public VI_OutBlock? VI_OutBlock { get; set; }
}

/// <summary>
/// 해외옵션 현재가체결: WOC
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외옵션 현재가체결")]
public class WOC
{
    //요청
    public WOCInBlock? WOCInBlock { get; set; }

    //응답
    public WOCOutBlock? WOCOutBlock { get; set; }
}

/// <summary>
/// 해외옵션 호가: WOH
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외옵션 호가")]
public class WOH
{
    //요청
    public WOHInBlock? WOHInBlock { get; set; }

    //응답
    public WOHOutBlock? WOHOutBlock { get; set; }
}

/// <summary>
/// 상품선물예상체결: YC3
/// </summary>
[Path("/websocket/futureoption", Description = "상품선물예상체결")]
public class YC3
{
    //요청
    public YC3InBlock? YC3InBlock { get; set; }

    //응답
    public YC3OutBlock? YC3OutBlock { get; set; }
}

/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
[Path("/websocket/futureoption", Description = "지수선물예상체결")]
public class YFC
{
    //요청
    public YFCInBlock? YFCInBlock { get; set; }

    //응답
    public YFCOutBlock? YFCOutBlock { get; set; }
}

/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물예상체결")]
public class YJC
{
    //요청
    public YJCInBlock? YJCInBlock { get; set; }

    //응답
    public YJCOutBlock? YJCOutBlock { get; set; }
}

/// <summary>
/// 예상지수: YJ_
/// </summary>
[Path("/websocket/stock", Description = "예상지수")]
public class YJ_
{
    //요청
    public YJ_InBlock? YJ_InBlock { get; set; }

    //응답
    public YJ_OutBlock? YJ_OutBlock { get; set; }
}

/// <summary>
/// KOSDAQ예상체결: YK3
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ예상체결")]
public class YK3
{
    //요청
    public YK3InBlock? YK3InBlock { get; set; }

    //응답
    public YK3OutBlock? YK3OutBlock { get; set; }
}

/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
[Path("/websocket/futureoption", Description = "지수옵션예상체결")]
public class YOC
{
    //요청
    public YOCInBlock? YOCInBlock { get; set; }

    //응답
    public YOCOutBlock? YOCOutBlock { get; set; }
}

/// <summary>
/// KOSPI예상체결: YS3
/// </summary>
[Path("/websocket/stock", Description = "KOSPI예상체결")]
public class YS3
{
    //요청
    public YS3InBlock? YS3InBlock { get; set; }

    //응답
    public YS3OutBlock? YS3OutBlock { get; set; }
}

/// <summary>
/// ELW예상체결: Ys3
/// </summary>
[Path("/websocket/elw", Description = "ELW예상체결")]
public class Ys3
{
    //요청
    public Ys3InBlock? Ys3InBlock { get; set; }

    //응답
    public Ys3OutBlock? Ys3OutBlock { get; set; }
}

