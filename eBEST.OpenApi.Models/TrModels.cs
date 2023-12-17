using eBEST.OpenApi.Blocks;

namespace eBEST.OpenApi.Models;

#region 업종

#region [업종] 시세

/// <summary>
/// 업종기간별추이
/// </summary>
[Path("/indtp/market-data", Description = "업종기간별추이")]
public class t1514 : TrBase
{
    /// 요청
    public t1514InBlock? t1514InBlock { get; set; }

    // 응답
    public t1514OutBlock? t1514OutBlock { get; set; }
    public t1514OutBlock1[]? t1514OutBlock1 { get; set; }
}

/// <summary>
/// 전체업종
/// </summary>
[Path("/indtp/market-data", Description = "전체업종")]
public class t8424 : TrBase
{
    /// 요청
    public t8424InBlock? t8424InBlock { get; set; }

    // 응답
    public t8424OutBlock[]? t8424OutBlock { get; set; }
}

/// <summary>
/// 예상지수
/// </summary>
[Path("/indtp/market-data", Description = "예상지수")]
public class t1485 : TrBase
{
    /// 요청
    public t1485InBlock? t1485InBlock { get; set; }

    // 응답
    public t1485OutBlock? t1485OutBlock { get; set; }
    public t1485OutBlock1[]? t1485OutBlock1 { get; set; }
}

/// <summary>
/// 업종현재가
/// </summary>
[Path("/indtp/market-data", Description = "업종현재가")]
public class t1511 : TrBase
{
    /// 요청
    public t1511InBlock? t1511InBlock { get; set; }

    // 응답
    public t1511OutBlock? t1511OutBlock { get; set; }
}

/// <summary>
/// 업종별종목시세
/// </summary>
[Path("/indtp/market-data", Description = "업종별종목시세")]
public class t1516 : TrBase
{
    /// 요청
    public t1516InBlock? t1516InBlock { get; set; }

    // 응답
    public t1516OutBlock? t1516OutBlock { get; set; }
    public t1516OutBlock1[]? t1516OutBlock1 { get; set; }
}
#endregion

#region [업종] 차트

/// <summary>
/// 업종챠트(종합)
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(종합)")]
public class t4203 : TrBase
{
    /// 요청
    public t4203InBlock? t4203InBlock { get; set; }

    // 응답
    public t4203OutBlock? t4203OutBlock { get; set; }
    public t4203OutBlock1[]? t4203OutBlock1 { get; set; }
}

/// <summary>
/// 업종차트(틱/n틱)
/// </summary>
[Path("/indtp/chart", Description = "업종차트(틱/n틱)")]
public class t8417 : TrBase
{
    /// 요청
    public t8417InBlock? t8417InBlock { get; set; }

    // 응답
    public t8417OutBlock? t8417OutBlock { get; set; }
    public t8417OutBlock1[]? t8417OutBlock1 { get; set; }
}

/// <summary>
/// 업종챠트(N분)
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(N분)")]
public class t8418 : TrBase
{
    /// 요청
    public t8418InBlock? t8418InBlock { get; set; }

    // 응답
    public t8418OutBlock? t8418OutBlock { get; set; }
    public t8418OutBlock1[]? t8418OutBlock1 { get; set; }
}

/// <summary>
/// 업종챠트(일주월)
/// </summary>
[Path("/indtp/chart", Description = "업종챠트(일주월)")]
public class t8419 : TrBase
{
    /// 요청
    public t8419InBlock? t8419InBlock { get; set; }

    // 응답
    public t8419OutBlock? t8419OutBlock { get; set; }
    public t8419OutBlock1[]? t8419OutBlock1 { get; set; }
}
#endregion

#endregion


#region 주식

#region [주식] 시세

/// <summary>
/// 주식현재가호가조회
/// </summary>
[Path("/stock/market-data", Description = "주식현재가호가조회")]
public class t1101 : TrBase
{
    /// 요청
    public t1101InBlock? t1101InBlock { get; set; }

    // 응답
    public t1101OutBlock? t1101OutBlock { get; set; }
}

/// <summary>
/// 주식현재가(시세)조회
/// </summary>
[Path("/stock/market-data", Description = "주식현재가(시세)조회")]
public class t1102 : TrBase
{
    /// 요청
    public t1102InBlock? t1102InBlock { get; set; }

    // 응답
    public t1102OutBlock? t1102OutBlock { get; set; }
}

/// <summary>
/// 주식현재가시세메모
/// </summary>
[Path("/stock/market-data", Description = "주식현재가시세메모")]
public class t1104 : TrBase
{
    /// 요청
    public t1104InBlock? t1104InBlock { get; set; }
    public t1104InBlock1[]? t1104InBlock1 { get; set; }

    // 응답
    public t1104OutBlock? t1104OutBlock { get; set; }
    public t1104OutBlock1[]? t1104OutBlock1 { get; set; }
}

/// <summary>
/// 주식피봇/디마크조회
/// </summary>
[Path("/stock/market-data", Description = "주식피봇/디마크조회")]
public class t1105 : TrBase
{
    /// 요청
    public t1105InBlock? t1105InBlock { get; set; }

    // 응답
    public t1105OutBlock? t1105OutBlock { get; set; }
}

/// <summary>
/// 시간외체결량
/// </summary>
[Path("/stock/market-data", Description = "시간외체결량")]
public class t1109 : TrBase
{
    /// 요청
    public t1109InBlock? t1109InBlock { get; set; }

    // 응답
    public t1109OutBlock? t1109OutBlock { get; set; }
    public t1109OutBlock1[]? t1109OutBlock1 { get; set; }
}

/// <summary>
/// 주식시간대별체결조회
/// </summary>
[Path("/stock/market-data", Description = "주식시간대별체결조회")]
public class t1301 : TrBase
{
    /// 요청
    public t1301InBlock? t1301InBlock { get; set; }

    // 응답
    public t1301OutBlock? t1301OutBlock { get; set; }
    public t1301OutBlock1[]? t1301OutBlock1 { get; set; }
}

/// <summary>
/// 주식분별주가조회
/// </summary>
[Path("/stock/market-data", Description = "주식분별주가조회")]
public class t1302 : TrBase
{
    /// 요청
    public t1302InBlock? t1302InBlock { get; set; }

    // 응답
    public t1302OutBlock? t1302OutBlock { get; set; }
    public t1302OutBlock1[]? t1302OutBlock1 { get; set; }
}

/// <summary>
/// 기간별주가
/// </summary>
[Path("/stock/market-data", Description = "기간별주가")]
public class t1305 : TrBase
{
    /// 요청
    public t1305InBlock? t1305InBlock { get; set; }

    // 응답
    public t1305OutBlock? t1305OutBlock { get; set; }
    public t1305OutBlock1[]? t1305OutBlock1 { get; set; }
}

/// <summary>
/// 주식시간대별체결조회챠트
/// </summary>
[Path("/stock/market-data", Description = "주식시간대별체결조회챠트")]
public class t1308 : TrBase
{
    /// 요청
    public t1308InBlock? t1308InBlock { get; set; }

    // 응답
    public t1308OutBlock1? t1308OutBlock1 { get; set; }
}

/// <summary>
/// 주식당일전일분틱조회
/// </summary>
[Path("/stock/market-data", Description = "주식당일전일분틱조회")]
public class t1310 : TrBase
{
    /// 요청
    public t1310InBlock? t1310InBlock { get; set; }

    // 응답
    public t1310OutBlock? t1310OutBlock { get; set; }
    public t1310OutBlock1[]? t1310OutBlock1 { get; set; }
}

/// <summary>
/// 관리/불성실/투자유의조회	
/// </summary>
[Path("/stock/market-data", Description = "관리/불성실/투자유의조회")]
public class t1404 : TrBase
{
    /// 요청
    public t1404InBlock? t1404InBlock { get; set; }

    // 응답
    public t1404OutBlock? t1404OutBlock { get; set; }
    public t1404OutBlock1[]? t1404OutBlock1 { get; set; }
}

/// <summary>
/// 투자경고/매매정지/정리매매조회
/// </summary>
[Path("/stock/market-data", Description = "투자경고/매매정지/정리매매조회")]
public class t1405 : TrBase
{
    /// 요청
    public t1405InBlock? t1405InBlock { get; set; }

    // 응답
    public t1405OutBlock? t1405OutBlock { get; set; }
    public t1405OutBlock1[]? t1405OutBlock1 { get; set; }
}

/// <summary>
/// 초저유동성조회
/// </summary>
[Path("/stock/market-data", Description = "초저유동성조회")]
public class t1410 : TrBase
{
    /// 요청
    public t1410InBlock? t1410InBlock { get; set; }

    // 응답
    public t1410OutBlock? t1410OutBlock { get; set; }
    public t1410OutBlock1[]? t1410OutBlock1 { get; set; }
}

/// <summary>
/// 상/하한	
/// </summary>
[Path("/stock/market-data", Description = "상/하한")]
public class t1422 : TrBase
{
    /// 요청
    public t1422InBlock? t1422InBlock { get; set; }

    // 응답
    public t1422OutBlock? t1422OutBlock { get; set; }
    public t1422OutBlock1[]? t1422OutBlock1 { get; set; }
}

/// <summary>
/// 상/하한가직전
/// </summary>
[Path("/stock/market-data", Description = "상/하한가직전")]
public class t1427 : TrBase
{
    /// 요청
    public t1427InBlock? t1427InBlock { get; set; }

    // 응답
    public t1427OutBlock? t1427OutBlock { get; set; }
    public t1427OutBlock1[]? t1427OutBlock1 { get; set; }
}

/// <summary>
/// 신고/신저가
/// </summary>
[Path("/stock/market-data", Description = "신고/신저가")]
public class t1442 : TrBase
{
    /// 요청
    public t1442InBlock? t1442InBlock { get; set; }

    // 응답
    public t1442OutBlock? t1442OutBlock { get; set; }
    public t1442OutBlock1[]? t1442OutBlock1 { get; set; }
}

/// <summary>
/// 가격대별매매비중조회
/// </summary>
[Path("/stock/market-data", Description = "가격대별매매비중조회")]
public class t1449 : TrBase
{
    /// 요청
    public t1449InBlock? t1449InBlock { get; set; }

    // 응답
    public t1449OutBlock? t1449OutBlock { get; set; }
    public t1449OutBlock1[]? t1449OutBlock1 { get; set; }
}

/// <summary>
/// 시간대별호가잔량추이
/// </summary>
[Path("/stock/market-data", Description = "시간대별호가잔량추이")]
public class t1471 : TrBase
{
    /// 요청
    public t1471InBlock? t1471InBlock { get; set; }

    // 응답
    public t1471OutBlock? t1471OutBlock { get; set; }
    public t1471OutBlock1[]? t1471OutBlock1 { get; set; }
}

/// <summary>
/// 체결강도추이
/// </summary>
[Path("/stock/market-data", Description = "체결강도추이")]
public class t1475 : TrBase
{
    /// 요청
    public t1475InBlock? t1475InBlock { get; set; }

    // 응답
    public t1475OutBlock? t1475OutBlock { get; set; }
    public t1475OutBlock1[]? t1475OutBlock1 { get; set; }
}

/// <summary>
/// 시간별예상체결가
/// </summary>
[Path("/stock/market-data", Description = "시간별예상체결가")]
public class t1486 : TrBase
{
    /// 요청
    public t1486InBlock? t1486InBlock { get; set; }

    // 응답
    public t1486OutBlock? t1486OutBlock { get; set; }
    public t1486OutBlock1[]? t1486OutBlock1 { get; set; }
}

/// <summary>
/// 예상체결가등락율상위조회
/// </summary>
[Path("/stock/market-data", Description = "예상체결가등락율상위조회")]
public class t1488 : TrBase
{
    /// 요청
    public t1488InBlock? t1488InBlock { get; set; }

    // 응답
    public t1488OutBlock? t1488OutBlock { get; set; }
    public t1488OutBlock1[]? t1488OutBlock1 { get; set; }
}

/// <summary>
/// API용주식멀티현재가조회
/// </summary>
[Path("/stock/market-data", Description = "API용주식멀티현재가조회")]
public class t8407 : TrBase
{
    /// 요청
    public t8407InBlock? t8407InBlock { get; set; }

    // 응답
    public t8407OutBlock1[]? t8407OutBlock1 { get; set; }
}

/// <summary>
/// 주식마스터조회API용
/// </summary>
[Path("/stock/market-data", Description = "주식마스터조회API용")]
public class t9945 : TrBase
{
    /// 요청
    public t9945InBlock? t9945InBlock { get; set; }

    // 응답
    public t9945OutBlock? t9945OutBlock { get; set; }
}
#endregion

#region [주식] 거래원

/// <summary>
/// 종목별상위회원사
/// </summary>
[Path("/stock/exchange", Description = "종목별상위회원사")]
public class t1752 : TrBase
{
    /// 요청
    public t1752InBlock? t1752InBlock { get; set; }

    // 응답
    public t1752OutBlock? t1752OutBlock { get; set; }
    public t1752OutBlock1[]? t1752OutBlock1 { get; set; }
}

/// <summary>
/// 회원사리스트
/// </summary>
[Path("/stock/exchange", Description = "회원사리스트")]
public class t1764 : TrBase
{
    /// 요청
    public t1764InBlock? t1764InBlock { get; set; }

    // 응답
    public t1764OutBlock? t1764OutBlock { get; set; }
}

/// <summary>
/// 종목별회원사추이
/// </summary>
[Path("/stock/exchange", Description = "종목별회원사추이")]
public class t1771 : TrBase
{
    /// 요청
    public t1771InBlock? t1771InBlock { get; set; }

    // 응답
    public t1771OutBlock? t1771OutBlock { get; set; }
    public t1771OutBlock2[]? t1771OutBlock2 { get; set; }
}

#endregion

#region [주식] 투자정보

/// <summary>
/// 뉴스본문
/// </summary>
[Path("/stock/investinfo", Description = "뉴스본문")]
public class t3102 : TrBase
{
    /// 요청
    public t3102InBlock? t3102InBlock { get; set; }

    // 응답
    public t3102OutBlock[]? t3102OutBlock { get; set; }
    public t3102OutBlock1[]? t3102OutBlock1 { get; set; }
    public t3102OutBlock2? t3102OutBlock2 { get; set; }
}

/// <summary>
/// 종목별증시일정
/// </summary>
[Path("/stock/investinfo", Description = "종목별증시일정")]
public class t3202 : TrBase
{
    /// 요청
    public t3202InBlock? t3202InBlock { get; set; }

    // 응답
    public t3202OutBlock[]? t3202OutBlock { get; set; }
}

/// <summary>
/// FNG_요약
/// </summary>
[Path("/stock/investinfo", Description = "FNG_요약")]
public class t3320 : TrBase
{
    /// 요청
    public t3320InBlock? t3320InBlock { get; set; }

    // 응답
    public t3320OutBlock? t3320OutBlock { get; set; }
    public t3320OutBlock1? t3320OutBlock1 { get; set; }
}

/// <summary>
/// 재무순위종합
/// </summary>
[Path("/stock/investinfo", Description = "재무순위종합")]
public class t3341 : TrBase
{
    /// 요청
    public t3341InBlock? t3341InBlock { get; set; }

    // 응답
    public t3341OutBlock? t3341OutBlock { get; set; }
    public t3341OutBlock1[]? t3341OutBlock1 { get; set; }
}

/// <summary>
/// 투자의견
/// </summary>
[Path("/stock/investinfo", Description = "투자의견")]
public class t3401 : TrBase
{
    /// 요청
    public t3401InBlock? t3401InBlock { get; set; }

    // 응답
    public t3401OutBlock? t3401OutBlock { get; set; }
    public t3401OutBlock1[]? t3401OutBlock1 { get; set; }
}

/// <summary>
/// 해외실시간지수
/// </summary>
[Path("/stock/investinfo", Description = "해외실시간지수")]
public class t3518 : TrBase
{
    /// 요청
    public t3518InBlock? t3518InBlock { get; set; }

    // 응답
    public t3518OutBlock? t3518OutBlock { get; set; }
    public t3518OutBlock1[]? t3518OutBlock1 { get; set; }
}

/// <summary>
/// 해외지수조회(API용)	
/// </summary>
[Path("/stock/investinfo", Description = "해외지수조회(API용)")]
public class t3521 : TrBase
{
    /// 요청
    public t3521InBlock? t3521InBlock { get; set; }

    // 응답
    public t3521OutBlock? t1771OutBlock { get; set; }
}

/// <summary>
/// 증시주변자금추이
/// </summary>
[Path("/stock/investinfo", Description = "증시주변자금추이")]
public class t8428 : TrBase
{
    /// 요청
    public t8428InBlock? t8428InBlock { get; set; }

    // 응답
    public t8428OutBlock? t8428OutBlock { get; set; }
    public t8428OutBlock1[]? t8428OutBlock1 { get; set; }
}
#endregion

#region [주식] 프로그램

/// <summary>
/// 프로그램매매종합조회
/// </summary>
[Path("/stock/program", Description = "프로그램매매종합조회")]
public class t1631 : TrBase
{
    /// 요청
    public t1631InBlock? t1631InBlock { get; set; }

    // 응답
    public t1631OutBlock? t1631OutBlock { get; set; }
    public t1631OutBlock1[]? t1631OutBlock1 { get; set; }
}

/// <summary>
/// 시간대별프로그램매매추이
/// </summary>
[Path("/stock/program", Description = "시간대별프로그램매매추이")]
public class t1632 : TrBase
{
    /// 요청
    public t1632InBlock? t1632InBlock { get; set; }

    // 응답
    public t1632OutBlock? t1632OutBlock { get; set; }
    public t1632OutBlock1[]? t1632OutBlock1 { get; set; }
}

/// <summary>
/// 기간별프로그램매매추이
/// </summary>
[Path("/stock/program", Description = "기간별프로그램매매추이")]
public class t1633 : TrBase
{
    /// 요청
    public t1633InBlock? t1633InBlock { get; set; }

    // 응답
    public t1633OutBlock? t1633OutBlock { get; set; }
    public t1633OutBlock1[]? t1633OutBlock1 { get; set; }
}

/// <summary>
/// 종목별프로그램매매동향
/// </summary>
[Path("/stock/program", Description = "종목별프로그램매매동향")]
public class t1636 : TrBase
{
    /// 요청
    public t1636InBlock? t1636InBlock { get; set; }

    // 응답
    public t1636OutBlock? t1636OutBlock { get; set; }
    public t1636OutBlock1[]? t1636OutBlock1 { get; set; }
}

/// <summary>
/// 종목별프로그램매매추이
/// </summary>
[Path("/stock/program", Description = "종목별프로그램매매추이")]
public class t1637 : TrBase
{
    /// 요청
    public t1637InBlock? t1637InBlock { get; set; }

    // 응답
    public t1637OutBlock? t1637OutBlock { get; set; }
    public t1637OutBlock1[]? t1637OutBlock1 { get; set; }
}

/// <summary>
/// 프로그램매매종합조회(미니)
/// </summary>
[Path("/stock/program", Description = "프로그램매매종합조회(미니)")]
public class t1640 : TrBase
{
    /// 요청
    public t1640InBlock? t1640InBlock { get; set; }

    // 응답
    public t1640OutBlock? t1640OutBlock { get; set; }
}

/// <summary>
/// 시간대별프로그램매매추이(차트)
/// </summary>
[Path("/stock/program", Description = "시간대별프로그램매매추이(차트)")]
public class t1662 : TrBase
{
    /// 요청
    public t1662InBlock? t1662InBlock { get; set; }

    // 응답
    public t1662OutBlock[]? t1662OutBlock { get; set; }
}
#endregion

#region [주식] 투자자

/// <summary>
/// 투자자별종합
/// </summary>
[Path("/stock/investor", Description = "투자자별종합")]
public class t1601 : TrBase
{
    /// 요청
    public t1601InBlock? t1601InBlock { get; set; }

    // 응답
    public t1601OutBlock1? t1601OutBlock1 { get; set; }
    public t1601OutBlock2? t1601OutBlock2 { get; set; }
    public t1601OutBlock3? t1601OutBlock3 { get; set; }
    public t1601OutBlock4? t1601OutBlock4 { get; set; }
    public t1601OutBlock5? t1601OutBlock5 { get; set; }
    public t1601OutBlock6? t1601OutBlock6 { get; set; }
}

/// <summary>
/// 시간대별투자자매매추이
/// </summary>
[Path("/stock/investor", Description = "시간대별투자자매매추이")]
public class t1602 : TrBase
{
    /// 요청
    public t1602InBlock? t1602InBlock { get; set; }

    // 응답
    public t1602OutBlock? t1602OutBlock { get; set; }
    public t1602OutBlock1[]? t1602OutBlock1 { get; set; }
}

/// <summary>
/// 시간대별투자자매매추이상세
/// </summary>
[Path("/stock/investor", Description = "시간대별투자자매매추이상세")]
public class t1603 : TrBase
{
    /// 요청
    public t1603InBlock? t1603InBlock { get; set; }

    // 응답
    public t1603OutBlock? t1603OutBlock { get; set; }
    public t1603OutBlock1[]? t1603OutBlock1 { get; set; }
}

/// <summary>
/// 투자자매매종합1
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합1")]
public class t1615 : TrBase
{
    /// 요청
    public t1615InBlock? t1615InBlock { get; set; }

    // 응답
    public t1615OutBlock? t1615OutBlock { get; set; }
    public t1615OutBlock1[]? t1615OutBlock1 { get; set; }
}

/// <summary>
/// 투자자매매종합2
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합2")]
public class t1617 : TrBase
{
    /// 요청
    public t1617InBlock? t1617InBlock { get; set; }

    // 응답
    public t1617OutBlock? t1617OutBlock { get; set; }
    public t1617OutBlock1[]? t1617OutBlock1 { get; set; }
}

/// <summary>
/// 업종별분별투자자매매동향(챠트용)
/// </summary>
[Path("/stock/investor", Description = "업종별분별투자자매매동향(챠트용)")]
public class t1621 : TrBase
{
    /// 요청
    public t1621InBlock? t1621InBlock { get; set; }

    // 응답
    public t1621OutBlock? t1621OutBlock { get; set; }
    public t1621OutBlock1[]? t1621OutBlock1 { get; set; }
}

/// <summary>
/// 투자자매매종합(챠트)
/// </summary>
[Path("/stock/investor", Description = "투자자매매종합(챠트)")]
public class t1664 : TrBase
{
    /// 요청
    public t1664InBlock? t1637InBlock { get; set; }

    // 응답
    public t1664OutBlock1[]? t1664OutBlock1 { get; set; }
}
#endregion

#region [주식] 외인/기관

/// <summary>
/// 외인기관종목별동향
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향")]
public class t1702 : TrBase
{
    /// 요청
    public t1702InBlock? t1702InBlock { get; set; }

    // 응답
    public t1702OutBlock? t1702OutBlock { get; set; }
    public t1702OutBlock1[]? t1702OutBlock1 { get; set; }
}

/// <summary>
/// 외인기관종목별동향
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향")]
public class t1716 : TrBase
{
    /// 요청
    public t1716InBlock? t1716InBlock { get; set; }

    // 응답
    public t1716OutBlock[]? t1716OutBlock { get; set; }
}

/// <summary>
/// 외인기관종목별동향
/// </summary>
[Path("/stock/frgr-itt", Description = "외인기관종목별동향")]
public class t1717 : TrBase
{
    /// 요청
    public t1717InBlock? t1717InBlock { get; set; }

    // 응답
    public t1717OutBlock[]? t1717OutBlock { get; set; }
}
#endregion

#region [주식] ELW

/// <summary>
/// ELW현재가(시세)조회
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(시세)조회")]
public class t1950 : TrBase
{
    /// 요청
    public t1950InBlock? t1950InBlock { get; set; }

    // 응답
    public t1950OutBlock? t1950OutBlock { get; set; }
    public t1950OutBlock1[]? t1950OutBlock1 { get; set; }
}

/// <summary>
/// ELW시간대별체결조회
/// </summary>
[Path("/stock/elw", Description = "ELW시간대별체결조회")]
public class t1951 : TrBase
{
    /// 요청
    public t1951InBlock? t1951InBlock { get; set; }

    // 응답
    public t1951OutBlock? t1951OutBlock { get; set; }
    public t1951OutBlock1[]? t1951OutBlock1 { get; set; }
}

/// <summary>
/// ELW일별주가
/// </summary>
[Path("/stock/elw", Description = "ELW일별주가")]
public class t1954 : TrBase
{
    /// 요청
    public t1954InBlock? t1954InBlock { get; set; }

    // 응답
    public t1954OutBlock? t1954OutBlock { get; set; }
    public t1954OutBlock1[]? t1954OutBlock1 { get; set; }
}

/// <summary>
/// ELW현재가(확정지급액)조회
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(확정지급액)조회")]
public class t1956 : TrBase
{
    /// 요청
    public t1956InBlock? t1956InBlock { get; set; }

    // 응답
    public t1956OutBlock? t1956OutBlock { get; set; }
    public t1956OutBlock1[]? t1956OutBlock1 { get; set; }
}

/// <summary>
/// ELW종목비교
/// </summary>
[Path("/stock/elw", Description = "ELW종목비교")]
public class t1958 : TrBase
{
    /// 요청
    public t1958InBlock? t1958InBlock { get; set; }

    // 응답
    public t1958OutBlock? t1958OutBlock { get; set; }
    public t1958OutBlock1? t1958OutBlock1 { get; set; }
    public t1958OutBlock2? t1958OutBlock2 { get; set; }
}

/// <summary>
/// LP대상종목정보조회
/// </summary>
[Path("/stock/elw", Description = "LP대상종목정보조회")]
public class t1959 : TrBase
{
    /// 요청
    public t1959InBlock? t1959InBlock { get; set; }

    // 응답
    public t1959OutBlock1[]? t1959OutBlock1 { get; set; }
}

/// <summary>
/// ELW등락율상위
/// </summary>
[Path("/stock/elw", Description = "ELW등락율상위")]
public class t1960 : TrBase
{
    /// 요청
    public t1960InBlock? t1960InBlock { get; set; }

    // 응답
    public t1960OutBlock? t1960OutBlock { get; set; }
    public t1960OutBlock1[]? t1960OutBlock1 { get; set; }
}

/// <summary>
/// ELW거래량상위
/// </summary>
[Path("/stock/elw", Description = "ELW거래량상위")]
public class t1961 : TrBase
{
    /// 요청
    public t1961InBlock? t1961InBlock { get; set; }

    // 응답
    public t1961OutBlock? t1961OutBlock { get; set; }
    public t1961OutBlock1[]? t1961OutBlock1 { get; set; }
}

/// <summary>
/// ELW전광판
/// </summary>
[Path("/stock/elw", Description = "ELW전광판")]
public class t1964 : TrBase
{
    /// 요청
    public t1964InBlock? t1964InBlock { get; set; }

    // 응답
    public t1964OutBlock1[]? t1964OutBlock1 { get; set; }
}

/// <summary>
/// ELW거래대금상위
/// </summary>
[Path("/stock/elw", Description = "ELW거래대금상위")]
public class t1966 : TrBase
{
    /// 요청
    public t1966InBlock? t1966InBlock { get; set; }

    // 응답
    public t1966OutBlock? t1966OutBlock { get; set; }
    public t1966OutBlock1[]? t1966OutBlock1 { get; set; }
}

/// <summary>
/// ELW지표검색
/// </summary>
[Path("/stock/elw", Description = "ELW지표검색")]
public class t1969 : TrBase
{
    /// 요청
    public t1969InBlock? t1969InBlock { get; set; }

    // 응답
    public t1969OutBlock? t1969OutBlock { get; set; }
    public t1969OutBlock1[]? t1969OutBlock1 { get; set; }
}

/// <summary>
/// ELW현재가호가조회
/// </summary>
[Path("/stock/elw", Description = "ELW현재가호가조회")]
public class t1971 : TrBase
{
    /// 요청
    public t1971InBlock? t1971InBlock { get; set; }

    // 응답
    public t1971OutBlock? t1971OutBlock { get; set; }
}

/// <summary>
/// ELW현재가(거래원)조회
/// </summary>
[Path("/stock/elw", Description = "ELW현재가(거래원)조회")]
public class t1972 : TrBase
{
    /// 요청
    public t1972InBlock? t1972InBlock { get; set; }

    // 응답
    public t1972OutBlock? t1972OutBlock { get; set; }
}

/// <summary>
/// ELW시간대별예상체결조회
/// </summary>
[Path("/stock/elw", Description = "ELW시간대별예상체결조회")]
public class t1973 : TrBase
{
    /// 요청
    public t1973InBlock? t1973InBlock { get; set; }

    // 응답
    public t1973OutBlock? t1973OutBlock { get; set; }
    public t1973OutBlock1[]? t1973OutBlock1 { get; set; }
}

/// <summary>
/// ELW기초자산동일종목
/// </summary>
[Path("/stock/elw", Description = "ELW기초자산동일종목")]
public class t1974 : TrBase
{
    /// 요청
    public t1974InBlock? t1974InBlock { get; set; }

    // 응답
    public t1974OutBlock? t1974OutBlock { get; set; }
    public t1974OutBlock1[]? t1974OutBlock1 { get; set; }
}

/// <summary>
/// 기초자산리스트조회
/// </summary>
[Path("/stock/elw", Description = "기초자산리스트조회")]
public class t1988 : TrBase
{
    /// 요청
    public t1988InBlock? t1988InBlock { get; set; }

    // 응답
    public t1988OutBlock? t1988OutBlock { get; set; }
    public t1988OutBlock1[]? t1988OutBlock1 { get; set; }
}

/// <summary>
/// ELW종목조회
/// </summary>
[Path("/stock/elw", Description = "ELW종목조회")]
public class t8431 : TrBase
{
    /// 요청
    public t8431InBlock? t8431InBlock { get; set; }

    // 응답
    public t8431OutBlock[]? t8431OutBlock { get; set; }
}

/// <summary>
/// 기초자산리스트조회
/// </summary>
[Path("/stock/elw", Description = "기초자산리스트조회")]
public class t9905 : TrBase
{
    /// 요청
    public t9905InBlock? t9905InBlock { get; set; }

    // 응답
    public t9905OutBlock1[]? t9905OutBlock1 { get; set; }
}

/// <summary>
/// 만기월조회
/// </summary>
[Path("/stock/elw", Description = "만기월조회")]
public class t9907 : TrBase
{
    /// 요청
    public t9907InBlock? t9907InBlock { get; set; }

    // 응답
    public t9907OutBlock1[]? t9907OutBlock1 { get; set; }
}

/// <summary>
/// ELW마스터조회API용
/// </summary>
[Path("/stock/elw", Description = "ELW마스터조회API용")]
public class t9942 : TrBase
{
    /// 요청
    public t9942InBlock? t9942InBlock { get; set; }

    // 응답
    public t9942OutBlock[]? t9942OutBlock { get; set; }
}
#endregion

#region [주식] ETF

/// <summary>
/// ETF현재가(시세)조회
/// </summary>
[Path("/stock/etf", Description = "ETF현재가(시세)조회")]
public class t1901 : TrBase
{
    /// 요청
    public t1901InBlock? t1901InBlock { get; set; }

    // 응답
    public t1901OutBlock? t1901OutBlock { get; set; }
}

/// <summary>
/// ETF시간별추이
/// </summary>
[Path("/stock/etf", Description = "ETF시간별추이")]
public class t1902 : TrBase
{
    /// 요청
    public t1902InBlock? t1902InBlock { get; set; }

    // 응답
    public t1902OutBlock? t1902OutBlock { get; set; }
    public t1902OutBlock1[]? t1902OutBlock1 { get; set; }
}

/// <summary>
/// ETF일별추이
/// </summary>
[Path("/stock/etf", Description = "ETF일별추이")]
public class t1903 : TrBase
{
    /// 요청
    public t1903InBlock? t1903InBlock { get; set; }

    // 응답
    public t1903OutBlock? t1903OutBlock { get; set; }
    public t1903OutBlock1[]? t1903OutBlock1 { get; set; }
}

/// <summary>
/// ETF구성종목조회
/// </summary>
[Path("/stock/etf", Description = "ETF구성종목조회")]
public class t1904 : TrBase
{
    /// 요청
    public t1904InBlock? t1904InBlock { get; set; }

    // 응답
    public t1904OutBlock? t1904OutBlock { get; set; }
    public t1904OutBlock1[]? t1904OutBlock1 { get; set; }
}

/// <summary>
/// ETFLP호가
/// </summary>
[Path("/stock/etf", Description = "ETFLP호가")]
public class t1906 : TrBase
{
    /// 요청
    public t1906InBlock? t1906InBlock { get; set; }

    // 응답
    public t1906OutBlock? t1906OutBlock { get; set; }
}
#endregion

#region [주식] 섹터

/// <summary>
/// 테마별종목
/// </summary>
[Path("/stock/sector", Description = "테마별종목")]
public class t1531 : TrBase
{
    /// 요청
    public t1531InBlock? t1531InBlock { get; set; }

    // 응답
    public t1531OutBlock[]? t1531OutBlock { get; set; }
}

/// <summary>
/// 종목별테마
/// </summary>
[Path("/stock/sector", Description = "종목별테마")]
public class t1532 : TrBase
{
    /// 요청
    public t1532InBlock? t1532InBlock { get; set; }

    // 응답
    public t1532OutBlock[]? t1532OutBlock { get; set; }
}

/// <summary>
/// 특이테마
/// </summary>
[Path("/stock/sector", Description = "특이테마")]
public class t1533 : TrBase
{
    /// 요청
    public t1533InBlock? t1533InBlock { get; set; }

    // 응답
    public t1533OutBlock? t1533OutBlock { get; set; }
    public t1533OutBlock1[]? t1533OutBlock1 { get; set; }
}

/// <summary>
/// 테마종목별시세조회
/// </summary>
[Path("/stock/sector", Description = "테마종목별시세조회")]
public class t1537 : TrBase
{
    /// 요청
    public t1537InBlock? t1537InBlock { get; set; }

    // 응답
    public t1537OutBlock? t1537OutBlock { get; set; }
    public t1537OutBlock1[]? t1537OutBlock1 { get; set; }
}

/// <summary>
/// 전체테마
/// </summary>
[Path("/stock/sector", Description = "전체테마")]
public class t8425 : TrBase
{
    /// 요청
    public t8425InBlock? t8425InBlock { get; set; }

    // 응답
    public t8425OutBlock[]? t8425OutBlock { get; set; }
}
#endregion

#region [주식] 종목검색

/// <summary>
/// 신호조회
/// </summary>
[Path("/stock/item-search", Description = "신호조회")]
public class t1809 : TrBase
{
    /// 요청
    public t1809InBlock? t1809InBlock { get; set; }

    // 응답
    public t1809OutBlock? t1809OutBlock { get; set; }
    public t1809OutBlock1[]? t1809OutBlock1 { get; set; }
}

/// <summary>
/// 종목Q클릭검색(씽큐스마트)
/// </summary>
[Path("/stock/item-search", Description = "종목Q클릭검색(씽큐스마트)")]
public class t1825 : TrBase
{
    /// 요청
    public t1825InBlock? t1825InBlock { get; set; }

    // 응답
    public t1825OutBlock? t1825OutBlock { get; set; }
    public t1825OutBlock1[]? t1825OutBlock1 { get; set; }
}

/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트)
/// </summary>
[Path("/stock/item-search", Description = "종목Q클릭검색리스트조회(씽큐스마트)")]
public class t1826 : TrBase
{
    /// 요청
    public t1826InBlock? t1826InBlock { get; set; }

    // 응답
    public t1826OutBlock[]? t1826OutBlock { get; set; }
}
#endregion

#region [주식] 상위종목

/// <summary>
/// 등락율상위
/// </summary>
[Path("/stock/high-item", Description = "등락율상위")]
public class t1441 : TrBase
{
    /// 요청
    public t1441InBlock? t1441InBlock { get; set; }

    // 응답
    public t1441OutBlock? t1441OutBlock { get; set; }
    public t1441OutBlock1[]? t1441OutBlock1 { get; set; }
}

/// <summary>
/// 시가총액상위
/// </summary>
[Path("/stock/high-item", Description = "시가총액상위")]
public class t1444 : TrBase
{
    /// 요청
    public t1444InBlock? t1444InBlock { get; set; }

    // 응답
    public t1444OutBlock? t1444OutBlock { get; set; }
    public t1444OutBlock1[]? t1444OutBlock1 { get; set; }
}

/// <summary>
/// 거래량상위
/// </summary>
[Path("/stock/high-item", Description = "거래량상위")]
public class t1452 : TrBase
{
    /// 요청
    public t1452InBlock? t1452InBlock { get; set; }

    // 응답
    public t1452OutBlock? t1452OutBlock { get; set; }
    public t1452OutBlock1[]? t1452OutBlock1 { get; set; }
}

/// <summary>
/// 거래대금상위
/// </summary>
[Path("/stock/high-item", Description = "거래대금상위")]
public class t1463 : TrBase
{
    /// 요청
    public t1463InBlock? t1463InBlock { get; set; }

    // 응답
    public t1463OutBlock? t1463OutBlock { get; set; }
    public t1463OutBlock1[]? t1463OutBlock1 { get; set; }
}

/// <summary>
/// 전일동시간대비거래급증
/// </summary>
[Path("/stock/high-item", Description = "전일동시간대비거래급증")]
public class t1466 : TrBase
{
    /// 요청
    public t1466InBlock? t1466InBlock { get; set; }

    // 응답
    public t1466OutBlock? t1466OutBlock { get; set; }
    public t1466OutBlock1[]? t1466OutBlock1 { get; set; }
}

/// <summary>
/// 시간외등락율상위
/// </summary>
[Path("/stock/high-item", Description = "시간외등락율상위")]
public class t1481 : TrBase
{
    /// 요청
    public t1481InBlock? t1481InBlock { get; set; }

    // 응답
    public t1481OutBlock? t1481OutBlock { get; set; }
    public t1481OutBlock1[]? t1481OutBlock1 { get; set; }
}

/// <summary>
/// 시간외거래량상위
/// </summary>
[Path("/stock/high-item", Description = "시간외거래량상위")]
public class t1482 : TrBase
{
    /// 요청
    public t1482InBlock? t1482InBlock { get; set; }

    // 응답
    public t1482OutBlock? t1482OutBlock { get; set; }
    public t1482OutBlock1[]? t1482OutBlock1 { get; set; }
}

/// <summary>
/// 예상체결량상위조회
/// </summary>
[Path("/stock/high-item", Description = "예상체결량상위조회")]
public class t1489 : TrBase
{
    /// 요청
    public t1489InBlock? t1489InBlock { get; set; }

    // 응답
    public t1489OutBlock? t1489OutBlock { get; set; }
    public t1489OutBlock1[]? t1489OutBlock1 { get; set; }
}

/// <summary>
/// 단일가예상등락율상위
/// </summary>
[Path("/stock/high-item", Description = "단일가예상등락율상위")]
public class t1492 : TrBase
{
    /// 요청
    public t1492InBlock? t1492InBlock { get; set; }

    // 응답
    public t1492OutBlock? t1492OutBlock { get; set; }
    public t1492OutBlock1[]? t1492OutBlock1 { get; set; }
}
#endregion

#region [주식] 차트

/// <summary>
/// 기간별투자자매매추이(챠트)
/// </summary>
[Path("/stock/chart", Description = "기간별투자자매매추이(챠트)")]
public class t1665 : TrBase
{
    /// 요청
    public t1665InBlock? t1665InBlock { get; set; }

    // 응답
    public t1665OutBlock? t1665OutBlock { get; set; }
    public t1665OutBlock1[]? t1665OutBlock1 { get; set; }
}

/// <summary>
/// API전용주식챠트(일주월년)
/// </summary>
[Path("/stock/chart", Description = "API전용주식챠트(일주월년)")]
public class t8410 : TrBase
{
    /// 요청
    public t8410InBlock? t8410InBlock { get; set; }

    // 응답
    public t8410OutBlock? t8410OutBlock { get; set; }
    public t8410OutBlock1[]? t8410OutBlock1 { get; set; }
}

/// <summary>
/// 주식챠트(틱/n틱)
/// </summary>
[Path("/stock/chart", Description = "주식챠트(틱/n틱)")]
public class t8411 : TrBase
{
    /// 요청
    public t8411InBlock? t8411InBlock { get; set; }

    // 응답
    public t8411OutBlock? t8411OutBlock { get; set; }
    public t8411OutBlock1[]? t8411OutBlock1 { get; set; }
}

/// <summary>
/// 주식챠트(N분)
/// </summary>
[Path("/stock/chart", Description = "주식챠트(N분)")]
public class t8412 : TrBase
{
    /// 요청
    public t8412InBlock? t8412InBlock { get; set; }

    // 응답
    public t8412OutBlock? t8412OutBlock { get; set; }
    public t8412OutBlock1[]? t8412OutBlock1 { get; set; }
}
#endregion

#region [주식] 기타

/// <summary>
/// 예탁담보융자가능종목현황조회
/// </summary>
[Path("/stock/etc", Description = "예탁담보융자가능종목현황조회")]
public class CLNAQ00100 : TrBase
{
    /// 요청
    public CLNAQ00100InBlock1? CLNAQ00100InBlock1 { get; set; }

    // 응답
    public CLNAQ00100OutBlock1? CLNAQ00100OutBlock1 { get; set; }
    public CLNAQ00100OutBlock2[]? CLNAQ00100OutBlock2 { get; set; }
}

/// <summary>
/// 신규상장종목조회
/// </summary>
[Path("/stock/etc", Description = "신규상장종목조회")]
public class t1403 : TrBase
{
    /// 요청
    public t1403InBlock? t1403InBlock { get; set; }

    // 응답
    public t1403OutBlock? t1403OutBlock { get; set; }
    public t1403OutBlock1[]? t1403OutBlock1 { get; set; }
}

/// <summary>
/// 증거금율별종목조회
/// </summary>
[Path("/stock/etc", Description = "증거금율별종목조회")]
public class t1411 : TrBase
{
    /// 요청
    public t1411InBlock? t1411InBlock { get; set; }

    // 응답
    public t1411OutBlock? t1411OutBlock { get; set; }
    public t1411OutBlock1[]? t1411OutBlock1 { get; set; }
}

/// <summary>
/// 종목별잔량/사전공시
/// </summary>
[Path("/stock/etc", Description = "종목별잔량/사전공시")]
public class t1638 : TrBase
{
    /// 요청
    public t1638InBlock? t1638InBlock { get; set; }

    // 응답
    public t1638OutBlock[]? t1638OutBlock { get; set; }
}

/// <summary>
/// 신용거래동향
/// </summary>
[Path("/stock/etc", Description = "신용거래동향")]
public class t1921 : TrBase
{
    /// 요청
    public t1921InBlock? t1921InBlock { get; set; }

    // 응답
    public t1921OutBlock? t1921OutBlock { get; set; }
    public t1921OutBlock1[]? t1921OutBlock1 { get; set; }
}

/// <summary>
/// 종목별신용정보
/// </summary>
[Path("/stock/etc", Description = "종목별신용정보")]
public class t1926 : TrBase
{
    /// 요청
    public t1926InBlock? t1926InBlock { get; set; }

    // 응답
    public t1926OutBlock? t1926OutBlock { get; set; }
}

/// <summary>
/// 공매도일별추이
/// </summary>
[Path("/stock/etc", Description = "공매도일별추이")]
public class t1927 : TrBase
{
    /// 요청
    public t1927InBlock? t1927InBlock { get; set; }

    // 응답
    public t1927OutBlock? t1927OutBlock { get; set; }
    public t1927OutBlock1[]? t1927OutBlock1 { get; set; }
}

/// <summary>
/// 종목별대차거래일간추이
/// </summary>
[Path("/stock/etc", Description = "종목별대차거래일간추이")]
public class t1941 : TrBase
{
    /// 요청
    public t1941InBlock? t1941InBlock { get; set; }

    // 응답
    public t1941OutBlock1[]? t1941OutBlock1 { get; set; }
}

/// <summary>
/// 주식종목조회
/// </summary>
[Path("/stock/etc", Description = "주식종목조회")]
public class t8430 : TrBase
{
    /// 요청
    public t8430InBlock? t8430InBlock { get; set; }

    // 응답
    public t8430OutBlock[]? t8430OutBlock { get; set; }
}

/// <summary>
/// 주식종목조회 API용
/// </summary>
[Path("/stock/etc", Description = "주식종목조회 API용")]
public class t8436 : TrBase
{
    /// 요청
    public t8436InBlock? t8436InBlock { get; set; }

    // 응답
    public t8436OutBlock[]? t8436OutBlock { get; set; }
}
#endregion

#region [주식] 계좌

/// <summary>
/// 계좌 거래내역
/// </summary>
[Path("/stock/accno", Description = "계좌 거래내역")]
public class CDPCQ04700 : TrBase
{
    /// 요청
    public CDPCQ04700InBlock1? CDPCQ04700InBlock1 { get; set; }

    // 응답
    public CDPCQ04700OutBlock1? CDPCQ04700OutBlock1 { get; set; }
    public CDPCQ04700OutBlock2? CDPCQ04700OutBlock2 { get; set; }
    public CDPCQ04700OutBlock3[]? CDPCQ04700OutBlock3 { get; set; }
    public CDPCQ04700OutBlock4? CDPCQ04700OutBlock4 { get; set; }
    public CDPCQ04700OutBlock5? CDPCQ04700OutBlock5 { get; set; }
}

/// <summary>
/// 계좌별신용한도조회
/// </summary>
[Path("/stock/accno", Description = "계좌별신용한도조회")]
public class CSPAQ00600 : TrBase
{
    /// 요청
    public CSPAQ00600InBlock1? CSPAQ00600InBlock1 { get; set; }

    // 응답
    public CSPAQ00600OutBlock1? CSPAQ00600OutBlock1 { get; set; }
    public CSPAQ00600OutBlock2? CSPAQ00600OutBlock2 { get; set; }
    public t1621OutBlock1[]? t1621OutBlock1 { get; set; }
}

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회
/// </summary>
[Path("/stock/accno", Description = "현물계좌예수금 주문가능금액 총평가 조회")]
public class CSPAQ12200 : TrBase
{
    /// 요청
    public CSPAQ12200InBlock1? CSPAQ12200InBlock1 { get; set; }

    // 응답
    public CSPAQ12200OutBlock1? CSPAQ12200OutBlock1 { get; set; }
    public CSPAQ12200OutBlock2? CSPAQ12200OutBlock2 { get; set; }
}

/// <summary>
/// BEP단가조회
/// </summary>
[Path("/stock/accno", Description = "BEP단가조회")]
public class CSPAQ12300 : TrBase
{
    /// 요청
    public CSPAQ12300InBlock1? CSPAQ12300InBlock1 { get; set; }

    // 응답
    public CSPAQ12300OutBlock1? CSPAQ12300OutBlock1 { get; set; }
    public CSPAQ12300OutBlock2? CSPAQ12300OutBlock2 { get; set; }
    public CSPAQ12300OutBlock3[]? CSPAQ12300OutBlock3 { get; set; }
}

/// <summary>
/// 현물계좌 주문체결내역 조회(API)
/// </summary>
[Path("/stock/accno", Description = "현물계좌 주문체결내역 조회(API)")]
public class CSPAQ13700 : TrBase
{
    /// 요청
    public CSPAQ13700InBlock1? CSPAQ13700InBlock1 { get; set; }

    // 응답
    public CSPAQ13700OutBlock1? CSPAQ13700OutBlock1 { get; set; }
    public CSPAQ13700OutBlock2? CSPAQ13700OutBlock2 { get; set; }
    public CSPAQ13700OutBlock3[]? CSPAQ13700OutBlock3 { get; set; } // 매뉴얼과 상이
}

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2
/// </summary>
[Path("/stock/accno", Description = "현물계좌예수금 주문가능금액 총평가2")]
public class CSPAQ22200 : TrBase
{
    /// 요청
    public CSPAQ22200InBlock1? CSPAQ22200InBlock1 { get; set; }

    // 응답
    public CSPAQ22200OutBlock1? CSPAQ22200OutBlock1 { get; set; }
    public CSPAQ22200OutBlock2? CSPAQ22200OutBlock2 { get; set; }
}

/// <summary>
/// 현물계좌증거금률별주문가능수량조회
/// </summary>
[Path("/stock/accno", Description = "현물계좌증거금률별주문가능수량조회")]
public class CSPBQ00200 : TrBase
{
    /// 요청
    public CSPBQ00200InBlock1? CSPBQ00200InBlock1 { get; set; }

    // 응답
    public CSPBQ00200OutBlock1? CSPBQ00200OutBlock1 { get; set; }
    public CSPBQ00200OutBlock2? CSPBQ00200OutBlock2 { get; set; }
}

/// <summary>
/// 주식계좌 기간별수익률 상세
/// </summary>
[Path("/stock/accno", Description = "주식계좌 기간별수익률 상세")]
public class FOCCQ33600 : TrBase
{
    /// 요청
    public FOCCQ33600InBlock1? FOCCQ33600InBlock1 { get; set; }

    // 응답
    public FOCCQ33600OutBlock1? FOCCQ33600OutBlock1 { get; set; }
    public FOCCQ33600OutBlock2? FOCCQ33600OutBlock2 { get; set; }
    public FOCCQ33600OutBlock3[]? FOCCQ33600OutBlock3 { get; set; }
}

/// <summary>
/// 주식당일매매일지/수수료
/// </summary>
[Path("/stock/accno", Description = "주식당일매매일지")]
public class t0150 : TrBase
{
    /// 요청
    public t0150InBlock? t0150InBlock { get; set; }

    // 응답
    public t0150OutBlock? t0150OutBlock { get; set; }
    public t0150OutBlock1[]? t0150OutBlock1 { get; set; }
}

/// <summary>
/// 주식당일매매일지/수수료(전일)
/// </summary>
[Path("/stock/accno", Description = "주식당일매매일지/수수료(전일)")]
public class t0151 : TrBase
{
    /// 요청
    public t0151InBlock? t0151InBlock { get; set; }

    // 응답
    public t0151OutBlock? t0151OutBlock { get; set; }
    public t0151OutBlock1[]? t0151OutBlock1 { get; set; }
}

/// <summary>
/// 주식잔고2
/// </summary>
[Path("/stock/accno", Description = "주식잔고2")]
public class t0424 : TrBase
{
    /// 요청
    public t0424InBlock? t0424InBlock { get; set; }

    // 응답
    public t0424OutBlock? t0424OutBlock { get; set; }
    public t0424OutBlock1[]? t0424OutBlock1 { get; set; }
}

/// <summary>
/// 주식체결/미체결
/// </summary>
[Path("/stock/accno", Description = "주식체결/미체결")]
public class t0425 : TrBase
{
    /// 요청
    public t0425InBlock? t0425InBlock { get; set; }

    // 응답
    public t0425OutBlock? t0425OutBlock { get; set; }
    public t0425OutBlock1[]? t0425OutBlock1 { get; set; }
}
#endregion

#region [주식] 주문

/// <summary>
/// 현물주문
/// </summary>
[Path("/stock/order", Description = "현물주문")]
public class CSPAT00601 : TrBase
{
    /// 요청
    public CSPAT00601InBlock1? CSPAT00601InBlock1 { get; set; }

    // 응답
    public CSPAT00601OutBlock1? CSPAT00601OutBlock1 { get; set; }
    public CSPAT00601OutBlock2? CSPAT00601OutBlock2 { get; set; }
}

/// <summary>
/// 현물정정주문
/// </summary>
[Path("/stock/order", Description = "현물정정주문")]
public class CSPAT00701 : TrBase
{
    /// 요청
    public CSPAT00701InBlock1? CSPAT00701InBlock1 { get; set; }

    // 응답
    public CSPAT00701OutBlock1? CSPAT00701OutBlock1 { get; set; }
    public CSPAT00701OutBlock2? CSPAT00701OutBlock2 { get; set; }
}

/// <summary>
/// 현물취소주문
/// </summary>
[Path("/stock/order", Description = "현물취소주문")]
public class CSPAT00801 : TrBase
{
    /// 요청
    public CSPAT00801InBlock1? CSPAT00801InBlock1 { get; set; }

    // 응답
    public CSPAT00801OutBlock1? CSPAT00801OutBlock1 { get; set; }
    public CSPAT00801OutBlock2? CSPAT00801OutBlock2 { get; set; }
}
#endregion

#endregion


#region 선물/옵션

#region [선물/옵션] 시세

/// <summary>
/// 선물/옵션현재가(시세)조회
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가(시세)조회")]
public class t2101 : TrBase
{
    /// 요청
    public t2101InBlock? t2101InBlock { get; set; }

    // 응답
    public t2101OutBlock? t2101OutBlock { get; set; }
}

/// <summary>
/// 선물/옵션현재가호가조회
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가호가조회")]
public class t2105 : TrBase
{
    /// 요청
    public t2105InBlock? t2105InBlock { get; set; }

    // 응답
    public t2105OutBlock? t2105OutBlock { get; set; }
}

/// <summary>
/// 선물/옵션현재가시세메모
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션현재가시세메모")]
public class t2106 : TrBase
{
    /// 요청
    public t2106InBlock? t2106InBlock { get; set; }
    public t2106InBlock1[]? t2106InBlock1 { get; set; }

    // 응답
    public t2106OutBlock? t2106OutBlock { get; set; }
    public t2106OutBlock1[]? t2106OutBlock1 { get; set; }
}

/// <summary>
/// 선물옵션시간대별체결조회
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션시간대별체결조회")]
public class t2201 : TrBase
{
    /// 요청
    public t2201InBlock? t2201InBlock { get; set; }

    // 응답
    public t2201OutBlock? t2201OutBlock { get; set; }
    public t2201OutBlock1[]? t2201OutBlock1 { get; set; }
}

/// <summary>
/// 기간별주가
/// </summary>
[Path("/futureoption/market-data", Description = "기간별주가")]
public class t2203 : TrBase
{
    /// 요청
    public t2203InBlock? t2203InBlock { get; set; }

    // 응답
    public t2203OutBlock? t2203OutBlock { get; set; }
    public t2203OutBlock1[]? t2203OutBlock1 { get; set; }
}

/// <summary>
/// 선물옵션시간대별체결조회(단일출력용)
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션시간대별체결조회(단일출력용)")]
public class t2210 : TrBase
{
    /// 요청
    public t2210InBlock? t2210InBlock { get; set; }

    // 응답
    public t2210OutBlock? t2210OutBlock { get; set; }
}

/// <summary>
/// 옵션전광판
/// </summary>
[Path("/futureoption/market-data", Description = "옵션전광판")]
public class t2301 : TrBase
{
    /// 요청
    public t2301InBlock? t2301InBlock { get; set; }

    // 응답
    public t2301OutBlock? t2301OutBlock { get; set; }
    public t2301OutBlock1[]? t2301OutBlock1 { get; set; }
    public t2301OutBlock2[]? t2301OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션호가잔량비율챠트
/// </summary>
[Path("/futureoption/market-data", Description = "선물옵션호가잔량비율챠트")]
public class t2405 : TrBase
{
    /// 요청
    public t2405InBlock? t2405InBlock { get; set; }

    // 응답
    public t2405OutBlock? t2405OutBlock { get; set; }
    public t2405OutBlock1[]? t2405OutBlock1 { get; set; }
}

/// <summary>
/// 미결제약정추이
/// </summary>
[Path("/futureoption/market-data", Description = "미결제약정추이")]
public class t2421 : TrBase
{
    /// 요청
    public t2421InBlock? t2421InBlock { get; set; }

    // 응답
    public t2421OutBlock? t2421OutBlock { get; set; }
    public t2421OutBlock1[]? t2421OutBlock1 { get; set; }
}

/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회
/// </summary>
[Path("/futureoption/market-data", Description = "EUREXKOSPI200옵션선물현재가(시세)조회")]
public class t2830 : TrBase
{
    /// 요청
    public t2830InBlock? t2830InBlock { get; set; }

    // 응답
    public t2830OutBlock? t2830OutBlock { get; set; }
}

/// <summary>
/// EUREXKOSPI200옵션선물호가조회
/// </summary>
[Path("/futureoption/market-data", Description = "EUREXKOSPI200옵션선물호가조회")]
public class t2831 : TrBase
{
    /// 요청
    public t2831InBlock? t2831InBlock { get; set; }

    // 응답
    public t2831OutBlock? t2831OutBlock { get; set; }
}

/// <summary>
/// EUREX야간옵션선물시간대별체결조회
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX야간옵션선물시간대별체결조회")]
public class t2832 : TrBase
{
    /// 요청
    public t2832InBlock? t2832InBlock { get; set; }

    // 응답
    public t2832OutBlock? t2832OutBlock { get; set; }
    public t2832OutBlock1[]? t2832OutBlock1 { get; set; }
}

/// <summary>
/// EUREX야간옵션선물기간별추이
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX야간옵션선물기간별추이")]
public class t2833 : TrBase
{
    /// 요청
    public t2833InBlock? t2833InBlock { get; set; }

    // 응답
    public t2833OutBlock? t2833OutBlock { get; set; }
    public t2833OutBlock1[]? t2833OutBlock1 { get; set; }
}

/// <summary>
/// EUREX옵션선물시세전광판
/// </summary>
[Path("/futureoption/market-data", Description = "EUREX옵션선물시세전광판")]
public class t2835 : TrBase
{
    /// 요청
    public t2835InBlock? t2835InBlock { get; set; }

    // 응답
    public t2835OutBlock1[]? t2835OutBlock1 { get; set; }
    public t2835OutBlock2[]? t2835OutBlock2 { get; set; }
}

/// <summary>
/// 주식선물마스터조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물마스터조회(API용)")]
public class t8401 : TrBase
{
    /// 요청
    public t8401InBlock? t8401InBlock { get; set; }

    // 응답
    public t8401OutBlock[]? t8401OutBlock { get; set; }
}

/// <summary>
/// 주식선물현재가조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물현재가조회(API용)")]
public class t8402 : TrBase
{
    /// 요청
    public t8402InBlock? t8402InBlock { get; set; }

    // 응답
    public t8402OutBlock? t8402OutBlock { get; set; }
}

/// <summary>
/// 주식선물호가조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물호가조회(API용)")]
public class t8403 : TrBase
{
    /// 요청
    public t8403InBlock? t8403InBlock { get; set; }

    // 응답
    public t8403OutBlock? t8403OutBlock { get; set; }
}

/// <summary>
/// 주식선물시간대별체결조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물시간대별체결조회(API용)")]
public class t8404 : TrBase
{
    /// 요청
    public t8404InBlock? t8404InBlock { get; set; }

    // 응답
    public t8404OutBlock? t8404OutBlock { get; set; }
    public t8404OutBlock1[]? t8404OutBlock1 { get; set; }
}

/// <summary>
/// 주식선물기간별주가(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물기간별주가(API용)")]
public class t8405 : TrBase
{
    /// 요청
    public t8405InBlock? t8405InBlock { get; set; }

    // 응답
    public t8405OutBlock? t8405OutBlock { get; set; }
    public t8405OutBlock1[]? t8405OutBlock1 { get; set; }
}

/// <summary>
/// 주식선물틱분별체결조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "주식선물틱분별체결조회(API용)")]
public class t8406 : TrBase
{
    /// 요청
    public t8406InBlock? t8406InBlock { get; set; }

    // 응답
    public t8406OutBlock1[]? t8406OutBlock1 { get; set; }
}

/// <summary>
/// 상품선물마스터조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "상품선물마스터조회(API용)")]
public class t8426 : TrBase
{
    /// 요청
    public t8426InBlock? t8426InBlock { get; set; }

    // 응답
    public t8426OutBlock[]? t8426OutBlock { get; set; }
}

/// <summary>
/// 과거데이터시간대별조회
/// </summary>
[Path("/futureoption/market-data", Description = "과거데이터시간대별조회")]
public class t8427 : TrBase
{
    /// 요청
    public t8427InBlock? t8427InBlock { get; set; }

    // 응답
    public t8427OutBlock? t8427OutBlock { get; set; }
    public t8427OutBlock1[]? t8427OutBlock1 { get; set; }
}

/// <summary>
/// 지수선물마스터조회API용
/// </summary>
[Path("/futureoption/market-data", Description = "지수선물마스터조회API용")]
public class t8432 : TrBase
{
    /// 요청
    public t8432InBlock? t8432InBlock { get; set; }

    // 응답
    public t8432OutBlock[]? t8432OutBlock { get; set; }
}

/// <summary>
/// 지수옵션마스터조회API용
/// </summary>
[Path("/futureoption/market-data", Description = "지수옵션마스터조회API용")]
public class t8433 : TrBase
{
    /// 요청
    public t8433InBlock? t8433InBlock { get; set; }

    // 응답
    public t8433OutBlock[]? t8433OutBlock { get; set; }
}

/// <summary>
/// 선물/옵션멀티현재가조회
/// </summary>
[Path("/futureoption/market-data", Description = "선물/옵션멀티현재가조회")]
public class t8434 : TrBase
{
    /// 요청
    public t8434InBlock? t8434InBlock { get; set; }

    // 응답
    public t8434OutBlock1[]? t8434OutBlock1 { get; set; }
}

/// <summary>
/// 파생종목마스터조회API용
/// </summary>
[Path("/futureoption/market-data", Description = "파생종목마스터조회API용")]
public class t8435 : TrBase
{
    /// 요청
    public t8435InBlock? t8435InBlock { get; set; }

    // 응답
    public t8435OutBlock[]? t8435OutBlock { get; set; }
}

/// <summary>
/// CME/EUREX마스터조회(API용)
/// </summary>
[Path("/futureoption/market-data", Description = "CME/EUREX마스터조회(API용)")]
public class t8437 : TrBase
{
    /// 요청
    public t8437InBlock? t8437InBlock { get; set; }

    // 응답
    public t8437OutBlock[]? t8437OutBlock { get; set; }
}

/// <summary>
/// 지수선물마스터조회API용
/// </summary>
[Path("/futureoption/market-data", Description = "지수선물마스터조회API용")]
public class t9943 : TrBase
{
    /// 요청
    public t9943InBlock? t9943InBlock { get; set; }

    // 응답
    public t9943OutBlock[]? t9943OutBlock { get; set; }
}

/// <summary>
/// 지수옵션마스터조회API용
/// </summary>
[Path("/futureoption/market-data", Description = "지수옵션마스터조회API용")]
public class t9944 : TrBase
{
    /// 요청
    public t9944InBlock? t9944InBlock { get; set; }

    // 응답
    public t9944OutBlock[]? t9944OutBlock { get; set; }
}
#endregion

#region [선물/옵션] 투자자

/// <summary>
/// 상품선물투자자매매동향(실시간)
/// </summary>
[Path("/futureoption/investor", Description = "상품선물투자자매매동향(실시간)")]
public class t2541 : TrBase
{
    /// 요청
    public t2541InBlock? t2541InBlock { get; set; }

    // 응답
    public t2541OutBlock? t2541OutBlock { get; set; }
    public t2541OutBlock1[]? t2541OutBlock1 { get; set; }
}

/// <summary>
/// 상품선물투자자매매동향(챠트용)
/// </summary>
[Path("/futureoption/investor", Description = "상품선물투자자매매동향(챠트용)")]
public class t2545 : TrBase
{
    /// 요청
    public t2545InBlock? t2545InBlock { get; set; }

    // 응답
    public t2545OutBlock? t2545OutBlock { get; set; }
    public t2545OutBlock1[]? t2545OutBlock1 { get; set; }
}
#endregion

#region [선물/옵션] 차트

/// <summary>
/// 선물옵션틱분별체결조회챠트
/// </summary>
[Path("/futureoption/chart", Description = "선물옵션틱분별체결조회챠트")]
public class t2209 : TrBase
{
    /// 요청
    public t2209InBlock? t2209InBlock { get; set; }

    // 응답
    public t2209OutBlock1[]? t2209OutBlock1 { get; set; }
}

/// <summary>
/// 선물옵션차트(틱/n틱)
/// </summary>
[Path("/futureoption/chart", Description = "선물옵션차트(틱/n틱)")]
public class t8414 : TrBase
{
    /// 요청
    public t8414InBlock? t8414InBlock { get; set; }

    // 응답
    public t8414OutBlock? t8414OutBlock { get; set; }
    public t8414OutBlock1[]? t8414OutBlock1 { get; set; }
}

/// <summary>
/// 선물/옵션챠트(N분)
/// </summary>
[Path("/futureoption/chart", Description = "선물/옵션챠트(N분)")]
public class t8415 : TrBase
{
    /// 요청
    public t8415InBlock? t8415InBlock { get; set; }

    // 응답
    public t8415OutBlock? t8415OutBlock { get; set; }
    public t8415OutBlock1[]? t8415OutBlock1 { get; set; }
}

/// <summary>
/// 선물/옵션챠트(일주월)
/// </summary>
[Path("/futureoption/chart", Description = "선물/옵션챠트(일주월)")]
public class t8416 : TrBase
{
    /// 요청
    public t8416InBlock? t8416InBlock { get; set; }

    // 응답
    public t8416OutBlock? t8416OutBlock { get; set; }
    public t8416OutBlock1[]? t8416OutBlock1 { get; set; }
}

/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트
/// </summary>
[Path("/futureoption/chart", Description = "EUREX야간옵션선물틱분별체결조회챠트")]
public class t8429 : TrBase
{
    /// 요청
    public t8429InBlock? t8429InBlock { get; set; }

    // 응답
    public t8429OutBlock1[]? t8429OutBlock1 { get; set; }
}
#endregion

#region [선물/옵션] 계좌

/// <summary>
/// 선물옵션 계좌 주문체결내역 조회
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 계좌 주문체결내역 조회")]
public class CFOAQ00600 : TrBase
{
    /// 요청
    public CFOAQ00600InBlock1? CFOAQ00600InBlock1 { get; set; }

    // 응답
    public CFOAQ00600OutBlock1? CFOAQ00600OutBlock1 { get; set; }
    public CFOAQ00600OutBlock2? CFOAQ00600OutBlock2 { get; set; }
    public CFOAQ00600OutBlock3[]? CFOAQ00600OutBlock3 { get; set; }
}

/// <summary>
/// 선물옵션 주문가능수량조회
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 주문가능수량조회")]
public class CFOAQ10100 : TrBase
{
    /// 요청
    public CFOAQ10100InBlock1? CFOAQ10100InBlock1 { get; set; }

    // 응답
    public CFOAQ10100OutBlock1? CFOAQ10100OutBlock1 { get; set; }
    public CFOAQ10100OutBlock2? CFOAQ10100OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션 계좌예탁금증거금조회
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 계좌예탁금증거금조회")]
public class CFOBQ10500 : TrBase
{
    /// 요청
    public CFOBQ10500InBlock1? CFOBQ10500InBlock1 { get; set; }

    // 응답
    public CFOBQ10500OutBlock1? CFOBQ10500OutBlock1 { get; set; }
    public CFOBQ10500OutBlock2? CFOBQ10500OutBlock2 { get; set; }
    public CFOBQ10500OutBlock3[]? CFOBQ10500OutBlock3 { get; set; }
}

/// <summary>
/// 선물옵션가정산예탁금상세
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션가정산예탁금상세")]
public class CFOEQ11100 : TrBase
{
    /// 요청
    public CFOEQ11100InBlock1? CFOEQ11100InBlock1 { get; set; }

    // 응답
    public CFOEQ11100OutBlock1? CFOEQ11100OutBlock1 { get; set; }
    public CFOEQ11100OutBlock2? CFOEQ11100OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션 일별 계좌손익내역
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 일별 계좌손익내역")]
public class CFOEQ82600 : TrBase
{
    /// 요청
    public CFOEQ82600InBlock1? CFOEQ82600InBlock1 { get; set; }

    // 응답
    public CFOEQ82600OutBlock1? CFOEQ82600OutBlock1 { get; set; }
    public CFOEQ82600OutBlock2? CFOEQ82600OutBlock2 { get; set; }
    public CFOEQ82600OutBlock3[]? CFOEQ82600OutBlock3 { get; set; }
}

/// <summary>
/// 계좌 미결제 약정현황(평균가)
/// </summary>
[Path("/futureoption/accno", Description = "계좌 미결제 약정현황(평균가)")]
public class CFOFQ02400 : TrBase
{
    /// 요청
    public CFOFQ02400InBlock1? CFOFQ02400InBlock1 { get; set; }

    // 응답
    public CFOFQ02400OutBlock1? CFOFQ02400OutBlock1 { get; set; }
    public CFOFQ02400OutBlock2? CFOFQ02400OutBlock2 { get; set; }
    public CFOFQ02400OutBlock3[]? CFOFQ02400OutBlock3 { get; set; }
    public CFOFQ02400OutBlock4[]? CFOFQ02400OutBlock4 { get; set; }
}

/// <summary>
/// 선물/옵션체결/미체결
/// </summary>
[Path("/futureoption/accno", Description = "선물/옵션체결/미체결")]
public class t0434 : TrBase
{
    /// 요청
    public t0434InBlock? t0434InBlock { get; set; }

    // 응답
    public t0434OutBlock? t0434OutBlock { get; set; }
    public t0434OutBlock1[]? t0434OutBlock1 { get; set; }
}

/// <summary>
/// 선물/옵션잔고평가(이동평균)
/// </summary>
[Path("/futureoption/accno", Description = "선물/옵션잔고평가(이동평균)")]
public class t0441 : TrBase
{
    /// 요청
    public t0441InBlock? t0441InBlock { get; set; }

    // 응답
    public t0441OutBlock? t0441OutBlock { get; set; }
    public t0441OutBlock1[]? t0441OutBlock1 { get; set; }
}

/// <summary>
/// EUREX 주문체결내역조회
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 주문체결내역조회")]
public class CEXAQ21100 : TrBase
{
    /// 요청
    public CEXAQ21100InBlock1? CEXAQ21100InBlock1 { get; set; }

    // 응답
    public CEXAQ21100OutBlock1? CEXAQ21100OutBlock1 { get; set; }
    public CEXAQ21100OutBlock2? CEXAQ21100OutBlock2 { get; set; }
    public CEXAQ21100OutBlock3[]? CEXAQ21100OutBlock3 { get; set; }
}

/// <summary>
/// EUREX 주문가능 수량/금액 조회
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 주문가능 수량/금액 조회")]
public class CEXAQ21200 : TrBase
{
    /// 요청
    public CEXAQ21200InBlock1? CEXAQ21200InBlock1 { get; set; }

    // 응답
    public CEXAQ21200OutBlock1? CEXAQ21200OutBlock1 { get; set; }
    public CEXAQ21200OutBlock2? CEXAQ21200OutBlock2 { get; set; }
}

/// <summary>
/// EUREX 야간장잔고및 평가현황
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 야간장잔고및 평가현황")]
public class CEXAQ31100 : TrBase
{
    /// 요청
    public CEXAQ31100InBlock1? CEXAQ31100InBlock1 { get; set; }

    // 응답
    public CEXAQ31100OutBlock1? CEXAQ31100OutBlock1 { get; set; }
    public CEXAQ31100OutBlock2? CEXAQ31100OutBlock2 { get; set; }
    public CEXAQ31100OutBlock3[]? CEXAQ31100OutBlock3 { get; set; }
}

/// <summary>
/// EUREX 예탁금 및 통합잔고조회
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 예탁금 및 통합잔고조회")]
public class CEXAQ31200 : TrBase
{
    /// 요청
    public CEXAQ31200InBlock1? CEXAQ31200InBlock1 { get; set; }

    // 응답
    public CEXAQ31200OutBlock1? CEXAQ31200OutBlock1 { get; set; }
    public CEXAQ31200OutBlock2? CEXAQ31200OutBlock2 { get; set; }
    public CEXAQ31200OutBlock3[]? CEXAQ31200OutBlock3 { get; set; }
}

/// <summary>
/// EUREX 야간옵션 기간주문체결조회
/// </summary>
[Path("/futureoption/accno", Description = "EUREX 야간옵션 기간주문체결조회")]
public class CEXAQ44200 : TrBase
{
    /// 요청
    public CEXAQ44200InBlock1? CEXAQ44200InBlock1 { get; set; }

    // 응답
    public CEXAQ44200OutBlock1? CEXAQ44200OutBlock1 { get; set; }
    public CEXAQ44200OutBlock2? CEXAQ44200OutBlock2 { get; set; }
    public CEXAQ44200OutBlock3[]? CEXAQ44200OutBlock3 { get; set; }
}

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황
/// </summary>
[Path("/futureoption/accno", Description = "선물옵션 기간별 계좌 수익률 현황")]
public class FOCCQ33700 : TrBase
{
    /// 요청
    public FOCCQ33700InBlock1? FOCCQ33700InBlock1 { get; set; }

    // 응답
    public FOCCQ33700OutBlock1? FOCCQ33700OutBlock1 { get; set; }
    public FOCCQ33700OutBlock2? FOCCQ33700OutBlock2 { get; set; }
    public FOCCQ33700OutBlock3[]? FOCCQ33700OutBlock3 { get; set; }
}
#endregion

#region [선물/옵션] 주문

/// <summary>
/// 선물옵션 정상주문
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 정상주문")]
public class CFOAT00100 : TrBase
{
    /// 요청
    public CFOAT00100InBlock1? CFOAT00100InBlock1 { get; set; }

    // 응답
    public CFOAT00100OutBlock1? CFOAT00100OutBlock1 { get; set; }
    public CFOAT00100OutBlock2? CFOAT00100OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션 정정주문
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 정정주문")]
public class CFOAT00200 : TrBase
{
    /// 요청
    public CFOAT00200InBlock1? t1621InBlock { get; set; }

    // 응답
    public CFOAT00200OutBlock1? CFOAT00200OutBlock1 { get; set; }
    public CFOAT00200OutBlock2? CFOAT00200OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션 취소주문
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 취소주문")]
public class CFOAT00300 : TrBase
{
    /// 요청
    public CFOAT00300InBlock1? CFOAT00300InBlock1 { get; set; }

    // 응답
    public CFOAT00300OutBlock1? CFOAT00300OutBlock1 { get; set; }
    public CFOAT00300OutBlock2? CFOAT00300OutBlock2 { get; set; }
}

/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회(옵션매도시 1계약당 주문증거금)
/// </summary>
[Path("/futureoption/order", Description = "선물옵션 옵션매도시 주문증거금조회(옵션매도시 1계약당 주문증거금)")]
public class CFOBQ10800 : TrBase
{
    /// 요청
    public CFOBQ10800InBlock1? CFOBQ10800InBlock1 { get; set; }

    // 응답
    public CFOBQ10800OutBlock1? CFOBQ10800OutBlock1 { get; set; }
    public CFOBQ10800OutBlock2[]? CFOBQ10800OutBlock2 { get; set; }
}

/// <summary>
/// EUREX 매수/매도주문
/// </summary>
[Path("/futureoption/order", Description = "EUREX 매수/매도주문")]
public class CEXAT11100 : TrBase
{
    /// 요청
    public CEXAT11100InBlock1? CEXAT11100InBlock1 { get; set; }

    // 응답
    public CEXAT11100OutBlock1? CEXAT11100OutBlock1 { get; set; }
    public t1621OutBlock1[]? t1621OutBlock1 { get; set; }
}

/// <summary>
/// EUREX 정정주문
/// </summary>
[Path("/futureoption/order", Description = "EUREX 정정주문")]
public class CEXAT11200 : TrBase
{
    /// 요청
    public CEXAT11200InBlock1? CEXAT11200InBlock1 { get; set; }

    // 응답
    public CEXAT11200OutBlock1? CEXAT11200OutBlock1 { get; set; }
    public CEXAT11200OutBlock2? CEXAT11200OutBlock2 { get; set; }
}

/// <summary>
/// EUREX 취소주문
/// </summary>
[Path("/futureoption/order", Description = "EUREX 취소주문")]
public class CEXAT11300 : TrBase
{
    /// 요청
    public CEXAT11300InBlock1? CEXAT11300InBlock1 { get; set; }

    // 응답
    public CEXAT11300OutBlock1? CEXAT11300OutBlock1 { get; set; }
    public CEXAT11300OutBlock2? CEXAT11300OutBlock2 { get; set; }
}
#endregion

#region [선물/옵션] 기타

/// <summary>
/// 파생상품증거금율조회
/// </summary>
[Path("/futureoption/etc", Description = "파생상품증거금율조회")]
public class MMDAQ91200 : TrBase
{
    /// 요청
    public MMDAQ91200InBlock1? MMDAQ91200InBlock1 { get; set; }

    // 응답
    public MMDAQ91200OutBlock1? MMDAQ91200OutBlock1 { get; set; }
    public MMDAQ91200OutBlock2[]? MMDAQ91200OutBlock2 { get; set; }
}
#endregion

#endregion


#region 해외선물

#region [해외선물] 시세

/// <summary>
/// 해외선물마스터조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물마스터조회")]
public class o3101 : TrBase
{
    /// 요청
    public o3101InBlock? o3101InBlock { get; set; }

    // 응답
    public o3101OutBlock? o3101OutBlock { get; set; }
}

/// <summary>
/// 해외선물 일별체결 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물 일별체결 조회")]
public class o3104 : TrBase
{
    /// 요청
    public o3104InBlock? o3104InBlock { get; set; }

    // 응답
    public o3104OutBlock1[]? o3104OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물 현재가(종목정보) 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물 현재가(종목정보) 조회")]
public class o3105 : TrBase
{
    /// 요청
    public o3105InBlock? o3105InBlock { get; set; }

    // 응답
    public o3105OutBlock? o3105OutBlock { get; set; }
}

/// <summary>
/// 해외선물 현재가호가 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물 현재가호가 조회")]
public class o3106 : TrBase
{
    /// 요청
    public o3106InBlock? o3106InBlock { get; set; }

    // 응답
    public o3106OutBlock? o3106OutBlock { get; set; }
}

/// <summary>
/// 해외선물 관심종목 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물 관심종목 조회")]
public class o3107 : TrBase
{
    /// 요청
    public o3107InBlock? o3107InBlock { get; set; }

    // 응답
    public o3107OutBlock[]? o3107OutBlock { get; set; }
}

/// <summary>
/// 해외선물 시간대별(Tick)체결 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물 시간대별(Tick)체결 조회")]
public class o3116 : TrBase
{
    /// 요청
    public o3116InBlock? o3116InBlock { get; set; }

    // 응답
    public o3116OutBlock? o3116OutBlock { get; set; }
    public o3116OutBlock1[]? o3116OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물옵션 마스터 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 마스터 조회")]
public class o3121 : TrBase
{
    /// 요청
    public o3121InBlock? o3121InBlock { get; set; }

    // 응답
    public o3121OutBlock[]? o3121OutBlock { get; set; } // 매뉴얼과 상이
}

/// <summary>
/// 해외선물옵션 차트 분봉 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 차트 분봉 조회")]
public class o3123 : TrBase
{
    /// 요청
    public o3123InBlock? o3123InBlock { get; set; }

    // 응답
    public o3123OutBlock? o3123OutBlock { get; set; }
    public o3123OutBlock1[]? o3123OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물옵션 현재가(종목정보) 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 현재가(종목정보) 조회")]
public class o3125 : TrBase
{
    /// 요청
    public o3125InBlock? o3125InBlock { get; set; }

    // 응답
    public o3125OutBlock? o3125OutBlock { get; set; }
}

/// <summary>
/// 해외선물옵션 현재가호가 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 현재가호가 조회")]
public class o3126 : TrBase
{
    /// 요청
    public o3126InBlock? o3126InBlock { get; set; }

    // 응답
    public o3126OutBlock? o3126OutBlock { get; set; }
}

/// <summary>
/// 해외선물옵션 관심종목 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 관심종목 조회")]
public class o3127 : TrBase
{
    /// 요청
    public o3127InBlock? o3127InBlock { get; set; }
    public o3127InBlock1[]? o3127InBlock1 { get; set; }

    // 응답
    public o3127OutBlock[]? o3127OutBlock { get; set; }
}

/// <summary>
/// 해외선물옵션 차트 일주월 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 차트 일주월 조회")]
public class o3128 : TrBase
{
    /// 요청
    public o3128InBlock? o3128InBlock { get; set; }

    // 응답
    public o3128OutBlock? o3128OutBlock { get; set; }
    public o3128OutBlock1[]? o3128OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물옵션 시간대별 Tick 체결 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 시간대별 Tick 체결 조회")]
public class o3136 : TrBase
{
    /// 요청
    public o3136InBlock? o3136InBlock { get; set; }

    // 응답
    public o3136OutBlock? o3136OutBlock { get; set; }
    public o3136OutBlock1[]? o3136OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물옵션 차트 NTick 체결 조회
/// </summary>
[Path("/overseas-futureoption/market-data", Description = "해외선물옵션 차트 NTick 체결 조회")]
public class o3137 : TrBase
{
    /// 요청
    public o3137InBlock? o3137InBlock { get; set; }

    // 응답
    public o3137OutBlock? o3137OutBlock { get; set; }
    public o3137OutBlock1[]? o3137OutBlock1 { get; set; }
}
#endregion

#region [해외선물] 계좌

/// <summary>
/// 해외선물 체결내역개별 조회(주문가능수량)
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 체결내역개별 조회(주문가능수량)")]
public class CIDBQ01400 : TrBase
{
    /// 요청
    public CIDBQ01400InBlock1? CIDBQ01400InBlock1 { get; set; }

    // 응답
    public CIDBQ01400OutBlock1? CIDBQ01400OutBlock1 { get; set; }
    public CIDBQ01400OutBlock2? CIDBQ01400OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 미결제잔고내역 조회
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 미결제잔고내역 조회")]
public class CIDBQ01500 : TrBase
{
    /// 요청
    public CIDBQ01500InBlock1? CIDBQ01500InBlock1 { get; set; }

    // 응답
    public CIDBQ01500OutBlock1? CIDBQ01500OutBlock1 { get; set; }
    public CIDBQ01500OutBlock2[]? CIDBQ01500OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 주문내역 조회
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 주문내역 조회")]
public class CIDBQ01800 : TrBase
{
    /// 요청
    public CIDBQ01800InBlock1? CIDBQ01800InBlock1 { get; set; }

    // 응답
    public CIDBQ01800OutBlock1? CIDBQ01800OutBlock1 { get; set; }
    public CIDBQ01800OutBlock2[]? CIDBQ01800OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 주문체결내역 상세 조회
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 주문체결내역 상세 조회")]
public class CIDBQ02400 : TrBase
{
    /// 요청
    public CIDBQ02400InBlock1? CIDBQ02400InBlock1 { get; set; }

    // 응답
    public CIDBQ02400OutBlock1? CIDBQ02400OutBlock1 { get; set; }
    public CIDBQ02400OutBlock2[]? CIDBQ02400OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 예수금/잔고현황
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 예수금/잔고현황")]
public class CIDBQ03000 : TrBase
{
    /// 요청
    public CIDBQ03000InBlock1? CIDBQ03000InBlock1 { get; set; }

    // 응답
    public CIDBQ03000OutBlock1? CIDBQ03000OutBlock1 { get; set; }
    public CIDBQ03000OutBlock2? CIDBQ03000OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 예탁자산 조회
/// </summary>
[Path("/overseas-futureoption/accno", Description = "해외선물 예탁자산 조회")]
public class CIDBQ05300 : TrBase
{
    /// 요청
    public CIDBQ05300InBlock1? CIDBQ05300InBlock1 { get; set; }

    // 응답
    public CIDBQ05300OutBlock1? CIDBQ05300OutBlock1 { get; set; }
    public CIDBQ05300OutBlock2[]? CIDBQ05300OutBlock2 { get; set; }
    public CIDBQ05300OutBlock3? CIDBQ05300OutBlock3 { get; set; }
}

/// <summary>
/// 일자별 미결제 잔고내역
/// </summary>
[Path("/overseas-futureoption/accno", Description = "일자별 미결제 잔고내역")]
public class CIDEQ00800 : TrBase
{
    /// 요청
    public CIDEQ00800InBlock1? CIDEQ00800InBlock1 { get; set; }

    // 응답
    public CIDEQ00800OutBlock1? CIDEQ00800OutBlock1 { get; set; }
    public CIDEQ00800OutBlock2[]? CIDEQ00800OutBlock2 { get; set; } // 매뉴얼과 상이
}
#endregion

#region [해외선물] 주문

/// <summary>
/// 해외선물 신규주문
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물 신규주문")]
public class CIDBT00100 : TrBase
{
    /// 요청
    public CIDBT00100InBlock1? CIDBT00100InBlock1 { get; set; }

    // 응답
    public CIDBT00100OutBlock1? CIDBT00100OutBlock1 { get; set; }
    public CIDBT00100OutBlock2? CIDBT00100OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 정정주문
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물 정정주문")]
public class CIDBT00900 : TrBase
{
    /// 요청
    public CIDBT00900InBlock1? CIDBT00900InBlock1 { get; set; }

    // 응답
    public CIDBT00900OutBlock1? CIDBT00900OutBlock1 { get; set; }
    public CIDBT00900OutBlock2? CIDBT00900OutBlock2 { get; set; }
}

/// <summary>
/// 해외선물 취소주문
/// </summary>
[Path("/overseas-futureoption/order", Description = "해외선물 취소주문")]
public class CIDBT01000 : TrBase
{
    /// 요청
    public CIDBT01000InBlock1? CIDBT01000InBlock1 { get; set; }

    // 응답
    public CIDBT01000OutBlock1? CIDBT01000OutBlock1 { get; set; }
    public CIDBT01000OutBlock2? CIDBT01000OutBlock2 { get; set; }
}
#endregion

#region [해외선물] 차트

/// <summary>
/// 해외선물차트 분봉 조회
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물차트 분봉 조회")]
public class o3103 : TrBase
{
    /// 요청
    public o3103InBlock? o3103InBlock { get; set; }

    // 응답
    public o3103OutBlock? o3103OutBlock { get; set; }
    public o3103OutBlock1[]? o3103OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물차트(일주월) 조회
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물차트(일주월) 조회")]
public class o3108 : TrBase
{
    /// 요청
    public o3108InBlock? o3108InBlock { get; set; }

    // 응답
    public o3108OutBlock? o3108OutBlock { get; set; }
    public o3108OutBlock1[]? o3108OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물 차트 NTick 체결 조회
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물 차트 NTick 체결 조회")]
public class o3117 : TrBase
{
    /// 요청
    public o3117InBlock? o3117InBlock { get; set; }

    // 응답
    public o3117OutBlock? o3117OutBlock { get; set; }
    public o3117OutBlock1[]? o3117OutBlock1 { get; set; }
}

/// <summary>
/// 해외선물옵션차트용NTick(고정형)-API용
/// </summary>
[Path("/overseas-futureoption/chart", Description = "해외선물옵션차트용NTick(고정형)-API용")]
public class o3139 : TrBase
{
    /// 요청
    public o3139InBlock? o3139InBlock { get; set; }

    // 응답
    public o3139OutBlock? o3139OutBlock { get; set; }
    public o3139OutBlock1[]? o3139OutBlock1 { get; set; }
}
#endregion

#endregion


#region 기타

#region [기타] 시간조회

/// <summary>
/// 서버시간조회
/// </summary>
[Path("/etc/time-search", Description = "서버시간조회")]
public class t0167 : TrBase
{
    public t0167InBlock? t0167InBlock { get; set; }
    public t0167OutBlock? t0167OutBlock { get; set; }
}
#endregion

#endregion
