namespace eBEST.OpenApi.Blocks;

#region 업종

#region [업종] 시세

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="gubun1">구분1	String	Y	1	미사용항목임	-	스페이스설정</param>
/// <param name="gubun2">구분2	String	Y	1	일@1	주@2	월@3	분</param>
/// <param name="cts_date">CTS_일자	String	Y	8	연속조회기준일(LT)	-	연속조회일	경우	이	값	기준으로	조회(cont:1일때)	(이전	조회한	t1514OutBlock.cts_date	값으로	설정)	-처음조회시	스페이스설정.</param>
/// <param name="cnt">조회건수	Object	Y	4</param>
/// <param name="rate_gbn">비중구분	String	Y	1	비중구분	-	1:거래량비중	-	2:거래대금비중</param>
public record t1514InBlock(string upcode, string gubun1, string gubun2, string cts_date, object cnt, string rate_gbn);

/// <summary>
/// 
/// </summary>
/// <param name="cts_date">CTS_일자	String	Y	8	연속조회키값(다음데이타가	있을	경우에	한해서	세팅	됨)	이	필드의	데이터를	다음	조회시	InBlock의	date	필드에	넣어준다.</param>
public record t1514OutBlock(string cts_date);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="jisu">지수	Number	Y	12.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	7.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	12.2</param>
/// <param name="value1">거래대금1	Number	Y	12</param>
/// <param name="high">상승	Number	Y	4</param>
/// <param name="unchg">보합	Number	Y	4</param>
/// <param name="low">하락	Number	Y	4</param>
/// <param name="uprate">상승종목비율	Number	Y	6.2</param>
/// <param name="frgsvolume">외인순매수	Number	Y	8</param>
/// <param name="openjisu">시가	Number	Y	12.2</param>
/// <param name="highjisu">고가	Number	Y	12.2</param>
/// <param name="lowjisu">저가	Number	Y	12.2</param>
/// <param name="value2">거래대금2	Number	Y	12</param>
/// <param name="up">상한	Number	Y	4</param>
/// <param name="down">하한	Number	Y	4</param>
/// <param name="totjo">종목수	Number	Y	4</param>
/// <param name="orgsvolume">기관순매수	Number	Y	8</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="rate">거래비중	Number	Y	7.2</param>
/// <param name="divrate">업종배당수익률	Number	Y	7.2</param>
public record t1514OutBlock1(string date, double jisu, string sign, double change, double diff, long volume, double diff_vol, long value1, int high, int unchg, int low, double uprate, int frgsvolume, double openjisu, double highjisu, double lowjisu, long value2, int up, int down, int totjo, int orgsvolume, string upcode, double rate, double divrate);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">구분1	String	Y	1</param>
public record t8424InBlock(string gubun1);

/// <summary>
/// 
/// </summary>
/// <param name="hname">업종명	String	Y	20</param>
/// <param name="upcode">업종코드	String	Y	3</param>
public record t8424OutBlock(string hname, string upcode);

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3	코스피@001	코스닥@301	KRX100@501	KP200@101	SRI@515	코스닥프리미어@404	KRX	보험@516	KRX	운송@517</param>
/// <param name="gubun">조회구분	String	Y	1	1:장전	2:장후</param>
public record t1485InBlock(string upcode, string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="pricejisu">현재지수	Number	Y	10.2</param>
/// <param name="sign">지수전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	10.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="yhighjo">상승종목수	Number	Y	4</param>
/// <param name="yupjo">상한종목수	Number	Y	4</param>
/// <param name="yunchgjo">보합종목수	Number	Y	4</param>
/// <param name="ylowjo">하락종목수	Number	Y	4</param>
/// <param name="ydownjo">하한종목수	Number	Y	4</param>
/// <param name="ytrajo">거래형성수	Number	Y	4</param>
public record t1485OutBlock(double pricejisu, string sign, double change, long volume, int yhighjo, int yupjo, int yunchgjo, int ylowjo, int ydownjo, int ytrajo);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	6</param>
/// <param name="jisu">예상지수	Number	Y	10.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	10.2</param>
/// <param name="volume">예상체결량	Number	Y	12</param>
/// <param name="volcha">예상체결량직전대비	Number	Y	12</param>
/// <param name="diff">예상등락율	Number	Y	6.2</param>
public record t1485OutBlock1(string chetime, double jisu, string sign, double change, long volume, long volcha, double diff);

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3	코스피@001	코스피200@101	KRX100@501	코스닥@301</param>
public record t1511InBlock(string upcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">업종구분	String	Y	1</param>
/// <param name="hname">업종명	String	Y	20</param>
/// <param name="pricejisu">현재지수	Number	Y	7.2</param>
/// <param name="jniljisu">전일지수	Number	Y	7.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	7.2</param>
/// <param name="diffjisu">지수등락율	Number	Y	6.2</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="volume">당일거래량	Number	Y	12</param>
/// <param name="volumechange">거래량전일대비	Number	Y	12</param>
/// <param name="volumerate">거래량비율	Number	Y	6.2</param>
/// <param name="jnilvalue">전일거래대금	Number	Y	12</param>
/// <param name="value">당일거래대금	Number	Y	12</param>
/// <param name="valuechange">거래대금전일대비	Number	Y	12</param>
/// <param name="valuerate">거래대금비율	Number	Y	6.2</param>
/// <param name="openjisu">시가지수	Number	Y	7.2</param>
/// <param name="opendiff">시가등락율	Number	Y	6.2</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="highjisu">고가지수	Number	Y	7.2</param>
/// <param name="highdiff">고가등락율	Number	Y	6.2</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="lowjisu">저가지수	Number	Y	7.2</param>
/// <param name="lowdiff">저가등락율	Number	Y	6.2</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="whjisu">52주최고지수	Number	Y	7.2</param>
/// <param name="whchange">52주최고현재가대비	Number	Y	7.2</param>
/// <param name="whjday">52주최고지수일자	String	Y	8</param>
/// <param name="wljisu">52주최저지수	Number	Y	7.2</param>
/// <param name="wlchange">52주최저현재가대비	Number	Y	7.2</param>
/// <param name="wljday">52주최저지수일자	String	Y	8</param>
/// <param name="yhjisu">연중최고지수	Number	Y	7.2</param>
/// <param name="yhchange">연중최고현재가대비	Number	Y	7.2</param>
/// <param name="yhjday">연중최고지수일자	String	Y	8</param>
/// <param name="yljisu">연중최저지수	Number	Y	7.2</param>
/// <param name="ylchange">연중최저현재가대비	Number	Y	7.2</param>
/// <param name="yljday">연중최저지수일자	String	Y	8</param>
/// <param name="firstjcode">첫번째지수코드	String	Y	3</param>
/// <param name="firstjname">첫번째지수명	String	Y	20</param>
/// <param name="firstjisu">첫번째지수	Number	Y	7.2</param>
/// <param name="firsign">첫번째대비구분	String	Y	1</param>
/// <param name="firchange">첫번째전일대비	Number	Y	7.2</param>
/// <param name="firdiff">첫번째등락율	Number	Y	6.2</param>
/// <param name="secondjcode">두번째지수코드	String	Y	3</param>
/// <param name="secondjname">두번째지수명	String	Y	20</param>
/// <param name="secondjisu">두번째지수	Number	Y	7.2</param>
/// <param name="secsign">두번째대비구분	String	Y	1</param>
/// <param name="secchange">두번째전일대비	Number	Y	7.2</param>
/// <param name="secdiff">두번째등락율	Number	Y	6.2</param>
/// <param name="thirdjcode">세번째지수코드	String	Y	3</param>
/// <param name="thirdjname">세번째지수명	String	Y	20</param>
/// <param name="thirdjisu">세번째지수	Number	Y	7.2</param>
/// <param name="thrsign">세번째대비구분	String	Y	1</param>
/// <param name="thrchange">세번째전일대비	Number	Y	7.2</param>
/// <param name="thrdiff">세번째등락율	Number	Y	6.2</param>
/// <param name="fourthjcode">네번째지수코드	String	Y	3</param>
/// <param name="fourthjname">네번째지수명	String	Y	20</param>
/// <param name="fourthjisu">네번째지수	Number	Y	7.2</param>
/// <param name="forsign">네번째대비구분	String	Y	1</param>
/// <param name="forchange">네번째전일대비	Number	Y	7.2</param>
/// <param name="fordiff">네번째등락율	Number	Y	6.2</param>
/// <param name="highjo">상승종목수	Number	Y	4</param>
/// <param name="upjo">상한종목수	Number	Y	4</param>
/// <param name="unchgjo">보합종목수	Number	Y	4</param>
/// <param name="lowjo">하락종목수	Number	Y	4</param>
/// <param name="downjo">하한종목수	Number	Y	4</param>
public record t1511OutBlock(string gubun, string hname, double pricejisu, double jniljisu, string sign, double change, double diffjisu, long jnilvolume, long volume, long volumechange, double volumerate, long jnilvalue, long value, long valuechange, double valuerate, double openjisu, double opendiff, string opentime, double highjisu, double highdiff, string hightime, double lowjisu, double lowdiff, string lowtime, double whjisu, double whchange, string whjday, double wljisu, double wlchange, string wljday, double yhjisu, double yhchange, string yhjday, double yljisu, double ylchange, string yljday, string firstjcode, string firstjname, double firstjisu, string firsign, double firchange, double firdiff, string secondjcode, string secondjname, double secondjisu, string secsign, double secchange, double secdiff, string thirdjcode, string thirdjname, double thirdjisu, string thrsign, double thrchange, double thrdiff, string fourthjcode, string fourthjname, double fourthjisu, string forsign, double forchange, double fordiff, int highjo, int upjo, int unchgjo, int lowjo, int downjo);

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="gubun">구분	String	Y	1	1:코스피업종	2:코스닥업종	3:섹터지수</param>
/// <param name="shcode">종목코드	String	Y	6	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	shcode	값으로	설정</param>
public record t1516InBlock(string upcode, string gubun, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="pricejisu">지수	Number	Y	12.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	7.2</param>
/// <param name="jdiff">등락율	Number	Y	6.2</param>
public record t1516OutBlock(string shcode, double pricejisu, string sign, double change, double jdiff);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="sojinrate">소진율	Number	Y	6.2</param>
/// <param name="beta">베타계수	Number	Y	6.5</param>
/// <param name="perx">PER	Number	Y	8.2</param>
/// <param name="frgsvolume">외인순매수	Number	Y	12</param>
/// <param name="orgsvolume">기관순매수	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="total">시가총액	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t1516OutBlock1(string hname, int price, string sign, int change, double diff, long volume, int open, int high, int low, double sojinrate, double beta, double perx, long frgsvolume, long orgsvolume, double diff_vol, string shcode, long total, long value);

#endregion

#region  [업종] 차트

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="gubun">주기구분(0:틱1:분2:일3:주4:월)	String	Y	1	0:틱	1:분	2:일	3:주	4:월</param>
/// <param name="ncnt">틱개수	Number	Y	4</param>
/// <param name="qrycnt">건수	Number	Y	4	1	이상	500	이하값만	유효</param>
/// <param name="tdgb">당일구분(0:전체1:당일만)	String	Y	1	0:전체	1:당일만</param>
/// <param name="sdate">시작일자	String	Y	8	조회구간종료일	Space:기본값</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="cts_daygb">연속당일구분(0:연속전체1:연속당일만2:연속전일만)	String	Y	1	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_daygb	값으로	설정</param>
public record t4203InBlock(string shcode, string gubun, int ncnt, int qrycnt, string tdgb, string sdate, string edate, string cts_date, string cts_time, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="jisiga">전일시가	Number	Y	7.2</param>
/// <param name="jihigh">전일고가	Number	Y	7.2</param>
/// <param name="jilow">전일저가	Number	Y	7.2</param>
/// <param name="jiclose">전일종가	Number	Y	7.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	7.2</param>
/// <param name="dihigh">당일고가	Number	Y	7.2</param>
/// <param name="dilow">당일저가	Number	Y	7.2</param>
/// <param name="diclose">당일종가	Number	Y	7.2</param>
/// <param name="disvalue">당일거래대금	Number	Y	12</param>
/// <param name="cts_date">연속일자	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	cts_date	필드에	넣어준다.</param>
/// <param name="cts_time">연속시간	String	Y	10	연속조회키	연속	조회시	이	값을	InBlock의	cts_time	필드에	넣어준다.</param>
/// <param name="cts_daygb">연속당일구분	String	Y	1	연속조회키	연속	조회시	이	값을	InBlock의	cts_daygb	필드에	넣어준다.</param>
public record t4203OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, long disvalue, string cts_date, string cts_time, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	7.2</param>
/// <param name="high">고가	Number	Y	7.2</param>
/// <param name="low">저가	Number	Y	7.2</param>
/// <param name="close">종가	Number	Y	7.2</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t4203OutBlock1(string date, string time, double open, double high, double low, double close, long jdiff_vol, long value);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="ncnt">단위(n틱)	Number	Y	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1	0:미사용</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8417InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="jisiga">전일시가	Number	Y	7.2</param>
/// <param name="jihigh">전일고가	Number	Y	7.2</param>
/// <param name="jilow">전일저가	Number	Y	7.2</param>
/// <param name="jiclose">전일종가	Number	Y	7.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	7.2</param>
/// <param name="dihigh">당일고가	Number	Y	7.2</param>
/// <param name="dilow">당일저가	Number	Y	7.2</param>
/// <param name="diclose">당일종가	Number	Y	7.2</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8417OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	7.2</param>
/// <param name="high">고가	Number	Y	7.2</param>
/// <param name="low">저가	Number	Y	7.2</param>
/// <param name="close">종가	Number	Y	7.2</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
public record t8417OutBlock1(string date, string time, double open, double high, double low, double close, long jdiff_vol);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="ncnt">단위(n분)	Number	Y	4	0:30초	1:	1분	2:	2분	.....	n:	n분</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1	0:미사용</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8418InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="jisiga">전일시가	Number	Y	7.2</param>
/// <param name="jihigh">전일고가	Number	Y	7.2</param>
/// <param name="jilow">전일저가	Number	Y	7.2</param>
/// <param name="jiclose">전일종가	Number	Y	7.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	7.2</param>
/// <param name="dihigh">당일고가	Number	Y	7.2</param>
/// <param name="dilow">당일저가	Number	Y	7.2</param>
/// <param name="diclose">당일종가	Number	Y	7.2</param>
/// <param name="disvalue">당일거래대금	Number	Y	12</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">업종시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">업종종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8418OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, long disvalue, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	7.2</param>
/// <param name="high">고가	Number	Y	7.2</param>
/// <param name="low">저가	Number	Y	7.2</param>
/// <param name="close">종가	Number	Y	7.2</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t8418OutBlock1(string date, string time, double open, double high, double low, double close, long jdiff_vol, long value);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	String	Y	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8419InBlock(string shcode, string gubun, int qrycnt, string sdate, string edate, string cts_date, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	3</param>
/// <param name="jisiga">전일시가	Number	Y	7.2</param>
/// <param name="jihigh">전일고가	Number	Y	7.2</param>
/// <param name="jilow">전일저가	Number	Y	7.2</param>
/// <param name="jiclose">전일종가	Number	Y	7.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	7.2</param>
/// <param name="dihigh">당일고가	Number	Y	7.2</param>
/// <param name="dilow">당일저가	Number	Y	7.2</param>
/// <param name="diclose">당일종가	Number	Y	7.2</param>
/// <param name="disvalue">당일거래대금	Number	Y	12</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="s_time">업종시작시간	String	Y	6</param>
/// <param name="e_time">업종종료시간	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8419OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, long disvalue, string cts_date, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	7.2</param>
/// <param name="high">고가	Number	Y	7.2</param>
/// <param name="low">저가	Number	Y	7.2</param>
/// <param name="close">종가	Number	Y	7.2</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t8419OutBlock1(string date, double open, double high, double low, double close, long jdiff_vol, long value);

#endregion

#endregion

#region 주식

#region [주식] 시세

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1101InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="offerho1">매도호가1	Number	Y	8</param>
/// <param name="bidho1">매수호가1	Number	Y	8</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	12</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	12</param>
/// <param name="preoffercha1">직전매도대비수량1	Number	Y	12</param>
/// <param name="prebidcha1">직전매수대비수량1	Number	Y	12</param>
/// <param name="offerho2">매도호가2	Number	Y	8</param>
/// <param name="bidho2">매수호가2	Number	Y	8</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	12</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	12</param>
/// <param name="preoffercha2">직전매도대비수량2	Number	Y	12</param>
/// <param name="prebidcha2">직전매수대비수량2	Number	Y	12</param>
/// <param name="offerho3">매도호가3	Number	Y	8</param>
/// <param name="bidho3">매수호가3	Number	Y	8</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	12</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	12</param>
/// <param name="preoffercha3">직전매도대비수량3	Number	Y	12</param>
/// <param name="prebidcha3">직전매수대비수량3	Number	Y	12</param>
/// <param name="offerho4">매도호가4	Number	Y	8</param>
/// <param name="bidho4">매수호가4	Number	Y	8</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	12</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	12</param>
/// <param name="preoffercha4">직전매도대비수량4	Number	Y	12</param>
/// <param name="prebidcha4">직전매수대비수량4	Number	Y	12</param>
/// <param name="offerho5">매도호가5	Number	Y	8</param>
/// <param name="bidho5">매수호가5	Number	Y	8</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	12</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	12</param>
/// <param name="preoffercha5">직전매도대비수량5	Number	Y	12</param>
/// <param name="prebidcha5">직전매수대비수량5	Number	Y	12</param>
/// <param name="offerho6">매도호가6	Number	Y	8</param>
/// <param name="bidho6">매수호가6	Number	Y	8</param>
/// <param name="offerrem6">매도호가수량6	Number	Y	12</param>
/// <param name="bidrem6">매수호가수량6	Number	Y	12</param>
/// <param name="preoffercha6">직전매도대비수량6	Number	Y	12</param>
/// <param name="prebidcha6">직전매수대비수량6	Number	Y	12</param>
/// <param name="offerho7">매도호가7	Number	Y	8</param>
/// <param name="bidho7">매수호가7	Number	Y	8</param>
/// <param name="offerrem7">매도호가수량7	Number	Y	12</param>
/// <param name="bidrem7">매수호가수량7	Number	Y	12</param>
/// <param name="preoffercha7">직전매도대비수량7	Number	Y	12</param>
/// <param name="prebidcha7">직전매수대비수량7	Number	Y	12</param>
/// <param name="offerho8">매도호가8	Number	Y	8</param>
/// <param name="bidho8">매수호가8	Number	Y	8</param>
/// <param name="offerrem8">매도호가수량8	Number	Y	12</param>
/// <param name="bidrem8">매수호가수량8	Number	Y	12</param>
/// <param name="preoffercha8">직전매도대비수량8	Number	Y	12</param>
/// <param name="prebidcha8">직전매수대비수량8	Number	Y	12</param>
/// <param name="offerho9">매도호가9	Number	Y	8</param>
/// <param name="bidho9">매수호가9	Number	Y	8</param>
/// <param name="offerrem9">매도호가수량9	Number	Y	12</param>
/// <param name="bidrem9">매수호가수량9	Number	Y	12</param>
/// <param name="preoffercha9">직전매도대비수량9	Number	Y	12</param>
/// <param name="prebidcha9">직전매수대비수량9	Number	Y	12</param>
/// <param name="offerho10">매도호가10	Number	Y	8</param>
/// <param name="bidho10">매수호가10	Number	Y	8</param>
/// <param name="offerrem10">매도호가수량10	Number	Y	12</param>
/// <param name="bidrem10">매수호가수량10	Number	Y	12</param>
/// <param name="preoffercha10">직전매도대비수량10	Number	Y	12</param>
/// <param name="prebidcha10">직전매수대비수량10	Number	Y	12</param>
/// <param name="offer">매도호가수량합	Number	Y	12</param>
/// <param name="bid">매수호가수량합	Number	Y	12</param>
/// <param name="preoffercha">직전매도대비수량합	Number	Y	12</param>
/// <param name="prebidcha">직전매수대비수량합	Number	Y	12</param>
/// <param name="hotime">수신시간	String	Y	8</param>
/// <param name="yeprice">예상체결가격	Number	Y	8</param>
/// <param name="yevolume">예상체결수량	Number	Y	12</param>
/// <param name="yesign">예상체결전일구분	String	Y	1</param>
/// <param name="yechange">예상체결전일대비	Number	Y	8</param>
/// <param name="yediff">예상체결등락율	Number	Y	6.2</param>
/// <param name="tmoffer">시간외매도잔량	Number	Y	12</param>
/// <param name="tmbid">시간외매수잔량	Number	Y	12</param>
/// <param name="ho_status">동시구분	String	Y	1</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
public record t1101OutBlock(string hname, int price, string sign, int change, double diff, long volume, int jnilclose, int offerho1, int bidho1, long offerrem1, long bidrem1, long preoffercha1, long prebidcha1, int offerho2, int bidho2, long offerrem2, long bidrem2, long preoffercha2, long prebidcha2, int offerho3, int bidho3, long offerrem3, long bidrem3, long preoffercha3, long prebidcha3, int offerho4, int bidho4, long offerrem4, long bidrem4, long preoffercha4, long prebidcha4, int offerho5, int bidho5, long offerrem5, long bidrem5, long preoffercha5, long prebidcha5, int offerho6, int bidho6, long offerrem6, long bidrem6, long preoffercha6, long prebidcha6, int offerho7, int bidho7, long offerrem7, long bidrem7, long preoffercha7, long prebidcha7, int offerho8, int bidho8, long offerrem8, long bidrem8, long preoffercha8, long prebidcha8, int offerho9, int bidho9, long offerrem9, long bidrem9, long preoffercha9, long prebidcha9, int offerho10, int bidho10, long offerrem10, long bidrem10, long preoffercha10, long prebidcha10, long offer, long bid, long preoffercha, long prebidcha, string hotime, int yeprice, long yevolume, string yesign, int yechange, double yediff, long tmoffer, long tmbid, string ho_status, string shcode, int uplmtprice, int dnlmtprice, int open, int high, int low);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1102InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="recprice">기준가(평가가격)	Number	Y	8</param>
/// <param name="avg">가중평균	Number	Y	8</param>
/// <param name="uplmtprice">상한가(최고호가가격)	Number	Y	8</param>
/// <param name="dnlmtprice">하한가(최저호가가격)	Number	Y	8</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="volumediff">거래량차	Number	Y	12</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="high52w">52최고가	Number	Y	8</param>
/// <param name="high52wdate">52최고가일	String	Y	8</param>
/// <param name="low52w">52최저가	Number	Y	8</param>
/// <param name="low52wdate">52최저가일	String	Y	8</param>
/// <param name="exhratio">소진율	Number	Y	6.2</param>
/// <param name="per">PER	Number	Y	6.2</param>
/// <param name="pbrx">PBRX	Number	Y	6.2</param>
/// <param name="listing">상장주식수(천)	Number	Y	12</param>
/// <param name="jkrate">증거금율	Number	Y	8</param>
/// <param name="memedan">수량단위	String	Y	5</param>
/// <param name="offernocd1">매도증권사코드1	String	Y	3</param>
/// <param name="bidnocd1">매수증권사코드1	String	Y	3</param>
/// <param name="offerno1">매도증권사명1	String	Y	6</param>
/// <param name="bidno1">매수증권사명1	String	Y	6</param>
/// <param name="dvol1">총매도수량1	Number	Y	8</param>
/// <param name="svol1">총매수수량1	Number	Y	8</param>
/// <param name="dcha1">매도증감1	Number	Y	8</param>
/// <param name="scha1">매수증감1	Number	Y	8</param>
/// <param name="ddiff1">매도비율1	Number	Y	6.2</param>
/// <param name="sdiff1">매수비율1	Number	Y	6.2</param>
/// <param name="offernocd2">매도증권사코드2	String	Y	3</param>
/// <param name="bidnocd2">매수증권사코드2	String	Y	3</param>
/// <param name="offerno2">매도증권사명2	String	Y	6</param>
/// <param name="bidno2">매수증권사명2	String	Y	6</param>
/// <param name="dvol2">총매도수량2	Number	Y	8</param>
/// <param name="svol2">총매수수량2	Number	Y	8</param>
/// <param name="dcha2">매도증감2	Number	Y	8</param>
/// <param name="scha2">매수증감2	Number	Y	8</param>
/// <param name="ddiff2">매도비율2	Number	Y	6.2</param>
/// <param name="sdiff2">매수비율2	Number	Y	6.2</param>
/// <param name="offernocd3">매도증권사코드3	String	Y	3</param>
/// <param name="bidnocd3">매수증권사코드3	String	Y	3</param>
/// <param name="offerno3">매도증권사명3	String	Y	6</param>
/// <param name="bidno3">매수증권사명3	String	Y	6</param>
/// <param name="dvol3">총매도수량3	Number	Y	8</param>
/// <param name="svol3">총매수수량3	Number	Y	8</param>
/// <param name="dcha3">매도증감3	Number	Y	8</param>
/// <param name="scha3">매수증감3	Number	Y	8</param>
/// <param name="ddiff3">매도비율3	Number	Y	6.2</param>
/// <param name="sdiff3">매수비율3	Number	Y	6.2</param>
/// <param name="offernocd4">매도증권사코드4	String	Y	3</param>
/// <param name="bidnocd4">매수증권사코드4	String	Y	3</param>
/// <param name="offerno4">매도증권사명4	String	Y	6</param>
/// <param name="bidno4">매수증권사명4	String	Y	6</param>
/// <param name="dvol4">총매도수량4	Number	Y	8</param>
/// <param name="svol4">총매수수량4	Number	Y	8</param>
/// <param name="dcha4">매도증감4	Number	Y	8</param>
/// <param name="scha4">매수증감4	Number	Y	8</param>
/// <param name="ddiff4">매도비율4	Number	Y	6.2</param>
/// <param name="sdiff4">매수비율4	Number	Y	6.2</param>
/// <param name="offernocd5">매도증권사코드5	String	Y	3</param>
/// <param name="bidnocd5">매수증권사코드5	String	Y	3</param>
/// <param name="offerno5">매도증권사명5	String	Y	6</param>
/// <param name="bidno5">매수증권사명5	String	Y	6</param>
/// <param name="dvol5">총매도수량5	Number	Y	8</param>
/// <param name="svol5">총매수수량5	Number	Y	8</param>
/// <param name="dcha5">매도증감5	Number	Y	8</param>
/// <param name="scha5">매수증감5	Number	Y	8</param>
/// <param name="ddiff5">매도비율5	Number	Y	6.2</param>
/// <param name="sdiff5">매수비율5	Number	Y	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	Number	Y	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	Number	Y	12</param>
/// <param name="ftradmddiff">외국계매도비율	Number	Y	6.2</param>
/// <param name="fwsvl">외국계매수합계수량	Number	Y	12</param>
/// <param name="ftradmscha">외국계매수직전대비	Number	Y	12</param>
/// <param name="ftradmsdiff">외국계매수비율	Number	Y	6.2</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
/// <param name="jvolume">전일동시간거래량	Number	Y	12</param>
/// <param name="highyear">연중최고가	Number	Y	8</param>
/// <param name="highyeardate">연중최고일자	String	Y	8</param>
/// <param name="lowyear">연중최저가	Number	Y	8</param>
/// <param name="lowyeardate">연중최저일자	String	Y	8</param>
/// <param name="target">목표가	Number	Y	8</param>
/// <param name="capital">자본금	Number	Y	12</param>
/// <param name="abscnt">유동주식수	Number	Y	12</param>
/// <param name="parprice">액면가	Number	Y	8</param>
/// <param name="gsmm">결산월	String	Y	2</param>
/// <param name="subprice">대용가	Number	Y	8</param>
/// <param name="total">시가총액	Number	Y	12</param>
/// <param name="listdate">상장일	String	Y	8</param>
/// <param name="name">전분기명	String	Y	10</param>
/// <param name="bfsales">전분기매출액	Number	Y	12</param>
/// <param name="bfoperatingincome">전분기영업이익	Number	Y	12</param>
/// <param name="bfordinaryincome">전분기경상이익	Number	Y	12</param>
/// <param name="bfnetincome">전분기순이익	Number	Y	12</param>
/// <param name="bfeps">전분기EPS	Number	Y	13.2</param>
/// <param name="name2">전전분기명	String	Y	10</param>
/// <param name="bfsales2">전전분기매출액	Number	Y	12</param>
/// <param name="bfoperatingincome2">전전분기영업이익	Number	Y	12</param>
/// <param name="bfordinaryincome2">전전분기경상이익	Number	Y	12</param>
/// <param name="bfnetincome2">전전분기순이익	Number	Y	12</param>
/// <param name="bfeps2">전전분기EPS	Number	Y	13.2</param>
/// <param name="salert">전년대비매출액	Number	Y	7.2</param>
/// <param name="opert">전년대비영업이익	Number	Y	7.2</param>
/// <param name="ordrt">전년대비경상이익	Number	Y	7.2</param>
/// <param name="netrt">전년대비순이익	Number	Y	7.2</param>
/// <param name="epsrt">전년대비EPS	Number	Y	7.2</param>
/// <param name="info1">락구분	String	Y	10</param>
/// <param name="info2">관리/급등구분	String	Y	10</param>
/// <param name="info3">정지/연장구분	String	Y	10</param>
/// <param name="info4">투자/불성실구분	String	Y	12</param>
/// <param name="janginfo">장구분	String	Y	10</param>
/// <param name="t_per">T.PER	Number	Y	6.2</param>
/// <param name="tonghwa">통화ISO코드	String	Y	3</param>
/// <param name="dval1">총매도대금1	Number	Y	18</param>
/// <param name="sval1">총매수대금1	Number	Y	18</param>
/// <param name="dval2">총매도대금2	Number	Y	18</param>
/// <param name="sval2">총매수대금2	Number	Y	18</param>
/// <param name="dval3">총매도대금3	Number	Y	18</param>
/// <param name="sval3">총매수대금3	Number	Y	18</param>
/// <param name="dval4">총매도대금4	Number	Y	18</param>
/// <param name="sval4">총매수대금4	Number	Y	18</param>
/// <param name="dval5">총매도대금5	Number	Y	18</param>
/// <param name="sval5">총매수대금5	Number	Y	18</param>
/// <param name="davg1">총매도평단가1	Number	Y	8</param>
/// <param name="savg1">총매수평단가1	Number	Y	8</param>
/// <param name="davg2">총매도평단가2	Number	Y	8</param>
/// <param name="savg2">총매수평단가2	Number	Y	8</param>
/// <param name="davg3">총매도평단가3	Number	Y	8</param>
/// <param name="savg3">총매수평단가3	Number	Y	8</param>
/// <param name="davg4">총매도평단가4	Number	Y	8</param>
/// <param name="savg4">총매수평단가4	Number	Y	8</param>
/// <param name="davg5">총매도평단가5	Number	Y	8</param>
/// <param name="savg5">총매수평단가5	Number	Y	8</param>
/// <param name="ftradmdval">외국계매도대금	Number	Y	18</param>
/// <param name="ftradmsval">외국계매수대금	Number	Y	18</param>
/// <param name="ftradmdvag">외국계매도평단가	Number	Y	8</param>
/// <param name="ftradmsvag">외국계매수평단가	Number	Y	8</param>
/// <param name="info5">투자주의환기	String	Y	8</param>
/// <param name="spac_gubun">기업인수목적회사여부	String	Y	1</param>
/// <param name="issueprice">발행가격	Number	Y	8</param>
/// <param name="alloc_gubun">배분적용구분코드(1:배분발생2:배분해제그외:미발생)	String	Y	1</param>
/// <param name="alloc_text">배분적용구분	String	Y	8</param>
/// <param name="shterm_text">단기과열/VI발동	String	Y	10</param>
/// <param name="svi_uplmtprice">정적VI상한가	Number	Y	8</param>
/// <param name="svi_dnlmtprice">정적VI하한가	Number	Y	8</param>
/// <param name="low_lqdt_gu">저유동성종목여부	String	Y	1</param>
/// <param name="abnormal_rise_gu">이상급등종목여부	String	Y	1</param>
/// <param name="lend_text">대차불가표시	String	Y	8</param>
/// <param name="ty_text">ETF/ETN투자유의	String	Y	8</param>
public record t1102OutBlock(string hname, int price, string sign, int change, double diff, long volume, int recprice, int avg, int uplmtprice, int dnlmtprice, long jnilvolume, long volumediff, int open, string opentime, int high, string hightime, int low, string lowtime, int high52w, string high52wdate, int low52w, string low52wdate, double exhratio, double per, double pbrx, long listing, int jkrate, string memedan, string offernocd1, string bidnocd1, string offerno1, string bidno1, int dvol1, int svol1, int dcha1, int scha1, double ddiff1, double sdiff1, string offernocd2, string bidnocd2, string offerno2, string bidno2, int dvol2, int svol2, int dcha2, int scha2, double ddiff2, double sdiff2, string offernocd3, string bidnocd3, string offerno3, string bidno3, int dvol3, int svol3, int dcha3, int scha3, double ddiff3, double sdiff3, string offernocd4, string bidnocd4, string offerno4, string bidno4, int dvol4, int svol4, int dcha4, int scha4, double ddiff4, double sdiff4, string offernocd5, string bidnocd5, string offerno5, string bidno5, int dvol5, int svol5, int dcha5, int scha5, double ddiff5, double sdiff5, long fwdvl, long ftradmdcha, double ftradmddiff, long fwsvl, long ftradmscha, double ftradmsdiff, double vol, string shcode, long value, long jvolume, int highyear, string highyeardate, int lowyear, string lowyeardate, int target, long capital, long abscnt, int parprice, string gsmm, int subprice, long total, string listdate, string name, long bfsales, long bfoperatingincome, long bfordinaryincome, long bfnetincome, double bfeps, string name2, long bfsales2, long bfoperatingincome2, long bfordinaryincome2, long bfnetincome2, double bfeps2, double salert, double opert, double ordrt, double netrt, double epsrt, string info1, string info2, string info3, string info4, string janginfo, double t_per, string tonghwa, long dval1, long sval1, long dval2, long sval2, long dval3, long sval3, long dval4, long sval4, long dval5, long sval5, int davg1, int savg1, int davg2, int savg2, int davg3, int savg3, int davg4, int savg4, int davg5, int savg5, long ftradmdval, long ftradmsval, int ftradmdvag, int ftradmsvag, string info5, string spac_gubun, int issueprice, string alloc_gubun, string alloc_text, string shterm_text, int svi_uplmtprice, int svi_dnlmtprice, string low_lqdt_gu, string abnormal_rise_gu, string lend_text, string ty_text);

/// <summary>
/// 
/// </summary>
/// <param name="code">종목코드	String	Y	6</param>
/// <param name="nrec">건수	String	Y	2	t1104InBlock1	의	개수</param>
public record t1104InBlock(string code, string nrec);

/// <summary>
/// 
/// </summary>
/// <param name="indx">인덱스	String	Y	1	t1104InBlock1	의	Occurs	Index(0부터	시작)</param>
/// <param name="gubn">조건구분	String	Y	1	1:시세	2:최고저가	3:Pivot	4:이동평균선</param>
/// <param name="dat1">데이타1	String	Y	1	1:시가	2:고가	3:저가	4:가중평균가</param>
/// <param name="dat2">데이타2	String	Y	8	1:당일	2:전일</param>
public record t1104InBlock1(string indx, string gubn, string dat1, string dat2);

/// <summary>
/// 
/// </summary>
/// <param name="nrec">출력건수	String	Y	2</param>
public record t1104OutBlock(string nrec);

/// <summary>
/// 
/// </summary>
/// <param name="indx">인덱스	String	Y	1</param>
/// <param name="gubn">조건구분	String	Y	1</param>
/// <param name="vals">출력값	String	Y	8</param>
public record t1104OutBlock1(string indx, string gubn, string vals);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1105InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="pbot">피봇	Number	Y	8</param>
/// <param name="offer1">1차저항	Number	Y	8</param>
/// <param name="supp1">1차지지	Number	Y	8</param>
/// <param name="offer2">2차저항	Number	Y	8</param>
/// <param name="supp2">2차지지	Number	Y	8</param>
/// <param name="stdprc">기준가격	Number	Y	8</param>
/// <param name="offerd">D저항	Number	Y	8</param>
/// <param name="suppd">D지지	Number	Y	8</param>
public record t1105OutBlock(string shcode, int pbot, int offer1, int supp1, int offer2, int supp2, int stdprc, int offerd, int suppd);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="dan_chetime">체결cts	String	Y	10	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="idx">IDX	Number	Y	4	연속조회시	OutBlock의	동일필드	입력</param>
public record t1109InBlock(string shcode, string dan_chetime, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="ctsshcode">종목cts	String	Y	6</param>
/// <param name="ctschetime">체결cts	String	Y	10</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1109OutBlock(string ctsshcode, string ctschetime, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="dan_chetime">시간	String	Y	10</param>
/// <param name="dan_price">현재가	Number	Y	8</param>
/// <param name="dan_sign">전일대비구분	String	Y	1</param>
/// <param name="dan_change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="dan_cvolume">체결량	Number	Y	8</param>
/// <param name="chdegree">체결강도	Number	Y	9.2</param>
/// <param name="dan_volume">누적거래량	Number	Y	12</param>
public record t1109OutBlock1(string dan_chetime, int dan_price, string dan_sign, int dan_change, double diff, int dan_cvolume, double chdegree, long dan_volume);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="cvolume">특이거래량	Number	Y	12	거래량	>	특이거래량</param>
/// <param name="starttime">시작시간	String	Y	4	장시작시간	이후</param>
/// <param name="endtime">종료시간	String	Y	4	장종료시간	이전</param>
/// <param name="cts_time">시간CTS	String	Y	10	연속조회시	OutBlock의	동일필드	입력</param>
public record t1301InBlock(string shcode, long cvolume, string starttime, string endtime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10</param>
public record t1301OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	12</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="revolume">순체결량	Number	Y	12</param>
/// <param name="rechecnt">순체결건수	Number	Y	8</param>
public record t1301OutBlock1(string chetime, int price, string sign, int change, double diff, long cvolume, double chdegree, long volume, long mdvolume, int mdchecnt, long msvolume, int mschecnt, long revolume, int rechecnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gubun">작업구분	String	Y	1	0:30초</param>
/// <param name="time">시간	String	Y	6	처음	조회시는	Space</param>
/// <param name="cnt">건수	Number	Y	3	1이상	900	이하</param>
public record t1302InBlock(string shcode, string gubun, string time, int cnt);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	6</param>
public record t1302OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	6</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="revolume">순매수체결량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="rechecnt">순체결건수	Number	Y	8</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="cvolume">체결량	Number	Y	12</param>
/// <param name="mdchecnttm">매도체결건수(시간)	Number	Y	8</param>
/// <param name="mschecnttm">매수체결건수(시간)	Number	Y	8</param>
/// <param name="totofferrem">매도잔량	Number	Y	12</param>
/// <param name="totbidrem">매수잔량	Number	Y	12</param>
/// <param name="mdvolumetm">시간별매도체결량	Number	Y	12</param>
/// <param name="msvolumetm">시간별매수체결량	Number	Y	12</param>
public record t1302OutBlock1(string chetime, int close, string sign, int change, double diff, double chdegree, long mdvolume, long msvolume, long revolume, int mdchecnt, int mschecnt, int rechecnt, long volume, int open, int high, int low, long cvolume, int mdchecnttm, int mschecnttm, long totofferrem, long totbidrem, long mdvolumetm, long msvolumetm);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="dwmcode">일주월구분	Number	Y	1	1@일,	2@주,	3@월</param>
/// <param name="date">날짜	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
/// <param name="idx">IDX	Number	Y	4	사용안함(Space)</param>
/// <param name="cnt">건수	Number	Y	4	1	이상</param>
public record t1305InBlock(string shcode, int dwmcode, string date, int idx, int cnt);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">CNT	Number	Y	4</param>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1305OutBlock(int cnt, string date, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="chdegree">체결강도	Number	Y	6.2</param>
/// <param name="sojinrate">소진율	Number	Y	6.2</param>
/// <param name="changerate">회전율	Number	Y	6.2</param>
/// <param name="fpvolume">외인순매수	Number	Y	12</param>
/// <param name="covolume">기관순매수	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="value">누적거래대금(단위:백만)	Number	Y	12</param>
/// <param name="ppvolume">개인순매수	Number	Y	12</param>
/// <param name="o_sign">시가대비구분	String	Y	1</param>
/// <param name="o_change">시가대비	Number	Y	8</param>
/// <param name="o_diff">시가기준등락율	Number	Y	6.2</param>
/// <param name="h_sign">고가대비구분	String	Y	1</param>
/// <param name="h_change">고가대비	Number	Y	8</param>
/// <param name="h_diff">고가기준등락율	Number	Y	6.2</param>
/// <param name="l_sign">저가대비구분	String	Y	1</param>
/// <param name="l_change">저가대비	Number	Y	8</param>
/// <param name="l_diff">저가기준등락율	Number	Y	6.2</param>
/// <param name="marketcap">시가총액(단위:백만)	Number	Y	12</param>
public record t1305OutBlock1(string date, int open, int high, int low, int close, string sign, int change, double diff, long volume, double diff_vol, double chdegree, double sojinrate, double changerate, long fpvolume, long covolume, string shcode, long value, long ppvolume, string o_sign, int o_change, double o_diff, string h_sign, int h_change, double h_diff, string l_sign, int l_change, double l_diff, long marketcap);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="starttime">시작시간	String	Y	4	장시작시간	이후(hhmm)</param>
/// <param name="endtime">종료시간	String	Y	4	장종료시간	이전(hhmm)</param>
/// <param name="bun_term">분간격	String	Y	2</param>
public record t1308InBlock(string shcode, string starttime, string endtime, string bun_term);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="chdegvol">체결강도(거래량)	Number	Y	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	Number	Y	8.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
public record t1308OutBlock1(string chetime, int price, string sign, int change, double diff, int cvolume, double chdegvol, double chdegcnt, long volume, long mdvolume, int mdchecnt, long msvolume, int mschecnt, int open, int high, int low);

/// <summary>
/// 
/// </summary>
/// <param name="daygb">당일전일구분	String	Y	1	0:당일</param>
/// <param name="timegb">분틱구분	String	Y	1	0:분</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="endtime">종료시간	String	Y	4	처음	조회시	시간	입력값. t1310OutBlock1.chetime <= endtime 인 데이터 조회됨.</param>
/// <param name="cts_time">시간CTS	String	Y	10	처음	조회시	Space, 다음 조회시 t1310OutBlock.cts_time 값 입력</param>
public record t1310InBlock(string daygb, string timegb, string shcode, string endtime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10</param>
public record t1310OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	12</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="revolume">순체결량	Number	Y	12</param>
/// <param name="rechecnt">순체결건수	Number	Y	8</param>
public record t1310OutBlock1(string chetime, int price, string sign, int change, double diff, long cvolume, double chdegree, long volume, long mdvolume, int mdchecnt, long msvolume, int mschecnt, long revolume, int rechecnt);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="jongchk">종목체크	String	Y	1	1:관리	2:불성실공시	3:투자유의	4.투자환기</param>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_shcode	값으로	설정</param>
public record t1404InBlock(string gubun, string jongchk, string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6</param>
public record t1404OutBlock(string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="date">지정일	String	Y	8</param>
/// <param name="tprice">지정일주가	Number	Y	8</param>
/// <param name="tchange">지정일대비	Number	Y	8</param>
/// <param name="tdiff">대비율	Number	Y	6.2</param>
/// <param name="reason">사유	String	Y	4</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="edate">해제일	String	Y	8</param>
public record t1404OutBlock1(string hname, int price, string sign, int change, double diff, long volume, string date, int tprice, int tchange, double tdiff, string reason, string shcode, string edate);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:전체</param>
/// <param name="jongchk">종목체크	String	Y	1	1	:	투자경고</param>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6	처음	조회시는	Space</param>
public record t1405InBlock(string gubun, string jongchk, string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6</param>
public record t1405OutBlock(string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="date">지정일	String	Y	8</param>
/// <param name="edate">해제일	String	Y	8</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1405OutBlock1(string hname, int price, string sign, int change, double diff, long volume, string date, string edate, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_shcode	값으로	설정</param>
public record t1410InBlock(string gubun, string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	String	Y	6</param>
public record t1410OutBlock(string cts_shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1410OutBlock1(string hname, int price, string sign, int change, double diff, long volume, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="qrygb">조회구분	String	Y	1	1:20종목씩	조회	2:전체조회</param>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="jnilgubun">전일구분	String	Y	1	0:당일	1:전일</param>
/// <param name="sign">상하한구분	String	Y	1	1:상한	4:하한</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값(설정시	저장됨)	증거금50	:	0x00400000	증거금100	:	0x00800000	증거금50/100	:	0x00200000	관리종목	:	0x00000080	시장경보	:	0x00000100	거래정지	:	0x00000200	우선주	:	0x00004000	투자유의	:	0x04000000	정리매매	:	0x01000000	불성실공시	:	0x80000000</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1422InBlock(string qrygb, string gubun, string jnilgubun, string sign, long jc_num, int sprice, int eprice, long volume, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">CNT	Number	Y	4</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1422OutBlock(int cnt, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="last">최종진입	String	Y	6</param>
/// <param name="lmtdaycnt">연속	Number	Y	8</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1422OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double diff_vol, long offerrem1, long bidrem1, string last, int lmtdaycnt, long jnilvolume, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="qrygb">조회구분	String	Y	1	1:20종목씩	조회	그외:전체조회</param>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="signgubun">상하한가구분	String	Y	1	1:상한직전	2:하한직전</param>
/// <param name="diff">등락율	Number	Y	3	등락율	signgubun	이	'1'(상한직전)인	경우	diff	이상	signgubun	이	'1'(상한직전)인	경우	-diff	이하</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값(설정시	저장됨)	Default:000000000000	000000000128(0x00000080):관리종목	000000000256(0x00000100):시장경보	000000000512(0x00000200):거래정지	000000016384(0x00004000):우선주	000002097152(0x00200000):증거금50/100	000004194304(0x00400000):증거금50	000008388608(0x00800000):증거금100	000016777216(0x01000000):정리매매	000067108864(0x04000000):투자유의	002147483648(0x80000000):불성실공시	ex)	관리종목,	시장경보	종목	제외시	:	000000000384(	128	+	256	)</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="jshex">전일상하한제외	String	Y	1	c'	or	'C'	입력시	전일	상/하한가	제외</param>
public record t1427InBlock(string qrygb, string gubun, string signgubun, int diff, long jc_num, int sprice, int eprice, long volume, int idx, string jshex);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">CNT	Number	Y	4</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1427OutBlock(int cnt, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="lmtprice">상한가/하한가	Number	Y	8</param>
/// <param name="rate">대비율	Number	Y	12.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="lmtdaycnt">연속	Number	Y	8</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="total">시가총액	Number	Y	12</param>
public record t1427OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double diff_vol, int lmtprice, double rate, string shcode, long jnilvolume, int open, int high, int low, int lmtdaycnt, long value, long total);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="type1">신고신저	String	Y	1	0:신고	1:신저</param>
/// <param name="type2">기간	String	Y	1	0@전일	1@5일	2@10일	3@20일	4@60일	5@90일	6@52주	7@년중</param>
/// <param name="type3">유지여부	String	Y	1	0:일시돌파	1:돌파유지</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값(설정시	저장됨)	증거금50	:	0x00400000	증거금100	:	0x00800000	증거금50/100	:	0x00200000	관리종목	:	0x00000080	시장경보	:	0x00000100	거래정지	:	0x00000200	우선주	:	0x00004000	투자유의	:	0x04000000	정리매매	:	0x01000000	불성실공시	:	0x80000000</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="jc_num2">대상제외2	Number	Y	12	기본	=>	000000000000	상장지수펀드	=>	000000000001	선박투자회사	=>	000000000002	스펙	=>	000000000004	ETN	=>	000000000008(0x00000008)	투자주의	=>	000000000016(0x00000010)	투자위험	=>	000000000032(0x00000020)	위험예고	=>	000000000064(0x00000040)	담보불가	=>	000000000128(0x00000080)	두개	이상	제외시	해당	값을	합산한다.</param>
public record t1442InBlock(string gubun, string type1, string type2, string type3, long jc_num, int sprice, int eprice, long volume, int idx, long jc_num2);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1442OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="pastprice">이전가	Number	Y	8</param>
/// <param name="pastsign">이전가대비구분	String	Y	1</param>
/// <param name="pastchange">이전가대비	Number	Y	8</param>
/// <param name="pastdiff">이전가대비율	Number	Y	6.2</param>
public record t1442OutBlock1(string shcode, string hname, int price, string sign, int change, double diff, long volume, int pastprice, string pastsign, int pastchange, double pastdiff);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="dategb">일자구분	String	Y	1	1@당일	2@전일	3@당일+전일</param>
public record t1449InBlock(string shcode, string dategb);

/// <summary>
/// 
/// </summary>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="msvolume">매수체결량	Number	Y	12</param>
/// <param name="mdvolume">매도체결량	Number	Y	12</param>
public record t1449OutBlock(int price, string sign, int change, double diff, long volume, long msvolume, long mdvolume);

/// <summary>
/// 
/// </summary>
/// <param name="price">체결가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="tickdiff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	12</param>
/// <param name="diff">비중	Number	Y	6.2</param>
/// <param name="mdvolume">매도체결량	Number	Y	12</param>
/// <param name="msvolume">매수체결량	Number	Y	12</param>
/// <param name="msdiff">매수비율	Number	Y	6.2</param>
public record t1449OutBlock1(int price, string sign, int change, double tickdiff, long cvolume, double diff, long mdvolume, long msvolume, double msdiff);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun">분구분	String	Y	2	00:30초	01:1분	02:2분	03:3분	.....</param>
/// <param name="time">시간	String	Y	6	기본값	:	Space,	현재시간을	기준으로	함	연속조회시에	직전	조회결과인	OutBlock의	time	값으로	설정</param>
/// <param name="cnt">자료개수	String	Y	3	요청건수(	1	이상	500	이하값만	유효)	ex)	10건	요청시	"010"</param>
public record t1471InBlock(string shcode, string gubun, string time, string cnt);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간CTS	String	Y	6</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
public record t1471OutBlock(string time, int price, string sign, int change, double diff, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="time">체결시간	String	Y	6</param>
/// <param name="preoffercha1">메도증감	Number	Y	12</param>
/// <param name="offerrem1">매도우선잔량	Number	Y	12</param>
/// <param name="offerho1">매도우선호가	Number	Y	8</param>
/// <param name="bidho1">매수우선호가	Number	Y	8</param>
/// <param name="bidrem1">매수우선잔량	Number	Y	12</param>
/// <param name="prebidcha1">매수증감	Number	Y	12</param>
/// <param name="totofferrem">총매도	Number	Y	12</param>
/// <param name="totbidrem">총매수	Number	Y	12</param>
/// <param name="totsun">순매수	Number	Y	12</param>
/// <param name="msrate">매수비율	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	8</param>
public record t1471OutBlock1(string time, long preoffercha1, long offerrem1, int offerho1, int bidho1, long bidrem1, long prebidcha1, long totofferrem, long totbidrem, long totsun, double msrate, int close);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="vptype">상승하락	String	Y	1	시간별/일별	구분	0	:	시간별	1	:	일별</param>
/// <param name="datacnt">데이터개수	Number	Y	4	스페이스	입력시	최대	20개	데이터	조회됨.</param>
/// <param name="date">기준일자	Number	Y	8	다음	조회시	입력.	이전	조회시	OutBlock.date값	입력</param>
/// <param name="time">기준시간	Number	Y	6	다음	조회시	입력.	이전	조회시	OutBlock.time값	입력</param>
/// <param name="rankcnt">랭크카운터	Number	Y	3	미사용	필드.</param>
/// <param name="gubun">조회구분	String	Y	1	일반	조회	:	0	차트	조회	:	1	OutBlock1의	volume	필드	값	구분함.	일반	:	누적거래량,	차트	:	체결량</param>
public record t1475InBlock(string shcode, string vptype, int datacnt, int date, int time, int rankcnt, string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="date">기준일자	Number	Y	8</param>
/// <param name="time">기준시간	Number	Y	6</param>
/// <param name="rankcnt">랭크카운터	Number	Y	3</param>
public record t1475OutBlock(int date, int time, int rankcnt);

/// <summary>
/// 
/// </summary>
/// <param name="datetime">일자	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="todayvp">당일VP	Number	Y	8.2</param>
/// <param name="ma5vp">5일MAVP	Number	Y	8.2</param>
/// <param name="ma20vp">20일MAVP	Number	Y	8.2</param>
/// <param name="ma60vp">60일MAVP	Number	Y	8.2</param>
public record t1475OutBlock1(string datetime, int price, string sign, int change, double diff, long volume, double todayvp, double ma5vp, double ma20vp, double ma60vp);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="cts_time">시간CTS	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="cnt">조회건수	Object	Y	4	0020</param>
public record t1486InBlock(string shcode, string cts_time, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10</param>
public record t1486OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	8</param>
/// <param name="price">예상체결가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">예상체결량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	8</param>
/// <param name="bidho1">매수호가	Number	Y	8</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
public record t1486OutBlock1(string chetime, int price, string sign, int change, double diff, long cvolume, int offerho1, int bidho1, long offerrem1, long bidrem1);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">거래소구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="sign">상하락구분	String	Y	1	1:상승	2:하락</param>
/// <param name="jgubun">장구분	String	Y	1	1:장전	2:장후	3:직전대비</param>
/// <param name="jongchk">종목체크	String	Y	12	대상제외값	0x00000080:관리종목	0x00000100:시장경보	0x00000200:거래정지	0x00004000:우선주	0x00200000:증거금50/100	0x00400000:증거금50	0x00800000:증거금100	0x01000000:정리매매	0x04000000:투자유의	0x80000000:불성실공시</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="volume">거래량	String	Y	1	전체@0	1만주이상@1	5만주이상@2	10만주이상@3	50만주이상@4	백만주이상@5</param>
/// <param name="yesprice">예상체결시작가격	Number	Y	8	yesprice	<=	예상체결가	인	종목</param>
/// <param name="yeeprice">예상체결종료가격	Number	Y	8	예상체결가	<=	yeeprice	인	종목</param>
/// <param name="yevolume">예상체결량	Number	Y	12	예상체결량	>=	yevolume	인	종목</param>
public record t1488InBlock(string gubun, string sign, string jgubun, string jongchk, int idx, string volume, int yesprice, int yeeprice, long yevolume);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1488OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="offerrem">매도잔량	Number	Y	12</param>
/// <param name="offerho">매도호가	Number	Y	8</param>
/// <param name="bidho">매수호가	Number	Y	8</param>
/// <param name="bidrem">매수잔량	Number	Y	12</param>
/// <param name="cnt">연속일수	Number	Y	4</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="jkrate">증거금율	String	Y	3</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
public record t1488OutBlock1(string hname, int price, string sign, int change, double diff, long volume, long offerrem, int offerho, int bidho, long bidrem, int cnt, string shcode, string jkrate, long jnilvolume);

/// <summary>
/// 
/// </summary>
/// <param name="nrec">건수	Number	Y	3	최대	50개까지</param>
/// <param name="shcode">종목코드	String	Y	300	구분자	없이	종목코드를	붙여서	입력	078020,	000660,	005930	을	전송시	'078020000660005930'	을	입력</param>
public record t8407InBlock(int nrec, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="offerho">매도호가	Number	Y	8</param>
/// <param name="bidho">매수호가	Number	Y	8</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="chdegree">체결강도	Number	Y	9.2</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="value">거래대금(백만)	Number	Y	12</param>
/// <param name="offerrem">우선매도잔량	Number	Y	12</param>
/// <param name="bidrem">우선매수잔량	Number	Y	12</param>
/// <param name="totofferrem">총매도잔량	Number	Y	12</param>
/// <param name="totbidrem">총매수잔량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
public record t8407OutBlock1(string shcode, string hname, int price, string sign, int change, double diff, long volume, int offerho, int bidho, int cvolume, double chdegree, int open, int high, int low, long value, long offerrem, long bidrem, long totofferrem, long totbidrem, int jnilclose, int uplmtprice, int dnlmtprice);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분(KSP:1KSD:2)	String	Y	1</param>
public record t9945InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="etfchk">ETF구분	String	Y	1</param>
/// <param name="filler">filler	String	Y	5</param>
public record t9945OutBlock(string hname, string shcode, string expcode, string etfchk, string filler);

#endregion

#region [주식] 거래원

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="traddate1">조회날짜1	String	Y	8	기간	조회시	시작일(YYYYMMDD)</param>
/// <param name="traddate2">조회날짜2	String	Y	8	기간	조회시	종료일(YYYYMMDD)</param>
/// <param name="fwgubun1">외국계구분	String	Y	1	0	:	전체	1	:	외국계	회원사만	조회</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4	OutBlock	동일필드	연속조회시	입력</param>
public record t1752InBlock(string shcode, string traddate1, string traddate2, string fwgubun1, int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="fwdvl">외국계매도	Number	Y	12</param>
/// <param name="fwsvl">외국계매수	Number	Y	12</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
public record t1752OutBlock(long fwdvl, long fwsvl, int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="tradname">회원사	String	Y	20</param>
/// <param name="tradmdvol">매도수량	Number	Y	12</param>
/// <param name="tradmsvol">매수수량	Number	Y	12</param>
/// <param name="tradmssvol">순매수	Number	Y	12</param>
/// <param name="wintrd">창구거래	Number	Y	12</param>
/// <param name="winrat">비중	Number	Y	6.1</param>
/// <param name="tradno">회원사코드	String	Y	3</param>
/// <param name="wgubun">외국계여부	String	Y	1</param>
/// <param name="swinrat">순비중	Number	Y	6.1</param>
public record t1752OutBlock1(string tradname, long tradmdvol, long tradmsvol, long tradmssvol, long wintrd, double winrat, string tradno, string wgubun, double swinrat);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun1">구분1	String	Y	1	0	or	1	:	전회원사조회	0,1	이외의	값	입력시	InBlock.shcode	종목으로	거래가	있는	회원사만	조회됨</param>
public record t1764InBlock(string shcode, string gubun1);

/// <summary>
/// 
/// </summary>
/// <param name="rank">순위	Number	Y	4</param>
/// <param name="tradno">거래원번호	String	Y	3</param>
/// <param name="tradname">거래원이름	String	Y	20</param>
public record t1764OutBlock(int rank, string tradno, string tradname);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="tradno">거래원코드	String	Y	3	거래원코드	t1764	를	조회한	후	t1764OutBlock	의	tradno	의	값을	사용</param>
/// <param name="gubun1">구분1	String	Y	1	0	:	시간별	1	:	일별</param>
/// <param name="traddate1">거래원날짜1	String	Y	8	일별	조회시	사용	OutBlock1.traddate	>=	InBlock.traddate1</param>
/// <param name="traddate2">거래원날짜2	String	Y	8	일별	조회시	사용	OutBlock1.traddate	<=	InBlock.traddate2</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4	처음	조회시	Space	입력	다음	조회시	OutBlock의	cts_idx	값을	입력</param>
/// <param name="cnt">요청건수	Object	Y	3</param>
public record t1771InBlock(string shcode, string tradno, string gubun1, string traddate1, string traddate2, int cts_idx, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
public record t1771OutBlock(int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="traddate">날짜	String	Y	8</param>
/// <param name="tradtime">시간	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="tradmdcha">매도	Number	Y	12</param>
/// <param name="tradmscha">매수	Number	Y	12</param>
/// <param name="tradmdval">매도대금	Number	Y	18</param>
/// <param name="tradmsval">매수대금	Number	Y	18</param>
/// <param name="tradmsscha">순매수	Number	Y	12</param>
/// <param name="tradmttvolume">누적순매수	Number	Y	12</param>
/// <param name="tradavg">평균단가	Number	Y	8</param>
/// <param name="tradmttavg">누적평균단가	Number	Y	8</param>
public record t1771OutBlock2(string traddate, string tradtime, int price, string sign, int change, double diff, long volume, long tradmdcha, long tradmscha, long tradmdval, long tradmsval, long tradmsscha, long tradmttvolume, int tradavg, int tradmttavg);

#endregion

#region [주식] 투자정보

/// <summary>
/// 
/// </summary>
/// <param name="sNewsno">뉴스번호	String	Y	24</param>
public record t3102InBlock(string sNewsno);

/// <summary>
/// 
/// </summary>
/// <param name="sJongcode">뉴스종목	String	Y	6</param>
public record t3102OutBlock(string sJongcode);

/// <summary>
/// 
/// </summary>
/// <param name="sBody">뉴스본문	String	Y	100</param>
public record t3102OutBlock1(string sBody);

/// <summary>
/// 
/// </summary>
/// <param name="sTitle">뉴스타이틀	String	Y	300</param>
public record t3102OutBlock2(string sTitle);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="date">조회일자	String	Y	8</param>
public record t3202InBlock(string shcode, string date);

/// <summary>
/// 
/// </summary>
/// <param name="recdt">기준일	String	Y	8</param>
/// <param name="tableid">테이블아이디	String	Y	6</param>
/// <param name="upgu">업무구분	String	Y	2	01:유상증자	02:무상증가	03:배당	04:감자	05:합병/분할	06:매수청구	07:실권주	08:액면교체	09:주주총회	10:상호변경	11:국내CB전환	12:해외CB전환	13:해외BW행사	14:스톡옵션행사</param>
/// <param name="custno">발행체번호	String	Y	5</param>
/// <param name="custnm">발행회사명	String	Y	80</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="upunm">업무명	String	Y	20</param>
public record t3202OutBlock(string recdt, string tableid, string upgu, string custno, string custnm, string shcode, string upunm);

/// <summary>
/// 
/// </summary>
/// <param name="gicode">종목코드	String	Y	7</param>
public record t3320InBlock(string gicode);

/// <summary>
/// 
/// </summary>
/// <param name="upgubunnm">업종구분명	String	Y	20</param>
/// <param name="sijangcd">시장구분	String	Y	1</param>
/// <param name="marketnm">시장구분명	String	Y	10</param>
/// <param name="company">한글기업명	String	Y	100</param>
/// <param name="baddress">본사주소	String	Y	100</param>
/// <param name="btelno">본사전화번호	String	Y	20</param>
/// <param name="gsyyyy">최근결산년도	String	Y	4</param>
/// <param name="gsmm">결산월	String	Y	2</param>
/// <param name="gsym">최근결산년월	String	Y	6</param>
/// <param name="lstprice">주당액면가	Number	Y	12</param>
/// <param name="gstock">주식수	Number	Y	12</param>
/// <param name="homeurl">Homepage	String	Y	50</param>
/// <param name="grdnm">그룹명	String	Y	30</param>
/// <param name="foreignratio">외국인	Number	Y	6.2</param>
/// <param name="irtel">주담전화	String	Y	30</param>
/// <param name="capital">자본금	Number	Y	12</param>
/// <param name="sigavalue">시가총액	Number	Y	12</param>
/// <param name="cashsis">배당금	Number	Y	12</param>
/// <param name="cashrate">배당수익율	Number	Y	13.2</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="notice1">위험고지구분1_정리매매	String	Y	1</param>
/// <param name="notice2">위험고지구분2_투자위험	String	Y	1</param>
/// <param name="notice3">위험고지구분3_단기과열	String	Y	1</param>
public record t3320OutBlock(string upgubunnm, string sijangcd, string marketnm, string company, string baddress, string btelno, string gsyyyy, string gsmm, string gsym, long lstprice, long gstock, string homeurl, string grdnm, double foreignratio, string irtel, long capital, long sigavalue, long cashsis, double cashrate, int price, int jnilclose, string notice1, string notice2, string notice3);

/// <summary>
/// 
/// </summary>
/// <param name="gicode">기업코드	String	Y	7</param>
/// <param name="gsym">결산년월	String	Y	6</param>
/// <param name="gsgb">결산구분	String	Y	1</param>
/// <param name="per">PER	Number	Y	13.2</param>
/// <param name="eps">EPS	Number	Y	13</param>
/// <param name="pbr">PBR	Number	Y	13.2</param>
/// <param name="roa">ROA	Number	Y	13.2</param>
/// <param name="roe">ROE	Number	Y	13.2</param>
/// <param name="ebitda">EBITDA	Number	Y	13.2</param>
/// <param name="evebitda">EVEBITDA	Number	Y	13.2</param>
/// <param name="par">액면가	Number	Y	13.2</param>
/// <param name="sps">SPS	Number	Y	13.2</param>
/// <param name="cps">CPS	Number	Y	13.2</param>
/// <param name="bps">BPS	Number	Y	13</param>
/// <param name="t_per">T.PER	Number	Y	13.2</param>
/// <param name="t_eps">T.EPS	Number	Y	13</param>
/// <param name="peg">PEG	Number	Y	13.2</param>
/// <param name="t_peg">T.PEG	Number	Y	13.2</param>
/// <param name="t_gsym">최근분기년도	String	Y	6</param>
public record t3320OutBlock1(string gicode, string gsym, string gsgb, double per, long eps, double pbr, double roa, double roe, double ebitda, double evebitda, double par, double sps, double cps, long bps, double t_per, long t_eps, double peg, double t_peg, string t_gsym);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">시장구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="gubun1">순위구분(1:매출액증가율2:영업이익증가율	3:세전계속이익증가율4:부채비율5:유보율	6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)	String	Y	1	1@매출액증가율	2@영업이익증가율	3@세전계속이익증가율	4@부채비율	5@유보율	6@EPS	7@BPS	8@ROE	9@PER	:	오름차순	a@PBR	:	오름차순	b@PEG	:	오름차순</param>
/// <param name="gubun2">대비구분	String	Y	1	1	고정</param>
/// <param name="idx">IDX	Number	Y	4	idx	첫조회시	space	연속조회시	Outblock의	idx	값	세팅</param>
public record t3341InBlock(string gubun, string gubun1, string gubun2, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">CNT	Number	Y	4</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t3341OutBlock(int cnt, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="rank">순위	Number	Y	4</param>
/// <param name="hname">기업명	String	Y	20</param>
/// <param name="salesgrowth">매출액증가율	Number	Y	12</param>
/// <param name="operatingincomegrowt">영업이익증가율	Number	Y	12</param>
/// <param name="ordinaryincomegrowth">경상이익증가율	Number	Y	12</param>
/// <param name="liabilitytoequity">부채비율	Number	Y	12</param>
/// <param name="enterpriseratio">유보율	Number	Y	12</param>
/// <param name="eps">EPS	Number	Y	12</param>
/// <param name="bps">BPS	Number	Y	12</param>
/// <param name="roe">ROE	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="per">PER	Number	Y	13.2</param>
/// <param name="pbr">PBR	Number	Y	13.2</param>
/// <param name="peg">PEG	Number	Y	13.2</param>
public record t3341OutBlock1(int rank, string hname, long salesgrowth, long operatingincomegrowt, long ordinaryincomegrowth, long liabilitytoequity, long enterpriseratio, long eps, long bps, long roe, string shcode, double per, double pbr, double peg);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	9</param>
/// <param name="gubun1">구분	String	Y	1</param>
/// <param name="tradno">회원사코드	String	Y	3</param>
/// <param name="cts_date">IDXDATE	String	Y	8</param>
public record t3401InBlock(string shcode, string gubun1, string tradno, string cts_date);

/// <summary>
/// 
/// </summary>
/// <param name="cts_date">IDXDATE	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">대비속성	String	Y	1</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t3401OutBlock(string cts_date, int price, string sign, int change, double diff, long volume, long value);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	9</param>
/// <param name="tradno">회원사코드	String	Y	3</param>
/// <param name="date">의견일자	String	Y	8</param>
/// <param name="tradname">회원사명	String	Y	30</param>
/// <param name="bopn">투자의견변경후	String	Y	30</param>
/// <param name="nopn">투자의견변경전	String	Y	30</param>
/// <param name="boga">목표가변경전	Number	Y	12</param>
/// <param name="noga">목표가변경후	Number	Y	12</param>
/// <param name="close">의견일종가	Number	Y	8</param>
public record t3401OutBlock1(string shcode, string tradno, string date, string tradname, string bopn, string nopn, long boga, long noga, int close);

/// <summary>
/// 
/// </summary>
/// <param name="kind">종목종류	String	Y	1	S:해외지수	F:해외선물	R:환율/금리</param>
/// <param name="symbol">SYMBOL	String	Y	16</param>
/// <param name="cnt">입력건수	Number	Y	4</param>
/// <param name="jgbn">조회구분	String	Y	1	0:일	1:주	2:월	3:분	4:틱</param>
/// <param name="nmin">N분	Number	Y	3	jgbn이	3인	경우에	n분</param>
/// <param name="cts_date">CTS_DATE	String	Y	8	다음	조회시	OutBlock의	cts_date	입력	처음	조회시	스페이스</param>
/// <param name="cts_time">CTS_TIME	String	Y	6	다음	조회시	OutBlock의	cts_time	입력	처음	조회시	스페이스</param>
public record t3518InBlock(string kind, string symbol, int cnt, string jgbn, int nmin, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_date">CTS_DATE	String	Y	8</param>
/// <param name="cts_time">CTS_TIME	String	Y	6</param>
public record t3518OutBlock(string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	8</param>
/// <param name="open">시가	Number	Y	9.4	※	종목종류별	가격	소수점	자리수	-	S(해외지수)	:	9.2	-	F(해외선물)	:	9.2	-	R(환율/금리)	:	9.4</param>
/// <param name="high">고가	Number	Y	9.4	※	종목종류별	가격	소수점	자리수	-	S(해외지수)	:	9.2	-	F(해외선물)	:	9.2	-	R(환율/금리)	:	9.4</param>
/// <param name="low">저가	Number	Y	9.4	※	종목종류별	가격	소수점	자리수	-	S(해외지수)	:	9.2	-	F(해외선물)	:	9.2	-	R(환율/금리)	:	9.4</param>
/// <param name="price">현재가	Number	Y	9.4</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	9.4</param>
/// <param name="uprate">등락율	Number	Y	9.4</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="bidho">매수호가	Number	Y	9.4</param>
/// <param name="offerho">매도호가	Number	Y	9.4</param>
/// <param name="bidrem">매수잔량	Number	Y	12</param>
/// <param name="offerrem">매도잔량	Number	Y	12</param>
/// <param name="kind">종목종류	String	Y	1</param>
/// <param name="symbol">SYMBOL	String	Y	16</param>
/// <param name="exid">EXID	String	Y	4</param>
/// <param name="kodate">한국일자	String	Y	8</param>
/// <param name="kotime">한국시간	String	Y	8</param>
public record t3518OutBlock1(string date, string time, double open, double high, double low, double price, string sign, double change, double uprate, long volume, double bidho, double offerho, long bidrem, long offerrem, string kind, string symbol, string exid, string kodate, string kotime);

/// <summary>
/// 
/// </summary>
/// <param name="kind">종목종류	String	Y	1	S	:	해외지수	R	:	해외환율	F	:	해외선물</param>
/// <param name="symbol">SYMBOL	String	Y	16	해외지수/환율/선물	SYMBOL	-----	주요해외지수	SYMBOL	-----	DJI@DJI	:	다우산업	NAS@IXIC	:	나스닥	종합	SPI@SPX	:	S&P	500	USI@SOXX	:	필라델피아	반도체	NII@NI225	:	니케이	225	TWS@TI01	:	대만	가권	SHS@000002	:	상해	A	SHS@000003	:	상해	B	SGI@STI	:	싱가폴	STI	HSI@HSI	:	항셍	PAS@CAC40	:	프랑스	CAC	40	LNS@FTSE100	:	영국	FTSE	100	XTR@DAX30	:	독일	DAX	30</param>
public record t3521InBlock(string kind, string symbol);

/// <summary>
/// API 매뉴얼에 없음
/// </summary>
/// <param name="date"></param>
/// <param name="symbol"></param>
/// <param name="change"></param>
/// <param name="sign"></param>
/// <param name="diff"></param>
/// <param name="close"></param>
/// <param name="hname"></param>
public record t3521OutBlock(string date, string symbol, double change, string sign, double diff, double close, string hname);

/// <summary>
/// 
/// </summary>
/// <param name="fdate">from일자	String	Y	8	출력	기간의	시작일</param>
/// <param name="tdate">to일자	String	Y	8	출력	기간의	종료일</param>
/// <param name="gubun">구분	String	Y	1	1:예탁금	2:수익증권</param>
/// <param name="key_date">날짜	String	Y	8	다음	조회시	사용함.	다음	조회시	OutBlock의	date	필드값	입력.	처음	조회시	Space</param>
/// <param name="upcode">업종코드	String	Y	3	001:코스피	301:코스닥</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
public record t8428InBlock(string fdate, string tdate, string gubun, string key_date, string upcode, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜CTS	String	Y	8</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t8428OutBlock(string date, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="jisu">지수	Number	Y	7.2</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="custmoney">고객예탁금_억원	Number	Y	12</param>
/// <param name="yecha">예탁증감_억원	Number	Y	12</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="outmoney">미수금_억원	Number	Y	12</param>
/// <param name="trjango">신용잔고_억원	Number	Y	12</param>
/// <param name="futymoney">선물예수금_억원	Number	Y	12</param>
/// <param name="stkmoney">주식형_억원	Number	Y	8</param>
/// <param name="mstkmoney">혼합형_억원(주식)	Number	Y	8</param>
/// <param name="mbndmoney">혼합형_억원(채권)	Number	Y	8</param>
/// <param name="bndmoney">채권형_억원	Number	Y	8</param>
/// <param name="bndsmoney">필러(구.단기채권)	Number	Y	8</param>
/// <param name="mmfmoney">MMF_억원(주식)	Number	Y	8</param>
public record t8428OutBlock1(string date, double jisu, string sign, double change, double diff, long volume, long custmoney, long yecha, double vol, long outmoney, long trjango, long futymoney, int stkmoney, int mstkmoney, int mbndmoney, int bndmoney, int bndsmoney, int mmfmoney);



#endregion

#region [주식] 프로그램

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	1:거래소	2:코스닥</param>
/// <param name="dgubun">일자구분	String	Y	1	1:당일조회	2:기간조회</param>
/// <param name="sdate">시작일자	String	Y	8</param>
/// <param name="edate">종료일자	String	Y	8</param>
public record t1631InBlock(string gubun, string dgubun, string sdate, string edate);

/// <summary>
/// 
/// </summary>
/// <param name="cdhrem">매도차익미체결잔량	Number	Y	8</param>
/// <param name="bdhrem">매도비차익미체결잔량	Number	Y	8</param>
/// <param name="tcdrem">매도차익주문수량	Number	Y	8</param>
/// <param name="tbdrem">매도비차익주문수량	Number	Y	8</param>
/// <param name="cshrem">매수차익미체결잔량	Number	Y	8</param>
/// <param name="bshrem">매수비차익미체결잔량	Number	Y	8</param>
/// <param name="tcsrem">매수차익주문수량	Number	Y	8</param>
/// <param name="tbsrem">매수비차익주문수량	Number	Y	8</param>
public record t1631OutBlock(int cdhrem, int bdhrem, int tcdrem, int tbdrem, int cshrem, int bshrem, int tcsrem, int tbsrem);

/// <summary>
/// 
/// </summary>
/// <param name="offervolume">매도수량	Number	Y	8</param>
/// <param name="offervalue">매도금액	Number	Y	12</param>
/// <param name="bidvolume">매수수량	Number	Y	8</param>
/// <param name="bidvalue">매수금액	Number	Y	12</param>
/// <param name="volume">순매수수량	Number	Y	8</param>
/// <param name="value">순매수금액	Number	Y	12</param>
public record t1631OutBlock1(int offervolume, long offervalue, int bidvolume, long bidvalue, int volume, long value);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0@거래소	1@코스닥</param>
/// <param name="gubun1">금액수량구분	String	Y	1	0:금액	1:수량</param>
/// <param name="gubun2">직전대비증감	String	Y	1	1:직전대비증감</param>
/// <param name="gubun3">전일구분	String	Y	1	1:전일분</param>
/// <param name="date">일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
/// <param name="time">시간	String	Y	6	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	time	값으로	설정</param>
public record t1632InBlock(string gubun, string gubun1, string gubun2, string gubun3, string date, string time);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜CTS	String	Y	8</param>
/// <param name="time">시간CTS	String	Y	6</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1632OutBlock(string date, string time, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="k200jisu">KP200	Number	Y	6.2</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	6.2</param>
/// <param name="k200basis">BASIS	Number	Y	6.2</param>
/// <param name="tot3">전체순매수	Number	Y	12</param>
/// <param name="tot1">전체매수	Number	Y	12</param>
/// <param name="tot2">전체매도	Number	Y	12</param>
/// <param name="cha3">차익순매수	Number	Y	12</param>
/// <param name="cha1">차익매수	Number	Y	12</param>
/// <param name="cha2">차익매도	Number	Y	12</param>
/// <param name="bcha3">비차익순매수	Number	Y	12</param>
/// <param name="bcha1">비차익매수	Number	Y	12</param>
/// <param name="bcha2">비차익매도	Number	Y	12</param>
public record t1632OutBlock1(string time, double k200jisu, string sign, double change, double k200basis, long tot3, long tot1, long tot2, long cha3, long cha1, long cha2, long bcha3, long bcha1, long bcha2);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">시장구분	String	Y	1	0@거래소	1@코스닥</param>
/// <param name="gubun1">금액수량구분	String	Y	1	0:금액	1:수량</param>
/// <param name="gubun2">수치누적구분	String	Y	1	0@수치	1@누적</param>
/// <param name="gubun3">일주월구분	String	Y	1	1@일	2@주	3@월</param>
/// <param name="fdate">from일자	String	Y	8</param>
/// <param name="tdate">to일자	String	Y	8</param>
/// <param name="gubun4">직전대비증감구분	String	Y	1	0:Default	1:직전대비증감</param>
/// <param name="date">날짜	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
public record t1633InBlock(string gubun, string gubun1, string gubun2, string gubun3, string fdate, string tdate, string gubun4, string date);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1633OutBlock(string date, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="jisu">KP200	Number	Y	6.2</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	6.2</param>
/// <param name="tot3">전체순매수	Number	Y	12</param>
/// <param name="tot1">전체매수	Number	Y	12</param>
/// <param name="tot2">전체매도	Number	Y	12</param>
/// <param name="cha3">차익순매수	Number	Y	12</param>
/// <param name="cha1">차익매수	Number	Y	12</param>
/// <param name="cha2">차익매도	Number	Y	12</param>
/// <param name="bcha3">비차익순매수	Number	Y	12</param>
/// <param name="bcha1">비차익매수	Number	Y	12</param>
/// <param name="bcha2">비차익매도	Number	Y	12</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record t1633OutBlock1(string date, double jisu, string sign, double change, long tot3, long tot1, long tot2, long cha3, long cha1, long cha2, long bcha3, long bcha1, long bcha2, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:코스피	1:코스닥</param>
/// <param name="gubun1">금액수량구분	String	Y	1	0:수량	1:금액</param>
/// <param name="gubun2">정렬기준	String	Y	1	0:시가총액비중	1:순매수상위	2:순매도상위	3:매도상위	4:매수상위</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="cts_idx">IDXCTS	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_idx	값으로	설정</param>
public record t1636InBlock(string gubun, string gubun1, string gubun2, string shcode, int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="cts_idx">IDXCTS	Number	Y	4</param>
public record t1636OutBlock(int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="rank">순위	Number	Y	8</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="svalue">순매수금액	Number	Y	12</param>
/// <param name="offervalue">매도금액	Number	Y	12</param>
/// <param name="stksvalue">매수금액	Number	Y	12</param>
/// <param name="svolume">순매수수량	Number	Y	12</param>
/// <param name="offervolume">매도수량	Number	Y	12</param>
/// <param name="stksvolume">매수수량	Number	Y	12</param>
/// <param name="sgta">시가총액	Number	Y	15</param>
/// <param name="rate">비중	Number	Y	6.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1636OutBlock1(int rank, string hname, int price, string sign, int change, double diff, long volume, long svalue, long offervalue, long stksvalue, long svolume, long offervolume, long stksvolume, long sgta, double rate, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">수량금액구분(0:수량1:금액)	String	Y	1</param>
/// <param name="gubun2">시간일별구분(0:시간1:일자)	String	Y	1</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="date">일자	String	Y	8	일별	연속	조회시에	이전	조회한	OutBlock1의	마지막	Row의	date	값으로	설정</param>
/// <param name="time">시간	String	Y	6	시간별	연속	조회시에	이전	조회한	OutBlock1의	마지막	Row의	time	값으로	설정</param>
/// <param name="cts_idx">IDXCTS(9999:차트)	Number	Y	4	차트	조회시에만	9999로	입력</param>
public record t1637InBlock(string gubun1, string gubun2, string shcode, string date, string time, int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="cts_idx">IDXCTS	Number	Y	4</param>
public record t1637OutBlock(int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="svalue">순매수금액	Number	Y	15</param>
/// <param name="offervalue">매도금액	Number	Y	15</param>
/// <param name="stksvalue">매수금액	Number	Y	15</param>
/// <param name="svolume">순매수수량	Number	Y	12</param>
/// <param name="offervolume">매도수량	Number	Y	12</param>
/// <param name="stksvolume">매수수량	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1637OutBlock1(string date, string time, int price, string sign, int change, double diff, long volume, long svalue, long offervalue, long stksvalue, long svolume, long offervolume, long stksvolume, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	2	11@거래소전체	12@거래소차익	13@거래소비차익	21@코스닥전체	22@코스닥차익	23@코스닥비차익</param>
public record t1640InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="offervolume">매도수량	Number	Y	8</param>
/// <param name="bidvolume">매수수량	Number	Y	8</param>
/// <param name="volume">순매수수량	Number	Y	8</param>
/// <param name="offerdiff">매도증감	Number	Y	8</param>
/// <param name="biddiff">매수증감	Number	Y	8</param>
/// <param name="sundiff">순매수증감	Number	Y	8</param>
/// <param name="basis">베이시스	Number	Y	6.2</param>
/// <param name="offervalue">매도금액	Number	Y	12</param>
/// <param name="bidvalue">매수금액	Number	Y	12</param>
/// <param name="value">순매수금액	Number	Y	12</param>
/// <param name="offervaldiff">매도금액증감	Number	Y	12</param>
/// <param name="bidvaldiff">매수금액증감	Number	Y	12</param>
/// <param name="sunvaldiff">순매수증감	Number	Y	12</param>
public record t1640OutBlock(int offervolume, int bidvolume, int volume, int offerdiff, int biddiff, int sundiff, double basis, long offervalue, long bidvalue, long value, long offervaldiff, long bidvaldiff, long sunvaldiff);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0@코스피	1@코스닥</param>
/// <param name="gubun1">금액수량구분	String	Y	1	0:금액	1:수량</param>
/// <param name="gubun3">전일구분	String	Y	1	0:당일	1:전일</param>
public record t1662InBlock(string gubun, string gubun1, string gubun3);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="k200jisu">KP200	Number	Y	6.2</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	6.2</param>
/// <param name="k200basis">BASIS	Number	Y	6.2</param>
/// <param name="tot3">전체순매수	Number	Y	12</param>
/// <param name="tot1">전체매수	Number	Y	12</param>
/// <param name="tot2">전체매도	Number	Y	12</param>
/// <param name="cha3">차익순매수	Number	Y	12</param>
/// <param name="cha1">차익매수	Number	Y	12</param>
/// <param name="cha2">차익매도	Number	Y	12</param>
/// <param name="bcha3">비차익순매수	Number	Y	12</param>
/// <param name="bcha1">비차익매수	Number	Y	12</param>
/// <param name="bcha2">비차익매도	Number	Y	12</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record t1662OutBlock(string time, double k200jisu, string sign, double change, double k200basis, long tot3, long tot1, long tot2, long cha3, long cha1, long cha2, long bcha3, long bcha1, long bcha2, long volume);

#endregion

#region [주식] 투자자

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">주식금액수량구분1	String	Y	1	1:수량	2:금액</param>
/// <param name="gubun2">옵션금액수량구분2	String	Y	1	1:수량	2:금액</param>
/// <param name="gubun3">금액단위	String	Y	1	사용안함</param>
/// <param name="gubun4">선물금액수량구분4	String	Y	1	1:수량	2:금액</param>
public record t1601InBlock(string gubun1, string gubun2, string gubun3, string gubun4);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock1(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock2(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock3(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock4(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock5(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1601OutBlock6(string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="market">시장구분	String	Y	1	1@코스피	2@KP200	3@코스닥	4@선물	5@콜옵션	6@풋옵션	7@ELW	8@ETF</param>
/// <param name="upcode">업종코드	String	Y	3	001:코스피	101:KP200	301:코스닥	900:선	물	700:콜옵션	800:풋옵션	550:ELW	560:ETF</param>
/// <param name="gubun1">수량구분	String	Y	1	1:수량	2:금액</param>
/// <param name="gubun2">전일분구분	String	Y	1	0:금일	1:전일</param>
/// <param name="cts_time">CTSTIME	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4	사용안함</param>
/// <param name="cnt">조회건수	Object	Y	4</param>
/// <param name="gubun3">직전대비구분(C:직전대비)	String	Y	1</param>
public record t1602InBlock(string market, string upcode, string gubun1, string gubun2, string cts_time, int cts_idx, object cnt, string gubun3);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">CTSTIME	String	Y	8</param>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t1602OutBlock(string cts_time, string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	8</param>
/// <param name="sv_08">개인순매수	Number	Y	12</param>
/// <param name="sv_17">외국인순매수	Number	Y	12</param>
/// <param name="sv_18">기관계순매수	Number	Y	12</param>
/// <param name="sv_01">증권순매수	Number	Y	12</param>
/// <param name="sv_03">투신순매수	Number	Y	12</param>
/// <param name="sv_04">은행순매수	Number	Y	12</param>
/// <param name="sv_02">보험순매수	Number	Y	12</param>
/// <param name="sv_05">종금순매수	Number	Y	12</param>
/// <param name="sv_06">기금순매수	Number	Y	12</param>
/// <param name="sv_07">기타순매수	Number	Y	12</param>
/// <param name="sv_11">국가순매수	Number	Y	12</param>
/// <param name="sv_00">사모펀드순매수	Number	Y	12</param>
public record t1602OutBlock1(string time, long sv_08, long sv_17, long sv_18, long sv_01, long sv_03, long sv_04, long sv_02, long sv_05, long sv_06, long sv_07, long sv_11, long sv_00);

/// <summary>
/// 
/// </summary>
/// <param name="market">시장구분	String	Y	1	1:코스피	2:코스닥	3:선물	4:콜옵션	5:풋옵션	6:ELW	7:ETF</param>
/// <param name="gubun1">투자자구분	String	Y	1	1:개인	2:외인	3:기관계	4:증권	5:투신	6:은행	7:보험	8:종금	9:기금	A:국가	B:기타	C:사모펀드</param>
/// <param name="gubun2">전일분구분	String	Y	1	0:당일	1:전일</param>
/// <param name="cts_time">CTSTIME	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_idx	값으로	설정</param>
/// <param name="cnt">조회건수	Object	Y	3	020</param>
/// <param name="upcode">업종코드	String	Y	3</param>
public record t1603InBlock(string market, string gubun1, string gubun2, string cts_time, int cts_idx, object cnt, string upcode);

/// <summary>
/// 
/// </summary>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
/// <param name="cts_time">CTSTIME	String	Y	8</param>
public record t1603OutBlock(int cts_idx, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	8</param>
/// <param name="tjjcode">투자자구분	String	Y	4</param>
/// <param name="msvolume">매수수량	Number	Y	8</param>
/// <param name="mdvolume">매도수량	Number	Y	8</param>
/// <param name="msvalue">매수금액	Number	Y	12</param>
/// <param name="mdvalue">매도금액	Number	Y	12</param>
/// <param name="svolume">순매수수량	Number	Y	8</param>
/// <param name="svalue">순매수금액	Number	Y	12</param>
public record t1603OutBlock1(string time, string tjjcode, int msvolume, int mdvolume, long msvalue, long mdvalue, int svolume, long svalue);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">주식구분	String	Y	1	1:수량	2:금액</param>
/// <param name="gubun2">옵션구분	String	Y	1	1:수량	2:금액</param>
public record t1615InBlock(string gubun1, string gubun2);

/// <summary>
/// 
/// </summary>
/// <param name="dwvolume">위탁매도수량	Number	Y	12</param>
/// <param name="dwvalue">위탁매도금액	Number	Y	12</param>
/// <param name="djvolume">자기매도수량	Number	Y	12</param>
/// <param name="djvalue">자기매도금액	Number	Y	12</param>
/// <param name="sum_volume">합계수량	Number	Y	12</param>
/// <param name="sum_value">합계금액	Number	Y	12</param>
public record t1615OutBlock(long dwvolume, long dwvalue, long djvolume, long djvalue, long sum_volume, long sum_value);

/// <summary>
/// 
/// </summary>
/// <param name="hname">시장명	String	Y	20</param>
/// <param name="sv_08">개인	Number	Y	12</param>
/// <param name="sv_17">외국인	Number	Y	12</param>
/// <param name="sv_18">기관계	Number	Y	12</param>
/// <param name="sv_07">증권	Number	Y	12</param>
public record t1615OutBlock1(string hname, long sv_08, long sv_17, long sv_18, long sv_07);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">시장구분	String	Y	1	1:코스피	2:코스닥	3:선물	4:콜옵션	5:풋옵션	6:주식선물	7:변동성	8:M선물	9:M콜옵션	0:M풋옵션</param>
/// <param name="gubun2">수량금액구분(1:수량2:금액)	String	Y	1</param>
/// <param name="gubun3">일자구분(1:시간대별2:일별)	String	Y	1</param>
/// <param name="cts_date">CTSDATE(연속키값-일자)	String	Y	8</param>
/// <param name="cts_time">CTSTIME(연속키값-시간)	String	Y	8</param>
public record t1617InBlock(string gubun1, string gubun2, string gubun3, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_date">CTSDATE	String	Y	8</param>
/// <param name="cts_time">CTSTIME	String	Y	8</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="sv_08">개인순매수	Number	Y	12</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="sv_17">외국인순매수	Number	Y	12</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="sv_18">기관계순매수	Number	Y	12</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="sv_01">증권순매수	Number	Y	12</param>
public record t1617OutBlock(string cts_date, string cts_time, long ms_08, long md_08, long sv_08, long ms_17, long md_17, long sv_17, long ms_18, long md_18, long sv_18, long ms_01, long md_01, long sv_01);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	8</param>
/// <param name="sv_08">개인	Number	Y	12</param>
/// <param name="sv_17">외국인	Number	Y	12</param>
/// <param name="sv_18">기관계	Number	Y	12</param>
/// <param name="sv_01">증권	Number	Y	12</param>
public record t1617OutBlock1(string date, string time, long sv_08, long sv_17, long sv_18, long sv_01);

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="nmin">N분	Object	Y	2</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
/// <param name="bgubun">전일분	String	Y	1	0:당일	1:전일</param>
public record t1621InBlock(string upcode, object nmin, object cnt, string bgubun);

/// <summary>
/// 
/// </summary>
/// <param name="indcode">개인투자자코드	String	Y	4</param>
/// <param name="forcode">외국인투자자코드	String	Y	4</param>
/// <param name="syscode">기관계투자자코드	String	Y	4</param>
/// <param name="stocode">증권투자자코드	String	Y	4</param>
/// <param name="invcode">투신투자자코드	String	Y	4</param>
/// <param name="bancode">은행투자자코드	String	Y	4</param>
/// <param name="inscode">보험투자자코드	String	Y	4</param>
/// <param name="fincode">종금투자자코드	String	Y	4</param>
/// <param name="moncode">기금투자자코드	String	Y	4</param>
/// <param name="etccode">기타투자자코드	String	Y	4</param>
/// <param name="natcode">국가투자자코드	String	Y	4</param>
/// <param name="pefcode">사모펀드투자자코드	String	Y	4</param>
/// <param name="jisucd">기준지수코드	String	Y	8</param>
/// <param name="jisunm">기준지수명	String	Y	20</param>
public record t1621OutBlock(string indcode, string forcode, string syscode, string stocode, string invcode, string bancode, string inscode, string fincode, string moncode, string etccode, string natcode, string pefcode, string jisucd, string jisunm);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="datetime">일자시간	String	Y	14</param>
/// <param name="indmsvol">개인순매수거래량	Number	Y	8</param>
/// <param name="indmsamt">개인순매수거래대금	Number	Y	12</param>
/// <param name="formsvol">외국인순매수거래량	Number	Y	8</param>
/// <param name="formsamt">외국인순매수거래대금	Number	Y	12</param>
/// <param name="sysmsvol">기관계순매수거래량	Number	Y	8</param>
/// <param name="sysmsamt">기관계순매수거래대금	Number	Y	12</param>
/// <param name="stomsvol">증권순매수거래량	Number	Y	8</param>
/// <param name="stomsamt">증권순매수거래대금	Number	Y	12</param>
/// <param name="invmsvol">투신순매수거래량	Number	Y	8</param>
/// <param name="invmsamt">투신순매수거래대금	Number	Y	12</param>
/// <param name="banmsvol">은행순매수거래량	Number	Y	8</param>
/// <param name="banmsamt">은행순매수거래대금	Number	Y	12</param>
/// <param name="insmsvol">보험순매수거래량	Number	Y	8</param>
/// <param name="insmsamt">보험순매수거래대금	Number	Y	12</param>
/// <param name="finmsvol">종금순매수거래량	Number	Y	8</param>
/// <param name="finmsamt">종금순매수거래대금	Number	Y	12</param>
/// <param name="monmsvol">기금순매수거래량	Number	Y	8</param>
/// <param name="monmsamt">기금순매수거래대금	Number	Y	12</param>
/// <param name="etcmsvol">기타순매수거래량	Number	Y	8</param>
/// <param name="etcmsamt">기타순매수거래대금	Number	Y	12</param>
/// <param name="natmsvol">국가순매수거래량	Number	Y	8</param>
/// <param name="natmsamt">국가순매수거래대금	Number	Y	12</param>
/// <param name="pefmsvol">사모펀드순매수거래량	Number	Y	8</param>
/// <param name="pefmsamt">사모펀드순매수거래대금	Number	Y	12</param>
/// <param name="upclose">기준지수	Number	Y	6.2</param>
/// <param name="upcvolume">기준체결거래량	Number	Y	8</param>
/// <param name="upvolume">기준누적거래량	Number	Y	12</param>
/// <param name="upvalue">기준거래대금	Number	Y	12</param>
public record t1621OutBlock1(string date, string time, string datetime, int indmsvol, long indmsamt, int formsvol, long formsamt, int sysmsvol, long sysmsamt, int stomsvol, long stomsamt, int invmsvol, long invmsamt, int banmsvol, long banmsamt, int insmsvol, long insmsamt, int finmsvol, long finmsamt, int monmsvol, long monmsamt, int etcmsvol, long etcmsamt, int natmsvol, long natmsamt, int pefmsvol, long pefmsamt, double upclose, int upcvolume, long upvolume, long upvalue);

/// <summary>
/// 
/// </summary>
/// <param name="mgubun">시장구분	String	Y	1	1@코스피	2@코스닥	3@선	물	4@콜옵션	5@풋옵션</param>
/// <param name="vagubun">금액수량구분	String	Y	1	1:수량	2:금액</param>
/// <param name="bdgubun">시간일별구분	String	Y	1	1:시간별	2:일별</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
public record t1664InBlock(string mgubun, string vagubun, string bdgubun, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="dt">일자시간	String	Y	8</param>
/// <param name="tjj01">증권순매수	Number	Y	12</param>
/// <param name="tjj02">보험순매수	Number	Y	12</param>
/// <param name="tjj03">투신순매수	Number	Y	12</param>
/// <param name="tjj04">은행순매수	Number	Y	12</param>
/// <param name="tjj05">종금순매수	Number	Y	12</param>
/// <param name="tjj06">기금순매수	Number	Y	12</param>
/// <param name="tjj07">기타순매수	Number	Y	12</param>
/// <param name="tjj08">개인순매수	Number	Y	12</param>
/// <param name="tjj17">외국인순매수	Number	Y	12</param>
/// <param name="tjj18">기관순매수	Number	Y	12</param>
/// <param name="cha">차익순매수	Number	Y	12</param>
/// <param name="bicha">비차익순매수	Number	Y	12</param>
/// <param name="totcha">종합순매수	Number	Y	12</param>
/// <param name="basis">베이시스	Number	Y	6.2</param>
public record t1664OutBlock1(string dt, long tjj01, long tjj02, long tjj03, long tjj04, long tjj05, long tjj06, long tjj07, long tjj08, long tjj17, long tjj18, long cha, long bicha, long totcha, double basis);



#endregion

#region [주식] 외인/기관

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="todt">종료일자	String	Y	8	t1702OutBlock1.date	<=	t1702InBlock.todt</param>
/// <param name="volvalgb">금액수량구분(0:금액1:수량2:단가)	String	Y	1</param>
/// <param name="msmdgb">매수매도구분(0:순매수1:매수2:매도)	String	Y	1</param>
/// <param name="cumulgb">누적구분(0:일간1:누적)	String	Y	1</param>
/// <param name="cts_date">CTSDATE	String	Y	8	최초	조회시	Space	연속조회시	t1702OutBlock.cts_date	입력</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
public record t1702InBlock(string shcode, string todt, string volvalgb, string msmdgb, string cumulgb, string cts_date, int cts_idx);

/// <summary>
/// 
/// </summary>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
/// <param name="cts_date">CTSDATE	String	Y	8</param>
public record t1702OutBlock(int cts_idx, string cts_date);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="amt0000">사모펀드	Number	Y	12</param>
/// <param name="amt0001">증권	Number	Y	12</param>
/// <param name="amt0002">보험	Number	Y	12</param>
/// <param name="amt0003">투신	Number	Y	12</param>
/// <param name="amt0004">은행	Number	Y	12</param>
/// <param name="amt0005">종금	Number	Y	12</param>
/// <param name="amt0006">기금	Number	Y	12</param>
/// <param name="amt0007">기타법인	Number	Y	12</param>
/// <param name="amt0008">개인	Number	Y	12</param>
/// <param name="amt0009">등록외국인	Number	Y	12</param>
/// <param name="amt0010">미등록외국인	Number	Y	12</param>
/// <param name="amt0011">국가외	Number	Y	12</param>
/// <param name="amt0018">기관	Number	Y	12</param>
/// <param name="amt0088">외인계(등록+미등록)	Number	Y	12</param>
/// <param name="amt0099">기타계(기타+국가)	Number	Y	12</param>
public record t1702OutBlock1(string date, int close, string sign, int change, double diff, long volume, long amt0000, long amt0001, long amt0002, long amt0003, long amt0004, long amt0005, long amt0006, long amt0007, long amt0008, long amt0009, long amt0010, long amt0011, long amt0018, long amt0088, long amt0099);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	String	Y	1	0:일간순매수	1:기간내누적순매수</param>
/// <param name="fromdt">시작일자	String	Y	8	YYYYMMDD</param>
/// <param name="todt">종료일자	String	Y	8	YYYYMMDD</param>
/// <param name="prapp">PR감산적용율	Number	Y	3	프로그램매매	감산	적용율	-	%단위</param>
/// <param name="prgubun">PR적용구분(0:적용안함1:적용)	String	Y	1	0:미적용	1:적용</param>
/// <param name="orggubun">기관적용	String	Y	1	0:미적용	1:적용</param>
/// <param name="frggubun">외인적용	String	Y	1	0:미적용	1:적용</param>
public record t1716InBlock(string shcode, string gubun, string fromdt, string todt, int prapp, string prgubun, string orggubun, string frggubun);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="krx_0008">거래소_개인	Number	Y	12</param>
/// <param name="krx_0018">거래소_기관	Number	Y	12</param>
/// <param name="krx_0009">거래소_외국인	Number	Y	12</param>
/// <param name="pgmvol">프로그램	Number	Y	12</param>
/// <param name="fsc_listing">금감원_외인보유주식수	Number	Y	12</param>
/// <param name="fsc_sjrate">금감원_소진율	Number	Y	6.2</param>
/// <param name="fsc_0009">금감원_외국인	Number	Y	12</param>
/// <param name="gm_volume">공매도수량	Number	Y	12</param>
/// <param name="gm_value">공매도대금	Number	Y	12</param>
public record t1716OutBlock(string date, int close, string sign, int change, double diff, long volume, long krx_0008, long krx_0018, long krx_0009, long pgmvol, long fsc_listing, double fsc_sjrate, long fsc_0009, long gm_volume, long gm_value);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	String	Y	1</param>
/// <param name="fromdt">시작일자(일간조회일경우는space)	String	Y	8	OutBlock.date	>=	fromdt</param>
/// <param name="todt">종료일자	String	Y	8	OutBlock.date	<=	todt</param>
public record t1717InBlock(string shcode, string gubun, string fromdt, string todt);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="tjj0000_vol">사모펀드(순매수량)	Number	Y	12</param>
/// <param name="tjj0001_vol">증권(순매수량)	Number	Y	12</param>
/// <param name="tjj0002_vol">보험(순매수량)	Number	Y	12</param>
/// <param name="tjj0003_vol">투신(순매수량)	Number	Y	12</param>
/// <param name="tjj0004_vol">은행(순매수량)	Number	Y	12</param>
/// <param name="tjj0005_vol">종금(순매수량)	Number	Y	12</param>
/// <param name="tjj0006_vol">기금(순매수량)	Number	Y	12</param>
/// <param name="tjj0007_vol">기타법인(순매수량)	Number	Y	12</param>
/// <param name="tjj0008_vol">개인(순매수량)	Number	Y	12</param>
/// <param name="tjj0009_vol">등록외국인(순매수량)	Number	Y	12</param>
/// <param name="tjj0010_vol">미등록외국인(순매수량)	Number	Y	12</param>
/// <param name="tjj0011_vol">국가외(순매수량)	Number	Y	12</param>
/// <param name="tjj0018_vol">기관(순매수량)	Number	Y	12</param>
/// <param name="tjj0016_vol">외인계(순매수량)(등록+미등록)	Number	Y	12</param>
/// <param name="tjj0017_vol">기타계(순매수량)(기타+국가)	Number	Y	12</param>
/// <param name="tjj0000_dan">사모펀드(단가)	Number	Y	12</param>
/// <param name="tjj0001_dan">증권(단가)	Number	Y	12</param>
/// <param name="tjj0002_dan">보험(단가)	Number	Y	12</param>
/// <param name="tjj0003_dan">투신(단가)	Number	Y	12</param>
/// <param name="tjj0004_dan">은행(단가)	Number	Y	12</param>
/// <param name="tjj0005_dan">종금(단가)	Number	Y	12</param>
/// <param name="tjj0006_dan">기금(단가)	Number	Y	12</param>
/// <param name="tjj0007_dan">기타법인(단가)	Number	Y	12</param>
/// <param name="tjj0008_dan">개인(단가)	Number	Y	12</param>
/// <param name="tjj0009_dan">등록외국인(단가)	Number	Y	12</param>
/// <param name="tjj0010_dan">미등록외국인(단가)	Number	Y	12</param>
/// <param name="tjj0011_dan">국가외(단가)	Number	Y	12</param>
/// <param name="tjj0018_dan">기관(단가)	Number	Y	12</param>
/// <param name="tjj0016_dan">외인계(단가)(등록+미등록)	Number	Y	12</param>
/// <param name="tjj0017_dan">기타계(단가)(기타+국가)	Number	Y	12</param>
public record t1717OutBlock(string date, int close, string sign, int change, double diff, long volume, long tjj0000_vol, long tjj0001_vol, long tjj0002_vol, long tjj0003_vol, long tjj0004_vol, long tjj0005_vol, long tjj0006_vol, long tjj0007_vol, long tjj0008_vol, long tjj0009_vol, long tjj0010_vol, long tjj0011_vol, long tjj0018_vol, long tjj0016_vol, long tjj0017_vol, long tjj0000_dan, long tjj0001_dan, long tjj0002_dan, long tjj0003_dan, long tjj0004_dan, long tjj0005_dan, long tjj0006_dan, long tjj0007_dan, long tjj0008_dan, long tjj0009_dan, long tjj0010_dan, long tjj0011_dan, long tjj0018_dan, long tjj0016_dan, long tjj0017_dan);

#endregion

#region [주식] ELW

/// <summary>
/// 
/// </summary>
/// <param name="shcode">ELW단축코드	String	Y	6</param>
public record t1950InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="chetime">체결시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	10</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="avg">가중평균	Number	Y	8</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="jvolume">전일동시간거래량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="volumechg">거래량차	Number	Y	12</param>
/// <param name="volumediff">거래량차등락율	Number	Y	6.2</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="odiff">시가등락율	Number	Y	6.2</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="hdiff">고가등락율	Number	Y	6.2</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="ldiff">저가등락율	Number	Y	6.2</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="high52w">52최고가	Number	Y	8</param>
/// <param name="high52wdiff">52최고가등락율	Number	Y	6.2</param>
/// <param name="high52wdate">52최고가일	String	Y	8</param>
/// <param name="low52w">52최저가	Number	Y	8</param>
/// <param name="low52wdiff">52최저가등락율	Number	Y	6.2</param>
/// <param name="low52wdate">52최저가일	String	Y	8</param>
/// <param name="exhratio">소진율	Number	Y	6.2</param>
/// <param name="listing">상장주식수(천)	Number	Y	12</param>
/// <param name="memedan">수량단위	String	Y	5</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="parity">패리티	Number	Y	8.2</param>
/// <param name="berate">손익분기	Number	Y	8.2</param>
/// <param name="gearing">기어링	Number	Y	8.2</param>
/// <param name="elwexec">행사가	Number	Y	8.2</param>
/// <param name="issueprice">발행가	Number	Y	8</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="capt">자본지지	Number	Y	8.2</param>
/// <param name="egearing">e.기어링	Number	Y	8.2</param>
/// <param name="premium">프리미엄	Number	Y	8.2</param>
/// <param name="spread">스프레드	Number	Y	6.2</param>
/// <param name="espread">최대스프레드	Number	Y	6.2</param>
/// <param name="theoryprice">이론가	Number	Y	10.2</param>
/// <param name="impv">내재변동성	Number	Y	6.2</param>
/// <param name="moneyness">상태	String	Y	1</param>
/// <param name="delt">델타	Number	Y	8.6</param>
/// <param name="gama">감마	Number	Y	8.6</param>
/// <param name="vega">베가	Number	Y	13.6</param>
/// <param name="ceta">쎄타	Number	Y	13.6</param>
/// <param name="rhox">로	Number	Y	13.6</param>
/// <param name="bjandatecnt">잔존일수	Number	Y	4</param>
/// <param name="mmsdate">행사개시일	String	Y	8</param>
/// <param name="mmedate">행사종료일	String	Y	8</param>
/// <param name="payday">지급일	String	Y	8</param>
/// <param name="listdate">발행일	String	Y	8</param>
/// <param name="lpmem">LP회원사	String	Y	20</param>
/// <param name="lp_holdvol">LP보유수량	Number	Y	12</param>
/// <param name="bcode">기초자산코드	String	Y	6</param>
/// <param name="bgubun">기초자산구분	String	Y	1</param>
/// <param name="bprice">기초자산현재가	Number	Y	8</param>
/// <param name="bsign">기초자산전일비구분	String	Y	1</param>
/// <param name="bchange">기초자산전일비	Number	Y	8</param>
/// <param name="bdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="bvolume">기초자산거래량	Number	Y	12</param>
/// <param name="info1">락구분	String	Y	10</param>
/// <param name="info2">관리/급등구분	String	Y	10</param>
/// <param name="info3">정지/연장구분	String	Y	10</param>
/// <param name="info4">투자/불성실구분	String	Y	12</param>
/// <param name="janginfo">장구분	String	Y	10</param>
/// <param name="basketgb">바스켓구분	String	Y	1</param>
/// <param name="basketcnt">바스켓갯수	Number	Y	3</param>
/// <param name="elwtype">ELW권리행사방식	String	Y	2</param>
/// <param name="settletype">ELW결제방법	String	Y	2</param>
/// <param name="lpord">LP사주문가능여부	String	Y	2</param>
/// <param name="elwdetail">권리내용	String	Y	100</param>
/// <param name="valuation">만기평가가격방식	String	Y	100</param>
public record t1950OutBlock(string hname, string chetime, int price, string sign, int change, double diff, long cvolume, long volume, int recprice, int avg, long jnilvolume, long jvolume, int jnilclose, long volumechg, double volumediff, int open, double odiff, string opentime, int high, double hdiff, string hightime, int low, double ldiff, string lowtime, int high52w, double high52wdiff, string high52wdate, int low52w, double low52wdiff, string low52wdate, double exhratio, long listing, string memedan, double vol, double parity, double berate, double gearing, double elwexec, int issueprice, double convrate, string lastdate, double capt, double egearing, double premium, double spread, double espread, double theoryprice, double impv, string moneyness, double delt, double gama, double vega, double ceta, double rhox, int bjandatecnt, string mmsdate, string mmedate, string payday, string listdate, string lpmem, long lp_holdvol, string bcode, string bgubun, int bprice, string bsign, int bchange, double bdiff, long bvolume, string info1, string info2, string info3, string info4, string janginfo, string basketgb, int basketcnt, string elwtype, string settletype, string lpord, string elwdetail, string valuation);

/// <summary>
/// 
/// </summary>
/// <param name="bskcode">기초자산코드	String	Y	6</param>
/// <param name="bskbno">기초자산비율	Number	Y	3</param>
/// <param name="bskprice">기초자산현재가	Number	Y	8</param>
/// <param name="bsksign">기초자산전일비구분	String	Y	1</param>
/// <param name="bskchange">기초자산전일비	Number	Y	8</param>
/// <param name="bskdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="bskvolume">기초자산거래량	Number	Y	12</param>
/// <param name="bskjnilclose">기초자산전일종가	Number	Y	8</param>
public record t1950OutBlock1(string bskcode, int bskbno, int bskprice, string bsksign, int bskchange, double bskdiff, long bskvolume, int bskjnilclose);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="cvolume">특이거래량	Number	Y	12	체결량	>	특이체결량인	종목</param>
/// <param name="starttime">시작시간	String	Y	4</param>
/// <param name="endtime">종료시간	String	Y	4</param>
/// <param name="cts_time">시간CTS	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t1951InBlock(string shcode, long cvolume, string starttime, string endtime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	8</param>
public record t1951OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	12</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="revolume">순체결량	Number	Y	12</param>
/// <param name="rechecnt">순체결건수	Number	Y	8</param>
public record t1951OutBlock1(string chetime, int price, string sign, int change, double diff, long cvolume, double chdegree, long volume, long mdvolume, int mdchecnt, long msvolume, int mschecnt, long revolume, int rechecnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="date">날짜	String	Y	8	사용안함</param>
/// <param name="cnt">건수	Number	Y	3	조회개수</param>
public record t1954InBlock(string shcode, string date, int cnt);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="bsjgubun">기초자산구분	String	Y	1</param>
/// <param name="bscode">기초자산코드(현물)	String	Y	6</param>
/// <param name="bjcode">기초자산코드(지수)	String	Y	3</param>
public record t1954OutBlock(string date, string bsjgubun, string bscode, string bjcode);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="bsprice">기초자산(현물)	Number	Y	8</param>
/// <param name="bjprice">기초자산(지수)	Number	Y	8.2</param>
/// <param name="bsign">전일대비구분	String	Y	1</param>
/// <param name="bschange">전일대비(현물)	Number	Y	8</param>
/// <param name="bjchange">전일대비(지수)	Number	Y	8.2</param>
/// <param name="bdiff">등락율	Number	Y	6.2</param>
/// <param name="bvolume">기초자산거래량	Number	Y	12</param>
/// <param name="parity">패리티	Number	Y	6.2</param>
/// <param name="egearing">e.기어링	Number	Y	6.2</param>
/// <param name="premium">프리미엄	Number	Y	6.2</param>
/// <param name="berate">손익분기	Number	Y	6.2</param>
/// <param name="capt">자본지지	Number	Y	6.2</param>
/// <param name="gearing">기어링	Number	Y	6.2</param>
/// <param name="mness">Moneyness	String	Y	1</param>
public record t1954OutBlock1(string date, int open, int high, int low, int close, string sign, int change, double diff, long volume, int bsprice, double bjprice, string bsign, int bschange, double bjchange, double bdiff, long bvolume, double parity, double egearing, double premium, double berate, double capt, double gearing, string mness);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1956InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="chetime">체결시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	10</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="avg">가중평균	Number	Y	8</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="jvolume">전일동시간거래량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="volumechg">거래량차	Number	Y	12</param>
/// <param name="volumediff">거래량차등락율	Number	Y	6.2</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="odiff">시가등락율	Number	Y	6.2</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="hdiff">고가등락율	Number	Y	6.2</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="ldiff">저가등락율	Number	Y	6.2</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="high52w">52최고가	Number	Y	8</param>
/// <param name="high52wdiff">52최고가등락율	Number	Y	6.2</param>
/// <param name="high52wdate">52최고가일	String	Y	8</param>
/// <param name="low52w">52최저가	Number	Y	8</param>
/// <param name="low52wdiff">52최저가등락율	Number	Y	6.2</param>
/// <param name="low52wdate">52최저가일	String	Y	8</param>
/// <param name="exhratio">소진율	Number	Y	6.2</param>
/// <param name="listing">상장주식수(천)	Number	Y	12</param>
/// <param name="memedan">수량단위	String	Y	5</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="parity">패리티	Number	Y	8.2</param>
/// <param name="berate">손익분기	Number	Y	8.2</param>
/// <param name="gearing">기어링	Number	Y	8.2</param>
/// <param name="elwexec">행사가	Number	Y	8.2</param>
/// <param name="issueprice">발행가	Number	Y	8</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="capt">자본지지	Number	Y	8.2</param>
/// <param name="egearing">e.기어링	Number	Y	8.2</param>
/// <param name="premium">프리미엄	Number	Y	8.2</param>
/// <param name="spread">스프레드	Number	Y	6.2</param>
/// <param name="espread">최대스프레드	Number	Y	6.2</param>
/// <param name="theoryprice">이론가	Number	Y	10.2</param>
/// <param name="impv">내재변동성	Number	Y	6.2</param>
/// <param name="moneyness">상태	String	Y	1</param>
/// <param name="delt">델타	Number	Y	8.6</param>
/// <param name="gama">감마	Number	Y	8.6</param>
/// <param name="vega">베가	Number	Y	13.6</param>
/// <param name="ceta">쎄타	Number	Y	13.6</param>
/// <param name="rhox">로	Number	Y	13.6</param>
/// <param name="bjandatecnt">잔존일수	Number	Y	4</param>
/// <param name="mmsdate">행사개시일	String	Y	8</param>
/// <param name="mmedate">행사종료일	String	Y	8</param>
/// <param name="payday">지급일	String	Y	8</param>
/// <param name="listdate">발행일	String	Y	8</param>
/// <param name="lpmem">LP회원사	String	Y	20</param>
/// <param name="lp_holdvol">LP보유수량	Number	Y	12</param>
/// <param name="bcode">기초자산코드	String	Y	6</param>
/// <param name="bgubun">기초자산구분	String	Y	1</param>
/// <param name="bprice">기초자산현재가	Number	Y	8</param>
/// <param name="bsign">기초자산전일비구분	String	Y	1</param>
/// <param name="bchange">기초자산전일비	Number	Y	8</param>
/// <param name="bdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="bvolume">기초자산거래량	Number	Y	12</param>
/// <param name="info1">락구분	String	Y	10</param>
/// <param name="info2">관리/급등구분	String	Y	10</param>
/// <param name="info3">정지/연장구분	String	Y	10</param>
/// <param name="info4">투자/불성실구분	String	Y	12</param>
/// <param name="janginfo">장구분	String	Y	10</param>
/// <param name="basketgb">바스켓구분	String	Y	1</param>
/// <param name="basketcnt">바스켓갯수	Number	Y	3</param>
/// <param name="elwtype">ELW권리행사방식	String	Y	2</param>
/// <param name="settletype">ELW결제방법	String	Y	2</param>
/// <param name="lpord">LP사주문가능여부	String	Y	2</param>
/// <param name="elwdetail">권리내용	String	Y	100</param>
/// <param name="valuation">만기평가가격방식	String	Y	100</param>
/// <param name="givemoney">확정지급액	Number	Y	8.3</param>
public record t1956OutBlock(string hname, string chetime, int price, string sign, int change, double diff, long cvolume, long volume, int recprice, int avg, long jnilvolume, long jvolume, int jnilclose, long volumechg, double volumediff, int open, double odiff, string opentime, int high, double hdiff, string hightime, int low, double ldiff, string lowtime, int high52w, double high52wdiff, string high52wdate, int low52w, double low52wdiff, string low52wdate, double exhratio, long listing, string memedan, double vol, double parity, double berate, double gearing, double elwexec, int issueprice, double convrate, string lastdate, double capt, double egearing, double premium, double spread, double espread, double theoryprice, double impv, string moneyness, double delt, double gama, double vega, double ceta, double rhox, int bjandatecnt, string mmsdate, string mmedate, string payday, string listdate, string lpmem, long lp_holdvol, string bcode, string bgubun, int bprice, string bsign, int bchange, double bdiff, long bvolume, string info1, string info2, string info3, string info4, string janginfo, string basketgb, int basketcnt, string elwtype, string settletype, string lpord, string elwdetail, string valuation, double givemoney);

/// <summary>
/// 
/// </summary>
/// <param name="bskcode">기초자산코드	String	Y	6</param>
/// <param name="bskbno">기초자산비율	Number	Y	3</param>
/// <param name="bskprice">기초자산현재가	Number	Y	8</param>
/// <param name="bsksign">기초자산전일비구분	String	Y	1</param>
/// <param name="bskchange">기초자산전일비	Number	Y	8</param>
/// <param name="bskdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="bskvolume">기초자산거래량	Number	Y	12</param>
/// <param name="bskjnilclose">기초자산전일종가	Number	Y	8</param>
public record t1956OutBlock1(string bskcode, int bskbno, int bskprice, string bsksign, int bskchange, double bskdiff, long bskvolume, int bskjnilclose);

/// <summary>
/// 
/// </summary>
/// <param name="shcode1">종목코드1	String	Y	6</param>
/// <param name="shcode2">종목코드2	String	Y	6</param>
public record t1958InBlock(string shcode1, string shcode2);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="item1">기초자산	String	Y	12</param>
/// <param name="issuernmk">발행사	String	Y	40</param>
/// <param name="elwopt">콜풋구분	String	Y	2</param>
/// <param name="elwtype">행사방식	String	Y	2</param>
/// <param name="settletype">결제방법	String	Y	2</param>
/// <param name="elwexec">행사가	Number	Y	8.2</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="listing">발행수량	Number	Y	12</param>
/// <param name="mmsdate">행사개시일	String	Y	8</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="nofdays">거래잔존일수	Number	Y	4</param>
/// <param name="payday">지급일	String	Y	8</param>
/// <param name="parity">패리티	Number	Y	6.2</param>
/// <param name="premium">프리미엄	Number	Y	6.2</param>
/// <param name="berate">손익분기	Number	Y	6.2</param>
/// <param name="capt">자본지지	Number	Y	6.2</param>
/// <param name="gearing">기어링	Number	Y	6.2</param>
/// <param name="egearing">e.기어링	Number	Y	6.2</param>
/// <param name="price">가격	Number	Y	8</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
public record t1958OutBlock(string hname, string item1, string issuernmk, string elwopt, string elwtype, string settletype, double elwexec, double convrate, long listing, string mmsdate, string lastdate, int nofdays, string payday, double parity, double premium, double berate, double capt, double gearing, double egearing, int price, long volume, double diff);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="item1">기초자산	String	Y	12</param>
/// <param name="issuernmk">발행사	String	Y	40</param>
/// <param name="elwopt">콜풋구분	String	Y	2</param>
/// <param name="elwtype">행사방식	String	Y	2</param>
/// <param name="settletype">결제방법	String	Y	2</param>
/// <param name="elwexec">행사가	Number	Y	8.2</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="listing">발행수량	Number	Y	12</param>
/// <param name="mmsdate">행사개시일	String	Y	8</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="nofdays">거래잔존일수	Number	Y	4</param>
/// <param name="payday">지급일	String	Y	8</param>
/// <param name="parity">패리티	Number	Y	6.2</param>
/// <param name="premium">프리미엄	Number	Y	6.2</param>
/// <param name="berate">손익분기	Number	Y	6.2</param>
/// <param name="capt">자본지지	Number	Y	6.2</param>
/// <param name="gearing">기어링	Number	Y	6.2</param>
/// <param name="egearing">e.기어링	Number	Y	6.2</param>
/// <param name="price">가격	Number	Y	8</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
public record t1958OutBlock1(string hname, string item1, string issuernmk, string elwopt, string elwtype, string settletype, double elwexec, double convrate, long listing, string mmsdate, string lastdate, int nofdays, string payday, double parity, double premium, double berate, double capt, double gearing, double egearing, int price, long volume, double diff);

/// <summary>
/// 
/// </summary>
/// <param name="hnamecmp">종목명비교	String	Y	6</param>
/// <param name="item1cmp">기초자산비교	String	Y	6</param>
/// <param name="issuernmkcmp">발행사비교	String	Y	6</param>
/// <param name="elwoptcmp">콜풋구분비교	String	Y	6</param>
/// <param name="elwtypecmp">행사방식비교	String	Y	6</param>
/// <param name="settlecmp">결제방법비교	String	Y	6</param>
/// <param name="elwexeccmp">행사가비교	Number	Y	8.2</param>
/// <param name="convcmp">전환비율비교	Number	Y	12.4</param>
/// <param name="listingcmp">발행수량비교	Number	Y	12</param>
/// <param name="mmsdatecmp">행사개시일비교	String	Y	6</param>
/// <param name="lastdatecmp">최종거래일비교	String	Y	6</param>
/// <param name="nofdayscmp">거래잔존일수비교	String	Y	6</param>
/// <param name="paydaycmp">지급일비교	String	Y	6</param>
/// <param name="paritycmp">패리티비교	Number	Y	6.2</param>
/// <param name="premiumcmp">프리미엄비교	Number	Y	6.2</param>
/// <param name="beratecmp">손익분기비교	Number	Y	6.2</param>
/// <param name="captcmp">자본지지비교	Number	Y	6.2</param>
/// <param name="gearingcmp">기어링비교	Number	Y	6.2</param>
/// <param name="egearingcmp">e.기어링비교	Number	Y	6.2</param>
/// <param name="pricecmp">가격비교	Number	Y	8</param>
/// <param name="volumecmp">거래량비교	Number	Y	12</param>
/// <param name="diffcmp">등락율비교	Number	Y	6.2</param>
public record t1958OutBlock2(string hnamecmp, string item1cmp, string issuernmkcmp, string elwoptcmp, string elwtypecmp, string settlecmp, double elwexeccmp, double convcmp, long listingcmp, string mmsdatecmp, string lastdatecmp, string nofdayscmp, string paydaycmp, double paritycmp, double premiumcmp, double beratecmp, double captcmp, double gearingcmp, double egearingcmp, int pricecmp, long volumecmp, double diffcmp);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1959InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="price">현재가	String	Y	12</param>
/// <param name="sign">부호	String	Y	1</param>
/// <param name="change">대비	String	Y	12</param>
/// <param name="rate">등락율	Number	Y	5.2</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="lp_gb">LP주문가능여부	String	Y	4</param>
/// <param name="lp_mem_nm1">LP회원사명1	String	Y	20</param>
/// <param name="lp_mem_nm2">LP회원사명2	String	Y	20</param>
/// <param name="lp_mem_nm3">LP회원사명3	String	Y	20</param>
/// <param name="lp_mem_nm4">LP회원사명4	String	Y	20</param>
/// <param name="lp_mem_nm5">LP회원사명5	String	Y	20</param>
/// <param name="lp_min_qty">LP최소호가수량	String	Y	10</param>
/// <param name="lp_st_date">LP시작일	String	Y	8</param>
/// <param name="lp_end_date">LP종료일	String	Y	8</param>
/// <param name="lp_spread">LP스프레드	Number	Y	5.2</param>
public record t1959OutBlock1(string shcode, string hname, string price, string sign, string change, double rate, string volume, string value, string lp_gb, string lp_mem_nm1, string lp_mem_nm2, string lp_mem_nm3, string lp_mem_nm4, string lp_mem_nm5, string lp_min_qty, string lp_st_date, string lp_end_date, double lp_spread);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">상승하락(0:상승1:하락)	String	Y	1	0:상승율	1:하락율</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	String	Y	2	@콜/풋/EX	01@콜	02@풋	00@EX</param>
/// <param name="itemcode">기초자산종목	String	Y	12	기초자산	종목코드	-	스페이스:전체	-	basket:BASKET	기초자산	종목	-	종목코드(12자리	표준코드)</param>
/// <param name="lastdate">조회만기일	String	Y	8	YYYYMM	스페이스:전체</param>
/// <param name="exgubun">대상제외	String	Y	6	1번째Byte	>	'0'	:	결제제외	-	현금결제	2번째Byte	>	'0'	:	결제제외	-	실물결제	3번재Byte	>	'0'	:	권리행사방식-	유럽형	제외	4번째Byte	>	'0'	:	권리행사방식-	미국형	제외	5번째Byte	1	:	비표준형	제외	2	:	표준형	제외	3	:	비표준형,	표준형	제외	4	:	디지털형	제외	5	:	비표준형,	디지털형	제외	6	:	표준형,	디지털형	제외	7	:	비표준형,	표준형	디지털형	제외	6번째Byte	>	'0'	:	Basket종목	제외</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="sjanday">잔존시작일수	Number	Y	8	잔존일수	>=	sjanday</param>
/// <param name="ejanday">잔존종료일수	Number	Y	8	잔존일수	<=	ejanday</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1960InBlock(string gubun, string ggubun, string itemcode, string lastdate, string exgubun, int sprice, int eprice, long volume, int sjanday, int ejanday, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1960OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="elwexec">행사가	Number	Y	10.2</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="lastdate">만기일	String	Y	8</param>
/// <param name="itemcode">기초자산종목코드	String	Y	12</param>
/// <param name="itemshcode">기초자산단축코드	String	Y	9</param>
/// <param name="itemname">기초자산종목명	String	Y	20</param>
/// <param name="itemprice">기초자산현재가	String	Y	10</param>
/// <param name="itemsign">기초자산대비구분	String	Y	1</param>
/// <param name="itemchange">기초자산전일대비	String	Y	10</param>
/// <param name="itemdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="elwshcode">ELW종목코드	String	Y	6</param>
/// <param name="bepoint">손익분기점	Number	Y	12.2</param>
public record t1960OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double elwexec, double convrate, string lastdate, string itemcode, string itemshcode, string itemname, string itemprice, string itemsign, string itemchange, double itemdiff, string elwshcode, double bepoint);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">당일전일(0:당일1:전일)	String	Y	1	0:당일	1:전일</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	String	Y	2	@콜/풋/EX	01@콜	02@풋	00@EX</param>
/// <param name="itemcode">기초자산종목	String	Y	12	기초자산	표준코드(12자리)</param>
/// <param name="lastdate">조회만기일	String	Y	8	YYYYMMDD</param>
/// <param name="exgubun">대상제외	String	Y	6	1번째Byte	>	'0'	:	결제제외	-	현금결제	2번째Byte	>	'0'	:	결제제외	-	실물결제	3번재Byte	>	'0'	:	권리행사방식-	유럽형	제외	4번째Byte	>	'0'	:	권리행사방식-	미국형	제외	5번째Byte	1	:	비표준형	제외	2	:	표준형	제외	3	:	비표준형,	표준형	제외	4	:	디지털형	제외	5	:	비표준형,	디지털형	제외	6	:	표준형,	디지털형	제외	7	:	비표준형,	표준형	디지털형	제외	6번째Byte	>	'0'	:	Basket종목	제외</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="sjanday">잔존시작일수	Number	Y	8	잔존일수	>=	sjanday</param>
/// <param name="ejanday">잔존종료일수	Number	Y	8	잔존일수	<=	ejanday</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1961InBlock(string gubun, string ggubun, string itemcode, string lastdate, string exgubun, int sprice, int eprice, long volume, int sjanday, int ejanday, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4	연속조회키	연속	조회시	이	값을	InBlock의	idx	필드에	넣어준다.</param>
public record t1961OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="elwexec">행사가	Number	Y	10.2</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="lastdate">만기일	String	Y	8</param>
/// <param name="itemcode">기초자산종목코드	String	Y	12</param>
/// <param name="itemshcode">기초자산단축코드	String	Y	9</param>
/// <param name="itemname">기초자산종목명	String	Y	20</param>
/// <param name="itemprice">기초자산현재가	String	Y	10</param>
/// <param name="itemsign">기초자산대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="itemchange">기초자산전일대비	String	Y	10</param>
/// <param name="itemdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="elwshcode">ELW종목코드	String	Y	6</param>
public record t1961OutBlock1(string hname, int price, string sign, int change, double diff, long volume, long jnilvolume, double elwexec, double convrate, string lastdate, string itemcode, string itemshcode, string itemname, string itemprice, string itemsign, string itemchange, double itemdiff, string elwshcode);

/// <summary>
/// 
/// </summary>
/// <param name="item">기초자산코드	String	Y	12	0:전체	basket:기초자산이	BASKET	종목	종목코드(12자리	표준코드)</param>
/// <param name="issuercd">발행사	String	Y	12	000000000000:전체	발행사코드(3자리)	002	신한금융투자	033	JP모간	004	대신	005	대우	048	SG	030	삼성	006	신영	012	우리투자증권	003	한국	017	현대	049	미래에셋	035	맥쿼리	024	동양	031	동부	056	하나대투	054	노무라	034	KB	투자	067	BNP	파리바</param>
/// <param name="lastmonth">만기월물	String	Y	6	전체@000000</param>
/// <param name="elwopt">콜풋구분	String	Y	1	전체@0	콜@1	풋@2</param>
/// <param name="atmgubun">머니구분	String	Y	1	전체@0	ATM@1	ITM@2	OTM@3</param>
/// <param name="elwtype">권리행사방식	String	Y	2	권리전체@00	유럽형@01	미국형@02</param>
/// <param name="settletype">결제방법	String	Y	2	결제방법전체@00	현금결제@01	실물결제@02</param>
/// <param name="elwexecgubun">행사기초자산구분	String	Y	1	행사가/기초자산가격	검색	적용	여부(1이면	적용)</param>
/// <param name="fromrat">시작비율	String	Y	5	행사가/기초자산가격	*	100	>=	fromrat</param>
/// <param name="torat">종료비율	String	Y	5	행사가/기초자산가격	*	100	<=	torat</param>
/// <param name="volume">거래량	String	Y	12	거래량	>=	volume</param>
public record t1964InBlock(string item, string issuercd, string lastmonth, string elwopt, string atmgubun, string elwtype, string settletype, string elwexecgubun, string fromrat, string torat, string volume);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">ELW코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="item1">기초자산코드	String	Y	6</param>
/// <param name="itemnm">기초자산명	String	Y	20</param>
/// <param name="issuernmk">발행사	String	Y	40</param>
/// <param name="elwopt">콜풋구분	String	Y	4</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="elwexec">행사가	Number	Y	10.2</param>
/// <param name="jandatecnt">잔존일수	Number	Y	8</param>
/// <param name="convrate">전환비율	Number	Y	8.4</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="mmsdate">행사개시일	String	Y	8</param>
/// <param name="payday">지급일	String	Y	8</param>
/// <param name="listing">발행수량	Number	Y	8</param>
/// <param name="atmgbnm">머니구분	String	Y	10</param>
/// <param name="parity">패리티	Number	Y	6.2</param>
/// <param name="preminum">프리미엄	Number	Y	10.2</param>
/// <param name="spread">스프래드	Number	Y	3.2</param>
/// <param name="berate">손익분기율	Number	Y	6.2</param>
/// <param name="capt">자본지지율	Number	Y	6.2</param>
/// <param name="gearing">기어링	Number	Y	6.2</param>
/// <param name="egearing">e기어링	Number	Y	6.2</param>
/// <param name="itemprice">기초자산현재가	Number	Y	8</param>
/// <param name="itemsign">기초자산전일대비구분	String	Y	1</param>
/// <param name="itemchange">기초자산전일대비	Number	Y	8</param>
/// <param name="itemdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="itemvolume">기초자산거래량	Number	Y	12</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="theoryprice">이론가	Number	Y	10.2</param>
/// <param name="lp_rate">LP보유비율	Number	Y	5.2</param>
/// <param name="impv">내재변동성	Number	Y	6.2</param>
/// <param name="delta">델타	Number	Y	10.6</param>
/// <param name="theta">쎄타	Number	Y	10.6</param>
public record t1964OutBlock1(string shcode, string hname, string item1, string itemnm, string issuernmk, string elwopt, int price, string sign, int change, double diff, long volume, double elwexec, int jandatecnt, double convrate, string lastdate, string mmsdate, string payday, int listing, string atmgbnm, double parity, double preminum, double spread, double berate, double capt, double gearing, double egearing, int itemprice, string itemsign, int itemchange, double itemdiff, long itemvolume, long jnilvolume, double theoryprice, double lp_rate, double impv, double delta, double theta);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">당일전일(0:당일1:전일)	String	Y	1	0:당일	1:전일</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	String	Y	2	@콜/풋/EX	01@콜	02@풋	00@EX</param>
/// <param name="itemcode">기초자산종목	String	Y	12	기초자산	표준코드(12자리)</param>
/// <param name="lastdate">조회만기일	String	Y	8	YYYYMMDD</param>
/// <param name="exgubun">대상제외	String	Y	6	1번째Byte	>	'0'	:	결제제외	-	현금결제	2번째Byte	>	'0'	:	결제제외	-	실물결제	3번재Byte	>	'0'	:	권리행사방식-	유럽형	제외	4번째Byte	>	'0'	:	권리행사방식-	미국형	제외	5번째Byte	1	:	비표준형	제외	2	:	표준형	제외	3	:	비표준형,	표준형	제외	4	:	디지털형	제외	5	:	비표준형,	디지털형	제외	6	:	표준형,	디지털형	제외	7	:	비표준형,	표준형	디지털형	제외	6번째Byte	>	'0'	:	Basket종목	제외</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="sjanday">잔존시작일수	Number	Y	8	잔존일수	>=	sjanday</param>
/// <param name="ejanday">잔존종료일수	Number	Y	8	잔존일수	<=	ejanday</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1966InBlock(string gubun, string ggubun, string itemcode, string lastdate, string exgubun, int sprice, int eprice, long volume, int sjanday, int ejanday, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4	연속조회키	연속	조회시	이	값을	InBlock의	idx	필드에	넣어준다.</param>
public record t1966OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
/// <param name="jnilvalue">전일거래대금	Number	Y	12</param>
/// <param name="elwexec">행사가	Number	Y	10.2</param>
/// <param name="convrate">전환비율	Number	Y	12.4</param>
/// <param name="lastdate">만기일	String	Y	8</param>
/// <param name="itemcode">기초자산종목코드	String	Y	12</param>
/// <param name="itemshcode">기초자산단축코드	String	Y	9</param>
/// <param name="itemname">기초자산종목명	String	Y	20</param>
/// <param name="itemprice">기초자산현재가	String	Y	10</param>
/// <param name="itemsign">기초자산대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="itemchange">기초자산전일대비	String	Y	10</param>
/// <param name="itemdiff">기초자산등락율	Number	Y	6.2</param>
/// <param name="elwshcode">ELW종목코드	String	Y	6</param>
public record t1966OutBlock1(string hname, int price, string sign, int change, double diff, long value, long jnilvalue, double elwexec, double convrate, string lastdate, string itemcode, string itemshcode, string itemname, string itemprice, string itemsign, string itemchange, double itemdiff, string elwshcode);

/// <summary>
/// 
/// </summary>
/// <param name="chkitem">기초자산chk구분	String	Y	1	0:기초자산	검색	안함	1:기초자산	검색</param>
/// <param name="cbitem">기초자산코드	String	Y	12	전체''@000000000000	basket:기초자산이	BASKET	종목	종목코드(12자리	표준코드)</param>
/// <param name="chkissuer">발행사chk구분	String	Y	1	0:발행사	검색	안함	1:발행사	검색</param>
/// <param name="cbissuer">발행사	String	Y	12	전체''@000000000000</param>
/// <param name="chkcallput">권리chk구분	String	Y	1	0:권리구분	검색	안함	1:권리구분	검색</param>
/// <param name="cbcallput">권리(call:01.put:02)	String	Y	2	전체@00	콜@01	풋@02	EX@03</param>
/// <param name="chkexec">행사가chk구분	String	Y	1	0:행사가/기초자산	비교	검색	안함	1:행사가/기초자산	비교	검색</param>
/// <param name="cbexec">행사가(>=:1.<=:2)	String	Y	1	>=@1	<=@2</param>
/// <param name="chktype">행사방식chk구분	String	Y	1	0:행사방식	검색	안함	1:행사방식	검색</param>
/// <param name="cbtype">행사방식	String	Y	2	전체@00	유럽형@01	미국형@02	기타@03</param>
/// <param name="chksettle">결제방법chk구분	String	Y	1	0:결제방법	검색	안함	1:결제방법	검색</param>
/// <param name="cbsettle">결제방법	String	Y	2	전체@00	현금결제@01	실물결제@02	현금+실물@03</param>
/// <param name="chklast">만기chk구분	String	Y	1	0:만기월	검색	안함	1:만기월	검색</param>
/// <param name="cblast">만기월별	String	Y	6	전체@000000</param>
/// <param name="chkelwexec">행사가격chk구분	String	Y	1	0:행사가	검색	안함	1:행사가	검색</param>
/// <param name="elwexecs">행사가이상	Number	Y	10.2	행사가	>=	elwexecs</param>
/// <param name="elwexece">행사가이하	Number	Y	10.2	행사가	<=	elwexece</param>
/// <param name="chkvolume">거래량chk구분	String	Y	1	0:거래량	검색	안함	1:거래량	검색</param>
/// <param name="volumes">거래량이상	Number	Y	12	거래량	>=	volumes</param>
/// <param name="volumee">거래량이하	Number	Y	12	거래량	<=	volumee</param>
/// <param name="chkrate">등락율chk구분	String	Y	1	0:등락율	검색	안함	1:등락율	검색</param>
/// <param name="rates">등락율이상	Number	Y	6.2	등락율	>=	rates</param>
/// <param name="ratee">등락율이하	Number	Y	6.2	등락율	<=	ratee</param>
/// <param name="chkpremium">프리미엄chk구분	String	Y	1	0:프리미엄	검색	안함	1:프리미엄	검색</param>
/// <param name="premiums">프리미엄이상	Number	Y	6.2	프리미엄	>=	premiums</param>
/// <param name="premiume">프리미엄이하	Number	Y	6.2	프리미엄	<=	premiume</param>
/// <param name="chkparity">패리티chk구분	String	Y	1	0:패리티	검색	안함	1:패리티	검색</param>
/// <param name="paritys">패리티이상	Number	Y	6.2	패리티	>=	paritys</param>
/// <param name="paritye">패리티이하	Number	Y	6.2	패리티	<=	paritye</param>
/// <param name="chkberate">손익분기chk구분	String	Y	1	0:손익분기	검색	안함	1:손익분기	검색</param>
/// <param name="berates">손익분기이상	Number	Y	6.2	손익분기	>=	berates</param>
/// <param name="beratee">손익분기이하	Number	Y	6.2	손익분기	<=	beratee</param>
/// <param name="chkcapt">자본지지chk구분	String	Y	1	0:자본지지	검색	안함	1:자본지지	검색</param>
/// <param name="capts">자본지지이상	Number	Y	6.2	자본지지	>=	capts</param>
/// <param name="capte">자본지지이하	Number	Y	6.2	자본지지	<=	capts</param>
/// <param name="chkegearing">e.기어링chk구분	String	Y	1	0:e.기어링	검색	안함	1:e.기어링	검색</param>
/// <param name="egearings">e.기어링이상	Number	Y	6.2	e.기어링	>=	egearings</param>
/// <param name="egearinge">e.기어링이하	Number	Y	6.2	e.기어링	<=	egearinge</param>
/// <param name="chkgearing">기어링chk구분	String	Y	1	0:기어링	검색	안함	1:기어링	검색</param>
/// <param name="gearings">기어링이상	Number	Y	6.2	기어링	>=	gearings</param>
/// <param name="gearinge">기어링이하	Number	Y	6.2	기어링	<=	gearinge</param>
/// <param name="chkdelta">델타chk구분	String	Y	1	0:델타	검색	안함	1:델타	검색</param>
/// <param name="deltas">델타이상	Number	Y	10.6	델타	>=	deltas</param>
/// <param name="deltae">델타이하	Number	Y	10.6	델타	<=	deltae</param>
/// <param name="chktheta">쎄타chk구분	String	Y	1	0:쎄타	검색	안함	1:쎄타	검색</param>
/// <param name="thetas">쎄타이상	Number	Y	10.6	쎄타	>=	thetas</param>
/// <param name="thetae">쎄타이하	Number	Y	10.6	쎄타	<=	thetas</param>
/// <param name="chkduedate">최종거래일chk구분	String	Y	1	0:최종거래일	검색	안함	1:최종거래일	검색</param>
/// <param name="duedates">최종거래일이상	String	Y	8	YYYYMMDD	형식	최종거래일	>=	duedates</param>
/// <param name="duedatee">최종거래일이하	String	Y	8	YYYYMMDD	형식	최종거래일	<=	duedatee</param>
/// <param name="onetickgubun">LP갭1틱	String	Y	1</param>
/// <param name="lp_liquidity">LP유동성공급	String	Y	1</param>
/// <param name="chklp_code">LPchk구분	String	Y	1</param>
/// <param name="lp_code">LP회원사코드	String	Y	3</param>
/// <param name="chkkoba">조기종료chk구분	String	Y	1</param>
/// <param name="cbkoba">조기종료(0:전체1:KOBA2:KOBA제외)	String	Y	1	전체@0	조기종료만@1	조기종료제외@2</param>
public record t1969InBlock(string chkitem, string cbitem, string chkissuer, string cbissuer, string chkcallput, string cbcallput, string chkexec, string cbexec, string chktype, string cbtype, string chksettle, string cbsettle, string chklast, string cblast, string chkelwexec, double elwexecs, double elwexece, string chkvolume, long volumes, long volumee, string chkrate, double rates, double ratee, string chkpremium, double premiums, double premiume, string chkparity, double paritys, double paritye, string chkberate, double berates, double beratee, string chkcapt, double capts, double capte, string chkegearing, double egearings, double egearinge, string chkgearing, double gearings, double gearinge, string chkdelta, double deltas, double deltae, string chktheta, double thetas, double thetae, string chkduedate, string duedates, string duedatee, string onetickgubun, string lp_liquidity, string chklp_code, string lp_code, string chkkoba, string cbkoba);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">종목갯수	Number	Y	4</param>
public record t1969OutBlock(int cnt);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="issuernmk">발행사	String	Y	40</param>
/// <param name="itemcode">기초자산코드	String	Y	12</param>
/// <param name="cpgubun">콜/풋구분	String	Y	2</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="elwexec">행사가	Number	Y	10.2</param>
/// <param name="item">기초자산명	String	Y	20</param>
/// <param name="bprice">기초자산가	Number	Y	10.2</param>
/// <param name="bsign">기초전일대비구분	String	Y	1</param>
/// <param name="bchange">기초전일대비	Number	Y	10.2</param>
/// <param name="bdiff">기초등락율	Number	Y	6.2</param>
/// <param name="premium">프리미엄	Number	Y	6.2</param>
/// <param name="parity">패리티	Number	Y	6.2</param>
/// <param name="berate">손익분기	Number	Y	6.2</param>
/// <param name="capt">자본지지	Number	Y	6.2</param>
/// <param name="egearing">e.기어링	Number	Y	6.2</param>
/// <param name="gearing">기어링	Number	Y	6.2</param>
/// <param name="lastdate">최종거래일	String	Y	8</param>
/// <param name="delta">델타	Number	Y	10.6</param>
/// <param name="theta">쎄타	Number	Y	10.6</param>
/// <param name="lpname">LP회원사	String	Y	40</param>
/// <param name="lphold">LP보유율	Number	Y	6.2</param>
/// <param name="bjandatecnt">잔존일수	Number	Y	4</param>
/// <param name="convrate">전환비율	Number	Y	8.4</param>
/// <param name="tickvalue">1틱환산	Number	Y	10.2</param>
/// <param name="kasis">괴리율	Number	Y	6.2</param>
public record t1969OutBlock1(string hname, string shcode, string issuernmk, string itemcode, string cpgubun, int price, string sign, int change, double diff, long volume, long jnilvolume, double elwexec, string item, double bprice, string bsign, double bchange, double bdiff, double premium, double parity, double berate, double capt, double egearing, double gearing, string lastdate, double delta, double theta, string lpname, double lphold, int bjandatecnt, double convrate, double tickvalue, double kasis);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1971InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="offerho1">매도호가1	Number	Y	8</param>
/// <param name="bidho1">매수호가1	Number	Y	8</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	12</param>
/// <param name="lp_offerrem1">LP매도호가수량1	Number	Y	12</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	12</param>
/// <param name="lp_bidrem1">LP매수호가수량1	Number	Y	12</param>
/// <param name="preoffercha1">직전매도대비수량1	Number	Y	12</param>
/// <param name="prebidcha1">직전매수대비수량1	Number	Y	12</param>
/// <param name="offerho2">매도호가2	Number	Y	8</param>
/// <param name="bidho2">매수호가2	Number	Y	8</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	12</param>
/// <param name="lp_offerrem2">LP매도호가수량2	Number	Y	12</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	12</param>
/// <param name="lp_bidrem2">LP매수호가수량2	Number	Y	12</param>
/// <param name="preoffercha2">직전매도대비수량2	Number	Y	12</param>
/// <param name="prebidcha2">직전매수대비수량2	Number	Y	12</param>
/// <param name="offerho3">매도호가3	Number	Y	8</param>
/// <param name="bidho3">매수호가3	Number	Y	8</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	12</param>
/// <param name="lp_offerrem3">LP매도호가수량3	Number	Y	12</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	12</param>
/// <param name="lp_bidrem3">LP매수호가수량3	Number	Y	12</param>
/// <param name="preoffercha3">직전매도대비수량3	Number	Y	12</param>
/// <param name="prebidcha3">직전매수대비수량3	Number	Y	12</param>
/// <param name="offerho4">매도호가4	Number	Y	8</param>
/// <param name="bidho4">매수호가4	Number	Y	8</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	12</param>
/// <param name="lp_offerrem4">LP매도호가수량4	Number	Y	12</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	12</param>
/// <param name="lp_bidrem4">LP매수호가수량4	Number	Y	12</param>
/// <param name="preoffercha4">직전매도대비수량4	Number	Y	12</param>
/// <param name="prebidcha4">직전매수대비수량4	Number	Y	12</param>
/// <param name="offerho5">매도호가5	Number	Y	8</param>
/// <param name="bidho5">매수호가5	Number	Y	8</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	12</param>
/// <param name="lp_offerrem5">LP매도호가수량5	Number	Y	12</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	12</param>
/// <param name="lp_bidrem5">LP매수호가수량5	Number	Y	12</param>
/// <param name="preoffercha5">직전매도대비수량5	Number	Y	12</param>
/// <param name="prebidcha5">직전매수대비수량5	Number	Y	12</param>
/// <param name="offerho6">매도호가6	Number	Y	8</param>
/// <param name="bidho6">매수호가6	Number	Y	8</param>
/// <param name="offerrem6">매도호가수량6	Number	Y	12</param>
/// <param name="lp_offerrem6">LP매도호가수량6	Number	Y	12</param>
/// <param name="bidrem6">매수호가수량6	Number	Y	12</param>
/// <param name="lp_bidrem6">LP매수호가수량6	Number	Y	12</param>
/// <param name="preoffercha6">직전매도대비수량6	Number	Y	12</param>
/// <param name="prebidcha6">직전매수대비수량6	Number	Y	12</param>
/// <param name="offerho7">매도호가7	Number	Y	8</param>
/// <param name="bidho7">매수호가7	Number	Y	8</param>
/// <param name="offerrem7">매도호가수량7	Number	Y	12</param>
/// <param name="lp_offerrem7">LP매도호가수량7	Number	Y	12</param>
/// <param name="bidrem7">매수호가수량7	Number	Y	12</param>
/// <param name="lp_bidrem7">LP매수호가수량7	Number	Y	12</param>
/// <param name="preoffercha7">직전매도대비수량7	Number	Y	12</param>
/// <param name="prebidcha7">직전매수대비수량7	Number	Y	12</param>
/// <param name="offerho8">매도호가8	Number	Y	8</param>
/// <param name="bidho8">매수호가8	Number	Y	8</param>
/// <param name="offerrem8">매도호가수량8	Number	Y	12</param>
/// <param name="lp_offerrem8">LP매도호가수량8	Number	Y	12</param>
/// <param name="bidrem8">매수호가수량8	Number	Y	12</param>
/// <param name="lp_bidrem8">LP매수호가수량8	Number	Y	12</param>
/// <param name="preoffercha8">직전매도대비수량8	Number	Y	12</param>
/// <param name="prebidcha8">직전매수대비수량8	Number	Y	12</param>
/// <param name="offerho9">매도호가9	Number	Y	8</param>
/// <param name="bidho9">매수호가9	Number	Y	8</param>
/// <param name="offerrem9">매도호가수량9	Number	Y	12</param>
/// <param name="lp_offerrem9">LP매도호가수량9	Number	Y	12</param>
/// <param name="bidrem9">매수호가수량9	Number	Y	12</param>
/// <param name="lp_bidrem9">LP매수호가수량9	Number	Y	12</param>
/// <param name="preoffercha9">직전매도대비수량9	Number	Y	12</param>
/// <param name="prebidcha9">직전매수대비수량9	Number	Y	12</param>
/// <param name="offerho10">매도호가10	Number	Y	8</param>
/// <param name="bidho10">매수호가10	Number	Y	8</param>
/// <param name="offerrem10">매도호가수량10	Number	Y	12</param>
/// <param name="lp_offerrem10">LP매도호가수량10	Number	Y	12</param>
/// <param name="bidrem10">매수호가수량10	Number	Y	12</param>
/// <param name="lp_bidrem10">LP매수호가수량10	Number	Y	12</param>
/// <param name="preoffercha10">직전매도대비수량10	Number	Y	12</param>
/// <param name="prebidcha10">직전매수대비수량10	Number	Y	12</param>
/// <param name="offer">매도호가수량합	Number	Y	12</param>
/// <param name="bid">매수호가수량합	Number	Y	12</param>
/// <param name="preoffercha">직전매도대비수량합	Number	Y	12</param>
/// <param name="prebidcha">직전매수대비수량합	Number	Y	12</param>
/// <param name="hotime">수신시간	String	Y	8</param>
/// <param name="yeprice">예상체결가격	Number	Y	8</param>
/// <param name="yevolume">예상체결수량	Number	Y	12</param>
/// <param name="yesign">예상체결전일구분	String	Y	1</param>
/// <param name="yechange">예상체결전일대비	Number	Y	8</param>
/// <param name="yediff">예상체결등락율	Number	Y	6.2</param>
/// <param name="tmoffer">시간외매도잔량	Number	Y	12</param>
/// <param name="tmbid">시간외매수잔량	Number	Y	12</param>
/// <param name="ho_status">동시구분	String	Y	1</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="invidx">ELW권리형태(1:표준2:디지털3:조기종료)	String	Y	1	1:표준	2:디지털	3:조기종료</param>
/// <param name="koba_stdprc">KO베리어	Number	Y	12.2</param>
/// <param name="koba_acc_rt">KO접근도	Number	Y	12.2</param>
/// <param name="koba_yn">KO발생여부(Y/N)	String	Y	1	Y:Yes	N:No</param>
public record t1971OutBlock(string hname, int price, string sign, int change, double diff, long volume, int jnilclose, int offerho1, int bidho1, long offerrem1, long lp_offerrem1, long bidrem1, long lp_bidrem1, long preoffercha1, long prebidcha1, int offerho2, int bidho2, long offerrem2, long lp_offerrem2, long bidrem2, long lp_bidrem2, long preoffercha2, long prebidcha2, int offerho3, int bidho3, long offerrem3, long lp_offerrem3, long bidrem3, long lp_bidrem3, long preoffercha3, long prebidcha3, int offerho4, int bidho4, long offerrem4, long lp_offerrem4, long bidrem4, long lp_bidrem4, long preoffercha4, long prebidcha4, int offerho5, int bidho5, long offerrem5, long lp_offerrem5, long bidrem5, long lp_bidrem5, long preoffercha5, long prebidcha5, int offerho6, int bidho6, long offerrem6, long lp_offerrem6, long bidrem6, long lp_bidrem6, long preoffercha6, long prebidcha6, int offerho7, int bidho7, long offerrem7, long lp_offerrem7, long bidrem7, long lp_bidrem7, long preoffercha7, long prebidcha7, int offerho8, int bidho8, long offerrem8, long lp_offerrem8, long bidrem8, long lp_bidrem8, long preoffercha8, long prebidcha8, int offerho9, int bidho9, long offerrem9, long lp_offerrem9, long bidrem9, long lp_bidrem9, long preoffercha9, long prebidcha9, int offerho10, int bidho10, long offerrem10, long lp_offerrem10, long bidrem10, long lp_bidrem10, long preoffercha10, long prebidcha10, long offer, long bid, long preoffercha, long prebidcha, string hotime, int yeprice, long yevolume, string yesign, int yechange, double yediff, long tmoffer, long tmbid, string ho_status, int open, int high, int low, string invidx, double koba_stdprc, double koba_acc_rt, string koba_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1972InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	40</param>
/// <param name="expcode">표준코드	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	9</param>
/// <param name="offerno1">매도증권사코드1	String	Y	6</param>
/// <param name="bidno1">매수증권사코드1	String	Y	6</param>
/// <param name="dvol1">총매도수량1	Number	Y	12</param>
/// <param name="svol1">총매수수량1	Number	Y	12</param>
/// <param name="dcha1">매도증감1	Number	Y	12</param>
/// <param name="scha1">매수증감1	Number	Y	12</param>
/// <param name="ddiff1">매도비율1	Number	Y	6.2</param>
/// <param name="sdiff1">매수비율1	Number	Y	6.2</param>
/// <param name="offerno2">매도증권사코드2	String	Y	6</param>
/// <param name="bidno2">매수증권사코드2	String	Y	6</param>
/// <param name="dvol2">총매도수량2	Number	Y	12</param>
/// <param name="svol2">총매수수량2	Number	Y	12</param>
/// <param name="dcha2">매도증감2	Number	Y	12</param>
/// <param name="scha2">매수증감2	Number	Y	12</param>
/// <param name="ddiff2">매도비율2	Number	Y	6.2</param>
/// <param name="sdiff2">매수비율2	Number	Y	6.2</param>
/// <param name="offerno3">매도증권사코드3	String	Y	6</param>
/// <param name="bidno3">매수증권사코드3	String	Y	6</param>
/// <param name="dvol3">총매도수량3	Number	Y	12</param>
/// <param name="svol3">총매수수량3	Number	Y	12</param>
/// <param name="dcha3">매도증감3	Number	Y	12</param>
/// <param name="scha3">매수증감3	Number	Y	12</param>
/// <param name="ddiff3">매도비율3	Number	Y	6.2</param>
/// <param name="sdiff3">매수비율3	Number	Y	6.2</param>
/// <param name="offerno4">매도증권사코드4	String	Y	6</param>
/// <param name="bidno4">매수증권사코드4	String	Y	6</param>
/// <param name="dvol4">총매도수량4	Number	Y	12</param>
/// <param name="svol4">총매수수량4	Number	Y	12</param>
/// <param name="dcha4">매도증감4	Number	Y	12</param>
/// <param name="scha4">매수증감4	Number	Y	12</param>
/// <param name="ddiff4">매도비율4	Number	Y	6.2</param>
/// <param name="sdiff4">매수비율4	Number	Y	6.2</param>
/// <param name="offerno5">매도증권사코드5	String	Y	6</param>
/// <param name="bidno5">매수증권사코드5	String	Y	6</param>
/// <param name="dvol5">총매도수량5	Number	Y	12</param>
/// <param name="svol5">총매수수량5	Number	Y	12</param>
/// <param name="dcha5">매도증감5	Number	Y	12</param>
/// <param name="scha5">매수증감5	Number	Y	12</param>
/// <param name="ddiff5">매도비율5	Number	Y	6.2</param>
/// <param name="sdiff5">매수비율5	Number	Y	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	Number	Y	12</param>
/// <param name="fwsvl">외국계매수합계수량	Number	Y	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	Number	Y	12</param>
/// <param name="ftradmscha">외국계매수직전대비	Number	Y	12</param>
/// <param name="fwddiff">외국계매도합계비율	Number	Y	6.2</param>
/// <param name="fwsdiff">외국계매수합계비율	Number	Y	6.2</param>
public record t1972OutBlock(string hname, string expcode, string shcode, string offerno1, string bidno1, long dvol1, long svol1, long dcha1, long scha1, double ddiff1, double sdiff1, string offerno2, string bidno2, long dvol2, long svol2, long dcha2, long scha2, double ddiff2, double sdiff2, string offerno3, string bidno3, long dvol3, long svol3, long dcha3, long scha3, double ddiff3, double sdiff3, string offerno4, string bidno4, long dvol4, long svol4, long dcha4, long scha4, double ddiff4, double sdiff4, string offerno5, string bidno5, long dvol5, long svol5, long dcha5, long scha5, double ddiff5, double sdiff5, long fwdvl, long fwsvl, long ftradmdcha, long ftradmscha, double fwddiff, double fwsdiff);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="cts_time">시간CTS	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t1973InBlock(string shcode, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	8</param>
public record t1973OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	8</param>
/// <param name="yeprice">예상체결가격	Number	Y	8</param>
/// <param name="yegubun">예상체결구분	String	Y	1</param>
/// <param name="jnilysign">전일종가대비구분	String	Y	1</param>
/// <param name="jnilychange">전일종가대비	Number	Y	8</param>
/// <param name="yediff">예상체결등락율	Number	Y	6.2</param>
/// <param name="yevolume">예상체결량	Number	Y	12</param>
/// <param name="ymdvolume">예상매도체결량	Number	Y	12</param>
/// <param name="ymsvolume">예상매수체결량	Number	Y	12</param>
public record t1973OutBlock1(string chetime, int yeprice, string yegubun, string jnilysign, int jnilychange, double yediff, long yevolume, long ymdvolume, long ymsvolume);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1974InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">종목갯수	Number	Y	4</param>
public record t1974OutBlock(int cnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="cpgubun">콜/풋구분	String	Y	2</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record t1974OutBlock1(string shcode, string hname, string cpgubun, int price, string sign, int change, double diff, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="mkt_gb">시장구분(0:전체1:코스피2:코스닥)	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="chk_price">가격설정(0:전체1:조건설정)	String	Y	1</param>
/// <param name="from_price">가격1	String	Y	12</param>
/// <param name="to_price">가격2	String	Y	12</param>
/// <param name="chk_vol">거래량설정(0:전체1:조건설정)	String	Y	1</param>
/// <param name="from_vol">거래량1	String	Y	12</param>
/// <param name="to_vol">거래량2	String	Y	12</param>
/// <param name="chk_rate">등락율설정(0:전체1:조건설정)	String	Y	1</param>
/// <param name="from_rate">등락율1	Number	Y	5.2</param>
/// <param name="to_rate">등락율2	Number	Y	5.2</param>
/// <param name="chk_amt">거래대금설정(0:전체1:조건설정)	String	Y	1</param>
/// <param name="from_amt">거래대금1	String	Y	12</param>
/// <param name="to_amt">거래대금2	String	Y	12</param>
/// <param name="chk_up">양봉설정(0:전체1:조건설정)	String	Y	1</param>
/// <param name="chk_down">음봉설정(0:전체1:조건설정)	String	Y	1</param>
public record t1988InBlock(string mkt_gb, string chk_price, string from_price, string to_price, string chk_vol, string from_vol, string to_vol, string chk_rate, double from_rate, double to_rate, string chk_amt, string from_amt, string to_amt, string chk_up, string chk_down);

/// <summary>
/// 
/// </summary>
/// <param name="ksp_cnt">코스피종목건수	String	Y	4</param>
/// <param name="ksd_cnt">코스닥종목건수	String	Y	4</param>
public record t1988OutBlock(string ksp_cnt, string ksd_cnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">표준코드	String	Y	12</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	String	Y	12</param>
/// <param name="sign">부호	String	Y	1</param>
/// <param name="change">대비	String	Y	12</param>
/// <param name="rate">등락율	Number	Y	5.2</param>
/// <param name="volume">누적거래량(주)	String	Y	12</param>
/// <param name="value">누적거래대금(백만)	String	Y	12</param>
/// <param name="mkt_gb">시장구분	String	Y	1</param>
/// <param name="jvolume">전일동시간대거래량(주)	String	Y	12</param>
public record t1988OutBlock1(string shcode, string expcode, string hname, string price, string sign, string change, double rate, string volume, string value, string mkt_gb, string jvolume);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t8431InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="recprice">기준가	Number	Y	8</param>
public record t8431OutBlock(string hname, string shcode, string expcode, int uplmtprice, int dnlmtprice, int jnilclose, int recprice);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">DUMMY	String	Y	1</param>
public record t9905InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">표준코드	String	Y	12</param>
/// <param name="hname">종목명	String	Y	20</param>
public record t9905OutBlock1(string shcode, string expcode, string hname);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">DUMMY	String	Y	1</param>
public record t9907InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="lastym">만기월	String	Y	6</param>
/// <param name="lastnm">만기월명	String	Y	10</param>
public record t9907OutBlock1(string lastym, string lastnm);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t9942InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	40</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">확장코드	String	Y	12</param>
public record t9942OutBlock(string hname, string shcode, string expcode);

#endregion

#region [주식] ETF

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1901InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="avg">가중평균	Number	Y	8</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="volumediff">거래량차	Number	Y	12</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="high52w">52최고가	Number	Y	8</param>
/// <param name="high52wdate">52최고가일	String	Y	8</param>
/// <param name="low52w">52최저가	Number	Y	8</param>
/// <param name="low52wdate">52최저가일	String	Y	8</param>
/// <param name="exhratio">소진율	Number	Y	6.2</param>
/// <param name="flmtvol">외국인보유수량	Number	Y	12</param>
/// <param name="per">PER	Number	Y	6.2</param>
/// <param name="listing">상장주식수(천)	Number	Y	12</param>
/// <param name="jkrate">증거금율	Number	Y	8</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
/// <param name="highyear">연중최고가	Number	Y	8</param>
/// <param name="highyeardate">연중최고일자	String	Y	8</param>
/// <param name="lowyear">연중최저가	Number	Y	8</param>
/// <param name="lowyeardate">연중최저일자	String	Y	8</param>
/// <param name="upname">업종명	String	Y	20</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="upprice">업종현재가	Number	Y	7.2</param>
/// <param name="upsign">업종전일비구분	String	Y	1</param>
/// <param name="upchange">업종전일대비	Number	Y	6.2</param>
/// <param name="updiff">업종등락율	Number	Y	6.2</param>
/// <param name="futname">선물최근월물명	String	Y	20</param>
/// <param name="futcode">선물최근월물코드	String	Y	8</param>
/// <param name="futprice">선물현재가	Number	Y	6.2</param>
/// <param name="futsign">선물전일비구분	String	Y	1</param>
/// <param name="futchange">선물전일대비	Number	Y	6.2</param>
/// <param name="futdiff">선물등락율	Number	Y	6.2</param>
/// <param name="nav">NAV	Number	Y	8.2</param>
/// <param name="navsign">NAV전일대비구분	String	Y	1</param>
/// <param name="navchange">NAV전일대비	Number	Y	8.2</param>
/// <param name="navdiff">NAV등락율	Number	Y	6.2</param>
/// <param name="cocrate">추적오차율	Number	Y	6.2</param>
/// <param name="kasis">괴리율	Number	Y	6.2</param>
/// <param name="subprice">대용가	Number	Y	10</param>
/// <param name="offerno1">매도증권사코드1	String	Y	6</param>
/// <param name="bidno1">매수증권사코드1	String	Y	6</param>
/// <param name="dvol1">총매도수량1	Number	Y	8</param>
/// <param name="svol1">총매수수량1	Number	Y	8</param>
/// <param name="dcha1">매도증감1	Number	Y	8</param>
/// <param name="scha1">매수증감1	Number	Y	8</param>
/// <param name="ddiff1">매도비율1	Number	Y	6.2</param>
/// <param name="sdiff1">매수비율1	Number	Y	6.2</param>
/// <param name="offerno2">매도증권사코드2	String	Y	6</param>
/// <param name="bidno2">매수증권사코드2	String	Y	6</param>
/// <param name="dvol2">총매도수량2	Number	Y	8</param>
/// <param name="svol2">총매수수량2	Number	Y	8</param>
/// <param name="dcha2">매도증감2	Number	Y	8</param>
/// <param name="scha2">매수증감2	Number	Y	8</param>
/// <param name="ddiff2">매도비율2	Number	Y	6.2</param>
/// <param name="sdiff2">매수비율2	Number	Y	6.2</param>
/// <param name="offerno3">매도증권사코드3	String	Y	6</param>
/// <param name="bidno3">매수증권사코드3	String	Y	6</param>
/// <param name="dvol3">총매도수량3	Number	Y	8</param>
/// <param name="svol3">총매수수량3	Number	Y	8</param>
/// <param name="dcha3">매도증감3	Number	Y	8</param>
/// <param name="scha3">매수증감3	Number	Y	8</param>
/// <param name="ddiff3">매도비율3	Number	Y	6.2</param>
/// <param name="sdiff3">매수비율3	Number	Y	6.2</param>
/// <param name="offerno4">매도증권사코드4	String	Y	6</param>
/// <param name="bidno4">매수증권사코드4	String	Y	6</param>
/// <param name="dvol4">총매도수량4	Number	Y	8</param>
/// <param name="svol4">총매수수량4	Number	Y	8</param>
/// <param name="dcha4">매도증감4	Number	Y	8</param>
/// <param name="scha4">매수증감4	Number	Y	8</param>
/// <param name="ddiff4">매도비율4	Number	Y	6.2</param>
/// <param name="sdiff4">매수비율4	Number	Y	6.2</param>
/// <param name="offerno5">매도증권사코드5	String	Y	6</param>
/// <param name="bidno5">매수증권사코드5	String	Y	6</param>
/// <param name="dvol5">총매도수량5	Number	Y	8</param>
/// <param name="svol5">총매수수량5	Number	Y	8</param>
/// <param name="dcha5">매도증감5	Number	Y	8</param>
/// <param name="scha5">매수증감5	Number	Y	8</param>
/// <param name="ddiff5">매도비율5	Number	Y	6.2</param>
/// <param name="sdiff5">매수비율5	Number	Y	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	Number	Y	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	Number	Y	12</param>
/// <param name="ftradmddiff">외국계매도비율	Number	Y	6.2</param>
/// <param name="fwsvl">외국계매수합계수량	Number	Y	12</param>
/// <param name="ftradmscha">외국계매수직전대비	Number	Y	12</param>
/// <param name="ftradmsdiff">외국계매수비율	Number	Y	6.2</param>
/// <param name="upname2">참고지수명	String	Y	20</param>
/// <param name="upcode2">참고지수코드	String	Y	3</param>
/// <param name="upprice2">참고지수현재가	Number	Y	7.2</param>
/// <param name="jnilnav">전일NAV	Number	Y	8.2</param>
/// <param name="jnilnavsign">전일NAV전일대비구분	String	Y	1</param>
/// <param name="jnilnavchange">전일NAV전일대비	Number	Y	8.2</param>
/// <param name="jnilnavdiff">전일NAV등락율	Number	Y	6.2</param>
/// <param name="etftotcap">순자산총액(억원)	Number	Y	12</param>
/// <param name="spread">스프레드	Number	Y	6.2</param>
/// <param name="leverage">레버리지	Number	Y	2</param>
/// <param name="taxgubun">과세구분	String	Y	1</param>
/// <param name="opcom_nmk">운용사	String	Y	20</param>
/// <param name="lp_nm1">LP1	String	Y	20</param>
/// <param name="lp_nm2">LP2	String	Y	20</param>
/// <param name="lp_nm3">LP3	String	Y	20</param>
/// <param name="lp_nm4">LP4	String	Y	20</param>
/// <param name="lp_nm5">LP5	String	Y	20</param>
/// <param name="etf_cp">복제방법	String	Y	10</param>
/// <param name="etf_kind">상품유형(Filler)	String	Y	10</param>
/// <param name="vi_gubun">VI발동해제	String	Y	10</param>
/// <param name="etn_kind_cd">ETN상품분류	String	Y	20</param>
/// <param name="lastymd">ETN만기일	String	Y	8</param>
/// <param name="payday">ETN지급일	String	Y	8</param>
/// <param name="lastdate">ETN최종거래일	String	Y	8</param>
/// <param name="issuernmk">ETN발행시장참가자	String	Y	20</param>
/// <param name="last_sdate">ETN만기상환가격결정시작일	String	Y	8</param>
/// <param name="last_edate">ETN만기상환가격결정종료일	String	Y	8</param>
/// <param name="lp_holdvol">ETNLP보유수량	String	Y	12</param>
/// <param name="listdate">상장일	String	Y	8</param>
/// <param name="etp_gb">ETP상품구분코드	String	Y	1</param>
/// <param name="etn_elback_yn">ETN조기상환가능여부	String	Y	1</param>
/// <param name="settletype">최종결제	String	Y	2</param>
/// <param name="idx_asset_class1">지수자산분류코드(대분류)	String	Y	2</param>
/// <param name="ty_text">ETF/ETN투자유의	String	Y	8</param>
/// <param name="leverage2">추적수익률배수	Number	Y	6.2</param>
public record t1901OutBlock(string hname, int price, string sign, int change, double diff, long volume, int recprice, int avg, int uplmtprice, int dnlmtprice, long jnilvolume, long volumediff, int open, string opentime, int high, string hightime, int low, string lowtime, int high52w, string high52wdate, int low52w, string low52wdate, double exhratio, long flmtvol, double per, long listing, int jkrate, double vol, string shcode, long value, int highyear, string highyeardate, int lowyear, string lowyeardate, string upname, string upcode, double upprice, string upsign, double upchange, double updiff, string futname, string futcode, double futprice, string futsign, double futchange, double futdiff, double nav, string navsign, double navchange, double navdiff, double cocrate, double kasis, long subprice, string offerno1, string bidno1, int dvol1, int svol1, int dcha1, int scha1, double ddiff1, double sdiff1, string offerno2, string bidno2, int dvol2, int svol2, int dcha2, int scha2, double ddiff2, double sdiff2, string offerno3, string bidno3, int dvol3, int svol3, int dcha3, int scha3, double ddiff3, double sdiff3, string offerno4, string bidno4, int dvol4, int svol4, int dcha4, int scha4, double ddiff4, double sdiff4, string offerno5, string bidno5, int dvol5, int svol5, int dcha5, int scha5, double ddiff5, double sdiff5, long fwdvl, long ftradmdcha, double ftradmddiff, long fwsvl, long ftradmscha, double ftradmsdiff, string upname2, string upcode2, double upprice2, double jnilnav, string jnilnavsign, double jnilnavchange, double jnilnavdiff, long etftotcap, double spread, int leverage, string taxgubun, string opcom_nmk, string lp_nm1, string lp_nm2, string lp_nm3, string lp_nm4, string lp_nm5, string etf_cp, string etf_kind, string vi_gubun, string etn_kind_cd, string lastymd, string payday, string lastdate, string issuernmk, string last_sdate, string last_edate, string lp_holdvol, string listdate, string etp_gb, string etn_elback_yn, string settletype, string idx_asset_class1, string ty_text, double leverage2);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="time">시간	String	Y	6	연속조회키	연속	조회시	이	값을	InBlock의	time	필드에	넣어준다.</param>
public record t1902InBlock(string shcode, string time);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="upname">업종지수명	String	Y	20</param>
public record t1902OutBlock(string time, string hname, string upname);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="navdiff">NAV대비	Number	Y	9.2</param>
/// <param name="nav">NAV	Number	Y	9.2</param>
/// <param name="navchange">전일대비	Number	Y	9.2</param>
/// <param name="crate">추적오차	Number	Y	9.2</param>
/// <param name="grate">괴리	Number	Y	9.2</param>
/// <param name="jisu">지수	Number	Y	8.2</param>
/// <param name="jichange">전일대비	Number	Y	8.2</param>
/// <param name="jirate">전일대비율	Number	Y	8.2</param>
public record t1902OutBlock1(string time, int price, string sign, int change, long volume, double navdiff, double nav, double navchange, double crate, double grate, double jisu, double jichange, double jirate);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="date">일자	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	date	필드에	넣어준다.</param>
public record t1903InBlock(string shcode, string date);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="upname">업종지수명	String	Y	20</param>
public record t1903OutBlock(string date, string hname, string upname);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="navdiff">NAV대비	Number	Y	9.2</param>
/// <param name="nav">NAV	Number	Y	9.2</param>
/// <param name="navchange">전일대비	Number	Y	9.2</param>
/// <param name="crate">추적오차	Number	Y	9.2</param>
/// <param name="grate">괴리	Number	Y	9.2</param>
/// <param name="jisu">지수	Number	Y	8.2</param>
/// <param name="jichange">전일대비	Number	Y	8.2</param>
/// <param name="jirate">전일대비율	Number	Y	8.2</param>
public record t1903OutBlock1(string date, int price, string sign, int change, long volume, double navdiff, double nav, double navchange, double crate, double grate, double jisu, double jichange, double jirate);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">ETF단축코드	String	Y	6</param>
/// <param name="date">PDF적용일자	String	Y	8</param>
/// <param name="sgb">정렬기준(1:평가금액2:증권수)	String	Y	1</param>
public record t1904InBlock(string shcode, string date, string sgb);

/// <summary>
/// 
/// </summary>
/// <param name="chk_tday">당일구분	String	Y	1</param>
/// <param name="date">PDF적용일자	String	Y	8</param>
/// <param name="price">ETF현재가	Number	Y	8</param>
/// <param name="sign">ETF전일대비구분	String	Y	1</param>
/// <param name="change">ETF전일대비	Number	Y	8</param>
/// <param name="diff">ETF등락율	Number	Y	6.2</param>
/// <param name="volume">ETF누적거래량	Number	Y	12</param>
/// <param name="nav">NAV	Number	Y	8.2</param>
/// <param name="navsign">NAV전일대비구분	String	Y	1</param>
/// <param name="navchange">NAV전일대비	Number	Y	8.2</param>
/// <param name="navdiff">NAV등락율	Number	Y	6.2</param>
/// <param name="jnilnav">전일NAV	Number	Y	8.2</param>
/// <param name="jnilnavsign">전일NAV전일대비구분	String	Y	1</param>
/// <param name="jnilnavchange">전일NAV전일대비	Number	Y	8.2</param>
/// <param name="jnilnavdiff">전일NAV등락율	Number	Y	6.2</param>
/// <param name="upname">업종명	String	Y	20</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="upprice">업종현재가	Number	Y	7.2</param>
/// <param name="upsign">업종전일비구분	String	Y	1</param>
/// <param name="upchange">업종전일대비	Number	Y	6.2</param>
/// <param name="updiff">업종등락율	Number	Y	6.2</param>
/// <param name="futname">선물최근월물명	String	Y	20</param>
/// <param name="futcode">선물최근월물코드	String	Y	8</param>
/// <param name="futprice">선물현재가	Number	Y	6.2</param>
/// <param name="futsign">선물전일비구분	String	Y	1</param>
/// <param name="futchange">선물전일대비	Number	Y	6.2</param>
/// <param name="futdiff">선물등락율	Number	Y	6.2</param>
/// <param name="upname2">참고지수명	String	Y	20</param>
/// <param name="upcode2">참고지수코드	String	Y	3</param>
/// <param name="upprice2">참고지수현재가	Number	Y	7.2</param>
/// <param name="etftotcap">순자산총액(단위:억)	Number	Y	12</param>
/// <param name="etfnum">구성종목수	Number	Y	4</param>
/// <param name="etfcunum">CU주식수	Number	Y	12</param>
/// <param name="cash">현금	Number	Y	12</param>
/// <param name="opcom_nmk">운용사명	String	Y	20</param>
/// <param name="tot_pval">전종목평가금액합	Number	Y	12</param>
/// <param name="tot_sigatval">전종목구성시가총액합	Number	Y	12</param>
public record t1904OutBlock(string chk_tday, string date, int price, string sign, int change, double diff, long volume, double nav, string navsign, double navchange, double navdiff, double jnilnav, string jnilnavsign, double jnilnavchange, double jnilnavdiff, string upname, string upcode, double upprice, string upsign, double upchange, double updiff, string futname, string futcode, double futprice, string futsign, double futchange, double futdiff, string upname2, string upcode2, double upprice2, long etftotcap, int etfnum, long etfcunum, long cash, string opcom_nmk, long tot_pval, long tot_sigatval);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	12</param>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="value">거래대금(백만)	Number	Y	12</param>
/// <param name="icux">단위증권수(계약수/원화현금/USD현금/창고증권)	Number	Y	12</param>
/// <param name="parprice">액면금액/설정현금액	Number	Y	12</param>
/// <param name="pvalue">평가금액	Number	Y	12</param>
/// <param name="sigatvalue">구성시가총액	Number	Y	12</param>
/// <param name="profitdate">PDF적용일자	String	Y	8</param>
/// <param name="weight">비중(평가금액)	Number	Y	6.2</param>
/// <param name="diff2">ETF종목과등락차	Number	Y	6.2</param>
public record t1904OutBlock1(string shcode, string hname, int price, string sign, int change, double diff, long volume, long value, long icux, long parprice, long pvalue, long sigatvalue, string profitdate, double weight, double diff2);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t1906InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="lp_offerrem1">LP매도호가수량1	Number	Y	12</param>
/// <param name="lp_bidrem1">LP매수호가수량1	Number	Y	12</param>
/// <param name="lp_offerrem2">LP매도호가수량2	Number	Y	12</param>
/// <param name="lp_bidrem2">LP매수호가수량2	Number	Y	12</param>
/// <param name="lp_offerrem3">LP매도호가수량3	Number	Y	12</param>
/// <param name="lp_bidrem3">LP매수호가수량3	Number	Y	12</param>
/// <param name="lp_offerrem4">LP매도호가수량4	Number	Y	12</param>
/// <param name="lp_bidrem4">LP매수호가수량4	Number	Y	12</param>
/// <param name="lp_offerrem5">LP매도호가수량5	Number	Y	12</param>
/// <param name="lp_bidrem5">LP매수호가수량5	Number	Y	12</param>
/// <param name="lp_offerrem6">LP매도호가수량6	Number	Y	12</param>
/// <param name="lp_bidrem6">LP매수호가수량6	Number	Y	12</param>
/// <param name="lp_offerrem7">LP매도호가수량7	Number	Y	12</param>
/// <param name="lp_bidrem7">LP매수호가수량7	Number	Y	12</param>
/// <param name="lp_offerrem8">LP매도호가수량8	Number	Y	12</param>
/// <param name="lp_bidrem8">LP매수호가수량8	Number	Y	12</param>
/// <param name="lp_offerrem9">LP매도호가수량9	Number	Y	12</param>
/// <param name="lp_bidrem9">LP매수호가수량9	Number	Y	12</param>
/// <param name="lp_offerrem10">LP매도호가수량10	Number	Y	12</param>
/// <param name="lp_bidrem10">LP매수호가수량10	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="offerho1">매도호가1	Number	Y	8</param>
/// <param name="bidho1">매수호가1	Number	Y	8</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	12</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	12</param>
/// <param name="preoffercha1">직전매도대비수량1	Number	Y	12</param>
/// <param name="prebidcha1">직전매수대비수량1	Number	Y	12</param>
/// <param name="offerho2">매도호가2	Number	Y	8</param>
/// <param name="bidho2">매수호가2	Number	Y	8</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	12</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	12</param>
/// <param name="preoffercha2">직전매도대비수량2	Number	Y	12</param>
/// <param name="prebidcha2">직전매수대비수량2	Number	Y	12</param>
/// <param name="offerho3">매도호가3	Number	Y	8</param>
/// <param name="bidho3">매수호가3	Number	Y	8</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	12</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	12</param>
/// <param name="preoffercha3">직전매도대비수량3	Number	Y	12</param>
/// <param name="prebidcha3">직전매수대비수량3	Number	Y	12</param>
/// <param name="offerho4">매도호가4	Number	Y	8</param>
/// <param name="bidho4">매수호가4	Number	Y	8</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	12</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	12</param>
/// <param name="preoffercha4">직전매도대비수량4	Number	Y	12</param>
/// <param name="prebidcha4">직전매수대비수량4	Number	Y	12</param>
/// <param name="offerho5">매도호가5	Number	Y	8</param>
/// <param name="bidho5">매수호가5	Number	Y	8</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	12</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	12</param>
/// <param name="preoffercha5">직전매도대비수량5	Number	Y	12</param>
/// <param name="prebidcha5">직전매수대비수량5	Number	Y	12</param>
/// <param name="offerho6">매도호가6	Number	Y	8</param>
/// <param name="bidho6">매수호가6	Number	Y	8</param>
/// <param name="offerrem6">매도호가수량6	Number	Y	12</param>
/// <param name="bidrem6">매수호가수량6	Number	Y	12</param>
/// <param name="preoffercha6">직전매도대비수량6	Number	Y	12</param>
/// <param name="prebidcha6">직전매수대비수량6	Number	Y	12</param>
/// <param name="offerho7">매도호가7	Number	Y	8</param>
/// <param name="bidho7">매수호가7	Number	Y	8</param>
/// <param name="offerrem7">매도호가수량7	Number	Y	12</param>
/// <param name="bidrem7">매수호가수량7	Number	Y	12</param>
/// <param name="preoffercha7">직전매도대비수량7	Number	Y	12</param>
/// <param name="prebidcha7">직전매수대비수량7	Number	Y	12</param>
/// <param name="offerho8">매도호가8	Number	Y	8</param>
/// <param name="bidho8">매수호가8	Number	Y	8</param>
/// <param name="offerrem8">매도호가수량8	Number	Y	12</param>
/// <param name="bidrem8">매수호가수량8	Number	Y	12</param>
/// <param name="preoffercha8">직전매도대비수량8	Number	Y	12</param>
/// <param name="prebidcha8">직전매수대비수량8	Number	Y	12</param>
/// <param name="offerho9">매도호가9	Number	Y	8</param>
/// <param name="bidho9">매수호가9	Number	Y	8</param>
/// <param name="offerrem9">매도호가수량9	Number	Y	12</param>
/// <param name="bidrem9">매수호가수량9	Number	Y	12</param>
/// <param name="preoffercha9">직전매도대비수량9	Number	Y	12</param>
/// <param name="prebidcha9">직전매수대비수량9	Number	Y	12</param>
/// <param name="offerho10">매도호가10	Number	Y	8</param>
/// <param name="bidho10">매수호가10	Number	Y	8</param>
/// <param name="offerrem10">매도호가수량10	Number	Y	12</param>
/// <param name="bidrem10">매수호가수량10	Number	Y	12</param>
/// <param name="preoffercha10">직전매도대비수량10	Number	Y	12</param>
/// <param name="prebidcha10">직전매수대비수량10	Number	Y	12</param>
/// <param name="offer">매도호가수량합	Number	Y	12</param>
/// <param name="bid">매수호가수량합	Number	Y	12</param>
/// <param name="preoffercha">직전매도대비수량합	Number	Y	12</param>
/// <param name="prebidcha">직전매수대비수량합	Number	Y	12</param>
/// <param name="hotime">수신시간	String	Y	8</param>
/// <param name="yeprice">예상체결가격	Number	Y	8</param>
/// <param name="yevolume">예상체결수량	Number	Y	12</param>
/// <param name="yesign">예상체결전일구분	String	Y	1</param>
/// <param name="yechange">예상체결전일대비	Number	Y	8</param>
/// <param name="yediff">예상체결등락율	Number	Y	6.2</param>
/// <param name="tmoffer">시간외매도잔량	Number	Y	12</param>
/// <param name="tmbid">시간외매수잔량	Number	Y	12</param>
/// <param name="ho_status">동시구분	String	Y	1</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
public record t1906OutBlock(string hname, int price, string sign, int change, double diff, long volume, long lp_offerrem1, long lp_bidrem1, long lp_offerrem2, long lp_bidrem2, long lp_offerrem3, long lp_bidrem3, long lp_offerrem4, long lp_bidrem4, long lp_offerrem5, long lp_bidrem5, long lp_offerrem6, long lp_bidrem6, long lp_offerrem7, long lp_bidrem7, long lp_offerrem8, long lp_bidrem8, long lp_offerrem9, long lp_bidrem9, long lp_offerrem10, long lp_bidrem10, int jnilclose, int offerho1, int bidho1, long offerrem1, long bidrem1, long preoffercha1, long prebidcha1, int offerho2, int bidho2, long offerrem2, long bidrem2, long preoffercha2, long prebidcha2, int offerho3, int bidho3, long offerrem3, long bidrem3, long preoffercha3, long prebidcha3, int offerho4, int bidho4, long offerrem4, long bidrem4, long preoffercha4, long prebidcha4, int offerho5, int bidho5, long offerrem5, long bidrem5, long preoffercha5, long prebidcha5, int offerho6, int bidho6, long offerrem6, long bidrem6, long preoffercha6, long prebidcha6, int offerho7, int bidho7, long offerrem7, long bidrem7, long preoffercha7, long prebidcha7, int offerho8, int bidho8, long offerrem8, long bidrem8, long preoffercha8, long prebidcha8, int offerho9, int bidho9, long offerrem9, long bidrem9, long preoffercha9, long prebidcha9, int offerho10, int bidho10, long offerrem10, long bidrem10, long preoffercha10, long prebidcha10, long offer, long bid, long preoffercha, long prebidcha, string hotime, int yeprice, long yevolume, string yesign, int yechange, double yediff, long tmoffer, long tmbid, string ho_status, string shcode, int uplmtprice, int dnlmtprice, int open, int high, int low);

#endregion

#region [주식] 섹터

/// <summary>
/// 
/// </summary>
/// <param name="tmname">테마명	String	Y	36	t8425조회하여	확인	후	입력</param>
/// <param name="tmcode">테마코드	String	Y	4	t8425조회하여	확인	후	입력</param>
public record t1531InBlock(string tmname, string tmcode);

/// <summary>
/// 
/// </summary>
/// <param name="tmname">테마명	String	Y	36</param>
/// <param name="avgdiff">평균등락율	Number	Y	6.2</param>
/// <param name="tmcode">테마코드	String	Y	4</param>
public record t1531OutBlock(string tmname, double avgdiff, string tmcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1532InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="tmname">테마명	String	Y	36</param>
/// <param name="avgdiff">평균등락율	Number	Y	6.2</param>
/// <param name="tmcode">테마코드	String	Y	4</param>
public record t1532OutBlock(string tmname, double avgdiff, string tmcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	1@상승율	상위	2@하락율	상위	3@거래증가율	상위	4@거래증가율	하위	5@상승종목비율	상위	6@상승종목비율	하위	7@기준대비	상승율	상위	8@기준대비	하락율	상위</param>
/// <param name="chgdate">대비일자	Number	Y	2</param>
public record t1533InBlock(string gubun, int chgdate);

/// <summary>
/// 
/// </summary>
/// <param name="bdate">일자	String	Y	8</param>
public record t1533OutBlock(string bdate);

/// <summary>
/// 
/// </summary>
/// <param name="tmname">테마명	String	Y	36</param>
/// <param name="totcnt">전체	Number	Y	4</param>
/// <param name="upcnt">상승	Number	Y	4</param>
/// <param name="dncnt">하락	Number	Y	4</param>
/// <param name="uprate">상승비율	Number	Y	6.2</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="avgdiff">평균등락율	Number	Y	6.2</param>
/// <param name="chgdiff">대비등락율	Number	Y	6.2</param>
/// <param name="tmcode">테마코드	String	Y	4</param>
public record t1533OutBlock1(string tmname, int totcnt, int upcnt, int dncnt, double uprate, double diff_vol, double avgdiff, double chgdiff, string tmcode);

/// <summary>
/// 
/// </summary>
/// <param name="tmcode">테마코드	String	Y	4	t8425조회하여	확인	후	입력</param>
public record t1537InBlock(string tmcode);

/// <summary>
/// 
/// </summary>
/// <param name="upcnt">상승종목수	Number	Y	4</param>
/// <param name="tmcnt">테마종목수	Number	Y	4</param>
/// <param name="uprate">상승종목비율	Number	Y	4</param>
/// <param name="tmname">테마명	String	Y	36</param>
public record t1537OutBlock(int upcnt, int tmcnt, int uprate, string tmname);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="jniltime">전일동시간	Number	Y	9.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="yeprice">예상체결가	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="value">누적거래대금(단위:백만)	Number	Y	12</param>
/// <param name="marketcap">시가총액(단위:백만)	Number	Y	12</param>
public record t1537OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double jniltime, string shcode, int yeprice, int open, int high, int low, long value, long marketcap);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t8425InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="tmname">테마명	String	Y	36</param>
/// <param name="tmcode">테마코드	String	Y	4</param>
public record t8425OutBlock(string tmname, string tmcode);

#endregion

#region [주식] 종목검색

/// <summary>
/// 
/// </summary>
/// <param name="gubun">신호구분	String	Y	1	'0'</param>
/// <param name="jmGb">종목구분	String	Y	1	'0'</param>
/// <param name="jmcode">종목코드	String	Y	6</param>
/// <param name="cts">NEXTKEY	String	Y	30	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts	값으로	설정</param>
public record t1809InBlock(string gubun, string jmGb, string jmcode, string cts);

/// <summary>
/// 
/// </summary>
/// <param name="cts">NEXTKEY	String	Y	30</param>
public record t1809OutBlock(string cts);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="signal_id">신호ID	String	Y	4</param>
/// <param name="signal_desc">신호명	String	Y	300</param>
/// <param name="point">신호강도	String	Y	3</param>
/// <param name="keyword">뉴스신호키워드	String	Y	40</param>
/// <param name="seq">신호별구분	String	Y	24</param>
/// <param name="gubun">신호구분	String	Y	2</param>
/// <param name="jmcode">신호종목	String	Y	6</param>
/// <param name="price">종목가격	Number	Y	7</param>
/// <param name="sign">종목등락부호	String	Y	1</param>
/// <param name="chgrate">대비등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	9</param>
/// <param name="datetime">신호일시	String	Y	16</param>
public record t1809OutBlock1(string date, string time, string signal_id, string signal_desc, string point, string keyword, string seq, string gubun, string jmcode, int price, string sign, double chgrate, long volume, string datetime);

/// <summary>
/// 
/// </summary>
/// <param name="search_cd">검색코드	String	Y	4	t1826OutBlock의	search_cd	참조</param>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	String	Y	1</param>
public record t1825InBlock(string search_cd, string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="JongCnt">검색종목수	Number	Y	4</param>
public record t1825OutBlock(int JongCnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="signcnt">연속봉수	Number	Y	3</param>
/// <param name="close">현재가	Number	Y	9</param>
/// <param name="change">전일대비	Number	Y	9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	10</param>
/// <param name="volumerate">거래량전일대비율	Number	Y	6.2</param>
public record t1825OutBlock1(string shcode, string hname, string sign, int signcnt, long close, long change, double diff, long volume, double volumerate);

/// <summary>
/// 
/// </summary>
/// <param name="search_gb">검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)	String	Y	1</param>
public record t1826InBlock(string search_gb);

/// <summary>
/// 
/// </summary>
/// <param name="search_cd">검색코드	String	Y	4</param>
/// <param name="search_nm">검색명	String	Y	40</param>
public record t1826OutBlock(string search_cd, string search_nm);

#endregion

#region [주식] 상위종목

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="gubun2">상승하락	String	Y	1	0:	상승률	1:	하락률	2:	보합</param>
/// <param name="gubun3">당일전일	String	Y	1	0:	당일	1:	전일</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값	증거금50	:	0x00400000	증거금100	:	0x00800000	증거금50/100	:	0x00200000	관리종목	:	0x00000080	시장경보	:	0x00000100	거래정지	:	0x00000200	우선주	:	0x00004000	투자유의	:	0x04000000	정리매매	:	0x01000000	불성실공시	:	0x80000000</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="jc_num2">대상제외2	Number	Y	12	기본	=>	000000000000	상장지수펀드	=>	000000000001	선박투자회사	=>	000000000002	스펙	=>	000000000004	ETN	=>	000000000008(0x00000008)	투자주의	=>	000000000016(0x00000010)	투자위험	=>	000000000032(0x00000020)	위험예고	=>	000000000064(0x00000040)	담보불가	=>	000000000128(0x00000080)	두개	이상	제외시	해당	값을	합산한다.</param>
public record t1441InBlock(string gubun1, string gubun2, string gubun3, long jc_num, int sprice, int eprice, long volume, int idx, long jc_num2);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1441OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	12</param>
/// <param name="bidho1">매수호가	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="updaycnt">연속	Number	Y	4</param>
/// <param name="jnildiff">전일등락율	Number	Y	6.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="voldiff">거래량대비율	Number	Y	8.2</param>
/// <param name="value">거래대금	Number	Y	15</param>
/// <param name="total">시가총액	Number	Y	12</param>
public record t1441OutBlock1(string hname, int price, string sign, int change, double diff, long volume, long offerrem1, long offerho1, long bidho1, long bidrem1, int updaycnt, double jnildiff, string shcode, int open, int high, int low, double voldiff, long value, long total);

/// <summary>
/// 
/// </summary>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시	Space	연속	조회시	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1444InBlock(string upcode, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1444OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="vol_rate">거래비중	Number	Y	6.2</param>
/// <param name="total">시가총액	Number	Y	12</param>
/// <param name="rate">비중	Number	Y	6.2</param>
/// <param name="for_rate">외인비중	Number	Y	6.2</param>
public record t1444OutBlock1(string shcode, string hname, int price, string sign, int change, double diff, long volume, double vol_rate, long total, double rate, double for_rate);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="jnilgubun">전일구분	String	Y	1	1:당일	2:전일</param>
/// <param name="sdiff">시작등락율	Number	Y	3	현재등락율	>=	sdiff</param>
/// <param name="ediff">종료등락율	Number	Y	3	현재등락율	<=	ediff</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값	(0x00000080)관리종목	=>	000000000128	(0x00000100)시장경보	=>	000000000256	(0x00000200)거래정지	=>	000000000512	(0x00004000)우선주	=>	000000016384	(0x00200000)증거금50	=>	000008388608	(0x01000000)정리매매	=>	000016777216	(0x04000000)투자유의	=>	000067108864	(0x80000000)불성실공시	=>	-02147483648	두개	이상	제외시	해당	값을	합산한다	예)관리종목	+	시장경보	=	000000000128	+	000000000256	=	000000000384</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1452InBlock(string gubun, string jnilgubun, int sdiff, int ediff, long jc_num, int sprice, int eprice, long volume, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1452OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="bef_diff">전일비	Number	Y	10.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1452OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double vol, long jnilvolume, double bef_diff, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0	:	전체	1	:	코스피	2	:	코스닥</param>
/// <param name="jnilgubun">전일구분	String	Y	1	0	:	당일	1	:	전일</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값	(0x00000080)관리종목	=>	000000000128	(0x00000100)시장경보	=>	000000000256	(0x00000200)거래정지	=>	000000000512	(0x00004000)우선주	=>	000000016384	(0x00200000)증거금50	=>	000008388608	(0x01000000)정리매매	=>	000016777216	(0x04000000)투자유의	=>	000067108864	(0x80000000)불성실공시	=>	-02147483648	두개	이상	제외시	해당	값을	합산한다	예)관리종목	+	시장경보	=	000000000128	+	000000000256	=	000000000384</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="jc_num2">대상제외2	Number	Y	12	기본	=>	000000000000	상장지수펀드	=>	000000000001	선박투자회사	=>	000000000002	스펙	=>	000000000004	ETN	=>	000000000008(0x00000008)	투자주의	=>	000000000016(0x00000010)	투자위험	=>	000000000032(0x00000020)	위험예고	=>	000000000064(0x00000040)	담보불가	=>	000000000128(0x00000080)	두개	이상	제외시	해당	값을	합산한다.</param>
public record t1463InBlock(string gubun, string jnilgubun, long jc_num, int sprice, int eprice, long volume, int idx, long jc_num2);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1463OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="jnilvalue">전일거래대금	Number	Y	12</param>
/// <param name="bef_diff">전일비	Number	Y	10.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="filler">filler	String	Y	1</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
public record t1463OutBlock1(string hname, int price, string sign, int change, double diff, long volume, long value, long jnilvalue, double bef_diff, string shcode, string filler, long jnilvolume);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0	:	전체	1	:	코스피	2	:	코스닥</param>
/// <param name="type1">전일거래량	String	Y	1	0@1주	이상	1@1만주	이상	2@5만주	이상	3@10만주	이상	4@20만주	이상	5@50만주	이상	6@100만주	이상</param>
/// <param name="type2">거래급등율	String	Y	1	0@전체	1@2000%이하	2@1500%이하	3@1000%이하	4@500%이하	5@100%이하	6@50%이하</param>
/// <param name="jc_num">대상제외	Number	Y	12	대상제외값	(0x00000080)관리종목	=>	000000000128	(0x00000100)시장경보	=>	000000000256	(0x00000200)거래정지	=>	000000000512	(0x00004000)우선주	=>	000000016384	(0x00200000)증거금50	=>	000008388608	(0x01000000)정리매매	=>	000016777216	(0x04000000)투자유의	=>	000067108864	(0x80000000)불성실공시	=>	-02147483648	두개	이상	제외시	해당	값을	합산한다	예)관리종목	+	시장경보	=	000000000128	+	000000000256	=	000000000384</param>
/// <param name="sprice">시작가격	Number	Y	8	현재가	>=	sprice</param>
/// <param name="eprice">종료가격	Number	Y	8	현재가	<=	eprice</param>
/// <param name="volume">거래량	Number	Y	12	거래량	>=	volume</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
/// <param name="jc_num2">대상제외2	Number	Y	12	기본	=>	000000000000	상장지수펀드	=>	000000000001	선박투자회사	=>	000000000002	스펙	=>	000000000004	ETN	=>	000000000008(0x00000008)	투자주의	=>	000000000016(0x00000010)	투자위험	=>	000000000032(0x00000020)	위험예고	=>	000000000064(0x00000040)	담보불가	=>	000000000128(0x00000080)	두개	이상	제외시	해당	값을	합산한다.</param>
public record t1466InBlock(string gubun, string type1, string type2, long jc_num, int sprice, int eprice, long volume, int idx, long jc_num2);

/// <summary>
/// 
/// </summary>
/// <param name="hhmm">현재시분	String	Y	5</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1466OutBlock(string hhmm, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="stdvolume">전일거래량	Number	Y	12</param>
/// <param name="volume">당일거래량	Number	Y	12</param>
/// <param name="voldiff">거래급등율	Number	Y	8.2</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
public record t1466OutBlock1(string shcode, string hname, int price, string sign, int change, double diff, long stdvolume, long volume, double voldiff, int open, int high, int low);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="gubun2">상승하락	String	Y	1	0:	상승률	1:	하락률</param>
/// <param name="jongchk">종목체크	String	Y	1	0:	전체	1:	우선제외	2:	관리제외	3:	우선관리제외</param>
/// <param name="volume">거래량	String	Y	1	0:	전체거래량	1:	1천주	이상	2:	5천주	이상	3:	1만주	이상	4:	5만주	이상	5:	10만주	이상	6:	50만주	이상	7:	100만주	이상</param>
/// <param name="idx">IDX	Number	Y	4	연속조회시	OutBlock의	idx	입력</param>
public record t1481InBlock(string gubun1, string gubun2, string jongchk, string volume, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1481OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	12</param>
/// <param name="bidho1">매수호가	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
public record t1481OutBlock1(string hname, int price, string sign, int change, double diff, long volume, long offerrem1, long bidrem1, long offerho1, long bidho1, string shcode, long value);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:	전체	1:	코스피	2:	코스닥</param>
/// <param name="jongchk">거래량	String	Y	1	0:	전체	1:	우선제외	2:	관리제외	3:	우선관리제외</param>
/// <param name="idx">IDX	Number	Y	4	연속조회시	OutBlock의	idx	입력</param>
public record t1482InBlock(string gubun, string jongchk, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1482OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="vol">회전율	Number	Y	6.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
public record t1482OutBlock1(string hname, int price, string sign, int change, double diff, long volume, double vol, string shcode, long value);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">거래소구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="jgubun">장구분	String	Y	1	0:장전	1:장후</param>
/// <param name="jongchk">종목체크	String	Y	12	대상제외값(설정시	저장됨)	증거금50	:	0x00400000	증거금100	:	0x00800000	증거금50/100	:	0x00200000	관리종목	:	0x00000080	시장경보	:	0x00000100	거래정지	:	0x00000200	우선주	:	0x00004000	투자유의	:	0x04000000	정리매매	:	0x01000000	불성실공시	:	0x80000000</param>
/// <param name="idx">IDX	Number	Y	4	다음	조회시	사용	첫	조회시	Space</param>
/// <param name="yesprice">예상체결시작가격	Number	Y	8	yesprice	<=	예상체결가	인	종목</param>
/// <param name="yeeprice">예상체결종료가격	Number	Y	8	예상체결가	<=	yeeprice	인	종목</param>
/// <param name="yevolume">예상체결량	Number	Y	12	예상체결량	>=	yevolume	인	종목</param>
public record t1489InBlock(string gubun, string jgubun, string jongchk, int idx, int yesprice, int yeeprice, long yevolume);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1489OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">예상거래량	Number	Y	12</param>
/// <param name="offerho">매도호가	Number	Y	8</param>
/// <param name="bidho">매수호가	Number	Y	8</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
public record t1489OutBlock1(string hname, int price, string sign, int change, double diff, long volume, int offerho, int bidho, string shcode, long jnilvolume);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">구분	String	Y	1	0:	전체	1:	코스피	2:	코스닥</param>
/// <param name="gubun2">상승하락	String	Y	1	0:	상승률	1:	하락률</param>
/// <param name="jongchk">종목체크	String	Y	1	전체@0	우선제외@1	관리제외@2	우선관리제외@3</param>
/// <param name="volume">거래량	String	Y	1	전체거래량@0	1백주	이상@1	5백주	이상@2	1천주	이상@3	5천주	이상@4	1만주	이상@5	5만주	이상@6	50만주	이상@6	100만주	이상@7</param>
/// <param name="idx">IDX	Number	Y	4	연속조회시	OutBlock의	idx	입력</param>
public record t1492InBlock(string gubun1, string gubun2, string jongchk, string volume, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1492OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">예상체결가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="yevolume">예상체결량	Number	Y	12</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	12</param>
/// <param name="bidho1">매수호가	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="value">누적거래대금	Number	Y	12</param>
public record t1492OutBlock1(string hname, int price, string sign, int change, double diff, long yevolume, long volume, long offerrem1, long bidrem1, long offerho1, long bidho1, string shcode, long value);

#endregion

#region [주식] 차트

/// <summary>
/// 
/// </summary>
/// <param name="market">시장구분	String	Y	1	1@코스피	2@KP200	3@코스닥	4@선물	5@풋옵션	6@콜옵션</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="gubun2">수치구분(1:수치2:누적)	String	Y	1</param>
/// <param name="gubun3">단위구분(1:일2:주3:월)	String	Y	1</param>
/// <param name="from_date">시작날짜	String	Y	8</param>
/// <param name="to_date">종료날짜	String	Y	8</param>
public record t1665InBlock(string market, string upcode, string gubun2, string gubun3, string from_date, string to_date);

/// <summary>
/// 
/// </summary>
/// <param name="mcode">시장코드	String	Y	8</param>
/// <param name="mname">시장명	String	Y	20</param>
public record t1665OutBlock(string mcode, string mname);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="sv_08">개인수량	Number	Y	12</param>
/// <param name="sv_17">외인계수량(등록+미등록)	Number	Y	12</param>
/// <param name="sv_18">기관계수량	Number	Y	12</param>
/// <param name="sv_01">증권수량	Number	Y	12</param>
/// <param name="sv_03">투신수량	Number	Y	12</param>
/// <param name="sv_04">은행수량	Number	Y	12</param>
/// <param name="sv_02">보험수량	Number	Y	12</param>
/// <param name="sv_05">종금수량	Number	Y	12</param>
/// <param name="sv_06">기금수량	Number	Y	12</param>
/// <param name="sv_07">기타수량	Number	Y	12</param>
/// <param name="sv_00">사모펀드수량	Number	Y	12</param>
/// <param name="sv_09">등록외국인수량	Number	Y	12</param>
/// <param name="sv_10">미등록외국인수량	Number	Y	12</param>
/// <param name="sv_11">국가수량	Number	Y	12</param>
/// <param name="sv_99">기타계수량(기타+국가)	Number	Y	12</param>
/// <param name="sa_08">개인금액	Number	Y	12</param>
/// <param name="sa_17">외인계금액(등록+미등록)	Number	Y	12</param>
/// <param name="sa_18">기관계금액	Number	Y	12</param>
/// <param name="sa_01">증권금액	Number	Y	12</param>
/// <param name="sa_03">투신금액	Number	Y	12</param>
/// <param name="sa_04">은행금액	Number	Y	12</param>
/// <param name="sa_02">보험금액	Number	Y	12</param>
/// <param name="sa_05">종금금액	Number	Y	12</param>
/// <param name="sa_06">기금금액	Number	Y	12</param>
/// <param name="sa_07">기타금액	Number	Y	12</param>
/// <param name="sa_00">사모펀드금액	Number	Y	12</param>
/// <param name="sa_09">등록외국인금액	Number	Y	12</param>
/// <param name="sa_10">미등록외국인금액	Number	Y	12</param>
/// <param name="sa_11">국가금액	Number	Y	12</param>
/// <param name="sa_99">기타계금액(기타+국가)	Number	Y	12</param>
/// <param name="jisu">시장지수	Number	Y	7.2</param>
public record t1665OutBlock1(string date, long sv_08, long sv_17, long sv_18, long sv_01, long sv_03, long sv_04, long sv_02, long sv_05, long sv_06, long sv_07, long sv_00, long sv_09, long sv_10, long sv_11, long sv_99, long sa_08, long sa_17, long sa_18, long sa_01, long sa_03, long sa_04, long sa_02, long sa_05, long sa_06, long sa_07, long sa_00, long sa_09, long sa_10, long sa_11, long sa_99, double jisu);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gubun">주기구분(2:일3:주4:월5:년)	String	Y	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4</param>
/// <param name="sdate">시작일자	String	Y	8	조회구간종료일	Space:기본값</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1</param>
/// <param name="sujung">수정주가여부(Y:적용N:비적용)	String	Y	1</param>
public record t8410InBlock(string shcode, string gubun, int qrycnt, string sdate, string edate, string cts_date, string comp_yn, string sujung);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="jisiga">전일시가	Number	Y	8</param>
/// <param name="jihigh">전일고가	Number	Y	8</param>
/// <param name="jilow">전일저가	Number	Y	8</param>
/// <param name="jiclose">전일종가	Number	Y	8</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	8</param>
/// <param name="dihigh">당일고가	Number	Y	8</param>
/// <param name="dilow">당일저가	Number	Y	8</param>
/// <param name="diclose">당일종가	Number	Y	8</param>
/// <param name="highend">상한가	Number	Y	8</param>
/// <param name="lowend">하한가	Number	Y	8</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
/// <param name="svi_uplmtprice">정적VI상한가	Number	Y	8</param>
/// <param name="svi_dnlmtprice">정적VI하한가	Number	Y	8</param>
public record t8410OutBlock(string shcode, int jisiga, int jihigh, int jilow, int jiclose, long jivolume, int disiga, int dihigh, int dilow, int diclose, int highend, int lowend, string cts_date, string s_time, string e_time, string dshmin, int rec_count, int svi_uplmtprice, int svi_dnlmtprice);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	12</param>
/// <param name="high">고가	Number	Y	12</param>
/// <param name="low">저가	Number	Y	12</param>
/// <param name="close">종가	Number	Y	12</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="jongchk">수정구분	Number	Y	13</param>
/// <param name="rate">수정비율	Number	Y	6.2</param>
/// <param name="pricechk">수정주가반영항목	Number	Y	13</param>
/// <param name="ratevalue">수정비율반영거래대금	Number	Y	12</param>
/// <param name="sign">종가등락구분(1:상한2:상승3:보합4:하한5:하락주식일만사용)	String	Y	1</param>
public record t8410OutBlock1(string date, long open, long high, long low, long close, long jdiff_vol, long value, long jongchk, double rate, long pricechk, long ratevalue, string sign);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="ncnt">단위(n틱)	Number	Y	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1</param>
public record t8411InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="jisiga">전일시가	Number	Y	8</param>
/// <param name="jihigh">전일고가	Number	Y	8</param>
/// <param name="jilow">전일저가	Number	Y	8</param>
/// <param name="jiclose">전일종가	Number	Y	8</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	8</param>
/// <param name="dihigh">당일고가	Number	Y	8</param>
/// <param name="dilow">당일저가	Number	Y	8</param>
/// <param name="diclose">당일종가	Number	Y	8</param>
/// <param name="highend">상한가	Number	Y	8</param>
/// <param name="lowend">하한가	Number	Y	8</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8411OutBlock(string shcode, int jisiga, int jihigh, int jilow, int jiclose, long jivolume, int disiga, int dihigh, int dilow, int diclose, int highend, int lowend, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	10</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="jongchk">수정구분	Number	Y	13</param>
/// <param name="rate">수정비율	Number	Y	6.2</param>
/// <param name="pricechk">수정주가반영항목	Number	Y	13</param>
public record t8411OutBlock1(string date, string time, int open, int high, int low, int close, long jdiff_vol, long jongchk, double rate, long pricechk);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="ncnt">단위(n분)	Number	Y	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1</param>
public record t8412InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="jisiga">전일시가	Number	Y	8</param>
/// <param name="jihigh">전일고가	Number	Y	8</param>
/// <param name="jilow">전일저가	Number	Y	8</param>
/// <param name="jiclose">전일종가	Number	Y	8</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	8</param>
/// <param name="dihigh">당일고가	Number	Y	8</param>
/// <param name="dilow">당일저가	Number	Y	8</param>
/// <param name="diclose">당일종가	Number	Y	8</param>
/// <param name="highend">상한가	Number	Y	8</param>
/// <param name="lowend">하한가	Number	Y	8</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8412OutBlock(string shcode, int jisiga, int jihigh, int jilow, int jiclose, long jivolume, int disiga, int dihigh, int dilow, int diclose, int highend, int lowend, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	10</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="jongchk">수정구분	Number	Y	13</param>
/// <param name="rate">수정비율	Number	Y	6.2</param>
/// <param name="sign">종가등락구분(1:상한2:상승3:보합4:하한5:하락)	String	Y	1</param>
public record t8412OutBlock1(string date, string time, int open, int high, int low, int close, long jdiff_vol, long value, long jongchk, double rate, string sign);


#endregion

#region [주식] 기타

/// <summary>
/// 
/// </summary>
/// <param name="QryTp">조회구분	String	Y	1	0@전체,	1@가능,	2@불가능</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="SecTpCode">유가증권구분	String	Y	1	0@전체,	3@거래소,	4@코스닥,	1@주식(거래소+코스닥)</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	String	Y	2	00</param>
/// <param name="LoanTp">대출구분	String	Y	1	1@예탁증권담보융자,	3@융자,	4@유통대주,	5@자기대주</param>
public record CLNAQ00100InBlock1(string QryTp, string IsuNo, string SecTpCode, string LoanIntrstGrdCode, string LoanTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="SecTpCode">유가증권구분	String	Y	1</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	String	Y	2</param>
/// <param name="LoanTp">대출구분	String	Y	1</param>
public record CLNAQ00100OutBlock1(int RecCnt, string QryTp, string IsuNo, string SecTpCode, string LoanIntrstGrdCode, string LoanTp);

/// <summary>
/// 
/// </summary>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="Parprc">액면가	Number	Y	13.2</param>
/// <param name="PrdayCprc">전일종가	Number	Y	13.2</param>
/// <param name="RatVal">비율값	Number	Y	19.8</param>
/// <param name="SubstPrc">대용가	Number	Y	13.2</param>
/// <param name="RegTpNm">등록구분	String	Y	20</param>
/// <param name="SpotMgnLevyClssNm">현물증거금징수분류명	String	Y	40</param>
/// <param name="FnoTrdStopRsnCnts">거래정지사유	String	Y	40</param>
/// <param name="DgrsPtnNm">요주의유형명	String	Y	40</param>
/// <param name="AcdPtnNm">사고유형	String	Y	40</param>
/// <param name="MktTpNm">시장구분	String	Y	20</param>
/// <param name="LmtVal">한도값	Number	Y	18</param>
/// <param name="AcntLmtVal">계좌한도값	Number	Y	18</param>
/// <param name="LoanGrdCode">대출등급코드	String	Y	2</param>
/// <param name="LoanAmt">대출금액	Number	Y	16</param>
/// <param name="LoanAbleRat">대출가능율	Number	Y	26.9</param>
/// <param name="LoanIntrat1">대출이율1	Number	Y	14.4</param>
/// <param name="RegPsnId">등록자ID	String	Y	16</param>
/// <param name="Rat01">비율값	Number	Y	19.8</param>
/// <param name="Rat02">비율값	Number	Y	19.8</param>
public record CLNAQ00100OutBlock2(string IsuNo, string IsuNm, double Parprc, double PrdayCprc, double RatVal, double SubstPrc, string RegTpNm, string SpotMgnLevyClssNm, string FnoTrdStopRsnCnts, string DgrsPtnNm, string AcdPtnNm, string MktTpNm, long LmtVal, long AcntLmtVal, string LoanGrdCode, long LoanAmt, double LoanAbleRat, double LoanIntrat1, string RegPsnId, double Rat01, double Rat02);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="LrgMnyoutSumAmt">대출금합계금액	Number	Y	16</param>
public record CLNAQ00100OutBlock3(int RecCnt, long LrgMnyoutSumAmt);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	0:	전체,	1:코스피,	2:코스닥</param>
/// <param name="styymm">시작상장월	String	Y	6	YYYYMM</param>
/// <param name="enyymm">종료상장월	String	Y	6	YYYYMM</param>
/// <param name="idx">IDX	Number	Y	4	연속조회시	OutBlock의	동일필드	입력</param>
public record t1403InBlock(string gubun, string styymm, string enyymm, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1403OutBlock(int idx);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="kmprice">공모가	Number	Y	8</param>
/// <param name="date">등록일	String	Y	8</param>
/// <param name="recprice">등록일기준가	Number	Y	8</param>
/// <param name="kmdiff">기준가등락율	Number	Y	6.2</param>
/// <param name="close">등록일종가	Number	Y	8</param>
/// <param name="recdiff">등록일등락율	Number	Y	6.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1403OutBlock1(string hname, int price, string sign, int change, double diff, long volume, int kmprice, string date, int recprice, double kmdiff, int close, double recdiff, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">시장구분	String	Y	1	0:전체	1:코스피	2:코스닥</param>
/// <param name="jongchk">위탁신용구분	String	Y	1	1:위탁	2:신용</param>
/// <param name="jkrate">증거금율구분	String	Y	1	2:20%	3:30%	5:40%	1:100%</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="idx">IDX	Number	Y	4	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	idx	값으로	설정</param>
public record t1411InBlock(string gubun, string jongchk, string jkrate, string shcode, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="jkrate">위탁증거금율	Number	Y	3</param>
/// <param name="sjkrate">신용증거금율	Number	Y	3</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1411OutBlock(int jkrate, int sjkrate, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="jkrate">위탁증거금율	Number	Y	3</param>
/// <param name="sjkrate">신용증거금율	Number	Y	3</param>
/// <param name="subprice">대용가	Number	Y	8</param>
/// <param name="recprice">전일종가	Number	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
public record t1411OutBlock1(string shcode, string hname, int jkrate, int sjkrate, int subprice, int recprice, int price, string sign, int change, double diff, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="gubun1">구분	String	Y	1	1	:	코스피	2	:	코스닥</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun2">정렬	String	Y	1	1	:	시가총액비중	2	:	순매수잔량상위	3	:	순매수잔량하위	4	:	매수잔량	5	:	매수공시수량	6	:	매도잔량	7	:	매도공시수량</param>
public record t1638InBlock(string gubun1, string shcode, string gubun2);

/// <summary>
/// 
/// </summary>
/// <param name="rank">순위	Number	Y	4</param>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="sigatotrt">시총비중	Number	Y	6.2</param>
/// <param name="obuyvol">순매수잔량	Number	Y	12</param>
/// <param name="buyrem">매수잔량	Number	Y	12</param>
/// <param name="psgvolume">매수공시수량	Number	Y	12</param>
/// <param name="sellrem">매도잔량	Number	Y	12</param>
/// <param name="pdgvolume">매도공시수량	Number	Y	12</param>
/// <param name="sigatot">시가총액	Number	Y	20</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1638OutBlock(int rank, string hname, int price, string sign, int change, double diff, double sigatotrt, long obuyvol, long buyrem, long psgvolume, long sellrem, long pdgvolume, long sigatot, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="gubun">융자대주구분	String	Y	1	1:융자	2:대주</param>
/// <param name="date">날짜	String	Y	8	다음	조회시	사용	OutBlock의	date	필드를	입력함.</param>
/// <param name="idx">IDX	Number	Y	4	사용안함</param>
public record t1921InBlock(string shcode, string gubun, string date, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="cnt">CNT	Number	Y	4</param>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="idx">IDX	Number	Y	4</param>
public record t1921OutBlock(int cnt, string date, int idx);

/// <summary>
/// 
/// </summary>
/// <param name="mmdate">날짜	String	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="jchange">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="nvolume">신규	Number	Y	8</param>
/// <param name="svolume">상환	Number	Y	8</param>
/// <param name="jvolume">잔고	Number	Y	8</param>
/// <param name="price">금액	Number	Y	8</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="gyrate">공여율	Number	Y	6.2</param>
/// <param name="jkrate">잔고율	Number	Y	6.2</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1921OutBlock1(string mmdate, int close, string sign, int jchange, double diff, int nvolume, int svolume, int jvolume, int price, int change, double gyrate, double jkrate, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
public record t1926InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="ynvolume">융자신규수량	Number	Y	8</param>
/// <param name="ysvolume">융자상환수량	Number	Y	8</param>
/// <param name="yjvolume">융자잔고수량	Number	Y	8</param>
/// <param name="yvchange">융자수량대비	Number	Y	8</param>
/// <param name="ygrate">융자공여율	Number	Y	9.2</param>
/// <param name="yjrate">융자잔고율	Number	Y	9.2</param>
/// <param name="ynprice">융자신규금액	Number	Y	8</param>
/// <param name="ysprice">융자상환금액	Number	Y	8</param>
/// <param name="yjprice">융자잔고금액	Number	Y	8</param>
/// <param name="yachange">융자금액대비	Number	Y	8</param>
/// <param name="dnvolume">대주신규수량	Number	Y	8</param>
/// <param name="dsvolume">대주상환수량	Number	Y	8</param>
/// <param name="djvolume">대주잔고수량	Number	Y	8</param>
/// <param name="dvchange">대주수량대비	Number	Y	8</param>
/// <param name="dgrate">대주공여율	Number	Y	9.2</param>
/// <param name="djrate">대주잔고율	Number	Y	9.2</param>
/// <param name="dnprice">대주신규금액	Number	Y	8</param>
/// <param name="dsprice">대주상환금액	Number	Y	8</param>
/// <param name="djprice">대주잔고금액	Number	Y	8</param>
/// <param name="dachange">대주금액대비	Number	Y	8</param>
/// <param name="mmdate">결제일	String	Y	8</param>
/// <param name="close">결제일종가	Number	Y	8</param>
/// <param name="volume">결제일거래량	Number	Y	10</param>
/// <param name="value">결제일거래대금	Number	Y	12</param>
/// <param name="pr5days">주가5일증가율	Number	Y	9.2</param>
/// <param name="pr20days">주가20일증가율	Number	Y	9.2</param>
/// <param name="yj5days">융자5일증가율	Number	Y	9.2</param>
/// <param name="yj20days">융자20일증가율	Number	Y	9.2</param>
/// <param name="dj5days">대주5일증가율	Number	Y	9.2</param>
/// <param name="dj20days">대주20일증가율	Number	Y	9.2</param>
public record t1926OutBlock(int ynvolume, int ysvolume, int yjvolume, int yvchange, double ygrate, double yjrate, int ynprice, int ysprice, int yjprice, int yachange, int dnvolume, int dsvolume, int djvolume, int dvchange, double dgrate, double djrate, int dnprice, int dsprice, int djprice, int dachange, string mmdate, int close, long volume, long value, double pr5days, double pr20days, double yj5days, double yj20days, double dj5days, double dj20days);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="date">일자	String	Y	8	다음	조회시	사용.	OutBlock의	date	필드	값을	입력함.</param>
/// <param name="sdate">시작일자	String	Y	8</param>
/// <param name="edate">종료일자	String	Y	8</param>
public record t1927InBlock(string shcode, string date, string sdate, string edate);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자CTS	String	Y	8</param>
public record t1927OutBlock(string date);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="gm_vo">공매도수량	Number	Y	12</param>
/// <param name="gm_va">공매도대금	Number	Y	12</param>
/// <param name="gm_per">공매도거래비중	Number	Y	6.2</param>
/// <param name="gm_avg">평균공매도단가	Number	Y	12</param>
/// <param name="gm_vo_sum">누적공매도수량	Number	Y	12</param>
/// <param name="gm_vo1">업틱룰적용공매도수량	Number	Y	12</param>
/// <param name="gm_va1">업틱룰적용공매도대금	Number	Y	12</param>
/// <param name="gm_vo2">업틱룰예외공매도수량	Number	Y	12</param>
/// <param name="gm_va2">업틱룰예외공매도대금	Number	Y	12</param>
public record t1927OutBlock1(string date, int price, string sign, int change, double diff, long volume, long value, long gm_vo, long gm_va, double gm_per, long gm_avg, long gm_vo_sum, long gm_vo1, long gm_va1, long gm_vo2, long gm_va2);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="sdate">시작일자	String	Y	8</param>
/// <param name="edate">종료일자	String	Y	8</param>
public record t1941InBlock(string shcode, string sdate, string edate);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="price">종가	Number	Y	8</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="upvolume">당일체결	Number	Y	12</param>
/// <param name="dnvolume">당일상환	Number	Y	12</param>
/// <param name="tovolume">당일잔고	Number	Y	12</param>
/// <param name="tovalue">잔고금액	Number	Y	12</param>
/// <param name="shcode">종목코드	String	Y	6</param>
/// <param name="tovoldif">대차증감	Number	Y	12</param>
public record t1941OutBlock1(string date, int price, string sign, int change, double diff, long volume, long upvolume, long dnvolume, long tovolume, long tovalue, string shcode, long tovoldif);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	String	Y	1</param>
public record t8430InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="etfgubun">ETF구분(1:ETF)	String	Y	1</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="jnilclose">전일가	Number	Y	8</param>
/// <param name="memedan">주문수량단위	String	Y	5</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="gubun">구분(1:코스피2:코스닥)	String	Y	1</param>
public record t8430OutBlock(string hname, string shcode, string expcode, string etfgubun, int uplmtprice, int dnlmtprice, int jnilclose, string memedan, int recprice, string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	String	Y	1</param>
public record t8436InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="etfgubun">ETF구분(1:ETF2:ETN)	String	Y	1</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="jnilclose">전일가	Number	Y	8</param>
/// <param name="memedan">주문수량단위	String	Y	5</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="gubun">구분(1:코스피2:코스닥)	String	Y	1</param>
/// <param name="bu12gubun">증권그룹	String	Y	2</param>
/// <param name="spac_gubun">기업인수목적회사여부(Y/N)	String	Y	1</param>
/// <param name="filler">filler(미사용)	String	Y	32</param>
public record t8436OutBlock(string hname, string shcode, string expcode, string etfgubun, int uplmtprice, int dnlmtprice, int jnilclose, string memedan, int recprice, string gubun, string bu12gubun, string spac_gubun, string filler);

#endregion

#region [주식] 계좌

/// <summary>
/// 
/// </summary>
/// <param name="QryTp">조회구분	String	Y	1	0@전체,	1@입출금,	2@입출고,	3@매매,	4@환전,	9@기타</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="SrtNo">시작번호	Number	Y	10</param>
/// <param name="PdptnCode">상품유형코드	String	Y	2	01</param>
/// <param name="IsuLgclssCode">종목대분류코드	String	Y	2	00@전체,	01@주식,	02@채권,	04@펀드,	03@선물,	05@해외주식,	06@해외파생</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
public record CDPCQ04700InBlock1(string QryTp, string QrySrtDt, string QryEndDt, long SrtNo, string PdptnCode, string IsuLgclssCode, string IsuNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="SrtNo">시작번호	Number	Y	10</param>
/// <param name="PdptnCode">상품유형코드	String	Y	2</param>
/// <param name="IsuLgclssCode">종목대분류코드	String	Y	2</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
public record CDPCQ04700OutBlock1(int RecCnt, string QryTp, string AcntNo, string Pwd, string QrySrtDt, string QryEndDt, long SrtNo, string PdptnCode, string IsuLgclssCode, string IsuNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
public record CDPCQ04700OutBlock2(int RecCnt, string AcntNm);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
/// <param name="TrdNo">거래번호	Number	Y	10</param>
/// <param name="TpCodeNm">구분코드명	String	Y	50</param>
/// <param name="SmryNo">적요번호	String	Y	4</param>
/// <param name="SmryNm">적요명	String	Y	40</param>
/// <param name="CancTpNm">취소구분	String	Y	20</param>
/// <param name="TrdQty">거래수량	Number	Y	16</param>
/// <param name="Trtax">거래세	Number	Y	16</param>
/// <param name="FcurrAdjstAmt">외화정산금액	Number	Y	25.4</param>
/// <param name="AdjstAmt">정산금액	Number	Y	16</param>
/// <param name="OvdSum">연체합	Number	Y	16</param>
/// <param name="DpsBfbalAmt">예수금전잔금액	Number	Y	16</param>
/// <param name="SellPldgRfundAmt">매도담보상환금	Number	Y	16</param>
/// <param name="DpspdgLoanBfbalAmt">예탁담보대출전잔금액	Number	Y	16</param>
/// <param name="TrdmdaNm">거래매체명	String	Y	40</param>
/// <param name="OrgTrdNo">원거래번호	Number	Y	10</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="TrdUprc">거래단가	Number	Y	13.2</param>
/// <param name="CmsnAmt">수수료	Number	Y	16</param>
/// <param name="FcurrCmsnAmt">외화수수료금액	Number	Y	15.2</param>
/// <param name="RfundDiffAmt">상환차이금액	Number	Y	16</param>
/// <param name="RepayAmtSum">변제금합계	Number	Y	16</param>
/// <param name="SecCrbalQty">유가증권금잔수량	Number	Y	16</param>
/// <param name="CslLoanRfundIntrstAmt">매도대금담보대출상환이자금액	Number	Y	16</param>
/// <param name="DpspdgLoanCrbalAmt">예탁담보대출금잔금액	Number	Y	16</param>
/// <param name="TrxTime">처리시각	String	Y	9</param>
/// <param name="Inouno">출납번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="TrdAmt">거래금액	Number	Y	16</param>
/// <param name="ChckAmt">수표금액	Number	Y	16</param>
/// <param name="TaxSumAmt">세금합계금액	Number	Y	16</param>
/// <param name="FcurrTaxSumAmt">외화세금합계금액	Number	Y	26.6</param>
/// <param name="IntrstUtlfee">이자이용료	Number	Y	16</param>
/// <param name="MnyDvdAmt">배당금액	Number	Y	16</param>
/// <param name="RcvblOcrAmt">미수발생금액	Number	Y	16</param>
/// <param name="TrxBrnNo">처리지점번호	String	Y	3</param>
/// <param name="TrxBrnNm">처리지점명	String	Y	40</param>
/// <param name="DpspdgLoanAmt">예탁담보대출금액	Number	Y	16</param>
/// <param name="DpspdgLoanRfundAmt">예탁담보대출상환금액	Number	Y	16</param>
/// <param name="BasePrc">기준가	Number	Y	13.2</param>
/// <param name="DpsCrbalAmt">예수금금잔금액	Number	Y	16</param>
/// <param name="BoaAmt">과표	Number	Y	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	Number	Y	16</param>
/// <param name="BcrLoanOcrAmt">수익증권담보대출발생금	Number	Y	16</param>
/// <param name="BcrLoanBfbalAmt">수익증권담보대출전잔금	Number	Y	16</param>
/// <param name="BnsBasePrc">매매기준가	Number	Y	20.1</param>
/// <param name="TaxchrBasePrc">과세기준가	Number	Y	20.1</param>
/// <param name="TrdUnit">거래좌수	Number	Y	16</param>
/// <param name="BalUnit">잔고좌수	Number	Y	16</param>
/// <param name="EvrTax">제세금	Number	Y	16</param>
/// <param name="EvalAmt">평가금액	Number	Y	16</param>
/// <param name="BcrLoanRfundAmt">수익증권담보대출상환금	Number	Y	16</param>
/// <param name="BcrLoanCrbalAmt">수익증권담보대출금잔금	Number	Y	16</param>
/// <param name="AddMgnOcrTotamt">추가증거금발생총액	Number	Y	16</param>
/// <param name="AddMnyMgnOcrAmt">추가현금증거금발생금액	Number	Y	16</param>
/// <param name="AddMgnDfryTotamt">추가증거금납부총액	Number	Y	16</param>
/// <param name="AddMnyMgnDfryAmt">추가현금증거금납부금액	Number	Y	16</param>
/// <param name="BnsplAmt">매매손익금액	Number	Y	16</param>
/// <param name="Ictax">소득세	Number	Y	16</param>
/// <param name="Ihtax">주민세	Number	Y	16</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="CrcyCode">통화코드	String	Y	3</param>
/// <param name="FcurrAmt">외화금액	Number	Y	24.4</param>
/// <param name="FcurrTrdAmt">외화거래금액	Number	Y	24.4</param>
/// <param name="FcurrDps">외화예수금	Number	Y	21.4</param>
/// <param name="FcurrDpsBfbalAmt">외화예수금전잔금액	Number	Y	21.4</param>
/// <param name="OppAcntNm">상대계좌명	String	Y	40</param>
/// <param name="OppAcntNo">상대계좌번호	String	Y	20</param>
/// <param name="LoanRfundAmt">대출상환금액	Number	Y	16</param>
/// <param name="LoanIntrstAmt">대출이자금액	Number	Y	16</param>
/// <param name="AskpsnNm">의뢰인명	String	Y	40</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="TrdXchrat">거래환율	Number	Y	15.4</param>
/// <param name="RdctCmsn">감면수수료	Number	Y	21.4</param>
/// <param name="FcurrStmpTx">외화인지세	Number	Y	21.4</param>
/// <param name="FcurrElecfnTrtax">외화전자금융거래세	Number	Y	21.4</param>
/// <param name="FcstckTrtax">외화증권거래세	Number	Y	21.4</param>
public record CDPCQ04700OutBlock3(string AcntNo, string TrdDt, long TrdNo, string TpCodeNm, string SmryNo, string SmryNm, string CancTpNm, long TrdQty, long Trtax, double FcurrAdjstAmt, long AdjstAmt, long OvdSum, long DpsBfbalAmt, long SellPldgRfundAmt, long DpspdgLoanBfbalAmt, string TrdmdaNm, long OrgTrdNo, string IsuNm, double TrdUprc, long CmsnAmt, double FcurrCmsnAmt, long RfundDiffAmt, long RepayAmtSum, long SecCrbalQty, long CslLoanRfundIntrstAmt, long DpspdgLoanCrbalAmt, string TrxTime, long Inouno, string IsuNo, long TrdAmt, long ChckAmt, long TaxSumAmt, double FcurrTaxSumAmt, long IntrstUtlfee, long MnyDvdAmt, long RcvblOcrAmt, string TrxBrnNo, string TrxBrnNm, long DpspdgLoanAmt, long DpspdgLoanRfundAmt, double BasePrc, long DpsCrbalAmt, long BoaAmt, long MnyoutAbleAmt, long BcrLoanOcrAmt, long BcrLoanBfbalAmt, double BnsBasePrc, double TaxchrBasePrc, long TrdUnit, long BalUnit, long EvrTax, long EvalAmt, long BcrLoanRfundAmt, long BcrLoanCrbalAmt, long AddMgnOcrTotamt, long AddMnyMgnOcrAmt, long AddMgnDfryTotamt, long AddMnyMgnDfryAmt, long BnsplAmt, long Ictax, long Ihtax, string LoanDt, string CrcyCode, double FcurrAmt, double FcurrTrdAmt, double FcurrDps, double FcurrDpsBfbalAmt, string OppAcntNm, string OppAcntNo, long LoanRfundAmt, long LoanIntrstAmt, string AskpsnNm, string OrdDt, double TrdXchrat, double RdctCmsn, double FcurrStmpTx, double FcurrElecfnTrtax, double FcstckTrtax);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="PnlSumAmt">손익합계금액	Number	Y	16</param>
/// <param name="CtrctAsm">약정누계	Number	Y	16</param>
/// <param name="CmsnAmtSumAmt">수수료합계금액	Number	Y	16</param>
public record CDPCQ04700OutBlock4(int RecCnt, long PnlSumAmt, long CtrctAsm, long CmsnAmtSumAmt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="MnyinAmt">입금금액	Number	Y	16</param>
/// <param name="SecinAmt">입고금액	Number	Y	16</param>
/// <param name="MnyoutAmt">출금금액	Number	Y	16</param>
/// <param name="SecoutAmt">출고금액	Number	Y	16</param>
/// <param name="DiffAmt">차이금액	Number	Y	16</param>
/// <param name="DiffAmt0">차이금액0	Number	Y	16</param>
/// <param name="SellQty">매도수량	Number	Y	16</param>
/// <param name="SellAmt">매도금액	Number	Y	16</param>
/// <param name="SellCmsn">매도수수료	Number	Y	16</param>
/// <param name="EvrTax">제세금	Number	Y	19</param>
/// <param name="FcurrSellAdjstAmt">외화매도정산금액	Number	Y	25.4</param>
/// <param name="BuyQty">매수수량	Number	Y	16</param>
/// <param name="BuyAmt">매수금액	Number	Y	16</param>
/// <param name="BuyCmsn">매수수수료	Number	Y	16</param>
/// <param name="ExecTax">체결세금	Number	Y	16</param>
/// <param name="FcurrBuyAdjstAmt">외화매수정산금액	Number	Y	25.4</param>
public record CDPCQ04700OutBlock5(int RecCnt, long MnyinAmt, long SecinAmt, long MnyoutAmt, long SecoutAmt, long DiffAmt, long DiffAmt0, long SellQty, long SellAmt, long SellCmsn, long EvrTax, double FcurrSellAdjstAmt, long BuyQty, long BuyAmt, long BuyCmsn, long ExecTax, double FcurrBuyAdjstAmt);

/// <summary>
/// 
/// </summary>
/// <param name="LoanDtlClssCode">대출상세분류코드	String	Y	2	01@유통융자,	03@자기융자,	05@유통대주,	07@자기대주</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2	41@xingAPI</param>
public record CSPAQ00600InBlock1(string LoanDtlClssCode, string IsuNo, double OrdPrc, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	String	Y	2</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
public record CSPAQ00600OutBlock1(int RecCnt, string AcntNo, string InptPwd, string LoanDtlClssCode, string IsuNo, double OrdPrc, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="SloanLmtAmt">대주한도	Number	Y	16</param>
/// <param name="SloanAmtSum">대주금액합계	Number	Y	16</param>
/// <param name="SloanNewAmt">대주신규금액	Number	Y	16</param>
/// <param name="SloanRfundAmt">대주상환금액	Number	Y	16</param>
/// <param name="MktcplMloanLmtAmt">유통융자한도금액	Number	Y	16</param>
/// <param name="MktcplMloanAmtSum">유통융자금액합계	Number	Y	16</param>
/// <param name="MktcplMloanNewAmt">유통융자신규금액	Number	Y	16</param>
/// <param name="MktcplMloanRfundAmt">유통융자상환금액	Number	Y	16</param>
/// <param name="SfaccMloanLmtAmt">자기융자한도금액	Number	Y	16</param>
/// <param name="SfaccMloanAmtSum">자기융자금액합계	Number	Y	16</param>
/// <param name="SfaccMloanNewAmt">자기융자신규금액	Number	Y	16</param>
/// <param name="SfaccMloanRfundAmt">자기융자상환금액	Number	Y	16</param>
/// <param name="BrnMktcplMloanLmtAmt">지점유통융자한도금액	Number	Y	16</param>
/// <param name="BrnMktcplMloanNewAmt">지점유통융자신규금액	Number	Y	16</param>
/// <param name="BrnMktcplMloanRfundAmt">지점유통융자상환금액	Number	Y	16</param>
/// <param name="BrnMktcplMloanUseAmt">지점유통융자사용금액	Number	Y	16</param>
/// <param name="BrnSfaccMloanLmtAmt">지점자기융자한도금액	Number	Y	16</param>
/// <param name="BrnSfaccMloanNewAmt">지점자기융자신규금액	Number	Y	16</param>
/// <param name="BrnSfaccMloanRfundAmt">지점자기융자상환금액	Number	Y	16</param>
/// <param name="BrnSfaccMloanUseAmt">지점자기융자사용금액	Number	Y	16</param>
/// <param name="FirmMloanLmtMgmtYn">이용사융자한도관리여부	String	Y	1</param>
/// <param name="FirmCrdtIsuRestrcTp">이용사신용종목제한구분	String	Y	1</param>
/// <param name="PldgMaintRat">담보유지비율	Number	Y	7.4</param>
/// <param name="FirmNm">이용사명	String	Y	50</param>
/// <param name="PldgRat">담보비율	Number	Y	7.4</param>
/// <param name="DpsastSum">예탁자산합계	Number	Y	17</param>
/// <param name="LmtChgAbleAmt">한도변경가능금액	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
/// <param name="RcvblUablOrdAbleQty">미수불가주문가능수량	Number	Y	16</param>
public record CSPAQ00600OutBlock2(int RecCnt, string AcntNm, double OrdPrc, long SloanLmtAmt, long SloanAmtSum, long SloanNewAmt, long SloanRfundAmt, long MktcplMloanLmtAmt, long MktcplMloanAmtSum, long MktcplMloanNewAmt, long MktcplMloanRfundAmt, long SfaccMloanLmtAmt, long SfaccMloanAmtSum, long SfaccMloanNewAmt, long SfaccMloanRfundAmt, long BrnMktcplMloanLmtAmt, long BrnMktcplMloanNewAmt, long BrnMktcplMloanRfundAmt, long BrnMktcplMloanUseAmt, long BrnSfaccMloanLmtAmt, long BrnSfaccMloanNewAmt, long BrnSfaccMloanRfundAmt, long BrnSfaccMloanUseAmt, string FirmMloanLmtMgmtYn, string FirmCrdtIsuRestrcTp, double PldgMaintRat, string FirmNm, double PldgRat, long DpsastSum, long LmtChgAbleAmt, long OrdAbleAmt, long OrdAbleQty, long RcvblUablOrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="BalCreTp">잔고생성구분	String	Y	1	0</param>
public record CSPAQ12200InBlock1(string BalCreTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="MgmtBrnNo">관리지점번호	String	Y	3</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="BalCreTp">잔고생성구분	String	Y	1</param>
public record CSPAQ12200OutBlock1(int RecCnt, string MgmtBrnNo, string AcntNo, string Pwd, string BalCreTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	Number	Y	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	Number	Y	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	Number	Y	16</param>
/// <param name="BalEvalAmt">잔고평가금액	Number	Y	16</param>
/// <param name="RcvblAmt">미수금액	Number	Y	16</param>
/// <param name="DpsastTotamt">예탁자산총액	Number	Y	16</param>
/// <param name="PnlRat">손익율	Number	Y	18.6</param>
/// <param name="InvstOrgAmt">투자원금	Number	Y	20</param>
/// <param name="InvstPlAmt">투자손익금액	Number	Y	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	Number	Y	16</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="SubstAmt">대용금액	Number	Y	16</param>
/// <param name="D1Dps">D1예수금	Number	Y	16</param>
/// <param name="D2Dps">D2예수금	Number	Y	16</param>
/// <param name="MnyrclAmt">현금미수금액	Number	Y	16</param>
/// <param name="MgnMny">증거금현금	Number	Y	16</param>
/// <param name="MgnSubst">증거금대용	Number	Y	16</param>
/// <param name="ChckAmt">수표금액	Number	Y	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	Number	Y	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat35ordAbleAmt">증거금률35%주문가능금액	Number	Y	16</param>
/// <param name="MgnRat50ordAbleAmt">증거금률50%주문가능금액	Number	Y	16</param>
/// <param name="PrdaySellAdjstAmt">전일매도정산금액	Number	Y	16</param>
/// <param name="PrdayBuyAdjstAmt">전일매수정산금액	Number	Y	16</param>
/// <param name="CrdaySellAdjstAmt">금일매도정산금액	Number	Y	16</param>
/// <param name="CrdayBuyAdjstAmt">금일매수정산금액	Number	Y	16</param>
/// <param name="D1ovdRepayRqrdAmt">D1연체변제소요금액	Number	Y	16</param>
/// <param name="D2ovdRepayRqrdAmt">D2연체변제소요금액	Number	Y	16</param>
/// <param name="D1PrsmptWthdwAbleAmt">D1추정인출가능금액	Number	Y	16</param>
/// <param name="D2PrsmptWthdwAbleAmt">D2추정인출가능금액	Number	Y	16</param>
/// <param name="DpspdgLoanAmt">예탁담보대출금액	Number	Y	16</param>
/// <param name="Imreq">신용설정보증금	Number	Y	16</param>
/// <param name="MloanAmt">융자금액	Number	Y	16</param>
/// <param name="ChgAfPldgRat">변경후담보비율	Number	Y	9.3</param>
/// <param name="OrgPldgAmt">원담보금액	Number	Y	16</param>
/// <param name="SubPldgAmt">부담보금액	Number	Y	16</param>
/// <param name="RqrdPldgAmt">소요담보금액	Number	Y	16</param>
/// <param name="OrgPdlckAmt">원담보부족금액	Number	Y	16</param>
/// <param name="PdlckAmt">담보부족금액	Number	Y	16</param>
/// <param name="AddPldgMny">추가담보현금	Number	Y	16</param>
/// <param name="D1OrdAbleAmt">D1주문가능금액	Number	Y	16</param>
/// <param name="CrdtIntdltAmt">신용이자미납금액	Number	Y	16</param>
/// <param name="EtclndAmt">기타대여금액	Number	Y	16</param>
/// <param name="NtdayPrsmptCvrgAmt">익일추정반대매매금액	Number	Y	16</param>
/// <param name="OrgPldgSumAmt">원담보합계금액	Number	Y	16</param>
/// <param name="CrdtOrdAbleAmt">신용주문가능금액	Number	Y	16</param>
/// <param name="SubPldgSumAmt">부담보합계금액	Number	Y	16</param>
/// <param name="CrdtPldgAmtMny">신용담보금현금	Number	Y	16</param>
/// <param name="CrdtPldgSubstAmt">신용담보대용금액	Number	Y	16</param>
/// <param name="AddCrdtPldgMny">추가신용담보현금	Number	Y	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	Number	Y	16</param>
/// <param name="AddCrdtPldgSubst">추가신용담보대용	Number	Y	16</param>
/// <param name="CslLoanAmtdt1">매도대금담보대출금액	Number	Y	16</param>
/// <param name="DpslRestrcAmt">처분제한금액	Number	Y	16</param>
public record CSPAQ12200OutBlock2(int RecCnt, string BrnNm, string AcntNm, long MnyOrdAbleAmt, long MnyoutAbleAmt, long SeOrdAbleAmt, long KdqOrdAbleAmt, long BalEvalAmt, long RcvblAmt, long DpsastTotamt, double PnlRat, long InvstOrgAmt, long InvstPlAmt, long CrdtPldgOrdAmt, long Dps, long SubstAmt, long D1Dps, long D2Dps, long MnyrclAmt, long MgnMny, long MgnSubst, long ChckAmt, long SubstOrdAbleAmt, long MgnRat100pctOrdAbleAmt, long MgnRat35ordAbleAmt, long MgnRat50ordAbleAmt, long PrdaySellAdjstAmt, long PrdayBuyAdjstAmt, long CrdaySellAdjstAmt, long CrdayBuyAdjstAmt, long D1ovdRepayRqrdAmt, long D2ovdRepayRqrdAmt, long D1PrsmptWthdwAbleAmt, long D2PrsmptWthdwAbleAmt, long DpspdgLoanAmt, long Imreq, long MloanAmt, double ChgAfPldgRat, long OrgPldgAmt, long SubPldgAmt, long RqrdPldgAmt, long OrgPdlckAmt, long PdlckAmt, long AddPldgMny, long D1OrdAbleAmt, long CrdtIntdltAmt, long EtclndAmt, long NtdayPrsmptCvrgAmt, long OrgPldgSumAmt, long CrdtOrdAbleAmt, long SubPldgSumAmt, long CrdtPldgAmtMny, long CrdtPldgSubstAmt, long AddCrdtPldgMny, long CrdtPldgRuseAmt, long AddCrdtPldgSubst, long CslLoanAmtdt1, long DpslRestrcAmt);

/// <summary>
/// 
/// </summary>
/// <param name="BalCreTp">잔고생성구분	String	Y	1	0:전체	1:현물	9:선물대용</param>
/// <param name="CmsnAppTpCode">수수료적용구분	String	Y	1	0:평가시	수수료	미적용	1:평가시	수수료	적용</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	String	Y	1	0:전부조회	1:D2잔고	0이상만	조회</param>
/// <param name="UprcTpCode">단가구분	String	Y	1	0:평균단가	1:BEP단가</param>
public record CSPAQ12300InBlock1(string BalCreTp, string CmsnAppTpCode, string D2balBaseQryTp, string UprcTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="BalCreTp">잔고생성구분	String	Y	1</param>
/// <param name="CmsnAppTpCode">수수료적용구분	String	Y	1</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	String	Y	1</param>
/// <param name="UprcTpCode">단가구분	String	Y	1</param>
public record CSPAQ12300OutBlock1(int RecCnt, string AcntNo, string Pwd, string BalCreTp, string CmsnAppTpCode, string D2balBaseQryTp, string UprcTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	Number	Y	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	Number	Y	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	Number	Y	16</param>
/// <param name="HtsOrdAbleAmt">HTS주문가능금액	Number	Y	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	Number	Y	16</param>
/// <param name="BalEvalAmt">잔고평가금액	Number	Y	16</param>
/// <param name="PchsAmt">매입금액	Number	Y	16</param>
/// <param name="RcvblAmt">미수금액	Number	Y	16</param>
/// <param name="PnlRat">손익율	Number	Y	18.6</param>
/// <param name="InvstOrgAmt">투자원금	Number	Y	20</param>
/// <param name="InvstPlAmt">투자손익금액	Number	Y	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	Number	Y	16</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="D1Dps">D1예수금	Number	Y	16</param>
/// <param name="D2Dps">D2예수금	Number	Y	16</param>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="MnyMgn">현금증거금액	Number	Y	16</param>
/// <param name="SubstMgn">대용증거금액	Number	Y	16</param>
/// <param name="SubstAmt">대용금액	Number	Y	16</param>
/// <param name="PrdayBuyExecAmt">전일매수체결금액	Number	Y	16</param>
/// <param name="PrdaySellExecAmt">전일매도체결금액	Number	Y	16</param>
/// <param name="CrdayBuyExecAmt">금일매수체결금액	Number	Y	16</param>
/// <param name="CrdaySellExecAmt">금일매도체결금액	Number	Y	16</param>
/// <param name="EvalPnlSum">평가손익합계	Number	Y	15</param>
/// <param name="DpsastTotamt">예탁자산총액	Number	Y	16</param>
/// <param name="Evrprc">제비용	Number	Y	19</param>
/// <param name="RuseAmt">재사용금액	Number	Y	16</param>
/// <param name="EtclndAmt">기타대여금액	Number	Y	16</param>
/// <param name="PrcAdjstAmt">가정산금액	Number	Y	16</param>
/// <param name="D1CmsnAmt">D1수수료	Number	Y	16</param>
/// <param name="D2CmsnAmt">D2수수료	Number	Y	16</param>
/// <param name="D1EvrTax">D1제세금	Number	Y	16</param>
/// <param name="D2EvrTax">D2제세금	Number	Y	16</param>
/// <param name="D1SettPrergAmt">D1결제예정금액	Number	Y	16</param>
/// <param name="D2SettPrergAmt">D2결제예정금액	Number	Y	16</param>
/// <param name="PrdayKseMnyMgn">전일KSE현금증거금	Number	Y	16</param>
/// <param name="PrdayKseSubstMgn">전일KSE대용증거금	Number	Y	16</param>
/// <param name="PrdayKseCrdtMnyMgn">전일KSE신용현금증거금	Number	Y	16</param>
/// <param name="PrdayKseCrdtSubstMgn">전일KSE신용대용증거금	Number	Y	16</param>
/// <param name="CrdayKseMnyMgn">금일KSE현금증거금	Number	Y	16</param>
/// <param name="CrdayKseSubstMgn">금일KSE대용증거금	Number	Y	16</param>
/// <param name="CrdayKseCrdtMnyMgn">금일KSE신용현금증거금	Number	Y	16</param>
/// <param name="CrdayKseCrdtSubstMgn">금일KSE신용대용증거금	Number	Y	16</param>
/// <param name="PrdayKdqMnyMgn">전일코스닥현금증거금	Number	Y	16</param>
/// <param name="PrdayKdqSubstMgn">전일코스닥대용증거금	Number	Y	16</param>
/// <param name="PrdayKdqCrdtMnyMgn">전일코스닥신용현금증거금	Number	Y	16</param>
/// <param name="PrdayKdqCrdtSubstMgn">전일코스닥신용대용증거금	Number	Y	16</param>
/// <param name="CrdayKdqMnyMgn">금일코스닥현금증거금	Number	Y	16</param>
/// <param name="CrdayKdqSubstMgn">금일코스닥대용증거금	Number	Y	16</param>
/// <param name="CrdayKdqCrdtMnyMgn">금일코스닥신용현금증거금	Number	Y	16</param>
/// <param name="CrdayKdqCrdtSubstMgn">금일코스닥신용대용증거금	Number	Y	16</param>
/// <param name="PrdayFrbrdMnyMgn">전일프리보드현금증거금	Number	Y	16</param>
/// <param name="PrdayFrbrdSubstMgn">전일프리보드대용증거금	Number	Y	16</param>
/// <param name="CrdayFrbrdMnyMgn">금일프리보드현금증거금	Number	Y	16</param>
/// <param name="CrdayFrbrdSubstMgn">금일프리보드대용증거금	Number	Y	16</param>
/// <param name="PrdayCrbmkMnyMgn">전일장외현금증거금	Number	Y	16</param>
/// <param name="PrdayCrbmkSubstMgn">전일장외대용증거금	Number	Y	16</param>
/// <param name="CrdayCrbmkMnyMgn">금일장외현금증거금	Number	Y	16</param>
/// <param name="CrdayCrbmkSubstMgn">금일장외대용증거금	Number	Y	16</param>
/// <param name="DpspdgQty">예탁담보수량	Number	Y	16</param>
/// <param name="BuyAdjstAmtD2">매수정산금(D+2)	Number	Y	16</param>
/// <param name="SellAdjstAmtD2">매도정산금(D+2)	Number	Y	16</param>
/// <param name="RepayRqrdAmtD1">변제소요금(D+1)	Number	Y	16</param>
/// <param name="RepayRqrdAmtD2">변제소요금(D+2)	Number	Y	16</param>
/// <param name="LoanAmt">대출금액	Number	Y	16</param>
public record CSPAQ12300OutBlock2(int RecCnt, string BrnNm, string AcntNm, long MnyOrdAbleAmt, long MnyoutAbleAmt, long SeOrdAbleAmt, long KdqOrdAbleAmt, long HtsOrdAbleAmt, long MgnRat100pctOrdAbleAmt, long BalEvalAmt, long PchsAmt, long RcvblAmt, double PnlRat, long InvstOrgAmt, long InvstPlAmt, long CrdtPldgOrdAmt, long Dps, long D1Dps, long D2Dps, string OrdDt, long MnyMgn, long SubstMgn, long SubstAmt, long PrdayBuyExecAmt, long PrdaySellExecAmt, long CrdayBuyExecAmt, long CrdaySellExecAmt, long EvalPnlSum, long DpsastTotamt, long Evrprc, long RuseAmt, long EtclndAmt, long PrcAdjstAmt, long D1CmsnAmt, long D2CmsnAmt, long D1EvrTax, long D2EvrTax, long D1SettPrergAmt, long D2SettPrergAmt, long PrdayKseMnyMgn, long PrdayKseSubstMgn, long PrdayKseCrdtMnyMgn, long PrdayKseCrdtSubstMgn, long CrdayKseMnyMgn, long CrdayKseSubstMgn, long CrdayKseCrdtMnyMgn, long CrdayKseCrdtSubstMgn, long PrdayKdqMnyMgn, long PrdayKdqSubstMgn, long PrdayKdqCrdtMnyMgn, long PrdayKdqCrdtSubstMgn, long CrdayKdqMnyMgn, long CrdayKdqSubstMgn, long CrdayKdqCrdtMnyMgn, long CrdayKdqCrdtSubstMgn, long PrdayFrbrdMnyMgn, long PrdayFrbrdSubstMgn, long CrdayFrbrdMnyMgn, long CrdayFrbrdSubstMgn, long PrdayCrbmkMnyMgn, long PrdayCrbmkSubstMgn, long CrdayCrbmkMnyMgn, long CrdayCrbmkSubstMgn, long DpspdgQty, long BuyAdjstAmtD2, long SellAdjstAmtD2, long RepayRqrdAmtD1, long RepayRqrdAmtD2, long LoanAmt);

/// <summary>
/// 
/// </summary>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="SecBalPtnCode">유가증권잔고유형코드	String	Y	2</param>
/// <param name="SecBalPtnNm">유가증권잔고유형명	String	Y	40</param>
/// <param name="BalQty">잔고수량	Number	Y	16</param>
/// <param name="BnsBaseBalQty">매매기준잔고수량	Number	Y	16</param>
/// <param name="CrdayBuyExecQty">금일매수체결수량	Number	Y	16</param>
/// <param name="CrdaySellExecQty">금일매도체결수량	Number	Y	16</param>
/// <param name="SellPrc">매도가	Number	Y	21.4</param>
/// <param name="BuyPrc">매수가	Number	Y	21.4</param>
/// <param name="SellPnlAmt">매도손익금액	Number	Y	16</param>
/// <param name="PnlRat">손익율	Number	Y	18.6</param>
/// <param name="NowPrc">현재가	Number	Y	15.2</param>
/// <param name="CrdtAmt">신용금액	Number	Y	16</param>
/// <param name="DueDt">만기일	String	Y	8</param>
/// <param name="PrdaySellExecPrc">전일매도체결가	Number	Y	13.2</param>
/// <param name="PrdaySellQty">전일매도수량	Number	Y	16</param>
/// <param name="PrdayBuyExecPrc">전일매수체결가	Number	Y	13.2</param>
/// <param name="PrdayBuyQty">전일매수수량	Number	Y	16</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="AvrUprc">평균단가	Number	Y	13.2</param>
/// <param name="SellAbleQty">매도가능수량	Number	Y	16</param>
/// <param name="SellOrdQty">매도주문수량	Number	Y	16</param>
/// <param name="CrdayBuyExecAmt">금일매수체결금액	Number	Y	16</param>
/// <param name="CrdaySellExecAmt">금일매도체결금액	Number	Y	16</param>
/// <param name="PrdayBuyExecAmt">전일매수체결금액	Number	Y	16</param>
/// <param name="PrdaySellExecAmt">전일매도체결금액	Number	Y	16</param>
/// <param name="BalEvalAmt">잔고평가금액	Number	Y	16</param>
/// <param name="EvalPnl">평가손익	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="SellUnercQty">매도미체결수량	Number	Y	16</param>
/// <param name="SellUnsttQty">매도미결제수량	Number	Y	16</param>
/// <param name="BuyUnercQty">매수미체결수량	Number	Y	16</param>
/// <param name="BuyUnsttQty">매수미결제수량	Number	Y	16</param>
/// <param name="UnsttQty">미결제수량	Number	Y	16</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="PrdayCprc">전일종가	Number	Y	15.2</param>
/// <param name="PchsAmt">매입금액	Number	Y	16</param>
/// <param name="RegMktCode">등록시장코드	String	Y	2</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	String	Y	2</param>
/// <param name="DpspdgLoanQty">예탁담보대출수량	Number	Y	16</param>
public record CSPAQ12300OutBlock3(string IsuNo, string IsuNm, string SecBalPtnCode, string SecBalPtnNm, long BalQty, long BnsBaseBalQty, long CrdayBuyExecQty, long CrdaySellExecQty, double SellPrc, double BuyPrc, long SellPnlAmt, double PnlRat, double NowPrc, long CrdtAmt, string DueDt, double PrdaySellExecPrc, long PrdaySellQty, double PrdayBuyExecPrc, long PrdayBuyQty, string LoanDt, double AvrUprc, long SellAbleQty, long SellOrdQty, long CrdayBuyExecAmt, long CrdaySellExecAmt, long PrdayBuyExecAmt, long PrdaySellExecAmt, long BalEvalAmt, long EvalPnl, long MnyOrdAbleAmt, long OrdAbleAmt, long SellUnercQty, long SellUnsttQty, long BuyUnercQty, long BuyUnsttQty, long UnsttQty, long UnercQty, double PrdayCprc, long PchsAmt, string RegMktCode, string LoanDtlClssCode, long DpspdgLoanQty);

/// <summary>
/// 
/// </summary>
/// <param name="OrdMktCode">주문시장코드	String	Y	2	00.전체</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	0@전체</param>
/// <param name="IsuNo">종목번호	String	Y	12	주식	:	A+종목코드</param>
/// <param name="ExecYn">체결여부	String	Y	1	0.전체</param>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="SrtOrdNo2">시작주문번호2	Number	Y	10	역순구분이	순	:	000000000</param>
/// <param name="BkseqTpCode">역순구분	String	Y	1	0.역순</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2	00.전체</param>
public record CSPAQ13700InBlock1(string OrdMktCode, string BnsTpCode, string IsuNo, string ExecYn, string OrdDt, long SrtOrdNo2, string BkseqTpCode, string OrdPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="ExecYn">체결여부	String	Y	1</param>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="SrtOrdNo2">시작주문번호2	Number	Y	10</param>
/// <param name="BkseqTpCode">역순구분	String	Y	1</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
public record CSPAQ13700OutBlock1(int RecCnt, string AcntNo, string InptPwd, string OrdMktCode, string BnsTpCode, string IsuNo, string ExecYn, string OrdDt, long SrtOrdNo2, string BkseqTpCode, string OrdPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="SellExecAmt">매도체결금액	Number	Y	16</param>
/// <param name="BuyExecAmt">매수체결금액	Number	Y	16</param>
/// <param name="SellExecQty">매도체결수량	Number	Y	16</param>
/// <param name="BuyExecQty">매수체결수량	Number	Y	16</param>
/// <param name="SellOrdQty">매도주문수량	Number	Y	16</param>
/// <param name="BuyOrdQty">매수주문수량	Number	Y	16</param>
public record CSPAQ13700OutBlock2(int RecCnt, long SellExecAmt, long BuyExecAmt, long SellExecQty, long BuyExecQty, long SellOrdQty, long BuyOrdQty);

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="MgmtBrnNo">관리지점번호	String	Y	3</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="OrdPtnNm">주문유형명	String	Y	40</param>
/// <param name="OrdTrxPtnCode">주문처리유형코드	Number	Y	9</param>
/// <param name="OrdTrxPtnNm">주문처리유형명	String	Y	50</param>
/// <param name="MrcTpCode">정정취소구분	String	Y	1</param>
/// <param name="MrcTpNm">정정취소구분명	String	Y	10</param>
/// <param name="MrcQty">정정취소수량	Number	Y	16</param>
/// <param name="MrcAbleQty">정정취소가능수량	Number	Y	16</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="ExecPrc">체결가	Number	Y	15.2</param>
/// <param name="ExecTrxTime">체결처리시각	String	Y	9</param>
/// <param name="LastExecTime">최종체결시각	String	Y	9</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2</param>
/// <param name="OrdprcPtnNm">호가유형명	String	Y	40</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1</param>
/// <param name="AllExecQty">전체체결수량	Number	Y	16</param>
/// <param name="RegCommdaCode">통신매체코드	String	Y	2</param>
/// <param name="CommdaNm">통신매체명	String	Y	40</param>
/// <param name="MbrNo">회원번호	String	Y	3</param>
/// <param name="RsvOrdYn">예약주문여부	String	Y	1</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="OpDrtnNo">운용지시번호	String	Y	12</param>
/// <param name="OdrrId">주문자ID	String	Y	16</param>
public record CSPAQ13700OutBlock3(string OrdDt, string MgmtBrnNo, string OrdMktCode, long OrdNo, long OrgOrdNo, string IsuNo, string IsuNm, string BnsTpCode, string BnsTpNm, string OrdPtnCode, string OrdPtnNm, long OrdTrxPtnCode, string OrdTrxPtnNm, string MrcTpCode, string MrcTpNm, long MrcQty, long MrcAbleQty, long OrdQty, double OrdPrc, long ExecQty, double ExecPrc, string ExecTrxTime, string LastExecTime, string OrdprcPtnCode, string OrdprcPtnNm, string OrdCndiTpCode, long AllExecQty, string RegCommdaCode, string CommdaNm, string MbrNo, string RsvOrdYn, string LoanDt, string OrdTime, string OpDrtnNo, string OdrrId);

/// <summary>
/// 
/// </summary>
/// <param name="BalCreTp">잔고생성구분	String	Y	1	0</param>
public record CSPAQ22200InBlock1(string BalCreTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="MgmtBrnNo">관리지점번호	String	Y	3</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="BalCreTp">잔고생성구분	String	Y	1</param>
public record CSPAQ22200OutBlock1(int RecCnt, string MgmtBrnNo, string AcntNo, string Pwd, string BalCreTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	Number	Y	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	Number	Y	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	Number	Y	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	Number	Y	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat35ordAbleAmt">증거금률35%주문가능금액	Number	Y	16</param>
/// <param name="MgnRat50ordAbleAmt">증거금률50%주문가능금액	Number	Y	16</param>
/// <param name="CrdtOrdAbleAmt">신용주문가능금액	Number	Y	16</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="SubstAmt">대용금액	Number	Y	16</param>
/// <param name="MgnMny">증거금현금	Number	Y	16</param>
/// <param name="MgnSubst">증거금대용	Number	Y	16</param>
/// <param name="D1Dps">D1예수금	Number	Y	16</param>
/// <param name="D2Dps">D2예수금	Number	Y	16</param>
/// <param name="RcvblAmt">미수금액	Number	Y	16</param>
/// <param name="D1ovdRepayRqrdAmt">D1연체변제소요금액	Number	Y	16</param>
/// <param name="D2ovdRepayRqrdAmt">D2연체변제소요금액	Number	Y	16</param>
/// <param name="MloanAmt">융자금액	Number	Y	16</param>
/// <param name="ChgAfPldgRat">변경후담보비율	Number	Y	9.3</param>
/// <param name="RqrdPldgAmt">소요담보금액	Number	Y	16</param>
/// <param name="PdlckAmt">담보부족금액	Number	Y	16</param>
/// <param name="OrgPldgSumAmt">원담보합계금액	Number	Y	16</param>
/// <param name="SubPldgSumAmt">부담보합계금액	Number	Y	16</param>
/// <param name="CrdtPldgAmtMny">신용담보금현금	Number	Y	16</param>
/// <param name="CrdtPldgSubstAmt">신용담보대용금액	Number	Y	16</param>
/// <param name="Imreq">신용설정보증금	Number	Y	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	Number	Y	16</param>
/// <param name="DpslRestrcAmt">처분제한금액	Number	Y	16</param>
/// <param name="PrdaySellAdjstAmt">전일매도정산금액	Number	Y	16</param>
/// <param name="PrdayBuyAdjstAmt">전일매수정산금액	Number	Y	16</param>
/// <param name="CrdaySellAdjstAmt">금일매도정산금액	Number	Y	16</param>
/// <param name="CrdayBuyAdjstAmt">금일매수정산금액	Number	Y	16</param>
/// <param name="CslLoanAmtdt1">매도대금담보대출금액	Number	Y	16</param>
public record CSPAQ22200OutBlock2(int RecCnt, string BrnNm, string AcntNm, long MnyOrdAbleAmt, long SubstOrdAbleAmt, long SeOrdAbleAmt, long KdqOrdAbleAmt, long CrdtPldgOrdAmt, long MgnRat100pctOrdAbleAmt, long MgnRat35ordAbleAmt, long MgnRat50ordAbleAmt, long CrdtOrdAbleAmt, long Dps, long SubstAmt, long MgnMny, long MgnSubst, long D1Dps, long D2Dps, long RcvblAmt, long D1ovdRepayRqrdAmt, long D2ovdRepayRqrdAmt, long MloanAmt, double ChgAfPldgRat, long RqrdPldgAmt, long PdlckAmt, long OrgPldgSumAmt, long SubPldgSumAmt, long CrdtPldgAmtMny, long CrdtPldgSubstAmt, long Imreq, long CrdtPldgRuseAmt, long DpslRestrcAmt, long PrdaySellAdjstAmt, long PrdayBuyAdjstAmt, long CrdaySellAdjstAmt, long CrdayBuyAdjstAmt, long CslLoanAmtdt1);

/// <summary>
/// 
/// </summary>
/// <param name="BnsTpCode">매매구분	String	Y	1	1@매도,	2@매수</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
public record CSPBQ00200InBlock1(string BnsTpCode, string IsuNo, double OrdPrc);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
/// <param name="RegCommdaCode">통신매체코드	String	Y	2</param>
public record CSPBQ00200OutBlock1(int RecCnt, string BnsTpCode, string AcntNo, string InptPwd, string IsuNo, double OrdPrc, string RegCommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="SubstAmt">대용금액	Number	Y	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	Number	Y	16</param>
/// <param name="MnyMgn">현금증거금액	Number	Y	16</param>
/// <param name="SubstMgn">대용증거금액	Number	Y	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	Number	Y	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	Number	Y	16</param>
/// <param name="PrsmptDpsD1">추정예수금(D+1)	Number	Y	16</param>
/// <param name="PrsmptDpsD2">추정예수금(D+2)	Number	Y	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	Number	Y	16</param>
/// <param name="RcvblAmt">미수금액	Number	Y	16</param>
/// <param name="CmsnRat">수수료율	Number	Y	15.5</param>
/// <param name="AddLevyAmt">추가징수금액	Number	Y	16</param>
/// <param name="RuseObjAmt">재사용대상금액	Number	Y	16</param>
/// <param name="MnyRuseObjAmt">현금재사용대상금액	Number	Y	16</param>
/// <param name="FirmMgnRat">이용사증거금률	Number	Y	7.4</param>
/// <param name="SubstRuseObjAmt">대용재사용대상금액	Number	Y	16</param>
/// <param name="IsuMgnRat">종목증거금률	Number	Y	7.4</param>
/// <param name="AcntMgnRat">계좌증거금률	Number	Y	7.4</param>
/// <param name="TrdMgnrt">거래증거금률	Number	Y	7.4</param>
/// <param name="Cmsn">수수료	Number	Y	16</param>
/// <param name="MgnRat20pctOrdAbleAmt">증거금률20퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat20OrdAbleQty">증거금률100퍼센트현금주문가능수량	Number	Y	16</param>
/// <param name="MgnRat30pctOrdAbleAmt">증거금률30퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat30OrdAbleQty">증거금률30퍼센트주문가능수량	Number	Y	16</param>
/// <param name="MgnRat40pctOrdAbleAmt">증거금률40퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat40OrdAbleQty">증거금률40퍼센트주문가능수량	Number	Y	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	Number	Y	16</param>
/// <param name="MgnRat100OrdAbleQty">증거금률100퍼센트주문가능수량	Number	Y	16</param>
/// <param name="MgnRat100MnyOrdAbleAmt">증거금률100퍼센트현금주문가능금액	Number	Y	16</param>
/// <param name="MgnRat100MnyOrdAbleQty">증거금률100퍼센트현금주문가능수량	Number	Y	16</param>
/// <param name="MgnRat20pctRuseAbleAmt">증거금률20퍼센트재사용가능금액	Number	Y	16</param>
/// <param name="MgnRat30pctRuseAbleAmt">증거금률30퍼센트재사용가능금액	Number	Y	16</param>
/// <param name="MgnRat40pctRuseAbleAmt">증거금률40퍼센트재사용가능금액	Number	Y	16</param>
/// <param name="MgnRat100pctRuseAbleAmt">증거금률100퍼센트재사용가능금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
public record CSPBQ00200OutBlock2(int RecCnt, string AcntNm, string IsuNm, long Dps, long SubstAmt, long CrdtPldgRuseAmt, long MnyOrdAbleAmt, long SubstOrdAbleAmt, long MnyMgn, long SubstMgn, long SeOrdAbleAmt, long KdqOrdAbleAmt, long PrsmptDpsD1, long PrsmptDpsD2, long MnyoutAbleAmt, long RcvblAmt, double CmsnRat, long AddLevyAmt, long RuseObjAmt, long MnyRuseObjAmt, double FirmMgnRat, long SubstRuseObjAmt, double IsuMgnRat, double AcntMgnRat, double TrdMgnrt, long Cmsn, long MgnRat20pctOrdAbleAmt, long MgnRat20OrdAbleQty, long MgnRat30pctOrdAbleAmt, long MgnRat30OrdAbleQty, long MgnRat40pctOrdAbleAmt, long MgnRat40OrdAbleQty, long MgnRat100pctOrdAbleAmt, long MgnRat100OrdAbleQty, long MgnRat100MnyOrdAbleAmt, long MgnRat100MnyOrdAbleQty, long MgnRat20pctRuseAbleAmt, long MgnRat30pctRuseAbleAmt, long MgnRat40pctRuseAbleAmt, long MgnRat100pctRuseAbleAmt, long OrdAbleQty, long OrdAbleAmt);

/// <summary>
/// 
/// </summary>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="TermTp">기간구분	String	Y	1	1:일별,	2:주별,	3:월별</param>
public record FOCCQ33600InBlock1(string QrySrtDt, string QryEndDt, string TermTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="TermTp">기간구분	String	Y	1</param>
public record FOCCQ33600OutBlock1(int RecCnt, string AcntNo, string Pwd, string QrySrtDt, string QryEndDt, string TermTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="BnsctrAmt">매매약정금액	Number	Y	16</param>
/// <param name="MnyinAmt">입금금액	Number	Y	16</param>
/// <param name="MnyoutAmt">출금금액	Number	Y	16</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	Number	Y	16</param>
/// <param name="InvstPlAmt">투자손익금액	Number	Y	16</param>
/// <param name="InvstErnrat">투자수익률	Number	Y	9.2</param>
public record FOCCQ33600OutBlock2(int RecCnt, string AcntNm, long BnsctrAmt, long MnyinAmt, long MnyoutAmt, long InvstAvrbalPramt, long InvstPlAmt, double InvstErnrat);

/// <summary>
/// 
/// </summary>
/// <param name="BaseDt">기준일	String	Y	8</param>
/// <param name="FdEvalAmt">기초평가금액	Number	Y	19</param>
/// <param name="EotEvalAmt">기말평가금액	Number	Y	19</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	Number	Y	16</param>
/// <param name="BnsctrAmt">매매약정금액	Number	Y	16</param>
/// <param name="MnyinSecinAmt">입금고액	Number	Y	16</param>
/// <param name="MnyoutSecoutAmt">출금고액	Number	Y	16</param>
/// <param name="EvalPnlAmt">평가손익금액	Number	Y	16</param>
/// <param name="TermErnrat">기간수익률	Number	Y	11.3</param>
/// <param name="Idx">지수	Number	Y	13.2</param>
public record FOCCQ33600OutBlock3(string BaseDt, long FdEvalAmt, long EotEvalAmt, long InvstAvrbalPramt, long BnsctrAmt, long MnyinSecinAmt, long MnyoutSecoutAmt, long EvalPnlAmt, double TermErnrat, double Idx);

/// <summary>
/// 
/// </summary>
/// <param name="cts_medosu">CTS_매매구분	String	Y	1	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	12	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_price">CTS_단가	String	Y	9	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_middiv">CTS_매체	String	Y	2	연속조회시	OutBlock의	동일필드	입력</param>
public record t0150InBlock(string cts_medosu, string cts_expcode, string cts_price, string cts_middiv);

/// <summary>
/// 
/// </summary>
/// <param name="mdqty">매도수량	Number	Y	9</param>
/// <param name="mdamt">매도약정금액	Number	Y	18</param>
/// <param name="mdfee">매도수수료	Number	Y	18</param>
/// <param name="mdtax">매도거래세	Number	Y	18</param>
/// <param name="mdargtax">매도농특세	Number	Y	18</param>
/// <param name="tmdtax">매도제비용합	Number	Y	18</param>
/// <param name="mdadjamt">매도정산금액	Number	Y	18</param>
/// <param name="msqty">매수수량	Number	Y	9</param>
/// <param name="msamt">매수약정금액	Number	Y	18</param>
/// <param name="msfee">매수수수료	Number	Y	18</param>
/// <param name="tmstax">매수제비용합	Number	Y	18</param>
/// <param name="msadjamt">매수정산금액	Number	Y	18</param>
/// <param name="tqty">합계수량	Number	Y	9</param>
/// <param name="tamt">합계약정금액	Number	Y	18</param>
/// <param name="tfee">합계수수료	Number	Y	18</param>
/// <param name="tottax">합계거래세	Number	Y	18</param>
/// <param name="targtax">합계농특세	Number	Y	18</param>
/// <param name="ttax">합계제비용합	Number	Y	18</param>
/// <param name="tadjamt">합계정산금액	Number	Y	18</param>
/// <param name="cts_medosu">CTS_매매구분	String	Y	1</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	12</param>
/// <param name="cts_price">CTS_단가	String	Y	9</param>
/// <param name="cts_middiv">CTS_매체	String	Y	2</param>
public record t0150OutBlock(long mdqty, long mdamt, long mdfee, long mdtax, long mdargtax, long tmdtax, long mdadjamt, long msqty, long msamt, long msfee, long tmstax, long msadjamt, long tqty, long tamt, long tfee, long tottax, long targtax, long ttax, long tadjamt, string cts_medosu, string cts_expcode, string cts_price, string cts_middiv);

/// <summary>
/// 
/// </summary>
/// <param name="medosu">매매구분	String	Y	10</param>
/// <param name="expcode">종목번호	String	Y	12</param>
/// <param name="qty">수량	Number	Y	9</param>
/// <param name="price">단가	Number	Y	9</param>
/// <param name="amt">약정금액	Number	Y	18</param>
/// <param name="fee">수수료	Number	Y	18</param>
/// <param name="tax">거래세	Number	Y	18</param>
/// <param name="argtax">농특세	Number	Y	18</param>
/// <param name="adjamt">정산금액	Number	Y	18</param>
/// <param name="middiv">매체	String	Y	20</param>
public record t0150OutBlock1(string medosu, string expcode, long qty, long price, long amt, long fee, long tax, long argtax, long adjamt, string middiv);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="cts_medosu">CTS_매매구분	String	Y	1	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	12	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_price">CTS_단가	String	Y	9	연속조회시	OutBlock의	동일필드	입력</param>
/// <param name="cts_middiv">CTS_매체	String	Y	2	연속조회시	OutBlock의	동일필드	입력</param>
public record t0151InBlock(string date, string cts_medosu, string cts_expcode, string cts_price, string cts_middiv);

/// <summary>
/// 
/// </summary>
/// <param name="mdqty">매도수량	Number	Y	9</param>
/// <param name="mdamt">매도약정금액	Number	Y	18</param>
/// <param name="mdfee">매도수수료	Number	Y	18</param>
/// <param name="mdtax">매도거래세	Number	Y	18</param>
/// <param name="mdargtax">매도농특세	Number	Y	18</param>
/// <param name="tmdtax">매도제비용합	Number	Y	18</param>
/// <param name="mdadjamt">매도정산금액	Number	Y	18</param>
/// <param name="msqty">매수수량	Number	Y	9</param>
/// <param name="msamt">매수약정금액	Number	Y	18</param>
/// <param name="msfee">매수수수료	Number	Y	18</param>
/// <param name="tmstax">매수제비용합	Number	Y	18</param>
/// <param name="msadjamt">매수정산금액	Number	Y	18</param>
/// <param name="tqty">합계수량	Number	Y	9</param>
/// <param name="tamt">합계약정금액	Number	Y	18</param>
/// <param name="tfee">합계수수료	Number	Y	18</param>
/// <param name="tottax">합계거래세	Number	Y	18</param>
/// <param name="targtax">합계농특세	Number	Y	18</param>
/// <param name="ttax">합계제비용합	Number	Y	18</param>
/// <param name="tadjamt">합계정산금액	Number	Y	18</param>
/// <param name="cts_medosu">CTS_매매구분	String	Y	1</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	12</param>
/// <param name="cts_price">CTS_단가	String	Y	9</param>
/// <param name="cts_middiv">CTS_매체	String	Y	2</param>
public record t0151OutBlock(long mdqty, long mdamt, long mdfee, long mdtax, long mdargtax, long tmdtax, long mdadjamt, long msqty, long msamt, long msfee, long tmstax, long msadjamt, long tqty, long tamt, long tfee, long tottax, long targtax, long ttax, long tadjamt, string cts_medosu, string cts_expcode, string cts_price, string cts_middiv);

/// <summary>
/// 
/// </summary>
/// <param name="medosu">매매구분	String	Y	10</param>
/// <param name="expcode">종목번호	String	Y	12</param>
/// <param name="qty">수량	Number	Y	9</param>
/// <param name="price">단가	Number	Y	9</param>
/// <param name="amt">약정금액	Number	Y	18</param>
/// <param name="fee">수수료	Number	Y	18</param>
/// <param name="tax">거래세	Number	Y	18</param>
/// <param name="argtax">농특세	Number	Y	18</param>
/// <param name="adjamt">정산금액	Number	Y	18</param>
/// <param name="middiv">매체	String	Y	20</param>
public record t0151OutBlock1(string medosu, string expcode, long qty, long price, long amt, long fee, long tax, long argtax, long adjamt, string middiv);

/// <summary>
/// 
/// </summary>
/// <param name="prcgb">단가구분	String	Y	1</param>
/// <param name="chegb">체결구분	String	Y	1</param>
/// <param name="dangb">단일가구분	String	Y	1</param>
/// <param name="charge">제비용포함여부	String	Y	1</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	22	연속조회시	OutBlock의	동일필드	입력</param>
public record t0424InBlock(string prcgb, string chegb, string dangb, string charge, string cts_expcode);

/// <summary>
/// 
/// </summary>
/// <param name="sunamt">추정순자산	Number	Y	18</param>
/// <param name="dtsunik">실현손익	Number	Y	18</param>
/// <param name="mamt">매입금액	Number	Y	18</param>
/// <param name="sunamt1">추정D2예수금	Number	Y	18</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	22</param>
/// <param name="tappamt">평가금액	Number	Y	18</param>
/// <param name="tdtsunik">평가손익	Number	Y	18</param>
public record t0424OutBlock(long sunamt, long dtsunik, long mamt, long sunamt1, string cts_expcode, long tappamt, long tdtsunik);

/// <summary>
/// 
/// </summary>
/// <param name="expcode">종목번호	String	Y	12</param>
/// <param name="jangb">잔고구분	String	Y	10</param>
/// <param name="janqty">잔고수량	Number	Y	18</param>
/// <param name="mdposqt">매도가능수량	Number	Y	18</param>
/// <param name="pamt">평균단가	Number	Y	18</param>
/// <param name="mamt">매입금액	Number	Y	18</param>
/// <param name="sinamt">대출금액	Number	Y	18</param>
/// <param name="lastdt">만기일자	String	Y	8</param>
/// <param name="msat">당일매수금액	Number	Y	18</param>
/// <param name="mpms">당일매수단가	Number	Y	18</param>
/// <param name="mdat">당일매도금액	Number	Y	18</param>
/// <param name="mpmd">당일매도단가	Number	Y	18</param>
/// <param name="jsat">전일매수금액	Number	Y	18</param>
/// <param name="jpms">전일매수단가	Number	Y	18</param>
/// <param name="jdat">전일매도금액	Number	Y	18</param>
/// <param name="jpmd">전일매도단가	Number	Y	18</param>
/// <param name="sysprocseq">처리순번	Number	Y	10</param>
/// <param name="loandt">대출일자	String	Y	8</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="marketgb">시장구분	String	Y	1</param>
/// <param name="jonggb">종목구분	String	Y	1</param>
/// <param name="janrt">보유비중	Number	Y	10.2</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="appamt">평가금액	Number	Y	18</param>
/// <param name="dtsunik">평가손익	Number	Y	18</param>
/// <param name="sunikrt">수익율	Number	Y	10.2</param>
/// <param name="fee">수수료	Number	Y	10</param>
/// <param name="tax">제세금	Number	Y	10</param>
/// <param name="sininter">신용이자	Number	Y	10</param>
public record t0424OutBlock1(string expcode, string jangb, long janqty, long mdposqt, long pamt, long mamt, long sinamt, string lastdt, long msat, long mpms, long mdat, long mpmd, long jsat, long jpms, long jdat, long jpmd, long sysprocseq, string loandt, string hname, string marketgb, string jonggb, double janrt, int price, long appamt, long dtsunik, double sunikrt, long fee, long tax, long sininter);

/// <summary>
/// 
/// </summary>
/// <param name="expcode">종목번호	String	Y	12</param>
/// <param name="chegb">체결구분	String	Y	1	0;전체</param>
/// <param name="medosu">매매구분	String	Y	1	0:전체</param>
/// <param name="sortgb">정렬순서	String	Y	1	1:주문번호	역순</param>
/// <param name="cts_ordno">주문번호	String	Y	10	연속조회시	OutBlock의	동일필드	입력</param>
public record t0425InBlock(string expcode, string chegb, string medosu, string sortgb, string cts_ordno);

/// <summary>
/// 
/// </summary>
/// <param name="tqty">총주문수량	Number	Y	18</param>
/// <param name="tcheqty">총체결수량	Number	Y	18</param>
/// <param name="tordrem">총미체결수량	Number	Y	18</param>
/// <param name="cmss">추정수수료	Number	Y	18</param>
/// <param name="tamt">총주문금액	Number	Y	18</param>
/// <param name="tmdamt">총매도체결금액	Number	Y	18</param>
/// <param name="tmsamt">총매수체결금액	Number	Y	18</param>
/// <param name="tax">추정제세금	Number	Y	18</param>
/// <param name="cts_ordno">주문번호	String	Y	10</param>
public record t0425OutBlock(long tqty, long tcheqty, long tordrem, long cmss, long tamt, long tmdamt, long tmsamt, long tax, string cts_ordno);

/// <summary>
/// 
/// </summary>
/// <param name="ordno">주문번호	Number	Y	10</param>
/// <param name="expcode">종목번호	String	Y	12</param>
/// <param name="medosu">구분	String	Y	10</param>
/// <param name="qty">주문수량	Number	Y	9</param>
/// <param name="price">주문가격	Number	Y	9</param>
/// <param name="cheqty">체결수량	Number	Y	9</param>
/// <param name="cheprice">체결가격	Number	Y	9</param>
/// <param name="ordrem">미체결잔량	Number	Y	9</param>
/// <param name="cfmqty">확인수량	Number	Y	9</param>
/// <param name="status">상태	String	Y	10</param>
/// <param name="orgordno">원주문번호	Number	Y	10</param>
/// <param name="ordgb">유형	String	Y	20</param>
/// <param name="ordtime">주문시간	String	Y	8</param>
/// <param name="ordermtd">주문매체	String	Y	10</param>
/// <param name="sysprocseq">처리순번	Number	Y	10</param>
/// <param name="hogagb">호가유형	String	Y	2</param>
/// <param name="price1">현재가	Number	Y	8</param>
/// <param name="orggb">주문구분	String	Y	2</param>
/// <param name="singb">신용구분	String	Y	2</param>
/// <param name="loandt">대출일자	String	Y	8</param>
public record t0425OutBlock1(long ordno, string expcode, string medosu, long qty, long price, long cheqty, long cheprice, long ordrem, long cfmqty, string status, long orgordno, string ordgb, string ordtime, string ordermtd, long sysprocseq, string hogagb, int price1, string orggb, string singb, string loandt);

#endregion

#region [주식] 주문

/// <summary>
/// 
/// </summary>
/// <param name="IsuNo">종목번호	String	Y	12	주식/ETF	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	1:매도,	2:매수</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2	00@지정가</param>
/// <param name="MgntrnCode">신용거래코드	String	Y	3	000:보통</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1	0:없음,1:IOC,2:FOK</param>
public record CSPAT00601InBlock1(string IsuNo, long OrdQty, double OrdPrc, string BnsTpCode, string OrdprcPtnCode, string MgntrnCode, string LoanDt, string OrdCndiTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	String	Y	2</param>
/// <param name="StslAbleYn">공매도가능여부	String	Y	1</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	String	Y	1</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="MgntrnCode">신용거래코드	String	Y	3</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="MbrNo">회원번호	String	Y	3</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1</param>
/// <param name="StrtgCode">전략코드	String	Y	6</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="OrdSeqNo">주문회차	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">아이템번호	Number	Y	10</param>
/// <param name="OpDrtnNo">운용지시번호	String	Y	12</param>
/// <param name="LpYn">유동성공급자여부	String	Y	1</param>
/// <param name="CvrgTpCode">반대매매구분	String	Y	1</param>
public record CSPAT00601OutBlock1(int RecCnt, string AcntNo, string InptPwd, string IsuNo, long OrdQty, double OrdPrc, string BnsTpCode, string OrdprcPtnCode, string PrgmOrdprcPtnCode, string StslAbleYn, string StslOrdprcTpCode, string CommdaCode, string MgntrnCode, string LoanDt, string MbrNo, string OrdCndiTpCode, string StrtgCode, string GrpId, long OrdSeqNo, long PtflNo, long BskNo, long TrchNo, long ItemNo, string OpDrtnNo, string LpYn, string CvrgTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="ShtnIsuNo">단축종목번호	String	Y	9</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="OrdAmt">주문금액	Number	Y	16</param>
/// <param name="SpareOrdNo">예비주문번호	Number	Y	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	Number	Y	10</param>
/// <param name="RsvOrdNo">예약주문번호	Number	Y	10</param>
/// <param name="SpotOrdQty">실물주문수량	Number	Y	16</param>
/// <param name="RuseOrdQty">재사용주문수량	Number	Y	16</param>
/// <param name="MnyOrdAmt">현금주문금액	Number	Y	16</param>
/// <param name="SubstOrdAmt">대용주문금액	Number	Y	16</param>
/// <param name="RuseOrdAmt">재사용주문금액	Number	Y	16</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
public record CSPAT00601OutBlock2(int RecCnt, long OrdNo, string OrdTime, string OrdMktCode, string OrdPtnCode, string ShtnIsuNo, string MgempNo, long OrdAmt, long SpareOrdNo, long CvrgSeqno, long RsvOrdNo, long SpotOrdQty, long RuseOrdQty, long MnyOrdAmt, long SubstOrdAmt, long RuseOrdAmt, string AcntNm, string IsuNm);

/// <summary>
/// 
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12	주식	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2	00@지정가</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1	0:없음,	1:IOC,	2:FOK</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
public record CSPAT00701InBlock1(long OrgOrdNo, string IsuNo, long OrdQty, string OrdprcPtnCode, string OrdCndiTpCode, double OrdPrc);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="StrtgCode">전략코드	String	Y	6</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="OrdSeqNo">주문회차	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">아이템번호	Number	Y	10</param>
public record CSPAT00701OutBlock1(int RecCnt, long OrgOrdNo, string AcntNo, string InptPwd, string IsuNo, long OrdQty, string OrdprcPtnCode, string OrdCndiTpCode, double OrdPrc, string CommdaCode, string StrtgCode, string GrpId, long OrdSeqNo, long PtflNo, long BskNo, long TrchNo, long ItemNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="PrntOrdNo">모주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="ShtnIsuNo">단축종목번호	String	Y	9</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	String	Y	2</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	String	Y	1</param>
/// <param name="StslAbleYn">공매도가능여부	String	Y	1</param>
/// <param name="MgntrnCode">신용거래코드	String	Y	3</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="CvrgOrdTp">반대매매주문구분	String	Y	1</param>
/// <param name="LpYn">유동성공급자여부	String	Y	1</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="OrdAmt">주문금액	Number	Y	16</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="SpareOrdNo">예비주문번호	Number	Y	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	Number	Y	10</param>
/// <param name="RsvOrdNo">예약주문번호	Number	Y	10</param>
/// <param name="MnyOrdAmt">현금주문금액	Number	Y	16</param>
/// <param name="SubstOrdAmt">대용주문금액	Number	Y	16</param>
/// <param name="RuseOrdAmt">재사용주문금액	Number	Y	16</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
public record CSPAT00701OutBlock2(int RecCnt, long OrdNo, long PrntOrdNo, string OrdTime, string OrdMktCode, string OrdPtnCode, string ShtnIsuNo, string PrgmOrdprcPtnCode, string StslOrdprcTpCode, string StslAbleYn, string MgntrnCode, string LoanDt, string CvrgOrdTp, string LpYn, string MgempNo, long OrdAmt, string BnsTpCode, long SpareOrdNo, long CvrgSeqno, long RsvOrdNo, long MnyOrdAmt, long SubstOrdAmt, long RuseOrdAmt, string AcntNm, string IsuNm);

/// <summary>
/// 
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12	주식	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
public record CSPAT00801InBlock1(long OrgOrdNo, string IsuNo, long OrdQty);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="StrtgCode">전략코드	String	Y	6</param>
/// <param name="OrdSeqNo">주문회차	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">아이템번호	Number	Y	10</param>
public record CSPAT00801OutBlock1(int RecCnt, long OrgOrdNo, string AcntNo, string InptPwd, string IsuNo, long OrdQty, string CommdaCode, string GrpId, string StrtgCode, long OrdSeqNo, long PtflNo, long BskNo, long TrchNo, long ItemNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="PrntOrdNo">모주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="ShtnIsuNo">단축종목번호	String	Y	9</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	String	Y	2</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	String	Y	1</param>
/// <param name="StslAbleYn">공매도가능여부	String	Y	1</param>
/// <param name="MgntrnCode">신용거래코드	String	Y	3</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="CvrgOrdTp">반대매매주문구분	String	Y	1</param>
/// <param name="LpYn">유동성공급자여부	String	Y	1</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="SpareOrdNo">예비주문번호	Number	Y	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	Number	Y	10</param>
/// <param name="RsvOrdNo">예약주문번호	Number	Y	10</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
public record CSPAT00801OutBlock2(int RecCnt, long OrdNo, long PrntOrdNo, string OrdTime, string OrdMktCode, string OrdPtnCode, string ShtnIsuNo, string PrgmOrdprcPtnCode, string StslOrdprcTpCode, string StslAbleYn, string MgntrnCode, string LoanDt, string CvrgOrdTp, string LpYn, string MgempNo, string BnsTpCode, long SpareOrdNo, long CvrgSeqno, long RsvOrdNo, string AcntNm, string IsuNm);

#endregion

#endregion

#region 선물/옵션

#region [선물/옵션] 시세

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
public record t2101InBlock(string focode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="mgjv">미결제량	Number	Y	8</param>
/// <param name="mgjvdiff">미결제증감	Number	Y	8</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="uplmtprice">상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice">하한가	Number	Y	6.2</param>
/// <param name="high52w">52최고가	Number	Y	6.2</param>
/// <param name="low52w">52최저가	Number	Y	6.2</param>
/// <param name="basis">베이시스	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	6.2</param>
/// <param name="theoryprice">이론가	Number	Y	6.2</param>
/// <param name="glyl">괴리율	Number	Y	6.3</param>
/// <param name="cbhprice">CB상한가	Number	Y	6.2</param>
/// <param name="cblprice">CB하한가	Number	Y	6.2</param>
/// <param name="lastmonth">만기일	String	Y	8</param>
/// <param name="jandatecnt">잔여일	Number	Y	8</param>
/// <param name="pricejisu">종합지수	Number	Y	6.2</param>
/// <param name="jisusign">종합지수전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="jisuchange">종합지수전일대비	Number	Y	6.2</param>
/// <param name="jisudiff">종합지수등락율	Number	Y	6.2</param>
/// <param name="kospijisu">KOSPI200지수	Number	Y	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="kospichange">KOSPI200전일대비	Number	Y	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	Number	Y	6.2</param>
/// <param name="listhprice">상장최고가	Number	Y	6.2</param>
/// <param name="listlprice">상장최저가	Number	Y	6.2</param>
/// <param name="delt">델타	Number	Y	6.4</param>
/// <param name="gama">감마	Number	Y	6.4</param>
/// <param name="ceta">세타	Number	Y	6.4</param>
/// <param name="vega">베가	Number	Y	6.4</param>
/// <param name="rhox">로우	Number	Y	6.4</param>
/// <param name="gmprice">근월물현재가	Number	Y	6.2</param>
/// <param name="gmsign">근월물전일대비구분	String	Y	1</param>
/// <param name="gmchange">근월물전일대비	Number	Y	6.2</param>
/// <param name="gmdiff">근월물등락율	Number	Y	6.2</param>
/// <param name="theorypriceg">이론가	Number	Y	6.2</param>
/// <param name="histimpv">역사적변동성	Number	Y	6.2</param>
/// <param name="impv">내재변동성	Number	Y	6.2</param>
/// <param name="sbasis">시장BASIS	Number	Y	6.2</param>
/// <param name="ibasis">이론BASIS	Number	Y	6.2</param>
/// <param name="gmfutcode">근월물종목코드	String	Y	8</param>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="greeks_time">거래소민감도수신시간	String	Y	6</param>
/// <param name="greeks_confirm">거래소민감도확정여부	String	Y	8</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="yeprice">예상체결가	Number	Y	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilychange">예상체결가전일종가대비	Number	Y	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	Number	Y	6.2</param>
/// <param name="alloc_gubun">배분구분(1:배분개시2:배분해제0:미발생)	String	Y	1</param>
/// <param name="bjandatecnt">잔여일(영업일)	Number	Y	8</param>
/// <param name="focode">종목코드	String	Y	8</param>
/// <param name="dy_gubun">실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)	String	Y	1</param>
/// <param name="dy_uplmtprice">실시간상한가	Number	Y	6.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	Number	Y	6.2</param>
/// <param name="updnstep_gubun">가격제한폭확대(0:미확대1:확대2:대상아님)	String	Y	1</param>
/// <param name="upstep">상한적용단계	String	Y	2</param>
/// <param name="dnstep">하한적용단계	String	Y	2</param>
/// <param name="uplmtprice_3rd">3단계상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice_3rd">3단계하한가	Number	Y	6.2</param>
public record t2101OutBlock(string hname, double price, string sign, double change, double jnilclose, double diff, long volume, long value, int mgjv, int mgjvdiff, double open, double high, double low, double uplmtprice, double dnlmtprice, double high52w, double low52w, double basis, double recprice, double theoryprice, double glyl, double cbhprice, double cblprice, string lastmonth, int jandatecnt, double pricejisu, string jisusign, double jisuchange, double jisudiff, double kospijisu, string kospisign, double kospichange, double kospidiff, double listhprice, double listlprice, double delt, double gama, double ceta, double vega, double rhox, double gmprice, string gmsign, double gmchange, double gmdiff, double theorypriceg, double histimpv, double impv, double sbasis, double ibasis, string gmfutcode, double actprice, string greeks_time, string greeks_confirm, string danhochk, double yeprice, string jnilysign, double jnilychange, double jnilydrate, string alloc_gubun, int bjandatecnt, string focode, string dy_gubun, double dy_uplmtprice, double dy_dnlmtprice, string updnstep_gubun, string upstep, string dnstep, double uplmtprice_3rd, double dnlmtprice_3rd);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
public record t2105InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="offerho1">매도호가1	Number	Y	6.2</param>
/// <param name="bidho1">매수호가1	Number	Y	6.2</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	8</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	8</param>
/// <param name="dcnt1">매도호가건수1	Number	Y	8</param>
/// <param name="scnt1">매수호가건수1	Number	Y	8</param>
/// <param name="offerho2">매도호가2	Number	Y	6.2</param>
/// <param name="bidho2">매수호가2	Number	Y	6.2</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	8</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	8</param>
/// <param name="dcnt2">매도호가건수2	Number	Y	8</param>
/// <param name="scnt2">매수호가건수2	Number	Y	8</param>
/// <param name="offerho3">매도호가3	Number	Y	6.2</param>
/// <param name="bidho3">매수호가3	Number	Y	6.2</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	8</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	8</param>
/// <param name="dcnt3">매도호가건수3	Number	Y	8</param>
/// <param name="scnt3">매수호가건수3	Number	Y	8</param>
/// <param name="offerho4">매도호가4	Number	Y	6.2</param>
/// <param name="bidho4">매수호가4	Number	Y	6.2</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	8</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	8</param>
/// <param name="dcnt4">매도호가건수4	Number	Y	8</param>
/// <param name="scnt4">매수호가건수4	Number	Y	8</param>
/// <param name="offerho5">매도호가5	Number	Y	6.2</param>
/// <param name="bidho5">매수호가5	Number	Y	6.2</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	8</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	8</param>
/// <param name="dcnt5">매도호가건수5	Number	Y	8</param>
/// <param name="scnt5">매수호가건수5	Number	Y	8</param>
/// <param name="dvol">매도호가총수량	Number	Y	8</param>
/// <param name="svol">매수호가총수량	Number	Y	8</param>
/// <param name="toffernum">총매도호가건수	Number	Y	8</param>
/// <param name="tbidnum">총매수호가건수	Number	Y	8</param>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="shcode">단축코드	String	Y	8</param>
public record t2105OutBlock(string hname, double price, string sign, double change, double diff, long volume, double stimeqrt, double jnilclose, double offerho1, double bidho1, int offerrem1, int bidrem1, int dcnt1, int scnt1, double offerho2, double bidho2, int offerrem2, int bidrem2, int dcnt2, int scnt2, double offerho3, double bidho3, int offerrem3, int bidrem3, int dcnt3, int scnt3, double offerho4, double bidho4, int offerrem4, int bidrem4, int dcnt4, int scnt4, double offerho5, double bidho5, int offerrem5, int bidrem5, int dcnt5, int scnt5, int dvol, int svol, int toffernum, int tbidnum, string time, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="code">종목코드	String	Y	8</param>
/// <param name="nrec">건수	String	Y	2	t2106InBlock1	의	개수</param>
public record t2106InBlock(string code, string nrec);

/// <summary>
/// 
/// </summary>
/// <param name="indx">인덱스	String	Y	1	t2106InBlock1	의	Occurs	순서(0부터	시작)</param>
/// <param name="gubn">조건구분	String	Y	1	1:시세	2:최고저가	3:Pivot	4:이동평균선</param>
/// <param name="dat1">데이타1	String	Y	1	1:시가	2:고가	3:저가	4:가중평균가</param>
/// <param name="dat2">데이타2	String	Y	8	1:당일	2:전일</param>
public record t2106InBlock1(string indx, string gubn, string dat1, string dat2);

/// <summary>
/// 
/// </summary>
/// <param name="nrec">출력건수	String	Y	2	t2106OutBlock1	의	개수</param>
public record t2106OutBlock(string nrec);

/// <summary>
/// 
/// </summary>
/// <param name="indx">인덱스	String	Y	1	t2106InBlock1	의	indx와	동일</param>
/// <param name="gubn">조건구분	String	Y	1	1:시세	2:최고저가	3:Pivot	4:이동평균선	t2106InBlock1의	gubn과	동일</param>
/// <param name="vals">출력값	String	Y	8</param>
public record t2106OutBlock1(string indx, string gubn, string vals);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cvolume">특이거래량	Number	Y	12	체결수량	>=	cvolume</param>
/// <param name="stime">시작시간	String	Y	4	체결시간	>=	stime(hhmm)</param>
/// <param name="etime">종료시간	String	Y	4	체결시간	<=	etime(hhmm)</param>
/// <param name="cts_time">시간CTS	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t2201InBlock(string focode, long cvolume, string stime, string etime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10	연속조회키	연속	조회시	이	값을	InBlock의	cts_time	필드에	넣어준다.</param>
public record t2201OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="offerho">매도호가	Number	Y	6.2</param>
/// <param name="bidho">매수호가	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="jnilopenupdn">미결전일증감	Number	Y	8</param>
/// <param name="ibasis">이론BASIS	Number	Y	6.2</param>
/// <param name="sbasis">시장BASIS	Number	Y	6.2</param>
/// <param name="kasis">괴리율	Number	Y	6.2</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="j_openupdn">미결직전증감	Number	Y	8</param>
/// <param name="n_msvolume">누적매수체결량	Number	Y	12</param>
/// <param name="n_mdvolume">누적매도체결량	Number	Y	12</param>
/// <param name="s_msvolume">누적순매수체결량	Number	Y	12</param>
/// <param name="n_mschecnt">누적매수체결건수	Number	Y	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	Number	Y	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	Number	Y	8</param>
public record t2201OutBlock1(string chetime, double price, string sign, double change, int cvolume, double chdegree, double offerho, double bidho, long volume, int openyak, int jnilopenupdn, double ibasis, double sbasis, double kasis, long value, int j_openupdn, long n_msvolume, long n_mdvolume, long s_msvolume, int n_mschecnt, int n_mdchecnt, int s_mschecnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="futcheck">선물최근월물	String	Y	1	0:default	1:최근월물만연결</param>
/// <param name="date">날짜	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_code	값으로	설정</param>
/// <param name="lastdate">전종목만기일	String	Y	8</param>
/// <param name="cnt">조회요청건수	Object	Y	3</param>
public record t2203InBlock(string shcode, string futcheck, string date, string cts_code, string lastdate, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	date	필드에	넣어준다.</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	cts_code	필드에	넣어준다.</param>
/// <param name="lastdate">전종목만기일	String	Y	8</param>
/// <param name="nowfutyn">최근월선물여부	String	Y	1</param>
public record t2203OutBlock(string date, string cts_code, string lastdate, string nowfutyn);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="openyakupdn">미결증감	Number	Y	8</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t2203OutBlock1(string date, double open, double high, double low, double close, string sign, double change, double diff, long volume, double diff_vol, int openyak, int openyakupdn, long value);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cvolume">특이거래량	Number	Y	12	체결수량	>=	cvolume</param>
/// <param name="stime">시작시간	String	Y	4	체결시간	>=	stime(hhmm)</param>
/// <param name="etime">종료시간	String	Y	4	체결시간	<=	etime(hhmm)</param>
public record t2210InBlock(string focode, long cvolume, string stime, string etime);

/// <summary>
/// 
/// </summary>
/// <param name="mdvolume">매도체결수량	Number	Y	8</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	8</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
public record t2210OutBlock(int mdvolume, int mdchecnt, int msvolume, int mschecnt);

/// <summary>
/// 
/// </summary>
/// <param name="yyyymm">월물	String	Y	6	ex)	미니,정규	:	'200604'	위클리	:	'W1	'</param>
/// <param name="gubun">미니구분(M:미니G:정규)	String	Y	1	M:	미니	G:	정규	W:	위클리</param>
public record t2301InBlock(string yyyymm, string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="histimpv">역사적변동성	Number	Y	4</param>
/// <param name="jandatecnt">옵션잔존일	Number	Y	4</param>
/// <param name="cimpv">콜옵션대표IV	Number	Y	6.3</param>
/// <param name="pimpv">풋옵션대표IV	Number	Y	6.3</param>
/// <param name="gmprice">근월물현재가	Number	Y	6.2</param>
/// <param name="gmsign">근월물전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="gmchange">근월물전일대비	Number	Y	6.2</param>
/// <param name="gmdiff">근월물등락율	Number	Y	6.2</param>
/// <param name="gmvolume">근월물거래량	Number	Y	12</param>
/// <param name="gmshcode">근월물선물코드	String	Y	8</param>
public record t2301OutBlock(int histimpv, int jandatecnt, double cimpv, double pimpv, double gmprice, string gmsign, double gmchange, double gmdiff, long gmvolume, string gmshcode);

/// <summary>
/// 
/// </summary>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="optcode">콜옵션코드	String	Y	8</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="iv">IV	Number	Y	6.2</param>
/// <param name="mgjv">미결제약정	Number	Y	12</param>
/// <param name="mgjvupdn">미결제약정증감	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	6.2</param>
/// <param name="bidho1">매수호가	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	12</param>
/// <param name="delt">델타	Number	Y	6.4</param>
/// <param name="gama">감마	Number	Y	6.4</param>
/// <param name="vega">베가	Number	Y	6.4</param>
/// <param name="ceta">쎄타	Number	Y	6.4</param>
/// <param name="rhox">로우	Number	Y	6.4</param>
/// <param name="theoryprice">이론가	Number	Y	6.2</param>
/// <param name="impv">내재가치	Number	Y	6.2</param>
/// <param name="timevl">시간가치	Number	Y	6.2</param>
/// <param name="jvolume">잔고수량	Number	Y	12</param>
/// <param name="parpl">평가손익	Number	Y	12</param>
/// <param name="jngo">청산가능수량	Number	Y	6</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="atmgubun">ATM구분	String	Y	1	0:선물	1:ATM	2:ITM	3:OTM</param>
/// <param name="jisuconv">지수환산	Number	Y	6.2</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t2301OutBlock1(double actprice, string optcode, double price, string sign, double change, double diff, long volume, double iv, long mgjv, long mgjvupdn, double offerho1, double bidho1, long cvolume, double delt, double gama, double vega, double ceta, double rhox, double theoryprice, double impv, double timevl, long jvolume, long parpl, int jngo, long offerrem1, long bidrem1, double open, double high, double low, string atmgubun, double jisuconv, long value);

/// <summary>
/// 
/// </summary>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="optcode">풋옵션코드	String	Y	8</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="iv">IV	Number	Y	6.2</param>
/// <param name="mgjv">미결제약정	Number	Y	12</param>
/// <param name="mgjvupdn">미결제약정증감	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	6.2</param>
/// <param name="bidho1">매수호가	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	12</param>
/// <param name="delt">델타	Number	Y	6.4</param>
/// <param name="gama">감마	Number	Y	6.4</param>
/// <param name="vega">베가	Number	Y	6.4</param>
/// <param name="ceta">쎄타	Number	Y	6.4</param>
/// <param name="rhox">로우	Number	Y	6.4</param>
/// <param name="theoryprice">이론가	Number	Y	6.2</param>
/// <param name="impv">내재가치	Number	Y	6.2</param>
/// <param name="timevl">시간가치	Number	Y	6.2</param>
/// <param name="jvolume">잔고수량	Number	Y	12</param>
/// <param name="parpl">평가손익	Number	Y	12</param>
/// <param name="jngo">청산가능수량	Number	Y	6</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="atmgubun">ATM구분	String	Y	1	0:선물	1:ATM	2:ITM	3:OTM</param>
/// <param name="jisuconv">지수환산	Number	Y	6.2</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t2301OutBlock2(double actprice, string optcode, double price, string sign, double change, double diff, long volume, double iv, long mgjv, long mgjvupdn, double offerho1, double bidho1, long cvolume, double delt, double gama, double vega, double ceta, double rhox, double theoryprice, double impv, double timevl, long jvolume, long parpl, int jngo, long offerrem1, long bidrem1, double open, double high, double low, string atmgubun, double jisuconv, long value);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="bgubun">분구분	String	Y	1	0:30초	1:분</param>
/// <param name="nmin">N분	Object	Y	2	bgubun	=	1	인	경우	N분	입력값</param>
/// <param name="etime">종료시간	String	Y	4	etime	이전	시간대를	조회함</param>
/// <param name="hgubun">호가구분	String	Y	1	0@총	호가잔량	1@1차	호가잔량	2@2차	호가잔량	3@3차	호가잔량	4@4차	호가잔량	5@5차	호가잔량</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
/// <param name="cts_time">시간CTS	String	Y	6	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t2405InBlock(string focode, string bgubun, object nmin, string etime, string hgubun, object cnt, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="mdvolume">매도체결수량	Number	Y	12</param>
/// <param name="mdchecnt">매도체결건수	Number	Y	8</param>
/// <param name="msvolume">매수체결수량	Number	Y	12</param>
/// <param name="mschecnt">매수체결건수	Number	Y	8</param>
/// <param name="cts_time">시간CTS	String	Y	6	연속조회키	연속	조회시	이	값을	InBlock의	cts_time	필드에	넣어준다.</param>
public record t2405OutBlock(long mdvolume, int mdchecnt, long msvolume, int mschecnt, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="offerho1">매도1호가	Number	Y	6.2</param>
/// <param name="bidho1">매수1호가	Number	Y	6.2</param>
/// <param name="offerrem">매도수량	Number	Y	8</param>
/// <param name="bidrem">매수수량	Number	Y	8</param>
/// <param name="offercnt">매도건수	Number	Y	8</param>
/// <param name="bidcnt">매수건수	Number	Y	8</param>
/// <param name="c_offerrem">매도증감수량	Number	Y	8</param>
/// <param name="c_bidrem">매수증감수량	Number	Y	8</param>
/// <param name="c_offercnt">매도증감건수	Number	Y	8</param>
/// <param name="c_bidcnt">매수증감건수	Number	Y	8</param>
/// <param name="r_bidrem">매수수량비율	Number	Y	6.2</param>
/// <param name="r_bidcnt">매수건수비율	Number	Y	6.2</param>
/// <param name="r_sign">매수비율구분	String	Y	1	2:매수수량비율	>	100	5:매수수량비율	<=	100</param>
/// <param name="date">일자	Object	Y	8</param>
public record t2405OutBlock1(string time, double price, string sign, double change, long volume, int cvolume, double offerho1, double bidho1, int offerrem, int bidrem, int offercnt, int bidcnt, int c_offerrem, int c_bidrem, int c_offercnt, int c_bidcnt, double r_bidrem, double r_bidcnt, string r_sign, object date);

/// <summary>
/// 
/// </summary>
/// <param name="focode">종목코드	String	Y	8</param>
/// <param name="bdgubun">분일구분	String	Y	1	0:30초	1:분	2:일</param>
/// <param name="nmin">N분	Object	Y	3	t2421InBlock.bdgubun	이	1인	경우	N분</param>
/// <param name="tcgubun">당일연결구분	String	Y	1	0:전체	1:당일</param>
/// <param name="cnt">조회건수	Object	Y	4</param>
public record t2421InBlock(string focode, string bdgubun, object nmin, string tcgubun, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="volume">누적거래량	Number	Y	15</param>
/// <param name="openyak">미결제수량	Number	Y	8</param>
public record t2421OutBlock(double price, string sign, double change, double diff, int cvolume, long volume, int openyak);

/// <summary>
/// 
/// </summary>
/// <param name="dt">일자시간	String	Y	14</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="openopenyak">미결제시량	Number	Y	8</param>
/// <param name="highopenyak">미결제고량	Number	Y	8</param>
/// <param name="lowopenyak">미결제저량	Number	Y	8</param>
/// <param name="closeopenyak">미결제종량	Number	Y	8</param>
/// <param name="openupdn">미결증감	Number	Y	8</param>
public record t2421OutBlock1(string dt, double open, double high, double low, double close, int openopenyak, int highopenyak, int lowopenyak, int closeopenyak, int openupdn);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
public record t2830InBlock(string focode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	6.2</param>
/// <param name="theoryprice">이론가	Number	Y	6.2</param>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="impv">내재가치	Number	Y	6.2</param>
/// <param name="timevl">시간가치	Number	Y	6.2</param>
/// <param name="kospijisu">KOSPI200지수	Number	Y	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	String	Y	1</param>
/// <param name="kospichange">KOSPI200전일대비	Number	Y	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	Number	Y	6.2</param>
/// <param name="cmeprice">CME야간선물현재가	Number	Y	6.2</param>
/// <param name="cmesign">CME야간선물전일대비구분	String	Y	1</param>
/// <param name="cmechange">CME야간선물전일대비	Number	Y	6.2</param>
/// <param name="cmediff">CME야간선물등락율	Number	Y	6.2</param>
/// <param name="cmefocode">CME야간선물종목코드	String	Y	8</param>
/// <param name="uplmtprice">정규장적용상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice">정규장적용하한가	Number	Y	6.2</param>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="yeprice">예상체결가	Number	Y	6.2</param>
/// <param name="ysign">전일대비구분	String	Y	1</param>
/// <param name="ychange">전일대비	Number	Y	6.2</param>
/// <param name="ydiff">등락율	Number	Y	6.2</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="jnilvolume">전일거래량	Number	Y	12</param>
/// <param name="jnilvalue">전일거래대금	Number	Y	12</param>
/// <param name="uplmtprice_3rd">정규장3단계상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice_3rd">정규장3단계하한가	Number	Y	6.2</param>
public record t2830OutBlock(string hname, double price, string sign, double change, double jnilclose, double diff, long volume, long value, double open, double high, double low, double recprice, double theoryprice, double actprice, double impv, double timevl, double kospijisu, string kospisign, double kospichange, double kospidiff, double cmeprice, string cmesign, double cmechange, double cmediff, string cmefocode, double uplmtprice, double dnlmtprice, string focode, double yeprice, string ysign, double ychange, double ydiff, string danhochk, long jnilvolume, long jnilvalue, double uplmtprice_3rd, double dnlmtprice_3rd);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
public record t2831InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="offerho1">매도호가1	Number	Y	6.2</param>
/// <param name="bidho1">매수호가1	Number	Y	6.2</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	8</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	8</param>
/// <param name="dcnt1">매도호가건수1	Number	Y	8</param>
/// <param name="scnt1">매수호가건수1	Number	Y	8</param>
/// <param name="offerho2">매도호가2	Number	Y	6.2</param>
/// <param name="bidho2">매수호가2	Number	Y	6.2</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	8</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	8</param>
/// <param name="dcnt2">매도호가건수2	Number	Y	8</param>
/// <param name="scnt2">매수호가건수2	Number	Y	8</param>
/// <param name="offerho3">매도호가3	Number	Y	6.2</param>
/// <param name="bidho3">매수호가3	Number	Y	6.2</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	8</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	8</param>
/// <param name="dcnt3">매도호가건수3	Number	Y	8</param>
/// <param name="scnt3">매수호가건수3	Number	Y	8</param>
/// <param name="offerho4">매도호가4	Number	Y	6.2</param>
/// <param name="bidho4">매수호가4	Number	Y	6.2</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	8</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	8</param>
/// <param name="dcnt4">매도호가건수4	Number	Y	8</param>
/// <param name="scnt4">매수호가건수4	Number	Y	8</param>
/// <param name="offerho5">매도호가5	Number	Y	6.2</param>
/// <param name="bidho5">매수호가5	Number	Y	6.2</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	8</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	8</param>
/// <param name="dcnt5">매도호가건수5	Number	Y	8</param>
/// <param name="scnt5">매수호가건수5	Number	Y	8</param>
/// <param name="dvol">매도호가총수량	Number	Y	8</param>
/// <param name="svol">매수호가총수량	Number	Y	8</param>
/// <param name="toffernum">총매도호가건수	Number	Y	8</param>
/// <param name="tbidnum">총매수호가건수	Number	Y	8</param>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="shcode">단축코드	String	Y	8</param>
public record t2831OutBlock(string hname, double price, string sign, double change, double diff, long volume, double jnilclose, double offerho1, double bidho1, int offerrem1, int bidrem1, int dcnt1, int scnt1, double offerho2, double bidho2, int offerrem2, int bidrem2, int dcnt2, int scnt2, double offerho3, double bidho3, int offerrem3, int bidrem3, int dcnt3, int scnt3, double offerho4, double bidho4, int offerrem4, int bidrem4, int dcnt4, int scnt4, double offerho5, double bidho5, int offerrem5, int bidrem5, int dcnt5, int scnt5, int dvol, int svol, int toffernum, int tbidnum, string time, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cvolume">특이거래량	Number	Y	12	체결수량	>=	cvolume</param>
/// <param name="stime">시작시간	String	Y	4	체결시간	>=	stime(hhmm)</param>
/// <param name="etime">종료시간	String	Y	4	체결시간	<=	etime(hhmm)</param>
/// <param name="cts_time">시간CTS	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t2832InBlock(string focode, long cvolume, string stime, string etime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10	연속조회키	연속	조회시	이	값을	InBlock의	cts_time	필드에	넣어준다.</param>
public record t2832OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="offerho">매도호가	Number	Y	6.2</param>
/// <param name="bidho">매수호가	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="n_msvolume">누적매수체결량	Number	Y	12</param>
/// <param name="n_mdvolume">누적매도체결량	Number	Y	12</param>
/// <param name="s_msvolume">누적순매수체결량	Number	Y	12</param>
/// <param name="n_mschecnt">누적매수체결건수	Number	Y	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	Number	Y	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	Number	Y	8</param>
public record t2832OutBlock1(string chetime, double price, string sign, double change, int cvolume, double chdegree, double offerho, double bidho, long volume, long n_msvolume, long n_mdvolume, long s_msvolume, int n_mschecnt, int n_mdchecnt, int s_mschecnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="futcheck">선물최근월물	String	Y	1	사용안함</param>
/// <param name="date">날짜	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_code	값으로	설정</param>
/// <param name="lastdate">전종목만기일	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	lastdate	값으로	설정</param>
/// <param name="cnt">조회요청건수	Object	Y	3</param>
public record t2833InBlock(string shcode, string futcheck, string date, string cts_code, string lastdate, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	date	필드에	넣어준다.</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	cts_code	필드에	넣어준다.</param>
/// <param name="lastdate">전종목만기일	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	lastdate	필드에	넣어준다.</param>
/// <param name="nowfutyn">최근월선물여부	String	Y	1</param>
public record t2833OutBlock(string date, string cts_code, string lastdate, string nowfutyn);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
public record t2833OutBlock1(string date, double open, double high, double low, double close, string sign, double change, double diff, long volume, double diff_vol);

/// <summary>
/// 
/// </summary>
/// <param name="yyyymm">월물(혹은주물WN)	String	Y	6	YYYYMM(예	201210)</param>
/// <param name="gubun">구분(G:원지수W:위클리)	String	Y	1</param>
/// <param name="gmprice">근월물현재가	Number	Y	6.2</param>
/// <param name="gmsign">근월물전일대비구분	String	Y	1</param>
/// <param name="gmchange">근월물전일대비	Number	Y	6.2</param>
/// <param name="gmdiff">근월물등락율	Number	Y	6.2</param>
/// <param name="gmvolume">근월물거래량	Number	Y	12</param>
/// <param name="gmshcode">근월물선물코드	String	Y	8</param>
public record t2835InBlock(string yyyymm, string gubun, double gmprice, string gmsign, double gmchange, double gmdiff, long gmvolume, string gmshcode);

/// <summary>
/// 
/// </summary>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="optcode">콜옵션코드	String	Y	8</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	6.2</param>
/// <param name="bidho1">매수호가	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	12</param>
/// <param name="impv">내재가치	Number	Y	6.2</param>
/// <param name="timevl">시간가치	Number	Y	6.2</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="atmgubun">ATM구분	String	Y	1</param>
/// <param name="jisuconv">지수환산	Number	Y	6.2</param>
public record t2835OutBlock1(double actprice, string optcode, double price, string sign, double change, double diff, long volume, double offerho1, double bidho1, long cvolume, double impv, double timevl, long offerrem1, long bidrem1, double open, double high, double low, string atmgubun, double jisuconv);

/// <summary>
/// 
/// </summary>
/// <param name="actprice">행사가	Number	Y	6.2</param>
/// <param name="optcode">풋옵션코드	String	Y	8</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="offerho1">매도호가	Number	Y	6.2</param>
/// <param name="bidho1">매수호가	Number	Y	6.2</param>
/// <param name="cvolume">체결량	Number	Y	12</param>
/// <param name="impv">내재가치	Number	Y	6.2</param>
/// <param name="timevl">시간가치	Number	Y	6.2</param>
/// <param name="offerrem1">매도잔량	Number	Y	12</param>
/// <param name="bidrem1">매수잔량	Number	Y	12</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="atmgubun">ATM구분	String	Y	1</param>
/// <param name="jisuconv">지수환산	Number	Y	6.2</param>
public record t2835OutBlock2(double actprice, string optcode, double price, string sign, double change, double diff, long volume, double offerho1, double bidho1, long cvolume, double impv, double timevl, long offerrem1, long bidrem1, double open, double high, double low, string atmgubun, double jisuconv);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t8401InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="basecode">기초자산코드	String	Y	9</param>
public record t8401OutBlock(string hname, string shcode, string expcode, string basecode);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
public record t8402InBlock(string focode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	Number	Y	6.2</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="mgjv">미결제량	Number	Y	8</param>
/// <param name="mgjvdiff">미결제증감	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="uplmtprice">상한가	Number	Y	8</param>
/// <param name="dnlmtprice">하한가	Number	Y	8</param>
/// <param name="high52w">52최고가	Number	Y	8</param>
/// <param name="low52w">52최저가	Number	Y	8</param>
/// <param name="basis">베이시스	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	8</param>
/// <param name="theoryprice">이론가	Number	Y	8</param>
/// <param name="glyl">괴리율	Number	Y	6.3</param>
/// <param name="lastmonth">만기일	String	Y	8</param>
/// <param name="jandatecnt">잔여일	Number	Y	8</param>
/// <param name="pricejisu">종합지수	Number	Y	6.2</param>
/// <param name="jisusign">종합지수전일대비구분	String	Y	1</param>
/// <param name="jisuchange">종합지수전일대비	Number	Y	6.2</param>
/// <param name="jisudiff">종합지수등락율	Number	Y	6.2</param>
/// <param name="kospijisu">KOSPI200지수	Number	Y	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	String	Y	1</param>
/// <param name="kospichange">KOSPI200전일대비	Number	Y	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	Number	Y	6.2</param>
/// <param name="listhprice">상장최고가	Number	Y	8</param>
/// <param name="listlprice">상장최저가	Number	Y	8</param>
/// <param name="delt">델타	Number	Y	6.4</param>
/// <param name="gama">감마	Number	Y	6.4</param>
/// <param name="ceta">세타	Number	Y	6.4</param>
/// <param name="vega">베가	Number	Y	6.4</param>
/// <param name="rhox">로우	Number	Y	6.4</param>
/// <param name="gmprice">근월물현재가	Number	Y	8</param>
/// <param name="gmsign">근월물전일대비구분	String	Y	1</param>
/// <param name="gmchange">근월물전일대비	Number	Y	8</param>
/// <param name="gmdiff">근월물등락율	Number	Y	6.2</param>
/// <param name="theorypriceg">이론가	Number	Y	8</param>
/// <param name="histimpv">역사적변동성	Number	Y	6.2</param>
/// <param name="impv">내재변동성	Number	Y	6.2</param>
/// <param name="sbasis">시장BASIS	Number	Y	8</param>
/// <param name="ibasis">이론BASIS	Number	Y	8</param>
/// <param name="gmfutcode">근월물종목코드	String	Y	8</param>
/// <param name="actprice">행사가	Number	Y	8</param>
/// <param name="shcode">기초자산단축코드	String	Y	6</param>
/// <param name="basehname">기초자산한글명	String	Y	20</param>
/// <param name="baseprice">기초자산현재가	Number	Y	8</param>
/// <param name="basesign">기초자산현재가대비구분	String	Y	1</param>
/// <param name="basechange">기초자산현재가전일대비	Number	Y	8</param>
/// <param name="basediff">기초자산등락률	Number	Y	6.2</param>
/// <param name="basevol">기초자산거래량	Number	Y	12</param>
/// <param name="baseprevol">기초자산전일거래량	Number	Y	12</param>
/// <param name="basebidprc">기초자산매수호가	Number	Y	9</param>
/// <param name="baseaskprc">기초자산매도호가	Number	Y	9</param>
/// <param name="basefornetbid">기초자산외국계회원사순매수	Number	Y	12</param>
/// <param name="prodgrp">상품군	String	Y	20</param>
/// <param name="mulcnt">승수	Number	Y	12.8</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="yeprice">예상체결가	Number	Y	8</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilychange">예상체결가전일종가대비	Number	Y	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	Number	Y	6.2</param>
public record t8402OutBlock(string hname, int price, string sign, int change, int jnilclose, double diff, long volume, double stimeqrt, long value, int mgjv, int mgjvdiff, int open, int high, int low, int uplmtprice, int dnlmtprice, int high52w, int low52w, double basis, int recprice, int theoryprice, double glyl, string lastmonth, int jandatecnt, double pricejisu, string jisusign, double jisuchange, double jisudiff, double kospijisu, string kospisign, double kospichange, double kospidiff, int listhprice, int listlprice, double delt, double gama, double ceta, double vega, double rhox, int gmprice, string gmsign, int gmchange, double gmdiff, int theorypriceg, double histimpv, double impv, int sbasis, int ibasis, string gmfutcode, int actprice, string shcode, string basehname, int baseprice, string basesign, int basechange, double basediff, long basevol, long baseprevol, long basebidprc, long baseaskprc, long basefornetbid, string prodgrp, double mulcnt, string danhochk, int yeprice, string jnilysign, int jnilychange, double jnilydrate);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
public record t8403InBlock(string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	8</param>
/// <param name="offerho1">매도호가1	Number	Y	8</param>
/// <param name="bidho1">매수호가1	Number	Y	8</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	8</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	8</param>
/// <param name="dcnt1">매도호가건수1	Number	Y	8</param>
/// <param name="scnt1">매수호가건수1	Number	Y	8</param>
/// <param name="offerho2">매도호가2	Number	Y	8</param>
/// <param name="bidho2">매수호가2	Number	Y	8</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	8</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	8</param>
/// <param name="dcnt2">매도호가건수2	Number	Y	8</param>
/// <param name="scnt2">매수호가건수2	Number	Y	8</param>
/// <param name="offerho3">매도호가3	Number	Y	8</param>
/// <param name="bidho3">매수호가3	Number	Y	8</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	8</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	8</param>
/// <param name="dcnt3">매도호가건수3	Number	Y	8</param>
/// <param name="scnt3">매수호가건수3	Number	Y	8</param>
/// <param name="offerho4">매도호가4	Number	Y	8</param>
/// <param name="bidho4">매수호가4	Number	Y	8</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	8</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	8</param>
/// <param name="dcnt4">매도호가건수4	Number	Y	8</param>
/// <param name="scnt4">매수호가건수4	Number	Y	8</param>
/// <param name="offerho5">매도호가5	Number	Y	8</param>
/// <param name="bidho5">매수호가5	Number	Y	8</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	8</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	8</param>
/// <param name="dcnt5">매도호가건수5	Number	Y	8</param>
/// <param name="scnt5">매수호가건수5	Number	Y	8</param>
/// <param name="offerho6">매도호가6	Number	Y	8</param>
/// <param name="bidho6">매수호가6	Number	Y	8</param>
/// <param name="offerrem6">매도호가수량6	Number	Y	8</param>
/// <param name="bidrem6">매수호가수량6	Number	Y	8</param>
/// <param name="dcnt6">매도호가건수6	Number	Y	8</param>
/// <param name="scnt6">매수호가건수6	Number	Y	8</param>
/// <param name="offerho7">매도호가7	Number	Y	8</param>
/// <param name="bidho7">매수호가7	Number	Y	8</param>
/// <param name="offerrem7">매도호가수량7	Number	Y	8</param>
/// <param name="bidrem7">매수호가수량7	Number	Y	8</param>
/// <param name="dcnt7">매도호가건수7	Number	Y	8</param>
/// <param name="scnt7">매수호가건수7	Number	Y	8</param>
/// <param name="offerho8">매도호가8	Number	Y	8</param>
/// <param name="bidho8">매수호가8	Number	Y	8</param>
/// <param name="offerrem8">매도호가수량8	Number	Y	8</param>
/// <param name="bidrem8">매수호가수량8	Number	Y	8</param>
/// <param name="dcnt8">매도호가건수8	Number	Y	8</param>
/// <param name="scnt8">매수호가건수8	Number	Y	8</param>
/// <param name="offerho9">매도호가9	Number	Y	8</param>
/// <param name="bidho9">매수호가9	Number	Y	8</param>
/// <param name="offerrem9">매도호가수량9	Number	Y	8</param>
/// <param name="bidrem9">매수호가수량9	Number	Y	8</param>
/// <param name="dcnt9">매도호가건수9	Number	Y	8</param>
/// <param name="scnt9">매수호가건수9	Number	Y	8</param>
/// <param name="offerho10">매도호가10	Number	Y	8</param>
/// <param name="bidho10">매수호가10	Number	Y	8</param>
/// <param name="offerrem10">매도호가수량10	Number	Y	8</param>
/// <param name="bidrem10">매수호가수량10	Number	Y	8</param>
/// <param name="dcnt10">매도호가건수10	Number	Y	8</param>
/// <param name="scnt10">매수호가건수10	Number	Y	8</param>
/// <param name="dvol">매도호가총수량	Number	Y	8</param>
/// <param name="svol">매수호가총수량	Number	Y	8</param>
/// <param name="toffernum">총매도호가건수	Number	Y	8</param>
/// <param name="tbidnum">총매수호가건수	Number	Y	8</param>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record t8403OutBlock(string hname, int price, string sign, int change, double diff, long volume, double stimeqrt, int jnilclose, int offerho1, int bidho1, int offerrem1, int bidrem1, int dcnt1, int scnt1, int offerho2, int bidho2, int offerrem2, int bidrem2, int dcnt2, int scnt2, int offerho3, int bidho3, int offerrem3, int bidrem3, int dcnt3, int scnt3, int offerho4, int bidho4, int offerrem4, int bidrem4, int dcnt4, int scnt4, int offerho5, int bidho5, int offerrem5, int bidrem5, int dcnt5, int scnt5, int offerho6, int bidho6, int offerrem6, int bidrem6, int dcnt6, int scnt6, int offerho7, int bidho7, int offerrem7, int bidrem7, int dcnt7, int scnt7, int offerho8, int bidho8, int offerrem8, int bidrem8, int dcnt8, int scnt8, int offerho9, int bidho9, int offerrem9, int bidrem9, int dcnt9, int scnt9, int offerho10, int bidho10, int offerrem10, int bidrem10, int dcnt10, int scnt10, int dvol, int svol, int toffernum, int tbidnum, string time, string shcode);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cvolume">특이거래량	Number	Y	12	거래량	>	특이거래량</param>
/// <param name="stime">시작시간	String	Y	4	장시작시간	이후</param>
/// <param name="etime">종료시간	String	Y	4	장종료시간	이전</param>
/// <param name="cts_time">시간CTS	String	Y	10	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_time	값으로	설정</param>
public record t8404InBlock(string focode, long cvolume, string stime, string etime, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="cts_time">시간CTS	String	Y	10	연속조회키	연속	조회시	이	값을	InBlock의	cts_time	필드에	넣어준다.</param>
public record t8404OutBlock(string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="chdegree">체결강도	Number	Y	8.2</param>
/// <param name="offerho">매도호가	Number	Y	8</param>
/// <param name="bidho">매수호가	Number	Y	8</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="jnilopenupdn">미결전일증감	Number	Y	8</param>
/// <param name="ibasis">이론BASIS	Number	Y	8</param>
/// <param name="sbasis">시장BASIS	Number	Y	8</param>
/// <param name="kasis">괴리율	Number	Y	6.2</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="j_openupdn">미결직전증감	Number	Y	8</param>
/// <param name="n_msvolume">누적매수체결량	Number	Y	12</param>
/// <param name="n_mdvolume">누적매도체결량	Number	Y	12</param>
/// <param name="s_msvolume">누적순매수체결량	Number	Y	12</param>
/// <param name="n_mschecnt">누적매수체결건수	Number	Y	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	Number	Y	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	Number	Y	8</param>
public record t8404OutBlock1(string chetime, int price, string sign, int change, int cvolume, double chdegree, int offerho, int bidho, long volume, int openyak, int jnilopenupdn, int ibasis, int sbasis, double kasis, long value, int j_openupdn, long n_msvolume, long n_mdvolume, long s_msvolume, int n_mschecnt, int n_mdchecnt, int s_mschecnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="futcheck">선물최근월물	String	Y	1	0:default	1:최근월물만연결</param>
/// <param name="date">날짜	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	date	값으로	설정</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_code	값으로	설정</param>
/// <param name="lastdate">전종목만기일	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	lastdate	값으로	설정</param>
/// <param name="cnt">조회요청건수	Object	Y	3</param>
public record t8405InBlock(string shcode, string futcheck, string date, string cts_code, string lastdate, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	date	필드에	넣어준다.</param>
/// <param name="cts_code">CTS종목코드	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	cts_code	필드에	넣어준다.</param>
/// <param name="lastdate">전종목만기일	String	Y	8	연속조회키	연속	조회시	이	값을	InBlock의	lastdate	필드에	넣어준다.</param>
/// <param name="nowfutyn">최근월선물여부	String	Y	1</param>
public record t8405OutBlock(string date, string cts_code, string lastdate, string nowfutyn);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="close">종가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="openyakupdn">미결증감	Number	Y	8</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t8405OutBlock1(string date, int open, int high, int low, int close, string sign, int change, double diff, long volume, double diff_vol, int openyak, int openyakupdn, long value);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cgubun">챠트구분	String	Y	1	T:틱차트	B:분차트</param>
/// <param name="bgubun">분구분	Object	Y	3	차트구분이	'B'일때만	체크	0:	30초	0초과	:	n분</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
public record t8406InBlock(string focode, string cgubun, object bgubun, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1	1:상한	2:상승	3:보합	4:하한	5:하락</param>
/// <param name="change">전일대비	Number	Y	8</param>
/// <param name="open">시가	Number	Y	8</param>
/// <param name="high">고가	Number	Y	8</param>
/// <param name="low">저가	Number	Y	8</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="openupdn">미결증감	Number	Y	8</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="s_mschecnt">매수순간체결건수	Number	Y	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	Number	Y	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	Number	Y	8</param>
/// <param name="s_mschevol">매수순간체결량	Number	Y	12</param>
/// <param name="s_mdchevol">매도순간체결량	Number	Y	12</param>
/// <param name="ss_mschevol">순매수순간체결량	Number	Y	12</param>
/// <param name="chdegvol">체결강도(거래량)	Number	Y	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	Number	Y	8.2</param>
public record t8406OutBlock1(string chetime, int price, string sign, int change, int open, int high, int low, long volume, long value, int openyak, int openupdn, int cvolume, int s_mschecnt, int s_mdchecnt, int ss_mschecnt, long s_mschevol, long s_mdchevol, long ss_mschevol, double chdegvol, double chdegcnt);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t8426InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
public record t8426OutBlock(string hname, string shcode, string expcode);

/// <summary>
/// 
/// </summary>
/// <param name="fo_gbn">선물옵션구분	String	Y	1	F:선물	O:옵션</param>
/// <param name="yyyy">조회년도	String	Y	4	YYYY</param>
/// <param name="mm">조회월	String	Y	2	MM</param>
/// <param name="cp_gbn">옵션콜풋구분	String	Y	1	2:콜	3:풋</param>
/// <param name="actprice">옵션행사가	Number	Y	6.2</param>
/// <param name="focode">선물옵션코드	String	Y	8</param>
/// <param name="dt_gbn">일분구분	String	Y	1	D:일	M:분</param>
/// <param name="min_term">분간격	String	Y	2</param>
/// <param name="date">날짜	String	Y	8	다음	조회시	OutBlock의	date	값	입력	처음	조회시	Space</param>
/// <param name="time">시간	String	Y	6	다음	조회시	OutBlock의	time	값	입력	처음	조회시	Space</param>
public record t8427InBlock(string fo_gbn, string yyyy, string mm, string cp_gbn, double actprice, string focode, string dt_gbn, string min_term, string date, string time);

/// <summary>
/// 
/// </summary>
/// <param name="focode">선물옵션코드	String	Y	8</param>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
public record t8427OutBlock(string focode, string date, string time);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="diff_vol">거래증가율	Number	Y	10.2</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="openyakupdn">미결증감	Number	Y	8</param>
/// <param name="value">거래대금	Number	Y	12</param>
public record t8427OutBlock1(string date, string time, double open, double high, double low, double close, string sign, double change, double diff, long volume, double diff_vol, int openyak, int openyakupdn, long value);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	V:변동성지수선물	S:섹터지수선물	그	이외의	값은	코스피200지수선물</param>
public record t8432InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="uplmtprice">상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice">하한가	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="jnilhigh">전일고가	Number	Y	6.2</param>
/// <param name="jnillow">전일저가	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	6.2</param>
public record t8432OutBlock(string hname, string shcode, string expcode, double uplmtprice, double dnlmtprice, double jnilclose, double jnilhigh, double jnillow, double recprice);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t8433InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="hprice">상한가	Number	Y	6.2</param>
/// <param name="lprice">하한가	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="jnilhigh">전일고가	Number	Y	6.2</param>
/// <param name="jnillow">전일저가	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	6.2</param>
public record t8433OutBlock(string hname, string shcode, string expcode, double hprice, double lprice, double jnilclose, double jnilhigh, double jnillow, double recprice);

/// <summary>
/// 
/// </summary>
/// <param name="qrycnt">건수	Number	Y	3	최대50개까지</param>
/// <param name="focode">단축코드	String	Y	400	구분자	없이	종목코드를	붙여서	입력</param>
public record t8434InBlock(int qrycnt, string focode);

/// <summary>
/// 
/// </summary>
/// <param name="hname">한글명	String	Y	20</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	12</param>
/// <param name="checnt">체결건수	Number	Y	8</param>
/// <param name="focode">단축코드	String	Y	8</param>
public record t8434OutBlock1(string hname, double price, string sign, double change, double diff, long volume, int checnt, string focode);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분(MF/MO)	String	Y	2	MF	:	미니선물	MO	:	미니옵션	WK	:	위클리옵션	SF	:	코스닥150선물</param>
public record t8435InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
/// <param name="uplmtprice">상한가	Number	Y	6.2</param>
/// <param name="dnlmtprice">하한가	Number	Y	6.2</param>
/// <param name="jnilclose">전일종가	Number	Y	6.2</param>
/// <param name="jnilhigh">전일고가	Number	Y	6.2</param>
/// <param name="jnillow">전일저가	Number	Y	6.2</param>
/// <param name="recprice">기준가	Number	Y	6.2</param>
public record t8435OutBlock(string hname, string shcode, string expcode, double uplmtprice, double dnlmtprice, double jnilclose, double jnilhigh, double jnillow, double recprice);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분(NF/NC/NM/NO)	String	Y	2	NF:200선물	NM:미니200선물	NO:200옵션</param>
public record t8437InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">종목코드	String	Y	8</param>
/// <param name="expcode">표준코드	String	Y	12</param>
/// <param name="tradeunit">거래승수	Number	Y	21.8</param>
/// <param name="atmgb">ATM구분(1:ATM2:ITM3:OTM)	String	Y	1</param>
public record t8437OutBlock(string hname, string shcode, string expcode, double tradeunit, string atmgb);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">구분	String	Y	1	V:변동성지수선물	S:섹터지수선물	그	이외의	값은	코스피200지수선물</param>
public record t9943InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
public record t9943OutBlock(string hname, string shcode, string expcode);

/// <summary>
/// 
/// </summary>
/// <param name="dummy">Dummy	String	Y	1</param>
public record t9944InBlock(string dummy);

/// <summary>
/// 
/// </summary>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="expcode">확장코드	String	Y	12</param>
public record t9944OutBlock(string hname, string shcode, string expcode);

#endregion

#region [선물/옵션] 투자자

/// <summary>
/// 
/// </summary>
/// <param name="eitem">상품ID	String	Y	2	01@KTB	02@5TB	03@LKTB	04@USD	05@JPY	06@EUR	07@GOLD	08@LH	09@MGD</param>
/// <param name="market">시장구분	String	Y	1	0@선물	1@콜	2@풋</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="gubun1">수량구분	String	Y	1</param>
/// <param name="gubun2">전일분구분	String	Y	1</param>
/// <param name="cts_time">CTSTIME	String	Y	8</param>
/// <param name="cts_idx">CTSIDX	Number	Y	4</param>
/// <param name="cnt">조회건수	Object	Y	4</param>
public record t2541InBlock(string eitem, string market, string upcode, string gubun1, string gubun2, string cts_time, int cts_idx, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="eitem">상품ID	String	Y	2</param>
/// <param name="sgubun">시장구분	String	Y	1</param>
/// <param name="cts_time">CTSTIME	String	Y	8</param>
/// <param name="tjjcode_08">개인투자자코드	String	Y	4</param>
/// <param name="ms_08">개인매수	Number	Y	12</param>
/// <param name="md_08">개인매도	Number	Y	12</param>
/// <param name="rate_08">개인증감	Number	Y	12</param>
/// <param name="svolume_08">개인순매수	Number	Y	12</param>
/// <param name="jjcode_17">외국인투자자코드	String	Y	4</param>
/// <param name="ms_17">외국인매수	Number	Y	12</param>
/// <param name="md_17">외국인매도	Number	Y	12</param>
/// <param name="rate_17">외국인증감	Number	Y	12</param>
/// <param name="svolume_17">외국인순매수	Number	Y	12</param>
/// <param name="jjcode_18">기관계투자자코드	String	Y	4</param>
/// <param name="ms_18">기관계매수	Number	Y	12</param>
/// <param name="md_18">기관계매도	Number	Y	12</param>
/// <param name="rate_18">기관계증감	Number	Y	12</param>
/// <param name="svolume_18">기관계순매수	Number	Y	12</param>
/// <param name="jjcode_01">증권투자자코드	String	Y	4</param>
/// <param name="ms_01">증권매수	Number	Y	12</param>
/// <param name="md_01">증권매도	Number	Y	12</param>
/// <param name="rate_01">증권증감	Number	Y	12</param>
/// <param name="svolume_01">증권순매수	Number	Y	12</param>
/// <param name="jjcode_03">투신투자자코드	String	Y	4</param>
/// <param name="ms_03">투신매수	Number	Y	12</param>
/// <param name="md_03">투신매도	Number	Y	12</param>
/// <param name="rate_03">투신증감	Number	Y	12</param>
/// <param name="svolume_03">투신순매수	Number	Y	12</param>
/// <param name="jjcode_04">은행투자자코드	String	Y	4</param>
/// <param name="ms_04">은행매수	Number	Y	12</param>
/// <param name="md_04">은행매도	Number	Y	12</param>
/// <param name="rate_04">은행증감	Number	Y	12</param>
/// <param name="svolume_04">은행순매수	Number	Y	12</param>
/// <param name="jjcode_02">보험투자자코드	String	Y	4</param>
/// <param name="ms_02">보험매수	Number	Y	12</param>
/// <param name="md_02">보험매도	Number	Y	12</param>
/// <param name="rate_02">보험증감	Number	Y	12</param>
/// <param name="svolume_02">보험순매수	Number	Y	12</param>
/// <param name="jjcode_05">종금투자자코드	String	Y	4</param>
/// <param name="ms_05">종금매수	Number	Y	12</param>
/// <param name="md_05">종금매도	Number	Y	12</param>
/// <param name="rate_05">종금증감	Number	Y	12</param>
/// <param name="svolume_05">종금순매수	Number	Y	12</param>
/// <param name="jjcode_06">기금투자자코드	String	Y	4</param>
/// <param name="ms_06">기금매수	Number	Y	12</param>
/// <param name="md_06">기금매도	Number	Y	12</param>
/// <param name="rate_06">기금증감	Number	Y	12</param>
/// <param name="svolume_06">기금순매수	Number	Y	12</param>
/// <param name="jjcode_07">기타투자자코드	String	Y	4</param>
/// <param name="ms_07">기타매수	Number	Y	12</param>
/// <param name="md_07">기타매도	Number	Y	12</param>
/// <param name="rate_07">기타증감	Number	Y	12</param>
/// <param name="svolume_07">기타순매수	Number	Y	12</param>
/// <param name="jjcode_11">국가투자자코드	String	Y	4</param>
/// <param name="ms_11">국가매수	Number	Y	12</param>
/// <param name="md_11">국가매도	Number	Y	12</param>
/// <param name="rate_11">국가증감	Number	Y	12</param>
/// <param name="svolume_11">국가순매수	Number	Y	12</param>
/// <param name="jjcode_00">사모펀드코드	String	Y	4</param>
/// <param name="ms_00">사모펀드매수	Number	Y	12</param>
/// <param name="md_00">사모펀드매도	Number	Y	12</param>
/// <param name="rate_00">사모펀드증감	Number	Y	12</param>
/// <param name="svolume_00">사모펀드순매수	Number	Y	12</param>
public record t2541OutBlock(string eitem, string sgubun, string cts_time, string tjjcode_08, long ms_08, long md_08, long rate_08, long svolume_08, string jjcode_17, long ms_17, long md_17, long rate_17, long svolume_17, string jjcode_18, long ms_18, long md_18, long rate_18, long svolume_18, string jjcode_01, long ms_01, long md_01, long rate_01, long svolume_01, string jjcode_03, long ms_03, long md_03, long rate_03, long svolume_03, string jjcode_04, long ms_04, long md_04, long rate_04, long svolume_04, string jjcode_02, long ms_02, long md_02, long rate_02, long svolume_02, string jjcode_05, long ms_05, long md_05, long rate_05, long svolume_05, string jjcode_06, long ms_06, long md_06, long rate_06, long svolume_06, string jjcode_07, long ms_07, long md_07, long rate_07, long svolume_07, string jjcode_11, long ms_11, long md_11, long rate_11, long svolume_11, string jjcode_00, long ms_00, long md_00, long rate_00, long svolume_00);

/// <summary>
/// 
/// </summary>
/// <param name="time">시간	String	Y	8</param>
/// <param name="sv_08">개인순매수	Number	Y	12</param>
/// <param name="sv_17">외국인순매수	Number	Y	12</param>
/// <param name="sv_18">기관계순매수	Number	Y	12</param>
/// <param name="sv_01">증권순매수	Number	Y	12</param>
/// <param name="sv_03">투신순매수	Number	Y	12</param>
/// <param name="sv_04">은행순매수	Number	Y	12</param>
/// <param name="sv_02">보험순매수	Number	Y	12</param>
/// <param name="sv_05">종금순매수	Number	Y	12</param>
/// <param name="sv_06">기금순매수	Number	Y	12</param>
/// <param name="sv_07">기타순매수	Number	Y	12</param>
/// <param name="sv_11">국가순매수	Number	Y	12</param>
/// <param name="sv_00">사모펀드순매수	Number	Y	12</param>
public record t2541OutBlock1(string time, long sv_08, long sv_17, long sv_18, long sv_01, long sv_03, long sv_04, long sv_02, long sv_05, long sv_06, long sv_07, long sv_11, long sv_00);

/// <summary>
/// 
/// </summary>
/// <param name="eitem">상품ID	String	Y	2	01@KTB	02@5TB	03@LKTB	04@USD	05@JPY	06@EUR	07@GOLD	08@LH	09@MGD</param>
/// <param name="sgubun">시장구분	String	Y	1	0@선물	1@콜	2@풋</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="nmin">N분	Object	Y	2</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
/// <param name="bgubun">전일분	String	Y	1</param>
public record t2545InBlock(string eitem, string sgubun, string upcode, object nmin, object cnt, string bgubun);

/// <summary>
/// 
/// </summary>
/// <param name="eitem">상품ID	String	Y	2</param>
/// <param name="sgubun">시장구분	String	Y	1</param>
/// <param name="indcode">개인투자자코드	String	Y	4</param>
/// <param name="forcode">외국인투자자코드	String	Y	4</param>
/// <param name="syscode">기관계투자자코드	String	Y	4</param>
/// <param name="stocode">증권투자자코드	String	Y	4</param>
/// <param name="invcode">투신투자자코드	String	Y	4</param>
/// <param name="bancode">은행투자자코드	String	Y	4</param>
/// <param name="inscode">보험투자자코드	String	Y	4</param>
/// <param name="fincode">종금투자자코드	String	Y	4</param>
/// <param name="moncode">기금투자자코드	String	Y	4</param>
/// <param name="etccode">기타투자자코드	String	Y	4</param>
/// <param name="natcode">국가투자자코드	String	Y	4</param>
/// <param name="pefcode">사모펀드투자자코드	String	Y	4</param>
/// <param name="jisucd">기준지수코드	String	Y	8</param>
/// <param name="jisunm">기준지수명	String	Y	20</param>
public record t2545OutBlock(string eitem, string sgubun, string indcode, string forcode, string syscode, string stocode, string invcode, string bancode, string inscode, string fincode, string moncode, string etccode, string natcode, string pefcode, string jisucd, string jisunm);

/// <summary>
/// 
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="datetime">일자시간	String	Y	14</param>
/// <param name="indmsvol">개인순매수거래량	Number	Y	8</param>
/// <param name="indmsamt">개인순매수거래대금	Number	Y	12</param>
/// <param name="formsvol">외국인순매수거래량	Number	Y	8</param>
/// <param name="formsamt">외국인순매수거래대금	Number	Y	12</param>
/// <param name="sysmsvol">기관계순매수거래량	Number	Y	8</param>
/// <param name="sysmsamt">기관계순매수거래대금	Number	Y	12</param>
/// <param name="stomsvol">증권순매수거래량	Number	Y	8</param>
/// <param name="stomsamt">증권순매수거래대금	Number	Y	12</param>
/// <param name="invmsvol">투신순매수거래량	Number	Y	8</param>
/// <param name="invmsamt">투신순매수거래대금	Number	Y	12</param>
/// <param name="banmsvol">은행순매수거래량	Number	Y	8</param>
/// <param name="banmsamt">은행순매수거래대금	Number	Y	12</param>
/// <param name="insmsvol">보험순매수거래량	Number	Y	8</param>
/// <param name="insmsamt">보험순매수거래대금	Number	Y	12</param>
/// <param name="finmsvol">종금순매수거래량	Number	Y	8</param>
/// <param name="finmsamt">종금순매수거래대금	Number	Y	12</param>
/// <param name="monmsvol">기금순매수거래량	Number	Y	8</param>
/// <param name="monmsamt">기금순매수거래대금	Number	Y	12</param>
/// <param name="etcmsvol">기타순매수거래량	Number	Y	8</param>
/// <param name="etcmsamt">기타순매수거래대금	Number	Y	12</param>
/// <param name="natmsvol">국가순매수거래량	Number	Y	8</param>
/// <param name="natmsamt">국가순매수거래대금	Number	Y	12</param>
/// <param name="pefmsvol">사모펀드순매수거래량	Number	Y	8</param>
/// <param name="pefmsamt">사모펀드순매수거래대금	Number	Y	12</param>
/// <param name="upclose">기준지수	Number	Y	6.2</param>
/// <param name="upcvolume">기준체결거래량	Number	Y	8</param>
/// <param name="upvolume">기준누적거래량	Number	Y	12</param>
/// <param name="upvalue">기준거래대금	Number	Y	12</param>
public record t2545OutBlock1(string date, string time, string datetime, int indmsvol, long indmsamt, int formsvol, long formsamt, int sysmsvol, long sysmsamt, int stomsvol, long stomsamt, int invmsvol, long invmsamt, int banmsvol, long banmsamt, int insmsvol, long insmsamt, int finmsvol, long finmsamt, int monmsvol, long monmsamt, int etcmsvol, long etcmsamt, int natmsvol, long natmsamt, int pefmsvol, long pefmsamt, double upclose, int upcvolume, long upvolume, long upvalue);

#endregion

#region [선물/옵션] 차트

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cgubun">챠트구분	String	Y	1	T:틱차트	B:분차트</param>
/// <param name="bgubun">분구분	Object	Y	3	차트구분이	'B'일때만	체크	0:	30초	0초과	:	n분</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
public record t2209InBlock(string focode, string cgubun, object bgubun, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="openyak">미결수량	Number	Y	8</param>
/// <param name="openupdn">미결증감	Number	Y	8</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="s_mschecnt">매수순간체결건수	Number	Y	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	Number	Y	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	Number	Y	8</param>
/// <param name="s_mschevol">매수순간체결량	Number	Y	12</param>
/// <param name="s_mdchevol">매도순간체결량	Number	Y	12</param>
/// <param name="ss_mschevol">순매수순간체결량	Number	Y	12</param>
/// <param name="chdegvol">체결강도(거래량)	Number	Y	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	Number	Y	8.2</param>
public record t2209OutBlock1(string chetime, double price, string sign, double change, double open, double high, double low, long volume, long value, int openyak, int openupdn, int cvolume, int s_mschecnt, int s_mdchecnt, int ss_mschecnt, long s_mschevol, long s_mdchevol, long ss_mschevol, double chdegvol, double chdegcnt);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="ncnt">단위(n틱)	Number	Y	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1	0:미사용</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10	N:비압축</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8414InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="jisiga">전일시가	Number	Y	6.2</param>
/// <param name="jihigh">전일고가	Number	Y	6.2</param>
/// <param name="jilow">전일저가	Number	Y	6.2</param>
/// <param name="jiclose">전일종가	Number	Y	6.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	6.2</param>
/// <param name="dihigh">당일고가	Number	Y	6.2</param>
/// <param name="dilow">당일저가	Number	Y	6.2</param>
/// <param name="diclose">당일종가	Number	Y	6.2</param>
/// <param name="highend">상한가	Number	Y	6.2</param>
/// <param name="lowend">하한가	Number	Y	6.2</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8414OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, double highend, double lowend, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	10</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="jdiff_vol">거래량	Number	Y	12</param>
/// <param name="openyak">미결제약정	Number	Y	12</param>
public record t8414OutBlock1(string date, string time, double open, double high, double low, double close, long jdiff_vol, long openyak);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="ncnt">단위(n분)	Number	Y	4	0:30초	1:	1분	2:	2분	.....	n:	n분</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	String	Y	1	0:미사용</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="stime">시작시간(현재미사용)	String	Y	6</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="etime">종료시간(현재미사용)	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8415InBlock(string shcode, int ncnt, int qrycnt, string nday, string sdate, string stime, string edate, string etime, string cts_date, string cts_time, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="jisiga">전일시가	Number	Y	6.2</param>
/// <param name="jihigh">전일고가	Number	Y	6.2</param>
/// <param name="jilow">전일저가	Number	Y	6.2</param>
/// <param name="jiclose">전일종가	Number	Y	6.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	6.2</param>
/// <param name="dihigh">당일고가	Number	Y	6.2</param>
/// <param name="dilow">당일저가	Number	Y	6.2</param>
/// <param name="diclose">당일종가	Number	Y	6.2</param>
/// <param name="highend">상한가	Number	Y	6.2</param>
/// <param name="lowend">하한가	Number	Y	6.2</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8415OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, double highend, double lowend, string cts_date, string cts_time, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	10</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="jdiff_vol">누적거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="openyak">미결제약정	Number	Y	12</param>
public record t8415OutBlock1(string date, string time, double open, double high, double low, double close, long jdiff_vol, long value, long openyak);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	String	Y	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	Number	Y	4	요청건수	압축모듈인	경우	최대	2000건까지	조회가능.	비압축인	경우	최대	500건까지	조회가능</param>
/// <param name="sdate">시작일자	String	Y	8	기본값	:	Space	(edate(필수입력)	기준으로	qrycnt	만큼	조회)	조회구간을	설정하여	필터링	하고	싶은	경우	입력</param>
/// <param name="edate">종료일자	String	Y	8	처음조회기준일(LE)	처음조회일	경우	이	값	기준으로	조회	("99999999"	혹은	'당일')</param>
/// <param name="cts_date">연속일자	String	Y	8	처음	조회시는	Space	연속	조회시에	이전	조회한	OutBlock의	cts_date	값으로	설정</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	String	Y	1	N:비압축	모듈	Y:	압	축	모듈</param>
public record t8416InBlock(string shcode, string gubun, int qrycnt, string sdate, string edate, string cts_date, string comp_yn);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="jisiga">전일시가	Number	Y	6.2</param>
/// <param name="jihigh">전일고가	Number	Y	6.2</param>
/// <param name="jilow">전일저가	Number	Y	6.2</param>
/// <param name="jiclose">전일종가	Number	Y	6.2</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	6.2</param>
/// <param name="dihigh">당일고가	Number	Y	6.2</param>
/// <param name="dilow">당일저가	Number	Y	6.2</param>
/// <param name="diclose">당일종가	Number	Y	6.2</param>
/// <param name="highend">상한가	Number	Y	6.2</param>
/// <param name="lowend">하한가	Number	Y	6.2</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="s_time">장시작시간(HHMMSS)	String	Y	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	String	Y	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	String	Y	2</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record t8416OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, double highend, double lowend, string cts_date, string s_time, string e_time, string dshmin, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="close">종가	Number	Y	6.2</param>
/// <param name="jdiff_vol">누적거래량	Number	Y	12</param>
/// <param name="value">거래대금	Number	Y	12</param>
/// <param name="openyak">미결제약정	Number	Y	12</param>
public record t8416OutBlock1(string date, double open, double high, double low, double close, long jdiff_vol, long value, long openyak);

/// <summary>
/// 
/// </summary>
/// <param name="focode">단축코드	String	Y	8</param>
/// <param name="cgubun">챠트구분	String	Y	1</param>
/// <param name="bgubun">분구분	Object	Y	3</param>
/// <param name="cnt">조회건수	Object	Y	3</param>
public record t8429InBlock(string focode, string cgubun, object bgubun, object cnt);

/// <summary>
/// 
/// </summary>
/// <param name="chetime">시간	String	Y	10</param>
/// <param name="price">현재가	Number	Y	6.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	6.2</param>
/// <param name="open">시가	Number	Y	6.2</param>
/// <param name="high">고가	Number	Y	6.2</param>
/// <param name="low">저가	Number	Y	6.2</param>
/// <param name="volume">거래량	Number	Y	12</param>
/// <param name="cvolume">체결수량	Number	Y	8</param>
/// <param name="s_mschecnt">매수순간체결건수	Number	Y	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	Number	Y	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	Number	Y	8</param>
/// <param name="s_mschevol">매수순간체결량	Number	Y	12</param>
/// <param name="s_mdchevol">매도순간체결량	Number	Y	12</param>
/// <param name="ss_mschevol">순매수순간체결량	Number	Y	12</param>
/// <param name="chdegvol">체결강도(거래량)	Number	Y	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	Number	Y	8.2</param>
public record t8429OutBlock1(string chetime, double price, string sign, double change, double open, double high, double low, long volume, int cvolume, int s_mschecnt, int s_mdchecnt, int ss_mschecnt, long s_mschevol, long s_mdchevol, long ss_mschevol, double chdegvol, double chdegcnt);

#endregion

#region [선물/옵션] 계좌

/// <summary>
/// 
/// </summary>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="FnoClssCode">선물옵션분류코드	String	Y	2	00@전체</param>
/// <param name="PrdgrpCode">상품군코드	String	Y	2	00:전체</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1	0:전체</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1	3:역순</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2	99</param>
public record CFOAQ00600InBlock1(string QrySrtDt, string QryEndDt, string FnoClssCode, string PrdgrpCode, string PrdtExecTpCode, string StnlnSeqTp, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="FnoClssCode">선물옵션분류코드	String	Y	2</param>
/// <param name="PrdgrpCode">상품군코드	String	Y	2</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
public record CFOAQ00600OutBlock1(int RecCnt, string AcntNo, string InptPwd, string QrySrtDt, string QryEndDt, string FnoClssCode, string PrdgrpCode, string PrdtExecTpCode, string StnlnSeqTp, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="FutsOrdQty">선물주문수량	Number	Y	16</param>
/// <param name="FutsExecQty">선물체결수량	Number	Y	16</param>
/// <param name="OptOrdQty">옵션주문수량	Number	Y	16</param>
/// <param name="OptExecQty">옵션체결수량	Number	Y	16</param>
public record CFOAQ00600OutBlock2(int RecCnt, string AcntNm, long FutsOrdQty, long FutsExecQty, long OptOrdQty, long OptExecQty);

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="MrcTpNm">정정취소구분명	String	Y	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2</param>
/// <param name="FnoOrdprcPtnNm">선물옵션호가유형명	String	Y	40</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdTpNm">주문구분명	String	Y	10</param>
/// <param name="ExecTpNm">체결구분명	String	Y	10</param>
/// <param name="ExecPrc">체결가	Number	Y	13.2</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="CtrctTime">약정시각	String	Y	9</param>
/// <param name="CtrctNo">약정번호	Number	Y	10</param>
/// <param name="ExecNo">체결번호	Number	Y	10</param>
/// <param name="BnsplAmt">매매손익금액	Number	Y	16</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="UserId">사용자ID	String	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="CommdaCodeNm">통신매체코드명	String	Y	40</param>
public record CFOAQ00600OutBlock3(string OrdDt, long OrdNo, long OrgOrdNo, string OrdTime, string FnoIsuNo, string IsuNm, string BnsTpNm, string MrcTpNm, string FnoOrdprcPtnCode, string FnoOrdprcPtnNm, double OrdPrc, long OrdQty, string OrdTpNm, string ExecTpNm, double ExecPrc, long ExecQty, string CtrctTime, long CtrctNo, long ExecNo, long BnsplAmt, long UnercQty, string UserId, string CommdaCode, string CommdaCodeNm);

/// <summary>
/// 
/// </summary>
/// <param name="QryTp">조회구분	String	Y	1	1@일반</param>
/// <param name="OrdAmt">주문금액	Number	Y	16</param>
/// <param name="RatVal">비율값	Number	Y	19.8	0</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	1@매도</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2	00@지정가</param>
public record CFOAQ10100InBlock1(string QryTp, long OrdAmt, double RatVal, string FnoIsuNo, string BnsTpCode, double FnoOrdPrc, string FnoOrdprcPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="OrdAmt">주문금액	Number	Y	16</param>
/// <param name="RatVal">비율값	Number	Y	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2</param>
public record CFOAQ10100OutBlock1(int RecCnt, string AcntNo, string Pwd, string QryTp, long OrdAmt, double RatVal, string FnoIsuNo, string BnsTpCode, double FnoOrdPrc, string FnoOrdprcPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="QryDt">조회일	String	Y	8</param>
/// <param name="FnoNowPrc">선물옵션현재가	Number	Y	27.8</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
/// <param name="NewOrdAbleQty">신규주문가능수량	Number	Y	16</param>
/// <param name="LqdtOrdAbleQty">청산주문가능수량	Number	Y	16</param>
/// <param name="UsePreargMgn">사용예정증거금액	Number	Y	16</param>
/// <param name="UsePreargMnyMgn">사용예정현금증거금액	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
public record CFOAQ10100OutBlock2(int RecCnt, string AcntNm, string QryDt, double FnoNowPrc, long OrdAbleQty, long NewOrdAbleQty, long LqdtOrdAbleQty, long UsePreargMgn, long UsePreargMnyMgn, long OrdAbleAmt, long MnyOrdAbleAmt);

/// <summary>
/// 
/// </summary>
public record CFOBQ10500InBlock1();

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
public record CFOBQ10500OutBlock1(int RecCnt, string AcntNo, string Pwd);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="DpsamtTotamt">예탁금총액	Number	Y	16</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="SubstAmt">대용금액	Number	Y	16</param>
/// <param name="FilupDpsamtTotamt">충당예탁금총액	Number	Y	16</param>
/// <param name="FilupDps">충당예수금	Number	Y	16</param>
/// <param name="FutsPnlAmt">선물손익금액	Number	Y	16</param>
/// <param name="WthdwAbleAmt">인출가능금액	Number	Y	16</param>
/// <param name="PsnOutAbleCurAmt">인출가능현금액	Number	Y	16</param>
/// <param name="PsnOutAbleSubstAmt">인출가능대용금액	Number	Y	16</param>
/// <param name="Mgn">증거금액	Number	Y	16</param>
/// <param name="MnyMgn">현금증거금액	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="AddMgn">추가증거금액	Number	Y	16</param>
/// <param name="MnyAddMgn">현금추가증거금액	Number	Y	16</param>
/// <param name="AmtPrdayChckInAmt">금전일수표입금액	Number	Y	16</param>
/// <param name="FnoPrdaySubstSellAmt">선물옵션전일대용매도금액	Number	Y	16</param>
/// <param name="FnoCrdaySubstSellAmt">선물옵션금일대용매도금액	Number	Y	16</param>
/// <param name="FnoPrdayFdamt">선물옵션전일가입금액	Number	Y	16</param>
/// <param name="FnoCrdayFdamt">선물옵션금일가입금액	Number	Y	16</param>
/// <param name="FcurrSubstAmt">외화대용금액	Number	Y	16</param>
/// <param name="FnoAcntAfmgnNm">선물옵션계좌사후증거금명	String	Y	20</param>
public record CFOBQ10500OutBlock2(int RecCnt, string AcntNm, long DpsamtTotamt, long Dps, long SubstAmt, long FilupDpsamtTotamt, long FilupDps, long FutsPnlAmt, long WthdwAbleAmt, long PsnOutAbleCurAmt, long PsnOutAbleSubstAmt, long Mgn, long MnyMgn, long OrdAbleAmt, long MnyOrdAbleAmt, long AddMgn, long MnyAddMgn, long AmtPrdayChckInAmt, long FnoPrdaySubstSellAmt, long FnoCrdaySubstSellAmt, long FnoPrdayFdamt, long FnoCrdayFdamt, long FcurrSubstAmt, string FnoAcntAfmgnNm);

/// <summary>
/// 
/// </summary>
/// <param name="PdGrpCodeNm">상품군코드명	String	Y	20</param>
/// <param name="NetRiskMgn">순위험증거금액	Number	Y	16</param>
/// <param name="PrcMgn">가격증거금액	Number	Y	16</param>
/// <param name="SprdMgn">스프레드증거금액	Number	Y	16</param>
/// <param name="PrcFlctMgn">가격변동증거금액	Number	Y	16</param>
/// <param name="MinMgn">최소증거금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금액	Number	Y	16</param>
/// <param name="OptNetBuyAmt">옵션순매수금액	Number	Y	16</param>
/// <param name="CsgnMgn">위탁증거금액	Number	Y	16</param>
/// <param name="MaintMgn">유지증거금액	Number	Y	16</param>
/// <param name="FutsBuyExecAmt">선물매수체결금액	Number	Y	16</param>
/// <param name="FutsSellExecAmt">선물매도체결금액	Number	Y	16</param>
/// <param name="OptBuyExecAmt">옵션매수체결금액	Number	Y	16</param>
/// <param name="OptSellExecAmt">옵션매도체결금액	Number	Y	16</param>
/// <param name="FutsPnlAmt">선물손익금액	Number	Y	16</param>
/// <param name="TotRiskCsgnMgn">총위험위탁증거금	Number	Y	16</param>
/// <param name="UndCsgnMgn">인수도위탁증거금	Number	Y	16</param>
/// <param name="MgnRdctAmt">증거금감면금액	Number	Y	16</param>
public record CFOBQ10500OutBlock3(string PdGrpCodeNm, long NetRiskMgn, long PrcMgn, long SprdMgn, long PrcFlctMgn, long MinMgn, long OrdMgn, long OptNetBuyAmt, long CsgnMgn, long MaintMgn, long FutsBuyExecAmt, long FutsSellExecAmt, long OptBuyExecAmt, long OptSellExecAmt, long FutsPnlAmt, long TotRiskCsgnMgn, long UndCsgnMgn, long MgnRdctAmt);

/// <summary>
/// 
/// </summary>
/// <param name="BnsDt">매매일	String	Y	8</param>
public record CFOEQ11100InBlock1(string BnsDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="BnsDt">매매일	String	Y	8</param>
public record CFOEQ11100OutBlock1(int RecCnt, string AcntNo, string Pwd, string BnsDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="OpnmkDpsamtTotamt">개장시예탁금총액	Number	Y	16</param>
/// <param name="OpnmkDps">개장시예수금	Number	Y	16</param>
/// <param name="OpnmkMnyrclAmt">개장시현금미수금	Number	Y	16</param>
/// <param name="OpnmkSubstAmt">개장시대용금액	Number	Y	16</param>
/// <param name="TotAmt">총금액	Number	Y	16</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="MnyrclAmt">현금미수금액	Number	Y	16</param>
/// <param name="SubstDsgnAmt">대용지정금액	Number	Y	16</param>
/// <param name="CsgnMgn">위탁증거금액	Number	Y	16</param>
/// <param name="MnyCsgnMgn">현금위탁증거금액	Number	Y	16</param>
/// <param name="MaintMgn">유지증거금액	Number	Y	16</param>
/// <param name="MnyMaintMgn">현금유지증거금액	Number	Y	16</param>
/// <param name="OutAbleAmt">출금가능총액	Number	Y	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	Number	Y	16</param>
/// <param name="SubstOutAbleAmt">출금가능대용	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="AddMgnOcrTpCode">추가증거금구분	String	Y	1</param>
/// <param name="AddMgn">추가증거금액	Number	Y	16</param>
/// <param name="MnyAddMgn">현금추가증거금액	Number	Y	16</param>
/// <param name="NtdayTotAmt">익일예탁총액	Number	Y	16</param>
/// <param name="NtdayDps">익일예탁현금	Number	Y	16</param>
/// <param name="NtdayMnyrclAmt">익일미수금	Number	Y	16</param>
/// <param name="NtdaySubstAmt">익일예탁대용	Number	Y	16</param>
/// <param name="NtdayCsgnMgn">익일위탁증거금	Number	Y	16</param>
/// <param name="NtdayMnyCsgnMgn">익일위탁증거금현금	Number	Y	16</param>
/// <param name="NtdayMaintMgn">익일유지증거금	Number	Y	16</param>
/// <param name="NtdayMnyMaintMgn">익일유지증거금현금	Number	Y	16</param>
/// <param name="NtdayOutAbleAmt">익일인출가능금액	Number	Y	16</param>
/// <param name="NtdayMnyoutAbleAmt">익일인출가능금액	Number	Y	16</param>
/// <param name="NtdaySubstOutAbleAmt">익일인출가능대용	Number	Y	16</param>
/// <param name="NtdayOrdAbleAmt">익일주문가능금액	Number	Y	16</param>
/// <param name="NtdayMnyOrdAbleAmt">익일주문가능현금	Number	Y	16</param>
/// <param name="NtdayAddMgnTp">익일추가증거금구분	String	Y	1</param>
/// <param name="NtdayAddMgn">익일추가증거금	Number	Y	16</param>
/// <param name="NtdayMnyAddMgn">익일추가증거금현금	Number	Y	16</param>
/// <param name="NtdaySettAmt">익일결제금액	Number	Y	16</param>
/// <param name="EvalDpsamtTotamt">평가예탁금총액	Number	Y	15</param>
/// <param name="MnyEvalDpstgAmt">현금평가예탁금액	Number	Y	15</param>
/// <param name="DpsamtUtlfeeGivPrergAmt">예탁금이용료지급예정금액	Number	Y	16</param>
/// <param name="TaxAmt">세금	Number	Y	16</param>
/// <param name="CsgnMgnrat">위탁증거금	비율	Number	Y	7.2</param>
/// <param name="CsgnMnyMgnrat">위탁증거금현금비율	Number	Y	7.2</param>
/// <param name="DpstgTotamtLackAmt">예탁총액부족금액(위탁증거금기준)	Number	Y	16</param>
/// <param name="DpstgMnyLackAmt">예탁현금부족금액(위탁증거금기준)	Number	Y	16</param>
/// <param name="RealInAmt">실입금액	Number	Y	16</param>
/// <param name="InAmt">입금액	Number	Y	16</param>
/// <param name="OutAmt">출금액	Number	Y	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	Number	Y	16</param>
/// <param name="FutsThdayDfamt">선물당일차금	Number	Y	16</param>
/// <param name="FutsUpdtDfamt">선물갱신차금	Number	Y	16</param>
/// <param name="FutsLastSettDfamt">선물최종결제차금	Number	Y	16</param>
/// <param name="OptSettDfamt">옵션결제차금	Number	Y	16</param>
/// <param name="OptBuyAmt">옵션매수금액	Number	Y	16</param>
/// <param name="OptSellAmt">옵션매도금액	Number	Y	16</param>
/// <param name="OptXrcDfamt">옵션행사차금	Number	Y	16</param>
/// <param name="OptAsgnDfamt">옵션배정차금	Number	Y	16</param>
/// <param name="RealGdsUndAmt">실물인수도금액	Number	Y	16</param>
/// <param name="RealGdsUndAsgnAmt">실물인수도배정대금	Number	Y	16</param>
/// <param name="RealGdsUndXrcAmt">실물인수도행사대금	Number	Y	16</param>
/// <param name="CmsnAmt">수수료	Number	Y	16</param>
/// <param name="FutsCmsn">선물수수료	Number	Y	16</param>
/// <param name="OptCmsn">옵션수수료	Number	Y	16</param>
/// <param name="FutsCtrctQty">선물약정수량	Number	Y	16</param>
/// <param name="FutsCtrctAmt">선물약정금액	Number	Y	16</param>
/// <param name="OptCtrctQty">옵션약정수량	Number	Y	16</param>
/// <param name="OptCtrctAmt">옵션약정금액	Number	Y	16</param>
/// <param name="FutsUnsttQty">선물미결제수량	Number	Y	16</param>
/// <param name="FutsUnsttAmt">선물미결제금액	Number	Y	16</param>
/// <param name="OptUnsttQty">옵션미결제수량	Number	Y	16</param>
/// <param name="OptUnsttAmt">옵션미결제금액	Number	Y	16</param>
/// <param name="FutsBuyUnsttQty">선물매수미결제수량	Number	Y	16</param>
/// <param name="FutsBuyUnsttAmt">선물매수미결제금액	Number	Y	16</param>
/// <param name="FutsSellUnsttQty">선물매도미결제수량	Number	Y	16</param>
/// <param name="FutsSellUnsttAmt">선물매도미결제금액	Number	Y	16</param>
/// <param name="OptBuyUnsttQty">옵션매수미결제수량	Number	Y	16</param>
/// <param name="OptBuyUnsttAmt">옵션매수미결제금액	Number	Y	16</param>
/// <param name="OptSellUnsttQty">옵션매도미결제수량	Number	Y	16</param>
/// <param name="OptSellUnsttAmt">옵션매도미결제금액	Number	Y	16</param>
/// <param name="FutsBuyctrQty">선물매수약정수량	Number	Y	16</param>
/// <param name="FutsBuyctrAmt">선물매수약정금액	Number	Y	16</param>
/// <param name="FutsSlctrQty">선물매도약정수량	Number	Y	16</param>
/// <param name="FutsSlctrAmt">선물매도약정금액	Number	Y	16</param>
/// <param name="OptBuyctrQty">옵션매수약정수량	Number	Y	16</param>
/// <param name="OptBuyctrAmt">옵션매수약정금액	Number	Y	16</param>
/// <param name="OptSlctrQty">옵션매도약정수량	Number	Y	16</param>
/// <param name="OptSlctrAmt">옵션매도약정금액	Number	Y	16</param>
/// <param name="FutsBnsplAmt">선물매매손익금액	Number	Y	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="FutsEvalPnlAmt">선물평가손익금액	Number	Y	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	Number	Y	16</param>
/// <param name="FutsEvalAmt">선물평가금액	Number	Y	16</param>
/// <param name="OptEvalAmt">옵션평가금액	Number	Y	16</param>
/// <param name="MktEndAfMnyInAmt">장종료후현금입금금액	Number	Y	16</param>
/// <param name="MktEndAfMnyOutAmt">장종료후현금출금금액	Number	Y	16</param>
/// <param name="MktEndAfSubstDsgnAmt">장종료후대용지정금액	Number	Y	16</param>
/// <param name="MktEndAfSubstAbndAmt">장종료후대용해지금액	Number	Y	16</param>
public record CFOEQ11100OutBlock2(int RecCnt, string AcntNm, long OpnmkDpsamtTotamt, long OpnmkDps, long OpnmkMnyrclAmt, long OpnmkSubstAmt, long TotAmt, long Dps, long MnyrclAmt, long SubstDsgnAmt, long CsgnMgn, long MnyCsgnMgn, long MaintMgn, long MnyMaintMgn, long OutAbleAmt, long MnyoutAbleAmt, long SubstOutAbleAmt, long OrdAbleAmt, long MnyOrdAbleAmt, string AddMgnOcrTpCode, long AddMgn, long MnyAddMgn, long NtdayTotAmt, long NtdayDps, long NtdayMnyrclAmt, long NtdaySubstAmt, long NtdayCsgnMgn, long NtdayMnyCsgnMgn, long NtdayMaintMgn, long NtdayMnyMaintMgn, long NtdayOutAbleAmt, long NtdayMnyoutAbleAmt, long NtdaySubstOutAbleAmt, long NtdayOrdAbleAmt, long NtdayMnyOrdAbleAmt, string NtdayAddMgnTp, long NtdayAddMgn, long NtdayMnyAddMgn, long NtdaySettAmt, long EvalDpsamtTotamt, long MnyEvalDpstgAmt, long DpsamtUtlfeeGivPrergAmt, long TaxAmt, double CsgnMgnrat, double CsgnMnyMgnrat, long DpstgTotamtLackAmt, long DpstgMnyLackAmt, long RealInAmt, long InAmt, long OutAmt, long FutsAdjstDfamt, long FutsThdayDfamt, long FutsUpdtDfamt, long FutsLastSettDfamt, long OptSettDfamt, long OptBuyAmt, long OptSellAmt, long OptXrcDfamt, long OptAsgnDfamt, long RealGdsUndAmt, long RealGdsUndAsgnAmt, long RealGdsUndXrcAmt, long CmsnAmt, long FutsCmsn, long OptCmsn, long FutsCtrctQty, long FutsCtrctAmt, long OptCtrctQty, long OptCtrctAmt, long FutsUnsttQty, long FutsUnsttAmt, long OptUnsttQty, long OptUnsttAmt, long FutsBuyUnsttQty, long FutsBuyUnsttAmt, long FutsSellUnsttQty, long FutsSellUnsttAmt, long OptBuyUnsttQty, long OptBuyUnsttAmt, long OptSellUnsttQty, long OptSellUnsttAmt, long FutsBuyctrQty, long FutsBuyctrAmt, long FutsSlctrQty, long FutsSlctrAmt, long OptBuyctrQty, long OptBuyctrAmt, long OptSlctrQty, long OptSlctrAmt, long FutsBnsplAmt, long OptBnsplAmt, long FutsEvalPnlAmt, long OptEvalPnlAmt, long FutsEvalAmt, long OptEvalAmt, long MktEndAfMnyInAmt, long MktEndAfMnyOutAmt, long MktEndAfSubstDsgnAmt, long MktEndAfSubstAbndAmt);

/// <summary>
/// 
/// </summary>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1	1@일자별</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1	1@순</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	String	Y	1	0:계좌에	따라	다르며	기본적으로는	선입선출</param>
public record CFOEQ82600InBlock1(string QrySrtDt, string QryEndDt, string QryTp, string StnlnSeqTp, string FnoBalEvalTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	String	Y	1</param>
public record CFOEQ82600OutBlock1(int RecCnt, string AcntNo, string Pwd, string QrySrtDt, string QryEndDt, string QryTp, string StnlnSeqTp, string FnoBalEvalTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="FutsAdjstDfamt">선물정산차금	Number	Y	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="FnoCmsnAmt">선물옵션수수료	Number	Y	16</param>
/// <param name="PnlSumAmt">손익합계금액	Number	Y	16</param>
/// <param name="MnyinSumAmt">입금합계금액	Number	Y	16</param>
/// <param name="MnyoutSumAmt">출금합계금액	Number	Y	16</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
public record CFOEQ82600OutBlock2(int RecCnt, long FutsAdjstDfamt, long OptBnsplAmt, long FnoCmsnAmt, long PnlSumAmt, long MnyinSumAmt, long MnyoutSumAmt, string AcntNm);

/// <summary>
/// 
/// </summary>
/// <param name="QryDt">조회일	String	Y	8</param>
/// <param name="DpstgTotamt">예탁총액	Number	Y	16</param>
/// <param name="DpstgMny">예탁현금	Number	Y	16</param>
/// <param name="FnoMgn">선물옵션증거금액	Number	Y	16</param>
/// <param name="FutsPnlAmt">선물손익금액	Number	Y	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	Number	Y	16</param>
/// <param name="CmsnAmt">수수료	Number	Y	16</param>
/// <param name="SumAmt1">합계금액1	Number	Y	16</param>
/// <param name="SumAmt2">합계금액	Number	Y	16</param>
/// <param name="PnlSumAmt">손익합계금액	Number	Y	16</param>
/// <param name="FutsBuyAmt">선물매수금액	Number	Y	16</param>
/// <param name="FutsSellAmt">선물매도금액	Number	Y	16</param>
/// <param name="OptBuyAmt">옵션매수금액	Number	Y	16</param>
/// <param name="OptSellAmt">옵션매도금액	Number	Y	16</param>
/// <param name="InAmt">입금액	Number	Y	16</param>
/// <param name="OutAmt">출금액	Number	Y	16</param>
/// <param name="EvalAmt">평가금액	Number	Y	16</param>
/// <param name="AddupEvalAmt">합산평가금액	Number	Y	16</param>
/// <param name="Amt2">금액2	Number	Y	16</param>
public record CFOEQ82600OutBlock3(string QryDt, long DpstgTotamt, long DpstgMny, long FnoMgn, long FutsPnlAmt, long OptBsnPnlAmt, long OptEvalPnlAmt, long CmsnAmt, long SumAmt1, long SumAmt2, long PnlSumAmt, long FutsBuyAmt, long FutsSellAmt, long OptBuyAmt, long OptSellAmt, long InAmt, long OutAmt, long EvalAmt, long AddupEvalAmt, long Amt2);

/// <summary>
/// 
/// </summary>
/// <param name="RegMktCode">등록시장코드	String	Y	2	99@전체</param>
/// <param name="BuyDt">매수일자	String	Y	8</param>
public record CFOFQ02400InBlock1(string RegMktCode, string BuyDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="RegMktCode">등록시장코드	String	Y	2</param>
/// <param name="BuyDt">매수일자	String	Y	8</param>
public record CFOFQ02400OutBlock1(int RecCnt, string AcntNo, string Pwd, string RegMktCode, string BuyDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="FutsCtrctQty">선물약정수량	Number	Y	16</param>
/// <param name="OptCtrctQty">옵션약정수량	Number	Y	16</param>
/// <param name="CtrctQty">약정수량	Number	Y	16</param>
/// <param name="FutsCtrctAmt">선물약정금액	Number	Y	16</param>
/// <param name="FutsBuyctrAmt">선물매수약정금액	Number	Y	16</param>
/// <param name="FutsSlctrAmt">선물매도약정금액	Number	Y	16</param>
/// <param name="CalloptCtrctAmt">콜옵션약정금액	Number	Y	16</param>
/// <param name="CallBuyAmt">콜매수금액	Number	Y	16</param>
/// <param name="CallSellAmt">콜매도금액	Number	Y	16</param>
/// <param name="PutoptCtrctAmt">풋옵션약정금액	Number	Y	16</param>
/// <param name="PutBuyAmt">풋매수금액	Number	Y	16</param>
/// <param name="PutSellAmt">풋매도금액	Number	Y	16</param>
/// <param name="AllCtrctAmt">전체약정금액	Number	Y	16</param>
/// <param name="BuyctrAsmAmt">매수약정누계금액	Number	Y	16</param>
/// <param name="SlctrAsmAmt">매도약정누계금액	Number	Y	16</param>
/// <param name="FutsPnlSum">선물손익합계	Number	Y	16</param>
/// <param name="OptPnlSum">옵션손익합계	Number	Y	16</param>
/// <param name="AllPnlSum">전체손익합계	Number	Y	16</param>
public record CFOFQ02400OutBlock2(int RecCnt, string AcntNm, long FutsCtrctQty, long OptCtrctQty, long CtrctQty, long FutsCtrctAmt, long FutsBuyctrAmt, long FutsSlctrAmt, long CalloptCtrctAmt, long CallBuyAmt, long CallSellAmt, long PutoptCtrctAmt, long PutBuyAmt, long PutSellAmt, long AllCtrctAmt, long BuyctrAsmAmt, long SlctrAsmAmt, long FutsPnlSum, long OptPnlSum, long AllPnlSum);

/// <summary>
/// 
/// </summary>
/// <param name="FnoClssCode">선물옵션품목구분	String	Y	1</param>
/// <param name="FutsSellQty">선물매도수량	Number	Y	16</param>
/// <param name="FutsSellPnl">선물매도손익	Number	Y	16</param>
/// <param name="FutsBuyQty">선물매수수량	Number	Y	16</param>
/// <param name="FutsBuyPnl">선물매수손익	Number	Y	16</param>
/// <param name="CallSellQty">콜매도수량	Number	Y	16</param>
/// <param name="CallSellPnl">콜매도손익	Number	Y	16</param>
/// <param name="CallBuyQty">콜매수수량	Number	Y	16</param>
/// <param name="CallBuyPnl">콜매수손익	Number	Y	16</param>
/// <param name="PutSellQty">풋매도수량	Number	Y	16</param>
/// <param name="PutSellPnl">풋매도손익	Number	Y	16</param>
/// <param name="PutBuyQty">풋매수수량	Number	Y	16</param>
/// <param name="PutBuyPnl">풋매수손익	Number	Y	16</param>
public record CFOFQ02400OutBlock3(string FnoClssCode, long FutsSellQty, long FutsSellPnl, long FutsBuyQty, long FutsBuyPnl, long CallSellQty, long CallSellPnl, long CallBuyQty, long CallBuyPnl, long PutSellQty, long PutSellPnl, long PutBuyQty, long PutBuyPnl);

/// <summary>
/// 
/// </summary>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="BalQty">잔고수량	Number	Y	16</param>
/// <param name="FnoAvrPrc">평균가	Number	Y	19.8</param>
/// <param name="BgnAmt">당초금액	Number	Y	16</param>
/// <param name="ThdayLqdtQty">당일청산수량	Number	Y	16</param>
/// <param name="Curprc">현재가	Number	Y	13.2</param>
/// <param name="EvalAmt">평가금액	Number	Y	16</param>
/// <param name="EvalPnlAmt">평가손익금액	Number	Y	16</param>
/// <param name="EvalErnrat">평가수익률	Number	Y	12.6</param>
public record CFOFQ02400OutBlock4(string IsuNo, string IsuNm, string BnsTpCode, string BnsTpNm, long BalQty, double FnoAvrPrc, long BgnAmt, long ThdayLqdtQty, double Curprc, long EvalAmt, long EvalPnlAmt, double EvalErnrat);

/// <summary>
/// 
/// </summary>
/// <param name="expcode">종목번호	String	Y	8</param>
/// <param name="chegb">체결구분	String	Y	1	0;전체</param>
/// <param name="sortgb">정렬순서	String	Y	1	1:주문번호	역순</param>
/// <param name="cts_ordno">CTS_주문번호	String	Y	7	처음	조회시는	Space</param>
public record t0434InBlock(string expcode, string chegb, string sortgb, string cts_ordno);

/// <summary>
/// 
/// </summary>
/// <param name="cts_ordno">CTS_주문번호	String	Y	7	연속조회키</param>
public record t0434OutBlock(string cts_ordno);

/// <summary>
/// 
/// </summary>
/// <param name="ordno">주문번호	Number	Y	7</param>
/// <param name="orgordno">원주문번호	Number	Y	7</param>
/// <param name="medosu">구분	String	Y	10</param>
/// <param name="ordgb">유형	String	Y	20</param>
/// <param name="qty">주문수량	Number	Y	9</param>
/// <param name="price">주문가격	Number	Y	9.2</param>
/// <param name="cheqty">체결수량	Number	Y	9</param>
/// <param name="cheprice">체결가격	Number	Y	9.2</param>
/// <param name="ordrem">미체결잔량	Number	Y	9</param>
/// <param name="status">상태	String	Y	10</param>
/// <param name="ordtime">주문시간	String	Y	8</param>
/// <param name="ordermtd">주문매체	String	Y	10</param>
/// <param name="expcode">종목번호	String	Y	8</param>
/// <param name="rtcode">사유코드	String	Y	3</param>
/// <param name="sysprocseq">처리순번	Number	Y	10</param>
/// <param name="hogatype">호가타입	String	Y	1</param>
public record t0434OutBlock1(int ordno, int orgordno, string medosu, string ordgb, long qty, double price, long cheqty, double cheprice, long ordrem, string status, string ordtime, string ordermtd, string expcode, string rtcode, long sysprocseq, string hogatype);

/// <summary>
/// 
/// </summary>
/// <param name="cts_expcode">CTS_종목번호	String	Y	8</param>
/// <param name="cts_medocd">CTS_매매구분	String	Y	1</param>
public record t0441InBlock(string cts_expcode, string cts_medocd);

/// <summary>
/// 
/// </summary>
/// <param name="tdtsunik">매매손익합계	Number	Y	18</param>
/// <param name="cts_expcode">CTS_종목번호	String	Y	8</param>
/// <param name="cts_medocd">CTS_매매구분	String	Y	1</param>
/// <param name="tappamt">평가금액	Number	Y	18</param>
/// <param name="tsunik">평가손익	Number	Y	18</param>
public record t0441OutBlock(long tdtsunik, string cts_expcode, string cts_medocd, long tappamt, long tsunik);

/// <summary>
/// 
/// </summary>
/// <param name="expcode">종목번호	String	Y	8</param>
/// <param name="medosu">구분	String	Y	4</param>
/// <param name="jqty">잔고수량	Number	Y	10</param>
/// <param name="cqty">청산가능수량	Number	Y	10</param>
/// <param name="pamt">평균단가	Number	Y	10.2</param>
/// <param name="mamt">총매입금액	Number	Y	18</param>
/// <param name="medocd">매매구분	String	Y	1</param>
/// <param name="dtsunik">매매손익	Number	Y	18</param>
/// <param name="sysprocseq">처리순번	Number	Y	10</param>
/// <param name="price">현재가	Number	Y	9.2</param>
/// <param name="appamt">평가금액	Number	Y	18</param>
/// <param name="dtsunik1">평가손익	Number	Y	18</param>
/// <param name="sunikrt">수익율	Number	Y	10.2</param>
public record t0441OutBlock1(string expcode, string medosu, long jqty, long cqty, double pamt, long mamt, string medocd, long dtsunik, long sysprocseq, double price, long appamt, long dtsunik1, double sunikrt);

/// <summary>
/// 
/// </summary>
/// <param name="ChoicInptTpCode">선택입력구분	String	Y	1	1:계좌</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1	0:전체,	1:체결,	2:미체결</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1	0:순,	1:역순</param>
public record CEXAQ21100InBlock1(string ChoicInptTpCode, string PrdtExecTpCode, string StnlnSeqTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	String	Y	1</param>
/// <param name="AcntNo">지점번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1</param>
public record CEXAQ21100OutBlock1(int RecCnt, string ChoicInptTpCode, string AcntNo, string Pwd, string PrdtExecTpCode, string StnlnSeqTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
public record CEXAQ21100OutBlock2(int RecCnt, string AcntNm, long OrdQty, long ExecQty);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo1">계좌번호1	String	Y	20</param>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="MrcTpNm">정정취소구분명	String	Y	10</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1</param>
/// <param name="FnoOrdprcPtnNm">선물옵션호가유형명	String	Y	40</param>
/// <param name="OrdCndiPrc">주문조건가격	Number	Y	25.8</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdTpNm">주문구분명	String	Y	10</param>
/// <param name="ExecPrc">체결가	Number	Y	13.2</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="CommdaNm">통신매체명	String	Y	40</param>
public record CEXAQ21100OutBlock3(string AcntNo1, string OrdDt, long OrdNo, long OrgOrdNo, string OrdTime, string FnoIsuNo, string IsuNm, string BnsTpNm, string BnsTpCode, string MrcTpNm, string ErxPrcCndiTpCode, string FnoOrdprcPtnNm, double OrdCndiPrc, double OrdPrc, long OrdQty, string OrdTpNm, double ExecPrc, long ExecQty, long UnercQty, string CommdaCode, string CommdaNm);

/// <summary>
/// 
/// </summary>
/// <param name="QryTp">조회구분	String	Y	1	@1</param>
/// <param name="OrdAmt">주문금액	Number	Y	16	@0</param>
/// <param name="RatVal">비율값	Number	Y	19.8	@0</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	1:매도,	2:매수</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1	1:시장가,	2:지정가</param>
public record CEXAQ21200InBlock1(string QryTp, long OrdAmt, double RatVal, string FnoIsuNo, string BnsTpCode, double OrdPrc, string ErxPrcCndiTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="OrdAmt">주문금액	Number	Y	16</param>
/// <param name="RatVal">비율값	Number	Y	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1</param>
public record CEXAQ21200OutBlock1(int RecCnt, string AcntNo, string Pwd, string QryTp, long OrdAmt, double RatVal, string FnoIsuNo, string BnsTpCode, double OrdPrc, string ErxPrcCndiTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="QryDt">조회일	String	Y	8</param>
/// <param name="NowPrc">현재가	Number	Y	15.2</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
/// <param name="NewOrdAbleQty">신규주문가능수량	Number	Y	16</param>
/// <param name="LqdtOrdAbleQty">청산주문가능수량	Number	Y	16</param>
/// <param name="UsePreargMgn">사용예정증거금액	Number	Y	16</param>
/// <param name="UsePreargMnyMgn">사용예정현금증거금액	Number	Y	16</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
public record CEXAQ21200OutBlock2(int RecCnt, string AcntNm, string QryDt, double NowPrc, long OrdAbleQty, long NewOrdAbleQty, long LqdtOrdAbleQty, long UsePreargMgn, long UsePreargMnyMgn, long OrdAbleAmt, long MnyOrdAbleAmt);

/// <summary>
/// 
/// </summary>
/// <param name="IsuCode">종목코드	String	Y	12</param>
/// <param name="BalEvalTp">잔고평가구분	String	Y	1	@1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	String	Y	1	@2</param>
public record CEXAQ31100InBlock1(string IsuCode, string BalEvalTp, string FutsPrcEvalTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="IsuCode">종목코드	String	Y	12</param>
/// <param name="BalEvalTp">잔고평가구분	String	Y	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	String	Y	1</param>
public record CEXAQ31100OutBlock1(int RecCnt, string AcntNo, string InptPwd, string IsuCode, string BalEvalTp, string FutsPrcEvalTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="BnsplAmt">매매손익금액	Number	Y	16</param>
/// <param name="AdjstDfamt">정산차금	Number	Y	16</param>
/// <param name="TotEvalAmt">총평가금액	Number	Y	16</param>
/// <param name="TotPnlAmt">총손익금액	Number	Y	16</param>
public record CEXAQ31100OutBlock2(int RecCnt, string AcntNo, string AcntNm, long BnsplAmt, long AdjstDfamt, long TotEvalAmt, long TotPnlAmt);

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="UnsttQty">미결제수량	Number	Y	16</param>
/// <param name="LqdtAbleQty">청산가능수량	Number	Y	16</param>
/// <param name="FnoAvrPrc">평균가	Number	Y	19.8</param>
/// <param name="BasePrc">기준가	Number	Y	30.1</param>
/// <param name="NowPrc">현재가	Number	Y	13.2</param>
/// <param name="CmpPrc">대비가	Number	Y	13.2</param>
/// <param name="EvalAmt">평가금액	Number	Y	16</param>
/// <param name="EvalPnl">평가손익	Number	Y	16</param>
/// <param name="PnlRat">손익률	Number	Y	12.6</param>
/// <param name="UnsttAmt">미결제금액	Number	Y	16</param>
/// <param name="BnsplAmt">매매손익금액	Number	Y	16</param>
public record CEXAQ31100OutBlock3(string FnoIsuNo, string IsuNm, string BnsTpCode, string BnsTpNm, long UnsttQty, long LqdtAbleQty, double FnoAvrPrc, double BasePrc, double NowPrc, double CmpPrc, long EvalAmt, long EvalPnl, double PnlRat, long UnsttAmt, long BnsplAmt);

/// <summary>
/// 
/// </summary>
/// <param name="BalEvalTp">잔고평가구분	String	Y	1	1:이동평균</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	String	Y	1	1:당초가</param>
public record CEXAQ31200InBlock1(string BalEvalTp, string FutsPrcEvalTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="InptPwd">입력비밀번호	String	Y	8</param>
/// <param name="BalEvalTp">잔고평가구분	String	Y	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	String	Y	1</param>
public record CEXAQ31200OutBlock1(int RecCnt, string AcntNo, string InptPwd, string BalEvalTp, string FutsPrcEvalTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="EvalDpsamtTotamt">평가예탁금총액	Number	Y	15</param>
/// <param name="MnyEvalDpstgAmt">현금평가예탁금액	Number	Y	15</param>
/// <param name="DpsamtTotamt">예탁금총액	Number	Y	16</param>
/// <param name="DpstgMny">예탁현금	Number	Y	16</param>
/// <param name="PsnOutAbleTotAmt">인출가능총금액	Number	Y	15</param>
/// <param name="PsnOutAbleCurAmt">인출가능현금액	Number	Y	16</param>
/// <param name="OrdAbleTotAmt">주문가능총금액	Number	Y	15</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="CsgnMgnTotamt">위탁증거금총액	Number	Y	16</param>
/// <param name="MnyCsgnMgn">현금위탁증거금액	Number	Y	16</param>
/// <param name="AddMgnTotamt">추가증거금총액	Number	Y	15</param>
/// <param name="MnyAddMgn">현금추가증거금액	Number	Y	16</param>
/// <param name="CmsnAmt">수수료	Number	Y	16</param>
/// <param name="FutsEvalPnlAmt">선물평가손익금액	Number	Y	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	Number	Y	16</param>
/// <param name="OptEvalAmt">옵션평가금액	Number	Y	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	Number	Y	16</param>
/// <param name="TotPnlAmt">총손익금액	Number	Y	16</param>
/// <param name="NetPnlAmt">순손익금액	Number	Y	16</param>
/// <param name="TotEvalAmt">총평가금액	Number	Y	16</param>
/// <param name="MnyinAmt">입금금액	Number	Y	16</param>
/// <param name="MnyoutAmt">출금금액	Number	Y	16</param>
/// <param name="FutsCmsnAmt">선물수수료금액	Number	Y	16</param>
public record CEXAQ31200OutBlock2(int RecCnt, string AcntNo, string AcntNm, long EvalDpsamtTotamt, long MnyEvalDpstgAmt, long DpsamtTotamt, long DpstgMny, long PsnOutAbleTotAmt, long PsnOutAbleCurAmt, long OrdAbleTotAmt, long MnyOrdAbleAmt, long CsgnMgnTotamt, long MnyCsgnMgn, long AddMgnTotamt, long MnyAddMgn, long CmsnAmt, long FutsEvalPnlAmt, long OptEvalPnlAmt, long OptEvalAmt, long OptBnsplAmt, long FutsAdjstDfamt, long TotPnlAmt, long NetPnlAmt, long TotEvalAmt, long MnyinAmt, long MnyoutAmt, long FutsCmsnAmt);

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="UnsttQty">미결제수량	Number	Y	16</param>
/// <param name="FnoAvrPrc">평균가	Number	Y	19.8</param>
/// <param name="NowPrc">현재가	Number	Y	13.2</param>
/// <param name="CmpPrc">대비가	Number	Y	13.2</param>
/// <param name="EvalPnl">평가손익	Number	Y	16</param>
/// <param name="PnlRat">손익률	Number	Y	12.6</param>
/// <param name="EvalAmt">평가금액	Number	Y	16</param>
/// <param name="LqdtAbleQty">청산가능수량	Number	Y	16</param>
public record CEXAQ31200OutBlock3(string FnoIsuNo, string IsuNm, string BnsTpCode, string BnsTpNm, long UnsttQty, double FnoAvrPrc, double NowPrc, double CmpPrc, long EvalPnl, double PnlRat, long EvalAmt, long LqdtAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1	0@전체</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	String	Y	2	SPACE</param>
/// <param name="SrtOrdNo2">시작주문번호2	Number	Y	10	0</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1	3:주문번호역순</param>
public record CEXAQ44200InBlock1(string QrySrtDt, string QryEndDt, string PrdtExecTpCode, string FnoTrdPtnCode, long SrtOrdNo2, string StnlnSeqTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="PrdtExecTpCode">체결구분	String	Y	1</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	String	Y	2</param>
/// <param name="SrtOrdNo2">시작주문번호2	Number	Y	10</param>
/// <param name="StnlnSeqTp">정렬순서구분	String	Y	1</param>
public record CEXAQ44200OutBlock1(int RecCnt, string ChoicInptTpCode, string AcntNo, string Pwd, string QrySrtDt, string QryEndDt, string PrdtExecTpCode, string FnoTrdPtnCode, long SrtOrdNo2, string StnlnSeqTp);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="ExecPrc">체결가	Number	Y	15.2</param>
public record CEXAQ44200OutBlock2(int RecCnt, long OrdQty, long ExecQty, long UnercQty, double ExecPrc);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo1">계좌번호1	String	Y	20</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="OrdDt">주문일	String	Y	8</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="IsuNo">종목번호	String	Y	12</param>
/// <param name="IsuNm">종목명	String	Y	40</param>
/// <param name="BnsTpNm">매매구분	String	Y	10</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="ErxOrdprcTpCode">유렉스호가구분코드	String	Y	1</param>
/// <param name="MrcTpNm">정정취소구분명	String	Y	10</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1</param>
/// <param name="CodeNm">코드명	String	Y	40</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="FnoRjtRsnCode">선물옵션거부사유코드	String	Y	3</param>
/// <param name="OrdTpNm">주문구분명	String	Y	10</param>
/// <param name="ExecTpNm">체결구분명	String	Y	10</param>
/// <param name="ExecPrc">체결가	Number	Y	13.2</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="ExecTime">체결시각	String	Y	9</param>
/// <param name="ExecNo">체결번호	Number	Y	10</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="UserId">사용자ID	String	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="CommdaCodeNm">통신매체코드명	String	Y	40</param>
/// <param name="IpAddr">IP주소	String	Y	16</param>
/// <param name="TrdPtnTpNm">거래유형구분	String	Y	20</param>
/// <param name="ErxOrdStatCode">유렉스주문상태코드	String	Y	1</param>
/// <param name="CodeNm0">코드명0	String	Y	40</param>
/// <param name="ExchRcptTime">거래소접수시각	String	Y	30</param>
public record CEXAQ44200OutBlock3(string AcntNo1, string AcntNm, string OrdDt, long OrdNo, long OrgOrdNo, string OrdTime, string IsuNo, string IsuNm, string BnsTpNm, string BnsTpCode, string ErxOrdprcTpCode, string MrcTpNm, string ErxPrcCndiTpCode, string CodeNm, double OrdPrc, long OrdQty, string FnoRjtRsnCode, string OrdTpNm, string ExecTpNm, double ExecPrc, long ExecQty, string ExecTime, long ExecNo, long UnercQty, string UserId, string CommdaCode, string CommdaCodeNm, string IpAddr, string TrdPtnTpNm, string ErxOrdStatCode, string CodeNm0, string ExchRcptTime);

/// <summary>
/// 
/// </summary>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1	1.평균예탁자산기준</param>
/// <param name="BaseAmtTp">기준금액구분	String	Y	1	1@평균예탁자산기준</param>
/// <param name="QryTermTp">조회기간구분	String	Y	1</param>
/// <param name="PnlCalcTpCode">손익산출구분코드	String	Y	1</param>
public record FOCCQ33700InBlock1(string QrySrtDt, string QryEndDt, string QryTp, string BaseAmtTp, string QryTermTp, string PnlCalcTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QrySrtDt">조회시작일	String	Y	8</param>
/// <param name="QryEndDt">조회종료일	String	Y	8</param>
/// <param name="QryTp">조회구분	String	Y	1</param>
/// <param name="BaseAmtTp">기준금액구분	String	Y	1</param>
/// <param name="QryTermTp">조회기간구분	String	Y	1</param>
/// <param name="PnlCalcTpCode">손익산출구분코드	String	Y	1</param>
public record FOCCQ33700OutBlock1(int RecCnt, string AcntNo, string Pwd, string QrySrtDt, string QryEndDt, string QryTp, string BaseAmtTp, string QryTermTp, string PnlCalcTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="InAmt">입금액	Number	Y	16</param>
/// <param name="OutAmt">출금액	Number	Y	16</param>
/// <param name="FnoCtrctAmt">선물옵션약정금액	Number	Y	16</param>
/// <param name="InvstPramtAvrbalAmt">투자원금평잔금액	Number	Y	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	Number	Y	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	Number	Y	16</param>
/// <param name="InvstPlAmt">투자손익금액	Number	Y	16</param>
/// <param name="ErnRat">수익률	Number	Y	12.6</param>
public record FOCCQ33700OutBlock2(int RecCnt, string AcntNm, long InAmt, long OutAmt, long FnoCtrctAmt, long InvstPramtAvrbalAmt, long FutsAdjstDfamt, long OptBsnPnlAmt, long OptEvalPnlAmt, long InvstPlAmt, double ErnRat);

/// <summary>
/// 
/// </summary>
/// <param name="TrdDt">거래일	String	Y	8</param>
/// <param name="FdDpsastAmt">기초예탁자산금액	Number	Y	16</param>
/// <param name="EotDpsastAmt">기말예탁자산금액	Number	Y	16</param>
/// <param name="InAmt">입금액	Number	Y	16</param>
/// <param name="OutAmt">출금액	Number	Y	16</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	Number	Y	16</param>
/// <param name="InvstPlAmt">투자손익금액	Number	Y	16</param>
/// <param name="Ernrat">수익률	Number	Y	12.6</param>
/// <param name="FnoCtrctAmt">선물옵션약정금액	Number	Y	16</param>
/// <param name="Trnrat">회전율	Number	Y	12.6</param>
/// <param name="FutsAdjstDfamt">선물정산차금	Number	Y	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	Number	Y	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	Number	Y	16</param>
public record FOCCQ33700OutBlock3(string TrdDt, long FdDpsastAmt, long EotDpsastAmt, long InAmt, long OutAmt, long InvstAvrbalPramt, long InvstPlAmt, double Ernrat, long FnoCtrctAmt, double Trnrat, long FutsAdjstDfamt, long OptBsnPnlAmt, long OptEvalPnlAmt);

#endregion

#region [선물/옵션] 주문

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	1@매도</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2	00@지정가</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
public record CFOAT00100InBlock1(string FnoIsuNo, string BnsTpCode, string FnoOrdprcPtnCode, double FnoOrdPrc, long OrdQty);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	String	Y	2</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	String	Y	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	String	Y	9</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="OrdSeqno">주문일련번호	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">항목번호	Number	Y	16</param>
/// <param name="OpDrtnNo">운용지시번호	String	Y	12</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="FundId">펀드ID	String	Y	12</param>
/// <param name="FundOrdNo">펀드주문번호	Number	Y	10</param>
public record CFOAT00100OutBlock1(int RecCnt, string OrdMktCode, string AcntNo, string Pwd, string FnoIsuNo, string BnsTpCode, string FnoOrdPtnCode, string FnoOrdprcPtnCode, string FnoTrdPtnCode, double FnoOrdPrc, long OrdQty, string CommdaCode, string DscusBnsCmpltTime, string GrpId, long OrdSeqno, long PtflNo, long BskNo, long TrchNo, long ItemNo, string OpDrtnNo, string MgempNo, string FundId, long FundOrdNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CFOAT00100OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2	00@지정가</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="MdfyQty">정정수량	Number	Y	16</param>
public record CFOAT00200InBlock1(string FnoIsuNo, long OrgOrdNo, string FnoOrdprcPtnCode, double FnoOrdPrc, long MdfyQty);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	String	Y	2</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	String	Y	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	Number	Y	27.8</param>
/// <param name="MdfyQty">정정수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	String	Y	9</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="OrdSeqno">주문일련번호	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">아이템번호	Number	Y	10</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="FundId">펀드ID	String	Y	12</param>
/// <param name="FundOrgOrdNo">펀드원주문번호	Number	Y	10</param>
/// <param name="FundOrdNo">펀드주문번호	Number	Y	10</param>
public record CFOAT00200OutBlock1(int RecCnt, string OrdMktCode, string AcntNo, string Pwd, string FnoIsuNo, string FnoOrdPtnCode, long OrgOrdNo, string FnoOrdprcPtnCode, double FnoOrdPrc, long MdfyQty, string CommdaCode, string DscusBnsCmpltTime, string GrpId, long OrdSeqno, long PtflNo, long BskNo, long TrchNo, long ItemNo, string MgempNo, string FundId, long FundOrgOrdNo, long FundOrdNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금액	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CFOAT00200OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="CancQty">취소수량	Number	Y	16</param>
public record CFOAT00300InBlock1(string FnoIsuNo, long OrgOrdNo, long CancQty);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdMktCode">주문시장코드	String	Y	2</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	String	Y	2</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="CancQty">취소수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	String	Y	9</param>
/// <param name="GrpId">그룹ID	String	Y	20</param>
/// <param name="OrdSeqno">주문일련번호	Number	Y	10</param>
/// <param name="PtflNo">포트폴리오번호	Number	Y	10</param>
/// <param name="BskNo">바스켓번호	Number	Y	10</param>
/// <param name="TrchNo">트렌치번호	Number	Y	10</param>
/// <param name="ItemNo">아이템번호	Number	Y	10</param>
/// <param name="MgempNo">관리사원번호	String	Y	9</param>
/// <param name="FundId">펀드ID	String	Y	12</param>
/// <param name="FundOrgOrdNo">펀드원주문번호	Number	Y	10</param>
/// <param name="FundOrdNo">펀드주문번호	Number	Y	10</param>
public record CFOAT00300OutBlock1(int RecCnt, string OrdMktCode, string AcntNo, string Pwd, string FnoIsuNo, string FnoOrdPtnCode, long OrgOrdNo, long CancQty, string CommdaCode, string DscusBnsCmpltTime, string GrpId, long OrdSeqno, long PtflNo, long BskNo, long TrchNo, long ItemNo, string MgempNo, string FundId, long FundOrgOrdNo, long FundOrdNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금액	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CFOAT00300OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="SpclDtPtnCode">특별일자유형코드	String	Y	3	기본	공백,	단,	위클리옵션은	월요일	"MON"	,	목요일	"THR"</param>
/// <param name="SettWklyCnt">결제주간수	String	Y	2	기본	공백,	단,	위클리옵션은	해당	주물	"W1",	"W3",	"W4"</param>
/// <param name="DueYymm">만기년월	String	Y	6	예)2023년	05월물</param>
/// <param name="IsuSmclssCode">종목소분류코드	String	Y	3	501@코스피200</param>
/// <param name="IsuMdclssCode">종목중분류코드	String	Y	2	00@전체</param>
public record CFOBQ10800InBlock1(string SpclDtPtnCode, string SettWklyCnt, string DueYymm, string IsuSmclssCode, string IsuMdclssCode);

/// <summary>
/// 
/// </summary>
/// <param name="SpclDtPtnCode">특별일자유형코드	String	Y	3</param>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="IsuMdclssCode">종목중분류코드	String	Y	2</param>
/// <param name="IsuSmclssCode">종목소분류코드	String	Y	3</param>
/// <param name="DueYymm">만기년월	String	Y	6</param>
/// <param name="SettWklyCnt">결제주간수	String	Y	2</param>
public record CFOBQ10800OutBlock1(string SpclDtPtnCode, int RecCnt, string IsuMdclssCode, string IsuSmclssCode, string DueYymm, string SettWklyCnt);

/// <summary>
/// 
/// </summary>
/// <param name="ElwXrcPrc">행사가	Number	Y	13.2</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="HanglIsuNm1">한글종목명1	String	Y	40</param>
/// <param name="TpNm1">구분명1	String	Y	40</param>
/// <param name="UpOptRegulThrprc">상승옵션조정이론가	Number	Y	27.8</param>
/// <param name="Thrprc1">이론가1	Number	Y	19.8</param>
/// <param name="BasePrc1">기준가1	Number	Y	13.2</param>
/// <param name="OrdMgn1">주문증거금액1	Number	Y	16</param>
/// <param name="FnoIsuNo0">선물옵션종목번호0	String	Y	12</param>
/// <param name="HanglIsuNm2">한글종목명2	String	Y	40</param>
/// <param name="TpNm2">구분명2	String	Y	40</param>
/// <param name="DownOptRegulThrprc">하락옵션조정이론가	Number	Y	27.8</param>
/// <param name="Thrprc2">이론가2	Number	Y	19.8</param>
/// <param name="BasePrc2">기준가2	Number	Y	13.2</param>
/// <param name="OrdMgn2">주문증거금액2	Number	Y	16</param>
public record CFOBQ10800OutBlock2(double ElwXrcPrc, string FnoIsuNo, string HanglIsuNm1, string TpNm1, double UpOptRegulThrprc, double Thrprc1, double BasePrc1, long OrdMgn1, string FnoIsuNo0, string HanglIsuNm2, string TpNm2, double DownOptRegulThrprc, double Thrprc2, double BasePrc2, long OrdMgn2);

/// <summary>
/// 
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1	1:매도</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
public record CEXAT11100InBlock1(string FnoIsuNo, string BnsTpCode, string ErxPrcCndiTpCode, double OrdPrc, long OrdQty);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분	String	Y	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdCndiPrc">주문조건가격	Number	Y	25.8</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
public record CEXAT11100OutBlock1(int RecCnt, string AcntNo, string Pwd, string FnoIsuNo, string BnsTpCode, string ErxPrcCndiTpCode, double OrdPrc, long OrdQty, double OrdCndiPrc, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CEXAT11100OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
public record CEXAT11200InBlock1(long OrgOrdNo, string FnoIsuNo, double OrdPrc);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	String	Y	1</param>
/// <param name="OrdPrc">주문가격	Number	Y	15.2</param>
/// <param name="MdfyQty">정정수량	Number	Y	16</param>
/// <param name="OrdCndiPrc">주문조건가격	Number	Y	25.8</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
public record CEXAT11200OutBlock1(int RecCnt, long OrgOrdNo, string AcntNo, string Pwd, string FnoIsuNo, string BnsTpCode, string ErxPrcCndiTpCode, double OrdPrc, long MdfyQty, double OrdCndiPrc, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금액	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CEXAT11200OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
public record CEXAT11300InBlock1(long OrgOrdNo, string FnoIsuNo);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	String	Y	12</param>
/// <param name="CancQty">취소수량	Number	Y	16</param>
/// <param name="CommdaCode">통신매체코드	String	Y	2</param>
public record CEXAT11300OutBlock1(int RecCnt, long OrgOrdNo, string AcntNo, string Pwd, string FnoIsuNo, long CancQty, string CommdaCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdNo">주문번호	Number	Y	10</param>
/// <param name="BrnNm">지점명	String	Y	40</param>
/// <param name="AcntNm">계좌명	String	Y	40</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	Number	Y	16</param>
/// <param name="OrdMgn">주문증거금액	Number	Y	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	Number	Y	16</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CEXAT11300OutBlock2(int RecCnt, long OrdNo, string BrnNm, string AcntNm, string IsuNm, long OrdAbleAmt, long MnyOrdAbleAmt, long OrdMgn, long MnyOrdMgn, long OrdAbleQty);

#endregion

#region [선물/옵션] 기타

/// <summary>
/// 
/// </summary>
/// <param name="IsuLgclssCode">종목대분류코드	String	Y	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	String	Y	2</param>
public record MMDAQ91200InBlock1(string IsuLgclssCode, string IsuMdclssCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="IsuLgclssCode">종목대분류코드	String	Y	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	String	Y	2</param>
public record MMDAQ91200OutBlock1(int RecCnt, string IsuLgclssCode, string IsuMdclssCode);

/// <summary>
/// 
/// </summary>
/// <param name="IsuSmclssCode">종목소분류코드	String	Y	3</param>
/// <param name="IsuMdclssCode">종목중분류코드	String	Y	2</param>
/// <param name="IsuLrgMdclssNm">종목대중분류명	String	Y	40</param>
/// <param name="IsuLrgMidSmclssNm">종목대중소분류명	String	Y	40</param>
/// <param name="ShtnHanglIsuNm">단축한글종목명	String	Y	40</param>
/// <param name="CsgnMgnrt">위탁증거금율	Number	Y	26.9</param>
/// <param name="MaintMgnrt">유지증거금율	Number	Y	26.9</param>
/// <param name="MnyMgnrt">현금증거금율	Number	Y	26.9</param>
/// <param name="RmndDays">잔여일수	Number	Y	6</param>
/// <param name="OnePrcntrOrdMgn">1계약당주문증거금	Number	Y	17</param>
public record MMDAQ91200OutBlock2(string IsuSmclssCode, string IsuMdclssCode, string IsuLrgMdclssNm, string IsuLrgMidSmclssNm, string ShtnHanglIsuNm, double CsgnMgnrt, double MaintMgnrt, double MnyMgnrt, int RmndDays, long OnePrcntrOrdMgn);

#endregion

#endregion

#region 해외선물

#region [해외선물] 시세

/// <summary>
/// 
/// </summary>
/// <param name="gubun">입력구분(예비)	String	Y	1</param>
public record o3101InBlock(string gubun);

/// <summary>
/// 
/// </summary>
/// <param name="Symbol">종목코드	String	Y	8</param>
/// <param name="SymbolNm">종목명	String	Y	50</param>
/// <param name="ApplDate">종목배치수신일(한국일자)	String	Y	8</param>
/// <param name="BscGdsCd">기초상품코드	String	Y	10</param>
/// <param name="BscGdsNm">기초상품명	String	Y	40</param>
/// <param name="ExchCd">거래소코드	String	Y	10</param>
/// <param name="ExchNm">거래소명	String	Y	40</param>
/// <param name="CrncyCd">기준통화코드	String	Y	3</param>
/// <param name="NotaCd">진법구분코드	String	Y	3</param>
/// <param name="UntPrc">호가단위가격	Number	Y	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	Number	Y	15.9</param>
/// <param name="RgltFctr">가격조정계수	Number	Y	15.10</param>
/// <param name="CtrtPrAmt">계약당금액	Number	Y	15.2</param>
/// <param name="GdsCd">상품구분코드	String	Y	3</param>
/// <param name="LstngYr">월물(년)	String	Y	4</param>
/// <param name="LstngM">월물(월)	String	Y	1</param>
/// <param name="EcPrc">정산가격	Number	Y	15.9</param>
/// <param name="DlStrtTm">거래시작시간	String	Y	6</param>
/// <param name="DlEndTm">거래종료시간	String	Y	6</param>
/// <param name="DlPsblCd">거래가능구분코드	String	Y	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	String	Y	1</param>
/// <param name="OpngMgn">개시증거금	Number	Y	15.2</param>
/// <param name="MntncMgn">유지증거금	Number	Y	15.2</param>
/// <param name="OpngMgnR">개시증거금율	Number	Y	7.3</param>
/// <param name="MntncMgnR">유지증거금율	Number	Y	7.3</param>
/// <param name="DotGb">유효소수점자리수	Number	Y	2</param>
public record o3101OutBlock(string Symbol, string SymbolNm, string ApplDate, string BscGdsCd, string BscGdsNm, string ExchCd, string ExchNm, string CrncyCd, string NotaCd, double UntPrc, double MnChgAmt, double RgltFctr, double CtrtPrAmt, string GdsCd, string LstngYr, string LstngM, double EcPrc, string DlStrtTm, string DlEndTm, string DlPsblCd, string MgnCltCd, double OpngMgn, double MntncMgn, double OpngMgnR, double MntncMgnR, int DotGb);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">조회구분	String	Y	1	0:일별	1:주별	2:월별</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="date">조회일자	String	Y	8	YYYYMMDD</param>
public record o3104InBlock(string gubun, string shcode, string date);

/// <summary>
/// 
/// </summary>
/// <param name="chedate">일자	String	Y	8</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">대비구분	String	Y	1</param>
/// <param name="change">대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
public record o3104OutBlock1(string chedate, double price, string sign, double change, double diff, double open, double high, double low, string cgubun, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목심볼	String	Y	8</param>
public record o3105InBlock(string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="Symbol">종목코드	String	Y	8</param>
/// <param name="SymbolNm">종목명	String	Y	50</param>
/// <param name="ApplDate">종목배치수신일	String	Y	8</param>
/// <param name="BscGdsCd">기초상품코드	String	Y	10</param>
/// <param name="BscGdsNm">기초상품명	String	Y	40</param>
/// <param name="ExchCd">거래소코드	String	Y	10</param>
/// <param name="ExchNm">거래소명	String	Y	40</param>
/// <param name="EcCd">정산구분코드	String	Y	1</param>
/// <param name="CrncyCd">기준통화코드	String	Y	3</param>
/// <param name="NotaCd">진법구분코드	String	Y	3</param>
/// <param name="UntPrc">호가단위가격	Number	Y	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	Number	Y	15.9</param>
/// <param name="RgltFctr">가격조정계수	Number	Y	15.10</param>
/// <param name="CtrtPrAmt">계약당금액	Number	Y	15.2</param>
/// <param name="LstngMCnt">상장개월수	Number	Y	2</param>
/// <param name="GdsCd">상품구분코드	String	Y	3</param>
/// <param name="MrktCd">시장구분코드	String	Y	3</param>
/// <param name="EminiCd">Emini구분코드	String	Y	1</param>
/// <param name="LstngYr">상장년	String	Y	4</param>
/// <param name="LstngM">상장월	String	Y	1</param>
/// <param name="SeqNo">월물순서	Number	Y	5</param>
/// <param name="LstngDt">상장일자	String	Y	8</param>
/// <param name="MtrtDt">만기일자	String	Y	8</param>
/// <param name="FnlDlDt">최종거래일	String	Y	8</param>
/// <param name="FstTrsfrDt">최초인도통지일자	String	Y	8</param>
/// <param name="EcPrc">정산가격	Number	Y	15.9</param>
/// <param name="DlDt">거래시작일자(한국)	String	Y	8</param>
/// <param name="DlStrtTm">거래시작시간(한국)	String	Y	6</param>
/// <param name="DlEndTm">거래종료시간(한국)	String	Y	6</param>
/// <param name="OvsStrDay">거래시작일자(현지)	String	Y	8</param>
/// <param name="OvsStrTm">거래시작시간(현지)	String	Y	6</param>
/// <param name="OvsEndDay">거래종료일자(현지)	String	Y	8</param>
/// <param name="OvsEndTm">거래종료시간(현지)	String	Y	6</param>
/// <param name="DlPsblCd">거래가능구분코드	String	Y	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	String	Y	1</param>
/// <param name="OpngMgn">개시증거금	Number	Y	15.2</param>
/// <param name="MntncMgn">유지증거금	Number	Y	15.2</param>
/// <param name="OpngMgnR">개시증거금율	Number	Y	7.3</param>
/// <param name="MntncMgnR">유지증거금율	Number	Y	7.3</param>
/// <param name="DotGb">유효소수점자리수	Number	Y	2</param>
/// <param name="TimeDiff">시차	Number	Y	5</param>
/// <param name="OvsDate">현지체결일자	String	Y	8</param>
/// <param name="KorDate">한국체결일자	String	Y	8</param>
/// <param name="TrdTm">현지체결시간	String	Y	6</param>
/// <param name="RcvTm">한국체결시각	String	Y	6</param>
/// <param name="TrdP">체결가격	Number	Y	15.9</param>
/// <param name="TrdQ">체결수량	Number	Y	10</param>
/// <param name="TotQ">누적거래량	Number	Y	15</param>
/// <param name="TrdAmt">체결거래대금	Number	Y	15.2</param>
/// <param name="TotAmt">누적거래대금	Number	Y	15.2</param>
/// <param name="OpenP">시가	Number	Y	15.9</param>
/// <param name="HighP">고가	Number	Y	15.9</param>
/// <param name="LowP">저가	Number	Y	15.9</param>
/// <param name="CloseP">전일종가	Number	Y	15.9</param>
/// <param name="YdiffP">전일대비	Number	Y	15.9</param>
/// <param name="YdiffSign">전일대비구분	String	Y	1</param>
/// <param name="Cgubun">체결구분	String	Y	1</param>
/// <param name="Diff">등락율	Number	Y	6.2</param>
public record o3105OutBlock(string Symbol, string SymbolNm, string ApplDate, string BscGdsCd, string BscGdsNm, string ExchCd, string ExchNm, string EcCd, string CrncyCd, string NotaCd, double UntPrc, double MnChgAmt, double RgltFctr, double CtrtPrAmt, int LstngMCnt, string GdsCd, string MrktCd, string EminiCd, string LstngYr, string LstngM, int SeqNo, string LstngDt, string MtrtDt, string FnlDlDt, string FstTrsfrDt, double EcPrc, string DlDt, string DlStrtTm, string DlEndTm, string OvsStrDay, string OvsStrTm, string OvsEndDay, string OvsEndTm, string DlPsblCd, string MgnCltCd, double OpngMgn, double MntncMgn, double OpngMgnR, double MntncMgnR, int DotGb, int TimeDiff, string OvsDate, string KorDate, string TrdTm, string RcvTm, double TrdP, long TrdQ, long TotQ, double TrdAmt, double TotAmt, double OpenP, double HighP, double LowP, double CloseP, double YdiffP, string YdiffSign, string Cgubun, double Diff);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목심볼	String	Y	8</param>
public record o3106InBlock(string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목코드	String	Y	8</param>
/// <param name="symbolname">종목명	String	Y	50</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
/// <param name="jnilclose">전일종가	Number	Y	15.9</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="hotime">호가수신시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	Number	Y	15.9</param>
/// <param name="bidho1">매수호가1	Number	Y	15.9</param>
/// <param name="offercnt1">매도호가건수1	Number	Y	10</param>
/// <param name="bidcnt1">매수호가건수1	Number	Y	10</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	10</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	10</param>
/// <param name="offerho2">매도호가2	Number	Y	15.9</param>
/// <param name="bidho2">매수호가2	Number	Y	15.9</param>
/// <param name="offercnt2">매도호가건수2	Number	Y	10</param>
/// <param name="bidcnt2">매수호가건수2	Number	Y	10</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	10</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	10</param>
/// <param name="offerho3">매도호가3	Number	Y	15.9</param>
/// <param name="bidho3">매수호가3	Number	Y	15.9</param>
/// <param name="offercnt3">매도호가건수3	Number	Y	10</param>
/// <param name="bidcnt3">매수호가건수3	Number	Y	10</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	10</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	10</param>
/// <param name="offerho4">매도호가4	Number	Y	15.9</param>
/// <param name="bidho4">매수호가4	Number	Y	15.9</param>
/// <param name="offercnt4">매도호가건수4	Number	Y	10</param>
/// <param name="bidcnt4">매수호가건수4	Number	Y	10</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	10</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	10</param>
/// <param name="offerho5">매도호가5	Number	Y	15.9</param>
/// <param name="bidho5">매수호가5	Number	Y	15.9</param>
/// <param name="offercnt5">매도호가건수5	Number	Y	10</param>
/// <param name="bidcnt5">매수호가건수5	Number	Y	10</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	10</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	10</param>
/// <param name="offercnt">매도호가건수합	Number	Y	10</param>
/// <param name="bidcnt">매수호가건수합	Number	Y	10</param>
/// <param name="offer">매도호가수량합	Number	Y	10</param>
/// <param name="bid">매수호가수량합	Number	Y	10</param>
public record o3106OutBlock(string symbol, string symbolname, double price, string sign, double change, double diff, long volume, double jnilclose, double open, double high, double low, string hotime, double offerho1, double bidho1, long offercnt1, long bidcnt1, long offerrem1, long bidrem1, double offerho2, double bidho2, long offercnt2, long bidcnt2, long offerrem2, long bidrem2, double offerho3, double bidho3, long offercnt3, long bidcnt3, long offerrem3, long bidrem3, double offerho4, double bidho4, long offercnt4, long bidcnt4, long offerrem4, long bidrem4, double offerho5, double bidho5, long offercnt5, long bidcnt5, long offerrem5, long bidrem5, long offercnt, long bidcnt, long offer, long bid);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목심볼	String	Y	8</param>
public record o3107InBlock(string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목코드	String	Y	8</param>
/// <param name="symbolname">종목명	String	Y	50</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
/// <param name="jnilclose">전일종가	Number	Y	15.9</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="offerho1">매도호가1	Number	Y	15.9</param>
/// <param name="bidho1">매수호가1	Number	Y	15.9</param>
/// <param name="offercnt1">매도호가건수1	Number	Y	10</param>
/// <param name="bidcnt1">매수호가건수1	Number	Y	10</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	10</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	10</param>
/// <param name="offercnt">매도호가건수합	Number	Y	10</param>
/// <param name="bidcnt">매수호가건수합	Number	Y	10</param>
/// <param name="offer">매도호가수량합	Number	Y	10</param>
/// <param name="bid">매수호가수량합	Number	Y	10</param>
public record o3107OutBlock(string symbol, string symbolname, double price, string sign, double change, double diff, long volume, double jnilclose, double open, double high, double low, double offerho1, double bidho1, long offercnt1, long bidcnt1, long offerrem1, long bidrem1, long offercnt, long bidcnt, long offer, long bid);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">조회구분	String	Y	1	0:당일	만	사용가능</param>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="readcnt">조회갯수	Number	Y	4</param>
/// <param name="cts_seq">순번CTS	Number	Y	8</param>
public record o3116InBlock(string gubun, string shcode, int readcnt, int cts_seq);

/// <summary>
/// 
/// </summary>
/// <param name="cts_seq">순번CTS	Number	Y	8</param>
public record o3116OutBlock(int cts_seq);

/// <summary>
/// 
/// </summary>
/// <param name="ovsdate">현지일자	String	Y	8</param>
/// <param name="ovstime">현지시간	String	Y	6</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	10</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
public record o3116OutBlock1(string ovsdate, string ovstime, double price, string sign, double change, double diff, long cvolume, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="MktGb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="BscGdsCd">옵션기초상품코드	String	Y	10	ex)	['시장구분'	옵션의	경우]	공란(옵션상품	목록),	O_ES(ES상품옵션종목	목록)</param>
public record o3121InBlock(string MktGb, string BscGdsCd);

/// <summary>
/// 
/// </summary>
/// <param name="Symbol">종목코드	String	Y	16</param>
/// <param name="SymbolNm">종목명	String	Y	50</param>
/// <param name="ApplDate">종목배치수신일(한국일자)	String	Y	8</param>
/// <param name="BscGdsCd">기초상품코드	String	Y	10	시장구분	공란	시	옵션기초상품코드	받는	필드</param>
/// <param name="BscGdsNm">기초상품명	String	Y	40</param>
/// <param name="ExchCd">거래소코드	String	Y	10</param>
/// <param name="ExchNm">거래소명	String	Y	40</param>
/// <param name="CrncyCd">기준통화코드	String	Y	3</param>
/// <param name="NotaCd">진법구분코드	String	Y	3</param>
/// <param name="UntPrc">호가단위가격	Number	Y	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	Number	Y	15.9</param>
/// <param name="RgltFctr">가격조정계수	Number	Y	15.10</param>
/// <param name="CtrtPrAmt">계약당금액	Number	Y	15.2</param>
/// <param name="GdsCd">상품구분코드	String	Y	3</param>
/// <param name="LstngYr">월물(년)	String	Y	4</param>
/// <param name="LstngM">월물(월)	String	Y	1</param>
/// <param name="EcPrc">정산가격	Number	Y	15.9</param>
/// <param name="DlStrtTm">거래시작시간	String	Y	6</param>
/// <param name="DlEndTm">거래종료시간	String	Y	6</param>
/// <param name="DlPsblCd">거래가능구분코드	String	Y	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	String	Y	1</param>
/// <param name="OpngMgn">개시증거금	Number	Y	15.2</param>
/// <param name="MntncMgn">유지증거금	Number	Y	15.2</param>
/// <param name="OpngMgnR">개시증거금율	Number	Y	7.3</param>
/// <param name="MntncMgnR">유지증거금율	Number	Y	7.3</param>
/// <param name="DotGb">유효소수점자리수	Number	Y	2</param>
/// <param name="XrcPrc">옵션행사가	String	Y	15</param>
/// <param name="FdasBasePrc">기초자산기준가격	String	Y	15</param>
/// <param name="OptTpCode">옵션콜풋구분	String	Y	1</param>
/// <param name="RgtXrcPtnCode">권리행사구분코드	String	Y	1</param>
/// <param name="Moneyness">ATM구분	String	Y	1</param>
/// <param name="LastSettPtnCode">해외파생기초자산종목코드	String	Y	30</param>
/// <param name="OptMinOrcPrc">해외옵션최소호가	String	Y	15</param>
/// <param name="OptMinBaseOrcPrc">해외옵션최소기준호가	String	Y	15</param>
public record o3121OutBlock(string Symbol, string SymbolNm, string ApplDate, string BscGdsCd, string BscGdsNm, string ExchCd, string ExchNm, string CrncyCd, string NotaCd, double UntPrc, double MnChgAmt, double RgltFctr, double CtrtPrAmt, string GdsCd, string LstngYr, string LstngM, double EcPrc, string DlStrtTm, string DlEndTm, string DlPsblCd, string MgnCltCd, double OpngMgn, double MntncMgn, double OpngMgnR, double MntncMgnR, int DotGb, string XrcPrc, string FdasBasePrc, string OptTpCode, string RgtXrcPtnCode, string Moneyness, string LastSettPtnCode, string OptMinOrcPrc, string OptMinBaseOrcPrc);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="shcode">단축코드	String	Y	16	ex)	ADU13,2ESF16_1915</param>
/// <param name="ncnt">N분주기	Number	Y	4	ex)	0(30초),	1(1분),	30(30분),	…</param>
/// <param name="readcnt">조회건수	Number	Y	4</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	6</param>
public record o3123InBlock(string mktgb, string shcode, int ncnt, int readcnt, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16</param>
/// <param name="timediff">시차	Number	Y	4</param>
/// <param name="readcnt">조회건수	Number	Y	4</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	6</param>
public record o3123OutBlock(string shcode, int timediff, int readcnt, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">현지시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3123OutBlock1(string date, string time, double open, double high, double low, double close, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="symbol">종목심볼	String	Y	16	ex)	2ESF16_1915</param>
public record o3125InBlock(string mktgb, string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="Symbol">종목코드	String	Y	16</param>
/// <param name="SymbolNm">종목명	String	Y	50</param>
/// <param name="ApplDate">종목배치수신일	String	Y	8</param>
/// <param name="BscGdsCd">기초상품코드	String	Y	10</param>
/// <param name="BscGdsNm">기초상품명	String	Y	40</param>
/// <param name="ExchCd">거래소코드	String	Y	10</param>
/// <param name="ExchNm">거래소명	String	Y	40</param>
/// <param name="EcCd">정산구분코드	String	Y	1</param>
/// <param name="CrncyCd">기준통화코드	String	Y	3</param>
/// <param name="NotaCd">진법구분코드	String	Y	3</param>
/// <param name="UntPrc">호가단위가격	Number	Y	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	Number	Y	15.9</param>
/// <param name="RgltFctr">가격조정계수	Number	Y	15.10</param>
/// <param name="CtrtPrAmt">계약당금액	Number	Y	15.2</param>
/// <param name="LstngMCnt">상장개월수	Number	Y	2</param>
/// <param name="GdsCd">상품구분코드	String	Y	3</param>
/// <param name="MrktCd">시장구분코드	String	Y	3</param>
/// <param name="EminiCd">Emini구분코드	String	Y	1</param>
/// <param name="LstngYr">상장년	String	Y	4</param>
/// <param name="LstngM">상장월	String	Y	1</param>
/// <param name="SeqNo">월물순서	Number	Y	5</param>
/// <param name="LstngDt">상장일자	String	Y	8</param>
/// <param name="MtrtDt">만기일자	String	Y	8</param>
/// <param name="FnlDlDt">최종거래일	String	Y	8</param>
/// <param name="FstTrsfrDt">최초인도통지일자	String	Y	8</param>
/// <param name="EcPrc">정산가격	Number	Y	15.9</param>
/// <param name="DlDt">거래시작일자(한국)	String	Y	8</param>
/// <param name="DlStrtTm">거래시작시간(한국)	String	Y	6</param>
/// <param name="DlEndTm">거래종료시간(한국)	String	Y	6</param>
/// <param name="OvsStrDay">거래시작일자(현지)	String	Y	8</param>
/// <param name="OvsStrTm">거래시작시간(현지)	String	Y	6</param>
/// <param name="OvsEndDay">거래종료일자(현지)	String	Y	8</param>
/// <param name="OvsEndTm">거래종료시간(현지)	String	Y	6</param>
/// <param name="DlPsblCd">거래가능구분코드	String	Y	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	String	Y	1</param>
/// <param name="OpngMgn">개시증거금	Number	Y	15.2</param>
/// <param name="MntncMgn">유지증거금	Number	Y	15.2</param>
/// <param name="OpngMgnR">개시증거금율	Number	Y	7.3</param>
/// <param name="MntncMgnR">유지증거금율	Number	Y	7.3</param>
/// <param name="DotGb">유효소수점자리수	Number	Y	2</param>
/// <param name="TimeDiff">시차	Number	Y	5</param>
/// <param name="OvsDate">현지체결일자	String	Y	8</param>
/// <param name="KorDate">한국체결일자	String	Y	8</param>
/// <param name="TrdTm">현지체결시간	String	Y	6</param>
/// <param name="RcvTm">한국체결시각	String	Y	6</param>
/// <param name="TrdP">체결가격	Number	Y	15.9</param>
/// <param name="TrdQ">체결수량	Number	Y	10</param>
/// <param name="TotQ">누적거래량	Number	Y	15</param>
/// <param name="TrdAmt">체결거래대금	Number	Y	15.2</param>
/// <param name="TotAmt">누적거래대금	Number	Y	15.2</param>
/// <param name="OpenP">시가	Number	Y	15.9</param>
/// <param name="HighP">고가	Number	Y	15.9</param>
/// <param name="LowP">저가	Number	Y	15.9</param>
/// <param name="CloseP">전일종가	Number	Y	15.9</param>
/// <param name="YdiffP">전일대비	Number	Y	15.9</param>
/// <param name="YdiffSign">전일대비구분	String	Y	1</param>
/// <param name="Cgubun">체결구분	String	Y	1</param>
/// <param name="Diff">등락율	Number	Y	6.2</param>
/// <param name="MinOrcPrc">최소호가	Number	Y	15.9</param>
/// <param name="MinBaseOrcPrc">최소기준호가	Number	Y	15.9</param>
public record o3125OutBlock(string Symbol, string SymbolNm, string ApplDate, string BscGdsCd, string BscGdsNm, string ExchCd, string ExchNm, string EcCd, string CrncyCd, string NotaCd, double UntPrc, double MnChgAmt, double RgltFctr, double CtrtPrAmt, int LstngMCnt, string GdsCd, string MrktCd, string EminiCd, string LstngYr, string LstngM, int SeqNo, string LstngDt, string MtrtDt, string FnlDlDt, string FstTrsfrDt, double EcPrc, string DlDt, string DlStrtTm, string DlEndTm, string OvsStrDay, string OvsStrTm, string OvsEndDay, string OvsEndTm, string DlPsblCd, string MgnCltCd, double OpngMgn, double MntncMgn, double OpngMgnR, double MntncMgnR, int DotGb, int TimeDiff, string OvsDate, string KorDate, string TrdTm, string RcvTm, double TrdP, long TrdQ, long TotQ, double TrdAmt, double TotAmt, double OpenP, double HighP, double LowP, double CloseP, double YdiffP, string YdiffSign, string Cgubun, double Diff, double MinOrcPrc, double MinBaseOrcPrc);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="symbol">종목심볼	String	Y	16	ex)	2ESF16_1915</param>
public record o3126InBlock(string mktgb, string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목코드	String	Y	16</param>
/// <param name="symbolname">종목명	String	Y	50</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
/// <param name="jnilclose">전일종가	Number	Y	15.9</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="hotime">호가수신시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	Number	Y	15.9</param>
/// <param name="bidho1">매수호가1	Number	Y	15.9</param>
/// <param name="offercnt1">매도호가건수1	Number	Y	10</param>
/// <param name="bidcnt1">매수호가건수1	Number	Y	10</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	10</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	10</param>
/// <param name="offerho2">매도호가2	Number	Y	15.9</param>
/// <param name="bidho2">매수호가2	Number	Y	15.9</param>
/// <param name="offercnt2">매도호가건수2	Number	Y	10</param>
/// <param name="bidcnt2">매수호가건수2	Number	Y	10</param>
/// <param name="offerrem2">매도호가수량2	Number	Y	10</param>
/// <param name="bidrem2">매수호가수량2	Number	Y	10</param>
/// <param name="offerho3">매도호가3	Number	Y	15.9</param>
/// <param name="bidho3">매수호가3	Number	Y	15.9</param>
/// <param name="offercnt3">매도호가건수3	Number	Y	10</param>
/// <param name="bidcnt3">매수호가건수3	Number	Y	10</param>
/// <param name="offerrem3">매도호가수량3	Number	Y	10</param>
/// <param name="bidrem3">매수호가수량3	Number	Y	10</param>
/// <param name="offerho4">매도호가4	Number	Y	15.9</param>
/// <param name="bidho4">매수호가4	Number	Y	15.9</param>
/// <param name="offercnt4">매도호가건수4	Number	Y	10</param>
/// <param name="bidcnt4">매수호가건수4	Number	Y	10</param>
/// <param name="offerrem4">매도호가수량4	Number	Y	10</param>
/// <param name="bidrem4">매수호가수량4	Number	Y	10</param>
/// <param name="offerho5">매도호가5	Number	Y	15.9</param>
/// <param name="bidho5">매수호가5	Number	Y	15.9</param>
/// <param name="offercnt5">매도호가건수5	Number	Y	10</param>
/// <param name="bidcnt5">매수호가건수5	Number	Y	10</param>
/// <param name="offerrem5">매도호가수량5	Number	Y	10</param>
/// <param name="bidrem5">매수호가수량5	Number	Y	10</param>
/// <param name="offercnt">매도호가건수합	Number	Y	10</param>
/// <param name="bidcnt">매수호가건수합	Number	Y	10</param>
/// <param name="offer">매도호가수량합	Number	Y	10</param>
/// <param name="bid">매수호가수량합	Number	Y	10</param>
public record o3126OutBlock(string symbol, string symbolname, double price, string sign, double change, double diff, long volume, double jnilclose, double open, double high, double low, string hotime, double offerho1, double bidho1, long offercnt1, long bidcnt1, long offerrem1, long bidrem1, double offerho2, double bidho2, long offercnt2, long bidcnt2, long offerrem2, long bidrem2, double offerho3, double bidho3, long offercnt3, long bidcnt3, long offerrem3, long bidrem3, double offerho4, double bidho4, long offercnt4, long bidcnt4, long offerrem4, long bidrem4, double offerho5, double bidho5, long offercnt5, long bidcnt5, long offerrem5, long bidrem5, long offercnt, long bidcnt, long offer, long bid);

/// <summary>
/// 
/// </summary>
/// <param name="nrec">건수	Number	Y	4</param>
public record o3127InBlock(int nrec);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">기본입력	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="symbol">종목심볼	String	Y	16	ex)	2ESF16_1915</param>
public record o3127InBlock1(string mktgb, string symbol);

/// <summary>
/// 
/// </summary>
/// <param name="symbol">종목코드	String	Y	16</param>
/// <param name="symbolname">종목명	String	Y	50</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
/// <param name="jnilclose">전일종가	Number	Y	15.9</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="offerho1">매도호가1	Number	Y	15.9</param>
/// <param name="bidho1">매수호가1	Number	Y	15.9</param>
/// <param name="offercnt1">매도호가건수1	Number	Y	10</param>
/// <param name="bidcnt1">매수호가건수1	Number	Y	10</param>
/// <param name="offerrem1">매도호가수량1	Number	Y	10</param>
/// <param name="bidrem1">매수호가수량1	Number	Y	10</param>
/// <param name="offercnt">매도호가건수합	Number	Y	10</param>
/// <param name="bidcnt">매수호가건수합	Number	Y	10</param>
/// <param name="offer">매도호가수량합	Number	Y	10</param>
/// <param name="bid">매수호가수량합	Number	Y	10</param>
public record o3127OutBlock(string symbol, string symbolname, double price, string sign, double change, double diff, long volume, double jnilclose, double open, double high, double low, double offerho1, double bidho1, long offercnt1, long bidcnt1, long offerrem1, long bidrem1, long offercnt, long bidcnt, long offer, long bid);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="shcode">단축코드	String	Y	16	ex)	ADU13,2ESF16_1915</param>
/// <param name="gubun">주기구분	String	Y	1	ex)	0(일),	1(주),	2(월)</param>
/// <param name="qrycnt">요청건수	Number	Y	4</param>
/// <param name="sdate">시작일자	String	Y	8</param>
/// <param name="edate">종료일자	String	Y	8	ex)	조회당일</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
public record o3128InBlock(string mktgb, string shcode, string gubun, int qrycnt, string sdate, string edate, string cts_date);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16</param>
/// <param name="jisiga">전일시가	Number	Y	15.9</param>
/// <param name="jihigh">전일고가	Number	Y	15.9</param>
/// <param name="jilow">전일저가	Number	Y	15.9</param>
/// <param name="jiclose">존일종가	Number	Y	15.9</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	15.9</param>
/// <param name="dihigh">당일고가	Number	Y	15.9</param>
/// <param name="dilow">당일저가	Number	Y	15.9</param>
/// <param name="diclose">당일종가	Number	Y	15.9</param>
/// <param name="mk_stime">장시작시간	String	Y	6</param>
/// <param name="mk_etime">장마감시간	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record o3128OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, string mk_stime, string mk_etime, string cts_date, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3128OutBlock1(string date, double open, double high, double low, double close, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="gubun">조회구분	String	Y	1	ex)	0(당일),	1(전일)</param>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="shcode">단축코드	String	Y	16	ex)	2ESF16_1915</param>
/// <param name="readcnt">조회갯수	Number	Y	4</param>
/// <param name="cts_seq">순번CTS	Number	Y	8</param>
public record o3136InBlock(string gubun, string mktgb, string shcode, int readcnt, int cts_seq);

/// <summary>
/// 
/// </summary>
/// <param name="cts_seq">순번CTS	Number	Y	8</param>
public record o3136OutBlock(int cts_seq);

/// <summary>
/// 
/// </summary>
/// <param name="ovsdate">현지일자	String	Y	8</param>
/// <param name="ovstime">현지시간	String	Y	6</param>
/// <param name="price">현재가	Number	Y	15.9</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	Number	Y	15.9</param>
/// <param name="diff">등락율	Number	Y	6.2</param>
/// <param name="cvolume">체결수량	Number	Y	10</param>
/// <param name="volume">누적거래량	Number	Y	10</param>
public record o3136OutBlock1(string ovsdate, string ovstime, double price, string sign, double change, double diff, long cvolume, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="shcode">단축코드	String	Y	16	ex)	2ESF16_1915</param>
/// <param name="ncnt">단위	Number	Y	4</param>
/// <param name="qrycnt">건수	Number	Y	4</param>
/// <param name="cts_seq">순번CTS	String	Y	10</param>
/// <param name="cts_daygb">당일구분CTS	String	Y	2</param>
public record o3137InBlock(string mktgb, string shcode, int ncnt, int qrycnt, string cts_seq, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
/// <param name="cts_seq">연속시간	String	Y	10</param>
/// <param name="cts_daygb">연속당일구분	String	Y	2</param>
public record o3137OutBlock(string shcode, int rec_count, string cts_seq, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3137OutBlock1(string date, string time, double open, double high, double low, double close, long volume);

#endregion

#region [해외선물] 계좌

/// <summary>
/// 
/// </summary>
/// <param name="QryTpCode">조회구분코드	String	Y	1	1:신규	2:청산	3:총가능</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	1:매도	2:매수</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11	지정가	(시장가인경우	0)</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1	1:	시장가	2:	지정가</param>
public record CIDBQ01400InBlock1(string QryTpCode, string IsuCodeVal, string BnsTpCode, double OvrsDrvtOrdPrc, string AbrdFutsOrdPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="QryTpCode">조회구분코드	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	18</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1</param>
public record CIDBQ01400OutBlock1(int RecCnt, string QryTpCode, string AcntNo, string IsuCodeVal, string BnsTpCode, double OvrsDrvtOrdPrc, string AbrdFutsOrdPtnCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdAbleQty">주문가능수량	Number	Y	16</param>
public record CIDBQ01400OutBlock2(int RecCnt, long OrdAbleQty);

/// <summary>
/// 
/// </summary>
/// <param name="AcntTpCode">계좌구분코드	String	Y	1	1:위탁</param>
/// <param name="QryDt">조회일자	String	Y	8</param>
/// <param name="BalTpCode">잔고구분코드	String	Y	1	1:합산	2:건별</param>
public record CIDBQ01500InBlock1(string AcntTpCode, string QryDt, string BalTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntTpCode">계좌구분코드	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="FcmAcntNo">FCM계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="QryDt">조회일자	String	Y	8</param>
/// <param name="BalTpCode">잔고구분코드	String	Y	1</param>
public record CIDBQ01500OutBlock1(int RecCnt, string AcntTpCode, string AcntNo, string FcmAcntNo, string Pwd, string QryDt, string BalTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="BaseDt">기준일자	String	Y	8</param>
/// <param name="Dps">예수금	Number	Y	16</param>
/// <param name="LpnlAmt">청산손익금액	Number	Y	19.2</param>
/// <param name="FutsDueBfLpnlAmt">선물만기전청산손익금액	Number	Y	23.2</param>
/// <param name="FutsDueBfCmsn">선물만기전수수료	Number	Y	23.2</param>
/// <param name="CsgnMgn">위탁증거금액	Number	Y	16</param>
/// <param name="MaintMgn">유지증거금	Number	Y	16</param>
/// <param name="CtlmtAmt">신용한도금액	Number	Y	23.2</param>
/// <param name="AddMgn">추가증거금액	Number	Y	16</param>
/// <param name="MgnclRat">마진콜율	Number	Y	27.1</param>
/// <param name="OrdAbleAmt">주문가능금액	Number	Y	16</param>
/// <param name="WthdwAbleAmt">인출가능금액	Number	Y	16</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="CrcyCodeVal">통화코드값	String	Y	3</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	String	Y	10</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	String	Y	1</param>
/// <param name="DueDt">만기일자	String	Y	8</param>
/// <param name="OvrsDrvtXrcPrc">해외파생행사가격	Number	Y	30.11</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="CmnCodeNm">공통코드명	String	Y	100</param>
/// <param name="TpCodeNm">구분코드명	String	Y	50</param>
/// <param name="BalQty">잔고수량	Number	Y	16</param>
/// <param name="PchsPrc">매입가격	Number	Y	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	Number	Y	30.11</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	Number	Y	19.2</param>
/// <param name="CsgnCmsn">위탁수수료	Number	Y	19.2</param>
/// <param name="PosNo">포지션번호	String	Y	13</param>
/// <param name="EufOneCmsnAmt">거래소비용1수수료금액	Number	Y	19.2</param>
/// <param name="EufTwoCmsnAmt">거래소비용2수수료금액	Number	Y	19.2</param>
public record CIDBQ01500OutBlock2(string BaseDt, long Dps, double LpnlAmt, double FutsDueBfLpnlAmt, double FutsDueBfCmsn, long CsgnMgn, long MaintMgn, double CtlmtAmt, long AddMgn, double MgnclRat, long OrdAbleAmt, long WthdwAbleAmt, string AcntNo, string IsuCodeVal, string IsuNm, string CrcyCodeVal, string OvrsDrvtPrdtCode, string OvrsDrvtOptTpCode, string DueDt, double OvrsDrvtXrcPrc, string BnsTpCode, string CmnCodeNm, string TpCodeNm, long BalQty, double PchsPrc, double OvrsDrvtNowPrc, double AbrdFutsEvalPnlAmt, double CsgnCmsn, string PosNo, double EufOneCmsnAmt, double EufTwoCmsnAmt);

/// <summary>
/// 
/// </summary>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="OrdDt">주문일자	String	Y	8	YYYYMMDD	형식</param>
/// <param name="ThdayTpCode">당일구분코드	String	Y	1	SPACE</param>
/// <param name="OrdStatCode">주문상태코드	String	Y	1	0:전체	1:체결	2:미체결</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	0:전체	1:매도	2:매수</param>
/// <param name="QryTpCode">조회구분코드	String	Y	1	1:역순	2:정순</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2	00:전체	01:일반	02:Average	03:Spread</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	String	Y	1	A:전체	F:선물	O:옵션</param>
public record CIDBQ01800InBlock1(string IsuCodeVal, string OrdDt, string ThdayTpCode, string OrdStatCode, string BnsTpCode, string QryTpCode, string OrdPtnCode, string OvrsDrvtFnoTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="ThdayTpCode">당일구분코드	String	Y	1</param>
/// <param name="OrdStatCode">주문상태코드	String	Y	1</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="QryTpCode">조회구분코드	String	Y	1</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	String	Y	1</param>
public record CIDBQ01800OutBlock1(int RecCnt, string AcntNo, string Pwd, string IsuCodeVal, string OrdDt, string ThdayTpCode, string OrdStatCode, string BnsTpCode, string QryTpCode, string OrdPtnCode, string OvrsDrvtFnoTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	String	Y	10</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="FcmOrdNo">FCM주문번호	String	Y	15</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="AbrdFutsXrcPrc">해외선물행사가격	Number	Y	30.11</param>
/// <param name="FcmAcntNo">FCM계좌번호	String	Y	20</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="BnsTpNm">매매구분명	String	Y	10</param>
/// <param name="FutsOrdStatCode">선물주문상태코드	String	Y	1</param>
/// <param name="TpCodeNm">구분코드명	String	Y	50</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1</param>
/// <param name="TrdTpNm">거래구분명	String	Y	20</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1</param>
/// <param name="OrdPtnNm">주문유형명	String	Y	40</param>
/// <param name="OrdPtnTermTpCode">주문유형기간구분코드	String	Y	2</param>
/// <param name="CmnCodeNm">공통코드명	String	Y	100</param>
/// <param name="AppSrtDt">적용시작일자	String	Y	8</param>
/// <param name="AppEndDt">적용종료일자	String	Y	8</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OvrsDrvtExecIsuCode">해외파생체결종목코드	String	Y	30</param>
/// <param name="ExecIsuNm">체결종목명	String	Y	50</param>
/// <param name="ExecBnsTpCode">체결매매구분코드	String	Y	1</param>
/// <param name="ExecBnsTpNm">체결매매구분명	String	Y	10</param>
/// <param name="AbrdFutsExecPrc">해외선물체결가격	Number	Y	30.11</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="OrdCndiPrc">주문조건가격	Number	Y	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	Number	Y	30.11</param>
/// <param name="MdfyQty">정정수량	Number	Y	16</param>
/// <param name="CancQty">취소수량	Number	Y	16</param>
/// <param name="RjtQty">거부수량	Number	Y	13</param>
/// <param name="CnfQty">확인수량	Number	Y	16</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="CvrgYn">반대매매여부	String	Y	1</param>
/// <param name="RegTmnlNo">등록단말번호	String	Y	3</param>
/// <param name="RegBrnNo">등록지점번호	String	Y	3</param>
/// <param name="RegUserId">등록사용자ID	String	Y	16</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="OrdTime">주문시각	String	Y	9</param>
/// <param name="OvrsOptXrcRsvTpCode">해외옵션행사예약구분코드	String	Y	1	1:만기행사</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	String	Y	1</param>
/// <param name="SprdBaseIsuYn">스프레드기준종목여부	String	Y	1</param>
/// <param name="OvrsFutsOrdDt">해외선물주문일자	String	Y	8</param>
/// <param name="OvrsFutsOrdNo2">해외선물주문번호2	String	Y	10</param>
/// <param name="OvrsFutsOrgOrdNo2">해외선물원주문번호2	String	Y	10</param>
/// <param name="OvrsDrvtIsuCode2">해외파생종목코드2	String	Y	30</param>
public record CIDBQ01800OutBlock2(string OvrsFutsOrdNo, string OvrsFutsOrgOrdNo, string FcmOrdNo, string IsuCodeVal, string IsuNm, double AbrdFutsXrcPrc, string FcmAcntNo, string BnsTpCode, string BnsTpNm, string FutsOrdStatCode, string TpCodeNm, string FutsOrdTpCode, string TrdTpNm, string AbrdFutsOrdPtnCode, string OrdPtnNm, string OrdPtnTermTpCode, string CmnCodeNm, string AppSrtDt, string AppEndDt, double OvrsDrvtOrdPrc, long OrdQty, string OvrsDrvtExecIsuCode, string ExecIsuNm, string ExecBnsTpCode, string ExecBnsTpNm, double AbrdFutsExecPrc, long ExecQty, double OrdCndiPrc, double OvrsDrvtNowPrc, long MdfyQty, long CancQty, long RjtQty, long CnfQty, long UnercQty, string CvrgYn, string RegTmnlNo, string RegBrnNo, string RegUserId, string OrdDt, string OrdTime, string OvrsOptXrcRsvTpCode, string OvrsDrvtOptTpCode, string SprdBaseIsuYn, string OvrsFutsOrdDt, string OvrsFutsOrdNo2, string OvrsFutsOrgOrdNo2, string OvrsDrvtIsuCode2);

/// <summary>
/// 
/// </summary>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="QrySrtDt">조회시작일자	String	Y	8	YYYYMMDD	형식	과거조회시는	사용	당일조회시는	공백</param>
/// <param name="QryEndDt">조회종료일자	String	Y	8	YYYYMMDD	형식	과거조회시는	사용	당일조회시는	공백</param>
/// <param name="ThdayTpCode">당일구분코드	String	Y	1	0:과거조회	1:당일조회</param>
/// <param name="OrdStatCode">주문상태코드	String	Y	1	0:전체	1:체결	2:미체결</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	0:전체	1:매도	2:매수</param>
/// <param name="QryTpCode">조회구분코드	String	Y	1	1:역순	2:정순</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2	00:전체	01:일반	02:Average	03:Spread</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	String	Y	1	A:전체	F:선물	O:옵션</param>
public record CIDBQ02400InBlock1(string IsuCodeVal, string QrySrtDt, string QryEndDt, string ThdayTpCode, string OrdStatCode, string BnsTpCode, string QryTpCode, string OrdPtnCode, string OvrsDrvtFnoTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="QrySrtDt">조회시작일자	String	Y	8</param>
/// <param name="QryEndDt">조회종료일자	String	Y	8</param>
/// <param name="ThdayTpCode">당일구분코드	String	Y	1</param>
/// <param name="OrdStatCode">주문상태코드	String	Y	1</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="QryTpCode">조회구분코드	String	Y	1</param>
/// <param name="OrdPtnCode">주문유형코드	String	Y	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	String	Y	1</param>
public record CIDBQ02400OutBlock1(int RecCnt, string AcntNo, string Pwd, string IsuCodeVal, string QrySrtDt, string QryEndDt, string ThdayTpCode, string OrdStatCode, string BnsTpCode, string QryTpCode, string OrdPtnCode, string OvrsDrvtFnoTpCode);

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	String	Y	10</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="FcmOrdNo">FCM주문번호	String	Y	15</param>
/// <param name="ExecDt">체결일자	String	Y	8</param>
/// <param name="OvrsFutsExecNo">해외선물체결번호	String	Y	10</param>
/// <param name="FcmAcntNo">FCM계좌번호	String	Y	20</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="AbrdFutsXrcPrc">해외선물행사가격	Number	Y	30.11</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	0:전체	1:매도	2:매수</param>
/// <param name="BnsTpNm">매매구분명	String	Y	10</param>
/// <param name="FutsOrdStatCode">선물주문상태코드	String	Y	1	0:전체	1:체결	2:미체결</param>
/// <param name="TpCodeNm">구분코드명	String	Y	50	신규,	정정,	취소</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1	공백</param>
/// <param name="TrdTpNm">거래구분명	String	Y	20	주문,	접수,	확인,	체결,	소멸,	거부</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1	공백</param>
/// <param name="OrdPtnNm">주문유형명	String	Y	40	시장가,	지정가,	Stop	Market,	Stop	Limit</param>
/// <param name="OrdPtnTermTpCode">주문유형기간구분코드	String	Y	2	공백</param>
/// <param name="CmnCodeNm">공통코드명	String	Y	100	일반,	Spread</param>
/// <param name="AppSrtDt">적용시작일자	String	Y	8</param>
/// <param name="AppEndDt">적용종료일자	String	Y	8</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="OvrsDrvtExecIsuCode">해외파생체결종목코드	String	Y	30</param>
/// <param name="ExecIsuNm">체결종목명	String	Y	50</param>
/// <param name="ExecBnsTpCode">체결매매구분코드	String	Y	1</param>
/// <param name="ExecBnsTpNm">체결매매구분명	String	Y	10</param>
/// <param name="ExecQty">체결수량	Number	Y	16</param>
/// <param name="AbrdFutsExecPrc">해외선물체결가격	Number	Y	30.11</param>
/// <param name="OrdCndiPrc">주문조건가격	Number	Y	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	Number	Y	30.11</param>
/// <param name="UnercQty">미체결수량	Number	Y	16</param>
/// <param name="TrxStatCode">처리상태코드	String	Y	2	공백</param>
/// <param name="TrxStatCodeNm">처리상태코드명	String	Y	40	공백</param>
/// <param name="CsgnCmsn">위탁수수료	Number	Y	19.2</param>
/// <param name="FcmCmsn">FCM수수료	Number	Y	21.4</param>
/// <param name="ThcoCmsn">당사수수료	Number	Y	19.2</param>
/// <param name="MdaCode">매체코드	String	Y	2	00	창구	22	아이폰	23	안드로이드	41	API	43	로보API	85	HTS	96	최종결제	LP	로스컷	SK	CashCall	SO	조건주문</param>
/// <param name="MdaCodeNm">매체코드명	String	Y	40</param>
/// <param name="RegTmnlNo">등록단말번호	String	Y	3</param>
/// <param name="RegUserId">등록사용자ID	String	Y	16</param>
/// <param name="OrdSndDttm">주문발송일시	String	Y	17</param>
/// <param name="ExecDttm">체결일시	String	Y	17</param>
/// <param name="EufOneCmsnAmt">거래소비용1수수료금액	Number	Y	19.2</param>
/// <param name="EufTwoCmsnAmt">거래소비용2수수료금액	Number	Y	19.2</param>
/// <param name="LchOneCmsnAmt">런던청산소1수수료금액	Number	Y	19.2</param>
/// <param name="LchTwoCmsnAmt">런던청산소2수수료금액	Number	Y	19.2</param>
/// <param name="TrdOneCmsnAmt">거래1수수료금액	Number	Y	19.2</param>
/// <param name="TrdTwoCmsnAmt">거래2수수료금액	Number	Y	19.2</param>
/// <param name="TrdThreeCmsnAmt">거래3수수료금액	Number	Y	19.2</param>
/// <param name="StrmOneCmsnAmt">단기1수수료금액	Number	Y	19.2</param>
/// <param name="StrmTwoCmsnAmt">단기2수수료금액	Number	Y	19.2</param>
/// <param name="StrmThreeCmsnAmt">단기3수수료금액	Number	Y	19.2</param>
/// <param name="TransOneCmsnAmt">전달1수수료금액	Number	Y	19.2</param>
/// <param name="TransTwoCmsnAmt">전달2수수료금액	Number	Y	19.2</param>
/// <param name="TransThreeCmsnAmt">전달3수수료금액	Number	Y	19.2</param>
/// <param name="TransFourCmsnAmt">전달4수수료금액	Number	Y	19.2</param>
/// <param name="OvrsOptXrcRsvTpCode">해외옵션행사예약구분코드	String	Y	1	1:만기행사</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	String	Y	1</param>
/// <param name="SprdBaseIsuYn">스프레드기준종목여부	String	Y	1</param>
/// <param name="OvrsDrvtIsuCode2">해외파생종목코드2	String	Y	30</param>
public record CIDBQ02400OutBlock2(string OrdDt, string OvrsFutsOrdNo, string OvrsFutsOrgOrdNo, string FcmOrdNo, string ExecDt, string OvrsFutsExecNo, string FcmAcntNo, string IsuCodeVal, string IsuNm, double AbrdFutsXrcPrc, string BnsTpCode, string BnsTpNm, string FutsOrdStatCode, string TpCodeNm, string FutsOrdTpCode, string TrdTpNm, string AbrdFutsOrdPtnCode, string OrdPtnNm, string OrdPtnTermTpCode, string CmnCodeNm, string AppSrtDt, string AppEndDt, long OrdQty, double OvrsDrvtOrdPrc, string OvrsDrvtExecIsuCode, string ExecIsuNm, string ExecBnsTpCode, string ExecBnsTpNm, long ExecQty, double AbrdFutsExecPrc, double OrdCndiPrc, double OvrsDrvtNowPrc, long UnercQty, string TrxStatCode, string TrxStatCodeNm, double CsgnCmsn, double FcmCmsn, double ThcoCmsn, string MdaCode, string MdaCodeNm, string RegTmnlNo, string RegUserId, string OrdSndDttm, string ExecDttm, double EufOneCmsnAmt, double EufTwoCmsnAmt, double LchOneCmsnAmt, double LchTwoCmsnAmt, double TrdOneCmsnAmt, double TrdTwoCmsnAmt, double TrdThreeCmsnAmt, double StrmOneCmsnAmt, double StrmTwoCmsnAmt, double StrmThreeCmsnAmt, double TransOneCmsnAmt, double TransTwoCmsnAmt, double TransThreeCmsnAmt, double TransFourCmsnAmt, string OvrsOptXrcRsvTpCode, string OvrsDrvtOptTpCode, string SprdBaseIsuYn, string OvrsDrvtIsuCode2);

/// <summary>
/// 
/// </summary>
/// <param name="AcntTpCode">계좌구분코드	String	Y	1	1	:	위탁계좌	2	:	중개계좌</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
public record CIDBQ03000InBlock1(string AcntTpCode, string TrdDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntTpCode">계좌구분코드	String	Y	1</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="AcntPwd">계좌비밀번호	String	Y	8</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
public record CIDBQ03000OutBlock1(int RecCnt, string AcntTpCode, string AcntNo, string AcntPwd, string TrdDt);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
/// <param name="CrcyObjCode">통화대상코드	String	Y	12</param>
/// <param name="OvrsFutsDps">해외선물예수금	Number	Y	23.2</param>
/// <param name="CustmMnyioAmt">고객입출금금액	Number	Y	19.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	Number	Y	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	Number	Y	19.2</param>
/// <param name="PrexchDps">가환전예수금	Number	Y	19.2</param>
/// <param name="EvalAssetAmt">평가자산금액	Number	Y	19.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	Number	Y	19.2</param>
/// <param name="AbrdFutsAddMgn">해외선물추가증거금액	Number	Y	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	Number	Y	19.2</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	Number	Y	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	Number	Y	19.2</param>
/// <param name="LastSettPnlAmt">최종결제손익금액	Number	Y	19.2</param>
/// <param name="OvrsOptSettAmt">해외옵션결제금액	Number	Y	19.2</param>
/// <param name="OvrsOptBalEvalAmt">해외옵션잔고평가금액	Number	Y	19.2</param>
public record CIDBQ03000OutBlock2(string AcntNo, string TrdDt, string CrcyObjCode, double OvrsFutsDps, double CustmMnyioAmt, double AbrdFutsLqdtPnlAmt, double AbrdFutsCmsnAmt, double PrexchDps, double EvalAssetAmt, double AbrdFutsCsgnMgn, double AbrdFutsAddMgn, double AbrdFutsWthdwAbleAmt, double AbrdFutsOrdAbleAmt, double AbrdFutsEvalPnlAmt, double LastSettPnlAmt, double OvrsOptSettAmt, double OvrsOptBalEvalAmt);

/// <summary>
/// 
/// </summary>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	String	Y	1	1:위탁</param>
/// <param name="CrcyCode">통화코드	String	Y	3	ALL:전체	CAD:캐나다	달러	CHF:스위스	프랑	EUR:유럽연합	유로	GBP:영국	파운드	HKD:홍콩	달러	JPY:일본	엔	SGD:싱가포르	달러	USD:미국	달러</param>
public record CIDBQ05300InBlock1(string OvrsAcntTpCode, string CrcyCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	String	Y	1</param>
/// <param name="FcmAcntNo">FCM계좌번호	String	Y	20</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="AcntPwd">계좌비밀번호	String	Y	8</param>
/// <param name="CrcyCode">통화코드	String	Y	3</param>
public record CIDBQ05300OutBlock1(int RecCnt, string OvrsAcntTpCode, string FcmAcntNo, string AcntNo, string AcntPwd, string CrcyCode);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="CrcyCode">통화코드	String	Y	3</param>
/// <param name="OvrsFutsDps">해외선물예수금	Number	Y	23.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	Number	Y	19.2</param>
/// <param name="OvrsFutsSplmMgn">해외선물추가증거금	Number	Y	23.2</param>
/// <param name="CustmLpnlAmt">고객청산손익금액	Number	Y	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	Number	Y	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	Number	Y	19.2</param>
/// <param name="AbrdFutsEvalDpstgTotAmt">해외선물평가예탁총금액	Number	Y	19.2</param>
/// <param name="Xchrat">환율	Number	Y	15.4</param>
/// <param name="FcurrRealMxchgAmt">외화실환전금액	Number	Y	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	Number	Y	19.2</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	Number	Y	19.2</param>
/// <param name="FutsDueNarrvLqdtPnlAmt">선물만기미도래청산손익금액	Number	Y	19.2</param>
/// <param name="FutsDueNarrvCmsn">선물만기미도래수수료	Number	Y	19.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	Number	Y	19.2</param>
/// <param name="OvrsFutsDueCmsn">해외선물만기수수료	Number	Y	19.2</param>
/// <param name="OvrsFutsOptBuyAmt">해외선물옵션매수금액	Number	Y	23.2</param>
/// <param name="OvrsFutsOptSellAmt">해외선물옵션매도금액	Number	Y	23.2</param>
/// <param name="OptBuyMktWrthAmt">옵션매수시장가치금액	Number	Y	19.2</param>
/// <param name="OptSellMktWrthAmt">옵션매도시장가치금액	Number	Y	19.2</param>
public record CIDBQ05300OutBlock2(string AcntNo, string CrcyCode, double OvrsFutsDps, double AbrdFutsCsgnMgn, double OvrsFutsSplmMgn, double CustmLpnlAmt, double AbrdFutsEvalPnlAmt, double AbrdFutsCmsnAmt, double AbrdFutsEvalDpstgTotAmt, double Xchrat, double FcurrRealMxchgAmt, double AbrdFutsWthdwAbleAmt, double AbrdFutsOrdAbleAmt, double FutsDueNarrvLqdtPnlAmt, double FutsDueNarrvCmsn, double AbrdFutsLqdtPnlAmt, double OvrsFutsDueCmsn, double OvrsFutsOptBuyAmt, double OvrsFutsOptSellAmt, double OptBuyMktWrthAmt, double OptSellMktWrthAmt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OvrsFutsDps">해외선물예수금	Number	Y	23.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	Number	Y	19.2</param>
/// <param name="FutsDueNarrvLqdtPnlAmt">선물만기미도래청산손익금액	Number	Y	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	Number	Y	19.2</param>
/// <param name="AbrdFutsEvalDpstgTotAmt">해외선물평가예탁총금액	Number	Y	19.2</param>
/// <param name="CustmLpnlAmt">고객청산손익금액	Number	Y	19.2</param>
/// <param name="OvrsFutsDueCmsn">해외선물만기수수료	Number	Y	19.2</param>
/// <param name="FcurrRealMxchgAmt">외화실환전금액	Number	Y	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	Number	Y	19.2</param>
/// <param name="FutsDueNarrvCmsn">선물만기미도래수수료	Number	Y	19.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	Number	Y	19.2</param>
/// <param name="OvrsFutsMaintMgn">해외선물유지증거금	Number	Y	19.2</param>
/// <param name="OvrsFutsOptBuyAmt">해외선물옵션매수금액	Number	Y	23.2</param>
/// <param name="OvrsFutsOptSellAmt">해외선물옵션매도금액	Number	Y	23.2</param>
/// <param name="CtlmtAmt">신용한도금액	Number	Y	23.2</param>
/// <param name="OvrsFutsSplmMgn">해외선물추가증거금	Number	Y	23.2</param>
/// <param name="MgnclRat">마진콜율	Number	Y	27.1</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	Number	Y	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	Number	Y	19.2</param>
/// <param name="OptBuyMktWrthAmt">옵션매수시장가치금액	Number	Y	19.2</param>
/// <param name="OptSellMktWrthAmt">옵션매도시장가치금액	Number	Y	19.2</param>
/// <param name="OvrsOptSettAmt">해외옵션결제금액	Number	Y	19.2</param>
/// <param name="OvrsOptBalEvalAmt">해외옵션잔고평가금액	Number	Y	19.2</param>
public record CIDBQ05300OutBlock3(int RecCnt, double OvrsFutsDps, double AbrdFutsLqdtPnlAmt, double FutsDueNarrvLqdtPnlAmt, double AbrdFutsEvalPnlAmt, double AbrdFutsEvalDpstgTotAmt, double CustmLpnlAmt, double OvrsFutsDueCmsn, double FcurrRealMxchgAmt, double AbrdFutsCmsnAmt, double FutsDueNarrvCmsn, double AbrdFutsCsgnMgn, double OvrsFutsMaintMgn, double OvrsFutsOptBuyAmt, double OvrsFutsOptSellAmt, double CtlmtAmt, double OvrsFutsSplmMgn, double MgnclRat, double AbrdFutsOrdAbleAmt, double AbrdFutsWthdwAbleAmt, double OptBuyMktWrthAmt, double OptSellMktWrthAmt, double OvrsOptSettAmt, double OvrsOptBalEvalAmt);

/// <summary>
/// 
/// </summary>
/// <param name="TrdDt">거래일자	String	Y	8</param>
public record CIDEQ00800InBlock1(string TrdDt);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="AcntPwd">계좌비밀번호	String	Y	8</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
public record CIDEQ00800OutBlock1(int RecCnt, string AcntNo, string AcntPwd, string TrdDt);

/// <summary>
/// 
/// </summary>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="TrdDt">거래일자	String	Y	8</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="BnsTpNm">매매구분명	String	Y	10</param>
/// <param name="BalQty">잔고수량	Number	Y	16</param>
/// <param name="LqdtAbleQty">청산가능수량	Number	Y	16</param>
/// <param name="PchsPrc">매입가격	Number	Y	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	Number	Y	30.11</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	Number	Y	19.2</param>
/// <param name="CustmBalAmt">고객잔고금액	Number	Y	19.2</param>
/// <param name="FcurrEvalAmt">외화평가금액	Number	Y	21.4</param>
/// <param name="IsuNm">종목명	String	Y	50</param>
/// <param name="CrcyCodeVal">통화코드값	String	Y	3</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	String	Y	10</param>
/// <param name="DueDt">만기일자	String	Y	8</param>
/// <param name="PrcntrAmt">계약당금액	Number	Y	19.2</param>
/// <param name="FcurrEvalPnlAmt">외화평가손익금액	Number	Y	21.4</param>
public record CIDEQ00800OutBlock2(string AcntNo, string TrdDt, string IsuCodeVal, string BnsTpNm, long BalQty, long LqdtAbleQty, double PchsPrc, double OvrsDrvtNowPrc, double AbrdFutsEvalPnlAmt, double CustmBalAmt, double FcurrEvalAmt, string IsuNm, string CrcyCodeVal, string OvrsDrvtPrdtCode, string DueDt, double PrcntrAmt, double FcurrEvalPnlAmt);

#endregion

#region [해외선물] 주문

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일자	String	Y	8	YYYYMMDD	형식</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1	1:신규</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	1:매도</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1	1:시장가</param>
/// <param name="CrcyCode">통화코드	String	Y	3	SPACE</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	Number	Y	30.11</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="PrdtCode">상품코드	String	Y	6	SPACE</param>
/// <param name="DueYymm">만기년월	String	Y	6	SPACE</param>
/// <param name="ExchCode">거래소코드	String	Y	10	SPACE</param>
public record CIDBT00100InBlock1(string OrdDt, string IsuCodeVal, string FutsOrdTpCode, string BnsTpCode, string AbrdFutsOrdPtnCode, string CrcyCode, double OvrsDrvtOrdPrc, double CndiOrdPrc, long OrdQty, string PrdtCode, string DueYymm, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="BrnCode">지점코드	String	Y	7</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	String	Y	1</param>
/// <param name="CrcyCode">통화코드	String	Y	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	Number	Y	30.11</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="PrdtCode">상품코드	String	Y	6</param>
/// <param name="DueYymm">만기년월	String	Y	6</param>
/// <param name="ExchCode">거래소코드	String	Y	10</param>
public record CIDBT00100OutBlock1(int RecCnt, string OrdDt, string BrnCode, string AcntNo, string Pwd, string IsuCodeVal, string FutsOrdTpCode, string BnsTpCode, string AbrdFutsOrdPtnCode, string CrcyCode, double OvrsDrvtOrdPrc, double CndiOrdPrc, long OrdQty, string PrdtCode, string DueYymm, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	String	Y	10</param>
public record CIDBT00100OutBlock2(int RecCnt, string AcntNo, string OvrsFutsOrdNo);

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일자	String	Y	8	YYYYMMDD	형식</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1	2:정정</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1	1:매도</param>
/// <param name="FutsOrdPtnCode">선물주문유형코드	String	Y	1	2:지정가</param>
/// <param name="CrcyCodeVal">통화코드값	String	Y	3	SPACE</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	Number	Y	30.11</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	String	Y	10	SPACE</param>
/// <param name="DueYymm">만기년월	String	Y	6	SPACE</param>
/// <param name="ExchCode">거래소코드	String	Y	10	SPACE</param>
public record CIDBT00900InBlock1(string OrdDt, string OvrsFutsOrgOrdNo, string IsuCodeVal, string FutsOrdTpCode, string BnsTpCode, string FutsOrdPtnCode, string CrcyCodeVal, double OvrsDrvtOrdPrc, double CndiOrdPrc, long OrdQty, string OvrsDrvtPrdtCode, string DueYymm, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="RegBrnNo">등록지점번호	String	Y	3</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1</param>
/// <param name="BnsTpCode">매매구분코드	String	Y	1</param>
/// <param name="FutsOrdPtnCode">선물주문유형코드	String	Y	1</param>
/// <param name="CrcyCodeVal">통화코드값	String	Y	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	Number	Y	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	Number	Y	30.11</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	String	Y	10</param>
/// <param name="DueYymm">만기년월	String	Y	6</param>
/// <param name="ExchCode">거래소코드	String	Y	10</param>
public record CIDBT00900OutBlock1(int RecCnt, string OrdDt, string RegBrnNo, string AcntNo, string Pwd, string OvrsFutsOrgOrdNo, string IsuCodeVal, string FutsOrdTpCode, string BnsTpCode, string FutsOrdPtnCode, string CrcyCodeVal, double OvrsDrvtOrdPrc, double CndiOrdPrc, long OrdQty, string OvrsDrvtPrdtCode, string DueYymm, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	String	Y	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	String	Y	80</param>
public record CIDBT00900OutBlock2(int RecCnt, string AcntNo, string OvrsFutsOrdNo, string InnerMsgCnts);

/// <summary>
/// 
/// </summary>
/// <param name="OrdDt">주문일자	String	Y	8	YYYYMMDD	형식</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1	3:취소</param>
/// <param name="PrdtTpCode">상품구분코드	String	Y	2	SPACE</param>
/// <param name="ExchCode">거래소코드	String	Y	10	SPACE</param>
public record CIDBT01000InBlock1(string OrdDt, string IsuCodeVal, string OvrsFutsOrgOrdNo, string FutsOrdTpCode, string PrdtTpCode, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="OrdDt">주문일자	String	Y	8</param>
/// <param name="BrnNo">지점번호	String	Y	3</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="Pwd">비밀번호	String	Y	8</param>
/// <param name="IsuCodeVal">종목코드값	String	Y	30</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	String	Y	10</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	String	Y	1</param>
/// <param name="PrdtTpCode">상품구분코드	String	Y	2</param>
/// <param name="ExchCode">거래소코드	String	Y	10</param>
public record CIDBT01000OutBlock1(int RecCnt, string OrdDt, string BrnNo, string AcntNo, string Pwd, string IsuCodeVal, string OvrsFutsOrgOrdNo, string FutsOrdTpCode, string PrdtTpCode, string ExchCode);

/// <summary>
/// 
/// </summary>
/// <param name="RecCnt">레코드갯수	Number	Y	5</param>
/// <param name="AcntNo">계좌번호	String	Y	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	String	Y	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	String	Y	80</param>
public record CIDBT01000OutBlock2(int RecCnt, string AcntNo, string OvrsFutsOrdNo, string InnerMsgCnts);

#endregion

#region [해외선물] 차트

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8	ex)	ADU13</param>
/// <param name="ncnt">N분주기	Number	Y	4	ex)	0(30초),	1(1분),	30(30분),	…</param>
/// <param name="readcnt">조회건수	Number	Y	4</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	6</param>
public record o3103InBlock(string shcode, int ncnt, int readcnt, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="timediff">시차	Number	Y	4</param>
/// <param name="readcnt">조회건수	Number	Y	4</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="cts_time">연속시간	String	Y	6</param>
public record o3103OutBlock(string shcode, int timediff, int readcnt, string cts_date, string cts_time);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">현지시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3103OutBlock1(string date, string time, double open, double high, double low, double close, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16	ex)	ADU13</param>
/// <param name="gubun">주기구분	String	Y	1	ex)	0(일),	1(주),	2(월)</param>
/// <param name="qrycnt">요청건수	Number	Y	4</param>
/// <param name="sdate">시작일자	String	Y	8</param>
/// <param name="edate">종료일자	String	Y	8	ex)	조회당일</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
public record o3108InBlock(string shcode, string gubun, int qrycnt, string sdate, string edate, string cts_date);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16</param>
/// <param name="jisiga">전일시가	Number	Y	15.9</param>
/// <param name="jihigh">전일고가	Number	Y	15.9</param>
/// <param name="jilow">전일저가	Number	Y	15.9</param>
/// <param name="jiclose">존일종가	Number	Y	15.9</param>
/// <param name="jivolume">전일거래량	Number	Y	12</param>
/// <param name="disiga">당일시가	Number	Y	15.9</param>
/// <param name="dihigh">당일고가	Number	Y	15.9</param>
/// <param name="dilow">당일저가	Number	Y	15.9</param>
/// <param name="diclose">당일종가	Number	Y	15.9</param>
/// <param name="mk_stime">장시작시간	String	Y	6</param>
/// <param name="mk_etime">장마감시간	String	Y	6</param>
/// <param name="cts_date">연속일자	String	Y	8</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
public record o3108OutBlock(string shcode, double jisiga, double jihigh, double jilow, double jiclose, long jivolume, double disiga, double dihigh, double dilow, double diclose, string mk_stime, string mk_etime, string cts_date, int rec_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3108OutBlock1(string date, double open, double high, double low, double close, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="ncnt">단위	Number	Y	4</param>
/// <param name="qrycnt">건수	Number	Y	4</param>
/// <param name="cts_seq">순번CTS	String	Y	10</param>
/// <param name="cts_daygb">당일구분CTS	String	Y	2</param>
public record o3117InBlock(string shcode, int ncnt, int qrycnt, string cts_seq, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	8</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
/// <param name="cts_seq">순번CTS	String	Y	10</param>
/// <param name="cts_daygb">당일구분CTS	String	Y	2</param>
public record o3117OutBlock(string shcode, int rec_count, string cts_seq, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	15.9</param>
/// <param name="high">고가	Number	Y	15.9</param>
/// <param name="low">저가	Number	Y	15.9</param>
/// <param name="close">종가	Number	Y	15.9</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3117OutBlock1(string date, string time, double open, double high, double low, double close, long volume);

/// <summary>
/// 
/// </summary>
/// <param name="mktgb">시장구분	String	Y	1	ex)	F(선물),	O(옵션)</param>
/// <param name="shcode">단축코드	String	Y	16	ex)	2ESF16_1915</param>
/// <param name="ncnt">단위	Number	Y	4</param>
/// <param name="qrycnt">건수	Number	Y	4</param>
/// <param name="cts_seq">순번CTS	String	Y	10</param>
/// <param name="cts_daygb">당일구분CTS	String	Y	2</param>
public record o3139InBlock(string mktgb, string shcode, int ncnt, int qrycnt, string cts_seq, string cts_daygb);

/// <summary>
/// 
/// </summary>
/// <param name="shcode">단축코드	String	Y	16</param>
/// <param name="rec_count">레코드카운트	Number	Y	7</param>
/// <param name="cts_seq">연속시간	String	Y	10</param>
/// <param name="cts_daygb">연속당일구분	String	Y	2</param>
/// <param name="last_count">마지막Tick건수	Number	Y	4</param>
public record o3139OutBlock(string shcode, int rec_count, string cts_seq, string cts_daygb, int last_count);

/// <summary>
/// 
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="open">시가	Number	Y	15.8</param>
/// <param name="high">고가	Number	Y	15.8</param>
/// <param name="low">저가	Number	Y	15.8</param>
/// <param name="close">종가	Number	Y	15.8</param>
/// <param name="volume">거래량	Number	Y	12</param>
public record o3139OutBlock1(string date, string time, double open, double high, double low, double close, long volume);

#endregion

#endregion

#region 기타

/// <summary>
/// 
/// </summary>
/// <param name="id">id	String	Y	8</param>
public record t0167InBlock(string id);

/// <summary>
/// 
/// </summary>
/// <param name="dt">일자(YYYYMMDD)	String	Y	8</param>
/// <param name="time">시간(HHMMSSssssss)	String	Y	12</param>
public record t0167OutBlock(string dt, string time);

#endregion

