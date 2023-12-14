namespace eBEST.OpenApi.Blocks;

#region 실시간시세

#region [업종] 실시간 시세

/// <summary>
/// 업종별투자자별매매현황
/// </summary>
/// <param name="tjjcode">투자자코드	String	Y	4</param>
/// <param name="tjjtime">수신시간	String	Y	8</param>
/// <param name="msvolume">매수거래량	String	Y	8</param>
/// <param name="mdvolume">매도거래량	String	Y	8</param>
/// <param name="msvol">거래량순매수	String	Y	8</param>
/// <param name="p_msvol">거래량순매수직전대비	String	Y	8</param>
/// <param name="msvalue">매수거래대금	String	Y	6</param>
/// <param name="mdvalue">매도거래대금	String	Y	6</param>
/// <param name="msval">거래대금순매수	String	Y	6</param>
/// <param name="p_msval">거래대금순매수직전대비	String	Y	6</param>
/// <param name="upcode">업종코드	String	Y	3</param>
public record BM_(string tjjcode, string tjjtime, string msvolume, string mdvolume, string msvol, string p_msvol, string msvalue, string mdvalue, string msval, string p_msval, string upcode);

#endregion

#region [주식] 실시간 시세

/// <summary>
/// ETF호가잔량	
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="lp_offerho1">LP매도호가수량1	String	Y	9</param>
/// <param name="lp_bidho1">LP매수호가수량1	String	Y	9</param>
/// <param name="lp_offerho2">LP매도호가수량2	String	Y	9</param>
/// <param name="lp_bidho2">LP매수호가수량2	String	Y	9</param>
/// <param name="lp_offerho3">LP매도호가수량3	String	Y	9</param>
/// <param name="lp_bidho3">LP매수호가수량3	String	Y	9</param>
/// <param name="lp_offerho4">LP매도호가수량4	String	Y	9</param>
/// <param name="lp_bidho4">LP매수호가수량4	String	Y	9</param>
/// <param name="lp_offerho5">LP매도호가수량5	String	Y	9</param>
/// <param name="lp_bidho5">LP매수호가수량5	String	Y	9</param>
/// <param name="lp_offerho6">LP매도호가수량6	String	Y	9</param>
/// <param name="lp_bidho6">LP매수호가수량6	String	Y	9</param>
/// <param name="lp_offerho7">LP매도호가수량7	String	Y	9</param>
/// <param name="lp_bidho7">LP매수호가수량7	String	Y	9</param>
/// <param name="lp_offerho8">LP매도호가수량8	String	Y	9</param>
/// <param name="lp_bidho8">LP매수호가수량8	String	Y	9</param>
/// <param name="lp_offerho9">LP매도호가수량9	String	Y	9</param>
/// <param name="lp_bidho9">LP매수호가수량9	String	Y	9</param>
/// <param name="lp_offerho10">LP매도호가수량10	String	Y	9</param>
/// <param name="lp_bidho10">LP매수호가수량10	String	Y	9</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	7</param>
/// <param name="bidho1">매수호가1	String	Y	7</param>
/// <param name="offerrem1">매도호가잔량1	String	Y	9</param>
/// <param name="bidrem1">매수호가잔량1	String	Y	9</param>
/// <param name="offerho2">매도호가2	String	Y	7</param>
/// <param name="bidho2">매수호가2	String	Y	7</param>
/// <param name="offerrem2">매도호가잔량2	String	Y	9</param>
/// <param name="bidrem2">매수호가잔량2	String	Y	9</param>
/// <param name="offerho3">매도호가3	String	Y	7</param>
/// <param name="bidho3">매수호가3	String	Y	7</param>
/// <param name="offerrem3">매도호가잔량3	String	Y	9</param>
/// <param name="bidrem3">매수호가잔량3	String	Y	9</param>
/// <param name="offerho4">매도호가4	String	Y	7</param>
/// <param name="bidho4">매수호가4	String	Y	7</param>
/// <param name="offerrem4">매도호가잔량4	String	Y	9</param>
/// <param name="bidrem4">매수호가잔량4	String	Y	9</param>
/// <param name="offerho5">매도호가5	String	Y	7</param>
/// <param name="bidho5">매수호가5	String	Y	7</param>
/// <param name="offerrem5">매도호가잔량5	String	Y	9</param>
/// <param name="bidrem5">매수호가잔량5	String	Y	9</param>
/// <param name="offerho6">매도호가6	String	Y	7</param>
/// <param name="bidho6">매수호가6	String	Y	7</param>
/// <param name="offerrem6">매도호가잔량6	String	Y	9</param>
/// <param name="bidrem6">매수호가잔량6	String	Y	9</param>
/// <param name="offerho7">매도호가7	String	Y	7</param>
/// <param name="bidho7">매수호가7	String	Y	7</param>
/// <param name="offerrem7">매도호가잔량7	String	Y	9</param>
/// <param name="bidrem7">매수호가잔량7	String	Y	9</param>
/// <param name="offerho8">매도호가8	String	Y	7</param>
/// <param name="bidho8">매수호가8	String	Y	7</param>
/// <param name="offerrem8">매도호가잔량8	String	Y	9</param>
/// <param name="bidrem8">매수호가잔량8	String	Y	9</param>
/// <param name="offerho9">매도호가9	String	Y	7</param>
/// <param name="bidho9">매수호가9	String	Y	7</param>
/// <param name="offerrem9">매도호가잔량9	String	Y	9</param>
/// <param name="bidrem9">매수호가잔량9	String	Y	9</param>
/// <param name="offerho10">매도호가10	String	Y	7</param>
/// <param name="bidho10">매수호가10	String	Y	7</param>
/// <param name="offerrem10">매도호가잔량10	String	Y	9</param>
/// <param name="bidrem10">매수호가잔량10	String	Y	9</param>
/// <param name="totofferrem">총매도호가잔량	String	Y	9</param>
/// <param name="totbidrem">총매수호가잔량	String	Y	9</param>
/// <param name="donsigubun">동시호가구분	String	Y	1</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
public record B7_(string hotime, string lp_offerho1, string lp_bidho1, string lp_offerho2, string lp_bidho2, string lp_offerho3, string lp_bidho3, string lp_offerho4, string lp_bidho4, string lp_offerho5, string lp_bidho5, string lp_offerho6, string lp_bidho6, string lp_offerho7, string lp_bidho7, string lp_offerho8, string lp_bidho8, string lp_offerho9, string lp_bidho9, string lp_offerho10, string lp_bidho10, string shcode, string offerho1, string bidho1, string offerrem1, string bidrem1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offerho6, string bidho6, string offerrem6, string bidrem6, string offerho7, string bidho7, string offerrem7, string bidrem7, string offerho8, string bidho8, string offerrem8, string bidrem8, string offerho9, string bidho9, string offerrem9, string bidrem9, string offerho10, string bidho10, string offerrem10, string bidrem10, string totofferrem, string totbidrem, string donsigubun, string alloc_gubun);

/// <summary>
/// KOSPI시간외단일가호가잔량
/// </summary>
/// <param name="dan_hotime">시간외단일가호가시간	String	Y	6</param>
/// <param name="dan_hstatus">시간외단일가장구분	String	Y	2</param>
/// <param name="dan_offerho1">시간외단일가매도호가1	String	Y	8</param>
/// <param name="dan_bidho1">시간외단일가매수호가1	String	Y	8</param>
/// <param name="dan_offerrem1">시간외단일가매도호가잔량1	String	Y	12</param>
/// <param name="dan_bidrem1">시간외단일가매수호가잔량1	String	Y	12</param>
/// <param name="dan_preoffercha1">시간외단일가직전매도대비수량1	String	Y	12</param>
/// <param name="dan_prebidcha1">시간외단일가직전매수대비수량1	String	Y	12</param>
/// <param name="dan_offerho2">시간외단일가매도호가2	String	Y	8</param>
/// <param name="dan_bidho2">시간외단일가매수호가2	String	Y	8</param>
/// <param name="dan_offerrem2">시간외단일가매도호가잔량2	String	Y	12</param>
/// <param name="dan_bidrem2">시간외단일가매수호가잔량2	String	Y	12</param>
/// <param name="dan_preoffercha2">시간외단일가직전매도대비수량2	String	Y	12</param>
/// <param name="dan_prebidcha2">시간외단일가직전매수대비수량2	String	Y	12</param>
/// <param name="dan_offerho3">시간외단일가매도호가3	String	Y	8</param>
/// <param name="dan_bidho3">시간외단일가매수호가3	String	Y	8</param>
/// <param name="dan_offerrem3">시간외단일가매도호가잔량3	String	Y	12</param>
/// <param name="dan_bidrem3">시간외단일가매수호가잔량3	String	Y	12</param>
/// <param name="dan_preoffercha3">시간외단일가직전매도대비수량3	String	Y	12</param>
/// <param name="dan_prebidcha3">시간외단일가직전매수대비수량3	String	Y	12</param>
/// <param name="dan_offerho4">시간외단일가매도호가4	String	Y	8</param>
/// <param name="dan_bidho4">시간외단일가매수호가4	String	Y	8</param>
/// <param name="dan_offerrem4">시간외단일가매도호가잔량4	String	Y	12</param>
/// <param name="dan_bidrem4">시간외단일가매수호가잔량4	String	Y	12</param>
/// <param name="dan_preoffercha4">시간외단일가직전매도대비수량4	String	Y	12</param>
/// <param name="dan_prebidcha4">시간외단일가직전매수대비수량4	String	Y	12</param>
/// <param name="dan_offerho5">시간외단일가매도호가5	String	Y	8</param>
/// <param name="dan_bidho5">시간외단일가매수호가5	String	Y	8</param>
/// <param name="dan_offerrem5">시간외단일가매도호가잔량5	String	Y	12</param>
/// <param name="dan_bidrem5">시간외단일가매수호가잔량5	String	Y	12</param>
/// <param name="dan_preoffercha5">시간외단일가직전매도대비수량5	String	Y	12</param>
/// <param name="dan_prebidcha5">시간외단일가직전매수대비수량5	String	Y	12</param>
/// <param name="dan_totofferrem">시간외단일가총매도호가잔량	String	Y	12</param>
/// <param name="dan_totbidrem">시간외단일가총매수호가잔량	String	Y	12</param>
/// <param name="dan_preoffercha">시간외단일가직전매도호가총대비수량	String	Y	12</param>
/// <param name="dan_prebidcha">시간외단일가직전매수호가총대비수량	String	Y	12</param>
/// <param name="dan_yeprice">시간외단일가예상체결가격	String	Y	8</param>
/// <param name="dan_yevolume">시간외단일가예상체결수량	String	Y	12</param>
/// <param name="dan_preysign">시간외단일가예상가직전가대비구분	String	Y	1</param>
/// <param name="dan_preychange">시간외단일가예상가직전가대비	String	Y	8</param>
/// <param name="dan_jnilysign">시간외단일가예상가전일가대비구분	String	Y	1</param>
/// <param name="dan_jnilychange">시간외단일가예상가전일가대비	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
public record DH1(string dan_hotime, string dan_hstatus, string dan_offerho1, string dan_bidho1, string dan_offerrem1, string dan_bidrem1, string dan_preoffercha1, string dan_prebidcha1, string dan_offerho2, string dan_bidho2, string dan_offerrem2, string dan_bidrem2, string dan_preoffercha2, string dan_prebidcha2, string dan_offerho3, string dan_bidho3, string dan_offerrem3, string dan_bidrem3, string dan_preoffercha3, string dan_prebidcha3, string dan_offerho4, string dan_bidho4, string dan_offerrem4, string dan_bidrem4, string dan_preoffercha4, string dan_prebidcha4, string dan_offerho5, string dan_bidho5, string dan_offerrem5, string dan_bidrem5, string dan_preoffercha5, string dan_prebidcha5, string dan_totofferrem, string dan_totbidrem, string dan_preoffercha, string dan_prebidcha, string dan_yeprice, string dan_yevolume, string dan_preysign, string dan_preychange, string dan_jnilysign, string dan_jnilychange, string shcode, string volume);

/// <summary>
/// KOSDAQ시간외단일가호가잔량
/// </summary>
/// <param name="dan_hotime">시간외단일가호가시간	String	Y	6</param>
/// <param name="dan_hstatus">시간외단일가장구분	String	Y	2</param>
/// <param name="dan_offerho1">시간외단일가매도호가1	String	Y	8</param>
/// <param name="dan_bidho1">시간외단일가매수호가1	String	Y	8</param>
/// <param name="dan_offerrem1">시간외단일가매도호가잔량1	String	Y	12</param>
/// <param name="dan_bidrem1">시간외단일가매수호가잔량1	String	Y	12</param>
/// <param name="dan_preoffercha1">시간외단일가직전매도대비수량1	String	Y	12</param>
/// <param name="dan_prebidcha1">시간외단일가직전매수대비수량1	String	Y	12</param>
/// <param name="dan_offerho2">시간외단일가매도호가2	String	Y	8</param>
/// <param name="dan_bidho2">시간외단일가매수호가2	String	Y	8</param>
/// <param name="dan_offerrem2">시간외단일가매도호가잔량2	String	Y	12</param>
/// <param name="dan_bidrem2">시간외단일가매수호가잔량2	String	Y	12</param>
/// <param name="dan_preoffercha2">시간외단일가직전매도대비수량2	String	Y	12</param>
/// <param name="dan_prebidcha2">시간외단일가직전매수대비수량2	String	Y	12</param>
/// <param name="dan_offerho3">시간외단일가매도호가3	String	Y	8</param>
/// <param name="dan_bidho3">시간외단일가매수호가3	String	Y	8</param>
/// <param name="dan_offerrem3">시간외단일가매도호가잔량3	String	Y	12</param>
/// <param name="dan_bidrem3">시간외단일가매수호가잔량3	String	Y	12</param>
/// <param name="dan_preoffercha3">시간외단일가직전매도대비수량3	String	Y	12</param>
/// <param name="dan_prebidcha3">시간외단일가직전매수대비수량3	String	Y	12</param>
/// <param name="dan_offerho4">시간외단일가매도호가4	String	Y	8</param>
/// <param name="dan_bidho4">시간외단일가매수호가4	String	Y	8</param>
/// <param name="dan_offerrem4">시간외단일가매도호가잔량4	String	Y	12</param>
/// <param name="dan_bidrem4">시간외단일가매수호가잔량4	String	Y	12</param>
/// <param name="dan_preoffercha4">시간외단일가직전매도대비수량4	String	Y	12</param>
/// <param name="dan_prebidcha4">시간외단일가직전매수대비수량4	String	Y	12</param>
/// <param name="dan_offerho5">시간외단일가매도호가5	String	Y	8</param>
/// <param name="dan_bidho5">시간외단일가매수호가5	String	Y	8</param>
/// <param name="dan_offerrem5">시간외단일가매도호가잔량5	String	Y	12</param>
/// <param name="dan_bidrem5">시간외단일가매수호가잔량5	String	Y	12</param>
/// <param name="dan_preoffercha5">시간외단일가직전매도대비수량5	String	Y	12</param>
/// <param name="dan_prebidcha5">시간외단일가직전매수대비수량5	String	Y	12</param>
/// <param name="dan_totofferrem">시간외단일가총매도호가잔량	String	Y	12</param>
/// <param name="dan_totbidrem">시간외단일가총매수호가잔량	String	Y	12</param>
/// <param name="dan_preoffercha">시간외단일가직전매도호가총대비수량	String	Y	12</param>
/// <param name="dan_prebidcha">시간외단일가직전매수호가총대비수량	String	Y	12</param>
/// <param name="dan_yeprice">시간외단일가예상체결가격	String	Y	8</param>
/// <param name="dan_yevolume">시간외단일가예상체결수량	String	Y	12</param>
/// <param name="dan_preysign">시간외단일가예상가직전가대비구분	String	Y	1</param>
/// <param name="dan_preychange">시간외단일가예상가직전가대비	String	Y	8</param>
/// <param name="dan_jnilysign">시간외단일가예상가전일가대비구분	String	Y	1</param>
/// <param name="dan_jnilychange">시간외단일가예상가전일가대비	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
public record DHA(string dan_hotime, string dan_hstatus, string dan_offerho1, string dan_bidho1, string dan_offerrem1, string dan_bidrem1, string dan_preoffercha1, string dan_prebidcha1, string dan_offerho2, string dan_bidho2, string dan_offerrem2, string dan_bidrem2, string dan_preoffercha2, string dan_prebidcha2, string dan_offerho3, string dan_bidho3, string dan_offerrem3, string dan_bidrem3, string dan_preoffercha3, string dan_prebidcha3, string dan_offerho4, string dan_bidho4, string dan_offerrem4, string dan_bidrem4, string dan_preoffercha4, string dan_prebidcha4, string dan_offerho5, string dan_bidho5, string dan_offerrem5, string dan_bidrem5, string dan_preoffercha5, string dan_prebidcha5, string dan_totofferrem, string dan_totbidrem, string dan_preoffercha, string dan_prebidcha, string dan_yeprice, string dan_yevolume, string dan_preysign, string dan_preychange, string dan_jnilysign, string dan_jnilychange, string shcode, string volume);

/// <summary>
/// KOSDAQ시간외단일가체결
/// </summary>
/// <param name="dan_chetime">시간외단일가체결시간	String	Y	6</param>
/// <param name="dan_sign">시간외단일가전일대비구분	String	Y	1</param>
/// <param name="dan_change">시간외단일가전일대비	String	Y	8</param>
/// <param name="dan_drate">시간외단일가등락율	String	Y	6.2</param>
/// <param name="dan_price">시간외단일가현재가	String	Y	8</param>
/// <param name="dan_opentime">시간외단일가시가시간	String	Y	6</param>
/// <param name="dan_open">시간외단일가시가	String	Y	8</param>
/// <param name="dan_hightime">시간외단일가고가시간	String	Y	6</param>
/// <param name="dan_high">시간외단일가고가	String	Y	8</param>
/// <param name="dan_lowtime">시간외단일가저가시간	String	Y	6</param>
/// <param name="dan_low">시간외단일가저가	String	Y	8</param>
/// <param name="dan_cgubun">시간외단일가체결구분	String	Y	1</param>
/// <param name="dan_cvolume">시간외단일가체결량	String	Y	8</param>
/// <param name="dan_volume">시간외단일가누적거래량	String	Y	12</param>
/// <param name="dan_value">시간외단일가누적거래대금	String	Y	12</param>
/// <param name="dan_mdvolume">시간외단일가매도누적체결량	String	Y	12</param>
/// <param name="dan_mdchecnt">시간외단일가매도누적체결건수	String	Y	8</param>
/// <param name="dan_msvolume">시간외단일가매수누적체결량	String	Y	12</param>
/// <param name="dan_mschecnt">시간외단일가매수누적체결건수	String	Y	8</param>
/// <param name="dan_prevolume">시간외단일가직전거래량	String	Y	8</param>
/// <param name="dan_precvolume">시간외단일가직전체결수량	String	Y	8</param>
/// <param name="dan_cpower">시간외단일가체결강도	String	Y	9.2</param>
/// <param name="dan_status">시간외단일가장정보	String	Y	2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record DK3(string dan_chetime, string dan_sign, string dan_change, string dan_drate, string dan_price, string dan_opentime, string dan_open, string dan_hightime, string dan_high, string dan_lowtime, string dan_low, string dan_cgubun, string dan_cvolume, string dan_volume, string dan_value, string dan_mdvolume, string dan_mdchecnt, string dan_msvolume, string dan_mschecnt, string dan_prevolume, string dan_precvolume, string dan_cpower, string dan_status, string shcode);

/// <summary>
/// KOSPI시간외단일가체결
/// </summary>
/// <param name="dan_chetime">시간외단일가체결시간	String	Y	6</param>
/// <param name="dan_sign">시간외단일가전일대비구분	String	Y	1</param>
/// <param name="dan_change">시간외단일가전일대비	String	Y	8</param>
/// <param name="dan_drate">시간외단일가등락율	String	Y	6.2</param>
/// <param name="dan_price">시간외단일가현재가	String	Y	8</param>
/// <param name="dan_opentime">시간외단일가시가시간	String	Y	6</param>
/// <param name="dan_open">시간외단일가시가	String	Y	8</param>
/// <param name="dan_hightime">시간외단일가고가시간	String	Y	6</param>
/// <param name="dan_high">시간외단일가고가	String	Y	8</param>
/// <param name="dan_lowtime">시간외단일가저가시간	String	Y	6</param>
/// <param name="dan_low">시간외단일가저가	String	Y	8</param>
/// <param name="dan_cgubun">시간외단일가체결구분	String	Y	1</param>
/// <param name="dan_cvolume">시간외단일가체결량	String	Y	8</param>
/// <param name="dan_volume">시간외단일가누적거래량	String	Y	12</param>
/// <param name="dan_value">시간외단일가누적거래대금	String	Y	12</param>
/// <param name="dan_mdvolume">시간외단일가매도누적체결량	String	Y	12</param>
/// <param name="dan_mdchecnt">시간외단일가매도누적체결건수	String	Y	8</param>
/// <param name="dan_msvolume">시간외단일가매수누적체결량	String	Y	12</param>
/// <param name="dan_mschecnt">시간외단일가매수누적체결건수	String	Y	8</param>
/// <param name="dan_prevolume">시간외단일가직전거래량	String	Y	8</param>
/// <param name="dan_precvolume">시간외단일가직전체결수량	String	Y	8</param>
/// <param name="dan_cpower">시간외단일가체결강도	String	Y	9.2</param>
/// <param name="dan_status">시간외단일가장정보	String	Y	2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record DS3(string dan_chetime, string dan_sign, string dan_change, string dan_drate, string dan_price, string dan_opentime, string dan_open, string dan_hightime, string dan_high, string dan_lowtime, string dan_low, string dan_cgubun, string dan_cvolume, string dan_volume, string dan_value, string dan_mdvolume, string dan_mdchecnt, string dan_msvolume, string dan_mschecnt, string dan_prevolume, string dan_precvolume, string dan_cpower, string dan_status, string shcode);

/// <summary>
/// 시간외단일가VI발동해제
/// </summary>
/// <param name="svi_recprice">정적VI발동기준가격	String	Y	8</param>
/// <param name="dvi_recprice">동적VI발동기준가격	String	Y	8</param>
/// <param name="vi_trgprice">VI발동가격	String	Y	8</param>
/// <param name="shcode">단축코드(KEY)	String	Y	6</param>
/// <param name="ref_shcode">참조코드(미사용)	String	Y	6</param>
/// <param name="time">시간	String	Y	6</param>
public record DVI(string svi_recprice, string dvi_recprice, string vi_trgprice, string shcode, string ref_shcode, string time);

/// <summary>
/// KOSPI호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	7</param>
/// <param name="bidho1">매수호가1	String	Y	7</param>
/// <param name="offerrem1">매도호가잔량1	String	Y	9</param>
/// <param name="bidrem1">매수호가잔량1	String	Y	9</param>
/// <param name="offerho2">매도호가2	String	Y	7</param>
/// <param name="bidho2">매수호가2	String	Y	7</param>
/// <param name="offerrem2">매도호가잔량2	String	Y	9</param>
/// <param name="bidrem2">매수호가잔량2	String	Y	9</param>
/// <param name="offerho3">매도호가3	String	Y	7</param>
/// <param name="bidho3">매수호가3	String	Y	7</param>
/// <param name="offerrem3">매도호가잔량3	String	Y	9</param>
/// <param name="bidrem3">매수호가잔량3	String	Y	9</param>
/// <param name="offerho4">매도호가4	String	Y	7</param>
/// <param name="bidho4">매수호가4	String	Y	7</param>
/// <param name="offerrem4">매도호가잔량4	String	Y	9</param>
/// <param name="bidrem4">매수호가잔량4	String	Y	9</param>
/// <param name="offerho5">매도호가5	String	Y	7</param>
/// <param name="bidho5">매수호가5	String	Y	7</param>
/// <param name="offerrem5">매도호가잔량5	String	Y	9</param>
/// <param name="bidrem5">매수호가잔량5	String	Y	9</param>
/// <param name="offerho6">매도호가6	String	Y	7</param>
/// <param name="bidho6">매수호가6	String	Y	7</param>
/// <param name="offerrem6">매도호가잔량6	String	Y	9</param>
/// <param name="bidrem6">매수호가잔량6	String	Y	9</param>
/// <param name="offerho7">매도호가7	String	Y	7</param>
/// <param name="bidho7">매수호가7	String	Y	7</param>
/// <param name="offerrem7">매도호가잔량7	String	Y	9</param>
/// <param name="bidrem7">매수호가잔량7	String	Y	9</param>
/// <param name="offerho8">매도호가8	String	Y	7</param>
/// <param name="bidho8">매수호가8	String	Y	7</param>
/// <param name="offerrem8">매도호가잔량8	String	Y	9</param>
/// <param name="bidrem8">매수호가잔량8	String	Y	9</param>
/// <param name="offerho9">매도호가9	String	Y	7</param>
/// <param name="bidho9">매수호가9	String	Y	7</param>
/// <param name="offerrem9">매도호가잔량9	String	Y	9</param>
/// <param name="bidrem9">매수호가잔량9	String	Y	9</param>
/// <param name="offerho10">매도호가10	String	Y	7</param>
/// <param name="bidho10">매수호가10	String	Y	7</param>
/// <param name="offerrem10">매도호가잔량10	String	Y	9</param>
/// <param name="bidrem10">매수호가잔량10	String	Y	9</param>
/// <param name="totofferrem">총매도호가잔량	String	Y	9</param>
/// <param name="totbidrem">총매수호가잔량	String	Y	9</param>
/// <param name="donsigubun">동시호가구분	String	Y	1</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
/// <param name="volume">누적거래량	String	Y	12</param>
public record H1_(string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offerho6, string bidho6, string offerrem6, string bidrem6, string offerho7, string bidho7, string offerrem7, string bidrem7, string offerho8, string bidho8, string offerrem8, string bidrem8, string offerho9, string bidho9, string offerrem9, string bidrem9, string offerho10, string bidho10, string offerrem10, string bidrem10, string totofferrem, string totbidrem, string donsigubun, string shcode, string alloc_gubun, string volume);

/// <summary>
/// KOSPI장전시간외호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="tmofferrem">시간외매도잔량	String	Y	12</param>
/// <param name="tmbidrem">시간외매수잔량	String	Y	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	String	Y	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record H2_(string hotime, string tmofferrem, string tmbidrem, string pretmoffercha, string pretmbidcha, string shcode);

/// <summary>
/// KOSDAQ호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	7</param>
/// <param name="bidho1">매수호가1	String	Y	7</param>
/// <param name="offerrem1">매도호가잔량1	String	Y	9</param>
/// <param name="bidrem1">매수호가잔량1	String	Y	9</param>
/// <param name="offerho2">매도호가2	String	Y	7</param>
/// <param name="bidho2">매수호가2	String	Y	7</param>
/// <param name="offerrem2">매도호가잔량2	String	Y	9</param>
/// <param name="bidrem2">매수호가잔량2	String	Y	9</param>
/// <param name="offerho3">매도호가3	String	Y	7</param>
/// <param name="bidho3">매수호가3	String	Y	7</param>
/// <param name="offerrem3">매도호가잔량3	String	Y	9</param>
/// <param name="bidrem3">매수호가잔량3	String	Y	9</param>
/// <param name="offerho4">매도호가4	String	Y	7</param>
/// <param name="bidho4">매수호가4	String	Y	7</param>
/// <param name="offerrem4">매도호가잔량4	String	Y	9</param>
/// <param name="bidrem4">매수호가잔량4	String	Y	9</param>
/// <param name="offerho5">매도호가5	String	Y	7</param>
/// <param name="bidho5">매수호가5	String	Y	7</param>
/// <param name="offerrem5">매도호가잔량5	String	Y	9</param>
/// <param name="bidrem5">매수호가잔량5	String	Y	9</param>
/// <param name="offerho6">매도호가6	String	Y	7</param>
/// <param name="bidho6">매수호가6	String	Y	7</param>
/// <param name="offerrem6">매도호가잔량6	String	Y	9</param>
/// <param name="bidrem6">매수호가잔량6	String	Y	9</param>
/// <param name="offerho7">매도호가7	String	Y	7</param>
/// <param name="bidho7">매수호가7	String	Y	7</param>
/// <param name="offerrem7">매도호가잔량7	String	Y	9</param>
/// <param name="bidrem7">매수호가잔량7	String	Y	9</param>
/// <param name="offerho8">매도호가8	String	Y	7</param>
/// <param name="bidho8">매수호가8	String	Y	7</param>
/// <param name="offerrem8">매도호가잔량8	String	Y	9</param>
/// <param name="bidrem8">매수호가잔량8	String	Y	9</param>
/// <param name="offerho9">매도호가9	String	Y	7</param>
/// <param name="bidho9">매수호가9	String	Y	7</param>
/// <param name="offerrem9">매도호가잔량9	String	Y	9</param>
/// <param name="bidrem9">매수호가잔량9	String	Y	9</param>
/// <param name="offerho10">매도호가10	String	Y	7</param>
/// <param name="bidho10">매수호가10	String	Y	7</param>
/// <param name="offerrem10">매도호가잔량10	String	Y	9</param>
/// <param name="bidrem10">매수호가잔량10	String	Y	9</param>
/// <param name="totofferrem">총매도호가잔량	String	Y	9</param>
/// <param name="totbidrem">총매수호가잔량	String	Y	9</param>
/// <param name="donsigubun">동시호가구분	String	Y	1</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
/// <param name="volume">누적거래량	String	Y	12</param>
public record HA_(string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offerho6, string bidho6, string offerrem6, string bidrem6, string offerho7, string bidho7, string offerrem7, string bidrem7, string offerho8, string bidho8, string offerrem8, string bidrem8, string offerho9, string bidho9, string offerrem9, string bidrem9, string offerho10, string bidho10, string offerrem10, string bidrem10, string totofferrem, string totbidrem, string donsigubun, string shcode, string alloc_gubun, string volume);

/// <summary>
/// KOSDAQ장전시간외호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="tmofferrem">시간외매도잔량	String	Y	12</param>
/// <param name="tmbidrem">시간외매수잔량	String	Y	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	String	Y	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record HB_(string hotime, string tmofferrem, string tmbidrem, string pretmoffercha, string pretmbidcha, string shcode);

/// <summary>
/// 코스피ETF종목실시간NAV
/// </summary>
/// <param name="time">시간	String	Y	8</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="navdiff">NAV대비	String	Y	9.2</param>
/// <param name="nav">NAV	String	Y	9.2</param>
/// <param name="navchange">전일대비	String	Y	9.2</param>
/// <param name="crate">추적오차	String	Y	9.2</param>
/// <param name="grate">괴리	String	Y	9.2</param>
/// <param name="jisu">지수	String	Y	8.2</param>
/// <param name="jichange">전일대비	String	Y	8.2</param>
/// <param name="jirate">전일대비율	String	Y	8.2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record I5_(string time, string price, string sign, string change, string volume, string navdiff, string nav, string navchange, string crate, string grate, string jisu, string jichange, string jirate, string shcode);

/// <summary>
/// 지수
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="jisu">지수	String	Y	8.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일비	String	Y	8.2</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="cvolume">체결량	String	Y	8</param>
/// <param name="volume">거래량	String	Y	8</param>
/// <param name="value">거래대금	String	Y	8</param>
/// <param name="upjo">상한종목수	String	Y	4</param>
/// <param name="highjo">상승종목수	String	Y	4</param>
/// <param name="unchgjo">보합종목수	String	Y	4</param>
/// <param name="lowjo">하락종목수	String	Y	4</param>
/// <param name="downjo">하한종목수	String	Y	4</param>
/// <param name="upjrate">상승종목비율	String	Y	6.2</param>
/// <param name="openjisu">시가지수	String	Y	8.2</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="highjisu">고가지수	String	Y	8.2</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="lowjisu">저가지수	String	Y	8.2</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="frgsvolume">외인순매수수량	String	Y	8</param>
/// <param name="orgsvolume">기관순매수수량	String	Y	8</param>
/// <param name="frgsvalue">외인순매수금액	String	Y	10</param>
/// <param name="orgsvalue">기관순매수금액	String	Y	10</param>
/// <param name="upcode">업종코드	String	Y	3</param>
public record IJ_(string time, string jisu, string sign, string change, string drate, string cvolume, string volume, string value, string upjo, string highjo, string unchgjo, string lowjo, string downjo, string upjrate, string openjisu, string opentime, string highjisu, string hightime, string lowjisu, string lowtime, string frgsvolume, string orgsvolume, string frgsvalue, string orgsvalue, string upcode);

/// <summary>
/// KOSPI거래원
/// </summary>
/// <param name="offerno1">매도증권사코드1	String	Y	3</param>
/// <param name="bidno1">매수증권사코드1	String	Y	3</param>
/// <param name="offertrad1">매도회원사명1	String	Y	6</param>
/// <param name="bidtrad1">매수회원사명1	String	Y	6</param>
/// <param name="tradmdvol1">매도거래량1	String	Y	10</param>
/// <param name="tradmsvol1">매수거래량1	String	Y	10</param>
/// <param name="tradmdrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	String	Y	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	String	Y	10</param>
/// <param name="offerno2">매도증권사코드2	String	Y	3</param>
/// <param name="bidno2">매수증권사코드2	String	Y	3</param>
/// <param name="offertrad2">매도회원사명2	String	Y	6</param>
/// <param name="bidtrad2">매수회원사명2	String	Y	6</param>
/// <param name="tradmdvol2">매도거래량2	String	Y	10</param>
/// <param name="tradmsvol2">매수거래량2	String	Y	10</param>
/// <param name="tradmdrate2">매도거래량비중2	String	Y	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	String	Y	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	String	Y	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	String	Y	10</param>
/// <param name="offerno3">매도증권사코드3	String	Y	3</param>
/// <param name="bidno3">매수증권사코드3	String	Y	3</param>
/// <param name="offertrad3">매도회원사명3	String	Y	6</param>
/// <param name="bidtrad3">매수회원사명3	String	Y	6</param>
/// <param name="tradmdvol3">매도거래량3	String	Y	10</param>
/// <param name="tradmsvol3">매수거래량3	String	Y	10</param>
/// <param name="tradmdrate3">매도거래량비중3	String	Y	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	String	Y	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	String	Y	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	String	Y	10</param>
/// <param name="offerno4">매도증권사코드4	String	Y	3</param>
/// <param name="bidno4">매수증권사코드4	String	Y	3</param>
/// <param name="offertrad4">매도회원사명4	String	Y	6</param>
/// <param name="bidtrad4">매수회원사명4	String	Y	6</param>
/// <param name="tradmdvol4">매도거래량4	String	Y	10</param>
/// <param name="tradmsvol4">매수거래량4	String	Y	10</param>
/// <param name="tradmdrate4">매도거래량비중4	String	Y	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	String	Y	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	String	Y	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	String	Y	10</param>
/// <param name="offerno5">매도증권사코드5	String	Y	3</param>
/// <param name="bidno5">매수증권사코드5	String	Y	3</param>
/// <param name="offertrad5">매도회원사명5	String	Y	6</param>
/// <param name="bidtrad5">매수회원사명5	String	Y	6</param>
/// <param name="tradmdvol5">매도거래량5	String	Y	10</param>
/// <param name="tradmsvol5">매수거래량5	String	Y	10</param>
/// <param name="tradmdrate5">매도거래량비중5	String	Y	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	String	Y	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	String	Y	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	String	Y	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	String	Y	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	String	Y	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	String	Y	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	String	Y	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	String	Y	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	String	Y	10</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="tradmdval1">매도거래대금1	String	Y	15</param>
/// <param name="tradmsval1">매수거래대금1	String	Y	15</param>
/// <param name="tradmdavg1">매도평균단가1	String	Y	7</param>
/// <param name="tradmsavg1">매수평균단가1	String	Y	7</param>
/// <param name="tradmdval2">매도거래대금2	String	Y	15</param>
/// <param name="tradmsval2">매수거래대금2	String	Y	15</param>
/// <param name="tradmdavg2">매도평균단가2	String	Y	7</param>
/// <param name="tradmsavg2">매수평균단가2	String	Y	7</param>
/// <param name="tradmdval3">매도거래대금3	String	Y	15</param>
/// <param name="tradmsval3">매수거래대금3	String	Y	15</param>
/// <param name="tradmdavg3">매도평균단가3	String	Y	7</param>
/// <param name="tradmsavg3">매수평균단가3	String	Y	7</param>
/// <param name="tradmdval4">매도거래대금4	String	Y	15</param>
/// <param name="tradmsval4">매수거래대금4	String	Y	15</param>
/// <param name="tradmdavg4">매도평균단가4	String	Y	7</param>
/// <param name="tradmsavg4">매수평균단가4	String	Y	7</param>
/// <param name="tradmdval5">매도거래대금5	String	Y	15</param>
/// <param name="tradmsval5">매수거래대금5	String	Y	15</param>
/// <param name="tradmdavg5">매도평균단가5	String	Y	7</param>
/// <param name="tradmsavg5">매수평균단가5	String	Y	7</param>
/// <param name="ftradmdval">외국계증권사매도거래대금	String	Y	15</param>
/// <param name="ftradmsval">외국계증권사매수거래대금	String	Y	15</param>
/// <param name="ftradmdavg">외국계증권사매도평균단가	String	Y	7</param>
/// <param name="ftradmsavg">외국계증권사매수평균단가	String	Y	7</param>
public record K1_(string offerno1, string bidno1, string offertrad1, string bidtrad1, string tradmdvol1, string tradmsvol1, string tradmdrate1, string tradmsrate1, string tradmdcha1, string tradmscha1, string offerno2, string bidno2, string offertrad2, string bidtrad2, string tradmdvol2, string tradmsvol2, string tradmdrate2, string tradmsrate2, string tradmdcha2, string tradmscha2, string offerno3, string bidno3, string offertrad3, string bidtrad3, string tradmdvol3, string tradmsvol3, string tradmdrate3, string tradmsrate3, string tradmdcha3, string tradmscha3, string offerno4, string bidno4, string offertrad4, string bidtrad4, string tradmdvol4, string tradmsvol4, string tradmdrate4, string tradmsrate4, string tradmdcha4, string tradmscha4, string offerno5, string bidno5, string offertrad5, string bidtrad5, string tradmdvol5, string tradmsvol5, string tradmdrate5, string tradmsrate5, string tradmdcha5, string tradmscha5, string ftradmdvol, string ftradmsvol, string ftradmdrate, string ftradmsrate, string ftradmdcha, string ftradmscha, string shcode, string tradmdval1, string tradmsval1, string tradmdavg1, string tradmsavg1, string tradmdval2, string tradmsval2, string tradmdavg2, string tradmsavg2, string tradmdval3, string tradmsval3, string tradmdavg3, string tradmsavg3, string tradmdval4, string tradmsval4, string tradmdavg4, string tradmsavg4, string tradmdval5, string tradmsval5, string tradmdavg5, string tradmsavg5, string ftradmdval, string ftradmsval, string ftradmdavg, string ftradmsavg);

/// <summary>
/// KOSDAQ체결
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="open">시가	String	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="high">고가	String	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="low">저가	String	Y	8</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="w_avrg">가중평균가	String	Y	8</param>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="status">장정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record K3_(string chetime, string sign, string change, string drate, string price, string opentime, string open, string hightime, string high, string lowtime, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string w_avrg, string offerho, string bidho, string status, string jnilvolume, string shcode);

/// <summary>
/// KOSDAQ프로그램매매종목별
/// </summary>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	10</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="dwcvolume">전체매도위탁체결수량	String	Y	12</param>
/// <param name="swcvolume">전체매수위탁체결수량	String	Y	12</param>
/// <param name="djcvolume">전체매도자기체결수량	String	Y	12</param>
/// <param name="sjcvolume">전체매수자기체결수량	String	Y	12</param>
/// <param name="tdvolume">전체매도체결수량	String	Y	12</param>
/// <param name="tsvolume">전체매수체결수량	String	Y	12</param>
/// <param name="dwcvalue">전체매도위탁체결금액	String	Y	15</param>
/// <param name="swcvalue">전체매수위탁체결금액	String	Y	15</param>
/// <param name="djcvalue">전체매도자기체결금액	String	Y	15</param>
/// <param name="sjcvalue">전체매수자기체결금액	String	Y	15</param>
/// <param name="tdvalue">전체매도체결금액	String	Y	15</param>
/// <param name="tsvalue">전체매수체결금액	String	Y	15</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record KH_(string time, string price, string sign, string change, string volume, string drate, string dwcvolume, string swcvolume, string djcvolume, string sjcvolume, string tdvolume, string tsvolume, string dwcvalue, string swcvalue, string djcvalue, string sjcvalue, string tdvalue, string tsvalue, string shcode);

/// <summary>
/// KOSDAQ프로그램매매전체집계
/// </summary>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="cdwvolume">차익매도위탁체결수량	String	Y	6</param>
/// <param name="cdjvolume">차익매도자기체결수량	String	Y	6</param>
/// <param name="cswvolume">차익매수위탁체결수량	String	Y	6</param>
/// <param name="csjvolume">차익매수자기체결수량	String	Y	6</param>
/// <param name="bdwvolume">비차익매도위탁체결수량	String	Y	6</param>
/// <param name="bdjvolume">비차익매도자기체결수량	String	Y	6</param>
/// <param name="bswvolume">비차익매수위탁체결수량	String	Y	6</param>
/// <param name="bsjvolume">비차익매수자기체결수량	String	Y	6</param>
/// <param name="dwvolume">전체매도위탁체결수량	String	Y	6</param>
/// <param name="swvolume">전체매수위탁체결수량	String	Y	6</param>
/// <param name="djvolume">전체매도자기체결수량	String	Y	6</param>
/// <param name="sjvolume">전체매수자기체결수량	String	Y	6</param>
/// <param name="cdwvalue">차익매도위탁체결금액	String	Y	8</param>
/// <param name="cdjvalue">차익매도자기체결금액	String	Y	8</param>
/// <param name="cswvalue">차익매수위탁체결금액	String	Y	8</param>
/// <param name="csjvalue">차익매수자기체결금액	String	Y	8</param>
/// <param name="bdwvalue">비차익매도위탁체결금액	String	Y	8</param>
/// <param name="bdjvalue">비차익매도자기체결금액	String	Y	8</param>
/// <param name="bswvalue">비차익매수위탁체결금액	String	Y	8</param>
/// <param name="bsjvalue">비차익매수자기체결금액	String	Y	8</param>
/// <param name="dwvalue">전체매도위탁체결금액	String	Y	8</param>
/// <param name="swvalue">전체매수위탁체결금액	String	Y	8</param>
/// <param name="djvalue">전체매도자기체결금액	String	Y	8</param>
/// <param name="sjvalue">전체매수자기체결금액	String	Y	8</param>
/// <param name="cdvolume">차익매도체결수량합계	String	Y	6</param>
/// <param name="csvolume">차익매수체결수량합계	String	Y	6</param>
/// <param name="bdvolume">비차익매도체결수량합계	String	Y	6</param>
/// <param name="bsvolume">비차익매수체결수량합계	String	Y	6</param>
/// <param name="tdvolume">전체매도체결수량합계	String	Y	6</param>
/// <param name="tsvolume">전체매수체결수량합계	String	Y	6</param>
/// <param name="cdvalue">차익매도체결금액합계	String	Y	8</param>
/// <param name="csvalue">차익매수체결금액합계	String	Y	8</param>
/// <param name="bdvalue">비차익매도체결금액합계	String	Y	8</param>
/// <param name="bsvalue">비차익매수체결금액합계	String	Y	8</param>
/// <param name="tdvalue">전체매도체결금액합계	String	Y	8</param>
/// <param name="tsvalue">전체매수체결금액합계	String	Y	8</param>
/// <param name="p_cdvolcha">차익매도체결수량직전대비	String	Y	6</param>
/// <param name="p_csvolcha">차익매수체결수량직전대비	String	Y	6</param>
/// <param name="p_bdvolcha">비차익매도체결수량직전대비	String	Y	6</param>
/// <param name="p_bsvolcha">비차익매수체결수량직전대비	String	Y	6</param>
/// <param name="p_tdvolcha">전체매도체결수량직전대비	String	Y	6</param>
/// <param name="p_tsvolcha">전체매수체결수량직전대비	String	Y	6</param>
/// <param name="p_cdvalcha">차익매도체결금액직전대비	String	Y	8</param>
/// <param name="p_csvalcha">차익매수체결금액직전대비	String	Y	8</param>
/// <param name="p_bdvalcha">비차익매도체결금액직전대비	String	Y	8</param>
/// <param name="p_bsvalcha">비차익매수체결금액직전대비	String	Y	8</param>
/// <param name="p_tdvalcha">전체매도체결금액직전대비	String	Y	8</param>
/// <param name="p_tsvalcha">전체매수체결금액직전대비	String	Y	8</param>
/// <param name="gubun">구분값	String	Y	1</param>
public record KM_(string time, string cdwvolume, string cdjvolume, string cswvolume, string csjvolume, string bdwvolume, string bdjvolume, string bswvolume, string bsjvolume, string dwvolume, string swvolume, string djvolume, string sjvolume, string cdwvalue, string cdjvalue, string cswvalue, string csjvalue, string bdwvalue, string bdjvalue, string bswvalue, string bsjvalue, string dwvalue, string swvalue, string djvalue, string sjvalue, string cdvolume, string csvolume, string bdvolume, string bsvolume, string tdvolume, string tsvolume, string cdvalue, string csvalue, string bdvalue, string bsvalue, string tdvalue, string tsvalue, string p_cdvolcha, string p_csvolcha, string p_bdvolcha, string p_bsvolcha, string p_tdvolcha, string p_tsvolcha, string p_cdvalcha, string p_csvalcha, string p_bdvalcha, string p_bsvalcha, string p_tdvalcha, string p_tsvalcha, string gubun);

/// <summary>
/// KOSDAQ우선호가
/// </summary>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record KS_(string offerho, string bidho, string shcode);

/// <summary>
/// KOSDAQ거래원
/// </summary>
/// <param name="offerno1">매도증권사코드1	String	Y	3</param>
/// <param name="bidno1">매수증권사코드1	String	Y	3</param>
/// <param name="offertrad1">매도회원사명1	String	Y	6</param>
/// <param name="bidtrad1">매수회원사명1	String	Y	6</param>
/// <param name="tradmdvol1">매도거래량1	String	Y	10</param>
/// <param name="tradmsvol1">매수거래량1	String	Y	10</param>
/// <param name="tradmdrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	String	Y	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	String	Y	10</param>
/// <param name="offerno2">매도증권사코드2	String	Y	3</param>
/// <param name="bidno2">매수증권사코드2	String	Y	3</param>
/// <param name="offertrad2">매도회원사명2	String	Y	6</param>
/// <param name="bidtrad2">매수회원사명2	String	Y	6</param>
/// <param name="tradmdvol2">매도거래량2	String	Y	10</param>
/// <param name="tradmsvol2">매수거래량2	String	Y	10</param>
/// <param name="tradmdrate2">매도거래량비중2	String	Y	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	String	Y	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	String	Y	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	String	Y	10</param>
/// <param name="offerno3">매도증권사코드3	String	Y	3</param>
/// <param name="bidno3">매수증권사코드3	String	Y	3</param>
/// <param name="offertrad3">매도회원사명3	String	Y	6</param>
/// <param name="bidtrad3">매수회원사명3	String	Y	6</param>
/// <param name="tradmdvol3">매도거래량3	String	Y	10</param>
/// <param name="tradmsvol3">매수거래량3	String	Y	10</param>
/// <param name="tradmdrate3">매도거래량비중3	String	Y	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	String	Y	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	String	Y	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	String	Y	10</param>
/// <param name="offerno4">매도증권사코드4	String	Y	3</param>
/// <param name="bidno4">매수증권사코드4	String	Y	3</param>
/// <param name="offertrad4">매도회원사명4	String	Y	6</param>
/// <param name="bidtrad4">매수회원사명4	String	Y	6</param>
/// <param name="tradmdvol4">매도거래량4	String	Y	10</param>
/// <param name="tradmsvol4">매수거래량4	String	Y	10</param>
/// <param name="tradmdrate4">매도거래량비중4	String	Y	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	String	Y	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	String	Y	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	String	Y	10</param>
/// <param name="offerno5">매도증권사코드5	String	Y	3</param>
/// <param name="bidno5">매수증권사코드5	String	Y	3</param>
/// <param name="offertrad5">매도회원사명5	String	Y	6</param>
/// <param name="bidtrad5">매수회원사명5	String	Y	6</param>
/// <param name="tradmdvol5">매도거래량5	String	Y	10</param>
/// <param name="tradmsvol5">매수거래량5	String	Y	10</param>
/// <param name="tradmdrate5">매도거래량비중5	String	Y	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	String	Y	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	String	Y	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	String	Y	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	String	Y	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	String	Y	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	String	Y	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	String	Y	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	String	Y	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	String	Y	10</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="tradmdval1">매도거래대금1	String	Y	15</param>
/// <param name="tradmsval1">매수거래대금1	String	Y	15</param>
/// <param name="tradmdavg1">매도평균단가1	String	Y	7</param>
/// <param name="tradmsavg1">매수평균단가1	String	Y	7</param>
/// <param name="tradmdval2">매도거래대금2	String	Y	15</param>
/// <param name="tradmsval2">매수거래대금2	String	Y	15</param>
/// <param name="tradmdavg2">매도평균단가2	String	Y	7</param>
/// <param name="tradmsavg2">매수평균단가2	String	Y	7</param>
/// <param name="tradmdval3">매도거래대금3	String	Y	15</param>
/// <param name="tradmsval3">매수거래대금3	String	Y	15</param>
/// <param name="tradmdavg3">매도평균단가3	String	Y	7</param>
/// <param name="tradmsavg3">매수평균단가3	String	Y	7</param>
/// <param name="tradmdval4">매도거래대금4	String	Y	15</param>
/// <param name="tradmsval4">매수거래대금4	String	Y	15</param>
/// <param name="tradmdavg4">매도평균단가4	String	Y	7</param>
/// <param name="tradmsavg4">매수평균단가4	String	Y	7</param>
/// <param name="tradmdval5">매도거래대금5	String	Y	15</param>
/// <param name="tradmsval5">매수거래대금5	String	Y	15</param>
/// <param name="tradmdavg5">매도평균단가5	String	Y	7</param>
/// <param name="tradmsavg5">매수평균단가5	String	Y	7</param>
/// <param name="ftradmdval">외국계증권사매도거래대금	String	Y	15</param>
/// <param name="ftradmsval">외국계증권사매수거래대금	String	Y	15</param>
/// <param name="ftradmdavg">외국계증권사매도평균단가	String	Y	7</param>
/// <param name="ftradmsavg">외국계증권사매수평균단가	String	Y	7</param>
public record OK_(string offerno1, string bidno1, string offertrad1, string bidtrad1, string tradmdvol1, string tradmsvol1, string tradmdrate1, string tradmsrate1, string tradmdcha1, string tradmscha1, string offerno2, string bidno2, string offertrad2, string bidtrad2, string tradmdvol2, string tradmsvol2, string tradmdrate2, string tradmsrate2, string tradmdcha2, string tradmscha2, string offerno3, string bidno3, string offertrad3, string bidtrad3, string tradmdvol3, string tradmsvol3, string tradmdrate3, string tradmsrate3, string tradmdcha3, string tradmscha3, string offerno4, string bidno4, string offertrad4, string bidtrad4, string tradmdvol4, string tradmsvol4, string tradmdrate4, string tradmsrate4, string tradmdcha4, string tradmscha4, string offerno5, string bidno5, string offertrad5, string bidtrad5, string tradmdvol5, string tradmsvol5, string tradmdrate5, string tradmsrate5, string tradmdcha5, string tradmscha5, string ftradmdvol, string ftradmsvol, string ftradmdrate, string ftradmsrate, string ftradmdcha, string ftradmscha, string shcode, string tradmdval1, string tradmsval1, string tradmdavg1, string tradmsavg1, string tradmdval2, string tradmsval2, string tradmdavg2, string tradmsavg2, string tradmdval3, string tradmsval3, string tradmdavg3, string tradmsavg3, string tradmdval4, string tradmsval4, string tradmdavg4, string tradmsavg4, string tradmdval5, string tradmsval5, string tradmdavg5, string tradmsavg5, string ftradmdval, string ftradmsval, string ftradmdavg, string ftradmsavg);

/// <summary>
/// KOSPI프로그램매매종목별
/// </summary>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	10</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="dwcvolume">전체매도위탁체결수량	String	Y	12</param>
/// <param name="swcvolume">전체매수위탁체결수량	String	Y	12</param>
/// <param name="djcvolume">전체매도자기체결수량	String	Y	12</param>
/// <param name="sjcvolume">전체매수자기체결수량	String	Y	12</param>
/// <param name="tdvolume">전체매도체결수량	String	Y	12</param>
/// <param name="tsvolume">전체매수체결수량	String	Y	12</param>
/// <param name="dwcvalue">전체매도위탁체결금액	String	Y	15</param>
/// <param name="swcvalue">전체매수위탁체결금액	String	Y	15</param>
/// <param name="djcvalue">전체매도자기체결금액	String	Y	15</param>
/// <param name="sjcvalue">전체매수자기체결금액	String	Y	15</param>
/// <param name="tdvalue">전체매도체결금액	String	Y	15</param>
/// <param name="tsvalue">전체매수체결금액	String	Y	15</param>
/// <param name="shcode">종목코드	String	Y	6</param>
public record PH_(string time, string price, string sign, string change, string volume, string drate, string dwcvolume, string swcvolume, string djcvolume, string sjcvolume, string tdvolume, string tsvolume, string dwcvalue, string swcvalue, string djcvalue, string sjcvalue, string tdvalue, string tsvalue, string shcode);

/// <summary>
/// KOSPI프로그램매매전체집계
/// </summary>
/// <param name="time">수신시간	String	Y	6</param>
/// <param name="cdhrem">차익매도호가잔량	String	Y	6</param>
/// <param name="cshrem">차익매수호가잔량	String	Y	6</param>
/// <param name="bdhrem">비차익매도호가잔량	String	Y	6</param>
/// <param name="bshrem">비차익매수호가잔량	String	Y	6</param>
/// <param name="cdhvolume">차익매도호가수량	String	Y	6</param>
/// <param name="cshvolume">차익매수호가수량	String	Y	6</param>
/// <param name="bdhvolume">비차익매도호가수량	String	Y	6</param>
/// <param name="bshvolume">비차익매수호가수량	String	Y	6</param>
/// <param name="cdwvolume">차익매도위탁체결수량	String	Y	6</param>
/// <param name="cdjvolume">차익매도자기체결수량	String	Y	6</param>
/// <param name="cswvolume">차익매수위탁체결수량	String	Y	6</param>
/// <param name="csjvolume">차익매수자기체결수량	String	Y	6</param>
/// <param name="cwvol">차익위탁순매수수량	String	Y	6</param>
/// <param name="cjvol">차익자기순매수수량	String	Y	6</param>
/// <param name="bdwvolume">비차익매도위탁체결수량	String	Y	6</param>
/// <param name="bdjvolume">비차익매도자기체결수량	String	Y	6</param>
/// <param name="bswvolume">비차익매수위탁체결수량	String	Y	6</param>
/// <param name="bsjvolume">비차익매수자기체결수량	String	Y	6</param>
/// <param name="bwvol">비차익위탁순매수수량	String	Y	6</param>
/// <param name="bjvol">비차익자기순매수수량	String	Y	6</param>
/// <param name="dwvolume">전체매도위탁체결수량	String	Y	6</param>
/// <param name="swvolume">전체매수위탁체결수량	String	Y	6</param>
/// <param name="wvol">전체위탁순매수수량	String	Y	6</param>
/// <param name="djvolume">전체매도자기체결수량	String	Y	6</param>
/// <param name="sjvolume">전체매수자기체결수량	String	Y	6</param>
/// <param name="jvol">전체자기순매수수량	String	Y	6</param>
/// <param name="cdwvalue">차익매도위탁체결금액	String	Y	8</param>
/// <param name="cdjvalue">차익매도자기체결금액	String	Y	8</param>
/// <param name="cswvalue">차익매수위탁체결금액	String	Y	8</param>
/// <param name="csjvalue">차익매수자기체결금액	String	Y	8</param>
/// <param name="cwval">차익위탁순매수금액	String	Y	8</param>
/// <param name="cjval">차익자기순매수금액	String	Y	8</param>
/// <param name="bdwvalue">비차익매도위탁체결금액	String	Y	8</param>
/// <param name="bdjvalue">비차익매도자기체결금액	String	Y	8</param>
/// <param name="bswvalue">비차익매수위탁체결금액	String	Y	8</param>
/// <param name="bsjvalue">비차익매수자기체결금액	String	Y	8</param>
/// <param name="bwval">비차익위탁순매수금액	String	Y	8</param>
/// <param name="bjval">비차익자기순매수금액	String	Y	8</param>
/// <param name="dwvalue">전체매도위탁체결금액	String	Y	8</param>
/// <param name="swvalue">전체매수위탁체결금액	String	Y	8</param>
/// <param name="wval">전체위탁순매수금액	String	Y	8</param>
/// <param name="djvalue">전체매도자기체결금액	String	Y	8</param>
/// <param name="sjvalue">전체매수자기체결금액	String	Y	8</param>
/// <param name="jval">전체자기순매수금액	String	Y	8</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="k200sign">KOSPI200전일대비구분	String	Y	1</param>
/// <param name="change">KOSPI200전일대비	String	Y	6.2</param>
/// <param name="k200basis">KOSPI200베이시스	String	Y	4.2</param>
/// <param name="cdvolume">차익매도체결수량합계	String	Y	6</param>
/// <param name="csvolume">차익매수체결수량합계	String	Y	6</param>
/// <param name="cvol">차익순매수수량합계	String	Y	6</param>
/// <param name="bdvolume">비차익매도체결수량합계	String	Y	6</param>
/// <param name="bsvolume">비차익매수체결수량합계	String	Y	6</param>
/// <param name="bvol">비차익순매수수량합계	String	Y	6</param>
/// <param name="tdvolume">전체매도체결수량합계	String	Y	6</param>
/// <param name="tsvolume">전체매수체결수량합계	String	Y	6</param>
/// <param name="tvol">전체순매수수량합계	String	Y	6</param>
/// <param name="cdvalue">차익매도체결금액합계	String	Y	8</param>
/// <param name="csvalue">차익매수체결금액합계	String	Y	8</param>
/// <param name="cval">차익순매수금액합계	String	Y	8</param>
/// <param name="bdvalue">비차익매도체결금액합계	String	Y	8</param>
/// <param name="bsvalue">비차익매수체결금액합계	String	Y	8</param>
/// <param name="bval">비차익순매수금액합계	String	Y	8</param>
/// <param name="tdvalue">전체매도체결금액합계	String	Y	8</param>
/// <param name="tsvalue">전체매수체결금액합계	String	Y	8</param>
/// <param name="tval">전체순매수금액합계	String	Y	8</param>
/// <param name="p_cdvolcha">차익매도체결수량직전대비	String	Y	6</param>
/// <param name="p_csvolcha">차익매수체결수량직전대비	String	Y	6</param>
/// <param name="p_cvolcha">차익순매수수량직전대비	String	Y	6</param>
/// <param name="p_bdvolcha">비차익매도체결수량직전대비	String	Y	6</param>
/// <param name="p_bsvolcha">비차익매수체결수량직전대비	String	Y	6</param>
/// <param name="p_bvolcha">비차익순매수수량직전대비	String	Y	6</param>
/// <param name="p_tdvolcha">전체매도체결수량직전대비	String	Y	6</param>
/// <param name="p_tsvolcha">전체매수체결수량직전대비	String	Y	6</param>
/// <param name="p_tvolcha">전체순매수수량직전대비	String	Y	6</param>
/// <param name="p_cdvalcha">차익매도체결금액직전대비	String	Y	8</param>
/// <param name="p_csvalcha">차익매수체결금액직전대비	String	Y	8</param>
/// <param name="p_cvalcha">차익순매수금액직전대비	String	Y	8</param>
/// <param name="p_bdvalcha">비차익매도체결금액직전대비	String	Y	8</param>
/// <param name="p_bsvalcha">비차익매수체결금액직전대비	String	Y	8</param>
/// <param name="p_bvalcha">비차익순매수금액직전대비	String	Y	8</param>
/// <param name="p_tdvalcha">전체매도체결금액직전대비	String	Y	8</param>
/// <param name="p_tsvalcha">전체매수체결금액직전대비	String	Y	8</param>
/// <param name="p_tvalcha">전체순매수금액직전대비	String	Y	8</param>
/// <param name="gubun">구분값	String	Y	1</param>
public record PM_(string time, string cdhrem, string cshrem, string bdhrem, string bshrem, string cdhvolume, string cshvolume, string bdhvolume, string bshvolume, string cdwvolume, string cdjvolume, string cswvolume, string csjvolume, string cwvol, string cjvol, string bdwvolume, string bdjvolume, string bswvolume, string bsjvolume, string bwvol, string bjvol, string dwvolume, string swvolume, string wvol, string djvolume, string sjvolume, string jvol, string cdwvalue, string cdjvalue, string cswvalue, string csjvalue, string cwval, string cjval, string bdwvalue, string bdjvalue, string bswvalue, string bsjvalue, string bwval, string bjval, string dwvalue, string swvalue, string wval, string djvalue, string sjvalue, string jval, string k200jisu, string k200sign, string change, string k200basis, string cdvolume, string csvolume, string cvol, string bdvolume, string bsvolume, string bvol, string tdvolume, string tsvolume, string tvol, string cdvalue, string csvalue, string cval, string bdvalue, string bsvalue, string bval, string tdvalue, string tsvalue, string tval, string p_cdvolcha, string p_csvolcha, string p_cvolcha, string p_bdvolcha, string p_bsvolcha, string p_bvolcha, string p_tdvolcha, string p_tsvolcha, string p_tvolcha, string p_cdvalcha, string p_csvalcha, string p_cvalcha, string p_bdvalcha, string p_bsvalcha, string p_bvalcha, string p_tdvalcha, string p_tsvalcha, string p_tvalcha, string gubun);

/// <summary>
/// KOSPI우선호가
/// </summary>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record S2_(string offerho, string bidho, string shcode);

/// <summary>
/// KOSPI체결
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="open">시가	String	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="high">고가	String	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="low">저가	String	Y	8</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="w_avrg">가중평균가	String	Y	8</param>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="status">장정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record S3_(string chetime, string sign, string change, string drate, string price, string opentime, string open, string hightime, string high, string lowtime, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string w_avrg, string offerho, string bidho, string status, string jnilvolume, string shcode);

/// <summary>
/// KOSPI기세
/// </summary>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="open">시가	String	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="high">고가	String	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="low">저가	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record S4_(string sign, string change, string drate, string price, string opentime, string open, string hightime, string high, string lowtime, string low, string shcode);

// SC0
// SC1
// SC2
// SC3
// SC4

/// <summary>
/// 상/하한가근접진입
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	String	Y	1</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="volincrate">거래증가율	String	Y	12.2</param>
/// <param name="updnlmtprice">상/하한가	String	Y	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	String	Y	6.2</param>
/// <param name="jnilvolume">전일거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gwangubun">관리구분	String	Y	1</param>
/// <param name="undergubun">이상급등구분	String	Y	1</param>
/// <param name="tgubun">투자유의구분	String	Y	1</param>
/// <param name="wgubun">우선주구분	String	Y	1</param>
/// <param name="dishonest">불성실구분	String	Y	1</param>
/// <param name="jkrate">증거금률	String	Y	1</param>
/// <param name="updnlmtdaycnt">상한가/하한가연속일수	String	Y	3</param>
public record SHC(string sijanggubun, string hname, string price, string sign, string change, string drate, string volume, string volincrate, string updnlmtprice, string updnlmtdrate, string jnilvolume, string shcode, string gwangubun, string undergubun, string tgubun, string wgubun, string dishonest, string jkrate, string updnlmtdaycnt);

/// <summary>
/// 상/하한가근접이탈
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	String	Y	1</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="volincrate">거래증가율	String	Y	12.2</param>
/// <param name="updnlmtprice">상/하한가	String	Y	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	String	Y	6.2</param>
/// <param name="jnilvolume">전일거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gwangubun">관리구분	String	Y	1</param>
/// <param name="undergubun">이상급등구분	String	Y	1</param>
/// <param name="tgubun">투자유의구분	String	Y	1</param>
/// <param name="wgubun">우선주구분	String	Y	1</param>
/// <param name="dishonest">불성실구분	String	Y	1</param>
/// <param name="jkrate">증거금률	String	Y	1</param>
public record SHD(string sijanggubun, string hname, string price, string sign, string change, string drate, string volume, string volincrate, string updnlmtprice, string updnlmtdrate, string jnilvolume, string shcode, string gwangubun, string undergubun, string tgubun, string wgubun, string dishonest, string jkrate);

/// <summary>
/// 상/하한가진입
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	String	Y	1</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="volincrate">거래증가율	String	Y	12.2</param>
/// <param name="totofferrem">매도호가총수량	String	Y	12</param>
/// <param name="totbidrem">매수호가총수량	String	Y	12</param>
/// <param name="updnlmtstime">상한가/하한가최종진입시간	String	Y	6</param>
/// <param name="updnlmtdaycnt">상한가/하한가연속일수	String	Y	3</param>
/// <param name="jnilvolume">전일거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gwangubun">관리구분	String	Y	1</param>
/// <param name="undergubun">이상급등구분	String	Y	1</param>
/// <param name="tgubun">투자유의구분	String	Y	1</param>
/// <param name="wgubun">우선주구분	String	Y	1</param>
/// <param name="dishonest">불성실구분	String	Y	1</param>
/// <param name="jkrate">증거금률	String	Y	1</param>
public record SHI(string sijanggubun, string hname, string price, string sign, string change, string drate, string volume, string volincrate, string totofferrem, string totbidrem, string updnlmtstime, string updnlmtdaycnt, string jnilvolume, string shcode, string gwangubun, string undergubun, string tgubun, string wgubun, string dishonest, string jkrate);

/// <summary>
/// 상/하한가이탈
/// </summary>
/// <param name="sijanggubun">거래소/코스닥구분	String	Y	1</param>
/// <param name="hname">종목명	String	Y	20</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="volincrate">거래증가율	String	Y	12.2</param>
/// <param name="updnlmtprice">상/하한가	String	Y	8</param>
/// <param name="updnlmtchange">상/하한가대비	String	Y	8</param>
/// <param name="updnlmtdrate">상/하한가대비율	String	Y	6.2</param>
/// <param name="jnilvolume">전일거래량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="gwangubun">관리구분	String	Y	1</param>
/// <param name="undergubun">이상급등구분	String	Y	1</param>
/// <param name="tgubun">투자유의구분	String	Y	1</param>
/// <param name="wgubun">우선주구분	String	Y	1</param>
/// <param name="dishonest">불성실구분	String	Y	1</param>
/// <param name="jkrate">증거금률	String	Y	1</param>
public record SHO(string sijanggubun, string hname, string price, string sign, string change, string drate, string volume, string volincrate, string updnlmtprice, string updnlmtchange, string updnlmtdrate, string jnilvolume, string shcode, string gwangubun, string undergubun, string tgubun, string wgubun, string dishonest, string jkrate);

/// <summary>
/// VI발동해제
/// </summary>
/// <param name="vi_gubun">구분(0:해제1:정적발동2:동적발동3:정적&동적)	String	Y	1</param>
/// <param name="svi_recprice">정적VI발동기준가격	String	Y	8</param>
/// <param name="dvi_recprice">동적VI발동기준가격	String	Y	8</param>
/// <param name="vi_trgprice">VI발동가격	String	Y	8</param>
/// <param name="shcode">단축코드(KEY)	String	Y	6</param>
/// <param name="ref_shcode">참조코드	String	Y	6</param>
/// <param name="time">시간	String	Y	6</param>
public record VI_(string vi_gubun, string svi_recprice, string dvi_recprice, string vi_trgprice, string shcode, string ref_shcode, string time);

/// <summary>
/// 예상지수
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="jisu">예상지수	String	Y	8.2</param>
/// <param name="sign">예상전일대비구분	String	Y	1</param>
/// <param name="change">예상전일비	String	Y	8.2</param>
/// <param name="drate">예상등락율	String	Y	6.2</param>
/// <param name="cvolume">예상체결량	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	8</param>
/// <param name="value">예상거래대금	String	Y	8</param>
/// <param name="upcode">업종코드	String	Y	3</param>
public record YJ_(string time, string jisu, string sign, string change, string drate, string cvolume, string volume, string value, string upcode);

/// <summary>
/// KOSDAQ예상체결
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	8</param>
/// <param name="yevolume">예상체결수량	String	Y	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="yofferho0">예상매도호가	String	Y	8</param>
/// <param name="ybidho0">예상매수호가	String	Y	8</param>
/// <param name="yofferrem0">예상매도호가수량	String	Y	12</param>
/// <param name="ybidrem0">예상매수호가수량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record YK3(string hotime, string yeprice, string yevolume, string jnilysign, string jnilchange, string jnilydrate, string yofferho0, string ybidho0, string yofferrem0, string ybidrem0, string shcode);

/// <summary>
/// KOSPI예상체결
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	8</param>
/// <param name="yevolume">예상체결수량	String	Y	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="yofferho0">예상매도호가	String	Y	8</param>
/// <param name="ybidho0">예상매수호가	String	Y	8</param>
/// <param name="yofferrem0">예상매도호가수량	String	Y	12</param>
/// <param name="ybidrem0">예상매수호가수량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record YS3(string hotime, string yeprice, string yevolume, string jnilysign, string jnilchange, string jnilydrate, string yofferho0, string ybidho0, string yofferrem0, string ybidrem0, string shcode);

/// <summary>
/// 뉴ELW투자지표민감도
/// </summary>
/// <param name="time">시간	String	Y	6</param>
/// <param name="theoryprice">장중이론가	String	Y	10.2</param>
/// <param name="delt">델타	String	Y	7.6</param>
/// <param name="gama">감마	String	Y	7.6</param>
/// <param name="ceta">세타	String	Y	12.6</param>
/// <param name="vega">베가	String	Y	12.6</param>
/// <param name="rhox">로우	String	Y	12.6</param>
/// <param name="impv">내재변동성	String	Y	5.2</param>
/// <param name="egearing">E.기어링	String	Y	8.2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="elwclose">ELW현재가	String	Y	8</param>
/// <param name="sign">ELW전일대비구분	String	Y	1</param>
/// <param name="change">ELW전일대비	String	Y	8</param>
/// <param name="date">일자	String	Y	8</param>
/// <param name="tickvalue">틱환산	String	Y	10.2</param>
/// <param name="lp_impv">LP내재변동성	String	Y	5.2</param>
public record ESN(string time, string theoryprice, string delt, string gama, string ceta, string vega, string rhox, string impv, string egearing, string shcode, string elwclose, string sign, string change, string date, string tickvalue, string lp_impv);

/// <summary>
/// ELW장전시간외호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="tmofferrem">시간외매도잔량	String	Y	12</param>
/// <param name="tmbidrem">시간외매수잔량	String	Y	12</param>
/// <param name="pretmoffercha">시간외매도수량직전대비	String	Y	12</param>
/// <param name="pretmbidcha">시간외매수수량직전대비	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record h2_(string hotime, string tmofferrem, string tmbidrem, string pretmoffercha, string pretmbidcha, string shcode);

/// <summary>
/// ELW호가잔량
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	7</param>
/// <param name="bidho1">매수호가1	String	Y	7</param>
/// <param name="offerrem1">매도호가잔량1	String	Y	9</param>
/// <param name="bidrem1">매수호가잔량1	String	Y	9</param>
/// <param name="lp_offerho1">LP매도호가수량1	String	Y	9</param>
/// <param name="lp_bidho1">LP매수호가수량1	String	Y	9</param>
/// <param name="offerho2">매도호가2	String	Y	7</param>
/// <param name="bidho2">매수호가2	String	Y	7</param>
/// <param name="offerrem2">매도호가잔량2	String	Y	9</param>
/// <param name="bidrem2">매수호가잔량2	String	Y	9</param>
/// <param name="lp_offerho2">LP매도호가수량2	String	Y	9</param>
/// <param name="lp_bidho2">LP매수호가수량2	String	Y	9</param>
/// <param name="offerho3">매도호가3	String	Y	7</param>
/// <param name="bidho3">매수호가3	String	Y	7</param>
/// <param name="offerrem3">매도호가잔량3	String	Y	9</param>
/// <param name="bidrem3">매수호가잔량3	String	Y	9</param>
/// <param name="lp_offerho3">LP매도호가수량3	String	Y	9</param>
/// <param name="lp_bidho3">LP매수호가수량3	String	Y	9</param>
/// <param name="offerho4">매도호가4	String	Y	7</param>
/// <param name="bidho4">매수호가4	String	Y	7</param>
/// <param name="offerrem4">매도호가잔량4	String	Y	9</param>
/// <param name="bidrem4">매수호가잔량4	String	Y	9</param>
/// <param name="lp_offerho4">LP매도호가수량4	String	Y	9</param>
/// <param name="lp_bidho4">LP매수호가수량4	String	Y	9</param>
/// <param name="offerho5">매도호가5	String	Y	7</param>
/// <param name="bidho5">매수호가5	String	Y	7</param>
/// <param name="offerrem5">매도호가잔량5	String	Y	9</param>
/// <param name="bidrem5">매수호가잔량5	String	Y	9</param>
/// <param name="lp_offerho5">LP매도호가수량5	String	Y	9</param>
/// <param name="lp_bidho5">LP매수호가수량5	String	Y	9</param>
/// <param name="offerho6">매도호가6	String	Y	7</param>
/// <param name="bidho6">매수호가6	String	Y	7</param>
/// <param name="offerrem6">매도호가잔량6	String	Y	9</param>
/// <param name="bidrem6">매수호가잔량6	String	Y	9</param>
/// <param name="lp_offerho6">LP매도호가수량6	String	Y	9</param>
/// <param name="lp_bidho6">LP매수호가수량6	String	Y	9</param>
/// <param name="offerho7">매도호가7	String	Y	7</param>
/// <param name="bidho7">매수호가7	String	Y	7</param>
/// <param name="offerrem7">매도호가잔량7	String	Y	9</param>
/// <param name="bidrem7">매수호가잔량7	String	Y	9</param>
/// <param name="lp_offerho7">LP매도호가수량7	String	Y	9</param>
/// <param name="lp_bidho7">LP매수호가수량7	String	Y	9</param>
/// <param name="offerho8">매도호가8	String	Y	7</param>
/// <param name="bidho8">매수호가8	String	Y	7</param>
/// <param name="offerrem8">매도호가잔량8	String	Y	9</param>
/// <param name="bidrem8">매수호가잔량8	String	Y	9</param>
/// <param name="lp_offerho8">LP매도호가수량8	String	Y	9</param>
/// <param name="lp_bidho8">LP매수호가수량8	String	Y	9</param>
/// <param name="offerho9">매도호가9	String	Y	7</param>
/// <param name="bidho9">매수호가9	String	Y	7</param>
/// <param name="offerrem9">매도호가잔량9	String	Y	9</param>
/// <param name="bidrem9">매수호가잔량9	String	Y	9</param>
/// <param name="lp_offerho9">LP매도호가수량9	String	Y	9</param>
/// <param name="lp_bidho9">LP매수호가수량9	String	Y	9</param>
/// <param name="offerho10">매도호가10	String	Y	7</param>
/// <param name="bidho10">매수호가10	String	Y	7</param>
/// <param name="offerrem10">매도호가잔량10	String	Y	9</param>
/// <param name="bidrem10">매수호가잔량10	String	Y	9</param>
/// <param name="lp_offerho10">LP매도호가수량10	String	Y	9</param>
/// <param name="lp_bidho10">LP매수호가수량10	String	Y	9</param>
/// <param name="totofferrem">총매도호가잔량	String	Y	9</param>
/// <param name="totbidrem">총매수호가잔량	String	Y	9</param>
/// <param name="donsigubun">동시호가구분	String	Y	1</param>
/// <param name="spread">스프레드	String	Y	6.2</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record h3_(string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string lp_offerho1, string lp_bidho1, string offerho2, string bidho2, string offerrem2, string bidrem2, string lp_offerho2, string lp_bidho2, string offerho3, string bidho3, string offerrem3, string bidrem3, string lp_offerho3, string lp_bidho3, string offerho4, string bidho4, string offerrem4, string bidrem4, string lp_offerho4, string lp_bidho4, string offerho5, string bidho5, string offerrem5, string bidrem5, string lp_offerho5, string lp_bidho5, string offerho6, string bidho6, string offerrem6, string bidrem6, string lp_offerho6, string lp_bidho6, string offerho7, string bidho7, string offerrem7, string bidrem7, string lp_offerho7, string lp_bidho7, string offerho8, string bidho8, string offerrem8, string bidrem8, string lp_offerho8, string lp_bidho8, string offerho9, string bidho9, string offerrem9, string bidrem9, string lp_offerho9, string lp_bidho9, string offerho10, string bidho10, string offerrem10, string bidrem10, string lp_offerho10, string lp_bidho10, string totofferrem, string totbidrem, string donsigubun, string spread, string shcode);

/// <summary>
/// ELW거래원
/// </summary>
/// <param name="offerno1">매도증권사코드1	String	Y	3</param>
/// <param name="bidno1">매수증권사코드1	String	Y	3</param>
/// <param name="offertrad1">매도회원사명1	String	Y	6</param>
/// <param name="bidtrad1">매수회원사명1	String	Y	6</param>
/// <param name="tradmdvol1">매도거래량1	String	Y	10</param>
/// <param name="tradmsvol1">매수거래량1	String	Y	10</param>
/// <param name="tradmdrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmsrate1">매도거래량비중1	String	Y	6.2</param>
/// <param name="tradmdcha1">매도거래량직전대비1	String	Y	10</param>
/// <param name="tradmscha1">매수거래량직전대비1	String	Y	10</param>
/// <param name="offerno2">매도증권사코드2	String	Y	3</param>
/// <param name="bidno2">매수증권사코드2	String	Y	3</param>
/// <param name="offertrad2">매도회원사명2	String	Y	6</param>
/// <param name="bidtrad2">매수회원사명2	String	Y	6</param>
/// <param name="tradmdvol2">매도거래량2	String	Y	10</param>
/// <param name="tradmsvol2">매수거래량2	String	Y	10</param>
/// <param name="tradmdrate2">매도거래량비중2	String	Y	6.2</param>
/// <param name="tradmsrate2">매수거래량비중2	String	Y	6.2</param>
/// <param name="tradmdcha2">매도거래량직전대비2	String	Y	10</param>
/// <param name="tradmscha2">매수거래량직전대비2	String	Y	10</param>
/// <param name="offerno3">매도증권사코드3	String	Y	3</param>
/// <param name="bidno3">매수증권사코드3	String	Y	3</param>
/// <param name="offertrad3">매도회원사명3	String	Y	6</param>
/// <param name="bidtrad3">매수회원사명3	String	Y	6</param>
/// <param name="tradmdvol3">매도거래량3	String	Y	10</param>
/// <param name="tradmsvol3">매수거래량3	String	Y	10</param>
/// <param name="tradmdrate3">매도거래량비중3	String	Y	6.2</param>
/// <param name="tradmsrate3">매수거래량비중3	String	Y	6.2</param>
/// <param name="tradmdcha3">매도거래량직전대비3	String	Y	10</param>
/// <param name="tradmscha3">매수거래량직전대비3	String	Y	10</param>
/// <param name="offerno4">매도증권사코드4	String	Y	3</param>
/// <param name="bidno4">매수증권사코드4	String	Y	3</param>
/// <param name="offertrad4">매도회원사명4	String	Y	6</param>
/// <param name="bidtrad4">매수회원사명4	String	Y	6</param>
/// <param name="tradmdvol4">매도거래량4	String	Y	10</param>
/// <param name="tradmsvol4">매수거래량4	String	Y	10</param>
/// <param name="tradmdrate4">매도거래량비중4	String	Y	6.2</param>
/// <param name="tradmsrate4">매수거래량비중4	String	Y	6.2</param>
/// <param name="tradmdcha4">매도거래량직전대비4	String	Y	10</param>
/// <param name="tradmscha4">매수거래량직전대비4	String	Y	10</param>
/// <param name="offerno5">매도증권사코드5	String	Y	3</param>
/// <param name="bidno5">매수증권사코드5	String	Y	3</param>
/// <param name="offertrad5">매도회원사명5	String	Y	6</param>
/// <param name="bidtrad5">매수회원사명5	String	Y	6</param>
/// <param name="tradmdvol5">매도거래량5	String	Y	10</param>
/// <param name="tradmsvol5">매수거래량5	String	Y	10</param>
/// <param name="tradmdrate5">매도거래량비중5	String	Y	6.2</param>
/// <param name="tradmsrate5">매수거래량비중5	String	Y	6.2</param>
/// <param name="tradmdcha5">매도거래량직전대비5	String	Y	10</param>
/// <param name="tradmscha5">매수거래량직전대비5	String	Y	10</param>
/// <param name="ftradmdvol">외국계증권사매도합계	String	Y	10</param>
/// <param name="ftradmsvol">외국계증권사매수합계	String	Y	10</param>
/// <param name="ftradmdrate">외국계증권사매도거래량비중	String	Y	6.2</param>
/// <param name="ftradmsrate">외국계증권사매수거래량비중	String	Y	6.2</param>
/// <param name="ftradmdcha">외국계증권사매도거래량직전대비	String	Y	10</param>
/// <param name="ftradmscha">외국계증권사매수거래량직전대비	String	Y	10</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record k1_(string offerno1, string bidno1, string offertrad1, string bidtrad1, string tradmdvol1, string tradmsvol1, string tradmdrate1, string tradmsrate1, string tradmdcha1, string tradmscha1, string offerno2, string bidno2, string offertrad2, string bidtrad2, string tradmdvol2, string tradmsvol2, string tradmdrate2, string tradmsrate2, string tradmdcha2, string tradmscha2, string offerno3, string bidno3, string offertrad3, string bidtrad3, string tradmdvol3, string tradmsvol3, string tradmdrate3, string tradmsrate3, string tradmdcha3, string tradmscha3, string offerno4, string bidno4, string offertrad4, string bidtrad4, string tradmdvol4, string tradmsvol4, string tradmdrate4, string tradmsrate4, string tradmdcha4, string tradmscha4, string offerno5, string bidno5, string offertrad5, string bidtrad5, string tradmdvol5, string tradmsvol5, string tradmdrate5, string tradmsrate5, string tradmdcha5, string tradmscha5, string ftradmdvol, string ftradmsvol, string ftradmdrate, string ftradmsrate, string ftradmdcha, string ftradmscha, string shcode);

/// <summary>
/// ELW우선호가	
/// </summary>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record s2_(string offerho, string bidho, string shcode);

/// <summary>
/// ELW체결
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="open">시가	String	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="high">고가	String	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="low">저가	String	Y	8</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	8</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="w_avrg">가중평균가	String	Y	8</param>
/// <param name="offerho">매도호가	String	Y	8</param>
/// <param name="bidho">매수호가	String	Y	8</param>
/// <param name="status">장정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="premium">프리미엄	String	Y	8.2</param>
/// <param name="moneyness">ATM구분	String	Y	1</param>
/// <param name="shcode">단축코드	String	Y	6</param>
/// <param name="lpvolume">LP보유수량	String	Y	15</param>
public record s3_(string chetime, string sign, string change, string drate, string price, string opentime, string open, string hightime, string high, string lowtime, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string w_avrg, string offerho, string bidho, string status, string jnilvolume, string premium, string moneyness, string shcode, string lpvolume);

/// <summary>
/// ELW기세
/// </summary>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	8</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	8</param>
/// <param name="opentime">시가시간	String	Y	6</param>
/// <param name="open">시가	String	Y	8</param>
/// <param name="hightime">고가시간	String	Y	6</param>
/// <param name="high">고가	String	Y	8</param>
/// <param name="lowtime">저가시간	String	Y	6</param>
/// <param name="low">저가	String	Y	8</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record s4_(string sign, string change, string drate, string price, string opentime, string open, string hightime, string high, string lowtime, string low, string shcode);

/// <summary>
/// ELW예상체결
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	8</param>
/// <param name="yevolume">예상체결수량	String	Y	12</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="yofferho0">예상매도호가	String	Y	8</param>
/// <param name="ybidho0">예상매수호가	String	Y	8</param>
/// <param name="yofferrem0">예상매도호가수량	String	Y	12</param>
/// <param name="ybidrem0">예상매수호가수량	String	Y	12</param>
/// <param name="shcode">단축코드	String	Y	6</param>
public record Ys3(string hotime, string yeprice, string yevolume, string jnilysign, string jnilchange, string jnilydrate, string yofferho0, string ybidho0, string yofferrem0, string ybidrem0, string shcode);

#endregion

#region [선물/옵션] 실시간 시세

/// <summary>
/// 선물주문체결
/// </summary>
/// <param name="lineseq">라인일련번호	String	Y	10</param>
/// <param name="accno">계좌번호	String	Y	11</param>
/// <param name="user">조작자ID	String	Y	8</param>
/// <param name="seq">일련번호	String	Y	11</param>
/// <param name="trcode">trcode	String	Y	11</param>
/// <param name="megrpno">매칭그룹번호	String	Y	2</param>
/// <param name="boardid">보드ID	String	Y	2</param>
/// <param name="memberno">회원번호	String	Y	5</param>
/// <param name="bpno">지점번호	String	Y	5</param>
/// <param name="ordno">주문번호	String	Y	10</param>
/// <param name="ordordno">원주문번호	String	Y	10</param>
/// <param name="expcode">종목코드	String	Y	12</param>
/// <param name="yakseq">약정번호	String	Y	11</param>
/// <param name="cheprice">체결가격	String	Y	11.2</param>
/// <param name="chevol">체결수량	String	Y	10</param>
/// <param name="sessionid">세션ID	String	Y	2</param>
/// <param name="chedate">체결일자	String	Y	8</param>
/// <param name="chetime">체결시각	String	Y	9</param>
/// <param name="spdprc1">최근월체결가격	String	Y	11.2</param>
/// <param name="spdprc2">차근월체결가격	String	Y	11.2</param>
/// <param name="dosugb">매도수구분	String	Y	1</param>
/// <param name="accno1">계좌번호1	String	Y	12</param>
/// <param name="sihogagb">시장조성호가구분	String	Y	1</param>
/// <param name="jakino">위탁사번호	String	Y	5</param>
/// <param name="daeyong">대용주권계좌번호	String	Y	12</param>
/// <param name="mem_filler">mem_filler	String	Y	7</param>
/// <param name="mem_accno">mem_accno	String	Y	11</param>
/// <param name="mem_filler1">mem_filler1	String	Y	42</param>
public record C01(string lineseq, string accno, string user, string seq, string trcode, string megrpno, string boardid, string memberno, string bpno, string ordno, string ordordno, string expcode, string yakseq, string cheprice, string chevol, string sessionid, string chedate, string chetime, string spdprc1, string spdprc2, string dosugb, string accno1, string sihogagb, string jakino, string daeyong, string mem_filler, string mem_accno, string mem_filler1);

/// <summary>
/// 상품선물실시간상하한가
/// </summary>
/// <param name="gubun">접속매매여부	String	Y	1</param>
/// <param name="dy_gubun">실시간가격제한여부	String	Y	1</param>
/// <param name="dy_uplmtprice">실시간상한가	String	Y	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	String	Y	8.2</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record CD0(string gubun, string dy_gubun, string dy_uplmtprice, string dy_dnlmtprice, string futcode);

/// <summary>
/// EUREX연계KP200지수옵션선물체결
/// </summary>
/// <param name="chetime">체결시간(24시간)	String	Y	6</param>
/// <param name="chetime1">체결시간(36시간)	String	Y	6</param>
/// <param name="sign">정규장종가대비구분	String	Y	1</param>
/// <param name="change">정규장종가대비	String	Y	6.2</param>
/// <param name="drate">정규장종가기준등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	6.2</param>
/// <param name="open">시가	String	Y	6.2</param>
/// <param name="high">고가	String	Y	6.2</param>
/// <param name="low">저가	String	Y	6.2</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금(미제공)	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수(미제공)	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수(미제공)	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="openyak">미결제약정수량	String	Y	8</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="eqva">KOSPI등가	String	Y	7.2</param>
/// <param name="theoryprice">이론가	String	Y	6.2</param>
/// <param name="impv">내재변동성	String	Y	6.2</param>
/// <param name="openyakcha">미결제약정증감	String	Y	8</param>
/// <param name="timevalue">시간가치	String	Y	6.2</param>
/// <param name="jgubun">장운영정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="optcode">단축코드	String	Y	8</param>
public record EC0(string chetime, string chetime1, string sign, string change, string drate, string price, string open, string high, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string offerho1, string bidho1, string openyak, string k200jisu, string eqva, string theoryprice, string impv, string openyakcha, string timevalue, string jgubun, string jnilvolume, string optcode);

/// <summary>
/// EUREX연계KP200지수옵션선물호가
/// </summary>
/// <param name="hotime">호가시간(24시간)	String	Y	6</param>
/// <param name="hotime1">호가시간(36시간)	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="offerrem1">매도호가수량1	String	Y	7</param>
/// <param name="bidrem1">매수호가수량1	String	Y	7</param>
/// <param name="offercnt1">매도호가건수1(미제공)	String	Y	5</param>
/// <param name="bidcnt1">매수호가건수1(미제공)	String	Y	5</param>
/// <param name="offerho2">매도호가2	String	Y	6.2</param>
/// <param name="bidho2">매수호가2	String	Y	6.2</param>
/// <param name="offerrem2">매도호가수량2	String	Y	7</param>
/// <param name="bidrem2">매수호가수량2	String	Y	7</param>
/// <param name="offercnt2">매도호가건수2(미제공)	String	Y	5</param>
/// <param name="bidcnt2">매수호가건수2(미제공)	String	Y	5</param>
/// <param name="offerho3">매도호가3	String	Y	6.2</param>
/// <param name="bidho3">매수호가3	String	Y	6.2</param>
/// <param name="offerrem3">매도호가수량3	String	Y	7</param>
/// <param name="bidrem3">매수호가수량3	String	Y	7</param>
/// <param name="offercnt3">매도호가건수3(미제공)	String	Y	5</param>
/// <param name="bidcnt3">매수호가건수3(미제공)	String	Y	5</param>
/// <param name="offerho4">매도호가4(미제공)	String	Y	6.2</param>
/// <param name="bidho4">매수호가4(미제공)	String	Y	6.2</param>
/// <param name="offerrem4">매도호가수량4(미제공)	String	Y	7</param>
/// <param name="bidrem4">매수호가수량4(미제공)	String	Y	7</param>
/// <param name="offercnt4">매도호가건수4(미제공)	String	Y	5</param>
/// <param name="bidcnt4">매수호가건수4(미제공)	String	Y	5</param>
/// <param name="offerho5">매도호가5(미제공)	String	Y	6.2</param>
/// <param name="bidho5">매수호가5(미제공)	String	Y	6.2</param>
/// <param name="offerrem5">매도호가수량5(미제공)	String	Y	7</param>
/// <param name="bidrem5">매수호가수량5(미제공)	String	Y	7</param>
/// <param name="offercnt5">매도호가건수5(미제공)	String	Y	5</param>
/// <param name="bidcnt5">매수호가건수5(미제공)	String	Y	5</param>
/// <param name="totofferrem">매도호가총수량	String	Y	7</param>
/// <param name="totbidrem">매수호가총수량	String	Y	7</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	5</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	5</param>
/// <param name="optcode">단축코드	String	Y	8</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
public record EH0(string hotime, string hotime1, string offerho1, string bidho1, string offerrem1, string bidrem1, string offercnt1, string bidcnt1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offercnt2, string bidcnt2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offercnt3, string bidcnt3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offercnt4, string bidcnt4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offercnt5, string bidcnt5, string totofferrem, string totbidrem, string totoffercnt, string totbidcnt, string optcode, string danhochk);

// EUX접수 EU0

/// <summary>
/// EUX체결
/// </summary>
/// <param name="lineseq">라인일련번호	String	Y	10</param>
/// <param name="accno">계좌번호	String	Y	11</param>
/// <param name="user">조작자ID	String	Y	8</param>
/// <param name="len">헤더길이	String	Y	6</param>
/// <param name="gubun">헤더구분	String	Y	1</param>
/// <param name="compress">압축구분	String	Y	1</param>
/// <param name="encrypt">암호구분	String	Y	1</param>
/// <param name="offset">공통시작지점	String	Y	3</param>
/// <param name="trcode">TRCODE	String	Y	8</param>
/// <param name="comid">이용사번호	String	Y	3</param>
/// <param name="userid">사용자ID	String	Y	16</param>
/// <param name="media">접속매체	String	Y	2</param>
/// <param name="ifid">I/F일련번호	String	Y	3</param>
/// <param name="seq">전문일련번호	String	Y	9</param>
/// <param name="trid">TR추적ID	String	Y	16</param>
/// <param name="pubip">공인IP	String	Y	12</param>
/// <param name="prvip">사설IP	String	Y	12</param>
/// <param name="pcbpno">처리지점번호	String	Y	3</param>
/// <param name="bpno">지점번호	String	Y	3</param>
/// <param name="termno">단말번호	String	Y	8</param>
/// <param name="lang">언어구분	String	Y	1</param>
/// <param name="proctm">AP처리시간	String	Y	9</param>
/// <param name="msgcode">메세지코드	String	Y	4</param>
/// <param name="outgu">메세지출력구분	String	Y	1</param>
/// <param name="compreq">압축요청구분	String	Y	1</param>
/// <param name="funckey">기능키	String	Y	4</param>
/// <param name="reqcnt">요청레코드개수	String	Y	4</param>
/// <param name="filler">예비영역	String	Y	6</param>
/// <param name="cont">연속구분	String	Y	1</param>
/// <param name="contkey">연속키값	String	Y	18</param>
/// <param name="varlen">가변시스템길이	String	Y	2</param>
/// <param name="varhdlen">가변해더길이	String	Y	2</param>
/// <param name="varmsglen">가변메시지길이	String	Y	2</param>
/// <param name="trsrc">조회발원지	String	Y	1</param>
/// <param name="eventid">I/F이벤트ID	String	Y	4</param>
/// <param name="ifinfo">I/F정보	String	Y	4</param>
/// <param name="filler1">예비영역	String	Y	41</param>
/// <param name="trcode1">tr코드	String	Y	4</param>
/// <param name="firmno">회사번호	String	Y	3</param>
/// <param name="acntno">계좌번호	String	Y	11</param>
/// <param name="acntno1">계좌번호	String	Y	9</param>
/// <param name="acntnm">계좌명	String	Y	40</param>
/// <param name="brnno">지점번호	String	Y	3</param>
/// <param name="ordmktcode">주문시장코드	String	Y	2</param>
/// <param name="ordno1">주문번호	String	Y	3</param>
/// <param name="ordno">주문번호	String	Y	7</param>
/// <param name="orgordno1">원주문번호	String	Y	3</param>
/// <param name="orgordno">원주문번호	String	Y	7</param>
/// <param name="prntordno">모주문번호	String	Y	3</param>
/// <param name="prntordno1">모주문번호	String	Y	7</param>
/// <param name="isuno">종목번호	String	Y	12</param>
/// <param name="fnoIsuno">선물옵션종목번호	String	Y	8</param>
/// <param name="fnoIsunm">선물옵션종목명	String	Y	40</param>
/// <param name="pdgrpcode">상품군분류코드	String	Y	2</param>
/// <param name="fnoIsuptntp">선물옵션종목유형구분	String	Y	1</param>
/// <param name="bnstp">매매구분	String	Y	1</param>
/// <param name="mrctp">정정취소구분	String	Y	1</param>
/// <param name="ordqty">주문수량	String	Y	16</param>
/// <param name="hogatype">호가유형코드	String	Y	2</param>
/// <param name="mmgb">거래유형코드	String	Y	2</param>
/// <param name="ordprc">주문가격	String	Y	13.2</param>
/// <param name="unercqty">미체결수량	String	Y	16</param>
/// <param name="commdacode">통신매체	String	Y	2</param>
/// <param name="peeamtcode">수수료합산코드	String	Y	2</param>
/// <param name="mgempno">관리사원	String	Y	9</param>
/// <param name="fnotrdunitamt">선물옵션거래단위금액	String	Y	19.8</param>
/// <param name="trxtime">처리시각	String	Y	9</param>
/// <param name="strtgcode">전략코드	String	Y	6</param>
/// <param name="grpId">그룹Id	String	Y	20</param>
/// <param name="ordseqno">주문회차	String	Y	10</param>
/// <param name="ptflno">포트폴리오번호	String	Y	10</param>
/// <param name="bskno">바스켓번호	String	Y	10</param>
/// <param name="trchno">트렌치번호	String	Y	10</param>
/// <param name="Itemno">아이템번호	String	Y	10</param>
/// <param name="OrderID">주문자Id	String	Y	16</param>
/// <param name="opdrtnno">운영지시번호	String	Y	12</param>
/// <param name="rjtcode">부적격코드	String	Y	4</param>
/// <param name="mrccnfqty">정정취소확인수량	String	Y	16</param>
/// <param name="orgordunercqty">원주문미체결수량	String	Y	16</param>
/// <param name="orgordmrcqty">원주문정정취소수량	String	Y	16</param>
/// <param name="ctrcttime">약정시각(체결시각)	String	Y	8</param>
/// <param name="ctrctno">약정번호	String	Y	10</param>
/// <param name="execprc">체결가격	String	Y	13.2</param>
/// <param name="execqty">체결수량	String	Y	16</param>
/// <param name="newqty">신규체결수량	String	Y	16</param>
/// <param name="qdtqty">청산체결수량	String	Y	16</param>
/// <param name="lastqty">최종결제수량	String	Y	16</param>
/// <param name="lallexecqty">전체체결수량	String	Y	16</param>
/// <param name="allexecamt">전체체결금액	String	Y	16</param>
/// <param name="fnobalevaltp">잔고평가구분	String	Y	1</param>
/// <param name="bnsplamt">매매손익금액	String	Y	16</param>
/// <param name="fnoIsuno1">선물옵션종목번호1	String	Y	8</param>
/// <param name="bnstp1">매매구분1	String	Y	1</param>
/// <param name="execprc1">체결가1	String	Y	13.2</param>
/// <param name="newqty1">신규체결수량1	String	Y	16</param>
/// <param name="qdtqty1">청산체결수량1	String	Y	16</param>
/// <param name="allexecamt1">전체체결금액1	String	Y	16</param>
/// <param name="fnoIsuno2">선물옵션종목번호2	String	Y	8</param>
/// <param name="bnstp2">매매구분2	String	Y	1</param>
/// <param name="execprc2">체결가2	String	Y	13.2</param>
/// <param name="newqty2">신규체결수량2	String	Y	16</param>
/// <param name="lqdtqty2">청산체결수량2	String	Y	16</param>
/// <param name="allexecamt2">전체체결금액2	String	Y	16</param>
/// <param name="dps">예수금	String	Y	16</param>
/// <param name="ftsubtdsgnamt">선물대용지정금액	String	Y	16</param>
/// <param name="mgn">증거금	String	Y	16</param>
/// <param name="mnymgn">증거금현금	String	Y	16</param>
/// <param name="ordableamt">주문가능금액	String	Y	16</param>
/// <param name="mnyordableamt">주문가능현금액	String	Y	16</param>
/// <param name="fnoIsuno_1">잔고종목번호1	String	Y	8</param>
/// <param name="bnstp_1">잔고매매구분1	String	Y	1</param>
/// <param name="unsttqty_1">미결제수량1	String	Y	16</param>
/// <param name="lqdtableqty_1">주문가능수량1	String	Y	16</param>
/// <param name="avrprc_1">평균가1	String	Y	13.2</param>
/// <param name="fnoIsuno_2">잔고종목번호2	String	Y	8</param>
/// <param name="bnstp_2">잔고매매구분2	String	Y	1</param>
/// <param name="unsttqty_2">미결제수량2	String	Y	16</param>
/// <param name="lqdtableqty_2">주문가능수량2	String	Y	16</param>
/// <param name="avrprc_2">평균가2	String	Y	13.2</param>
public record EU1(string lineseq, string accno, string user, string len, string gubun, string compress, string encrypt, string offset, string trcode, string comid, string userid, string media, string ifid, string seq, string trid, string pubip, string prvip, string pcbpno, string bpno, string termno, string lang, string proctm, string msgcode, string outgu, string compreq, string funckey, string reqcnt, string filler, string cont, string contkey, string varlen, string varhdlen, string varmsglen, string trsrc, string eventid, string ifinfo, string filler1, string trcode1, string firmno, string acntno, string acntno1, string acntnm, string brnno, string ordmktcode, string ordno1, string ordno, string orgordno1, string orgordno, string prntordno, string prntordno1, string isuno, string fnoIsuno, string fnoIsunm, string pdgrpcode, string fnoIsuptntp, string bnstp, string mrctp, string ordqty, string hogatype, string mmgb, string ordprc, string unercqty, string commdacode, string peeamtcode, string mgempno, string fnotrdunitamt, string trxtime, string strtgcode, string grpId, string ordseqno, string ptflno, string bskno, string trchno, string Itemno, string OrderID, string opdrtnno, string rjtcode, string mrccnfqty, string orgordunercqty, string orgordmrcqty, string ctrcttime, string ctrctno, string execprc, string execqty, string newqty, string qdtqty, string lastqty, string lallexecqty, string allexecamt, string fnobalevaltp, string bnsplamt, string fnoIsuno1, string bnstp1, string execprc1, string newqty1, string qdtqty1, string allexecamt1, string fnoIsuno2, string bnstp2, string execprc2, string newqty2, string lqdtqty2, string allexecamt2, string dps, string ftsubtdsgnamt, string mgn, string mnymgn, string ordableamt, string mnyordableamt, string fnoIsuno_1, string bnstp_1, string unsttqty_1, string lqdtableqty_1, string avrprc_1, string fnoIsuno_2, string bnstp_2, string unsttqty_2, string lqdtableqty_2, string avrprc_2);

// EUX확인 EU2

/// <summary>
/// KOSPI200선물체결
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	6.2</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	6.2</param>
/// <param name="open">시가	String	Y	6.2</param>
/// <param name="high">고가	String	Y	6.2</param>
/// <param name="low">저가	String	Y	6.2</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="openyak">미결제약정수량	String	Y	8</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="theoryprice">이론가	String	Y	6.2</param>
/// <param name="kasis">괴리율	String	Y	6.2</param>
/// <param name="sbasis">시장BASIS	String	Y	6.2</param>
/// <param name="ibasis">이론BASIS	String	Y	6.2</param>
/// <param name="openyakcha">미결제약정증감	String	Y	8</param>
/// <param name="jgubun">장운영정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record FC0(string chetime, string sign, string change, string drate, string price, string open, string high, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string offerho1, string bidho1, string openyak, string k200jisu, string theoryprice, string kasis, string sbasis, string ibasis, string openyakcha, string jgubun, string jnilvolume, string futcode);

/// <summary>
/// KOSPI200선물실시간상하한가
/// </summary>
/// <param name="gubun">접속매매여부	String	Y	1</param>
/// <param name="dy_gubun">실시간가격제한여부	String	Y	1</param>
/// <param name="dy_uplmtprice">실시간상한가	String	Y	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	String	Y	8.2</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record FD0(string gubun, string dy_gubun, string dy_uplmtprice, string dy_dnlmtprice, string futcode);

/// <summary>
/// KOSPI200선물호가
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="offerrem1">매도호가수량1	String	Y	6</param>
/// <param name="bidrem1">매수호가수량1	String	Y	6</param>
/// <param name="offercnt1">매도호가건수1	String	Y	5</param>
/// <param name="bidcnt1">매수호가건수1	String	Y	5</param>
/// <param name="offerho2">매도호가2	String	Y	6.2</param>
/// <param name="bidho2">매수호가2	String	Y	6.2</param>
/// <param name="offerrem2">매도호가수량2	String	Y	6</param>
/// <param name="bidrem2">매수호가수량2	String	Y	6</param>
/// <param name="offercnt2">매도호가건수2	String	Y	5</param>
/// <param name="bidcnt2">매수호가건수2	String	Y	5</param>
/// <param name="offerho3">매도호가3	String	Y	6.2</param>
/// <param name="bidho3">매수호가3	String	Y	6.2</param>
/// <param name="offerrem3">매도호가수량3	String	Y	6</param>
/// <param name="bidrem3">매수호가수량3	String	Y	6</param>
/// <param name="offercnt3">매도호가건수3	String	Y	5</param>
/// <param name="bidcnt3">매수호가건수3	String	Y	5</param>
/// <param name="offerho4">매도호가4	String	Y	6.2</param>
/// <param name="bidho4">매수호가4	String	Y	6.2</param>
/// <param name="offerrem4">매도호가수량4	String	Y	6</param>
/// <param name="bidrem4">매수호가수량4	String	Y	6</param>
/// <param name="offercnt4">매도호가건수4	String	Y	5</param>
/// <param name="bidcnt4">매수호가건수4	String	Y	5</param>
/// <param name="offerho5">매도호가5	String	Y	6.2</param>
/// <param name="bidho5">매수호가5	String	Y	6.2</param>
/// <param name="offerrem5">매도호가수량5	String	Y	6</param>
/// <param name="bidrem5">매수호가수량5	String	Y	6</param>
/// <param name="offercnt5">매도호가건수5	String	Y	5</param>
/// <param name="bidcnt5">매수호가건수5	String	Y	5</param>
/// <param name="totofferrem">매도호가총수량	String	Y	6</param>
/// <param name="totbidrem">매수호가총수량	String	Y	6</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	5</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	5</param>
/// <param name="futcode">단축코드	String	Y	8</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
public record FH0(string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offercnt1, string bidcnt1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offercnt2, string bidcnt2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offercnt3, string bidcnt3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offercnt4, string bidcnt4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offercnt5, string bidcnt5, string totofferrem, string totbidrem, string totoffercnt, string totbidcnt, string futcode, string danhochk, string alloc_gubun);

/// <summary>
/// KOSPI200선물가격제한폭확대
/// </summary>
/// <param name="upstep">적용상한단계	String	Y	2</param>
/// <param name="dnstep">적용하한단계	String	Y	2</param>
/// <param name="uplmtprice">적용상한가	String	Y	6.2</param>
/// <param name="dnlmtprice">적용하한가	String	Y	6.2</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record FX0(string upstep, string dnstep, string uplmtprice, string dnlmtprice, string futcode);

// 선물주문정정취소 H01

/// <summary>
/// 주식선물체결
/// </summary>
/// <param name="futcode">단축코드	String	Y	8</param>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">대비기호	String	Y	1</param>
/// <param name="change">전일대비	String	Y	10</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	10</param>
/// <param name="open">시가	String	Y	10</param>
/// <param name="high">고가	String	Y	10</param>
/// <param name="low">저가	String	Y	10</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	15</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="offerho1">매도호가1	String	Y	10</param>
/// <param name="bidho1">매수호가1	String	Y	10</param>
/// <param name="openyak">미결제약정수량	String	Y	8</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="theoryprice">이론가	String	Y	8</param>
/// <param name="kasis">괴리율	String	Y	6.3</param>
/// <param name="sbasis">시장BASIS	String	Y	6</param>
/// <param name="ibasis">이론BASIS	String	Y	6</param>
/// <param name="openyakcha">미결제약정증감	String	Y	8</param>
/// <param name="jgubun">장운영정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="basprice">기초자산현재가	String	Y	8</param>
public record JC0(string futcode, string chetime, string sign, string change, string drate, string price, string open, string high, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string offerho1, string bidho1, string openyak, string k200jisu, string theoryprice, string kasis, string sbasis, string ibasis, string openyakcha, string jgubun, string jnilvolume, string basprice);

/// <summary>
/// 주식선물실시간상하한가
/// </summary>
/// <param name="gubun">접속매매여부	String	Y	1</param>
/// <param name="dy_gubun">실시간가격제한여부	String	Y	1</param>
/// <param name="dy_uplmtprice">실시간상한가	String	Y	10</param>
/// <param name="dy_dnlmtprice">실시간하한가	String	Y	10</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record JD0(string gubun, string dy_gubun, string dy_uplmtprice, string dy_dnlmtprice, string futcode);

/// <summary>
/// 주식선물호가
/// </summary>
/// <param name="futcode">단축코드	String	Y	8</param>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	10</param>
/// <param name="bidho1">매수호가1	String	Y	10</param>
/// <param name="offerrem1">매도호가수량1	String	Y	7</param>
/// <param name="bidrem1">매수호가수량1	String	Y	7</param>
/// <param name="offercnt1">매도호가건수1	String	Y	5</param>
/// <param name="bidcnt1">매수호가건수1	String	Y	5</param>
/// <param name="offerho2">매도호가2	String	Y	10</param>
/// <param name="bidho2">매수호가2	String	Y	10</param>
/// <param name="offerrem2">매도호가수량2	String	Y	7</param>
/// <param name="bidrem2">매수호가수량2	String	Y	7</param>
/// <param name="offercnt2">매도호가건수2	String	Y	5</param>
/// <param name="bidcnt2">매수호가건수2	String	Y	5</param>
/// <param name="offerho3">매도호가3	String	Y	10</param>
/// <param name="bidho3">매수호가3	String	Y	10</param>
/// <param name="offerrem3">매도호가수량3	String	Y	7</param>
/// <param name="bidrem3">매수호가수량3	String	Y	7</param>
/// <param name="offercnt3">매도호가건수3	String	Y	5</param>
/// <param name="bidcnt3">매수호가건수3	String	Y	5</param>
/// <param name="offerho4">매도호가4	String	Y	10</param>
/// <param name="bidho4">매수호가4	String	Y	10</param>
/// <param name="offerrem4">매도호가수량4	String	Y	7</param>
/// <param name="bidrem4">매수호가수량4	String	Y	7</param>
/// <param name="offercnt4">매도호가건수4	String	Y	5</param>
/// <param name="bidcnt4">매수호가건수4	String	Y	5</param>
/// <param name="offerho5">매도호가5	String	Y	10</param>
/// <param name="bidho5">매수호가5	String	Y	10</param>
/// <param name="offerrem5">매도호가수량5	String	Y	7</param>
/// <param name="bidrem5">매수호가수량5	String	Y	7</param>
/// <param name="offercnt5">매도호가건수5	String	Y	5</param>
/// <param name="bidcnt5">매수호가건수5	String	Y	5</param>
/// <param name="offerho6">매도호가6	String	Y	10</param>
/// <param name="bidho6">매수호가6	String	Y	10</param>
/// <param name="offerrem6">매도호가수량6	String	Y	7</param>
/// <param name="bidrem6">매수호가수량6	String	Y	7</param>
/// <param name="offercnt6">매도호가건수6	String	Y	5</param>
/// <param name="bidcnt6">매수호가건수6	String	Y	5</param>
/// <param name="offerho7">매도호가7	String	Y	10</param>
/// <param name="bidho7">매수호가7	String	Y	10</param>
/// <param name="offerrem7">매도호가수량7	String	Y	7</param>
/// <param name="bidrem7">매수호가수량7	String	Y	7</param>
/// <param name="offercnt7">매도호가건수7	String	Y	5</param>
/// <param name="bidcnt7">매수호가건수7	String	Y	5</param>
/// <param name="offerho8">매도호가8	String	Y	10</param>
/// <param name="bidho8">매수호가8	String	Y	10</param>
/// <param name="offerrem8">매도호가수량8	String	Y	7</param>
/// <param name="bidrem8">매수호가수량8	String	Y	7</param>
/// <param name="offercnt8">매도호가건수8	String	Y	5</param>
/// <param name="bidcnt8">매수호가건수8	String	Y	5</param>
/// <param name="offerho9">매도호가9	String	Y	10</param>
/// <param name="bidho9">매수호가9	String	Y	10</param>
/// <param name="offerrem9">매도호가수량9	String	Y	7</param>
/// <param name="bidrem9">매수호가수량9	String	Y	7</param>
/// <param name="offercnt9">매도호가건수9	String	Y	5</param>
/// <param name="bidcnt9">매수호가건수9	String	Y	5</param>
/// <param name="offerho10">매도호가10	String	Y	10</param>
/// <param name="bidho10">매수호가10	String	Y	10</param>
/// <param name="offerrem10">매도호가수량10	String	Y	7</param>
/// <param name="bidrem10">매수호가수량10	String	Y	7</param>
/// <param name="offercnt10">매도호가건수10	String	Y	5</param>
/// <param name="bidcnt10">매수호가건수10	String	Y	5</param>
/// <param name="totofferrem">매도호가총수량	String	Y	8</param>
/// <param name="totbidrem">매수호가총수량	String	Y	8</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	5</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	5</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
public record JH0(string futcode, string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offercnt1, string bidcnt1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offercnt2, string bidcnt2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offercnt3, string bidcnt3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offercnt4, string bidcnt4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offercnt5, string bidcnt5, string offerho6, string bidho6, string offerrem6, string bidrem6, string offercnt6, string bidcnt6, string offerho7, string bidho7, string offerrem7, string bidrem7, string offercnt7, string bidcnt7, string offerho8, string bidho8, string offerrem8, string bidrem8, string offercnt8, string bidcnt8, string offerho9, string bidho9, string offerrem9, string bidrem9, string offercnt9, string bidcnt9, string offerho10, string bidho10, string offerrem10, string bidrem10, string offercnt10, string bidcnt10, string totofferrem, string totbidrem, string totoffercnt, string totbidcnt, string danhochk, string alloc_gubun);

/// <summary>
/// 주식선물가격제한폭확대
/// </summary>
/// <param name="upstep">적용상한단계	String	Y	2</param>
/// <param name="dnstep">적용하한단계	String	Y	2</param>
/// <param name="uplmtprice">적용상한가	String	Y	10</param>
/// <param name="dnlmtprice">적용하한가	String	Y	10</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record JX0(string upstep, string dnstep, string uplmtprice, string dnlmtprice, string futcode);

// 선물접수 O01

/// <summary>
/// KOSPI200옵션체결
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	6.2</param>
/// <param name="drate">등락율	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	6.2</param>
/// <param name="open">시가	String	Y	6.2</param>
/// <param name="high">고가	String	Y	6.2</param>
/// <param name="low">저가	String	Y	6.2</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="cvolume">체결량	String	Y	6</param>
/// <param name="volume">누적거래량	String	Y	12</param>
/// <param name="value">누적거래대금	String	Y	12</param>
/// <param name="mdvolume">매도누적체결량	String	Y	12</param>
/// <param name="mdchecnt">매도누적체결건수	String	Y	8</param>
/// <param name="msvolume">매수누적체결량	String	Y	12</param>
/// <param name="mschecnt">매수누적체결건수	String	Y	8</param>
/// <param name="cpower">체결강도	String	Y	9.2</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="openyak">미결제약정수량	String	Y	8</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="eqva">KOSPI등가	String	Y	7.2</param>
/// <param name="theoryprice">이론가	String	Y	6.2</param>
/// <param name="impv">내재변동성	String	Y	6.2</param>
/// <param name="openyakcha">미결제약정증감	String	Y	8</param>
/// <param name="timevalue">시간가치	String	Y	6.2</param>
/// <param name="jgubun">장운영정보	String	Y	2</param>
/// <param name="jnilvolume">전일동시간대거래량	String	Y	12</param>
/// <param name="optcode">단축코드	String	Y	8</param>
public record OC0(string chetime, string sign, string change, string drate, string price, string open, string high, string low, string cgubun, string cvolume, string volume, string value, string mdvolume, string mdchecnt, string msvolume, string mschecnt, string cpower, string offerho1, string bidho1, string openyak, string k200jisu, string eqva, string theoryprice, string impv, string openyakcha, string timevalue, string jgubun, string jnilvolume, string optcode);

/// <summary>
/// KOSPI200옵션실시간상하한가
/// </summary>
/// <param name="gubun">접속매매여부	String	Y	1</param>
/// <param name="dy_gubun">실시간가격제한여부	String	Y	1</param>
/// <param name="dy_uplmtprice">실시간상한가	String	Y	8.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	String	Y	8.2</param>
/// <param name="opttcode">단축코드	String	Y	8</param>
public record OD0(string gubun, string dy_gubun, string dy_uplmtprice, string dy_dnlmtprice, string opttcode);

/// <summary>
/// KOSPI200옵션호가
/// </summary>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가1	String	Y	6.2</param>
/// <param name="bidho1">매수호가1	String	Y	6.2</param>
/// <param name="offerrem1">매도호가수량1	String	Y	7</param>
/// <param name="bidrem1">매수호가수량1	String	Y	7</param>
/// <param name="offercnt1">매도호가건수1	String	Y	5</param>
/// <param name="bidcnt1">매수호가건수1	String	Y	5</param>
/// <param name="offerho2">매도호가2	String	Y	6.2</param>
/// <param name="bidho2">매수호가2	String	Y	6.2</param>
/// <param name="offerrem2">매도호가수량2	String	Y	7</param>
/// <param name="bidrem2">매수호가수량2	String	Y	7</param>
/// <param name="offercnt2">매도호가건수2	String	Y	5</param>
/// <param name="bidcnt2">매수호가건수2	String	Y	5</param>
/// <param name="offerho3">매도호가3	String	Y	6.2</param>
/// <param name="bidho3">매수호가3	String	Y	6.2</param>
/// <param name="offerrem3">매도호가수량3	String	Y	7</param>
/// <param name="bidrem3">매수호가수량3	String	Y	7</param>
/// <param name="offercnt3">매도호가건수3	String	Y	5</param>
/// <param name="bidcnt3">매수호가건수3	String	Y	5</param>
/// <param name="offerho4">매도호가4	String	Y	6.2</param>
/// <param name="bidho4">매수호가4	String	Y	6.2</param>
/// <param name="offerrem4">매도호가수량4	String	Y	7</param>
/// <param name="bidrem4">매수호가수량4	String	Y	7</param>
/// <param name="offercnt4">매도호가건수4	String	Y	5</param>
/// <param name="bidcnt4">매수호가건수4	String	Y	5</param>
/// <param name="offerho5">매도호가5	String	Y	6.2</param>
/// <param name="bidho5">매수호가5	String	Y	6.2</param>
/// <param name="offerrem5">매도호가수량5	String	Y	7</param>
/// <param name="bidrem5">매수호가수량5	String	Y	7</param>
/// <param name="offercnt5">매도호가건수5	String	Y	5</param>
/// <param name="bidcnt5">매수호가건수5	String	Y	5</param>
/// <param name="totofferrem">매도호가총수량	String	Y	7</param>
/// <param name="totbidrem">매수호가총수량	String	Y	7</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	5</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	5</param>
/// <param name="optcode">단축코드	String	Y	8</param>
/// <param name="danhochk">단일가호가여부	String	Y	1</param>
/// <param name="alloc_gubun">배분적용구분	String	Y	1</param>
public record OH0(string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offercnt1, string bidcnt1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offercnt2, string bidcnt2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offercnt3, string bidcnt3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offercnt4, string bidcnt4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offercnt5, string bidcnt5, string totofferrem, string totbidrem, string totoffercnt, string totbidcnt, string optcode, string danhochk, string alloc_gubun);

/// <summary>
/// KOSPI200옵션민감도
/// </summary>
/// <param name="chetime">체결시간	String	Y	6</param>
/// <param name="actprice">행사가	String	Y	6.2</param>
/// <param name="k200jisu">KOSPI200지수	String	Y	6.2</param>
/// <param name="fut200jisu">선물가격	String	Y	6.2</param>
/// <param name="price">현재가	String	Y	6.2</param>
/// <param name="capimpv">대표내재변동성	String	Y	6.2</param>
/// <param name="impv">내재변동성	String	Y	6.2</param>
/// <param name="delt">델타(블랙숄즈)	String	Y	7.4</param>
/// <param name="gama">감마(블랙숄즈)	String	Y	7.4</param>
/// <param name="ceta">세타(블랙숄즈)	String	Y	7.4</param>
/// <param name="vega">베가(블랙숄즈)	String	Y	7.4</param>
/// <param name="rhox">로우(블랙숄즈)	String	Y	7.4</param>
/// <param name="theoryprice">이론가(블랙숄즈)	String	Y	6.2</param>
/// <param name="bimpv">전일가내재변동성	String	Y	6.2</param>
/// <param name="offerimpv">매도가내재변동성	String	Y	6.2</param>
/// <param name="bidimpv">매수가내재변동성	String	Y	6.2</param>
/// <param name="optcode">옵션코드	String	Y	8</param>
public record OMG(string chetime, string actprice, string k200jisu, string fut200jisu, string price, string capimpv, string impv, string delt, string gama, string ceta, string vega, string rhox, string theoryprice, string bimpv, string offerimpv, string bidimpv, string optcode);

/// <summary>
/// KOSPI200옵션가격제한폭확대
/// </summary>
/// <param name="upstep">적용상한단계	String	Y	2</param>
/// <param name="dnstep">적용하한단계	String	Y	2</param>
/// <param name="uplmtprice">적용상한가	String	Y	6.2</param>
/// <param name="dnlmtprice">적용하한가	String	Y	6.2</param>
/// <param name="opttcode">단축코드	String	Y	8</param>
public record OX0(string upstep, string dnstep, string uplmtprice, string dnlmtprice, string opttcode);

/// <summary>
/// 상품선물예상체결
/// </summary>
/// <param name="ychetime">예상체결시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	9.2</param>
/// <param name="yevolume">예상체결수량	String	Y	6</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	9.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	9.2</param>
/// <param name="shcode">단축코드	String	Y	8</param>
public record YC3(string ychetime, string yeprice, string yevolume, string jnilysign, string jnilchange, string jnilydrate, string shcode);

/// <summary>
/// 지수선물예상체결
/// </summary>
/// <param name="ychetime">예상체결시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record YFC(string ychetime, string yeprice, string jnilysign, string jnilchange, string jnilydrate, string futcode);

/// <summary>
/// 주식선물예상체결
/// </summary>
/// <param name="ychetime">예상체결시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	10</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	10</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="futcode">단축코드	String	Y	8</param>
public record YJC(string ychetime, string yeprice, string jnilysign, string jnilchange, string jnilydrate, string futcode);

/// <summary>
/// 지수옵션예상체결
/// </summary>
/// <param name="ychetime">예상체결시간	String	Y	6</param>
/// <param name="yeprice">예상체결가격	String	Y	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	String	Y	1</param>
/// <param name="jnilchange">예상체결가전일종가대비	String	Y	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	String	Y	6.2</param>
/// <param name="optcode">단축코드	String	Y	8</param>
public record YOC(string ychetime, string yeprice, string jnilysign, string jnilchange, string jnilydrate, string optcode);

#endregion

#region [해외선물] 실시간 시세

/// <summary>
/// 해외선물 체결
/// </summary>
/// <param name="symbol">종목코드	String	Y	8</param>
/// <param name="ovsdate">체결일자(현지)	String	Y	8</param>
/// <param name="kordate">체결일자(한국)	String	Y	8</param>
/// <param name="trdtm">체결시간(현지)	String	Y	6</param>
/// <param name="kortm">체결시간(한국)	String	Y	6</param>
/// <param name="curpr">체결가격	String	Y	15.9</param>
/// <param name="ydiffpr">전일대비	String	Y	15.9</param>
/// <param name="ydiffSign">전일대비기호	String	Y	1</param>
/// <param name="open">시가	String	Y	15.9</param>
/// <param name="high">고가	String	Y	15.9</param>
/// <param name="low">저가	String	Y	15.9</param>
/// <param name="chgrate">등락율	String	Y	6.2</param>
/// <param name="trdq">건별체결수량	String	Y	10</param>
/// <param name="totq">누적체결수량	String	Y	15</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="mdvolume">매도누적체결수량	String	Y	15</param>
/// <param name="msvolume">매수누적체결수량	String	Y	15</param>
/// <param name="ovsmkend">장마감일	String	Y	8</param>
public record OVC(string symbol, string ovsdate, string kordate, string trdtm, string kortm, string curpr, string ydiffpr, string ydiffSign, string open, string high, string low, string chgrate, string trdq, string totq, string cgubun, string mdvolume, string msvolume, string ovsmkend);

/// <summary>
/// 해외선물 호가
/// </summary>
/// <param name="symbol">종목코드	String	Y	8</param>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가	1	String	Y	15.9</param>
/// <param name="bidho1">매수호가	1	String	Y	15.9</param>
/// <param name="offerrem1">매도호가	잔량	1	String	Y	10</param>
/// <param name="bidrem1">매수호가	잔량	1	String	Y	10</param>
/// <param name="offerno1">매도호가	건수	1	String	Y	10</param>
/// <param name="bidno1">매수호가	건수	1	String	Y	10</param>
/// <param name="offerho2">매도호가	2	String	Y	15.9</param>
/// <param name="bidho2">매수호가	2	String	Y	15.9</param>
/// <param name="offerrem2">매도호가	잔량	2	String	Y	10</param>
/// <param name="bidrem2">매수호가	잔량	2	String	Y	10</param>
/// <param name="offerno2">매도호가	건수	2	String	Y	10</param>
/// <param name="bidno2">매수호가	건수	2	String	Y	10</param>
/// <param name="offerho3">매도호가	3	String	Y	15.9</param>
/// <param name="bidho3">매수호가	3	String	Y	15.9</param>
/// <param name="offerrem3">매도호가	잔량	3	String	Y	10</param>
/// <param name="bidrem3">매수호가	잔량	3	String	Y	10</param>
/// <param name="offerno3">매도호가	건수	3	String	Y	10</param>
/// <param name="bidno3">매수호가	건수	3	String	Y	10</param>
/// <param name="offerho4">매도호가	4	String	Y	15.9</param>
/// <param name="bidho4">매수호가	4	String	Y	15.9</param>
/// <param name="offerrem4">매도호가	잔량	4	String	Y	10</param>
/// <param name="bidrem4">매수호가	잔량	4	String	Y	10</param>
/// <param name="offerno4">매도호가	건수	4	String	Y	10</param>
/// <param name="bidno4">매수호가	건수	4	String	Y	10</param>
/// <param name="offerho5">매도호가	5	String	Y	15.9</param>
/// <param name="bidho5">매수호가	5	String	Y	15.9</param>
/// <param name="offerrem5">매도호가	잔량	5	String	Y	10</param>
/// <param name="bidrem5">매수호가	잔량	5	String	Y	10</param>
/// <param name="offerno5">매도호가	건수	5	String	Y	10</param>
/// <param name="bidno5">매수호가	건수	5	String	Y	10</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	10</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	10</param>
/// <param name="totofferrem">매도호가총수량	String	Y	10</param>
/// <param name="totbidrem">매수호가총수량	String	Y	10</param>
public record OVH(string symbol, string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offerno1, string bidno1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offerno2, string bidno2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offerno3, string bidno3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offerno4, string bidno4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offerno5, string bidno5, string totoffercnt, string totbidcnt, string totofferrem, string totbidrem);

/// <summary>
/// 해외옵션 체결
/// </summary>
/// <param name="symbol">종목코드	String	Y	16</param>
/// <param name="ovsdate">체결일자(현지)	String	Y	8</param>
/// <param name="kordate">체결일자(한국)	String	Y	8</param>
/// <param name="trdtm">체결시간(현지)	String	Y	6</param>
/// <param name="kortm">체결시간(한국)	String	Y	6</param>
/// <param name="curpr">체결가격	String	Y	15.9</param>
/// <param name="ydiffpr">전일대비	String	Y	15.9</param>
/// <param name="ydiffSign">전일대비기호	String	Y	1</param>
/// <param name="open">시가	String	Y	15.9</param>
/// <param name="high">고가	String	Y	15.9</param>
/// <param name="low">저가	String	Y	15.9</param>
/// <param name="chgrate">등락율	String	Y	6.2</param>
/// <param name="trdq">건별체결수량	String	Y	10</param>
/// <param name="totq">누적체결수량	String	Y	15</param>
/// <param name="cgubun">체결구분	String	Y	1</param>
/// <param name="mdvolume">매도누적체결수량	String	Y	15</param>
/// <param name="msvolume">매수누적체결수량	String	Y	15</param>
/// <param name="ovsmkend">장마감일	String	Y	8</param>
public record WOC(string symbol, string ovsdate, string kordate, string trdtm, string kortm, string curpr, string ydiffpr, string ydiffSign, string open, string high, string low, string chgrate, string trdq, string totq, string cgubun, string mdvolume, string msvolume, string ovsmkend);

/// <summary>
/// 해외옵션 호가
/// </summary>
/// <param name="symbol">종목코드	String	Y	16</param>
/// <param name="hotime">호가시간	String	Y	6</param>
/// <param name="offerho1">매도호가	1	String	Y	15.9</param>
/// <param name="bidho1">매수호가	1	String	Y	15.9</param>
/// <param name="offerrem1">매도호가	잔량	1	String	Y	10</param>
/// <param name="bidrem1">매수호가	잔량	1	String	Y	10</param>
/// <param name="offerno1">매도호가	건수	1	String	Y	10</param>
/// <param name="bidno1">매수호가	건수	1	String	Y	10</param>
/// <param name="offerho2">매도호가	2	String	Y	15.9</param>
/// <param name="bidho2">매수호가	2	String	Y	15.9</param>
/// <param name="offerrem2">매도호가	잔량	2	String	Y	10</param>
/// <param name="bidrem2">매수호가	잔량	2	String	Y	10</param>
/// <param name="offerno2">매도호가	건수	2	String	Y	10</param>
/// <param name="bidno2">매수호가	건수	2	String	Y	10</param>
/// <param name="offerho3">매도호가	3	String	Y	15.9</param>
/// <param name="bidho3">매수호가	3	String	Y	15.9</param>
/// <param name="offerrem3">매도호가	잔량	3	String	Y	10</param>
/// <param name="bidrem3">매수호가	잔량	3	String	Y	10</param>
/// <param name="offerno3">매도호가	건수	3	String	Y	10</param>
/// <param name="bidno3">매수호가	건수	3	String	Y	10</param>
/// <param name="offerho4">매도호가	4	String	Y	15.9</param>
/// <param name="bidho4">매수호가	4	String	Y	15.9</param>
/// <param name="offerrem4">매도호가	잔량	4	String	Y	10</param>
/// <param name="bidrem4">매수호가	잔량	4	String	Y	10</param>
/// <param name="offerno4">매도호가	건수	4	String	Y	10</param>
/// <param name="bidno4">매수호가	건수	4	String	Y	10</param>
/// <param name="offerho5">매도호가	5	String	Y	15.9</param>
/// <param name="bidho5">매수호가	5	String	Y	15.9</param>
/// <param name="offerrem5">매도호가	잔량	5	String	Y	10</param>
/// <param name="bidrem5">매수호가	잔량	5	String	Y	10</param>
/// <param name="offerno5">매도호가	건수	5	String	Y	10</param>
/// <param name="bidno5">매수호가	건수	5	String	Y	10</param>
/// <param name="totoffercnt">매도호가총건수	String	Y	10</param>
/// <param name="totbidcnt">매수호가총건수	String	Y	10</param>
/// <param name="totofferrem">매도호가총수량	String	Y	10</param>
/// <param name="totbidrem">매수호가총수량	String	Y	10</param>
public record WOH(string symbol, string hotime, string offerho1, string bidho1, string offerrem1, string bidrem1, string offerno1, string bidno1, string offerho2, string bidho2, string offerrem2, string bidrem2, string offerno2, string bidno2, string offerho3, string bidho3, string offerrem3, string bidrem3, string offerno3, string bidno3, string offerho4, string bidho4, string offerrem4, string bidrem4, string offerno4, string bidno4, string offerho5, string bidho5, string offerrem5, string bidrem5, string offerno5, string bidno5, string totoffercnt, string totbidcnt, string totofferrem, string totbidrem);

/// <summary>
/// 해외선물 주문접수
/// </summary>
/// <param name="lineseq">라인일련번호	String	Y	10</param>
/// <param name="key">KEY	String	Y	11</param>
/// <param name="user">조작자ID	String	Y	8</param>
/// <param name="svc_id">서비스ID	String	Y	4	HO01:주문ACK,HO04:주문Pending</param>
/// <param name="ordr_dt">주문일자	String	Y	8</param>
/// <param name="brn_cd">지점번호	String	Y	3</param>
/// <param name="ordr_no">주문번호	String	Y	10</param>
/// <param name="orgn_ordr_no">원주문번호	String	Y	10</param>
/// <param name="mthr_ordr_no">모주문번호	String	Y	10</param>
/// <param name="ac_no">계좌번호	String	Y	11</param>
/// <param name="is_cd">종목코드	String	Y	30</param>
/// <param name="s_b_ccd">매도매수유형	String	Y	1	1:매도,2:매수</param>
/// <param name="ordr_ccd">정정취소유형	String	Y	1	1:신규,2:정정,3:취소</param>
/// <param name="ordr_typ_cd">주문유형코드	String	Y	1	1:시장가,2:지정가,3:Stop	Market,4:Stop	Limit</param>
/// <param name="ordr_typ_prd_ccd">주문기간코드	String	Y	2	01:일반,02:Average,03:Spread</param>
/// <param name="ordr_aplc_strt_dt">주문적용시작일자	String	Y	8</param>
/// <param name="ordr_aplc_end_dt">주문적용종료일자	String	Y	8</param>
/// <param name="ordr_prc">주문가격	String	Y	18.11</param>
/// <param name="cndt_ordr_prc">주문조건가격	String	Y	18.11</param>
/// <param name="ordr_q">주문수량	String	Y	12</param>
/// <param name="ordr_tm">주문시간	String	Y	9</param>
/// <param name="userid">사용자ID	String	Y	8</param>
/// <param name="xrc_rsv_tp_code">행사예약구분코드	String	Y	1	1:	옵션행사예약,0:	옵션행사예약아님</param>
public record TC1(string lineseq, string key, string user, string svc_id, string ordr_dt, string brn_cd, string ordr_no, string orgn_ordr_no, string mthr_ordr_no, string ac_no, string is_cd, string s_b_ccd, string ordr_ccd, string ordr_typ_cd, string ordr_typ_prd_ccd, string ordr_aplc_strt_dt, string ordr_aplc_end_dt, string ordr_prc, string cndt_ordr_prc, string ordr_q, string ordr_tm, string userid, string xrc_rsv_tp_code);

/// <summary>
/// 해외선물 주문응답
/// </summary>
/// <param name="lineseq">라인일련번호	String	Y	10</param>
/// <param name="key">KEY	String	Y	11</param>
/// <param name="user">조작자ID	String	Y	8</param>
/// <param name="svc_id">서비스ID	String	Y	4	HO02:확인,HO03:거부</param>
/// <param name="ordr_dt">주문일자	String	Y	8</param>
/// <param name="brn_cd">지점번호	String	Y	3</param>
/// <param name="ordr_no">주문번호	String	Y	10</param>
/// <param name="orgn_ordr_no">원주문번호	String	Y	10</param>
/// <param name="mthr_ordr_no">모주문번호	String	Y	10</param>
/// <param name="ac_no">계좌번호	String	Y	11</param>
/// <param name="is_cd">종목코드	String	Y	30</param>
/// <param name="s_b_ccd">매도매수유형	String	Y	1	1:매도,2:매수</param>
/// <param name="ordr_ccd">정정취소유형	String	Y	1	1:신규,2:정정,3:취소</param>
/// <param name="ordr_typ_cd">주문유형코드	String	Y	1	1:시장가,2:지정가,3:Stop	Market,4:Stop	Limit</param>
/// <param name="ordr_typ_prd_ccd">주문기간코드	String	Y	2	01:일반,02:Average,03:Spread</param>
/// <param name="ordr_aplc_strt_dt">주문적용시작일자	String	Y	8</param>
/// <param name="ordr_aplc_end_dt">주문적용종료일자	String	Y	8</param>
/// <param name="ordr_prc">주문가격	String	Y	18.11</param>
/// <param name="cndt_ordr_prc">주문조건가격	String	Y	18.11</param>
/// <param name="ordr_q">주문수량	String	Y	12</param>
/// <param name="ordr_tm">주문시간	String	Y	9</param>
/// <param name="cnfr_q">호가확인수량	String	Y	12</param>
/// <param name="rfsl_cd">호가거부사유코드	String	Y	4</param>
/// <param name="text">호가거부사유코드명	String	Y	80</param>
/// <param name="userid">사용자ID	String	Y	8</param>
public record TC2(string lineseq, string key, string user, string svc_id, string ordr_dt, string brn_cd, string ordr_no, string orgn_ordr_no, string mthr_ordr_no, string ac_no, string is_cd, string s_b_ccd, string ordr_ccd, string ordr_typ_cd, string ordr_typ_prd_ccd, string ordr_aplc_strt_dt, string ordr_aplc_end_dt, string ordr_prc, string cndt_ordr_prc, string ordr_q, string ordr_tm, string cnfr_q, string rfsl_cd, string text, string userid);

/// <summary>
/// 해외선물 주문체결
/// </summary>
/// <param name="lineseq">라인일련번호	String	Y	10</param>
/// <param name="key">KEY	String	Y	11</param>
/// <param name="user">조작자ID	String	Y	8</param>
/// <param name="svc_id">서비스ID	String	Y	4	CH01</param>
/// <param name="ordr_dt">주문일자	String	Y	8</param>
/// <param name="brn_cd">지점번호	String	Y	3</param>
/// <param name="ordr_no">주문번호	String	Y	10</param>
/// <param name="orgn_ordr_no">원주문번호	String	Y	10</param>
/// <param name="mthr_ordr_no">모주문번호	String	Y	10</param>
/// <param name="ac_no">계좌번호	String	Y	11</param>
/// <param name="is_cd">종목코드	String	Y	30</param>
/// <param name="s_b_ccd">매도매수유형	String	Y	1	1:매도,2:매수</param>
/// <param name="ordr_ccd">정정취소유형	String	Y	1	1:신규,2:정정,3:취소</param>
/// <param name="ccls_q">체결수량	String	Y	15</param>
/// <param name="ccls_prc">체결가격	String	Y	18.11</param>
/// <param name="ccls_no">체결번호	String	Y	10</param>
/// <param name="ccls_tm">체결시간	String	Y	9</param>
/// <param name="avg_byng_uprc">매입평균단가	String	Y	18.11</param>
/// <param name="byug_amt">매입금액	String	Y	25.8</param>
/// <param name="clr_pl_amt">청산손익	String	Y	19.2</param>
/// <param name="ent_fee">위탁수수료	String	Y	19.2</param>
/// <param name="fcm_fee">매입잔고수량	String	Y	19</param>
/// <param name="userid">사용자ID	String	Y	8</param>
/// <param name="now_prc">현재가격	String	Y	18.11</param>
/// <param name="crncy_cd">통화코드	String	Y	3</param>
/// <param name="mtrt_dt">만기일자	String	Y	8</param>
/// <param name="ord_prdt_tp_code">주문상품구분코드	String	Y	1</param>
/// <param name="exec_prdt_tp_code">주문상품구분코드	String	Y	1</param>
/// <param name="sprd_base_isu_yn">스프레드종목여부	String	Y	1</param>
/// <param name="ccls_dt">체결일자	String	Y	8</param>
/// <param name="filler2">FILLER2	String	Y	30</param>
/// <param name="sprd_is_cd">스프레드종목코드	String	Y	30</param>
/// <param name="lme_prdt_ccd">LME상품유형	String	Y	1	1:LME(월물상품),2:LME(3M상품),0:LME외</param>
/// <param name="lme_sprd_prc">LME스프레드가격	String	Y	18.11</param>
/// <param name="last_now_prc">최종현재가격	String	Y	18.11</param>
/// <param name="bf_mtrt_dt">이전만기일자	String	Y	8</param>
/// <param name="clr_q">청산수량	String	Y	15</param>
public record TC3(string lineseq, string key, string user, string svc_id, string ordr_dt, string brn_cd, string ordr_no, string orgn_ordr_no, string mthr_ordr_no, string ac_no, string is_cd, string s_b_ccd, string ordr_ccd, string ccls_q, string ccls_prc, string ccls_no, string ccls_tm, string avg_byng_uprc, string byug_amt, string clr_pl_amt, string ent_fee, string fcm_fee, string userid, string now_prc, string crncy_cd, string mtrt_dt, string ord_prdt_tp_code, string exec_prdt_tp_code, string sprd_base_isu_yn, string ccls_dt, string filler2, string sprd_is_cd, string lme_prdt_ccd, string lme_sprd_prc, string last_now_prc, string bf_mtrt_dt, string clr_q);



#endregion

#region [기타] 실시간 시세

/// <summary>
/// 장운영정보
/// </summary>
/// <param name="jangubun">장구분	String	Y	1</param>
/// <param name="jstatus">장상태	String	Y	2</param>
public record JIF(string jangubun, string jstatus);

/// <summary>
/// 실시간뉴스제목패킷
/// </summary>
/// <param name="date">날짜	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="id">뉴스구분자	String	Y	2</param>
/// <param name="realkey">키값	String	Y	24</param>
/// <param name="title">제목	String	Y	300</param>
/// <param name="code">단축종목코드	String	Y	240</param>
/// <param name="bodysize">BODY길이	String	Y	8</param>
public record NWS(string date, string time, string id, string realkey, string title, string code, string bodysize);

#endregion

#region [실시간 시세 투자정보] 투자정보

/// <summary>
/// 시간대별투자자매매추이
/// </summary>
/// <param name="tjjtime">수신시간	String	Y	8</param>
/// <param name="tjjcode1">투자자코드1(개인)	String	Y	4</param>
/// <param name="msvolume1">매수거래량1	String	Y	8</param>
/// <param name="mdvolume1">매도거래량1	String	Y	8</param>
/// <param name="msvol1">거래량순매수1	String	Y	8</param>
/// <param name="msvalue1">매수거래대금1	String	Y	6</param>
/// <param name="mdvalue1">매도거래대금1	String	Y	6</param>
/// <param name="msval1">거래대금순매수1	String	Y	6</param>
/// <param name="tjjcode2">투자자코드2(외국인)	String	Y	4</param>
/// <param name="msvolume2">매수거래량2	String	Y	8</param>
/// <param name="mdvolume2">매도거래량2	String	Y	8</param>
/// <param name="msvol2">거래량순매수2	String	Y	8</param>
/// <param name="msvalue2">매수거래대금2	String	Y	6</param>
/// <param name="mdvalue2">매도거래대금2	String	Y	6</param>
/// <param name="msval2">거래대금순매수2	String	Y	6</param>
/// <param name="tjjcode3">투자자코드3(기관계)	String	Y	4</param>
/// <param name="msvolume3">매수거래량3	String	Y	8</param>
/// <param name="mdvolume3">매도거래량3	String	Y	8</param>
/// <param name="msvol3">거래량순매수3	String	Y	8</param>
/// <param name="msvalue3">매수거래대금3	String	Y	6</param>
/// <param name="mdvalue3">매도거래대금3	String	Y	6</param>
/// <param name="msval3">거래대금순매수3	String	Y	6</param>
/// <param name="tjjcode4">투자자코드4(증권)	String	Y	4</param>
/// <param name="msvolume4">매수거래량4	String	Y	8</param>
/// <param name="mdvolume4">매도거래량4	String	Y	8</param>
/// <param name="msvol4">거래량순매수4	String	Y	8</param>
/// <param name="msvalue4">매수거래대금4	String	Y	6</param>
/// <param name="mdvalue4">매도거래대금4	String	Y	6</param>
/// <param name="msval4">거래대금순매수4	String	Y	6</param>
/// <param name="tjjcode5">투자자코드5(투신)	String	Y	4</param>
/// <param name="msvolume5">매수거래량5	String	Y	8</param>
/// <param name="mdvolume5">매도거래량5	String	Y	8</param>
/// <param name="msvol5">거래량순매수5	String	Y	8</param>
/// <param name="msvalue5">매수거래대금5	String	Y	6</param>
/// <param name="mdvalue5">매도거래대금5	String	Y	6</param>
/// <param name="msval5">거래대금순매수5	String	Y	6</param>
/// <param name="tjjcode6">투자자코드6(은행)	String	Y	4</param>
/// <param name="msvolume6">매수거래량6	String	Y	8</param>
/// <param name="mdvolume6">매도거래량6	String	Y	8</param>
/// <param name="msvol6">거래량순매수6	String	Y	8</param>
/// <param name="msvalue6">매수거래대금6	String	Y	6</param>
/// <param name="mdvalue6">매도거래대금6	String	Y	6</param>
/// <param name="msval6">거래대금순매수6	String	Y	6</param>
/// <param name="tjjcode7">투자자코드7(보험)	String	Y	4</param>
/// <param name="msvolume7">매수거래량7	String	Y	8</param>
/// <param name="mdvolume7">매도거래량7	String	Y	8</param>
/// <param name="msvol7">거래량순매수7	String	Y	8</param>
/// <param name="msvalue7">매수거래대금7	String	Y	6</param>
/// <param name="mdvalue7">매도거래대금7	String	Y	6</param>
/// <param name="msval7">거래대금순매수7	String	Y	6</param>
/// <param name="tjjcode8">투자자코드8(종금)	String	Y	4</param>
/// <param name="msvolume8">매수거래량8	String	Y	8</param>
/// <param name="mdvolume8">매도거래량8	String	Y	8</param>
/// <param name="msvol8">거래량순매수8	String	Y	8</param>
/// <param name="msvalue8">매수거래대금8	String	Y	6</param>
/// <param name="mdvalue8">매도거래대금8	String	Y	6</param>
/// <param name="msval8">거래대금순매수8	String	Y	6</param>
/// <param name="tjjcode9">투자자코드9(기금)	String	Y	4</param>
/// <param name="msvolume9">매수거래량9	String	Y	8</param>
/// <param name="mdvolume9">매도거래량9	String	Y	8</param>
/// <param name="msvol9">거래량순매수9	String	Y	8</param>
/// <param name="msvalue9">매수거래대금9	String	Y	6</param>
/// <param name="mdvalue9">매도거래대금9	String	Y	6</param>
/// <param name="msval9">거래대금순매수9	String	Y	6</param>
/// <param name="tjjcode10">투자자코드10(선물업자)	String	Y	4</param>
/// <param name="msvolume10">매수거래량10	String	Y	8</param>
/// <param name="mdvolume10">매도거래량10	String	Y	8</param>
/// <param name="msvol10">거래량순매수10	String	Y	8</param>
/// <param name="msvalue10">매수거래대금10	String	Y	6</param>
/// <param name="mdvalue10">매도거래대금10	String	Y	6</param>
/// <param name="msval10">거래대금순매수10	String	Y	6</param>
/// <param name="tjjcode11">투자자코드11(기타)	String	Y	4</param>
/// <param name="msvolume11">매수거래량11	String	Y	8</param>
/// <param name="mdvolume11">매도거래량11	String	Y	8</param>
/// <param name="msvol11">거래량순매수11	String	Y	8</param>
/// <param name="msvalue11">매수거래대금11	String	Y	6</param>
/// <param name="mdvalue11">매도거래대금11	String	Y	6</param>
/// <param name="msval11">거래대금순매수11	String	Y	6</param>
/// <param name="upcode">업종코드	String	Y	3</param>
/// <param name="tjjcode0">투자자코드0(사모펀드)	String	Y	4</param>
/// <param name="msvolume0">매수거래량0	String	Y	8</param>
/// <param name="mdvolume0">매도거래량0	String	Y	8</param>
/// <param name="msvol0">거래량순매수0	String	Y	8</param>
/// <param name="msvalue0">매수거래대금0	String	Y	6</param>
/// <param name="mdvalue0">매도거래대금0	String	Y	6</param>
/// <param name="msval0">거래대금순매수0	String	Y	6</param>
public record BMT(string tjjtime, string tjjcode1, string msvolume1, string mdvolume1, string msvol1, string msvalue1, string mdvalue1, string msval1, string tjjcode2, string msvolume2, string mdvolume2, string msvol2, string msvalue2, string mdvalue2, string msval2, string tjjcode3, string msvolume3, string mdvolume3, string msvol3, string msvalue3, string mdvalue3, string msval3, string tjjcode4, string msvolume4, string mdvolume4, string msvol4, string msvalue4, string mdvalue4, string msval4, string tjjcode5, string msvolume5, string mdvolume5, string msvol5, string msvalue5, string mdvalue5, string msval5, string tjjcode6, string msvolume6, string mdvolume6, string msvol6, string msvalue6, string mdvalue6, string msval6, string tjjcode7, string msvolume7, string mdvolume7, string msvol7, string msvalue7, string mdvalue7, string msval7, string tjjcode8, string msvolume8, string mdvolume8, string msvol8, string msvalue8, string mdvalue8, string msval8, string tjjcode9, string msvolume9, string mdvolume9, string msvol9, string msvalue9, string mdvalue9, string msval9, string tjjcode10, string msvolume10, string mdvolume10, string msvol10, string msvalue10, string mdvalue10, string msval10, string tjjcode11, string msvolume11, string mdvolume11, string msvol11, string msvalue11, string mdvalue11, string msval11, string upcode, string tjjcode0, string msvolume0, string mdvolume0, string msvol0, string msvalue0, string mdvalue0, string msval0);

/// <summary>
/// 현물정보USD실시간	
/// </summary>
/// <param name="time">전송시간	String	Y	6</param>
/// <param name="offer">매도호가	String	Y	7.2</param>
/// <param name="bid">매수호가	String	Y	7.2</param>
/// <param name="open">시가	String	Y	7.2</param>
/// <param name="high">고가	String	Y	7.2</param>
/// <param name="low">저가	String	Y	7.2</param>
/// <param name="price">체결가	String	Y	7.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	7.2</param>
/// <param name="drate">등락율	String	Y	7.2</param>
/// <param name="ctime">데이타발생시간	String	Y	6</param>
/// <param name="base_id">기초자산ID	String	Y	6</param>
public record CUR(string time, string offer, string bid, string open, string high, string low, string price, string sign, string change, string drate, string ctime, string base_id);

/// <summary>
/// US지수
/// </summary>
/// <param name="date">일자	String	Y	8</param>
/// <param name="time">시간	String	Y	6</param>
/// <param name="kodate">한국일자	String	Y	8</param>
/// <param name="kotime">한국시간	String	Y	6</param>
/// <param name="open">시가	String	Y	9.2</param>
/// <param name="high">고가	String	Y	9.2</param>
/// <param name="low">저가	String	Y	9.2</param>
/// <param name="price">현재가	String	Y	9.2</param>
/// <param name="sign">전일대비구분	String	Y	1</param>
/// <param name="change">전일대비	String	Y	9.2</param>
/// <param name="uprate">등락율	String	Y	9.2</param>
/// <param name="bidho">매수호가	String	Y	9.2</param>
/// <param name="bidrem">매수잔량	String	Y	9</param>
/// <param name="offerho">매도호가	String	Y	9.2</param>
/// <param name="offerrem">매도잔량	String	Y	9</param>
/// <param name="volume">누적거래량	String	Y	12.0</param>
/// <param name="xsymbol">심벌	String	Y	16</param>
/// <param name="cvolume">체결거래량	String	Y	8.0</param>
public record MK2(string date, string time, string kodate, string kotime, string open, string high, string low, string price, string sign, string change, string uprate, string bidho, string bidrem, string offerho, string offerrem, string volume, string xsymbol, string cvolume);

#endregion

#endregion