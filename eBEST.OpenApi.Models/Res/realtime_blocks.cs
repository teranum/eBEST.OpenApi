// [2024-03-11 오전 11:59:00]
// 이 파일은 ResToModel 에 의해 자동으로 만들어졌습니다.
// XingAPI Res폴더의 .res 파일에서 변환되었습니다.
namespace eBEST.OpenApi.Models;

/// <summary>
/// ETF호가잔량: B7_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record B7_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ETF호가잔량: B7_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="lp_offerho1">LP매도호가수량1	long	9</param>
/// <param name="lp_bidho1">LP매수호가수량1	long	9</param>
/// <param name="lp_offerho2">LP매도호가수량2	long	9</param>
/// <param name="lp_bidho2">LP매수호가수량2	long	9</param>
/// <param name="lp_offerho3">LP매도호가수량3	long	9</param>
/// <param name="lp_bidho3">LP매수호가수량3	long	9</param>
/// <param name="lp_offerho4">LP매도호가수량4	long	9</param>
/// <param name="lp_bidho4">LP매수호가수량4	long	9</param>
/// <param name="lp_offerho5">LP매도호가수량5	long	9</param>
/// <param name="lp_bidho5">LP매수호가수량5	long	9</param>
/// <param name="lp_offerho6">LP매도호가수량6	long	9</param>
/// <param name="lp_bidho6">LP매수호가수량6	long	9</param>
/// <param name="lp_offerho7">LP매도호가수량7	long	9</param>
/// <param name="lp_bidho7">LP매수호가수량7	long	9</param>
/// <param name="lp_offerho8">LP매도호가수량8	long	9</param>
/// <param name="lp_bidho8">LP매수호가수량8	long	9</param>
/// <param name="lp_offerho9">LP매도호가수량9	long	9</param>
/// <param name="lp_bidho9">LP매수호가수량9	long	9</param>
/// <param name="lp_offerho10">LP매도호가수량10	long	9</param>
/// <param name="lp_bidho10">LP매수호가수량10	long	9</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="offerho1">매도호가1	int	7</param>
/// <param name="bidho1">매수호가1	int	7</param>
/// <param name="offerrem1">매도호가잔량1	long	9</param>
/// <param name="bidrem1">매수호가잔량1	long	9</param>
/// <param name="offerho2">매도호가2	int	7</param>
/// <param name="bidho2">매수호가2	int	7</param>
/// <param name="offerrem2">매도호가잔량2	long	9</param>
/// <param name="bidrem2">매수호가잔량2	long	9</param>
/// <param name="offerho3">매도호가3	int	7</param>
/// <param name="bidho3">매수호가3	int	7</param>
/// <param name="offerrem3">매도호가잔량3	long	9</param>
/// <param name="bidrem3">매수호가잔량3	long	9</param>
/// <param name="offerho4">매도호가4	int	7</param>
/// <param name="bidho4">매수호가4	int	7</param>
/// <param name="offerrem4">매도호가잔량4	long	9</param>
/// <param name="bidrem4">매수호가잔량4	long	9</param>
/// <param name="offerho5">매도호가5	int	7</param>
/// <param name="bidho5">매수호가5	int	7</param>
/// <param name="offerrem5">매도호가잔량5	long	9</param>
/// <param name="bidrem5">매수호가잔량5	long	9</param>
/// <param name="offerho6">매도호가6	int	7</param>
/// <param name="bidho6">매수호가6	int	7</param>
/// <param name="offerrem6">매도호가잔량6	long	9</param>
/// <param name="bidrem6">매수호가잔량6	long	9</param>
/// <param name="offerho7">매도호가7	int	7</param>
/// <param name="bidho7">매수호가7	int	7</param>
/// <param name="offerrem7">매도호가잔량7	long	9</param>
/// <param name="bidrem7">매수호가잔량7	long	9</param>
/// <param name="offerho8">매도호가8	int	7</param>
/// <param name="bidho8">매수호가8	int	7</param>
/// <param name="offerrem8">매도호가잔량8	long	9</param>
/// <param name="bidrem8">매수호가잔량8	long	9</param>
/// <param name="offerho9">매도호가9	int	7</param>
/// <param name="bidho9">매수호가9	int	7</param>
/// <param name="offerrem9">매도호가잔량9	long	9</param>
/// <param name="bidrem9">매수호가잔량9	long	9</param>
/// <param name="offerho10">매도호가10	int	7</param>
/// <param name="bidho10">매수호가10	int	7</param>
/// <param name="offerrem10">매도호가잔량10	long	9</param>
/// <param name="bidrem10">매수호가잔량10	long	9</param>
/// <param name="totofferrem">총매도호가잔량	long	9</param>
/// <param name="totbidrem">총매수호가잔량	long	9</param>
/// <param name="donsigubun">동시호가구분	string	1</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
[BlockInfo(true, 598)]
public record B7_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("LP매도호가수량1", 9)] long lp_offerho1,
    [BlockField("LP매수호가수량1", 9)] long lp_bidho1,
    [BlockField("LP매도호가수량2", 9)] long lp_offerho2,
    [BlockField("LP매수호가수량2", 9)] long lp_bidho2,
    [BlockField("LP매도호가수량3", 9)] long lp_offerho3,
    [BlockField("LP매수호가수량3", 9)] long lp_bidho3,
    [BlockField("LP매도호가수량4", 9)] long lp_offerho4,
    [BlockField("LP매수호가수량4", 9)] long lp_bidho4,
    [BlockField("LP매도호가수량5", 9)] long lp_offerho5,
    [BlockField("LP매수호가수량5", 9)] long lp_bidho5,
    [BlockField("LP매도호가수량6", 9)] long lp_offerho6,
    [BlockField("LP매수호가수량6", 9)] long lp_bidho6,
    [BlockField("LP매도호가수량7", 9)] long lp_offerho7,
    [BlockField("LP매수호가수량7", 9)] long lp_bidho7,
    [BlockField("LP매도호가수량8", 9)] long lp_offerho8,
    [BlockField("LP매수호가수량8", 9)] long lp_bidho8,
    [BlockField("LP매도호가수량9", 9)] long lp_offerho9,
    [BlockField("LP매수호가수량9", 9)] long lp_bidho9,
    [BlockField("LP매도호가수량10", 9)] long lp_offerho10,
    [BlockField("LP매수호가수량10", 9)] long lp_bidho10,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("매도호가1", 7)] int offerho1,
    [BlockField("매수호가1", 7)] int bidho1,
    [BlockField("매도호가잔량1", 9)] long offerrem1,
    [BlockField("매수호가잔량1", 9)] long bidrem1,
    [BlockField("매도호가2", 7)] int offerho2,
    [BlockField("매수호가2", 7)] int bidho2,
    [BlockField("매도호가잔량2", 9)] long offerrem2,
    [BlockField("매수호가잔량2", 9)] long bidrem2,
    [BlockField("매도호가3", 7)] int offerho3,
    [BlockField("매수호가3", 7)] int bidho3,
    [BlockField("매도호가잔량3", 9)] long offerrem3,
    [BlockField("매수호가잔량3", 9)] long bidrem3,
    [BlockField("매도호가4", 7)] int offerho4,
    [BlockField("매수호가4", 7)] int bidho4,
    [BlockField("매도호가잔량4", 9)] long offerrem4,
    [BlockField("매수호가잔량4", 9)] long bidrem4,
    [BlockField("매도호가5", 7)] int offerho5,
    [BlockField("매수호가5", 7)] int bidho5,
    [BlockField("매도호가잔량5", 9)] long offerrem5,
    [BlockField("매수호가잔량5", 9)] long bidrem5,
    [BlockField("매도호가6", 7)] int offerho6,
    [BlockField("매수호가6", 7)] int bidho6,
    [BlockField("매도호가잔량6", 9)] long offerrem6,
    [BlockField("매수호가잔량6", 9)] long bidrem6,
    [BlockField("매도호가7", 7)] int offerho7,
    [BlockField("매수호가7", 7)] int bidho7,
    [BlockField("매도호가잔량7", 9)] long offerrem7,
    [BlockField("매수호가잔량7", 9)] long bidrem7,
    [BlockField("매도호가8", 7)] int offerho8,
    [BlockField("매수호가8", 7)] int bidho8,
    [BlockField("매도호가잔량8", 9)] long offerrem8,
    [BlockField("매수호가잔량8", 9)] long bidrem8,
    [BlockField("매도호가9", 7)] int offerho9,
    [BlockField("매수호가9", 7)] int bidho9,
    [BlockField("매도호가잔량9", 9)] long offerrem9,
    [BlockField("매수호가잔량9", 9)] long bidrem9,
    [BlockField("매도호가10", 7)] int offerho10,
    [BlockField("매수호가10", 7)] int bidho10,
    [BlockField("매도호가잔량10", 9)] long offerrem10,
    [BlockField("매수호가잔량10", 9)] long bidrem10,
    [BlockField("총매도호가잔량", 9)] long totofferrem,
    [BlockField("총매수호가잔량", 9)] long totbidrem,
    [BlockField("동시호가구분", 1)] string donsigubun,
    [BlockField("배분적용구분", 1)] string alloc_gubun
    );


/// <summary>
/// 시간대별투자자매매추이: BMT
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 4)]
public record BMTInBlock(
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 시간대별투자자매매추이: BMT
/// </summary>
/// <param name="tjjtime">수신시간	string	8</param>
/// <param name="tjjcode1">투자자코드1(개인)	string	4</param>
/// <param name="msvolume1">매수 거래량1	int	8</param>
/// <param name="mdvolume1">매도 거래량1	int	8</param>
/// <param name="msvol1">거래량 순매수1	int	8</param>
/// <param name="msvalue1">매수 거래대금1	int	6</param>
/// <param name="mdvalue1">매도 거래대금1	int	6</param>
/// <param name="msval1">거래대금 순매수1	int	6</param>
/// <param name="tjjcode2">투자자코드2(외국인)	string	4</param>
/// <param name="msvolume2">매수 거래량2	int	8</param>
/// <param name="mdvolume2">매도 거래량2	int	8</param>
/// <param name="msvol2">거래량 순매수2	int	8</param>
/// <param name="msvalue2">매수 거래대금2	int	6</param>
/// <param name="mdvalue2">매도 거래대금2	int	6</param>
/// <param name="msval2">거래대금 순매수2	int	6</param>
/// <param name="tjjcode3">투자자코드3(기관계)	string	4</param>
/// <param name="msvolume3">매수 거래량3	int	8</param>
/// <param name="mdvolume3">매도 거래량3	int	8</param>
/// <param name="msvol3">거래량 순매수3	int	8</param>
/// <param name="msvalue3">매수 거래대금3	int	6</param>
/// <param name="mdvalue3">매도 거래대금3	int	6</param>
/// <param name="msval3">거래대금 순매수3	int	6</param>
/// <param name="tjjcode4">투자자코드4(증권)	string	4</param>
/// <param name="msvolume4">매수 거래량4	int	8</param>
/// <param name="mdvolume4">매도 거래량4	int	8</param>
/// <param name="msvol4">거래량 순매수4	int	8</param>
/// <param name="msvalue4">매수 거래대금4	int	6</param>
/// <param name="mdvalue4">매도 거래대금4	int	6</param>
/// <param name="msval4">거래대금 순매수4	int	6</param>
/// <param name="tjjcode5">투자자코드5(투신)	string	4</param>
/// <param name="msvolume5">매수 거래량5	int	8</param>
/// <param name="mdvolume5">매도 거래량5	int	8</param>
/// <param name="msvol5">거래량 순매수5	int	8</param>
/// <param name="msvalue5">매수 거래대금5	int	6</param>
/// <param name="mdvalue5">매도 거래대금5	int	6</param>
/// <param name="msval5">거래대금 순매수5	int	6</param>
/// <param name="tjjcode6">투자자코드6(은행)	string	4</param>
/// <param name="msvolume6">매수 거래량6	int	8</param>
/// <param name="mdvolume6">매도 거래량6	int	8</param>
/// <param name="msvol6">거래량 순매수6	int	8</param>
/// <param name="msvalue6">매수 거래대금6	int	6</param>
/// <param name="mdvalue6">매도 거래대금6	int	6</param>
/// <param name="msval6">거래대금 순매수6	int	6</param>
/// <param name="tjjcode7">투자자코드7(보험)	string	4</param>
/// <param name="msvolume7">매수 거래량7	int	8</param>
/// <param name="mdvolume7">매도 거래량7	int	8</param>
/// <param name="msvol7">거래량 순매수7	int	8</param>
/// <param name="msvalue7">매수 거래대금7	int	6</param>
/// <param name="mdvalue7">매도 거래대금7	int	6</param>
/// <param name="msval7">거래대금 순매수7	int	6</param>
/// <param name="tjjcode8">투자자코드8(종금)	string	4</param>
/// <param name="msvolume8">매수 거래량8	int	8</param>
/// <param name="mdvolume8">매도 거래량8	int	8</param>
/// <param name="msvol8">거래량 순매수8	int	8</param>
/// <param name="msvalue8">매수 거래대금8	int	6</param>
/// <param name="mdvalue8">매도 거래대금8	int	6</param>
/// <param name="msval8">거래대금 순매수8	int	6</param>
/// <param name="tjjcode9">투자자코드9(기금)	string	4</param>
/// <param name="msvolume9">매수 거래량9	int	8</param>
/// <param name="mdvolume9">매도 거래량9	int	8</param>
/// <param name="msvol9">거래량 순매수9	int	8</param>
/// <param name="msvalue9">매수 거래대금9	int	6</param>
/// <param name="mdvalue9">매도 거래대금9	int	6</param>
/// <param name="msval9">거래대금 순매수9	int	6</param>
/// <param name="tjjcode10">투자자코드10(선물업자)	string	4</param>
/// <param name="msvolume10">매수 거래량10	int	8</param>
/// <param name="mdvolume10">매도 거래량10	int	8</param>
/// <param name="msvol10">거래량 순매수10	int	8</param>
/// <param name="msvalue10">매수 거래대금10	int	6</param>
/// <param name="mdvalue10">매도 거래대금10	int	6</param>
/// <param name="msval10">거래대금 순매수10	int	6</param>
/// <param name="tjjcode11">투자자코드11(기타)	string	4</param>
/// <param name="msvolume11">매수 거래량11	int	8</param>
/// <param name="mdvolume11">매도 거래량11	int	8</param>
/// <param name="msvol11">거래량 순매수11	int	8</param>
/// <param name="msvalue11">매수 거래대금11	int	6</param>
/// <param name="mdvalue11">매도 거래대금11	int	6</param>
/// <param name="msval11">거래대금 순매수11	int	6</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="tjjcode0">투자자코드0(사모펀드)	string	4</param>
/// <param name="msvolume0">매수 거래량0	int	8</param>
/// <param name="mdvolume0">매도 거래량0	int	8</param>
/// <param name="msvol0">거래량 순매수0	int	8</param>
/// <param name="msvalue0">매수 거래대금0	int	6</param>
/// <param name="mdvalue0">매도 거래대금0	int	6</param>
/// <param name="msval0">거래대금 순매수0	int	6</param>
[BlockInfo(true, 649)]
public record BMTOutBlock(
    [BlockField("수신시간", 8)] string tjjtime,
    [BlockField("투자자코드1(개인)", 4)] string tjjcode1,
    [BlockField("매수 거래량1", 8)] int msvolume1,
    [BlockField("매도 거래량1", 8)] int mdvolume1,
    [BlockField("거래량 순매수1", 8)] int msvol1,
    [BlockField("매수 거래대금1", 6)] int msvalue1,
    [BlockField("매도 거래대금1", 6)] int mdvalue1,
    [BlockField("거래대금 순매수1", 6)] int msval1,
    [BlockField("투자자코드2(외국인)", 4)] string tjjcode2,
    [BlockField("매수 거래량2", 8)] int msvolume2,
    [BlockField("매도 거래량2", 8)] int mdvolume2,
    [BlockField("거래량 순매수2", 8)] int msvol2,
    [BlockField("매수 거래대금2", 6)] int msvalue2,
    [BlockField("매도 거래대금2", 6)] int mdvalue2,
    [BlockField("거래대금 순매수2", 6)] int msval2,
    [BlockField("투자자코드3(기관계)", 4)] string tjjcode3,
    [BlockField("매수 거래량3", 8)] int msvolume3,
    [BlockField("매도 거래량3", 8)] int mdvolume3,
    [BlockField("거래량 순매수3", 8)] int msvol3,
    [BlockField("매수 거래대금3", 6)] int msvalue3,
    [BlockField("매도 거래대금3", 6)] int mdvalue3,
    [BlockField("거래대금 순매수3", 6)] int msval3,
    [BlockField("투자자코드4(증권)", 4)] string tjjcode4,
    [BlockField("매수 거래량4", 8)] int msvolume4,
    [BlockField("매도 거래량4", 8)] int mdvolume4,
    [BlockField("거래량 순매수4", 8)] int msvol4,
    [BlockField("매수 거래대금4", 6)] int msvalue4,
    [BlockField("매도 거래대금4", 6)] int mdvalue4,
    [BlockField("거래대금 순매수4", 6)] int msval4,
    [BlockField("투자자코드5(투신)", 4)] string tjjcode5,
    [BlockField("매수 거래량5", 8)] int msvolume5,
    [BlockField("매도 거래량5", 8)] int mdvolume5,
    [BlockField("거래량 순매수5", 8)] int msvol5,
    [BlockField("매수 거래대금5", 6)] int msvalue5,
    [BlockField("매도 거래대금5", 6)] int mdvalue5,
    [BlockField("거래대금 순매수5", 6)] int msval5,
    [BlockField("투자자코드6(은행)", 4)] string tjjcode6,
    [BlockField("매수 거래량6", 8)] int msvolume6,
    [BlockField("매도 거래량6", 8)] int mdvolume6,
    [BlockField("거래량 순매수6", 8)] int msvol6,
    [BlockField("매수 거래대금6", 6)] int msvalue6,
    [BlockField("매도 거래대금6", 6)] int mdvalue6,
    [BlockField("거래대금 순매수6", 6)] int msval6,
    [BlockField("투자자코드7(보험)", 4)] string tjjcode7,
    [BlockField("매수 거래량7", 8)] int msvolume7,
    [BlockField("매도 거래량7", 8)] int mdvolume7,
    [BlockField("거래량 순매수7", 8)] int msvol7,
    [BlockField("매수 거래대금7", 6)] int msvalue7,
    [BlockField("매도 거래대금7", 6)] int mdvalue7,
    [BlockField("거래대금 순매수7", 6)] int msval7,
    [BlockField("투자자코드8(종금)", 4)] string tjjcode8,
    [BlockField("매수 거래량8", 8)] int msvolume8,
    [BlockField("매도 거래량8", 8)] int mdvolume8,
    [BlockField("거래량 순매수8", 8)] int msvol8,
    [BlockField("매수 거래대금8", 6)] int msvalue8,
    [BlockField("매도 거래대금8", 6)] int mdvalue8,
    [BlockField("거래대금 순매수8", 6)] int msval8,
    [BlockField("투자자코드9(기금)", 4)] string tjjcode9,
    [BlockField("매수 거래량9", 8)] int msvolume9,
    [BlockField("매도 거래량9", 8)] int mdvolume9,
    [BlockField("거래량 순매수9", 8)] int msvol9,
    [BlockField("매수 거래대금9", 6)] int msvalue9,
    [BlockField("매도 거래대금9", 6)] int mdvalue9,
    [BlockField("거래대금 순매수9", 6)] int msval9,
    [BlockField("투자자코드10(선물업자)", 4)] string tjjcode10,
    [BlockField("매수 거래량10", 8)] int msvolume10,
    [BlockField("매도 거래량10", 8)] int mdvolume10,
    [BlockField("거래량 순매수10", 8)] int msvol10,
    [BlockField("매수 거래대금10", 6)] int msvalue10,
    [BlockField("매도 거래대금10", 6)] int mdvalue10,
    [BlockField("거래대금 순매수10", 6)] int msval10,
    [BlockField("투자자코드11(기타)", 4)] string tjjcode11,
    [BlockField("매수 거래량11", 8)] int msvolume11,
    [BlockField("매도 거래량11", 8)] int mdvolume11,
    [BlockField("거래량 순매수11", 8)] int msvol11,
    [BlockField("매수 거래대금11", 6)] int msvalue11,
    [BlockField("매도 거래대금11", 6)] int mdvalue11,
    [BlockField("거래대금 순매수11", 6)] int msval11,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("투자자코드0(사모펀드)", 4)] string tjjcode0,
    [BlockField("매수 거래량0", 8)] int msvolume0,
    [BlockField("매도 거래량0", 8)] int mdvolume0,
    [BlockField("거래량 순매수0", 8)] int msvol0,
    [BlockField("매수 거래대금0", 6)] int msvalue0,
    [BlockField("매도 거래대금0", 6)] int mdvalue0,
    [BlockField("거래대금 순매수0", 6)] int msval0
    );


/// <summary>
/// 업종별투자자별매매현황: BM_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 4)]
public record BM_InBlock(
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 업종별투자자별매매현황: BM_
/// </summary>
/// <param name="tjjcode">투자자코드	string	4</param>
/// <param name="tjjtime">수신시간	string	8</param>
/// <param name="msvolume">매수 거래량	int	8</param>
/// <param name="mdvolume">매도 거래량	int	8</param>
/// <param name="msvol">거래량 순매수	int	8</param>
/// <param name="p_msvol">거래량 순매수 직전대비	int	8</param>
/// <param name="msvalue">매수 거래대금	int	6</param>
/// <param name="mdvalue">매도 거래대금	int	6</param>
/// <param name="msval">거래대금 순매수	int	6</param>
/// <param name="p_msval">거래대금 순매수 직전대비	int	6</param>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 82)]
public record BM_OutBlock(
    [BlockField("투자자코드", 4)] string tjjcode,
    [BlockField("수신시간", 8)] string tjjtime,
    [BlockField("매수 거래량", 8)] int msvolume,
    [BlockField("매도 거래량", 8)] int mdvolume,
    [BlockField("거래량 순매수", 8)] int msvol,
    [BlockField("거래량 순매수 직전대비", 8)] int p_msvol,
    [BlockField("매수 거래대금", 6)] int msvalue,
    [BlockField("매도 거래대금", 6)] int mdvalue,
    [BlockField("거래대금 순매수", 6)] int msval,
    [BlockField("거래대금 순매수 직전대비", 6)] int p_msval,
    [BlockField("업종코드", 3)] string upcode
    );


/// <summary>
/// 선물주문체결: C01
/// </summary>
[BlockInfo(false, 0)]
public record C01InBlock(
    );

/// <summary>
/// 선물주문체결: C01
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="seq">일련번호	long	11</param>
/// <param name="trcode">trcode	string	11</param>
/// <param name="megrpno">매칭그룹번호	string	2</param>
/// <param name="boardid">보드ID	string	2</param>
/// <param name="memberno">회원번호	string	5</param>
/// <param name="bpno">지점번호	string	5</param>
/// <param name="ordno">주문번호	string	10</param>
/// <param name="ordordno">원주문번호	string	10</param>
/// <param name="expcode">종목코드	string	12</param>
/// <param name="yakseq">약정번호	string	11</param>
/// <param name="cheprice">체결가격	double	11.2</param>
/// <param name="chevol">체결수량	long	10</param>
/// <param name="sessionid">세션ID	string	2</param>
/// <param name="chedate">체결일자	string	8</param>
/// <param name="chetime">체결시각	string	9</param>
/// <param name="spdprc1">최근월체결가격	double	11.2</param>
/// <param name="spdprc2">차근월체결가격	double	11.2</param>
/// <param name="dosugb">매도수구분	string	1</param>
/// <param name="accno1">계좌번호1	string	12</param>
/// <param name="sihogagb">시장조성호가구분	string	1</param>
/// <param name="jakino">위탁사번호	string	5</param>
/// <param name="daeyong">대용주권계좌번호	string	12</param>
/// <param name="mem_filler">mem_filler	string	7</param>
/// <param name="mem_accno">mem_accno	string	11</param>
/// <param name="mem_filler1">mem_filler1	string	42</param>
[BlockInfo(false, 261)]
public record C01OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("일련번호", 11)] long seq,
    [BlockField("trcode", 11)] string trcode,
    [BlockField("매칭그룹번호", 2)] string megrpno,
    [BlockField("보드ID", 2)] string boardid,
    [BlockField("회원번호", 5)] string memberno,
    [BlockField("지점번호", 5)] string bpno,
    [BlockField("주문번호", 10)] string ordno,
    [BlockField("원주문번호", 10)] string ordordno,
    [BlockField("종목코드", 12)] string expcode,
    [BlockField("약정번호", 11)] string yakseq,
    [BlockField("체결가격", 11.2)] double cheprice,
    [BlockField("체결수량", 10)] long chevol,
    [BlockField("세션ID", 2)] string sessionid,
    [BlockField("체결일자", 8)] string chedate,
    [BlockField("체결시각", 9)] string chetime,
    [BlockField("최근월체결가격", 11.2)] double spdprc1,
    [BlockField("차근월체결가격", 11.2)] double spdprc2,
    [BlockField("매도수구분", 1)] string dosugb,
    [BlockField("계좌번호1", 12)] string accno1,
    [BlockField("시장조성호가구분", 1)] string sihogagb,
    [BlockField("위탁사번호", 5)] string jakino,
    [BlockField("대용주권계좌번호", 12)] string daeyong,
    [BlockField("mem_filler", 7)] string mem_filler,
    [BlockField("mem_accno", 11)] string mem_accno,
    [BlockField("mem_filler1", 42)] string mem_filler1
    );


/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record CD0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 31)]
public record CD0OutBlock(
    [BlockField("접속매매여부", 1)] string gubun,
    [BlockField("실시간가격제한여부", 1)] string dy_gubun,
    [BlockField("실시간상한가", 8.2)] double dy_uplmtprice,
    [BlockField("실시간하한가", 8.2)] double dy_dnlmtprice,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// 현물정보 USD 실시간: CUR
/// </summary>
/// <param name="base_id">기초자산ID	string	6</param>
[BlockInfo(true, 7)]
public record CURInBlock(
    [BlockField("기초자산ID", 6)] string base_id
    );

/// <summary>
/// 현물정보 USD 실시간: CUR
/// </summary>
/// <param name="time">전송시간	string	6</param>
/// <param name="offer">매도호가	double	7.2</param>
/// <param name="bid">매수호가	double	7.2</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="price">체결가	double	7.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	7.2</param>
/// <param name="drate">등락율	double	7.2</param>
/// <param name="ctime">데이타 발생시간	string	6</param>
/// <param name="base_id">기초자산ID	string	6</param>
[BlockInfo(true, 87)]
public record CUROutBlock(
    [BlockField("전송시간", 6)] string time,
    [BlockField("매도호가", 7.2)] double offer,
    [BlockField("매수호가", 7.2)] double bid,
    [BlockField("시가", 7.2)] double open,
    [BlockField("고가", 7.2)] double high,
    [BlockField("저가", 7.2)] double low,
    [BlockField("체결가", 7.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 7.2)] double change,
    [BlockField("등락율", 7.2)] double drate,
    [BlockField("데이타 발생시간", 6)] string ctime,
    [BlockField("기초자산ID", 6)] string base_id
    );


/// <summary>
/// KOSPI시간외단일가호가잔량: DH1
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record DH1InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI시간외단일가호가잔량: DH1
/// </summary>
/// <param name="dan_hotime">시간외단일가호가시간	string	6</param>
/// <param name="dan_hstatus">시간외단일가장구분	string	2</param>
/// <param name="dan_offerho1">시간외단일가매도호가1	int	8</param>
/// <param name="dan_bidho1">시간외단일가매수호가1	int	8</param>
/// <param name="dan_offerrem1">시간외단일가매도호가잔량1	long	12</param>
/// <param name="dan_bidrem1">시간외단일가매수호가잔량1	long	12</param>
/// <param name="dan_preoffercha1">시간외단일가직전매도대비수량1	long	12</param>
/// <param name="dan_prebidcha1">시간외단일가직전매수대비수량1	long	12</param>
/// <param name="dan_offerho2">시간외단일가매도호가2	int	8</param>
/// <param name="dan_bidho2">시간외단일가매수호가2	int	8</param>
/// <param name="dan_offerrem2">시간외단일가매도호가잔량2	long	12</param>
/// <param name="dan_bidrem2">시간외단일가매수호가잔량2	long	12</param>
/// <param name="dan_preoffercha2">시간외단일가직전매도대비수량2	long	12</param>
/// <param name="dan_prebidcha2">시간외단일가직전매수대비수량2	long	12</param>
/// <param name="dan_offerho3">시간외단일가매도호가3	int	8</param>
/// <param name="dan_bidho3">시간외단일가매수호가3	int	8</param>
/// <param name="dan_offerrem3">시간외단일가매도호가잔량3	long	12</param>
/// <param name="dan_bidrem3">시간외단일가매수호가잔량3	long	12</param>
/// <param name="dan_preoffercha3">시간외단일가직전매도대비수량3	long	12</param>
/// <param name="dan_prebidcha3">시간외단일가직전매수대비수량3	long	12</param>
/// <param name="dan_offerho4">시간외단일가매도호가4	int	8</param>
/// <param name="dan_bidho4">시간외단일가매수호가4	int	8</param>
/// <param name="dan_offerrem4">시간외단일가매도호가잔량4	long	12</param>
/// <param name="dan_bidrem4">시간외단일가매수호가잔량4	long	12</param>
/// <param name="dan_preoffercha4">시간외단일가직전매도대비수량4	long	12</param>
/// <param name="dan_prebidcha4">시간외단일가직전매수대비수량4	long	12</param>
/// <param name="dan_offerho5">시간외단일가매도호가5	int	8</param>
/// <param name="dan_bidho5">시간외단일가매수호가5	int	8</param>
/// <param name="dan_offerrem5">시간외단일가매도호가잔량5	long	12</param>
/// <param name="dan_bidrem5">시간외단일가매수호가잔량5	long	12</param>
/// <param name="dan_preoffercha5">시간외단일가직전매도대비수량5	long	12</param>
/// <param name="dan_prebidcha5">시간외단일가직전매수대비수량5	long	12</param>
/// <param name="dan_totofferrem">시간외단일가총매도호가잔량	long	12</param>
/// <param name="dan_totbidrem">시간외단일가총매수호가잔량	long	12</param>
/// <param name="dan_preoffercha">시간외단일가직전매도호가총대비수량	long	12</param>
/// <param name="dan_prebidcha">시간외단일가직전매수호가총대비수량	long	12</param>
/// <param name="dan_yeprice">시간외단일가예상체결가격	int	8</param>
/// <param name="dan_yevolume">시간외단일가예상체결수량	long	12</param>
/// <param name="dan_preysign">시간외단일가예상가직전가대비구분	string	1</param>
/// <param name="dan_preychange">시간외단일가예상가직전가대비	int	8</param>
/// <param name="dan_jnilysign">시간외단일가예상가전일가대비구분	string	1</param>
/// <param name="dan_jnilychange">시간외단일가예상가전일가대비	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="volume">누적거래량	long	12</param>
[BlockInfo(true, 476)]
public record DH1OutBlock(
    [BlockField("시간외단일가호가시간", 6)] string dan_hotime,
    [BlockField("시간외단일가장구분", 2)] string dan_hstatus,
    [BlockField("시간외단일가매도호가1", 8)] int dan_offerho1,
    [BlockField("시간외단일가매수호가1", 8)] int dan_bidho1,
    [BlockField("시간외단일가매도호가잔량1", 12)] long dan_offerrem1,
    [BlockField("시간외단일가매수호가잔량1", 12)] long dan_bidrem1,
    [BlockField("시간외단일가직전매도대비수량1", 12)] long dan_preoffercha1,
    [BlockField("시간외단일가직전매수대비수량1", 12)] long dan_prebidcha1,
    [BlockField("시간외단일가매도호가2", 8)] int dan_offerho2,
    [BlockField("시간외단일가매수호가2", 8)] int dan_bidho2,
    [BlockField("시간외단일가매도호가잔량2", 12)] long dan_offerrem2,
    [BlockField("시간외단일가매수호가잔량2", 12)] long dan_bidrem2,
    [BlockField("시간외단일가직전매도대비수량2", 12)] long dan_preoffercha2,
    [BlockField("시간외단일가직전매수대비수량2", 12)] long dan_prebidcha2,
    [BlockField("시간외단일가매도호가3", 8)] int dan_offerho3,
    [BlockField("시간외단일가매수호가3", 8)] int dan_bidho3,
    [BlockField("시간외단일가매도호가잔량3", 12)] long dan_offerrem3,
    [BlockField("시간외단일가매수호가잔량3", 12)] long dan_bidrem3,
    [BlockField("시간외단일가직전매도대비수량3", 12)] long dan_preoffercha3,
    [BlockField("시간외단일가직전매수대비수량3", 12)] long dan_prebidcha3,
    [BlockField("시간외단일가매도호가4", 8)] int dan_offerho4,
    [BlockField("시간외단일가매수호가4", 8)] int dan_bidho4,
    [BlockField("시간외단일가매도호가잔량4", 12)] long dan_offerrem4,
    [BlockField("시간외단일가매수호가잔량4", 12)] long dan_bidrem4,
    [BlockField("시간외단일가직전매도대비수량4", 12)] long dan_preoffercha4,
    [BlockField("시간외단일가직전매수대비수량4", 12)] long dan_prebidcha4,
    [BlockField("시간외단일가매도호가5", 8)] int dan_offerho5,
    [BlockField("시간외단일가매수호가5", 8)] int dan_bidho5,
    [BlockField("시간외단일가매도호가잔량5", 12)] long dan_offerrem5,
    [BlockField("시간외단일가매수호가잔량5", 12)] long dan_bidrem5,
    [BlockField("시간외단일가직전매도대비수량5", 12)] long dan_preoffercha5,
    [BlockField("시간외단일가직전매수대비수량5", 12)] long dan_prebidcha5,
    [BlockField("시간외단일가총매도호가잔량", 12)] long dan_totofferrem,
    [BlockField("시간외단일가총매수호가잔량", 12)] long dan_totbidrem,
    [BlockField("시간외단일가직전매도호가총대비수량", 12)] long dan_preoffercha,
    [BlockField("시간외단일가직전매수호가총대비수량", 12)] long dan_prebidcha,
    [BlockField("시간외단일가예상체결가격", 8)] int dan_yeprice,
    [BlockField("시간외단일가예상체결수량", 12)] long dan_yevolume,
    [BlockField("시간외단일가예상가직전가대비구분", 1)] string dan_preysign,
    [BlockField("시간외단일가예상가직전가대비", 8)] int dan_preychange,
    [BlockField("시간외단일가예상가전일가대비구분", 1)] string dan_jnilysign,
    [BlockField("시간외단일가예상가전일가대비", 8)] int dan_jnilychange,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("누적거래량", 12)] long volume
    );


/// <summary>
/// KOSDAQ시간외단일가호가잔량: DHA
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record DHAInBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ시간외단일가호가잔량: DHA
/// </summary>
/// <param name="dan_hotime">시간외단일가호가시간	string	6</param>
/// <param name="dan_hstatus">시간외단일가장구분	string	2</param>
/// <param name="dan_offerho1">시간외단일가매도호가1	int	8</param>
/// <param name="dan_bidho1">시간외단일가매수호가1	int	8</param>
/// <param name="dan_offerrem1">시간외단일가매도호가잔량1	long	12</param>
/// <param name="dan_bidrem1">시간외단일가매수호가잔량1	long	12</param>
/// <param name="dan_preoffercha1">시간외단일가직전매도대비수량1	long	12</param>
/// <param name="dan_prebidcha1">시간외단일가직전매수대비수량1	long	12</param>
/// <param name="dan_offerho2">시간외단일가매도호가2	int	8</param>
/// <param name="dan_bidho2">시간외단일가매수호가2	int	8</param>
/// <param name="dan_offerrem2">시간외단일가매도호가잔량2	long	12</param>
/// <param name="dan_bidrem2">시간외단일가매수호가잔량2	long	12</param>
/// <param name="dan_preoffercha2">시간외단일가직전매도대비수량2	long	12</param>
/// <param name="dan_prebidcha2">시간외단일가직전매수대비수량2	long	12</param>
/// <param name="dan_offerho3">시간외단일가매도호가3	int	8</param>
/// <param name="dan_bidho3">시간외단일가매수호가3	int	8</param>
/// <param name="dan_offerrem3">시간외단일가매도호가잔량3	long	12</param>
/// <param name="dan_bidrem3">시간외단일가매수호가잔량3	long	12</param>
/// <param name="dan_preoffercha3">시간외단일가직전매도대비수량3	long	12</param>
/// <param name="dan_prebidcha3">시간외단일가직전매수대비수량3	long	12</param>
/// <param name="dan_offerho4">시간외단일가매도호가4	int	8</param>
/// <param name="dan_bidho4">시간외단일가매수호가4	int	8</param>
/// <param name="dan_offerrem4">시간외단일가매도호가잔량4	long	12</param>
/// <param name="dan_bidrem4">시간외단일가매수호가잔량4	long	12</param>
/// <param name="dan_preoffercha4">시간외단일가직전매도대비수량4	long	12</param>
/// <param name="dan_prebidcha4">시간외단일가직전매수대비수량4	long	12</param>
/// <param name="dan_offerho5">시간외단일가매도호가5	int	8</param>
/// <param name="dan_bidho5">시간외단일가매수호가5	int	8</param>
/// <param name="dan_offerrem5">시간외단일가매도호가잔량5	long	12</param>
/// <param name="dan_bidrem5">시간외단일가매수호가잔량5	long	12</param>
/// <param name="dan_preoffercha5">시간외단일가직전매도대비수량5	long	12</param>
/// <param name="dan_prebidcha5">시간외단일가직전매수대비수량5	long	12</param>
/// <param name="dan_totofferrem">시간외단일가총매도호가잔량	long	12</param>
/// <param name="dan_totbidrem">시간외단일가총매수호가잔량	long	12</param>
/// <param name="dan_preoffercha">시간외단일가직전매도호가총대비수량	long	12</param>
/// <param name="dan_prebidcha">시간외단일가직전매수호가총대비수량	long	12</param>
/// <param name="dan_yeprice">시간외단일가예상체결가격	int	8</param>
/// <param name="dan_yevolume">시간외단일가예상체결수량	long	12</param>
/// <param name="dan_preysign">시간외단일가예상가직전가대비구분	string	1</param>
/// <param name="dan_preychange">시간외단일가예상가직전가대비	int	8</param>
/// <param name="dan_jnilysign">시간외단일가예상가전일가대비구분	string	1</param>
/// <param name="dan_jnilychange">시간외단일가예상가전일가대비	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="volume">누적거래량	long	12</param>
[BlockInfo(true, 476)]
public record DHAOutBlock(
    [BlockField("시간외단일가호가시간", 6)] string dan_hotime,
    [BlockField("시간외단일가장구분", 2)] string dan_hstatus,
    [BlockField("시간외단일가매도호가1", 8)] int dan_offerho1,
    [BlockField("시간외단일가매수호가1", 8)] int dan_bidho1,
    [BlockField("시간외단일가매도호가잔량1", 12)] long dan_offerrem1,
    [BlockField("시간외단일가매수호가잔량1", 12)] long dan_bidrem1,
    [BlockField("시간외단일가직전매도대비수량1", 12)] long dan_preoffercha1,
    [BlockField("시간외단일가직전매수대비수량1", 12)] long dan_prebidcha1,
    [BlockField("시간외단일가매도호가2", 8)] int dan_offerho2,
    [BlockField("시간외단일가매수호가2", 8)] int dan_bidho2,
    [BlockField("시간외단일가매도호가잔량2", 12)] long dan_offerrem2,
    [BlockField("시간외단일가매수호가잔량2", 12)] long dan_bidrem2,
    [BlockField("시간외단일가직전매도대비수량2", 12)] long dan_preoffercha2,
    [BlockField("시간외단일가직전매수대비수량2", 12)] long dan_prebidcha2,
    [BlockField("시간외단일가매도호가3", 8)] int dan_offerho3,
    [BlockField("시간외단일가매수호가3", 8)] int dan_bidho3,
    [BlockField("시간외단일가매도호가잔량3", 12)] long dan_offerrem3,
    [BlockField("시간외단일가매수호가잔량3", 12)] long dan_bidrem3,
    [BlockField("시간외단일가직전매도대비수량3", 12)] long dan_preoffercha3,
    [BlockField("시간외단일가직전매수대비수량3", 12)] long dan_prebidcha3,
    [BlockField("시간외단일가매도호가4", 8)] int dan_offerho4,
    [BlockField("시간외단일가매수호가4", 8)] int dan_bidho4,
    [BlockField("시간외단일가매도호가잔량4", 12)] long dan_offerrem4,
    [BlockField("시간외단일가매수호가잔량4", 12)] long dan_bidrem4,
    [BlockField("시간외단일가직전매도대비수량4", 12)] long dan_preoffercha4,
    [BlockField("시간외단일가직전매수대비수량4", 12)] long dan_prebidcha4,
    [BlockField("시간외단일가매도호가5", 8)] int dan_offerho5,
    [BlockField("시간외단일가매수호가5", 8)] int dan_bidho5,
    [BlockField("시간외단일가매도호가잔량5", 12)] long dan_offerrem5,
    [BlockField("시간외단일가매수호가잔량5", 12)] long dan_bidrem5,
    [BlockField("시간외단일가직전매도대비수량5", 12)] long dan_preoffercha5,
    [BlockField("시간외단일가직전매수대비수량5", 12)] long dan_prebidcha5,
    [BlockField("시간외단일가총매도호가잔량", 12)] long dan_totofferrem,
    [BlockField("시간외단일가총매수호가잔량", 12)] long dan_totbidrem,
    [BlockField("시간외단일가직전매도호가총대비수량", 12)] long dan_preoffercha,
    [BlockField("시간외단일가직전매수호가총대비수량", 12)] long dan_prebidcha,
    [BlockField("시간외단일가예상체결가격", 8)] int dan_yeprice,
    [BlockField("시간외단일가예상체결수량", 12)] long dan_yevolume,
    [BlockField("시간외단일가예상가직전가대비구분", 1)] string dan_preysign,
    [BlockField("시간외단일가예상가직전가대비", 8)] int dan_preychange,
    [BlockField("시간외단일가예상가전일가대비구분", 1)] string dan_jnilysign,
    [BlockField("시간외단일가예상가전일가대비", 8)] int dan_jnilychange,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("누적거래량", 12)] long volume
    );


/// <summary>
/// KOSDAQ시간외단일가체결: DK3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record DK3InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ시간외단일가체결: DK3
/// </summary>
/// <param name="dan_chetime">시간외단일가체결시간	string	6</param>
/// <param name="dan_sign">시간외단일가전일대비구분	string	1</param>
/// <param name="dan_change">시간외단일가전일대비	int	8</param>
/// <param name="dan_drate">시간외단일가등락율	double	6.2</param>
/// <param name="dan_price">시간외단일가현재가	int	8</param>
/// <param name="dan_opentime">시간외단일가시가시간	string	6</param>
/// <param name="dan_open">시간외단일가시가	int	8</param>
/// <param name="dan_hightime">시간외단일가고가시간	string	6</param>
/// <param name="dan_high">시간외단일가고가	int	8</param>
/// <param name="dan_lowtime">시간외단일가저가시간	string	6</param>
/// <param name="dan_low">시간외단일가저가	int	8</param>
/// <param name="dan_cgubun">시간외단일가체결구분	string	1</param>
/// <param name="dan_cvolume">시간외단일가체결량	int	8</param>
/// <param name="dan_volume">시간외단일가누적거래량	long	12</param>
/// <param name="dan_value">시간외단일가누적거래대금	long	12</param>
/// <param name="dan_mdvolume">시간외단일가매도누적체결량	long	12</param>
/// <param name="dan_mdchecnt">시간외단일가매도누적체결건수	int	8</param>
/// <param name="dan_msvolume">시간외단일가매수누적체결량	long	12</param>
/// <param name="dan_mschecnt">시간외단일가매수누적체결건수	int	8</param>
/// <param name="dan_prevolume">시간외단일가직전거래량	int	8</param>
/// <param name="dan_precvolume">시간외단일가직전체결수량	int	8</param>
/// <param name="dan_cpower">시간외단일가체결강도	double	9.2</param>
/// <param name="dan_status">시간외단일가장정보	string	2</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 201)]
public record DK3OutBlock(
    [BlockField("시간외단일가체결시간", 6)] string dan_chetime,
    [BlockField("시간외단일가전일대비구분", 1)] string dan_sign,
    [BlockField("시간외단일가전일대비", 8)] int dan_change,
    [BlockField("시간외단일가등락율", 6.2)] double dan_drate,
    [BlockField("시간외단일가현재가", 8)] int dan_price,
    [BlockField("시간외단일가시가시간", 6)] string dan_opentime,
    [BlockField("시간외단일가시가", 8)] int dan_open,
    [BlockField("시간외단일가고가시간", 6)] string dan_hightime,
    [BlockField("시간외단일가고가", 8)] int dan_high,
    [BlockField("시간외단일가저가시간", 6)] string dan_lowtime,
    [BlockField("시간외단일가저가", 8)] int dan_low,
    [BlockField("시간외단일가체결구분", 1)] string dan_cgubun,
    [BlockField("시간외단일가체결량", 8)] int dan_cvolume,
    [BlockField("시간외단일가누적거래량", 12)] long dan_volume,
    [BlockField("시간외단일가누적거래대금", 12)] long dan_value,
    [BlockField("시간외단일가매도누적체결량", 12)] long dan_mdvolume,
    [BlockField("시간외단일가매도누적체결건수", 8)] int dan_mdchecnt,
    [BlockField("시간외단일가매수누적체결량", 12)] long dan_msvolume,
    [BlockField("시간외단일가매수누적체결건수", 8)] int dan_mschecnt,
    [BlockField("시간외단일가직전거래량", 8)] int dan_prevolume,
    [BlockField("시간외단일가직전체결수량", 8)] int dan_precvolume,
    [BlockField("시간외단일가체결강도", 9.2)] double dan_cpower,
    [BlockField("시간외단일가장정보", 2)] string dan_status,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// KOSPI시간외단일가체결: DS3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record DS3InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI시간외단일가체결: DS3
/// </summary>
/// <param name="dan_chetime">시간외단일가체결시간	string	6</param>
/// <param name="dan_sign">시간외단일가전일대비구분	string	1</param>
/// <param name="dan_change">시간외단일가전일대비	int	8</param>
/// <param name="dan_drate">시간외단일가등락율	double	6.2</param>
/// <param name="dan_price">시간외단일가현재가	int	8</param>
/// <param name="dan_opentime">시간외단일가시가시간	string	6</param>
/// <param name="dan_open">시간외단일가시가	int	8</param>
/// <param name="dan_hightime">시간외단일가고가시간	string	6</param>
/// <param name="dan_high">시간외단일가고가	int	8</param>
/// <param name="dan_lowtime">시간외단일가저가시간	string	6</param>
/// <param name="dan_low">시간외단일가저가	int	8</param>
/// <param name="dan_cgubun">시간외단일가체결구분	string	1</param>
/// <param name="dan_cvolume">시간외단일가체결량	int	8</param>
/// <param name="dan_volume">시간외단일가누적거래량	long	12</param>
/// <param name="dan_value">시간외단일가누적거래대금	long	12</param>
/// <param name="dan_mdvolume">시간외단일가매도누적체결량	long	12</param>
/// <param name="dan_mdchecnt">시간외단일가매도누적체결건수	int	8</param>
/// <param name="dan_msvolume">시간외단일가매수누적체결량	long	12</param>
/// <param name="dan_mschecnt">시간외단일가매수누적체결건수	int	8</param>
/// <param name="dan_prevolume">시간외단일가직전거래량	int	8</param>
/// <param name="dan_precvolume">시간외단일가직전체결수량	int	8</param>
/// <param name="dan_cpower">시간외단일가체결강도	double	9.2</param>
/// <param name="dan_status">시간외단일가장정보	string	2</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 201)]
public record DS3OutBlock(
    [BlockField("시간외단일가체결시간", 6)] string dan_chetime,
    [BlockField("시간외단일가전일대비구분", 1)] string dan_sign,
    [BlockField("시간외단일가전일대비", 8)] int dan_change,
    [BlockField("시간외단일가등락율", 6.2)] double dan_drate,
    [BlockField("시간외단일가현재가", 8)] int dan_price,
    [BlockField("시간외단일가시가시간", 6)] string dan_opentime,
    [BlockField("시간외단일가시가", 8)] int dan_open,
    [BlockField("시간외단일가고가시간", 6)] string dan_hightime,
    [BlockField("시간외단일가고가", 8)] int dan_high,
    [BlockField("시간외단일가저가시간", 6)] string dan_lowtime,
    [BlockField("시간외단일가저가", 8)] int dan_low,
    [BlockField("시간외단일가체결구분", 1)] string dan_cgubun,
    [BlockField("시간외단일가체결량", 8)] int dan_cvolume,
    [BlockField("시간외단일가누적거래량", 12)] long dan_volume,
    [BlockField("시간외단일가누적거래대금", 12)] long dan_value,
    [BlockField("시간외단일가매도누적체결량", 12)] long dan_mdvolume,
    [BlockField("시간외단일가매도누적체결건수", 8)] int dan_mdchecnt,
    [BlockField("시간외단일가매수누적체결량", 12)] long dan_msvolume,
    [BlockField("시간외단일가매수누적체결건수", 8)] int dan_mschecnt,
    [BlockField("시간외단일가직전거래량", 8)] int dan_prevolume,
    [BlockField("시간외단일가직전체결수량", 8)] int dan_precvolume,
    [BlockField("시간외단일가체결강도", 9.2)] double dan_cpower,
    [BlockField("시간외단일가장정보", 2)] string dan_status,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 시간외단일가VI발동해제: DVI
/// </summary>
/// <param name="shcode">단축코드(KEY)	string	6</param>
[BlockInfo(true, 7)]
public record DVIInBlock(
    [BlockField("단축코드(KEY)", 6)] string shcode
    );

/// <summary>
/// 시간외단일가VI발동해제: DVI
/// </summary>
/// <param name="vi_gubun">구분(0:해제 1:정적발동 2:동적발동 3:정적 and 동적)	string	1</param>
/// <param name="svi_recprice">정적VI발동기준가격	int	8</param>
/// <param name="dvi_recprice">동적VI발동기준가격	int	8</param>
/// <param name="vi_trgprice">VI발동가격	int	8</param>
/// <param name="shcode">단축코드(KEY)	string	6</param>
/// <param name="ref_shcode">참조코드(미사용)	string	6</param>
/// <param name="time">시간	string	6</param>
[BlockInfo(true, 50)]
public record DVIOutBlock(
    [BlockField("구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)", 1)] string vi_gubun,
    [BlockField("정적VI발동기준가격", 8)] int svi_recprice,
    [BlockField("동적VI발동기준가격", 8)] int dvi_recprice,
    [BlockField("VI발동가격", 8)] int vi_trgprice,
    [BlockField("단축코드(KEY)", 6)] string shcode,
    [BlockField("참조코드(미사용)", 6)] string ref_shcode,
    [BlockField("시간", 6)] string time
    );


/// <summary>
/// EUREX연계KP200지수옵션선물체결: EC0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record EC0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// EUREX연계KP200지수옵션선물체결: EC0
/// </summary>
/// <param name="chetime">체결시간(24시간)	string	6</param>
/// <param name="chetime1">체결시간(36시간)	string	6</param>
/// <param name="sign">정규장종가대비구분	string	1</param>
/// <param name="change">정규장종가대비	double	6.2</param>
/// <param name="drate">정규장종가기준등락율	double	6.2</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	6</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금(미제공)	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수(미제공)	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수(미제공)	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="openyak">미결제약정수량	int	8</param>
/// <param name="k200jisu">KOSPI200지수	double	6.2</param>
/// <param name="eqva">KOSPI등가	double	7.2</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="openyakcha">미결제약정증감	int	8</param>
/// <param name="timevalue">시간가치	double	6.2</param>
/// <param name="jgubun">장운영정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 240)]
public record EC0OutBlock(
    [BlockField("체결시간(24시간)", 6)] string chetime,
    [BlockField("체결시간(36시간)", 6)] string chetime1,
    [BlockField("정규장종가대비구분", 1)] string sign,
    [BlockField("정규장종가대비", 6.2)] double change,
    [BlockField("정규장종가기준등락율", 6.2)] double drate,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 6)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금(미제공)", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수(미제공)", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수(미제공)", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("미결제약정수량", 8)] int openyak,
    [BlockField("KOSPI200지수", 6.2)] double k200jisu,
    [BlockField("KOSPI등가", 7.2)] double eqva,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("미결제약정증감", 8)] int openyakcha,
    [BlockField("시간가치", 6.2)] double timevalue,
    [BlockField("장운영정보", 2)] string jgubun,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 8)] string optcode
    );


/// <summary>
/// EUREX연계KP200지수옵션선물호가: EH0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record EH0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// EUREX연계KP200지수옵션선물호가: EH0
/// </summary>
/// <param name="hotime">호가시간(24시간)	string	6</param>
/// <param name="hotime1">호가시간(36시간)	string	6</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="offerrem1">매도호가수량1	int	7</param>
/// <param name="bidrem1">매수호가수량1	int	7</param>
/// <param name="offercnt1">매도호가건수1(미제공)	int	5</param>
/// <param name="bidcnt1">매수호가건수1(미제공)	int	5</param>
/// <param name="offerho2">매도호가2	double	6.2</param>
/// <param name="bidho2">매수호가2	double	6.2</param>
/// <param name="offerrem2">매도호가수량2	int	7</param>
/// <param name="bidrem2">매수호가수량2	int	7</param>
/// <param name="offercnt2">매도호가건수2(미제공)	int	5</param>
/// <param name="bidcnt2">매수호가건수2(미제공)	int	5</param>
/// <param name="offerho3">매도호가3	double	6.2</param>
/// <param name="bidho3">매수호가3	double	6.2</param>
/// <param name="offerrem3">매도호가수량3	int	7</param>
/// <param name="bidrem3">매수호가수량3	int	7</param>
/// <param name="offercnt3">매도호가건수3(미제공)	int	5</param>
/// <param name="bidcnt3">매수호가건수3(미제공)	int	5</param>
/// <param name="offerho4">매도호가4(미제공)	double	6.2</param>
/// <param name="bidho4">매수호가4(미제공)	double	6.2</param>
/// <param name="offerrem4">매도호가수량4(미제공)	int	7</param>
/// <param name="bidrem4">매수호가수량4(미제공)	int	7</param>
/// <param name="offercnt4">매도호가건수4(미제공)	int	5</param>
/// <param name="bidcnt4">매수호가건수4(미제공)	int	5</param>
/// <param name="offerho5">매도호가5(미제공)	double	6.2</param>
/// <param name="bidho5">매수호가5(미제공)	double	6.2</param>
/// <param name="offerrem5">매도호가수량5(미제공)	int	7</param>
/// <param name="bidrem5">매수호가수량5(미제공)	int	7</param>
/// <param name="offercnt5">매도호가건수5(미제공)	int	5</param>
/// <param name="bidcnt5">매수호가건수5(미제공)	int	5</param>
/// <param name="totofferrem">매도호가총수량	int	7</param>
/// <param name="totbidrem">매수호가총수량	int	7</param>
/// <param name="totoffercnt">매도호가총건수	int	5</param>
/// <param name="totbidcnt">매수호가총건수	int	5</param>
/// <param name="optcode">단축코드	string	8</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
[BlockInfo(true, 263)]
public record EH0OutBlock(
    [BlockField("호가시간(24시간)", 6)] string hotime,
    [BlockField("호가시간(36시간)", 6)] string hotime1,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("매도호가수량1", 7)] int offerrem1,
    [BlockField("매수호가수량1", 7)] int bidrem1,
    [BlockField("매도호가건수1(미제공)", 5)] int offercnt1,
    [BlockField("매수호가건수1(미제공)", 5)] int bidcnt1,
    [BlockField("매도호가2", 6.2)] double offerho2,
    [BlockField("매수호가2", 6.2)] double bidho2,
    [BlockField("매도호가수량2", 7)] int offerrem2,
    [BlockField("매수호가수량2", 7)] int bidrem2,
    [BlockField("매도호가건수2(미제공)", 5)] int offercnt2,
    [BlockField("매수호가건수2(미제공)", 5)] int bidcnt2,
    [BlockField("매도호가3", 6.2)] double offerho3,
    [BlockField("매수호가3", 6.2)] double bidho3,
    [BlockField("매도호가수량3", 7)] int offerrem3,
    [BlockField("매수호가수량3", 7)] int bidrem3,
    [BlockField("매도호가건수3(미제공)", 5)] int offercnt3,
    [BlockField("매수호가건수3(미제공)", 5)] int bidcnt3,
    [BlockField("매도호가4(미제공)", 6.2)] double offerho4,
    [BlockField("매수호가4(미제공)", 6.2)] double bidho4,
    [BlockField("매도호가수량4(미제공)", 7)] int offerrem4,
    [BlockField("매수호가수량4(미제공)", 7)] int bidrem4,
    [BlockField("매도호가건수4(미제공)", 5)] int offercnt4,
    [BlockField("매수호가건수4(미제공)", 5)] int bidcnt4,
    [BlockField("매도호가5(미제공)", 6.2)] double offerho5,
    [BlockField("매수호가5(미제공)", 6.2)] double bidho5,
    [BlockField("매도호가수량5(미제공)", 7)] int offerrem5,
    [BlockField("매수호가수량5(미제공)", 7)] int bidrem5,
    [BlockField("매도호가건수5(미제공)", 5)] int offercnt5,
    [BlockField("매수호가건수5(미제공)", 5)] int bidcnt5,
    [BlockField("매도호가총수량", 7)] int totofferrem,
    [BlockField("매수호가총수량", 7)] int totbidrem,
    [BlockField("매도호가총건수", 5)] int totoffercnt,
    [BlockField("매수호가총건수", 5)] int totbidcnt,
    [BlockField("단축코드", 8)] string optcode,
    [BlockField("단일가호가여부", 1)] string danhochk
    );


/// <summary>
/// 뉴ELW투자지표민감도: ESN
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record ESNInBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// 뉴ELW투자지표민감도: ESN
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="theoryprice">장중이론가	double	10.2</param>
/// <param name="delt">델타	double	7.6</param>
/// <param name="gama">감마	double	7.6</param>
/// <param name="ceta">세타	double	12.6</param>
/// <param name="vega">베가	double	12.6</param>
/// <param name="rhox">로우	double	12.6</param>
/// <param name="impv">내재변동성	double	5.2</param>
/// <param name="egearing">E.기어링	double	8.2</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="elwclose">ELW현재가	int	8</param>
/// <param name="sign">ELW전일대비구분	string	1</param>
/// <param name="change">ELW전일대비	int	8</param>
/// <param name="date">일자	string	8</param>
/// <param name="tickvalue">틱환산	double	10.2</param>
/// <param name="lp_impv">LP내재변동성	double	5.2</param>
[BlockInfo(true, 141)]
public record ESNOutBlock(
    [BlockField("시간", 6)] string time,
    [BlockField("장중이론가", 10.2)] double theoryprice,
    [BlockField("델타", 7.6)] double delt,
    [BlockField("감마", 7.6)] double gama,
    [BlockField("세타", 12.6)] double ceta,
    [BlockField("베가", 12.6)] double vega,
    [BlockField("로우", 12.6)] double rhox,
    [BlockField("내재변동성", 5.2)] double impv,
    [BlockField("E.기어링", 8.2)] double egearing,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("ELW현재가", 8)] int elwclose,
    [BlockField("ELW전일대비구분", 1)] string sign,
    [BlockField("ELW전일대비", 8)] int change,
    [BlockField("일자", 8)] string date,
    [BlockField("틱환산", 10.2)] double tickvalue,
    [BlockField("LP내재변동성", 5.2)] double lp_impv
    );


/// <summary>
/// EUX접수: EU0
/// </summary>
[BlockInfo(false, 0)]
public record EU0InBlock(
    );

/// <summary>
/// EUX접수: EU0
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="trcode1">tr코드	string	4</param>
/// <param name="firmno">회사번호	string	3</param>
/// <param name="acntno">계좌번호	string	11</param>
/// <param name="acntno1">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="brnno">지점번호	string	3</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordno1">주문번호	string	3</param>
/// <param name="ordno">주문번호	int	7</param>
/// <param name="orgordno1">원주문번호	string	3</param>
/// <param name="orgordno">원주문번호	int	7</param>
/// <param name="prntordno">모주문번호	string	3</param>
/// <param name="prntordno1">모주문번호	int	7</param>
/// <param name="isuno">종목번호	string	12</param>
/// <param name="fnoIsuno">선물옵션종목번호	string	8</param>
/// <param name="fnoIsunm">선물옵션종목명	string	40</param>
/// <param name="pdgrpcode">상품군분류코드	string	2</param>
/// <param name="fnoIsuptntp">선물옵션종목유형구분	string	1</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="mrctp">정정취소구분	string	1</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="hogatype">호가유형코드	string	2</param>
/// <param name="mmgb">거래유형코드	string	2</param>
/// <param name="ordprc">주문가격	double	13.2</param>
/// <param name="unercqty">미체결수량	long	16</param>
/// <param name="commdacode">통신매체	string	2</param>
/// <param name="peeamtcode">수수료합산코드	string	2</param>
/// <param name="mgempno">관리사원	string	9</param>
/// <param name="fnotrdunitamt">선물옵션거래단위금액	double	19.8</param>
/// <param name="trxtime">처리시각	string	9</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	string	10</param>
/// <param name="ptflno">포트폴리오 번호	string	10</param>
/// <param name="bskno">바스켓번호	string	10</param>
/// <param name="trchno">트렌치번호	string	10</param>
/// <param name="Itemno">아이템번호	string	10</param>
/// <param name="OrderID">주문자Id	string	16</param>
/// <param name="opdrtnno">운영지시번호	string	12</param>
/// <param name="rjtcode">부적격코드	string	4</param>
/// <param name="mrccnfqty">정정취소확인수량	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmrcqty">원주문정정취소수량	long	16</param>
/// <param name="ctrcttime">약정시각(체결시각)	string	8</param>
/// <param name="ctrctno">약정번호	string	10</param>
/// <param name="execprc">체결가격	double	13.2</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="newqty">신규체결수량	long	16</param>
/// <param name="qdtqty">청산체결수량	long	16</param>
/// <param name="lastqty">최종결제수량	long	16</param>
/// <param name="lallexecqty">전체체결수량	long	16</param>
/// <param name="allexecamt">전체체결금액	long	16</param>
/// <param name="fnobalevaltp">잔고평가구분	string	1</param>
/// <param name="bnsplamt">매매손익금액	long	16</param>
/// <param name="fnoIsuno1">선물옵션종목번호1	string	8</param>
/// <param name="bnstp1">매매구분1	string	1</param>
/// <param name="execprc1">체결가1	double	13.2</param>
/// <param name="newqty1">신규체결수량1	long	16</param>
/// <param name="qdtqty1">청산체결수량1	long	16</param>
/// <param name="allexecamt1">전체체결금액1	long	16</param>
/// <param name="fnoIsuno2">선물옵션종목번호2	string	8</param>
/// <param name="bnstp2">매매구분2	string	1</param>
/// <param name="execprc2">체결가2	double	13.2</param>
/// <param name="newqty2">신규체결수량2	long	16</param>
/// <param name="lqdtqty2">청산체결수량2	long	16</param>
/// <param name="allexecamt2">전체체결금액2	long	16</param>
/// <param name="dps">예수금	long	16</param>
/// <param name="ftsubtdsgnamt">선물대용지정금액	long	16</param>
/// <param name="mgn">증거금	long	16</param>
/// <param name="mnymgn">증거금현금	long	16</param>
/// <param name="ordableamt">주문가능금액	long	16</param>
/// <param name="mnyordableamt">주문가능현금액	long	16</param>
/// <param name="fnoIsuno_1">잔고 종목번호1	string	8</param>
/// <param name="bnstp_1">잔고 매매구분1	string	1</param>
/// <param name="unsttqty_1">미결제수량1	long	16</param>
/// <param name="lqdtableqty_1">주문가능수량1	long	16</param>
/// <param name="avrprc_1">평균가1	double	13.2</param>
/// <param name="fnoIsuno_2">잔고 종목번호2	string	8</param>
/// <param name="bnstp_2">잔고 매매구분2	string	1</param>
/// <param name="unsttqty_2">미결제수량2	long	16</param>
/// <param name="lqdtableqty_2">주문가능수량2	long	16</param>
/// <param name="avrprc_2">평균가2	double	13.2</param>
[BlockInfo(false, 1142)]
public record EU0OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("tr코드", 4)] string trcode1,
    [BlockField("회사번호", 3)] string firmno,
    [BlockField("계좌번호", 11)] string acntno,
    [BlockField("계좌번호", 9)] string acntno1,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("지점번호", 3)] string brnno,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문번호", 3)] string ordno1,
    [BlockField("주문번호", 7)] int ordno,
    [BlockField("원주문번호", 3)] string orgordno1,
    [BlockField("원주문번호", 7)] int orgordno,
    [BlockField("모주문번호", 3)] string prntordno,
    [BlockField("모주문번호", 7)] int prntordno1,
    [BlockField("종목번호", 12)] string isuno,
    [BlockField("선물옵션종목번호", 8)] string fnoIsuno,
    [BlockField("선물옵션종목명", 40)] string fnoIsunm,
    [BlockField("상품군분류코드", 2)] string pdgrpcode,
    [BlockField("선물옵션종목유형구분", 1)] string fnoIsuptntp,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("정정취소구분", 1)] string mrctp,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("호가유형코드", 2)] string hogatype,
    [BlockField("거래유형코드", 2)] string mmgb,
    [BlockField("주문가격", 13.2)] double ordprc,
    [BlockField("미체결수량", 16)] long unercqty,
    [BlockField("통신매체", 2)] string commdacode,
    [BlockField("수수료합산코드", 2)] string peeamtcode,
    [BlockField("관리사원", 9)] string mgempno,
    [BlockField("선물옵션거래단위금액", 19.8)] double fnotrdunitamt,
    [BlockField("처리시각", 9)] string trxtime,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] string ordseqno,
    [BlockField("포트폴리오 번호", 10)] string ptflno,
    [BlockField("바스켓번호", 10)] string bskno,
    [BlockField("트렌치번호", 10)] string trchno,
    [BlockField("아이템번호", 10)] string Itemno,
    [BlockField("주문자Id", 16)] string OrderID,
    [BlockField("운영지시번호", 12)] string opdrtnno,
    [BlockField("부적격코드", 4)] string rjtcode,
    [BlockField("정정취소확인수량", 16)] long mrccnfqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정취소수량", 16)] long orgordmrcqty,
    [BlockField("약정시각(체결시각)", 8)] string ctrcttime,
    [BlockField("약정번호", 10)] string ctrctno,
    [BlockField("체결가격", 13.2)] double execprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("신규체결수량", 16)] long newqty,
    [BlockField("청산체결수량", 16)] long qdtqty,
    [BlockField("최종결제수량", 16)] long lastqty,
    [BlockField("전체체결수량", 16)] long lallexecqty,
    [BlockField("전체체결금액", 16)] long allexecamt,
    [BlockField("잔고평가구분", 1)] string fnobalevaltp,
    [BlockField("매매손익금액", 16)] long bnsplamt,
    [BlockField("선물옵션종목번호1", 8)] string fnoIsuno1,
    [BlockField("매매구분1", 1)] string bnstp1,
    [BlockField("체결가1", 13.2)] double execprc1,
    [BlockField("신규체결수량1", 16)] long newqty1,
    [BlockField("청산체결수량1", 16)] long qdtqty1,
    [BlockField("전체체결금액1", 16)] long allexecamt1,
    [BlockField("선물옵션종목번호2", 8)] string fnoIsuno2,
    [BlockField("매매구분2", 1)] string bnstp2,
    [BlockField("체결가2", 13.2)] double execprc2,
    [BlockField("신규체결수량2", 16)] long newqty2,
    [BlockField("청산체결수량2", 16)] long lqdtqty2,
    [BlockField("전체체결금액2", 16)] long allexecamt2,
    [BlockField("예수금", 16)] long dps,
    [BlockField("선물대용지정금액", 16)] long ftsubtdsgnamt,
    [BlockField("증거금", 16)] long mgn,
    [BlockField("증거금현금", 16)] long mnymgn,
    [BlockField("주문가능금액", 16)] long ordableamt,
    [BlockField("주문가능현금액", 16)] long mnyordableamt,
    [BlockField("잔고 종목번호1", 8)] string fnoIsuno_1,
    [BlockField("잔고 매매구분1", 1)] string bnstp_1,
    [BlockField("미결제수량1", 16)] long unsttqty_1,
    [BlockField("주문가능수량1", 16)] long lqdtableqty_1,
    [BlockField("평균가1", 13.2)] double avrprc_1,
    [BlockField("잔고 종목번호2", 8)] string fnoIsuno_2,
    [BlockField("잔고 매매구분2", 1)] string bnstp_2,
    [BlockField("미결제수량2", 16)] long unsttqty_2,
    [BlockField("주문가능수량2", 16)] long lqdtableqty_2,
    [BlockField("평균가2", 13.2)] double avrprc_2
    );


/// <summary>
/// EUX체결: EU1
/// </summary>
[BlockInfo(false, 0)]
public record EU1InBlock(
    );

/// <summary>
/// EUX체결: EU1
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="trcode1">tr코드	string	4</param>
/// <param name="firmno">회사번호	string	3</param>
/// <param name="acntno">계좌번호	string	11</param>
/// <param name="acntno1">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="brnno">지점번호	string	3</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordno1">주문번호	string	3</param>
/// <param name="ordno">주문번호	int	7</param>
/// <param name="orgordno1">원주문번호	string	3</param>
/// <param name="orgordno">원주문번호	int	7</param>
/// <param name="prntordno">모주문번호	string	3</param>
/// <param name="prntordno1">모주문번호	int	7</param>
/// <param name="isuno">종목번호	string	12</param>
/// <param name="fnoIsuno">선물옵션종목번호	string	8</param>
/// <param name="fnoIsunm">선물옵션종목명	string	40</param>
/// <param name="pdgrpcode">상품군분류코드	string	2</param>
/// <param name="fnoIsuptntp">선물옵션종목유형구분	string	1</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="mrctp">정정취소구분	string	1</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="hogatype">호가유형코드	string	2</param>
/// <param name="mmgb">거래유형코드	string	2</param>
/// <param name="ordprc">주문가격	double	13.2</param>
/// <param name="unercqty">미체결수량	long	16</param>
/// <param name="commdacode">통신매체	string	2</param>
/// <param name="peeamtcode">수수료합산코드	string	2</param>
/// <param name="mgempno">관리사원	string	9</param>
/// <param name="fnotrdunitamt">선물옵션거래단위금액	double	19.8</param>
/// <param name="trxtime">처리시각	string	9</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	string	10</param>
/// <param name="ptflno">포트폴리오 번호	string	10</param>
/// <param name="bskno">바스켓번호	string	10</param>
/// <param name="trchno">트렌치번호	string	10</param>
/// <param name="Itemno">아이템번호	string	10</param>
/// <param name="OrderID">주문자Id	string	16</param>
/// <param name="opdrtnno">운영지시번호	string	12</param>
/// <param name="rjtcode">부적격코드	string	4</param>
/// <param name="mrccnfqty">정정취소확인수량	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmrcqty">원주문정정취소수량	long	16</param>
/// <param name="ctrcttime">약정시각(체결시각)	string	8</param>
/// <param name="ctrctno">약정번호	string	10</param>
/// <param name="execprc">체결가격	double	13.2</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="newqty">신규체결수량	long	16</param>
/// <param name="qdtqty">청산체결수량	long	16</param>
/// <param name="lastqty">최종결제수량	long	16</param>
/// <param name="lallexecqty">전체체결수량	long	16</param>
/// <param name="allexecamt">전체체결금액	long	16</param>
/// <param name="fnobalevaltp">잔고평가구분	string	1</param>
/// <param name="bnsplamt">매매손익금액	long	16</param>
/// <param name="fnoIsuno1">선물옵션종목번호1	string	8</param>
/// <param name="bnstp1">매매구분1	string	1</param>
/// <param name="execprc1">체결가1	double	13.2</param>
/// <param name="newqty1">신규체결수량1	long	16</param>
/// <param name="qdtqty1">청산체결수량1	long	16</param>
/// <param name="allexecamt1">전체체결금액1	long	16</param>
/// <param name="fnoIsuno2">선물옵션종목번호2	string	8</param>
/// <param name="bnstp2">매매구분2	string	1</param>
/// <param name="execprc2">체결가2	double	13.2</param>
/// <param name="newqty2">신규체결수량2	long	16</param>
/// <param name="lqdtqty2">청산체결수량2	long	16</param>
/// <param name="allexecamt2">전체체결금액2	long	16</param>
/// <param name="dps">예수금	long	16</param>
/// <param name="ftsubtdsgnamt">선물대용지정금액	long	16</param>
/// <param name="mgn">증거금	long	16</param>
/// <param name="mnymgn">증거금현금	long	16</param>
/// <param name="ordableamt">주문가능금액	long	16</param>
/// <param name="mnyordableamt">주문가능현금액	long	16</param>
/// <param name="fnoIsuno_1">잔고 종목번호1	string	8</param>
/// <param name="bnstp_1">잔고 매매구분1	string	1</param>
/// <param name="unsttqty_1">미결제수량1	long	16</param>
/// <param name="lqdtableqty_1">주문가능수량1	long	16</param>
/// <param name="avrprc_1">평균가1	double	13.2</param>
/// <param name="fnoIsuno_2">잔고 종목번호2	string	8</param>
/// <param name="bnstp_2">잔고 매매구분2	string	1</param>
/// <param name="unsttqty_2">미결제수량2	long	16</param>
/// <param name="lqdtableqty_2">주문가능수량2	long	16</param>
/// <param name="avrprc_2">평균가2	double	13.2</param>
[BlockInfo(false, 1142)]
public record EU1OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("tr코드", 4)] string trcode1,
    [BlockField("회사번호", 3)] string firmno,
    [BlockField("계좌번호", 11)] string acntno,
    [BlockField("계좌번호", 9)] string acntno1,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("지점번호", 3)] string brnno,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문번호", 3)] string ordno1,
    [BlockField("주문번호", 7)] int ordno,
    [BlockField("원주문번호", 3)] string orgordno1,
    [BlockField("원주문번호", 7)] int orgordno,
    [BlockField("모주문번호", 3)] string prntordno,
    [BlockField("모주문번호", 7)] int prntordno1,
    [BlockField("종목번호", 12)] string isuno,
    [BlockField("선물옵션종목번호", 8)] string fnoIsuno,
    [BlockField("선물옵션종목명", 40)] string fnoIsunm,
    [BlockField("상품군분류코드", 2)] string pdgrpcode,
    [BlockField("선물옵션종목유형구분", 1)] string fnoIsuptntp,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("정정취소구분", 1)] string mrctp,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("호가유형코드", 2)] string hogatype,
    [BlockField("거래유형코드", 2)] string mmgb,
    [BlockField("주문가격", 13.2)] double ordprc,
    [BlockField("미체결수량", 16)] long unercqty,
    [BlockField("통신매체", 2)] string commdacode,
    [BlockField("수수료합산코드", 2)] string peeamtcode,
    [BlockField("관리사원", 9)] string mgempno,
    [BlockField("선물옵션거래단위금액", 19.8)] double fnotrdunitamt,
    [BlockField("처리시각", 9)] string trxtime,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] string ordseqno,
    [BlockField("포트폴리오 번호", 10)] string ptflno,
    [BlockField("바스켓번호", 10)] string bskno,
    [BlockField("트렌치번호", 10)] string trchno,
    [BlockField("아이템번호", 10)] string Itemno,
    [BlockField("주문자Id", 16)] string OrderID,
    [BlockField("운영지시번호", 12)] string opdrtnno,
    [BlockField("부적격코드", 4)] string rjtcode,
    [BlockField("정정취소확인수량", 16)] long mrccnfqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정취소수량", 16)] long orgordmrcqty,
    [BlockField("약정시각(체결시각)", 8)] string ctrcttime,
    [BlockField("약정번호", 10)] string ctrctno,
    [BlockField("체결가격", 13.2)] double execprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("신규체결수량", 16)] long newqty,
    [BlockField("청산체결수량", 16)] long qdtqty,
    [BlockField("최종결제수량", 16)] long lastqty,
    [BlockField("전체체결수량", 16)] long lallexecqty,
    [BlockField("전체체결금액", 16)] long allexecamt,
    [BlockField("잔고평가구분", 1)] string fnobalevaltp,
    [BlockField("매매손익금액", 16)] long bnsplamt,
    [BlockField("선물옵션종목번호1", 8)] string fnoIsuno1,
    [BlockField("매매구분1", 1)] string bnstp1,
    [BlockField("체결가1", 13.2)] double execprc1,
    [BlockField("신규체결수량1", 16)] long newqty1,
    [BlockField("청산체결수량1", 16)] long qdtqty1,
    [BlockField("전체체결금액1", 16)] long allexecamt1,
    [BlockField("선물옵션종목번호2", 8)] string fnoIsuno2,
    [BlockField("매매구분2", 1)] string bnstp2,
    [BlockField("체결가2", 13.2)] double execprc2,
    [BlockField("신규체결수량2", 16)] long newqty2,
    [BlockField("청산체결수량2", 16)] long lqdtqty2,
    [BlockField("전체체결금액2", 16)] long allexecamt2,
    [BlockField("예수금", 16)] long dps,
    [BlockField("선물대용지정금액", 16)] long ftsubtdsgnamt,
    [BlockField("증거금", 16)] long mgn,
    [BlockField("증거금현금", 16)] long mnymgn,
    [BlockField("주문가능금액", 16)] long ordableamt,
    [BlockField("주문가능현금액", 16)] long mnyordableamt,
    [BlockField("잔고 종목번호1", 8)] string fnoIsuno_1,
    [BlockField("잔고 매매구분1", 1)] string bnstp_1,
    [BlockField("미결제수량1", 16)] long unsttqty_1,
    [BlockField("주문가능수량1", 16)] long lqdtableqty_1,
    [BlockField("평균가1", 13.2)] double avrprc_1,
    [BlockField("잔고 종목번호2", 8)] string fnoIsuno_2,
    [BlockField("잔고 매매구분2", 1)] string bnstp_2,
    [BlockField("미결제수량2", 16)] long unsttqty_2,
    [BlockField("주문가능수량2", 16)] long lqdtableqty_2,
    [BlockField("평균가2", 13.2)] double avrprc_2
    );


/// <summary>
/// EUX확인: EU2
/// </summary>
[BlockInfo(false, 0)]
public record EU2InBlock(
    );

/// <summary>
/// EUX확인: EU2
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="trcode1">tr코드	string	4</param>
/// <param name="firmno">회사번호	string	3</param>
/// <param name="acntno">계좌번호	string	11</param>
/// <param name="acntno1">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="brnno">지점번호	string	3</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordno1">주문번호	string	3</param>
/// <param name="ordno">주문번호	int	7</param>
/// <param name="orgordno1">원주문번호	string	3</param>
/// <param name="orgordno">원주문번호	int	7</param>
/// <param name="prntordno">모주문번호	string	3</param>
/// <param name="prntordno1">모주문번호	int	7</param>
/// <param name="isuno">종목번호	string	12</param>
/// <param name="fnoIsuno">선물옵션종목번호	string	8</param>
/// <param name="fnoIsunm">선물옵션종목명	string	40</param>
/// <param name="pdgrpcode">상품군분류코드	string	2</param>
/// <param name="fnoIsuptntp">선물옵션종목유형구분	string	1</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="mrctp">정정취소구분	string	1</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="hogatype">호가유형코드	string	2</param>
/// <param name="mmgb">거래유형코드	string	2</param>
/// <param name="ordprc">주문가격	double	13.2</param>
/// <param name="unercqty">미체결수량	long	16</param>
/// <param name="commdacode">통신매체	string	2</param>
/// <param name="peeamtcode">수수료합산코드	string	2</param>
/// <param name="mgempno">관리사원	string	9</param>
/// <param name="fnotrdunitamt">선물옵션거래단위금액	double	19.8</param>
/// <param name="trxtime">처리시각	string	9</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	string	10</param>
/// <param name="ptflno">포트폴리오 번호	string	10</param>
/// <param name="bskno">바스켓번호	string	10</param>
/// <param name="trchno">트렌치번호	string	10</param>
/// <param name="Itemno">아이템번호	string	10</param>
/// <param name="OrderID">주문자Id	string	16</param>
/// <param name="opdrtnno">운영지시번호	string	12</param>
/// <param name="rjtcode">부적격코드	string	4</param>
/// <param name="mrccnfqty">정정취소확인수량	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmrcqty">원주문정정취소수량	long	16</param>
/// <param name="ctrcttime">약정시각(체결시각)	string	8</param>
/// <param name="ctrctno">약정번호	string	10</param>
/// <param name="execprc">체결가격	double	13.2</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="newqty">신규체결수량	long	16</param>
/// <param name="qdtqty">청산체결수량	long	16</param>
/// <param name="lastqty">최종결제수량	long	16</param>
/// <param name="lallexecqty">전체체결수량	long	16</param>
/// <param name="allexecamt">전체체결금액	long	16</param>
/// <param name="fnobalevaltp">잔고평가구분	string	1</param>
/// <param name="bnsplamt">매매손익금액	long	16</param>
/// <param name="fnoIsuno1">선물옵션종목번호1	string	8</param>
/// <param name="bnstp1">매매구분1	string	1</param>
/// <param name="execprc1">체결가1	double	13.2</param>
/// <param name="newqty1">신규체결수량1	long	16</param>
/// <param name="qdtqty1">청산체결수량1	long	16</param>
/// <param name="allexecamt1">전체체결금액1	long	16</param>
/// <param name="fnoIsuno2">선물옵션종목번호2	string	8</param>
/// <param name="bnstp2">매매구분2	string	1</param>
/// <param name="execprc2">체결가2	double	13.2</param>
/// <param name="newqty2">신규체결수량2	long	16</param>
/// <param name="lqdtqty2">청산체결수량2	long	16</param>
/// <param name="allexecamt2">전체체결금액2	long	16</param>
/// <param name="dps">예수금	long	16</param>
/// <param name="ftsubtdsgnamt">선물대용지정금액	long	16</param>
/// <param name="mgn">증거금	long	16</param>
/// <param name="mnymgn">증거금현금	long	16</param>
/// <param name="ordableamt">주문가능금액	long	16</param>
/// <param name="mnyordableamt">주문가능현금액	long	16</param>
/// <param name="fnoIsuno_1">잔고 종목번호1	string	8</param>
/// <param name="bnstp_1">잔고 매매구분1	string	1</param>
/// <param name="unsttqty_1">미결제수량1	long	16</param>
/// <param name="lqdtableqty_1">주문가능수량1	long	16</param>
/// <param name="avrprc_1">평균가1	double	13.2</param>
/// <param name="fnoIsuno_2">잔고 종목번호2	string	8</param>
/// <param name="bnstp_2">잔고 매매구분2	string	1</param>
/// <param name="unsttqty_2">미결제수량2	long	16</param>
/// <param name="lqdtableqty_2">주문가능수량2	long	16</param>
/// <param name="avrprc_2">평균가2	double	13.2</param>
[BlockInfo(false, 1142)]
public record EU2OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("tr코드", 4)] string trcode1,
    [BlockField("회사번호", 3)] string firmno,
    [BlockField("계좌번호", 11)] string acntno,
    [BlockField("계좌번호", 9)] string acntno1,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("지점번호", 3)] string brnno,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문번호", 3)] string ordno1,
    [BlockField("주문번호", 7)] int ordno,
    [BlockField("원주문번호", 3)] string orgordno1,
    [BlockField("원주문번호", 7)] int orgordno,
    [BlockField("모주문번호", 3)] string prntordno,
    [BlockField("모주문번호", 7)] int prntordno1,
    [BlockField("종목번호", 12)] string isuno,
    [BlockField("선물옵션종목번호", 8)] string fnoIsuno,
    [BlockField("선물옵션종목명", 40)] string fnoIsunm,
    [BlockField("상품군분류코드", 2)] string pdgrpcode,
    [BlockField("선물옵션종목유형구분", 1)] string fnoIsuptntp,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("정정취소구분", 1)] string mrctp,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("호가유형코드", 2)] string hogatype,
    [BlockField("거래유형코드", 2)] string mmgb,
    [BlockField("주문가격", 13.2)] double ordprc,
    [BlockField("미체결수량", 16)] long unercqty,
    [BlockField("통신매체", 2)] string commdacode,
    [BlockField("수수료합산코드", 2)] string peeamtcode,
    [BlockField("관리사원", 9)] string mgempno,
    [BlockField("선물옵션거래단위금액", 19.8)] double fnotrdunitamt,
    [BlockField("처리시각", 9)] string trxtime,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] string ordseqno,
    [BlockField("포트폴리오 번호", 10)] string ptflno,
    [BlockField("바스켓번호", 10)] string bskno,
    [BlockField("트렌치번호", 10)] string trchno,
    [BlockField("아이템번호", 10)] string Itemno,
    [BlockField("주문자Id", 16)] string OrderID,
    [BlockField("운영지시번호", 12)] string opdrtnno,
    [BlockField("부적격코드", 4)] string rjtcode,
    [BlockField("정정취소확인수량", 16)] long mrccnfqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정취소수량", 16)] long orgordmrcqty,
    [BlockField("약정시각(체결시각)", 8)] string ctrcttime,
    [BlockField("약정번호", 10)] string ctrctno,
    [BlockField("체결가격", 13.2)] double execprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("신규체결수량", 16)] long newqty,
    [BlockField("청산체결수량", 16)] long qdtqty,
    [BlockField("최종결제수량", 16)] long lastqty,
    [BlockField("전체체결수량", 16)] long lallexecqty,
    [BlockField("전체체결금액", 16)] long allexecamt,
    [BlockField("잔고평가구분", 1)] string fnobalevaltp,
    [BlockField("매매손익금액", 16)] long bnsplamt,
    [BlockField("선물옵션종목번호1", 8)] string fnoIsuno1,
    [BlockField("매매구분1", 1)] string bnstp1,
    [BlockField("체결가1", 13.2)] double execprc1,
    [BlockField("신규체결수량1", 16)] long newqty1,
    [BlockField("청산체결수량1", 16)] long qdtqty1,
    [BlockField("전체체결금액1", 16)] long allexecamt1,
    [BlockField("선물옵션종목번호2", 8)] string fnoIsuno2,
    [BlockField("매매구분2", 1)] string bnstp2,
    [BlockField("체결가2", 13.2)] double execprc2,
    [BlockField("신규체결수량2", 16)] long newqty2,
    [BlockField("청산체결수량2", 16)] long lqdtqty2,
    [BlockField("전체체결금액2", 16)] long allexecamt2,
    [BlockField("예수금", 16)] long dps,
    [BlockField("선물대용지정금액", 16)] long ftsubtdsgnamt,
    [BlockField("증거금", 16)] long mgn,
    [BlockField("증거금현금", 16)] long mnymgn,
    [BlockField("주문가능금액", 16)] long ordableamt,
    [BlockField("주문가능현금액", 16)] long mnyordableamt,
    [BlockField("잔고 종목번호1", 8)] string fnoIsuno_1,
    [BlockField("잔고 매매구분1", 1)] string bnstp_1,
    [BlockField("미결제수량1", 16)] long unsttqty_1,
    [BlockField("주문가능수량1", 16)] long lqdtableqty_1,
    [BlockField("평균가1", 13.2)] double avrprc_1,
    [BlockField("잔고 종목번호2", 8)] string fnoIsuno_2,
    [BlockField("잔고 매매구분2", 1)] string bnstp_2,
    [BlockField("미결제수량2", 16)] long unsttqty_2,
    [BlockField("주문가능수량2", 16)] long lqdtableqty_2,
    [BlockField("평균가2", 13.2)] double avrprc_2
    );


/// <summary>
/// KOSPI200선물체결(C0): FC0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record FC0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// KOSPI200선물체결(C0): FC0
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	6</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="openyak">미결제약정수량	int	8</param>
/// <param name="k200jisu">KOSPI200지수	double	6.2</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="kasis">괴리율	double	6.2</param>
/// <param name="sbasis">시장BASIS	double	6.2</param>
/// <param name="ibasis">이론BASIS	double	6.2</param>
/// <param name="openyakcha">미결제약정증감	int	8</param>
/// <param name="jgubun">장운영정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 232)]
public record FC0OutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 6)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("미결제약정수량", 8)] int openyak,
    [BlockField("KOSPI200지수", 6.2)] double k200jisu,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("괴리율", 6.2)] double kasis,
    [BlockField("시장BASIS", 6.2)] double sbasis,
    [BlockField("이론BASIS", 6.2)] double ibasis,
    [BlockField("미결제약정증감", 8)] int openyakcha,
    [BlockField("장운영정보", 2)] string jgubun,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record FD0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 31)]
public record FD0OutBlock(
    [BlockField("접속매매여부", 1)] string gubun,
    [BlockField("실시간가격제한여부", 1)] string dy_gubun,
    [BlockField("실시간상한가", 8.2)] double dy_uplmtprice,
    [BlockField("실시간하한가", 8.2)] double dy_dnlmtprice,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// KOSPI200선물호가(H0): FH0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record FH0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// KOSPI200선물호가(H0): FH0
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="offerrem1">매도호가수량1	int	6</param>
/// <param name="bidrem1">매수호가수량1	int	6</param>
/// <param name="offercnt1">매도호가건수1	int	5</param>
/// <param name="bidcnt1">매수호가건수1	int	5</param>
/// <param name="offerho2">매도호가2	double	6.2</param>
/// <param name="bidho2">매수호가2	double	6.2</param>
/// <param name="offerrem2">매도호가수량2	int	6</param>
/// <param name="bidrem2">매수호가수량2	int	6</param>
/// <param name="offercnt2">매도호가건수2	int	5</param>
/// <param name="bidcnt2">매수호가건수2	int	5</param>
/// <param name="offerho3">매도호가3	double	6.2</param>
/// <param name="bidho3">매수호가3	double	6.2</param>
/// <param name="offerrem3">매도호가수량3	int	6</param>
/// <param name="bidrem3">매수호가수량3	int	6</param>
/// <param name="offercnt3">매도호가건수3	int	5</param>
/// <param name="bidcnt3">매수호가건수3	int	5</param>
/// <param name="offerho4">매도호가4	double	6.2</param>
/// <param name="bidho4">매수호가4	double	6.2</param>
/// <param name="offerrem4">매도호가수량4	int	6</param>
/// <param name="bidrem4">매수호가수량4	int	6</param>
/// <param name="offercnt4">매도호가건수4	int	5</param>
/// <param name="bidcnt4">매수호가건수4	int	5</param>
/// <param name="offerho5">매도호가5	double	6.2</param>
/// <param name="bidho5">매수호가5	double	6.2</param>
/// <param name="offerrem5">매도호가수량5	int	6</param>
/// <param name="bidrem5">매수호가수량5	int	6</param>
/// <param name="offercnt5">매도호가건수5	int	5</param>
/// <param name="bidcnt5">매수호가건수5	int	5</param>
/// <param name="totofferrem">매도호가총수량	int	6</param>
/// <param name="totbidrem">매수호가총수량	int	6</param>
/// <param name="totoffercnt">매도호가총건수	int	5</param>
/// <param name="totbidcnt">매수호가총건수	int	5</param>
/// <param name="futcode">단축코드	string	8</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
[BlockInfo(true, 246)]
public record FH0OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("매도호가수량1", 6)] int offerrem1,
    [BlockField("매수호가수량1", 6)] int bidrem1,
    [BlockField("매도호가건수1", 5)] int offercnt1,
    [BlockField("매수호가건수1", 5)] int bidcnt1,
    [BlockField("매도호가2", 6.2)] double offerho2,
    [BlockField("매수호가2", 6.2)] double bidho2,
    [BlockField("매도호가수량2", 6)] int offerrem2,
    [BlockField("매수호가수량2", 6)] int bidrem2,
    [BlockField("매도호가건수2", 5)] int offercnt2,
    [BlockField("매수호가건수2", 5)] int bidcnt2,
    [BlockField("매도호가3", 6.2)] double offerho3,
    [BlockField("매수호가3", 6.2)] double bidho3,
    [BlockField("매도호가수량3", 6)] int offerrem3,
    [BlockField("매수호가수량3", 6)] int bidrem3,
    [BlockField("매도호가건수3", 5)] int offercnt3,
    [BlockField("매수호가건수3", 5)] int bidcnt3,
    [BlockField("매도호가4", 6.2)] double offerho4,
    [BlockField("매수호가4", 6.2)] double bidho4,
    [BlockField("매도호가수량4", 6)] int offerrem4,
    [BlockField("매수호가수량4", 6)] int bidrem4,
    [BlockField("매도호가건수4", 5)] int offercnt4,
    [BlockField("매수호가건수4", 5)] int bidcnt4,
    [BlockField("매도호가5", 6.2)] double offerho5,
    [BlockField("매수호가5", 6.2)] double bidho5,
    [BlockField("매도호가수량5", 6)] int offerrem5,
    [BlockField("매수호가수량5", 6)] int bidrem5,
    [BlockField("매도호가건수5", 5)] int offercnt5,
    [BlockField("매수호가건수5", 5)] int bidcnt5,
    [BlockField("매도호가총수량", 6)] int totofferrem,
    [BlockField("매수호가총수량", 6)] int totbidrem,
    [BlockField("매도호가총건수", 5)] int totoffercnt,
    [BlockField("매수호가총건수", 5)] int totbidcnt,
    [BlockField("단축코드", 8)] string futcode,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("배분적용구분", 1)] string alloc_gubun
    );


/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record FX0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	double	6.2</param>
/// <param name="dnlmtprice">적용 하한가	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 29)]
public record FX0OutBlock(
    [BlockField("적용 상한단계", 2)] string upstep,
    [BlockField("적용 하한단계", 2)] string dnstep,
    [BlockField("적용 상한가", 6.2)] double uplmtprice,
    [BlockField("적용 하한가", 6.2)] double dnlmtprice,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// 선물주문정정취소: H01
/// </summary>
[BlockInfo(false, 0)]
public record H01InBlock(
    );

/// <summary>
/// 선물주문정정취소: H01
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="seq">일련번호	long	11</param>
/// <param name="trcode">trcode	string	11</param>
/// <param name="megrpno">매칭그룹번호	string	2</param>
/// <param name="boardid">보드ID	string	2</param>
/// <param name="memberno">회원번호	string	5</param>
/// <param name="bpno">지점번호	string	5</param>
/// <param name="ordno">주문번호	string	10</param>
/// <param name="ordordno">원주문번호	string	10</param>
/// <param name="expcode">종목코드	string	12</param>
/// <param name="dosugb">매도수구분	string	1</param>
/// <param name="mocagb">정정취소구분	string	1</param>
/// <param name="accno1">계좌번호1	string	12</param>
/// <param name="qty2">호가수량	long	10</param>
/// <param name="price">호가가격	double	11.2</param>
/// <param name="ordgb">주문유형	string	1</param>
/// <param name="hogagb">호가구분	string	1</param>
/// <param name="sihogagb">시장조성호가구분	string	11</param>
/// <param name="treaid">자사주신고서ID	string	5</param>
/// <param name="treacode">자사주매매방법	string	1</param>
/// <param name="askcode">매도유형코드	string	2</param>
/// <param name="creditcode">신용구분코드	string	2</param>
/// <param name="jakigb">위탁자기구분	string	2</param>
/// <param name="trustnum">위탁사번호	string	5</param>
/// <param name="ptgb">프로그램구분	string	2</param>
/// <param name="substocnum">대용주권계좌번호	string	12</param>
/// <param name="accgb">계좌구분코드	string	2</param>
/// <param name="accmarggb">계좌증거금코드	string	2</param>
/// <param name="nationcode">국가코드	string	3</param>
/// <param name="investgb">투자자구분	string	4</param>
/// <param name="forecode">외국인코드	string	2</param>
/// <param name="medcode">주문매체구분	string	1</param>
/// <param name="ordid">주문식별자번호	string	12</param>
/// <param name="macid">MAC주소	string	12</param>
/// <param name="orddate">호가일자	string	8</param>
/// <param name="rcvtime">회원사주문시각	string	9</param>
/// <param name="mem_filler">mem_filler	string	7</param>
/// <param name="mem_accno">mem_accno	string	11</param>
/// <param name="mem_filler1">mem_filler1	string	42</param>
/// <param name="ordacpttm">매칭접수시간	string	9</param>
/// <param name="qty">실정정취소수량	long	10</param>
/// <param name="autogb">자동취소구분	string	1</param>
/// <param name="rejcode">거부사유	string	4</param>
/// <param name="prgordde">프로그램호가신고	string	1</param>
[BlockInfo(false, 316)]
public record H01OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("일련번호", 11)] long seq,
    [BlockField("trcode", 11)] string trcode,
    [BlockField("매칭그룹번호", 2)] string megrpno,
    [BlockField("보드ID", 2)] string boardid,
    [BlockField("회원번호", 5)] string memberno,
    [BlockField("지점번호", 5)] string bpno,
    [BlockField("주문번호", 10)] string ordno,
    [BlockField("원주문번호", 10)] string ordordno,
    [BlockField("종목코드", 12)] string expcode,
    [BlockField("매도수구분", 1)] string dosugb,
    [BlockField("정정취소구분", 1)] string mocagb,
    [BlockField("계좌번호1", 12)] string accno1,
    [BlockField("호가수량", 10)] long qty2,
    [BlockField("호가가격", 11.2)] double price,
    [BlockField("주문유형", 1)] string ordgb,
    [BlockField("호가구분", 1)] string hogagb,
    [BlockField("시장조성호가구분", 11)] string sihogagb,
    [BlockField("자사주신고서ID", 5)] string treaid,
    [BlockField("자사주매매방법", 1)] string treacode,
    [BlockField("매도유형코드", 2)] string askcode,
    [BlockField("신용구분코드", 2)] string creditcode,
    [BlockField("위탁자기구분", 2)] string jakigb,
    [BlockField("위탁사번호", 5)] string trustnum,
    [BlockField("프로그램구분", 2)] string ptgb,
    [BlockField("대용주권계좌번호", 12)] string substocnum,
    [BlockField("계좌구분코드", 2)] string accgb,
    [BlockField("계좌증거금코드", 2)] string accmarggb,
    [BlockField("국가코드", 3)] string nationcode,
    [BlockField("투자자구분", 4)] string investgb,
    [BlockField("외국인코드", 2)] string forecode,
    [BlockField("주문매체구분", 1)] string medcode,
    [BlockField("주문식별자번호", 12)] string ordid,
    [BlockField("MAC주소", 12)] string macid,
    [BlockField("호가일자", 8)] string orddate,
    [BlockField("회원사주문시각", 9)] string rcvtime,
    [BlockField("mem_filler", 7)] string mem_filler,
    [BlockField("mem_accno", 11)] string mem_accno,
    [BlockField("mem_filler1", 42)] string mem_filler1,
    [BlockField("매칭접수시간", 9)] string ordacpttm,
    [BlockField("실정정취소수량", 10)] long qty,
    [BlockField("자동취소구분", 1)] string autogb,
    [BlockField("거부사유", 4)] string rejcode,
    [BlockField("프로그램호가신고", 1)] string prgordde
    );


/// <summary>
/// KOSPI호가잔량: H1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record H1_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI호가잔량: H1_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	int	7</param>
/// <param name="bidho1">매수호가1	int	7</param>
/// <param name="offerrem1">매도호가잔량1	long	9</param>
/// <param name="bidrem1">매수호가잔량1	long	9</param>
/// <param name="offerho2">매도호가2	int	7</param>
/// <param name="bidho2">매수호가2	int	7</param>
/// <param name="offerrem2">매도호가잔량2	long	9</param>
/// <param name="bidrem2">매수호가잔량2	long	9</param>
/// <param name="offerho3">매도호가3	int	7</param>
/// <param name="bidho3">매수호가3	int	7</param>
/// <param name="offerrem3">매도호가잔량3	long	9</param>
/// <param name="bidrem3">매수호가잔량3	long	9</param>
/// <param name="offerho4">매도호가4	int	7</param>
/// <param name="bidho4">매수호가4	int	7</param>
/// <param name="offerrem4">매도호가잔량4	long	9</param>
/// <param name="bidrem4">매수호가잔량4	long	9</param>
/// <param name="offerho5">매도호가5	int	7</param>
/// <param name="bidho5">매수호가5	int	7</param>
/// <param name="offerrem5">매도호가잔량5	long	9</param>
/// <param name="bidrem5">매수호가잔량5	long	9</param>
/// <param name="offerho6">매도호가6	int	7</param>
/// <param name="bidho6">매수호가6	int	7</param>
/// <param name="offerrem6">매도호가잔량6	long	9</param>
/// <param name="bidrem6">매수호가잔량6	long	9</param>
/// <param name="offerho7">매도호가7	int	7</param>
/// <param name="bidho7">매수호가7	int	7</param>
/// <param name="offerrem7">매도호가잔량7	long	9</param>
/// <param name="bidrem7">매수호가잔량7	long	9</param>
/// <param name="offerho8">매도호가8	int	7</param>
/// <param name="bidho8">매수호가8	int	7</param>
/// <param name="offerrem8">매도호가잔량8	long	9</param>
/// <param name="bidrem8">매수호가잔량8	long	9</param>
/// <param name="offerho9">매도호가9	int	7</param>
/// <param name="bidho9">매수호가9	int	7</param>
/// <param name="offerrem9">매도호가잔량9	long	9</param>
/// <param name="bidrem9">매수호가잔량9	long	9</param>
/// <param name="offerho10">매도호가10	int	7</param>
/// <param name="bidho10">매수호가10	int	7</param>
/// <param name="offerrem10">매도호가잔량10	long	9</param>
/// <param name="bidrem10">매수호가잔량10	long	9</param>
/// <param name="totofferrem">총매도호가잔량	long	9</param>
/// <param name="totbidrem">총매수호가잔량	long	9</param>
/// <param name="donsigubun">동시호가구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
/// <param name="volume">누적거래량	long	12</param>
[BlockInfo(true, 411)]
public record H1_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 7)] int offerho1,
    [BlockField("매수호가1", 7)] int bidho1,
    [BlockField("매도호가잔량1", 9)] long offerrem1,
    [BlockField("매수호가잔량1", 9)] long bidrem1,
    [BlockField("매도호가2", 7)] int offerho2,
    [BlockField("매수호가2", 7)] int bidho2,
    [BlockField("매도호가잔량2", 9)] long offerrem2,
    [BlockField("매수호가잔량2", 9)] long bidrem2,
    [BlockField("매도호가3", 7)] int offerho3,
    [BlockField("매수호가3", 7)] int bidho3,
    [BlockField("매도호가잔량3", 9)] long offerrem3,
    [BlockField("매수호가잔량3", 9)] long bidrem3,
    [BlockField("매도호가4", 7)] int offerho4,
    [BlockField("매수호가4", 7)] int bidho4,
    [BlockField("매도호가잔량4", 9)] long offerrem4,
    [BlockField("매수호가잔량4", 9)] long bidrem4,
    [BlockField("매도호가5", 7)] int offerho5,
    [BlockField("매수호가5", 7)] int bidho5,
    [BlockField("매도호가잔량5", 9)] long offerrem5,
    [BlockField("매수호가잔량5", 9)] long bidrem5,
    [BlockField("매도호가6", 7)] int offerho6,
    [BlockField("매수호가6", 7)] int bidho6,
    [BlockField("매도호가잔량6", 9)] long offerrem6,
    [BlockField("매수호가잔량6", 9)] long bidrem6,
    [BlockField("매도호가7", 7)] int offerho7,
    [BlockField("매수호가7", 7)] int bidho7,
    [BlockField("매도호가잔량7", 9)] long offerrem7,
    [BlockField("매수호가잔량7", 9)] long bidrem7,
    [BlockField("매도호가8", 7)] int offerho8,
    [BlockField("매수호가8", 7)] int bidho8,
    [BlockField("매도호가잔량8", 9)] long offerrem8,
    [BlockField("매수호가잔량8", 9)] long bidrem8,
    [BlockField("매도호가9", 7)] int offerho9,
    [BlockField("매수호가9", 7)] int bidho9,
    [BlockField("매도호가잔량9", 9)] long offerrem9,
    [BlockField("매수호가잔량9", 9)] long bidrem9,
    [BlockField("매도호가10", 7)] int offerho10,
    [BlockField("매수호가10", 7)] int bidho10,
    [BlockField("매도호가잔량10", 9)] long offerrem10,
    [BlockField("매수호가잔량10", 9)] long bidrem10,
    [BlockField("총매도호가잔량", 9)] long totofferrem,
    [BlockField("총매수호가잔량", 9)] long totbidrem,
    [BlockField("동시호가구분", 1)] string donsigubun,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("배분적용구분", 1)] string alloc_gubun,
    [BlockField("누적거래량", 12)] long volume
    );


/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record H2_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 66)]
public record H2_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("시간외매도잔량", 12)] long tmofferrem,
    [BlockField("시간외매수잔량", 12)] long tmbidrem,
    [BlockField("시간외매도수량직전대비", 12)] long pretmoffercha,
    [BlockField("시간외매수수량직전대비", 12)] long pretmbidcha,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record h2_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 66)]
public record h2_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("시간외매도잔량", 12)] long tmofferrem,
    [BlockField("시간외매수잔량", 12)] long tmbidrem,
    [BlockField("시간외매도수량직전대비", 12)] long pretmoffercha,
    [BlockField("시간외매수수량직전대비", 12)] long pretmbidcha,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW호가잔량: h3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record h3_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW호가잔량: h3_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	int	7</param>
/// <param name="bidho1">매수호가1	int	7</param>
/// <param name="offerrem1">매도호가잔량1	long	9</param>
/// <param name="bidrem1">매수호가잔량1	long	9</param>
/// <param name="lp_offerho1">LP매도호가수량1	long	9</param>
/// <param name="lp_bidho1">LP매수호가수량1	long	9</param>
/// <param name="offerho2">매도호가2	int	7</param>
/// <param name="bidho2">매수호가2	int	7</param>
/// <param name="offerrem2">매도호가잔량2	long	9</param>
/// <param name="bidrem2">매수호가잔량2	long	9</param>
/// <param name="lp_offerho2">LP매도호가수량2	long	9</param>
/// <param name="lp_bidho2">LP매수호가수량2	long	9</param>
/// <param name="offerho3">매도호가3	int	7</param>
/// <param name="bidho3">매수호가3	int	7</param>
/// <param name="offerrem3">매도호가잔량3	long	9</param>
/// <param name="bidrem3">매수호가잔량3	long	9</param>
/// <param name="lp_offerho3">LP매도호가수량3	long	9</param>
/// <param name="lp_bidho3">LP매수호가수량3	long	9</param>
/// <param name="offerho4">매도호가4	int	7</param>
/// <param name="bidho4">매수호가4	int	7</param>
/// <param name="offerrem4">매도호가잔량4	long	9</param>
/// <param name="bidrem4">매수호가잔량4	long	9</param>
/// <param name="lp_offerho4">LP매도호가수량4	long	9</param>
/// <param name="lp_bidho4">LP매수호가수량4	long	9</param>
/// <param name="offerho5">매도호가5	int	7</param>
/// <param name="bidho5">매수호가5	int	7</param>
/// <param name="offerrem5">매도호가잔량5	long	9</param>
/// <param name="bidrem5">매수호가잔량5	long	9</param>
/// <param name="lp_offerho5">LP매도호가수량5	long	9</param>
/// <param name="lp_bidho5">LP매수호가수량5	long	9</param>
/// <param name="offerho6">매도호가6	int	7</param>
/// <param name="bidho6">매수호가6	int	7</param>
/// <param name="offerrem6">매도호가잔량6	long	9</param>
/// <param name="bidrem6">매수호가잔량6	long	9</param>
/// <param name="lp_offerho6">LP매도호가수량6	long	9</param>
/// <param name="lp_bidho6">LP매수호가수량6	long	9</param>
/// <param name="offerho7">매도호가7	int	7</param>
/// <param name="bidho7">매수호가7	int	7</param>
/// <param name="offerrem7">매도호가잔량7	long	9</param>
/// <param name="bidrem7">매수호가잔량7	long	9</param>
/// <param name="lp_offerho7">LP매도호가수량7	long	9</param>
/// <param name="lp_bidho7">LP매수호가수량7	long	9</param>
/// <param name="offerho8">매도호가8	int	7</param>
/// <param name="bidho8">매수호가8	int	7</param>
/// <param name="offerrem8">매도호가잔량8	long	9</param>
/// <param name="bidrem8">매수호가잔량8	long	9</param>
/// <param name="lp_offerho8">LP매도호가수량8	long	9</param>
/// <param name="lp_bidho8">LP매수호가수량8	long	9</param>
/// <param name="offerho9">매도호가9	int	7</param>
/// <param name="bidho9">매수호가9	int	7</param>
/// <param name="offerrem9">매도호가잔량9	long	9</param>
/// <param name="bidrem9">매수호가잔량9	long	9</param>
/// <param name="lp_offerho9">LP매도호가수량9	long	9</param>
/// <param name="lp_bidho9">LP매수호가수량9	long	9</param>
/// <param name="offerho10">매도호가10	int	7</param>
/// <param name="bidho10">매수호가10	int	7</param>
/// <param name="offerrem10">매도호가잔량10	long	9</param>
/// <param name="bidrem10">매수호가잔량10	long	9</param>
/// <param name="lp_offerho10">LP매도호가수량10	long	9</param>
/// <param name="lp_bidho10">LP매수호가수량10	long	9</param>
/// <param name="totofferrem">총매도호가잔량	long	9</param>
/// <param name="totbidrem">총매수호가잔량	long	9</param>
/// <param name="donsigubun">동시호가구분	string	1</param>
/// <param name="spread">스프레드	double	6.2</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 603)]
public record h3_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 7)] int offerho1,
    [BlockField("매수호가1", 7)] int bidho1,
    [BlockField("매도호가잔량1", 9)] long offerrem1,
    [BlockField("매수호가잔량1", 9)] long bidrem1,
    [BlockField("LP매도호가수량1", 9)] long lp_offerho1,
    [BlockField("LP매수호가수량1", 9)] long lp_bidho1,
    [BlockField("매도호가2", 7)] int offerho2,
    [BlockField("매수호가2", 7)] int bidho2,
    [BlockField("매도호가잔량2", 9)] long offerrem2,
    [BlockField("매수호가잔량2", 9)] long bidrem2,
    [BlockField("LP매도호가수량2", 9)] long lp_offerho2,
    [BlockField("LP매수호가수량2", 9)] long lp_bidho2,
    [BlockField("매도호가3", 7)] int offerho3,
    [BlockField("매수호가3", 7)] int bidho3,
    [BlockField("매도호가잔량3", 9)] long offerrem3,
    [BlockField("매수호가잔량3", 9)] long bidrem3,
    [BlockField("LP매도호가수량3", 9)] long lp_offerho3,
    [BlockField("LP매수호가수량3", 9)] long lp_bidho3,
    [BlockField("매도호가4", 7)] int offerho4,
    [BlockField("매수호가4", 7)] int bidho4,
    [BlockField("매도호가잔량4", 9)] long offerrem4,
    [BlockField("매수호가잔량4", 9)] long bidrem4,
    [BlockField("LP매도호가수량4", 9)] long lp_offerho4,
    [BlockField("LP매수호가수량4", 9)] long lp_bidho4,
    [BlockField("매도호가5", 7)] int offerho5,
    [BlockField("매수호가5", 7)] int bidho5,
    [BlockField("매도호가잔량5", 9)] long offerrem5,
    [BlockField("매수호가잔량5", 9)] long bidrem5,
    [BlockField("LP매도호가수량5", 9)] long lp_offerho5,
    [BlockField("LP매수호가수량5", 9)] long lp_bidho5,
    [BlockField("매도호가6", 7)] int offerho6,
    [BlockField("매수호가6", 7)] int bidho6,
    [BlockField("매도호가잔량6", 9)] long offerrem6,
    [BlockField("매수호가잔량6", 9)] long bidrem6,
    [BlockField("LP매도호가수량6", 9)] long lp_offerho6,
    [BlockField("LP매수호가수량6", 9)] long lp_bidho6,
    [BlockField("매도호가7", 7)] int offerho7,
    [BlockField("매수호가7", 7)] int bidho7,
    [BlockField("매도호가잔량7", 9)] long offerrem7,
    [BlockField("매수호가잔량7", 9)] long bidrem7,
    [BlockField("LP매도호가수량7", 9)] long lp_offerho7,
    [BlockField("LP매수호가수량7", 9)] long lp_bidho7,
    [BlockField("매도호가8", 7)] int offerho8,
    [BlockField("매수호가8", 7)] int bidho8,
    [BlockField("매도호가잔량8", 9)] long offerrem8,
    [BlockField("매수호가잔량8", 9)] long bidrem8,
    [BlockField("LP매도호가수량8", 9)] long lp_offerho8,
    [BlockField("LP매수호가수량8", 9)] long lp_bidho8,
    [BlockField("매도호가9", 7)] int offerho9,
    [BlockField("매수호가9", 7)] int bidho9,
    [BlockField("매도호가잔량9", 9)] long offerrem9,
    [BlockField("매수호가잔량9", 9)] long bidrem9,
    [BlockField("LP매도호가수량9", 9)] long lp_offerho9,
    [BlockField("LP매수호가수량9", 9)] long lp_bidho9,
    [BlockField("매도호가10", 7)] int offerho10,
    [BlockField("매수호가10", 7)] int bidho10,
    [BlockField("매도호가잔량10", 9)] long offerrem10,
    [BlockField("매수호가잔량10", 9)] long bidrem10,
    [BlockField("LP매도호가수량10", 9)] long lp_offerho10,
    [BlockField("LP매수호가수량10", 9)] long lp_bidho10,
    [BlockField("총매도호가잔량", 9)] long totofferrem,
    [BlockField("총매수호가잔량", 9)] long totbidrem,
    [BlockField("동시호가구분", 1)] string donsigubun,
    [BlockField("스프레드", 6.2)] double spread,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// KOSDAQ호가잔량: HA_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record HA_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ호가잔량: HA_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	int	7</param>
/// <param name="bidho1">매수호가1	int	7</param>
/// <param name="offerrem1">매도호가잔량1	long	9</param>
/// <param name="bidrem1">매수호가잔량1	long	9</param>
/// <param name="offerho2">매도호가2	int	7</param>
/// <param name="bidho2">매수호가2	int	7</param>
/// <param name="offerrem2">매도호가잔량2	long	9</param>
/// <param name="bidrem2">매수호가잔량2	long	9</param>
/// <param name="offerho3">매도호가3	int	7</param>
/// <param name="bidho3">매수호가3	int	7</param>
/// <param name="offerrem3">매도호가잔량3	long	9</param>
/// <param name="bidrem3">매수호가잔량3	long	9</param>
/// <param name="offerho4">매도호가4	int	7</param>
/// <param name="bidho4">매수호가4	int	7</param>
/// <param name="offerrem4">매도호가잔량4	long	9</param>
/// <param name="bidrem4">매수호가잔량4	long	9</param>
/// <param name="offerho5">매도호가5	int	7</param>
/// <param name="bidho5">매수호가5	int	7</param>
/// <param name="offerrem5">매도호가잔량5	long	9</param>
/// <param name="bidrem5">매수호가잔량5	long	9</param>
/// <param name="offerho6">매도호가6	int	7</param>
/// <param name="bidho6">매수호가6	int	7</param>
/// <param name="offerrem6">매도호가잔량6	long	9</param>
/// <param name="bidrem6">매수호가잔량6	long	9</param>
/// <param name="offerho7">매도호가7	int	7</param>
/// <param name="bidho7">매수호가7	int	7</param>
/// <param name="offerrem7">매도호가잔량7	long	9</param>
/// <param name="bidrem7">매수호가잔량7	long	9</param>
/// <param name="offerho8">매도호가8	int	7</param>
/// <param name="bidho8">매수호가8	int	7</param>
/// <param name="offerrem8">매도호가잔량8	long	9</param>
/// <param name="bidrem8">매수호가잔량8	long	9</param>
/// <param name="offerho9">매도호가9	int	7</param>
/// <param name="bidho9">매수호가9	int	7</param>
/// <param name="offerrem9">매도호가잔량9	long	9</param>
/// <param name="bidrem9">매수호가잔량9	long	9</param>
/// <param name="offerho10">매도호가10	int	7</param>
/// <param name="bidho10">매수호가10	int	7</param>
/// <param name="offerrem10">매도호가잔량10	long	9</param>
/// <param name="bidrem10">매수호가잔량10	long	9</param>
/// <param name="totofferrem">총매도호가잔량	long	9</param>
/// <param name="totbidrem">총매수호가잔량	long	9</param>
/// <param name="donsigubun">동시호가구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
/// <param name="volume">누적거래량	long	12</param>
[BlockInfo(true, 411)]
public record HA_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 7)] int offerho1,
    [BlockField("매수호가1", 7)] int bidho1,
    [BlockField("매도호가잔량1", 9)] long offerrem1,
    [BlockField("매수호가잔량1", 9)] long bidrem1,
    [BlockField("매도호가2", 7)] int offerho2,
    [BlockField("매수호가2", 7)] int bidho2,
    [BlockField("매도호가잔량2", 9)] long offerrem2,
    [BlockField("매수호가잔량2", 9)] long bidrem2,
    [BlockField("매도호가3", 7)] int offerho3,
    [BlockField("매수호가3", 7)] int bidho3,
    [BlockField("매도호가잔량3", 9)] long offerrem3,
    [BlockField("매수호가잔량3", 9)] long bidrem3,
    [BlockField("매도호가4", 7)] int offerho4,
    [BlockField("매수호가4", 7)] int bidho4,
    [BlockField("매도호가잔량4", 9)] long offerrem4,
    [BlockField("매수호가잔량4", 9)] long bidrem4,
    [BlockField("매도호가5", 7)] int offerho5,
    [BlockField("매수호가5", 7)] int bidho5,
    [BlockField("매도호가잔량5", 9)] long offerrem5,
    [BlockField("매수호가잔량5", 9)] long bidrem5,
    [BlockField("매도호가6", 7)] int offerho6,
    [BlockField("매수호가6", 7)] int bidho6,
    [BlockField("매도호가잔량6", 9)] long offerrem6,
    [BlockField("매수호가잔량6", 9)] long bidrem6,
    [BlockField("매도호가7", 7)] int offerho7,
    [BlockField("매수호가7", 7)] int bidho7,
    [BlockField("매도호가잔량7", 9)] long offerrem7,
    [BlockField("매수호가잔량7", 9)] long bidrem7,
    [BlockField("매도호가8", 7)] int offerho8,
    [BlockField("매수호가8", 7)] int bidho8,
    [BlockField("매도호가잔량8", 9)] long offerrem8,
    [BlockField("매수호가잔량8", 9)] long bidrem8,
    [BlockField("매도호가9", 7)] int offerho9,
    [BlockField("매수호가9", 7)] int bidho9,
    [BlockField("매도호가잔량9", 9)] long offerrem9,
    [BlockField("매수호가잔량9", 9)] long bidrem9,
    [BlockField("매도호가10", 7)] int offerho10,
    [BlockField("매수호가10", 7)] int bidho10,
    [BlockField("매도호가잔량10", 9)] long offerrem10,
    [BlockField("매수호가잔량10", 9)] long bidrem10,
    [BlockField("총매도호가잔량", 9)] long totofferrem,
    [BlockField("총매수호가잔량", 9)] long totbidrem,
    [BlockField("동시호가구분", 1)] string donsigubun,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("배분적용구분", 1)] string alloc_gubun,
    [BlockField("누적거래량", 12)] long volume
    );


/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record HB_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 66)]
public record HB_OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("시간외매도잔량", 12)] long tmofferrem,
    [BlockField("시간외매수잔량", 12)] long tmbidrem,
    [BlockField("시간외매도수량직전대비", 12)] long pretmoffercha,
    [BlockField("시간외매수수량직전대비", 12)] long pretmbidcha,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 코스피ETF종목실시간NAV: I5_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record I5_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// 코스피ETF종목실시간NAV: I5_
/// </summary>
/// <param name="time">시간	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="navdiff">NAV대비	double	9.2</param>
/// <param name="nav">NAV	double	9.2</param>
/// <param name="navchange">전일대비	double	9.2</param>
/// <param name="crate">추적오차	double	9.2</param>
/// <param name="grate">괴리	double	9.2</param>
/// <param name="jisu">지수	double	8.2</param>
/// <param name="jichange">전일대비	double	8.2</param>
/// <param name="jirate">전일대비율	double	8.2</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 126)]
public record I5_OutBlock(
    [BlockField("시간", 8)] string time,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("NAV대비", 9.2)] double navdiff,
    [BlockField("NAV", 9.2)] double nav,
    [BlockField("전일대비", 9.2)] double navchange,
    [BlockField("추적오차", 9.2)] double crate,
    [BlockField("괴리", 9.2)] double grate,
    [BlockField("지수", 8.2)] double jisu,
    [BlockField("전일대비", 8.2)] double jichange,
    [BlockField("전일대비율", 8.2)] double jirate,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 지수: IJ_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 4)]
public record IJ_InBlock(
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 지수: IJ_
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="jisu">지수	double	8.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일비	double	8.2</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="cvolume">체결량	int	8</param>
/// <param name="volume">거래량	int	8</param>
/// <param name="value">거래대금	int	8</param>
/// <param name="upjo">상한종목수	int	4</param>
/// <param name="highjo">상승종목수	int	4</param>
/// <param name="unchgjo">보합종목수	int	4</param>
/// <param name="lowjo">하락종목수	int	4</param>
/// <param name="downjo">하한종목수	int	4</param>
/// <param name="upjrate">상승종목비율	double	6.2</param>
/// <param name="openjisu">시가지수	double	8.2</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="highjisu">고가지수	double	8.2</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="lowjisu">저가지수	double	8.2</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="frgsvolume">외인순매수수량	int	8</param>
/// <param name="orgsvolume">기관순매수수량	int	8</param>
/// <param name="frgsvalue">외인순매수금액	long	10</param>
/// <param name="orgsvalue">기관순매수금액	long	10</param>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 185)]
public record IJ_OutBlock(
    [BlockField("시간", 6)] string time,
    [BlockField("지수", 8.2)] double jisu,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일비", 8.2)] double change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("체결량", 8)] int cvolume,
    [BlockField("거래량", 8)] int volume,
    [BlockField("거래대금", 8)] int value,
    [BlockField("상한종목수", 4)] int upjo,
    [BlockField("상승종목수", 4)] int highjo,
    [BlockField("보합종목수", 4)] int unchgjo,
    [BlockField("하락종목수", 4)] int lowjo,
    [BlockField("하한종목수", 4)] int downjo,
    [BlockField("상승종목비율", 6.2)] double upjrate,
    [BlockField("시가지수", 8.2)] double openjisu,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가지수", 8.2)] double highjisu,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가지수", 8.2)] double lowjisu,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("외인순매수수량", 8)] int frgsvolume,
    [BlockField("기관순매수수량", 8)] int orgsvolume,
    [BlockField("외인순매수금액", 10)] long frgsvalue,
    [BlockField("기관순매수금액", 10)] long orgsvalue,
    [BlockField("업종코드", 3)] string upcode
    );


/// <summary>
/// 주식선물체결: JC0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record JC0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 주식선물체결: JC0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">대비기호	string	1</param>
/// <param name="change">전일대비	long	10</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	long	10</param>
/// <param name="open">시가	long	10</param>
/// <param name="high">고가	long	10</param>
/// <param name="low">저가	long	10</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	6</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	15</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="offerho1">매도호가1	long	10</param>
/// <param name="bidho1">매수호가1	long	10</param>
/// <param name="openyak">미결제약정수량	int	8</param>
/// <param name="k200jisu">KOSPI200지수	double	6.2</param>
/// <param name="theoryprice">이론가	int	8</param>
/// <param name="kasis">괴리율	double	6.3</param>
/// <param name="sbasis">시장BASIS	int	6</param>
/// <param name="ibasis">이론BASIS	int	6</param>
/// <param name="openyakcha">미결제약정증감	int	8</param>
/// <param name="jgubun">장운영정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="basprice">기초자산현재가	int	8</param>
[BlockInfo(true, 274)]
public record JC0OutBlock(
    [BlockField("단축코드", 8)] string futcode,
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("대비기호", 1)] string sign,
    [BlockField("전일대비", 10)] long change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 10)] long price,
    [BlockField("시가", 10)] long open,
    [BlockField("고가", 10)] long high,
    [BlockField("저가", 10)] long low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 6)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 15)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("매도호가1", 10)] long offerho1,
    [BlockField("매수호가1", 10)] long bidho1,
    [BlockField("미결제약정수량", 8)] int openyak,
    [BlockField("KOSPI200지수", 6.2)] double k200jisu,
    [BlockField("이론가", 8)] int theoryprice,
    [BlockField("괴리율", 6.3)] double kasis,
    [BlockField("시장BASIS", 6)] int sbasis,
    [BlockField("이론BASIS", 6)] int ibasis,
    [BlockField("미결제약정증감", 8)] int openyakcha,
    [BlockField("장운영정보", 2)] string jgubun,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("기초자산현재가", 8)] int basprice
    );


/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record JD0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	long	10</param>
/// <param name="dy_dnlmtprice">실시간하한가	long	10</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 35)]
public record JD0OutBlock(
    [BlockField("접속매매여부", 1)] string gubun,
    [BlockField("실시간가격제한여부", 1)] string dy_gubun,
    [BlockField("실시간상한가", 10)] long dy_uplmtprice,
    [BlockField("실시간하한가", 10)] long dy_dnlmtprice,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// 주식선물호가: JH0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record JH0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 주식선물호가: JH0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	long	10</param>
/// <param name="bidho1">매수호가1	long	10</param>
/// <param name="offerrem1">매도호가수량1	int	7</param>
/// <param name="bidrem1">매수호가수량1	int	7</param>
/// <param name="offercnt1">매도호가건수1	int	5</param>
/// <param name="bidcnt1">매수호가건수1	int	5</param>
/// <param name="offerho2">매도호가2	long	10</param>
/// <param name="bidho2">매수호가2	long	10</param>
/// <param name="offerrem2">매도호가수량2	int	7</param>
/// <param name="bidrem2">매수호가수량2	int	7</param>
/// <param name="offercnt2">매도호가건수2	int	5</param>
/// <param name="bidcnt2">매수호가건수2	int	5</param>
/// <param name="offerho3">매도호가3	long	10</param>
/// <param name="bidho3">매수호가3	long	10</param>
/// <param name="offerrem3">매도호가수량3	int	7</param>
/// <param name="bidrem3">매수호가수량3	int	7</param>
/// <param name="offercnt3">매도호가건수3	int	5</param>
/// <param name="bidcnt3">매수호가건수3	int	5</param>
/// <param name="offerho4">매도호가4	long	10</param>
/// <param name="bidho4">매수호가4	long	10</param>
/// <param name="offerrem4">매도호가수량4	int	7</param>
/// <param name="bidrem4">매수호가수량4	int	7</param>
/// <param name="offercnt4">매도호가건수4	int	5</param>
/// <param name="bidcnt4">매수호가건수4	int	5</param>
/// <param name="offerho5">매도호가5	long	10</param>
/// <param name="bidho5">매수호가5	long	10</param>
/// <param name="offerrem5">매도호가수량5	int	7</param>
/// <param name="bidrem5">매수호가수량5	int	7</param>
/// <param name="offercnt5">매도호가건수5	int	5</param>
/// <param name="bidcnt5">매수호가건수5	int	5</param>
/// <param name="offerho6">매도호가6	long	10</param>
/// <param name="bidho6">매수호가6	long	10</param>
/// <param name="offerrem6">매도호가수량6	int	7</param>
/// <param name="bidrem6">매수호가수량6	int	7</param>
/// <param name="offercnt6">매도호가건수6	int	5</param>
/// <param name="bidcnt6">매수호가건수6	int	5</param>
/// <param name="offerho7">매도호가7	long	10</param>
/// <param name="bidho7">매수호가7	long	10</param>
/// <param name="offerrem7">매도호가수량7	int	7</param>
/// <param name="bidrem7">매수호가수량7	int	7</param>
/// <param name="offercnt7">매도호가건수7	int	5</param>
/// <param name="bidcnt7">매수호가건수7	int	5</param>
/// <param name="offerho8">매도호가8	long	10</param>
/// <param name="bidho8">매수호가8	long	10</param>
/// <param name="offerrem8">매도호가수량8	int	7</param>
/// <param name="bidrem8">매수호가수량8	int	7</param>
/// <param name="offercnt8">매도호가건수8	int	5</param>
/// <param name="bidcnt8">매수호가건수8	int	5</param>
/// <param name="offerho9">매도호가9	long	10</param>
/// <param name="bidho9">매수호가9	long	10</param>
/// <param name="offerrem9">매도호가수량9	int	7</param>
/// <param name="bidrem9">매수호가수량9	int	7</param>
/// <param name="offercnt9">매도호가건수9	int	5</param>
/// <param name="bidcnt9">매수호가건수9	int	5</param>
/// <param name="offerho10">매도호가10	long	10</param>
/// <param name="bidho10">매수호가10	long	10</param>
/// <param name="offerrem10">매도호가수량10	int	7</param>
/// <param name="bidrem10">매수호가수량10	int	7</param>
/// <param name="offercnt10">매도호가건수10	int	5</param>
/// <param name="bidcnt10">매수호가건수10	int	5</param>
/// <param name="totofferrem">매도호가총수량	int	8</param>
/// <param name="totbidrem">매수호가총수량	int	8</param>
/// <param name="totoffercnt">매도호가총건수	int	5</param>
/// <param name="totbidcnt">매수호가총건수	int	5</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
[BlockInfo(true, 550)]
public record JH0OutBlock(
    [BlockField("단축코드", 8)] string futcode,
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 10)] long offerho1,
    [BlockField("매수호가1", 10)] long bidho1,
    [BlockField("매도호가수량1", 7)] int offerrem1,
    [BlockField("매수호가수량1", 7)] int bidrem1,
    [BlockField("매도호가건수1", 5)] int offercnt1,
    [BlockField("매수호가건수1", 5)] int bidcnt1,
    [BlockField("매도호가2", 10)] long offerho2,
    [BlockField("매수호가2", 10)] long bidho2,
    [BlockField("매도호가수량2", 7)] int offerrem2,
    [BlockField("매수호가수량2", 7)] int bidrem2,
    [BlockField("매도호가건수2", 5)] int offercnt2,
    [BlockField("매수호가건수2", 5)] int bidcnt2,
    [BlockField("매도호가3", 10)] long offerho3,
    [BlockField("매수호가3", 10)] long bidho3,
    [BlockField("매도호가수량3", 7)] int offerrem3,
    [BlockField("매수호가수량3", 7)] int bidrem3,
    [BlockField("매도호가건수3", 5)] int offercnt3,
    [BlockField("매수호가건수3", 5)] int bidcnt3,
    [BlockField("매도호가4", 10)] long offerho4,
    [BlockField("매수호가4", 10)] long bidho4,
    [BlockField("매도호가수량4", 7)] int offerrem4,
    [BlockField("매수호가수량4", 7)] int bidrem4,
    [BlockField("매도호가건수4", 5)] int offercnt4,
    [BlockField("매수호가건수4", 5)] int bidcnt4,
    [BlockField("매도호가5", 10)] long offerho5,
    [BlockField("매수호가5", 10)] long bidho5,
    [BlockField("매도호가수량5", 7)] int offerrem5,
    [BlockField("매수호가수량5", 7)] int bidrem5,
    [BlockField("매도호가건수5", 5)] int offercnt5,
    [BlockField("매수호가건수5", 5)] int bidcnt5,
    [BlockField("매도호가6", 10)] long offerho6,
    [BlockField("매수호가6", 10)] long bidho6,
    [BlockField("매도호가수량6", 7)] int offerrem6,
    [BlockField("매수호가수량6", 7)] int bidrem6,
    [BlockField("매도호가건수6", 5)] int offercnt6,
    [BlockField("매수호가건수6", 5)] int bidcnt6,
    [BlockField("매도호가7", 10)] long offerho7,
    [BlockField("매수호가7", 10)] long bidho7,
    [BlockField("매도호가수량7", 7)] int offerrem7,
    [BlockField("매수호가수량7", 7)] int bidrem7,
    [BlockField("매도호가건수7", 5)] int offercnt7,
    [BlockField("매수호가건수7", 5)] int bidcnt7,
    [BlockField("매도호가8", 10)] long offerho8,
    [BlockField("매수호가8", 10)] long bidho8,
    [BlockField("매도호가수량8", 7)] int offerrem8,
    [BlockField("매수호가수량8", 7)] int bidrem8,
    [BlockField("매도호가건수8", 5)] int offercnt8,
    [BlockField("매수호가건수8", 5)] int bidcnt8,
    [BlockField("매도호가9", 10)] long offerho9,
    [BlockField("매수호가9", 10)] long bidho9,
    [BlockField("매도호가수량9", 7)] int offerrem9,
    [BlockField("매수호가수량9", 7)] int bidrem9,
    [BlockField("매도호가건수9", 5)] int offercnt9,
    [BlockField("매수호가건수9", 5)] int bidcnt9,
    [BlockField("매도호가10", 10)] long offerho10,
    [BlockField("매수호가10", 10)] long bidho10,
    [BlockField("매도호가수량10", 7)] int offerrem10,
    [BlockField("매수호가수량10", 7)] int bidrem10,
    [BlockField("매도호가건수10", 5)] int offercnt10,
    [BlockField("매수호가건수10", 5)] int bidcnt10,
    [BlockField("매도호가총수량", 8)] int totofferrem,
    [BlockField("매수호가총수량", 8)] int totbidrem,
    [BlockField("매도호가총건수", 5)] int totoffercnt,
    [BlockField("매수호가총건수", 5)] int totbidcnt,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("배분적용구분", 1)] string alloc_gubun
    );


/// <summary>
/// 장운영정보: JIF
/// </summary>
/// <param name="jangubun">장구분	string	1</param>
[BlockInfo(false, 1)]
public record JIFInBlock(
    [BlockField("장구분", 1)] string jangubun
    );

/// <summary>
/// 장운영정보: JIF
/// </summary>
/// <param name="jangubun">장구분	string	1</param>
/// <param name="jstatus">장상태	string	2</param>
[BlockInfo(false, 3)]
public record JIFOutBlock(
    [BlockField("장구분", 1)] string jangubun,
    [BlockField("장상태", 2)] string jstatus
    );


/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record JX0InBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	long	10</param>
/// <param name="dnlmtprice">적용 하한가	long	10</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 37)]
public record JX0OutBlock(
    [BlockField("적용 상한단계", 2)] string upstep,
    [BlockField("적용 하한단계", 2)] string dnstep,
    [BlockField("적용 상한가", 10)] long uplmtprice,
    [BlockField("적용 하한가", 10)] long dnlmtprice,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// KOSPI거래원: K1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record K1_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI거래원: K1_
/// </summary>
/// <param name="offerno1">매도증권사코드1	string	3</param>
/// <param name="bidno1">매수증권사코드1	string	3</param>
/// <param name="offertrad1">매도회원사명1	string	6</param>
/// <param name="bidtrad1">매수회원사명1	string	6</param>
/// <param name="tradmdvol1">매도거래량1	long	10</param>
/// <param name="tradmsvol1">매수거래량1	long	10</param>
/// <param name="tradmdrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	long	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	long	10</param>
/// <param name="offerno2">매도증권사코드2	string	3</param>
/// <param name="bidno2">매수증권사코드2	string	3</param>
/// <param name="offertrad2">매도회원사명2	string	6</param>
/// <param name="bidtrad2">매수회원사명2	string	6</param>
/// <param name="tradmdvol2">매도거래량2	long	10</param>
/// <param name="tradmsvol2">매수거래량2	long	10</param>
/// <param name="tradmdrate2">매도거래량비중2	double	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	double	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	long	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	long	10</param>
/// <param name="offerno3">매도증권사코드3	string	3</param>
/// <param name="bidno3">매수증권사코드3	string	3</param>
/// <param name="offertrad3">매도회원사명3	string	6</param>
/// <param name="bidtrad3">매수회원사명3	string	6</param>
/// <param name="tradmdvol3">매도거래량3	long	10</param>
/// <param name="tradmsvol3">매수거래량3	long	10</param>
/// <param name="tradmdrate3">매도거래량비중3	double	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	double	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	long	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	long	10</param>
/// <param name="offerno4">매도증권사코드4	string	3</param>
/// <param name="bidno4">매수증권사코드4	string	3</param>
/// <param name="offertrad4">매도회원사명4	string	6</param>
/// <param name="bidtrad4">매수회원사명4	string	6</param>
/// <param name="tradmdvol4">매도거래량4	long	10</param>
/// <param name="tradmsvol4">매수거래량4	long	10</param>
/// <param name="tradmdrate4">매도거래량비중4	double	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	double	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	long	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	long	10</param>
/// <param name="offerno5">매도증권사코드5	string	3</param>
/// <param name="bidno5">매수증권사코드5	string	3</param>
/// <param name="offertrad5">매도회원사명5	string	6</param>
/// <param name="bidtrad5">매수회원사명5	string	6</param>
/// <param name="tradmdvol5">매도거래량5	long	10</param>
/// <param name="tradmsvol5">매수거래량5	long	10</param>
/// <param name="tradmdrate5">매도거래량비중5	double	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	double	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	long	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	long	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	string	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	string	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	double	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	double	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	string	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	string	10</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="tradmdval1">매도거래대금1	long	15</param>
/// <param name="tradmsval1">매수거래대금1	long	15</param>
/// <param name="tradmdavg1">매도평균단가1	int	7</param>
/// <param name="tradmsavg1">매수평균단가1	int	7</param>
/// <param name="tradmdval2">매도거래대금2	long	15</param>
/// <param name="tradmsval2">매수거래대금2	long	15</param>
/// <param name="tradmdavg2">매도평균단가2	int	7</param>
/// <param name="tradmsavg2">매수평균단가2	int	7</param>
/// <param name="tradmdval3">매도거래대금3	long	15</param>
/// <param name="tradmsval3">매수거래대금3	long	15</param>
/// <param name="tradmdavg3">매도평균단가3	int	7</param>
/// <param name="tradmsavg3">매수평균단가3	int	7</param>
/// <param name="tradmdval4">매도거래대금4	long	15</param>
/// <param name="tradmsval4">매수거래대금4	long	15</param>
/// <param name="tradmdavg4">매도평균단가4	int	7</param>
/// <param name="tradmsavg4">매수평균단가4	int	7</param>
/// <param name="tradmdval5">매도거래대금5	long	15</param>
/// <param name="tradmsval5">매수거래대금5	long	15</param>
/// <param name="tradmdavg5">매도평균단가5	int	7</param>
/// <param name="tradmsavg5">매수평균단가5	int	7</param>
/// <param name="ftradmdval">외국계증권사매도거래대금	long	15</param>
/// <param name="ftradmsval">외국계증권사매수거래대금	long	15</param>
/// <param name="ftradmdavg">외국계증권사매도평균단가	int	7</param>
/// <param name="ftradmsavg">외국계증권사매수평균단가	int	7</param>
[BlockInfo(true, 753)]
public record K1_OutBlock(
    [BlockField("매도증권사코드1", 3)] string offerno1,
    [BlockField("매수증권사코드1", 3)] string bidno1,
    [BlockField("매도회원사명1", 6)] string offertrad1,
    [BlockField("매수회원사명1", 6)] string bidtrad1,
    [BlockField("매도거래량1", 10)] long tradmdvol1,
    [BlockField("매수거래량1", 10)] long tradmsvol1,
    [BlockField("매도거래량비중1", 6.2)] double tradmdrate1,
    [BlockField("매도거래량비중1", 6.2)] double tradmsrate1,
    [BlockField("매도거래량직전대비1", 10)] long tradmdcha1,
    [BlockField("매수거래량직전대비1", 10)] long tradmscha1,
    [BlockField("매도증권사코드2", 3)] string offerno2,
    [BlockField("매수증권사코드2", 3)] string bidno2,
    [BlockField("매도회원사명2", 6)] string offertrad2,
    [BlockField("매수회원사명2", 6)] string bidtrad2,
    [BlockField("매도거래량2", 10)] long tradmdvol2,
    [BlockField("매수거래량2", 10)] long tradmsvol2,
    [BlockField("매도거래량비중2", 6.2)] double tradmdrate2,
    [BlockField("매수거래량비중2", 6.2)] double tradmsrate2,
    [BlockField("매도거래량직전대비2", 10)] long tradmdcha2,
    [BlockField("매수거래량직전대비2", 10)] long tradmscha2,
    [BlockField("매도증권사코드3", 3)] string offerno3,
    [BlockField("매수증권사코드3", 3)] string bidno3,
    [BlockField("매도회원사명3", 6)] string offertrad3,
    [BlockField("매수회원사명3", 6)] string bidtrad3,
    [BlockField("매도거래량3", 10)] long tradmdvol3,
    [BlockField("매수거래량3", 10)] long tradmsvol3,
    [BlockField("매도거래량비중3", 6.2)] double tradmdrate3,
    [BlockField("매수거래량비중3", 6.2)] double tradmsrate3,
    [BlockField("매도거래량직전대비3", 10)] long tradmdcha3,
    [BlockField("매수거래량직전대비3", 10)] long tradmscha3,
    [BlockField("매도증권사코드4", 3)] string offerno4,
    [BlockField("매수증권사코드4", 3)] string bidno4,
    [BlockField("매도회원사명4", 6)] string offertrad4,
    [BlockField("매수회원사명4", 6)] string bidtrad4,
    [BlockField("매도거래량4", 10)] long tradmdvol4,
    [BlockField("매수거래량4", 10)] long tradmsvol4,
    [BlockField("매도거래량비중4", 6.2)] double tradmdrate4,
    [BlockField("매수거래량비중4", 6.2)] double tradmsrate4,
    [BlockField("매도거래량직전대비4", 10)] long tradmdcha4,
    [BlockField("매수거래량직전대비4", 10)] long tradmscha4,
    [BlockField("매도증권사코드5", 3)] string offerno5,
    [BlockField("매수증권사코드5", 3)] string bidno5,
    [BlockField("매도회원사명5", 6)] string offertrad5,
    [BlockField("매수회원사명5", 6)] string bidtrad5,
    [BlockField("매도거래량5", 10)] long tradmdvol5,
    [BlockField("매수거래량5", 10)] long tradmsvol5,
    [BlockField("매도거래량비중5", 6.2)] double tradmdrate5,
    [BlockField("매수거래량비중5", 6.2)] double tradmsrate5,
    [BlockField("매도거래량직전대비5", 10)] long tradmdcha5,
    [BlockField("매수거래량직전대비5", 10)] long tradmscha5,
    [BlockField("외국계증권사매도합계", 10)] string ftradmdvol,
    [BlockField("외국계증권사매수합계", 10)] string ftradmsvol,
    [BlockField("외국계증권사매도거래량비중", 6.2)] double ftradmdrate,
    [BlockField("외국계증권사매수거래량비중", 6.2)] double ftradmsrate,
    [BlockField("외국계증권사매도거래량직전대비", 10)] string ftradmdcha,
    [BlockField("외국계증권사매수거래량직전대비", 10)] string ftradmscha,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("매도거래대금1", 15)] long tradmdval1,
    [BlockField("매수거래대금1", 15)] long tradmsval1,
    [BlockField("매도평균단가1", 7)] int tradmdavg1,
    [BlockField("매수평균단가1", 7)] int tradmsavg1,
    [BlockField("매도거래대금2", 15)] long tradmdval2,
    [BlockField("매수거래대금2", 15)] long tradmsval2,
    [BlockField("매도평균단가2", 7)] int tradmdavg2,
    [BlockField("매수평균단가2", 7)] int tradmsavg2,
    [BlockField("매도거래대금3", 15)] long tradmdval3,
    [BlockField("매수거래대금3", 15)] long tradmsval3,
    [BlockField("매도평균단가3", 7)] int tradmdavg3,
    [BlockField("매수평균단가3", 7)] int tradmsavg3,
    [BlockField("매도거래대금4", 15)] long tradmdval4,
    [BlockField("매수거래대금4", 15)] long tradmsval4,
    [BlockField("매도평균단가4", 7)] int tradmdavg4,
    [BlockField("매수평균단가4", 7)] int tradmsavg4,
    [BlockField("매도거래대금5", 15)] long tradmdval5,
    [BlockField("매수거래대금5", 15)] long tradmsval5,
    [BlockField("매도평균단가5", 7)] int tradmdavg5,
    [BlockField("매수평균단가5", 7)] int tradmsavg5,
    [BlockField("외국계증권사매도거래대금", 15)] long ftradmdval,
    [BlockField("외국계증권사매수거래대금", 15)] long ftradmsval,
    [BlockField("외국계증권사매도평균단가", 7)] int ftradmdavg,
    [BlockField("외국계증권사매수평균단가", 7)] int ftradmsavg
    );


/// <summary>
/// ELW거래원: k1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record k1_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW거래원: k1_
/// </summary>
/// <param name="offerno1">매도증권사코드1	string	3</param>
/// <param name="bidno1">매수증권사코드1	string	3</param>
/// <param name="offertrad1">매도회원사명1	string	6</param>
/// <param name="bidtrad1">매수회원사명1	string	6</param>
/// <param name="tradmdvol1">매도거래량1	long	10</param>
/// <param name="tradmsvol1">매수거래량1	long	10</param>
/// <param name="tradmdrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	long	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	long	10</param>
/// <param name="offerno2">매도증권사코드2	string	3</param>
/// <param name="bidno2">매수증권사코드2	string	3</param>
/// <param name="offertrad2">매도회원사명2	string	6</param>
/// <param name="bidtrad2">매수회원사명2	string	6</param>
/// <param name="tradmdvol2">매도거래량2	long	10</param>
/// <param name="tradmsvol2">매수거래량2	long	10</param>
/// <param name="tradmdrate2">매도거래량비중2	double	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	double	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	long	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	long	10</param>
/// <param name="offerno3">매도증권사코드3	string	3</param>
/// <param name="bidno3">매수증권사코드3	string	3</param>
/// <param name="offertrad3">매도회원사명3	string	6</param>
/// <param name="bidtrad3">매수회원사명3	string	6</param>
/// <param name="tradmdvol3">매도거래량3	long	10</param>
/// <param name="tradmsvol3">매수거래량3	long	10</param>
/// <param name="tradmdrate3">매도거래량비중3	double	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	double	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	long	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	long	10</param>
/// <param name="offerno4">매도증권사코드4	string	3</param>
/// <param name="bidno4">매수증권사코드4	string	3</param>
/// <param name="offertrad4">매도회원사명4	string	6</param>
/// <param name="bidtrad4">매수회원사명4	string	6</param>
/// <param name="tradmdvol4">매도거래량4	long	10</param>
/// <param name="tradmsvol4">매수거래량4	long	10</param>
/// <param name="tradmdrate4">매도거래량비중4	double	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	double	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	long	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	long	10</param>
/// <param name="offerno5">매도증권사코드5	string	3</param>
/// <param name="bidno5">매수증권사코드5	string	3</param>
/// <param name="offertrad5">매도회원사명5	string	6</param>
/// <param name="bidtrad5">매수회원사명5	string	6</param>
/// <param name="tradmdvol5">매도거래량5	long	10</param>
/// <param name="tradmsvol5">매수거래량5	long	10</param>
/// <param name="tradmdrate5">매도거래량비중5	double	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	double	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	long	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	long	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	string	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	string	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	double	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	double	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	string	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	string	10</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 465)]
public record k1_OutBlock(
    [BlockField("매도증권사코드1", 3)] string offerno1,
    [BlockField("매수증권사코드1", 3)] string bidno1,
    [BlockField("매도회원사명1", 6)] string offertrad1,
    [BlockField("매수회원사명1", 6)] string bidtrad1,
    [BlockField("매도거래량1", 10)] long tradmdvol1,
    [BlockField("매수거래량1", 10)] long tradmsvol1,
    [BlockField("매도거래량비중1", 6.2)] double tradmdrate1,
    [BlockField("매도거래량비중1", 6.2)] double tradmsrate1,
    [BlockField("매도거래량직전대비1", 10)] long tradmdcha1,
    [BlockField("매수거래량직전대비1", 10)] long tradmscha1,
    [BlockField("매도증권사코드2", 3)] string offerno2,
    [BlockField("매수증권사코드2", 3)] string bidno2,
    [BlockField("매도회원사명2", 6)] string offertrad2,
    [BlockField("매수회원사명2", 6)] string bidtrad2,
    [BlockField("매도거래량2", 10)] long tradmdvol2,
    [BlockField("매수거래량2", 10)] long tradmsvol2,
    [BlockField("매도거래량비중2", 6.2)] double tradmdrate2,
    [BlockField("매수거래량비중2", 6.2)] double tradmsrate2,
    [BlockField("매도거래량직전대비2", 10)] long tradmdcha2,
    [BlockField("매수거래량직전대비2", 10)] long tradmscha2,
    [BlockField("매도증권사코드3", 3)] string offerno3,
    [BlockField("매수증권사코드3", 3)] string bidno3,
    [BlockField("매도회원사명3", 6)] string offertrad3,
    [BlockField("매수회원사명3", 6)] string bidtrad3,
    [BlockField("매도거래량3", 10)] long tradmdvol3,
    [BlockField("매수거래량3", 10)] long tradmsvol3,
    [BlockField("매도거래량비중3", 6.2)] double tradmdrate3,
    [BlockField("매수거래량비중3", 6.2)] double tradmsrate3,
    [BlockField("매도거래량직전대비3", 10)] long tradmdcha3,
    [BlockField("매수거래량직전대비3", 10)] long tradmscha3,
    [BlockField("매도증권사코드4", 3)] string offerno4,
    [BlockField("매수증권사코드4", 3)] string bidno4,
    [BlockField("매도회원사명4", 6)] string offertrad4,
    [BlockField("매수회원사명4", 6)] string bidtrad4,
    [BlockField("매도거래량4", 10)] long tradmdvol4,
    [BlockField("매수거래량4", 10)] long tradmsvol4,
    [BlockField("매도거래량비중4", 6.2)] double tradmdrate4,
    [BlockField("매수거래량비중4", 6.2)] double tradmsrate4,
    [BlockField("매도거래량직전대비4", 10)] long tradmdcha4,
    [BlockField("매수거래량직전대비4", 10)] long tradmscha4,
    [BlockField("매도증권사코드5", 3)] string offerno5,
    [BlockField("매수증권사코드5", 3)] string bidno5,
    [BlockField("매도회원사명5", 6)] string offertrad5,
    [BlockField("매수회원사명5", 6)] string bidtrad5,
    [BlockField("매도거래량5", 10)] long tradmdvol5,
    [BlockField("매수거래량5", 10)] long tradmsvol5,
    [BlockField("매도거래량비중5", 6.2)] double tradmdrate5,
    [BlockField("매수거래량비중5", 6.2)] double tradmsrate5,
    [BlockField("매도거래량직전대비5", 10)] long tradmdcha5,
    [BlockField("매수거래량직전대비5", 10)] long tradmscha5,
    [BlockField("외국계증권사매도합계", 10)] string ftradmdvol,
    [BlockField("외국계증권사매수합계", 10)] string ftradmsvol,
    [BlockField("외국계증권사매도거래량비중", 6.2)] double ftradmdrate,
    [BlockField("외국계증권사매수거래량비중", 6.2)] double ftradmsrate,
    [BlockField("외국계증권사매도거래량직전대비", 10)] string ftradmdcha,
    [BlockField("외국계증권사매수거래량직전대비", 10)] string ftradmscha,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// KOSDAQ체결: K3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record K3_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ체결: K3_
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	8</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="w_avrg">가중평균가	int	8</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="status">장정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 223)]
public record K3_OutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 8)] int price,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("시가", 8)] int open,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("고가", 8)] int high,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("저가", 8)] int low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 8)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("가중평균가", 8)] int w_avrg,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("장정보", 2)] string status,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// KOSDAQ프로그램매매종목별: KH_
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
[BlockInfo(true, 7)]
public record KH_InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ프로그램매매종목별: KH_
/// </summary>
/// <param name="time">수신시간	string	6</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	int	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="cdhrem">차익매도호가 잔량	long	12</param>
/// <param name="cshrem">차익매수호가 잔량	long	12</param>
/// <param name="bdhrem">비차익매도호가 잔량	long	12</param>
/// <param name="bshrem">비차익매수호가 잔량	long	12</param>
/// <param name="cdhvolume">차익매도호가 수량	long	12</param>
/// <param name="cshvolume">차익매수호가 수량	long	12</param>
/// <param name="bdhvolume">비차익매도호가 수량	long	12</param>
/// <param name="bshvolume">비차익매수호가 수량	long	12</param>
/// <param name="dwcvolume">전체매도위탁체결수량	long	12</param>
/// <param name="swcvolume">전체매수위탁체결수량	long	12</param>
/// <param name="djcvolume">전체매도자기체결수량	long	12</param>
/// <param name="sjcvolume">전체매수자기체결수량	long	12</param>
/// <param name="tdvolume">전체매도체결수량	long	12</param>
/// <param name="tsvolume">전체매수체결수량	long	12</param>
/// <param name="tvol">전체순매수 수량	long	12</param>
/// <param name="dwcvalue">전체매도위탁체결금액	long	15</param>
/// <param name="swcvalue">전체매수위탁체결금액	long	15</param>
/// <param name="djcvalue">전체매도자기체결금액	long	15</param>
/// <param name="sjcvalue">전체매수자기체결금액	long	15</param>
/// <param name="tdvalue">전체매도체결금액	long	15</param>
/// <param name="tsvalue">전체매수체결금액	long	15</param>
/// <param name="tval">전체순매수 금액	long	15</param>
/// <param name="pdgvolume">매도 사전공시수량	long	12</param>
/// <param name="psgvolume">매수 사전공시수량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
[BlockInfo(true, 385)]
public record KH_OutBlock(
    [BlockField("수신시간", 6)] string time,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] int sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("차익매도호가 잔량", 12)] long cdhrem,
    [BlockField("차익매수호가 잔량", 12)] long cshrem,
    [BlockField("비차익매도호가 잔량", 12)] long bdhrem,
    [BlockField("비차익매수호가 잔량", 12)] long bshrem,
    [BlockField("차익매도호가 수량", 12)] long cdhvolume,
    [BlockField("차익매수호가 수량", 12)] long cshvolume,
    [BlockField("비차익매도호가 수량", 12)] long bdhvolume,
    [BlockField("비차익매수호가 수량", 12)] long bshvolume,
    [BlockField("전체매도위탁체결수량", 12)] long dwcvolume,
    [BlockField("전체매수위탁체결수량", 12)] long swcvolume,
    [BlockField("전체매도자기체결수량", 12)] long djcvolume,
    [BlockField("전체매수자기체결수량", 12)] long sjcvolume,
    [BlockField("전체매도체결수량", 12)] long tdvolume,
    [BlockField("전체매수체결수량", 12)] long tsvolume,
    [BlockField("전체순매수 수량", 12)] long tvol,
    [BlockField("전체매도위탁체결금액", 15)] long dwcvalue,
    [BlockField("전체매수위탁체결금액", 15)] long swcvalue,
    [BlockField("전체매도자기체결금액", 15)] long djcvalue,
    [BlockField("전체매수자기체결금액", 15)] long sjcvalue,
    [BlockField("전체매도체결금액", 15)] long tdvalue,
    [BlockField("전체매수체결금액", 15)] long tsvalue,
    [BlockField("전체순매수 금액", 15)] long tval,
    [BlockField("매도 사전공시수량", 12)] long pdgvolume,
    [BlockField("매수 사전공시수량", 12)] long psgvolume,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// KOSDAQ프로그램매매전체집계: KM_
/// </summary>
/// <param name="gubun">구분값	string	1</param>
[BlockInfo(true, 2)]
public record KM_InBlock(
    [BlockField("구분값", 1)] string gubun
    );

/// <summary>
/// KOSDAQ프로그램매매전체집계: KM_
/// </summary>
/// <param name="time">수신시간	string	6</param>
/// <param name="cdhrem">차익매도호가 잔량	int	6</param>
/// <param name="cshrem">차익매수호가 잔량	int	6</param>
/// <param name="bdhrem">비차익매도호가 잔량	int	6</param>
/// <param name="bshrem">비차익매수호가 잔량	int	6</param>
/// <param name="cdhvolume">차익매도호가 수량	int	6</param>
/// <param name="cshvolume">차익매수호가 수량	int	6</param>
/// <param name="bdhvolume">비차익매도호가 수량	int	6</param>
/// <param name="bshvolume">비차익매수호가 수량	int	6</param>
/// <param name="cdwvolume">차익매도위탁체결수량	int	6</param>
/// <param name="cdjvolume">차익매도자기체결수량	int	6</param>
/// <param name="cswvolume">차익매수위탁체결수량	int	6</param>
/// <param name="csjvolume">차익매수자기체결수량	int	6</param>
/// <param name="cwvol">차익위탁순매수 수량	int	6</param>
/// <param name="cjvol">차익자기순매수 수량	int	6</param>
/// <param name="bdwvolume">비차익매도위탁체결수량	int	6</param>
/// <param name="bdjvolume">비차익매도자기체결수량	int	6</param>
/// <param name="bswvolume">비차익매수위탁체결수량	int	6</param>
/// <param name="bsjvolume">비차익매수자기체결수량	int	6</param>
/// <param name="bwvol">비차익위탁순매수 수량	int	6</param>
/// <param name="bjvol">비차익자기순매수 수량	int	6</param>
/// <param name="dwvolume">전체매도위탁체결수량	int	6</param>
/// <param name="swvolume">전체매수위탁체결수량	int	6</param>
/// <param name="wvol">전체위탁순매수 수량	int	6</param>
/// <param name="djvolume">전체매도자기체결수량	int	6</param>
/// <param name="sjvolume">전체매수자기체결수량	int	6</param>
/// <param name="jvol">전체자기순매수 수량	int	6</param>
/// <param name="cdwvalue">차익매도위탁체결금액	int	8</param>
/// <param name="cdjvalue">차익매도자기체결금액	int	8</param>
/// <param name="cswvalue">차익매수위탁체결금액	int	8</param>
/// <param name="csjvalue">차익매수자기체결금액	int	8</param>
/// <param name="cwval">차익위탁순매수 금액	int	8</param>
/// <param name="cjval">차익자기순매수 금액	int	8</param>
/// <param name="bdwvalue">비차익매도위탁체결금액	int	8</param>
/// <param name="bdjvalue">비차익매도자기체결금액	int	8</param>
/// <param name="bswvalue">비차익매수위탁체결금액	int	8</param>
/// <param name="bsjvalue">비차익매수자기체결금액	int	8</param>
/// <param name="bwval">비차익위탁순매수 금액	int	8</param>
/// <param name="bjval">비차익자기순매수 금액	int	8</param>
/// <param name="dwvalue">전체매도위탁체결금액	int	8</param>
/// <param name="swvalue">전체매수위탁체결금액	int	8</param>
/// <param name="wval">전체위탁순매수 금액	int	8</param>
/// <param name="djvalue">전체매도자기체결금액	int	8</param>
/// <param name="sjvalue">전체매수자기체결금액	int	8</param>
/// <param name="jval">전체자기순매수 금액	int	8</param>
/// <param name="k50jisu">KOSDAQ50 지수	double	6.2</param>
/// <param name="k50sign">KOSDAQ50 전일대비구분	string	1</param>
/// <param name="change">KOSDAQ50 전일대비	double	6.2</param>
/// <param name="k50basis">KOSDAQ50 베이시스	double	4.2</param>
/// <param name="cdvolume">차익매도체결수량합계	int	6</param>
/// <param name="csvolume">차익매수체결수량합계	int	6</param>
/// <param name="cvol">차익순매수 수량합계	int	6</param>
/// <param name="bdvolume">비차익매도체결수량합계	int	6</param>
/// <param name="bsvolume">비차익매수체결수량합계	int	6</param>
/// <param name="bvol">비차익순매수 수량합계	int	6</param>
/// <param name="tdvolume">전체매도체결수량합계	int	6</param>
/// <param name="tsvolume">전체매수체결수량합계	int	6</param>
/// <param name="tvol">전체순매수 수량합계	int	6</param>
/// <param name="cdvalue">차익매도체결금액합계	int	8</param>
/// <param name="csvalue">차익매수체결금액합계	int	8</param>
/// <param name="cval">차익순매수 금액합계	int	8</param>
/// <param name="bdvalue">비차익매도체결금액합계	int	8</param>
/// <param name="bsvalue">비차익매수체결금액합계	int	8</param>
/// <param name="bval">비차익순매수 금액합계	int	8</param>
/// <param name="tdvalue">전체매도체결금액합계	int	8</param>
/// <param name="tsvalue">전체매수체결금액합계	int	8</param>
/// <param name="tval">전체순매수 금액합계	int	8</param>
/// <param name="p_cdvolcha">차익매도체결수량직전대비	int	6</param>
/// <param name="p_csvolcha">차익매수체결수량직전대비	int	6</param>
/// <param name="p_cvolcha">차익순매수 수량직전대비	int	6</param>
/// <param name="p_bdvolcha">비차익매도체결수량직전대비	int	6</param>
/// <param name="p_bsvolcha">비차익매수체결수량직전대비	int	6</param>
/// <param name="p_bvolcha">비차익순매수 수량직전대비	int	6</param>
/// <param name="p_tdvolcha">전체매도체결수량직전대비	int	6</param>
/// <param name="p_tsvolcha">전체매수체결수량직전대비	int	6</param>
/// <param name="p_tvolcha">전체순매수 수량직전대비	int	6</param>
/// <param name="p_cdvalcha">차익매도체결금액직전대비	int	8</param>
/// <param name="p_csvalcha">차익매수체결금액직전대비	int	8</param>
/// <param name="p_cvalcha">차익순매수 금액직전대비	int	8</param>
/// <param name="p_bdvalcha">비차익매도체결금액직전대비	int	8</param>
/// <param name="p_bsvalcha">비차익매수체결금액직전대비	int	8</param>
/// <param name="p_bvalcha">비차익순매수 금액직전대비	int	8</param>
/// <param name="p_tdvalcha">전체매도체결금액직전대비	int	8</param>
/// <param name="p_tsvalcha">전체매수체결금액직전대비	int	8</param>
/// <param name="p_tvalcha">전체순매수 금액직전대비	int	8</param>
/// <param name="gubun">구분값	string	1</param>
[BlockInfo(true, 662)]
public record KM_OutBlock(
    [BlockField("수신시간", 6)] string time,
    [BlockField("차익매도호가 잔량", 6)] int cdhrem,
    [BlockField("차익매수호가 잔량", 6)] int cshrem,
    [BlockField("비차익매도호가 잔량", 6)] int bdhrem,
    [BlockField("비차익매수호가 잔량", 6)] int bshrem,
    [BlockField("차익매도호가 수량", 6)] int cdhvolume,
    [BlockField("차익매수호가 수량", 6)] int cshvolume,
    [BlockField("비차익매도호가 수량", 6)] int bdhvolume,
    [BlockField("비차익매수호가 수량", 6)] int bshvolume,
    [BlockField("차익매도위탁체결수량", 6)] int cdwvolume,
    [BlockField("차익매도자기체결수량", 6)] int cdjvolume,
    [BlockField("차익매수위탁체결수량", 6)] int cswvolume,
    [BlockField("차익매수자기체결수량", 6)] int csjvolume,
    [BlockField("차익위탁순매수 수량", 6)] int cwvol,
    [BlockField("차익자기순매수 수량", 6)] int cjvol,
    [BlockField("비차익매도위탁체결수량", 6)] int bdwvolume,
    [BlockField("비차익매도자기체결수량", 6)] int bdjvolume,
    [BlockField("비차익매수위탁체결수량", 6)] int bswvolume,
    [BlockField("비차익매수자기체결수량", 6)] int bsjvolume,
    [BlockField("비차익위탁순매수 수량", 6)] int bwvol,
    [BlockField("비차익자기순매수 수량", 6)] int bjvol,
    [BlockField("전체매도위탁체결수량", 6)] int dwvolume,
    [BlockField("전체매수위탁체결수량", 6)] int swvolume,
    [BlockField("전체위탁순매수 수량", 6)] int wvol,
    [BlockField("전체매도자기체결수량", 6)] int djvolume,
    [BlockField("전체매수자기체결수량", 6)] int sjvolume,
    [BlockField("전체자기순매수 수량", 6)] int jvol,
    [BlockField("차익매도위탁체결금액", 8)] int cdwvalue,
    [BlockField("차익매도자기체결금액", 8)] int cdjvalue,
    [BlockField("차익매수위탁체결금액", 8)] int cswvalue,
    [BlockField("차익매수자기체결금액", 8)] int csjvalue,
    [BlockField("차익위탁순매수 금액", 8)] int cwval,
    [BlockField("차익자기순매수 금액", 8)] int cjval,
    [BlockField("비차익매도위탁체결금액", 8)] int bdwvalue,
    [BlockField("비차익매도자기체결금액", 8)] int bdjvalue,
    [BlockField("비차익매수위탁체결금액", 8)] int bswvalue,
    [BlockField("비차익매수자기체결금액", 8)] int bsjvalue,
    [BlockField("비차익위탁순매수 금액", 8)] int bwval,
    [BlockField("비차익자기순매수 금액", 8)] int bjval,
    [BlockField("전체매도위탁체결금액", 8)] int dwvalue,
    [BlockField("전체매수위탁체결금액", 8)] int swvalue,
    [BlockField("전체위탁순매수 금액", 8)] int wval,
    [BlockField("전체매도자기체결금액", 8)] int djvalue,
    [BlockField("전체매수자기체결금액", 8)] int sjvalue,
    [BlockField("전체자기순매수 금액", 8)] int jval,
    [BlockField("KOSDAQ50 지수", 6.2)] double k50jisu,
    [BlockField("KOSDAQ50 전일대비구분", 1)] string k50sign,
    [BlockField("KOSDAQ50 전일대비", 6.2)] double change,
    [BlockField("KOSDAQ50 베이시스", 4.2)] double k50basis,
    [BlockField("차익매도체결수량합계", 6)] int cdvolume,
    [BlockField("차익매수체결수량합계", 6)] int csvolume,
    [BlockField("차익순매수 수량합계", 6)] int cvol,
    [BlockField("비차익매도체결수량합계", 6)] int bdvolume,
    [BlockField("비차익매수체결수량합계", 6)] int bsvolume,
    [BlockField("비차익순매수 수량합계", 6)] int bvol,
    [BlockField("전체매도체결수량합계", 6)] int tdvolume,
    [BlockField("전체매수체결수량합계", 6)] int tsvolume,
    [BlockField("전체순매수 수량합계", 6)] int tvol,
    [BlockField("차익매도체결금액합계", 8)] int cdvalue,
    [BlockField("차익매수체결금액합계", 8)] int csvalue,
    [BlockField("차익순매수 금액합계", 8)] int cval,
    [BlockField("비차익매도체결금액합계", 8)] int bdvalue,
    [BlockField("비차익매수체결금액합계", 8)] int bsvalue,
    [BlockField("비차익순매수 금액합계", 8)] int bval,
    [BlockField("전체매도체결금액합계", 8)] int tdvalue,
    [BlockField("전체매수체결금액합계", 8)] int tsvalue,
    [BlockField("전체순매수 금액합계", 8)] int tval,
    [BlockField("차익매도체결수량직전대비", 6)] int p_cdvolcha,
    [BlockField("차익매수체결수량직전대비", 6)] int p_csvolcha,
    [BlockField("차익순매수 수량직전대비", 6)] int p_cvolcha,
    [BlockField("비차익매도체결수량직전대비", 6)] int p_bdvolcha,
    [BlockField("비차익매수체결수량직전대비", 6)] int p_bsvolcha,
    [BlockField("비차익순매수 수량직전대비", 6)] int p_bvolcha,
    [BlockField("전체매도체결수량직전대비", 6)] int p_tdvolcha,
    [BlockField("전체매수체결수량직전대비", 6)] int p_tsvolcha,
    [BlockField("전체순매수 수량직전대비", 6)] int p_tvolcha,
    [BlockField("차익매도체결금액직전대비", 8)] int p_cdvalcha,
    [BlockField("차익매수체결금액직전대비", 8)] int p_csvalcha,
    [BlockField("차익순매수 금액직전대비", 8)] int p_cvalcha,
    [BlockField("비차익매도체결금액직전대비", 8)] int p_bdvalcha,
    [BlockField("비차익매수체결금액직전대비", 8)] int p_bsvalcha,
    [BlockField("비차익순매수 금액직전대비", 8)] int p_bvalcha,
    [BlockField("전체매도체결금액직전대비", 8)] int p_tdvalcha,
    [BlockField("전체매수체결금액직전대비", 8)] int p_tsvalcha,
    [BlockField("전체순매수 금액직전대비", 8)] int p_tvalcha,
    [BlockField("구분값", 1)] string gubun
    );


/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record KS_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 25)]
public record KS_OutBlock(
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// US지수: MK2
/// </summary>
/// <param name="symbol">심볼코드	string	16</param>
[BlockInfo(true, 17)]
public record MK2InBlock(
    [BlockField("심볼코드", 16)] string symbol
    );

/// <summary>
/// US지수: MK2
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="kodate">한국일자	string	8</param>
/// <param name="kotime">한국시간	string	6</param>
/// <param name="open">시가	double	9.2</param>
/// <param name="high">고가	double	9.2</param>
/// <param name="low">저가	double	9.2</param>
/// <param name="price">현재가	double	9.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	9.2</param>
/// <param name="uprate">등락율	double	9.2</param>
/// <param name="bidho">매수호가	double	9.2</param>
/// <param name="bidrem">매수잔량	long	9</param>
/// <param name="offerho">매도호가	double	9.2</param>
/// <param name="offerrem">매도잔량	long	9</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="xsymbol">심벌	string	16</param>
/// <param name="cvolume">체결거래량	double	8</param>
[BlockInfo(true, 173)]
public record MK2OutBlock(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("한국일자", 8)] string kodate,
    [BlockField("한국시간", 6)] string kotime,
    [BlockField("시가", 9.2)] double open,
    [BlockField("고가", 9.2)] double high,
    [BlockField("저가", 9.2)] double low,
    [BlockField("현재가", 9.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 9.2)] double change,
    [BlockField("등락율", 9.2)] double uprate,
    [BlockField("매수호가", 9.2)] double bidho,
    [BlockField("매수잔량", 9)] long bidrem,
    [BlockField("매도호가", 9.2)] double offerho,
    [BlockField("매도잔량", 9)] long offerrem,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("심벌", 16)] string xsymbol,
    [BlockField("체결거래량", 8)] double cvolume
    );


/// <summary>
/// 실시간 뉴스 제목 패킷: NWS
/// </summary>
/// <param name="nwcode">뉴스코드	string	6</param>
[BlockInfo(false, 6)]
public record NWSInBlock(
    [BlockField("뉴스코드", 6)] string nwcode
    );

/// <summary>
/// 실시간 뉴스 제목 패킷: NWS
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="id">뉴스구분자	string	2</param>
/// <param name="realkey">키값	string	24</param>
/// <param name="title">제목	string	300</param>
/// <param name="code">단축종목코드	string	240</param>
/// <param name="bodysize">BODY길이	int	8</param>
[BlockInfo(false, 588)]
public record NWSOutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("뉴스구분자", 2)] string id,
    [BlockField("키값", 24)] string realkey,
    [BlockField("제목", 300)] string title,
    [BlockField("단축종목코드", 240)] string code,
    [BlockField("BODY길이", 8)] int bodysize
    );


/// <summary>
/// 선물접수: O01
/// </summary>
[BlockInfo(false, 0)]
public record O01InBlock(
    );

/// <summary>
/// 선물접수: O01
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="trcode1">tr코드	string	4</param>
/// <param name="firmno">회사번호	string	3</param>
/// <param name="acntno">계좌번호	string	11</param>
/// <param name="acntno1">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="brnno">지점번호	string	3</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordno1">주문번호	string	3</param>
/// <param name="ordno">주문번호	int	7</param>
/// <param name="orgordno1">원주문번호	string	3</param>
/// <param name="orgordno">원주문번호	int	7</param>
/// <param name="prntordno">모주문번호	string	3</param>
/// <param name="prntordno1">모주문번호	int	7</param>
/// <param name="isuno">종목번호	string	12</param>
/// <param name="fnoIsuno">선물옵션종목번호	string	8</param>
/// <param name="fnoIsunm">선물옵션종목명	string	40</param>
/// <param name="pdgrpcode">상품군분류코드	string	2</param>
/// <param name="fnoIsuptntp">선물옵션종목유형구분	string	1</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="mrctp">정정취소구분	string	1</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="hogatype">호가유형코드	string	2</param>
/// <param name="mmgb">거래유형코드	string	2</param>
/// <param name="ordprc">주문가격	double	13.2</param>
/// <param name="unercqty">미체결수량	long	16</param>
/// <param name="commdacode">통신매체	string	2</param>
/// <param name="peeamtcode">수수료합산코드	string	2</param>
/// <param name="mgempno">관리사원	string	9</param>
/// <param name="fnotrdunitamt">선물옵션거래단위금액	double	19.8</param>
/// <param name="trxtime">처리시각	string	9</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	string	10</param>
/// <param name="ptflno">포트폴리오 번호	string	10</param>
/// <param name="bskno">바스켓번호	string	10</param>
/// <param name="trchno">트렌치번호	string	10</param>
/// <param name="Itemno">아이템번호	string	10</param>
/// <param name="userId">주문자Id	string	16</param>
/// <param name="opdrtnno">운영지시번호	string	12</param>
/// <param name="rjtcode">부적격코드	string	3</param>
/// <param name="mrccnfqty">정정취소확인수량	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmrcqty">원주문정정취소수량	long	16</param>
/// <param name="ctrcttime">약정시각(체결시각)	string	8</param>
/// <param name="ctrctno">약정번호	string	10</param>
/// <param name="execprc">체결가격	double	13.2</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="newqty">신규체결수량	long	16</param>
/// <param name="qdtqty">청산체결수량	long	16</param>
/// <param name="lastqty">최종결제수량	long	16</param>
/// <param name="lallexecqty">전체체결수량	long	16</param>
/// <param name="allexecamt">전체체결금액	long	16</param>
/// <param name="fnobalevaltp">잔고평가구분	string	1</param>
/// <param name="bnsplamt">매매손익금액	long	16</param>
/// <param name="fnoIsuno1">선물옵션종목번호1	string	8</param>
/// <param name="bnstp1">매매구분1	string	1</param>
/// <param name="execprc1">체결가1	double	13.2</param>
/// <param name="newqty1">신규체결수량1	long	16</param>
/// <param name="qdtqty1">청산체결수량1	long	16</param>
/// <param name="allexecamt1">전체체결금액1	long	16</param>
/// <param name="fnoIsuno2">선물옵션종목번호2	string	8</param>
/// <param name="bnstp2">매매구분2	string	1</param>
/// <param name="execprc2">체결가2	double	13.2</param>
/// <param name="newqty2">신규체결수량2	long	16</param>
/// <param name="lqdtqty2">청산체결수량2	long	16</param>
/// <param name="allexecamt2">전체체결금액2	long	16</param>
/// <param name="dps">예수금	long	16</param>
/// <param name="ftsubtdsgnamt">선물대용지정금액	long	16</param>
/// <param name="mgn">증거금	long	16</param>
/// <param name="mnymgn">증거금현금	long	16</param>
/// <param name="ordableamt">주문가능금액	long	16</param>
/// <param name="mnyordableamt">주문가능현금액	long	16</param>
/// <param name="fnoIsuno_1">잔고 종목번호1	string	8</param>
/// <param name="bnstp_1">잔고 매매구분1	string	1</param>
/// <param name="unsttqty_1">미결제수량1	long	16</param>
/// <param name="lqdtableqty_1">주문가능수량1	long	16</param>
/// <param name="avrprc_1">평균가1	double	13.2</param>
/// <param name="fnoIsuno_2">잔고 종목번호2	string	8</param>
/// <param name="bnstp_2">잔고 매매구분2	string	1</param>
/// <param name="unsttqty_2">미결제수량2	long	16</param>
/// <param name="lqdtableqty_2">주문가능수량2	long	16</param>
/// <param name="avrprc_2">평균가2	double	13.2</param>
[BlockInfo(false, 1141)]
public record O01OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("tr코드", 4)] string trcode1,
    [BlockField("회사번호", 3)] string firmno,
    [BlockField("계좌번호", 11)] string acntno,
    [BlockField("계좌번호", 9)] string acntno1,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("지점번호", 3)] string brnno,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문번호", 3)] string ordno1,
    [BlockField("주문번호", 7)] int ordno,
    [BlockField("원주문번호", 3)] string orgordno1,
    [BlockField("원주문번호", 7)] int orgordno,
    [BlockField("모주문번호", 3)] string prntordno,
    [BlockField("모주문번호", 7)] int prntordno1,
    [BlockField("종목번호", 12)] string isuno,
    [BlockField("선물옵션종목번호", 8)] string fnoIsuno,
    [BlockField("선물옵션종목명", 40)] string fnoIsunm,
    [BlockField("상품군분류코드", 2)] string pdgrpcode,
    [BlockField("선물옵션종목유형구분", 1)] string fnoIsuptntp,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("정정취소구분", 1)] string mrctp,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("호가유형코드", 2)] string hogatype,
    [BlockField("거래유형코드", 2)] string mmgb,
    [BlockField("주문가격", 13.2)] double ordprc,
    [BlockField("미체결수량", 16)] long unercqty,
    [BlockField("통신매체", 2)] string commdacode,
    [BlockField("수수료합산코드", 2)] string peeamtcode,
    [BlockField("관리사원", 9)] string mgempno,
    [BlockField("선물옵션거래단위금액", 19.8)] double fnotrdunitamt,
    [BlockField("처리시각", 9)] string trxtime,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] string ordseqno,
    [BlockField("포트폴리오 번호", 10)] string ptflno,
    [BlockField("바스켓번호", 10)] string bskno,
    [BlockField("트렌치번호", 10)] string trchno,
    [BlockField("아이템번호", 10)] string Itemno,
    [BlockField("주문자Id", 16)] string userId,
    [BlockField("운영지시번호", 12)] string opdrtnno,
    [BlockField("부적격코드", 3)] string rjtcode,
    [BlockField("정정취소확인수량", 16)] long mrccnfqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정취소수량", 16)] long orgordmrcqty,
    [BlockField("약정시각(체결시각)", 8)] string ctrcttime,
    [BlockField("약정번호", 10)] string ctrctno,
    [BlockField("체결가격", 13.2)] double execprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("신규체결수량", 16)] long newqty,
    [BlockField("청산체결수량", 16)] long qdtqty,
    [BlockField("최종결제수량", 16)] long lastqty,
    [BlockField("전체체결수량", 16)] long lallexecqty,
    [BlockField("전체체결금액", 16)] long allexecamt,
    [BlockField("잔고평가구분", 1)] string fnobalevaltp,
    [BlockField("매매손익금액", 16)] long bnsplamt,
    [BlockField("선물옵션종목번호1", 8)] string fnoIsuno1,
    [BlockField("매매구분1", 1)] string bnstp1,
    [BlockField("체결가1", 13.2)] double execprc1,
    [BlockField("신규체결수량1", 16)] long newqty1,
    [BlockField("청산체결수량1", 16)] long qdtqty1,
    [BlockField("전체체결금액1", 16)] long allexecamt1,
    [BlockField("선물옵션종목번호2", 8)] string fnoIsuno2,
    [BlockField("매매구분2", 1)] string bnstp2,
    [BlockField("체결가2", 13.2)] double execprc2,
    [BlockField("신규체결수량2", 16)] long newqty2,
    [BlockField("청산체결수량2", 16)] long lqdtqty2,
    [BlockField("전체체결금액2", 16)] long allexecamt2,
    [BlockField("예수금", 16)] long dps,
    [BlockField("선물대용지정금액", 16)] long ftsubtdsgnamt,
    [BlockField("증거금", 16)] long mgn,
    [BlockField("증거금현금", 16)] long mnymgn,
    [BlockField("주문가능금액", 16)] long ordableamt,
    [BlockField("주문가능현금액", 16)] long mnyordableamt,
    [BlockField("잔고 종목번호1", 8)] string fnoIsuno_1,
    [BlockField("잔고 매매구분1", 1)] string bnstp_1,
    [BlockField("미결제수량1", 16)] long unsttqty_1,
    [BlockField("주문가능수량1", 16)] long lqdtableqty_1,
    [BlockField("평균가1", 13.2)] double avrprc_1,
    [BlockField("잔고 종목번호2", 8)] string fnoIsuno_2,
    [BlockField("잔고 매매구분2", 1)] string bnstp_2,
    [BlockField("미결제수량2", 16)] long unsttqty_2,
    [BlockField("주문가능수량2", 16)] long lqdtableqty_2,
    [BlockField("평균가2", 13.2)] double avrprc_2
    );


/// <summary>
/// KOSPI200옵션체결(C0): OC0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record OC0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// KOSPI200옵션체결(C0): OC0
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	6</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="openyak">미결제약정수량	int	8</param>
/// <param name="k200jisu">KOSPI200지수	double	6.2</param>
/// <param name="eqva">KOSPI등가	double	7.2</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="openyakcha">미결제약정증감	int	8</param>
/// <param name="timevalue">시간가치	double	6.2</param>
/// <param name="jgubun">장운영정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 233)]
public record OC0OutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 6)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("미결제약정수량", 8)] int openyak,
    [BlockField("KOSPI200지수", 6.2)] double k200jisu,
    [BlockField("KOSPI등가", 7.2)] double eqva,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("미결제약정증감", 8)] int openyakcha,
    [BlockField("시간가치", 6.2)] double timevalue,
    [BlockField("장운영정보", 2)] string jgubun,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 8)] string optcode
    );


/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record OD0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="opttcode">단축코드	string	8</param>
[BlockInfo(true, 31)]
public record OD0OutBlock(
    [BlockField("접속매매여부", 1)] string gubun,
    [BlockField("실시간가격제한여부", 1)] string dy_gubun,
    [BlockField("실시간상한가", 8.2)] double dy_uplmtprice,
    [BlockField("실시간하한가", 8.2)] double dy_dnlmtprice,
    [BlockField("단축코드", 8)] string opttcode
    );


/// <summary>
/// KOSPI200옵션호가(H0): OH0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record OH0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// KOSPI200옵션호가(H0): OH0
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="offerrem1">매도호가수량1	int	7</param>
/// <param name="bidrem1">매수호가수량1	int	7</param>
/// <param name="offercnt1">매도호가건수1	int	5</param>
/// <param name="bidcnt1">매수호가건수1	int	5</param>
/// <param name="offerho2">매도호가2	double	6.2</param>
/// <param name="bidho2">매수호가2	double	6.2</param>
/// <param name="offerrem2">매도호가수량2	int	7</param>
/// <param name="bidrem2">매수호가수량2	int	7</param>
/// <param name="offercnt2">매도호가건수2	int	5</param>
/// <param name="bidcnt2">매수호가건수2	int	5</param>
/// <param name="offerho3">매도호가3	double	6.2</param>
/// <param name="bidho3">매수호가3	double	6.2</param>
/// <param name="offerrem3">매도호가수량3	int	7</param>
/// <param name="bidrem3">매수호가수량3	int	7</param>
/// <param name="offercnt3">매도호가건수3	int	5</param>
/// <param name="bidcnt3">매수호가건수3	int	5</param>
/// <param name="offerho4">매도호가4	double	6.2</param>
/// <param name="bidho4">매수호가4	double	6.2</param>
/// <param name="offerrem4">매도호가수량4	int	7</param>
/// <param name="bidrem4">매수호가수량4	int	7</param>
/// <param name="offercnt4">매도호가건수4	int	5</param>
/// <param name="bidcnt4">매수호가건수4	int	5</param>
/// <param name="offerho5">매도호가5	double	6.2</param>
/// <param name="bidho5">매수호가5	double	6.2</param>
/// <param name="offerrem5">매도호가수량5	int	7</param>
/// <param name="bidrem5">매수호가수량5	int	7</param>
/// <param name="offercnt5">매도호가건수5	int	5</param>
/// <param name="bidcnt5">매수호가건수5	int	5</param>
/// <param name="totofferrem">매도호가총수량	int	7</param>
/// <param name="totbidrem">매수호가총수량	int	7</param>
/// <param name="totoffercnt">매도호가총건수	int	5</param>
/// <param name="totbidcnt">매수호가총건수	int	5</param>
/// <param name="optcode">단축코드	string	8</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="alloc_gubun">배분적용구분	string	1</param>
[BlockInfo(true, 258)]
public record OH0OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("매도호가수량1", 7)] int offerrem1,
    [BlockField("매수호가수량1", 7)] int bidrem1,
    [BlockField("매도호가건수1", 5)] int offercnt1,
    [BlockField("매수호가건수1", 5)] int bidcnt1,
    [BlockField("매도호가2", 6.2)] double offerho2,
    [BlockField("매수호가2", 6.2)] double bidho2,
    [BlockField("매도호가수량2", 7)] int offerrem2,
    [BlockField("매수호가수량2", 7)] int bidrem2,
    [BlockField("매도호가건수2", 5)] int offercnt2,
    [BlockField("매수호가건수2", 5)] int bidcnt2,
    [BlockField("매도호가3", 6.2)] double offerho3,
    [BlockField("매수호가3", 6.2)] double bidho3,
    [BlockField("매도호가수량3", 7)] int offerrem3,
    [BlockField("매수호가수량3", 7)] int bidrem3,
    [BlockField("매도호가건수3", 5)] int offercnt3,
    [BlockField("매수호가건수3", 5)] int bidcnt3,
    [BlockField("매도호가4", 6.2)] double offerho4,
    [BlockField("매수호가4", 6.2)] double bidho4,
    [BlockField("매도호가수량4", 7)] int offerrem4,
    [BlockField("매수호가수량4", 7)] int bidrem4,
    [BlockField("매도호가건수4", 5)] int offercnt4,
    [BlockField("매수호가건수4", 5)] int bidcnt4,
    [BlockField("매도호가5", 6.2)] double offerho5,
    [BlockField("매수호가5", 6.2)] double bidho5,
    [BlockField("매도호가수량5", 7)] int offerrem5,
    [BlockField("매수호가수량5", 7)] int bidrem5,
    [BlockField("매도호가건수5", 5)] int offercnt5,
    [BlockField("매수호가건수5", 5)] int bidcnt5,
    [BlockField("매도호가총수량", 7)] int totofferrem,
    [BlockField("매수호가총수량", 7)] int totbidrem,
    [BlockField("매도호가총건수", 5)] int totoffercnt,
    [BlockField("매수호가총건수", 5)] int totbidcnt,
    [BlockField("단축코드", 8)] string optcode,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("배분적용구분", 1)] string alloc_gubun
    );


/// <summary>
/// KOSDAQ거래원: OK_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record OK_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ거래원: OK_
/// </summary>
/// <param name="offerno1">매도증권사코드1	string	3</param>
/// <param name="bidno1">매수증권사코드1	string	3</param>
/// <param name="offertrad1">매도회원사명1	string	6</param>
/// <param name="bidtrad1">매수회원사명1	string	6</param>
/// <param name="tradmdvol1">매도거래량1	long	10</param>
/// <param name="tradmsvol1">매수거래량1	long	10</param>
/// <param name="tradmdrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	double	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	long	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	long	10</param>
/// <param name="offerno2">매도증권사코드2	string	3</param>
/// <param name="bidno2">매수증권사코드2	string	3</param>
/// <param name="offertrad2">매도회원사명2	string	6</param>
/// <param name="bidtrad2">매수회원사명2	string	6</param>
/// <param name="tradmdvol2">매도거래량2	long	10</param>
/// <param name="tradmsvol2">매수거래량2	long	10</param>
/// <param name="tradmdrate2">매도거래량비중2	double	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	double	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	long	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	long	10</param>
/// <param name="offerno3">매도증권사코드3	string	3</param>
/// <param name="bidno3">매수증권사코드3	string	3</param>
/// <param name="offertrad3">매도회원사명3	string	6</param>
/// <param name="bidtrad3">매수회원사명3	string	6</param>
/// <param name="tradmdvol3">매도거래량3	long	10</param>
/// <param name="tradmsvol3">매수거래량3	long	10</param>
/// <param name="tradmdrate3">매도거래량비중3	double	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	double	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	long	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	long	10</param>
/// <param name="offerno4">매도증권사코드4	string	3</param>
/// <param name="bidno4">매수증권사코드4	string	3</param>
/// <param name="offertrad4">매도회원사명4	string	6</param>
/// <param name="bidtrad4">매수회원사명4	string	6</param>
/// <param name="tradmdvol4">매도거래량4	long	10</param>
/// <param name="tradmsvol4">매수거래량4	long	10</param>
/// <param name="tradmdrate4">매도거래량비중4	double	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	double	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	long	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	long	10</param>
/// <param name="offerno5">매도증권사코드5	string	3</param>
/// <param name="bidno5">매수증권사코드5	string	3</param>
/// <param name="offertrad5">매도회원사명5	string	6</param>
/// <param name="bidtrad5">매수회원사명5	string	6</param>
/// <param name="tradmdvol5">매도거래량5	long	10</param>
/// <param name="tradmsvol5">매수거래량5	long	10</param>
/// <param name="tradmdrate5">매도거래량비중5	double	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	double	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	long	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	long	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	string	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	string	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	double	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	double	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	string	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	string	10</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="tradmdval1">매도거래대금1	long	15</param>
/// <param name="tradmsval1">매수거래대금1	long	15</param>
/// <param name="tradmdavg1">매도평균단가1	int	7</param>
/// <param name="tradmsavg1">매수평균단가1	int	7</param>
/// <param name="tradmdval2">매도거래대금2	long	15</param>
/// <param name="tradmsval2">매수거래대금2	long	15</param>
/// <param name="tradmdavg2">매도평균단가2	int	7</param>
/// <param name="tradmsavg2">매수평균단가2	int	7</param>
/// <param name="tradmdval3">매도거래대금3	long	15</param>
/// <param name="tradmsval3">매수거래대금3	long	15</param>
/// <param name="tradmdavg3">매도평균단가3	int	7</param>
/// <param name="tradmsavg3">매수평균단가3	int	7</param>
/// <param name="tradmdval4">매도거래대금4	long	15</param>
/// <param name="tradmsval4">매수거래대금4	long	15</param>
/// <param name="tradmdavg4">매도평균단가4	int	7</param>
/// <param name="tradmsavg4">매수평균단가4	int	7</param>
/// <param name="tradmdval5">매도거래대금5	long	15</param>
/// <param name="tradmsval5">매수거래대금5	long	15</param>
/// <param name="tradmdavg5">매도평균단가5	int	7</param>
/// <param name="tradmsavg5">매수평균단가5	int	7</param>
/// <param name="ftradmdval">외국계증권사매도거래대금	long	15</param>
/// <param name="ftradmsval">외국계증권사매수거래대금	long	15</param>
/// <param name="ftradmdavg">외국계증권사매도평균단가	int	7</param>
/// <param name="ftradmsavg">외국계증권사매수평균단가	int	7</param>
[BlockInfo(true, 753)]
public record OK_OutBlock(
    [BlockField("매도증권사코드1", 3)] string offerno1,
    [BlockField("매수증권사코드1", 3)] string bidno1,
    [BlockField("매도회원사명1", 6)] string offertrad1,
    [BlockField("매수회원사명1", 6)] string bidtrad1,
    [BlockField("매도거래량1", 10)] long tradmdvol1,
    [BlockField("매수거래량1", 10)] long tradmsvol1,
    [BlockField("매도거래량비중1", 6.2)] double tradmdrate1,
    [BlockField("매도거래량비중1", 6.2)] double tradmsrate1,
    [BlockField("매도거래량직전대비1", 10)] long tradmdcha1,
    [BlockField("매수거래량직전대비1", 10)] long tradmscha1,
    [BlockField("매도증권사코드2", 3)] string offerno2,
    [BlockField("매수증권사코드2", 3)] string bidno2,
    [BlockField("매도회원사명2", 6)] string offertrad2,
    [BlockField("매수회원사명2", 6)] string bidtrad2,
    [BlockField("매도거래량2", 10)] long tradmdvol2,
    [BlockField("매수거래량2", 10)] long tradmsvol2,
    [BlockField("매도거래량비중2", 6.2)] double tradmdrate2,
    [BlockField("매수거래량비중2", 6.2)] double tradmsrate2,
    [BlockField("매도거래량직전대비2", 10)] long tradmdcha2,
    [BlockField("매수거래량직전대비2", 10)] long tradmscha2,
    [BlockField("매도증권사코드3", 3)] string offerno3,
    [BlockField("매수증권사코드3", 3)] string bidno3,
    [BlockField("매도회원사명3", 6)] string offertrad3,
    [BlockField("매수회원사명3", 6)] string bidtrad3,
    [BlockField("매도거래량3", 10)] long tradmdvol3,
    [BlockField("매수거래량3", 10)] long tradmsvol3,
    [BlockField("매도거래량비중3", 6.2)] double tradmdrate3,
    [BlockField("매수거래량비중3", 6.2)] double tradmsrate3,
    [BlockField("매도거래량직전대비3", 10)] long tradmdcha3,
    [BlockField("매수거래량직전대비3", 10)] long tradmscha3,
    [BlockField("매도증권사코드4", 3)] string offerno4,
    [BlockField("매수증권사코드4", 3)] string bidno4,
    [BlockField("매도회원사명4", 6)] string offertrad4,
    [BlockField("매수회원사명4", 6)] string bidtrad4,
    [BlockField("매도거래량4", 10)] long tradmdvol4,
    [BlockField("매수거래량4", 10)] long tradmsvol4,
    [BlockField("매도거래량비중4", 6.2)] double tradmdrate4,
    [BlockField("매수거래량비중4", 6.2)] double tradmsrate4,
    [BlockField("매도거래량직전대비4", 10)] long tradmdcha4,
    [BlockField("매수거래량직전대비4", 10)] long tradmscha4,
    [BlockField("매도증권사코드5", 3)] string offerno5,
    [BlockField("매수증권사코드5", 3)] string bidno5,
    [BlockField("매도회원사명5", 6)] string offertrad5,
    [BlockField("매수회원사명5", 6)] string bidtrad5,
    [BlockField("매도거래량5", 10)] long tradmdvol5,
    [BlockField("매수거래량5", 10)] long tradmsvol5,
    [BlockField("매도거래량비중5", 6.2)] double tradmdrate5,
    [BlockField("매수거래량비중5", 6.2)] double tradmsrate5,
    [BlockField("매도거래량직전대비5", 10)] long tradmdcha5,
    [BlockField("매수거래량직전대비5", 10)] long tradmscha5,
    [BlockField("외국계증권사매도합계", 10)] string ftradmdvol,
    [BlockField("외국계증권사매수합계", 10)] string ftradmsvol,
    [BlockField("외국계증권사매도거래량비중", 6.2)] double ftradmdrate,
    [BlockField("외국계증권사매수거래량비중", 6.2)] double ftradmsrate,
    [BlockField("외국계증권사매도거래량직전대비", 10)] string ftradmdcha,
    [BlockField("외국계증권사매수거래량직전대비", 10)] string ftradmscha,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("매도거래대금1", 15)] long tradmdval1,
    [BlockField("매수거래대금1", 15)] long tradmsval1,
    [BlockField("매도평균단가1", 7)] int tradmdavg1,
    [BlockField("매수평균단가1", 7)] int tradmsavg1,
    [BlockField("매도거래대금2", 15)] long tradmdval2,
    [BlockField("매수거래대금2", 15)] long tradmsval2,
    [BlockField("매도평균단가2", 7)] int tradmdavg2,
    [BlockField("매수평균단가2", 7)] int tradmsavg2,
    [BlockField("매도거래대금3", 15)] long tradmdval3,
    [BlockField("매수거래대금3", 15)] long tradmsval3,
    [BlockField("매도평균단가3", 7)] int tradmdavg3,
    [BlockField("매수평균단가3", 7)] int tradmsavg3,
    [BlockField("매도거래대금4", 15)] long tradmdval4,
    [BlockField("매수거래대금4", 15)] long tradmsval4,
    [BlockField("매도평균단가4", 7)] int tradmdavg4,
    [BlockField("매수평균단가4", 7)] int tradmsavg4,
    [BlockField("매도거래대금5", 15)] long tradmdval5,
    [BlockField("매수거래대금5", 15)] long tradmsval5,
    [BlockField("매도평균단가5", 7)] int tradmdavg5,
    [BlockField("매수평균단가5", 7)] int tradmsavg5,
    [BlockField("외국계증권사매도거래대금", 15)] long ftradmdval,
    [BlockField("외국계증권사매수거래대금", 15)] long ftradmsval,
    [BlockField("외국계증권사매도평균단가", 7)] int ftradmdavg,
    [BlockField("외국계증권사매수평균단가", 7)] int ftradmsavg
    );


/// <summary>
/// KOSPI200옵션민감도(MG): OMG
/// </summary>
/// <param name="optcode">옵션코드	string	8</param>
[BlockInfo(true, 9)]
public record OMGInBlock(
    [BlockField("옵션코드", 8)] string optcode
    );

/// <summary>
/// KOSPI200옵션민감도(MG): OMG
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="k200jisu">KOSPI200지수	double	6.2</param>
/// <param name="fut200jisu">선물가격	double	6.2</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="capimpv">대표내재변동성	double	6.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="delt">델타(블랙숄즈)	double	7.4</param>
/// <param name="gama">감마(블랙숄즈)	double	7.4</param>
/// <param name="ceta">세타(블랙숄즈)	double	7.4</param>
/// <param name="vega">베가(블랙숄즈)	double	7.4</param>
/// <param name="rhox">로우(블랙숄즈)	double	7.4</param>
/// <param name="theoryprice">이론가(블랙숄즈)	double	6.2</param>
/// <param name="bimpv">전일가내재변동성	double	6.2</param>
/// <param name="offerimpv">매도가내재변동성	double	6.2</param>
/// <param name="bidimpv">매수가내재변동성	double	6.2</param>
/// <param name="optcode">옵션코드	string	8</param>
[BlockInfo(true, 126)]
public record OMGOutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("KOSPI200지수", 6.2)] double k200jisu,
    [BlockField("선물가격", 6.2)] double fut200jisu,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("대표내재변동성", 6.2)] double capimpv,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("델타(블랙숄즈)", 7.4)] double delt,
    [BlockField("감마(블랙숄즈)", 7.4)] double gama,
    [BlockField("세타(블랙숄즈)", 7.4)] double ceta,
    [BlockField("베가(블랙숄즈)", 7.4)] double vega,
    [BlockField("로우(블랙숄즈)", 7.4)] double rhox,
    [BlockField("이론가(블랙숄즈)", 6.2)] double theoryprice,
    [BlockField("전일가내재변동성", 6.2)] double bimpv,
    [BlockField("매도가내재변동성", 6.2)] double offerimpv,
    [BlockField("매수가내재변동성", 6.2)] double bidimpv,
    [BlockField("옵션코드", 8)] string optcode
    );


/// <summary>
/// 해외선물 현재가체결: OVC
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
[BlockInfo(true, 9)]
public record OVCInBlock(
    [BlockField("종목코드", 8)] string symbol
    );

/// <summary>
/// 해외선물 현재가체결: OVC
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
/// <param name="ovsdate">체결일자(현지)	string	8</param>
/// <param name="kordate">체결일자(한국)	string	8</param>
/// <param name="trdtm">체결시간(현지)	string	6</param>
/// <param name="kortm">체결시간(한국)	string	6</param>
/// <param name="curpr">체결가격	double	15.9</param>
/// <param name="ydiffpr">전일대비	double	15.9</param>
/// <param name="ydiffSign">전일대비기호	string	1</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="chgrate">등락율	double	6.2</param>
/// <param name="trdq">건별체결수량	long	10</param>
/// <param name="totq">누적체결수량	string	15</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="mdvolume">매도누적체결수량	string	15</param>
/// <param name="msvolume">매수누적체결수량	string	15</param>
/// <param name="ovsmkend">장마감일	string	8</param>
[BlockInfo(true, 200)]
public record OVCOutBlock(
    [BlockField("종목코드", 8)] string symbol,
    [BlockField("체결일자(현지)", 8)] string ovsdate,
    [BlockField("체결일자(한국)", 8)] string kordate,
    [BlockField("체결시간(현지)", 6)] string trdtm,
    [BlockField("체결시간(한국)", 6)] string kortm,
    [BlockField("체결가격", 15.9)] double curpr,
    [BlockField("전일대비", 15.9)] double ydiffpr,
    [BlockField("전일대비기호", 1)] string ydiffSign,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("등락율", 6.2)] double chgrate,
    [BlockField("건별체결수량", 10)] long trdq,
    [BlockField("누적체결수량", 15)] string totq,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("매도누적체결수량", 15)] string mdvolume,
    [BlockField("매수누적체결수량", 15)] string msvolume,
    [BlockField("장마감일", 8)] string ovsmkend
    );


/// <summary>
/// 해외선물 호가: OVH
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
[BlockInfo(true, 9)]
public record OVHInBlock(
    [BlockField("종목코드", 8)] string symbol
    );

/// <summary>
/// 해외선물 호가: OVH
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가 1	double	15.9</param>
/// <param name="bidho1">매수호가 1	double	15.9</param>
/// <param name="offerrem1">매도호가 잔량 1	long	10</param>
/// <param name="bidrem1">매수호가 잔량 1	long	10</param>
/// <param name="offerno1">매도호가 건수 1	long	10</param>
/// <param name="bidno1">매수호가 건수 1	long	10</param>
/// <param name="offerho2">매도호가 2	double	15.9</param>
/// <param name="bidho2">매수호가 2	double	15.9</param>
/// <param name="offerrem2">매도호가 잔량 2	long	10</param>
/// <param name="bidrem2">매수호가 잔량 2	long	10</param>
/// <param name="offerno2">매도호가 건수 2	long	10</param>
/// <param name="bidno2">매수호가 건수 2	long	10</param>
/// <param name="offerho3">매도호가 3	double	15.9</param>
/// <param name="bidho3">매수호가 3	double	15.9</param>
/// <param name="offerrem3">매도호가 잔량 3	long	10</param>
/// <param name="bidrem3">매수호가 잔량 3	long	10</param>
/// <param name="offerno3">매도호가 건수 3	long	10</param>
/// <param name="bidno3">매수호가 건수 3	long	10</param>
/// <param name="offerho4">매도호가 4	double	15.9</param>
/// <param name="bidho4">매수호가 4	double	15.9</param>
/// <param name="offerrem4">매도호가 잔량 4	long	10</param>
/// <param name="bidrem4">매수호가 잔량 4	long	10</param>
/// <param name="offerno4">매도호가 건수 4	long	10</param>
/// <param name="bidno4">매수호가 건수 4	long	10</param>
/// <param name="offerho5">매도호가 5	double	15.9</param>
/// <param name="bidho5">매수호가 5	double	15.9</param>
/// <param name="offerrem5">매도호가 잔량 5	long	10</param>
/// <param name="bidrem5">매수호가 잔량 5	long	10</param>
/// <param name="offerno5">매도호가 건수 5	long	10</param>
/// <param name="bidno5">매수호가 건수 5	long	10</param>
/// <param name="totoffercnt">매도호가총건수	long	10</param>
/// <param name="totbidcnt">매수호가총건수	long	10</param>
/// <param name="totofferrem">매도호가총수량	long	10</param>
/// <param name="totbidrem">매수호가총수량	long	10</param>
[BlockInfo(true, 440)]
public record OVHOutBlock(
    [BlockField("종목코드", 8)] string symbol,
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가 1", 15.9)] double offerho1,
    [BlockField("매수호가 1", 15.9)] double bidho1,
    [BlockField("매도호가 잔량 1", 10)] long offerrem1,
    [BlockField("매수호가 잔량 1", 10)] long bidrem1,
    [BlockField("매도호가 건수 1", 10)] long offerno1,
    [BlockField("매수호가 건수 1", 10)] long bidno1,
    [BlockField("매도호가 2", 15.9)] double offerho2,
    [BlockField("매수호가 2", 15.9)] double bidho2,
    [BlockField("매도호가 잔량 2", 10)] long offerrem2,
    [BlockField("매수호가 잔량 2", 10)] long bidrem2,
    [BlockField("매도호가 건수 2", 10)] long offerno2,
    [BlockField("매수호가 건수 2", 10)] long bidno2,
    [BlockField("매도호가 3", 15.9)] double offerho3,
    [BlockField("매수호가 3", 15.9)] double bidho3,
    [BlockField("매도호가 잔량 3", 10)] long offerrem3,
    [BlockField("매수호가 잔량 3", 10)] long bidrem3,
    [BlockField("매도호가 건수 3", 10)] long offerno3,
    [BlockField("매수호가 건수 3", 10)] long bidno3,
    [BlockField("매도호가 4", 15.9)] double offerho4,
    [BlockField("매수호가 4", 15.9)] double bidho4,
    [BlockField("매도호가 잔량 4", 10)] long offerrem4,
    [BlockField("매수호가 잔량 4", 10)] long bidrem4,
    [BlockField("매도호가 건수 4", 10)] long offerno4,
    [BlockField("매수호가 건수 4", 10)] long bidno4,
    [BlockField("매도호가 5", 15.9)] double offerho5,
    [BlockField("매수호가 5", 15.9)] double bidho5,
    [BlockField("매도호가 잔량 5", 10)] long offerrem5,
    [BlockField("매수호가 잔량 5", 10)] long bidrem5,
    [BlockField("매도호가 건수 5", 10)] long offerno5,
    [BlockField("매수호가 건수 5", 10)] long bidno5,
    [BlockField("매도호가총건수", 10)] long totoffercnt,
    [BlockField("매수호가총건수", 10)] long totbidcnt,
    [BlockField("매도호가총수량", 10)] long totofferrem,
    [BlockField("매수호가총수량", 10)] long totbidrem
    );


/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record OX0InBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	double	6.2</param>
/// <param name="dnlmtprice">적용 하한가	double	6.2</param>
/// <param name="opttcode">단축코드	string	8</param>
[BlockInfo(true, 29)]
public record OX0OutBlock(
    [BlockField("적용 상한단계", 2)] string upstep,
    [BlockField("적용 하한단계", 2)] string dnstep,
    [BlockField("적용 상한가", 6.2)] double uplmtprice,
    [BlockField("적용 하한가", 6.2)] double dnlmtprice,
    [BlockField("단축코드", 8)] string opttcode
    );


/// <summary>
/// KOSPI프로그램매매종목별: PH_
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
[BlockInfo(true, 7)]
public record PH_InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// KOSPI프로그램매매종목별: PH_
/// </summary>
/// <param name="time">수신시간	string	6</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	int	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="cdhrem">차익매도호가 잔량	long	12</param>
/// <param name="cshrem">차익매수호가 잔량	long	12</param>
/// <param name="bdhrem">비차익매도호가 잔량	long	12</param>
/// <param name="bshrem">비차익매수호가 잔량	long	12</param>
/// <param name="cdhvolume">차익매도호가 수량	long	12</param>
/// <param name="cshvolume">차익매수호가 수량	long	12</param>
/// <param name="bdhvolume">비차익매도호가 수량	long	12</param>
/// <param name="bshvolume">비차익매수호가 수량	long	12</param>
/// <param name="dwcvolume">전체매도위탁체결수량	long	12</param>
/// <param name="swcvolume">전체매수위탁체결수량	long	12</param>
/// <param name="djcvolume">전체매도자기체결수량	long	12</param>
/// <param name="sjcvolume">전체매수자기체결수량	long	12</param>
/// <param name="tdvolume">전체매도체결수량	long	12</param>
/// <param name="tsvolume">전체매수체결수량	long	12</param>
/// <param name="tvol">전체순매수 수량	long	12</param>
/// <param name="dwcvalue">전체매도위탁체결금액	long	15</param>
/// <param name="swcvalue">전체매수위탁체결금액	long	15</param>
/// <param name="djcvalue">전체매도자기체결금액	long	15</param>
/// <param name="sjcvalue">전체매수자기체결금액	long	15</param>
/// <param name="tdvalue">전체매도체결금액	long	15</param>
/// <param name="tsvalue">전체매수체결금액	long	15</param>
/// <param name="tval">전체순매수 금액	long	15</param>
/// <param name="pdgvolume">매도 사전공시수량	long	12</param>
/// <param name="psgvolume">매수 사전공시수량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
[BlockInfo(true, 385)]
public record PH_OutBlock(
    [BlockField("수신시간", 6)] string time,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] int sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("차익매도호가 잔량", 12)] long cdhrem,
    [BlockField("차익매수호가 잔량", 12)] long cshrem,
    [BlockField("비차익매도호가 잔량", 12)] long bdhrem,
    [BlockField("비차익매수호가 잔량", 12)] long bshrem,
    [BlockField("차익매도호가 수량", 12)] long cdhvolume,
    [BlockField("차익매수호가 수량", 12)] long cshvolume,
    [BlockField("비차익매도호가 수량", 12)] long bdhvolume,
    [BlockField("비차익매수호가 수량", 12)] long bshvolume,
    [BlockField("전체매도위탁체결수량", 12)] long dwcvolume,
    [BlockField("전체매수위탁체결수량", 12)] long swcvolume,
    [BlockField("전체매도자기체결수량", 12)] long djcvolume,
    [BlockField("전체매수자기체결수량", 12)] long sjcvolume,
    [BlockField("전체매도체결수량", 12)] long tdvolume,
    [BlockField("전체매수체결수량", 12)] long tsvolume,
    [BlockField("전체순매수 수량", 12)] long tvol,
    [BlockField("전체매도위탁체결금액", 15)] long dwcvalue,
    [BlockField("전체매수위탁체결금액", 15)] long swcvalue,
    [BlockField("전체매도자기체결금액", 15)] long djcvalue,
    [BlockField("전체매수자기체결금액", 15)] long sjcvalue,
    [BlockField("전체매도체결금액", 15)] long tdvalue,
    [BlockField("전체매수체결금액", 15)] long tsvalue,
    [BlockField("전체순매수 금액", 15)] long tval,
    [BlockField("매도 사전공시수량", 12)] long pdgvolume,
    [BlockField("매수 사전공시수량", 12)] long psgvolume,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// KOSPI프로그램매매전체집계: PM_
/// </summary>
/// <param name="gubun">구분값	string	1</param>
[BlockInfo(true, 2)]
public record PM_InBlock(
    [BlockField("구분값", 1)] string gubun
    );

/// <summary>
/// KOSPI프로그램매매전체집계: PM_
/// </summary>
/// <param name="time">수신시간	string	6</param>
/// <param name="cdhrem">차익매도호가 잔량	int	6</param>
/// <param name="cshrem">차익매수호가 잔량	int	6</param>
/// <param name="bdhrem">비차익매도호가 잔량	int	6</param>
/// <param name="bshrem">비차익매수호가 잔량	int	6</param>
/// <param name="cdhvolume">차익매도호가 수량	int	6</param>
/// <param name="cshvolume">차익매수호가 수량	int	6</param>
/// <param name="bdhvolume">비차익매도호가 수량	int	6</param>
/// <param name="bshvolume">비차익매수호가 수량	int	6</param>
/// <param name="cdwvolume">차익매도위탁체결수량	int	6</param>
/// <param name="cdjvolume">차익매도자기체결수량	int	6</param>
/// <param name="cswvolume">차익매수위탁체결수량	int	6</param>
/// <param name="csjvolume">차익매수자기체결수량	int	6</param>
/// <param name="cwvol">차익위탁순매수 수량	int	6</param>
/// <param name="cjvol">차익자기순매수 수량	int	6</param>
/// <param name="bdwvolume">비차익매도위탁체결수량	int	6</param>
/// <param name="bdjvolume">비차익매도자기체결수량	int	6</param>
/// <param name="bswvolume">비차익매수위탁체결수량	int	6</param>
/// <param name="bsjvolume">비차익매수자기체결수량	int	6</param>
/// <param name="bwvol">비차익위탁순매수 수량	int	6</param>
/// <param name="bjvol">비차익자기순매수 수량	int	6</param>
/// <param name="dwvolume">전체매도위탁체결수량	int	6</param>
/// <param name="swvolume">전체매수위탁체결수량	int	6</param>
/// <param name="wvol">전체위탁순매수 수량	int	6</param>
/// <param name="djvolume">전체매도자기체결수량	int	6</param>
/// <param name="sjvolume">전체매수자기체결수량	int	6</param>
/// <param name="jvol">전체자기순매수 수량	int	6</param>
/// <param name="cdwvalue">차익매도위탁체결금액	int	8</param>
/// <param name="cdjvalue">차익매도자기체결금액	int	8</param>
/// <param name="cswvalue">차익매수위탁체결금액	int	8</param>
/// <param name="csjvalue">차익매수자기체결금액	int	8</param>
/// <param name="cwval">차익위탁순매수 금액	int	8</param>
/// <param name="cjval">차익자기순매수 금액	int	8</param>
/// <param name="bdwvalue">비차익매도위탁체결금액	int	8</param>
/// <param name="bdjvalue">비차익매도자기체결금액	int	8</param>
/// <param name="bswvalue">비차익매수위탁체결금액	int	8</param>
/// <param name="bsjvalue">비차익매수자기체결금액	int	8</param>
/// <param name="bwval">비차익위탁순매수 금액	int	8</param>
/// <param name="bjval">비차익자기순매수 금액	int	8</param>
/// <param name="dwvalue">전체매도위탁체결금액	int	8</param>
/// <param name="swvalue">전체매수위탁체결금액	int	8</param>
/// <param name="wval">전체위탁순매수 금액	int	8</param>
/// <param name="djvalue">전체매도자기체결금액	int	8</param>
/// <param name="sjvalue">전체매수자기체결금액	int	8</param>
/// <param name="jval">전체자기순매수 금액	int	8</param>
/// <param name="k200jisu">KOSPI200 지수	double	6.2</param>
/// <param name="k200sign">KOSPI200 전일대비구분	string	1</param>
/// <param name="change">KOSPI200 전일대비	double	6.2</param>
/// <param name="k200basis">KOSPI200 베이시스	double	4.2</param>
/// <param name="cdvolume">차익매도체결수량합계	int	6</param>
/// <param name="csvolume">차익매수체결수량합계	int	6</param>
/// <param name="cvol">차익순매수 수량합계	int	6</param>
/// <param name="bdvolume">비차익매도체결수량합계	int	6</param>
/// <param name="bsvolume">비차익매수체결수량합계	int	6</param>
/// <param name="bvol">비차익순매수 수량합계	int	6</param>
/// <param name="tdvolume">전체매도체결수량합계	int	6</param>
/// <param name="tsvolume">전체매수체결수량합계	int	6</param>
/// <param name="tvol">전체순매수 수량합계	int	6</param>
/// <param name="cdvalue">차익매도체결금액합계	int	8</param>
/// <param name="csvalue">차익매수체결금액합계	int	8</param>
/// <param name="cval">차익순매수 금액합계	int	8</param>
/// <param name="bdvalue">비차익매도체결금액합계	int	8</param>
/// <param name="bsvalue">비차익매수체결금액합계	int	8</param>
/// <param name="bval">비차익순매수 금액합계	int	8</param>
/// <param name="tdvalue">전체매도체결금액합계	int	8</param>
/// <param name="tsvalue">전체매수체결금액합계	int	8</param>
/// <param name="tval">전체순매수 금액합계	int	8</param>
/// <param name="p_cdvolcha">차익매도체결수량직전대비	int	6</param>
/// <param name="p_csvolcha">차익매수체결수량직전대비	int	6</param>
/// <param name="p_cvolcha">차익순매수 수량직전대비	int	6</param>
/// <param name="p_bdvolcha">비차익매도체결수량직전대비	int	6</param>
/// <param name="p_bsvolcha">비차익매수체결수량직전대비	int	6</param>
/// <param name="p_bvolcha">비차익순매수 수량직전대비	int	6</param>
/// <param name="p_tdvolcha">전체매도체결수량직전대비	int	6</param>
/// <param name="p_tsvolcha">전체매수체결수량직전대비	int	6</param>
/// <param name="p_tvolcha">전체순매수 수량직전대비	int	6</param>
/// <param name="p_cdvalcha">차익매도체결금액직전대비	int	8</param>
/// <param name="p_csvalcha">차익매수체결금액직전대비	int	8</param>
/// <param name="p_cvalcha">차익순매수 금액직전대비	int	8</param>
/// <param name="p_bdvalcha">비차익매도체결금액직전대비	int	8</param>
/// <param name="p_bsvalcha">비차익매수체결금액직전대비	int	8</param>
/// <param name="p_bvalcha">비차익순매수 금액직전대비	int	8</param>
/// <param name="p_tdvalcha">전체매도체결금액직전대비	int	8</param>
/// <param name="p_tsvalcha">전체매수체결금액직전대비	int	8</param>
/// <param name="p_tvalcha">전체순매수 금액직전대비	int	8</param>
/// <param name="gubun">구분값	string	1</param>
[BlockInfo(true, 662)]
public record PM_OutBlock(
    [BlockField("수신시간", 6)] string time,
    [BlockField("차익매도호가 잔량", 6)] int cdhrem,
    [BlockField("차익매수호가 잔량", 6)] int cshrem,
    [BlockField("비차익매도호가 잔량", 6)] int bdhrem,
    [BlockField("비차익매수호가 잔량", 6)] int bshrem,
    [BlockField("차익매도호가 수량", 6)] int cdhvolume,
    [BlockField("차익매수호가 수량", 6)] int cshvolume,
    [BlockField("비차익매도호가 수량", 6)] int bdhvolume,
    [BlockField("비차익매수호가 수량", 6)] int bshvolume,
    [BlockField("차익매도위탁체결수량", 6)] int cdwvolume,
    [BlockField("차익매도자기체결수량", 6)] int cdjvolume,
    [BlockField("차익매수위탁체결수량", 6)] int cswvolume,
    [BlockField("차익매수자기체결수량", 6)] int csjvolume,
    [BlockField("차익위탁순매수 수량", 6)] int cwvol,
    [BlockField("차익자기순매수 수량", 6)] int cjvol,
    [BlockField("비차익매도위탁체결수량", 6)] int bdwvolume,
    [BlockField("비차익매도자기체결수량", 6)] int bdjvolume,
    [BlockField("비차익매수위탁체결수량", 6)] int bswvolume,
    [BlockField("비차익매수자기체결수량", 6)] int bsjvolume,
    [BlockField("비차익위탁순매수 수량", 6)] int bwvol,
    [BlockField("비차익자기순매수 수량", 6)] int bjvol,
    [BlockField("전체매도위탁체결수량", 6)] int dwvolume,
    [BlockField("전체매수위탁체결수량", 6)] int swvolume,
    [BlockField("전체위탁순매수 수량", 6)] int wvol,
    [BlockField("전체매도자기체결수량", 6)] int djvolume,
    [BlockField("전체매수자기체결수량", 6)] int sjvolume,
    [BlockField("전체자기순매수 수량", 6)] int jvol,
    [BlockField("차익매도위탁체결금액", 8)] int cdwvalue,
    [BlockField("차익매도자기체결금액", 8)] int cdjvalue,
    [BlockField("차익매수위탁체결금액", 8)] int cswvalue,
    [BlockField("차익매수자기체결금액", 8)] int csjvalue,
    [BlockField("차익위탁순매수 금액", 8)] int cwval,
    [BlockField("차익자기순매수 금액", 8)] int cjval,
    [BlockField("비차익매도위탁체결금액", 8)] int bdwvalue,
    [BlockField("비차익매도자기체결금액", 8)] int bdjvalue,
    [BlockField("비차익매수위탁체결금액", 8)] int bswvalue,
    [BlockField("비차익매수자기체결금액", 8)] int bsjvalue,
    [BlockField("비차익위탁순매수 금액", 8)] int bwval,
    [BlockField("비차익자기순매수 금액", 8)] int bjval,
    [BlockField("전체매도위탁체결금액", 8)] int dwvalue,
    [BlockField("전체매수위탁체결금액", 8)] int swvalue,
    [BlockField("전체위탁순매수 금액", 8)] int wval,
    [BlockField("전체매도자기체결금액", 8)] int djvalue,
    [BlockField("전체매수자기체결금액", 8)] int sjvalue,
    [BlockField("전체자기순매수 금액", 8)] int jval,
    [BlockField("KOSPI200 지수", 6.2)] double k200jisu,
    [BlockField("KOSPI200 전일대비구분", 1)] string k200sign,
    [BlockField("KOSPI200 전일대비", 6.2)] double change,
    [BlockField("KOSPI200 베이시스", 4.2)] double k200basis,
    [BlockField("차익매도체결수량합계", 6)] int cdvolume,
    [BlockField("차익매수체결수량합계", 6)] int csvolume,
    [BlockField("차익순매수 수량합계", 6)] int cvol,
    [BlockField("비차익매도체결수량합계", 6)] int bdvolume,
    [BlockField("비차익매수체결수량합계", 6)] int bsvolume,
    [BlockField("비차익순매수 수량합계", 6)] int bvol,
    [BlockField("전체매도체결수량합계", 6)] int tdvolume,
    [BlockField("전체매수체결수량합계", 6)] int tsvolume,
    [BlockField("전체순매수 수량합계", 6)] int tvol,
    [BlockField("차익매도체결금액합계", 8)] int cdvalue,
    [BlockField("차익매수체결금액합계", 8)] int csvalue,
    [BlockField("차익순매수 금액합계", 8)] int cval,
    [BlockField("비차익매도체결금액합계", 8)] int bdvalue,
    [BlockField("비차익매수체결금액합계", 8)] int bsvalue,
    [BlockField("비차익순매수 금액합계", 8)] int bval,
    [BlockField("전체매도체결금액합계", 8)] int tdvalue,
    [BlockField("전체매수체결금액합계", 8)] int tsvalue,
    [BlockField("전체순매수 금액합계", 8)] int tval,
    [BlockField("차익매도체결수량직전대비", 6)] int p_cdvolcha,
    [BlockField("차익매수체결수량직전대비", 6)] int p_csvolcha,
    [BlockField("차익순매수 수량직전대비", 6)] int p_cvolcha,
    [BlockField("비차익매도체결수량직전대비", 6)] int p_bdvolcha,
    [BlockField("비차익매수체결수량직전대비", 6)] int p_bsvolcha,
    [BlockField("비차익순매수 수량직전대비", 6)] int p_bvolcha,
    [BlockField("전체매도체결수량직전대비", 6)] int p_tdvolcha,
    [BlockField("전체매수체결수량직전대비", 6)] int p_tsvolcha,
    [BlockField("전체순매수 수량직전대비", 6)] int p_tvolcha,
    [BlockField("차익매도체결금액직전대비", 8)] int p_cdvalcha,
    [BlockField("차익매수체결금액직전대비", 8)] int p_csvalcha,
    [BlockField("차익순매수 금액직전대비", 8)] int p_cvalcha,
    [BlockField("비차익매도체결금액직전대비", 8)] int p_bdvalcha,
    [BlockField("비차익매수체결금액직전대비", 8)] int p_bsvalcha,
    [BlockField("비차익순매수 금액직전대비", 8)] int p_bvalcha,
    [BlockField("전체매도체결금액직전대비", 8)] int p_tdvalcha,
    [BlockField("전체매수체결금액직전대비", 8)] int p_tsvalcha,
    [BlockField("전체순매수 금액직전대비", 8)] int p_tvalcha,
    [BlockField("구분값", 1)] string gubun
    );


/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record S2_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 25)]
public record S2_OutBlock(
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW우선호가: s2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record s2_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW우선호가: s2_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 25)]
public record s2_OutBlock(
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// KOSPI체결: S3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record S3_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI체결: S3_
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	8</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="w_avrg">가중평균가	int	8</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="status">장정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 223)]
public record S3_OutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 8)] int price,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("시가", 8)] int open,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("고가", 8)] int high,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("저가", 8)] int low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 8)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("가중평균가", 8)] int w_avrg,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("장정보", 2)] string status,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW체결: s3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record s3_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW체결: s3_
/// </summary>
/// <param name="chetime">체결시간	string	6</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="cvolume">체결량	int	8</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="mdvolume">매도누적체결량	long	12</param>
/// <param name="mdchecnt">매도누적체결건수	int	8</param>
/// <param name="msvolume">매수누적체결량	long	12</param>
/// <param name="mschecnt">매수누적체결건수	int	8</param>
/// <param name="cpower">체결강도	double	9.2</param>
/// <param name="w_avrg">가중평균가	int	8</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="status">장정보	string	2</param>
/// <param name="jnilvolume">전일동시간대거래량	long	12</param>
/// <param name="premium">프리미엄	double	8.2</param>
/// <param name="moneyness">ATM구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="lpvolume">LP보유수량	long	15</param>
[BlockInfo(true, 250)]
public record s3_OutBlock(
    [BlockField("체결시간", 6)] string chetime,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 8)] int price,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("시가", 8)] int open,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("고가", 8)] int high,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("저가", 8)] int low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("체결량", 8)] int cvolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("매도누적체결량", 12)] long mdvolume,
    [BlockField("매도누적체결건수", 8)] int mdchecnt,
    [BlockField("매수누적체결량", 12)] long msvolume,
    [BlockField("매수누적체결건수", 8)] int mschecnt,
    [BlockField("체결강도", 9.2)] double cpower,
    [BlockField("가중평균가", 8)] int w_avrg,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("장정보", 2)] string status,
    [BlockField("전일동시간대거래량", 12)] long jnilvolume,
    [BlockField("프리미엄", 8.2)] double premium,
    [BlockField("ATM구분", 1)] string moneyness,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("LP보유수량", 15)] long lpvolume
    );


/// <summary>
/// KOSPI기세: S4_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record S4_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI기세: S4_
/// </summary>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 82)]
public record S4_OutBlock(
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 8)] int price,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("시가", 8)] int open,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("고가", 8)] int high,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("저가", 8)] int low,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW기세: s4_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record s4_InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW기세: s4_
/// </summary>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 82)]
public record s4_OutBlock(
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("현재가", 8)] int price,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("시가", 8)] int open,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("고가", 8)] int high,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("저가", 8)] int low,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 주식주문접수: SC0
/// </summary>
[BlockInfo(false, 0)]
public record SC0InBlock(
    );

/// <summary>
/// 주식주문접수: SC0
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="ordchegb">주문체결구분	string	2</param>
/// <param name="marketgb">시장구분	string	2</param>
/// <param name="ordgb">주문구분	string	2</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="accno1">계좌번호	string	11</param>
/// <param name="accno2">계좌번호	string	9</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="shtcode">단축종목번호	string	9</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="ordprice">주문가격	long	13</param>
/// <param name="hogagb">주문조건	string	1</param>
/// <param name="etfhogagb">호가유형코드	string	2</param>
/// <param name="pgmtype">프로그램호가구분	int	2</param>
/// <param name="gmhogagb">공매도호가구분	int	1</param>
/// <param name="gmhogayn">공매도가능여부	int	1</param>
/// <param name="singb">신용구분	string	3</param>
/// <param name="loandt">대출일	string	8</param>
/// <param name="cvrgordtp">반대매매주문구분	string	1</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="groupid">그룹ID	string	20</param>
/// <param name="ordseqno">주문회차	long	10</param>
/// <param name="prtno">포트폴리오번호	long	10</param>
/// <param name="basketno">바스켓번호	long	10</param>
/// <param name="trchno">트렌치번호	long	10</param>
/// <param name="itemno">아아템번호	long	10</param>
/// <param name="brwmgmyn">차입구분	int	1</param>
/// <param name="mbrno">회원사번호	int	3</param>
/// <param name="procgb">처리구분	string	1</param>
/// <param name="admbrchno">관리지점번호	string	3</param>
/// <param name="futaccno">선물계좌번호	string	20</param>
/// <param name="futmarketgb">선물상품구분	string	1</param>
/// <param name="tongsingb">통신매체구분	string	2</param>
/// <param name="lpgb">유동성공급자구분	string	1</param>
/// <param name="dummy">DUMMY	string	20</param>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="ordtm">주문시각	string	9</param>
/// <param name="prntordno">모주문번호	long	10</param>
/// <param name="mgempno">관리사원번호	string	9</param>
/// <param name="orgordundrqty">원주문미체결수량	long	16</param>
/// <param name="orgordmdfyqty">원주문정정수량	long	16</param>
/// <param name="ordordcancelqty">원주문취소수량	long	16</param>
/// <param name="nmcpysndno">비회원사송신번호	long	10</param>
/// <param name="ordamt">주문금액	long	16</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="spareordno">예비주문번호	long	10</param>
/// <param name="cvrgseqno">반대매매일련번호	long	10</param>
/// <param name="rsvordno">예약주문번호	long	10</param>
/// <param name="mtordseqno">복수주문일련번호	long	10</param>
/// <param name="spareordqty">예비주문수량	long	16</param>
/// <param name="orduserid">주문사원번호	string	16</param>
/// <param name="spotordqty">실물주문수량	long	16</param>
/// <param name="ordruseqty">재사용주문수량	long	16</param>
/// <param name="mnyordamt">현금주문금액	long	16</param>
/// <param name="ordsubstamt">주문대용금액	long	16</param>
/// <param name="ruseordamt">재사용주문금액	long	16</param>
/// <param name="ordcmsnamt">수수료주문금액	long	16</param>
/// <param name="crdtuseamt">사용신용담보재사용금	long	16</param>
/// <param name="secbalqty">잔고수량	long	16</param>
/// <param name="spotordableqty">실물가능수량	long	16</param>
/// <param name="ordableruseqty">재사용가능수량(매도)	long	16</param>
/// <param name="flctqty">변동수량	long	16</param>
/// <param name="secbalqtyd2">잔고수량(D2)	long	16</param>
/// <param name="sellableqty">매도주문가능수량	long	16</param>
/// <param name="unercsellordqty">미체결매도주문수량	long	16</param>
/// <param name="avrpchsprc">평균매입가	long	13</param>
/// <param name="pchsamt">매입금액	long	16</param>
/// <param name="deposit">예수금	long	16</param>
/// <param name="substamt">대용금	long	16</param>
/// <param name="csgnmnymgn">위탁증거금현금	long	16</param>
/// <param name="csgnsubstmgn">위탁증거금대용	long	16</param>
/// <param name="crdtpldgruseamt">신용담보재사용금	long	16</param>
/// <param name="ordablemny">주문가능현금	long	16</param>
/// <param name="ordablesubstamt">주문가능대용	long	16</param>
/// <param name="ruseableamt">재사용가능금액	long	16</param>
[BlockInfo(false, 1088)]
public record SC0OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("주문체결구분", 2)] string ordchegb,
    [BlockField("시장구분", 2)] string marketgb,
    [BlockField("주문구분", 2)] string ordgb,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("계좌번호", 11)] string accno1,
    [BlockField("계좌번호", 9)] string accno2,
    [BlockField("비밀번호", 8)] string passwd,
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("단축종목번호", 9)] string shtcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("주문가격", 13)] long ordprice,
    [BlockField("주문조건", 1)] string hogagb,
    [BlockField("호가유형코드", 2)] string etfhogagb,
    [BlockField("프로그램호가구분", 2)] int pgmtype,
    [BlockField("공매도호가구분", 1)] int gmhogagb,
    [BlockField("공매도가능여부", 1)] int gmhogayn,
    [BlockField("신용구분", 3)] string singb,
    [BlockField("대출일", 8)] string loandt,
    [BlockField("반대매매주문구분", 1)] string cvrgordtp,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹ID", 20)] string groupid,
    [BlockField("주문회차", 10)] long ordseqno,
    [BlockField("포트폴리오번호", 10)] long prtno,
    [BlockField("바스켓번호", 10)] long basketno,
    [BlockField("트렌치번호", 10)] long trchno,
    [BlockField("아아템번호", 10)] long itemno,
    [BlockField("차입구분", 1)] int brwmgmyn,
    [BlockField("회원사번호", 3)] int mbrno,
    [BlockField("처리구분", 1)] string procgb,
    [BlockField("관리지점번호", 3)] string admbrchno,
    [BlockField("선물계좌번호", 20)] string futaccno,
    [BlockField("선물상품구분", 1)] string futmarketgb,
    [BlockField("통신매체구분", 2)] string tongsingb,
    [BlockField("유동성공급자구분", 1)] string lpgb,
    [BlockField("DUMMY", 20)] string dummy,
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("주문시각", 9)] string ordtm,
    [BlockField("모주문번호", 10)] long prntordno,
    [BlockField("관리사원번호", 9)] string mgempno,
    [BlockField("원주문미체결수량", 16)] long orgordundrqty,
    [BlockField("원주문정정수량", 16)] long orgordmdfyqty,
    [BlockField("원주문취소수량", 16)] long ordordcancelqty,
    [BlockField("비회원사송신번호", 10)] long nmcpysndno,
    [BlockField("주문금액", 16)] long ordamt,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("예비주문번호", 10)] long spareordno,
    [BlockField("반대매매일련번호", 10)] long cvrgseqno,
    [BlockField("예약주문번호", 10)] long rsvordno,
    [BlockField("복수주문일련번호", 10)] long mtordseqno,
    [BlockField("예비주문수량", 16)] long spareordqty,
    [BlockField("주문사원번호", 16)] string orduserid,
    [BlockField("실물주문수량", 16)] long spotordqty,
    [BlockField("재사용주문수량", 16)] long ordruseqty,
    [BlockField("현금주문금액", 16)] long mnyordamt,
    [BlockField("주문대용금액", 16)] long ordsubstamt,
    [BlockField("재사용주문금액", 16)] long ruseordamt,
    [BlockField("수수료주문금액", 16)] long ordcmsnamt,
    [BlockField("사용신용담보재사용금", 16)] long crdtuseamt,
    [BlockField("잔고수량", 16)] long secbalqty,
    [BlockField("실물가능수량", 16)] long spotordableqty,
    [BlockField("재사용가능수량(매도)", 16)] long ordableruseqty,
    [BlockField("변동수량", 16)] long flctqty,
    [BlockField("잔고수량(D2)", 16)] long secbalqtyd2,
    [BlockField("매도주문가능수량", 16)] long sellableqty,
    [BlockField("미체결매도주문수량", 16)] long unercsellordqty,
    [BlockField("평균매입가", 13)] long avrpchsprc,
    [BlockField("매입금액", 16)] long pchsamt,
    [BlockField("예수금", 16)] long deposit,
    [BlockField("대용금", 16)] long substamt,
    [BlockField("위탁증거금현금", 16)] long csgnmnymgn,
    [BlockField("위탁증거금대용", 16)] long csgnsubstmgn,
    [BlockField("신용담보재사용금", 16)] long crdtpldgruseamt,
    [BlockField("주문가능현금", 16)] long ordablemny,
    [BlockField("주문가능대용", 16)] long ordablesubstamt,
    [BlockField("재사용가능금액", 16)] long ruseableamt
    );


/// <summary>
/// 주식주문체결: SC1
/// </summary>
[BlockInfo(false, 0)]
public record SC1InBlock(
    );

/// <summary>
/// 주식주문체결: SC1
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="ordxctptncode">주문체결유형코드	string	2</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordptncode">주문유형코드	string	2</param>
/// <param name="mgmtbrnno">관리지점번호	string	3</param>
/// <param name="accno1">계좌번호	string	11</param>
/// <param name="accno2">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="Isuno">종목번호	string	12</param>
/// <param name="Isunm">종목명	string	40</param>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="execno">체결번호	long	10</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="ordprc">주문가격	long	13</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="execprc">체결가격	long	13</param>
/// <param name="mdfycnfqty">정정확인수량	long	16</param>
/// <param name="mdfycnfprc">정정확인가격	long	16</param>
/// <param name="canccnfqty">취소확인수량	long	16</param>
/// <param name="rjtqty">거부수량	long	16</param>
/// <param name="ordtrxptncode">주문처리유형코드	int	4</param>
/// <param name="mtiordseqno">복수주문일련번호	long	10</param>
/// <param name="ordcndi">주문조건	string	1</param>
/// <param name="ordprcptncode">호가유형코드	string	2</param>
/// <param name="nsavtrdqty">비저축체결수량	long	16</param>
/// <param name="shtnIsuno">단축종목번호	string	9</param>
/// <param name="opdrtnno">운용지시번호	string	12</param>
/// <param name="cvrgordtp">반대매매주문구분	string	1</param>
/// <param name="unercqty">미체결수량(주문)	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmdfyqty">원주문정정수량	long	16</param>
/// <param name="orgordcancqty">원주문취소수량	long	16</param>
/// <param name="ordavrexecprc">주문평균체결가격	long	13</param>
/// <param name="ordamt">주문금액	long	16</param>
/// <param name="stdIsuno">표준종목번호	string	12</param>
/// <param name="bfstdIsuno">전표준종목번호	string	12</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="ordtrdptncode">주문거래유형코드	string	2</param>
/// <param name="mgntrncode">신용거래코드	string	3</param>
/// <param name="adduptp">수수료합산코드	string	2</param>
/// <param name="commdacode">통신매체코드	string	2</param>
/// <param name="Loandt">대출일	string	8</param>
/// <param name="mbrnmbrno">회원/비회원사번호	int	3</param>
/// <param name="ordacntno">주문계좌번호	string	20</param>
/// <param name="agrgbrnno">집계지점번호	string	3</param>
/// <param name="mgempno">관리사원번호	string	9</param>
/// <param name="futsLnkbrnno">선물연계지점번호	string	3</param>
/// <param name="futsLnkacntno">선물연계계좌번호	string	20</param>
/// <param name="futsmkttp">선물시장구분	string	1</param>
/// <param name="regmktcode">등록시장코드	string	2</param>
/// <param name="mnymgnrat">현금증거금률	int	7</param>
/// <param name="substmgnrat">대용증거금률	long	9</param>
/// <param name="mnyexecamt">현금체결금액	long	16</param>
/// <param name="ubstexecamt">대용체결금액	long	16</param>
/// <param name="cmsnamtexecamt">수수료체결금액	long	16</param>
/// <param name="crdtpldgexecamt">신용담보체결금액	long	16</param>
/// <param name="crdtexecamt">신용체결금액	long	16</param>
/// <param name="prdayruseexecval">전일재사용체결금액	long	16</param>
/// <param name="crdayruseexecval">금일재사용체결금액	long	16</param>
/// <param name="spotexecqty">실물체결수량	long	16</param>
/// <param name="stslexecqty">공매도체결수량	long	16</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	long	10</param>
/// <param name="ptflno">포트폴리오번호	long	10</param>
/// <param name="bskno">바스켓번호	long	10</param>
/// <param name="trchno">트렌치번호	long	10</param>
/// <param name="itemno">아이템번호	long	10</param>
/// <param name="orduserId">주문자Id	string	16</param>
/// <param name="brwmgmtYn">차입관리여부	int	1</param>
/// <param name="frgrunqno">외국인고유번호	string	6</param>
/// <param name="trtzxLevytp">거래세징수구분	string	1</param>
/// <param name="lptp">유동성공급자구분	string	1</param>
/// <param name="exectime">체결시각	string	9</param>
/// <param name="rcptexectime">거래소수신체결시각	string	9</param>
/// <param name="rmndLoanamt">잔여대출금액	long	16</param>
/// <param name="secbalqty">잔고수량	long	16</param>
/// <param name="spotordableqty">실물가능수량	long	16</param>
/// <param name="ordableruseqty">재사용가능수량(매도)	long	16</param>
/// <param name="flctqty">변동수량	long	16</param>
/// <param name="secbalqtyd2">잔고수량(d2)	long	16</param>
/// <param name="sellableqty">매도주문가능수량	long	16</param>
/// <param name="unercsellordqty">미체결매도주문수량	long	16</param>
/// <param name="avrpchsprc">평균매입가	long	13</param>
/// <param name="pchsant">매입금액	long	16</param>
/// <param name="deposit">예수금	long	16</param>
/// <param name="substamt">대용금	long	16</param>
/// <param name="csgnmnymgn">위탁증거금현금	long	16</param>
/// <param name="csgnsubstmgn">위탁증거금대용	long	16</param>
/// <param name="crdtpldgruseamt">신용담보재사용금	long	16</param>
/// <param name="ordablemny">주문가능현금	long	16</param>
/// <param name="ordablesubstamt">주문가능대용	long	16</param>
/// <param name="ruseableamt">재사용가능금액	long	16</param>
[BlockInfo(false, 1329)]
public record SC1OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("주문체결유형코드", 2)] string ordxctptncode,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문유형코드", 2)] string ordptncode,
    [BlockField("관리지점번호", 3)] string mgmtbrnno,
    [BlockField("계좌번호", 11)] string accno1,
    [BlockField("계좌번호", 9)] string accno2,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("종목번호", 12)] string Isuno,
    [BlockField("종목명", 40)] string Isunm,
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("체결번호", 10)] long execno,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("주문가격", 13)] long ordprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("체결가격", 13)] long execprc,
    [BlockField("정정확인수량", 16)] long mdfycnfqty,
    [BlockField("정정확인가격", 16)] long mdfycnfprc,
    [BlockField("취소확인수량", 16)] long canccnfqty,
    [BlockField("거부수량", 16)] long rjtqty,
    [BlockField("주문처리유형코드", 4)] int ordtrxptncode,
    [BlockField("복수주문일련번호", 10)] long mtiordseqno,
    [BlockField("주문조건", 1)] string ordcndi,
    [BlockField("호가유형코드", 2)] string ordprcptncode,
    [BlockField("비저축체결수량", 16)] long nsavtrdqty,
    [BlockField("단축종목번호", 9)] string shtnIsuno,
    [BlockField("운용지시번호", 12)] string opdrtnno,
    [BlockField("반대매매주문구분", 1)] string cvrgordtp,
    [BlockField("미체결수량(주문)", 16)] long unercqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정수량", 16)] long orgordmdfyqty,
    [BlockField("원주문취소수량", 16)] long orgordcancqty,
    [BlockField("주문평균체결가격", 13)] long ordavrexecprc,
    [BlockField("주문금액", 16)] long ordamt,
    [BlockField("표준종목번호", 12)] string stdIsuno,
    [BlockField("전표준종목번호", 12)] string bfstdIsuno,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("주문거래유형코드", 2)] string ordtrdptncode,
    [BlockField("신용거래코드", 3)] string mgntrncode,
    [BlockField("수수료합산코드", 2)] string adduptp,
    [BlockField("통신매체코드", 2)] string commdacode,
    [BlockField("대출일", 8)] string Loandt,
    [BlockField("회원/비회원사번호", 3)] int mbrnmbrno,
    [BlockField("주문계좌번호", 20)] string ordacntno,
    [BlockField("집계지점번호", 3)] string agrgbrnno,
    [BlockField("관리사원번호", 9)] string mgempno,
    [BlockField("선물연계지점번호", 3)] string futsLnkbrnno,
    [BlockField("선물연계계좌번호", 20)] string futsLnkacntno,
    [BlockField("선물시장구분", 1)] string futsmkttp,
    [BlockField("등록시장코드", 2)] string regmktcode,
    [BlockField("현금증거금률", 7)] int mnymgnrat,
    [BlockField("대용증거금률", 9)] long substmgnrat,
    [BlockField("현금체결금액", 16)] long mnyexecamt,
    [BlockField("대용체결금액", 16)] long ubstexecamt,
    [BlockField("수수료체결금액", 16)] long cmsnamtexecamt,
    [BlockField("신용담보체결금액", 16)] long crdtpldgexecamt,
    [BlockField("신용체결금액", 16)] long crdtexecamt,
    [BlockField("전일재사용체결금액", 16)] long prdayruseexecval,
    [BlockField("금일재사용체결금액", 16)] long crdayruseexecval,
    [BlockField("실물체결수량", 16)] long spotexecqty,
    [BlockField("공매도체결수량", 16)] long stslexecqty,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] long ordseqno,
    [BlockField("포트폴리오번호", 10)] long ptflno,
    [BlockField("바스켓번호", 10)] long bskno,
    [BlockField("트렌치번호", 10)] long trchno,
    [BlockField("아이템번호", 10)] long itemno,
    [BlockField("주문자Id", 16)] string orduserId,
    [BlockField("차입관리여부", 1)] int brwmgmtYn,
    [BlockField("외국인고유번호", 6)] string frgrunqno,
    [BlockField("거래세징수구분", 1)] string trtzxLevytp,
    [BlockField("유동성공급자구분", 1)] string lptp,
    [BlockField("체결시각", 9)] string exectime,
    [BlockField("거래소수신체결시각", 9)] string rcptexectime,
    [BlockField("잔여대출금액", 16)] long rmndLoanamt,
    [BlockField("잔고수량", 16)] long secbalqty,
    [BlockField("실물가능수량", 16)] long spotordableqty,
    [BlockField("재사용가능수량(매도)", 16)] long ordableruseqty,
    [BlockField("변동수량", 16)] long flctqty,
    [BlockField("잔고수량(d2)", 16)] long secbalqtyd2,
    [BlockField("매도주문가능수량", 16)] long sellableqty,
    [BlockField("미체결매도주문수량", 16)] long unercsellordqty,
    [BlockField("평균매입가", 13)] long avrpchsprc,
    [BlockField("매입금액", 16)] long pchsant,
    [BlockField("예수금", 16)] long deposit,
    [BlockField("대용금", 16)] long substamt,
    [BlockField("위탁증거금현금", 16)] long csgnmnymgn,
    [BlockField("위탁증거금대용", 16)] long csgnsubstmgn,
    [BlockField("신용담보재사용금", 16)] long crdtpldgruseamt,
    [BlockField("주문가능현금", 16)] long ordablemny,
    [BlockField("주문가능대용", 16)] long ordablesubstamt,
    [BlockField("재사용가능금액", 16)] long ruseableamt
    );


/// <summary>
/// 주식주문정정: SC2
/// </summary>
[BlockInfo(false, 0)]
public record SC2InBlock(
    );

/// <summary>
/// 주식주문정정: SC2
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="ordxctptncode">주문체결유형코드	string	2</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordptncode">주문유형코드	string	2</param>
/// <param name="mgmtbrnno">관리지점번호	string	3</param>
/// <param name="accno1">계좌번호	string	11</param>
/// <param name="accno2">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="Isuno">종목번호	string	12</param>
/// <param name="Isunm">종목명	string	40</param>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="execno">체결번호	long	10</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="ordprc">주문가격	long	13</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="execprc">체결가격	long	13</param>
/// <param name="mdfycnfqty">정정확인수량	long	16</param>
/// <param name="mdfycnfprc">정정확인가격	long	16</param>
/// <param name="canccnfqty">취소확인수량	long	16</param>
/// <param name="rjtqty">거부수량	long	16</param>
/// <param name="ordtrxptncode">주문처리유형코드	int	4</param>
/// <param name="mtiordseqno">복수주문일련번호	long	10</param>
/// <param name="ordcndi">주문조건	string	1</param>
/// <param name="ordprcptncode">호가유형코드	string	2</param>
/// <param name="nsavtrdqty">비저축체결수량	long	16</param>
/// <param name="shtnIsuno">단축종목번호	string	9</param>
/// <param name="opdrtnno">운용지시번호	string	12</param>
/// <param name="cvrgordtp">반대매매주문구분	string	1</param>
/// <param name="unercqty">미체결수량(주문)	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmdfyqty">원주문정정수량	long	16</param>
/// <param name="orgordcancqty">원주문취소수량	long	16</param>
/// <param name="ordavrexecprc">주문평균체결가격	long	13</param>
/// <param name="ordamt">주문금액	long	16</param>
/// <param name="stdIsuno">표준종목번호	string	12</param>
/// <param name="bfstdIsuno">전표준종목번호	string	12</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="ordtrdptncode">주문거래유형코드	string	2</param>
/// <param name="mgntrncode">신용거래코드	string	3</param>
/// <param name="adduptp">수수료합산코드	string	2</param>
/// <param name="commdacode">통신매체코드	string	2</param>
/// <param name="Loandt">대출일	string	8</param>
/// <param name="mbrnmbrno">회원/비회원사번호	int	3</param>
/// <param name="ordacntno">주문계좌번호	string	20</param>
/// <param name="agrgbrnno">집계지점번호	string	3</param>
/// <param name="mgempno">관리사원번호	string	9</param>
/// <param name="futsLnkbrnno">선물연계지점번호	string	3</param>
/// <param name="futsLnkacntno">선물연계계좌번호	string	20</param>
/// <param name="futsmkttp">선물시장구분	string	1</param>
/// <param name="regmktcode">등록시장코드	string	2</param>
/// <param name="mnymgnrat">현금증거금률	int	7</param>
/// <param name="substmgnrat">대용증거금률	long	9</param>
/// <param name="mnyexecamt">현금체결금액	long	16</param>
/// <param name="ubstexecamt">대용체결금액	long	16</param>
/// <param name="cmsnamtexecamt">수수료체결금액	long	16</param>
/// <param name="crdtpldgexecamt">신용담보체결금액	long	16</param>
/// <param name="crdtexecamt">신용체결금액	long	16</param>
/// <param name="prdayruseexecval">전일재사용체결금액	long	16</param>
/// <param name="crdayruseexecval">금일재사용체결금액	long	16</param>
/// <param name="spotexecqty">실물체결수량	long	16</param>
/// <param name="stslexecqty">공매도체결수량	long	16</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	long	10</param>
/// <param name="ptflno">포트폴리오번호	long	10</param>
/// <param name="bskno">바스켓번호	long	10</param>
/// <param name="trchno">트렌치번호	long	10</param>
/// <param name="itemno">아이템번호	long	10</param>
/// <param name="orduserId">주문자Id	string	16</param>
/// <param name="brwmgmtYn">차입관리여부	int	1</param>
/// <param name="frgrunqno">외국인고유번호	string	6</param>
/// <param name="trtzxLevytp">거래세징수구분	string	1</param>
/// <param name="lptp">유동성공급자구분	string	1</param>
/// <param name="exectime">체결시각	string	9</param>
/// <param name="rcptexectime">거래소수신체결시각	string	9</param>
/// <param name="rmndLoanamt">잔여대출금액	long	16</param>
/// <param name="secbalqty">잔고수량	long	16</param>
/// <param name="spotordableqty">실물가능수량	long	16</param>
/// <param name="ordableruseqty">재사용가능수량(매도)	long	16</param>
/// <param name="flctqty">변동수량	long	16</param>
/// <param name="secbalqtyd2">잔고수량(d2)	long	16</param>
/// <param name="sellableqty">매도주문가능수량	long	16</param>
/// <param name="unercsellordqty">미체결매도주문수량	long	16</param>
/// <param name="avrpchsprc">평균매입가	long	13</param>
/// <param name="pchsant">매입금액	long	16</param>
/// <param name="deposit">예수금	long	16</param>
/// <param name="substamt">대용금	long	16</param>
/// <param name="csgnmnymgn">위탁증거금현금	long	16</param>
/// <param name="csgnsubstmgn">위탁증거금대용	long	16</param>
/// <param name="crdtpldgruseamt">신용담보재사용금	long	16</param>
/// <param name="ordablemny">주문가능현금	long	16</param>
/// <param name="ordablesubstamt">주문가능대용	long	16</param>
/// <param name="ruseableamt">재사용가능금액	long	16</param>
[BlockInfo(false, 1329)]
public record SC2OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("주문체결유형코드", 2)] string ordxctptncode,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문유형코드", 2)] string ordptncode,
    [BlockField("관리지점번호", 3)] string mgmtbrnno,
    [BlockField("계좌번호", 11)] string accno1,
    [BlockField("계좌번호", 9)] string accno2,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("종목번호", 12)] string Isuno,
    [BlockField("종목명", 40)] string Isunm,
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("체결번호", 10)] long execno,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("주문가격", 13)] long ordprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("체결가격", 13)] long execprc,
    [BlockField("정정확인수량", 16)] long mdfycnfqty,
    [BlockField("정정확인가격", 16)] long mdfycnfprc,
    [BlockField("취소확인수량", 16)] long canccnfqty,
    [BlockField("거부수량", 16)] long rjtqty,
    [BlockField("주문처리유형코드", 4)] int ordtrxptncode,
    [BlockField("복수주문일련번호", 10)] long mtiordseqno,
    [BlockField("주문조건", 1)] string ordcndi,
    [BlockField("호가유형코드", 2)] string ordprcptncode,
    [BlockField("비저축체결수량", 16)] long nsavtrdqty,
    [BlockField("단축종목번호", 9)] string shtnIsuno,
    [BlockField("운용지시번호", 12)] string opdrtnno,
    [BlockField("반대매매주문구분", 1)] string cvrgordtp,
    [BlockField("미체결수량(주문)", 16)] long unercqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정수량", 16)] long orgordmdfyqty,
    [BlockField("원주문취소수량", 16)] long orgordcancqty,
    [BlockField("주문평균체결가격", 13)] long ordavrexecprc,
    [BlockField("주문금액", 16)] long ordamt,
    [BlockField("표준종목번호", 12)] string stdIsuno,
    [BlockField("전표준종목번호", 12)] string bfstdIsuno,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("주문거래유형코드", 2)] string ordtrdptncode,
    [BlockField("신용거래코드", 3)] string mgntrncode,
    [BlockField("수수료합산코드", 2)] string adduptp,
    [BlockField("통신매체코드", 2)] string commdacode,
    [BlockField("대출일", 8)] string Loandt,
    [BlockField("회원/비회원사번호", 3)] int mbrnmbrno,
    [BlockField("주문계좌번호", 20)] string ordacntno,
    [BlockField("집계지점번호", 3)] string agrgbrnno,
    [BlockField("관리사원번호", 9)] string mgempno,
    [BlockField("선물연계지점번호", 3)] string futsLnkbrnno,
    [BlockField("선물연계계좌번호", 20)] string futsLnkacntno,
    [BlockField("선물시장구분", 1)] string futsmkttp,
    [BlockField("등록시장코드", 2)] string regmktcode,
    [BlockField("현금증거금률", 7)] int mnymgnrat,
    [BlockField("대용증거금률", 9)] long substmgnrat,
    [BlockField("현금체결금액", 16)] long mnyexecamt,
    [BlockField("대용체결금액", 16)] long ubstexecamt,
    [BlockField("수수료체결금액", 16)] long cmsnamtexecamt,
    [BlockField("신용담보체결금액", 16)] long crdtpldgexecamt,
    [BlockField("신용체결금액", 16)] long crdtexecamt,
    [BlockField("전일재사용체결금액", 16)] long prdayruseexecval,
    [BlockField("금일재사용체결금액", 16)] long crdayruseexecval,
    [BlockField("실물체결수량", 16)] long spotexecqty,
    [BlockField("공매도체결수량", 16)] long stslexecqty,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] long ordseqno,
    [BlockField("포트폴리오번호", 10)] long ptflno,
    [BlockField("바스켓번호", 10)] long bskno,
    [BlockField("트렌치번호", 10)] long trchno,
    [BlockField("아이템번호", 10)] long itemno,
    [BlockField("주문자Id", 16)] string orduserId,
    [BlockField("차입관리여부", 1)] int brwmgmtYn,
    [BlockField("외국인고유번호", 6)] string frgrunqno,
    [BlockField("거래세징수구분", 1)] string trtzxLevytp,
    [BlockField("유동성공급자구분", 1)] string lptp,
    [BlockField("체결시각", 9)] string exectime,
    [BlockField("거래소수신체결시각", 9)] string rcptexectime,
    [BlockField("잔여대출금액", 16)] long rmndLoanamt,
    [BlockField("잔고수량", 16)] long secbalqty,
    [BlockField("실물가능수량", 16)] long spotordableqty,
    [BlockField("재사용가능수량(매도)", 16)] long ordableruseqty,
    [BlockField("변동수량", 16)] long flctqty,
    [BlockField("잔고수량(d2)", 16)] long secbalqtyd2,
    [BlockField("매도주문가능수량", 16)] long sellableqty,
    [BlockField("미체결매도주문수량", 16)] long unercsellordqty,
    [BlockField("평균매입가", 13)] long avrpchsprc,
    [BlockField("매입금액", 16)] long pchsant,
    [BlockField("예수금", 16)] long deposit,
    [BlockField("대용금", 16)] long substamt,
    [BlockField("위탁증거금현금", 16)] long csgnmnymgn,
    [BlockField("위탁증거금대용", 16)] long csgnsubstmgn,
    [BlockField("신용담보재사용금", 16)] long crdtpldgruseamt,
    [BlockField("주문가능현금", 16)] long ordablemny,
    [BlockField("주문가능대용", 16)] long ordablesubstamt,
    [BlockField("재사용가능금액", 16)] long ruseableamt
    );


/// <summary>
/// 주식주문취소: SC3
/// </summary>
[BlockInfo(false, 0)]
public record SC3InBlock(
    );

/// <summary>
/// 주식주문취소: SC3
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="ordxctptncode">주문체결유형코드	string	2</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordptncode">주문유형코드	string	2</param>
/// <param name="mgmtbrnno">관리지점번호	string	3</param>
/// <param name="accno1">계좌번호	string	11</param>
/// <param name="accno2">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="Isuno">종목번호	string	12</param>
/// <param name="Isunm">종목명	string	40</param>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="execno">체결번호	long	10</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="ordprc">주문가격	long	13</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="execprc">체결가격	long	13</param>
/// <param name="mdfycnfqty">정정확인수량	long	16</param>
/// <param name="mdfycnfprc">정정확인가격	long	16</param>
/// <param name="canccnfqty">취소확인수량	long	16</param>
/// <param name="rjtqty">거부수량	long	16</param>
/// <param name="ordtrxptncode">주문처리유형코드	int	4</param>
/// <param name="mtiordseqno">복수주문일련번호	long	10</param>
/// <param name="ordcndi">주문조건	string	1</param>
/// <param name="ordprcptncode">호가유형코드	string	2</param>
/// <param name="nsavtrdqty">비저축체결수량	long	16</param>
/// <param name="shtnIsuno">단축종목번호	string	9</param>
/// <param name="opdrtnno">운용지시번호	string	12</param>
/// <param name="cvrgordtp">반대매매주문구분	string	1</param>
/// <param name="unercqty">미체결수량(주문)	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmdfyqty">원주문정정수량	long	16</param>
/// <param name="orgordcancqty">원주문취소수량	long	16</param>
/// <param name="ordavrexecprc">주문평균체결가격	long	13</param>
/// <param name="ordamt">주문금액	long	16</param>
/// <param name="stdIsuno">표준종목번호	string	12</param>
/// <param name="bfstdIsuno">전표준종목번호	string	12</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="ordtrdptncode">주문거래유형코드	string	2</param>
/// <param name="mgntrncode">신용거래코드	string	3</param>
/// <param name="adduptp">수수료합산코드	string	2</param>
/// <param name="commdacode">통신매체코드	string	2</param>
/// <param name="Loandt">대출일	string	8</param>
/// <param name="mbrnmbrno">회원/비회원사번호	int	3</param>
/// <param name="ordacntno">주문계좌번호	string	20</param>
/// <param name="agrgbrnno">집계지점번호	string	3</param>
/// <param name="mgempno">관리사원번호	string	9</param>
/// <param name="futsLnkbrnno">선물연계지점번호	string	3</param>
/// <param name="futsLnkacntno">선물연계계좌번호	string	20</param>
/// <param name="futsmkttp">선물시장구분	string	1</param>
/// <param name="regmktcode">등록시장코드	string	2</param>
/// <param name="mnymgnrat">현금증거금률	int	7</param>
/// <param name="substmgnrat">대용증거금률	long	9</param>
/// <param name="mnyexecamt">현금체결금액	long	16</param>
/// <param name="ubstexecamt">대용체결금액	long	16</param>
/// <param name="cmsnamtexecamt">수수료체결금액	long	16</param>
/// <param name="crdtpldgexecamt">신용담보체결금액	long	16</param>
/// <param name="crdtexecamt">신용체결금액	long	16</param>
/// <param name="prdayruseexecval">전일재사용체결금액	long	16</param>
/// <param name="crdayruseexecval">금일재사용체결금액	long	16</param>
/// <param name="spotexecqty">실물체결수량	long	16</param>
/// <param name="stslexecqty">공매도체결수량	long	16</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	long	10</param>
/// <param name="ptflno">포트폴리오번호	long	10</param>
/// <param name="bskno">바스켓번호	long	10</param>
/// <param name="trchno">트렌치번호	long	10</param>
/// <param name="itemno">아이템번호	long	10</param>
/// <param name="orduserId">주문자Id	string	16</param>
/// <param name="brwmgmtYn">차입관리여부	int	1</param>
/// <param name="frgrunqno">외국인고유번호	string	6</param>
/// <param name="trtzxLevytp">거래세징수구분	string	1</param>
/// <param name="lptp">유동성공급자구분	string	1</param>
/// <param name="exectime">체결시각	string	9</param>
/// <param name="rcptexectime">거래소수신체결시각	string	9</param>
/// <param name="rmndLoanamt">잔여대출금액	long	16</param>
/// <param name="secbalqty">잔고수량	long	16</param>
/// <param name="spotordableqty">실물가능수량	long	16</param>
/// <param name="ordableruseqty">재사용가능수량(매도)	long	16</param>
/// <param name="flctqty">변동수량	long	16</param>
/// <param name="secbalqtyd2">잔고수량(d2)	long	16</param>
/// <param name="sellableqty">매도주문가능수량	long	16</param>
/// <param name="unercsellordqty">미체결매도주문수량	long	16</param>
/// <param name="avrpchsprc">평균매입가	long	13</param>
/// <param name="pchsant">매입금액	long	16</param>
/// <param name="deposit">예수금	long	16</param>
/// <param name="substamt">대용금	long	16</param>
/// <param name="csgnmnymgn">위탁증거금현금	long	16</param>
/// <param name="csgnsubstmgn">위탁증거금대용	long	16</param>
/// <param name="crdtpldgruseamt">신용담보재사용금	long	16</param>
/// <param name="ordablemny">주문가능현금	long	16</param>
/// <param name="ordablesubstamt">주문가능대용	long	16</param>
/// <param name="ruseableamt">재사용가능금액	long	16</param>
[BlockInfo(false, 1329)]
public record SC3OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("주문체결유형코드", 2)] string ordxctptncode,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문유형코드", 2)] string ordptncode,
    [BlockField("관리지점번호", 3)] string mgmtbrnno,
    [BlockField("계좌번호", 11)] string accno1,
    [BlockField("계좌번호", 9)] string accno2,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("종목번호", 12)] string Isuno,
    [BlockField("종목명", 40)] string Isunm,
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("체결번호", 10)] long execno,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("주문가격", 13)] long ordprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("체결가격", 13)] long execprc,
    [BlockField("정정확인수량", 16)] long mdfycnfqty,
    [BlockField("정정확인가격", 16)] long mdfycnfprc,
    [BlockField("취소확인수량", 16)] long canccnfqty,
    [BlockField("거부수량", 16)] long rjtqty,
    [BlockField("주문처리유형코드", 4)] int ordtrxptncode,
    [BlockField("복수주문일련번호", 10)] long mtiordseqno,
    [BlockField("주문조건", 1)] string ordcndi,
    [BlockField("호가유형코드", 2)] string ordprcptncode,
    [BlockField("비저축체결수량", 16)] long nsavtrdqty,
    [BlockField("단축종목번호", 9)] string shtnIsuno,
    [BlockField("운용지시번호", 12)] string opdrtnno,
    [BlockField("반대매매주문구분", 1)] string cvrgordtp,
    [BlockField("미체결수량(주문)", 16)] long unercqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정수량", 16)] long orgordmdfyqty,
    [BlockField("원주문취소수량", 16)] long orgordcancqty,
    [BlockField("주문평균체결가격", 13)] long ordavrexecprc,
    [BlockField("주문금액", 16)] long ordamt,
    [BlockField("표준종목번호", 12)] string stdIsuno,
    [BlockField("전표준종목번호", 12)] string bfstdIsuno,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("주문거래유형코드", 2)] string ordtrdptncode,
    [BlockField("신용거래코드", 3)] string mgntrncode,
    [BlockField("수수료합산코드", 2)] string adduptp,
    [BlockField("통신매체코드", 2)] string commdacode,
    [BlockField("대출일", 8)] string Loandt,
    [BlockField("회원/비회원사번호", 3)] int mbrnmbrno,
    [BlockField("주문계좌번호", 20)] string ordacntno,
    [BlockField("집계지점번호", 3)] string agrgbrnno,
    [BlockField("관리사원번호", 9)] string mgempno,
    [BlockField("선물연계지점번호", 3)] string futsLnkbrnno,
    [BlockField("선물연계계좌번호", 20)] string futsLnkacntno,
    [BlockField("선물시장구분", 1)] string futsmkttp,
    [BlockField("등록시장코드", 2)] string regmktcode,
    [BlockField("현금증거금률", 7)] int mnymgnrat,
    [BlockField("대용증거금률", 9)] long substmgnrat,
    [BlockField("현금체결금액", 16)] long mnyexecamt,
    [BlockField("대용체결금액", 16)] long ubstexecamt,
    [BlockField("수수료체결금액", 16)] long cmsnamtexecamt,
    [BlockField("신용담보체결금액", 16)] long crdtpldgexecamt,
    [BlockField("신용체결금액", 16)] long crdtexecamt,
    [BlockField("전일재사용체결금액", 16)] long prdayruseexecval,
    [BlockField("금일재사용체결금액", 16)] long crdayruseexecval,
    [BlockField("실물체결수량", 16)] long spotexecqty,
    [BlockField("공매도체결수량", 16)] long stslexecqty,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] long ordseqno,
    [BlockField("포트폴리오번호", 10)] long ptflno,
    [BlockField("바스켓번호", 10)] long bskno,
    [BlockField("트렌치번호", 10)] long trchno,
    [BlockField("아이템번호", 10)] long itemno,
    [BlockField("주문자Id", 16)] string orduserId,
    [BlockField("차입관리여부", 1)] int brwmgmtYn,
    [BlockField("외국인고유번호", 6)] string frgrunqno,
    [BlockField("거래세징수구분", 1)] string trtzxLevytp,
    [BlockField("유동성공급자구분", 1)] string lptp,
    [BlockField("체결시각", 9)] string exectime,
    [BlockField("거래소수신체결시각", 9)] string rcptexectime,
    [BlockField("잔여대출금액", 16)] long rmndLoanamt,
    [BlockField("잔고수량", 16)] long secbalqty,
    [BlockField("실물가능수량", 16)] long spotordableqty,
    [BlockField("재사용가능수량(매도)", 16)] long ordableruseqty,
    [BlockField("변동수량", 16)] long flctqty,
    [BlockField("잔고수량(d2)", 16)] long secbalqtyd2,
    [BlockField("매도주문가능수량", 16)] long sellableqty,
    [BlockField("미체결매도주문수량", 16)] long unercsellordqty,
    [BlockField("평균매입가", 13)] long avrpchsprc,
    [BlockField("매입금액", 16)] long pchsant,
    [BlockField("예수금", 16)] long deposit,
    [BlockField("대용금", 16)] long substamt,
    [BlockField("위탁증거금현금", 16)] long csgnmnymgn,
    [BlockField("위탁증거금대용", 16)] long csgnsubstmgn,
    [BlockField("신용담보재사용금", 16)] long crdtpldgruseamt,
    [BlockField("주문가능현금", 16)] long ordablemny,
    [BlockField("주문가능대용", 16)] long ordablesubstamt,
    [BlockField("재사용가능금액", 16)] long ruseableamt
    );


/// <summary>
/// 주식주문거부: SC4
/// </summary>
[BlockInfo(false, 0)]
public record SC4InBlock(
    );

/// <summary>
/// 주식주문거부: SC4
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="len">헤더길이	int	6</param>
/// <param name="gubun">헤더구분	string	1</param>
/// <param name="compress">압축구분	string	1</param>
/// <param name="encrypt">암호구분	string	1</param>
/// <param name="offset">공통시작지점	int	3</param>
/// <param name="trcode">TRCODE	string	8</param>
/// <param name="comid">이용사번호	string	3</param>
/// <param name="userid">사용자ID	string	16</param>
/// <param name="media">접속매체	string	2</param>
/// <param name="ifid">I/F일련번호	string	3</param>
/// <param name="seq">전문일련번호	string	9</param>
/// <param name="trid">TR추적ID	string	16</param>
/// <param name="pubip">공인IP	string	12</param>
/// <param name="prvip">사설IP	string	12</param>
/// <param name="pcbpno">처리지점번호	string	3</param>
/// <param name="bpno">지점번호	string	3</param>
/// <param name="termno">단말번호	string	8</param>
/// <param name="lang">언어구분	string	1</param>
/// <param name="proctm">AP처리시간	long	9</param>
/// <param name="msgcode">메세지코드	string	4</param>
/// <param name="outgu">메세지출력구분	string	1</param>
/// <param name="compreq">압축요청구분	string	1</param>
/// <param name="funckey">기능키	string	4</param>
/// <param name="reqcnt">요청레코드개수	int	4</param>
/// <param name="filler">예비영역	string	6</param>
/// <param name="cont">연속구분	string	1</param>
/// <param name="contkey">연속키값	string	18</param>
/// <param name="varlen">가변시스템길이	int	2</param>
/// <param name="varhdlen">가변해더길이	int	2</param>
/// <param name="varmsglen">가변메시지길이	int	2</param>
/// <param name="trsrc">조회발원지	string	1</param>
/// <param name="eventid">I/F이벤트ID	string	4</param>
/// <param name="ifinfo">I/F정보	string	4</param>
/// <param name="filler1">예비영역	string	41</param>
/// <param name="ordxctptncode">주문체결유형코드	string	2</param>
/// <param name="ordmktcode">주문시장코드	string	2</param>
/// <param name="ordptncode">주문유형코드	string	2</param>
/// <param name="mgmtbrnno">관리지점번호	string	3</param>
/// <param name="accno1">계좌번호	string	11</param>
/// <param name="accno2">계좌번호	string	9</param>
/// <param name="acntnm">계좌명	string	40</param>
/// <param name="Isuno">종목번호	string	12</param>
/// <param name="Isunm">종목명	string	40</param>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="execno">체결번호	long	10</param>
/// <param name="ordqty">주문수량	long	16</param>
/// <param name="ordprc">주문가격	long	13</param>
/// <param name="execqty">체결수량	long	16</param>
/// <param name="execprc">체결가격	long	13</param>
/// <param name="mdfycnfqty">정정확인수량	long	16</param>
/// <param name="mdfycnfprc">정정확인가격	long	16</param>
/// <param name="canccnfqty">취소확인수량	long	16</param>
/// <param name="rjtqty">거부수량	long	16</param>
/// <param name="ordtrxptncode">주문처리유형코드	int	4</param>
/// <param name="mtiordseqno">복수주문일련번호	long	10</param>
/// <param name="ordcndi">주문조건	string	1</param>
/// <param name="ordprcptncode">호가유형코드	string	2</param>
/// <param name="nsavtrdqty">비저축체결수량	long	16</param>
/// <param name="shtnIsuno">단축종목번호	string	9</param>
/// <param name="opdrtnno">운용지시번호	string	12</param>
/// <param name="cvrgordtp">반대매매주문구분	string	1</param>
/// <param name="unercqty">미체결수량(주문)	long	16</param>
/// <param name="orgordunercqty">원주문미체결수량	long	16</param>
/// <param name="orgordmdfyqty">원주문정정수량	long	16</param>
/// <param name="orgordcancqty">원주문취소수량	long	16</param>
/// <param name="ordavrexecprc">주문평균체결가격	long	13</param>
/// <param name="ordamt">주문금액	long	16</param>
/// <param name="stdIsuno">표준종목번호	string	12</param>
/// <param name="bfstdIsuno">전표준종목번호	string	12</param>
/// <param name="bnstp">매매구분	string	1</param>
/// <param name="ordtrdptncode">주문거래유형코드	string	2</param>
/// <param name="mgntrncode">신용거래코드	string	3</param>
/// <param name="adduptp">수수료합산코드	string	2</param>
/// <param name="commdacode">통신매체코드	string	2</param>
/// <param name="Loandt">대출일	string	8</param>
/// <param name="mbrnmbrno">회원/비회원사번호	int	3</param>
/// <param name="ordacntno">주문계좌번호	string	20</param>
/// <param name="agrgbrnno">집계지점번호	string	3</param>
/// <param name="mgempno">관리사원번호	string	9</param>
/// <param name="futsLnkbrnno">선물연계지점번호	string	3</param>
/// <param name="futsLnkacntno">선물연계계좌번호	string	20</param>
/// <param name="futsmkttp">선물시장구분	string	1</param>
/// <param name="regmktcode">등록시장코드	string	2</param>
/// <param name="mnymgnrat">현금증거금률	int	7</param>
/// <param name="substmgnrat">대용증거금률	long	9</param>
/// <param name="mnyexecamt">현금체결금액	long	16</param>
/// <param name="ubstexecamt">대용체결금액	long	16</param>
/// <param name="cmsnamtexecamt">수수료체결금액	long	16</param>
/// <param name="crdtpldgexecamt">신용담보체결금액	long	16</param>
/// <param name="crdtexecamt">신용체결금액	long	16</param>
/// <param name="prdayruseexecval">전일재사용체결금액	long	16</param>
/// <param name="crdayruseexecval">금일재사용체결금액	long	16</param>
/// <param name="spotexecqty">실물체결수량	long	16</param>
/// <param name="stslexecqty">공매도체결수량	long	16</param>
/// <param name="strtgcode">전략코드	string	6</param>
/// <param name="grpId">그룹Id	string	20</param>
/// <param name="ordseqno">주문회차	long	10</param>
/// <param name="ptflno">포트폴리오번호	long	10</param>
/// <param name="bskno">바스켓번호	long	10</param>
/// <param name="trchno">트렌치번호	long	10</param>
/// <param name="itemno">아이템번호	long	10</param>
/// <param name="orduserId">주문자Id	string	16</param>
/// <param name="brwmgmtYn">차입관리여부	int	1</param>
/// <param name="frgrunqno">외국인고유번호	string	6</param>
/// <param name="trtzxLevytp">거래세징수구분	string	1</param>
/// <param name="lptp">유동성공급자구분	string	1</param>
/// <param name="exectime">체결시각	string	9</param>
/// <param name="rcptexectime">거래소수신체결시각	string	9</param>
/// <param name="rmndLoanamt">잔여대출금액	long	16</param>
/// <param name="secbalqty">잔고수량	long	16</param>
/// <param name="spotordableqty">실물가능수량	long	16</param>
/// <param name="ordableruseqty">재사용가능수량(매도)	long	16</param>
/// <param name="flctqty">변동수량	long	16</param>
/// <param name="secbalqtyd2">잔고수량(d2)	long	16</param>
/// <param name="sellableqty">매도주문가능수량	long	16</param>
/// <param name="unercsellordqty">미체결매도주문수량	long	16</param>
/// <param name="avrpchsprc">평균매입가	long	13</param>
/// <param name="pchsant">매입금액	long	16</param>
/// <param name="deposit">예수금	long	16</param>
/// <param name="substamt">대용금	long	16</param>
/// <param name="csgnmnymgn">위탁증거금현금	long	16</param>
/// <param name="csgnsubstmgn">위탁증거금대용	long	16</param>
/// <param name="crdtpldgruseamt">신용담보재사용금	long	16</param>
/// <param name="ordablemny">주문가능현금	long	16</param>
/// <param name="ordablesubstamt">주문가능대용	long	16</param>
/// <param name="ruseableamt">재사용가능금액	long	16</param>
[BlockInfo(false, 1329)]
public record SC4OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("헤더길이", 6)] int len,
    [BlockField("헤더구분", 1)] string gubun,
    [BlockField("압축구분", 1)] string compress,
    [BlockField("암호구분", 1)] string encrypt,
    [BlockField("공통시작지점", 3)] int offset,
    [BlockField("TRCODE", 8)] string trcode,
    [BlockField("이용사번호", 3)] string comid,
    [BlockField("사용자ID", 16)] string userid,
    [BlockField("접속매체", 2)] string media,
    [BlockField("I/F일련번호", 3)] string ifid,
    [BlockField("전문일련번호", 9)] string seq,
    [BlockField("TR추적ID", 16)] string trid,
    [BlockField("공인IP", 12)] string pubip,
    [BlockField("사설IP", 12)] string prvip,
    [BlockField("처리지점번호", 3)] string pcbpno,
    [BlockField("지점번호", 3)] string bpno,
    [BlockField("단말번호", 8)] string termno,
    [BlockField("언어구분", 1)] string lang,
    [BlockField("AP처리시간", 9)] long proctm,
    [BlockField("메세지코드", 4)] string msgcode,
    [BlockField("메세지출력구분", 1)] string outgu,
    [BlockField("압축요청구분", 1)] string compreq,
    [BlockField("기능키", 4)] string funckey,
    [BlockField("요청레코드개수", 4)] int reqcnt,
    [BlockField("예비영역", 6)] string filler,
    [BlockField("연속구분", 1)] string cont,
    [BlockField("연속키값", 18)] string contkey,
    [BlockField("가변시스템길이", 2)] int varlen,
    [BlockField("가변해더길이", 2)] int varhdlen,
    [BlockField("가변메시지길이", 2)] int varmsglen,
    [BlockField("조회발원지", 1)] string trsrc,
    [BlockField("I/F이벤트ID", 4)] string eventid,
    [BlockField("I/F정보", 4)] string ifinfo,
    [BlockField("예비영역", 41)] string filler1,
    [BlockField("주문체결유형코드", 2)] string ordxctptncode,
    [BlockField("주문시장코드", 2)] string ordmktcode,
    [BlockField("주문유형코드", 2)] string ordptncode,
    [BlockField("관리지점번호", 3)] string mgmtbrnno,
    [BlockField("계좌번호", 11)] string accno1,
    [BlockField("계좌번호", 9)] string accno2,
    [BlockField("계좌명", 40)] string acntnm,
    [BlockField("종목번호", 12)] string Isuno,
    [BlockField("종목명", 40)] string Isunm,
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("체결번호", 10)] long execno,
    [BlockField("주문수량", 16)] long ordqty,
    [BlockField("주문가격", 13)] long ordprc,
    [BlockField("체결수량", 16)] long execqty,
    [BlockField("체결가격", 13)] long execprc,
    [BlockField("정정확인수량", 16)] long mdfycnfqty,
    [BlockField("정정확인가격", 16)] long mdfycnfprc,
    [BlockField("취소확인수량", 16)] long canccnfqty,
    [BlockField("거부수량", 16)] long rjtqty,
    [BlockField("주문처리유형코드", 4)] int ordtrxptncode,
    [BlockField("복수주문일련번호", 10)] long mtiordseqno,
    [BlockField("주문조건", 1)] string ordcndi,
    [BlockField("호가유형코드", 2)] string ordprcptncode,
    [BlockField("비저축체결수량", 16)] long nsavtrdqty,
    [BlockField("단축종목번호", 9)] string shtnIsuno,
    [BlockField("운용지시번호", 12)] string opdrtnno,
    [BlockField("반대매매주문구분", 1)] string cvrgordtp,
    [BlockField("미체결수량(주문)", 16)] long unercqty,
    [BlockField("원주문미체결수량", 16)] long orgordunercqty,
    [BlockField("원주문정정수량", 16)] long orgordmdfyqty,
    [BlockField("원주문취소수량", 16)] long orgordcancqty,
    [BlockField("주문평균체결가격", 13)] long ordavrexecprc,
    [BlockField("주문금액", 16)] long ordamt,
    [BlockField("표준종목번호", 12)] string stdIsuno,
    [BlockField("전표준종목번호", 12)] string bfstdIsuno,
    [BlockField("매매구분", 1)] string bnstp,
    [BlockField("주문거래유형코드", 2)] string ordtrdptncode,
    [BlockField("신용거래코드", 3)] string mgntrncode,
    [BlockField("수수료합산코드", 2)] string adduptp,
    [BlockField("통신매체코드", 2)] string commdacode,
    [BlockField("대출일", 8)] string Loandt,
    [BlockField("회원/비회원사번호", 3)] int mbrnmbrno,
    [BlockField("주문계좌번호", 20)] string ordacntno,
    [BlockField("집계지점번호", 3)] string agrgbrnno,
    [BlockField("관리사원번호", 9)] string mgempno,
    [BlockField("선물연계지점번호", 3)] string futsLnkbrnno,
    [BlockField("선물연계계좌번호", 20)] string futsLnkacntno,
    [BlockField("선물시장구분", 1)] string futsmkttp,
    [BlockField("등록시장코드", 2)] string regmktcode,
    [BlockField("현금증거금률", 7)] int mnymgnrat,
    [BlockField("대용증거금률", 9)] long substmgnrat,
    [BlockField("현금체결금액", 16)] long mnyexecamt,
    [BlockField("대용체결금액", 16)] long ubstexecamt,
    [BlockField("수수료체결금액", 16)] long cmsnamtexecamt,
    [BlockField("신용담보체결금액", 16)] long crdtpldgexecamt,
    [BlockField("신용체결금액", 16)] long crdtexecamt,
    [BlockField("전일재사용체결금액", 16)] long prdayruseexecval,
    [BlockField("금일재사용체결금액", 16)] long crdayruseexecval,
    [BlockField("실물체결수량", 16)] long spotexecqty,
    [BlockField("공매도체결수량", 16)] long stslexecqty,
    [BlockField("전략코드", 6)] string strtgcode,
    [BlockField("그룹Id", 20)] string grpId,
    [BlockField("주문회차", 10)] long ordseqno,
    [BlockField("포트폴리오번호", 10)] long ptflno,
    [BlockField("바스켓번호", 10)] long bskno,
    [BlockField("트렌치번호", 10)] long trchno,
    [BlockField("아이템번호", 10)] long itemno,
    [BlockField("주문자Id", 16)] string orduserId,
    [BlockField("차입관리여부", 1)] int brwmgmtYn,
    [BlockField("외국인고유번호", 6)] string frgrunqno,
    [BlockField("거래세징수구분", 1)] string trtzxLevytp,
    [BlockField("유동성공급자구분", 1)] string lptp,
    [BlockField("체결시각", 9)] string exectime,
    [BlockField("거래소수신체결시각", 9)] string rcptexectime,
    [BlockField("잔여대출금액", 16)] long rmndLoanamt,
    [BlockField("잔고수량", 16)] long secbalqty,
    [BlockField("실물가능수량", 16)] long spotordableqty,
    [BlockField("재사용가능수량(매도)", 16)] long ordableruseqty,
    [BlockField("변동수량", 16)] long flctqty,
    [BlockField("잔고수량(d2)", 16)] long secbalqtyd2,
    [BlockField("매도주문가능수량", 16)] long sellableqty,
    [BlockField("미체결매도주문수량", 16)] long unercsellordqty,
    [BlockField("평균매입가", 13)] long avrpchsprc,
    [BlockField("매입금액", 16)] long pchsant,
    [BlockField("예수금", 16)] long deposit,
    [BlockField("대용금", 16)] long substamt,
    [BlockField("위탁증거금현금", 16)] long csgnmnymgn,
    [BlockField("위탁증거금대용", 16)] long csgnsubstmgn,
    [BlockField("신용담보재사용금", 16)] long crdtpldgruseamt,
    [BlockField("주문가능현금", 16)] long ordablemny,
    [BlockField("주문가능대용", 16)] long ordablesubstamt,
    [BlockField("재사용가능금액", 16)] long ruseableamt
    );


/// <summary>
/// 상/하한가근접진입: SHC
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
[BlockInfo(true, 2)]
public record SHCInBlock(
    [BlockField("상/하한구분", 1)] string updnlmtgubun
    );

/// <summary>
/// 상/하한가근접진입: SHC
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	string	1</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="volincrate">거래증가율	double	12.2</param>
/// <param name="updnlmtprice">상/하한가	int	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	double	6.2</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gwangubun">관리구분	string	1</param>
/// <param name="undergubun">이상급등구분	string	1</param>
/// <param name="tgubun">투자유의구분	string	1</param>
/// <param name="wgubun">우선주구분	string	1</param>
/// <param name="dishonest">불성실구분	string	1</param>
/// <param name="jkrate">증거금률	string	1</param>
/// <param name="updnlmtdaycnt">상한가/하한가연속일수	int	3</param>
[BlockInfo(true, 128)]
public record SHCOutBlock(
    [BlockField("거래소/코스닥구분", 1)] string sijanggubun,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 12.2)] double volincrate,
    [BlockField("상/하한가", 8)] int updnlmtprice,
    [BlockField("상/하한가대비율", 6.2)] double updnlmtdrate,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("관리구분", 1)] string gwangubun,
    [BlockField("이상급등구분", 1)] string undergubun,
    [BlockField("투자유의구분", 1)] string tgubun,
    [BlockField("우선주구분", 1)] string wgubun,
    [BlockField("불성실구분", 1)] string dishonest,
    [BlockField("증거금률", 1)] string jkrate,
    [BlockField("상한가/하한가연속일수", 3)] int updnlmtdaycnt
    );


/// <summary>
/// 상/하한가근접이탈: SHD
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
[BlockInfo(true, 2)]
public record SHDInBlock(
    [BlockField("상/하한구분", 1)] string updnlmtgubun
    );

/// <summary>
/// 상/하한가근접이탈: SHD
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	string	1</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="volincrate">거래증가율	double	12.2</param>
/// <param name="updnlmtprice">상/하한가	int	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	double	6.2</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gwangubun">관리구분	string	1</param>
/// <param name="undergubun">이상급등구분	string	1</param>
/// <param name="tgubun">투자유의구분	string	1</param>
/// <param name="wgubun">우선주구분	string	1</param>
/// <param name="dishonest">불성실구분	string	1</param>
/// <param name="jkrate">증거금률	string	1</param>
[BlockInfo(true, 124)]
public record SHDOutBlock(
    [BlockField("거래소/코스닥구분", 1)] string sijanggubun,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 12.2)] double volincrate,
    [BlockField("상/하한가", 8)] int updnlmtprice,
    [BlockField("상/하한가대비율", 6.2)] double updnlmtdrate,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("관리구분", 1)] string gwangubun,
    [BlockField("이상급등구분", 1)] string undergubun,
    [BlockField("투자유의구분", 1)] string tgubun,
    [BlockField("우선주구분", 1)] string wgubun,
    [BlockField("불성실구분", 1)] string dishonest,
    [BlockField("증거금률", 1)] string jkrate
    );


/// <summary>
/// 상/하한가진입: SHI
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
[BlockInfo(true, 2)]
public record SHIInBlock(
    [BlockField("상/하한구분", 1)] string updnlmtgubun
    );

/// <summary>
/// 상/하한가진입: SHI
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	string	1</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="volincrate">거래증가율	double	12.2</param>
/// <param name="totofferrem">매도호가총수량	long	12</param>
/// <param name="totbidrem">매수호가총수량	long	12</param>
/// <param name="updnlmtstime">상한가/하한가최종진입시간	string	6</param>
/// <param name="updnlmtdaycnt">상한가/하한가연속일수	int	3</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gwangubun">관리구분	string	1</param>
/// <param name="undergubun">이상급등구분	string	1</param>
/// <param name="tgubun">투자유의구분	string	1</param>
/// <param name="wgubun">우선주구분	string	1</param>
/// <param name="dishonest">불성실구분	string	1</param>
/// <param name="jkrate">증거금률	string	1</param>
[BlockInfo(true, 145)]
public record SHIOutBlock(
    [BlockField("거래소/코스닥구분", 1)] string sijanggubun,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 12.2)] double volincrate,
    [BlockField("매도호가총수량", 12)] long totofferrem,
    [BlockField("매수호가총수량", 12)] long totbidrem,
    [BlockField("상한가/하한가최종진입시간", 6)] string updnlmtstime,
    [BlockField("상한가/하한가연속일수", 3)] int updnlmtdaycnt,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("관리구분", 1)] string gwangubun,
    [BlockField("이상급등구분", 1)] string undergubun,
    [BlockField("투자유의구분", 1)] string tgubun,
    [BlockField("우선주구분", 1)] string wgubun,
    [BlockField("불성실구분", 1)] string dishonest,
    [BlockField("증거금률", 1)] string jkrate
    );


/// <summary>
/// 상/하한가이탈: SHO
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
[BlockInfo(true, 2)]
public record SHOInBlock(
    [BlockField("상/하한구분", 1)] string updnlmtgubun
    );

/// <summary>
/// 상/하한가이탈: SHO
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	string	1</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="drate">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="volincrate">거래증가율	double	12.2</param>
/// <param name="updnlmtprice">상/하한가	int	8</param>
/// <param name="updnlmtchange">상/하한가대비	int	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	double	6.2</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gwangubun">관리구분	string	1</param>
/// <param name="undergubun">이상급등구분	string	1</param>
/// <param name="tgubun">투자유의구분	string	1</param>
/// <param name="wgubun">우선주구분	string	1</param>
/// <param name="dishonest">불성실구분	string	1</param>
/// <param name="jkrate">증거금률	string	1</param>
[BlockInfo(true, 133)]
public record SHOOutBlock(
    [BlockField("거래소/코스닥구분", 1)] string sijanggubun,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double drate,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 12.2)] double volincrate,
    [BlockField("상/하한가", 8)] int updnlmtprice,
    [BlockField("상/하한가대비", 8)] int updnlmtchange,
    [BlockField("상/하한가대비율", 6.2)] double updnlmtdrate,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("관리구분", 1)] string gwangubun,
    [BlockField("이상급등구분", 1)] string undergubun,
    [BlockField("투자유의구분", 1)] string tgubun,
    [BlockField("우선주구분", 1)] string wgubun,
    [BlockField("불성실구분", 1)] string dishonest,
    [BlockField("증거금률", 1)] string jkrate
    );


/// <summary>
/// 해외선물주문: TC1
/// </summary>
[BlockInfo(false, 0)]
public record TC1InBlock(
    );

/// <summary>
/// 해외선물주문: TC1
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="key">KEY	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="svc_id">서비스ID	string	4</param>
/// <param name="ordr_dt">주문일자	string	8</param>
/// <param name="brn_cd">지점번호	string	3</param>
/// <param name="ordr_no">주문번호	long	10</param>
/// <param name="orgn_ordr_no">원주문번호	long	10</param>
/// <param name="mthr_ordr_no">모주문번호	long	10</param>
/// <param name="ac_no">계좌번호	string	11</param>
/// <param name="is_cd">종목코드	string	30</param>
/// <param name="s_b_ccd">매도매수유형	string	1</param>
/// <param name="ordr_ccd">정정취소유형	string	1</param>
/// <param name="ordr_typ_cd">주문유형코드	string	1</param>
/// <param name="ordr_typ_prd_ccd">주문기간코드	string	2</param>
/// <param name="ordr_aplc_strt_dt">주문적용시작일자	string	8</param>
/// <param name="ordr_aplc_end_dt">주문적용종료일자	string	8</param>
/// <param name="ordr_prc">주문가격	double	18.11</param>
/// <param name="cndt_ordr_prc">주문조건가격	double	18.11</param>
/// <param name="ordr_q">주문수량	long	12</param>
/// <param name="ordr_tm">주문시간	string	9</param>
/// <param name="userid">사용자ID	string	8</param>
/// <param name="xrc_rsv_tcp_code">만기행사유무	string	1</param>
[BlockInfo(false, 202)]
public record TC1OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("KEY", 11)] string key,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("서비스ID", 4)] string svc_id,
    [BlockField("주문일자", 8)] string ordr_dt,
    [BlockField("지점번호", 3)] string brn_cd,
    [BlockField("주문번호", 10)] long ordr_no,
    [BlockField("원주문번호", 10)] long orgn_ordr_no,
    [BlockField("모주문번호", 10)] long mthr_ordr_no,
    [BlockField("계좌번호", 11)] string ac_no,
    [BlockField("종목코드", 30)] string is_cd,
    [BlockField("매도매수유형", 1)] string s_b_ccd,
    [BlockField("정정취소유형", 1)] string ordr_ccd,
    [BlockField("주문유형코드", 1)] string ordr_typ_cd,
    [BlockField("주문기간코드", 2)] string ordr_typ_prd_ccd,
    [BlockField("주문적용시작일자", 8)] string ordr_aplc_strt_dt,
    [BlockField("주문적용종료일자", 8)] string ordr_aplc_end_dt,
    [BlockField("주문가격", 18.11)] double ordr_prc,
    [BlockField("주문조건가격", 18.11)] double cndt_ordr_prc,
    [BlockField("주문수량", 12)] long ordr_q,
    [BlockField("주문시간", 9)] string ordr_tm,
    [BlockField("사용자ID", 8)] string userid,
    [BlockField("만기행사유무", 1)] string xrc_rsv_tcp_code
    );


/// <summary>
/// 해외선물응답: TC2
/// </summary>
[BlockInfo(false, 0)]
public record TC2InBlock(
    );

/// <summary>
/// 해외선물응답: TC2
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="key">KEY	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="svc_id">서비스ID	string	4</param>
/// <param name="ordr_dt">주문일자	string	8</param>
/// <param name="brn_cd">지점번호	string	3</param>
/// <param name="ordr_no">주문번호	long	10</param>
/// <param name="orgn_ordr_no">원주문번호	long	10</param>
/// <param name="mthr_ordr_no">모주문번호	long	10</param>
/// <param name="ac_no">계좌번호	string	11</param>
/// <param name="is_cd">종목코드	string	30</param>
/// <param name="s_b_ccd">매도매수유형	string	1</param>
/// <param name="ordr_ccd">정정취소유형	string	1</param>
/// <param name="ordr_typ_cd">주문유형코드	string	1</param>
/// <param name="ordr_typ_prd_ccd">주문기간코드	string	2</param>
/// <param name="ordr_aplc_strt_dt">주문적용시작일자	string	8</param>
/// <param name="ordr_aplc_end_dt">주문적용종료일자	string	8</param>
/// <param name="ordr_prc">주문가격	double	18.11</param>
/// <param name="cndt_ordr_prc">주문조건가격	double	18.11</param>
/// <param name="ordr_q">주문수량	long	12</param>
/// <param name="ordr_tm">주문시간	string	9</param>
/// <param name="cnfr_q">호가확인수량	long	12</param>
/// <param name="rfsl_cd">호가거부사유코드	string	4</param>
/// <param name="text">호가거부사유코드명	string	80</param>
/// <param name="user_id">사용자ID	string	8</param>
[BlockInfo(false, 297)]
public record TC2OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("KEY", 11)] string key,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("서비스ID", 4)] string svc_id,
    [BlockField("주문일자", 8)] string ordr_dt,
    [BlockField("지점번호", 3)] string brn_cd,
    [BlockField("주문번호", 10)] long ordr_no,
    [BlockField("원주문번호", 10)] long orgn_ordr_no,
    [BlockField("모주문번호", 10)] long mthr_ordr_no,
    [BlockField("계좌번호", 11)] string ac_no,
    [BlockField("종목코드", 30)] string is_cd,
    [BlockField("매도매수유형", 1)] string s_b_ccd,
    [BlockField("정정취소유형", 1)] string ordr_ccd,
    [BlockField("주문유형코드", 1)] string ordr_typ_cd,
    [BlockField("주문기간코드", 2)] string ordr_typ_prd_ccd,
    [BlockField("주문적용시작일자", 8)] string ordr_aplc_strt_dt,
    [BlockField("주문적용종료일자", 8)] string ordr_aplc_end_dt,
    [BlockField("주문가격", 18.11)] double ordr_prc,
    [BlockField("주문조건가격", 18.11)] double cndt_ordr_prc,
    [BlockField("주문수량", 12)] long ordr_q,
    [BlockField("주문시간", 9)] string ordr_tm,
    [BlockField("호가확인수량", 12)] long cnfr_q,
    [BlockField("호가거부사유코드", 4)] string rfsl_cd,
    [BlockField("호가거부사유코드명", 80)] string text,
    [BlockField("사용자ID", 8)] string user_id
    );


/// <summary>
/// 해외선물체결: TC3
/// </summary>
[BlockInfo(false, 0)]
public record TC3InBlock(
    );

/// <summary>
/// 해외선물체결: TC3
/// </summary>
/// <param name="lineseq">라인일련번호	long	10</param>
/// <param name="key">KEY	string	11</param>
/// <param name="user">조작자ID	string	8</param>
/// <param name="svc_id">서비스ID	string	4</param>
/// <param name="ordr_dt">주문일자	string	8</param>
/// <param name="brn_cd">지점번호	string	3</param>
/// <param name="ordr_no">주문번호	long	10</param>
/// <param name="orgn_ordr_no">원주문번호	long	10</param>
/// <param name="mthr_ordr_no">모주문번호	long	10</param>
/// <param name="ac_no">계좌번호	string	11</param>
/// <param name="is_cd">종목코드	string	30</param>
/// <param name="s_b_ccd">매도매수유형	string	1</param>
/// <param name="ordr_ccd">정정취소유형	string	1</param>
/// <param name="ccls_q">체결수량	long	15</param>
/// <param name="ccls_prc">체결가격	double	18.11</param>
/// <param name="ccls_no">체결번호	string	10</param>
/// <param name="ccls_tm">체결시간	string	9</param>
/// <param name="avg_byng_uprc">매입평균단가	double	18.11</param>
/// <param name="byug_amt">매입금액	double	25.8</param>
/// <param name="clr_pl_amt">청산손익	double	19.2</param>
/// <param name="ent_fee">위탁수수료	double	19.2</param>
/// <param name="fcm_fee">매입잔고수량	long	19</param>
/// <param name="userid">사용자ID	string	8</param>
/// <param name="now_prc">현재가격	double	18.11</param>
/// <param name="crncy_cd">통화코드	string	3</param>
/// <param name="mtrt_dt">만기일자	string	8</param>
/// <param name="ord_prdt_tp_code">주문상품구분코드	string	1</param>
/// <param name="exec_prdt_tp_code">주문상품구분코드	string	1</param>
/// <param name="sprd_base_isu_yn">스프레드종목여부	string	1</param>
/// <param name="ccls_dt">체결일자	string	8</param>
/// <param name="filler2">FILLER2	string	30</param>
/// <param name="sprd_is_cd">스프레드종목코드	string	30</param>
/// <param name="lme_prdt_ccd">LME상품유형	string	1</param>
/// <param name="lme_sprd_prc">LME스프레드가격	double	18.11</param>
/// <param name="last_now_prc">최종현재가격	double	18.11</param>
/// <param name="bf_mtrt_dt">이전만기일자	string	8</param>
/// <param name="clr_q">청산수량	long	15</param>
[BlockInfo(false, 437)]
public record TC3OutBlock(
    [BlockField("라인일련번호", 10)] long lineseq,
    [BlockField("KEY", 11)] string key,
    [BlockField("조작자ID", 8)] string user,
    [BlockField("서비스ID", 4)] string svc_id,
    [BlockField("주문일자", 8)] string ordr_dt,
    [BlockField("지점번호", 3)] string brn_cd,
    [BlockField("주문번호", 10)] long ordr_no,
    [BlockField("원주문번호", 10)] long orgn_ordr_no,
    [BlockField("모주문번호", 10)] long mthr_ordr_no,
    [BlockField("계좌번호", 11)] string ac_no,
    [BlockField("종목코드", 30)] string is_cd,
    [BlockField("매도매수유형", 1)] string s_b_ccd,
    [BlockField("정정취소유형", 1)] string ordr_ccd,
    [BlockField("체결수량", 15)] long ccls_q,
    [BlockField("체결가격", 18.11)] double ccls_prc,
    [BlockField("체결번호", 10)] string ccls_no,
    [BlockField("체결시간", 9)] string ccls_tm,
    [BlockField("매입평균단가", 18.11)] double avg_byng_uprc,
    [BlockField("매입금액", 25.8)] double byug_amt,
    [BlockField("청산손익", 19.2)] double clr_pl_amt,
    [BlockField("위탁수수료", 19.2)] double ent_fee,
    [BlockField("매입잔고수량", 19)] long fcm_fee,
    [BlockField("사용자ID", 8)] string userid,
    [BlockField("현재가격", 18.11)] double now_prc,
    [BlockField("통화코드", 3)] string crncy_cd,
    [BlockField("만기일자", 8)] string mtrt_dt,
    [BlockField("주문상품구분코드", 1)] string ord_prdt_tp_code,
    [BlockField("주문상품구분코드", 1)] string exec_prdt_tp_code,
    [BlockField("스프레드종목여부", 1)] string sprd_base_isu_yn,
    [BlockField("체결일자", 8)] string ccls_dt,
    [BlockField("FILLER2", 30)] string filler2,
    [BlockField("스프레드종목코드", 30)] string sprd_is_cd,
    [BlockField("LME상품유형", 1)] string lme_prdt_ccd,
    [BlockField("LME스프레드가격", 18.11)] double lme_sprd_prc,
    [BlockField("최종현재가격", 18.11)] double last_now_prc,
    [BlockField("이전만기일자", 8)] string bf_mtrt_dt,
    [BlockField("청산수량", 15)] long clr_q
    );


/// <summary>
/// VI발동해제: VI_
/// </summary>
/// <param name="shcode">단축코드(KEY)	string	6</param>
[BlockInfo(true, 7)]
public record VI_InBlock(
    [BlockField("단축코드(KEY)", 6)] string shcode
    );

/// <summary>
/// VI발동해제: VI_
/// </summary>
/// <param name="vi_gubun">구분(0:해제 1:정적발동 2:동적발동 3:정적 and 동적)	string	1</param>
/// <param name="svi_recprice">정적VI발동기준가격	int	8</param>
/// <param name="dvi_recprice">동적VI발동기준가격	int	8</param>
/// <param name="vi_trgprice">VI발동가격	int	8</param>
/// <param name="shcode">단축코드(KEY)	string	6</param>
/// <param name="ref_shcode">참조코드	string	6</param>
/// <param name="time">시간	string	6</param>
[BlockInfo(true, 50)]
public record VI_OutBlock(
    [BlockField("구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)", 1)] string vi_gubun,
    [BlockField("정적VI발동기준가격", 8)] int svi_recprice,
    [BlockField("동적VI발동기준가격", 8)] int dvi_recprice,
    [BlockField("VI발동가격", 8)] int vi_trgprice,
    [BlockField("단축코드(KEY)", 6)] string shcode,
    [BlockField("참조코드", 6)] string ref_shcode,
    [BlockField("시간", 6)] string time
    );


/// <summary>
/// 해외옵션 현재가체결: WOC
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
[BlockInfo(true, 17)]
public record WOCInBlock(
    [BlockField("종목코드", 16)] string symbol
    );

/// <summary>
/// 해외옵션 현재가체결: WOC
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
/// <param name="ovsdate">체결일자(현지)	string	8</param>
/// <param name="kordate">체결일자(한국)	string	8</param>
/// <param name="trdtm">체결시간(현지)	string	6</param>
/// <param name="kortm">체결시간(한국)	string	6</param>
/// <param name="curpr">체결가격	double	15.9</param>
/// <param name="ydiffpr">전일대비	double	15.9</param>
/// <param name="ydiffSign">전일대비기호	string	1</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="chgrate">등락율	double	6.2</param>
/// <param name="trdq">건별체결수량	long	10</param>
/// <param name="totq">누적체결수량	string	15</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="mdvolume">매도누적체결수량	string	15</param>
/// <param name="msvolume">매수누적체결수량	string	15</param>
/// <param name="ovsmkend">장마감일	string	8</param>
[BlockInfo(true, 208)]
public record WOCOutBlock(
    [BlockField("종목코드", 16)] string symbol,
    [BlockField("체결일자(현지)", 8)] string ovsdate,
    [BlockField("체결일자(한국)", 8)] string kordate,
    [BlockField("체결시간(현지)", 6)] string trdtm,
    [BlockField("체결시간(한국)", 6)] string kortm,
    [BlockField("체결가격", 15.9)] double curpr,
    [BlockField("전일대비", 15.9)] double ydiffpr,
    [BlockField("전일대비기호", 1)] string ydiffSign,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("등락율", 6.2)] double chgrate,
    [BlockField("건별체결수량", 10)] long trdq,
    [BlockField("누적체결수량", 15)] string totq,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("매도누적체결수량", 15)] string mdvolume,
    [BlockField("매수누적체결수량", 15)] string msvolume,
    [BlockField("장마감일", 8)] string ovsmkend
    );


/// <summary>
/// 해외옵션 호가: WOH
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
[BlockInfo(true, 17)]
public record WOHInBlock(
    [BlockField("종목코드", 16)] string symbol
    );

/// <summary>
/// 해외옵션 호가: WOH
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="offerho1">매도호가 1	double	15.9</param>
/// <param name="bidho1">매수호가 1	double	15.9</param>
/// <param name="offerrem1">매도호가 잔량 1	long	10</param>
/// <param name="bidrem1">매수호가 잔량 1	long	10</param>
/// <param name="offerno1">매도호가 건수 1	long	10</param>
/// <param name="bidno1">매수호가 건수 1	long	10</param>
/// <param name="offerho2">매도호가 2	double	15.9</param>
/// <param name="bidho2">매수호가 2	double	15.9</param>
/// <param name="offerrem2">매도호가 잔량 2	long	10</param>
/// <param name="bidrem2">매수호가 잔량 2	long	10</param>
/// <param name="offerno2">매도호가 건수 2	long	10</param>
/// <param name="bidno2">매수호가 건수 2	long	10</param>
/// <param name="offerho3">매도호가 3	double	15.9</param>
/// <param name="bidho3">매수호가 3	double	15.9</param>
/// <param name="offerrem3">매도호가 잔량 3	long	10</param>
/// <param name="bidrem3">매수호가 잔량 3	long	10</param>
/// <param name="offerno3">매도호가 건수 3	long	10</param>
/// <param name="bidno3">매수호가 건수 3	long	10</param>
/// <param name="offerho4">매도호가 4	double	15.9</param>
/// <param name="bidho4">매수호가 4	double	15.9</param>
/// <param name="offerrem4">매도호가 잔량 4	long	10</param>
/// <param name="bidrem4">매수호가 잔량 4	long	10</param>
/// <param name="offerno4">매도호가 건수 4	long	10</param>
/// <param name="bidno4">매수호가 건수 4	long	10</param>
/// <param name="offerho5">매도호가 5	double	15.9</param>
/// <param name="bidho5">매수호가 5	double	15.9</param>
/// <param name="offerrem5">매도호가 잔량 5	long	10</param>
/// <param name="bidrem5">매수호가 잔량 5	long	10</param>
/// <param name="offerno5">매도호가 건수 5	long	10</param>
/// <param name="bidno5">매수호가 건수 5	long	10</param>
/// <param name="totoffercnt">매도호가총건수	long	10</param>
/// <param name="totbidcnt">매수호가총건수	long	10</param>
/// <param name="totofferrem">매도호가총수량	long	10</param>
/// <param name="totbidrem">매수호가총수량	long	10</param>
[BlockInfo(true, 448)]
public record WOHOutBlock(
    [BlockField("종목코드", 16)] string symbol,
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("매도호가 1", 15.9)] double offerho1,
    [BlockField("매수호가 1", 15.9)] double bidho1,
    [BlockField("매도호가 잔량 1", 10)] long offerrem1,
    [BlockField("매수호가 잔량 1", 10)] long bidrem1,
    [BlockField("매도호가 건수 1", 10)] long offerno1,
    [BlockField("매수호가 건수 1", 10)] long bidno1,
    [BlockField("매도호가 2", 15.9)] double offerho2,
    [BlockField("매수호가 2", 15.9)] double bidho2,
    [BlockField("매도호가 잔량 2", 10)] long offerrem2,
    [BlockField("매수호가 잔량 2", 10)] long bidrem2,
    [BlockField("매도호가 건수 2", 10)] long offerno2,
    [BlockField("매수호가 건수 2", 10)] long bidno2,
    [BlockField("매도호가 3", 15.9)] double offerho3,
    [BlockField("매수호가 3", 15.9)] double bidho3,
    [BlockField("매도호가 잔량 3", 10)] long offerrem3,
    [BlockField("매수호가 잔량 3", 10)] long bidrem3,
    [BlockField("매도호가 건수 3", 10)] long offerno3,
    [BlockField("매수호가 건수 3", 10)] long bidno3,
    [BlockField("매도호가 4", 15.9)] double offerho4,
    [BlockField("매수호가 4", 15.9)] double bidho4,
    [BlockField("매도호가 잔량 4", 10)] long offerrem4,
    [BlockField("매수호가 잔량 4", 10)] long bidrem4,
    [BlockField("매도호가 건수 4", 10)] long offerno4,
    [BlockField("매수호가 건수 4", 10)] long bidno4,
    [BlockField("매도호가 5", 15.9)] double offerho5,
    [BlockField("매수호가 5", 15.9)] double bidho5,
    [BlockField("매도호가 잔량 5", 10)] long offerrem5,
    [BlockField("매수호가 잔량 5", 10)] long bidrem5,
    [BlockField("매도호가 건수 5", 10)] long offerno5,
    [BlockField("매수호가 건수 5", 10)] long bidno5,
    [BlockField("매도호가총건수", 10)] long totoffercnt,
    [BlockField("매수호가총건수", 10)] long totbidcnt,
    [BlockField("매도호가총수량", 10)] long totofferrem,
    [BlockField("매수호가총수량", 10)] long totbidrem
    );


/// <summary>
/// 상품선물예상체결: YC3
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record YC3InBlock(
    [BlockField("단축코드", 8)] string shcode
    );

/// <summary>
/// 상품선물예상체결: YC3
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	double	9.2</param>
/// <param name="yevolume">예상체결수량	int	6</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	double	9.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	9.2</param>
/// <param name="shcode">단축코드	string	8</param>
[BlockInfo(true, 55)]
public record YC3OutBlock(
    [BlockField("예상체결시간", 6)] string ychetime,
    [BlockField("예상체결가격", 9.2)] double yeprice,
    [BlockField("예상체결수량", 6)] int yevolume,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 9.2)] double jnilchange,
    [BlockField("예상체결가전일종가등락율", 9.2)] double jnilydrate,
    [BlockField("단축코드", 8)] string shcode
    );


/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record YFCInBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	double	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	double	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 39)]
public record YFCOutBlock(
    [BlockField("예상체결시간", 6)] string ychetime,
    [BlockField("예상체결가격", 6.2)] double yeprice,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 6.2)] double jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record YJCInBlock(
    [BlockField("단축코드", 8)] string futcode
    );

/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	long	10</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	long	10</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
[BlockInfo(true, 47)]
public record YJCOutBlock(
    [BlockField("예상체결시간", 6)] string ychetime,
    [BlockField("예상체결가격", 10)] long yeprice,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 10)] long jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("단축코드", 8)] string futcode
    );


/// <summary>
/// 예상지수: YJ_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 4)]
public record YJ_InBlock(
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 예상지수: YJ_
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="jisu">예상지수	double	8.2</param>
/// <param name="sign">예상전일대비구분	string	1</param>
/// <param name="change">예상전일비	double	8.2</param>
/// <param name="drate">예상등락율	double	6.2</param>
/// <param name="cvolume">예상체결량	int	8</param>
/// <param name="volume">누적거래량	int	8</param>
/// <param name="value">예상거래대금	int	8</param>
/// <param name="upcode">업종코드	string	3</param>
[BlockInfo(true, 65)]
public record YJ_OutBlock(
    [BlockField("시간", 6)] string time,
    [BlockField("예상지수", 8.2)] double jisu,
    [BlockField("예상전일대비구분", 1)] string sign,
    [BlockField("예상전일비", 8.2)] double change,
    [BlockField("예상등락율", 6.2)] double drate,
    [BlockField("예상체결량", 8)] int cvolume,
    [BlockField("누적거래량", 8)] int volume,
    [BlockField("예상거래대금", 8)] int value,
    [BlockField("업종코드", 3)] string upcode
    );


/// <summary>
/// KOSDAQ예상체결: YK3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record YK3InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSDAQ예상체결: YK3
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	long	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	int	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="yofferho0">예상매도호가	int	8</param>
/// <param name="ybidho0">예상매수호가	int	8</param>
/// <param name="yofferrem0">예상매도호가수량	long	12</param>
/// <param name="ybidrem0">예상매수호가수량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 98)]
public record YK3OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] long yevolume,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 8)] int jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("예상매도호가", 8)] int yofferho0,
    [BlockField("예상매수호가", 8)] int ybidho0,
    [BlockField("예상매도호가수량", 12)] long yofferrem0,
    [BlockField("예상매수호가수량", 12)] long ybidrem0,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 9)]
public record YOCInBlock(
    [BlockField("단축코드", 8)] string optcode
    );

/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	double	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	double	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="optcode">단축코드	string	8</param>
[BlockInfo(true, 39)]
public record YOCOutBlock(
    [BlockField("예상체결시간", 6)] string ychetime,
    [BlockField("예상체결가격", 6.2)] double yeprice,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 6.2)] double jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("단축코드", 8)] string optcode
    );


/// <summary>
/// KOSPI예상체결: YS3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record YS3InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// KOSPI예상체결: YS3
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	long	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	int	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="yofferho0">예상매도호가	int	8</param>
/// <param name="ybidho0">예상매수호가	int	8</param>
/// <param name="yofferrem0">예상매도호가수량	long	12</param>
/// <param name="ybidrem0">예상매수호가수량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 98)]
public record YS3OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] long yevolume,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 8)] int jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("예상매도호가", 8)] int yofferho0,
    [BlockField("예상매수호가", 8)] int ybidho0,
    [BlockField("예상매도호가수량", 12)] long yofferrem0,
    [BlockField("예상매수호가수량", 12)] long ybidrem0,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// ELW예상체결: Ys3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 7)]
public record Ys3InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW예상체결: Ys3
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	long	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	int	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="yofferho0">예상매도호가	int	8</param>
/// <param name="ybidho0">예상매수호가	int	8</param>
/// <param name="yofferrem0">예상매도호가수량	long	12</param>
/// <param name="ybidrem0">예상매수호가수량	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
[BlockInfo(true, 98)]
public record Ys3OutBlock(
    [BlockField("호가시간", 6)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] long yevolume,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 8)] int jnilchange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("예상매도호가", 8)] int yofferho0,
    [BlockField("예상매수호가", 8)] int ybidho0,
    [BlockField("예상매도호가수량", 12)] long yofferrem0,
    [BlockField("예상매수호가수량", 12)] long ybidrem0,
    [BlockField("단축코드", 6)] string shcode
    );


