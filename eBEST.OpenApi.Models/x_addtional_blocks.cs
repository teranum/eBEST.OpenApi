namespace eBEST.OpenApi.Models;

#region CSPAT00601

/// <summary>
/// 현물주문: CSPAT00601
/// </summary>
/// <param name="IsuNo">종목번호	String	Y	12	주식/ETF	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
/// <param name="BnsTpCode">매매구분	String	Y	1	1:매도,	2:매수</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2	00@지정가</param>
/// <param name="MgntrnCode">신용거래코드	String	Y	3	000:보통</param>
/// <param name="LoanDt">대출일	String	Y	8</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1	0:없음,1:IOC,2:FOK</param>
public record CSPAT00601InBlock1(
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("신용거래코드", 3)] string MgntrnCode,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode
    );

/// <summary>
/// 현물주문: CSPAT00601
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
public record CSPAT00601OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("프로그램호가유형코드", 2)] string PrgmOrdprcPtnCode,
    [BlockField("공매도가능여부", 1)] string StslAbleYn,
    [BlockField("공매도호가구분", 1)] string StslOrdprcTpCode,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("신용거래코드", 3)] string MgntrnCode,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("회원번호", 3)] string MbrNo,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode,
    [BlockField("전략코드", 6)] string StrtgCode,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("주문회차", 10)] long OrdSeqNo,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("아이템번호", 10)] long ItemNo,
    [BlockField("운용지시번호", 12)] string OpDrtnNo,
    [BlockField("유동성공급자여부", 1)] string LpYn,
    [BlockField("반대매매구분", 1)] string CvrgTpCode);

/// <summary>
/// 현물주문: CSPAT00601
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
public record CSPAT00601OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("단축종목번호", 9)] string ShtnIsuNo,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("예비주문번호", 10)] long SpareOrdNo,
    [BlockField("반대매매일련번호", 10)] long CvrgSeqno,
    [BlockField("예약주문번호", 10)] long RsvOrdNo,
    [BlockField("실물주문수량", 16)] long SpotOrdQty,
    [BlockField("재사용주문수량", 16)] long RuseOrdQty,
    [BlockField("현금주문금액", 16)] long MnyOrdAmt,
    [BlockField("대용주문금액", 16)] long SubstOrdAmt,
    [BlockField("재사용주문금액", 16)] long RuseOrdAmt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 40)] string IsuNm);
#endregion

#region CSPAT00701

/// <summary>
/// 현물정정주문 : CSPAT00701
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12	주식	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	String	Y	2	00@지정가</param>
/// <param name="OrdCndiTpCode">주문조건구분	String	Y	1	0:없음,	1:IOC,	2:FOK</param>
/// <param name="OrdPrc">주문가	Number	Y	13.2</param>
public record CSPAT00701InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode,
    [BlockField("주문가", 13.2)] double OrdPrc
    );

/// <summary>
/// 현물정정주문 : CSPAT00701
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
public record CSPAT00701OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("전략코드", 6)] string StrtgCode,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("주문회차", 10)] long OrdSeqNo,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("아이템번호", 10)] long ItemNo
    );

/// <summary>
/// 현물정정주문 : CSPAT00701
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
public record CSPAT00701OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("모주문번호", 10)] long PrntOrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("단축종목번호", 9)] string ShtnIsuNo,
    [BlockField("프로그램호가유형코드", 2)] string PrgmOrdprcPtnCode,
    [BlockField("공매도호가구분", 1)] string StslOrdprcTpCode,
    [BlockField("공매도가능여부", 1)] string StslAbleYn,
    [BlockField("신용거래코드", 3)] string MgntrnCode,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("반대매매주문구분", 1)] string CvrgOrdTp,
    [BlockField("유동성공급자여부", 1)] string LpYn,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("예비주문번호", 10)] long SpareOrdNo,
    [BlockField("반대매매일련번호", 10)] long CvrgSeqno,
    [BlockField("예약주문번호", 10)] long RsvOrdNo,
    [BlockField("현금주문금액", 16)] long MnyOrdAmt,
    [BlockField("대용주문금액", 16)] long SubstOrdAmt,
    [BlockField("재사용주문금액", 16)] long RuseOrdAmt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 40)] string IsuNm
    );
#endregion

#region CSPAT00801

/// <summary>
/// 
/// </summary>
/// <param name="OrgOrdNo">원주문번호	Number	Y	10</param>
/// <param name="IsuNo">종목번호	String	Y	12	주식	:	종목코드	or	A+종목코드(모의투자는	A+종목코드)</param>
/// <param name="OrdQty">주문수량	Number	Y	16</param>
public record CSPAT00801InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty
    );

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
public record CSPAT00801OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("전략코드", 6)] string StrtgCode,
    [BlockField("주문회차", 10)] long OrdSeqNo,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("아이템번호", 10)] long ItemNo
    );

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
public record CSPAT00801OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("모주문번호", 10)] long PrntOrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("단축종목번호", 9)] string ShtnIsuNo,
    [BlockField("프로그램호가유형코드", 2)] string PrgmOrdprcPtnCode,
    [BlockField("공매도호가구분", 1)] string StslOrdprcTpCode,
    [BlockField("공매도가능여부", 1)] string StslAbleYn,
    [BlockField("신용거래코드", 3)] string MgntrnCode,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("반대매매주문구분", 1)] string CvrgOrdTp,
    [BlockField("유동성공급자여부", 1)] string LpYn,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("예비주문번호", 10)] long SpareOrdNo,
    [BlockField("반대매매일련번호", 10)] long CvrgSeqno,
    [BlockField("예약주문번호", 10)] long RsvOrdNo,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 40)] string IsuNm
    );

#endregion

#region t1859

/// <summary>
/// 서버저장조건 조건검색	t1859InBlock
/// </summary>
/// <param name="query_index">서버저장인덱스	string	12, t1866 TR에서 조회한 t1866OutBlock1.query_index</param>
public record t1859InBlock(
    [BlockField("서버저장인덱스", 12)] string query_index);

/// <summary>
/// 서버저장조건 조건검색	t1859OutBlock
/// </summary>
/// <param name="result_count">검색종목수	int	5</param>
/// <param name="result_time">포착시간	int	6</param>
/// <param name="text">전략설명	string	200</param>
public record t1859OutBlock(
    [BlockField("검색종목수", 5)] int result_count,
    [BlockField("포착시간", 6)] int result_time,
    [BlockField("전략설명", 200)] string text
    );

/// <summary>
/// 서버저장조건 조건검색	t1859OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	7</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="price">현재가	int	7</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	long	9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
public record t1859OutBlock1(
    [BlockField("종목코드", 7)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("현재가", 7)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 9)] long change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume
    );

#endregion

#region t1860

/// <summary>
/// 서버저장조건 실시간검색    t1860InBlock
/// </summary>
/// <param name="sSysUserFlag">사용자구분	string	1 ('U' 고정)</param>
/// <param name="sFlag">Flag	string	1 ('E:'등록, 'D':중지)</param>
/// <param name="sAlertNum">실시간 검색키	string	11 (Flag 값: 'D':중지 일떄만 입력 - 등록 요청 시 수신받은 t1860OutBlock.sAlertNum 값)</param>
/// <param name="query_index">서버저장인덱스	string	12	(t1866 TR에서 조회한 t1866OutBlock1.query_index)</param>
public record t1860InBlock(
    [BlockField("사용자구분('U' 고정)", 1)] string sSysUserFlag,
    [BlockField("Flag('E:'등록, 'D':중지)", 1)] string sFlag,
    [BlockField("실시간 검색키", 11)] string sAlertNum,
    [BlockField("서버저장인덱스", 12)] string query_index
    );

/// <summary>
/// 서버저장조건 실시간검색    t1860OutBlock1
/// </summary>
/// <param name="sSysUserFlag">사용자구분	string	1</param>
/// <param name="sFlag">Flag	string	1</param>
/// <param name="sResultFlag">결과플레그	string	1 ('S':성공, 그 외 실패)</param>
/// <param name="sTime">현재시간	string	6</param>
/// <param name="sAlertNum">실시간키	string	11</param>
/// <param name="Msg">메세지	string	40</param>
public record t1860OutBlock(
    [BlockField("사용자구분", 1)] string sSysUserFlag,
    [BlockField("Flag", 1)] string sFlag,
    [BlockField("결과플레그", 1)] string sResultFlag,
    [BlockField("현재시간", 6)] string sTime,
    [BlockField("실시간키", 11)] string sAlertNum,
    [BlockField("메세지", 40)] string Msg
    );
#endregion

#region AFR

/// <summary>
/// API사용자조건검색실시간	: AFR
/// </summary>
/// <param name="sAlertNum">실시간키	string	6</param>
public record AFRInBlock(
    [BlockField("실시간키", 11)] string sAlertNum
    );

/// <summary>
/// API사용자조건검색실시간	: AFR
/// </summary>
/// <param name="gsCode">종목코드	string	9</param>
/// <param name="gshname">종목명	string	40</param>
/// <param name="gsPrice">현재가	string	8</param>
/// <param name="gsSign">전일대비구분	string	1</param>
/// <param name="gsChange">전일대비	string	8</param>
/// <param name="gsChgRate">등락율	string	6</param>
/// <param name="gsVolume">거래량	string	9</param>
/// <param name="gsJobFlag">종목상태(N:진입 R:재진입 O:이탈)	string	1</param>
public record AFROutBlock(
    [BlockField("종목코드", 9)] string gsCode,
    [BlockField("종목명", 40)] string gshname,
    [BlockField("현재가", 8)] string gsPrice,
    [BlockField("전일대비구분", 1)] string gsSign,
    [BlockField("전일대비", 8)] string gsChange,
    [BlockField("등락율", 6)] string gsChgRate,
    [BlockField("거래량", 9)] string gsVolume,
    [BlockField("종목상태(N:진입 R:재진입 O:이탈)", 1)] string gsJobFlag
    );
#endregion
