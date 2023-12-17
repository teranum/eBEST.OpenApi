// [2023-12-17 오후 3:00:48]
// 이 파일은 BlockMaker에 의해 자동으로 만들어졌습니다.
// XingAPI res폴더의 TR파일에서 변환되었습니다.
using System.ComponentModel;
namespace eBEST.OpenApi.Blocks;

/// <summary>
/// ETF호가잔량: B7_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record B7_InBlock([Description("단축코드	string	6")] string shcode);

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
public record B7_OutBlock([Description("호가시간	string	6")] string hotime, [Description("LP매도호가수량1	long	9")] long lp_offerho1, [Description("LP매수호가수량1	long	9")] long lp_bidho1, [Description("LP매도호가수량2	long	9")] long lp_offerho2, [Description("LP매수호가수량2	long	9")] long lp_bidho2, [Description("LP매도호가수량3	long	9")] long lp_offerho3, [Description("LP매수호가수량3	long	9")] long lp_bidho3, [Description("LP매도호가수량4	long	9")] long lp_offerho4, [Description("LP매수호가수량4	long	9")] long lp_bidho4, [Description("LP매도호가수량5	long	9")] long lp_offerho5, [Description("LP매수호가수량5	long	9")] long lp_bidho5, [Description("LP매도호가수량6	long	9")] long lp_offerho6, [Description("LP매수호가수량6	long	9")] long lp_bidho6, [Description("LP매도호가수량7	long	9")] long lp_offerho7, [Description("LP매수호가수량7	long	9")] long lp_bidho7, [Description("LP매도호가수량8	long	9")] long lp_offerho8, [Description("LP매수호가수량8	long	9")] long lp_bidho8, [Description("LP매도호가수량9	long	9")] long lp_offerho9, [Description("LP매수호가수량9	long	9")] long lp_bidho9, [Description("LP매도호가수량10	long	9")] long lp_offerho10, [Description("LP매수호가수량10	long	9")] long lp_bidho10, [Description("단축코드	string	6")] string shcode, [Description("매도호가1	int	7")] int offerho1, [Description("매수호가1	int	7")] int bidho1, [Description("매도호가잔량1	long	9")] long offerrem1, [Description("매수호가잔량1	long	9")] long bidrem1, [Description("매도호가2	int	7")] int offerho2, [Description("매수호가2	int	7")] int bidho2, [Description("매도호가잔량2	long	9")] long offerrem2, [Description("매수호가잔량2	long	9")] long bidrem2, [Description("매도호가3	int	7")] int offerho3, [Description("매수호가3	int	7")] int bidho3, [Description("매도호가잔량3	long	9")] long offerrem3, [Description("매수호가잔량3	long	9")] long bidrem3, [Description("매도호가4	int	7")] int offerho4, [Description("매수호가4	int	7")] int bidho4, [Description("매도호가잔량4	long	9")] long offerrem4, [Description("매수호가잔량4	long	9")] long bidrem4, [Description("매도호가5	int	7")] int offerho5, [Description("매수호가5	int	7")] int bidho5, [Description("매도호가잔량5	long	9")] long offerrem5, [Description("매수호가잔량5	long	9")] long bidrem5, [Description("매도호가6	int	7")] int offerho6, [Description("매수호가6	int	7")] int bidho6, [Description("매도호가잔량6	long	9")] long offerrem6, [Description("매수호가잔량6	long	9")] long bidrem6, [Description("매도호가7	int	7")] int offerho7, [Description("매수호가7	int	7")] int bidho7, [Description("매도호가잔량7	long	9")] long offerrem7, [Description("매수호가잔량7	long	9")] long bidrem7, [Description("매도호가8	int	7")] int offerho8, [Description("매수호가8	int	7")] int bidho8, [Description("매도호가잔량8	long	9")] long offerrem8, [Description("매수호가잔량8	long	9")] long bidrem8, [Description("매도호가9	int	7")] int offerho9, [Description("매수호가9	int	7")] int bidho9, [Description("매도호가잔량9	long	9")] long offerrem9, [Description("매수호가잔량9	long	9")] long bidrem9, [Description("매도호가10	int	7")] int offerho10, [Description("매수호가10	int	7")] int bidho10, [Description("매도호가잔량10	long	9")] long offerrem10, [Description("매수호가잔량10	long	9")] long bidrem10, [Description("총매도호가잔량	long	9")] long totofferrem, [Description("총매수호가잔량	long	9")] long totbidrem, [Description("동시호가구분	string	1")] string donsigubun, [Description("배분적용구분	string	1")] string alloc_gubun);

/// <summary>
/// 시간대별투자자매매추이: BMT
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record BMTInBlock([Description("업종코드	string	3")] string upcode);

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
public record BMTOutBlock([Description("수신시간	string	8")] string tjjtime, [Description("투자자코드1(개인)	string	4")] string tjjcode1, [Description("매수 거래량1	int	8")] int msvolume1, [Description("매도 거래량1	int	8")] int mdvolume1, [Description("거래량 순매수1	int	8")] int msvol1, [Description("매수 거래대금1	int	6")] int msvalue1, [Description("매도 거래대금1	int	6")] int mdvalue1, [Description("거래대금 순매수1	int	6")] int msval1, [Description("투자자코드2(외국인)	string	4")] string tjjcode2, [Description("매수 거래량2	int	8")] int msvolume2, [Description("매도 거래량2	int	8")] int mdvolume2, [Description("거래량 순매수2	int	8")] int msvol2, [Description("매수 거래대금2	int	6")] int msvalue2, [Description("매도 거래대금2	int	6")] int mdvalue2, [Description("거래대금 순매수2	int	6")] int msval2, [Description("투자자코드3(기관계)	string	4")] string tjjcode3, [Description("매수 거래량3	int	8")] int msvolume3, [Description("매도 거래량3	int	8")] int mdvolume3, [Description("거래량 순매수3	int	8")] int msvol3, [Description("매수 거래대금3	int	6")] int msvalue3, [Description("매도 거래대금3	int	6")] int mdvalue3, [Description("거래대금 순매수3	int	6")] int msval3, [Description("투자자코드4(증권)	string	4")] string tjjcode4, [Description("매수 거래량4	int	8")] int msvolume4, [Description("매도 거래량4	int	8")] int mdvolume4, [Description("거래량 순매수4	int	8")] int msvol4, [Description("매수 거래대금4	int	6")] int msvalue4, [Description("매도 거래대금4	int	6")] int mdvalue4, [Description("거래대금 순매수4	int	6")] int msval4, [Description("투자자코드5(투신)	string	4")] string tjjcode5, [Description("매수 거래량5	int	8")] int msvolume5, [Description("매도 거래량5	int	8")] int mdvolume5, [Description("거래량 순매수5	int	8")] int msvol5, [Description("매수 거래대금5	int	6")] int msvalue5, [Description("매도 거래대금5	int	6")] int mdvalue5, [Description("거래대금 순매수5	int	6")] int msval5, [Description("투자자코드6(은행)	string	4")] string tjjcode6, [Description("매수 거래량6	int	8")] int msvolume6, [Description("매도 거래량6	int	8")] int mdvolume6, [Description("거래량 순매수6	int	8")] int msvol6, [Description("매수 거래대금6	int	6")] int msvalue6, [Description("매도 거래대금6	int	6")] int mdvalue6, [Description("거래대금 순매수6	int	6")] int msval6, [Description("투자자코드7(보험)	string	4")] string tjjcode7, [Description("매수 거래량7	int	8")] int msvolume7, [Description("매도 거래량7	int	8")] int mdvolume7, [Description("거래량 순매수7	int	8")] int msvol7, [Description("매수 거래대금7	int	6")] int msvalue7, [Description("매도 거래대금7	int	6")] int mdvalue7, [Description("거래대금 순매수7	int	6")] int msval7, [Description("투자자코드8(종금)	string	4")] string tjjcode8, [Description("매수 거래량8	int	8")] int msvolume8, [Description("매도 거래량8	int	8")] int mdvolume8, [Description("거래량 순매수8	int	8")] int msvol8, [Description("매수 거래대금8	int	6")] int msvalue8, [Description("매도 거래대금8	int	6")] int mdvalue8, [Description("거래대금 순매수8	int	6")] int msval8, [Description("투자자코드9(기금)	string	4")] string tjjcode9, [Description("매수 거래량9	int	8")] int msvolume9, [Description("매도 거래량9	int	8")] int mdvolume9, [Description("거래량 순매수9	int	8")] int msvol9, [Description("매수 거래대금9	int	6")] int msvalue9, [Description("매도 거래대금9	int	6")] int mdvalue9, [Description("거래대금 순매수9	int	6")] int msval9, [Description("투자자코드10(선물업자)	string	4")] string tjjcode10, [Description("매수 거래량10	int	8")] int msvolume10, [Description("매도 거래량10	int	8")] int mdvolume10, [Description("거래량 순매수10	int	8")] int msvol10, [Description("매수 거래대금10	int	6")] int msvalue10, [Description("매도 거래대금10	int	6")] int mdvalue10, [Description("거래대금 순매수10	int	6")] int msval10, [Description("투자자코드11(기타)	string	4")] string tjjcode11, [Description("매수 거래량11	int	8")] int msvolume11, [Description("매도 거래량11	int	8")] int mdvolume11, [Description("거래량 순매수11	int	8")] int msvol11, [Description("매수 거래대금11	int	6")] int msvalue11, [Description("매도 거래대금11	int	6")] int mdvalue11, [Description("거래대금 순매수11	int	6")] int msval11, [Description("업종코드	string	3")] string upcode, [Description("투자자코드0(사모펀드)	string	4")] string tjjcode0, [Description("매수 거래량0	int	8")] int msvolume0, [Description("매도 거래량0	int	8")] int mdvolume0, [Description("거래량 순매수0	int	8")] int msvol0, [Description("매수 거래대금0	int	6")] int msvalue0, [Description("매도 거래대금0	int	6")] int mdvalue0, [Description("거래대금 순매수0	int	6")] int msval0);

/// <summary>
/// 업종별투자자별매매현황: BM_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record BM_InBlock([Description("업종코드	string	3")] string upcode);

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
public record BM_OutBlock([Description("투자자코드	string	4")] string tjjcode, [Description("수신시간	string	8")] string tjjtime, [Description("매수 거래량	int	8")] int msvolume, [Description("매도 거래량	int	8")] int mdvolume, [Description("거래량 순매수	int	8")] int msvol, [Description("거래량 순매수 직전대비	int	8")] int p_msvol, [Description("매수 거래대금	int	6")] int msvalue, [Description("매도 거래대금	int	6")] int mdvalue, [Description("거래대금 순매수	int	6")] int msval, [Description("거래대금 순매수 직전대비	int	6")] int p_msval, [Description("업종코드	string	3")] string upcode);

/// <summary>
/// 선물주문체결: C01
/// </summary>
public record C01InBlock();

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
public record C01OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("일련번호	long	11")] long seq, [Description("trcode	string	11")] string trcode, [Description("매칭그룹번호	string	2")] string megrpno, [Description("보드ID	string	2")] string boardid, [Description("회원번호	string	5")] string memberno, [Description("지점번호	string	5")] string bpno, [Description("주문번호	string	10")] string ordno, [Description("원주문번호	string	10")] string ordordno, [Description("종목코드	string	12")] string expcode, [Description("약정번호	string	11")] string yakseq, [Description("체결가격	double	11.2")] double cheprice, [Description("체결수량	long	10")] long chevol, [Description("세션ID	string	2")] string sessionid, [Description("체결일자	string	8")] string chedate, [Description("체결시각	string	9")] string chetime, [Description("최근월체결가격	double	11.2")] double spdprc1, [Description("차근월체결가격	double	11.2")] double spdprc2, [Description("매도수구분	string	1")] string dosugb, [Description("계좌번호1	string	12")] string accno1, [Description("시장조성호가구분	string	1")] string sihogagb, [Description("위탁사번호	string	5")] string jakino, [Description("대용주권계좌번호	string	12")] string daeyong, [Description("mem_filler	string	7")] string mem_filler, [Description("mem_accno	string	11")] string mem_accno, [Description("mem_filler1	string	42")] string mem_filler1);

/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record CD0InBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// 상품선물실시간상하한가(D0): CD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="futcode">단축코드	string	8</param>
public record CD0OutBlock([Description("접속매매여부	string	1")] string gubun, [Description("실시간가격제한여부	string	1")] string dy_gubun, [Description("실시간상한가	double	8.2")] double dy_uplmtprice, [Description("실시간하한가	double	8.2")] double dy_dnlmtprice, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// 현물정보 USD 실시간: CUR
/// </summary>
/// <param name="base_id">기초자산ID	string	6</param>
public record CURInBlock([Description("기초자산ID	string	6")] string base_id);

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
public record CUROutBlock([Description("전송시간	string	6")] string time, [Description("매도호가	double	7.2")] double offer, [Description("매수호가	double	7.2")] double bid, [Description("시가	double	7.2")] double open, [Description("고가	double	7.2")] double high, [Description("저가	double	7.2")] double low, [Description("체결가	double	7.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	7.2")] double change, [Description("등락율	double	7.2")] double drate, [Description("데이타 발생시간	string	6")] string ctime, [Description("기초자산ID	string	6")] string base_id);

/// <summary>
/// KOSPI시간외단일가호가잔량: DH1
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record DH1InBlock([Description("단축코드	string	6")] string shcode);

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
public record DH1OutBlock([Description("시간외단일가호가시간	string	6")] string dan_hotime, [Description("시간외단일가장구분	string	2")] string dan_hstatus, [Description("시간외단일가매도호가1	int	8")] int dan_offerho1, [Description("시간외단일가매수호가1	int	8")] int dan_bidho1, [Description("시간외단일가매도호가잔량1	long	12")] long dan_offerrem1, [Description("시간외단일가매수호가잔량1	long	12")] long dan_bidrem1, [Description("시간외단일가직전매도대비수량1	long	12")] long dan_preoffercha1, [Description("시간외단일가직전매수대비수량1	long	12")] long dan_prebidcha1, [Description("시간외단일가매도호가2	int	8")] int dan_offerho2, [Description("시간외단일가매수호가2	int	8")] int dan_bidho2, [Description("시간외단일가매도호가잔량2	long	12")] long dan_offerrem2, [Description("시간외단일가매수호가잔량2	long	12")] long dan_bidrem2, [Description("시간외단일가직전매도대비수량2	long	12")] long dan_preoffercha2, [Description("시간외단일가직전매수대비수량2	long	12")] long dan_prebidcha2, [Description("시간외단일가매도호가3	int	8")] int dan_offerho3, [Description("시간외단일가매수호가3	int	8")] int dan_bidho3, [Description("시간외단일가매도호가잔량3	long	12")] long dan_offerrem3, [Description("시간외단일가매수호가잔량3	long	12")] long dan_bidrem3, [Description("시간외단일가직전매도대비수량3	long	12")] long dan_preoffercha3, [Description("시간외단일가직전매수대비수량3	long	12")] long dan_prebidcha3, [Description("시간외단일가매도호가4	int	8")] int dan_offerho4, [Description("시간외단일가매수호가4	int	8")] int dan_bidho4, [Description("시간외단일가매도호가잔량4	long	12")] long dan_offerrem4, [Description("시간외단일가매수호가잔량4	long	12")] long dan_bidrem4, [Description("시간외단일가직전매도대비수량4	long	12")] long dan_preoffercha4, [Description("시간외단일가직전매수대비수량4	long	12")] long dan_prebidcha4, [Description("시간외단일가매도호가5	int	8")] int dan_offerho5, [Description("시간외단일가매수호가5	int	8")] int dan_bidho5, [Description("시간외단일가매도호가잔량5	long	12")] long dan_offerrem5, [Description("시간외단일가매수호가잔량5	long	12")] long dan_bidrem5, [Description("시간외단일가직전매도대비수량5	long	12")] long dan_preoffercha5, [Description("시간외단일가직전매수대비수량5	long	12")] long dan_prebidcha5, [Description("시간외단일가총매도호가잔량	long	12")] long dan_totofferrem, [Description("시간외단일가총매수호가잔량	long	12")] long dan_totbidrem, [Description("시간외단일가직전매도호가총대비수량	long	12")] long dan_preoffercha, [Description("시간외단일가직전매수호가총대비수량	long	12")] long dan_prebidcha, [Description("시간외단일가예상체결가격	int	8")] int dan_yeprice, [Description("시간외단일가예상체결수량	long	12")] long dan_yevolume, [Description("시간외단일가예상가직전가대비구분	string	1")] string dan_preysign, [Description("시간외단일가예상가직전가대비	int	8")] int dan_preychange, [Description("시간외단일가예상가전일가대비구분	string	1")] string dan_jnilysign, [Description("시간외단일가예상가전일가대비	int	8")] int dan_jnilychange, [Description("단축코드	string	6")] string shcode, [Description("누적거래량	long	12")] long volume);

/// <summary>
/// KOSDAQ시간외단일가호가잔량: DHA
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record DHAInBlock([Description("단축코드	string	6")] string shcode);

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
public record DHAOutBlock([Description("시간외단일가호가시간	string	6")] string dan_hotime, [Description("시간외단일가장구분	string	2")] string dan_hstatus, [Description("시간외단일가매도호가1	int	8")] int dan_offerho1, [Description("시간외단일가매수호가1	int	8")] int dan_bidho1, [Description("시간외단일가매도호가잔량1	long	12")] long dan_offerrem1, [Description("시간외단일가매수호가잔량1	long	12")] long dan_bidrem1, [Description("시간외단일가직전매도대비수량1	long	12")] long dan_preoffercha1, [Description("시간외단일가직전매수대비수량1	long	12")] long dan_prebidcha1, [Description("시간외단일가매도호가2	int	8")] int dan_offerho2, [Description("시간외단일가매수호가2	int	8")] int dan_bidho2, [Description("시간외단일가매도호가잔량2	long	12")] long dan_offerrem2, [Description("시간외단일가매수호가잔량2	long	12")] long dan_bidrem2, [Description("시간외단일가직전매도대비수량2	long	12")] long dan_preoffercha2, [Description("시간외단일가직전매수대비수량2	long	12")] long dan_prebidcha2, [Description("시간외단일가매도호가3	int	8")] int dan_offerho3, [Description("시간외단일가매수호가3	int	8")] int dan_bidho3, [Description("시간외단일가매도호가잔량3	long	12")] long dan_offerrem3, [Description("시간외단일가매수호가잔량3	long	12")] long dan_bidrem3, [Description("시간외단일가직전매도대비수량3	long	12")] long dan_preoffercha3, [Description("시간외단일가직전매수대비수량3	long	12")] long dan_prebidcha3, [Description("시간외단일가매도호가4	int	8")] int dan_offerho4, [Description("시간외단일가매수호가4	int	8")] int dan_bidho4, [Description("시간외단일가매도호가잔량4	long	12")] long dan_offerrem4, [Description("시간외단일가매수호가잔량4	long	12")] long dan_bidrem4, [Description("시간외단일가직전매도대비수량4	long	12")] long dan_preoffercha4, [Description("시간외단일가직전매수대비수량4	long	12")] long dan_prebidcha4, [Description("시간외단일가매도호가5	int	8")] int dan_offerho5, [Description("시간외단일가매수호가5	int	8")] int dan_bidho5, [Description("시간외단일가매도호가잔량5	long	12")] long dan_offerrem5, [Description("시간외단일가매수호가잔량5	long	12")] long dan_bidrem5, [Description("시간외단일가직전매도대비수량5	long	12")] long dan_preoffercha5, [Description("시간외단일가직전매수대비수량5	long	12")] long dan_prebidcha5, [Description("시간외단일가총매도호가잔량	long	12")] long dan_totofferrem, [Description("시간외단일가총매수호가잔량	long	12")] long dan_totbidrem, [Description("시간외단일가직전매도호가총대비수량	long	12")] long dan_preoffercha, [Description("시간외단일가직전매수호가총대비수량	long	12")] long dan_prebidcha, [Description("시간외단일가예상체결가격	int	8")] int dan_yeprice, [Description("시간외단일가예상체결수량	long	12")] long dan_yevolume, [Description("시간외단일가예상가직전가대비구분	string	1")] string dan_preysign, [Description("시간외단일가예상가직전가대비	int	8")] int dan_preychange, [Description("시간외단일가예상가전일가대비구분	string	1")] string dan_jnilysign, [Description("시간외단일가예상가전일가대비	int	8")] int dan_jnilychange, [Description("단축코드	string	6")] string shcode, [Description("누적거래량	long	12")] long volume);

/// <summary>
/// KOSDAQ시간외단일가체결: DK3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record DK3InBlock([Description("단축코드	string	6")] string shcode);

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
public record DK3OutBlock([Description("시간외단일가체결시간	string	6")] string dan_chetime, [Description("시간외단일가전일대비구분	string	1")] string dan_sign, [Description("시간외단일가전일대비	int	8")] int dan_change, [Description("시간외단일가등락율	double	6.2")] double dan_drate, [Description("시간외단일가현재가	int	8")] int dan_price, [Description("시간외단일가시가시간	string	6")] string dan_opentime, [Description("시간외단일가시가	int	8")] int dan_open, [Description("시간외단일가고가시간	string	6")] string dan_hightime, [Description("시간외단일가고가	int	8")] int dan_high, [Description("시간외단일가저가시간	string	6")] string dan_lowtime, [Description("시간외단일가저가	int	8")] int dan_low, [Description("시간외단일가체결구분	string	1")] string dan_cgubun, [Description("시간외단일가체결량	int	8")] int dan_cvolume, [Description("시간외단일가누적거래량	long	12")] long dan_volume, [Description("시간외단일가누적거래대금	long	12")] long dan_value, [Description("시간외단일가매도누적체결량	long	12")] long dan_mdvolume, [Description("시간외단일가매도누적체결건수	int	8")] int dan_mdchecnt, [Description("시간외단일가매수누적체결량	long	12")] long dan_msvolume, [Description("시간외단일가매수누적체결건수	int	8")] int dan_mschecnt, [Description("시간외단일가직전거래량	int	8")] int dan_prevolume, [Description("시간외단일가직전체결수량	int	8")] int dan_precvolume, [Description("시간외단일가체결강도	double	9.2")] double dan_cpower, [Description("시간외단일가장정보	string	2")] string dan_status, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSPI시간외단일가체결: DS3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record DS3InBlock([Description("단축코드	string	6")] string shcode);

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
public record DS3OutBlock([Description("시간외단일가체결시간	string	6")] string dan_chetime, [Description("시간외단일가전일대비구분	string	1")] string dan_sign, [Description("시간외단일가전일대비	int	8")] int dan_change, [Description("시간외단일가등락율	double	6.2")] double dan_drate, [Description("시간외단일가현재가	int	8")] int dan_price, [Description("시간외단일가시가시간	string	6")] string dan_opentime, [Description("시간외단일가시가	int	8")] int dan_open, [Description("시간외단일가고가시간	string	6")] string dan_hightime, [Description("시간외단일가고가	int	8")] int dan_high, [Description("시간외단일가저가시간	string	6")] string dan_lowtime, [Description("시간외단일가저가	int	8")] int dan_low, [Description("시간외단일가체결구분	string	1")] string dan_cgubun, [Description("시간외단일가체결량	int	8")] int dan_cvolume, [Description("시간외단일가누적거래량	long	12")] long dan_volume, [Description("시간외단일가누적거래대금	long	12")] long dan_value, [Description("시간외단일가매도누적체결량	long	12")] long dan_mdvolume, [Description("시간외단일가매도누적체결건수	int	8")] int dan_mdchecnt, [Description("시간외단일가매수누적체결량	long	12")] long dan_msvolume, [Description("시간외단일가매수누적체결건수	int	8")] int dan_mschecnt, [Description("시간외단일가직전거래량	int	8")] int dan_prevolume, [Description("시간외단일가직전체결수량	int	8")] int dan_precvolume, [Description("시간외단일가체결강도	double	9.2")] double dan_cpower, [Description("시간외단일가장정보	string	2")] string dan_status, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// 시간외단일가VI발동해제: DVI
/// </summary>
/// <param name="shcode">단축코드(KEY)	string	6</param>
public record DVIInBlock([Description("단축코드(KEY)	string	6")] string shcode);

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
public record DVIOutBlock([Description("구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)	string	1")] string vi_gubun, [Description("정적VI발동기준가격	int	8")] int svi_recprice, [Description("동적VI발동기준가격	int	8")] int dvi_recprice, [Description("VI발동가격	int	8")] int vi_trgprice, [Description("단축코드(KEY)	string	6")] string shcode, [Description("참조코드(미사용)	string	6")] string ref_shcode, [Description("시간	string	6")] string time);

/// <summary>
/// EUREX연계KP200지수옵션선물체결: EC0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record EC0InBlock([Description("단축코드	string	8")] string optcode);

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
public record EC0OutBlock([Description("체결시간(24시간)	string	6")] string chetime, [Description("체결시간(36시간)	string	6")] string chetime1, [Description("정규장종가대비구분	string	1")] string sign, [Description("정규장종가대비	double	6.2")] double change, [Description("정규장종가기준등락율	double	6.2")] double drate, [Description("현재가	double	6.2")] double price, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	6")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금(미제공)	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수(미제공)	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수(미제공)	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("미결제약정수량	int	8")] int openyak, [Description("KOSPI200지수	double	6.2")] double k200jisu, [Description("KOSPI등가	double	7.2")] double eqva, [Description("이론가	double	6.2")] double theoryprice, [Description("내재변동성	double	6.2")] double impv, [Description("미결제약정증감	int	8")] int openyakcha, [Description("시간가치	double	6.2")] double timevalue, [Description("장운영정보	string	2")] string jgubun, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("단축코드	string	8")] string optcode);

/// <summary>
/// EUREX연계KP200지수옵션선물호가: EH0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record EH0InBlock([Description("단축코드	string	8")] string optcode);

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
public record EH0OutBlock([Description("호가시간(24시간)	string	6")] string hotime, [Description("호가시간(36시간)	string	6")] string hotime1, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("매도호가수량1	int	7")] int offerrem1, [Description("매수호가수량1	int	7")] int bidrem1, [Description("매도호가건수1(미제공)	int	5")] int offercnt1, [Description("매수호가건수1(미제공)	int	5")] int bidcnt1, [Description("매도호가2	double	6.2")] double offerho2, [Description("매수호가2	double	6.2")] double bidho2, [Description("매도호가수량2	int	7")] int offerrem2, [Description("매수호가수량2	int	7")] int bidrem2, [Description("매도호가건수2(미제공)	int	5")] int offercnt2, [Description("매수호가건수2(미제공)	int	5")] int bidcnt2, [Description("매도호가3	double	6.2")] double offerho3, [Description("매수호가3	double	6.2")] double bidho3, [Description("매도호가수량3	int	7")] int offerrem3, [Description("매수호가수량3	int	7")] int bidrem3, [Description("매도호가건수3(미제공)	int	5")] int offercnt3, [Description("매수호가건수3(미제공)	int	5")] int bidcnt3, [Description("매도호가4(미제공)	double	6.2")] double offerho4, [Description("매수호가4(미제공)	double	6.2")] double bidho4, [Description("매도호가수량4(미제공)	int	7")] int offerrem4, [Description("매수호가수량4(미제공)	int	7")] int bidrem4, [Description("매도호가건수4(미제공)	int	5")] int offercnt4, [Description("매수호가건수4(미제공)	int	5")] int bidcnt4, [Description("매도호가5(미제공)	double	6.2")] double offerho5, [Description("매수호가5(미제공)	double	6.2")] double bidho5, [Description("매도호가수량5(미제공)	int	7")] int offerrem5, [Description("매수호가수량5(미제공)	int	7")] int bidrem5, [Description("매도호가건수5(미제공)	int	5")] int offercnt5, [Description("매수호가건수5(미제공)	int	5")] int bidcnt5, [Description("매도호가총수량	int	7")] int totofferrem, [Description("매수호가총수량	int	7")] int totbidrem, [Description("매도호가총건수	int	5")] int totoffercnt, [Description("매수호가총건수	int	5")] int totbidcnt, [Description("단축코드	string	8")] string optcode, [Description("단일가호가여부	string	1")] string danhochk);

/// <summary>
/// 뉴ELW투자지표민감도: ESN
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record ESNInBlock([Description("단축코드	string	6")] string shcode);

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
public record ESNOutBlock([Description("시간	string	6")] string time, [Description("장중이론가	double	10.2")] double theoryprice, [Description("델타	double	7.6")] double delt, [Description("감마	double	7.6")] double gama, [Description("세타	double	12.6")] double ceta, [Description("베가	double	12.6")] double vega, [Description("로우	double	12.6")] double rhox, [Description("내재변동성	double	5.2")] double impv, [Description("E.기어링	double	8.2")] double egearing, [Description("단축코드	string	6")] string shcode, [Description("ELW현재가	int	8")] int elwclose, [Description("ELW전일대비구분	string	1")] string sign, [Description("ELW전일대비	int	8")] int change, [Description("일자	string	8")] string date, [Description("틱환산	double	10.2")] double tickvalue, [Description("LP내재변동성	double	5.2")] double lp_impv);

/// <summary>
/// EUX접수: EU0
/// </summary>
public record EU0InBlock();

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
public record EU0OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("tr코드	string	4")] string trcode1, [Description("회사번호	string	3")] string firmno, [Description("계좌번호	string	11")] string acntno, [Description("계좌번호	string	9")] string acntno1, [Description("계좌명	string	40")] string acntnm, [Description("지점번호	string	3")] string brnno, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문번호	string	3")] string ordno1, [Description("주문번호	int	7")] int ordno, [Description("원주문번호	string	3")] string orgordno1, [Description("원주문번호	int	7")] int orgordno, [Description("모주문번호	string	3")] string prntordno, [Description("모주문번호	int	7")] int prntordno1, [Description("종목번호	string	12")] string isuno, [Description("선물옵션종목번호	string	8")] string fnoIsuno, [Description("선물옵션종목명	string	40")] string fnoIsunm, [Description("상품군분류코드	string	2")] string pdgrpcode, [Description("선물옵션종목유형구분	string	1")] string fnoIsuptntp, [Description("매매구분	string	1")] string bnstp, [Description("정정취소구분	string	1")] string mrctp, [Description("주문수량	long	16")] long ordqty, [Description("호가유형코드	string	2")] string hogatype, [Description("거래유형코드	string	2")] string mmgb, [Description("주문가격	double	13.2")] double ordprc, [Description("미체결수량	long	16")] long unercqty, [Description("통신매체	string	2")] string commdacode, [Description("수수료합산코드	string	2")] string peeamtcode, [Description("관리사원	string	9")] string mgempno, [Description("선물옵션거래단위금액	double	19.8")] double fnotrdunitamt, [Description("처리시각	string	9")] string trxtime, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	string	10")] string ordseqno, [Description("포트폴리오 번호	string	10")] string ptflno, [Description("바스켓번호	string	10")] string bskno, [Description("트렌치번호	string	10")] string trchno, [Description("아이템번호	string	10")] string Itemno, [Description("주문자Id	string	16")] string OrderID, [Description("운영지시번호	string	12")] string opdrtnno, [Description("부적격코드	string	4")] string rjtcode, [Description("정정취소확인수량	long	16")] long mrccnfqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정취소수량	long	16")] long orgordmrcqty, [Description("약정시각(체결시각)	string	8")] string ctrcttime, [Description("약정번호	string	10")] string ctrctno, [Description("체결가격	double	13.2")] double execprc, [Description("체결수량	long	16")] long execqty, [Description("신규체결수량	long	16")] long newqty, [Description("청산체결수량	long	16")] long qdtqty, [Description("최종결제수량	long	16")] long lastqty, [Description("전체체결수량	long	16")] long lallexecqty, [Description("전체체결금액	long	16")] long allexecamt, [Description("잔고평가구분	string	1")] string fnobalevaltp, [Description("매매손익금액	long	16")] long bnsplamt, [Description("선물옵션종목번호1	string	8")] string fnoIsuno1, [Description("매매구분1	string	1")] string bnstp1, [Description("체결가1	double	13.2")] double execprc1, [Description("신규체결수량1	long	16")] long newqty1, [Description("청산체결수량1	long	16")] long qdtqty1, [Description("전체체결금액1	long	16")] long allexecamt1, [Description("선물옵션종목번호2	string	8")] string fnoIsuno2, [Description("매매구분2	string	1")] string bnstp2, [Description("체결가2	double	13.2")] double execprc2, [Description("신규체결수량2	long	16")] long newqty2, [Description("청산체결수량2	long	16")] long lqdtqty2, [Description("전체체결금액2	long	16")] long allexecamt2, [Description("예수금	long	16")] long dps, [Description("선물대용지정금액	long	16")] long ftsubtdsgnamt, [Description("증거금	long	16")] long mgn, [Description("증거금현금	long	16")] long mnymgn, [Description("주문가능금액	long	16")] long ordableamt, [Description("주문가능현금액	long	16")] long mnyordableamt, [Description("잔고 종목번호1	string	8")] string fnoIsuno_1, [Description("잔고 매매구분1	string	1")] string bnstp_1, [Description("미결제수량1	long	16")] long unsttqty_1, [Description("주문가능수량1	long	16")] long lqdtableqty_1, [Description("평균가1	double	13.2")] double avrprc_1, [Description("잔고 종목번호2	string	8")] string fnoIsuno_2, [Description("잔고 매매구분2	string	1")] string bnstp_2, [Description("미결제수량2	long	16")] long unsttqty_2, [Description("주문가능수량2	long	16")] long lqdtableqty_2, [Description("평균가2	double	13.2")] double avrprc_2);

/// <summary>
/// EUX체결: EU1
/// </summary>
public record EU1InBlock();

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
public record EU1OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("tr코드	string	4")] string trcode1, [Description("회사번호	string	3")] string firmno, [Description("계좌번호	string	11")] string acntno, [Description("계좌번호	string	9")] string acntno1, [Description("계좌명	string	40")] string acntnm, [Description("지점번호	string	3")] string brnno, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문번호	string	3")] string ordno1, [Description("주문번호	int	7")] int ordno, [Description("원주문번호	string	3")] string orgordno1, [Description("원주문번호	int	7")] int orgordno, [Description("모주문번호	string	3")] string prntordno, [Description("모주문번호	int	7")] int prntordno1, [Description("종목번호	string	12")] string isuno, [Description("선물옵션종목번호	string	8")] string fnoIsuno, [Description("선물옵션종목명	string	40")] string fnoIsunm, [Description("상품군분류코드	string	2")] string pdgrpcode, [Description("선물옵션종목유형구분	string	1")] string fnoIsuptntp, [Description("매매구분	string	1")] string bnstp, [Description("정정취소구분	string	1")] string mrctp, [Description("주문수량	long	16")] long ordqty, [Description("호가유형코드	string	2")] string hogatype, [Description("거래유형코드	string	2")] string mmgb, [Description("주문가격	double	13.2")] double ordprc, [Description("미체결수량	long	16")] long unercqty, [Description("통신매체	string	2")] string commdacode, [Description("수수료합산코드	string	2")] string peeamtcode, [Description("관리사원	string	9")] string mgempno, [Description("선물옵션거래단위금액	double	19.8")] double fnotrdunitamt, [Description("처리시각	string	9")] string trxtime, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	string	10")] string ordseqno, [Description("포트폴리오 번호	string	10")] string ptflno, [Description("바스켓번호	string	10")] string bskno, [Description("트렌치번호	string	10")] string trchno, [Description("아이템번호	string	10")] string Itemno, [Description("주문자Id	string	16")] string OrderID, [Description("운영지시번호	string	12")] string opdrtnno, [Description("부적격코드	string	4")] string rjtcode, [Description("정정취소확인수량	long	16")] long mrccnfqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정취소수량	long	16")] long orgordmrcqty, [Description("약정시각(체결시각)	string	8")] string ctrcttime, [Description("약정번호	string	10")] string ctrctno, [Description("체결가격	double	13.2")] double execprc, [Description("체결수량	long	16")] long execqty, [Description("신규체결수량	long	16")] long newqty, [Description("청산체결수량	long	16")] long qdtqty, [Description("최종결제수량	long	16")] long lastqty, [Description("전체체결수량	long	16")] long lallexecqty, [Description("전체체결금액	long	16")] long allexecamt, [Description("잔고평가구분	string	1")] string fnobalevaltp, [Description("매매손익금액	long	16")] long bnsplamt, [Description("선물옵션종목번호1	string	8")] string fnoIsuno1, [Description("매매구분1	string	1")] string bnstp1, [Description("체결가1	double	13.2")] double execprc1, [Description("신규체결수량1	long	16")] long newqty1, [Description("청산체결수량1	long	16")] long qdtqty1, [Description("전체체결금액1	long	16")] long allexecamt1, [Description("선물옵션종목번호2	string	8")] string fnoIsuno2, [Description("매매구분2	string	1")] string bnstp2, [Description("체결가2	double	13.2")] double execprc2, [Description("신규체결수량2	long	16")] long newqty2, [Description("청산체결수량2	long	16")] long lqdtqty2, [Description("전체체결금액2	long	16")] long allexecamt2, [Description("예수금	long	16")] long dps, [Description("선물대용지정금액	long	16")] long ftsubtdsgnamt, [Description("증거금	long	16")] long mgn, [Description("증거금현금	long	16")] long mnymgn, [Description("주문가능금액	long	16")] long ordableamt, [Description("주문가능현금액	long	16")] long mnyordableamt, [Description("잔고 종목번호1	string	8")] string fnoIsuno_1, [Description("잔고 매매구분1	string	1")] string bnstp_1, [Description("미결제수량1	long	16")] long unsttqty_1, [Description("주문가능수량1	long	16")] long lqdtableqty_1, [Description("평균가1	double	13.2")] double avrprc_1, [Description("잔고 종목번호2	string	8")] string fnoIsuno_2, [Description("잔고 매매구분2	string	1")] string bnstp_2, [Description("미결제수량2	long	16")] long unsttqty_2, [Description("주문가능수량2	long	16")] long lqdtableqty_2, [Description("평균가2	double	13.2")] double avrprc_2);

/// <summary>
/// EUX확인: EU2
/// </summary>
public record EU2InBlock();

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
public record EU2OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("tr코드	string	4")] string trcode1, [Description("회사번호	string	3")] string firmno, [Description("계좌번호	string	11")] string acntno, [Description("계좌번호	string	9")] string acntno1, [Description("계좌명	string	40")] string acntnm, [Description("지점번호	string	3")] string brnno, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문번호	string	3")] string ordno1, [Description("주문번호	int	7")] int ordno, [Description("원주문번호	string	3")] string orgordno1, [Description("원주문번호	int	7")] int orgordno, [Description("모주문번호	string	3")] string prntordno, [Description("모주문번호	int	7")] int prntordno1, [Description("종목번호	string	12")] string isuno, [Description("선물옵션종목번호	string	8")] string fnoIsuno, [Description("선물옵션종목명	string	40")] string fnoIsunm, [Description("상품군분류코드	string	2")] string pdgrpcode, [Description("선물옵션종목유형구분	string	1")] string fnoIsuptntp, [Description("매매구분	string	1")] string bnstp, [Description("정정취소구분	string	1")] string mrctp, [Description("주문수량	long	16")] long ordqty, [Description("호가유형코드	string	2")] string hogatype, [Description("거래유형코드	string	2")] string mmgb, [Description("주문가격	double	13.2")] double ordprc, [Description("미체결수량	long	16")] long unercqty, [Description("통신매체	string	2")] string commdacode, [Description("수수료합산코드	string	2")] string peeamtcode, [Description("관리사원	string	9")] string mgempno, [Description("선물옵션거래단위금액	double	19.8")] double fnotrdunitamt, [Description("처리시각	string	9")] string trxtime, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	string	10")] string ordseqno, [Description("포트폴리오 번호	string	10")] string ptflno, [Description("바스켓번호	string	10")] string bskno, [Description("트렌치번호	string	10")] string trchno, [Description("아이템번호	string	10")] string Itemno, [Description("주문자Id	string	16")] string OrderID, [Description("운영지시번호	string	12")] string opdrtnno, [Description("부적격코드	string	4")] string rjtcode, [Description("정정취소확인수량	long	16")] long mrccnfqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정취소수량	long	16")] long orgordmrcqty, [Description("약정시각(체결시각)	string	8")] string ctrcttime, [Description("약정번호	string	10")] string ctrctno, [Description("체결가격	double	13.2")] double execprc, [Description("체결수량	long	16")] long execqty, [Description("신규체결수량	long	16")] long newqty, [Description("청산체결수량	long	16")] long qdtqty, [Description("최종결제수량	long	16")] long lastqty, [Description("전체체결수량	long	16")] long lallexecqty, [Description("전체체결금액	long	16")] long allexecamt, [Description("잔고평가구분	string	1")] string fnobalevaltp, [Description("매매손익금액	long	16")] long bnsplamt, [Description("선물옵션종목번호1	string	8")] string fnoIsuno1, [Description("매매구분1	string	1")] string bnstp1, [Description("체결가1	double	13.2")] double execprc1, [Description("신규체결수량1	long	16")] long newqty1, [Description("청산체결수량1	long	16")] long qdtqty1, [Description("전체체결금액1	long	16")] long allexecamt1, [Description("선물옵션종목번호2	string	8")] string fnoIsuno2, [Description("매매구분2	string	1")] string bnstp2, [Description("체결가2	double	13.2")] double execprc2, [Description("신규체결수량2	long	16")] long newqty2, [Description("청산체결수량2	long	16")] long lqdtqty2, [Description("전체체결금액2	long	16")] long allexecamt2, [Description("예수금	long	16")] long dps, [Description("선물대용지정금액	long	16")] long ftsubtdsgnamt, [Description("증거금	long	16")] long mgn, [Description("증거금현금	long	16")] long mnymgn, [Description("주문가능금액	long	16")] long ordableamt, [Description("주문가능현금액	long	16")] long mnyordableamt, [Description("잔고 종목번호1	string	8")] string fnoIsuno_1, [Description("잔고 매매구분1	string	1")] string bnstp_1, [Description("미결제수량1	long	16")] long unsttqty_1, [Description("주문가능수량1	long	16")] long lqdtableqty_1, [Description("평균가1	double	13.2")] double avrprc_1, [Description("잔고 종목번호2	string	8")] string fnoIsuno_2, [Description("잔고 매매구분2	string	1")] string bnstp_2, [Description("미결제수량2	long	16")] long unsttqty_2, [Description("주문가능수량2	long	16")] long lqdtableqty_2, [Description("평균가2	double	13.2")] double avrprc_2);

/// <summary>
/// KOSPI200선물체결(C0): FC0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record FC0InBlock([Description("단축코드	string	8")] string futcode);

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
public record FC0OutBlock([Description("체결시간	string	6")] string chetime, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double drate, [Description("현재가	double	6.2")] double price, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	6")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("미결제약정수량	int	8")] int openyak, [Description("KOSPI200지수	double	6.2")] double k200jisu, [Description("이론가	double	6.2")] double theoryprice, [Description("괴리율	double	6.2")] double kasis, [Description("시장BASIS	double	6.2")] double sbasis, [Description("이론BASIS	double	6.2")] double ibasis, [Description("미결제약정증감	int	8")] int openyakcha, [Description("장운영정보	string	2")] string jgubun, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record FD0InBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// KOSPI200선물실시간상하한가(D0): FD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="futcode">단축코드	string	8</param>
public record FD0OutBlock([Description("접속매매여부	string	1")] string gubun, [Description("실시간가격제한여부	string	1")] string dy_gubun, [Description("실시간상한가	double	8.2")] double dy_uplmtprice, [Description("실시간하한가	double	8.2")] double dy_dnlmtprice, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// KOSPI200선물호가(H0): FH0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record FH0InBlock([Description("단축코드	string	8")] string futcode);

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
public record FH0OutBlock([Description("호가시간	string	6")] string hotime, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("매도호가수량1	int	6")] int offerrem1, [Description("매수호가수량1	int	6")] int bidrem1, [Description("매도호가건수1	int	5")] int offercnt1, [Description("매수호가건수1	int	5")] int bidcnt1, [Description("매도호가2	double	6.2")] double offerho2, [Description("매수호가2	double	6.2")] double bidho2, [Description("매도호가수량2	int	6")] int offerrem2, [Description("매수호가수량2	int	6")] int bidrem2, [Description("매도호가건수2	int	5")] int offercnt2, [Description("매수호가건수2	int	5")] int bidcnt2, [Description("매도호가3	double	6.2")] double offerho3, [Description("매수호가3	double	6.2")] double bidho3, [Description("매도호가수량3	int	6")] int offerrem3, [Description("매수호가수량3	int	6")] int bidrem3, [Description("매도호가건수3	int	5")] int offercnt3, [Description("매수호가건수3	int	5")] int bidcnt3, [Description("매도호가4	double	6.2")] double offerho4, [Description("매수호가4	double	6.2")] double bidho4, [Description("매도호가수량4	int	6")] int offerrem4, [Description("매수호가수량4	int	6")] int bidrem4, [Description("매도호가건수4	int	5")] int offercnt4, [Description("매수호가건수4	int	5")] int bidcnt4, [Description("매도호가5	double	6.2")] double offerho5, [Description("매수호가5	double	6.2")] double bidho5, [Description("매도호가수량5	int	6")] int offerrem5, [Description("매수호가수량5	int	6")] int bidrem5, [Description("매도호가건수5	int	5")] int offercnt5, [Description("매수호가건수5	int	5")] int bidcnt5, [Description("매도호가총수량	int	6")] int totofferrem, [Description("매수호가총수량	int	6")] int totbidrem, [Description("매도호가총건수	int	5")] int totoffercnt, [Description("매수호가총건수	int	5")] int totbidcnt, [Description("단축코드	string	8")] string futcode, [Description("단일가호가여부	string	1")] string danhochk, [Description("배분적용구분	string	1")] string alloc_gubun);

/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record FX0InBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// KOSPI200선물가격제한폭확대(X0): FX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	double	6.2</param>
/// <param name="dnlmtprice">적용 하한가	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
public record FX0OutBlock([Description("적용 상한단계	string	2")] string upstep, [Description("적용 하한단계	string	2")] string dnstep, [Description("적용 상한가	double	6.2")] double uplmtprice, [Description("적용 하한가	double	6.2")] double dnlmtprice, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// 선물주문정정취소: H01
/// </summary>
public record H01InBlock();

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
public record H01OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("일련번호	long	11")] long seq, [Description("trcode	string	11")] string trcode, [Description("매칭그룹번호	string	2")] string megrpno, [Description("보드ID	string	2")] string boardid, [Description("회원번호	string	5")] string memberno, [Description("지점번호	string	5")] string bpno, [Description("주문번호	string	10")] string ordno, [Description("원주문번호	string	10")] string ordordno, [Description("종목코드	string	12")] string expcode, [Description("매도수구분	string	1")] string dosugb, [Description("정정취소구분	string	1")] string mocagb, [Description("계좌번호1	string	12")] string accno1, [Description("호가수량	long	10")] long qty2, [Description("호가가격	double	11.2")] double price, [Description("주문유형	string	1")] string ordgb, [Description("호가구분	string	1")] string hogagb, [Description("시장조성호가구분	string	11")] string sihogagb, [Description("자사주신고서ID	string	5")] string treaid, [Description("자사주매매방법	string	1")] string treacode, [Description("매도유형코드	string	2")] string askcode, [Description("신용구분코드	string	2")] string creditcode, [Description("위탁자기구분	string	2")] string jakigb, [Description("위탁사번호	string	5")] string trustnum, [Description("프로그램구분	string	2")] string ptgb, [Description("대용주권계좌번호	string	12")] string substocnum, [Description("계좌구분코드	string	2")] string accgb, [Description("계좌증거금코드	string	2")] string accmarggb, [Description("국가코드	string	3")] string nationcode, [Description("투자자구분	string	4")] string investgb, [Description("외국인코드	string	2")] string forecode, [Description("주문매체구분	string	1")] string medcode, [Description("주문식별자번호	string	12")] string ordid, [Description("MAC주소	string	12")] string macid, [Description("호가일자	string	8")] string orddate, [Description("회원사주문시각	string	9")] string rcvtime, [Description("mem_filler	string	7")] string mem_filler, [Description("mem_accno	string	11")] string mem_accno, [Description("mem_filler1	string	42")] string mem_filler1, [Description("매칭접수시간	string	9")] string ordacpttm, [Description("실정정취소수량	long	10")] long qty, [Description("자동취소구분	string	1")] string autogb, [Description("거부사유	string	4")] string rejcode, [Description("프로그램호가신고	string	1")] string prgordde);

/// <summary>
/// KOSPI호가잔량: H1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record H1_InBlock([Description("단축코드	string	6")] string shcode);

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
public record H1_OutBlock([Description("호가시간	string	6")] string hotime, [Description("매도호가1	int	7")] int offerho1, [Description("매수호가1	int	7")] int bidho1, [Description("매도호가잔량1	long	9")] long offerrem1, [Description("매수호가잔량1	long	9")] long bidrem1, [Description("매도호가2	int	7")] int offerho2, [Description("매수호가2	int	7")] int bidho2, [Description("매도호가잔량2	long	9")] long offerrem2, [Description("매수호가잔량2	long	9")] long bidrem2, [Description("매도호가3	int	7")] int offerho3, [Description("매수호가3	int	7")] int bidho3, [Description("매도호가잔량3	long	9")] long offerrem3, [Description("매수호가잔량3	long	9")] long bidrem3, [Description("매도호가4	int	7")] int offerho4, [Description("매수호가4	int	7")] int bidho4, [Description("매도호가잔량4	long	9")] long offerrem4, [Description("매수호가잔량4	long	9")] long bidrem4, [Description("매도호가5	int	7")] int offerho5, [Description("매수호가5	int	7")] int bidho5, [Description("매도호가잔량5	long	9")] long offerrem5, [Description("매수호가잔량5	long	9")] long bidrem5, [Description("매도호가6	int	7")] int offerho6, [Description("매수호가6	int	7")] int bidho6, [Description("매도호가잔량6	long	9")] long offerrem6, [Description("매수호가잔량6	long	9")] long bidrem6, [Description("매도호가7	int	7")] int offerho7, [Description("매수호가7	int	7")] int bidho7, [Description("매도호가잔량7	long	9")] long offerrem7, [Description("매수호가잔량7	long	9")] long bidrem7, [Description("매도호가8	int	7")] int offerho8, [Description("매수호가8	int	7")] int bidho8, [Description("매도호가잔량8	long	9")] long offerrem8, [Description("매수호가잔량8	long	9")] long bidrem8, [Description("매도호가9	int	7")] int offerho9, [Description("매수호가9	int	7")] int bidho9, [Description("매도호가잔량9	long	9")] long offerrem9, [Description("매수호가잔량9	long	9")] long bidrem9, [Description("매도호가10	int	7")] int offerho10, [Description("매수호가10	int	7")] int bidho10, [Description("매도호가잔량10	long	9")] long offerrem10, [Description("매수호가잔량10	long	9")] long bidrem10, [Description("총매도호가잔량	long	9")] long totofferrem, [Description("총매수호가잔량	long	9")] long totbidrem, [Description("동시호가구분	string	1")] string donsigubun, [Description("단축코드	string	6")] string shcode, [Description("배분적용구분	string	1")] string alloc_gubun, [Description("누적거래량	long	12")] long volume);

/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record H2_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSPI장전시간외호가잔량: H2_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
public record H2_OutBlock([Description("호가시간	string	6")] string hotime, [Description("시간외매도잔량	long	12")] long tmofferrem, [Description("시간외매수잔량	long	12")] long tmbidrem, [Description("시간외매도수량직전대비	long	12")] long pretmoffercha, [Description("시간외매수수량직전대비	long	12")] long pretmbidcha, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record h2_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW장전시간외호가잔량: h2_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
public record h2_OutBlock([Description("호가시간	string	6")] string hotime, [Description("시간외매도잔량	long	12")] long tmofferrem, [Description("시간외매수잔량	long	12")] long tmbidrem, [Description("시간외매도수량직전대비	long	12")] long pretmoffercha, [Description("시간외매수수량직전대비	long	12")] long pretmbidcha, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW호가잔량: h3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record h3_InBlock([Description("단축코드	string	6")] string shcode);

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
public record h3_OutBlock([Description("호가시간	string	6")] string hotime, [Description("매도호가1	int	7")] int offerho1, [Description("매수호가1	int	7")] int bidho1, [Description("매도호가잔량1	long	9")] long offerrem1, [Description("매수호가잔량1	long	9")] long bidrem1, [Description("LP매도호가수량1	long	9")] long lp_offerho1, [Description("LP매수호가수량1	long	9")] long lp_bidho1, [Description("매도호가2	int	7")] int offerho2, [Description("매수호가2	int	7")] int bidho2, [Description("매도호가잔량2	long	9")] long offerrem2, [Description("매수호가잔량2	long	9")] long bidrem2, [Description("LP매도호가수량2	long	9")] long lp_offerho2, [Description("LP매수호가수량2	long	9")] long lp_bidho2, [Description("매도호가3	int	7")] int offerho3, [Description("매수호가3	int	7")] int bidho3, [Description("매도호가잔량3	long	9")] long offerrem3, [Description("매수호가잔량3	long	9")] long bidrem3, [Description("LP매도호가수량3	long	9")] long lp_offerho3, [Description("LP매수호가수량3	long	9")] long lp_bidho3, [Description("매도호가4	int	7")] int offerho4, [Description("매수호가4	int	7")] int bidho4, [Description("매도호가잔량4	long	9")] long offerrem4, [Description("매수호가잔량4	long	9")] long bidrem4, [Description("LP매도호가수량4	long	9")] long lp_offerho4, [Description("LP매수호가수량4	long	9")] long lp_bidho4, [Description("매도호가5	int	7")] int offerho5, [Description("매수호가5	int	7")] int bidho5, [Description("매도호가잔량5	long	9")] long offerrem5, [Description("매수호가잔량5	long	9")] long bidrem5, [Description("LP매도호가수량5	long	9")] long lp_offerho5, [Description("LP매수호가수량5	long	9")] long lp_bidho5, [Description("매도호가6	int	7")] int offerho6, [Description("매수호가6	int	7")] int bidho6, [Description("매도호가잔량6	long	9")] long offerrem6, [Description("매수호가잔량6	long	9")] long bidrem6, [Description("LP매도호가수량6	long	9")] long lp_offerho6, [Description("LP매수호가수량6	long	9")] long lp_bidho6, [Description("매도호가7	int	7")] int offerho7, [Description("매수호가7	int	7")] int bidho7, [Description("매도호가잔량7	long	9")] long offerrem7, [Description("매수호가잔량7	long	9")] long bidrem7, [Description("LP매도호가수량7	long	9")] long lp_offerho7, [Description("LP매수호가수량7	long	9")] long lp_bidho7, [Description("매도호가8	int	7")] int offerho8, [Description("매수호가8	int	7")] int bidho8, [Description("매도호가잔량8	long	9")] long offerrem8, [Description("매수호가잔량8	long	9")] long bidrem8, [Description("LP매도호가수량8	long	9")] long lp_offerho8, [Description("LP매수호가수량8	long	9")] long lp_bidho8, [Description("매도호가9	int	7")] int offerho9, [Description("매수호가9	int	7")] int bidho9, [Description("매도호가잔량9	long	9")] long offerrem9, [Description("매수호가잔량9	long	9")] long bidrem9, [Description("LP매도호가수량9	long	9")] long lp_offerho9, [Description("LP매수호가수량9	long	9")] long lp_bidho9, [Description("매도호가10	int	7")] int offerho10, [Description("매수호가10	int	7")] int bidho10, [Description("매도호가잔량10	long	9")] long offerrem10, [Description("매수호가잔량10	long	9")] long bidrem10, [Description("LP매도호가수량10	long	9")] long lp_offerho10, [Description("LP매수호가수량10	long	9")] long lp_bidho10, [Description("총매도호가잔량	long	9")] long totofferrem, [Description("총매수호가잔량	long	9")] long totbidrem, [Description("동시호가구분	string	1")] string donsigubun, [Description("스프레드	double	6.2")] double spread, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ호가잔량: HA_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record HA_InBlock([Description("단축코드	string	6")] string shcode);

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
public record HA_OutBlock([Description("호가시간	string	6")] string hotime, [Description("매도호가1	int	7")] int offerho1, [Description("매수호가1	int	7")] int bidho1, [Description("매도호가잔량1	long	9")] long offerrem1, [Description("매수호가잔량1	long	9")] long bidrem1, [Description("매도호가2	int	7")] int offerho2, [Description("매수호가2	int	7")] int bidho2, [Description("매도호가잔량2	long	9")] long offerrem2, [Description("매수호가잔량2	long	9")] long bidrem2, [Description("매도호가3	int	7")] int offerho3, [Description("매수호가3	int	7")] int bidho3, [Description("매도호가잔량3	long	9")] long offerrem3, [Description("매수호가잔량3	long	9")] long bidrem3, [Description("매도호가4	int	7")] int offerho4, [Description("매수호가4	int	7")] int bidho4, [Description("매도호가잔량4	long	9")] long offerrem4, [Description("매수호가잔량4	long	9")] long bidrem4, [Description("매도호가5	int	7")] int offerho5, [Description("매수호가5	int	7")] int bidho5, [Description("매도호가잔량5	long	9")] long offerrem5, [Description("매수호가잔량5	long	9")] long bidrem5, [Description("매도호가6	int	7")] int offerho6, [Description("매수호가6	int	7")] int bidho6, [Description("매도호가잔량6	long	9")] long offerrem6, [Description("매수호가잔량6	long	9")] long bidrem6, [Description("매도호가7	int	7")] int offerho7, [Description("매수호가7	int	7")] int bidho7, [Description("매도호가잔량7	long	9")] long offerrem7, [Description("매수호가잔량7	long	9")] long bidrem7, [Description("매도호가8	int	7")] int offerho8, [Description("매수호가8	int	7")] int bidho8, [Description("매도호가잔량8	long	9")] long offerrem8, [Description("매수호가잔량8	long	9")] long bidrem8, [Description("매도호가9	int	7")] int offerho9, [Description("매수호가9	int	7")] int bidho9, [Description("매도호가잔량9	long	9")] long offerrem9, [Description("매수호가잔량9	long	9")] long bidrem9, [Description("매도호가10	int	7")] int offerho10, [Description("매수호가10	int	7")] int bidho10, [Description("매도호가잔량10	long	9")] long offerrem10, [Description("매수호가잔량10	long	9")] long bidrem10, [Description("총매도호가잔량	long	9")] long totofferrem, [Description("총매수호가잔량	long	9")] long totbidrem, [Description("동시호가구분	string	1")] string donsigubun, [Description("단축코드	string	6")] string shcode, [Description("배분적용구분	string	1")] string alloc_gubun, [Description("누적거래량	long	12")] long volume);

/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record HB_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ장전시간외호가잔량: HB_
/// </summary>
/// <param name="hotime">호가시간	string	6</param>
/// <param name="tmofferrem">시간외매도잔량	long	12</param>
/// <param name="tmbidrem">시간외매수잔량	long	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	long	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	long	12</param>
/// <param name="shcode">단축코드	string	6</param>
public record HB_OutBlock([Description("호가시간	string	6")] string hotime, [Description("시간외매도잔량	long	12")] long tmofferrem, [Description("시간외매수잔량	long	12")] long tmbidrem, [Description("시간외매도수량직전대비	long	12")] long pretmoffercha, [Description("시간외매수수량직전대비	long	12")] long pretmbidcha, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// 코스피ETF종목실시간NAV: I5_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record I5_InBlock([Description("단축코드	string	6")] string shcode);

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
public record I5_OutBlock([Description("시간	string	8")] string time, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("누적거래량	double	12")] double volume, [Description("NAV대비	double	9.2")] double navdiff, [Description("NAV	double	9.2")] double nav, [Description("전일대비	double	9.2")] double navchange, [Description("추적오차	double	9.2")] double crate, [Description("괴리	double	9.2")] double grate, [Description("지수	double	8.2")] double jisu, [Description("전일대비	double	8.2")] double jichange, [Description("전일대비율	double	8.2")] double jirate, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// 지수: IJ_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record IJ_InBlock([Description("업종코드	string	3")] string upcode);

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
public record IJ_OutBlock([Description("시간	string	6")] string time, [Description("지수	double	8.2")] double jisu, [Description("전일대비구분	string	1")] string sign, [Description("전일비	double	8.2")] double change, [Description("등락율	double	6.2")] double drate, [Description("체결량	int	8")] int cvolume, [Description("거래량	int	8")] int volume, [Description("거래대금	int	8")] int value, [Description("상한종목수	int	4")] int upjo, [Description("상승종목수	int	4")] int highjo, [Description("보합종목수	int	4")] int unchgjo, [Description("하락종목수	int	4")] int lowjo, [Description("하한종목수	int	4")] int downjo, [Description("상승종목비율	double	6.2")] double upjrate, [Description("시가지수	double	8.2")] double openjisu, [Description("시가시간	string	6")] string opentime, [Description("고가지수	double	8.2")] double highjisu, [Description("고가시간	string	6")] string hightime, [Description("저가지수	double	8.2")] double lowjisu, [Description("저가시간	string	6")] string lowtime, [Description("외인순매수수량	int	8")] int frgsvolume, [Description("기관순매수수량	int	8")] int orgsvolume, [Description("외인순매수금액	long	10")] long frgsvalue, [Description("기관순매수금액	long	10")] long orgsvalue, [Description("업종코드	string	3")] string upcode);

/// <summary>
/// 주식선물체결: JC0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record JC0InBlock([Description("단축코드	string	8")] string futcode);

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
public record JC0OutBlock([Description("단축코드	string	8")] string futcode, [Description("체결시간	string	6")] string chetime, [Description("대비기호	string	1")] string sign, [Description("전일대비	long	10")] long change, [Description("등락율	double	6.2")] double drate, [Description("현재가	long	10")] long price, [Description("시가	long	10")] long open, [Description("고가	long	10")] long high, [Description("저가	long	10")] long low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	6")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	15")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("매도호가1	long	10")] long offerho1, [Description("매수호가1	long	10")] long bidho1, [Description("미결제약정수량	int	8")] int openyak, [Description("KOSPI200지수	double	6.2")] double k200jisu, [Description("이론가	int	8")] int theoryprice, [Description("괴리율	double	6.3")] double kasis, [Description("시장BASIS	int	6")] int sbasis, [Description("이론BASIS	int	6")] int ibasis, [Description("미결제약정증감	int	8")] int openyakcha, [Description("장운영정보	string	2")] string jgubun, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("기초자산현재가	int	8")] int basprice);

/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record JD0InBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// 주식선물실시간상하한가: JD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	long	10</param>
/// <param name="dy_dnlmtprice">실시간하한가	long	10</param>
/// <param name="futcode">단축코드	string	8</param>
public record JD0OutBlock([Description("접속매매여부	string	1")] string gubun, [Description("실시간가격제한여부	string	1")] string dy_gubun, [Description("실시간상한가	long	10")] long dy_uplmtprice, [Description("실시간하한가	long	10")] long dy_dnlmtprice, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// 주식선물호가: JH0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record JH0InBlock([Description("단축코드	string	8")] string futcode);

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
public record JH0OutBlock([Description("단축코드	string	8")] string futcode, [Description("호가시간	string	6")] string hotime, [Description("매도호가1	long	10")] long offerho1, [Description("매수호가1	long	10")] long bidho1, [Description("매도호가수량1	int	7")] int offerrem1, [Description("매수호가수량1	int	7")] int bidrem1, [Description("매도호가건수1	int	5")] int offercnt1, [Description("매수호가건수1	int	5")] int bidcnt1, [Description("매도호가2	long	10")] long offerho2, [Description("매수호가2	long	10")] long bidho2, [Description("매도호가수량2	int	7")] int offerrem2, [Description("매수호가수량2	int	7")] int bidrem2, [Description("매도호가건수2	int	5")] int offercnt2, [Description("매수호가건수2	int	5")] int bidcnt2, [Description("매도호가3	long	10")] long offerho3, [Description("매수호가3	long	10")] long bidho3, [Description("매도호가수량3	int	7")] int offerrem3, [Description("매수호가수량3	int	7")] int bidrem3, [Description("매도호가건수3	int	5")] int offercnt3, [Description("매수호가건수3	int	5")] int bidcnt3, [Description("매도호가4	long	10")] long offerho4, [Description("매수호가4	long	10")] long bidho4, [Description("매도호가수량4	int	7")] int offerrem4, [Description("매수호가수량4	int	7")] int bidrem4, [Description("매도호가건수4	int	5")] int offercnt4, [Description("매수호가건수4	int	5")] int bidcnt4, [Description("매도호가5	long	10")] long offerho5, [Description("매수호가5	long	10")] long bidho5, [Description("매도호가수량5	int	7")] int offerrem5, [Description("매수호가수량5	int	7")] int bidrem5, [Description("매도호가건수5	int	5")] int offercnt5, [Description("매수호가건수5	int	5")] int bidcnt5, [Description("매도호가6	long	10")] long offerho6, [Description("매수호가6	long	10")] long bidho6, [Description("매도호가수량6	int	7")] int offerrem6, [Description("매수호가수량6	int	7")] int bidrem6, [Description("매도호가건수6	int	5")] int offercnt6, [Description("매수호가건수6	int	5")] int bidcnt6, [Description("매도호가7	long	10")] long offerho7, [Description("매수호가7	long	10")] long bidho7, [Description("매도호가수량7	int	7")] int offerrem7, [Description("매수호가수량7	int	7")] int bidrem7, [Description("매도호가건수7	int	5")] int offercnt7, [Description("매수호가건수7	int	5")] int bidcnt7, [Description("매도호가8	long	10")] long offerho8, [Description("매수호가8	long	10")] long bidho8, [Description("매도호가수량8	int	7")] int offerrem8, [Description("매수호가수량8	int	7")] int bidrem8, [Description("매도호가건수8	int	5")] int offercnt8, [Description("매수호가건수8	int	5")] int bidcnt8, [Description("매도호가9	long	10")] long offerho9, [Description("매수호가9	long	10")] long bidho9, [Description("매도호가수량9	int	7")] int offerrem9, [Description("매수호가수량9	int	7")] int bidrem9, [Description("매도호가건수9	int	5")] int offercnt9, [Description("매수호가건수9	int	5")] int bidcnt9, [Description("매도호가10	long	10")] long offerho10, [Description("매수호가10	long	10")] long bidho10, [Description("매도호가수량10	int	7")] int offerrem10, [Description("매수호가수량10	int	7")] int bidrem10, [Description("매도호가건수10	int	5")] int offercnt10, [Description("매수호가건수10	int	5")] int bidcnt10, [Description("매도호가총수량	int	8")] int totofferrem, [Description("매수호가총수량	int	8")] int totbidrem, [Description("매도호가총건수	int	5")] int totoffercnt, [Description("매수호가총건수	int	5")] int totbidcnt, [Description("단일가호가여부	string	1")] string danhochk, [Description("배분적용구분	string	1")] string alloc_gubun);

/// <summary>
/// 장운영정보: JIF
/// </summary>
/// <param name="jangubun">장구분	string	1</param>
public record JIFInBlock([Description("장구분	string	1")] string jangubun);

/// <summary>
/// 장운영정보: JIF
/// </summary>
/// <param name="jangubun">장구분	string	1</param>
/// <param name="jstatus">장상태	string	2</param>
public record JIFOutBlock([Description("장구분	string	1")] string jangubun, [Description("장상태	string	2")] string jstatus);

/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record JX0InBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// 주식선물가격제한폭확대: JX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	long	10</param>
/// <param name="dnlmtprice">적용 하한가	long	10</param>
/// <param name="futcode">단축코드	string	8</param>
public record JX0OutBlock([Description("적용 상한단계	string	2")] string upstep, [Description("적용 하한단계	string	2")] string dnstep, [Description("적용 상한가	long	10")] long uplmtprice, [Description("적용 하한가	long	10")] long dnlmtprice, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// KOSPI거래원: K1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record K1_InBlock([Description("단축코드	string	6")] string shcode);

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
public record K1_OutBlock([Description("매도증권사코드1	string	3")] string offerno1, [Description("매수증권사코드1	string	3")] string bidno1, [Description("매도회원사명1	string	6")] string offertrad1, [Description("매수회원사명1	string	6")] string bidtrad1, [Description("매도거래량1	long	10")] long tradmdvol1, [Description("매수거래량1	long	10")] long tradmsvol1, [Description("매도거래량비중1	double	6.2")] double tradmdrate1, [Description("매도거래량비중1	double	6.2")] double tradmsrate1, [Description("매도거래량직전대비1	long	10")] long tradmdcha1, [Description("매수거래량직전대비1	long	10")] long tradmscha1, [Description("매도증권사코드2	string	3")] string offerno2, [Description("매수증권사코드2	string	3")] string bidno2, [Description("매도회원사명2	string	6")] string offertrad2, [Description("매수회원사명2	string	6")] string bidtrad2, [Description("매도거래량2	long	10")] long tradmdvol2, [Description("매수거래량2	long	10")] long tradmsvol2, [Description("매도거래량비중2	double	6.2")] double tradmdrate2, [Description("매수거래량비중2	double	6.2")] double tradmsrate2, [Description("매도거래량직전대비2	long	10")] long tradmdcha2, [Description("매수거래량직전대비2	long	10")] long tradmscha2, [Description("매도증권사코드3	string	3")] string offerno3, [Description("매수증권사코드3	string	3")] string bidno3, [Description("매도회원사명3	string	6")] string offertrad3, [Description("매수회원사명3	string	6")] string bidtrad3, [Description("매도거래량3	long	10")] long tradmdvol3, [Description("매수거래량3	long	10")] long tradmsvol3, [Description("매도거래량비중3	double	6.2")] double tradmdrate3, [Description("매수거래량비중3	double	6.2")] double tradmsrate3, [Description("매도거래량직전대비3	long	10")] long tradmdcha3, [Description("매수거래량직전대비3	long	10")] long tradmscha3, [Description("매도증권사코드4	string	3")] string offerno4, [Description("매수증권사코드4	string	3")] string bidno4, [Description("매도회원사명4	string	6")] string offertrad4, [Description("매수회원사명4	string	6")] string bidtrad4, [Description("매도거래량4	long	10")] long tradmdvol4, [Description("매수거래량4	long	10")] long tradmsvol4, [Description("매도거래량비중4	double	6.2")] double tradmdrate4, [Description("매수거래량비중4	double	6.2")] double tradmsrate4, [Description("매도거래량직전대비4	long	10")] long tradmdcha4, [Description("매수거래량직전대비4	long	10")] long tradmscha4, [Description("매도증권사코드5	string	3")] string offerno5, [Description("매수증권사코드5	string	3")] string bidno5, [Description("매도회원사명5	string	6")] string offertrad5, [Description("매수회원사명5	string	6")] string bidtrad5, [Description("매도거래량5	long	10")] long tradmdvol5, [Description("매수거래량5	long	10")] long tradmsvol5, [Description("매도거래량비중5	double	6.2")] double tradmdrate5, [Description("매수거래량비중5	double	6.2")] double tradmsrate5, [Description("매도거래량직전대비5	long	10")] long tradmdcha5, [Description("매수거래량직전대비5	long	10")] long tradmscha5, [Description("외국계증권사매도합계	string	10")] string ftradmdvol, [Description("외국계증권사매수합계	string	10")] string ftradmsvol, [Description("외국계증권사매도거래량비중	double	6.2")] double ftradmdrate, [Description("외국계증권사매수거래량비중	double	6.2")] double ftradmsrate, [Description("외국계증권사매도거래량직전대비	string	10")] string ftradmdcha, [Description("외국계증권사매수거래량직전대비	string	10")] string ftradmscha, [Description("단축코드	string	6")] string shcode, [Description("매도거래대금1	long	15")] long tradmdval1, [Description("매수거래대금1	long	15")] long tradmsval1, [Description("매도평균단가1	int	7")] int tradmdavg1, [Description("매수평균단가1	int	7")] int tradmsavg1, [Description("매도거래대금2	long	15")] long tradmdval2, [Description("매수거래대금2	long	15")] long tradmsval2, [Description("매도평균단가2	int	7")] int tradmdavg2, [Description("매수평균단가2	int	7")] int tradmsavg2, [Description("매도거래대금3	long	15")] long tradmdval3, [Description("매수거래대금3	long	15")] long tradmsval3, [Description("매도평균단가3	int	7")] int tradmdavg3, [Description("매수평균단가3	int	7")] int tradmsavg3, [Description("매도거래대금4	long	15")] long tradmdval4, [Description("매수거래대금4	long	15")] long tradmsval4, [Description("매도평균단가4	int	7")] int tradmdavg4, [Description("매수평균단가4	int	7")] int tradmsavg4, [Description("매도거래대금5	long	15")] long tradmdval5, [Description("매수거래대금5	long	15")] long tradmsval5, [Description("매도평균단가5	int	7")] int tradmdavg5, [Description("매수평균단가5	int	7")] int tradmsavg5, [Description("외국계증권사매도거래대금	long	15")] long ftradmdval, [Description("외국계증권사매수거래대금	long	15")] long ftradmsval, [Description("외국계증권사매도평균단가	int	7")] int ftradmdavg, [Description("외국계증권사매수평균단가	int	7")] int ftradmsavg);

/// <summary>
/// ELW거래원: k1_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record k1_InBlock([Description("단축코드	string	6")] string shcode);

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
public record k1_OutBlock([Description("매도증권사코드1	string	3")] string offerno1, [Description("매수증권사코드1	string	3")] string bidno1, [Description("매도회원사명1	string	6")] string offertrad1, [Description("매수회원사명1	string	6")] string bidtrad1, [Description("매도거래량1	long	10")] long tradmdvol1, [Description("매수거래량1	long	10")] long tradmsvol1, [Description("매도거래량비중1	double	6.2")] double tradmdrate1, [Description("매도거래량비중1	double	6.2")] double tradmsrate1, [Description("매도거래량직전대비1	long	10")] long tradmdcha1, [Description("매수거래량직전대비1	long	10")] long tradmscha1, [Description("매도증권사코드2	string	3")] string offerno2, [Description("매수증권사코드2	string	3")] string bidno2, [Description("매도회원사명2	string	6")] string offertrad2, [Description("매수회원사명2	string	6")] string bidtrad2, [Description("매도거래량2	long	10")] long tradmdvol2, [Description("매수거래량2	long	10")] long tradmsvol2, [Description("매도거래량비중2	double	6.2")] double tradmdrate2, [Description("매수거래량비중2	double	6.2")] double tradmsrate2, [Description("매도거래량직전대비2	long	10")] long tradmdcha2, [Description("매수거래량직전대비2	long	10")] long tradmscha2, [Description("매도증권사코드3	string	3")] string offerno3, [Description("매수증권사코드3	string	3")] string bidno3, [Description("매도회원사명3	string	6")] string offertrad3, [Description("매수회원사명3	string	6")] string bidtrad3, [Description("매도거래량3	long	10")] long tradmdvol3, [Description("매수거래량3	long	10")] long tradmsvol3, [Description("매도거래량비중3	double	6.2")] double tradmdrate3, [Description("매수거래량비중3	double	6.2")] double tradmsrate3, [Description("매도거래량직전대비3	long	10")] long tradmdcha3, [Description("매수거래량직전대비3	long	10")] long tradmscha3, [Description("매도증권사코드4	string	3")] string offerno4, [Description("매수증권사코드4	string	3")] string bidno4, [Description("매도회원사명4	string	6")] string offertrad4, [Description("매수회원사명4	string	6")] string bidtrad4, [Description("매도거래량4	long	10")] long tradmdvol4, [Description("매수거래량4	long	10")] long tradmsvol4, [Description("매도거래량비중4	double	6.2")] double tradmdrate4, [Description("매수거래량비중4	double	6.2")] double tradmsrate4, [Description("매도거래량직전대비4	long	10")] long tradmdcha4, [Description("매수거래량직전대비4	long	10")] long tradmscha4, [Description("매도증권사코드5	string	3")] string offerno5, [Description("매수증권사코드5	string	3")] string bidno5, [Description("매도회원사명5	string	6")] string offertrad5, [Description("매수회원사명5	string	6")] string bidtrad5, [Description("매도거래량5	long	10")] long tradmdvol5, [Description("매수거래량5	long	10")] long tradmsvol5, [Description("매도거래량비중5	double	6.2")] double tradmdrate5, [Description("매수거래량비중5	double	6.2")] double tradmsrate5, [Description("매도거래량직전대비5	long	10")] long tradmdcha5, [Description("매수거래량직전대비5	long	10")] long tradmscha5, [Description("외국계증권사매도합계	string	10")] string ftradmdvol, [Description("외국계증권사매수합계	string	10")] string ftradmsvol, [Description("외국계증권사매도거래량비중	double	6.2")] double ftradmdrate, [Description("외국계증권사매수거래량비중	double	6.2")] double ftradmsrate, [Description("외국계증권사매도거래량직전대비	string	10")] string ftradmdcha, [Description("외국계증권사매수거래량직전대비	string	10")] string ftradmscha, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ체결: K3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record K3_InBlock([Description("단축코드	string	6")] string shcode);

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
public record K3_OutBlock([Description("체결시간	string	6")] string chetime, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("현재가	int	8")] int price, [Description("시가시간	string	6")] string opentime, [Description("시가	int	8")] int open, [Description("고가시간	string	6")] string hightime, [Description("고가	int	8")] int high, [Description("저가시간	string	6")] string lowtime, [Description("저가	int	8")] int low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	8")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("가중평균가	int	8")] int w_avrg, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("장정보	string	2")] string status, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ프로그램매매종목별: KH_
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record KH_InBlock([Description("종목코드	string	6")] string shcode);

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
public record KH_OutBlock([Description("수신시간	string	6")] string time, [Description("현재가	int	8")] int price, [Description("전일대비구분	int	1")] int sign, [Description("전일대비	int	8")] int change, [Description("누적거래량	long	10")] long volume, [Description("등락율	double	6.2")] double drate, [Description("차익매도호가 잔량	long	12")] long cdhrem, [Description("차익매수호가 잔량	long	12")] long cshrem, [Description("비차익매도호가 잔량	long	12")] long bdhrem, [Description("비차익매수호가 잔량	long	12")] long bshrem, [Description("차익매도호가 수량	long	12")] long cdhvolume, [Description("차익매수호가 수량	long	12")] long cshvolume, [Description("비차익매도호가 수량	long	12")] long bdhvolume, [Description("비차익매수호가 수량	long	12")] long bshvolume, [Description("전체매도위탁체결수량	long	12")] long dwcvolume, [Description("전체매수위탁체결수량	long	12")] long swcvolume, [Description("전체매도자기체결수량	long	12")] long djcvolume, [Description("전체매수자기체결수량	long	12")] long sjcvolume, [Description("전체매도체결수량	long	12")] long tdvolume, [Description("전체매수체결수량	long	12")] long tsvolume, [Description("전체순매수 수량	long	12")] long tvol, [Description("전체매도위탁체결금액	long	15")] long dwcvalue, [Description("전체매수위탁체결금액	long	15")] long swcvalue, [Description("전체매도자기체결금액	long	15")] long djcvalue, [Description("전체매수자기체결금액	long	15")] long sjcvalue, [Description("전체매도체결금액	long	15")] long tdvalue, [Description("전체매수체결금액	long	15")] long tsvalue, [Description("전체순매수 금액	long	15")] long tval, [Description("매도 사전공시수량	long	12")] long pdgvolume, [Description("매수 사전공시수량	long	12")] long psgvolume, [Description("종목코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ프로그램매매전체집계: KM_
/// </summary>
/// <param name="gubun">구분값	string	1</param>
public record KM_InBlock([Description("구분값	string	1")] string gubun);

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
public record KM_OutBlock([Description("수신시간	string	6")] string time, [Description("차익매도호가 잔량	int	6")] int cdhrem, [Description("차익매수호가 잔량	int	6")] int cshrem, [Description("비차익매도호가 잔량	int	6")] int bdhrem, [Description("비차익매수호가 잔량	int	6")] int bshrem, [Description("차익매도호가 수량	int	6")] int cdhvolume, [Description("차익매수호가 수량	int	6")] int cshvolume, [Description("비차익매도호가 수량	int	6")] int bdhvolume, [Description("비차익매수호가 수량	int	6")] int bshvolume, [Description("차익매도위탁체결수량	int	6")] int cdwvolume, [Description("차익매도자기체결수량	int	6")] int cdjvolume, [Description("차익매수위탁체결수량	int	6")] int cswvolume, [Description("차익매수자기체결수량	int	6")] int csjvolume, [Description("차익위탁순매수 수량	int	6")] int cwvol, [Description("차익자기순매수 수량	int	6")] int cjvol, [Description("비차익매도위탁체결수량	int	6")] int bdwvolume, [Description("비차익매도자기체결수량	int	6")] int bdjvolume, [Description("비차익매수위탁체결수량	int	6")] int bswvolume, [Description("비차익매수자기체결수량	int	6")] int bsjvolume, [Description("비차익위탁순매수 수량	int	6")] int bwvol, [Description("비차익자기순매수 수량	int	6")] int bjvol, [Description("전체매도위탁체결수량	int	6")] int dwvolume, [Description("전체매수위탁체결수량	int	6")] int swvolume, [Description("전체위탁순매수 수량	int	6")] int wvol, [Description("전체매도자기체결수량	int	6")] int djvolume, [Description("전체매수자기체결수량	int	6")] int sjvolume, [Description("전체자기순매수 수량	int	6")] int jvol, [Description("차익매도위탁체결금액	int	8")] int cdwvalue, [Description("차익매도자기체결금액	int	8")] int cdjvalue, [Description("차익매수위탁체결금액	int	8")] int cswvalue, [Description("차익매수자기체결금액	int	8")] int csjvalue, [Description("차익위탁순매수 금액	int	8")] int cwval, [Description("차익자기순매수 금액	int	8")] int cjval, [Description("비차익매도위탁체결금액	int	8")] int bdwvalue, [Description("비차익매도자기체결금액	int	8")] int bdjvalue, [Description("비차익매수위탁체결금액	int	8")] int bswvalue, [Description("비차익매수자기체결금액	int	8")] int bsjvalue, [Description("비차익위탁순매수 금액	int	8")] int bwval, [Description("비차익자기순매수 금액	int	8")] int bjval, [Description("전체매도위탁체결금액	int	8")] int dwvalue, [Description("전체매수위탁체결금액	int	8")] int swvalue, [Description("전체위탁순매수 금액	int	8")] int wval, [Description("전체매도자기체결금액	int	8")] int djvalue, [Description("전체매수자기체결금액	int	8")] int sjvalue, [Description("전체자기순매수 금액	int	8")] int jval, [Description("KOSDAQ50 지수	double	6.2")] double k50jisu, [Description("KOSDAQ50 전일대비구분	string	1")] string k50sign, [Description("KOSDAQ50 전일대비	double	6.2")] double change, [Description("KOSDAQ50 베이시스	double	4.2")] double k50basis, [Description("차익매도체결수량합계	int	6")] int cdvolume, [Description("차익매수체결수량합계	int	6")] int csvolume, [Description("차익순매수 수량합계	int	6")] int cvol, [Description("비차익매도체결수량합계	int	6")] int bdvolume, [Description("비차익매수체결수량합계	int	6")] int bsvolume, [Description("비차익순매수 수량합계	int	6")] int bvol, [Description("전체매도체결수량합계	int	6")] int tdvolume, [Description("전체매수체결수량합계	int	6")] int tsvolume, [Description("전체순매수 수량합계	int	6")] int tvol, [Description("차익매도체결금액합계	int	8")] int cdvalue, [Description("차익매수체결금액합계	int	8")] int csvalue, [Description("차익순매수 금액합계	int	8")] int cval, [Description("비차익매도체결금액합계	int	8")] int bdvalue, [Description("비차익매수체결금액합계	int	8")] int bsvalue, [Description("비차익순매수 금액합계	int	8")] int bval, [Description("전체매도체결금액합계	int	8")] int tdvalue, [Description("전체매수체결금액합계	int	8")] int tsvalue, [Description("전체순매수 금액합계	int	8")] int tval, [Description("차익매도체결수량직전대비	int	6")] int p_cdvolcha, [Description("차익매수체결수량직전대비	int	6")] int p_csvolcha, [Description("차익순매수 수량직전대비	int	6")] int p_cvolcha, [Description("비차익매도체결수량직전대비	int	6")] int p_bdvolcha, [Description("비차익매수체결수량직전대비	int	6")] int p_bsvolcha, [Description("비차익순매수 수량직전대비	int	6")] int p_bvolcha, [Description("전체매도체결수량직전대비	int	6")] int p_tdvolcha, [Description("전체매수체결수량직전대비	int	6")] int p_tsvolcha, [Description("전체순매수 수량직전대비	int	6")] int p_tvolcha, [Description("차익매도체결금액직전대비	int	8")] int p_cdvalcha, [Description("차익매수체결금액직전대비	int	8")] int p_csvalcha, [Description("차익순매수 금액직전대비	int	8")] int p_cvalcha, [Description("비차익매도체결금액직전대비	int	8")] int p_bdvalcha, [Description("비차익매수체결금액직전대비	int	8")] int p_bsvalcha, [Description("비차익순매수 금액직전대비	int	8")] int p_bvalcha, [Description("전체매도체결금액직전대비	int	8")] int p_tdvalcha, [Description("전체매수체결금액직전대비	int	8")] int p_tsvalcha, [Description("전체순매수 금액직전대비	int	8")] int p_tvalcha, [Description("구분값	string	1")] string gubun);

/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record KS_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSDAQ우선호가: KS_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
public record KS_OutBlock([Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// US지수: MK2
/// </summary>
/// <param name="symbol">심볼코드	string	16</param>
public record MK2InBlock([Description("심볼코드	string	16")] string symbol);

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
public record MK2OutBlock([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("한국일자	string	8")] string kodate, [Description("한국시간	string	6")] string kotime, [Description("시가	double	9.2")] double open, [Description("고가	double	9.2")] double high, [Description("저가	double	9.2")] double low, [Description("현재가	double	9.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	9.2")] double change, [Description("등락율	double	9.2")] double uprate, [Description("매수호가	double	9.2")] double bidho, [Description("매수잔량	long	9")] long bidrem, [Description("매도호가	double	9.2")] double offerho, [Description("매도잔량	long	9")] long offerrem, [Description("누적거래량	double	12")] double volume, [Description("심벌	string	16")] string xsymbol, [Description("체결거래량	double	8")] double cvolume);

/// <summary>
/// 실시간 뉴스 제목 패킷: NWS
/// </summary>
/// <param name="nwcode">뉴스코드	string	6</param>
public record NWSInBlock([Description("뉴스코드	string	6")] string nwcode);

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
public record NWSOutBlock([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("뉴스구분자	string	2")] string id, [Description("키값	string	24")] string realkey, [Description("제목	string	300")] string title, [Description("단축종목코드	string	240")] string code, [Description("BODY길이	int	8")] int bodysize);

/// <summary>
/// 선물접수: O01
/// </summary>
public record O01InBlock();

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
public record O01OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("tr코드	string	4")] string trcode1, [Description("회사번호	string	3")] string firmno, [Description("계좌번호	string	11")] string acntno, [Description("계좌번호	string	9")] string acntno1, [Description("계좌명	string	40")] string acntnm, [Description("지점번호	string	3")] string brnno, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문번호	string	3")] string ordno1, [Description("주문번호	int	7")] int ordno, [Description("원주문번호	string	3")] string orgordno1, [Description("원주문번호	int	7")] int orgordno, [Description("모주문번호	string	3")] string prntordno, [Description("모주문번호	int	7")] int prntordno1, [Description("종목번호	string	12")] string isuno, [Description("선물옵션종목번호	string	8")] string fnoIsuno, [Description("선물옵션종목명	string	40")] string fnoIsunm, [Description("상품군분류코드	string	2")] string pdgrpcode, [Description("선물옵션종목유형구분	string	1")] string fnoIsuptntp, [Description("매매구분	string	1")] string bnstp, [Description("정정취소구분	string	1")] string mrctp, [Description("주문수량	long	16")] long ordqty, [Description("호가유형코드	string	2")] string hogatype, [Description("거래유형코드	string	2")] string mmgb, [Description("주문가격	double	13.2")] double ordprc, [Description("미체결수량	long	16")] long unercqty, [Description("통신매체	string	2")] string commdacode, [Description("수수료합산코드	string	2")] string peeamtcode, [Description("관리사원	string	9")] string mgempno, [Description("선물옵션거래단위금액	double	19.8")] double fnotrdunitamt, [Description("처리시각	string	9")] string trxtime, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	string	10")] string ordseqno, [Description("포트폴리오 번호	string	10")] string ptflno, [Description("바스켓번호	string	10")] string bskno, [Description("트렌치번호	string	10")] string trchno, [Description("아이템번호	string	10")] string Itemno, [Description("주문자Id	string	16")] string userId, [Description("운영지시번호	string	12")] string opdrtnno, [Description("부적격코드	string	3")] string rjtcode, [Description("정정취소확인수량	long	16")] long mrccnfqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정취소수량	long	16")] long orgordmrcqty, [Description("약정시각(체결시각)	string	8")] string ctrcttime, [Description("약정번호	string	10")] string ctrctno, [Description("체결가격	double	13.2")] double execprc, [Description("체결수량	long	16")] long execqty, [Description("신규체결수량	long	16")] long newqty, [Description("청산체결수량	long	16")] long qdtqty, [Description("최종결제수량	long	16")] long lastqty, [Description("전체체결수량	long	16")] long lallexecqty, [Description("전체체결금액	long	16")] long allexecamt, [Description("잔고평가구분	string	1")] string fnobalevaltp, [Description("매매손익금액	long	16")] long bnsplamt, [Description("선물옵션종목번호1	string	8")] string fnoIsuno1, [Description("매매구분1	string	1")] string bnstp1, [Description("체결가1	double	13.2")] double execprc1, [Description("신규체결수량1	long	16")] long newqty1, [Description("청산체결수량1	long	16")] long qdtqty1, [Description("전체체결금액1	long	16")] long allexecamt1, [Description("선물옵션종목번호2	string	8")] string fnoIsuno2, [Description("매매구분2	string	1")] string bnstp2, [Description("체결가2	double	13.2")] double execprc2, [Description("신규체결수량2	long	16")] long newqty2, [Description("청산체결수량2	long	16")] long lqdtqty2, [Description("전체체결금액2	long	16")] long allexecamt2, [Description("예수금	long	16")] long dps, [Description("선물대용지정금액	long	16")] long ftsubtdsgnamt, [Description("증거금	long	16")] long mgn, [Description("증거금현금	long	16")] long mnymgn, [Description("주문가능금액	long	16")] long ordableamt, [Description("주문가능현금액	long	16")] long mnyordableamt, [Description("잔고 종목번호1	string	8")] string fnoIsuno_1, [Description("잔고 매매구분1	string	1")] string bnstp_1, [Description("미결제수량1	long	16")] long unsttqty_1, [Description("주문가능수량1	long	16")] long lqdtableqty_1, [Description("평균가1	double	13.2")] double avrprc_1, [Description("잔고 종목번호2	string	8")] string fnoIsuno_2, [Description("잔고 매매구분2	string	1")] string bnstp_2, [Description("미결제수량2	long	16")] long unsttqty_2, [Description("주문가능수량2	long	16")] long lqdtableqty_2, [Description("평균가2	double	13.2")] double avrprc_2);

/// <summary>
/// KOSPI200옵션체결(C0): OC0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record OC0InBlock([Description("단축코드	string	8")] string optcode);

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
public record OC0OutBlock([Description("체결시간	string	6")] string chetime, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double drate, [Description("현재가	double	6.2")] double price, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	6")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("미결제약정수량	int	8")] int openyak, [Description("KOSPI200지수	double	6.2")] double k200jisu, [Description("KOSPI등가	double	7.2")] double eqva, [Description("이론가	double	6.2")] double theoryprice, [Description("내재변동성	double	6.2")] double impv, [Description("미결제약정증감	int	8")] int openyakcha, [Description("시간가치	double	6.2")] double timevalue, [Description("장운영정보	string	2")] string jgubun, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("단축코드	string	8")] string optcode);

/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record OD0InBlock([Description("단축코드	string	8")] string optcode);

/// <summary>
/// KOSPI200옵션실시간상하한가(D0): OD0
/// </summary>
/// <param name="gubun">접속매매여부	string	1</param>
/// <param name="dy_gubun">실시간가격제한여부	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	8.2</param>
/// <param name="opttcode">단축코드	string	8</param>
public record OD0OutBlock([Description("접속매매여부	string	1")] string gubun, [Description("실시간가격제한여부	string	1")] string dy_gubun, [Description("실시간상한가	double	8.2")] double dy_uplmtprice, [Description("실시간하한가	double	8.2")] double dy_dnlmtprice, [Description("단축코드	string	8")] string opttcode);

/// <summary>
/// KOSPI200옵션호가(H0): OH0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record OH0InBlock([Description("단축코드	string	8")] string optcode);

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
public record OH0OutBlock([Description("호가시간	string	6")] string hotime, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("매도호가수량1	int	7")] int offerrem1, [Description("매수호가수량1	int	7")] int bidrem1, [Description("매도호가건수1	int	5")] int offercnt1, [Description("매수호가건수1	int	5")] int bidcnt1, [Description("매도호가2	double	6.2")] double offerho2, [Description("매수호가2	double	6.2")] double bidho2, [Description("매도호가수량2	int	7")] int offerrem2, [Description("매수호가수량2	int	7")] int bidrem2, [Description("매도호가건수2	int	5")] int offercnt2, [Description("매수호가건수2	int	5")] int bidcnt2, [Description("매도호가3	double	6.2")] double offerho3, [Description("매수호가3	double	6.2")] double bidho3, [Description("매도호가수량3	int	7")] int offerrem3, [Description("매수호가수량3	int	7")] int bidrem3, [Description("매도호가건수3	int	5")] int offercnt3, [Description("매수호가건수3	int	5")] int bidcnt3, [Description("매도호가4	double	6.2")] double offerho4, [Description("매수호가4	double	6.2")] double bidho4, [Description("매도호가수량4	int	7")] int offerrem4, [Description("매수호가수량4	int	7")] int bidrem4, [Description("매도호가건수4	int	5")] int offercnt4, [Description("매수호가건수4	int	5")] int bidcnt4, [Description("매도호가5	double	6.2")] double offerho5, [Description("매수호가5	double	6.2")] double bidho5, [Description("매도호가수량5	int	7")] int offerrem5, [Description("매수호가수량5	int	7")] int bidrem5, [Description("매도호가건수5	int	5")] int offercnt5, [Description("매수호가건수5	int	5")] int bidcnt5, [Description("매도호가총수량	int	7")] int totofferrem, [Description("매수호가총수량	int	7")] int totbidrem, [Description("매도호가총건수	int	5")] int totoffercnt, [Description("매수호가총건수	int	5")] int totbidcnt, [Description("단축코드	string	8")] string optcode, [Description("단일가호가여부	string	1")] string danhochk, [Description("배분적용구분	string	1")] string alloc_gubun);

/// <summary>
/// KOSDAQ거래원: OK_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record OK_InBlock([Description("단축코드	string	6")] string shcode);

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
public record OK_OutBlock([Description("매도증권사코드1	string	3")] string offerno1, [Description("매수증권사코드1	string	3")] string bidno1, [Description("매도회원사명1	string	6")] string offertrad1, [Description("매수회원사명1	string	6")] string bidtrad1, [Description("매도거래량1	long	10")] long tradmdvol1, [Description("매수거래량1	long	10")] long tradmsvol1, [Description("매도거래량비중1	double	6.2")] double tradmdrate1, [Description("매도거래량비중1	double	6.2")] double tradmsrate1, [Description("매도거래량직전대비1	long	10")] long tradmdcha1, [Description("매수거래량직전대비1	long	10")] long tradmscha1, [Description("매도증권사코드2	string	3")] string offerno2, [Description("매수증권사코드2	string	3")] string bidno2, [Description("매도회원사명2	string	6")] string offertrad2, [Description("매수회원사명2	string	6")] string bidtrad2, [Description("매도거래량2	long	10")] long tradmdvol2, [Description("매수거래량2	long	10")] long tradmsvol2, [Description("매도거래량비중2	double	6.2")] double tradmdrate2, [Description("매수거래량비중2	double	6.2")] double tradmsrate2, [Description("매도거래량직전대비2	long	10")] long tradmdcha2, [Description("매수거래량직전대비2	long	10")] long tradmscha2, [Description("매도증권사코드3	string	3")] string offerno3, [Description("매수증권사코드3	string	3")] string bidno3, [Description("매도회원사명3	string	6")] string offertrad3, [Description("매수회원사명3	string	6")] string bidtrad3, [Description("매도거래량3	long	10")] long tradmdvol3, [Description("매수거래량3	long	10")] long tradmsvol3, [Description("매도거래량비중3	double	6.2")] double tradmdrate3, [Description("매수거래량비중3	double	6.2")] double tradmsrate3, [Description("매도거래량직전대비3	long	10")] long tradmdcha3, [Description("매수거래량직전대비3	long	10")] long tradmscha3, [Description("매도증권사코드4	string	3")] string offerno4, [Description("매수증권사코드4	string	3")] string bidno4, [Description("매도회원사명4	string	6")] string offertrad4, [Description("매수회원사명4	string	6")] string bidtrad4, [Description("매도거래량4	long	10")] long tradmdvol4, [Description("매수거래량4	long	10")] long tradmsvol4, [Description("매도거래량비중4	double	6.2")] double tradmdrate4, [Description("매수거래량비중4	double	6.2")] double tradmsrate4, [Description("매도거래량직전대비4	long	10")] long tradmdcha4, [Description("매수거래량직전대비4	long	10")] long tradmscha4, [Description("매도증권사코드5	string	3")] string offerno5, [Description("매수증권사코드5	string	3")] string bidno5, [Description("매도회원사명5	string	6")] string offertrad5, [Description("매수회원사명5	string	6")] string bidtrad5, [Description("매도거래량5	long	10")] long tradmdvol5, [Description("매수거래량5	long	10")] long tradmsvol5, [Description("매도거래량비중5	double	6.2")] double tradmdrate5, [Description("매수거래량비중5	double	6.2")] double tradmsrate5, [Description("매도거래량직전대비5	long	10")] long tradmdcha5, [Description("매수거래량직전대비5	long	10")] long tradmscha5, [Description("외국계증권사매도합계	string	10")] string ftradmdvol, [Description("외국계증권사매수합계	string	10")] string ftradmsvol, [Description("외국계증권사매도거래량비중	double	6.2")] double ftradmdrate, [Description("외국계증권사매수거래량비중	double	6.2")] double ftradmsrate, [Description("외국계증권사매도거래량직전대비	string	10")] string ftradmdcha, [Description("외국계증권사매수거래량직전대비	string	10")] string ftradmscha, [Description("단축코드	string	6")] string shcode, [Description("매도거래대금1	long	15")] long tradmdval1, [Description("매수거래대금1	long	15")] long tradmsval1, [Description("매도평균단가1	int	7")] int tradmdavg1, [Description("매수평균단가1	int	7")] int tradmsavg1, [Description("매도거래대금2	long	15")] long tradmdval2, [Description("매수거래대금2	long	15")] long tradmsval2, [Description("매도평균단가2	int	7")] int tradmdavg2, [Description("매수평균단가2	int	7")] int tradmsavg2, [Description("매도거래대금3	long	15")] long tradmdval3, [Description("매수거래대금3	long	15")] long tradmsval3, [Description("매도평균단가3	int	7")] int tradmdavg3, [Description("매수평균단가3	int	7")] int tradmsavg3, [Description("매도거래대금4	long	15")] long tradmdval4, [Description("매수거래대금4	long	15")] long tradmsval4, [Description("매도평균단가4	int	7")] int tradmdavg4, [Description("매수평균단가4	int	7")] int tradmsavg4, [Description("매도거래대금5	long	15")] long tradmdval5, [Description("매수거래대금5	long	15")] long tradmsval5, [Description("매도평균단가5	int	7")] int tradmdavg5, [Description("매수평균단가5	int	7")] int tradmsavg5, [Description("외국계증권사매도거래대금	long	15")] long ftradmdval, [Description("외국계증권사매수거래대금	long	15")] long ftradmsval, [Description("외국계증권사매도평균단가	int	7")] int ftradmdavg, [Description("외국계증권사매수평균단가	int	7")] int ftradmsavg);

/// <summary>
/// KOSPI200옵션민감도(MG): OMG
/// </summary>
/// <param name="optcode">옵션코드	string	8</param>
public record OMGInBlock([Description("옵션코드	string	8")] string optcode);

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
public record OMGOutBlock([Description("체결시간	string	6")] string chetime, [Description("행사가	double	6.2")] double actprice, [Description("KOSPI200지수	double	6.2")] double k200jisu, [Description("선물가격	double	6.2")] double fut200jisu, [Description("현재가	double	6.2")] double price, [Description("대표내재변동성	double	6.2")] double capimpv, [Description("내재변동성	double	6.2")] double impv, [Description("델타(블랙숄즈)	double	7.4")] double delt, [Description("감마(블랙숄즈)	double	7.4")] double gama, [Description("세타(블랙숄즈)	double	7.4")] double ceta, [Description("베가(블랙숄즈)	double	7.4")] double vega, [Description("로우(블랙숄즈)	double	7.4")] double rhox, [Description("이론가(블랙숄즈)	double	6.2")] double theoryprice, [Description("전일가내재변동성	double	6.2")] double bimpv, [Description("매도가내재변동성	double	6.2")] double offerimpv, [Description("매수가내재변동성	double	6.2")] double bidimpv, [Description("옵션코드	string	8")] string optcode);

/// <summary>
/// 해외선물 현재가체결: OVC
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
public record OVCInBlock([Description("종목코드	string	8")] string symbol);

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
public record OVCOutBlock([Description("종목코드	string	8")] string symbol, [Description("체결일자(현지)	string	8")] string ovsdate, [Description("체결일자(한국)	string	8")] string kordate, [Description("체결시간(현지)	string	6")] string trdtm, [Description("체결시간(한국)	string	6")] string kortm, [Description("체결가격	double	15.9")] double curpr, [Description("전일대비	double	15.9")] double ydiffpr, [Description("전일대비기호	string	1")] string ydiffSign, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("등락율	double	6.2")] double chgrate, [Description("건별체결수량	long	10")] long trdq, [Description("누적체결수량	string	15")] string totq, [Description("체결구분	string	1")] string cgubun, [Description("매도누적체결수량	string	15")] string mdvolume, [Description("매수누적체결수량	string	15")] string msvolume, [Description("장마감일	string	8")] string ovsmkend);

/// <summary>
/// 해외선물 호가: OVH
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
public record OVHInBlock([Description("종목코드	string	8")] string symbol);

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
public record OVHOutBlock([Description("종목코드	string	8")] string symbol, [Description("호가시간	string	6")] string hotime, [Description("매도호가 1	double	15.9")] double offerho1, [Description("매수호가 1	double	15.9")] double bidho1, [Description("매도호가 잔량 1	long	10")] long offerrem1, [Description("매수호가 잔량 1	long	10")] long bidrem1, [Description("매도호가 건수 1	long	10")] long offerno1, [Description("매수호가 건수 1	long	10")] long bidno1, [Description("매도호가 2	double	15.9")] double offerho2, [Description("매수호가 2	double	15.9")] double bidho2, [Description("매도호가 잔량 2	long	10")] long offerrem2, [Description("매수호가 잔량 2	long	10")] long bidrem2, [Description("매도호가 건수 2	long	10")] long offerno2, [Description("매수호가 건수 2	long	10")] long bidno2, [Description("매도호가 3	double	15.9")] double offerho3, [Description("매수호가 3	double	15.9")] double bidho3, [Description("매도호가 잔량 3	long	10")] long offerrem3, [Description("매수호가 잔량 3	long	10")] long bidrem3, [Description("매도호가 건수 3	long	10")] long offerno3, [Description("매수호가 건수 3	long	10")] long bidno3, [Description("매도호가 4	double	15.9")] double offerho4, [Description("매수호가 4	double	15.9")] double bidho4, [Description("매도호가 잔량 4	long	10")] long offerrem4, [Description("매수호가 잔량 4	long	10")] long bidrem4, [Description("매도호가 건수 4	long	10")] long offerno4, [Description("매수호가 건수 4	long	10")] long bidno4, [Description("매도호가 5	double	15.9")] double offerho5, [Description("매수호가 5	double	15.9")] double bidho5, [Description("매도호가 잔량 5	long	10")] long offerrem5, [Description("매수호가 잔량 5	long	10")] long bidrem5, [Description("매도호가 건수 5	long	10")] long offerno5, [Description("매수호가 건수 5	long	10")] long bidno5, [Description("매도호가총건수	long	10")] long totoffercnt, [Description("매수호가총건수	long	10")] long totbidcnt, [Description("매도호가총수량	long	10")] long totofferrem, [Description("매수호가총수량	long	10")] long totbidrem);

/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record OX0InBlock([Description("단축코드	string	8")] string optcode);

/// <summary>
/// KOSPI200옵션가격제한폭확대(X0): OX0
/// </summary>
/// <param name="upstep">적용 상한단계	string	2</param>
/// <param name="dnstep">적용 하한단계	string	2</param>
/// <param name="uplmtprice">적용 상한가	double	6.2</param>
/// <param name="dnlmtprice">적용 하한가	double	6.2</param>
/// <param name="opttcode">단축코드	string	8</param>
public record OX0OutBlock([Description("적용 상한단계	string	2")] string upstep, [Description("적용 하한단계	string	2")] string dnstep, [Description("적용 상한가	double	6.2")] double uplmtprice, [Description("적용 하한가	double	6.2")] double dnlmtprice, [Description("단축코드	string	8")] string opttcode);

/// <summary>
/// KOSPI프로그램매매종목별: PH_
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record PH_InBlock([Description("종목코드	string	6")] string shcode);

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
public record PH_OutBlock([Description("수신시간	string	6")] string time, [Description("현재가	int	8")] int price, [Description("전일대비구분	int	1")] int sign, [Description("전일대비	int	8")] int change, [Description("누적거래량	long	10")] long volume, [Description("등락율	double	6.2")] double drate, [Description("차익매도호가 잔량	long	12")] long cdhrem, [Description("차익매수호가 잔량	long	12")] long cshrem, [Description("비차익매도호가 잔량	long	12")] long bdhrem, [Description("비차익매수호가 잔량	long	12")] long bshrem, [Description("차익매도호가 수량	long	12")] long cdhvolume, [Description("차익매수호가 수량	long	12")] long cshvolume, [Description("비차익매도호가 수량	long	12")] long bdhvolume, [Description("비차익매수호가 수량	long	12")] long bshvolume, [Description("전체매도위탁체결수량	long	12")] long dwcvolume, [Description("전체매수위탁체결수량	long	12")] long swcvolume, [Description("전체매도자기체결수량	long	12")] long djcvolume, [Description("전체매수자기체결수량	long	12")] long sjcvolume, [Description("전체매도체결수량	long	12")] long tdvolume, [Description("전체매수체결수량	long	12")] long tsvolume, [Description("전체순매수 수량	long	12")] long tvol, [Description("전체매도위탁체결금액	long	15")] long dwcvalue, [Description("전체매수위탁체결금액	long	15")] long swcvalue, [Description("전체매도자기체결금액	long	15")] long djcvalue, [Description("전체매수자기체결금액	long	15")] long sjcvalue, [Description("전체매도체결금액	long	15")] long tdvalue, [Description("전체매수체결금액	long	15")] long tsvalue, [Description("전체순매수 금액	long	15")] long tval, [Description("매도 사전공시수량	long	12")] long pdgvolume, [Description("매수 사전공시수량	long	12")] long psgvolume, [Description("종목코드	string	6")] string shcode);

/// <summary>
/// KOSPI프로그램매매전체집계: PM_
/// </summary>
/// <param name="gubun">구분값	string	1</param>
public record PM_InBlock([Description("구분값	string	1")] string gubun);

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
public record PM_OutBlock([Description("수신시간	string	6")] string time, [Description("차익매도호가 잔량	int	6")] int cdhrem, [Description("차익매수호가 잔량	int	6")] int cshrem, [Description("비차익매도호가 잔량	int	6")] int bdhrem, [Description("비차익매수호가 잔량	int	6")] int bshrem, [Description("차익매도호가 수량	int	6")] int cdhvolume, [Description("차익매수호가 수량	int	6")] int cshvolume, [Description("비차익매도호가 수량	int	6")] int bdhvolume, [Description("비차익매수호가 수량	int	6")] int bshvolume, [Description("차익매도위탁체결수량	int	6")] int cdwvolume, [Description("차익매도자기체결수량	int	6")] int cdjvolume, [Description("차익매수위탁체결수량	int	6")] int cswvolume, [Description("차익매수자기체결수량	int	6")] int csjvolume, [Description("차익위탁순매수 수량	int	6")] int cwvol, [Description("차익자기순매수 수량	int	6")] int cjvol, [Description("비차익매도위탁체결수량	int	6")] int bdwvolume, [Description("비차익매도자기체결수량	int	6")] int bdjvolume, [Description("비차익매수위탁체결수량	int	6")] int bswvolume, [Description("비차익매수자기체결수량	int	6")] int bsjvolume, [Description("비차익위탁순매수 수량	int	6")] int bwvol, [Description("비차익자기순매수 수량	int	6")] int bjvol, [Description("전체매도위탁체결수량	int	6")] int dwvolume, [Description("전체매수위탁체결수량	int	6")] int swvolume, [Description("전체위탁순매수 수량	int	6")] int wvol, [Description("전체매도자기체결수량	int	6")] int djvolume, [Description("전체매수자기체결수량	int	6")] int sjvolume, [Description("전체자기순매수 수량	int	6")] int jvol, [Description("차익매도위탁체결금액	int	8")] int cdwvalue, [Description("차익매도자기체결금액	int	8")] int cdjvalue, [Description("차익매수위탁체결금액	int	8")] int cswvalue, [Description("차익매수자기체결금액	int	8")] int csjvalue, [Description("차익위탁순매수 금액	int	8")] int cwval, [Description("차익자기순매수 금액	int	8")] int cjval, [Description("비차익매도위탁체결금액	int	8")] int bdwvalue, [Description("비차익매도자기체결금액	int	8")] int bdjvalue, [Description("비차익매수위탁체결금액	int	8")] int bswvalue, [Description("비차익매수자기체결금액	int	8")] int bsjvalue, [Description("비차익위탁순매수 금액	int	8")] int bwval, [Description("비차익자기순매수 금액	int	8")] int bjval, [Description("전체매도위탁체결금액	int	8")] int dwvalue, [Description("전체매수위탁체결금액	int	8")] int swvalue, [Description("전체위탁순매수 금액	int	8")] int wval, [Description("전체매도자기체결금액	int	8")] int djvalue, [Description("전체매수자기체결금액	int	8")] int sjvalue, [Description("전체자기순매수 금액	int	8")] int jval, [Description("KOSPI200 지수	double	6.2")] double k200jisu, [Description("KOSPI200 전일대비구분	string	1")] string k200sign, [Description("KOSPI200 전일대비	double	6.2")] double change, [Description("KOSPI200 베이시스	double	4.2")] double k200basis, [Description("차익매도체결수량합계	int	6")] int cdvolume, [Description("차익매수체결수량합계	int	6")] int csvolume, [Description("차익순매수 수량합계	int	6")] int cvol, [Description("비차익매도체결수량합계	int	6")] int bdvolume, [Description("비차익매수체결수량합계	int	6")] int bsvolume, [Description("비차익순매수 수량합계	int	6")] int bvol, [Description("전체매도체결수량합계	int	6")] int tdvolume, [Description("전체매수체결수량합계	int	6")] int tsvolume, [Description("전체순매수 수량합계	int	6")] int tvol, [Description("차익매도체결금액합계	int	8")] int cdvalue, [Description("차익매수체결금액합계	int	8")] int csvalue, [Description("차익순매수 금액합계	int	8")] int cval, [Description("비차익매도체결금액합계	int	8")] int bdvalue, [Description("비차익매수체결금액합계	int	8")] int bsvalue, [Description("비차익순매수 금액합계	int	8")] int bval, [Description("전체매도체결금액합계	int	8")] int tdvalue, [Description("전체매수체결금액합계	int	8")] int tsvalue, [Description("전체순매수 금액합계	int	8")] int tval, [Description("차익매도체결수량직전대비	int	6")] int p_cdvolcha, [Description("차익매수체결수량직전대비	int	6")] int p_csvolcha, [Description("차익순매수 수량직전대비	int	6")] int p_cvolcha, [Description("비차익매도체결수량직전대비	int	6")] int p_bdvolcha, [Description("비차익매수체결수량직전대비	int	6")] int p_bsvolcha, [Description("비차익순매수 수량직전대비	int	6")] int p_bvolcha, [Description("전체매도체결수량직전대비	int	6")] int p_tdvolcha, [Description("전체매수체결수량직전대비	int	6")] int p_tsvolcha, [Description("전체순매수 수량직전대비	int	6")] int p_tvolcha, [Description("차익매도체결금액직전대비	int	8")] int p_cdvalcha, [Description("차익매수체결금액직전대비	int	8")] int p_csvalcha, [Description("차익순매수 금액직전대비	int	8")] int p_cvalcha, [Description("비차익매도체결금액직전대비	int	8")] int p_bdvalcha, [Description("비차익매수체결금액직전대비	int	8")] int p_bsvalcha, [Description("비차익순매수 금액직전대비	int	8")] int p_bvalcha, [Description("전체매도체결금액직전대비	int	8")] int p_tdvalcha, [Description("전체매수체결금액직전대비	int	8")] int p_tsvalcha, [Description("전체순매수 금액직전대비	int	8")] int p_tvalcha, [Description("구분값	string	1")] string gubun);

/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record S2_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSPI우선호가: S2_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
public record S2_OutBlock([Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW우선호가: s2_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record s2_InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW우선호가: s2_
/// </summary>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">단축코드	string	6</param>
public record s2_OutBlock([Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// KOSPI체결: S3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record S3_InBlock([Description("단축코드	string	6")] string shcode);

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
public record S3_OutBlock([Description("체결시간	string	6")] string chetime, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("현재가	int	8")] int price, [Description("시가시간	string	6")] string opentime, [Description("시가	int	8")] int open, [Description("고가시간	string	6")] string hightime, [Description("고가	int	8")] int high, [Description("저가시간	string	6")] string lowtime, [Description("저가	int	8")] int low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	8")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("가중평균가	int	8")] int w_avrg, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("장정보	string	2")] string status, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW체결: s3_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record s3_InBlock([Description("단축코드	string	6")] string shcode);

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
public record s3_OutBlock([Description("체결시간	string	6")] string chetime, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("현재가	int	8")] int price, [Description("시가시간	string	6")] string opentime, [Description("시가	int	8")] int open, [Description("고가시간	string	6")] string hightime, [Description("고가	int	8")] int high, [Description("저가시간	string	6")] string lowtime, [Description("저가	int	8")] int low, [Description("체결구분	string	1")] string cgubun, [Description("체결량	int	8")] int cvolume, [Description("누적거래량	long	12")] long volume, [Description("누적거래대금	long	12")] long value, [Description("매도누적체결량	long	12")] long mdvolume, [Description("매도누적체결건수	int	8")] int mdchecnt, [Description("매수누적체결량	long	12")] long msvolume, [Description("매수누적체결건수	int	8")] int mschecnt, [Description("체결강도	double	9.2")] double cpower, [Description("가중평균가	int	8")] int w_avrg, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("장정보	string	2")] string status, [Description("전일동시간대거래량	long	12")] long jnilvolume, [Description("프리미엄	double	8.2")] double premium, [Description("ATM구분	string	1")] string moneyness, [Description("단축코드	string	6")] string shcode, [Description("LP보유수량	long	15")] long lpvolume);

/// <summary>
/// KOSPI기세: S4_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record S4_InBlock([Description("단축코드	string	6")] string shcode);

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
public record S4_OutBlock([Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("현재가	int	8")] int price, [Description("시가시간	string	6")] string opentime, [Description("시가	int	8")] int open, [Description("고가시간	string	6")] string hightime, [Description("고가	int	8")] int high, [Description("저가시간	string	6")] string lowtime, [Description("저가	int	8")] int low, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW기세: s4_
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record s4_InBlock([Description("단축코드	string	6")] string shcode);

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
public record s4_OutBlock([Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("현재가	int	8")] int price, [Description("시가시간	string	6")] string opentime, [Description("시가	int	8")] int open, [Description("고가시간	string	6")] string hightime, [Description("고가	int	8")] int high, [Description("저가시간	string	6")] string lowtime, [Description("저가	int	8")] int low, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// 주식주문접수: SC0
/// </summary>
public record SC0InBlock();

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
public record SC0OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("주문체결구분	string	2")] string ordchegb, [Description("시장구분	string	2")] string marketgb, [Description("주문구분	string	2")] string ordgb, [Description("원주문번호	long	10")] long orgordno, [Description("계좌번호	string	11")] string accno1, [Description("계좌번호	string	9")] string accno2, [Description("비밀번호	string	8")] string passwd, [Description("종목번호	string	12")] string expcode, [Description("단축종목번호	string	9")] string shtcode, [Description("종목명	string	40")] string hname, [Description("주문수량	long	16")] long ordqty, [Description("주문가격	long	13")] long ordprice, [Description("주문조건	string	1")] string hogagb, [Description("호가유형코드	string	2")] string etfhogagb, [Description("프로그램호가구분	int	2")] int pgmtype, [Description("공매도호가구분	int	1")] int gmhogagb, [Description("공매도가능여부	int	1")] int gmhogayn, [Description("신용구분	string	3")] string singb, [Description("대출일	string	8")] string loandt, [Description("반대매매주문구분	string	1")] string cvrgordtp, [Description("전략코드	string	6")] string strtgcode, [Description("그룹ID	string	20")] string groupid, [Description("주문회차	long	10")] long ordseqno, [Description("포트폴리오번호	long	10")] long prtno, [Description("바스켓번호	long	10")] long basketno, [Description("트렌치번호	long	10")] long trchno, [Description("아아템번호	long	10")] long itemno, [Description("차입구분	int	1")] int brwmgmyn, [Description("회원사번호	int	3")] int mbrno, [Description("처리구분	string	1")] string procgb, [Description("관리지점번호	string	3")] string admbrchno, [Description("선물계좌번호	string	20")] string futaccno, [Description("선물상품구분	string	1")] string futmarketgb, [Description("통신매체구분	string	2")] string tongsingb, [Description("유동성공급자구분	string	1")] string lpgb, [Description("DUMMY	string	20")] string dummy, [Description("주문번호	long	10")] long ordno, [Description("주문시각	string	9")] string ordtm, [Description("모주문번호	long	10")] long prntordno, [Description("관리사원번호	string	9")] string mgempno, [Description("원주문미체결수량	long	16")] long orgordundrqty, [Description("원주문정정수량	long	16")] long orgordmdfyqty, [Description("원주문취소수량	long	16")] long ordordcancelqty, [Description("비회원사송신번호	long	10")] long nmcpysndno, [Description("주문금액	long	16")] long ordamt, [Description("매매구분	string	1")] string bnstp, [Description("예비주문번호	long	10")] long spareordno, [Description("반대매매일련번호	long	10")] long cvrgseqno, [Description("예약주문번호	long	10")] long rsvordno, [Description("복수주문일련번호	long	10")] long mtordseqno, [Description("예비주문수량	long	16")] long spareordqty, [Description("주문사원번호	string	16")] string orduserid, [Description("실물주문수량	long	16")] long spotordqty, [Description("재사용주문수량	long	16")] long ordruseqty, [Description("현금주문금액	long	16")] long mnyordamt, [Description("주문대용금액	long	16")] long ordsubstamt, [Description("재사용주문금액	long	16")] long ruseordamt, [Description("수수료주문금액	long	16")] long ordcmsnamt, [Description("사용신용담보재사용금	long	16")] long crdtuseamt, [Description("잔고수량	long	16")] long secbalqty, [Description("실물가능수량	long	16")] long spotordableqty, [Description("재사용가능수량(매도)	long	16")] long ordableruseqty, [Description("변동수량	long	16")] long flctqty, [Description("잔고수량(D2)	long	16")] long secbalqtyd2, [Description("매도주문가능수량	long	16")] long sellableqty, [Description("미체결매도주문수량	long	16")] long unercsellordqty, [Description("평균매입가	long	13")] long avrpchsprc, [Description("매입금액	long	16")] long pchsamt, [Description("예수금	long	16")] long deposit, [Description("대용금	long	16")] long substamt, [Description("위탁증거금현금	long	16")] long csgnmnymgn, [Description("위탁증거금대용	long	16")] long csgnsubstmgn, [Description("신용담보재사용금	long	16")] long crdtpldgruseamt, [Description("주문가능현금	long	16")] long ordablemny, [Description("주문가능대용	long	16")] long ordablesubstamt, [Description("재사용가능금액	long	16")] long ruseableamt);

/// <summary>
/// 주식주문체결: SC1
/// </summary>
public record SC1InBlock();

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
public record SC1OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("주문체결유형코드	string	2")] string ordxctptncode, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문유형코드	string	2")] string ordptncode, [Description("관리지점번호	string	3")] string mgmtbrnno, [Description("계좌번호	string	11")] string accno1, [Description("계좌번호	string	9")] string accno2, [Description("계좌명	string	40")] string acntnm, [Description("종목번호	string	12")] string Isuno, [Description("종목명	string	40")] string Isunm, [Description("주문번호	long	10")] long ordno, [Description("원주문번호	long	10")] long orgordno, [Description("체결번호	long	10")] long execno, [Description("주문수량	long	16")] long ordqty, [Description("주문가격	long	13")] long ordprc, [Description("체결수량	long	16")] long execqty, [Description("체결가격	long	13")] long execprc, [Description("정정확인수량	long	16")] long mdfycnfqty, [Description("정정확인가격	long	16")] long mdfycnfprc, [Description("취소확인수량	long	16")] long canccnfqty, [Description("거부수량	long	16")] long rjtqty, [Description("주문처리유형코드	int	4")] int ordtrxptncode, [Description("복수주문일련번호	long	10")] long mtiordseqno, [Description("주문조건	string	1")] string ordcndi, [Description("호가유형코드	string	2")] string ordprcptncode, [Description("비저축체결수량	long	16")] long nsavtrdqty, [Description("단축종목번호	string	9")] string shtnIsuno, [Description("운용지시번호	string	12")] string opdrtnno, [Description("반대매매주문구분	string	1")] string cvrgordtp, [Description("미체결수량(주문)	long	16")] long unercqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정수량	long	16")] long orgordmdfyqty, [Description("원주문취소수량	long	16")] long orgordcancqty, [Description("주문평균체결가격	long	13")] long ordavrexecprc, [Description("주문금액	long	16")] long ordamt, [Description("표준종목번호	string	12")] string stdIsuno, [Description("전표준종목번호	string	12")] string bfstdIsuno, [Description("매매구분	string	1")] string bnstp, [Description("주문거래유형코드	string	2")] string ordtrdptncode, [Description("신용거래코드	string	3")] string mgntrncode, [Description("수수료합산코드	string	2")] string adduptp, [Description("통신매체코드	string	2")] string commdacode, [Description("대출일	string	8")] string Loandt, [Description("회원/비회원사번호	int	3")] int mbrnmbrno, [Description("주문계좌번호	string	20")] string ordacntno, [Description("집계지점번호	string	3")] string agrgbrnno, [Description("관리사원번호	string	9")] string mgempno, [Description("선물연계지점번호	string	3")] string futsLnkbrnno, [Description("선물연계계좌번호	string	20")] string futsLnkacntno, [Description("선물시장구분	string	1")] string futsmkttp, [Description("등록시장코드	string	2")] string regmktcode, [Description("현금증거금률	int	7")] int mnymgnrat, [Description("대용증거금률	long	9")] long substmgnrat, [Description("현금체결금액	long	16")] long mnyexecamt, [Description("대용체결금액	long	16")] long ubstexecamt, [Description("수수료체결금액	long	16")] long cmsnamtexecamt, [Description("신용담보체결금액	long	16")] long crdtpldgexecamt, [Description("신용체결금액	long	16")] long crdtexecamt, [Description("전일재사용체결금액	long	16")] long prdayruseexecval, [Description("금일재사용체결금액	long	16")] long crdayruseexecval, [Description("실물체결수량	long	16")] long spotexecqty, [Description("공매도체결수량	long	16")] long stslexecqty, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	long	10")] long ordseqno, [Description("포트폴리오번호	long	10")] long ptflno, [Description("바스켓번호	long	10")] long bskno, [Description("트렌치번호	long	10")] long trchno, [Description("아이템번호	long	10")] long itemno, [Description("주문자Id	string	16")] string orduserId, [Description("차입관리여부	int	1")] int brwmgmtYn, [Description("외국인고유번호	string	6")] string frgrunqno, [Description("거래세징수구분	string	1")] string trtzxLevytp, [Description("유동성공급자구분	string	1")] string lptp, [Description("체결시각	string	9")] string exectime, [Description("거래소수신체결시각	string	9")] string rcptexectime, [Description("잔여대출금액	long	16")] long rmndLoanamt, [Description("잔고수량	long	16")] long secbalqty, [Description("실물가능수량	long	16")] long spotordableqty, [Description("재사용가능수량(매도)	long	16")] long ordableruseqty, [Description("변동수량	long	16")] long flctqty, [Description("잔고수량(d2)	long	16")] long secbalqtyd2, [Description("매도주문가능수량	long	16")] long sellableqty, [Description("미체결매도주문수량	long	16")] long unercsellordqty, [Description("평균매입가	long	13")] long avrpchsprc, [Description("매입금액	long	16")] long pchsant, [Description("예수금	long	16")] long deposit, [Description("대용금	long	16")] long substamt, [Description("위탁증거금현금	long	16")] long csgnmnymgn, [Description("위탁증거금대용	long	16")] long csgnsubstmgn, [Description("신용담보재사용금	long	16")] long crdtpldgruseamt, [Description("주문가능현금	long	16")] long ordablemny, [Description("주문가능대용	long	16")] long ordablesubstamt, [Description("재사용가능금액	long	16")] long ruseableamt);

/// <summary>
/// 주식주문정정: SC2
/// </summary>
public record SC2InBlock();

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
public record SC2OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("주문체결유형코드	string	2")] string ordxctptncode, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문유형코드	string	2")] string ordptncode, [Description("관리지점번호	string	3")] string mgmtbrnno, [Description("계좌번호	string	11")] string accno1, [Description("계좌번호	string	9")] string accno2, [Description("계좌명	string	40")] string acntnm, [Description("종목번호	string	12")] string Isuno, [Description("종목명	string	40")] string Isunm, [Description("주문번호	long	10")] long ordno, [Description("원주문번호	long	10")] long orgordno, [Description("체결번호	long	10")] long execno, [Description("주문수량	long	16")] long ordqty, [Description("주문가격	long	13")] long ordprc, [Description("체결수량	long	16")] long execqty, [Description("체결가격	long	13")] long execprc, [Description("정정확인수량	long	16")] long mdfycnfqty, [Description("정정확인가격	long	16")] long mdfycnfprc, [Description("취소확인수량	long	16")] long canccnfqty, [Description("거부수량	long	16")] long rjtqty, [Description("주문처리유형코드	int	4")] int ordtrxptncode, [Description("복수주문일련번호	long	10")] long mtiordseqno, [Description("주문조건	string	1")] string ordcndi, [Description("호가유형코드	string	2")] string ordprcptncode, [Description("비저축체결수량	long	16")] long nsavtrdqty, [Description("단축종목번호	string	9")] string shtnIsuno, [Description("운용지시번호	string	12")] string opdrtnno, [Description("반대매매주문구분	string	1")] string cvrgordtp, [Description("미체결수량(주문)	long	16")] long unercqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정수량	long	16")] long orgordmdfyqty, [Description("원주문취소수량	long	16")] long orgordcancqty, [Description("주문평균체결가격	long	13")] long ordavrexecprc, [Description("주문금액	long	16")] long ordamt, [Description("표준종목번호	string	12")] string stdIsuno, [Description("전표준종목번호	string	12")] string bfstdIsuno, [Description("매매구분	string	1")] string bnstp, [Description("주문거래유형코드	string	2")] string ordtrdptncode, [Description("신용거래코드	string	3")] string mgntrncode, [Description("수수료합산코드	string	2")] string adduptp, [Description("통신매체코드	string	2")] string commdacode, [Description("대출일	string	8")] string Loandt, [Description("회원/비회원사번호	int	3")] int mbrnmbrno, [Description("주문계좌번호	string	20")] string ordacntno, [Description("집계지점번호	string	3")] string agrgbrnno, [Description("관리사원번호	string	9")] string mgempno, [Description("선물연계지점번호	string	3")] string futsLnkbrnno, [Description("선물연계계좌번호	string	20")] string futsLnkacntno, [Description("선물시장구분	string	1")] string futsmkttp, [Description("등록시장코드	string	2")] string regmktcode, [Description("현금증거금률	int	7")] int mnymgnrat, [Description("대용증거금률	long	9")] long substmgnrat, [Description("현금체결금액	long	16")] long mnyexecamt, [Description("대용체결금액	long	16")] long ubstexecamt, [Description("수수료체결금액	long	16")] long cmsnamtexecamt, [Description("신용담보체결금액	long	16")] long crdtpldgexecamt, [Description("신용체결금액	long	16")] long crdtexecamt, [Description("전일재사용체결금액	long	16")] long prdayruseexecval, [Description("금일재사용체결금액	long	16")] long crdayruseexecval, [Description("실물체결수량	long	16")] long spotexecqty, [Description("공매도체결수량	long	16")] long stslexecqty, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	long	10")] long ordseqno, [Description("포트폴리오번호	long	10")] long ptflno, [Description("바스켓번호	long	10")] long bskno, [Description("트렌치번호	long	10")] long trchno, [Description("아이템번호	long	10")] long itemno, [Description("주문자Id	string	16")] string orduserId, [Description("차입관리여부	int	1")] int brwmgmtYn, [Description("외국인고유번호	string	6")] string frgrunqno, [Description("거래세징수구분	string	1")] string trtzxLevytp, [Description("유동성공급자구분	string	1")] string lptp, [Description("체결시각	string	9")] string exectime, [Description("거래소수신체결시각	string	9")] string rcptexectime, [Description("잔여대출금액	long	16")] long rmndLoanamt, [Description("잔고수량	long	16")] long secbalqty, [Description("실물가능수량	long	16")] long spotordableqty, [Description("재사용가능수량(매도)	long	16")] long ordableruseqty, [Description("변동수량	long	16")] long flctqty, [Description("잔고수량(d2)	long	16")] long secbalqtyd2, [Description("매도주문가능수량	long	16")] long sellableqty, [Description("미체결매도주문수량	long	16")] long unercsellordqty, [Description("평균매입가	long	13")] long avrpchsprc, [Description("매입금액	long	16")] long pchsant, [Description("예수금	long	16")] long deposit, [Description("대용금	long	16")] long substamt, [Description("위탁증거금현금	long	16")] long csgnmnymgn, [Description("위탁증거금대용	long	16")] long csgnsubstmgn, [Description("신용담보재사용금	long	16")] long crdtpldgruseamt, [Description("주문가능현금	long	16")] long ordablemny, [Description("주문가능대용	long	16")] long ordablesubstamt, [Description("재사용가능금액	long	16")] long ruseableamt);

/// <summary>
/// 주식주문취소: SC3
/// </summary>
public record SC3InBlock();

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
public record SC3OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("주문체결유형코드	string	2")] string ordxctptncode, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문유형코드	string	2")] string ordptncode, [Description("관리지점번호	string	3")] string mgmtbrnno, [Description("계좌번호	string	11")] string accno1, [Description("계좌번호	string	9")] string accno2, [Description("계좌명	string	40")] string acntnm, [Description("종목번호	string	12")] string Isuno, [Description("종목명	string	40")] string Isunm, [Description("주문번호	long	10")] long ordno, [Description("원주문번호	long	10")] long orgordno, [Description("체결번호	long	10")] long execno, [Description("주문수량	long	16")] long ordqty, [Description("주문가격	long	13")] long ordprc, [Description("체결수량	long	16")] long execqty, [Description("체결가격	long	13")] long execprc, [Description("정정확인수량	long	16")] long mdfycnfqty, [Description("정정확인가격	long	16")] long mdfycnfprc, [Description("취소확인수량	long	16")] long canccnfqty, [Description("거부수량	long	16")] long rjtqty, [Description("주문처리유형코드	int	4")] int ordtrxptncode, [Description("복수주문일련번호	long	10")] long mtiordseqno, [Description("주문조건	string	1")] string ordcndi, [Description("호가유형코드	string	2")] string ordprcptncode, [Description("비저축체결수량	long	16")] long nsavtrdqty, [Description("단축종목번호	string	9")] string shtnIsuno, [Description("운용지시번호	string	12")] string opdrtnno, [Description("반대매매주문구분	string	1")] string cvrgordtp, [Description("미체결수량(주문)	long	16")] long unercqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정수량	long	16")] long orgordmdfyqty, [Description("원주문취소수량	long	16")] long orgordcancqty, [Description("주문평균체결가격	long	13")] long ordavrexecprc, [Description("주문금액	long	16")] long ordamt, [Description("표준종목번호	string	12")] string stdIsuno, [Description("전표준종목번호	string	12")] string bfstdIsuno, [Description("매매구분	string	1")] string bnstp, [Description("주문거래유형코드	string	2")] string ordtrdptncode, [Description("신용거래코드	string	3")] string mgntrncode, [Description("수수료합산코드	string	2")] string adduptp, [Description("통신매체코드	string	2")] string commdacode, [Description("대출일	string	8")] string Loandt, [Description("회원/비회원사번호	int	3")] int mbrnmbrno, [Description("주문계좌번호	string	20")] string ordacntno, [Description("집계지점번호	string	3")] string agrgbrnno, [Description("관리사원번호	string	9")] string mgempno, [Description("선물연계지점번호	string	3")] string futsLnkbrnno, [Description("선물연계계좌번호	string	20")] string futsLnkacntno, [Description("선물시장구분	string	1")] string futsmkttp, [Description("등록시장코드	string	2")] string regmktcode, [Description("현금증거금률	int	7")] int mnymgnrat, [Description("대용증거금률	long	9")] long substmgnrat, [Description("현금체결금액	long	16")] long mnyexecamt, [Description("대용체결금액	long	16")] long ubstexecamt, [Description("수수료체결금액	long	16")] long cmsnamtexecamt, [Description("신용담보체결금액	long	16")] long crdtpldgexecamt, [Description("신용체결금액	long	16")] long crdtexecamt, [Description("전일재사용체결금액	long	16")] long prdayruseexecval, [Description("금일재사용체결금액	long	16")] long crdayruseexecval, [Description("실물체결수량	long	16")] long spotexecqty, [Description("공매도체결수량	long	16")] long stslexecqty, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	long	10")] long ordseqno, [Description("포트폴리오번호	long	10")] long ptflno, [Description("바스켓번호	long	10")] long bskno, [Description("트렌치번호	long	10")] long trchno, [Description("아이템번호	long	10")] long itemno, [Description("주문자Id	string	16")] string orduserId, [Description("차입관리여부	int	1")] int brwmgmtYn, [Description("외국인고유번호	string	6")] string frgrunqno, [Description("거래세징수구분	string	1")] string trtzxLevytp, [Description("유동성공급자구분	string	1")] string lptp, [Description("체결시각	string	9")] string exectime, [Description("거래소수신체결시각	string	9")] string rcptexectime, [Description("잔여대출금액	long	16")] long rmndLoanamt, [Description("잔고수량	long	16")] long secbalqty, [Description("실물가능수량	long	16")] long spotordableqty, [Description("재사용가능수량(매도)	long	16")] long ordableruseqty, [Description("변동수량	long	16")] long flctqty, [Description("잔고수량(d2)	long	16")] long secbalqtyd2, [Description("매도주문가능수량	long	16")] long sellableqty, [Description("미체결매도주문수량	long	16")] long unercsellordqty, [Description("평균매입가	long	13")] long avrpchsprc, [Description("매입금액	long	16")] long pchsant, [Description("예수금	long	16")] long deposit, [Description("대용금	long	16")] long substamt, [Description("위탁증거금현금	long	16")] long csgnmnymgn, [Description("위탁증거금대용	long	16")] long csgnsubstmgn, [Description("신용담보재사용금	long	16")] long crdtpldgruseamt, [Description("주문가능현금	long	16")] long ordablemny, [Description("주문가능대용	long	16")] long ordablesubstamt, [Description("재사용가능금액	long	16")] long ruseableamt);

/// <summary>
/// 주식주문거부: SC4
/// </summary>
public record SC4InBlock();

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
public record SC4OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("계좌번호	string	11")] string accno, [Description("조작자ID	string	8")] string user, [Description("헤더길이	int	6")] int len, [Description("헤더구분	string	1")] string gubun, [Description("압축구분	string	1")] string compress, [Description("암호구분	string	1")] string encrypt, [Description("공통시작지점	int	3")] int offset, [Description("TRCODE	string	8")] string trcode, [Description("이용사번호	string	3")] string comid, [Description("사용자ID	string	16")] string userid, [Description("접속매체	string	2")] string media, [Description("I/F일련번호	string	3")] string ifid, [Description("전문일련번호	string	9")] string seq, [Description("TR추적ID	string	16")] string trid, [Description("공인IP	string	12")] string pubip, [Description("사설IP	string	12")] string prvip, [Description("처리지점번호	string	3")] string pcbpno, [Description("지점번호	string	3")] string bpno, [Description("단말번호	string	8")] string termno, [Description("언어구분	string	1")] string lang, [Description("AP처리시간	long	9")] long proctm, [Description("메세지코드	string	4")] string msgcode, [Description("메세지출력구분	string	1")] string outgu, [Description("압축요청구분	string	1")] string compreq, [Description("기능키	string	4")] string funckey, [Description("요청레코드개수	int	4")] int reqcnt, [Description("예비영역	string	6")] string filler, [Description("연속구분	string	1")] string cont, [Description("연속키값	string	18")] string contkey, [Description("가변시스템길이	int	2")] int varlen, [Description("가변해더길이	int	2")] int varhdlen, [Description("가변메시지길이	int	2")] int varmsglen, [Description("조회발원지	string	1")] string trsrc, [Description("I/F이벤트ID	string	4")] string eventid, [Description("I/F정보	string	4")] string ifinfo, [Description("예비영역	string	41")] string filler1, [Description("주문체결유형코드	string	2")] string ordxctptncode, [Description("주문시장코드	string	2")] string ordmktcode, [Description("주문유형코드	string	2")] string ordptncode, [Description("관리지점번호	string	3")] string mgmtbrnno, [Description("계좌번호	string	11")] string accno1, [Description("계좌번호	string	9")] string accno2, [Description("계좌명	string	40")] string acntnm, [Description("종목번호	string	12")] string Isuno, [Description("종목명	string	40")] string Isunm, [Description("주문번호	long	10")] long ordno, [Description("원주문번호	long	10")] long orgordno, [Description("체결번호	long	10")] long execno, [Description("주문수량	long	16")] long ordqty, [Description("주문가격	long	13")] long ordprc, [Description("체결수량	long	16")] long execqty, [Description("체결가격	long	13")] long execprc, [Description("정정확인수량	long	16")] long mdfycnfqty, [Description("정정확인가격	long	16")] long mdfycnfprc, [Description("취소확인수량	long	16")] long canccnfqty, [Description("거부수량	long	16")] long rjtqty, [Description("주문처리유형코드	int	4")] int ordtrxptncode, [Description("복수주문일련번호	long	10")] long mtiordseqno, [Description("주문조건	string	1")] string ordcndi, [Description("호가유형코드	string	2")] string ordprcptncode, [Description("비저축체결수량	long	16")] long nsavtrdqty, [Description("단축종목번호	string	9")] string shtnIsuno, [Description("운용지시번호	string	12")] string opdrtnno, [Description("반대매매주문구분	string	1")] string cvrgordtp, [Description("미체결수량(주문)	long	16")] long unercqty, [Description("원주문미체결수량	long	16")] long orgordunercqty, [Description("원주문정정수량	long	16")] long orgordmdfyqty, [Description("원주문취소수량	long	16")] long orgordcancqty, [Description("주문평균체결가격	long	13")] long ordavrexecprc, [Description("주문금액	long	16")] long ordamt, [Description("표준종목번호	string	12")] string stdIsuno, [Description("전표준종목번호	string	12")] string bfstdIsuno, [Description("매매구분	string	1")] string bnstp, [Description("주문거래유형코드	string	2")] string ordtrdptncode, [Description("신용거래코드	string	3")] string mgntrncode, [Description("수수료합산코드	string	2")] string adduptp, [Description("통신매체코드	string	2")] string commdacode, [Description("대출일	string	8")] string Loandt, [Description("회원/비회원사번호	int	3")] int mbrnmbrno, [Description("주문계좌번호	string	20")] string ordacntno, [Description("집계지점번호	string	3")] string agrgbrnno, [Description("관리사원번호	string	9")] string mgempno, [Description("선물연계지점번호	string	3")] string futsLnkbrnno, [Description("선물연계계좌번호	string	20")] string futsLnkacntno, [Description("선물시장구분	string	1")] string futsmkttp, [Description("등록시장코드	string	2")] string regmktcode, [Description("현금증거금률	int	7")] int mnymgnrat, [Description("대용증거금률	long	9")] long substmgnrat, [Description("현금체결금액	long	16")] long mnyexecamt, [Description("대용체결금액	long	16")] long ubstexecamt, [Description("수수료체결금액	long	16")] long cmsnamtexecamt, [Description("신용담보체결금액	long	16")] long crdtpldgexecamt, [Description("신용체결금액	long	16")] long crdtexecamt, [Description("전일재사용체결금액	long	16")] long prdayruseexecval, [Description("금일재사용체결금액	long	16")] long crdayruseexecval, [Description("실물체결수량	long	16")] long spotexecqty, [Description("공매도체결수량	long	16")] long stslexecqty, [Description("전략코드	string	6")] string strtgcode, [Description("그룹Id	string	20")] string grpId, [Description("주문회차	long	10")] long ordseqno, [Description("포트폴리오번호	long	10")] long ptflno, [Description("바스켓번호	long	10")] long bskno, [Description("트렌치번호	long	10")] long trchno, [Description("아이템번호	long	10")] long itemno, [Description("주문자Id	string	16")] string orduserId, [Description("차입관리여부	int	1")] int brwmgmtYn, [Description("외국인고유번호	string	6")] string frgrunqno, [Description("거래세징수구분	string	1")] string trtzxLevytp, [Description("유동성공급자구분	string	1")] string lptp, [Description("체결시각	string	9")] string exectime, [Description("거래소수신체결시각	string	9")] string rcptexectime, [Description("잔여대출금액	long	16")] long rmndLoanamt, [Description("잔고수량	long	16")] long secbalqty, [Description("실물가능수량	long	16")] long spotordableqty, [Description("재사용가능수량(매도)	long	16")] long ordableruseqty, [Description("변동수량	long	16")] long flctqty, [Description("잔고수량(d2)	long	16")] long secbalqtyd2, [Description("매도주문가능수량	long	16")] long sellableqty, [Description("미체결매도주문수량	long	16")] long unercsellordqty, [Description("평균매입가	long	13")] long avrpchsprc, [Description("매입금액	long	16")] long pchsant, [Description("예수금	long	16")] long deposit, [Description("대용금	long	16")] long substamt, [Description("위탁증거금현금	long	16")] long csgnmnymgn, [Description("위탁증거금대용	long	16")] long csgnsubstmgn, [Description("신용담보재사용금	long	16")] long crdtpldgruseamt, [Description("주문가능현금	long	16")] long ordablemny, [Description("주문가능대용	long	16")] long ordablesubstamt, [Description("재사용가능금액	long	16")] long ruseableamt);

/// <summary>
/// 상/하한가근접진입: SHC
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
public record SHCInBlock([Description("상/하한구분	string	1")] string updnlmtgubun);

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
public record SHCOutBlock([Description("거래소/코스닥구분	string	1")] string sijanggubun, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	12.2")] double volincrate, [Description("상/하한가	int	8")] int updnlmtprice, [Description("상/하한가대비율	double	6.2")] double updnlmtdrate, [Description("전일거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode, [Description("관리구분	string	1")] string gwangubun, [Description("이상급등구분	string	1")] string undergubun, [Description("투자유의구분	string	1")] string tgubun, [Description("우선주구분	string	1")] string wgubun, [Description("불성실구분	string	1")] string dishonest, [Description("증거금률	string	1")] string jkrate, [Description("상한가/하한가연속일수	int	3")] int updnlmtdaycnt);

/// <summary>
/// 상/하한가근접이탈: SHD
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
public record SHDInBlock([Description("상/하한구분	string	1")] string updnlmtgubun);

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
public record SHDOutBlock([Description("거래소/코스닥구분	string	1")] string sijanggubun, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	12.2")] double volincrate, [Description("상/하한가	int	8")] int updnlmtprice, [Description("상/하한가대비율	double	6.2")] double updnlmtdrate, [Description("전일거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode, [Description("관리구분	string	1")] string gwangubun, [Description("이상급등구분	string	1")] string undergubun, [Description("투자유의구분	string	1")] string tgubun, [Description("우선주구분	string	1")] string wgubun, [Description("불성실구분	string	1")] string dishonest, [Description("증거금률	string	1")] string jkrate);

/// <summary>
/// 상/하한가진입: SHI
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
public record SHIInBlock([Description("상/하한구분	string	1")] string updnlmtgubun);

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
public record SHIOutBlock([Description("거래소/코스닥구분	string	1")] string sijanggubun, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	12.2")] double volincrate, [Description("매도호가총수량	long	12")] long totofferrem, [Description("매수호가총수량	long	12")] long totbidrem, [Description("상한가/하한가최종진입시간	string	6")] string updnlmtstime, [Description("상한가/하한가연속일수	int	3")] int updnlmtdaycnt, [Description("전일거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode, [Description("관리구분	string	1")] string gwangubun, [Description("이상급등구분	string	1")] string undergubun, [Description("투자유의구분	string	1")] string tgubun, [Description("우선주구분	string	1")] string wgubun, [Description("불성실구분	string	1")] string dishonest, [Description("증거금률	string	1")] string jkrate);

/// <summary>
/// 상/하한가이탈: SHO
/// </summary>
/// <param name="updnlmtgubun">상/하한구분	string	1</param>
public record SHOInBlock([Description("상/하한구분	string	1")] string updnlmtgubun);

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
public record SHOOutBlock([Description("거래소/코스닥구분	string	1")] string sijanggubun, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double drate, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	12.2")] double volincrate, [Description("상/하한가	int	8")] int updnlmtprice, [Description("상/하한가대비	int	8")] int updnlmtchange, [Description("상/하한가대비율	double	6.2")] double updnlmtdrate, [Description("전일거래량	long	12")] long jnilvolume, [Description("단축코드	string	6")] string shcode, [Description("관리구분	string	1")] string gwangubun, [Description("이상급등구분	string	1")] string undergubun, [Description("투자유의구분	string	1")] string tgubun, [Description("우선주구분	string	1")] string wgubun, [Description("불성실구분	string	1")] string dishonest, [Description("증거금률	string	1")] string jkrate);

/// <summary>
/// 해외선물주문: TC1
/// </summary>
public record TC1InBlock();

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
public record TC1OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("KEY	string	11")] string key, [Description("조작자ID	string	8")] string user, [Description("서비스ID	string	4")] string svc_id, [Description("주문일자	string	8")] string ordr_dt, [Description("지점번호	string	3")] string brn_cd, [Description("주문번호	long	10")] long ordr_no, [Description("원주문번호	long	10")] long orgn_ordr_no, [Description("모주문번호	long	10")] long mthr_ordr_no, [Description("계좌번호	string	11")] string ac_no, [Description("종목코드	string	30")] string is_cd, [Description("매도매수유형	string	1")] string s_b_ccd, [Description("정정취소유형	string	1")] string ordr_ccd, [Description("주문유형코드	string	1")] string ordr_typ_cd, [Description("주문기간코드	string	2")] string ordr_typ_prd_ccd, [Description("주문적용시작일자	string	8")] string ordr_aplc_strt_dt, [Description("주문적용종료일자	string	8")] string ordr_aplc_end_dt, [Description("주문가격	double	18.11")] double ordr_prc, [Description("주문조건가격	double	18.11")] double cndt_ordr_prc, [Description("주문수량	long	12")] long ordr_q, [Description("주문시간	string	9")] string ordr_tm, [Description("사용자ID	string	8")] string userid, [Description("만기행사유무	string	1")] string xrc_rsv_tcp_code);

/// <summary>
/// 해외선물응답: TC2
/// </summary>
public record TC2InBlock();

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
public record TC2OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("KEY	string	11")] string key, [Description("조작자ID	string	8")] string user, [Description("서비스ID	string	4")] string svc_id, [Description("주문일자	string	8")] string ordr_dt, [Description("지점번호	string	3")] string brn_cd, [Description("주문번호	long	10")] long ordr_no, [Description("원주문번호	long	10")] long orgn_ordr_no, [Description("모주문번호	long	10")] long mthr_ordr_no, [Description("계좌번호	string	11")] string ac_no, [Description("종목코드	string	30")] string is_cd, [Description("매도매수유형	string	1")] string s_b_ccd, [Description("정정취소유형	string	1")] string ordr_ccd, [Description("주문유형코드	string	1")] string ordr_typ_cd, [Description("주문기간코드	string	2")] string ordr_typ_prd_ccd, [Description("주문적용시작일자	string	8")] string ordr_aplc_strt_dt, [Description("주문적용종료일자	string	8")] string ordr_aplc_end_dt, [Description("주문가격	double	18.11")] double ordr_prc, [Description("주문조건가격	double	18.11")] double cndt_ordr_prc, [Description("주문수량	long	12")] long ordr_q, [Description("주문시간	string	9")] string ordr_tm, [Description("호가확인수량	long	12")] long cnfr_q, [Description("호가거부사유코드	string	4")] string rfsl_cd, [Description("호가거부사유코드명	string	80")] string text, [Description("사용자ID	string	8")] string user_id);

/// <summary>
/// 해외선물체결: TC3
/// </summary>
public record TC3InBlock();

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
public record TC3OutBlock([Description("라인일련번호	long	10")] long lineseq, [Description("KEY	string	11")] string key, [Description("조작자ID	string	8")] string user, [Description("서비스ID	string	4")] string svc_id, [Description("주문일자	string	8")] string ordr_dt, [Description("지점번호	string	3")] string brn_cd, [Description("주문번호	long	10")] long ordr_no, [Description("원주문번호	long	10")] long orgn_ordr_no, [Description("모주문번호	long	10")] long mthr_ordr_no, [Description("계좌번호	string	11")] string ac_no, [Description("종목코드	string	30")] string is_cd, [Description("매도매수유형	string	1")] string s_b_ccd, [Description("정정취소유형	string	1")] string ordr_ccd, [Description("체결수량	long	15")] long ccls_q, [Description("체결가격	double	18.11")] double ccls_prc, [Description("체결번호	string	10")] string ccls_no, [Description("체결시간	string	9")] string ccls_tm, [Description("매입평균단가	double	18.11")] double avg_byng_uprc, [Description("매입금액	double	25.8")] double byug_amt, [Description("청산손익	double	19.2")] double clr_pl_amt, [Description("위탁수수료	double	19.2")] double ent_fee, [Description("매입잔고수량	long	19")] long fcm_fee, [Description("사용자ID	string	8")] string userid, [Description("현재가격	double	18.11")] double now_prc, [Description("통화코드	string	3")] string crncy_cd, [Description("만기일자	string	8")] string mtrt_dt, [Description("주문상품구분코드	string	1")] string ord_prdt_tp_code, [Description("주문상품구분코드	string	1")] string exec_prdt_tp_code, [Description("스프레드종목여부	string	1")] string sprd_base_isu_yn, [Description("체결일자	string	8")] string ccls_dt, [Description("FILLER2	string	30")] string filler2, [Description("스프레드종목코드	string	30")] string sprd_is_cd, [Description("LME상품유형	string	1")] string lme_prdt_ccd, [Description("LME스프레드가격	double	18.11")] double lme_sprd_prc, [Description("최종현재가격	double	18.11")] double last_now_prc, [Description("이전만기일자	string	8")] string bf_mtrt_dt, [Description("청산수량	long	15")] long clr_q);

/// <summary>
/// VI발동해제: VI_
/// </summary>
/// <param name="shcode">단축코드(KEY)	string	6</param>
public record VI_InBlock([Description("단축코드(KEY)	string	6")] string shcode);

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
public record VI_OutBlock([Description("구분(0:해제 1:정적발동 2:동적발동 3:정적&동적)	string	1")] string vi_gubun, [Description("정적VI발동기준가격	int	8")] int svi_recprice, [Description("동적VI발동기준가격	int	8")] int dvi_recprice, [Description("VI발동가격	int	8")] int vi_trgprice, [Description("단축코드(KEY)	string	6")] string shcode, [Description("참조코드	string	6")] string ref_shcode, [Description("시간	string	6")] string time);

/// <summary>
/// 해외옵션 현재가체결: WOC
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
public record WOCInBlock([Description("종목코드	string	16")] string symbol);

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
public record WOCOutBlock([Description("종목코드	string	16")] string symbol, [Description("체결일자(현지)	string	8")] string ovsdate, [Description("체결일자(한국)	string	8")] string kordate, [Description("체결시간(현지)	string	6")] string trdtm, [Description("체결시간(한국)	string	6")] string kortm, [Description("체결가격	double	15.9")] double curpr, [Description("전일대비	double	15.9")] double ydiffpr, [Description("전일대비기호	string	1")] string ydiffSign, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("등락율	double	6.2")] double chgrate, [Description("건별체결수량	long	10")] long trdq, [Description("누적체결수량	string	15")] string totq, [Description("체결구분	string	1")] string cgubun, [Description("매도누적체결수량	string	15")] string mdvolume, [Description("매수누적체결수량	string	15")] string msvolume, [Description("장마감일	string	8")] string ovsmkend);

/// <summary>
/// 해외옵션 호가: WOH
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
public record WOHInBlock([Description("종목코드	string	16")] string symbol);

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
public record WOHOutBlock([Description("종목코드	string	16")] string symbol, [Description("호가시간	string	6")] string hotime, [Description("매도호가 1	double	15.9")] double offerho1, [Description("매수호가 1	double	15.9")] double bidho1, [Description("매도호가 잔량 1	long	10")] long offerrem1, [Description("매수호가 잔량 1	long	10")] long bidrem1, [Description("매도호가 건수 1	long	10")] long offerno1, [Description("매수호가 건수 1	long	10")] long bidno1, [Description("매도호가 2	double	15.9")] double offerho2, [Description("매수호가 2	double	15.9")] double bidho2, [Description("매도호가 잔량 2	long	10")] long offerrem2, [Description("매수호가 잔량 2	long	10")] long bidrem2, [Description("매도호가 건수 2	long	10")] long offerno2, [Description("매수호가 건수 2	long	10")] long bidno2, [Description("매도호가 3	double	15.9")] double offerho3, [Description("매수호가 3	double	15.9")] double bidho3, [Description("매도호가 잔량 3	long	10")] long offerrem3, [Description("매수호가 잔량 3	long	10")] long bidrem3, [Description("매도호가 건수 3	long	10")] long offerno3, [Description("매수호가 건수 3	long	10")] long bidno3, [Description("매도호가 4	double	15.9")] double offerho4, [Description("매수호가 4	double	15.9")] double bidho4, [Description("매도호가 잔량 4	long	10")] long offerrem4, [Description("매수호가 잔량 4	long	10")] long bidrem4, [Description("매도호가 건수 4	long	10")] long offerno4, [Description("매수호가 건수 4	long	10")] long bidno4, [Description("매도호가 5	double	15.9")] double offerho5, [Description("매수호가 5	double	15.9")] double bidho5, [Description("매도호가 잔량 5	long	10")] long offerrem5, [Description("매수호가 잔량 5	long	10")] long bidrem5, [Description("매도호가 건수 5	long	10")] long offerno5, [Description("매수호가 건수 5	long	10")] long bidno5, [Description("매도호가총건수	long	10")] long totoffercnt, [Description("매수호가총건수	long	10")] long totbidcnt, [Description("매도호가총수량	long	10")] long totofferrem, [Description("매수호가총수량	long	10")] long totbidrem);

/// <summary>
/// 상품선물예상체결: YC3
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record YC3InBlock([Description("단축코드	string	8")] string shcode);

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
public record YC3OutBlock([Description("예상체결시간	string	6")] string ychetime, [Description("예상체결가격	double	9.2")] double yeprice, [Description("예상체결수량	int	6")] int yevolume, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	double	9.2")] double jnilchange, [Description("예상체결가전일종가등락율	double	9.2")] double jnilydrate, [Description("단축코드	string	8")] string shcode);

/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record YFCInBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// 지수선물예상체결: YFC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	double	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	double	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
public record YFCOutBlock([Description("예상체결시간	string	6")] string ychetime, [Description("예상체결가격	double	6.2")] double yeprice, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	double	6.2")] double jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
/// <param name="futcode">단축코드	string	8</param>
public record YJCInBlock([Description("단축코드	string	8")] string futcode);

/// <summary>
/// 주식선물예상체결: YJC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	long	10</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	long	10</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="futcode">단축코드	string	8</param>
public record YJCOutBlock([Description("예상체결시간	string	6")] string ychetime, [Description("예상체결가격	long	10")] long yeprice, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	long	10")] long jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("단축코드	string	8")] string futcode);

/// <summary>
/// 예상지수: YJ_
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record YJ_InBlock([Description("업종코드	string	3")] string upcode);

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
public record YJ_OutBlock([Description("시간	string	6")] string time, [Description("예상지수	double	8.2")] double jisu, [Description("예상전일대비구분	string	1")] string sign, [Description("예상전일비	double	8.2")] double change, [Description("예상등락율	double	6.2")] double drate, [Description("예상체결량	int	8")] int cvolume, [Description("누적거래량	int	8")] int volume, [Description("예상거래대금	int	8")] int value, [Description("업종코드	string	3")] string upcode);

/// <summary>
/// KOSDAQ예상체결: YK3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record YK3InBlock([Description("단축코드	string	6")] string shcode);

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
public record YK3OutBlock([Description("호가시간	string	6")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	long	12")] long yevolume, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	int	8")] int jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("예상매도호가	int	8")] int yofferho0, [Description("예상매수호가	int	8")] int ybidho0, [Description("예상매도호가수량	long	12")] long yofferrem0, [Description("예상매수호가수량	long	12")] long ybidrem0, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
/// <param name="optcode">단축코드	string	8</param>
public record YOCInBlock([Description("단축코드	string	8")] string optcode);

/// <summary>
/// 지수옵션예상체결: YOC
/// </summary>
/// <param name="ychetime">예상체결시간	string	6</param>
/// <param name="yeprice">예상체결가격	double	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	double	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="optcode">단축코드	string	8</param>
public record YOCOutBlock([Description("예상체결시간	string	6")] string ychetime, [Description("예상체결가격	double	6.2")] double yeprice, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	double	6.2")] double jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("단축코드	string	8")] string optcode);

/// <summary>
/// KOSPI예상체결: YS3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record YS3InBlock([Description("단축코드	string	6")] string shcode);

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
public record YS3OutBlock([Description("호가시간	string	6")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	long	12")] long yevolume, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	int	8")] int jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("예상매도호가	int	8")] int yofferho0, [Description("예상매수호가	int	8")] int ybidho0, [Description("예상매도호가수량	long	12")] long yofferrem0, [Description("예상매수호가수량	long	12")] long ybidrem0, [Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW예상체결: Ys3
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record Ys3InBlock([Description("단축코드	string	6")] string shcode);

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
public record Ys3OutBlock([Description("호가시간	string	6")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	long	12")] long yevolume, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	int	8")] int jnilchange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("예상매도호가	int	8")] int yofferho0, [Description("예상매수호가	int	8")] int ybidho0, [Description("예상매도호가수량	long	12")] long yofferrem0, [Description("예상매수호가수량	long	12")] long ybidrem0, [Description("단축코드	string	6")] string shcode);

