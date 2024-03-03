// [2024-02-13 오후 9:25:02]
// 이 파일은 ResToModel 에 의해 자동으로 만들어졌습니다.
// XingAPI Res폴더의 .res 파일에서 변환되었습니다.
namespace eBEST.OpenApi.Models;

/// <summary>
/// ETF호가잔량: B7_
/// </summary>
[Path("/websocket/stock", Description = "ETF호가잔량")]
public class B7_ : TrBase
{
    // InBlock
    public B7_InBlock? B7_InBlock { get; set; }

    // OutBlock
    public B7_OutBlock? B7_OutBlock { get; set; }
}


/// <summary>
/// 시간대별투자자매매추이: BMT
/// </summary>
[Path("/websocket/investinfo", Description = "시간대별투자자매매추이")]
public class BMT : TrBase
{
    // InBlock
    public BMTInBlock? BMTInBlock { get; set; }

    // OutBlock
    public BMTOutBlock? BMTOutBlock { get; set; }
}


/// <summary>
/// 업종별투자자별매매현황: BM_
/// </summary>
[Path("/websocket/indtp", Description = "업종별투자자별매매현황")]
public class BM_ : TrBase
{
    // InBlock
    public BM_InBlock? BM_InBlock { get; set; }

    // OutBlock
    public BM_OutBlock? BM_OutBlock { get; set; }
}


/// <summary>
/// 선물주문체결: C01
/// </summary>
[Path("/websocket/futureoption", Description = "선물주문체결", Key = "account")]
public class C01 : TrBase
{
    // InBlock
    public C01InBlock? C01InBlock { get; set; }

    // OutBlock
    public C01OutBlock? C01OutBlock { get; set; }
}


/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
[Path("/websocket/futureoption", Description = "상품선물실시간상하한가(D0)")]
public class CD0 : TrBase
{
    // InBlock
    public CD0InBlock? CD0InBlock { get; set; }

    // OutBlock
    public CD0OutBlock? CD0OutBlock { get; set; }
}


/// <summary>
/// 현물정보 USD 실시간: CUR
/// </summary>
[Path("/websocket/investinfo", Description = "현물정보 USD 실시간")]
public class CUR : TrBase
{
    // InBlock
    public CURInBlock? CURInBlock { get; set; }

    // OutBlock
    public CUROutBlock? CUROutBlock { get; set; }
}


/// <summary>
/// KOSPI시간외단일가호가잔량: DH1
/// </summary>
[Path("/websocket/stock", Description = "KOSPI시간외단일가호가잔량")]
public class DH1 : TrBase
{
    // InBlock
    public DH1InBlock? DH1InBlock { get; set; }

    // OutBlock
    public DH1OutBlock? DH1OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ시간외단일가호가잔량: DHA
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ시간외단일가호가잔량")]
public class DHA : TrBase
{
    // InBlock
    public DHAInBlock? DHAInBlock { get; set; }

    // OutBlock
    public DHAOutBlock? DHAOutBlock { get; set; }
}


/// <summary>
/// KOSDAQ시간외단일가체결: DK3
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ시간외단일가체결")]
public class DK3 : TrBase
{
    // InBlock
    public DK3InBlock? DK3InBlock { get; set; }

    // OutBlock
    public DK3OutBlock? DK3OutBlock { get; set; }
}


/// <summary>
/// KOSPI시간외단일가체결: DS3
/// </summary>
[Path("/websocket/stock", Description = "KOSPI시간외단일가체결")]
public class DS3 : TrBase
{
    // InBlock
    public DS3InBlock? DS3InBlock { get; set; }

    // OutBlock
    public DS3OutBlock? DS3OutBlock { get; set; }
}


/// <summary>
/// 시간외단일가VI발동해제: DVI
/// </summary>
[Path("/websocket/stock", Description = "시간외단일가VI발동해제")]
public class DVI : TrBase
{
    // InBlock
    public DVIInBlock? DVIInBlock { get; set; }

    // OutBlock
    public DVIOutBlock? DVIOutBlock { get; set; }
}


/// <summary>
/// EUREX연계KP200지수옵션선물체결: EC0
/// </summary>
[Path("/websocket/futureoption", Description = "EUREX연계KP200지수옵션선물체결")]
public class EC0 : TrBase
{
    // InBlock
    public EC0InBlock? EC0InBlock { get; set; }

    // OutBlock
    public EC0OutBlock? EC0OutBlock { get; set; }
}


/// <summary>
/// EUREX연계KP200지수옵션선물호가: EH0
/// </summary>
[Path("/websocket/futureoption", Description = "EUREX연계KP200지수옵션선물호가")]
public class EH0 : TrBase
{
    // InBlock
    public EH0InBlock? EH0InBlock { get; set; }

    // OutBlock
    public EH0OutBlock? EH0OutBlock { get; set; }
}


/// <summary>
/// 뉴ELW투자지표민감도: ESN
/// </summary>
[Path("/websocket/stock", Description = "뉴ELW투자지표민감도")]
public class ESN : TrBase
{
    // InBlock
    public ESNInBlock? ESNInBlock { get; set; }

    // OutBlock
    public ESNOutBlock? ESNOutBlock { get; set; }
}


/// <summary>
/// EUX접수: EU0
/// </summary>
[Path("/websocket/futureoption", Description = "EUX접수", Key = "account")]
public class EU0 : TrBase
{
    // InBlock
    public EU0InBlock? EU0InBlock { get; set; }

    // OutBlock
    public EU0OutBlock? EU0OutBlock { get; set; }
}


/// <summary>
/// EUX체결: EU1
/// </summary>
[Path("/websocket/futureoption", Description = "EUX체결", Key = "account")]
public class EU1 : TrBase
{
    // InBlock
    public EU1InBlock? EU1InBlock { get; set; }

    // OutBlock
    public EU1OutBlock? EU1OutBlock { get; set; }
}


/// <summary>
/// EUX확인: EU2
/// </summary>
[Path("/websocket/futureoption", Description = "EUX확인", Key = "account")]
public class EU2 : TrBase
{
    // InBlock
    public EU2InBlock? EU2InBlock { get; set; }

    // OutBlock
    public EU2OutBlock? EU2OutBlock { get; set; }
}


/// <summary>
/// KOSPI200선물체결(C0): FC0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물체결(C0)")]
public class FC0 : TrBase
{
    // InBlock
    public FC0InBlock? FC0InBlock { get; set; }

    // OutBlock
    public FC0OutBlock? FC0OutBlock { get; set; }
}


/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물실시간상하한가(D0)")]
public class FD0 : TrBase
{
    // InBlock
    public FD0InBlock? FD0InBlock { get; set; }

    // OutBlock
    public FD0OutBlock? FD0OutBlock { get; set; }
}


/// <summary>
/// KOSPI200선물호가(H0): FH0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물호가(H0)")]
public class FH0 : TrBase
{
    // InBlock
    public FH0InBlock? FH0InBlock { get; set; }

    // OutBlock
    public FH0OutBlock? FH0OutBlock { get; set; }
}


/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200선물가격제한폭확대(X0)")]
public class FX0 : TrBase
{
    // InBlock
    public FX0InBlock? FX0InBlock { get; set; }

    // OutBlock
    public FX0OutBlock? FX0OutBlock { get; set; }
}


/// <summary>
/// 선물주문정정취소: H01
/// </summary>
[Path("/websocket/futureoption", Description = "선물주문정정취소", Key = "account")]
public class H01 : TrBase
{
    // InBlock
    public H01InBlock? H01InBlock { get; set; }

    // OutBlock
    public H01OutBlock? H01OutBlock { get; set; }
}


/// <summary>
/// KOSPI호가잔량: H1_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI호가잔량")]
public class H1_ : TrBase
{
    // InBlock
    public H1_InBlock? H1_InBlock { get; set; }

    // OutBlock
    public H1_OutBlock? H1_OutBlock { get; set; }
}


/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI장전시간외호가잔량")]
public class H2_ : TrBase
{
    // InBlock
    public H2_InBlock? H2_InBlock { get; set; }

    // OutBlock
    public H2_OutBlock? H2_OutBlock { get; set; }
}


/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
[Path("/websocket/stock", Description = "ELW장전시간외호가잔량")]
public class h2_ : TrBase
{
    // InBlock
    public h2_InBlock? h2_InBlock { get; set; }

    // OutBlock
    public h2_OutBlock? h2_OutBlock { get; set; }
}


/// <summary>
/// ELW호가잔량: h3_
/// </summary>
[Path("/websocket/stock", Description = "ELW호가잔량")]
public class h3_ : TrBase
{
    // InBlock
    public h3_InBlock? h3_InBlock { get; set; }

    // OutBlock
    public h3_OutBlock? h3_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ호가잔량: HA_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ호가잔량")]
public class HA_ : TrBase
{
    // InBlock
    public HA_InBlock? HA_InBlock { get; set; }

    // OutBlock
    public HA_OutBlock? HA_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ장전시간외호가잔량")]
public class HB_ : TrBase
{
    // InBlock
    public HB_InBlock? HB_InBlock { get; set; }

    // OutBlock
    public HB_OutBlock? HB_OutBlock { get; set; }
}


/// <summary>
/// 코스피ETF종목실시간NAV: I5_
/// </summary>
[Path("/websocket/stock", Description = "코스피ETF종목실시간NAV")]
public class I5_ : TrBase
{
    // InBlock
    public I5_InBlock? I5_InBlock { get; set; }

    // OutBlock
    public I5_OutBlock? I5_OutBlock { get; set; }
}


/// <summary>
/// 지수: IJ_
/// </summary>
[Path("/websocket/stock", Description = "지수")]
public class IJ_ : TrBase
{
    // InBlock
    public IJ_InBlock? IJ_InBlock { get; set; }

    // OutBlock
    public IJ_OutBlock? IJ_OutBlock { get; set; }
}


/// <summary>
/// 주식선물체결: JC0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물체결")]
public class JC0 : TrBase
{
    // InBlock
    public JC0InBlock? JC0InBlock { get; set; }

    // OutBlock
    public JC0OutBlock? JC0OutBlock { get; set; }
}


/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물실시간상하한가")]
public class JD0 : TrBase
{
    // InBlock
    public JD0InBlock? JD0InBlock { get; set; }

    // OutBlock
    public JD0OutBlock? JD0OutBlock { get; set; }
}


/// <summary>
/// 주식선물호가: JH0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물호가")]
public class JH0 : TrBase
{
    // InBlock
    public JH0InBlock? JH0InBlock { get; set; }

    // OutBlock
    public JH0OutBlock? JH0OutBlock { get; set; }
}


/// <summary>
/// 장운영정보: JIF
/// </summary>
[Path("/websocket/etc", Description = "장운영정보")]
public class JIF : TrBase
{
    // InBlock
    public JIFInBlock? JIFInBlock { get; set; }

    // OutBlock
    public JIFOutBlock? JIFOutBlock { get; set; }
}


/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물가격제한폭확대")]
public class JX0 : TrBase
{
    // InBlock
    public JX0InBlock? JX0InBlock { get; set; }

    // OutBlock
    public JX0OutBlock? JX0OutBlock { get; set; }
}


/// <summary>
/// KOSPI거래원: K1_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI거래원")]
public class K1_ : TrBase
{
    // InBlock
    public K1_InBlock? K1_InBlock { get; set; }

    // OutBlock
    public K1_OutBlock? K1_OutBlock { get; set; }
}


/// <summary>
/// ELW거래원: k1_
/// </summary>
[Path("/websocket/stock", Description = "ELW거래원")]
public class k1_ : TrBase
{
    // InBlock
    public k1_InBlock? k1_InBlock { get; set; }

    // OutBlock
    public k1_OutBlock? k1_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ체결: K3_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ체결")]
public class K3_ : TrBase
{
    // InBlock
    public K3_InBlock? K3_InBlock { get; set; }

    // OutBlock
    public K3_OutBlock? K3_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ프로그램매매종목별: KH_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ프로그램매매종목별")]
public class KH_ : TrBase
{
    // InBlock
    public KH_InBlock? KH_InBlock { get; set; }

    // OutBlock
    public KH_OutBlock? KH_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ프로그램매매전체집계: KM_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ프로그램매매전체집계")]
public class KM_ : TrBase
{
    // InBlock
    public KM_InBlock? KM_InBlock { get; set; }

    // OutBlock
    public KM_OutBlock? KM_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ우선호가")]
public class KS_ : TrBase
{
    // InBlock
    public KS_InBlock? KS_InBlock { get; set; }

    // OutBlock
    public KS_OutBlock? KS_OutBlock { get; set; }
}


/// <summary>
/// US지수: MK2
/// </summary>
[Path("/websocket/investinfo", Description = "US지수")]
public class MK2 : TrBase
{
    // InBlock
    public MK2InBlock? MK2InBlock { get; set; }

    // OutBlock
    public MK2OutBlock? MK2OutBlock { get; set; }
}


/// <summary>
/// 실시간 뉴스 제목 패킷: NWS
/// </summary>
[Path("/websocket/etc", Description = "실시간 뉴스 제목 패킷")]
public class NWS : TrBase
{
    // InBlock
    public NWSInBlock? NWSInBlock { get; set; }

    // OutBlock
    public NWSOutBlock? NWSOutBlock { get; set; }
}


/// <summary>
/// 선물접수: O01
/// </summary>
[Path("/websocket/futureoption", Description = "선물접수", Key = "account")]
public class O01 : TrBase
{
    // InBlock
    public O01InBlock? O01InBlock { get; set; }

    // OutBlock
    public O01OutBlock? O01OutBlock { get; set; }
}


/// <summary>
/// KOSPI200옵션체결(C0): OC0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션체결(C0)")]
public class OC0 : TrBase
{
    // InBlock
    public OC0InBlock? OC0InBlock { get; set; }

    // OutBlock
    public OC0OutBlock? OC0OutBlock { get; set; }
}


/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션실시간상하한가(D0)")]
public class OD0 : TrBase
{
    // InBlock
    public OD0InBlock? OD0InBlock { get; set; }

    // OutBlock
    public OD0OutBlock? OD0OutBlock { get; set; }
}


/// <summary>
/// KOSPI200옵션호가(H0): OH0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션호가(H0)")]
public class OH0 : TrBase
{
    // InBlock
    public OH0InBlock? OH0InBlock { get; set; }

    // OutBlock
    public OH0OutBlock? OH0OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ거래원: OK_
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ거래원")]
public class OK_ : TrBase
{
    // InBlock
    public OK_InBlock? OK_InBlock { get; set; }

    // OutBlock
    public OK_OutBlock? OK_OutBlock { get; set; }
}


/// <summary>
/// KOSPI200옵션민감도(MG): OMG
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션민감도(MG)")]
public class OMG : TrBase
{
    // InBlock
    public OMGInBlock? OMGInBlock { get; set; }

    // OutBlock
    public OMGOutBlock? OMGOutBlock { get; set; }
}


/// <summary>
/// 해외선물 현재가체결: OVC
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물 현재가체결")]
public class OVC : TrBase
{
    // InBlock
    public OVCInBlock? OVCInBlock { get; set; }

    // OutBlock
    public OVCOutBlock? OVCOutBlock { get; set; }
}


/// <summary>
/// 해외선물 호가: OVH
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물 호가")]
public class OVH : TrBase
{
    // InBlock
    public OVHInBlock? OVHInBlock { get; set; }

    // OutBlock
    public OVHOutBlock? OVHOutBlock { get; set; }
}


/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
[Path("/websocket/futureoption", Description = "KOSPI200옵션가격제한폭확대(X0)")]
public class OX0 : TrBase
{
    // InBlock
    public OX0InBlock? OX0InBlock { get; set; }

    // OutBlock
    public OX0OutBlock? OX0OutBlock { get; set; }
}


/// <summary>
/// KOSPI프로그램매매종목별: PH_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI프로그램매매종목별")]
public class PH_ : TrBase
{
    // InBlock
    public PH_InBlock? PH_InBlock { get; set; }

    // OutBlock
    public PH_OutBlock? PH_OutBlock { get; set; }
}


/// <summary>
/// KOSPI프로그램매매전체집계: PM_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI프로그램매매전체집계")]
public class PM_ : TrBase
{
    // InBlock
    public PM_InBlock? PM_InBlock { get; set; }

    // OutBlock
    public PM_OutBlock? PM_OutBlock { get; set; }
}


/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI우선호가")]
public class S2_ : TrBase
{
    // InBlock
    public S2_InBlock? S2_InBlock { get; set; }

    // OutBlock
    public S2_OutBlock? S2_OutBlock { get; set; }
}


/// <summary>
/// ELW우선호가: s2_
/// </summary>
[Path("/websocket/stock", Description = "ELW우선호가")]
public class s2_ : TrBase
{
    // InBlock
    public s2_InBlock? s2_InBlock { get; set; }

    // OutBlock
    public s2_OutBlock? s2_OutBlock { get; set; }
}


/// <summary>
/// KOSPI체결: S3_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI체결")]
public class S3_ : TrBase
{
    // InBlock
    public S3_InBlock? S3_InBlock { get; set; }

    // OutBlock
    public S3_OutBlock? S3_OutBlock { get; set; }
}


/// <summary>
/// ELW체결: s3_
/// </summary>
[Path("/websocket/stock", Description = "ELW체결")]
public class s3_ : TrBase
{
    // InBlock
    public s3_InBlock? s3_InBlock { get; set; }

    // OutBlock
    public s3_OutBlock? s3_OutBlock { get; set; }
}


/// <summary>
/// KOSPI기세: S4_
/// </summary>
[Path("/websocket/stock", Description = "KOSPI기세")]
public class S4_ : TrBase
{
    // InBlock
    public S4_InBlock? S4_InBlock { get; set; }

    // OutBlock
    public S4_OutBlock? S4_OutBlock { get; set; }
}


/// <summary>
/// ELW기세: s4_
/// </summary>
[Path("/websocket/stock", Description = "ELW기세")]
public class s4_ : TrBase
{
    // InBlock
    public s4_InBlock? s4_InBlock { get; set; }

    // OutBlock
    public s4_OutBlock? s4_OutBlock { get; set; }
}


/// <summary>
/// 주식주문접수: SC0
/// </summary>
[Path("/websocket/stock", Description = "주식주문접수", Key = "account")]
public class SC0 : TrBase
{
    // InBlock
    public SC0InBlock? SC0InBlock { get; set; }

    // OutBlock
    public SC0OutBlock? SC0OutBlock { get; set; }
}


/// <summary>
/// 주식주문체결: SC1
/// </summary>
[Path("/websocket/stock", Description = "주식주문체결", Key = "account")]
public class SC1 : TrBase
{
    // InBlock
    public SC1InBlock? SC1InBlock { get; set; }

    // OutBlock
    public SC1OutBlock? SC1OutBlock { get; set; }
}


/// <summary>
/// 주식주문정정: SC2
/// </summary>
[Path("/websocket/stock", Description = "주식주문정정", Key = "account")]
public class SC2 : TrBase
{
    // InBlock
    public SC2InBlock? SC2InBlock { get; set; }

    // OutBlock
    public SC2OutBlock? SC2OutBlock { get; set; }
}


/// <summary>
/// 주식주문취소: SC3
/// </summary>
[Path("/websocket/stock", Description = "주식주문취소", Key = "account")]
public class SC3 : TrBase
{
    // InBlock
    public SC3InBlock? SC3InBlock { get; set; }

    // OutBlock
    public SC3OutBlock? SC3OutBlock { get; set; }
}


/// <summary>
/// 주식주문거부: SC4
/// </summary>
[Path("/websocket/stock", Description = "주식주문거부", Key = "account")]
public class SC4 : TrBase
{
    // InBlock
    public SC4InBlock? SC4InBlock { get; set; }

    // OutBlock
    public SC4OutBlock? SC4OutBlock { get; set; }
}


/// <summary>
/// 상/하한가근접진입: SHC
/// </summary>
[Path("/websocket/stock", Description = "상/하한가근접진입")]
public class SHC : TrBase
{
    // InBlock
    public SHCInBlock? SHCInBlock { get; set; }

    // OutBlock
    public SHCOutBlock? SHCOutBlock { get; set; }
}


/// <summary>
/// 상/하한가근접이탈: SHD
/// </summary>
[Path("/websocket/stock", Description = "상/하한가근접이탈")]
public class SHD : TrBase
{
    // InBlock
    public SHDInBlock? SHDInBlock { get; set; }

    // OutBlock
    public SHDOutBlock? SHDOutBlock { get; set; }
}


/// <summary>
/// 상/하한가진입: SHI
/// </summary>
[Path("/websocket/stock", Description = "상/하한가진입")]
public class SHI : TrBase
{
    // InBlock
    public SHIInBlock? SHIInBlock { get; set; }

    // OutBlock
    public SHIOutBlock? SHIOutBlock { get; set; }
}


/// <summary>
/// 상/하한가이탈: SHO
/// </summary>
[Path("/websocket/stock", Description = "상/하한가이탈")]
public class SHO : TrBase
{
    // InBlock
    public SHOInBlock? SHOInBlock { get; set; }

    // OutBlock
    public SHOOutBlock? SHOOutBlock { get; set; }
}


/// <summary>
/// 해외선물주문: TC1
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물주문", Key = "account")]
public class TC1 : TrBase
{
    // InBlock
    public TC1InBlock? TC1InBlock { get; set; }

    // OutBlock
    public TC1OutBlock? TC1OutBlock { get; set; }
}


/// <summary>
/// 해외선물응답: TC2
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물응답", Key = "account")]
public class TC2 : TrBase
{
    // InBlock
    public TC2InBlock? TC2InBlock { get; set; }

    // OutBlock
    public TC2OutBlock? TC2OutBlock { get; set; }
}


/// <summary>
/// 해외선물체결: TC3
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외선물체결", Key = "account")]
public class TC3 : TrBase
{
    // InBlock
    public TC3InBlock? TC3InBlock { get; set; }

    // OutBlock
    public TC3OutBlock? TC3OutBlock { get; set; }
}


/// <summary>
/// VI발동해제: VI_
/// </summary>
[Path("/websocket/stock", Description = "VI발동해제")]
public class VI_ : TrBase
{
    // InBlock
    public VI_InBlock? VI_InBlock { get; set; }

    // OutBlock
    public VI_OutBlock? VI_OutBlock { get; set; }
}


/// <summary>
/// 해외옵션 현재가체결: WOC
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외옵션 현재가체결")]
public class WOC : TrBase
{
    // InBlock
    public WOCInBlock? WOCInBlock { get; set; }

    // OutBlock
    public WOCOutBlock? WOCOutBlock { get; set; }
}


/// <summary>
/// 해외옵션 호가: WOH
/// </summary>
[Path("/websocket/overseas-futureoption", Description = "해외옵션 호가")]
public class WOH : TrBase
{
    // InBlock
    public WOHInBlock? WOHInBlock { get; set; }

    // OutBlock
    public WOHOutBlock? WOHOutBlock { get; set; }
}


/// <summary>
/// 상품선물예상체결: YC3
/// </summary>
[Path("/websocket/futureoption", Description = "상품선물예상체결")]
public class YC3 : TrBase
{
    // InBlock
    public YC3InBlock? YC3InBlock { get; set; }

    // OutBlock
    public YC3OutBlock? YC3OutBlock { get; set; }
}


/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
[Path("/websocket/futureoption", Description = "지수선물예상체결")]
public class YFC : TrBase
{
    // InBlock
    public YFCInBlock? YFCInBlock { get; set; }

    // OutBlock
    public YFCOutBlock? YFCOutBlock { get; set; }
}


/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
[Path("/websocket/futureoption", Description = "주식선물예상체결")]
public class YJC : TrBase
{
    // InBlock
    public YJCInBlock? YJCInBlock { get; set; }

    // OutBlock
    public YJCOutBlock? YJCOutBlock { get; set; }
}


/// <summary>
/// 예상지수: YJ_
/// </summary>
[Path("/websocket/stock", Description = "예상지수")]
public class YJ_ : TrBase
{
    // InBlock
    public YJ_InBlock? YJ_InBlock { get; set; }

    // OutBlock
    public YJ_OutBlock? YJ_OutBlock { get; set; }
}


/// <summary>
/// KOSDAQ예상체결: YK3
/// </summary>
[Path("/websocket/stock", Description = "KOSDAQ예상체결")]
public class YK3 : TrBase
{
    // InBlock
    public YK3InBlock? YK3InBlock { get; set; }

    // OutBlock
    public YK3OutBlock? YK3OutBlock { get; set; }
}


/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
[Path("/websocket/futureoption", Description = "지수옵션예상체결")]
public class YOC : TrBase
{
    // InBlock
    public YOCInBlock? YOCInBlock { get; set; }

    // OutBlock
    public YOCOutBlock? YOCOutBlock { get; set; }
}


/// <summary>
/// KOSPI예상체결: YS3
/// </summary>
[Path("/websocket/stock", Description = "KOSPI예상체결")]
public class YS3 : TrBase
{
    // InBlock
    public YS3InBlock? YS3InBlock { get; set; }

    // OutBlock
    public YS3OutBlock? YS3OutBlock { get; set; }
}


/// <summary>
/// ELW예상체결: Ys3
/// </summary>
[Path("/websocket/stock", Description = "ELW예상체결")]
public class Ys3 : TrBase
{
    // InBlock
    public Ys3InBlock? Ys3InBlock { get; set; }

    // OutBlock
    public Ys3OutBlock? Ys3OutBlock { get; set; }
}


