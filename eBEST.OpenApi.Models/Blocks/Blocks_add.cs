namespace eBEST.OpenApi.Blocks;


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
