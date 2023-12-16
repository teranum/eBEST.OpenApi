// [2023-12-16 오후 8:53:31]
// 이 파일은 BlockMaker에 의해 자동으로 만들어졌습니다.
// XingAPI res폴더의 TR파일에서 변환되었습니다.

using System.ComponentModel;
namespace eBEST.OpenApi.Blocks;
/// <summary>
/// 계좌 거래내역: CDPCQ04700: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="SrtNo">시작번호	long	10</param>
/// <param name="PdptnCode">상품유형코드	string	2</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
public record CDPCQ04700InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분	string	1")] string QryTp, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("시작번호	long	10")] long SrtNo, [Description("상품유형코드	string	2")] string PdptnCode, [Description("종목대분류코드	string	2")] string IsuLgclssCode, [Description("종목번호	string	12")] string IsuNo);

/// <summary>
/// 계좌 거래내역: CDPCQ04700: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="SrtNo">시작번호	long	10</param>
/// <param name="PdptnCode">상품유형코드	string	2</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
public record CDPCQ04700OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분	string	1")] string QryTp, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("시작번호	long	10")] long SrtNo, [Description("상품유형코드	string	2")] string PdptnCode, [Description("종목대분류코드	string	2")] string IsuLgclssCode, [Description("종목번호	string	12")] string IsuNo);

/// <summary>
/// 계좌 거래내역: CDPCQ04700: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
public record CDPCQ04700OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm);

/// <summary>
/// 계좌 거래내역: CDPCQ04700: OutBlock3
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="TrdDt">거래일자	string	8</param>
/// <param name="TrdNo">거래번호	long	10</param>
/// <param name="TpCodeNm">구분코드명	string	50</param>
/// <param name="SmryNo">적요번호	string	4</param>
/// <param name="SmryNm">적요명	string	40</param>
/// <param name="CancTpNm">취소구분	string	20</param>
/// <param name="TrdQty">거래수량	long	16</param>
/// <param name="Trtax">거래세	long	16</param>
/// <param name="FcurrAdjstAmt">외화정산금액	double	25.4</param>
/// <param name="AdjstAmt">정산금액	long	16</param>
/// <param name="OvdSum">연체합	long	16</param>
/// <param name="DpsBfbalAmt">예수금전잔금액	long	16</param>
/// <param name="SellPldgRfundAmt">매도담보상환금	long	16</param>
/// <param name="DpspdgLoanBfbalAmt">예탁담보대출전잔금액	long	16</param>
/// <param name="TrdmdaNm">거래매체명	string	40</param>
/// <param name="OrgTrdNo">원거래번호	long	10</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="TrdUprc">거래단가	double	13.2</param>
/// <param name="CmsnAmt">수수료	long	16</param>
/// <param name="FcurrCmsnAmt">외화수수료금액	double	15.2</param>
/// <param name="RfundDiffAmt">상환차이금액	long	16</param>
/// <param name="RepayAmtSum">변제금합계	long	16</param>
/// <param name="SecCrbalQty">유가증권금잔수량	long	16</param>
/// <param name="CslLoanRfundIntrstAmt">매도대금담보대출상환이자금액	long	16</param>
/// <param name="DpspdgLoanCrbalAmt">예탁담보대출금잔금액	long	16</param>
/// <param name="TrxTime">처리시각	string	9</param>
/// <param name="Inouno">출납번호	long	10</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="TrdAmt">거래금액	long	16</param>
/// <param name="ChckAmt">수표금액	long	16</param>
/// <param name="TaxSumAmt">세금합계금액	long	16</param>
/// <param name="FcurrTaxSumAmt">외화세금합계금액	double	26.6</param>
/// <param name="IntrstUtlfee">이자이용료	long	16</param>
/// <param name="MnyDvdAmt">배당금액	long	16</param>
/// <param name="RcvblOcrAmt">미수발생금액	long	16</param>
/// <param name="TrxBrnNo">처리지점번호	string	3</param>
/// <param name="TrxBrnNm">처리지점명	string	40</param>
/// <param name="DpspdgLoanAmt">예탁담보대출금액	long	16</param>
/// <param name="DpspdgLoanRfundAmt">예탁담보대출상환금액	long	16</param>
/// <param name="BasePrc">기준가	double	13.2</param>
/// <param name="DpsCrbalAmt">예수금금잔금액	long	16</param>
/// <param name="BoaAmt">과표	long	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	long	16</param>
/// <param name="BcrLoanOcrAmt">수익증권담보대출발생금	long	16</param>
/// <param name="BcrLoanBfbalAmt">수익증권담보대출전잔금	long	16</param>
/// <param name="BnsBasePrc">매매기준가	double	20.1</param>
/// <param name="TaxchrBasePrc">과세기준가	double	20.1</param>
/// <param name="TrdUnit">거래좌수	long	16</param>
/// <param name="BalUnit">잔고좌수	long	16</param>
/// <param name="EvrTax">제세금	long	16</param>
/// <param name="EvalAmt">평가금액	long	16</param>
/// <param name="BcrLoanRfundAmt">수익증권담보대출상환금	long	16</param>
/// <param name="BcrLoanCrbalAmt">수익증권담보대출금잔금	long	16</param>
/// <param name="AddMgnOcrTotamt">추가증거금발생총액	long	16</param>
/// <param name="AddMnyMgnOcrAmt">추가현금증거금발생금액	long	16</param>
/// <param name="AddMgnDfryTotamt">추가증거금납부총액	long	16</param>
/// <param name="AddMnyMgnDfryAmt">추가현금증거금납부금액	long	16</param>
/// <param name="BnsplAmt">매매손익금액	long	16</param>
/// <param name="Ictax">소득세	long	16</param>
/// <param name="Ihtax">주민세	long	16</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="CrcyCode">통화코드	string	3</param>
/// <param name="FcurrAmt">외화금액	double	24.4</param>
/// <param name="FcurrTrdAmt">외화거래금액	double	24.4</param>
/// <param name="FcurrDps">외화예수금	double	21.4</param>
/// <param name="FcurrDpsBfbalAmt">외화예수금전잔금액	double	21.4</param>
/// <param name="OppAcntNm">상대계좌명	string	40</param>
/// <param name="OppAcntNo">상대계좌번호	string	20</param>
/// <param name="LoanRfundAmt">대출상환금액	long	16</param>
/// <param name="LoanIntrstAmt">대출이자금액	long	16</param>
/// <param name="AskpsnNm">의뢰인명	string	40</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="TrdXchrat">거래환율	double	15.4</param>
/// <param name="RdctCmsn">감면수수료	double	21.4</param>
/// <param name="FcurrStmpTx">외화인지세	double	21.4</param>
/// <param name="FcurrElecfnTrtax">외화전자금융거래세	double	21.4</param>
/// <param name="FcstckTrtax">외화증권거래세	double	21.4</param>
public record CDPCQ04700OutBlock3([Description("계좌번호	string	20")] string AcntNo, [Description("거래일자	string	8")] string TrdDt, [Description("거래번호	long	10")] long TrdNo, [Description("구분코드명	string	50")] string TpCodeNm, [Description("적요번호	string	4")] string SmryNo, [Description("적요명	string	40")] string SmryNm, [Description("취소구분	string	20")] string CancTpNm, [Description("거래수량	long	16")] long TrdQty, [Description("거래세	long	16")] long Trtax, [Description("외화정산금액	double	25.4")] double FcurrAdjstAmt, [Description("정산금액	long	16")] long AdjstAmt, [Description("연체합	long	16")] long OvdSum, [Description("예수금전잔금액	long	16")] long DpsBfbalAmt, [Description("매도담보상환금	long	16")] long SellPldgRfundAmt, [Description("예탁담보대출전잔금액	long	16")] long DpspdgLoanBfbalAmt, [Description("거래매체명	string	40")] string TrdmdaNm, [Description("원거래번호	long	10")] long OrgTrdNo, [Description("종목명	string	40")] string IsuNm, [Description("거래단가	double	13.2")] double TrdUprc, [Description("수수료	long	16")] long CmsnAmt, [Description("외화수수료금액	double	15.2")] double FcurrCmsnAmt, [Description("상환차이금액	long	16")] long RfundDiffAmt, [Description("변제금합계	long	16")] long RepayAmtSum, [Description("유가증권금잔수량	long	16")] long SecCrbalQty, [Description("매도대금담보대출상환이자금액	long	16")] long CslLoanRfundIntrstAmt, [Description("예탁담보대출금잔금액	long	16")] long DpspdgLoanCrbalAmt, [Description("처리시각	string	9")] string TrxTime, [Description("출납번호	long	10")] long Inouno, [Description("종목번호	string	12")] string IsuNo, [Description("거래금액	long	16")] long TrdAmt, [Description("수표금액	long	16")] long ChckAmt, [Description("세금합계금액	long	16")] long TaxSumAmt, [Description("외화세금합계금액	double	26.6")] double FcurrTaxSumAmt, [Description("이자이용료	long	16")] long IntrstUtlfee, [Description("배당금액	long	16")] long MnyDvdAmt, [Description("미수발생금액	long	16")] long RcvblOcrAmt, [Description("처리지점번호	string	3")] string TrxBrnNo, [Description("처리지점명	string	40")] string TrxBrnNm, [Description("예탁담보대출금액	long	16")] long DpspdgLoanAmt, [Description("예탁담보대출상환금액	long	16")] long DpspdgLoanRfundAmt, [Description("기준가	double	13.2")] double BasePrc, [Description("예수금금잔금액	long	16")] long DpsCrbalAmt, [Description("과표	long	16")] long BoaAmt, [Description("출금가능금액	long	16")] long MnyoutAbleAmt, [Description("수익증권담보대출발생금	long	16")] long BcrLoanOcrAmt, [Description("수익증권담보대출전잔금	long	16")] long BcrLoanBfbalAmt, [Description("매매기준가	double	20.1")] double BnsBasePrc, [Description("과세기준가	double	20.1")] double TaxchrBasePrc, [Description("거래좌수	long	16")] long TrdUnit, [Description("잔고좌수	long	16")] long BalUnit, [Description("제세금	long	16")] long EvrTax, [Description("평가금액	long	16")] long EvalAmt, [Description("수익증권담보대출상환금	long	16")] long BcrLoanRfundAmt, [Description("수익증권담보대출금잔금	long	16")] long BcrLoanCrbalAmt, [Description("추가증거금발생총액	long	16")] long AddMgnOcrTotamt, [Description("추가현금증거금발생금액	long	16")] long AddMnyMgnOcrAmt, [Description("추가증거금납부총액	long	16")] long AddMgnDfryTotamt, [Description("추가현금증거금납부금액	long	16")] long AddMnyMgnDfryAmt, [Description("매매손익금액	long	16")] long BnsplAmt, [Description("소득세	long	16")] long Ictax, [Description("주민세	long	16")] long Ihtax, [Description("대출일	string	8")] string LoanDt, [Description("통화코드	string	3")] string CrcyCode, [Description("외화금액	double	24.4")] double FcurrAmt, [Description("외화거래금액	double	24.4")] double FcurrTrdAmt, [Description("외화예수금	double	21.4")] double FcurrDps, [Description("외화예수금전잔금액	double	21.4")] double FcurrDpsBfbalAmt, [Description("상대계좌명	string	40")] string OppAcntNm, [Description("상대계좌번호	string	20")] string OppAcntNo, [Description("대출상환금액	long	16")] long LoanRfundAmt, [Description("대출이자금액	long	16")] long LoanIntrstAmt, [Description("의뢰인명	string	40")] string AskpsnNm, [Description("주문일자	string	8")] string OrdDt, [Description("거래환율	double	15.4")] double TrdXchrat, [Description("감면수수료	double	21.4")] double RdctCmsn, [Description("외화인지세	double	21.4")] double FcurrStmpTx, [Description("외화전자금융거래세	double	21.4")] double FcurrElecfnTrtax, [Description("외화증권거래세	double	21.4")] double FcstckTrtax);

/// <summary>
/// 계좌 거래내역: CDPCQ04700: OutBlock4
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="PnlSumAmt">손익합계금액	long	16</param>
/// <param name="CtrctAsm">약정누계	long	16</param>
/// <param name="CmsnAmtSumAmt">수수료합계금액	long	16</param>
public record CDPCQ04700OutBlock4([Description("레코드갯수	int	5")] int RecCnt, [Description("손익합계금액	long	16")] long PnlSumAmt, [Description("약정누계	long	16")] long CtrctAsm, [Description("수수료합계금액	long	16")] long CmsnAmtSumAmt);

/// <summary>
/// 계좌 거래내역: CDPCQ04700: OutBlock5
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MnyinAmt">입금금액	long	16</param>
/// <param name="SecinAmt">입고금액	long	16</param>
/// <param name="MnyoutAmt">출금금액	long	16</param>
/// <param name="SecoutAmt">출고금액	long	16</param>
/// <param name="DiffAmt">차이금액	long	16</param>
/// <param name="DiffAmt0">차이금액0	long	16</param>
/// <param name="SellQty">매도수량	long	16</param>
/// <param name="SellAmt">매도금액	long	16</param>
/// <param name="SellCmsn">매도수수료	long	16</param>
/// <param name="EvrTax">제세금	long	19</param>
/// <param name="FcurrSellAdjstAmt">외화매도정산금액	double	25.4</param>
/// <param name="BuyQty">매수수량	long	16</param>
/// <param name="BuyAmt">매수금액	long	16</param>
/// <param name="BuyCmsn">매수수수료	long	16</param>
/// <param name="ExecTax">체결세금	long	16</param>
/// <param name="FcurrBuyAdjstAmt">외화매수정산금액	double	25.4</param>
public record CDPCQ04700OutBlock5([Description("레코드갯수	int	5")] int RecCnt, [Description("입금금액	long	16")] long MnyinAmt, [Description("입고금액	long	16")] long SecinAmt, [Description("출금금액	long	16")] long MnyoutAmt, [Description("출고금액	long	16")] long SecoutAmt, [Description("차이금액	long	16")] long DiffAmt, [Description("차이금액0	long	16")] long DiffAmt0, [Description("매도수량	long	16")] long SellQty, [Description("매도금액	long	16")] long SellAmt, [Description("매도수수료	long	16")] long SellCmsn, [Description("제세금	long	19")] long EvrTax, [Description("외화매도정산금액	double	25.4")] double FcurrSellAdjstAmt, [Description("매수수량	long	16")] long BuyQty, [Description("매수금액	long	16")] long BuyAmt, [Description("매수수수료	long	16")] long BuyCmsn, [Description("체결세금	long	16")] long ExecTax, [Description("외화매수정산금액	double	25.4")] double FcurrBuyAdjstAmt);


/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">지점번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ21100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("선택입력구분	string	1")] string ChoicInptTpCode, [Description("지점번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("정렬순서구분	string	1")] string StnlnSeqTp);

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">지점번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ21100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("선택입력구분	string	1")] string ChoicInptTpCode, [Description("지점번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("정렬순서구분	string	1")] string StnlnSeqTp);

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="ExecQty">체결수량	long	16</param>
public record CEXAQ21100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("주문수량	long	16")] long OrdQty, [Description("체결수량	long	16")] long ExecQty);

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100: OutBlock3
/// </summary>
/// <param name="AcntNo1">계좌번호1	string	20</param>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="MrcTpNm">정정취소구분명	string	10</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="FnoOrdprcPtnNm">선물옵션호가유형명	string	40</param>
/// <param name="OrdCndiPrc">주문조건가격	double	25.8</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdTpNm">주문구분명	string	10</param>
/// <param name="ExecPrc">체결가	double	13.2</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="CommdaNm">통신매체명	string	40</param>
public record CEXAQ21100OutBlock3([Description("계좌번호1	string	20")] string AcntNo1, [Description("주문일	string	8")] string OrdDt, [Description("주문번호	long	10")] long OrdNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	10")] string BnsTpNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("정정취소구분명	string	10")] string MrcTpNm, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode, [Description("선물옵션호가유형명	string	40")] string FnoOrdprcPtnNm, [Description("주문조건가격	double	25.8")] double OrdCndiPrc, [Description("주문가	double	13.2")] double OrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("주문구분명	string	10")] string OrdTpNm, [Description("체결가	double	13.2")] double ExecPrc, [Description("체결수량	long	16")] long ExecQty, [Description("미체결수량	long	16")] long UnercQty, [Description("통신매체코드	string	2")] string CommdaCode, [Description("통신매체명	string	40")] string CommdaNm);


/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="RatVal">비율값	double	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
public record CEXAQ21200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회구분	string	1")] string QryTp, [Description("주문금액	long	16")] long OrdAmt, [Description("비율값	double	19.8")] double RatVal, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("주문가	double	13.2")] double OrdPrc, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode);

/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="RatVal">비율값	double	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
public record CEXAQ21200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회구분	string	1")] string QryTp, [Description("주문금액	long	16")] long OrdAmt, [Description("비율값	double	19.8")] double RatVal, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("주문가	double	13.2")] double OrdPrc, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode);

/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="QryDt">조회일	string	8</param>
/// <param name="NowPrc">현재가	double	15.2</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
/// <param name="NewOrdAbleQty">신규주문가능수량	long	16</param>
/// <param name="LqdtOrdAbleQty">청산주문가능수량	long	16</param>
/// <param name="UsePreargMgn">사용예정증거금액	long	16</param>
/// <param name="UsePreargMnyMgn">사용예정현금증거금액	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
public record CEXAQ21200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("조회일	string	8")] string QryDt, [Description("현재가	double	15.2")] double NowPrc, [Description("주문가능수량	long	16")] long OrdAbleQty, [Description("신규주문가능수량	long	16")] long NewOrdAbleQty, [Description("청산주문가능수량	long	16")] long LqdtOrdAbleQty, [Description("사용예정증거금액	long	16")] long UsePreargMgn, [Description("사용예정현금증거금액	long	16")] long UsePreargMnyMgn, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt);


/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuCode">종목코드	string	12</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목코드	string	12")] string IsuCode, [Description("잔고평가구분	string	1")] string BalEvalTp, [Description("선물가격평가구분	string	1")] string FutsPrcEvalTp);

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuCode">종목코드	string	12</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목코드	string	12")] string IsuCode, [Description("잔고평가구분	string	1")] string BalEvalTp, [Description("선물가격평가구분	string	1")] string FutsPrcEvalTp);

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="BnsplAmt">매매손익금액	long	16</param>
/// <param name="AdjstDfamt">정산차금	long	16</param>
/// <param name="TotEvalAmt">총평가금액	long	16</param>
/// <param name="TotPnlAmt">총손익금액	long	16</param>
public record CEXAQ31100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌명	string	40")] string AcntNm, [Description("매매손익금액	long	16")] long BnsplAmt, [Description("정산차금	long	16")] long AdjstDfamt, [Description("총평가금액	long	16")] long TotEvalAmt, [Description("총손익금액	long	16")] long TotPnlAmt);

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100: OutBlock3
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="UnsttQty">미결제수량	long	16</param>
/// <param name="LqdtAbleQty">청산가능수량	long	16</param>
/// <param name="FnoAvrPrc">평균가	double	19.8</param>
/// <param name="BasePrc">기준가	double	30.1</param>
/// <param name="NowPrc">현재가	double	13.2</param>
/// <param name="CmpPrc">대비가	double	13.2</param>
/// <param name="EvalAmt">평가금액	long	16</param>
/// <param name="EvalPnl">평가손익	long	16</param>
/// <param name="PnlRat">손익률	double	12.6</param>
/// <param name="UnsttAmt">미결제금액	long	16</param>
/// <param name="BnsplAmt">매매손익금액	long	16</param>
public record CEXAQ31100OutBlock3([Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("매매구분	string	10")] string BnsTpNm, [Description("미결제수량	long	16")] long UnsttQty, [Description("청산가능수량	long	16")] long LqdtAbleQty, [Description("평균가	double	19.8")] double FnoAvrPrc, [Description("기준가	double	30.1")] double BasePrc, [Description("현재가	double	13.2")] double NowPrc, [Description("대비가	double	13.2")] double CmpPrc, [Description("평가금액	long	16")] long EvalAmt, [Description("평가손익	long	16")] long EvalPnl, [Description("손익률	double	12.6")] double PnlRat, [Description("미결제금액	long	16")] long UnsttAmt, [Description("매매손익금액	long	16")] long BnsplAmt);


/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("잔고평가구분	string	1")] string BalEvalTp, [Description("선물가격평가구분	string	1")] string FutsPrcEvalTp);

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("잔고평가구분	string	1")] string BalEvalTp, [Description("선물가격평가구분	string	1")] string FutsPrcEvalTp);

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="EvalDpsamtTotamt">평가예탁금총액	long	15</param>
/// <param name="MnyEvalDpstgAmt">현금평가예탁금액	long	15</param>
/// <param name="DpsamtTotamt">예탁금총액	long	16</param>
/// <param name="DpstgMny">예탁현금	long	16</param>
/// <param name="PsnOutAbleTotAmt">인출가능총금액	long	15</param>
/// <param name="PsnOutAbleCurAmt">인출가능현금액	long	16</param>
/// <param name="OrdAbleTotAmt">주문가능총금액	long	15</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="CsgnMgnTotamt">위탁증거금총액	long	16</param>
/// <param name="MnyCsgnMgn">현금위탁증거금액	long	16</param>
/// <param name="AddMgnTotamt">추가증거금총액	long	15</param>
/// <param name="MnyAddMgn">현금추가증거금액	long	16</param>
/// <param name="CmsnAmt">수수료	long	16</param>
/// <param name="FutsEvalPnlAmt">선물평가손익금액	long	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	long	16</param>
/// <param name="OptEvalAmt">옵션평가금액	long	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	long	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="TotPnlAmt">총손익금액	long	16</param>
/// <param name="NetPnlAmt">순손익금액	long	16</param>
/// <param name="TotEvalAmt">총평가금액	long	16</param>
/// <param name="MnyinAmt">입금금액	long	16</param>
/// <param name="MnyoutAmt">출금금액	long	16</param>
/// <param name="FutsCmsnAmt">선물수수료금액	long	16</param>
public record CEXAQ31200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌명	string	40")] string AcntNm, [Description("평가예탁금총액	long	15")] long EvalDpsamtTotamt, [Description("현금평가예탁금액	long	15")] long MnyEvalDpstgAmt, [Description("예탁금총액	long	16")] long DpsamtTotamt, [Description("예탁현금	long	16")] long DpstgMny, [Description("인출가능총금액	long	15")] long PsnOutAbleTotAmt, [Description("인출가능현금액	long	16")] long PsnOutAbleCurAmt, [Description("주문가능총금액	long	15")] long OrdAbleTotAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("위탁증거금총액	long	16")] long CsgnMgnTotamt, [Description("현금위탁증거금액	long	16")] long MnyCsgnMgn, [Description("추가증거금총액	long	15")] long AddMgnTotamt, [Description("현금추가증거금액	long	16")] long MnyAddMgn, [Description("수수료	long	16")] long CmsnAmt, [Description("선물평가손익금액	long	16")] long FutsEvalPnlAmt, [Description("옵션평가손익금액	long	16")] long OptEvalPnlAmt, [Description("옵션평가금액	long	16")] long OptEvalAmt, [Description("옵션매매손익금액	long	16")] long OptBnsplAmt, [Description("선물정산차금	long	16")] long FutsAdjstDfamt, [Description("총손익금액	long	16")] long TotPnlAmt, [Description("순손익금액	long	16")] long NetPnlAmt, [Description("총평가금액	long	16")] long TotEvalAmt, [Description("입금금액	long	16")] long MnyinAmt, [Description("출금금액	long	16")] long MnyoutAmt, [Description("선물수수료금액	long	16")] long FutsCmsnAmt);

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200: OutBlock3
/// </summary>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="UnsttQty">미결제수량	long	16</param>
/// <param name="FnoAvrPrc">평균가	double	19.8</param>
/// <param name="NowPrc">현재가	double	13.2</param>
/// <param name="CmpPrc">대비가	double	13.2</param>
/// <param name="EvalPnl">평가손익	long	16</param>
/// <param name="PnlRat">손익률	double	12.6</param>
/// <param name="EvalAmt">평가금액	long	16</param>
/// <param name="LqdtAbleQty">청산가능수량	long	16</param>
public record CEXAQ31200OutBlock3([Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("매매구분	string	10")] string BnsTpNm, [Description("미결제수량	long	16")] long UnsttQty, [Description("평균가	double	19.8")] double FnoAvrPrc, [Description("현재가	double	13.2")] double NowPrc, [Description("대비가	double	13.2")] double CmpPrc, [Description("평가손익	long	16")] long EvalPnl, [Description("손익률	double	12.6")] double PnlRat, [Description("평가금액	long	16")] long EvalAmt, [Description("청산가능수량	long	16")] long LqdtAbleQty);


/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	string	2</param>
/// <param name="SrtOrdNo2">시작주문번호2	long	10</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ44200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("선택입력구분	string	1")] string ChoicInptTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("선물옵션거래유형코드	string	2")] string FnoTrdPtnCode, [Description("시작주문번호2	long	10")] long SrtOrdNo2, [Description("정렬순서구분	string	1")] string StnlnSeqTp);

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	string	2</param>
/// <param name="SrtOrdNo2">시작주문번호2	long	10</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ44200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("선택입력구분	string	1")] string ChoicInptTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("선물옵션거래유형코드	string	2")] string FnoTrdPtnCode, [Description("시작주문번호2	long	10")] long SrtOrdNo2, [Description("정렬순서구분	string	1")] string StnlnSeqTp);

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="ExecPrc">체결가	double	15.2</param>
public record CEXAQ44200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문수량	long	16")] long OrdQty, [Description("체결수량	long	16")] long ExecQty, [Description("미체결수량	long	16")] long UnercQty, [Description("체결가	double	15.2")] double ExecPrc);

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200: OutBlock3
/// </summary>
/// <param name="AcntNo1">계좌번호1	string	20</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="ErxOrdprcTpCode">유렉스호가구분코드	string	1</param>
/// <param name="MrcTpNm">정정취소구분명	string	10</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="CodeNm">코드명	string	40</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="FnoRjtRsnCode">선물옵션거부사유코드	string	3</param>
/// <param name="OrdTpNm">주문구분명	string	10</param>
/// <param name="ExecTpNm">체결구분명	string	10</param>
/// <param name="ExecPrc">체결가	double	13.2</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="ExecTime">체결시각	string	9</param>
/// <param name="ExecNo">체결번호	long	10</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="UserId">사용자ID	string	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="CommdaCodeNm">통신매체코드명	string	40</param>
/// <param name="IpAddr">IP주소	string	16</param>
/// <param name="TrdPtnTpNm">거래유형구분	string	20</param>
/// <param name="ErxOrdStatCode">유렉스주문상태코드	string	1</param>
/// <param name="CodeNm0">코드명0	string	40</param>
/// <param name="ExchRcptTime">거래소접수시각	string	30</param>
public record CEXAQ44200OutBlock3([Description("계좌번호1	string	20")] string AcntNo1, [Description("계좌명	string	40")] string AcntNm, [Description("주문일	string	8")] string OrdDt, [Description("주문번호	long	10")] long OrdNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("종목번호	string	12")] string IsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	10")] string BnsTpNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("유렉스호가구분코드	string	1")] string ErxOrdprcTpCode, [Description("정정취소구분명	string	10")] string MrcTpNm, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode, [Description("코드명	string	40")] string CodeNm, [Description("주문가	double	13.2")] double OrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("선물옵션거부사유코드	string	3")] string FnoRjtRsnCode, [Description("주문구분명	string	10")] string OrdTpNm, [Description("체결구분명	string	10")] string ExecTpNm, [Description("체결가	double	13.2")] double ExecPrc, [Description("체결수량	long	16")] long ExecQty, [Description("체결시각	string	9")] string ExecTime, [Description("체결번호	long	10")] long ExecNo, [Description("미체결수량	long	16")] long UnercQty, [Description("사용자ID	string	16")] string UserId, [Description("통신매체코드	string	2")] string CommdaCode, [Description("통신매체코드명	string	40")] string CommdaCodeNm, [Description("IP주소	string	16")] string IpAddr, [Description("거래유형구분	string	20")] string TrdPtnTpNm, [Description("유렉스주문상태코드	string	1")] string ErxOrdStatCode, [Description("코드명0	string	40")] string CodeNm0, [Description("거래소접수시각	string	30")] string ExchRcptTime);


/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100: InBlock1
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CEXAT11100InBlock1([Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode, [Description("주문가격	double	15.2")] double OrdPrc, [Description("주문수량	long	16")] long OrdQty);

/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdCndiPrc">주문조건가격	double	25.8</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CEXAT11100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode, [Description("주문가격	double	15.2")] double OrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("주문조건가격	double	25.8")] double OrdCndiPrc, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CEXAT11100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금	long	16")] long OrdMgn, [Description("현금주문증거금	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 유렉스 정정주문: CEXAT11200: InBlock1
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
public record CEXAT11200InBlock1([Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("주문가격	double	15.2")] double OrdPrc);

/// <summary>
/// 유렉스 정정주문: CEXAT11200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="MdfyQty">정정수량	long	16</param>
/// <param name="OrdCndiPrc">주문조건가격	double	25.8</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CEXAT11200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("유렉스가격조건구분코드	string	1")] string ErxPrcCndiTpCode, [Description("주문가격	double	15.2")] double OrdPrc, [Description("정정수량	long	16")] long MdfyQty, [Description("주문조건가격	double	25.8")] double OrdCndiPrc, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 유렉스 정정주문: CEXAT11200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금액	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CEXAT11200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금액	long	16")] long OrdMgn, [Description("현금주문증거금액	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 유렉스 취소주문: CEXAT11300: InBlock1
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
public record CEXAT11300InBlock1([Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo);

/// <summary>
/// 유렉스 취소주문: CEXAT11300: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="CancQty">취소수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CEXAT11300OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("취소수량	long	16")] long CancQty, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 유렉스 취소주문: CEXAT11300: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금액	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CEXAT11300OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금액	long	16")] long OrdMgn, [Description("현금주문증거금액	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="FnoClssCode">선물옵션분류코드	string	2</param>
/// <param name="PrdgrpCode">상품군코드	string	2</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CFOAQ00600InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("선물옵션분류코드	string	2")] string FnoClssCode, [Description("상품군코드	string	2")] string PrdgrpCode, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("정렬순서구분	string	1")] string StnlnSeqTp, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="FnoClssCode">선물옵션분류코드	string	2</param>
/// <param name="PrdgrpCode">상품군코드	string	2</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CFOAQ00600OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("선물옵션분류코드	string	2")] string FnoClssCode, [Description("상품군코드	string	2")] string PrdgrpCode, [Description("체결구분	string	1")] string PrdtExecTpCode, [Description("정렬순서구분	string	1")] string StnlnSeqTp, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="FutsOrdQty">선물주문수량	long	16</param>
/// <param name="FutsExecQty">선물체결수량	long	16</param>
/// <param name="OptOrdQty">옵션주문수량	long	16</param>
/// <param name="OptExecQty">옵션체결수량	long	16</param>
public record CFOAQ00600OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("선물주문수량	long	16")] long FutsOrdQty, [Description("선물체결수량	long	16")] long FutsExecQty, [Description("옵션주문수량	long	16")] long OptOrdQty, [Description("옵션체결수량	long	16")] long OptExecQty);

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600: OutBlock3
/// </summary>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="MrcTpNm">정정취소구분명	string	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdprcPtnNm">선물옵션호가유형명	string	40</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdTpNm">주문구분명	string	10</param>
/// <param name="ExecTpNm">체결구분명	string	10</param>
/// <param name="ExecPrc">체결가	double	13.2</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="CtrctTime">약정시각	string	9</param>
/// <param name="CtrctNo">약정번호	long	10</param>
/// <param name="ExecNo">체결번호	long	10</param>
/// <param name="BnsplAmt">매매손익금액	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="UserId">사용자ID	string	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="CommdaCodeNm">통신매체코드명	string	40</param>
public record CFOAQ00600OutBlock3([Description("주문일	string	8")] string OrdDt, [Description("주문번호	long	10")] long OrdNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	10")] string BnsTpNm, [Description("정정취소구분명	string	10")] string MrcTpNm, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode, [Description("선물옵션호가유형명	string	40")] string FnoOrdprcPtnNm, [Description("주문가	double	13.2")] double OrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("주문구분명	string	10")] string OrdTpNm, [Description("체결구분명	string	10")] string ExecTpNm, [Description("체결가	double	13.2")] double ExecPrc, [Description("체결수량	long	16")] long ExecQty, [Description("약정시각	string	9")] string CtrctTime, [Description("약정번호	long	10")] long CtrctNo, [Description("체결번호	long	10")] long ExecNo, [Description("매매손익금액	long	16")] long BnsplAmt, [Description("미체결수량	long	16")] long UnercQty, [Description("사용자ID	string	16")] string UserId, [Description("통신매체코드	string	2")] string CommdaCode, [Description("통신매체코드명	string	40")] string CommdaCodeNm);


/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="RatVal">비율값	double	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
public record CFOAQ10100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회구분	string	1")] string QryTp, [Description("주문금액	long	16")] long OrdAmt, [Description("비율값	double	19.8")] double RatVal, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode);

/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="RatVal">비율값	double	19.8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
public record CFOAQ10100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회구분	string	1")] string QryTp, [Description("주문금액	long	16")] long OrdAmt, [Description("비율값	double	19.8")] double RatVal, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode);

/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="QryDt">조회일	string	8</param>
/// <param name="FnoNowPrc">선물옵션현재가	double	27.8</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
/// <param name="NewOrdAbleQty">신규주문가능수량	long	16</param>
/// <param name="LqdtOrdAbleQty">청산주문가능수량	long	16</param>
/// <param name="UsePreargMgn">사용예정증거금액	long	16</param>
/// <param name="UsePreargMnyMgn">사용예정현금증거금액	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
public record CFOAQ10100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("조회일	string	8")] string QryDt, [Description("선물옵션현재가	double	27.8")] double FnoNowPrc, [Description("주문가능수량	long	16")] long OrdAbleQty, [Description("신규주문가능수량	long	16")] long NewOrdAbleQty, [Description("청산주문가능수량	long	16")] long LqdtOrdAbleQty, [Description("사용예정증거금액	long	16")] long UsePreargMgn, [Description("사용예정현금증거금액	long	16")] long UsePreargMnyMgn, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt);


/// <summary>
/// 선물옵션 정상주문: CFOAT00100: InBlock1
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CFOAT00100InBlock1([Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("주문수량	long	16")] long OrdQty);

/// <summary>
/// 선물옵션 정상주문: CFOAT00100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	string	2</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoTrdPtnCode">선물옵션거래유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	string	9</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="OrdSeqno">주문일련번호	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">항목번호	long	16</param>
/// <param name="OpDrtnNo">운용지시번호	string	12</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="FundId">펀드ID	string	12</param>
/// <param name="FundOrdNo">펀드주문번호	long	10</param>
public record CFOAT00100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("선물옵션주문유형코드	string	2")] string FnoOrdPtnCode, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode, [Description("선물옵션거래유형코드	string	2")] string FnoTrdPtnCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("통신매체코드	string	2")] string CommdaCode, [Description("협의매매완료시각	string	9")] string DscusBnsCmpltTime, [Description("그룹ID	string	20")] string GrpId, [Description("주문일련번호	long	10")] long OrdSeqno, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("항목번호	long	16")] long ItemNo, [Description("운용지시번호	string	12")] string OpDrtnNo, [Description("관리사원번호	string	9")] string MgempNo, [Description("펀드ID	string	12")] string FundId, [Description("펀드주문번호	long	10")] long FundOrdNo);

/// <summary>
/// 선물옵션 정상주문: CFOAT00100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CFOAT00100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금	long	16")] long OrdMgn, [Description("현금주문증거금	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 선물옵션 정정주문: CFOAT00200: InBlock1
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="MdfyQty">정정수량	long	16</param>
public record CFOAT00200InBlock1([Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("정정수량	long	16")] long MdfyQty);

/// <summary>
/// 선물옵션 정정주문: CFOAT00200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	string	2</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="MdfyQty">정정수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	string	9</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="OrdSeqno">주문일련번호	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">아이템번호	long	10</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="FundId">펀드ID	string	12</param>
/// <param name="FundOrgOrdNo">펀드원주문번호	long	10</param>
/// <param name="FundOrdNo">펀드주문번호	long	10</param>
public record CFOAT00200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("선물옵션주문유형코드	string	2")] string FnoOrdPtnCode, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("선물옵션호가유형코드	string	2")] string FnoOrdprcPtnCode, [Description("선물옵션주문가격	double	27.8")] double FnoOrdPrc, [Description("정정수량	long	16")] long MdfyQty, [Description("통신매체코드	string	2")] string CommdaCode, [Description("협의매매완료시각	string	9")] string DscusBnsCmpltTime, [Description("그룹ID	string	20")] string GrpId, [Description("주문일련번호	long	10")] long OrdSeqno, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("아이템번호	long	10")] long ItemNo, [Description("관리사원번호	string	9")] string MgempNo, [Description("펀드ID	string	12")] string FundId, [Description("펀드원주문번호	long	10")] long FundOrgOrdNo, [Description("펀드주문번호	long	10")] long FundOrdNo);

/// <summary>
/// 선물옵션 정정주문: CFOAT00200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금액	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CFOAT00200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금액	long	16")] long OrdMgn, [Description("현금주문증거금액	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 선물옵션 취소주문: CFOAT00300: InBlock1
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="CancQty">취소수량	long	16</param>
public record CFOAT00300InBlock1([Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("취소수량	long	16")] long CancQty);

/// <summary>
/// 선물옵션 취소주문: CFOAT00300: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="FnoOrdPtnCode">선물옵션주문유형코드	string	2</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="CancQty">취소수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="DscusBnsCmpltTime">협의매매완료시각	string	9</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="OrdSeqno">주문일련번호	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">아이템번호	long	10</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="FundId">펀드ID	string	12</param>
/// <param name="FundOrgOrdNo">펀드원주문번호	long	10</param>
/// <param name="FundOrdNo">펀드주문번호	long	10</param>
public record CFOAT00300OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("선물옵션주문유형코드	string	2")] string FnoOrdPtnCode, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("취소수량	long	16")] long CancQty, [Description("통신매체코드	string	2")] string CommdaCode, [Description("협의매매완료시각	string	9")] string DscusBnsCmpltTime, [Description("그룹ID	string	20")] string GrpId, [Description("주문일련번호	long	10")] long OrdSeqno, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("아이템번호	long	10")] long ItemNo, [Description("관리사원번호	string	9")] string MgempNo, [Description("펀드ID	string	12")] string FundId, [Description("펀드원주문번호	long	10")] long FundOrgOrdNo, [Description("펀드주문번호	long	10")] long FundOrdNo);

/// <summary>
/// 선물옵션 취소주문: CFOAT00300: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdMgn">주문증거금액	long	16</param>
/// <param name="MnyOrdMgn">현금주문증거금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CFOAT00300OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	50")] string IsuNm, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문증거금액	long	16")] long OrdMgn, [Description("현금주문증거금액	long	16")] long MnyOrdMgn, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
public record CFOBQ10500InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd);

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
public record CFOBQ10500OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd);

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="DpsamtTotamt">예탁금총액	long	16</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="SubstAmt">대용금액	long	16</param>
/// <param name="FilupDpsamtTotamt">충당예탁금총액	long	16</param>
/// <param name="FilupDps">충당예수금	long	16</param>
/// <param name="FutsPnlAmt">선물손익금액	long	16</param>
/// <param name="WthdwAbleAmt">인출가능금액	long	16</param>
/// <param name="PsnOutAbleCurAmt">인출가능현금액	long	16</param>
/// <param name="PsnOutAbleSubstAmt">인출가능대용금액	long	16</param>
/// <param name="Mgn">증거금액	long	16</param>
/// <param name="MnyMgn">현금증거금액	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="AddMgn">추가증거금액	long	16</param>
/// <param name="MnyAddMgn">현금추가증거금액	long	16</param>
/// <param name="AmtPrdayChckInAmt">금전일수표입금액	long	16</param>
/// <param name="FnoPrdaySubstSellAmt">선물옵션전일대용매도금액	long	16</param>
/// <param name="FnoCrdaySubstSellAmt">선물옵션금일대용매도금액	long	16</param>
/// <param name="FnoPrdayFdamt">선물옵션전일가입금액	long	16</param>
/// <param name="FnoCrdayFdamt">선물옵션금일가입금액	long	16</param>
/// <param name="FcurrSubstAmt">외화대용금액	long	16</param>
/// <param name="FnoAcntAfmgnNm">선물옵션계좌사후증거금명	string	20</param>
public record CFOBQ10500OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("예탁금총액	long	16")] long DpsamtTotamt, [Description("예수금	long	16")] long Dps, [Description("대용금액	long	16")] long SubstAmt, [Description("충당예탁금총액	long	16")] long FilupDpsamtTotamt, [Description("충당예수금	long	16")] long FilupDps, [Description("선물손익금액	long	16")] long FutsPnlAmt, [Description("인출가능금액	long	16")] long WthdwAbleAmt, [Description("인출가능현금액	long	16")] long PsnOutAbleCurAmt, [Description("인출가능대용금액	long	16")] long PsnOutAbleSubstAmt, [Description("증거금액	long	16")] long Mgn, [Description("현금증거금액	long	16")] long MnyMgn, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("추가증거금액	long	16")] long AddMgn, [Description("현금추가증거금액	long	16")] long MnyAddMgn, [Description("금전일수표입금액	long	16")] long AmtPrdayChckInAmt, [Description("선물옵션전일대용매도금액	long	16")] long FnoPrdaySubstSellAmt, [Description("선물옵션금일대용매도금액	long	16")] long FnoCrdaySubstSellAmt, [Description("선물옵션전일가입금액	long	16")] long FnoPrdayFdamt, [Description("선물옵션금일가입금액	long	16")] long FnoCrdayFdamt, [Description("외화대용금액	long	16")] long FcurrSubstAmt, [Description("선물옵션계좌사후증거금명	string	20")] string FnoAcntAfmgnNm);

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500: OutBlock3
/// </summary>
/// <param name="PdGrpCodeNm">상품군코드명	string	20</param>
/// <param name="NetRiskMgn">순위험증거금액	long	16</param>
/// <param name="PrcMgn">가격증거금액	long	16</param>
/// <param name="SprdMgn">스프레드증거금액	long	16</param>
/// <param name="PrcFlctMgn">가격변동증거금액	long	16</param>
/// <param name="MinMgn">최소증거금액	long	16</param>
/// <param name="OrdMgn">주문증거금액	long	16</param>
/// <param name="OptNetBuyAmt">옵션순매수금액	long	16</param>
/// <param name="CsgnMgn">위탁증거금액	long	16</param>
/// <param name="MaintMgn">유지증거금액	long	16</param>
/// <param name="FutsBuyExecAmt">선물매수체결금액	long	16</param>
/// <param name="FutsSellExecAmt">선물매도체결금액	long	16</param>
/// <param name="OptBuyExecAmt">옵션매수체결금액	long	16</param>
/// <param name="OptSellExecAmt">옵션매도체결금액	long	16</param>
/// <param name="FutsPnlAmt">선물손익금액	long	16</param>
/// <param name="TotRiskCsgnMgn">총위험위탁증거금	long	16</param>
/// <param name="UndCsgnMgn">인수도위탁증거금	long	16</param>
/// <param name="MgnRdctAmt">증거금감면금액	long	16</param>
public record CFOBQ10500OutBlock3([Description("상품군코드명	string	20")] string PdGrpCodeNm, [Description("순위험증거금액	long	16")] long NetRiskMgn, [Description("가격증거금액	long	16")] long PrcMgn, [Description("스프레드증거금액	long	16")] long SprdMgn, [Description("가격변동증거금액	long	16")] long PrcFlctMgn, [Description("최소증거금액	long	16")] long MinMgn, [Description("주문증거금액	long	16")] long OrdMgn, [Description("옵션순매수금액	long	16")] long OptNetBuyAmt, [Description("위탁증거금액	long	16")] long CsgnMgn, [Description("유지증거금액	long	16")] long MaintMgn, [Description("선물매수체결금액	long	16")] long FutsBuyExecAmt, [Description("선물매도체결금액	long	16")] long FutsSellExecAmt, [Description("옵션매수체결금액	long	16")] long OptBuyExecAmt, [Description("옵션매도체결금액	long	16")] long OptSellExecAmt, [Description("선물손익금액	long	16")] long FutsPnlAmt, [Description("총위험위탁증거금	long	16")] long TotRiskCsgnMgn, [Description("인수도위탁증거금	long	16")] long UndCsgnMgn, [Description("증거금감면금액	long	16")] long MgnRdctAmt);


/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
/// <param name="IsuSmclssCode">종목소분류코드	string	3</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="SettWklyCnt">결제주간수	string	2</param>
/// <param name="SpclDtPtnCode">특별일자유형코드	string	3</param>
public record CFOBQ10800InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("종목중분류코드	string	2")] string IsuMdclssCode, [Description("종목소분류코드	string	3")] string IsuSmclssCode, [Description("만기년월	string	6")] string DueYymm, [Description("결제주간수	string	2")] string SettWklyCnt, [Description("특별일자유형코드	string	3")] string SpclDtPtnCode);

/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
/// <param name="IsuSmclssCode">종목소분류코드	string	3</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="SettWklyCnt">결제주간수	string	2</param>
/// <param name="SpclDtPtnCode">특별일자유형코드	string	3</param>
public record CFOBQ10800OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("종목중분류코드	string	2")] string IsuMdclssCode, [Description("종목소분류코드	string	3")] string IsuSmclssCode, [Description("만기년월	string	6")] string DueYymm, [Description("결제주간수	string	2")] string SettWklyCnt, [Description("특별일자유형코드	string	3")] string SpclDtPtnCode);

/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800: OutBlock2
/// </summary>
/// <param name="ElwXrcPrc">행사가	double	13.2</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="HanglIsuNm1">한글종목명1	string	40</param>
/// <param name="TpNm1">구분명1	string	40</param>
/// <param name="UpOptRegulThrprc">상승옵션조정이론가	double	27.8</param>
/// <param name="Thrprc1">이론가1	double	19.8</param>
/// <param name="BasePrc1">기준가1	double	13.2</param>
/// <param name="OrdMgn1">주문증거금액1	long	16</param>
/// <param name="FnoIsuNo0">선물옵션종목번호0	string	12</param>
/// <param name="HanglIsuNm2">한글종목명2	string	40</param>
/// <param name="TpNm2">구분명2	string	40</param>
/// <param name="DownOptRegulThrprc">하락옵션조정이론가	double	27.8</param>
/// <param name="Thrprc2">이론가2	double	19.8</param>
/// <param name="BasePrc2">기준가2	double	13.2</param>
/// <param name="OrdMgn2">주문증거금액2	long	16</param>
public record CFOBQ10800OutBlock2([Description("행사가	double	13.2")] double ElwXrcPrc, [Description("선물옵션종목번호	string	12")] string FnoIsuNo, [Description("한글종목명1	string	40")] string HanglIsuNm1, [Description("구분명1	string	40")] string TpNm1, [Description("상승옵션조정이론가	double	27.8")] double UpOptRegulThrprc, [Description("이론가1	double	19.8")] double Thrprc1, [Description("기준가1	double	13.2")] double BasePrc1, [Description("주문증거금액1	long	16")] long OrdMgn1, [Description("선물옵션종목번호0	string	12")] string FnoIsuNo0, [Description("한글종목명2	string	40")] string HanglIsuNm2, [Description("구분명2	string	40")] string TpNm2, [Description("하락옵션조정이론가	double	27.8")] double DownOptRegulThrprc, [Description("이론가2	double	19.8")] double Thrprc2, [Description("기준가2	double	13.2")] double BasePrc2, [Description("주문증거금액2	long	16")] long OrdMgn2);


/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BnsDt">매매일	string	8</param>
public record CFOEQ11100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("매매일	string	8")] string BnsDt);

/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BnsDt">매매일	string	8</param>
public record CFOEQ11100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("매매일	string	8")] string BnsDt);

/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="OpnmkDpsamtTotamt">개장시예탁금총액	long	16</param>
/// <param name="OpnmkDps">개장시예수금	long	16</param>
/// <param name="OpnmkMnyrclAmt">개장시현금미수금	long	16</param>
/// <param name="OpnmkSubstAmt">개장시대용금액	long	16</param>
/// <param name="TotAmt">총금액	long	16</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="MnyrclAmt">현금미수금액	long	16</param>
/// <param name="SubstDsgnAmt">대용지정금액	long	16</param>
/// <param name="CsgnMgn">위탁증거금액	long	16</param>
/// <param name="MnyCsgnMgn">현금위탁증거금액	long	16</param>
/// <param name="MaintMgn">유지증거금액	long	16</param>
/// <param name="MnyMaintMgn">현금유지증거금액	long	16</param>
/// <param name="OutAbleAmt">출금가능총액	long	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	long	16</param>
/// <param name="SubstOutAbleAmt">출금가능대용	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="AddMgnOcrTpCode">추가증거금구분	string	1</param>
/// <param name="AddMgn">추가증거금액	long	16</param>
/// <param name="MnyAddMgn">현금추가증거금액	long	16</param>
/// <param name="NtdayTotAmt">익일예탁총액	long	16</param>
/// <param name="NtdayDps">익일예탁현금	long	16</param>
/// <param name="NtdayMnyrclAmt">익일미수금	long	16</param>
/// <param name="NtdaySubstAmt">익일예탁대용	long	16</param>
/// <param name="NtdayCsgnMgn">익일위탁증거금	long	16</param>
/// <param name="NtdayMnyCsgnMgn">익일위탁증거금현금	long	16</param>
/// <param name="NtdayMaintMgn">익일유지증거금	long	16</param>
/// <param name="NtdayMnyMaintMgn">익일유지증거금현금	long	16</param>
/// <param name="NtdayOutAbleAmt">익일인출가능금액	long	16</param>
/// <param name="NtdayMnyoutAbleAmt">익일인출가능금액	long	16</param>
/// <param name="NtdaySubstOutAbleAmt">익일인출가능대용	long	16</param>
/// <param name="NtdayOrdAbleAmt">익일주문가능금액	long	16</param>
/// <param name="NtdayMnyOrdAbleAmt">익일주문가능현금	long	16</param>
/// <param name="NtdayAddMgnTp">익일추가증거금구분	string	1</param>
/// <param name="NtdayAddMgn">익일추가증거금	long	16</param>
/// <param name="NtdayMnyAddMgn">익일추가증거금현금	long	16</param>
/// <param name="NtdaySettAmt">익일결제금액	long	16</param>
/// <param name="EvalDpsamtTotamt">평가예탁금총액	long	15</param>
/// <param name="MnyEvalDpstgAmt">현금평가예탁금액	long	15</param>
/// <param name="DpsamtUtlfeeGivPrergAmt">예탁금이용료지급예정금액	long	16</param>
/// <param name="TaxAmt">세금	long	16</param>
/// <param name="CsgnMgnrat">위탁증거금 비율	double	7.2</param>
/// <param name="CsgnMnyMgnrat">위탁증거금현금비율	double	7.2</param>
/// <param name="DpstgTotamtLackAmt">예탁총액부족금액(위탁증거금기준)	long	16</param>
/// <param name="DpstgMnyLackAmt">예탁현금부족금액(위탁증거금기준)	long	16</param>
/// <param name="RealInAmt">실입금액	long	16</param>
/// <param name="InAmt">입금액	long	16</param>
/// <param name="OutAmt">출금액	long	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="FutsThdayDfamt">선물당일차금	long	16</param>
/// <param name="FutsUpdtDfamt">선물갱신차금	long	16</param>
/// <param name="FutsLastSettDfamt">선물최종결제차금	long	16</param>
/// <param name="OptSettDfamt">옵션결제차금	long	16</param>
/// <param name="OptBuyAmt">옵션매수금액	long	16</param>
/// <param name="OptSellAmt">옵션매도금액	long	16</param>
/// <param name="OptXrcDfamt">옵션행사차금	long	16</param>
/// <param name="OptAsgnDfamt">옵션배정차금	long	16</param>
/// <param name="RealGdsUndAmt">실물인수도금액	long	16</param>
/// <param name="RealGdsUndAsgnAmt">실물인수도배정대금	long	16</param>
/// <param name="RealGdsUndXrcAmt">실물인수도행사대금	long	16</param>
/// <param name="CmsnAmt">수수료	long	16</param>
/// <param name="FutsCmsn">선물수수료	long	16</param>
/// <param name="OptCmsn">옵션수수료	long	16</param>
/// <param name="FutsCtrctQty">선물약정수량	long	16</param>
/// <param name="FutsCtrctAmt">선물약정금액	long	16</param>
/// <param name="OptCtrctQty">옵션약정수량	long	16</param>
/// <param name="OptCtrctAmt">옵션약정금액	long	16</param>
/// <param name="FutsUnsttQty">선물미결제수량	long	16</param>
/// <param name="FutsUnsttAmt">선물미결제금액	long	16</param>
/// <param name="OptUnsttQty">옵션미결제수량	long	16</param>
/// <param name="OptUnsttAmt">옵션미결제금액	long	16</param>
/// <param name="FutsBuyUnsttQty">선물매수미결제수량	long	16</param>
/// <param name="FutsBuyUnsttAmt">선물매수미결제금액	long	16</param>
/// <param name="FutsSellUnsttQty">선물매도미결제수량	long	16</param>
/// <param name="FutsSellUnsttAmt">선물매도미결제금액	long	16</param>
/// <param name="OptBuyUnsttQty">옵션매수미결제수량	long	16</param>
/// <param name="OptBuyUnsttAmt">옵션매수미결제금액	long	16</param>
/// <param name="OptSellUnsttQty">옵션매도미결제수량	long	16</param>
/// <param name="OptSellUnsttAmt">옵션매도미결제금액	long	16</param>
/// <param name="FutsBuyctrQty">선물매수약정수량	long	16</param>
/// <param name="FutsBuyctrAmt">선물매수약정금액	long	16</param>
/// <param name="FutsSlctrQty">선물매도약정수량	long	16</param>
/// <param name="FutsSlctrAmt">선물매도약정금액	long	16</param>
/// <param name="OptBuyctrQty">옵션매수약정수량	long	16</param>
/// <param name="OptBuyctrAmt">옵션매수약정금액	long	16</param>
/// <param name="OptSlctrQty">옵션매도약정수량	long	16</param>
/// <param name="OptSlctrAmt">옵션매도약정금액	long	16</param>
/// <param name="FutsBnsplAmt">선물매매손익금액	long	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	long	16</param>
/// <param name="FutsEvalPnlAmt">선물평가손익금액	long	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	long	16</param>
/// <param name="FutsEvalAmt">선물평가금액	long	16</param>
/// <param name="OptEvalAmt">옵션평가금액	long	16</param>
/// <param name="MktEndAfMnyInAmt">장종료후현금입금금액	long	16</param>
/// <param name="MktEndAfMnyOutAmt">장종료후현금출금금액	long	16</param>
/// <param name="MktEndAfSubstDsgnAmt">장종료후대용지정금액	long	16</param>
/// <param name="MktEndAfSubstAbndAmt">장종료후대용해지금액	long	16</param>
public record CFOEQ11100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("개장시예탁금총액	long	16")] long OpnmkDpsamtTotamt, [Description("개장시예수금	long	16")] long OpnmkDps, [Description("개장시현금미수금	long	16")] long OpnmkMnyrclAmt, [Description("개장시대용금액	long	16")] long OpnmkSubstAmt, [Description("총금액	long	16")] long TotAmt, [Description("예수금	long	16")] long Dps, [Description("현금미수금액	long	16")] long MnyrclAmt, [Description("대용지정금액	long	16")] long SubstDsgnAmt, [Description("위탁증거금액	long	16")] long CsgnMgn, [Description("현금위탁증거금액	long	16")] long MnyCsgnMgn, [Description("유지증거금액	long	16")] long MaintMgn, [Description("현금유지증거금액	long	16")] long MnyMaintMgn, [Description("출금가능총액	long	16")] long OutAbleAmt, [Description("출금가능금액	long	16")] long MnyoutAbleAmt, [Description("출금가능대용	long	16")] long SubstOutAbleAmt, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("추가증거금구분	string	1")] string AddMgnOcrTpCode, [Description("추가증거금액	long	16")] long AddMgn, [Description("현금추가증거금액	long	16")] long MnyAddMgn, [Description("익일예탁총액	long	16")] long NtdayTotAmt, [Description("익일예탁현금	long	16")] long NtdayDps, [Description("익일미수금	long	16")] long NtdayMnyrclAmt, [Description("익일예탁대용	long	16")] long NtdaySubstAmt, [Description("익일위탁증거금	long	16")] long NtdayCsgnMgn, [Description("익일위탁증거금현금	long	16")] long NtdayMnyCsgnMgn, [Description("익일유지증거금	long	16")] long NtdayMaintMgn, [Description("익일유지증거금현금	long	16")] long NtdayMnyMaintMgn, [Description("익일인출가능금액	long	16")] long NtdayOutAbleAmt, [Description("익일인출가능금액	long	16")] long NtdayMnyoutAbleAmt, [Description("익일인출가능대용	long	16")] long NtdaySubstOutAbleAmt, [Description("익일주문가능금액	long	16")] long NtdayOrdAbleAmt, [Description("익일주문가능현금	long	16")] long NtdayMnyOrdAbleAmt, [Description("익일추가증거금구분	string	1")] string NtdayAddMgnTp, [Description("익일추가증거금	long	16")] long NtdayAddMgn, [Description("익일추가증거금현금	long	16")] long NtdayMnyAddMgn, [Description("익일결제금액	long	16")] long NtdaySettAmt, [Description("평가예탁금총액	long	15")] long EvalDpsamtTotamt, [Description("현금평가예탁금액	long	15")] long MnyEvalDpstgAmt, [Description("예탁금이용료지급예정금액	long	16")] long DpsamtUtlfeeGivPrergAmt, [Description("세금	long	16")] long TaxAmt, [Description("위탁증거금 비율	double	7.2")] double CsgnMgnrat, [Description("위탁증거금현금비율	double	7.2")] double CsgnMnyMgnrat, [Description("예탁총액부족금액(위탁증거금기준)	long	16")] long DpstgTotamtLackAmt, [Description("예탁현금부족금액(위탁증거금기준)	long	16")] long DpstgMnyLackAmt, [Description("실입금액	long	16")] long RealInAmt, [Description("입금액	long	16")] long InAmt, [Description("출금액	long	16")] long OutAmt, [Description("선물정산차금	long	16")] long FutsAdjstDfamt, [Description("선물당일차금	long	16")] long FutsThdayDfamt, [Description("선물갱신차금	long	16")] long FutsUpdtDfamt, [Description("선물최종결제차금	long	16")] long FutsLastSettDfamt, [Description("옵션결제차금	long	16")] long OptSettDfamt, [Description("옵션매수금액	long	16")] long OptBuyAmt, [Description("옵션매도금액	long	16")] long OptSellAmt, [Description("옵션행사차금	long	16")] long OptXrcDfamt, [Description("옵션배정차금	long	16")] long OptAsgnDfamt, [Description("실물인수도금액	long	16")] long RealGdsUndAmt, [Description("실물인수도배정대금	long	16")] long RealGdsUndAsgnAmt, [Description("실물인수도행사대금	long	16")] long RealGdsUndXrcAmt, [Description("수수료	long	16")] long CmsnAmt, [Description("선물수수료	long	16")] long FutsCmsn, [Description("옵션수수료	long	16")] long OptCmsn, [Description("선물약정수량	long	16")] long FutsCtrctQty, [Description("선물약정금액	long	16")] long FutsCtrctAmt, [Description("옵션약정수량	long	16")] long OptCtrctQty, [Description("옵션약정금액	long	16")] long OptCtrctAmt, [Description("선물미결제수량	long	16")] long FutsUnsttQty, [Description("선물미결제금액	long	16")] long FutsUnsttAmt, [Description("옵션미결제수량	long	16")] long OptUnsttQty, [Description("옵션미결제금액	long	16")] long OptUnsttAmt, [Description("선물매수미결제수량	long	16")] long FutsBuyUnsttQty, [Description("선물매수미결제금액	long	16")] long FutsBuyUnsttAmt, [Description("선물매도미결제수량	long	16")] long FutsSellUnsttQty, [Description("선물매도미결제금액	long	16")] long FutsSellUnsttAmt, [Description("옵션매수미결제수량	long	16")] long OptBuyUnsttQty, [Description("옵션매수미결제금액	long	16")] long OptBuyUnsttAmt, [Description("옵션매도미결제수량	long	16")] long OptSellUnsttQty, [Description("옵션매도미결제금액	long	16")] long OptSellUnsttAmt, [Description("선물매수약정수량	long	16")] long FutsBuyctrQty, [Description("선물매수약정금액	long	16")] long FutsBuyctrAmt, [Description("선물매도약정수량	long	16")] long FutsSlctrQty, [Description("선물매도약정금액	long	16")] long FutsSlctrAmt, [Description("옵션매수약정수량	long	16")] long OptBuyctrQty, [Description("옵션매수약정금액	long	16")] long OptBuyctrAmt, [Description("옵션매도약정수량	long	16")] long OptSlctrQty, [Description("옵션매도약정금액	long	16")] long OptSlctrAmt, [Description("선물매매손익금액	long	16")] long FutsBnsplAmt, [Description("옵션매매손익금액	long	16")] long OptBnsplAmt, [Description("선물평가손익금액	long	16")] long FutsEvalPnlAmt, [Description("옵션평가손익금액	long	16")] long OptEvalPnlAmt, [Description("선물평가금액	long	16")] long FutsEvalAmt, [Description("옵션평가금액	long	16")] long OptEvalAmt, [Description("장종료후현금입금금액	long	16")] long MktEndAfMnyInAmt, [Description("장종료후현금출금금액	long	16")] long MktEndAfMnyOutAmt, [Description("장종료후대용지정금액	long	16")] long MktEndAfSubstDsgnAmt, [Description("장종료후대용해지금액	long	16")] long MktEndAfSubstAbndAmt);


/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	string	1</param>
public record CFOEQ82600InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("조회구분	string	1")] string QryTp, [Description("정렬순서구분	string	1")] string StnlnSeqTp, [Description("선물옵션잔고평가구분코드	string	1")] string FnoBalEvalTpCode);

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	string	1</param>
public record CFOEQ82600OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("조회구분	string	1")] string QryTp, [Description("정렬순서구분	string	1")] string StnlnSeqTp, [Description("선물옵션잔고평가구분코드	string	1")] string FnoBalEvalTpCode);

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	long	16</param>
/// <param name="FnoCmsnAmt">선물옵션수수료	long	16</param>
/// <param name="PnlSumAmt">손익합계금액	long	16</param>
/// <param name="MnyinSumAmt">입금합계금액	long	16</param>
/// <param name="MnyoutSumAmt">출금합계금액	long	16</param>
/// <param name="AcntNm">계좌명	string	40</param>
public record CFOEQ82600OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("선물정산차금	long	16")] long FutsAdjstDfamt, [Description("옵션매매손익금액	long	16")] long OptBnsplAmt, [Description("선물옵션수수료	long	16")] long FnoCmsnAmt, [Description("손익합계금액	long	16")] long PnlSumAmt, [Description("입금합계금액	long	16")] long MnyinSumAmt, [Description("출금합계금액	long	16")] long MnyoutSumAmt, [Description("계좌명	string	40")] string AcntNm);

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600: OutBlock3
/// </summary>
/// <param name="QryDt">조회일	string	8</param>
/// <param name="DpstgTotamt">예탁총액	long	16</param>
/// <param name="DpstgMny">예탁현금	long	16</param>
/// <param name="FnoMgn">선물옵션증거금액	long	16</param>
/// <param name="FutsPnlAmt">선물손익금액	long	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	long	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	long	16</param>
/// <param name="CmsnAmt">수수료	long	16</param>
/// <param name="SumAmt1">합계금액1	long	16</param>
/// <param name="SumAmt2">합계금액	long	16</param>
/// <param name="PnlSumAmt">손익합계금액	long	16</param>
/// <param name="FutsBuyAmt">선물매수금액	long	16</param>
/// <param name="FutsSellAmt">선물매도금액	long	16</param>
/// <param name="OptBuyAmt">옵션매수금액	long	16</param>
/// <param name="OptSellAmt">옵션매도금액	long	16</param>
/// <param name="InAmt">입금액	long	16</param>
/// <param name="OutAmt">출금액	long	16</param>
/// <param name="EvalAmt">평가금액	long	16</param>
/// <param name="AddupEvalAmt">합산평가금액	long	16</param>
/// <param name="Amt2">금액2	long	16</param>
public record CFOEQ82600OutBlock3([Description("조회일	string	8")] string QryDt, [Description("예탁총액	long	16")] long DpstgTotamt, [Description("예탁현금	long	16")] long DpstgMny, [Description("선물옵션증거금액	long	16")] long FnoMgn, [Description("선물손익금액	long	16")] long FutsPnlAmt, [Description("옵션매매손익금액	long	16")] long OptBsnPnlAmt, [Description("옵션평가손익금액	long	16")] long OptEvalPnlAmt, [Description("수수료	long	16")] long CmsnAmt, [Description("합계금액1	long	16")] long SumAmt1, [Description("합계금액	long	16")] long SumAmt2, [Description("손익합계금액	long	16")] long PnlSumAmt, [Description("선물매수금액	long	16")] long FutsBuyAmt, [Description("선물매도금액	long	16")] long FutsSellAmt, [Description("옵션매수금액	long	16")] long OptBuyAmt, [Description("옵션매도금액	long	16")] long OptSellAmt, [Description("입금액	long	16")] long InAmt, [Description("출금액	long	16")] long OutAmt, [Description("평가금액	long	16")] long EvalAmt, [Description("합산평가금액	long	16")] long AddupEvalAmt, [Description("금액2	long	16")] long Amt2);


/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="RegMktCode">등록시장코드	string	2</param>
/// <param name="BuyDt">매수일자	string	8</param>
public record CFOFQ02400InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("등록시장코드	string	2")] string RegMktCode, [Description("매수일자	string	8")] string BuyDt);

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="RegMktCode">등록시장코드	string	2</param>
/// <param name="BuyDt">매수일자	string	8</param>
public record CFOFQ02400OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("등록시장코드	string	2")] string RegMktCode, [Description("매수일자	string	8")] string BuyDt);

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="FutsCtrctQty">선물약정수량	long	16</param>
/// <param name="OptCtrctQty">옵션약정수량	long	16</param>
/// <param name="CtrctQty">약정수량	long	16</param>
/// <param name="FutsCtrctAmt">선물약정금액	long	16</param>
/// <param name="FutsBuyctrAmt">선물매수약정금액	long	16</param>
/// <param name="FutsSlctrAmt">선물매도약정금액	long	16</param>
/// <param name="CalloptCtrctAmt">콜옵션약정금액	long	16</param>
/// <param name="CallBuyAmt">콜매수금액	long	16</param>
/// <param name="CallSellAmt">콜매도금액	long	16</param>
/// <param name="PutoptCtrctAmt">풋옵션약정금액	long	16</param>
/// <param name="PutBuyAmt">풋매수금액	long	16</param>
/// <param name="PutSellAmt">풋매도금액	long	16</param>
/// <param name="AllCtrctAmt">전체약정금액	long	16</param>
/// <param name="BuyctrAsmAmt">매수약정누계금액	long	16</param>
/// <param name="SlctrAsmAmt">매도약정누계금액	long	16</param>
/// <param name="FutsPnlSum">선물손익합계	long	16</param>
/// <param name="OptPnlSum">옵션손익합계	long	16</param>
/// <param name="AllPnlSum">전체손익합계	long	16</param>
public record CFOFQ02400OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("선물약정수량	long	16")] long FutsCtrctQty, [Description("옵션약정수량	long	16")] long OptCtrctQty, [Description("약정수량	long	16")] long CtrctQty, [Description("선물약정금액	long	16")] long FutsCtrctAmt, [Description("선물매수약정금액	long	16")] long FutsBuyctrAmt, [Description("선물매도약정금액	long	16")] long FutsSlctrAmt, [Description("콜옵션약정금액	long	16")] long CalloptCtrctAmt, [Description("콜매수금액	long	16")] long CallBuyAmt, [Description("콜매도금액	long	16")] long CallSellAmt, [Description("풋옵션약정금액	long	16")] long PutoptCtrctAmt, [Description("풋매수금액	long	16")] long PutBuyAmt, [Description("풋매도금액	long	16")] long PutSellAmt, [Description("전체약정금액	long	16")] long AllCtrctAmt, [Description("매수약정누계금액	long	16")] long BuyctrAsmAmt, [Description("매도약정누계금액	long	16")] long SlctrAsmAmt, [Description("선물손익합계	long	16")] long FutsPnlSum, [Description("옵션손익합계	long	16")] long OptPnlSum, [Description("전체손익합계	long	16")] long AllPnlSum);

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400: OutBlock3
/// </summary>
/// <param name="FnoClssCode">선물옵션품목구분	string	1</param>
/// <param name="FutsSellQty">선물매도수량	long	16</param>
/// <param name="FutsSellPnl">선물매도손익	long	16</param>
/// <param name="FutsBuyQty">선물매수수량	long	16</param>
/// <param name="FutsBuyPnl">선물매수손익	long	16</param>
/// <param name="CallSellQty">콜매도수량	long	16</param>
/// <param name="CallSellPnl">콜매도손익	long	16</param>
/// <param name="CallBuyQty">콜매수수량	long	16</param>
/// <param name="CallBuyPnl">콜매수손익	long	16</param>
/// <param name="PutSellQty">풋매도수량	long	16</param>
/// <param name="PutSellPnl">풋매도손익	long	16</param>
/// <param name="PutBuyQty">풋매수수량	long	16</param>
/// <param name="PutBuyPnl">풋매수손익	long	16</param>
public record CFOFQ02400OutBlock3([Description("선물옵션품목구분	string	1")] string FnoClssCode, [Description("선물매도수량	long	16")] long FutsSellQty, [Description("선물매도손익	long	16")] long FutsSellPnl, [Description("선물매수수량	long	16")] long FutsBuyQty, [Description("선물매수손익	long	16")] long FutsBuyPnl, [Description("콜매도수량	long	16")] long CallSellQty, [Description("콜매도손익	long	16")] long CallSellPnl, [Description("콜매수수량	long	16")] long CallBuyQty, [Description("콜매수손익	long	16")] long CallBuyPnl, [Description("풋매도수량	long	16")] long PutSellQty, [Description("풋매도손익	long	16")] long PutSellPnl, [Description("풋매수수량	long	16")] long PutBuyQty, [Description("풋매수손익	long	16")] long PutBuyPnl);

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400: OutBlock4
/// </summary>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="BalQty">잔고수량	long	16</param>
/// <param name="FnoAvrPrc">평균가	double	19.8</param>
/// <param name="BgnAmt">당초금액	long	16</param>
/// <param name="ThdayLqdtQty">당일청산수량	long	16</param>
/// <param name="Curprc">현재가	double	13.2</param>
/// <param name="EvalAmt">평가금액	long	16</param>
/// <param name="EvalPnlAmt">평가손익금액	long	16</param>
/// <param name="EvalErnrat">평가수익률	double	12.6</param>
public record CFOFQ02400OutBlock4([Description("종목번호	string	12")] string IsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("매매구분	string	10")] string BnsTpNm, [Description("잔고수량	long	16")] long BalQty, [Description("평균가	double	19.8")] double FnoAvrPrc, [Description("당초금액	long	16")] long BgnAmt, [Description("당일청산수량	long	16")] long ThdayLqdtQty, [Description("현재가	double	13.2")] double Curprc, [Description("평가금액	long	16")] long EvalAmt, [Description("평가손익금액	long	16")] long EvalPnlAmt, [Description("평가수익률	double	12.6")] double EvalErnrat);


/// <summary>
/// 챠트엑셀데이터조회: CHARTEXCEL
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="indexname">지표명	string	40</param>
/// <param name="indexparam">지표조건설정	string	40</param>
/// <param name="indexouttype">결과데이터 구분	string	1</param>
/// <param name="market">시장구분	string	1</param>
/// <param name="period">주기구분	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="isexcelout">결과 지표데이터 엑셀표시 여부	string	1</param>
/// <param name="excelfilename">엑셀데이터 파일명	string	256</param>
/// <param name="IsReal">실시간 데이터수신 자동등록 여부	string	1</param>
public record ChartExcelInBlock([Description("지표ID	long	10")] long indexid, [Description("지표명	string	40")] string indexname, [Description("지표조건설정	string	40")] string indexparam, [Description("결과데이터 구분	string	1")] string indexouttype, [Description("시장구분	string	1")] string market, [Description("주기구분	string	1")] string period, [Description("단축코드	string	8")] string shcode, [Description("결과 지표데이터 엑셀표시 여부	string	1")] string isexcelout, [Description("엑셀데이터 파일명	string	256")] string excelfilename, [Description("실시간 데이터수신 자동등록 여부	string	1")] string IsReal);

/// <summary>
/// 챠트엑셀데이터조회: CHARTEXCEL
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="rec_cnt">레코드갯수	int	5</param>
/// <param name="validdata_cnt">유효 데이터 컬럼 갯수	int	2</param>
public record ChartExcelOutBlock([Description("지표ID	long	10")] long indexid, [Description("레코드갯수	int	5")] int rec_cnt, [Description("유효 데이터 컬럼 갯수	int	2")] int validdata_cnt);

/// <summary>
/// 챠트엑셀데이터조회: CHARTEXCEL
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	10</param>
/// <param name="high">고가	double	10</param>
/// <param name="low">저가	double	10</param>
/// <param name="close">종가	double	10</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="value1">지표값1	double	10</param>
/// <param name="value2">지표값2	double	10</param>
/// <param name="value3">지표값3	double	10</param>
/// <param name="value4">지표값4	double	10</param>
/// <param name="value5">지표값5	double	10</param>
/// <param name="pos">위치	int	8</param>
public record ChartExcelOutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	10")] double open, [Description("고가	double	10")] double high, [Description("저가	double	10")] double low, [Description("종가	double	10")] double close, [Description("거래량	double	12")] double volume, [Description("지표값1	double	10")] double value1, [Description("지표값2	double	10")] double value2, [Description("지표값3	double	10")] double value3, [Description("지표값4	double	10")] double value4, [Description("지표값5	double	10")] double value5, [Description("위치	int	8")] int pos);


/// <summary>
/// 챠트지표데이터조회: CHARTINDEX
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="indexname">지표명	string	40</param>
/// <param name="indexparam">지표조건설정	string	40</param>
/// <param name="market">시장구분	string	1</param>
/// <param name="period">주기구분	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="qrycnt">요청건수(최대 500개)	int	4</param>
/// <param name="ncnt">단위(n틱/n분)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="Isamend">수정주가 반영 여부	string	1</param>
/// <param name="Isgab">갭보정 여부	string	1</param>
/// <param name="IsReal">실시간 데이터수신 자동등록 여부	string	1</param>
public record ChartIndexInBlock([Description("지표ID	long	10")] long indexid, [Description("지표명	string	40")] string indexname, [Description("지표조건설정	string	40")] string indexparam, [Description("시장구분	string	1")] string market, [Description("주기구분	string	1")] string period, [Description("단축코드	string	8")] string shcode, [Description("요청건수(최대 500개)	int	4")] int qrycnt, [Description("단위(n틱/n분)	int	4")] int ncnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("수정주가 반영 여부	string	1")] string Isamend, [Description("갭보정 여부	string	1")] string Isgab, [Description("실시간 데이터수신 자동등록 여부	string	1")] string IsReal);

/// <summary>
/// 챠트지표데이터조회: CHARTINDEX
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="rec_cnt">레코드갯수	int	5</param>
/// <param name="validdata_cnt">유효 데이터 컬럼 갯수	int	2</param>
public record ChartIndexOutBlock([Description("지표ID	long	10")] long indexid, [Description("레코드갯수	int	5")] int rec_cnt, [Description("유효 데이터 컬럼 갯수	int	2")] int validdata_cnt);

/// <summary>
/// 챠트지표데이터조회: CHARTINDEX
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	10</param>
/// <param name="high">고가	double	10</param>
/// <param name="low">저가	double	10</param>
/// <param name="close">종가	double	10</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="value1">지표값1	double	10</param>
/// <param name="value2">지표값2	double	10</param>
/// <param name="value3">지표값3	double	10</param>
/// <param name="value4">지표값4	double	10</param>
/// <param name="value5">지표값5	double	10</param>
/// <param name="pos">위치	int	8</param>
public record ChartIndexOutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	10")] double open, [Description("고가	double	10")] double high, [Description("저가	double	10")] double low, [Description("종가	double	10")] double close, [Description("거래량	double	12")] double volume, [Description("지표값1	double	10")] double value1, [Description("지표값2	double	10")] double value2, [Description("지표값3	double	10")] double value3, [Description("지표값4	double	10")] double value4, [Description("지표값5	double	10")] double value5, [Description("위치	int	8")] int pos);


/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
public record CIDBQ01400InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분코드	string	1")] string QryTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode);

/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
public record CIDBQ01400OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분코드	string	1")] string QryTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode);

/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CIDBQ01400OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문가능수량	long	16")] long OrdAbleQty);


/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryDt">조회일자	string	8</param>
/// <param name="BalTpCode">잔고구분코드	string	1</param>
public record CIDBQ01500InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌구분코드	string	1")] string AcntTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회일자	string	8")] string QryDt, [Description("잔고구분코드	string	1")] string BalTpCode);

/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryDt">조회일자	string	8</param>
/// <param name="BalTpCode">잔고구분코드	string	1</param>
public record CIDBQ01500OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌구분코드	string	1")] string AcntTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회일자	string	8")] string QryDt, [Description("잔고구분코드	string	1")] string BalTpCode);

/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500: OutBlock2
/// </summary>
/// <param name="BaseDt">기준일자	string	8</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="LpnlAmt">청산손익금액	double	19.2</param>
/// <param name="FutsDueBfLpnlAmt">선물만기전청산손익금액	double	23.2</param>
/// <param name="FutsDueBfCmsn">선물만기전수수료	double	23.2</param>
/// <param name="CsgnMgn">위탁증거금액	long	16</param>
/// <param name="MaintMgn">유지증거금	long	16</param>
/// <param name="CtlmtAmt">신용한도금액	double	23.2</param>
/// <param name="AddMgn">추가증거금액	long	16</param>
/// <param name="MgnclRat">마진콜율	double	27.1</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="WthdwAbleAmt">인출가능금액	long	16</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="CrcyCodeVal">통화코드값	string	3</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	string	10</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	string	1</param>
/// <param name="DueDt">만기일자	string	8</param>
/// <param name="OvrsDrvtXrcPrc">해외파생행사가격	double	30.11</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="CmnCodeNm">공통코드명	string	100</param>
/// <param name="TpCodeNm">구분코드명	string	50</param>
/// <param name="BalQty">잔고수량	long	16</param>
/// <param name="PchsPrc">매입가격	double	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	double	30.11</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	double	19.2</param>
/// <param name="CsgnCmsn">위탁수수료	double	19.2</param>
/// <param name="PosNo">포지션번호	string	13</param>
/// <param name="EufOneCmsnAmt">거래소비용1수수료금액	double	19.2</param>
/// <param name="EufTwoCmsnAmt">거래소비용2수수료금액	double	19.2</param>
public record CIDBQ01500OutBlock2([Description("기준일자	string	8")] string BaseDt, [Description("예수금	long	16")] long Dps, [Description("청산손익금액	double	19.2")] double LpnlAmt, [Description("선물만기전청산손익금액	double	23.2")] double FutsDueBfLpnlAmt, [Description("선물만기전수수료	double	23.2")] double FutsDueBfCmsn, [Description("위탁증거금액	long	16")] long CsgnMgn, [Description("유지증거금	long	16")] long MaintMgn, [Description("신용한도금액	double	23.2")] double CtlmtAmt, [Description("추가증거금액	long	16")] long AddMgn, [Description("마진콜율	double	27.1")] double MgnclRat, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("인출가능금액	long	16")] long WthdwAbleAmt, [Description("계좌번호	string	20")] string AcntNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("종목명	string	50")] string IsuNm, [Description("통화코드값	string	3")] string CrcyCodeVal, [Description("해외파생상품코드	string	10")] string OvrsDrvtPrdtCode, [Description("해외파생옵션구분코드	string	1")] string OvrsDrvtOptTpCode, [Description("만기일자	string	8")] string DueDt, [Description("해외파생행사가격	double	30.11")] double OvrsDrvtXrcPrc, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("공통코드명	string	100")] string CmnCodeNm, [Description("구분코드명	string	50")] string TpCodeNm, [Description("잔고수량	long	16")] long BalQty, [Description("매입가격	double	30.11")] double PchsPrc, [Description("해외파생현재가	double	30.11")] double OvrsDrvtNowPrc, [Description("해외선물평가손익금액	double	19.2")] double AbrdFutsEvalPnlAmt, [Description("위탁수수료	double	19.2")] double CsgnCmsn, [Description("포지션번호	string	13")] string PosNo, [Description("거래소비용1수수료금액	double	19.2")] double EufOneCmsnAmt, [Description("거래소비용2수수료금액	double	19.2")] double EufTwoCmsnAmt);


/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="ThdayTpCode">당일구분코드	string	1</param>
/// <param name="OrdStatCode">주문상태코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	string	1</param>
public record CIDBQ01800InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("주문일자	string	8")] string OrdDt, [Description("당일구분코드	string	1")] string ThdayTpCode, [Description("주문상태코드	string	1")] string OrdStatCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("조회구분코드	string	1")] string QryTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("해외파생선물옵션구분코드	string	1")] string OvrsDrvtFnoTpCode);

/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="ThdayTpCode">당일구분코드	string	1</param>
/// <param name="OrdStatCode">주문상태코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	string	1</param>
public record CIDBQ01800OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("주문일자	string	8")] string OrdDt, [Description("당일구분코드	string	1")] string ThdayTpCode, [Description("주문상태코드	string	1")] string OrdStatCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("조회구분코드	string	1")] string QryTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("해외파생선물옵션구분코드	string	1")] string OvrsDrvtFnoTpCode);

/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800: OutBlock2
/// </summary>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="FcmOrdNo">FCM주문번호	string	15</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="AbrdFutsXrcPrc">해외선물행사가격	double	30.11</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="BnsTpNm">매매구분명	string	10</param>
/// <param name="FutsOrdStatCode">선물주문상태코드	string	1</param>
/// <param name="TpCodeNm">구분코드명	string	50</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="TrdTpNm">거래구분명	string	20</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
/// <param name="OrdPtnNm">주문유형명	string	40</param>
/// <param name="OrdPtnTermTpCode">주문유형기간구분코드	string	2</param>
/// <param name="CmnCodeNm">공통코드명	string	100</param>
/// <param name="AppSrtDt">적용시작일자	string	8</param>
/// <param name="AppEndDt">적용종료일자	string	8</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OvrsDrvtExecIsuCode">해외파생체결종목코드	string	30</param>
/// <param name="ExecIsuNm">체결종목명	string	50</param>
/// <param name="ExecBnsTpCode">체결매매구분코드	string	1</param>
/// <param name="ExecBnsTpNm">체결매매구분명	string	10</param>
/// <param name="AbrdFutsExecPrc">해외선물체결가격	double	30.11</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="OrdCndiPrc">주문조건가격	double	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	double	30.11</param>
/// <param name="MdfyQty">정정수량	long	16</param>
/// <param name="CancQty">취소수량	long	16</param>
/// <param name="RjtQty">거부수량	long	13</param>
/// <param name="CnfQty">확인수량	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="CvrgYn">반대매매여부	string	1</param>
/// <param name="RegTmnlNo">등록단말번호	string	3</param>
/// <param name="RegBrnNo">등록지점번호	string	3</param>
/// <param name="RegUserId">등록사용자ID	string	16</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="OvrsOptXrcRsvTpCode">해외옵션행사예약구분코드	string	1</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	string	1</param>
/// <param name="SprdBaseIsuYn">스프레드기준종목여부	string	1</param>
/// <param name="OvrsFutsOrdDt">해외선물주문일자	string	8</param>
/// <param name="OvrsFutsOrdNo2">해외선물주문번호2	string	10</param>
/// <param name="OvrsFutsOrgOrdNo2">해외선물원주문번호2	string	10</param>
/// <param name="OvrsDrvtIsuCode2">해외파생종목코드2	string	30</param>
public record CIDBQ01800OutBlock2([Description("해외선물주문번호	string	10")] string OvrsFutsOrdNo, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("FCM주문번호	string	15")] string FcmOrdNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("종목명	string	50")] string IsuNm, [Description("해외선물행사가격	double	30.11")] double AbrdFutsXrcPrc, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("매매구분명	string	10")] string BnsTpNm, [Description("선물주문상태코드	string	1")] string FutsOrdStatCode, [Description("구분코드명	string	50")] string TpCodeNm, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("거래구분명	string	20")] string TrdTpNm, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode, [Description("주문유형명	string	40")] string OrdPtnNm, [Description("주문유형기간구분코드	string	2")] string OrdPtnTermTpCode, [Description("공통코드명	string	100")] string CmnCodeNm, [Description("적용시작일자	string	8")] string AppSrtDt, [Description("적용종료일자	string	8")] string AppEndDt, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("해외파생체결종목코드	string	30")] string OvrsDrvtExecIsuCode, [Description("체결종목명	string	50")] string ExecIsuNm, [Description("체결매매구분코드	string	1")] string ExecBnsTpCode, [Description("체결매매구분명	string	10")] string ExecBnsTpNm, [Description("해외선물체결가격	double	30.11")] double AbrdFutsExecPrc, [Description("체결수량	long	16")] long ExecQty, [Description("주문조건가격	double	30.11")] double OrdCndiPrc, [Description("해외파생현재가	double	30.11")] double OvrsDrvtNowPrc, [Description("정정수량	long	16")] long MdfyQty, [Description("취소수량	long	16")] long CancQty, [Description("거부수량	long	13")] long RjtQty, [Description("확인수량	long	16")] long CnfQty, [Description("미체결수량	long	16")] long UnercQty, [Description("반대매매여부	string	1")] string CvrgYn, [Description("등록단말번호	string	3")] string RegTmnlNo, [Description("등록지점번호	string	3")] string RegBrnNo, [Description("등록사용자ID	string	16")] string RegUserId, [Description("주문일자	string	8")] string OrdDt, [Description("주문시각	string	9")] string OrdTime, [Description("해외옵션행사예약구분코드	string	1")] string OvrsOptXrcRsvTpCode, [Description("해외파생옵션구분코드	string	1")] string OvrsDrvtOptTpCode, [Description("스프레드기준종목여부	string	1")] string SprdBaseIsuYn, [Description("해외선물주문일자	string	8")] string OvrsFutsOrdDt, [Description("해외선물주문번호2	string	10")] string OvrsFutsOrdNo2, [Description("해외선물원주문번호2	string	10")] string OvrsFutsOrgOrdNo2, [Description("해외파생종목코드2	string	30")] string OvrsDrvtIsuCode2);


/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="QrySrtDt">조회시작일자	string	8</param>
/// <param name="QryEndDt">조회종료일자	string	8</param>
/// <param name="ThdayTpCode">당일구분코드	string	1</param>
/// <param name="OrdStatCode">주문상태코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	string	1</param>
public record CIDBQ02400InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("조회시작일자	string	8")] string QrySrtDt, [Description("조회종료일자	string	8")] string QryEndDt, [Description("당일구분코드	string	1")] string ThdayTpCode, [Description("주문상태코드	string	1")] string OrdStatCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("조회구분코드	string	1")] string QryTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("해외파생선물옵션구분코드	string	1")] string OvrsDrvtFnoTpCode);

/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="QrySrtDt">조회시작일자	string	8</param>
/// <param name="QryEndDt">조회종료일자	string	8</param>
/// <param name="ThdayTpCode">당일구분코드	string	1</param>
/// <param name="OrdStatCode">주문상태코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="OvrsDrvtFnoTpCode">해외파생선물옵션구분코드	string	1</param>
public record CIDBQ02400OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("조회시작일자	string	8")] string QrySrtDt, [Description("조회종료일자	string	8")] string QryEndDt, [Description("당일구분코드	string	1")] string ThdayTpCode, [Description("주문상태코드	string	1")] string OrdStatCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("조회구분코드	string	1")] string QryTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("해외파생선물옵션구분코드	string	1")] string OvrsDrvtFnoTpCode);

/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400: OutBlock2
/// </summary>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="FcmOrdNo">FCM주문번호	string	15</param>
/// <param name="ExecDt">체결일자	string	8</param>
/// <param name="OvrsFutsExecNo">해외선물체결번호	string	10</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="AbrdFutsXrcPrc">해외선물행사가격	double	30.11</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="BnsTpNm">매매구분명	string	10</param>
/// <param name="FutsOrdStatCode">선물주문상태코드	string	1</param>
/// <param name="TpCodeNm">구분코드명	string	50</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="TrdTpNm">거래구분명	string	20</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
/// <param name="OrdPtnNm">주문유형명	string	40</param>
/// <param name="OrdPtnTermTpCode">주문유형기간구분코드	string	2</param>
/// <param name="CmnCodeNm">공통코드명	string	100</param>
/// <param name="AppSrtDt">적용시작일자	string	8</param>
/// <param name="AppEndDt">적용종료일자	string	8</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="OvrsDrvtExecIsuCode">해외파생체결종목코드	string	30</param>
/// <param name="ExecIsuNm">체결종목명	string	50</param>
/// <param name="ExecBnsTpCode">체결매매구분코드	string	1</param>
/// <param name="ExecBnsTpNm">체결매매구분명	string	10</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="AbrdFutsExecPrc">해외선물체결가격	double	30.11</param>
/// <param name="OrdCndiPrc">주문조건가격	double	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	double	30.11</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="TrxStatCode">처리상태코드	string	2</param>
/// <param name="TrxStatCodeNm">처리상태코드명	string	40</param>
/// <param name="CsgnCmsn">위탁수수료	double	19.2</param>
/// <param name="FcmCmsn">FCM수수료	double	21.4</param>
/// <param name="ThcoCmsn">당사수수료	double	19.2</param>
/// <param name="MdaCode">매체코드	string	2</param>
/// <param name="MdaCodeNm">매체코드명	string	40</param>
/// <param name="RegTmnlNo">등록단말번호	string	3</param>
/// <param name="RegUserId">등록사용자ID	string	16</param>
/// <param name="OrdSndDttm">주문발송일시	string	17</param>
/// <param name="ExecDttm">체결일시	string	17</param>
/// <param name="EufOneCmsnAmt">거래소비용1수수료금액	double	19.2</param>
/// <param name="EufTwoCmsnAmt">거래소비용2수수료금액	double	19.2</param>
/// <param name="LchOneCmsnAmt">런던청산소1수수료금액	double	19.2</param>
/// <param name="LchTwoCmsnAmt">런던청산소2수수료금액	double	19.2</param>
/// <param name="TrdOneCmsnAmt">거래1수수료금액	double	19.2</param>
/// <param name="TrdTwoCmsnAmt">거래2수수료금액	double	19.2</param>
/// <param name="TrdThreeCmsnAmt">거래3수수료금액	double	19.2</param>
/// <param name="StrmOneCmsnAmt">단기1수수료금액	double	19.2</param>
/// <param name="StrmTwoCmsnAmt">단기2수수료금액	double	19.2</param>
/// <param name="StrmThreeCmsnAmt">단기3수수료금액	double	19.2</param>
/// <param name="TransOneCmsnAmt">전달1수수료금액	double	19.2</param>
/// <param name="TransTwoCmsnAmt">전달2수수료금액	double	19.2</param>
/// <param name="TransThreeCmsnAmt">전달3수수료금액	double	19.2</param>
/// <param name="TransFourCmsnAmt">전달4수수료금액	double	19.2</param>
/// <param name="OvrsOptXrcRsvTpCode">해외옵션행사예약구분코드	string	1</param>
/// <param name="OvrsDrvtOptTpCode">해외파생옵션구분코드	string	1</param>
/// <param name="SprdBaseIsuYn">스프레드기준종목여부	string	1</param>
/// <param name="OvrsDrvtIsuCode2">해외파생종목코드2	string	30</param>
public record CIDBQ02400OutBlock2([Description("주문일자	string	8")] string OrdDt, [Description("해외선물주문번호	string	10")] string OvrsFutsOrdNo, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("FCM주문번호	string	15")] string FcmOrdNo, [Description("체결일자	string	8")] string ExecDt, [Description("해외선물체결번호	string	10")] string OvrsFutsExecNo, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("종목명	string	50")] string IsuNm, [Description("해외선물행사가격	double	30.11")] double AbrdFutsXrcPrc, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("매매구분명	string	10")] string BnsTpNm, [Description("선물주문상태코드	string	1")] string FutsOrdStatCode, [Description("구분코드명	string	50")] string TpCodeNm, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("거래구분명	string	20")] string TrdTpNm, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode, [Description("주문유형명	string	40")] string OrdPtnNm, [Description("주문유형기간구분코드	string	2")] string OrdPtnTermTpCode, [Description("공통코드명	string	100")] string CmnCodeNm, [Description("적용시작일자	string	8")] string AppSrtDt, [Description("적용종료일자	string	8")] string AppEndDt, [Description("주문수량	long	16")] long OrdQty, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("해외파생체결종목코드	string	30")] string OvrsDrvtExecIsuCode, [Description("체결종목명	string	50")] string ExecIsuNm, [Description("체결매매구분코드	string	1")] string ExecBnsTpCode, [Description("체결매매구분명	string	10")] string ExecBnsTpNm, [Description("체결수량	long	16")] long ExecQty, [Description("해외선물체결가격	double	30.11")] double AbrdFutsExecPrc, [Description("주문조건가격	double	30.11")] double OrdCndiPrc, [Description("해외파생현재가	double	30.11")] double OvrsDrvtNowPrc, [Description("미체결수량	long	16")] long UnercQty, [Description("처리상태코드	string	2")] string TrxStatCode, [Description("처리상태코드명	string	40")] string TrxStatCodeNm, [Description("위탁수수료	double	19.2")] double CsgnCmsn, [Description("FCM수수료	double	21.4")] double FcmCmsn, [Description("당사수수료	double	19.2")] double ThcoCmsn, [Description("매체코드	string	2")] string MdaCode, [Description("매체코드명	string	40")] string MdaCodeNm, [Description("등록단말번호	string	3")] string RegTmnlNo, [Description("등록사용자ID	string	16")] string RegUserId, [Description("주문발송일시	string	17")] string OrdSndDttm, [Description("체결일시	string	17")] string ExecDttm, [Description("거래소비용1수수료금액	double	19.2")] double EufOneCmsnAmt, [Description("거래소비용2수수료금액	double	19.2")] double EufTwoCmsnAmt, [Description("런던청산소1수수료금액	double	19.2")] double LchOneCmsnAmt, [Description("런던청산소2수수료금액	double	19.2")] double LchTwoCmsnAmt, [Description("거래1수수료금액	double	19.2")] double TrdOneCmsnAmt, [Description("거래2수수료금액	double	19.2")] double TrdTwoCmsnAmt, [Description("거래3수수료금액	double	19.2")] double TrdThreeCmsnAmt, [Description("단기1수수료금액	double	19.2")] double StrmOneCmsnAmt, [Description("단기2수수료금액	double	19.2")] double StrmTwoCmsnAmt, [Description("단기3수수료금액	double	19.2")] double StrmThreeCmsnAmt, [Description("전달1수수료금액	double	19.2")] double TransOneCmsnAmt, [Description("전달2수수료금액	double	19.2")] double TransTwoCmsnAmt, [Description("전달3수수료금액	double	19.2")] double TransThreeCmsnAmt, [Description("전달4수수료금액	double	19.2")] double TransFourCmsnAmt, [Description("해외옵션행사예약구분코드	string	1")] string OvrsOptXrcRsvTpCode, [Description("해외파생옵션구분코드	string	1")] string OvrsDrvtOptTpCode, [Description("스프레드기준종목여부	string	1")] string SprdBaseIsuYn, [Description("해외파생종목코드2	string	30")] string OvrsDrvtIsuCode2);


/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDBQ03000InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌구분코드	string	1")] string AcntTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("거래일자	string	8")] string TrdDt);

/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDBQ03000OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌구분코드	string	1")] string AcntTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("거래일자	string	8")] string TrdDt);

/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000: OutBlock2
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="TrdDt">거래일자	string	8</param>
/// <param name="CrcyObjCode">통화대상코드	string	12</param>
/// <param name="OvrsFutsDps">해외선물예수금	double	23.2</param>
/// <param name="CustmMnyioAmt">고객입출금금액	double	19.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	double	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	double	19.2</param>
/// <param name="PrexchDps">가환전예수금	double	19.2</param>
/// <param name="EvalAssetAmt">평가자산금액	double	19.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	double	19.2</param>
/// <param name="AbrdFutsAddMgn">해외선물추가증거금액	double	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	double	19.2</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	double	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	double	19.2</param>
/// <param name="LastSettPnlAmt">최종결제손익금액	double	19.2</param>
/// <param name="OvrsOptSettAmt">해외옵션결제금액	double	19.2</param>
/// <param name="OvrsOptBalEvalAmt">해외옵션잔고평가금액	double	19.2</param>
public record CIDBQ03000OutBlock2([Description("계좌번호	string	20")] string AcntNo, [Description("거래일자	string	8")] string TrdDt, [Description("통화대상코드	string	12")] string CrcyObjCode, [Description("해외선물예수금	double	23.2")] double OvrsFutsDps, [Description("고객입출금금액	double	19.2")] double CustmMnyioAmt, [Description("해외선물청산손익금액	double	19.2")] double AbrdFutsLqdtPnlAmt, [Description("해외선물수수료금액	double	19.2")] double AbrdFutsCmsnAmt, [Description("가환전예수금	double	19.2")] double PrexchDps, [Description("평가자산금액	double	19.2")] double EvalAssetAmt, [Description("해외선물위탁증거금액	double	19.2")] double AbrdFutsCsgnMgn, [Description("해외선물추가증거금액	double	19.2")] double AbrdFutsAddMgn, [Description("해외선물인출가능금액	double	19.2")] double AbrdFutsWthdwAbleAmt, [Description("해외선물주문가능금액	double	19.2")] double AbrdFutsOrdAbleAmt, [Description("해외선물평가손익금액	double	19.2")] double AbrdFutsEvalPnlAmt, [Description("최종결제손익금액	double	19.2")] double LastSettPnlAmt, [Description("해외옵션결제금액	double	19.2")] double OvrsOptSettAmt, [Description("해외옵션잔고평가금액	double	19.2")] double OvrsOptBalEvalAmt);


/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	string	1</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="CrcyCode">통화코드	string	3</param>
public record CIDBQ05300InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("해외계좌구분코드	string	1")] string OvrsAcntTpCode, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("통화코드	string	3")] string CrcyCode);

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	string	1</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="CrcyCode">통화코드	string	3</param>
public record CIDBQ05300OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("해외계좌구분코드	string	1")] string OvrsAcntTpCode, [Description("FCM계좌번호	string	20")] string FcmAcntNo, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("통화코드	string	3")] string CrcyCode);

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300: OutBlock2
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="CrcyCode">통화코드	string	3</param>
/// <param name="OvrsFutsDps">해외선물예수금	double	23.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	double	19.2</param>
/// <param name="OvrsFutsSplmMgn">해외선물추가증거금	double	23.2</param>
/// <param name="CustmLpnlAmt">고객청산손익금액	double	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	double	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	double	19.2</param>
/// <param name="AbrdFutsEvalDpstgTotAmt">해외선물평가예탁총금액	double	19.2</param>
/// <param name="Xchrat">환율	double	15.4</param>
/// <param name="FcurrRealMxchgAmt">외화실환전금액	double	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	double	19.2</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	double	19.2</param>
/// <param name="FutsDueNarrvLqdtPnlAmt">선물만기미도래청산손익금액	double	19.2</param>
/// <param name="FutsDueNarrvCmsn">선물만기미도래수수료	double	19.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	double	19.2</param>
/// <param name="OvrsFutsDueCmsn">해외선물만기수수료	double	19.2</param>
/// <param name="OvrsFutsOptBuyAmt">해외선물옵션매수금액	double	23.2</param>
/// <param name="OvrsFutsOptSellAmt">해외선물옵션매도금액	double	23.2</param>
/// <param name="OptBuyMktWrthAmt">옵션매수시장가치금액	double	19.2</param>
/// <param name="OptSellMktWrthAmt">옵션매도시장가치금액	double	19.2</param>
public record CIDBQ05300OutBlock2([Description("계좌번호	string	20")] string AcntNo, [Description("통화코드	string	3")] string CrcyCode, [Description("해외선물예수금	double	23.2")] double OvrsFutsDps, [Description("해외선물위탁증거금액	double	19.2")] double AbrdFutsCsgnMgn, [Description("해외선물추가증거금	double	23.2")] double OvrsFutsSplmMgn, [Description("고객청산손익금액	double	19.2")] double CustmLpnlAmt, [Description("해외선물평가손익금액	double	19.2")] double AbrdFutsEvalPnlAmt, [Description("해외선물수수료금액	double	19.2")] double AbrdFutsCmsnAmt, [Description("해외선물평가예탁총금액	double	19.2")] double AbrdFutsEvalDpstgTotAmt, [Description("환율	double	15.4")] double Xchrat, [Description("외화실환전금액	double	19.2")] double FcurrRealMxchgAmt, [Description("해외선물인출가능금액	double	19.2")] double AbrdFutsWthdwAbleAmt, [Description("해외선물주문가능금액	double	19.2")] double AbrdFutsOrdAbleAmt, [Description("선물만기미도래청산손익금액	double	19.2")] double FutsDueNarrvLqdtPnlAmt, [Description("선물만기미도래수수료	double	19.2")] double FutsDueNarrvCmsn, [Description("해외선물청산손익금액	double	19.2")] double AbrdFutsLqdtPnlAmt, [Description("해외선물만기수수료	double	19.2")] double OvrsFutsDueCmsn, [Description("해외선물옵션매수금액	double	23.2")] double OvrsFutsOptBuyAmt, [Description("해외선물옵션매도금액	double	23.2")] double OvrsFutsOptSellAmt, [Description("옵션매수시장가치금액	double	19.2")] double OptBuyMktWrthAmt, [Description("옵션매도시장가치금액	double	19.2")] double OptSellMktWrthAmt);

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300: OutBlock3
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OvrsFutsDps">해외선물예수금	double	23.2</param>
/// <param name="AbrdFutsLqdtPnlAmt">해외선물청산손익금액	double	19.2</param>
/// <param name="FutsDueNarrvLqdtPnlAmt">선물만기미도래청산손익금액	double	19.2</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	double	19.2</param>
/// <param name="AbrdFutsEvalDpstgTotAmt">해외선물평가예탁총금액	double	19.2</param>
/// <param name="CustmLpnlAmt">고객청산손익금액	double	19.2</param>
/// <param name="OvrsFutsDueCmsn">해외선물만기수수료	double	19.2</param>
/// <param name="FcurrRealMxchgAmt">외화실환전금액	double	19.2</param>
/// <param name="AbrdFutsCmsnAmt">해외선물수수료금액	double	19.2</param>
/// <param name="FutsDueNarrvCmsn">선물만기미도래수수료	double	19.2</param>
/// <param name="AbrdFutsCsgnMgn">해외선물위탁증거금액	double	19.2</param>
/// <param name="OvrsFutsMaintMgn">해외선물유지증거금	double	19.2</param>
/// <param name="OvrsFutsOptBuyAmt">해외선물옵션매수금액	double	23.2</param>
/// <param name="OvrsFutsOptSellAmt">해외선물옵션매도금액	double	23.2</param>
/// <param name="CtlmtAmt">신용한도금액	double	23.2</param>
/// <param name="OvrsFutsSplmMgn">해외선물추가증거금	double	23.2</param>
/// <param name="MgnclRat">마진콜율	double	27.1</param>
/// <param name="AbrdFutsOrdAbleAmt">해외선물주문가능금액	double	19.2</param>
/// <param name="AbrdFutsWthdwAbleAmt">해외선물인출가능금액	double	19.2</param>
/// <param name="OptBuyMktWrthAmt">옵션매수시장가치금액	double	19.2</param>
/// <param name="OptSellMktWrthAmt">옵션매도시장가치금액	double	19.2</param>
/// <param name="OvrsOptSettAmt">해외옵션결제금액	double	19.2</param>
/// <param name="OvrsOptBalEvalAmt">해외옵션잔고평가금액	double	19.2</param>
public record CIDBQ05300OutBlock3([Description("레코드갯수	int	5")] int RecCnt, [Description("해외선물예수금	double	23.2")] double OvrsFutsDps, [Description("해외선물청산손익금액	double	19.2")] double AbrdFutsLqdtPnlAmt, [Description("선물만기미도래청산손익금액	double	19.2")] double FutsDueNarrvLqdtPnlAmt, [Description("해외선물평가손익금액	double	19.2")] double AbrdFutsEvalPnlAmt, [Description("해외선물평가예탁총금액	double	19.2")] double AbrdFutsEvalDpstgTotAmt, [Description("고객청산손익금액	double	19.2")] double CustmLpnlAmt, [Description("해외선물만기수수료	double	19.2")] double OvrsFutsDueCmsn, [Description("외화실환전금액	double	19.2")] double FcurrRealMxchgAmt, [Description("해외선물수수료금액	double	19.2")] double AbrdFutsCmsnAmt, [Description("선물만기미도래수수료	double	19.2")] double FutsDueNarrvCmsn, [Description("해외선물위탁증거금액	double	19.2")] double AbrdFutsCsgnMgn, [Description("해외선물유지증거금	double	19.2")] double OvrsFutsMaintMgn, [Description("해외선물옵션매수금액	double	23.2")] double OvrsFutsOptBuyAmt, [Description("해외선물옵션매도금액	double	23.2")] double OvrsFutsOptSellAmt, [Description("신용한도금액	double	23.2")] double CtlmtAmt, [Description("해외선물추가증거금	double	23.2")] double OvrsFutsSplmMgn, [Description("마진콜율	double	27.1")] double MgnclRat, [Description("해외선물주문가능금액	double	19.2")] double AbrdFutsOrdAbleAmt, [Description("해외선물인출가능금액	double	19.2")] double AbrdFutsWthdwAbleAmt, [Description("옵션매수시장가치금액	double	19.2")] double OptBuyMktWrthAmt, [Description("옵션매도시장가치금액	double	19.2")] double OptSellMktWrthAmt, [Description("해외옵션결제금액	double	19.2")] double OvrsOptSettAmt, [Description("해외옵션잔고평가금액	double	19.2")] double OvrsOptBalEvalAmt);


/// <summary>
/// 해외선물신규주문: CIDBT00100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="BrnCode">지점코드	string	7</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
/// <param name="CrcyCode">통화코드	string	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	double	30.11</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="PrdtCode">상품코드	string	6</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT00100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("지점코드	string	7")] string BrnCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode, [Description("통화코드	string	3")] string CrcyCode, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("조건주문가격	double	30.11")] double CndiOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("상품코드	string	6")] string PrdtCode, [Description("만기년월	string	6")] string DueYymm, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물신규주문: CIDBT00100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="BrnCode">지점코드	string	7</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
/// <param name="CrcyCode">통화코드	string	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	double	30.11</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="PrdtCode">상품코드	string	6</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT00100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("지점코드	string	7")] string BrnCode, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("해외선물주문유형코드	string	1")] string AbrdFutsOrdPtnCode, [Description("통화코드	string	3")] string CrcyCode, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("조건주문가격	double	30.11")] double CndiOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("상품코드	string	6")] string PrdtCode, [Description("만기년월	string	6")] string DueYymm, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물신규주문: CIDBT00100: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
public record CIDBT00100OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("해외선물주문번호	string	10")] string OvrsFutsOrdNo);


/// <summary>
/// 해외선물정정주문: CIDBT00900: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="RegBrnNo">등록지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="FutsOrdPtnCode">선물주문유형코드	string	1</param>
/// <param name="CrcyCodeVal">통화코드값	string	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	double	30.11</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	string	10</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT00900InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("등록지점번호	string	3")] string RegBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("선물주문유형코드	string	1")] string FutsOrdPtnCode, [Description("통화코드값	string	3")] string CrcyCodeVal, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("조건주문가격	double	30.11")] double CndiOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("해외파생상품코드	string	10")] string OvrsDrvtPrdtCode, [Description("만기년월	string	6")] string DueYymm, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물정정주문: CIDBT00900: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="RegBrnNo">등록지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="FutsOrdPtnCode">선물주문유형코드	string	1</param>
/// <param name="CrcyCodeVal">통화코드값	string	3</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="CndiOrdPrc">조건주문가격	double	30.11</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	string	10</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT00900OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("등록지점번호	string	3")] string RegBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("매매구분코드	string	1")] string BnsTpCode, [Description("선물주문유형코드	string	1")] string FutsOrdPtnCode, [Description("통화코드값	string	3")] string CrcyCodeVal, [Description("해외파생주문가격	double	30.11")] double OvrsDrvtOrdPrc, [Description("조건주문가격	double	30.11")] double CndiOrdPrc, [Description("주문수량	long	16")] long OrdQty, [Description("해외파생상품코드	string	10")] string OvrsDrvtPrdtCode, [Description("만기년월	string	6")] string DueYymm, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물정정주문: CIDBT00900: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	string	80</param>
public record CIDBT00900OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("해외선물주문번호	string	10")] string OvrsFutsOrdNo, [Description("내부메시지내용	string	80")] string InnerMsgCnts);


/// <summary>
/// 해외선물취소주문: CIDBT01000: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="BrnNo">지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="PrdtTpCode">상품구분코드	string	2</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT01000InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("지점번호	string	3")] string BrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("상품구분코드	string	2")] string PrdtTpCode, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물취소주문: CIDBT01000: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdDt">주문일자	string	8</param>
/// <param name="BrnNo">지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="OvrsFutsOrgOrdNo">해외선물원주문번호	string	10</param>
/// <param name="FutsOrdTpCode">선물주문구분코드	string	1</param>
/// <param name="PrdtTpCode">상품구분코드	string	2</param>
/// <param name="ExchCode">거래소코드	string	10</param>
public record CIDBT01000OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("주문일자	string	8")] string OrdDt, [Description("지점번호	string	3")] string BrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("해외선물원주문번호	string	10")] string OvrsFutsOrgOrdNo, [Description("선물주문구분코드	string	1")] string FutsOrdTpCode, [Description("상품구분코드	string	2")] string PrdtTpCode, [Description("거래소코드	string	10")] string ExchCode);

/// <summary>
/// 해외선물취소주문: CIDBT01000: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	string	80</param>
public record CIDBT01000OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("해외선물주문번호	string	10")] string OvrsFutsOrdNo, [Description("내부메시지내용	string	80")] string InnerMsgCnts);


/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDEQ00800InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("거래일자	string	8")] string TrdDt);

/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDEQ00800OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("계좌비밀번호	string	8")] string AcntPwd, [Description("거래일자	string	8")] string TrdDt);

/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800: OutBlock2
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="TrdDt">거래일자	string	8</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="BnsTpNm">매매구분명	string	10</param>
/// <param name="BalQty">잔고수량	long	16</param>
/// <param name="LqdtAbleQty">청산가능수량	long	16</param>
/// <param name="PchsPrc">매입가격	double	30.11</param>
/// <param name="OvrsDrvtNowPrc">해외파생현재가	double	30.11</param>
/// <param name="AbrdFutsEvalPnlAmt">해외선물평가손익금액	double	19.2</param>
/// <param name="CustmBalAmt">고객잔고금액	double	19.2</param>
/// <param name="FcurrEvalAmt">외화평가금액	double	21.4</param>
/// <param name="IsuNm">종목명	string	50</param>
/// <param name="CrcyCodeVal">통화코드값	string	3</param>
/// <param name="OvrsDrvtPrdtCode">해외파생상품코드	string	10</param>
/// <param name="DueDt">만기일자	string	8</param>
/// <param name="PrcntrAmt">계약당금액	double	19.2</param>
/// <param name="FcurrEvalPnlAmt">외화평가손익금액	double	21.4</param>
public record CIDEQ00800OutBlock2([Description("계좌번호	string	20")] string AcntNo, [Description("거래일자	string	8")] string TrdDt, [Description("종목코드값	string	30")] string IsuCodeVal, [Description("매매구분명	string	10")] string BnsTpNm, [Description("잔고수량	long	16")] long BalQty, [Description("청산가능수량	long	16")] long LqdtAbleQty, [Description("매입가격	double	30.11")] double PchsPrc, [Description("해외파생현재가	double	30.11")] double OvrsDrvtNowPrc, [Description("해외선물평가손익금액	double	19.2")] double AbrdFutsEvalPnlAmt, [Description("고객잔고금액	double	19.2")] double CustmBalAmt, [Description("외화평가금액	double	21.4")] double FcurrEvalAmt, [Description("종목명	string	50")] string IsuNm, [Description("통화코드값	string	3")] string CrcyCodeVal, [Description("해외파생상품코드	string	10")] string OvrsDrvtPrdtCode, [Description("만기일자	string	8")] string DueDt, [Description("계약당금액	double	19.2")] double PrcntrAmt, [Description("외화평가손익금액	double	21.4")] double FcurrEvalPnlAmt);


/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="SecTpCode">유가증권구분	string	1</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	string	2</param>
/// <param name="LoanTp">대출구분	string	1</param>
public record CLNAQ00100InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분	string	1")] string QryTp, [Description("종목번호	string	12")] string IsuNo, [Description("유가증권구분	string	1")] string SecTpCode, [Description("대출이자등급코드	string	2")] string LoanIntrstGrdCode, [Description("대출구분	string	1")] string LoanTp);

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="SecTpCode">유가증권구분	string	1</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	string	2</param>
/// <param name="LoanTp">대출구분	string	1</param>
public record CLNAQ00100OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("조회구분	string	1")] string QryTp, [Description("종목번호	string	12")] string IsuNo, [Description("유가증권구분	string	1")] string SecTpCode, [Description("대출이자등급코드	string	2")] string LoanIntrstGrdCode, [Description("대출구분	string	1")] string LoanTp);

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100: OutBlock2
/// </summary>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="Parprc">액면가	double	13.2</param>
/// <param name="PrdayCprc">전일종가	double	13.2</param>
/// <param name="RatVal">비율값	double	19.8</param>
/// <param name="SubstPrc">대용가	double	13.2</param>
/// <param name="RegTpNm">등록구분	string	20</param>
/// <param name="SpotMgnLevyClssNm">현물증거금징수분류명	string	40</param>
/// <param name="FnoTrdStopRsnCnts">거래정지사유	string	40</param>
/// <param name="DgrsPtnNm">요주의유형명	string	40</param>
/// <param name="AcdPtnNm">사고유형	string	40</param>
/// <param name="MktTpNm">시장구분	string	20</param>
/// <param name="LmtVal">한도값	long	18</param>
/// <param name="AcntLmtVal">계좌한도값	long	18</param>
/// <param name="LoanGrdCode">대출등급코드	string	2</param>
/// <param name="LoanAmt">대출금액	long	16</param>
/// <param name="LoanAbleRat">대출가능율	double	26.9</param>
/// <param name="LoanIntrat1">대출이율1	double	14.4</param>
/// <param name="RegPsnId">등록자ID	string	16</param>
/// <param name="Rat01">비율값	double	19.8</param>
/// <param name="Rat02">비율값	double	19.8</param>
public record CLNAQ00100OutBlock2([Description("종목번호	string	12")] string IsuNo, [Description("종목명	string	40")] string IsuNm, [Description("액면가	double	13.2")] double Parprc, [Description("전일종가	double	13.2")] double PrdayCprc, [Description("비율값	double	19.8")] double RatVal, [Description("대용가	double	13.2")] double SubstPrc, [Description("등록구분	string	20")] string RegTpNm, [Description("현물증거금징수분류명	string	40")] string SpotMgnLevyClssNm, [Description("거래정지사유	string	40")] string FnoTrdStopRsnCnts, [Description("요주의유형명	string	40")] string DgrsPtnNm, [Description("사고유형	string	40")] string AcdPtnNm, [Description("시장구분	string	20")] string MktTpNm, [Description("한도값	long	18")] long LmtVal, [Description("계좌한도값	long	18")] long AcntLmtVal, [Description("대출등급코드	string	2")] string LoanGrdCode, [Description("대출금액	long	16")] long LoanAmt, [Description("대출가능율	double	26.9")] double LoanAbleRat, [Description("대출이율1	double	14.4")] double LoanIntrat1, [Description("등록자ID	string	16")] string RegPsnId, [Description("비율값	double	19.8")] double Rat01, [Description("비율값	double	19.8")] double Rat02);

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100: OutBlock3
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="LrgMnyoutSumAmt">대출금합계금액	long	16</param>
public record CLNAQ00100OutBlock3([Description("레코드갯수	int	5")] int RecCnt, [Description("대출금합계금액	long	16")] long LrgMnyoutSumAmt);


/// <summary>
/// 계좌별신용한도조회: CSPAQ00600: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CSPAQ00600InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("대출상세분류코드	string	2")] string LoanDtlClssCode, [Description("종목번호	string	12")] string IsuNo, [Description("주문가	double	13.2")] double OrdPrc, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 계좌별신용한도조회: CSPAQ00600: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CSPAQ00600OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("대출상세분류코드	string	2")] string LoanDtlClssCode, [Description("종목번호	string	12")] string IsuNo, [Description("주문가	double	13.2")] double OrdPrc, [Description("통신매체코드	string	2")] string CommdaCode);

/// <summary>
/// 계좌별신용한도조회: CSPAQ00600: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="SloanLmtAmt">대주한도	long	16</param>
/// <param name="SloanAmtSum">대주금액합계	long	16</param>
/// <param name="SloanNewAmt">대주신규금액	long	16</param>
/// <param name="SloanRfundAmt">대주상환금액	long	16</param>
/// <param name="MktcplMloanLmtAmt">유통융자한도금액	long	16</param>
/// <param name="MktcplMloanAmtSum">유통융자금액합계	long	16</param>
/// <param name="MktcplMloanNewAmt">유통융자신규금액	long	16</param>
/// <param name="MktcplMloanRfundAmt">유통융자상환금액	long	16</param>
/// <param name="SfaccMloanLmtAmt">자기융자한도금액	long	16</param>
/// <param name="SfaccMloanAmtSum">자기융자금액합계	long	16</param>
/// <param name="SfaccMloanNewAmt">자기융자신규금액	long	16</param>
/// <param name="SfaccMloanRfundAmt">자기융자상환금액	long	16</param>
/// <param name="BrnMktcplMloanLmtAmt">지점유통융자한도금액	long	16</param>
/// <param name="BrnMktcplMloanNewAmt">지점유통융자신규금액	long	16</param>
/// <param name="BrnMktcplMloanRfundAmt">지점유통융자상환금액	long	16</param>
/// <param name="BrnMktcplMloanUseAmt">지점유통융자사용금액	long	16</param>
/// <param name="BrnSfaccMloanLmtAmt">지점자기융자한도금액	long	16</param>
/// <param name="BrnSfaccMloanNewAmt">지점자기융자신규금액	long	16</param>
/// <param name="BrnSfaccMloanRfundAmt">지점자기융자상환금액	long	16</param>
/// <param name="BrnSfaccMloanUseAmt">지점자기융자사용금액	long	16</param>
/// <param name="FirmMloanLmtMgmtYn">이용사융자한도관리여부	string	1</param>
/// <param name="FirmCrdtIsuRestrcTp">이용사신용종목제한구분	string	1</param>
/// <param name="PldgMaintRat">담보유지비율	double	7.4</param>
/// <param name="FirmNm">이용사명	string	50</param>
/// <param name="PldgRat">담보비율	double	7.4</param>
/// <param name="DpsastSum">예탁자산합계	long	17</param>
/// <param name="LmtChgAbleAmt">한도변경가능금액	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
/// <param name="RcvblUablOrdAbleQty">미수불가주문가능수량	long	16</param>
public record CSPAQ00600OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("주문가	double	13.2")] double OrdPrc, [Description("대주한도	long	16")] long SloanLmtAmt, [Description("대주금액합계	long	16")] long SloanAmtSum, [Description("대주신규금액	long	16")] long SloanNewAmt, [Description("대주상환금액	long	16")] long SloanRfundAmt, [Description("유통융자한도금액	long	16")] long MktcplMloanLmtAmt, [Description("유통융자금액합계	long	16")] long MktcplMloanAmtSum, [Description("유통융자신규금액	long	16")] long MktcplMloanNewAmt, [Description("유통융자상환금액	long	16")] long MktcplMloanRfundAmt, [Description("자기융자한도금액	long	16")] long SfaccMloanLmtAmt, [Description("자기융자금액합계	long	16")] long SfaccMloanAmtSum, [Description("자기융자신규금액	long	16")] long SfaccMloanNewAmt, [Description("자기융자상환금액	long	16")] long SfaccMloanRfundAmt, [Description("지점유통융자한도금액	long	16")] long BrnMktcplMloanLmtAmt, [Description("지점유통융자신규금액	long	16")] long BrnMktcplMloanNewAmt, [Description("지점유통융자상환금액	long	16")] long BrnMktcplMloanRfundAmt, [Description("지점유통융자사용금액	long	16")] long BrnMktcplMloanUseAmt, [Description("지점자기융자한도금액	long	16")] long BrnSfaccMloanLmtAmt, [Description("지점자기융자신규금액	long	16")] long BrnSfaccMloanNewAmt, [Description("지점자기융자상환금액	long	16")] long BrnSfaccMloanRfundAmt, [Description("지점자기융자사용금액	long	16")] long BrnSfaccMloanUseAmt, [Description("이용사융자한도관리여부	string	1")] string FirmMloanLmtMgmtYn, [Description("이용사신용종목제한구분	string	1")] string FirmCrdtIsuRestrcTp, [Description("담보유지비율	double	7.4")] double PldgMaintRat, [Description("이용사명	string	50")] string FirmNm, [Description("담보비율	double	7.4")] double PldgRat, [Description("예탁자산합계	long	17")] long DpsastSum, [Description("한도변경가능금액	long	16")] long LmtChgAbleAmt, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("주문가능수량	long	16")] long OrdAbleQty, [Description("미수불가주문가능수량	long	16")] long RcvblUablOrdAbleQty);


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ12200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("관리지점번호	string	3")] string MgmtBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp);

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ12200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("관리지점번호	string	3")] string MgmtBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp);

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	long	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	long	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	long	16</param>
/// <param name="BalEvalAmt">잔고평가금액	long	16</param>
/// <param name="RcvblAmt">미수금액	long	16</param>
/// <param name="DpsastTotamt">예탁자산총액	long	16</param>
/// <param name="PnlRat">손익율	double	18.6</param>
/// <param name="InvstOrgAmt">투자원금	long	20</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	long	16</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="SubstAmt">대용금액	long	16</param>
/// <param name="D1Dps">D1예수금	long	16</param>
/// <param name="D2Dps">D2예수금	long	16</param>
/// <param name="MnyrclAmt">현금미수금액	long	16</param>
/// <param name="MgnMny">증거금현금	long	16</param>
/// <param name="MgnSubst">증거금대용	long	16</param>
/// <param name="ChckAmt">수표금액	long	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	long	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat35ordAbleAmt">증거금률35%주문가능금액	long	16</param>
/// <param name="MgnRat50ordAbleAmt">증거금률50%주문가능금액	long	16</param>
/// <param name="PrdaySellAdjstAmt">전일매도정산금액	long	16</param>
/// <param name="PrdayBuyAdjstAmt">전일매수정산금액	long	16</param>
/// <param name="CrdaySellAdjstAmt">금일매도정산금액	long	16</param>
/// <param name="CrdayBuyAdjstAmt">금일매수정산금액	long	16</param>
/// <param name="D1ovdRepayRqrdAmt">D1연체변제소요금액	long	16</param>
/// <param name="D2ovdRepayRqrdAmt">D2연체변제소요금액	long	16</param>
/// <param name="D1PrsmptWthdwAbleAmt">D1추정인출가능금액	long	16</param>
/// <param name="D2PrsmptWthdwAbleAmt">D2추정인출가능금액	long	16</param>
/// <param name="DpspdgLoanAmt">예탁담보대출금액	long	16</param>
/// <param name="Imreq">신용설정보증금	long	16</param>
/// <param name="MloanAmt">융자금액	long	16</param>
/// <param name="ChgAfPldgRat">변경후담보비율	double	9.3</param>
/// <param name="OrgPldgAmt">원담보금액	long	16</param>
/// <param name="SubPldgAmt">부담보금액	long	16</param>
/// <param name="RqrdPldgAmt">소요담보금액	long	16</param>
/// <param name="OrgPdlckAmt">원담보부족금액	long	16</param>
/// <param name="PdlckAmt">담보부족금액	long	16</param>
/// <param name="AddPldgMny">추가담보현금	long	16</param>
/// <param name="D1OrdAbleAmt">D1주문가능금액	long	16</param>
/// <param name="CrdtIntdltAmt">신용이자미납금액	long	16</param>
/// <param name="EtclndAmt">기타대여금액	long	16</param>
/// <param name="NtdayPrsmptCvrgAmt">익일추정반대매매금액	long	16</param>
/// <param name="OrgPldgSumAmt">원담보합계금액	long	16</param>
/// <param name="CrdtOrdAbleAmt">신용주문가능금액	long	16</param>
/// <param name="SubPldgSumAmt">부담보합계금액	long	16</param>
/// <param name="CrdtPldgAmtMny">신용담보금현금	long	16</param>
/// <param name="CrdtPldgSubstAmt">신용담보대용금액	long	16</param>
/// <param name="AddCrdtPldgMny">추가신용담보현금	long	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	long	16</param>
/// <param name="AddCrdtPldgSubst">추가신용담보대용	long	16</param>
/// <param name="CslLoanAmtdt1">매도대금담보대출금액	long	16</param>
/// <param name="DpslRestrcAmt">처분제한금액	long	16</param>
public record CSPAQ12200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("출금가능금액	long	16")] long MnyoutAbleAmt, [Description("거래소금액	long	16")] long SeOrdAbleAmt, [Description("코스닥금액	long	16")] long KdqOrdAbleAmt, [Description("잔고평가금액	long	16")] long BalEvalAmt, [Description("미수금액	long	16")] long RcvblAmt, [Description("예탁자산총액	long	16")] long DpsastTotamt, [Description("손익율	double	18.6")] double PnlRat, [Description("투자원금	long	20")] long InvstOrgAmt, [Description("투자손익금액	long	16")] long InvstPlAmt, [Description("신용담보주문금액	long	16")] long CrdtPldgOrdAmt, [Description("예수금	long	16")] long Dps, [Description("대용금액	long	16")] long SubstAmt, [Description("D1예수금	long	16")] long D1Dps, [Description("D2예수금	long	16")] long D2Dps, [Description("현금미수금액	long	16")] long MnyrclAmt, [Description("증거금현금	long	16")] long MgnMny, [Description("증거금대용	long	16")] long MgnSubst, [Description("수표금액	long	16")] long ChckAmt, [Description("대용주문가능금액	long	16")] long SubstOrdAbleAmt, [Description("증거금률100퍼센트주문가능금액	long	16")] long MgnRat100pctOrdAbleAmt, [Description("증거금률35%주문가능금액	long	16")] long MgnRat35ordAbleAmt, [Description("증거금률50%주문가능금액	long	16")] long MgnRat50ordAbleAmt, [Description("전일매도정산금액	long	16")] long PrdaySellAdjstAmt, [Description("전일매수정산금액	long	16")] long PrdayBuyAdjstAmt, [Description("금일매도정산금액	long	16")] long CrdaySellAdjstAmt, [Description("금일매수정산금액	long	16")] long CrdayBuyAdjstAmt, [Description("D1연체변제소요금액	long	16")] long D1ovdRepayRqrdAmt, [Description("D2연체변제소요금액	long	16")] long D2ovdRepayRqrdAmt, [Description("D1추정인출가능금액	long	16")] long D1PrsmptWthdwAbleAmt, [Description("D2추정인출가능금액	long	16")] long D2PrsmptWthdwAbleAmt, [Description("예탁담보대출금액	long	16")] long DpspdgLoanAmt, [Description("신용설정보증금	long	16")] long Imreq, [Description("융자금액	long	16")] long MloanAmt, [Description("변경후담보비율	double	9.3")] double ChgAfPldgRat, [Description("원담보금액	long	16")] long OrgPldgAmt, [Description("부담보금액	long	16")] long SubPldgAmt, [Description("소요담보금액	long	16")] long RqrdPldgAmt, [Description("원담보부족금액	long	16")] long OrgPdlckAmt, [Description("담보부족금액	long	16")] long PdlckAmt, [Description("추가담보현금	long	16")] long AddPldgMny, [Description("D1주문가능금액	long	16")] long D1OrdAbleAmt, [Description("신용이자미납금액	long	16")] long CrdtIntdltAmt, [Description("기타대여금액	long	16")] long EtclndAmt, [Description("익일추정반대매매금액	long	16")] long NtdayPrsmptCvrgAmt, [Description("원담보합계금액	long	16")] long OrgPldgSumAmt, [Description("신용주문가능금액	long	16")] long CrdtOrdAbleAmt, [Description("부담보합계금액	long	16")] long SubPldgSumAmt, [Description("신용담보금현금	long	16")] long CrdtPldgAmtMny, [Description("신용담보대용금액	long	16")] long CrdtPldgSubstAmt, [Description("추가신용담보현금	long	16")] long AddCrdtPldgMny, [Description("신용담보재사용금액	long	16")] long CrdtPldgRuseAmt, [Description("추가신용담보대용	long	16")] long AddCrdtPldgSubst, [Description("매도대금담보대출금액	long	16")] long CslLoanAmtdt1, [Description("처분제한금액	long	16")] long DpslRestrcAmt);


/// <summary>
/// BEP단가조회: CSPAQ12300: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
/// <param name="CmsnAppTpCode">수수료적용구분	string	1</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	string	1</param>
/// <param name="UprcTpCode">단가구분	string	1</param>
public record CSPAQ12300InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp, [Description("수수료적용구분	string	1")] string CmsnAppTpCode, [Description("D2잔고기준조회구분	string	1")] string D2balBaseQryTp, [Description("단가구분	string	1")] string UprcTpCode);

/// <summary>
/// BEP단가조회: CSPAQ12300: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
/// <param name="CmsnAppTpCode">수수료적용구분	string	1</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	string	1</param>
/// <param name="UprcTpCode">단가구분	string	1</param>
public record CSPAQ12300OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp, [Description("수수료적용구분	string	1")] string CmsnAppTpCode, [Description("D2잔고기준조회구분	string	1")] string D2balBaseQryTp, [Description("단가구분	string	1")] string UprcTpCode);

/// <summary>
/// BEP단가조회: CSPAQ12300: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	long	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	long	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	long	16</param>
/// <param name="HtsOrdAbleAmt">HTS주문가능금액	long	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	long	16</param>
/// <param name="BalEvalAmt">잔고평가금액	long	16</param>
/// <param name="PchsAmt">매입금액	long	16</param>
/// <param name="RcvblAmt">미수금액	long	16</param>
/// <param name="PnlRat">손익율	double	18.6</param>
/// <param name="InvstOrgAmt">투자원금	long	20</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	long	16</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="D1Dps">D1예수금	long	16</param>
/// <param name="D2Dps">D2예수금	long	16</param>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="MnyMgn">현금증거금액	long	16</param>
/// <param name="SubstMgn">대용증거금액	long	16</param>
/// <param name="SubstAmt">대용금액	long	16</param>
/// <param name="PrdayBuyExecAmt">전일매수체결금액	long	16</param>
/// <param name="PrdaySellExecAmt">전일매도체결금액	long	16</param>
/// <param name="CrdayBuyExecAmt">금일매수체결금액	long	16</param>
/// <param name="CrdaySellExecAmt">금일매도체결금액	long	16</param>
/// <param name="EvalPnlSum">평가손익합계	long	15</param>
/// <param name="DpsastTotamt">예탁자산총액	long	16</param>
/// <param name="Evrprc">제비용	long	19</param>
/// <param name="RuseAmt">재사용금액	long	16</param>
/// <param name="EtclndAmt">기타대여금액	long	16</param>
/// <param name="PrcAdjstAmt">가정산금액	long	16</param>
/// <param name="D1CmsnAmt">D1수수료	long	16</param>
/// <param name="D2CmsnAmt">D2수수료	long	16</param>
/// <param name="D1EvrTax">D1제세금	long	16</param>
/// <param name="D2EvrTax">D2제세금	long	16</param>
/// <param name="D1SettPrergAmt">D1결제예정금액	long	16</param>
/// <param name="D2SettPrergAmt">D2결제예정금액	long	16</param>
/// <param name="PrdayKseMnyMgn">전일KSE현금증거금	long	16</param>
/// <param name="PrdayKseSubstMgn">전일KSE대용증거금	long	16</param>
/// <param name="PrdayKseCrdtMnyMgn">전일KSE신용현금증거금	long	16</param>
/// <param name="PrdayKseCrdtSubstMgn">전일KSE신용대용증거금	long	16</param>
/// <param name="CrdayKseMnyMgn">금일KSE현금증거금	long	16</param>
/// <param name="CrdayKseSubstMgn">금일KSE대용증거금	long	16</param>
/// <param name="CrdayKseCrdtMnyMgn">금일KSE신용현금증거금	long	16</param>
/// <param name="CrdayKseCrdtSubstMgn">금일KSE신용대용증거금	long	16</param>
/// <param name="PrdayKdqMnyMgn">전일코스닥현금증거금	long	16</param>
/// <param name="PrdayKdqSubstMgn">전일코스닥대용증거금	long	16</param>
/// <param name="PrdayKdqCrdtMnyMgn">전일코스닥신용현금증거금	long	16</param>
/// <param name="PrdayKdqCrdtSubstMgn">전일코스닥신용대용증거금	long	16</param>
/// <param name="CrdayKdqMnyMgn">금일코스닥현금증거금	long	16</param>
/// <param name="CrdayKdqSubstMgn">금일코스닥대용증거금	long	16</param>
/// <param name="CrdayKdqCrdtMnyMgn">금일코스닥신용현금증거금	long	16</param>
/// <param name="CrdayKdqCrdtSubstMgn">금일코스닥신용대용증거금	long	16</param>
/// <param name="PrdayFrbrdMnyMgn">전일프리보드현금증거금	long	16</param>
/// <param name="PrdayFrbrdSubstMgn">전일프리보드대용증거금	long	16</param>
/// <param name="CrdayFrbrdMnyMgn">금일프리보드현금증거금	long	16</param>
/// <param name="CrdayFrbrdSubstMgn">금일프리보드대용증거금	long	16</param>
/// <param name="PrdayCrbmkMnyMgn">전일장외현금증거금	long	16</param>
/// <param name="PrdayCrbmkSubstMgn">전일장외대용증거금	long	16</param>
/// <param name="CrdayCrbmkMnyMgn">금일장외현금증거금	long	16</param>
/// <param name="CrdayCrbmkSubstMgn">금일장외대용증거금	long	16</param>
/// <param name="DpspdgQty">예탁담보수량	long	16</param>
/// <param name="BuyAdjstAmtD2">매수정산금(D+2)	long	16</param>
/// <param name="SellAdjstAmtD2">매도정산금(D+2)	long	16</param>
/// <param name="RepayRqrdAmtD1">변제소요금(D+1)	long	16</param>
/// <param name="RepayRqrdAmtD2">변제소요금(D+2)	long	16</param>
/// <param name="LoanAmt">대출금액	long	16</param>
public record CSPAQ12300OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("출금가능금액	long	16")] long MnyoutAbleAmt, [Description("거래소금액	long	16")] long SeOrdAbleAmt, [Description("코스닥금액	long	16")] long KdqOrdAbleAmt, [Description("HTS주문가능금액	long	16")] long HtsOrdAbleAmt, [Description("증거금률100퍼센트주문가능금액	long	16")] long MgnRat100pctOrdAbleAmt, [Description("잔고평가금액	long	16")] long BalEvalAmt, [Description("매입금액	long	16")] long PchsAmt, [Description("미수금액	long	16")] long RcvblAmt, [Description("손익율	double	18.6")] double PnlRat, [Description("투자원금	long	20")] long InvstOrgAmt, [Description("투자손익금액	long	16")] long InvstPlAmt, [Description("신용담보주문금액	long	16")] long CrdtPldgOrdAmt, [Description("예수금	long	16")] long Dps, [Description("D1예수금	long	16")] long D1Dps, [Description("D2예수금	long	16")] long D2Dps, [Description("주문일	string	8")] string OrdDt, [Description("현금증거금액	long	16")] long MnyMgn, [Description("대용증거금액	long	16")] long SubstMgn, [Description("대용금액	long	16")] long SubstAmt, [Description("전일매수체결금액	long	16")] long PrdayBuyExecAmt, [Description("전일매도체결금액	long	16")] long PrdaySellExecAmt, [Description("금일매수체결금액	long	16")] long CrdayBuyExecAmt, [Description("금일매도체결금액	long	16")] long CrdaySellExecAmt, [Description("평가손익합계	long	15")] long EvalPnlSum, [Description("예탁자산총액	long	16")] long DpsastTotamt, [Description("제비용	long	19")] long Evrprc, [Description("재사용금액	long	16")] long RuseAmt, [Description("기타대여금액	long	16")] long EtclndAmt, [Description("가정산금액	long	16")] long PrcAdjstAmt, [Description("D1수수료	long	16")] long D1CmsnAmt, [Description("D2수수료	long	16")] long D2CmsnAmt, [Description("D1제세금	long	16")] long D1EvrTax, [Description("D2제세금	long	16")] long D2EvrTax, [Description("D1결제예정금액	long	16")] long D1SettPrergAmt, [Description("D2결제예정금액	long	16")] long D2SettPrergAmt, [Description("전일KSE현금증거금	long	16")] long PrdayKseMnyMgn, [Description("전일KSE대용증거금	long	16")] long PrdayKseSubstMgn, [Description("전일KSE신용현금증거금	long	16")] long PrdayKseCrdtMnyMgn, [Description("전일KSE신용대용증거금	long	16")] long PrdayKseCrdtSubstMgn, [Description("금일KSE현금증거금	long	16")] long CrdayKseMnyMgn, [Description("금일KSE대용증거금	long	16")] long CrdayKseSubstMgn, [Description("금일KSE신용현금증거금	long	16")] long CrdayKseCrdtMnyMgn, [Description("금일KSE신용대용증거금	long	16")] long CrdayKseCrdtSubstMgn, [Description("전일코스닥현금증거금	long	16")] long PrdayKdqMnyMgn, [Description("전일코스닥대용증거금	long	16")] long PrdayKdqSubstMgn, [Description("전일코스닥신용현금증거금	long	16")] long PrdayKdqCrdtMnyMgn, [Description("전일코스닥신용대용증거금	long	16")] long PrdayKdqCrdtSubstMgn, [Description("금일코스닥현금증거금	long	16")] long CrdayKdqMnyMgn, [Description("금일코스닥대용증거금	long	16")] long CrdayKdqSubstMgn, [Description("금일코스닥신용현금증거금	long	16")] long CrdayKdqCrdtMnyMgn, [Description("금일코스닥신용대용증거금	long	16")] long CrdayKdqCrdtSubstMgn, [Description("전일프리보드현금증거금	long	16")] long PrdayFrbrdMnyMgn, [Description("전일프리보드대용증거금	long	16")] long PrdayFrbrdSubstMgn, [Description("금일프리보드현금증거금	long	16")] long CrdayFrbrdMnyMgn, [Description("금일프리보드대용증거금	long	16")] long CrdayFrbrdSubstMgn, [Description("전일장외현금증거금	long	16")] long PrdayCrbmkMnyMgn, [Description("전일장외대용증거금	long	16")] long PrdayCrbmkSubstMgn, [Description("금일장외현금증거금	long	16")] long CrdayCrbmkMnyMgn, [Description("금일장외대용증거금	long	16")] long CrdayCrbmkSubstMgn, [Description("예탁담보수량	long	16")] long DpspdgQty, [Description("매수정산금(D+2)	long	16")] long BuyAdjstAmtD2, [Description("매도정산금(D+2)	long	16")] long SellAdjstAmtD2, [Description("변제소요금(D+1)	long	16")] long RepayRqrdAmtD1, [Description("변제소요금(D+2)	long	16")] long RepayRqrdAmtD2, [Description("대출금액	long	16")] long LoanAmt);

/// <summary>
/// BEP단가조회: CSPAQ12300: OutBlock3
/// </summary>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="SecBalPtnCode">유가증권잔고유형코드	string	2</param>
/// <param name="SecBalPtnNm">유가증권잔고유형명	string	40</param>
/// <param name="BalQty">잔고수량	long	16</param>
/// <param name="BnsBaseBalQty">매매기준잔고수량	long	16</param>
/// <param name="CrdayBuyExecQty">금일매수체결수량	long	16</param>
/// <param name="CrdaySellExecQty">금일매도체결수량	long	16</param>
/// <param name="SellPrc">매도가	double	21.4</param>
/// <param name="BuyPrc">매수가	double	21.4</param>
/// <param name="SellPnlAmt">매도손익금액	long	16</param>
/// <param name="PnlRat">손익율	double	18.6</param>
/// <param name="NowPrc">현재가	double	15.2</param>
/// <param name="CrdtAmt">신용금액	long	16</param>
/// <param name="DueDt">만기일	string	8</param>
/// <param name="PrdaySellExecPrc">전일매도체결가	double	13.2</param>
/// <param name="PrdaySellQty">전일매도수량	long	16</param>
/// <param name="PrdayBuyExecPrc">전일매수체결가	double	13.2</param>
/// <param name="PrdayBuyQty">전일매수수량	long	16</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="AvrUprc">평균단가	double	13.2</param>
/// <param name="SellAbleQty">매도가능수량	long	16</param>
/// <param name="SellOrdQty">매도주문수량	long	16</param>
/// <param name="CrdayBuyExecAmt">금일매수체결금액	long	16</param>
/// <param name="CrdaySellExecAmt">금일매도체결금액	long	16</param>
/// <param name="PrdayBuyExecAmt">전일매수체결금액	long	16</param>
/// <param name="PrdaySellExecAmt">전일매도체결금액	long	16</param>
/// <param name="BalEvalAmt">잔고평가금액	long	16</param>
/// <param name="EvalPnl">평가손익	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
/// <param name="SellUnercQty">매도미체결수량	long	16</param>
/// <param name="SellUnsttQty">매도미결제수량	long	16</param>
/// <param name="BuyUnercQty">매수미체결수량	long	16</param>
/// <param name="BuyUnsttQty">매수미결제수량	long	16</param>
/// <param name="UnsttQty">미결제수량	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="PrdayCprc">전일종가	double	15.2</param>
/// <param name="PchsAmt">매입금액	long	16</param>
/// <param name="RegMktCode">등록시장코드	string	2</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	string	2</param>
/// <param name="DpspdgLoanQty">예탁담보대출수량	long	16</param>
public record CSPAQ12300OutBlock3([Description("종목번호	string	12")] string IsuNo, [Description("종목명	string	40")] string IsuNm, [Description("유가증권잔고유형코드	string	2")] string SecBalPtnCode, [Description("유가증권잔고유형명	string	40")] string SecBalPtnNm, [Description("잔고수량	long	16")] long BalQty, [Description("매매기준잔고수량	long	16")] long BnsBaseBalQty, [Description("금일매수체결수량	long	16")] long CrdayBuyExecQty, [Description("금일매도체결수량	long	16")] long CrdaySellExecQty, [Description("매도가	double	21.4")] double SellPrc, [Description("매수가	double	21.4")] double BuyPrc, [Description("매도손익금액	long	16")] long SellPnlAmt, [Description("손익율	double	18.6")] double PnlRat, [Description("현재가	double	15.2")] double NowPrc, [Description("신용금액	long	16")] long CrdtAmt, [Description("만기일	string	8")] string DueDt, [Description("전일매도체결가	double	13.2")] double PrdaySellExecPrc, [Description("전일매도수량	long	16")] long PrdaySellQty, [Description("전일매수체결가	double	13.2")] double PrdayBuyExecPrc, [Description("전일매수수량	long	16")] long PrdayBuyQty, [Description("대출일	string	8")] string LoanDt, [Description("평균단가	double	13.2")] double AvrUprc, [Description("매도가능수량	long	16")] long SellAbleQty, [Description("매도주문수량	long	16")] long SellOrdQty, [Description("금일매수체결금액	long	16")] long CrdayBuyExecAmt, [Description("금일매도체결금액	long	16")] long CrdaySellExecAmt, [Description("전일매수체결금액	long	16")] long PrdayBuyExecAmt, [Description("전일매도체결금액	long	16")] long PrdaySellExecAmt, [Description("잔고평가금액	long	16")] long BalEvalAmt, [Description("평가손익	long	16")] long EvalPnl, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("주문가능금액	long	16")] long OrdAbleAmt, [Description("매도미체결수량	long	16")] long SellUnercQty, [Description("매도미결제수량	long	16")] long SellUnsttQty, [Description("매수미체결수량	long	16")] long BuyUnercQty, [Description("매수미결제수량	long	16")] long BuyUnsttQty, [Description("미결제수량	long	16")] long UnsttQty, [Description("미체결수량	long	16")] long UnercQty, [Description("전일종가	double	15.2")] double PrdayCprc, [Description("매입금액	long	16")] long PchsAmt, [Description("등록시장코드	string	2")] string RegMktCode, [Description("대출상세분류코드	string	2")] string LoanDtlClssCode, [Description("예탁담보대출수량	long	16")] long DpspdgLoanQty);


/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="ExecYn">체결여부	string	1</param>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="SrtOrdNo2">시작주문번호2	long	10</param>
/// <param name="BkseqTpCode">역순구분	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
public record CSPAQ13700InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("매매구분	string	1")] string BnsTpCode, [Description("종목번호	string	12")] string IsuNo, [Description("체결여부	string	1")] string ExecYn, [Description("주문일	string	8")] string OrdDt, [Description("시작주문번호2	long	10")] long SrtOrdNo2, [Description("역순구분	string	1")] string BkseqTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode);

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="ExecYn">체결여부	string	1</param>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="SrtOrdNo2">시작주문번호2	long	10</param>
/// <param name="BkseqTpCode">역순구분	string	1</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
public record CSPAQ13700OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("매매구분	string	1")] string BnsTpCode, [Description("종목번호	string	12")] string IsuNo, [Description("체결여부	string	1")] string ExecYn, [Description("주문일	string	8")] string OrdDt, [Description("시작주문번호2	long	10")] long SrtOrdNo2, [Description("역순구분	string	1")] string BkseqTpCode, [Description("주문유형코드	string	2")] string OrdPtnCode);

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="SellExecAmt">매도체결금액	long	16</param>
/// <param name="BuyExecAmt">매수체결금액	long	16</param>
/// <param name="SellExecQty">매도체결수량	long	16</param>
/// <param name="BuyExecQty">매수체결수량	long	16</param>
/// <param name="SellOrdQty">매도주문수량	long	16</param>
/// <param name="BuyOrdQty">매수주문수량	long	16</param>
public record CSPAQ13700OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("매도체결금액	long	16")] long SellExecAmt, [Description("매수체결금액	long	16")] long BuyExecAmt, [Description("매도체결수량	long	16")] long SellExecQty, [Description("매수체결수량	long	16")] long BuyExecQty, [Description("매도주문수량	long	16")] long SellOrdQty, [Description("매수주문수량	long	16")] long BuyOrdQty);

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700: OutBlock3
/// </summary>
/// <param name="OrdDt">주문일	string	8</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="BnsTpNm">매매구분	string	10</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="OrdPtnNm">주문유형명	string	40</param>
/// <param name="OrdTrxPtnCode">주문처리유형코드	long	9</param>
/// <param name="OrdTrxPtnNm">주문처리유형명	string	50</param>
/// <param name="MrcTpCode">정정취소구분	string	1</param>
/// <param name="MrcTpNm">정정취소구분명	string	10</param>
/// <param name="MrcQty">정정취소수량	long	16</param>
/// <param name="MrcAbleQty">정정취소가능수량	long	16</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="ExecPrc">체결가	double	15.2</param>
/// <param name="ExecTrxTime">체결처리시각	string	9</param>
/// <param name="LastExecTime">최종체결시각	string	9</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="OrdprcPtnNm">호가유형명	string	40</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
/// <param name="AllExecQty">전체체결수량	long	16</param>
/// <param name="RegCommdaCode">통신매체코드	string	2</param>
/// <param name="CommdaNm">통신매체명	string	40</param>
/// <param name="MbrNo">회원번호	string	3</param>
/// <param name="RsvOrdYn">예약주문여부	string	1</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="OpDrtnNo">운용지시번호	string	12</param>
/// <param name="OdrrId">주문자ID	string	16</param>
public record CSPAQ13700OutBlock3([Description("주문일	string	8")] string OrdDt, [Description("관리지점번호	string	3")] string MgmtBrnNo, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("주문번호	long	10")] long OrdNo, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("종목번호	string	12")] string IsuNo, [Description("종목명	string	40")] string IsuNm, [Description("매매구분	string	1")] string BnsTpCode, [Description("매매구분	string	10")] string BnsTpNm, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("주문유형명	string	40")] string OrdPtnNm, [Description("주문처리유형코드	long	9")] long OrdTrxPtnCode, [Description("주문처리유형명	string	50")] string OrdTrxPtnNm, [Description("정정취소구분	string	1")] string MrcTpCode, [Description("정정취소구분명	string	10")] string MrcTpNm, [Description("정정취소수량	long	16")] long MrcQty, [Description("정정취소가능수량	long	16")] long MrcAbleQty, [Description("주문수량	long	16")] long OrdQty, [Description("주문가격	double	15.2")] double OrdPrc, [Description("체결수량	long	16")] long ExecQty, [Description("체결가	double	15.2")] double ExecPrc, [Description("체결처리시각	string	9")] string ExecTrxTime, [Description("최종체결시각	string	9")] string LastExecTime, [Description("호가유형코드	string	2")] string OrdprcPtnCode, [Description("호가유형명	string	40")] string OrdprcPtnNm, [Description("주문조건구분	string	1")] string OrdCndiTpCode, [Description("전체체결수량	long	16")] long AllExecQty, [Description("통신매체코드	string	2")] string RegCommdaCode, [Description("통신매체명	string	40")] string CommdaNm, [Description("회원번호	string	3")] string MbrNo, [Description("예약주문여부	string	1")] string RsvOrdYn, [Description("대출일	string	8")] string LoanDt, [Description("주문시각	string	9")] string OrdTime, [Description("운용지시번호	string	12")] string OpDrtnNo, [Description("주문자ID	string	16")] string OdrrId);


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ22200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("관리지점번호	string	3")] string MgmtBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp);

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ22200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("관리지점번호	string	3")] string MgmtBrnNo, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("잔고생성구분	string	1")] string BalCreTp);

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BrnNm">지점명	string	40</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	long	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	long	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	long	16</param>
/// <param name="CrdtPldgOrdAmt">신용담보주문금액	long	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat35ordAbleAmt">증거금률35%주문가능금액	long	16</param>
/// <param name="MgnRat50ordAbleAmt">증거금률50%주문가능금액	long	16</param>
/// <param name="CrdtOrdAbleAmt">신용주문가능금액	long	16</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="SubstAmt">대용금액	long	16</param>
/// <param name="MgnMny">증거금현금	long	16</param>
/// <param name="MgnSubst">증거금대용	long	16</param>
/// <param name="D1Dps">D1예수금	long	16</param>
/// <param name="D2Dps">D2예수금	long	16</param>
/// <param name="RcvblAmt">미수금액	long	16</param>
/// <param name="D1ovdRepayRqrdAmt">D1연체변제소요금액	long	16</param>
/// <param name="D2ovdRepayRqrdAmt">D2연체변제소요금액	long	16</param>
/// <param name="MloanAmt">융자금액	long	16</param>
/// <param name="ChgAfPldgRat">변경후담보비율	double	9.3</param>
/// <param name="RqrdPldgAmt">소요담보금액	long	16</param>
/// <param name="PdlckAmt">담보부족금액	long	16</param>
/// <param name="OrgPldgSumAmt">원담보합계금액	long	16</param>
/// <param name="SubPldgSumAmt">부담보합계금액	long	16</param>
/// <param name="CrdtPldgAmtMny">신용담보금현금	long	16</param>
/// <param name="CrdtPldgSubstAmt">신용담보대용금액	long	16</param>
/// <param name="Imreq">신용설정보증금	long	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	long	16</param>
/// <param name="DpslRestrcAmt">처분제한금액	long	16</param>
/// <param name="PrdaySellAdjstAmt">전일매도정산금액	long	16</param>
/// <param name="PrdayBuyAdjstAmt">전일매수정산금액	long	16</param>
/// <param name="CrdaySellAdjstAmt">금일매도정산금액	long	16</param>
/// <param name="CrdayBuyAdjstAmt">금일매수정산금액	long	16</param>
/// <param name="CslLoanAmtdt1">매도대금담보대출금액	long	16</param>
public record CSPAQ22200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("지점명	string	40")] string BrnNm, [Description("계좌명	string	40")] string AcntNm, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("대용주문가능금액	long	16")] long SubstOrdAbleAmt, [Description("거래소금액	long	16")] long SeOrdAbleAmt, [Description("코스닥금액	long	16")] long KdqOrdAbleAmt, [Description("신용담보주문금액	long	16")] long CrdtPldgOrdAmt, [Description("증거금률100퍼센트주문가능금액	long	16")] long MgnRat100pctOrdAbleAmt, [Description("증거금률35%주문가능금액	long	16")] long MgnRat35ordAbleAmt, [Description("증거금률50%주문가능금액	long	16")] long MgnRat50ordAbleAmt, [Description("신용주문가능금액	long	16")] long CrdtOrdAbleAmt, [Description("예수금	long	16")] long Dps, [Description("대용금액	long	16")] long SubstAmt, [Description("증거금현금	long	16")] long MgnMny, [Description("증거금대용	long	16")] long MgnSubst, [Description("D1예수금	long	16")] long D1Dps, [Description("D2예수금	long	16")] long D2Dps, [Description("미수금액	long	16")] long RcvblAmt, [Description("D1연체변제소요금액	long	16")] long D1ovdRepayRqrdAmt, [Description("D2연체변제소요금액	long	16")] long D2ovdRepayRqrdAmt, [Description("융자금액	long	16")] long MloanAmt, [Description("변경후담보비율	double	9.3")] double ChgAfPldgRat, [Description("소요담보금액	long	16")] long RqrdPldgAmt, [Description("담보부족금액	long	16")] long PdlckAmt, [Description("원담보합계금액	long	16")] long OrgPldgSumAmt, [Description("부담보합계금액	long	16")] long SubPldgSumAmt, [Description("신용담보금현금	long	16")] long CrdtPldgAmtMny, [Description("신용담보대용금액	long	16")] long CrdtPldgSubstAmt, [Description("신용설정보증금	long	16")] long Imreq, [Description("신용담보재사용금액	long	16")] long CrdtPldgRuseAmt, [Description("처분제한금액	long	16")] long DpslRestrcAmt, [Description("전일매도정산금액	long	16")] long PrdaySellAdjstAmt, [Description("전일매수정산금액	long	16")] long PrdayBuyAdjstAmt, [Description("금일매도정산금액	long	16")] long CrdaySellAdjstAmt, [Description("금일매수정산금액	long	16")] long CrdayBuyAdjstAmt, [Description("매도대금담보대출금액	long	16")] long CslLoanAmtdt1);


/// <summary>
/// 현물주문: CSPAT00600: InBlock1
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="MgntrnCode">신용거래코드	string	3</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
public record CSPAT00600InBlock1([Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty, [Description("주문가	double	13.2")] double OrdPrc, [Description("매매구분	string	1")] string BnsTpCode, [Description("호가유형코드	string	2")] string OrdprcPtnCode, [Description("신용거래코드	string	3")] string MgntrnCode, [Description("대출일	string	8")] string LoanDt, [Description("주문조건구분	string	1")] string OrdCndiTpCode);

/// <summary>
/// 현물주문: CSPAT00600: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	string	2</param>
/// <param name="StslAbleYn">공매도가능여부	string	1</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	string	1</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="MgntrnCode">신용거래코드	string	3</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="MbrNo">회원번호	string	3</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
/// <param name="StrtgCode">전략코드	string	6</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="OrdSeqNo">주문회차	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">아이템번호	long	10</param>
/// <param name="OpDrtnNo">운용지시번호	string	12</param>
/// <param name="LpYn">유동성공급자여부	string	1</param>
/// <param name="CvrgTpCode">반대매매구분	string	1</param>
public record CSPAT00600OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty, [Description("주문가	double	13.2")] double OrdPrc, [Description("매매구분	string	1")] string BnsTpCode, [Description("호가유형코드	string	2")] string OrdprcPtnCode, [Description("프로그램호가유형코드	string	2")] string PrgmOrdprcPtnCode, [Description("공매도가능여부	string	1")] string StslAbleYn, [Description("공매도호가구분	string	1")] string StslOrdprcTpCode, [Description("통신매체코드	string	2")] string CommdaCode, [Description("신용거래코드	string	3")] string MgntrnCode, [Description("대출일	string	8")] string LoanDt, [Description("회원번호	string	3")] string MbrNo, [Description("주문조건구분	string	1")] string OrdCndiTpCode, [Description("전략코드	string	6")] string StrtgCode, [Description("그룹ID	string	20")] string GrpId, [Description("주문회차	long	10")] long OrdSeqNo, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("아이템번호	long	10")] long ItemNo, [Description("운용지시번호	string	12")] string OpDrtnNo, [Description("유동성공급자여부	string	1")] string LpYn, [Description("반대매매구분	string	1")] string CvrgTpCode);

/// <summary>
/// 현물주문: CSPAT00600: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="ShtnIsuNo">단축종목번호	string	9</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="SpareOrdNo">예비주문번호	long	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	long	10</param>
/// <param name="RsvOrdNo">예약주문번호	long	10</param>
/// <param name="SpotOrdQty">실물주문수량	long	16</param>
/// <param name="RuseOrdQty">재사용주문수량	long	16</param>
/// <param name="MnyOrdAmt">현금주문금액	long	16</param>
/// <param name="SubstOrdAmt">대용주문금액	long	16</param>
/// <param name="RuseOrdAmt">재사용주문금액	long	16</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	40</param>
public record CSPAT00600OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("단축종목번호	string	9")] string ShtnIsuNo, [Description("관리사원번호	string	9")] string MgempNo, [Description("주문금액	long	16")] long OrdAmt, [Description("예비주문번호	long	10")] long SpareOrdNo, [Description("반대매매일련번호	long	10")] long CvrgSeqno, [Description("예약주문번호	long	10")] long RsvOrdNo, [Description("실물주문수량	long	16")] long SpotOrdQty, [Description("재사용주문수량	long	16")] long RuseOrdQty, [Description("현금주문금액	long	16")] long MnyOrdAmt, [Description("대용주문금액	long	16")] long SubstOrdAmt, [Description("재사용주문금액	long	16")] long RuseOrdAmt, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	40")] string IsuNm);


/// <summary>
/// 현물정정주문: CSPAT00700: InBlock1
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
public record CSPAT00700InBlock1([Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty, [Description("호가유형코드	string	2")] string OrdprcPtnCode, [Description("주문조건구분	string	1")] string OrdCndiTpCode, [Description("주문가	double	13.2")] double OrdPrc);

/// <summary>
/// 현물정정주문: CSPAT00700: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="StrtgCode">전략코드	string	6</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="OrdSeqNo">주문회차	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">아이템번호	long	10</param>
public record CSPAT00700OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty, [Description("호가유형코드	string	2")] string OrdprcPtnCode, [Description("주문조건구분	string	1")] string OrdCndiTpCode, [Description("주문가	double	13.2")] double OrdPrc, [Description("통신매체코드	string	2")] string CommdaCode, [Description("전략코드	string	6")] string StrtgCode, [Description("그룹ID	string	20")] string GrpId, [Description("주문회차	long	10")] long OrdSeqNo, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("아이템번호	long	10")] long ItemNo);

/// <summary>
/// 현물정정주문: CSPAT00700: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="PrntOrdNo">모주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="ShtnIsuNo">단축종목번호	string	9</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	string	2</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	string	1</param>
/// <param name="StslAbleYn">공매도가능여부	string	1</param>
/// <param name="MgntrnCode">신용거래코드	string	3</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="CvrgOrdTp">반대매매주문구분	string	1</param>
/// <param name="LpYn">유동성공급자여부	string	1</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="OrdAmt">주문금액	long	16</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="SpareOrdNo">예비주문번호	long	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	long	10</param>
/// <param name="RsvOrdNo">예약주문번호	long	10</param>
/// <param name="MnyOrdAmt">현금주문금액	long	16</param>
/// <param name="SubstOrdAmt">대용주문금액	long	16</param>
/// <param name="RuseOrdAmt">재사용주문금액	long	16</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	40</param>
public record CSPAT00700OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("모주문번호	long	10")] long PrntOrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("단축종목번호	string	9")] string ShtnIsuNo, [Description("프로그램호가유형코드	string	2")] string PrgmOrdprcPtnCode, [Description("공매도호가구분	string	1")] string StslOrdprcTpCode, [Description("공매도가능여부	string	1")] string StslAbleYn, [Description("신용거래코드	string	3")] string MgntrnCode, [Description("대출일	string	8")] string LoanDt, [Description("반대매매주문구분	string	1")] string CvrgOrdTp, [Description("유동성공급자여부	string	1")] string LpYn, [Description("관리사원번호	string	9")] string MgempNo, [Description("주문금액	long	16")] long OrdAmt, [Description("매매구분	string	1")] string BnsTpCode, [Description("예비주문번호	long	10")] long SpareOrdNo, [Description("반대매매일련번호	long	10")] long CvrgSeqno, [Description("예약주문번호	long	10")] long RsvOrdNo, [Description("현금주문금액	long	16")] long MnyOrdAmt, [Description("대용주문금액	long	16")] long SubstOrdAmt, [Description("재사용주문금액	long	16")] long RuseOrdAmt, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	40")] string IsuNm);


/// <summary>
/// 현물취소주문: CSPAT00800: InBlock1
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CSPAT00800InBlock1([Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty);

/// <summary>
/// 현물취소주문: CSPAT00800: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
/// <param name="GrpId">그룹ID	string	20</param>
/// <param name="StrtgCode">전략코드	string	6</param>
/// <param name="OrdSeqNo">주문회차	long	10</param>
/// <param name="PtflNo">포트폴리오번호	long	10</param>
/// <param name="BskNo">바스켓번호	long	10</param>
/// <param name="TrchNo">트렌치번호	long	10</param>
/// <param name="ItemNo">아이템번호	long	10</param>
public record CSPAT00800OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("원주문번호	long	10")] long OrgOrdNo, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문수량	long	16")] long OrdQty, [Description("통신매체코드	string	2")] string CommdaCode, [Description("그룹ID	string	20")] string GrpId, [Description("전략코드	string	6")] string StrtgCode, [Description("주문회차	long	10")] long OrdSeqNo, [Description("포트폴리오번호	long	10")] long PtflNo, [Description("바스켓번호	long	10")] long BskNo, [Description("트렌치번호	long	10")] long TrchNo, [Description("아이템번호	long	10")] long ItemNo);

/// <summary>
/// 현물취소주문: CSPAT00800: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdNo">주문번호	long	10</param>
/// <param name="PrntOrdNo">모주문번호	long	10</param>
/// <param name="OrdTime">주문시각	string	9</param>
/// <param name="OrdMktCode">주문시장코드	string	2</param>
/// <param name="OrdPtnCode">주문유형코드	string	2</param>
/// <param name="ShtnIsuNo">단축종목번호	string	9</param>
/// <param name="PrgmOrdprcPtnCode">프로그램호가유형코드	string	2</param>
/// <param name="StslOrdprcTpCode">공매도호가구분	string	1</param>
/// <param name="StslAbleYn">공매도가능여부	string	1</param>
/// <param name="MgntrnCode">신용거래코드	string	3</param>
/// <param name="LoanDt">대출일	string	8</param>
/// <param name="CvrgOrdTp">반대매매주문구분	string	1</param>
/// <param name="LpYn">유동성공급자여부	string	1</param>
/// <param name="MgempNo">관리사원번호	string	9</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="SpareOrdNo">예비주문번호	long	10</param>
/// <param name="CvrgSeqno">반대매매일련번호	long	10</param>
/// <param name="RsvOrdNo">예약주문번호	long	10</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	40</param>
public record CSPAT00800OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("주문번호	long	10")] long OrdNo, [Description("모주문번호	long	10")] long PrntOrdNo, [Description("주문시각	string	9")] string OrdTime, [Description("주문시장코드	string	2")] string OrdMktCode, [Description("주문유형코드	string	2")] string OrdPtnCode, [Description("단축종목번호	string	9")] string ShtnIsuNo, [Description("프로그램호가유형코드	string	2")] string PrgmOrdprcPtnCode, [Description("공매도호가구분	string	1")] string StslOrdprcTpCode, [Description("공매도가능여부	string	1")] string StslAbleYn, [Description("신용거래코드	string	3")] string MgntrnCode, [Description("대출일	string	8")] string LoanDt, [Description("반대매매주문구분	string	1")] string CvrgOrdTp, [Description("유동성공급자여부	string	1")] string LpYn, [Description("관리사원번호	string	9")] string MgempNo, [Description("매매구분	string	1")] string BnsTpCode, [Description("예비주문번호	long	10")] long SpareOrdNo, [Description("반대매매일련번호	long	10")] long CvrgSeqno, [Description("예약주문번호	long	10")] long RsvOrdNo, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	40")] string IsuNm);


/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="RegCommdaCode">통신매체코드	string	2</param>
public record CSPBQ00200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("매매구분	string	1")] string BnsTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문가격	double	15.2")] double OrdPrc, [Description("통신매체코드	string	2")] string RegCommdaCode);

/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="RegCommdaCode">통신매체코드	string	2</param>
public record CSPBQ00200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("매매구분	string	1")] string BnsTpCode, [Description("계좌번호	string	20")] string AcntNo, [Description("입력비밀번호	string	8")] string InptPwd, [Description("종목번호	string	12")] string IsuNo, [Description("주문가격	double	15.2")] double OrdPrc, [Description("통신매체코드	string	2")] string RegCommdaCode);

/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="IsuNm">종목명	string	40</param>
/// <param name="Dps">예수금	long	16</param>
/// <param name="SubstAmt">대용금액	long	16</param>
/// <param name="CrdtPldgRuseAmt">신용담보재사용금액	long	16</param>
/// <param name="MnyOrdAbleAmt">현금주문가능금액	long	16</param>
/// <param name="SubstOrdAbleAmt">대용주문가능금액	long	16</param>
/// <param name="MnyMgn">현금증거금액	long	16</param>
/// <param name="SubstMgn">대용증거금액	long	16</param>
/// <param name="SeOrdAbleAmt">거래소금액	long	16</param>
/// <param name="KdqOrdAbleAmt">코스닥금액	long	16</param>
/// <param name="PrsmptDpsD1">추정예수금(D+1)	long	16</param>
/// <param name="PrsmptDpsD2">추정예수금(D+2)	long	16</param>
/// <param name="MnyoutAbleAmt">출금가능금액	long	16</param>
/// <param name="RcvblAmt">미수금액	long	16</param>
/// <param name="CmsnRat">수수료율	double	15.5</param>
/// <param name="AddLevyAmt">추가징수금액	long	16</param>
/// <param name="RuseObjAmt">재사용대상금액	long	16</param>
/// <param name="MnyRuseObjAmt">현금재사용대상금액	long	16</param>
/// <param name="FirmMgnRat">이용사증거금률	double	7.4</param>
/// <param name="SubstRuseObjAmt">대용재사용대상금액	long	16</param>
/// <param name="IsuMgnRat">종목증거금률	double	7.4</param>
/// <param name="AcntMgnRat">계좌증거금률	double	7.4</param>
/// <param name="TrdMgnrt">거래증거금률	double	7.4</param>
/// <param name="Cmsn">수수료	long	16</param>
/// <param name="MgnRat20pctOrdAbleAmt">증거금률20퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat20OrdAbleQty">증거금률100퍼센트현금주문가능수량?	long	16</param>
/// <param name="MgnRat30pctOrdAbleAmt">증거금률30퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat30OrdAbleQty">증거금률30퍼센트주문가능수량??	long	16</param>
/// <param name="MgnRat40pctOrdAbleAmt">증거금률40퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat40OrdAbleQty">증거금률40퍼센트주문가능수량??	long	16</param>
/// <param name="MgnRat100pctOrdAbleAmt">증거금률100퍼센트주문가능금액	long	16</param>
/// <param name="MgnRat100OrdAbleQty">증거금률100퍼센트주문가능수량??	long	16</param>
/// <param name="MgnRat100MnyOrdAbleAmt">증거금률100퍼센트현금주문가능금액?	long	16</param>
/// <param name="MgnRat100MnyOrdAbleQty">증거금률100퍼센트현금주문가능수량	long	16</param>
/// <param name="MgnRat20pctRuseAbleAmt">증거금률20퍼센트재사용가능금액	long	16</param>
/// <param name="MgnRat30pctRuseAbleAmt">증거금률30퍼센트재사용가능금액	long	16</param>
/// <param name="MgnRat40pctRuseAbleAmt">증거금률40퍼센트재사용가능금액	long	16</param>
/// <param name="MgnRat100pctRuseAbleAmt">증거금률100퍼센트재사용가능금액	long	16</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
/// <param name="OrdAbleAmt">주문가능금액	long	16</param>
public record CSPBQ00200OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("종목명	string	40")] string IsuNm, [Description("예수금	long	16")] long Dps, [Description("대용금액	long	16")] long SubstAmt, [Description("신용담보재사용금액	long	16")] long CrdtPldgRuseAmt, [Description("현금주문가능금액	long	16")] long MnyOrdAbleAmt, [Description("대용주문가능금액	long	16")] long SubstOrdAbleAmt, [Description("현금증거금액	long	16")] long MnyMgn, [Description("대용증거금액	long	16")] long SubstMgn, [Description("거래소금액	long	16")] long SeOrdAbleAmt, [Description("코스닥금액	long	16")] long KdqOrdAbleAmt, [Description("추정예수금(D+1)	long	16")] long PrsmptDpsD1, [Description("추정예수금(D+2)	long	16")] long PrsmptDpsD2, [Description("출금가능금액	long	16")] long MnyoutAbleAmt, [Description("미수금액	long	16")] long RcvblAmt, [Description("수수료율	double	15.5")] double CmsnRat, [Description("추가징수금액	long	16")] long AddLevyAmt, [Description("재사용대상금액	long	16")] long RuseObjAmt, [Description("현금재사용대상금액	long	16")] long MnyRuseObjAmt, [Description("이용사증거금률	double	7.4")] double FirmMgnRat, [Description("대용재사용대상금액	long	16")] long SubstRuseObjAmt, [Description("종목증거금률	double	7.4")] double IsuMgnRat, [Description("계좌증거금률	double	7.4")] double AcntMgnRat, [Description("거래증거금률	double	7.4")] double TrdMgnrt, [Description("수수료	long	16")] long Cmsn, [Description("증거금률20퍼센트주문가능금액	long	16")] long MgnRat20pctOrdAbleAmt, [Description("증거금률100퍼센트현금주문가능수량?	long	16")] long MgnRat20OrdAbleQty, [Description("증거금률30퍼센트주문가능금액	long	16")] long MgnRat30pctOrdAbleAmt, [Description("증거금률30퍼센트주문가능수량??	long	16")] long MgnRat30OrdAbleQty, [Description("증거금률40퍼센트주문가능금액	long	16")] long MgnRat40pctOrdAbleAmt, [Description("증거금률40퍼센트주문가능수량??	long	16")] long MgnRat40OrdAbleQty, [Description("증거금률100퍼센트주문가능금액	long	16")] long MgnRat100pctOrdAbleAmt, [Description("증거금률100퍼센트주문가능수량??	long	16")] long MgnRat100OrdAbleQty, [Description("증거금률100퍼센트현금주문가능금액?	long	16")] long MgnRat100MnyOrdAbleAmt, [Description("증거금률100퍼센트현금주문가능수량	long	16")] long MgnRat100MnyOrdAbleQty, [Description("증거금률20퍼센트재사용가능금액	long	16")] long MgnRat20pctRuseAbleAmt, [Description("증거금률30퍼센트재사용가능금액	long	16")] long MgnRat30pctRuseAbleAmt, [Description("증거금률40퍼센트재사용가능금액	long	16")] long MgnRat40pctRuseAbleAmt, [Description("증거금률100퍼센트재사용가능금액	long	16")] long MgnRat100pctRuseAbleAmt, [Description("주문가능수량	long	16")] long OrdAbleQty, [Description("주문가능금액	long	16")] long OrdAbleAmt);


/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="TermTp">기간구분	string	1</param>
public record FOCCQ33600InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("기간구분	string	1")] string TermTp);

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="TermTp">기간구분	string	1</param>
public record FOCCQ33600OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("기간구분	string	1")] string TermTp);

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="BnsctrAmt">매매약정금액	long	16</param>
/// <param name="MnyinAmt">입금금액	long	16</param>
/// <param name="MnyoutAmt">출금금액	long	16</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	long	16</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="InvstErnrat">투자수익률	double	9.2</param>
public record FOCCQ33600OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("매매약정금액	long	16")] long BnsctrAmt, [Description("입금금액	long	16")] long MnyinAmt, [Description("출금금액	long	16")] long MnyoutAmt, [Description("투자원금평잔금액	long	16")] long InvstAvrbalPramt, [Description("투자손익금액	long	16")] long InvstPlAmt, [Description("투자수익률	double	9.2")] double InvstErnrat);

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600: OutBlock3
/// </summary>
/// <param name="BaseDt">기준일	string	8</param>
/// <param name="FdEvalAmt">기초평가금액	long	19</param>
/// <param name="EotEvalAmt">기말평가금액	long	19</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	long	16</param>
/// <param name="BnsctrAmt">매매약정금액	long	16</param>
/// <param name="MnyinSecinAmt">입금고액	long	16</param>
/// <param name="MnyoutSecoutAmt">출금고액	long	16</param>
/// <param name="EvalPnlAmt">평가손익금액	long	16</param>
/// <param name="TermErnrat">기간수익률	double	11.3</param>
/// <param name="Idx">지수	double	13.2</param>
public record FOCCQ33600OutBlock3([Description("기준일	string	8")] string BaseDt, [Description("기초평가금액	long	19")] long FdEvalAmt, [Description("기말평가금액	long	19")] long EotEvalAmt, [Description("투자원금평잔금액	long	16")] long InvstAvrbalPramt, [Description("매매약정금액	long	16")] long BnsctrAmt, [Description("입금고액	long	16")] long MnyinSecinAmt, [Description("출금고액	long	16")] long MnyoutSecoutAmt, [Description("평가손익금액	long	16")] long EvalPnlAmt, [Description("기간수익률	double	11.3")] double TermErnrat, [Description("지수	double	13.2")] double Idx);


/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="BaseAmtTp">기준금액구분	string	1</param>
/// <param name="QryTermTp">조회기간구분	string	1</param>
/// <param name="PnlCalcTpCode">손익산출구분코드	string	1</param>
public record FOCCQ33700InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("조회구분	string	1")] string QryTp, [Description("기준금액구분	string	1")] string BaseAmtTp, [Description("조회기간구분	string	1")] string QryTermTp, [Description("손익산출구분코드	string	1")] string PnlCalcTpCode);

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="BaseAmtTp">기준금액구분	string	1</param>
/// <param name="QryTermTp">조회기간구분	string	1</param>
/// <param name="PnlCalcTpCode">손익산출구분코드	string	1</param>
public record FOCCQ33700OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌번호	string	20")] string AcntNo, [Description("비밀번호	string	8")] string Pwd, [Description("조회시작일	string	8")] string QrySrtDt, [Description("조회종료일	string	8")] string QryEndDt, [Description("조회구분	string	1")] string QryTp, [Description("기준금액구분	string	1")] string BaseAmtTp, [Description("조회기간구분	string	1")] string QryTermTp, [Description("손익산출구분코드	string	1")] string PnlCalcTpCode);

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700: OutBlock2
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="InAmt">입금액	long	16</param>
/// <param name="OutAmt">출금액	long	16</param>
/// <param name="FnoCtrctAmt">선물옵션약정금액	long	16</param>
/// <param name="InvstPramtAvrbalAmt">투자원금평잔금액	long	16</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	long	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	long	16</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="ErnRat">수익률	double	12.6</param>
public record FOCCQ33700OutBlock2([Description("레코드갯수	int	5")] int RecCnt, [Description("계좌명	string	40")] string AcntNm, [Description("입금액	long	16")] long InAmt, [Description("출금액	long	16")] long OutAmt, [Description("선물옵션약정금액	long	16")] long FnoCtrctAmt, [Description("투자원금평잔금액	long	16")] long InvstPramtAvrbalAmt, [Description("선물정산차금	long	16")] long FutsAdjstDfamt, [Description("옵션매매손익금액	long	16")] long OptBsnPnlAmt, [Description("옵션평가손익금액	long	16")] long OptEvalPnlAmt, [Description("투자손익금액	long	16")] long InvstPlAmt, [Description("수익률	double	12.6")] double ErnRat);

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700: OutBlock3
/// </summary>
/// <param name="TrdDt">거래일	string	8</param>
/// <param name="FdDpsastAmt">기초예탁자산금액	long	16</param>
/// <param name="EotDpsastAmt">기말예탁자산금액	long	16</param>
/// <param name="InAmt">입금액	long	16</param>
/// <param name="OutAmt">출금액	long	16</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	long	16</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="Ernrat">수익률	double	12.6</param>
/// <param name="FnoCtrctAmt">선물옵션약정금액	long	16</param>
/// <param name="Trnrat">회전율	double	12.6</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="OptBsnPnlAmt">옵션매매손익금액	long	16</param>
/// <param name="OptEvalPnlAmt">옵션평가손익금액	long	16</param>
public record FOCCQ33700OutBlock3([Description("거래일	string	8")] string TrdDt, [Description("기초예탁자산금액	long	16")] long FdDpsastAmt, [Description("기말예탁자산금액	long	16")] long EotDpsastAmt, [Description("입금액	long	16")] long InAmt, [Description("출금액	long	16")] long OutAmt, [Description("투자원금평잔금액	long	16")] long InvstAvrbalPramt, [Description("투자손익금액	long	16")] long InvstPlAmt, [Description("수익률	double	12.6")] double Ernrat, [Description("선물옵션약정금액	long	16")] long FnoCtrctAmt, [Description("회전율	double	12.6")] double Trnrat, [Description("선물정산차금	long	16")] long FutsAdjstDfamt, [Description("옵션매매손익금액	long	16")] long OptBsnPnlAmt, [Description("옵션평가손익금액	long	16")] long OptEvalPnlAmt);


/// <summary>
/// 파생상품증거금율조회: MMDAQ91200: InBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
public record MMDAQ91200InBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("종목대분류코드	string	2")] string IsuLgclssCode, [Description("종목중분류코드	string	2")] string IsuMdclssCode);

/// <summary>
/// 파생상품증거금율조회: MMDAQ91200: OutBlock1
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
public record MMDAQ91200OutBlock1([Description("레코드갯수	int	5")] int RecCnt, [Description("종목대분류코드	string	2")] string IsuLgclssCode, [Description("종목중분류코드	string	2")] string IsuMdclssCode);

/// <summary>
/// 파생상품증거금율조회: MMDAQ91200: OutBlock2
/// </summary>
/// <param name="IsuSmclssCode">종목소분류코드	string	3</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
/// <param name="IsuLrgMdclssNm">종목대중분류명	string	40</param>
/// <param name="IsuLrgMidSmclssNm">종목대중소분류명	string	40</param>
/// <param name="ShtnHanglIsuNm">단축한글종목명	string	40</param>
/// <param name="CsgnMgnrt">위탁증거금율	double	26.9</param>
/// <param name="MaintMgnrt">유지증거금율	double	26.9</param>
/// <param name="MnyMgnrt">현금증거금율	double	26.9</param>
/// <param name="RmndDays">잔여일수	int	6</param>
/// <param name="OnePrcntrOrdMgn">1계약당주문증거금	long	17</param>
public record MMDAQ91200OutBlock2([Description("종목소분류코드	string	3")] string IsuSmclssCode, [Description("종목중분류코드	string	2")] string IsuMdclssCode, [Description("종목대중분류명	string	40")] string IsuLrgMdclssNm, [Description("종목대중소분류명	string	40")] string IsuLrgMidSmclssNm, [Description("단축한글종목명	string	40")] string ShtnHanglIsuNm, [Description("위탁증거금율	double	26.9")] double CsgnMgnrt, [Description("유지증거금율	double	26.9")] double MaintMgnrt, [Description("현금증거금율	double	26.9")] double MnyMgnrt, [Description("잔여일수	int	6")] int RmndDays, [Description("1계약당주문증거금	long	17")] long OnePrcntrOrdMgn);


/// <summary>
/// 해외선물마스터조회(o3101)-API용: o3101: InBlock
/// </summary>
/// <param name="gubun">입력구분(예비)	string	1</param>
public record o3101InBlock([Description("입력구분(예비)	string	1")] string gubun);

/// <summary>
/// 해외선물마스터조회(o3101)-API용: o3101: OutBlock
/// </summary>
/// <param name="Symbol">종목코드	string	8</param>
/// <param name="SymbolNm">종목명	string	50</param>
/// <param name="ApplDate">종목배치수신일(한국일자)	string	8</param>
/// <param name="BscGdsCd">기초상품코드	string	10</param>
/// <param name="BscGdsNm">기초상품명	string	40</param>
/// <param name="ExchCd">거래소코드	string	10</param>
/// <param name="ExchNm">거래소명	string	40</param>
/// <param name="CrncyCd">기준통화코드	string	3</param>
/// <param name="NotaCd">진법구분코드	string	3</param>
/// <param name="UntPrc">호가단위가격	double	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	double	15.9</param>
/// <param name="RgltFctr">가격조정계수	double	15.1</param>
/// <param name="CtrtPrAmt">계약당금액	double	15.2</param>
/// <param name="GdsCd">상품구분코드	string	3</param>
/// <param name="LstngYr">월물(년)	string	4</param>
/// <param name="LstngM">월물(월)	string	1</param>
/// <param name="EcPrc">정산가격	double	15.9</param>
/// <param name="DlStrtTm">거래시작시간	string	6</param>
/// <param name="DlEndTm">거래종료시간	string	6</param>
/// <param name="DlPsblCd">거래가능구분코드	string	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	string	1</param>
/// <param name="OpngMgn">개시증거금	double	15.2</param>
/// <param name="MntncMgn">유지증거금	double	15.2</param>
/// <param name="OpngMgnR">개시증거금율	double	7.3</param>
/// <param name="MntncMgnR">유지증거금율	double	7.3</param>
/// <param name="DotGb">유효소수점자리수	int	2</param>
public record o3101OutBlock([Description("종목코드	string	8")] string Symbol, [Description("종목명	string	50")] string SymbolNm, [Description("종목배치수신일(한국일자)	string	8")] string ApplDate, [Description("기초상품코드	string	10")] string BscGdsCd, [Description("기초상품명	string	40")] string BscGdsNm, [Description("거래소코드	string	10")] string ExchCd, [Description("거래소명	string	40")] string ExchNm, [Description("기준통화코드	string	3")] string CrncyCd, [Description("진법구분코드	string	3")] string NotaCd, [Description("호가단위가격	double	15.9")] double UntPrc, [Description("최소가격변동금액	double	15.9")] double MnChgAmt, [Description("가격조정계수	double	15.1")] double RgltFctr, [Description("계약당금액	double	15.2")] double CtrtPrAmt, [Description("상품구분코드	string	3")] string GdsCd, [Description("월물(년)	string	4")] string LstngYr, [Description("월물(월)	string	1")] string LstngM, [Description("정산가격	double	15.9")] double EcPrc, [Description("거래시작시간	string	6")] string DlStrtTm, [Description("거래종료시간	string	6")] string DlEndTm, [Description("거래가능구분코드	string	1")] string DlPsblCd, [Description("증거금징수구분코드	string	1")] string MgnCltCd, [Description("개시증거금	double	15.2")] double OpngMgn, [Description("유지증거금	double	15.2")] double MntncMgn, [Description("개시증거금율	double	7.3")] double OpngMgnR, [Description("유지증거금율	double	7.3")] double MntncMgnR, [Description("유효소수점자리수	int	2")] int DotGb);


/// <summary>
/// 해외선물차트(분)(o3103)-API용: o3103: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">N분주기	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3103InBlock([Description("단축코드	string	8")] string shcode, [Description("N분주기	int	4")] int ncnt, [Description("조회건수	int	4")] int readcnt, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	6")] string cts_time);

/// <summary>
/// 해외선물차트(분)(o3103)-API용: o3103: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="timediff">시차	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3103OutBlock([Description("단축코드	string	8")] string shcode, [Description("시차	int	4")] int timediff, [Description("조회건수	int	4")] int readcnt, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	6")] string cts_time);

/// <summary>
/// 해외선물차트(분)(o3103)-API용: o3103: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">현지시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3103OutBlock1([Description("날짜	string	8")] string date, [Description("현지시간	string	6")] string time, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물일별체결조회(o3104)-API용: o3104: InBlock
/// </summary>
/// <param name="gubun">조회구분	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="date">조회일자	string	8</param>
public record o3104InBlock([Description("조회구분	string	1")] string gubun, [Description("단축코드	string	8")] string shcode, [Description("조회일자	string	8")] string date);

/// <summary>
/// 해외선물일별체결조회(o3104)-API용: o3104: OutBlock1
/// </summary>
/// <param name="chedate">일자	string	8</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="cgubun">체결구분	string	1</param>
/// <param name="volume">누적거래량	long	10</param>
public record o3104OutBlock1([Description("일자	string	8")] string chedate, [Description("현재가	double	15.9")] double price, [Description("대비구분	string	1")] string sign, [Description("대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("체결구분	string	1")] string cgubun, [Description("누적거래량	long	10")] long volume);


/// <summary>
/// 해외선물현재가(종목정보)조회(o3105)-API용: o3105: InBlock
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
public record o3105InBlock([Description("종목코드	string	8")] string symbol);

/// <summary>
/// 해외선물현재가(종목정보)조회(o3105)-API용: o3105: OutBlock
/// </summary>
/// <param name="Symbol">종목코드	string	8</param>
/// <param name="SymbolNm">종목명	string	50</param>
/// <param name="ApplDate">종목배치수신일	string	8</param>
/// <param name="BscGdsCd">기초상품코드	string	10</param>
/// <param name="BscGdsNm">기초상품명	string	40</param>
/// <param name="ExchCd">거래소코드	string	10</param>
/// <param name="ExchNm">거래소명	string	40</param>
/// <param name="EcCd">정산구분코드	string	1</param>
/// <param name="CrncyCd">기준통화코드	string	3</param>
/// <param name="NotaCd">진법구분코드	string	3</param>
/// <param name="UntPrc">호가단위가격	double	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	double	15.9</param>
/// <param name="RgltFctr">가격조정계수	double	15.1</param>
/// <param name="CtrtPrAmt">계약당금액	double	15.2</param>
/// <param name="LstngMCnt">상장개월수	int	2</param>
/// <param name="GdsCd">상품구분코드	string	3</param>
/// <param name="MrktCd">시장구분코드	string	3</param>
/// <param name="EminiCd">Emini구분코드	string	1</param>
/// <param name="LstngYr">상장년	string	4</param>
/// <param name="LstngM">상장월	string	1</param>
/// <param name="SeqNo">월물순서	int	5</param>
/// <param name="LstngDt">상장일자	string	8</param>
/// <param name="MtrtDt">최종거래가능일	string	8</param>
/// <param name="FnlDlDt">최종거래일	string	8</param>
/// <param name="FstTrsfrDt">최초인도통지일자	string	8</param>
/// <param name="EcPrc">정산가격	double	15.9</param>
/// <param name="DlDt">거래시작일자(한국)	string	8</param>
/// <param name="DlStrtTm">거래시작시간(한국)	string	6</param>
/// <param name="DlEndTm">거래종료시간(한국)	string	6</param>
/// <param name="OvsStrDay">거래시작일자(현지)	string	8</param>
/// <param name="OvsStrTm">거래시작시간(현지)	string	6</param>
/// <param name="OvsEndDay">거래종료일자(현지)	string	8</param>
/// <param name="OvsEndTm">거래종료시간(현지)	string	6</param>
/// <param name="DlPsblCd">거래가능구분코드	string	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	string	1</param>
/// <param name="OpngMgn">개시증거금	double	15.2</param>
/// <param name="MntncMgn">유지증거금	double	15.2</param>
/// <param name="OpngMgnR">개시증거금율	double	7.3</param>
/// <param name="MntncMgnR">유지증거금율	double	7.3</param>
/// <param name="DotGb">유효소수점자리수	int	2</param>
/// <param name="TimeDiff">시차	int	5</param>
/// <param name="OvsDate">현지체결일자	string	8</param>
/// <param name="KorDate">한국체결일자	string	8</param>
/// <param name="TrdTm">현지체결시간	string	6</param>
/// <param name="RcvTm">한국체결시각	string	6</param>
/// <param name="TrdP">체결가격	double	15.9</param>
/// <param name="TrdQ">체결수량	long	10</param>
/// <param name="TotQ">누적거래량	long	15</param>
/// <param name="TrdAmt">체결거래대금	double	15.2</param>
/// <param name="TotAmt">누적거래대금	double	15.2</param>
/// <param name="OpenP">시가	double	15.9</param>
/// <param name="HighP">고가	double	15.9</param>
/// <param name="LowP">저가	double	15.9</param>
/// <param name="CloseP">전일종가	double	15.9</param>
/// <param name="YdiffP">전일대비	double	15.9</param>
/// <param name="YdiffSign">전일대비구분	string	1</param>
/// <param name="Cgubun">체결구분	string	1</param>
/// <param name="Diff">등락율	double	6.2</param>
public record o3105OutBlock([Description("종목코드	string	8")] string Symbol, [Description("종목명	string	50")] string SymbolNm, [Description("종목배치수신일	string	8")] string ApplDate, [Description("기초상품코드	string	10")] string BscGdsCd, [Description("기초상품명	string	40")] string BscGdsNm, [Description("거래소코드	string	10")] string ExchCd, [Description("거래소명	string	40")] string ExchNm, [Description("정산구분코드	string	1")] string EcCd, [Description("기준통화코드	string	3")] string CrncyCd, [Description("진법구분코드	string	3")] string NotaCd, [Description("호가단위가격	double	15.9")] double UntPrc, [Description("최소가격변동금액	double	15.9")] double MnChgAmt, [Description("가격조정계수	double	15.1")] double RgltFctr, [Description("계약당금액	double	15.2")] double CtrtPrAmt, [Description("상장개월수	int	2")] int LstngMCnt, [Description("상품구분코드	string	3")] string GdsCd, [Description("시장구분코드	string	3")] string MrktCd, [Description("Emini구분코드	string	1")] string EminiCd, [Description("상장년	string	4")] string LstngYr, [Description("상장월	string	1")] string LstngM, [Description("월물순서	int	5")] int SeqNo, [Description("상장일자	string	8")] string LstngDt, [Description("최종거래가능일	string	8")] string MtrtDt, [Description("최종거래일	string	8")] string FnlDlDt, [Description("최초인도통지일자	string	8")] string FstTrsfrDt, [Description("정산가격	double	15.9")] double EcPrc, [Description("거래시작일자(한국)	string	8")] string DlDt, [Description("거래시작시간(한국)	string	6")] string DlStrtTm, [Description("거래종료시간(한국)	string	6")] string DlEndTm, [Description("거래시작일자(현지)	string	8")] string OvsStrDay, [Description("거래시작시간(현지)	string	6")] string OvsStrTm, [Description("거래종료일자(현지)	string	8")] string OvsEndDay, [Description("거래종료시간(현지)	string	6")] string OvsEndTm, [Description("거래가능구분코드	string	1")] string DlPsblCd, [Description("증거금징수구분코드	string	1")] string MgnCltCd, [Description("개시증거금	double	15.2")] double OpngMgn, [Description("유지증거금	double	15.2")] double MntncMgn, [Description("개시증거금율	double	7.3")] double OpngMgnR, [Description("유지증거금율	double	7.3")] double MntncMgnR, [Description("유효소수점자리수	int	2")] int DotGb, [Description("시차	int	5")] int TimeDiff, [Description("현지체결일자	string	8")] string OvsDate, [Description("한국체결일자	string	8")] string KorDate, [Description("현지체결시간	string	6")] string TrdTm, [Description("한국체결시각	string	6")] string RcvTm, [Description("체결가격	double	15.9")] double TrdP, [Description("체결수량	long	10")] long TrdQ, [Description("누적거래량	long	15")] long TotQ, [Description("체결거래대금	double	15.2")] double TrdAmt, [Description("누적거래대금	double	15.2")] double TotAmt, [Description("시가	double	15.9")] double OpenP, [Description("고가	double	15.9")] double HighP, [Description("저가	double	15.9")] double LowP, [Description("전일종가	double	15.9")] double CloseP, [Description("전일대비	double	15.9")] double YdiffP, [Description("전일대비구분	string	1")] string YdiffSign, [Description("체결구분	string	1")] string Cgubun, [Description("등락율	double	6.2")] double Diff);


/// <summary>
/// 해외선물현재가호가조회(o3106)-API용: o3106: InBlock
/// </summary>
/// <param name="symbol">단축코드	string	8</param>
public record o3106InBlock([Description("단축코드	string	8")] string symbol);

/// <summary>
/// 해외선물현재가호가조회(o3106)-API용: o3106: OutBlock
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
/// <param name="symbolname">종목명	string	50</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="jnilclose">전일종가	double	15.9</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="hotime">호가수신시간	string	6</param>
/// <param name="offerho1">매도호가1	double	15.9</param>
/// <param name="bidho1">매수호가1	double	15.9</param>
/// <param name="offercnt1">매도호가건수1	long	10</param>
/// <param name="bidcnt1">매수호가건수1	long	10</param>
/// <param name="offerrem1">매도호가수량1	long	10</param>
/// <param name="bidrem1">매수호가수량1	long	10</param>
/// <param name="offerho2">매도호가2	double	15.9</param>
/// <param name="bidho2">매수호가2	double	15.9</param>
/// <param name="offercnt2">매도호가건수2	long	10</param>
/// <param name="bidcnt2">매수호가건수2	long	10</param>
/// <param name="offerrem2">매도호가수량2	long	10</param>
/// <param name="bidrem2">매수호가수량2	long	10</param>
/// <param name="offerho3">매도호가3	double	15.9</param>
/// <param name="bidho3">매수호가3	double	15.9</param>
/// <param name="offercnt3">매도호가건수3	long	10</param>
/// <param name="bidcnt3">매수호가건수3	long	10</param>
/// <param name="offerrem3">매도호가수량3	long	10</param>
/// <param name="bidrem3">매수호가수량3	long	10</param>
/// <param name="offerho4">매도호가4	double	15.9</param>
/// <param name="bidho4">매수호가4	double	15.9</param>
/// <param name="offercnt4">매도호가건수4	long	10</param>
/// <param name="bidcnt4">매수호가건수4	long	10</param>
/// <param name="offerrem4">매도호가수량4	long	10</param>
/// <param name="bidrem4">매수호가수량4	long	10</param>
/// <param name="offerho5">매도호가5	double	15.9</param>
/// <param name="bidho5">매수호가5	double	15.9</param>
/// <param name="offercnt5">매도호가건수5	long	10</param>
/// <param name="bidcnt5">매수호가건수5	long	10</param>
/// <param name="offerrem5">매도호가수량5	long	10</param>
/// <param name="bidrem5">매수호가수량5	long	10</param>
/// <param name="offercnt">매도호가건수합	long	10</param>
/// <param name="bidcnt">매수호가건수합	long	10</param>
/// <param name="offer">매도호가수량합	long	10</param>
/// <param name="bid">매수호가수량합	long	10</param>
public record o3106OutBlock([Description("종목코드	string	8")] string symbol, [Description("종목명	string	50")] string symbolname, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	10")] long volume, [Description("전일종가	double	15.9")] double jnilclose, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("호가수신시간	string	6")] string hotime, [Description("매도호가1	double	15.9")] double offerho1, [Description("매수호가1	double	15.9")] double bidho1, [Description("매도호가건수1	long	10")] long offercnt1, [Description("매수호가건수1	long	10")] long bidcnt1, [Description("매도호가수량1	long	10")] long offerrem1, [Description("매수호가수량1	long	10")] long bidrem1, [Description("매도호가2	double	15.9")] double offerho2, [Description("매수호가2	double	15.9")] double bidho2, [Description("매도호가건수2	long	10")] long offercnt2, [Description("매수호가건수2	long	10")] long bidcnt2, [Description("매도호가수량2	long	10")] long offerrem2, [Description("매수호가수량2	long	10")] long bidrem2, [Description("매도호가3	double	15.9")] double offerho3, [Description("매수호가3	double	15.9")] double bidho3, [Description("매도호가건수3	long	10")] long offercnt3, [Description("매수호가건수3	long	10")] long bidcnt3, [Description("매도호가수량3	long	10")] long offerrem3, [Description("매수호가수량3	long	10")] long bidrem3, [Description("매도호가4	double	15.9")] double offerho4, [Description("매수호가4	double	15.9")] double bidho4, [Description("매도호가건수4	long	10")] long offercnt4, [Description("매수호가건수4	long	10")] long bidcnt4, [Description("매도호가수량4	long	10")] long offerrem4, [Description("매수호가수량4	long	10")] long bidrem4, [Description("매도호가5	double	15.9")] double offerho5, [Description("매수호가5	double	15.9")] double bidho5, [Description("매도호가건수5	long	10")] long offercnt5, [Description("매수호가건수5	long	10")] long bidcnt5, [Description("매도호가수량5	long	10")] long offerrem5, [Description("매수호가수량5	long	10")] long bidrem5, [Description("매도호가건수합	long	10")] long offercnt, [Description("매수호가건수합	long	10")] long bidcnt, [Description("매도호가수량합	long	10")] long offer, [Description("매수호가수량합	long	10")] long bid);


/// <summary>
/// 해외선물관심종목조회(o3107)-API용: o3107: InBlock
/// </summary>
/// <param name="symbol">종목심볼	string	8</param>
public record o3107InBlock([Description("종목심볼	string	8")] string symbol);

/// <summary>
/// 해외선물관심종목조회(o3107)-API용: o3107: OutBlock
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
/// <param name="symbolname">종목명	string	50</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="jnilclose">전일종가	double	15.9</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="offerho1">매도호가1	double	15.9</param>
/// <param name="bidho1">매수호가1	double	15.9</param>
/// <param name="offercnt1">매도호가건수1	long	10</param>
/// <param name="bidcnt1">매수호가건수1	long	10</param>
/// <param name="offerrem1">매도호가수량1	long	10</param>
/// <param name="bidrem1">매수호가수량1	long	10</param>
/// <param name="offercnt">매도호가건수합	long	10</param>
/// <param name="bidcnt">매수호가건수합	long	10</param>
/// <param name="offer">매도호가수량합	long	10</param>
/// <param name="bid">매수호가수량합	long	10</param>
public record o3107OutBlock([Description("종목코드	string	8")] string symbol, [Description("종목명	string	50")] string symbolname, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	10")] long volume, [Description("전일종가	double	15.9")] double jnilclose, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("매도호가1	double	15.9")] double offerho1, [Description("매수호가1	double	15.9")] double bidho1, [Description("매도호가건수1	long	10")] long offercnt1, [Description("매수호가건수1	long	10")] long bidcnt1, [Description("매도호가수량1	long	10")] long offerrem1, [Description("매수호가수량1	long	10")] long bidrem1, [Description("매도호가건수합	long	10")] long offercnt, [Description("매수호가건수합	long	10")] long bidcnt, [Description("매도호가수량합	long	10")] long offer, [Description("매수호가수량합	long	10")] long bid);


/// <summary>
/// 해외선물차트(일주월)(o3108)-API용: o3108: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="gubun">주기구분	string	1</param>
/// <param name="qrycnt">요청건수	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
public record o3108InBlock([Description("단축코드	string	16")] string shcode, [Description("주기구분	string	1")] string gubun, [Description("요청건수	int	4")] int qrycnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date);

/// <summary>
/// 해외선물차트(일주월)(o3108)-API용: o3108: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="jisiga">전일시가	double	15.9</param>
/// <param name="jihigh">전일고가	double	15.9</param>
/// <param name="jilow">전일저가	double	15.9</param>
/// <param name="jiclose">전일종가	double	15.9</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	15.9</param>
/// <param name="dihigh">당일고가	double	15.9</param>
/// <param name="dilow">당일저가	double	15.9</param>
/// <param name="diclose">당일종가	double	15.9</param>
/// <param name="mk_stime">장시작시간	string	6</param>
/// <param name="mk_etime">장마감시간	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record o3108OutBlock([Description("단축코드	string	16")] string shcode, [Description("전일시가	double	15.9")] double jisiga, [Description("전일고가	double	15.9")] double jihigh, [Description("전일저가	double	15.9")] double jilow, [Description("전일종가	double	15.9")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	15.9")] double disiga, [Description("당일고가	double	15.9")] double dihigh, [Description("당일저가	double	15.9")] double dilow, [Description("당일종가	double	15.9")] double diclose, [Description("장시작시간	string	6")] string mk_stime, [Description("장마감시간	string	6")] string mk_etime, [Description("연속일자	string	8")] string cts_date, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 해외선물차트(일주월)(o3108)-API용: o3108: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3108OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물시간대별(Tick)체결(o3116)-API용: o3116: InBlock
/// </summary>
/// <param name="gubun">조회구분(0:당일1:전일)	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="readcnt">조회갯수	int	4</param>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3116InBlock([Description("조회구분(0:당일1:전일)	string	1")] string gubun, [Description("단축코드	string	8")] string shcode, [Description("조회갯수	int	4")] int readcnt, [Description("순번CTS	int	8")] int cts_seq);

/// <summary>
/// 해외선물시간대별(Tick)체결(o3116)-API용: o3116: OutBlock
/// </summary>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3116OutBlock([Description("순번CTS	int	8")] int cts_seq);

/// <summary>
/// 해외선물시간대별(Tick)체결(o3116)-API용: o3116: OutBlock1
/// </summary>
/// <param name="ovsdate">현지일자	string	8</param>
/// <param name="ovstime">현지시간	string	6</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	10</param>
/// <param name="volume">누적거래량	long	10</param>
public record o3116OutBlock1([Description("현지일자	string	8")] string ovsdate, [Description("현지시간	string	6")] string ovstime, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	long	10")] long cvolume, [Description("누적거래량	long	10")] long volume);


/// <summary>
/// 해외선물차트용NTick(o3117)-API용: o3117: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3117InBlock([Description("단축코드	string	8")] string shcode, [Description("단위	int	4")] int ncnt, [Description("건수	int	4")] int qrycnt, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb);

/// <summary>
/// 해외선물차트용NTick(o3117)-API용: o3117: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3117OutBlock([Description("단축코드	string	8")] string shcode, [Description("레코드카운트	int	7")] int rec_count, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb);

/// <summary>
/// 해외선물차트용NTick(o3117)-API용: o3117: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3117OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물옵션마스터조회(o3121)-API용: o3121: InBlock
/// </summary>
/// <param name="MktGb">시장구분	string	1</param>
/// <param name="BscGdsCd">옵션기초상품코드	string	10</param>
public record o3121InBlock([Description("시장구분	string	1")] string MktGb, [Description("옵션기초상품코드	string	10")] string BscGdsCd);

/// <summary>
/// 해외선물옵션마스터조회(o3121)-API용: o3121: OutBlock
/// </summary>
/// <param name="Symbol">종목코드	string	16</param>
/// <param name="SymbolNm">종목명	string	50</param>
/// <param name="ApplDate">종목배치수신일(한국일자)	string	8</param>
/// <param name="BscGdsCd">기초상품코드	string	10</param>
/// <param name="BscGdsNm">기초상품명	string	40</param>
/// <param name="ExchCd">거래소코드	string	10</param>
/// <param name="ExchNm">거래소명	string	40</param>
/// <param name="CrncyCd">기준통화코드	string	3</param>
/// <param name="NotaCd">진법구분코드	string	3</param>
/// <param name="UntPrc">호가단위가격	double	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	double	15.9</param>
/// <param name="RgltFctr">가격조정계수	double	15.1</param>
/// <param name="CtrtPrAmt">계약당금액	double	15.2</param>
/// <param name="GdsCd">상품구분코드	string	3</param>
/// <param name="LstngYr">월물(년)	string	4</param>
/// <param name="LstngM">월물(월)	string	1</param>
/// <param name="EcPrc">정산가격	double	15.9</param>
/// <param name="DlStrtTm">거래시작시간	string	6</param>
/// <param name="DlEndTm">거래종료시간	string	6</param>
/// <param name="DlPsblCd">거래가능구분코드	string	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	string	1</param>
/// <param name="OpngMgn">개시증거금	double	15.2</param>
/// <param name="MntncMgn">유지증거금	double	15.2</param>
/// <param name="OpngMgnR">개시증거금율	double	7.3</param>
/// <param name="MntncMgnR">유지증거금율	double	7.3</param>
/// <param name="DotGb">유효소수점자리수	int	2</param>
/// <param name="XrcPrc">옵션행사가	string	15</param>
/// <param name="FdasBasePrc">기초자산기준가격	string	15</param>
/// <param name="OptTpCode">옵션콜풋구분	string	1</param>
/// <param name="RgtXrcPtnCode">권리행사구분코드	string	1</param>
/// <param name="Moneyness">ATM구분	string	1</param>
/// <param name="LastSettPtnCode">해외파생기초자산종목코드	string	30</param>
/// <param name="OptMinOrcPrc">해외옵션최소호가	string	15</param>
/// <param name="OptMinBaseOrcPrc">해외옵션최소기준호가	string	15</param>
public record o3121OutBlock([Description("종목코드	string	16")] string Symbol, [Description("종목명	string	50")] string SymbolNm, [Description("종목배치수신일(한국일자)	string	8")] string ApplDate, [Description("기초상품코드	string	10")] string BscGdsCd, [Description("기초상품명	string	40")] string BscGdsNm, [Description("거래소코드	string	10")] string ExchCd, [Description("거래소명	string	40")] string ExchNm, [Description("기준통화코드	string	3")] string CrncyCd, [Description("진법구분코드	string	3")] string NotaCd, [Description("호가단위가격	double	15.9")] double UntPrc, [Description("최소가격변동금액	double	15.9")] double MnChgAmt, [Description("가격조정계수	double	15.1")] double RgltFctr, [Description("계약당금액	double	15.2")] double CtrtPrAmt, [Description("상품구분코드	string	3")] string GdsCd, [Description("월물(년)	string	4")] string LstngYr, [Description("월물(월)	string	1")] string LstngM, [Description("정산가격	double	15.9")] double EcPrc, [Description("거래시작시간	string	6")] string DlStrtTm, [Description("거래종료시간	string	6")] string DlEndTm, [Description("거래가능구분코드	string	1")] string DlPsblCd, [Description("증거금징수구분코드	string	1")] string MgnCltCd, [Description("개시증거금	double	15.2")] double OpngMgn, [Description("유지증거금	double	15.2")] double MntncMgn, [Description("개시증거금율	double	7.3")] double OpngMgnR, [Description("유지증거금율	double	7.3")] double MntncMgnR, [Description("유효소수점자리수	int	2")] int DotGb, [Description("옵션행사가	string	15")] string XrcPrc, [Description("기초자산기준가격	string	15")] string FdasBasePrc, [Description("옵션콜풋구분	string	1")] string OptTpCode, [Description("권리행사구분코드	string	1")] string RgtXrcPtnCode, [Description("ATM구분	string	1")] string Moneyness, [Description("해외파생기초자산종목코드	string	30")] string LastSettPtnCode, [Description("해외옵션최소호가	string	15")] string OptMinOrcPrc, [Description("해외옵션최소기준호가	string	15")] string OptMinBaseOrcPrc);


/// <summary>
/// 해외선물옵션차트(분)(o3123)-API용: o3123: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">N분주기	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3123InBlock([Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string shcode, [Description("N분주기	int	4")] int ncnt, [Description("조회건수	int	4")] int readcnt, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	6")] string cts_time);

/// <summary>
/// 해외선물옵션차트(분)(o3123)-API용: o3123: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="timediff">시차	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3123OutBlock([Description("단축코드	string	16")] string shcode, [Description("시차	int	4")] int timediff, [Description("조회건수	int	4")] int readcnt, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	6")] string cts_time);

/// <summary>
/// 해외선물옵션차트(분)(o3123)-API용: o3123: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">현지시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3123OutBlock1([Description("날짜	string	8")] string date, [Description("현지시간	string	6")] string time, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물옵션현재가(종목정보)조회(o3125)-API용: o3125: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">종목코드	string	16</param>
public record o3125InBlock([Description("시장구분	string	1")] string mktgb, [Description("종목코드	string	16")] string symbol);

/// <summary>
/// 해외선물옵션현재가(종목정보)조회(o3125)-API용: o3125: OutBlock
/// </summary>
/// <param name="Symbol">종목코드	string	16</param>
/// <param name="SymbolNm">종목명	string	50</param>
/// <param name="ApplDate">종목배치수신일	string	8</param>
/// <param name="BscGdsCd">기초상품코드	string	10</param>
/// <param name="BscGdsNm">기초상품명	string	40</param>
/// <param name="ExchCd">거래소코드	string	10</param>
/// <param name="ExchNm">거래소명	string	40</param>
/// <param name="EcCd">정산구분코드	string	1</param>
/// <param name="CrncyCd">기준통화코드	string	3</param>
/// <param name="NotaCd">진법구분코드	string	3</param>
/// <param name="UntPrc">호가단위가격	double	15.9</param>
/// <param name="MnChgAmt">최소가격변동금액	double	15.9</param>
/// <param name="RgltFctr">가격조정계수	double	15.1</param>
/// <param name="CtrtPrAmt">계약당금액	double	15.2</param>
/// <param name="LstngMCnt">상장개월수	int	2</param>
/// <param name="GdsCd">상품구분코드	string	3</param>
/// <param name="MrktCd">시장구분코드	string	3</param>
/// <param name="EminiCd">Emini구분코드	string	1</param>
/// <param name="LstngYr">상장년	string	4</param>
/// <param name="LstngM">상장월	string	1</param>
/// <param name="SeqNo">월물순서	int	5</param>
/// <param name="LstngDt">상장일자	string	8</param>
/// <param name="MtrtDt">최종거래가능일	string	8</param>
/// <param name="FnlDlDt">최종거래일	string	8</param>
/// <param name="FstTrsfrDt">최초인도통지일자	string	8</param>
/// <param name="EcPrc">정산가격	double	15.9</param>
/// <param name="DlDt">거래시작일자(한국)	string	8</param>
/// <param name="DlStrtTm">거래시작시간(한국)	string	6</param>
/// <param name="DlEndTm">거래종료시간(한국)	string	6</param>
/// <param name="OvsStrDay">거래시작일자(현지)	string	8</param>
/// <param name="OvsStrTm">거래시작시간(현지)	string	6</param>
/// <param name="OvsEndDay">거래종료일자(현지)	string	8</param>
/// <param name="OvsEndTm">거래종료시간(현지)	string	6</param>
/// <param name="DlPsblCd">거래가능구분코드	string	1</param>
/// <param name="MgnCltCd">증거금징수구분코드	string	1</param>
/// <param name="OpngMgn">개시증거금	double	15.2</param>
/// <param name="MntncMgn">유지증거금	double	15.2</param>
/// <param name="OpngMgnR">개시증거금율	double	7.3</param>
/// <param name="MntncMgnR">유지증거금율	double	7.3</param>
/// <param name="DotGb">유효소수점자리수	int	2</param>
/// <param name="TimeDiff">시차	int	5</param>
/// <param name="OvsDate">현지체결일자	string	8</param>
/// <param name="KorDate">한국체결일자	string	8</param>
/// <param name="TrdTm">현지체결시간	string	6</param>
/// <param name="RcvTm">한국체결시각	string	6</param>
/// <param name="TrdP">체결가격	double	15.9</param>
/// <param name="TrdQ">체결수량	long	10</param>
/// <param name="TotQ">누적거래량	long	15</param>
/// <param name="TrdAmt">체결거래대금	double	15.2</param>
/// <param name="TotAmt">누적거래대금	double	15.2</param>
/// <param name="OpenP">시가	double	15.9</param>
/// <param name="HighP">고가	double	15.9</param>
/// <param name="LowP">저가	double	15.9</param>
/// <param name="CloseP">전일종가	double	15.9</param>
/// <param name="YdiffP">전일대비	double	15.9</param>
/// <param name="YdiffSign">전일대비구분	string	1</param>
/// <param name="Cgubun">체결구분	string	1</param>
/// <param name="Diff">등락율	double	6.2</param>
/// <param name="MinOrcPrc">최소호가	double	15.9</param>
/// <param name="MinBaseOrcPrc">최소기준호가	double	15.9</param>
public record o3125OutBlock([Description("종목코드	string	16")] string Symbol, [Description("종목명	string	50")] string SymbolNm, [Description("종목배치수신일	string	8")] string ApplDate, [Description("기초상품코드	string	10")] string BscGdsCd, [Description("기초상품명	string	40")] string BscGdsNm, [Description("거래소코드	string	10")] string ExchCd, [Description("거래소명	string	40")] string ExchNm, [Description("정산구분코드	string	1")] string EcCd, [Description("기준통화코드	string	3")] string CrncyCd, [Description("진법구분코드	string	3")] string NotaCd, [Description("호가단위가격	double	15.9")] double UntPrc, [Description("최소가격변동금액	double	15.9")] double MnChgAmt, [Description("가격조정계수	double	15.1")] double RgltFctr, [Description("계약당금액	double	15.2")] double CtrtPrAmt, [Description("상장개월수	int	2")] int LstngMCnt, [Description("상품구분코드	string	3")] string GdsCd, [Description("시장구분코드	string	3")] string MrktCd, [Description("Emini구분코드	string	1")] string EminiCd, [Description("상장년	string	4")] string LstngYr, [Description("상장월	string	1")] string LstngM, [Description("월물순서	int	5")] int SeqNo, [Description("상장일자	string	8")] string LstngDt, [Description("최종거래가능일	string	8")] string MtrtDt, [Description("최종거래일	string	8")] string FnlDlDt, [Description("최초인도통지일자	string	8")] string FstTrsfrDt, [Description("정산가격	double	15.9")] double EcPrc, [Description("거래시작일자(한국)	string	8")] string DlDt, [Description("거래시작시간(한국)	string	6")] string DlStrtTm, [Description("거래종료시간(한국)	string	6")] string DlEndTm, [Description("거래시작일자(현지)	string	8")] string OvsStrDay, [Description("거래시작시간(현지)	string	6")] string OvsStrTm, [Description("거래종료일자(현지)	string	8")] string OvsEndDay, [Description("거래종료시간(현지)	string	6")] string OvsEndTm, [Description("거래가능구분코드	string	1")] string DlPsblCd, [Description("증거금징수구분코드	string	1")] string MgnCltCd, [Description("개시증거금	double	15.2")] double OpngMgn, [Description("유지증거금	double	15.2")] double MntncMgn, [Description("개시증거금율	double	7.3")] double OpngMgnR, [Description("유지증거금율	double	7.3")] double MntncMgnR, [Description("유효소수점자리수	int	2")] int DotGb, [Description("시차	int	5")] int TimeDiff, [Description("현지체결일자	string	8")] string OvsDate, [Description("한국체결일자	string	8")] string KorDate, [Description("현지체결시간	string	6")] string TrdTm, [Description("한국체결시각	string	6")] string RcvTm, [Description("체결가격	double	15.9")] double TrdP, [Description("체결수량	long	10")] long TrdQ, [Description("누적거래량	long	15")] long TotQ, [Description("체결거래대금	double	15.2")] double TrdAmt, [Description("누적거래대금	double	15.2")] double TotAmt, [Description("시가	double	15.9")] double OpenP, [Description("고가	double	15.9")] double HighP, [Description("저가	double	15.9")] double LowP, [Description("전일종가	double	15.9")] double CloseP, [Description("전일대비	double	15.9")] double YdiffP, [Description("전일대비구분	string	1")] string YdiffSign, [Description("체결구분	string	1")] string Cgubun, [Description("등락율	double	6.2")] double Diff, [Description("최소호가	double	15.9")] double MinOrcPrc, [Description("최소기준호가	double	15.9")] double MinBaseOrcPrc);


/// <summary>
/// 해외선물옵션현재가호가조회(o3126)-API용: o3126: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">단축코드	string	16</param>
public record o3126InBlock([Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string symbol);

/// <summary>
/// 해외선물옵션현재가호가조회(o3126)-API용: o3126: OutBlock
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
/// <param name="symbolname">종목명	string	50</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="jnilclose">전일종가	double	15.9</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="hotime">호가수신시간	string	6</param>
/// <param name="offerho1">매도호가1	double	15.9</param>
/// <param name="bidho1">매수호가1	double	15.9</param>
/// <param name="offercnt1">매도호가건수1	long	10</param>
/// <param name="bidcnt1">매수호가건수1	long	10</param>
/// <param name="offerrem1">매도호가수량1	long	10</param>
/// <param name="bidrem1">매수호가수량1	long	10</param>
/// <param name="offerho2">매도호가2	double	15.9</param>
/// <param name="bidho2">매수호가2	double	15.9</param>
/// <param name="offercnt2">매도호가건수2	long	10</param>
/// <param name="bidcnt2">매수호가건수2	long	10</param>
/// <param name="offerrem2">매도호가수량2	long	10</param>
/// <param name="bidrem2">매수호가수량2	long	10</param>
/// <param name="offerho3">매도호가3	double	15.9</param>
/// <param name="bidho3">매수호가3	double	15.9</param>
/// <param name="offercnt3">매도호가건수3	long	10</param>
/// <param name="bidcnt3">매수호가건수3	long	10</param>
/// <param name="offerrem3">매도호가수량3	long	10</param>
/// <param name="bidrem3">매수호가수량3	long	10</param>
/// <param name="offerho4">매도호가4	double	15.9</param>
/// <param name="bidho4">매수호가4	double	15.9</param>
/// <param name="offercnt4">매도호가건수4	long	10</param>
/// <param name="bidcnt4">매수호가건수4	long	10</param>
/// <param name="offerrem4">매도호가수량4	long	10</param>
/// <param name="bidrem4">매수호가수량4	long	10</param>
/// <param name="offerho5">매도호가5	double	15.9</param>
/// <param name="bidho5">매수호가5	double	15.9</param>
/// <param name="offercnt5">매도호가건수5	long	10</param>
/// <param name="bidcnt5">매수호가건수5	long	10</param>
/// <param name="offerrem5">매도호가수량5	long	10</param>
/// <param name="bidrem5">매수호가수량5	long	10</param>
/// <param name="offercnt">매도호가건수합	long	10</param>
/// <param name="bidcnt">매수호가건수합	long	10</param>
/// <param name="offer">매도호가수량합	long	10</param>
/// <param name="bid">매수호가수량합	long	10</param>
public record o3126OutBlock([Description("종목코드	string	16")] string symbol, [Description("종목명	string	50")] string symbolname, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	10")] long volume, [Description("전일종가	double	15.9")] double jnilclose, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("호가수신시간	string	6")] string hotime, [Description("매도호가1	double	15.9")] double offerho1, [Description("매수호가1	double	15.9")] double bidho1, [Description("매도호가건수1	long	10")] long offercnt1, [Description("매수호가건수1	long	10")] long bidcnt1, [Description("매도호가수량1	long	10")] long offerrem1, [Description("매수호가수량1	long	10")] long bidrem1, [Description("매도호가2	double	15.9")] double offerho2, [Description("매수호가2	double	15.9")] double bidho2, [Description("매도호가건수2	long	10")] long offercnt2, [Description("매수호가건수2	long	10")] long bidcnt2, [Description("매도호가수량2	long	10")] long offerrem2, [Description("매수호가수량2	long	10")] long bidrem2, [Description("매도호가3	double	15.9")] double offerho3, [Description("매수호가3	double	15.9")] double bidho3, [Description("매도호가건수3	long	10")] long offercnt3, [Description("매수호가건수3	long	10")] long bidcnt3, [Description("매도호가수량3	long	10")] long offerrem3, [Description("매수호가수량3	long	10")] long bidrem3, [Description("매도호가4	double	15.9")] double offerho4, [Description("매수호가4	double	15.9")] double bidho4, [Description("매도호가건수4	long	10")] long offercnt4, [Description("매수호가건수4	long	10")] long bidcnt4, [Description("매도호가수량4	long	10")] long offerrem4, [Description("매수호가수량4	long	10")] long bidrem4, [Description("매도호가5	double	15.9")] double offerho5, [Description("매수호가5	double	15.9")] double bidho5, [Description("매도호가건수5	long	10")] long offercnt5, [Description("매수호가건수5	long	10")] long bidcnt5, [Description("매도호가수량5	long	10")] long offerrem5, [Description("매수호가수량5	long	10")] long bidrem5, [Description("매도호가건수합	long	10")] long offercnt, [Description("매수호가건수합	long	10")] long bidcnt, [Description("매도호가수량합	long	10")] long offer, [Description("매수호가수량합	long	10")] long bid);


/// <summary>
/// 해외선물옵션관심종목조회(o3127)-API용: o3127: InBlock
/// </summary>
/// <param name="nrec">건수	int	4</param>
public record o3127InBlock([Description("건수	int	4")] int nrec);

/// <summary>
/// 해외선물옵션관심종목조회(o3127)-API용: o3127: InBlock1
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">종목심볼	string	16</param>
public record o3127InBlock1([Description("시장구분	string	1")] string mktgb, [Description("종목심볼	string	16")] string symbol);

/// <summary>
/// 해외선물옵션관심종목조회(o3127)-API용: o3127: OutBlock
/// </summary>
/// <param name="symbol">종목코드	string	16</param>
/// <param name="symbolname">종목명	string	50</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	10</param>
/// <param name="jnilclose">전일종가	double	15.9</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="offerho1">매도호가1	double	15.9</param>
/// <param name="bidho1">매수호가1	double	15.9</param>
/// <param name="offercnt1">매도호가건수1	long	10</param>
/// <param name="bidcnt1">매수호가건수1	long	10</param>
/// <param name="offerrem1">매도호가수량1	long	10</param>
/// <param name="bidrem1">매수호가수량1	long	10</param>
/// <param name="offercnt">매도호가건수합	long	10</param>
/// <param name="bidcnt">매수호가건수합	long	10</param>
/// <param name="offer">매도호가수량합	long	10</param>
/// <param name="bid">매수호가수량합	long	10</param>
public record o3127OutBlock([Description("종목코드	string	16")] string symbol, [Description("종목명	string	50")] string symbolname, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	10")] long volume, [Description("전일종가	double	15.9")] double jnilclose, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("매도호가1	double	15.9")] double offerho1, [Description("매수호가1	double	15.9")] double bidho1, [Description("매도호가건수1	long	10")] long offercnt1, [Description("매수호가건수1	long	10")] long bidcnt1, [Description("매도호가수량1	long	10")] long offerrem1, [Description("매수호가수량1	long	10")] long bidrem1, [Description("매도호가건수합	long	10")] long offercnt, [Description("매수호가건수합	long	10")] long bidcnt, [Description("매도호가수량합	long	10")] long offer, [Description("매수호가수량합	long	10")] long bid);


/// <summary>
/// 해외선물옵션차트일주월(o3128)-API용: o3128: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="gubun">주기구분	string	1</param>
/// <param name="qrycnt">요청건수	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
public record o3128InBlock([Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string shcode, [Description("주기구분	string	1")] string gubun, [Description("요청건수	int	4")] int qrycnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date);

/// <summary>
/// 해외선물옵션차트일주월(o3128)-API용: o3128: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="jisiga">전일시가	double	15.9</param>
/// <param name="jihigh">전일고가	double	15.9</param>
/// <param name="jilow">전일저가	double	15.9</param>
/// <param name="jiclose">전일종가	double	15.9</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	15.9</param>
/// <param name="dihigh">당일고가	double	15.9</param>
/// <param name="dilow">당일저가	double	15.9</param>
/// <param name="diclose">당일종가	double	15.9</param>
/// <param name="mk_stime">장시작시간	string	6</param>
/// <param name="mk_etime">장마감시간	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record o3128OutBlock([Description("단축코드	string	16")] string shcode, [Description("전일시가	double	15.9")] double jisiga, [Description("전일고가	double	15.9")] double jihigh, [Description("전일저가	double	15.9")] double jilow, [Description("전일종가	double	15.9")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	15.9")] double disiga, [Description("당일고가	double	15.9")] double dihigh, [Description("당일저가	double	15.9")] double dilow, [Description("당일종가	double	15.9")] double diclose, [Description("장시작시간	string	6")] string mk_stime, [Description("장마감시간	string	6")] string mk_etime, [Description("연속일자	string	8")] string cts_date, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 해외선물옵션차트일주월(o3128)-API용: o3128: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3128OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물옵션시간대별(Tick)체결(o3136)-API용: o3136: InBlock
/// </summary>
/// <param name="gubun">조회구분(0:당일1:전일)	string	1</param>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="readcnt">조회갯수	int	4</param>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3136InBlock([Description("조회구분(0:당일1:전일)	string	1")] string gubun, [Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string shcode, [Description("조회갯수	int	4")] int readcnt, [Description("순번CTS	int	8")] int cts_seq);

/// <summary>
/// 해외선물옵션시간대별(Tick)체결(o3136)-API용: o3136: OutBlock
/// </summary>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3136OutBlock([Description("순번CTS	int	8")] int cts_seq);

/// <summary>
/// 해외선물옵션시간대별(Tick)체결(o3136)-API용: o3136: OutBlock1
/// </summary>
/// <param name="ovsdate">현지일자	string	8</param>
/// <param name="ovstime">현지시간	string	6</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	10</param>
/// <param name="volume">누적거래량	long	10</param>
public record o3136OutBlock1([Description("현지일자	string	8")] string ovsdate, [Description("현지시간	string	6")] string ovstime, [Description("현재가	double	15.9")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	15.9")] double change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	long	10")] long cvolume, [Description("누적거래량	long	10")] long volume);


/// <summary>
/// 해외선물옵션차트용NTick(o3137)-API용: o3137: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3137InBlock([Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string shcode, [Description("단위	int	4")] int ncnt, [Description("건수	int	4")] int qrycnt, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb);

/// <summary>
/// 해외선물옵션차트용NTick(o3137)-API용: o3137: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3137OutBlock([Description("단축코드	string	16")] string shcode, [Description("레코드카운트	int	7")] int rec_count, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb);

/// <summary>
/// 해외선물옵션차트용NTick(o3137)-API용: o3137: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3137OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	15.9")] double open, [Description("고가	double	15.9")] double high, [Description("저가	double	15.9")] double low, [Description("종가	double	15.9")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 해외선물옵션차트용NTick(고정형)(o3139)-API용: o3139: InBlock
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3139InBlock([Description("시장구분	string	1")] string mktgb, [Description("단축코드	string	16")] string shcode, [Description("단위	int	4")] int ncnt, [Description("건수	int	4")] int qrycnt, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb);

/// <summary>
/// 해외선물옵션차트용NTick(고정형)(o3139)-API용: o3139: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
/// <param name="last_count">마지막Tick건수	int	4</param>
public record o3139OutBlock([Description("단축코드	string	16")] string shcode, [Description("레코드카운트	int	7")] int rec_count, [Description("연속시간	string	10")] string cts_seq, [Description("연속당일구분	string	2")] string cts_daygb, [Description("마지막Tick건수	int	4")] int last_count);

/// <summary>
/// 해외선물옵션차트용NTick(고정형)(o3139)-API용: o3139: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.8</param>
/// <param name="high">고가	double	15.8</param>
/// <param name="low">저가	double	15.8</param>
/// <param name="close">종가	double	15.8</param>
/// <param name="volume">거래량	long	12</param>
public record o3139OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	15.8")] double open, [Description("고가	double	15.8")] double high, [Description("저가	double	15.8")] double low, [Description("종가	double	15.8")] double close, [Description("거래량	long	12")] long volume);


/// <summary>
/// 주식당일매매일지/수수료(t0150): t0150: InBlock
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0150InBlock([Description("계좌번호	string	11")] string accno, [Description("CTS_매매구분	string	1")] string cts_medosu, [Description("CTS_종목번호	string	12")] string cts_expcode, [Description("CTS_단가	string	9")] string cts_price, [Description("CTS_매체	string	2")] string cts_middiv);

/// <summary>
/// 주식당일매매일지/수수료(t0150): t0150: OutBlock
/// </summary>
/// <param name="mdqty">매도수량	long	9</param>
/// <param name="mdamt">매도약정금액	long	18</param>
/// <param name="mdfee">매도수수료	long	18</param>
/// <param name="mdtax">매도거래세	long	18</param>
/// <param name="mdargtax">매도농특세	long	18</param>
/// <param name="tmdtax">매도제비용합	long	18</param>
/// <param name="mdadjamt">매도정산금액	long	18</param>
/// <param name="msqty">매수수량	long	9</param>
/// <param name="msamt">매수약정금액	long	18</param>
/// <param name="msfee">매수수수료	long	18</param>
/// <param name="tmstax">매수제비용합	long	18</param>
/// <param name="msadjamt">매수정산금액	long	18</param>
/// <param name="tqty">합계수량	long	9</param>
/// <param name="tamt">합계약정금액	long	18</param>
/// <param name="tfee">합계수수료	long	18</param>
/// <param name="tottax">합계거래세	long	18</param>
/// <param name="targtax">합계농특세	long	18</param>
/// <param name="ttax">합계제비용합	long	18</param>
/// <param name="tadjamt">합계정산금액	long	18</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0150OutBlock([Description("매도수량	long	9")] long mdqty, [Description("매도약정금액	long	18")] long mdamt, [Description("매도수수료	long	18")] long mdfee, [Description("매도거래세	long	18")] long mdtax, [Description("매도농특세	long	18")] long mdargtax, [Description("매도제비용합	long	18")] long tmdtax, [Description("매도정산금액	long	18")] long mdadjamt, [Description("매수수량	long	9")] long msqty, [Description("매수약정금액	long	18")] long msamt, [Description("매수수수료	long	18")] long msfee, [Description("매수제비용합	long	18")] long tmstax, [Description("매수정산금액	long	18")] long msadjamt, [Description("합계수량	long	9")] long tqty, [Description("합계약정금액	long	18")] long tamt, [Description("합계수수료	long	18")] long tfee, [Description("합계거래세	long	18")] long tottax, [Description("합계농특세	long	18")] long targtax, [Description("합계제비용합	long	18")] long ttax, [Description("합계정산금액	long	18")] long tadjamt, [Description("CTS_매매구분	string	1")] string cts_medosu, [Description("CTS_종목번호	string	12")] string cts_expcode, [Description("CTS_단가	string	9")] string cts_price, [Description("CTS_매체	string	2")] string cts_middiv);

/// <summary>
/// 주식당일매매일지/수수료(t0150): t0150: OutBlock1
/// </summary>
/// <param name="medosu">매매구분	string	10</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="qty">수량	long	9</param>
/// <param name="price">단가	long	9</param>
/// <param name="amt">약정금액	long	18</param>
/// <param name="fee">수수료	long	18</param>
/// <param name="tax">거래세	long	18</param>
/// <param name="argtax">농특세	long	18</param>
/// <param name="adjamt">정산금액	long	18</param>
/// <param name="middiv">매체	string	20</param>
public record t0150OutBlock1([Description("매매구분	string	10")] string medosu, [Description("종목번호	string	12")] string expcode, [Description("수량	long	9")] long qty, [Description("단가	long	9")] long price, [Description("약정금액	long	18")] long amt, [Description("수수료	long	18")] long fee, [Description("거래세	long	18")] long tax, [Description("농특세	long	18")] long argtax, [Description("정산금액	long	18")] long adjamt, [Description("매체	string	20")] string middiv);


/// <summary>
/// 주식당일매매일지/수수료(전일)(t0151): t0151: InBlock
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0151InBlock([Description("일자	string	8")] string date, [Description("계좌번호	string	11")] string accno, [Description("CTS_매매구분	string	1")] string cts_medosu, [Description("CTS_종목번호	string	12")] string cts_expcode, [Description("CTS_단가	string	9")] string cts_price, [Description("CTS_매체	string	2")] string cts_middiv);

/// <summary>
/// 주식당일매매일지/수수료(전일)(t0151): t0151: OutBlock
/// </summary>
/// <param name="mdqty">매도수량	long	9</param>
/// <param name="mdamt">매도약정금액	long	18</param>
/// <param name="mdfee">매도수수료	long	18</param>
/// <param name="mdtax">매도거래세	long	18</param>
/// <param name="mdargtax">매도농특세	long	18</param>
/// <param name="tmdtax">매도제비용합	long	18</param>
/// <param name="mdadjamt">매도정산금액	long	18</param>
/// <param name="msqty">매수수량	long	9</param>
/// <param name="msamt">매수약정금액	long	18</param>
/// <param name="msfee">매수수수료	long	18</param>
/// <param name="tmstax">매수제비용합	long	18</param>
/// <param name="msadjamt">매수정산금액	long	18</param>
/// <param name="tqty">합계수량	long	9</param>
/// <param name="tamt">합계약정금액	long	18</param>
/// <param name="tfee">합계수수료	long	18</param>
/// <param name="tottax">합계거래세	long	18</param>
/// <param name="targtax">합계농특세	long	18</param>
/// <param name="ttax">합계제비용합	long	18</param>
/// <param name="tadjamt">합계정산금액	long	18</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0151OutBlock([Description("매도수량	long	9")] long mdqty, [Description("매도약정금액	long	18")] long mdamt, [Description("매도수수료	long	18")] long mdfee, [Description("매도거래세	long	18")] long mdtax, [Description("매도농특세	long	18")] long mdargtax, [Description("매도제비용합	long	18")] long tmdtax, [Description("매도정산금액	long	18")] long mdadjamt, [Description("매수수량	long	9")] long msqty, [Description("매수약정금액	long	18")] long msamt, [Description("매수수수료	long	18")] long msfee, [Description("매수제비용합	long	18")] long tmstax, [Description("매수정산금액	long	18")] long msadjamt, [Description("합계수량	long	9")] long tqty, [Description("합계약정금액	long	18")] long tamt, [Description("합계수수료	long	18")] long tfee, [Description("합계거래세	long	18")] long tottax, [Description("합계농특세	long	18")] long targtax, [Description("합계제비용합	long	18")] long ttax, [Description("합계정산금액	long	18")] long tadjamt, [Description("CTS_매매구분	string	1")] string cts_medosu, [Description("CTS_종목번호	string	12")] string cts_expcode, [Description("CTS_단가	string	9")] string cts_price, [Description("CTS_매체	string	2")] string cts_middiv);

/// <summary>
/// 주식당일매매일지/수수료(전일)(t0151): t0151: OutBlock1
/// </summary>
/// <param name="medosu">매매구분	string	10</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="qty">수량	long	9</param>
/// <param name="price">단가	long	9</param>
/// <param name="amt">약정금액	long	18</param>
/// <param name="fee">수수료	long	18</param>
/// <param name="tax">거래세	long	18</param>
/// <param name="argtax">농특세	long	18</param>
/// <param name="adjamt">정산금액	long	18</param>
/// <param name="middiv">매체	string	20</param>
public record t0151OutBlock1([Description("매매구분	string	10")] string medosu, [Description("종목번호	string	12")] string expcode, [Description("수량	long	9")] long qty, [Description("단가	long	9")] long price, [Description("약정금액	long	18")] long amt, [Description("수수료	long	18")] long fee, [Description("거래세	long	18")] long tax, [Description("농특세	long	18")] long argtax, [Description("정산금액	long	18")] long adjamt, [Description("매체	string	20")] string middiv);


/// <summary>
/// 서버시간조회(t0167): t0167: InBlock
/// </summary>
/// <param name="id">id	string	8</param>
public record t0167InBlock([Description("id	string	8")] string id);

/// <summary>
/// 서버시간조회(t0167): t0167: OutBlock
/// </summary>
/// <param name="dt">일자(YYYYMMDD)	string	8</param>
/// <param name="time">시간(HHMMSSssssss)	string	12</param>
public record t0167OutBlock([Description("일자(YYYYMMDD)	string	8")] string dt, [Description("시간(HHMMSSssssss)	string	12")] string time);


/// <summary>
/// 주식잔고2(t0424): t0424: InBlock
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="prcgb">단가구분	string	1</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="dangb">단일가구분	string	1</param>
/// <param name="charge">제비용포함여부	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	22</param>
public record t0424InBlock([Description("계좌번호	string	11")] string accno, [Description("비밀번호	string	8")] string passwd, [Description("단가구분	string	1")] string prcgb, [Description("체결구분	string	1")] string chegb, [Description("단일가구분	string	1")] string dangb, [Description("제비용포함여부	string	1")] string charge, [Description("CTS_종목번호	string	22")] string cts_expcode);

/// <summary>
/// 주식잔고2(t0424): t0424: OutBlock
/// </summary>
/// <param name="sunamt">추정순자산	long	18</param>
/// <param name="dtsunik">실현손익	long	18</param>
/// <param name="mamt">매입금액	long	18</param>
/// <param name="sunamt1">추정D2예수금	long	18</param>
/// <param name="cts_expcode">CTS_종목번호	string	22</param>
/// <param name="tappamt">평가금액	long	18</param>
/// <param name="tdtsunik">평가손익	long	18</param>
public record t0424OutBlock([Description("추정순자산	long	18")] long sunamt, [Description("실현손익	long	18")] long dtsunik, [Description("매입금액	long	18")] long mamt, [Description("추정D2예수금	long	18")] long sunamt1, [Description("CTS_종목번호	string	22")] string cts_expcode, [Description("평가금액	long	18")] long tappamt, [Description("평가손익	long	18")] long tdtsunik);

/// <summary>
/// 주식잔고2(t0424): t0424: OutBlock1
/// </summary>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="jangb">잔고구분	string	10</param>
/// <param name="janqty">잔고수량	long	18</param>
/// <param name="mdposqt">매도가능수량	long	18</param>
/// <param name="pamt">평균단가	long	18</param>
/// <param name="mamt">매입금액	long	18</param>
/// <param name="sinamt">대출금액	long	18</param>
/// <param name="lastdt">만기일자	string	8</param>
/// <param name="msat">당일매수금액	long	18</param>
/// <param name="mpms">당일매수단가	long	18</param>
/// <param name="mdat">당일매도금액	long	18</param>
/// <param name="mpmd">당일매도단가	long	18</param>
/// <param name="jsat">전일매수금액	long	18</param>
/// <param name="jpms">전일매수단가	long	18</param>
/// <param name="jdat">전일매도금액	long	18</param>
/// <param name="jpmd">전일매도단가	long	18</param>
/// <param name="sysprocseq">처리순번	long	10</param>
/// <param name="loandt">대출일자	string	8</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="marketgb">시장구분	string	1</param>
/// <param name="jonggb">종목구분	string	1</param>
/// <param name="janrt">보유비중	double	10.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="appamt">평가금액	long	18</param>
/// <param name="dtsunik">평가손익	long	18</param>
/// <param name="sunikrt">수익율	double	10.2</param>
/// <param name="fee">수수료	long	10</param>
/// <param name="tax">제세금	long	10</param>
/// <param name="sininter">신용이자	long	10</param>
public record t0424OutBlock1([Description("종목번호	string	12")] string expcode, [Description("잔고구분	string	10")] string jangb, [Description("잔고수량	long	18")] long janqty, [Description("매도가능수량	long	18")] long mdposqt, [Description("평균단가	long	18")] long pamt, [Description("매입금액	long	18")] long mamt, [Description("대출금액	long	18")] long sinamt, [Description("만기일자	string	8")] string lastdt, [Description("당일매수금액	long	18")] long msat, [Description("당일매수단가	long	18")] long mpms, [Description("당일매도금액	long	18")] long mdat, [Description("당일매도단가	long	18")] long mpmd, [Description("전일매수금액	long	18")] long jsat, [Description("전일매수단가	long	18")] long jpms, [Description("전일매도금액	long	18")] long jdat, [Description("전일매도단가	long	18")] long jpmd, [Description("처리순번	long	10")] long sysprocseq, [Description("대출일자	string	8")] string loandt, [Description("종목명	string	20")] string hname, [Description("시장구분	string	1")] string marketgb, [Description("종목구분	string	1")] string jonggb, [Description("보유비중	double	10.2")] double janrt, [Description("현재가	int	8")] int price, [Description("평가금액	long	18")] long appamt, [Description("평가손익	long	18")] long dtsunik, [Description("수익율	double	10.2")] double sunikrt, [Description("수수료	long	10")] long fee, [Description("제세금	long	10")] long tax, [Description("신용이자	long	10")] long sininter);


/// <summary>
/// 주식체결/미체결(t0425): t0425: InBlock
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="medosu">매매구분	string	1</param>
/// <param name="sortgb">정렬순서	string	1</param>
/// <param name="cts_ordno">주문번호	string	10</param>
public record t0425InBlock([Description("계좌번호	string	11")] string accno, [Description("비밀번호	string	8")] string passwd, [Description("종목번호	string	12")] string expcode, [Description("체결구분	string	1")] string chegb, [Description("매매구분	string	1")] string medosu, [Description("정렬순서	string	1")] string sortgb, [Description("주문번호	string	10")] string cts_ordno);

/// <summary>
/// 주식체결/미체결(t0425): t0425: OutBlock
/// </summary>
/// <param name="tqty">총주문수량	long	18</param>
/// <param name="tcheqty">총체결수량	long	18</param>
/// <param name="tordrem">총미체결수량	long	18</param>
/// <param name="cmss">추정수수료	long	18</param>
/// <param name="tamt">총주문금액	long	18</param>
/// <param name="tmdamt">총매도체결금액	long	18</param>
/// <param name="tmsamt">총매수체결금액	long	18</param>
/// <param name="tax">추정제세금	long	18</param>
/// <param name="cts_ordno">주문번호	string	10</param>
public record t0425OutBlock([Description("총주문수량	long	18")] long tqty, [Description("총체결수량	long	18")] long tcheqty, [Description("총미체결수량	long	18")] long tordrem, [Description("추정수수료	long	18")] long cmss, [Description("총주문금액	long	18")] long tamt, [Description("총매도체결금액	long	18")] long tmdamt, [Description("총매수체결금액	long	18")] long tmsamt, [Description("추정제세금	long	18")] long tax, [Description("주문번호	string	10")] string cts_ordno);

/// <summary>
/// 주식체결/미체결(t0425): t0425: OutBlock1
/// </summary>
/// <param name="ordno">주문번호	long	10</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="medosu">구분	string	10</param>
/// <param name="qty">주문수량	long	9</param>
/// <param name="price">주문가격	long	9</param>
/// <param name="cheqty">체결수량	long	9</param>
/// <param name="cheprice">체결가격	long	9</param>
/// <param name="ordrem">미체결잔량	long	9</param>
/// <param name="cfmqty">확인수량	long	9</param>
/// <param name="status">상태	string	10</param>
/// <param name="orgordno">원주문번호	long	10</param>
/// <param name="ordgb">유형	string	20</param>
/// <param name="ordtime">주문시간	string	8</param>
/// <param name="ordermtd">주문매체	string	10</param>
/// <param name="sysprocseq">처리순번	long	10</param>
/// <param name="hogagb">호가유형	string	2</param>
/// <param name="price1">현재가	int	8</param>
/// <param name="orggb">주문구분	string	2</param>
/// <param name="singb">신용구분	string	2</param>
/// <param name="loandt">대출일자	string	8</param>
public record t0425OutBlock1([Description("주문번호	long	10")] long ordno, [Description("종목번호	string	12")] string expcode, [Description("구분	string	10")] string medosu, [Description("주문수량	long	9")] long qty, [Description("주문가격	long	9")] long price, [Description("체결수량	long	9")] long cheqty, [Description("체결가격	long	9")] long cheprice, [Description("미체결잔량	long	9")] long ordrem, [Description("확인수량	long	9")] long cfmqty, [Description("상태	string	10")] string status, [Description("원주문번호	long	10")] long orgordno, [Description("유형	string	20")] string ordgb, [Description("주문시간	string	8")] string ordtime, [Description("주문매체	string	10")] string ordermtd, [Description("처리순번	long	10")] long sysprocseq, [Description("호가유형	string	2")] string hogagb, [Description("현재가	int	8")] int price1, [Description("주문구분	string	2")] string orggb, [Description("신용구분	string	2")] string singb, [Description("대출일자	string	8")] string loandt);


/// <summary>
/// 선물/옵션체결/미체결(t0434): t0434: InBlock
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="expcode">종목번호	string	8</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="sortgb">정렬순서	string	1</param>
/// <param name="cts_ordno">CTS_주문번호	string	7</param>
public record t0434InBlock([Description("계좌번호	string	11")] string accno, [Description("비밀번호	string	8")] string passwd, [Description("종목번호	string	8")] string expcode, [Description("체결구분	string	1")] string chegb, [Description("정렬순서	string	1")] string sortgb, [Description("CTS_주문번호	string	7")] string cts_ordno);

/// <summary>
/// 선물/옵션체결/미체결(t0434): t0434: OutBlock
/// </summary>
/// <param name="cts_ordno">CTS_주문번호	string	7</param>
public record t0434OutBlock([Description("CTS_주문번호	string	7")] string cts_ordno);

/// <summary>
/// 선물/옵션체결/미체결(t0434): t0434: OutBlock1
/// </summary>
/// <param name="ordno">주문번호	int	7</param>
/// <param name="orgordno">원주문번호	int	7</param>
/// <param name="medosu">구분	string	10</param>
/// <param name="ordgb">유형	string	20</param>
/// <param name="qty">주문수량	long	9</param>
/// <param name="price">주문가격	double	9.2</param>
/// <param name="cheqty">체결수량	long	9</param>
/// <param name="cheprice">체결가격	double	9.2</param>
/// <param name="ordrem">미체결잔량	long	9</param>
/// <param name="status">상태	string	10</param>
/// <param name="ordtime">주문시간	string	8</param>
/// <param name="ordermtd">주문매체	string	10</param>
/// <param name="expcode">종목번호	string	8</param>
/// <param name="rtcode">사유코드	string	3</param>
/// <param name="sysprocseq">처리순번	long	10</param>
/// <param name="hogatype">호가타입	string	1</param>
public record t0434OutBlock1([Description("주문번호	int	7")] int ordno, [Description("원주문번호	int	7")] int orgordno, [Description("구분	string	10")] string medosu, [Description("유형	string	20")] string ordgb, [Description("주문수량	long	9")] long qty, [Description("주문가격	double	9.2")] double price, [Description("체결수량	long	9")] long cheqty, [Description("체결가격	double	9.2")] double cheprice, [Description("미체결잔량	long	9")] long ordrem, [Description("상태	string	10")] string status, [Description("주문시간	string	8")] string ordtime, [Description("주문매체	string	10")] string ordermtd, [Description("종목번호	string	8")] string expcode, [Description("사유코드	string	3")] string rtcode, [Description("처리순번	long	10")] long sysprocseq, [Description("호가타입	string	1")] string hogatype);


/// <summary>
/// 선물/옵션잔고평가(이동평균)(t0441): t0441: InBlock
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="cts_expcode">CTS_종목번호	string	8</param>
/// <param name="cts_medocd">CTS_매매구분	string	1</param>
public record t0441InBlock([Description("계좌번호	string	11")] string accno, [Description("비밀번호	string	8")] string passwd, [Description("CTS_종목번호	string	8")] string cts_expcode, [Description("CTS_매매구분	string	1")] string cts_medocd);

/// <summary>
/// 선물/옵션잔고평가(이동평균)(t0441): t0441: OutBlock
/// </summary>
/// <param name="tdtsunik">매매손익합계	long	18</param>
/// <param name="cts_expcode">CTS_종목번호	string	8</param>
/// <param name="cts_medocd">CTS_매매구분	string	1</param>
/// <param name="tappamt">평가금액	long	18</param>
/// <param name="tsunik">평가손익	long	18</param>
public record t0441OutBlock([Description("매매손익합계	long	18")] long tdtsunik, [Description("CTS_종목번호	string	8")] string cts_expcode, [Description("CTS_매매구분	string	1")] string cts_medocd, [Description("평가금액	long	18")] long tappamt, [Description("평가손익	long	18")] long tsunik);

/// <summary>
/// 선물/옵션잔고평가(이동평균)(t0441): t0441: OutBlock1
/// </summary>
/// <param name="expcode">종목번호	string	8</param>
/// <param name="medosu">구분	string	4</param>
/// <param name="jqty">잔고수량	long	10</param>
/// <param name="cqty">청산가능수량	long	10</param>
/// <param name="pamt">평균단가	double	10.2</param>
/// <param name="mamt">총매입금액	long	18</param>
/// <param name="medocd">매매구분	string	1</param>
/// <param name="dtsunik">매매손익	long	18</param>
/// <param name="sysprocseq">처리순번	long	10</param>
/// <param name="price">현재가	double	9.2</param>
/// <param name="appamt">평가금액	long	18</param>
/// <param name="dtsunik1">평가손익	long	18</param>
/// <param name="sunikrt">수익율	double	10.2</param>
public record t0441OutBlock1([Description("종목번호	string	8")] string expcode, [Description("구분	string	4")] string medosu, [Description("잔고수량	long	10")] long jqty, [Description("청산가능수량	long	10")] long cqty, [Description("평균단가	double	10.2")] double pamt, [Description("총매입금액	long	18")] long mamt, [Description("매매구분	string	1")] string medocd, [Description("매매손익	long	18")] long dtsunik, [Description("처리순번	long	10")] long sysprocseq, [Description("현재가	double	9.2")] double price, [Description("평가금액	long	18")] long appamt, [Description("평가손익	long	18")] long dtsunik1, [Description("수익율	double	10.2")] double sunikrt);


/// <summary>
/// 주식현재가호가조회(t1101): t1101: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1101InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// 주식현재가호가조회(t1101): t1101: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="offerho1">매도호가1	int	8</param>
/// <param name="bidho1">매수호가1	int	8</param>
/// <param name="offerrem1">매도호가수량1	long	12</param>
/// <param name="bidrem1">매수호가수량1	long	12</param>
/// <param name="preoffercha1">직전매도대비수량1	long	12</param>
/// <param name="prebidcha1">직전매수대비수량1	long	12</param>
/// <param name="offerho2">매도호가2	int	8</param>
/// <param name="bidho2">매수호가2	int	8</param>
/// <param name="offerrem2">매도호가수량2	long	12</param>
/// <param name="bidrem2">매수호가수량2	long	12</param>
/// <param name="preoffercha2">직전매도대비수량2	long	12</param>
/// <param name="prebidcha2">직전매수대비수량2	long	12</param>
/// <param name="offerho3">매도호가3	int	8</param>
/// <param name="bidho3">매수호가3	int	8</param>
/// <param name="offerrem3">매도호가수량3	long	12</param>
/// <param name="bidrem3">매수호가수량3	long	12</param>
/// <param name="preoffercha3">직전매도대비수량3	long	12</param>
/// <param name="prebidcha3">직전매수대비수량3	long	12</param>
/// <param name="offerho4">매도호가4	int	8</param>
/// <param name="bidho4">매수호가4	int	8</param>
/// <param name="offerrem4">매도호가수량4	long	12</param>
/// <param name="bidrem4">매수호가수량4	long	12</param>
/// <param name="preoffercha4">직전매도대비수량4	long	12</param>
/// <param name="prebidcha4">직전매수대비수량4	long	12</param>
/// <param name="offerho5">매도호가5	int	8</param>
/// <param name="bidho5">매수호가5	int	8</param>
/// <param name="offerrem5">매도호가수량5	long	12</param>
/// <param name="bidrem5">매수호가수량5	long	12</param>
/// <param name="preoffercha5">직전매도대비수량5	long	12</param>
/// <param name="prebidcha5">직전매수대비수량5	long	12</param>
/// <param name="offerho6">매도호가6	int	8</param>
/// <param name="bidho6">매수호가6	int	8</param>
/// <param name="offerrem6">매도호가수량6	long	12</param>
/// <param name="bidrem6">매수호가수량6	long	12</param>
/// <param name="preoffercha6">직전매도대비수량6	long	12</param>
/// <param name="prebidcha6">직전매수대비수량6	long	12</param>
/// <param name="offerho7">매도호가7	int	8</param>
/// <param name="bidho7">매수호가7	int	8</param>
/// <param name="offerrem7">매도호가수량7	long	12</param>
/// <param name="bidrem7">매수호가수량7	long	12</param>
/// <param name="preoffercha7">직전매도대비수량7	long	12</param>
/// <param name="prebidcha7">직전매수대비수량7	long	12</param>
/// <param name="offerho8">매도호가8	int	8</param>
/// <param name="bidho8">매수호가8	int	8</param>
/// <param name="offerrem8">매도호가수량8	long	12</param>
/// <param name="bidrem8">매수호가수량8	long	12</param>
/// <param name="preoffercha8">직전매도대비수량8	long	12</param>
/// <param name="prebidcha8">직전매수대비수량8	long	12</param>
/// <param name="offerho9">매도호가9	int	8</param>
/// <param name="bidho9">매수호가9	int	8</param>
/// <param name="offerrem9">매도호가수량9	long	12</param>
/// <param name="bidrem9">매수호가수량9	long	12</param>
/// <param name="preoffercha9">직전매도대비수량9	long	12</param>
/// <param name="prebidcha9">직전매수대비수량9	long	12</param>
/// <param name="offerho10">매도호가10	int	8</param>
/// <param name="bidho10">매수호가10	int	8</param>
/// <param name="offerrem10">매도호가수량10	long	12</param>
/// <param name="bidrem10">매수호가수량10	long	12</param>
/// <param name="preoffercha10">직전매도대비수량10	long	12</param>
/// <param name="prebidcha10">직전매수대비수량10	long	12</param>
/// <param name="offer">매도호가수량합	long	12</param>
/// <param name="bid">매수호가수량합	long	12</param>
/// <param name="preoffercha">직전매도대비수량합	long	12</param>
/// <param name="prebidcha">직전매수대비수량합	long	12</param>
/// <param name="hotime">수신시간	string	8</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	long	12</param>
/// <param name="yesign">예상체결전일구분	string	1</param>
/// <param name="yechange">예상체결전일대비	int	8</param>
/// <param name="yediff">예상체결등락율	double	6.2</param>
/// <param name="tmoffer">시간외매도잔량	long	12</param>
/// <param name="tmbid">시간외매수잔량	long	12</param>
/// <param name="ho_status">동시구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
public record t1101OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("전일종가	int	8")] int jnilclose, [Description("매도호가1	int	8")] int offerho1, [Description("매수호가1	int	8")] int bidho1, [Description("매도호가수량1	long	12")] long offerrem1, [Description("매수호가수량1	long	12")] long bidrem1, [Description("직전매도대비수량1	long	12")] long preoffercha1, [Description("직전매수대비수량1	long	12")] long prebidcha1, [Description("매도호가2	int	8")] int offerho2, [Description("매수호가2	int	8")] int bidho2, [Description("매도호가수량2	long	12")] long offerrem2, [Description("매수호가수량2	long	12")] long bidrem2, [Description("직전매도대비수량2	long	12")] long preoffercha2, [Description("직전매수대비수량2	long	12")] long prebidcha2, [Description("매도호가3	int	8")] int offerho3, [Description("매수호가3	int	8")] int bidho3, [Description("매도호가수량3	long	12")] long offerrem3, [Description("매수호가수량3	long	12")] long bidrem3, [Description("직전매도대비수량3	long	12")] long preoffercha3, [Description("직전매수대비수량3	long	12")] long prebidcha3, [Description("매도호가4	int	8")] int offerho4, [Description("매수호가4	int	8")] int bidho4, [Description("매도호가수량4	long	12")] long offerrem4, [Description("매수호가수량4	long	12")] long bidrem4, [Description("직전매도대비수량4	long	12")] long preoffercha4, [Description("직전매수대비수량4	long	12")] long prebidcha4, [Description("매도호가5	int	8")] int offerho5, [Description("매수호가5	int	8")] int bidho5, [Description("매도호가수량5	long	12")] long offerrem5, [Description("매수호가수량5	long	12")] long bidrem5, [Description("직전매도대비수량5	long	12")] long preoffercha5, [Description("직전매수대비수량5	long	12")] long prebidcha5, [Description("매도호가6	int	8")] int offerho6, [Description("매수호가6	int	8")] int bidho6, [Description("매도호가수량6	long	12")] long offerrem6, [Description("매수호가수량6	long	12")] long bidrem6, [Description("직전매도대비수량6	long	12")] long preoffercha6, [Description("직전매수대비수량6	long	12")] long prebidcha6, [Description("매도호가7	int	8")] int offerho7, [Description("매수호가7	int	8")] int bidho7, [Description("매도호가수량7	long	12")] long offerrem7, [Description("매수호가수량7	long	12")] long bidrem7, [Description("직전매도대비수량7	long	12")] long preoffercha7, [Description("직전매수대비수량7	long	12")] long prebidcha7, [Description("매도호가8	int	8")] int offerho8, [Description("매수호가8	int	8")] int bidho8, [Description("매도호가수량8	long	12")] long offerrem8, [Description("매수호가수량8	long	12")] long bidrem8, [Description("직전매도대비수량8	long	12")] long preoffercha8, [Description("직전매수대비수량8	long	12")] long prebidcha8, [Description("매도호가9	int	8")] int offerho9, [Description("매수호가9	int	8")] int bidho9, [Description("매도호가수량9	long	12")] long offerrem9, [Description("매수호가수량9	long	12")] long bidrem9, [Description("직전매도대비수량9	long	12")] long preoffercha9, [Description("직전매수대비수량9	long	12")] long prebidcha9, [Description("매도호가10	int	8")] int offerho10, [Description("매수호가10	int	8")] int bidho10, [Description("매도호가수량10	long	12")] long offerrem10, [Description("매수호가수량10	long	12")] long bidrem10, [Description("직전매도대비수량10	long	12")] long preoffercha10, [Description("직전매수대비수량10	long	12")] long prebidcha10, [Description("매도호가수량합	long	12")] long offer, [Description("매수호가수량합	long	12")] long bid, [Description("직전매도대비수량합	long	12")] long preoffercha, [Description("직전매수대비수량합	long	12")] long prebidcha, [Description("수신시간	string	8")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	long	12")] long yevolume, [Description("예상체결전일구분	string	1")] string yesign, [Description("예상체결전일대비	int	8")] int yechange, [Description("예상체결등락율	double	6.2")] double yediff, [Description("시간외매도잔량	long	12")] long tmoffer, [Description("시간외매수잔량	long	12")] long tmbid, [Description("동시구분	string	1")] string ho_status, [Description("단축코드	string	6")] string shcode, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low);


/// <summary>
/// 주식현재가(시세)조회(t1102): t1102: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1102InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// 주식현재가(시세)조회(t1102): t1102: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="recprice">기준가(평가가격)	int	8</param>
/// <param name="avg">가중평균	int	8</param>
/// <param name="uplmtprice">상한가(최고호가가격)	int	8</param>
/// <param name="dnlmtprice">하한가(최저호가가격)	int	8</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="volumediff">거래량차	long	12</param>
/// <param name="open">시가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="high52w">52최고가	int	8</param>
/// <param name="high52wdate">52최고가일	string	8</param>
/// <param name="low52w">52최저가	int	8</param>
/// <param name="low52wdate">52최저가일	string	8</param>
/// <param name="exhratio">소진율	double	6.2</param>
/// <param name="per">PER	double	6.2</param>
/// <param name="pbrx">PBRX	double	6.2</param>
/// <param name="listing">상장주식수(천)	long	12</param>
/// <param name="jkrate">증거금율	int	8</param>
/// <param name="memedan">수량단위	string	5</param>
/// <param name="offernocd1">매도증권사코드1	string	3</param>
/// <param name="bidnocd1">매수증권사코드1	string	3</param>
/// <param name="offerno1">매도증권사명1	string	6</param>
/// <param name="bidno1">매수증권사명1	string	6</param>
/// <param name="dvol1">총매도수량1	int	8</param>
/// <param name="svol1">총매수수량1	int	8</param>
/// <param name="dcha1">매도증감1	int	8</param>
/// <param name="scha1">매수증감1	int	8</param>
/// <param name="ddiff1">매도비율1	double	6.2</param>
/// <param name="sdiff1">매수비율1	double	6.2</param>
/// <param name="offernocd2">매도증권사코드2	string	3</param>
/// <param name="bidnocd2">매수증권사코드2	string	3</param>
/// <param name="offerno2">매도증권사명2	string	6</param>
/// <param name="bidno2">매수증권사명2	string	6</param>
/// <param name="dvol2">총매도수량2	int	8</param>
/// <param name="svol2">총매수수량2	int	8</param>
/// <param name="dcha2">매도증감2	int	8</param>
/// <param name="scha2">매수증감2	int	8</param>
/// <param name="ddiff2">매도비율2	double	6.2</param>
/// <param name="sdiff2">매수비율2	double	6.2</param>
/// <param name="offernocd3">매도증권사코드3	string	3</param>
/// <param name="bidnocd3">매수증권사코드3	string	3</param>
/// <param name="offerno3">매도증권사명3	string	6</param>
/// <param name="bidno3">매수증권사명3	string	6</param>
/// <param name="dvol3">총매도수량3	int	8</param>
/// <param name="svol3">총매수수량3	int	8</param>
/// <param name="dcha3">매도증감3	int	8</param>
/// <param name="scha3">매수증감3	int	8</param>
/// <param name="ddiff3">매도비율3	double	6.2</param>
/// <param name="sdiff3">매수비율3	double	6.2</param>
/// <param name="offernocd4">매도증권사코드4	string	3</param>
/// <param name="bidnocd4">매수증권사코드4	string	3</param>
/// <param name="offerno4">매도증권사명4	string	6</param>
/// <param name="bidno4">매수증권사명4	string	6</param>
/// <param name="dvol4">총매도수량4	int	8</param>
/// <param name="svol4">총매수수량4	int	8</param>
/// <param name="dcha4">매도증감4	int	8</param>
/// <param name="scha4">매수증감4	int	8</param>
/// <param name="ddiff4">매도비율4	double	6.2</param>
/// <param name="sdiff4">매수비율4	double	6.2</param>
/// <param name="offernocd5">매도증권사코드5	string	3</param>
/// <param name="bidnocd5">매수증권사코드5	string	3</param>
/// <param name="offerno5">매도증권사명5	string	6</param>
/// <param name="bidno5">매수증권사명5	string	6</param>
/// <param name="dvol5">총매도수량5	int	8</param>
/// <param name="svol5">총매수수량5	int	8</param>
/// <param name="dcha5">매도증감5	int	8</param>
/// <param name="scha5">매수증감5	int	8</param>
/// <param name="ddiff5">매도비율5	double	6.2</param>
/// <param name="sdiff5">매수비율5	double	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	long	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	long	12</param>
/// <param name="ftradmddiff">외국계매도비율	double	6.2</param>
/// <param name="fwsvl">외국계매수합계수량	long	12</param>
/// <param name="ftradmscha">외국계매수직전대비	long	12</param>
/// <param name="ftradmsdiff">외국계매수비율	double	6.2</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="jvolume">전일동시간거래량	long	12</param>
/// <param name="highyear">연중최고가	int	8</param>
/// <param name="highyeardate">연중최고일자	string	8</param>
/// <param name="lowyear">연중최저가	int	8</param>
/// <param name="lowyeardate">연중최저일자	string	8</param>
/// <param name="target">목표가	int	8</param>
/// <param name="capital">자본금	long	12</param>
/// <param name="abscnt">유동주식수	long	12</param>
/// <param name="parprice">액면가	int	8</param>
/// <param name="gsmm">결산월	string	2</param>
/// <param name="subprice">대용가	int	8</param>
/// <param name="total">시가총액	long	12</param>
/// <param name="listdate">상장일	string	8</param>
/// <param name="name">전분기명	string	10</param>
/// <param name="bfsales">전분기매출액	long	12</param>
/// <param name="bfoperatingincome">전분기영업이익	long	12</param>
/// <param name="bfordinaryincome">전분기경상이익	long	12</param>
/// <param name="bfnetincome">전분기순이익	long	12</param>
/// <param name="bfeps">전분기EPS	double	13.2</param>
/// <param name="name2">전전분기명	string	10</param>
/// <param name="bfsales2">전전분기매출액	long	12</param>
/// <param name="bfoperatingincome2">전전분기영업이익	long	12</param>
/// <param name="bfordinaryincome2">전전분기경상이익	long	12</param>
/// <param name="bfnetincome2">전전분기순이익	long	12</param>
/// <param name="bfeps2">전전분기EPS	double	13.2</param>
/// <param name="salert">전년대비매출액	double	7.2</param>
/// <param name="opert">전년대비영업이익	double	7.2</param>
/// <param name="ordrt">전년대비경상이익	double	7.2</param>
/// <param name="netrt">전년대비순이익	double	7.2</param>
/// <param name="epsrt">전년대비EPS	double	7.2</param>
/// <param name="info1">락구분	string	10</param>
/// <param name="info2">관리/급등구분	string	10</param>
/// <param name="info3">정지/연장구분	string	10</param>
/// <param name="info4">투자/불성실구분	string	12</param>
/// <param name="janginfo">장구분	string	10</param>
/// <param name="t_per">T.PER	double	6.2</param>
/// <param name="tonghwa">통화ISO코드	string	3</param>
/// <param name="dval1">총매도대금1	long	18</param>
/// <param name="sval1">총매수대금1	long	18</param>
/// <param name="dval2">총매도대금2	long	18</param>
/// <param name="sval2">총매수대금2	long	18</param>
/// <param name="dval3">총매도대금3	long	18</param>
/// <param name="sval3">총매수대금3	long	18</param>
/// <param name="dval4">총매도대금4	long	18</param>
/// <param name="sval4">총매수대금4	long	18</param>
/// <param name="dval5">총매도대금5	long	18</param>
/// <param name="sval5">총매수대금5	long	18</param>
/// <param name="davg1">총매도평단가1	int	8</param>
/// <param name="savg1">총매수평단가1	int	8</param>
/// <param name="davg2">총매도평단가2	int	8</param>
/// <param name="savg2">총매수평단가2	int	8</param>
/// <param name="davg3">총매도평단가3	int	8</param>
/// <param name="savg3">총매수평단가3	int	8</param>
/// <param name="davg4">총매도평단가4	int	8</param>
/// <param name="savg4">총매수평단가4	int	8</param>
/// <param name="davg5">총매도평단가5	int	8</param>
/// <param name="savg5">총매수평단가5	int	8</param>
/// <param name="ftradmdval">외국계매도대금	long	18</param>
/// <param name="ftradmsval">외국계매수대금	long	18</param>
/// <param name="ftradmdvag">외국계매도평단가	int	8</param>
/// <param name="ftradmsvag">외국계매수평단가	int	8</param>
/// <param name="info5">투자주의환기	string	8</param>
/// <param name="spac_gubun">기업인수목적회사여부	string	1</param>
/// <param name="issueprice">발행가격	int	8</param>
/// <param name="alloc_gubun">배분적용구분코드(1:배분발생2:배분해제그외:미발생)	string	1</param>
/// <param name="alloc_text">배분적용구분	string	8</param>
/// <param name="shterm_text">단기과열/VI발동	string	10</param>
/// <param name="svi_uplmtprice">정적VI상한가	int	8</param>
/// <param name="svi_dnlmtprice">정적VI하한가	int	8</param>
/// <param name="low_lqdt_gu">저유동성종목여부	string	1</param>
/// <param name="abnormal_rise_gu">이상급등종목여부	string	1</param>
/// <param name="lend_text">대차불가표시	string	8</param>
/// <param name="ty_text">ETF/ETN투자유의	string	8</param>
public record t1102OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("기준가(평가가격)	int	8")] int recprice, [Description("가중평균	int	8")] int avg, [Description("상한가(최고호가가격)	int	8")] int uplmtprice, [Description("하한가(최저호가가격)	int	8")] int dnlmtprice, [Description("전일거래량	long	12")] long jnilvolume, [Description("거래량차	long	12")] long volumediff, [Description("시가	int	8")] int open, [Description("시가시간	string	6")] string opentime, [Description("고가	int	8")] int high, [Description("고가시간	string	6")] string hightime, [Description("저가	int	8")] int low, [Description("저가시간	string	6")] string lowtime, [Description("52최고가	int	8")] int high52w, [Description("52최고가일	string	8")] string high52wdate, [Description("52최저가	int	8")] int low52w, [Description("52최저가일	string	8")] string low52wdate, [Description("소진율	double	6.2")] double exhratio, [Description("PER	double	6.2")] double per, [Description("PBRX	double	6.2")] double pbrx, [Description("상장주식수(천)	long	12")] long listing, [Description("증거금율	int	8")] int jkrate, [Description("수량단위	string	5")] string memedan, [Description("매도증권사코드1	string	3")] string offernocd1, [Description("매수증권사코드1	string	3")] string bidnocd1, [Description("매도증권사명1	string	6")] string offerno1, [Description("매수증권사명1	string	6")] string bidno1, [Description("총매도수량1	int	8")] int dvol1, [Description("총매수수량1	int	8")] int svol1, [Description("매도증감1	int	8")] int dcha1, [Description("매수증감1	int	8")] int scha1, [Description("매도비율1	double	6.2")] double ddiff1, [Description("매수비율1	double	6.2")] double sdiff1, [Description("매도증권사코드2	string	3")] string offernocd2, [Description("매수증권사코드2	string	3")] string bidnocd2, [Description("매도증권사명2	string	6")] string offerno2, [Description("매수증권사명2	string	6")] string bidno2, [Description("총매도수량2	int	8")] int dvol2, [Description("총매수수량2	int	8")] int svol2, [Description("매도증감2	int	8")] int dcha2, [Description("매수증감2	int	8")] int scha2, [Description("매도비율2	double	6.2")] double ddiff2, [Description("매수비율2	double	6.2")] double sdiff2, [Description("매도증권사코드3	string	3")] string offernocd3, [Description("매수증권사코드3	string	3")] string bidnocd3, [Description("매도증권사명3	string	6")] string offerno3, [Description("매수증권사명3	string	6")] string bidno3, [Description("총매도수량3	int	8")] int dvol3, [Description("총매수수량3	int	8")] int svol3, [Description("매도증감3	int	8")] int dcha3, [Description("매수증감3	int	8")] int scha3, [Description("매도비율3	double	6.2")] double ddiff3, [Description("매수비율3	double	6.2")] double sdiff3, [Description("매도증권사코드4	string	3")] string offernocd4, [Description("매수증권사코드4	string	3")] string bidnocd4, [Description("매도증권사명4	string	6")] string offerno4, [Description("매수증권사명4	string	6")] string bidno4, [Description("총매도수량4	int	8")] int dvol4, [Description("총매수수량4	int	8")] int svol4, [Description("매도증감4	int	8")] int dcha4, [Description("매수증감4	int	8")] int scha4, [Description("매도비율4	double	6.2")] double ddiff4, [Description("매수비율4	double	6.2")] double sdiff4, [Description("매도증권사코드5	string	3")] string offernocd5, [Description("매수증권사코드5	string	3")] string bidnocd5, [Description("매도증권사명5	string	6")] string offerno5, [Description("매수증권사명5	string	6")] string bidno5, [Description("총매도수량5	int	8")] int dvol5, [Description("총매수수량5	int	8")] int svol5, [Description("매도증감5	int	8")] int dcha5, [Description("매수증감5	int	8")] int scha5, [Description("매도비율5	double	6.2")] double ddiff5, [Description("매수비율5	double	6.2")] double sdiff5, [Description("외국계매도합계수량	long	12")] long fwdvl, [Description("외국계매도직전대비	long	12")] long ftradmdcha, [Description("외국계매도비율	double	6.2")] double ftradmddiff, [Description("외국계매수합계수량	long	12")] long fwsvl, [Description("외국계매수직전대비	long	12")] long ftradmscha, [Description("외국계매수비율	double	6.2")] double ftradmsdiff, [Description("회전율	double	6.2")] double vol, [Description("단축코드	string	6")] string shcode, [Description("누적거래대금	long	12")] long value, [Description("전일동시간거래량	long	12")] long jvolume, [Description("연중최고가	int	8")] int highyear, [Description("연중최고일자	string	8")] string highyeardate, [Description("연중최저가	int	8")] int lowyear, [Description("연중최저일자	string	8")] string lowyeardate, [Description("목표가	int	8")] int target, [Description("자본금	long	12")] long capital, [Description("유동주식수	long	12")] long abscnt, [Description("액면가	int	8")] int parprice, [Description("결산월	string	2")] string gsmm, [Description("대용가	int	8")] int subprice, [Description("시가총액	long	12")] long total, [Description("상장일	string	8")] string listdate, [Description("전분기명	string	10")] string name, [Description("전분기매출액	long	12")] long bfsales, [Description("전분기영업이익	long	12")] long bfoperatingincome, [Description("전분기경상이익	long	12")] long bfordinaryincome, [Description("전분기순이익	long	12")] long bfnetincome, [Description("전분기EPS	double	13.2")] double bfeps, [Description("전전분기명	string	10")] string name2, [Description("전전분기매출액	long	12")] long bfsales2, [Description("전전분기영업이익	long	12")] long bfoperatingincome2, [Description("전전분기경상이익	long	12")] long bfordinaryincome2, [Description("전전분기순이익	long	12")] long bfnetincome2, [Description("전전분기EPS	double	13.2")] double bfeps2, [Description("전년대비매출액	double	7.2")] double salert, [Description("전년대비영업이익	double	7.2")] double opert, [Description("전년대비경상이익	double	7.2")] double ordrt, [Description("전년대비순이익	double	7.2")] double netrt, [Description("전년대비EPS	double	7.2")] double epsrt, [Description("락구분	string	10")] string info1, [Description("관리/급등구분	string	10")] string info2, [Description("정지/연장구분	string	10")] string info3, [Description("투자/불성실구분	string	12")] string info4, [Description("장구분	string	10")] string janginfo, [Description("T.PER	double	6.2")] double t_per, [Description("통화ISO코드	string	3")] string tonghwa, [Description("총매도대금1	long	18")] long dval1, [Description("총매수대금1	long	18")] long sval1, [Description("총매도대금2	long	18")] long dval2, [Description("총매수대금2	long	18")] long sval2, [Description("총매도대금3	long	18")] long dval3, [Description("총매수대금3	long	18")] long sval3, [Description("총매도대금4	long	18")] long dval4, [Description("총매수대금4	long	18")] long sval4, [Description("총매도대금5	long	18")] long dval5, [Description("총매수대금5	long	18")] long sval5, [Description("총매도평단가1	int	8")] int davg1, [Description("총매수평단가1	int	8")] int savg1, [Description("총매도평단가2	int	8")] int davg2, [Description("총매수평단가2	int	8")] int savg2, [Description("총매도평단가3	int	8")] int davg3, [Description("총매수평단가3	int	8")] int savg3, [Description("총매도평단가4	int	8")] int davg4, [Description("총매수평단가4	int	8")] int savg4, [Description("총매도평단가5	int	8")] int davg5, [Description("총매수평단가5	int	8")] int savg5, [Description("외국계매도대금	long	18")] long ftradmdval, [Description("외국계매수대금	long	18")] long ftradmsval, [Description("외국계매도평단가	int	8")] int ftradmdvag, [Description("외국계매수평단가	int	8")] int ftradmsvag, [Description("투자주의환기	string	8")] string info5, [Description("기업인수목적회사여부	string	1")] string spac_gubun, [Description("발행가격	int	8")] int issueprice, [Description("배분적용구분코드(1:배분발생2:배분해제그외:미발생)	string	1")] string alloc_gubun, [Description("배분적용구분	string	8")] string alloc_text, [Description("단기과열/VI발동	string	10")] string shterm_text, [Description("정적VI상한가	int	8")] int svi_uplmtprice, [Description("정적VI하한가	int	8")] int svi_dnlmtprice, [Description("저유동성종목여부	string	1")] string low_lqdt_gu, [Description("이상급등종목여부	string	1")] string abnormal_rise_gu, [Description("대차불가표시	string	8")] string lend_text, [Description("ETF/ETN투자유의	string	8")] string ty_text);


/// <summary>
/// 주식현재가시세메모(t1104): t1104: InBlock
/// </summary>
/// <param name="code">종목코드	string	6</param>
/// <param name="nrec">건수	string	2</param>
public record t1104InBlock([Description("종목코드	string	6")] string code, [Description("건수	string	2")] string nrec);

/// <summary>
/// 주식현재가시세메모(t1104): t1104: InBlock1
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="dat1">데이타1	string	1</param>
/// <param name="dat2">데이타2	string	8</param>
public record t1104InBlock1([Description("인덱스	string	1")] string indx, [Description("조건구분	string	1")] string gubn, [Description("데이타1	string	1")] string dat1, [Description("데이타2	string	8")] string dat2);

/// <summary>
/// 주식현재가시세메모(t1104): t1104: OutBlock
/// </summary>
/// <param name="nrec">출력건수	string	2</param>
public record t1104OutBlock([Description("출력건수	string	2")] string nrec);

/// <summary>
/// 주식현재가시세메모(t1104): t1104: OutBlock1
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="vals">출력값	string	8</param>
public record t1104OutBlock1([Description("인덱스	string	1")] string indx, [Description("조건구분	string	1")] string gubn, [Description("출력값	string	8")] string vals);


/// <summary>
/// 주식피못/디마크조회(t1105): t1105: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1105InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// 주식피못/디마크조회(t1105): t1105: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="pbot">피봇	int	8</param>
/// <param name="offer1">1차저항	int	8</param>
/// <param name="supp1">1차지지	int	8</param>
/// <param name="offer2">2차저항	int	8</param>
/// <param name="supp2">2차지지	int	8</param>
/// <param name="stdprc">기준가격	int	8</param>
/// <param name="offerd">D저항	int	8</param>
/// <param name="suppd">D지지	int	8</param>
public record t1105OutBlock([Description("단축코드	string	6")] string shcode, [Description("피봇	int	8")] int pbot, [Description("1차저항	int	8")] int offer1, [Description("1차지지	int	8")] int supp1, [Description("2차저항	int	8")] int offer2, [Description("2차지지	int	8")] int supp2, [Description("기준가격	int	8")] int stdprc, [Description("D저항	int	8")] int offerd, [Description("D지지	int	8")] int suppd);


/// <summary>
/// 시간외체결량(t1109): t1109: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="dan_chetime">체결cts	string	10</param>
/// <param name="idx">IDX	int	4</param>
public record t1109InBlock([Description("종목코드	string	6")] string shcode, [Description("체결cts	string	10")] string dan_chetime, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외체결량(t1109): t1109: OutBlock
/// </summary>
/// <param name="ctsshcode">종목cts	string	6</param>
/// <param name="ctschetime">체결cts	string	10</param>
/// <param name="idx">IDX	int	4</param>
public record t1109OutBlock([Description("종목cts	string	6")] string ctsshcode, [Description("체결cts	string	10")] string ctschetime, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외체결량(t1109): t1109: OutBlock1
/// </summary>
/// <param name="dan_chetime">시간	string	10</param>
/// <param name="dan_price">현재가	int	8</param>
/// <param name="dan_sign">전일대비구분	string	1</param>
/// <param name="dan_change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="dan_cvolume">체결량	int	8</param>
/// <param name="chdegree">체결강도	double	9.2</param>
/// <param name="dan_volume">누적거래량	long	12</param>
public record t1109OutBlock1([Description("시간	string	10")] string dan_chetime, [Description("현재가	int	8")] int dan_price, [Description("전일대비구분	string	1")] string dan_sign, [Description("전일대비	int	8")] int dan_change, [Description("등락율	double	6.2")] double diff, [Description("체결량	int	8")] int dan_cvolume, [Description("체결강도	double	9.2")] double chdegree, [Description("누적거래량	long	12")] long dan_volume);


/// <summary>
/// 주식시간대별체결조회(t1301): t1301: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1301InBlock([Description("단축코드	string	6")] string shcode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string starttime, [Description("종료시간	string	4")] string endtime, [Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식시간대별체결조회(t1301): t1301: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1301OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식시간대별체결조회(t1301): t1301: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	12</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="mdvolume">매도체결수량	long	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	long	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="revolume">순체결량	long	12</param>
/// <param name="rechecnt">순체결건수	int	8</param>
public record t1301OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	long	12")] long cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("거래량	long	12")] long volume, [Description("매도체결수량	long	12")] long mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	long	12")] long msvolume, [Description("매수체결건수	int	8")] int mschecnt, [Description("순체결량	long	12")] long revolume, [Description("순체결건수	int	8")] int rechecnt);


/// <summary>
/// 주식분별주가조회(t1302): t1302: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gubun">작업구분	string	1</param>
/// <param name="time">시간	string	6</param>
/// <param name="cnt">건수	int	3</param>
public record t1302InBlock([Description("단축코드	string	6")] string shcode, [Description("작업구분	string	1")] string gubun, [Description("시간	string	6")] string time, [Description("건수	int	3")] int cnt);

/// <summary>
/// 주식분별주가조회(t1302): t1302: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	6</param>
public record t1302OutBlock([Description("시간CTS	string	6")] string cts_time);

/// <summary>
/// 주식분별주가조회(t1302): t1302: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	6</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="mdvolume">매도체결수량	long	12</param>
/// <param name="msvolume">매수체결수량	long	12</param>
/// <param name="revolume">순매수체결량	long	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="rechecnt">순체결건수	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="cvolume">체결량	long	12</param>
/// <param name="mdchecnttm">매도체결건수(시간)	int	8</param>
/// <param name="mschecnttm">매수체결건수(시간)	int	8</param>
/// <param name="totofferrem">매도잔량	long	12</param>
/// <param name="totbidrem">매수잔량	long	12</param>
/// <param name="mdvolumetm">시간별매도체결량	long	12</param>
/// <param name="msvolumetm">시간별매수체결량	long	12</param>
public record t1302OutBlock1([Description("시간	string	6")] string chetime, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결강도	double	8.2")] double chdegree, [Description("매도체결수량	long	12")] long mdvolume, [Description("매수체결수량	long	12")] long msvolume, [Description("순매수체결량	long	12")] long revolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결건수	int	8")] int mschecnt, [Description("순체결건수	int	8")] int rechecnt, [Description("거래량	long	12")] long volume, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("체결량	long	12")] long cvolume, [Description("매도체결건수(시간)	int	8")] int mdchecnttm, [Description("매수체결건수(시간)	int	8")] int mschecnttm, [Description("매도잔량	long	12")] long totofferrem, [Description("매수잔량	long	12")] long totbidrem, [Description("시간별매도체결량	long	12")] long mdvolumetm, [Description("시간별매수체결량	long	12")] long msvolumetm);


/// <summary>
/// 기간별주가(t1305): t1305: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="dwmcode">일주월구분	int	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="cnt">건수	int	4</param>
public record t1305InBlock([Description("단축코드	string	6")] string shcode, [Description("일주월구분	int	1")] int dwmcode, [Description("날짜	string	8")] string date, [Description("IDX	int	4")] int idx, [Description("건수	int	4")] int cnt);

/// <summary>
/// 기간별주가(t1305): t1305: OutBlock
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1305OutBlock([Description("CNT	int	4")] int cnt, [Description("날짜	string	8")] string date, [Description("IDX	int	4")] int idx);

/// <summary>
/// 기간별주가(t1305): t1305: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="chdegree">체결강도	double	6.2</param>
/// <param name="sojinrate">소진율	double	6.2</param>
/// <param name="changerate">회전율	double	6.2</param>
/// <param name="fpvolume">외인순매수	long	12</param>
/// <param name="covolume">기관순매수	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="value">누적거래대금(단위:백만)	long	12</param>
/// <param name="ppvolume">개인순매수	long	12</param>
/// <param name="o_sign">시가대비구분	string	1</param>
/// <param name="o_change">시가대비	int	8</param>
/// <param name="o_diff">시가기준등락율	double	6.2</param>
/// <param name="h_sign">고가대비구분	string	1</param>
/// <param name="h_change">고가대비	int	8</param>
/// <param name="h_diff">고가기준등락율	double	6.2</param>
/// <param name="l_sign">저가대비구분	string	1</param>
/// <param name="l_change">저가대비	int	8</param>
/// <param name="l_diff">저가기준등락율	double	6.2</param>
/// <param name="marketcap">시가총액(단위:백만)	long	12</param>
public record t1305OutBlock1([Description("날짜	string	8")] string date, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("체결강도	double	6.2")] double chdegree, [Description("소진율	double	6.2")] double sojinrate, [Description("회전율	double	6.2")] double changerate, [Description("외인순매수	long	12")] long fpvolume, [Description("기관순매수	long	12")] long covolume, [Description("종목코드	string	6")] string shcode, [Description("누적거래대금(단위:백만)	long	12")] long value, [Description("개인순매수	long	12")] long ppvolume, [Description("시가대비구분	string	1")] string o_sign, [Description("시가대비	int	8")] int o_change, [Description("시가기준등락율	double	6.2")] double o_diff, [Description("고가대비구분	string	1")] string h_sign, [Description("고가대비	int	8")] int h_change, [Description("고가기준등락율	double	6.2")] double h_diff, [Description("저가대비구분	string	1")] string l_sign, [Description("저가대비	int	8")] int l_change, [Description("저가기준등락율	double	6.2")] double l_diff, [Description("시가총액(단위:백만)	long	12")] long marketcap);


/// <summary>
/// 주식시간대별체결조회챠트(t1308): t1308: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="bun_term">분간격	string	2</param>
public record t1308InBlock([Description("단축코드	string	6")] string shcode, [Description("시작시간	string	4")] string starttime, [Description("종료시간	string	4")] string endtime, [Description("분간격	string	2")] string bun_term);

/// <summary>
/// 주식시간대별체결조회챠트(t1308): t1308: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="chdegvol">체결강도(거래량)	double	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	double	8.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="mdvolume">매도체결수량	long	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	long	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
public record t1308OutBlock1([Description("시간	string	8")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	int	8")] int cvolume, [Description("체결강도(거래량)	double	8.2")] double chdegvol, [Description("체결강도(건수)	double	8.2")] double chdegcnt, [Description("거래량	long	12")] long volume, [Description("매도체결수량	long	12")] long mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	long	12")] long msvolume, [Description("매수체결건수	int	8")] int mschecnt, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low);


/// <summary>
/// 주식당일전일분틱조회(t1310): t1310: InBlock
/// </summary>
/// <param name="daygb">당일전일구분	string	1</param>
/// <param name="timegb">분틱구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1310InBlock([Description("당일전일구분	string	1")] string daygb, [Description("분틱구분	string	1")] string timegb, [Description("단축코드	string	6")] string shcode, [Description("종료시간	string	4")] string endtime, [Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식당일전일분틱조회(t1310): t1310: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1310OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식당일전일분틱조회(t1310): t1310: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	12</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="mdvolume">매도체결수량	long	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	long	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="revolume">순체결량	long	12</param>
/// <param name="rechecnt">순체결건수	int	8</param>
public record t1310OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	long	12")] long cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("거래량	long	12")] long volume, [Description("매도체결수량	long	12")] long mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	long	12")] long msvolume, [Description("매수체결건수	int	8")] int mschecnt, [Description("순체결량	long	12")] long revolume, [Description("순체결건수	int	8")] int rechecnt);


/// <summary>
/// 신규상장종목조회(t1403): t1403: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="styymm">시작상장월	string	6</param>
/// <param name="enyymm">종료상장월	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1403InBlock([Description("구분	string	1")] string gubun, [Description("시작상장월	string	6")] string styymm, [Description("종료상장월	string	6")] string enyymm, [Description("IDX	int	4")] int idx);

/// <summary>
/// 신규상장종목조회(t1403): t1403: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1403OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 신규상장종목조회(t1403): t1403: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="kmprice">공모가	int	8</param>
/// <param name="date">등록일	string	8</param>
/// <param name="recprice">등록일기준가	int	8</param>
/// <param name="kmdiff">기준가등락율	double	6.2</param>
/// <param name="close">등록일종가	int	8</param>
/// <param name="recdiff">등록일등락율	double	6.2</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1403OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("공모가	int	8")] int kmprice, [Description("등록일	string	8")] string date, [Description("등록일기준가	int	8")] int recprice, [Description("기준가등락율	double	6.2")] double kmdiff, [Description("등록일종가	int	8")] int close, [Description("등록일등락율	double	6.2")] double recdiff, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 관리/불성실/투자유의조회(t1404): t1404: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1404InBlock([Description("구분	string	1")] string gubun, [Description("종목체크	string	1")] string jongchk, [Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 관리/불성실/투자유의조회(t1404): t1404: OutBlock
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1404OutBlock([Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 관리/불성실/투자유의조회(t1404): t1404: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="date">지정일	string	8</param>
/// <param name="tprice">지정일주가	int	8</param>
/// <param name="tchange">지정일대비	int	8</param>
/// <param name="tdiff">대비율	double	6.2</param>
/// <param name="reason">사유	string	4</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="edate">해제일	string	8</param>
public record t1404OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("지정일	string	8")] string date, [Description("지정일주가	int	8")] int tprice, [Description("지정일대비	int	8")] int tchange, [Description("대비율	double	6.2")] double tdiff, [Description("사유	string	4")] string reason, [Description("종목코드	string	6")] string shcode, [Description("해제일	string	8")] string edate);


/// <summary>
/// 투자경고/매매정지/정리매매조회(t1405): t1405: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1405InBlock([Description("구분	string	1")] string gubun, [Description("종목체크	string	1")] string jongchk, [Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 투자경고/매매정지/정리매매조회(t1405): t1405: OutBlock
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1405OutBlock([Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 투자경고/매매정지/정리매매조회(t1405): t1405: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="date">지정일	string	8</param>
/// <param name="edate">해제일	string	8</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1405OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("지정일	string	8")] string date, [Description("해제일	string	8")] string edate, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 초저유동성조회(t1410): t1410: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1410InBlock([Description("구분	string	1")] string gubun, [Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 초저유동성조회(t1410): t1410: OutBlock
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1410OutBlock([Description("종목코드_CTS	string	6")] string cts_shcode);

/// <summary>
/// 초저유동성조회(t1410): t1410: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1410OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 증거금율별종목조회(t1411): t1411: InBlock
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="jongchk">위탁신용구분	string	1</param>
/// <param name="jkrate">증거금율구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1411InBlock([Description("시장구분	string	1")] string gubun, [Description("위탁신용구분	string	1")] string jongchk, [Description("증거금율구분	string	1")] string jkrate, [Description("종목코드	string	6")] string shcode, [Description("IDX	int	4")] int idx);

/// <summary>
/// 증거금율별종목조회(t1411): t1411: OutBlock
/// </summary>
/// <param name="jkrate">위탁증거금율	int	3</param>
/// <param name="sjkrate">신용증거금율	int	3</param>
/// <param name="idx">IDX	int	4</param>
public record t1411OutBlock([Description("위탁증거금율	int	3")] int jkrate, [Description("신용증거금율	int	3")] int sjkrate, [Description("IDX	int	4")] int idx);

/// <summary>
/// 증거금율별종목조회(t1411): t1411: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="jkrate">위탁증거금율	int	3</param>
/// <param name="sjkrate">신용증거금율	int	3</param>
/// <param name="subprice">대용가	int	8</param>
/// <param name="recprice">전일종가	int	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
public record t1411OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	20")] string hname, [Description("위탁증거금율	int	3")] int jkrate, [Description("신용증거금율	int	3")] int sjkrate, [Description("대용가	int	8")] int subprice, [Description("전일종가	int	8")] int recprice, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume);


/// <summary>
/// 상/하한(t1422): t1422: InBlock
/// </summary>
/// <param name="qrygb">조회구분	string	1</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="jnilgubun">전일구분	string	1</param>
/// <param name="sign">상하한구분	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
public record t1422InBlock([Description("조회구분	string	1")] string qrygb, [Description("구분	string	1")] string gubun, [Description("전일구분	string	1")] string jnilgubun, [Description("상하한구분	string	1")] string sign, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx);

/// <summary>
/// 상/하한(t1422): t1422: OutBlock
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t1422OutBlock([Description("CNT	int	4")] int cnt, [Description("IDX	int	4")] int idx);

/// <summary>
/// 상/하한(t1422): t1422: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="last">최종진입	string	6</param>
/// <param name="lmtdaycnt">연속	int	8</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1422OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("최종진입	string	6")] string last, [Description("연속	int	8")] int lmtdaycnt, [Description("전일거래량	long	12")] long jnilvolume, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 상/하한가직전(t1427): t1427: InBlock
/// </summary>
/// <param name="qrygb">조회구분	string	1</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="signgubun">상하한가구분	string	1</param>
/// <param name="diff">등락율	int	3</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jshex">전일상하한제외	string	1</param>
public record t1427InBlock([Description("조회구분	string	1")] string qrygb, [Description("구분	string	1")] string gubun, [Description("상하한가구분	string	1")] string signgubun, [Description("등락율	int	3")] int diff, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx, [Description("전일상하한제외	string	1")] string jshex);

/// <summary>
/// 상/하한가직전(t1427): t1427: OutBlock
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t1427OutBlock([Description("CNT	int	4")] int cnt, [Description("IDX	int	4")] int idx);

/// <summary>
/// 상/하한가직전(t1427): t1427: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="lmtprice">상한가/하한가	int	8</param>
/// <param name="rate">대비율	double	12.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="lmtdaycnt">연속	int	8</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="total">시가총액	long	12</param>
public record t1427OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("상한가/하한가	int	8")] int lmtprice, [Description("대비율	double	12.2")] double rate, [Description("종목코드	string	6")] string shcode, [Description("전일거래량	long	12")] long jnilvolume, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("연속	int	8")] int lmtdaycnt, [Description("거래대금	long	12")] long value, [Description("시가총액	long	12")] long total);


/// <summary>
/// 등락율상위(t1441): t1441: InBlock
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="gubun2">상승하락	string	1</param>
/// <param name="gubun3">당일전일	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jc_num2">대상제외2	long	12</param>
public record t1441InBlock([Description("구분	string	1")] string gubun1, [Description("상승하락	string	1")] string gubun2, [Description("당일전일	string	1")] string gubun3, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx, [Description("대상제외2	long	12")] long jc_num2);

/// <summary>
/// 등락율상위(t1441): t1441: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1441OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 등락율상위(t1441): t1441: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="offerho1">매도호가	long	12</param>
/// <param name="bidho1">매수호가	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="updaycnt">연속	int	4</param>
/// <param name="jnildiff">전일등락율	double	6.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="voldiff">거래량대비율	double	8.2</param>
/// <param name="value">거래대금	long	15</param>
/// <param name="total">시가총액	long	12</param>
public record t1441OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("매도잔량	long	12")] long offerrem1, [Description("매도호가	long	12")] long offerho1, [Description("매수호가	long	12")] long bidho1, [Description("매수잔량	long	12")] long bidrem1, [Description("연속	int	4")] int updaycnt, [Description("전일등락율	double	6.2")] double jnildiff, [Description("종목코드	string	6")] string shcode, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("거래량대비율	double	8.2")] double voldiff, [Description("거래대금	long	15")] long value, [Description("시가총액	long	12")] long total);


/// <summary>
/// 신고/신저가(t1442): t1442: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="type1">신고신저	string	1</param>
/// <param name="type2">기간	string	1</param>
/// <param name="type3">유지여부	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jc_num2">대상제외2	long	12</param>
public record t1442InBlock([Description("구분	string	1")] string gubun, [Description("신고신저	string	1")] string type1, [Description("기간	string	1")] string type2, [Description("유지여부	string	1")] string type3, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx, [Description("대상제외2	long	12")] long jc_num2);

/// <summary>
/// 신고/신저가(t1442): t1442: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1442OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 신고/신저가(t1442): t1442: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="pastprice">이전가	int	8</param>
/// <param name="pastsign">이전가대비구분	string	1</param>
/// <param name="pastchange">이전가대비	int	8</param>
/// <param name="pastdiff">이전가대비율	double	6.2</param>
public record t1442OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("이전가	int	8")] int pastprice, [Description("이전가대비구분	string	1")] string pastsign, [Description("이전가대비	int	8")] int pastchange, [Description("이전가대비율	double	6.2")] double pastdiff);


/// <summary>
/// 시가총액상위(t1444): t1444: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="idx">IDX	int	4</param>
public record t1444InBlock([Description("업종코드	string	3")] string upcode, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시가총액상위(t1444): t1444: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1444OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 시가총액상위(t1444): t1444: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="vol_rate">거래비중	double	6.2</param>
/// <param name="total">시가총액	long	12</param>
/// <param name="rate">비중	double	6.2</param>
/// <param name="for_rate">외인비중	double	6.2</param>
public record t1444OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래비중	double	6.2")] double vol_rate, [Description("시가총액	long	12")] long total, [Description("비중	double	6.2")] double rate, [Description("외인비중	double	6.2")] double for_rate);


/// <summary>
/// 가격대별매매비중조회(t1449): t1449: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="dategb">일자구분	string	1</param>
public record t1449InBlock([Description("단축코드	string	6")] string shcode, [Description("일자구분	string	1")] string dategb);

/// <summary>
/// 가격대별매매비중조회(t1449): t1449: OutBlock
/// </summary>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="msvolume">매수체결량	long	12</param>
/// <param name="mdvolume">매도체결량	long	12</param>
public record t1449OutBlock([Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("매수체결량	long	12")] long msvolume, [Description("매도체결량	long	12")] long mdvolume);

/// <summary>
/// 가격대별매매비중조회(t1449): t1449: OutBlock1
/// </summary>
/// <param name="price">체결가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="tickdiff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	12</param>
/// <param name="diff">비중	double	6.2</param>
/// <param name="mdvolume">매도체결량	long	12</param>
/// <param name="msvolume">매수체결량	long	12</param>
/// <param name="msdiff">매수비율	double	6.2</param>
public record t1449OutBlock1([Description("체결가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double tickdiff, [Description("체결수량	long	12")] long cvolume, [Description("비중	double	6.2")] double diff, [Description("매도체결량	long	12")] long mdvolume, [Description("매수체결량	long	12")] long msvolume, [Description("매수비율	double	6.2")] double msdiff);


/// <summary>
/// 거래량상위(t1452): t1452: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jnilgubun">전일구분	string	1</param>
/// <param name="sdiff">시작등락율	int	3</param>
/// <param name="ediff">종료등락율	int	3</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
public record t1452InBlock([Description("구분	string	1")] string gubun, [Description("전일구분	string	1")] string jnilgubun, [Description("시작등락율	int	3")] int sdiff, [Description("종료등락율	int	3")] int ediff, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx);

/// <summary>
/// 거래량상위(t1452): t1452: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1452OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 거래량상위(t1452): t1452: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="bef_diff">전일비	double	10.2</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1452OutBlock1([Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("회전율	double	6.2")] double vol, [Description("전일거래량	long	12")] long jnilvolume, [Description("전일비	double	10.2")] double bef_diff, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 거래대금상위(t1463): t1463: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jnilgubun">전일구분	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jc_num2">대상제외2	long	12</param>
public record t1463InBlock([Description("구분	string	1")] string gubun, [Description("전일구분	string	1")] string jnilgubun, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx, [Description("대상제외2	long	12")] long jc_num2);

/// <summary>
/// 거래대금상위(t1463): t1463: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1463OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 거래대금상위(t1463): t1463: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="jnilvalue">전일거래대금	long	12</param>
/// <param name="bef_diff">전일비	double	10.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="filler">filler	string	1</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
public record t1463OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래대금	long	12")] long value, [Description("전일거래대금	long	12")] long jnilvalue, [Description("전일비	double	10.2")] double bef_diff, [Description("종목코드	string	6")] string shcode, [Description("filler	string	1")] string filler, [Description("전일거래량	long	12")] long jnilvolume);


/// <summary>
/// 전일동시간대비거래급증(t1466): t1466: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="type1">전일거래량	string	1</param>
/// <param name="type2">거래급등율	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jc_num2">대상제외2	long	12</param>
public record t1466InBlock([Description("구분	string	1")] string gubun, [Description("전일거래량	string	1")] string type1, [Description("거래급등율	string	1")] string type2, [Description("대상제외	long	12")] long jc_num, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("IDX	int	4")] int idx, [Description("대상제외2	long	12")] long jc_num2);

/// <summary>
/// 전일동시간대비거래급증(t1466): t1466: OutBlock
/// </summary>
/// <param name="hhmm">현재시분	string	5</param>
/// <param name="idx">IDX	int	4</param>
public record t1466OutBlock([Description("현재시분	string	5")] string hhmm, [Description("IDX	int	4")] int idx);

/// <summary>
/// 전일동시간대비거래급증(t1466): t1466: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="stdvolume">전일거래량	long	12</param>
/// <param name="volume">당일거래량	long	12</param>
/// <param name="voldiff">거래급등율	double	8.2</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
public record t1466OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("전일거래량	long	12")] long stdvolume, [Description("당일거래량	long	12")] long volume, [Description("거래급등율	double	8.2")] double voldiff, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low);


/// <summary>
/// 시간대별호가잔량추이(t1471): t1471: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">분구분	string	2</param>
/// <param name="time">시간	string	6</param>
/// <param name="cnt">자료개수	string	3</param>
public record t1471InBlock([Description("종목코드	string	6")] string shcode, [Description("분구분	string	2")] string gubun, [Description("시간	string	6")] string time, [Description("자료개수	string	3")] string cnt);

/// <summary>
/// 시간대별호가잔량추이(t1471): t1471: OutBlock
/// </summary>
/// <param name="time">시간CTS	string	6</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
public record t1471OutBlock([Description("시간CTS	string	6")] string time, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume);

/// <summary>
/// 시간대별호가잔량추이(t1471): t1471: OutBlock1
/// </summary>
/// <param name="time">체결시간	string	6</param>
/// <param name="preoffercha1">메도증감	long	12</param>
/// <param name="offerrem1">매도우선잔량	long	12</param>
/// <param name="offerho1">매도우선호가	int	8</param>
/// <param name="bidho1">매수우선호가	int	8</param>
/// <param name="bidrem1">매수우선잔량	long	12</param>
/// <param name="prebidcha1">매수증감	long	12</param>
/// <param name="totofferrem">총매도	long	12</param>
/// <param name="totbidrem">총매수	long	12</param>
/// <param name="totsun">순매수	long	12</param>
/// <param name="msrate">매수비율	double	6.2</param>
/// <param name="close">종가	int	8</param>
public record t1471OutBlock1([Description("체결시간	string	6")] string time, [Description("메도증감	long	12")] long preoffercha1, [Description("매도우선잔량	long	12")] long offerrem1, [Description("매도우선호가	int	8")] int offerho1, [Description("매수우선호가	int	8")] int bidho1, [Description("매수우선잔량	long	12")] long bidrem1, [Description("매수증감	long	12")] long prebidcha1, [Description("총매도	long	12")] long totofferrem, [Description("총매수	long	12")] long totbidrem, [Description("순매수	long	12")] long totsun, [Description("매수비율	double	6.2")] double msrate, [Description("종가	int	8")] int close);


/// <summary>
/// 체결강도추이(t1475): t1475: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="vptype">상승하락	string	1</param>
/// <param name="datacnt">데이터개수	int	4</param>
/// <param name="date">기준일자	int	8</param>
/// <param name="time">기준시간	int	6</param>
/// <param name="rankcnt">랭크카운터	int	3</param>
/// <param name="gubun">조회구분	string	1</param>
public record t1475InBlock([Description("종목코드	string	6")] string shcode, [Description("상승하락	string	1")] string vptype, [Description("데이터개수	int	4")] int datacnt, [Description("기준일자	int	8")] int date, [Description("기준시간	int	6")] int time, [Description("랭크카운터	int	3")] int rankcnt, [Description("조회구분	string	1")] string gubun);

/// <summary>
/// 체결강도추이(t1475): t1475: OutBlock
/// </summary>
/// <param name="date">기준일자	int	8</param>
/// <param name="time">기준시간	int	6</param>
/// <param name="rankcnt">랭크카운터	int	3</param>
public record t1475OutBlock([Description("기준일자	int	8")] int date, [Description("기준시간	int	6")] int time, [Description("랭크카운터	int	3")] int rankcnt);

/// <summary>
/// 체결강도추이(t1475): t1475: OutBlock1
/// </summary>
/// <param name="datetime">일자	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="todayvp">당일VP	double	8.2</param>
/// <param name="ma5vp">5일MAVP	double	8.2</param>
/// <param name="ma20vp">20일MAVP	double	8.2</param>
/// <param name="ma60vp">60일MAVP	double	8.2</param>
public record t1475OutBlock1([Description("일자	string	10")] string datetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("당일VP	double	8.2")] double todayvp, [Description("5일MAVP	double	8.2")] double ma5vp, [Description("20일MAVP	double	8.2")] double ma20vp, [Description("60일MAVP	double	8.2")] double ma60vp);


/// <summary>
/// 시간외등락율상위(t1481): t1481: InBlock
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="gubun2">상승하락	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="volume">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1481InBlock([Description("구분	string	1")] string gubun1, [Description("상승하락	string	1")] string gubun2, [Description("종목체크	string	1")] string jongchk, [Description("거래량	string	1")] string volume, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외등락율상위(t1481): t1481: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1481OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외등락율상위(t1481): t1481: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="offerho1">매도호가	long	12</param>
/// <param name="bidho1">매수호가	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="value">누적거래대금	long	12</param>
public record t1481OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("매도호가	long	12")] long offerho1, [Description("매수호가	long	12")] long bidho1, [Description("종목코드	string	6")] string shcode, [Description("누적거래대금	long	12")] long value);


/// <summary>
/// 시간외거래량상위(t1482): t1482: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1482InBlock([Description("구분	string	1")] string gubun, [Description("거래량	string	1")] string jongchk, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외거래량상위(t1482): t1482: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1482OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 시간외거래량상위(t1482): t1482: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="value">누적거래대금	long	12</param>
public record t1482OutBlock1([Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("회전율	double	6.2")] double vol, [Description("종목코드	string	6")] string shcode, [Description("누적거래대금	long	12")] long value);


/// <summary>
/// 예상지수(t1485): t1485: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun">조회구분	string	1</param>
public record t1485InBlock([Description("업종코드	string	3")] string upcode, [Description("조회구분	string	1")] string gubun);

/// <summary>
/// 예상지수(t1485): t1485: OutBlock
/// </summary>
/// <param name="pricejisu">현재지수	double	10.2</param>
/// <param name="sign">지수전일대비구분	string	1</param>
/// <param name="change">전일대비	double	10.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="yhighjo">상승종목수	int	4</param>
/// <param name="yupjo">상한종목수	int	4</param>
/// <param name="yunchgjo">보합종목수	int	4</param>
/// <param name="ylowjo">하락종목수	int	4</param>
/// <param name="ydownjo">하한종목수	int	4</param>
/// <param name="ytrajo">거래형성수	int	4</param>
public record t1485OutBlock([Description("현재지수	double	10.2")] double pricejisu, [Description("지수전일대비구분	string	1")] string sign, [Description("전일대비	double	10.2")] double change, [Description("거래량	long	12")] long volume, [Description("상승종목수	int	4")] int yhighjo, [Description("상한종목수	int	4")] int yupjo, [Description("보합종목수	int	4")] int yunchgjo, [Description("하락종목수	int	4")] int ylowjo, [Description("하한종목수	int	4")] int ydownjo, [Description("거래형성수	int	4")] int ytrajo);

/// <summary>
/// 예상지수(t1485): t1485: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	6</param>
/// <param name="jisu">예상지수	double	10.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	10.2</param>
/// <param name="volume">예상체결량	long	12</param>
/// <param name="volcha">예상체결량직전대비	long	12</param>
/// <param name="diff">예상등락율	double	6.2</param>
public record t1485OutBlock1([Description("시간	string	6")] string chetime, [Description("예상지수	double	10.2")] double jisu, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	10.2")] double change, [Description("예상체결량	long	12")] long volume, [Description("예상체결량직전대비	long	12")] long volcha, [Description("예상등락율	double	6.2")] double diff);


/// <summary>
/// 시간별예상체결가(t1486): t1486: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cts_time">시간CTS	string	10</param>
/// <param name="cnt">조회건수	int	4</param>
public record t1486InBlock([Description("단축코드	string	6")] string shcode, [Description("시간CTS	string	10")] string cts_time, [Description("조회건수	int	4")] int cnt);

/// <summary>
/// 시간별예상체결가(t1486): t1486: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1486OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 시간별예상체결가(t1486): t1486: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	8</param>
/// <param name="price">예상체결가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">예상체결량	long	12</param>
/// <param name="offerho1">매도호가	int	8</param>
/// <param name="bidho1">매수호가	int	8</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
public record t1486OutBlock1([Description("시간	string	8")] string chetime, [Description("예상체결가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("예상체결량	long	12")] long cvolume, [Description("매도호가	int	8")] int offerho1, [Description("매수호가	int	8")] int bidho1, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1);


/// <summary>
/// 예상체결가등락율상위조회(t1488): t1488: InBlock
/// </summary>
/// <param name="gubun">거래소구분	string	1</param>
/// <param name="sign">상하락구분	string	1</param>
/// <param name="jgubun">장구분	string	1</param>
/// <param name="jongchk">종목체크	string	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="volume">거래량	string	1</param>
/// <param name="yesprice">예상체결시작가격	int	8</param>
/// <param name="yeeprice">예상체결종료가격	int	8</param>
/// <param name="yevolume">예상체결량	long	12</param>
public record t1488InBlock([Description("거래소구분	string	1")] string gubun, [Description("상하락구분	string	1")] string sign, [Description("장구분	string	1")] string jgubun, [Description("종목체크	string	12")] string jongchk, [Description("IDX	int	4")] int idx, [Description("거래량	string	1")] string volume, [Description("예상체결시작가격	int	8")] int yesprice, [Description("예상체결종료가격	int	8")] int yeeprice, [Description("예상체결량	long	12")] long yevolume);

/// <summary>
/// 예상체결가등락율상위조회(t1488): t1488: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1488OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 예상체결가등락율상위조회(t1488): t1488: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="offerrem">매도잔량	long	12</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="bidrem">매수잔량	long	12</param>
/// <param name="cnt">연속일수	int	4</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="jkrate">증거금율	string	3</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
public record t1488OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("매도잔량	long	12")] long offerrem, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("매수잔량	long	12")] long bidrem, [Description("연속일수	int	4")] int cnt, [Description("종목코드	string	6")] string shcode, [Description("증거금율	string	3")] string jkrate, [Description("전일거래량	long	12")] long jnilvolume);


/// <summary>
/// 예상체결량상위조회(t1489): t1489: InBlock
/// </summary>
/// <param name="gubun">거래소구분	string	1</param>
/// <param name="jgubun">장구분	string	1</param>
/// <param name="jongchk">종목체크	string	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="yesprice">예상체결시작가격	int	8</param>
/// <param name="yeeprice">예상체결종료가격	int	8</param>
/// <param name="yevolume">예상체결량	long	12</param>
public record t1489InBlock([Description("거래소구분	string	1")] string gubun, [Description("장구분	string	1")] string jgubun, [Description("종목체크	string	12")] string jongchk, [Description("IDX	int	4")] int idx, [Description("예상체결시작가격	int	8")] int yesprice, [Description("예상체결종료가격	int	8")] int yeeprice, [Description("예상체결량	long	12")] long yevolume);

/// <summary>
/// 예상체결량상위조회(t1489): t1489: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1489OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 예상체결량상위조회(t1489): t1489: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">예상거래량	long	12</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
public record t1489OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("예상거래량	long	12")] long volume, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("종목코드	string	6")] string shcode, [Description("전일거래량	long	12")] long jnilvolume);


/// <summary>
/// 단일가예상등락율상위(t1492): t1492: InBlock
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="gubun2">상승하락	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="volume">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1492InBlock([Description("구분	string	1")] string gubun1, [Description("상승하락	string	1")] string gubun2, [Description("종목체크	string	1")] string jongchk, [Description("거래량	string	1")] string volume, [Description("IDX	int	4")] int idx);

/// <summary>
/// 단일가예상등락율상위(t1492): t1492: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1492OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// 단일가예상등락율상위(t1492): t1492: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">예상체결가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="yevolume">예상체결량	long	12</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="offerho1">매도호가	long	12</param>
/// <param name="bidho1">매수호가	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="value">누적거래대금	long	12</param>
public record t1492OutBlock1([Description("한글명	string	20")] string hname, [Description("예상체결가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("예상체결량	long	12")] long yevolume, [Description("누적거래량	long	12")] long volume, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("매도호가	long	12")] long offerho1, [Description("매수호가	long	12")] long bidho1, [Description("종목코드	string	6")] string shcode, [Description("누적거래대금	long	12")] long value);


/// <summary>
/// 업종현재가(t1511): t1511: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record t1511InBlock([Description("업종코드	string	3")] string upcode);

/// <summary>
/// 업종현재가(t1511): t1511: OutBlock
/// </summary>
/// <param name="gubun">업종구분	string	1</param>
/// <param name="hname">업종명	string	20</param>
/// <param name="pricejisu">현재지수	double	7.2</param>
/// <param name="jniljisu">전일지수	double	7.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	7.2</param>
/// <param name="diffjisu">지수등락율	double	6.2</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="volume">당일거래량	long	12</param>
/// <param name="volumechange">거래량전일대비	long	12</param>
/// <param name="volumerate">거래량비율	double	6.2</param>
/// <param name="jnilvalue">전일거래대금	long	12</param>
/// <param name="value">당일거래대금	long	12</param>
/// <param name="valuechange">거래대금전일대비	long	12</param>
/// <param name="valuerate">거래대금비율	double	6.2</param>
/// <param name="openjisu">시가지수	double	7.2</param>
/// <param name="opendiff">시가등락율	double	6.2</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="highjisu">고가지수	double	7.2</param>
/// <param name="highdiff">고가등락율	double	6.2</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="lowjisu">저가지수	double	7.2</param>
/// <param name="lowdiff">저가등락율	double	6.2</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="whjisu">52주최고지수	double	7.2</param>
/// <param name="whchange">52주최고현재가대비	double	7.2</param>
/// <param name="whjday">52주최고지수일자	string	8</param>
/// <param name="wljisu">52주최저지수	double	7.2</param>
/// <param name="wlchange">52주최저현재가대비	double	7.2</param>
/// <param name="wljday">52주최저지수일자	string	8</param>
/// <param name="yhjisu">연중최고지수	double	7.2</param>
/// <param name="yhchange">연중최고현재가대비	double	7.2</param>
/// <param name="yhjday">연중최고지수일자	string	8</param>
/// <param name="yljisu">연중최저지수	double	7.2</param>
/// <param name="ylchange">연중최저현재가대비	double	7.2</param>
/// <param name="yljday">연중최저지수일자	string	8</param>
/// <param name="firstjcode">첫번째지수코드	string	3</param>
/// <param name="firstjname">첫번째지수명	string	20</param>
/// <param name="firstjisu">첫번째지수	double	7.2</param>
/// <param name="firsign">첫번째대비구분	string	1</param>
/// <param name="firchange">첫번째전일대비	double	7.2</param>
/// <param name="firdiff">첫번째등락율	double	6.2</param>
/// <param name="secondjcode">두번째지수코드	string	3</param>
/// <param name="secondjname">두번째지수명	string	20</param>
/// <param name="secondjisu">두번째지수	double	7.2</param>
/// <param name="secsign">두번째대비구분	string	1</param>
/// <param name="secchange">두번째전일대비	double	7.2</param>
/// <param name="secdiff">두번째등락율	double	6.2</param>
/// <param name="thirdjcode">세번째지수코드	string	3</param>
/// <param name="thirdjname">세번째지수명	string	20</param>
/// <param name="thirdjisu">세번째지수	double	7.2</param>
/// <param name="thrsign">세번째대비구분	string	1</param>
/// <param name="thrchange">세번째전일대비	double	7.2</param>
/// <param name="thrdiff">세번째등락율	double	6.2</param>
/// <param name="fourthjcode">네번째지수코드	string	3</param>
/// <param name="fourthjname">네번째지수명	string	20</param>
/// <param name="fourthjisu">네번째지수	double	7.2</param>
/// <param name="forsign">네번째대비구분	string	1</param>
/// <param name="forchange">네번째전일대비	double	7.2</param>
/// <param name="fordiff">네번째등락율	double	6.2</param>
/// <param name="highjo">상승종목수	int	4</param>
/// <param name="upjo">상한종목수	int	4</param>
/// <param name="unchgjo">보합종목수	int	4</param>
/// <param name="lowjo">하락종목수	int	4</param>
/// <param name="downjo">하한종목수	int	4</param>
public record t1511OutBlock([Description("업종구분	string	1")] string gubun, [Description("업종명	string	20")] string hname, [Description("현재지수	double	7.2")] double pricejisu, [Description("전일지수	double	7.2")] double jniljisu, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	7.2")] double change, [Description("지수등락율	double	6.2")] double diffjisu, [Description("전일거래량	long	12")] long jnilvolume, [Description("당일거래량	long	12")] long volume, [Description("거래량전일대비	long	12")] long volumechange, [Description("거래량비율	double	6.2")] double volumerate, [Description("전일거래대금	long	12")] long jnilvalue, [Description("당일거래대금	long	12")] long value, [Description("거래대금전일대비	long	12")] long valuechange, [Description("거래대금비율	double	6.2")] double valuerate, [Description("시가지수	double	7.2")] double openjisu, [Description("시가등락율	double	6.2")] double opendiff, [Description("시가시간	string	6")] string opentime, [Description("고가지수	double	7.2")] double highjisu, [Description("고가등락율	double	6.2")] double highdiff, [Description("고가시간	string	6")] string hightime, [Description("저가지수	double	7.2")] double lowjisu, [Description("저가등락율	double	6.2")] double lowdiff, [Description("저가시간	string	6")] string lowtime, [Description("52주최고지수	double	7.2")] double whjisu, [Description("52주최고현재가대비	double	7.2")] double whchange, [Description("52주최고지수일자	string	8")] string whjday, [Description("52주최저지수	double	7.2")] double wljisu, [Description("52주최저현재가대비	double	7.2")] double wlchange, [Description("52주최저지수일자	string	8")] string wljday, [Description("연중최고지수	double	7.2")] double yhjisu, [Description("연중최고현재가대비	double	7.2")] double yhchange, [Description("연중최고지수일자	string	8")] string yhjday, [Description("연중최저지수	double	7.2")] double yljisu, [Description("연중최저현재가대비	double	7.2")] double ylchange, [Description("연중최저지수일자	string	8")] string yljday, [Description("첫번째지수코드	string	3")] string firstjcode, [Description("첫번째지수명	string	20")] string firstjname, [Description("첫번째지수	double	7.2")] double firstjisu, [Description("첫번째대비구분	string	1")] string firsign, [Description("첫번째전일대비	double	7.2")] double firchange, [Description("첫번째등락율	double	6.2")] double firdiff, [Description("두번째지수코드	string	3")] string secondjcode, [Description("두번째지수명	string	20")] string secondjname, [Description("두번째지수	double	7.2")] double secondjisu, [Description("두번째대비구분	string	1")] string secsign, [Description("두번째전일대비	double	7.2")] double secchange, [Description("두번째등락율	double	6.2")] double secdiff, [Description("세번째지수코드	string	3")] string thirdjcode, [Description("세번째지수명	string	20")] string thirdjname, [Description("세번째지수	double	7.2")] double thirdjisu, [Description("세번째대비구분	string	1")] string thrsign, [Description("세번째전일대비	double	7.2")] double thrchange, [Description("세번째등락율	double	6.2")] double thrdiff, [Description("네번째지수코드	string	3")] string fourthjcode, [Description("네번째지수명	string	20")] string fourthjname, [Description("네번째지수	double	7.2")] double fourthjisu, [Description("네번째대비구분	string	1")] string forsign, [Description("네번째전일대비	double	7.2")] double forchange, [Description("네번째등락율	double	6.2")] double fordiff, [Description("상승종목수	int	4")] int highjo, [Description("상한종목수	int	4")] int upjo, [Description("보합종목수	int	4")] int unchgjo, [Description("하락종목수	int	4")] int lowjo, [Description("하한종목수	int	4")] int downjo);


/// <summary>
/// 업종기간별추이(t1514): t1514: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">구분1	string	1</param>
/// <param name="gubun2">구분2	string	1</param>
/// <param name="cts_date">CTS_일자	string	8</param>
/// <param name="cnt">조회건수	int	4</param>
/// <param name="rate_gbn">비중구분	string	1</param>
public record t1514InBlock([Description("업종코드	string	3")] string upcode, [Description("구분1	string	1")] string gubun1, [Description("구분2	string	1")] string gubun2, [Description("CTS_일자	string	8")] string cts_date, [Description("조회건수	int	4")] int cnt, [Description("비중구분	string	1")] string rate_gbn);

/// <summary>
/// 업종기간별추이(t1514): t1514: OutBlock
/// </summary>
/// <param name="cts_date">CTS_일자	string	8</param>
public record t1514OutBlock([Description("CTS_일자	string	8")] string cts_date);

/// <summary>
/// 업종기간별추이(t1514): t1514: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="jisu">지수	double	12.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	7.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	12.2</param>
/// <param name="value1">거래대금1	long	12</param>
/// <param name="high">상승	int	4</param>
/// <param name="unchg">보합	int	4</param>
/// <param name="low">하락	int	4</param>
/// <param name="uprate">상승종목비율	double	6.2</param>
/// <param name="frgsvolume">외인순매수	int	8</param>
/// <param name="openjisu">시가	double	12.2</param>
/// <param name="highjisu">고가	double	12.2</param>
/// <param name="lowjisu">저가	double	12.2</param>
/// <param name="value2">거래대금2	long	12</param>
/// <param name="up">상한	int	4</param>
/// <param name="down">하한	int	4</param>
/// <param name="totjo">종목수	int	4</param>
/// <param name="orgsvolume">기관순매수	int	8</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="rate">거래비중	double	7.2</param>
/// <param name="divrate">업종배당수익률	double	7.2</param>
public record t1514OutBlock1([Description("일자	string	8")] string date, [Description("지수	double	12.2")] double jisu, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	7.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래증가율	double	12.2")] double diff_vol, [Description("거래대금1	long	12")] long value1, [Description("상승	int	4")] int high, [Description("보합	int	4")] int unchg, [Description("하락	int	4")] int low, [Description("상승종목비율	double	6.2")] double uprate, [Description("외인순매수	int	8")] int frgsvolume, [Description("시가	double	12.2")] double openjisu, [Description("고가	double	12.2")] double highjisu, [Description("저가	double	12.2")] double lowjisu, [Description("거래대금2	long	12")] long value2, [Description("상한	int	4")] int up, [Description("하한	int	4")] int down, [Description("종목수	int	4")] int totjo, [Description("기관순매수	int	8")] int orgsvolume, [Description("업종코드	string	3")] string upcode, [Description("거래비중	double	7.2")] double rate, [Description("업종배당수익률	double	7.2")] double divrate);


/// <summary>
/// 업종별종목시세(t1516): t1516: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1516InBlock([Description("업종코드	string	3")] string upcode, [Description("구분	string	1")] string gubun, [Description("종목코드	string	6")] string shcode);

/// <summary>
/// 업종별종목시세(t1516): t1516: OutBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="pricejisu">지수	double	12.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	7.2</param>
/// <param name="jdiff">등락율	double	6.2</param>
public record t1516OutBlock([Description("종목코드	string	6")] string shcode, [Description("지수	double	12.2")] double pricejisu, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	7.2")] double change, [Description("등락율	double	6.2")] double jdiff);

/// <summary>
/// 업종별종목시세(t1516): t1516: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="sojinrate">소진율	double	6.2</param>
/// <param name="beta">베타계수	double	6.5</param>
/// <param name="perx">PER	double	8.2</param>
/// <param name="frgsvolume">외인순매수	long	12</param>
/// <param name="orgsvolume">기관순매수	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="total">시가총액	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t1516OutBlock1([Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("소진율	double	6.2")] double sojinrate, [Description("베타계수	double	6.5")] double beta, [Description("PER	double	8.2")] double perx, [Description("외인순매수	long	12")] long frgsvolume, [Description("기관순매수	long	12")] long orgsvolume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("종목코드	string	6")] string shcode, [Description("시가총액	long	12")] long total, [Description("거래대금	long	12")] long value);


/// <summary>
/// 테마별종목(t1531): t1531: InBlock
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1531InBlock([Description("테마명	string	36")] string tmname, [Description("테마코드	string	4")] string tmcode);

/// <summary>
/// 테마별종목(t1531): t1531: OutBlock
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="avgdiff">평균등락율	double	6.2</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1531OutBlock([Description("테마명	string	36")] string tmname, [Description("평균등락율	double	6.2")] double avgdiff, [Description("테마코드	string	4")] string tmcode);


/// <summary>
/// 종목별테마(t1532): t1532: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1532InBlock([Description("종목코드	string	6")] string shcode);

/// <summary>
/// 종목별테마(t1532): t1532: OutBlock
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="avgdiff">평균등락율	double	6.2</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1532OutBlock([Description("테마명	string	36")] string tmname, [Description("평균등락율	double	6.2")] double avgdiff, [Description("테마코드	string	4")] string tmcode);


/// <summary>
/// 특이테마(t1533): t1533: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="chgdate">대비일자	int	2</param>
public record t1533InBlock([Description("구분	string	1")] string gubun, [Description("대비일자	int	2")] int chgdate);

/// <summary>
/// 특이테마(t1533): t1533: OutBlock
/// </summary>
/// <param name="bdate">일자	string	8</param>
public record t1533OutBlock([Description("일자	string	8")] string bdate);

/// <summary>
/// 특이테마(t1533): t1533: OutBlock1
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="totcnt">전체	int	4</param>
/// <param name="upcnt">상승	int	4</param>
/// <param name="dncnt">하락	int	4</param>
/// <param name="uprate">상승비율	double	6.2</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="avgdiff">평균등락율	double	6.2</param>
/// <param name="chgdiff">대비등락율	double	6.2</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1533OutBlock1([Description("테마명	string	36")] string tmname, [Description("전체	int	4")] int totcnt, [Description("상승	int	4")] int upcnt, [Description("하락	int	4")] int dncnt, [Description("상승비율	double	6.2")] double uprate, [Description("거래증가율	double	10.2")] double diff_vol, [Description("평균등락율	double	6.2")] double avgdiff, [Description("대비등락율	double	6.2")] double chgdiff, [Description("테마코드	string	4")] string tmcode);


/// <summary>
/// 테마종목별시세조회(t1537): t1537: InBlock
/// </summary>
/// <param name="tmcode">테마코드	string	4</param>
public record t1537InBlock([Description("테마코드	string	4")] string tmcode);

/// <summary>
/// 테마종목별시세조회(t1537): t1537: OutBlock
/// </summary>
/// <param name="upcnt">상승종목수	int	4</param>
/// <param name="tmcnt">테마종목수	int	4</param>
/// <param name="uprate">상승종목비율	int	4</param>
/// <param name="tmname">테마명	string	36</param>
public record t1537OutBlock([Description("상승종목수	int	4")] int upcnt, [Description("테마종목수	int	4")] int tmcnt, [Description("상승종목비율	int	4")] int uprate, [Description("테마명	string	36")] string tmname);

/// <summary>
/// 테마종목별시세조회(t1537): t1537: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="jniltime">전일동시간	double	9.2</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="yeprice">예상체결가	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="value">누적거래대금(단위:백만)	long	12</param>
/// <param name="marketcap">시가총액(단위:백만)	long	12</param>
public record t1537OutBlock1([Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("전일동시간	double	9.2")] double jniltime, [Description("종목코드	string	6")] string shcode, [Description("예상체결가	int	8")] int yeprice, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("누적거래대금(단위:백만)	long	12")] long value, [Description("시가총액(단위:백만)	long	12")] long marketcap);


/// <summary>
/// 투자자별종합(t1601): t1601: InBlock
/// </summary>
/// <param name="gubun1">주식금액수량구분1	string	1</param>
/// <param name="gubun2">옵션금액수량구분2	string	1</param>
/// <param name="gubun3">금액단위	string	1</param>
/// <param name="gubun4">선물금액수량구분4	string	1</param>
public record t1601InBlock([Description("주식금액수량구분1	string	1")] string gubun1, [Description("옵션금액수량구분2	string	1")] string gubun2, [Description("금액단위	string	1")] string gubun3, [Description("선물금액수량구분4	string	1")] string gubun4);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock1
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock1([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock2
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock2([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock3
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock3([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock4
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock4([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock5
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock5([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 투자자별종합(t1601): t1601: OutBlock6
/// </summary>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_11">국가투자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_00">사모펀드투자자코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1601OutBlock6([Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("국가투자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("사모펀드투자자코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);


/// <summary>
/// 시간대별투자자매매추이(t1602): t1602: InBlock
/// </summary>
/// <param name="market">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">수량구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	4</param>
/// <param name="gubun3">직전대비구분(C:직전대비)	string	1</param>
public record t1602InBlock([Description("시장구분	string	1")] string market, [Description("업종코드	string	3")] string upcode, [Description("수량구분	string	1")] string gubun1, [Description("전일분구분	string	1")] string gubun2, [Description("CTSTIME	string	8")] string cts_time, [Description("CTSIDX	int	4")] int cts_idx, [Description("조회건수	int	4")] int cnt, [Description("직전대비구분(C:직전대비)	string	1")] string gubun3);

/// <summary>
/// 시간대별투자자매매추이(t1602): t1602: OutBlock
/// </summary>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_11">국가투자자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_00">사모펀드코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t1602OutBlock([Description("CTSTIME	string	8")] string cts_time, [Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("국가투자자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("사모펀드코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 시간대별투자자매매추이(t1602): t1602: OutBlock1
/// </summary>
/// <param name="time">시간	string	8</param>
/// <param name="sv_08">개인순매수	long	12</param>
/// <param name="sv_17">외국인순매수	long	12</param>
/// <param name="sv_18">기관계순매수	long	12</param>
/// <param name="sv_01">증권순매수	long	12</param>
/// <param name="sv_03">투신순매수	long	12</param>
/// <param name="sv_04">은행순매수	long	12</param>
/// <param name="sv_02">보험순매수	long	12</param>
/// <param name="sv_05">종금순매수	long	12</param>
/// <param name="sv_06">기금순매수	long	12</param>
/// <param name="sv_07">기타순매수	long	12</param>
/// <param name="sv_11">국가순매수	long	12</param>
/// <param name="sv_00">사모펀드순매수	long	12</param>
public record t1602OutBlock1([Description("시간	string	8")] string time, [Description("개인순매수	long	12")] long sv_08, [Description("외국인순매수	long	12")] long sv_17, [Description("기관계순매수	long	12")] long sv_18, [Description("증권순매수	long	12")] long sv_01, [Description("투신순매수	long	12")] long sv_03, [Description("은행순매수	long	12")] long sv_04, [Description("보험순매수	long	12")] long sv_02, [Description("종금순매수	long	12")] long sv_05, [Description("기금순매수	long	12")] long sv_06, [Description("기타순매수	long	12")] long sv_07, [Description("국가순매수	long	12")] long sv_11, [Description("사모펀드순매수	long	12")] long sv_00);


/// <summary>
/// 시간대별투자자매매추이상세(t1603): t1603: InBlock
/// </summary>
/// <param name="market">시장구분	string	1</param>
/// <param name="gubun1">투자자구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="upcode">업종코드	string	3</param>
public record t1603InBlock([Description("시장구분	string	1")] string market, [Description("투자자구분	string	1")] string gubun1, [Description("전일분구분	string	1")] string gubun2, [Description("CTSTIME	string	8")] string cts_time, [Description("CTSIDX	int	4")] int cts_idx, [Description("조회건수	int	3")] int cnt, [Description("업종코드	string	3")] string upcode);

/// <summary>
/// 시간대별투자자매매추이상세(t1603): t1603: OutBlock
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cts_time">CTSTIME	string	8</param>
public record t1603OutBlock([Description("CTSIDX	int	4")] int cts_idx, [Description("CTSTIME	string	8")] string cts_time);

/// <summary>
/// 시간대별투자자매매추이상세(t1603): t1603: OutBlock1
/// </summary>
/// <param name="time">시간	string	8</param>
/// <param name="tjjcode">투자자구분	string	4</param>
/// <param name="msvolume">매수수량	int	8</param>
/// <param name="mdvolume">매도수량	int	8</param>
/// <param name="msvalue">매수금액	long	12</param>
/// <param name="mdvalue">매도금액	long	12</param>
/// <param name="svolume">순매수수량	int	8</param>
/// <param name="svalue">순매수금액	long	12</param>
public record t1603OutBlock1([Description("시간	string	8")] string time, [Description("투자자구분	string	4")] string tjjcode, [Description("매수수량	int	8")] int msvolume, [Description("매도수량	int	8")] int mdvolume, [Description("매수금액	long	12")] long msvalue, [Description("매도금액	long	12")] long mdvalue, [Description("순매수수량	int	8")] int svolume, [Description("순매수금액	long	12")] long svalue);


/// <summary>
/// 투자자매매종합1(t1615): t1615: InBlock
/// </summary>
/// <param name="gubun1">주식구분	string	1</param>
/// <param name="gubun2">옵션구분	string	1</param>
public record t1615InBlock([Description("주식구분	string	1")] string gubun1, [Description("옵션구분	string	1")] string gubun2);

/// <summary>
/// 투자자매매종합1(t1615): t1615: OutBlock
/// </summary>
/// <param name="dwvolume">위탁매도수량	long	12</param>
/// <param name="dwvalue">위탁매도금액	long	12</param>
/// <param name="djvolume">자기매도수량	long	12</param>
/// <param name="djvalue">자기매도금액	long	12</param>
/// <param name="sum_volume">합계수량	long	12</param>
/// <param name="sum_value">합계금액	long	12</param>
public record t1615OutBlock([Description("위탁매도수량	long	12")] long dwvolume, [Description("위탁매도금액	long	12")] long dwvalue, [Description("자기매도수량	long	12")] long djvolume, [Description("자기매도금액	long	12")] long djvalue, [Description("합계수량	long	12")] long sum_volume, [Description("합계금액	long	12")] long sum_value);

/// <summary>
/// 투자자매매종합1(t1615): t1615: OutBlock1
/// </summary>
/// <param name="hname">시장명	string	20</param>
/// <param name="sv_08">개인	long	12</param>
/// <param name="sv_17">외국인	long	12</param>
/// <param name="sv_18">기관계	long	12</param>
/// <param name="sv_07">증권	long	12</param>
public record t1615OutBlock1([Description("시장명	string	20")] string hname, [Description("개인	long	12")] long sv_08, [Description("외국인	long	12")] long sv_17, [Description("기관계	long	12")] long sv_18, [Description("증권	long	12")] long sv_07);


/// <summary>
/// 투자자매매종합2(t1617): t1617: InBlock
/// </summary>
/// <param name="gubun1">시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)	string	1</param>
/// <param name="gubun2">수량금액구분(1:수량2:금액)	string	1</param>
/// <param name="gubun3">일자구분(1:시간대별2:일별)	string	1</param>
/// <param name="cts_date">CTSDATE(연속키값-일자)	string	8</param>
/// <param name="cts_time">CTSTIME(연속키값-시간)	string	8</param>
public record t1617InBlock([Description("시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)	string	1")] string gubun1, [Description("수량금액구분(1:수량2:금액)	string	1")] string gubun2, [Description("일자구분(1:시간대별2:일별)	string	1")] string gubun3, [Description("CTSDATE(연속키값-일자)	string	8")] string cts_date, [Description("CTSTIME(연속키값-시간)	string	8")] string cts_time);

/// <summary>
/// 투자자매매종합2(t1617): t1617: OutBlock
/// </summary>
/// <param name="cts_date">CTSDATE	string	8</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="sv_08">개인순매수	long	12</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="sv_17">외국인순매수	long	12</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="sv_18">기관계순매수	long	12</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="sv_01">증권순매수	long	12</param>
public record t1617OutBlock([Description("CTSDATE	string	8")] string cts_date, [Description("CTSTIME	string	8")] string cts_time, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인순매수	long	12")] long sv_08, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인순매수	long	12")] long sv_17, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계순매수	long	12")] long sv_18, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권순매수	long	12")] long sv_01);

/// <summary>
/// 투자자매매종합2(t1617): t1617: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	8</param>
/// <param name="sv_08">개인	long	12</param>
/// <param name="sv_17">외국인	long	12</param>
/// <param name="sv_18">기관계	long	12</param>
/// <param name="sv_01">증권	long	12</param>
public record t1617OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	8")] string time, [Description("개인	long	12")] long sv_08, [Description("외국인	long	12")] long sv_17, [Description("기관계	long	12")] long sv_18, [Description("증권	long	12")] long sv_01);


/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621: InBlock
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="bgubun">전일분	string	1</param>
public record t1621InBlock([Description("업종코드	string	3")] string upcode, [Description("N분	int	2")] int nmin, [Description("조회건수	int	3")] int cnt, [Description("전일분	string	1")] string bgubun);

/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621: OutBlock
/// </summary>
/// <param name="indcode">개인투자자코드	string	4</param>
/// <param name="forcode">외국인투자자코드	string	4</param>
/// <param name="syscode">기관계투자자코드	string	4</param>
/// <param name="stocode">증권투자자코드	string	4</param>
/// <param name="invcode">투신투자자코드	string	4</param>
/// <param name="bancode">은행투자자코드	string	4</param>
/// <param name="inscode">보험투자자코드	string	4</param>
/// <param name="fincode">종금투자자코드	string	4</param>
/// <param name="moncode">기금투자자코드	string	4</param>
/// <param name="etccode">기타투자자코드	string	4</param>
/// <param name="natcode">국가투자자코드	string	4</param>
/// <param name="pefcode">사모펀드투자자코드	string	4</param>
/// <param name="jisucd">기준지수코드	string	8</param>
/// <param name="jisunm">기준지수명	string	20</param>
public record t1621OutBlock([Description("개인투자자코드	string	4")] string indcode, [Description("외국인투자자코드	string	4")] string forcode, [Description("기관계투자자코드	string	4")] string syscode, [Description("증권투자자코드	string	4")] string stocode, [Description("투신투자자코드	string	4")] string invcode, [Description("은행투자자코드	string	4")] string bancode, [Description("보험투자자코드	string	4")] string inscode, [Description("종금투자자코드	string	4")] string fincode, [Description("기금투자자코드	string	4")] string moncode, [Description("기타투자자코드	string	4")] string etccode, [Description("국가투자자코드	string	4")] string natcode, [Description("사모펀드투자자코드	string	4")] string pefcode, [Description("기준지수코드	string	8")] string jisucd, [Description("기준지수명	string	20")] string jisunm);

/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="datetime">일자시간	string	14</param>
/// <param name="indmsvol">개인순매수거래량	int	8</param>
/// <param name="indmsamt">개인순매수거래대금	double	12</param>
/// <param name="formsvol">외국인순매수거래량	int	8</param>
/// <param name="formsamt">외국인순매수거래대금	double	12</param>
/// <param name="sysmsvol">기관계순매수거래량	int	8</param>
/// <param name="sysmsamt">기관계순매수거래대금	double	12</param>
/// <param name="stomsvol">증권순매수거래량	int	8</param>
/// <param name="stomsamt">증권순매수거래대금	double	12</param>
/// <param name="invmsvol">투신순매수거래량	int	8</param>
/// <param name="invmsamt">투신순매수거래대금	double	12</param>
/// <param name="banmsvol">은행순매수거래량	int	8</param>
/// <param name="banmsamt">은행순매수거래대금	double	12</param>
/// <param name="insmsvol">보험순매수거래량	int	8</param>
/// <param name="insmsamt">보험순매수거래대금	double	12</param>
/// <param name="finmsvol">종금순매수거래량	int	8</param>
/// <param name="finmsamt">종금순매수거래대금	double	12</param>
/// <param name="monmsvol">기금순매수거래량	int	8</param>
/// <param name="monmsamt">기금순매수거래대금	double	12</param>
/// <param name="etcmsvol">기타순매수거래량	int	8</param>
/// <param name="etcmsamt">기타순매수거래대금	double	12</param>
/// <param name="natmsvol">국가순매수거래량	int	8</param>
/// <param name="natmsamt">국가순매수거래대금	double	12</param>
/// <param name="pefmsvol">사모펀드순매수거래량	int	8</param>
/// <param name="pefmsamt">사모펀드순매수거래대금	double	12</param>
/// <param name="upclose">기준지수	double	6.2</param>
/// <param name="upcvolume">기준체결거래량	int	8</param>
/// <param name="upvolume">기준누적거래량	double	12</param>
/// <param name="upvalue">기준거래대금	double	12</param>
public record t1621OutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("일자시간	string	14")] string datetime, [Description("개인순매수거래량	int	8")] int indmsvol, [Description("개인순매수거래대금	double	12")] double indmsamt, [Description("외국인순매수거래량	int	8")] int formsvol, [Description("외국인순매수거래대금	double	12")] double formsamt, [Description("기관계순매수거래량	int	8")] int sysmsvol, [Description("기관계순매수거래대금	double	12")] double sysmsamt, [Description("증권순매수거래량	int	8")] int stomsvol, [Description("증권순매수거래대금	double	12")] double stomsamt, [Description("투신순매수거래량	int	8")] int invmsvol, [Description("투신순매수거래대금	double	12")] double invmsamt, [Description("은행순매수거래량	int	8")] int banmsvol, [Description("은행순매수거래대금	double	12")] double banmsamt, [Description("보험순매수거래량	int	8")] int insmsvol, [Description("보험순매수거래대금	double	12")] double insmsamt, [Description("종금순매수거래량	int	8")] int finmsvol, [Description("종금순매수거래대금	double	12")] double finmsamt, [Description("기금순매수거래량	int	8")] int monmsvol, [Description("기금순매수거래대금	double	12")] double monmsamt, [Description("기타순매수거래량	int	8")] int etcmsvol, [Description("기타순매수거래대금	double	12")] double etcmsamt, [Description("국가순매수거래량	int	8")] int natmsvol, [Description("국가순매수거래대금	double	12")] double natmsamt, [Description("사모펀드순매수거래량	int	8")] int pefmsvol, [Description("사모펀드순매수거래대금	double	12")] double pefmsamt, [Description("기준지수	double	6.2")] double upclose, [Description("기준체결거래량	int	8")] int upcvolume, [Description("기준누적거래량	double	12")] double upvolume, [Description("기준거래대금	double	12")] double upvalue);


/// <summary>
/// 프로그램매매종합조회(t1631): t1631: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="dgubun">일자구분	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1631InBlock([Description("구분	string	1")] string gubun, [Description("일자구분	string	1")] string dgubun, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate);

/// <summary>
/// 프로그램매매종합조회(t1631): t1631: OutBlock
/// </summary>
/// <param name="cdhrem">매도차익미체결잔량	int	8</param>
/// <param name="bdhrem">매도비차익미체결잔량	int	8</param>
/// <param name="tcdrem">매도차익주문수량	int	8</param>
/// <param name="tbdrem">매도비차익주문수량	int	8</param>
/// <param name="cshrem">매수차익미체결잔량	int	8</param>
/// <param name="bshrem">매수비차익미체결잔량	int	8</param>
/// <param name="tcsrem">매수차익주문수량	int	8</param>
/// <param name="tbsrem">매수비차익주문수량	int	8</param>
public record t1631OutBlock([Description("매도차익미체결잔량	int	8")] int cdhrem, [Description("매도비차익미체결잔량	int	8")] int bdhrem, [Description("매도차익주문수량	int	8")] int tcdrem, [Description("매도비차익주문수량	int	8")] int tbdrem, [Description("매수차익미체결잔량	int	8")] int cshrem, [Description("매수비차익미체결잔량	int	8")] int bshrem, [Description("매수차익주문수량	int	8")] int tcsrem, [Description("매수비차익주문수량	int	8")] int tbsrem);

/// <summary>
/// 프로그램매매종합조회(t1631): t1631: OutBlock1
/// </summary>
/// <param name="offervolume">매도수량	int	8</param>
/// <param name="offervalue">매도금액	long	12</param>
/// <param name="bidvolume">매수수량	int	8</param>
/// <param name="bidvalue">매수금액	long	12</param>
/// <param name="volume">순매수수량	int	8</param>
/// <param name="value">순매수금액	long	12</param>
public record t1631OutBlock1([Description("매도수량	int	8")] int offervolume, [Description("매도금액	long	12")] long offervalue, [Description("매수수량	int	8")] int bidvolume, [Description("매수금액	long	12")] long bidvalue, [Description("순매수수량	int	8")] int volume, [Description("순매수금액	long	12")] long value);


/// <summary>
/// 시간대별프로그램매매추이(t1632): t1632: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">직전대비증감	string	1</param>
/// <param name="gubun3">전일구분	string	1</param>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
public record t1632InBlock([Description("구분	string	1")] string gubun, [Description("금액수량구분	string	1")] string gubun1, [Description("직전대비증감	string	1")] string gubun2, [Description("전일구분	string	1")] string gubun3, [Description("일자	string	8")] string date, [Description("시간	string	6")] string time);

/// <summary>
/// 시간대별프로그램매매추이(t1632): t1632: OutBlock
/// </summary>
/// <param name="date">날짜CTS	string	8</param>
/// <param name="time">시간CTS	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1632OutBlock([Description("날짜CTS	string	8")] string date, [Description("시간CTS	string	6")] string time, [Description("IDX	int	4")] int idx);

/// <summary>
/// 시간대별프로그램매매추이(t1632): t1632: OutBlock1
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="k200jisu">KP200	double	6.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="k200basis">BASIS	double	6.2</param>
/// <param name="tot3">전체순매수	long	12</param>
/// <param name="tot1">전체매수	long	12</param>
/// <param name="tot2">전체매도	long	12</param>
/// <param name="cha3">차익순매수	long	12</param>
/// <param name="cha1">차익매수	long	12</param>
/// <param name="cha2">차익매도	long	12</param>
/// <param name="bcha3">비차익순매수	long	12</param>
/// <param name="bcha1">비차익매수	long	12</param>
/// <param name="bcha2">비차익매도	long	12</param>
public record t1632OutBlock1([Description("시간	string	6")] string time, [Description("KP200	double	6.2")] double k200jisu, [Description("대비구분	string	1")] string sign, [Description("대비	double	6.2")] double change, [Description("BASIS	double	6.2")] double k200basis, [Description("전체순매수	long	12")] long tot3, [Description("전체매수	long	12")] long tot1, [Description("전체매도	long	12")] long tot2, [Description("차익순매수	long	12")] long cha3, [Description("차익매수	long	12")] long cha1, [Description("차익매도	long	12")] long cha2, [Description("비차익순매수	long	12")] long bcha3, [Description("비차익매수	long	12")] long bcha1, [Description("비차익매도	long	12")] long bcha2);


/// <summary>
/// 기간별프로그램매매추이(t1633): t1633: InBlock
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">수치누적구분	string	1</param>
/// <param name="gubun3">일주월구분	string	1</param>
/// <param name="fdate">from일자	string	8</param>
/// <param name="tdate">to일자	string	8</param>
/// <param name="gubun4">직전대비증감구분	string	1</param>
/// <param name="date">날짜	string	8</param>
public record t1633InBlock([Description("시장구분	string	1")] string gubun, [Description("금액수량구분	string	1")] string gubun1, [Description("수치누적구분	string	1")] string gubun2, [Description("일주월구분	string	1")] string gubun3, [Description("from일자	string	8")] string fdate, [Description("to일자	string	8")] string tdate, [Description("직전대비증감구분	string	1")] string gubun4, [Description("날짜	string	8")] string date);

/// <summary>
/// 기간별프로그램매매추이(t1633): t1633: OutBlock
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1633OutBlock([Description("날짜	string	8")] string date, [Description("IDX	int	4")] int idx);

/// <summary>
/// 기간별프로그램매매추이(t1633): t1633: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="jisu">KP200	double	6.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="tot3">전체순매수	long	12</param>
/// <param name="tot1">전체매수	long	12</param>
/// <param name="tot2">전체매도	long	12</param>
/// <param name="cha3">차익순매수	long	12</param>
/// <param name="cha1">차익매수	long	12</param>
/// <param name="cha2">차익매도	long	12</param>
/// <param name="bcha3">비차익순매수	long	12</param>
/// <param name="bcha1">비차익매수	long	12</param>
/// <param name="bcha2">비차익매도	long	12</param>
/// <param name="volume">거래량	long	12</param>
public record t1633OutBlock1([Description("일자	string	8")] string date, [Description("KP200	double	6.2")] double jisu, [Description("대비구분	string	1")] string sign, [Description("대비	double	6.2")] double change, [Description("전체순매수	long	12")] long tot3, [Description("전체매수	long	12")] long tot1, [Description("전체매도	long	12")] long tot2, [Description("차익순매수	long	12")] long cha3, [Description("차익매수	long	12")] long cha1, [Description("차익매도	long	12")] long cha2, [Description("비차익순매수	long	12")] long bcha3, [Description("비차익매수	long	12")] long bcha1, [Description("비차익매도	long	12")] long bcha2, [Description("거래량	long	12")] long volume);


/// <summary>
/// 종목별프로그램매매동향(t1636): t1636: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">정렬기준	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1636InBlock([Description("구분	string	1")] string gubun, [Description("금액수량구분	string	1")] string gubun1, [Description("정렬기준	string	1")] string gubun2, [Description("종목코드	string	6")] string shcode, [Description("IDXCTS	int	4")] int cts_idx);

/// <summary>
/// 종목별프로그램매매동향(t1636): t1636: OutBlock
/// </summary>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1636OutBlock([Description("IDXCTS	int	4")] int cts_idx);

/// <summary>
/// 종목별프로그램매매동향(t1636): t1636: OutBlock1
/// </summary>
/// <param name="rank">순위	int	8</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="svalue">순매수금액	long	12</param>
/// <param name="offervalue">매도금액	long	12</param>
/// <param name="stksvalue">매수금액	long	12</param>
/// <param name="svolume">순매수수량	long	12</param>
/// <param name="offervolume">매도수량	long	12</param>
/// <param name="stksvolume">매수수량	long	12</param>
/// <param name="sgta">시가총액	long	15</param>
/// <param name="rate">비중	double	6.2</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1636OutBlock1([Description("순위	int	8")] int rank, [Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("대비구분	string	1")] string sign, [Description("대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("순매수금액	long	12")] long svalue, [Description("매도금액	long	12")] long offervalue, [Description("매수금액	long	12")] long stksvalue, [Description("순매수수량	long	12")] long svolume, [Description("매도수량	long	12")] long offervolume, [Description("매수수량	long	12")] long stksvolume, [Description("시가총액	long	15")] long sgta, [Description("비중	double	6.2")] double rate, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 종목별프로그램매매추이(t1637): t1637: InBlock
/// </summary>
/// <param name="gubun1">수량금액구분(0:수량1:금액)	string	1</param>
/// <param name="gubun2">시간일별구분(0:시간1:일자)	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="cts_idx">IDXCTS(9999:차트)	int	4</param>
public record t1637InBlock([Description("수량금액구분(0:수량1:금액)	string	1")] string gubun1, [Description("시간일별구분(0:시간1:일자)	string	1")] string gubun2, [Description("종목코드	string	6")] string shcode, [Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("IDXCTS(9999:차트)	int	4")] int cts_idx);

/// <summary>
/// 종목별프로그램매매추이(t1637): t1637: OutBlock
/// </summary>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1637OutBlock([Description("IDXCTS	int	4")] int cts_idx);

/// <summary>
/// 종목별프로그램매매추이(t1637): t1637: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="svalue">순매수금액	long	15</param>
/// <param name="offervalue">매도금액	long	15</param>
/// <param name="stksvalue">매수금액	long	15</param>
/// <param name="svolume">순매수수량	long	12</param>
/// <param name="offervolume">매도수량	long	12</param>
/// <param name="stksvolume">매수수량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1637OutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("현재가	int	8")] int price, [Description("대비구분	string	1")] string sign, [Description("대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("순매수금액	long	15")] long svalue, [Description("매도금액	long	15")] long offervalue, [Description("매수금액	long	15")] long stksvalue, [Description("순매수수량	long	12")] long svolume, [Description("매도수량	long	12")] long offervolume, [Description("매수수량	long	12")] long stksvolume, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 종목별잔량/사전공시(t1638): t1638: InBlock
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun2">정렬	string	1</param>
public record t1638InBlock([Description("구분	string	1")] string gubun1, [Description("종목코드	string	6")] string shcode, [Description("정렬	string	1")] string gubun2);

/// <summary>
/// 종목별잔량/사전공시(t1638): t1638: OutBlock
/// </summary>
/// <param name="rank">순위	int	4</param>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="sigatotrt">시총비중	double	6.2</param>
/// <param name="obuyvol">순매수잔량	long	12</param>
/// <param name="buyrem">매수잔량	long	12</param>
/// <param name="psgvolume">매수공시수량	long	12</param>
/// <param name="sellrem">매도잔량	long	12</param>
/// <param name="pdgvolume">매도공시수량	long	12</param>
/// <param name="sigatot">시가총액	long	20</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1638OutBlock([Description("순위	int	4")] int rank, [Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("시총비중	double	6.2")] double sigatotrt, [Description("순매수잔량	long	12")] long obuyvol, [Description("매수잔량	long	12")] long buyrem, [Description("매수공시수량	long	12")] long psgvolume, [Description("매도잔량	long	12")] long sellrem, [Description("매도공시수량	long	12")] long pdgvolume, [Description("시가총액	long	20")] long sigatot, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 프로그램매매종합조회(미니)(t1640): t1640: InBlock
/// </summary>
/// <param name="gubun">구분	string	2</param>
public record t1640InBlock([Description("구분	string	2")] string gubun);

/// <summary>
/// 프로그램매매종합조회(미니)(t1640): t1640: OutBlock
/// </summary>
/// <param name="offervolume">매도수량	int	8</param>
/// <param name="bidvolume">매수수량	int	8</param>
/// <param name="volume">순매수수량	int	8</param>
/// <param name="offerdiff">매도증감	int	8</param>
/// <param name="biddiff">매수증감	int	8</param>
/// <param name="sundiff">순매수증감	int	8</param>
/// <param name="basis">베이시스	double	6.2</param>
/// <param name="offervalue">매도금액	double	12</param>
/// <param name="bidvalue">매수금액	double	12</param>
/// <param name="value">순매수금액	double	12</param>
/// <param name="offervaldiff">매도금액증감	double	12</param>
/// <param name="bidvaldiff">매수금액증감	double	12</param>
/// <param name="sunvaldiff">순매수증감	double	12</param>
public record t1640OutBlock([Description("매도수량	int	8")] int offervolume, [Description("매수수량	int	8")] int bidvolume, [Description("순매수수량	int	8")] int volume, [Description("매도증감	int	8")] int offerdiff, [Description("매수증감	int	8")] int biddiff, [Description("순매수증감	int	8")] int sundiff, [Description("베이시스	double	6.2")] double basis, [Description("매도금액	double	12")] double offervalue, [Description("매수금액	double	12")] double bidvalue, [Description("순매수금액	double	12")] double value, [Description("매도금액증감	double	12")] double offervaldiff, [Description("매수금액증감	double	12")] double bidvaldiff, [Description("순매수증감	double	12")] double sunvaldiff);


/// <summary>
/// 시간대별프로그램매매추이(차트)(t1662): t1662: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun3">전일구분	string	1</param>
public record t1662InBlock([Description("구분	string	1")] string gubun, [Description("금액수량구분	string	1")] string gubun1, [Description("전일구분	string	1")] string gubun3);

/// <summary>
/// 시간대별프로그램매매추이(차트)(t1662): t1662: OutBlock
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="k200jisu">KP200	double	6.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="k200basis">BASIS	double	6.2</param>
/// <param name="tot3">전체순매수	long	12</param>
/// <param name="tot1">전체매수	long	12</param>
/// <param name="tot2">전체매도	long	12</param>
/// <param name="cha3">차익순매수	long	12</param>
/// <param name="cha1">차익매수	long	12</param>
/// <param name="cha2">차익매도	long	12</param>
/// <param name="bcha3">비차익순매수	long	12</param>
/// <param name="bcha1">비차익매수	long	12</param>
/// <param name="bcha2">비차익매도	long	12</param>
/// <param name="volume">거래량	long	12</param>
public record t1662OutBlock([Description("시간	string	6")] string time, [Description("KP200	double	6.2")] double k200jisu, [Description("대비구분	string	1")] string sign, [Description("대비	double	6.2")] double change, [Description("BASIS	double	6.2")] double k200basis, [Description("전체순매수	long	12")] long tot3, [Description("전체매수	long	12")] long tot1, [Description("전체매도	long	12")] long tot2, [Description("차익순매수	long	12")] long cha3, [Description("차익매수	long	12")] long cha1, [Description("차익매도	long	12")] long cha2, [Description("비차익순매수	long	12")] long bcha3, [Description("비차익매수	long	12")] long bcha1, [Description("비차익매도	long	12")] long bcha2, [Description("거래량	long	12")] long volume);


/// <summary>
/// 투자자매매종합(챠트): t1664: InBlock
/// </summary>
/// <param name="mgubun">시장구분	string	1</param>
/// <param name="vagubun">금액수량구분	string	1</param>
/// <param name="bdgubun">시간일별구분	string	1</param>
/// <param name="cnt">조회건수	int	3</param>
public record t1664InBlock([Description("시장구분	string	1")] string mgubun, [Description("금액수량구분	string	1")] string vagubun, [Description("시간일별구분	string	1")] string bdgubun, [Description("조회건수	int	3")] int cnt);

/// <summary>
/// 투자자매매종합(챠트): t1664: OutBlock1
/// </summary>
/// <param name="dt">일자시간	string	8</param>
/// <param name="tjj01">증권순매수	double	12</param>
/// <param name="tjj02">보험순매수	double	12</param>
/// <param name="tjj03">투신순매수	double	12</param>
/// <param name="tjj04">은행순매수	double	12</param>
/// <param name="tjj05">종금순매수	double	12</param>
/// <param name="tjj06">기금순매수	double	12</param>
/// <param name="tjj07">기타순매수	double	12</param>
/// <param name="tjj08">개인순매수	double	12</param>
/// <param name="tjj17">외국인순매수	double	12</param>
/// <param name="tjj18">기관순매수	double	12</param>
/// <param name="cha">차익순매수	double	12</param>
/// <param name="bicha">비차익순매수	double	12</param>
/// <param name="totcha">종합순매수	double	12</param>
/// <param name="basis">베이시스	double	6.2</param>
public record t1664OutBlock1([Description("일자시간	string	8")] string dt, [Description("증권순매수	double	12")] double tjj01, [Description("보험순매수	double	12")] double tjj02, [Description("투신순매수	double	12")] double tjj03, [Description("은행순매수	double	12")] double tjj04, [Description("종금순매수	double	12")] double tjj05, [Description("기금순매수	double	12")] double tjj06, [Description("기타순매수	double	12")] double tjj07, [Description("개인순매수	double	12")] double tjj08, [Description("외국인순매수	double	12")] double tjj17, [Description("기관순매수	double	12")] double tjj18, [Description("차익순매수	double	12")] double cha, [Description("비차익순매수	double	12")] double bicha, [Description("종합순매수	double	12")] double totcha, [Description("베이시스	double	6.2")] double basis);


/// <summary>
/// 기간별투자자매매추이(챠트): t1665: InBlock
/// </summary>
/// <param name="market">시장구분(1:kospi2:kp2003:kosdaq4:선물5:풋옵션6:콜옵션)	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun2">수치구분(1:수치2:누적)	string	1</param>
/// <param name="gubun3">단위구분(1:일2:주3:월)	string	1</param>
/// <param name="from_date">시작날짜	string	8</param>
/// <param name="to_date">종료날짜	string	8</param>
public record t1665InBlock([Description("시장구분(1:kospi2:kp2003:kosdaq4:선물5:풋옵션6:콜옵션)	string	1")] string market, [Description("업종코드	string	3")] string upcode, [Description("수치구분(1:수치2:누적)	string	1")] string gubun2, [Description("단위구분(1:일2:주3:월)	string	1")] string gubun3, [Description("시작날짜	string	8")] string from_date, [Description("종료날짜	string	8")] string to_date);

/// <summary>
/// 기간별투자자매매추이(챠트): t1665: OutBlock
/// </summary>
/// <param name="mcode">시장코드	string	8</param>
/// <param name="mname">시장명	string	20</param>
public record t1665OutBlock([Description("시장코드	string	8")] string mcode, [Description("시장명	string	20")] string mname);

/// <summary>
/// 기간별투자자매매추이(챠트): t1665: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="sv_08">개인수량	long	12</param>
/// <param name="sv_17">외인계수량(등록+미등록)	long	12</param>
/// <param name="sv_18">기관계수량	long	12</param>
/// <param name="sv_01">증권수량	long	12</param>
/// <param name="sv_03">투신수량	long	12</param>
/// <param name="sv_04">은행수량	long	12</param>
/// <param name="sv_02">보험수량	long	12</param>
/// <param name="sv_05">종금수량	long	12</param>
/// <param name="sv_06">기금수량	long	12</param>
/// <param name="sv_07">기타수량	long	12</param>
/// <param name="sv_00">사모펀드수량	long	12</param>
/// <param name="sv_09">등록외국인수량	long	12</param>
/// <param name="sv_10">미등록외국인수량	long	12</param>
/// <param name="sv_11">국가수량	long	12</param>
/// <param name="sv_99">기타계수량(기타+국가)	long	12</param>
/// <param name="sa_08">개인금액	double	12</param>
/// <param name="sa_17">외인계금액(등록+미등록)	double	12</param>
/// <param name="sa_18">기관계금액	double	12</param>
/// <param name="sa_01">증권금액	double	12</param>
/// <param name="sa_03">투신금액	double	12</param>
/// <param name="sa_04">은행금액	double	12</param>
/// <param name="sa_02">보험금액	double	12</param>
/// <param name="sa_05">종금금액	double	12</param>
/// <param name="sa_06">기금금액	double	12</param>
/// <param name="sa_07">기타금액	double	12</param>
/// <param name="sa_00">사모펀드금액	double	12</param>
/// <param name="sa_09">등록외국인금액	double	12</param>
/// <param name="sa_10">미등록외국인금액	double	12</param>
/// <param name="sa_11">국가금액	double	12</param>
/// <param name="sa_99">기타계금액(기타+국가)	double	12</param>
/// <param name="jisu">시장지수	double	7.2</param>
public record t1665OutBlock1([Description("일자	string	8")] string date, [Description("개인수량	long	12")] long sv_08, [Description("외인계수량(등록+미등록)	long	12")] long sv_17, [Description("기관계수량	long	12")] long sv_18, [Description("증권수량	long	12")] long sv_01, [Description("투신수량	long	12")] long sv_03, [Description("은행수량	long	12")] long sv_04, [Description("보험수량	long	12")] long sv_02, [Description("종금수량	long	12")] long sv_05, [Description("기금수량	long	12")] long sv_06, [Description("기타수량	long	12")] long sv_07, [Description("사모펀드수량	long	12")] long sv_00, [Description("등록외국인수량	long	12")] long sv_09, [Description("미등록외국인수량	long	12")] long sv_10, [Description("국가수량	long	12")] long sv_11, [Description("기타계수량(기타+국가)	long	12")] long sv_99, [Description("개인금액	double	12")] double sa_08, [Description("외인계금액(등록+미등록)	double	12")] double sa_17, [Description("기관계금액	double	12")] double sa_18, [Description("증권금액	double	12")] double sa_01, [Description("투신금액	double	12")] double sa_03, [Description("은행금액	double	12")] double sa_04, [Description("보험금액	double	12")] double sa_02, [Description("종금금액	double	12")] double sa_05, [Description("기금금액	double	12")] double sa_06, [Description("기타금액	double	12")] double sa_07, [Description("사모펀드금액	double	12")] double sa_00, [Description("등록외국인금액	double	12")] double sa_09, [Description("미등록외국인금액	double	12")] double sa_10, [Description("국가금액	double	12")] double sa_11, [Description("기타계금액(기타+국가)	double	12")] double sa_99, [Description("시장지수	double	7.2")] double jisu);


/// <summary>
/// 외인기관종목별동향(t1702): t1702: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="todt">종료일자	string	8</param>
/// <param name="volvalgb">금액수량구분(0:금액1:수량2:단가)	string	1</param>
/// <param name="msmdgb">매수매도구분(0:순매수1:매수2:매도)	string	1</param>
/// <param name="cumulgb">누적구분(0:일간1:누적)	string	1</param>
/// <param name="cts_date">CTSDATE	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1702InBlock([Description("종목코드	string	6")] string shcode, [Description("종료일자	string	8")] string todt, [Description("금액수량구분(0:금액1:수량2:단가)	string	1")] string volvalgb, [Description("매수매도구분(0:순매수1:매수2:매도)	string	1")] string msmdgb, [Description("누적구분(0:일간1:누적)	string	1")] string cumulgb, [Description("CTSDATE	string	8")] string cts_date, [Description("CTSIDX	int	4")] int cts_idx);

/// <summary>
/// 외인기관종목별동향(t1702): t1702: OutBlock
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cts_date">CTSDATE	string	8</param>
public record t1702OutBlock([Description("CTSIDX	int	4")] int cts_idx, [Description("CTSDATE	string	8")] string cts_date);

/// <summary>
/// 외인기관종목별동향(t1702): t1702: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="amt0000">사모펀드	long	12</param>
/// <param name="amt0001">증권	long	12</param>
/// <param name="amt0002">보험	long	12</param>
/// <param name="amt0003">투신	long	12</param>
/// <param name="amt0004">은행	long	12</param>
/// <param name="amt0005">종금	long	12</param>
/// <param name="amt0006">기금	long	12</param>
/// <param name="amt0007">기타법인	long	12</param>
/// <param name="amt0008">개인	long	12</param>
/// <param name="amt0009">등록외국인	long	12</param>
/// <param name="amt0010">미등록외국인	long	12</param>
/// <param name="amt0011">국가외	long	12</param>
/// <param name="amt0018">기관	long	12</param>
/// <param name="amt0088">외인계(등록+미등록)	long	12</param>
/// <param name="amt0099">기타계(기타+국가)	long	12</param>
public record t1702OutBlock1([Description("일자	string	8")] string date, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("사모펀드	long	12")] long amt0000, [Description("증권	long	12")] long amt0001, [Description("보험	long	12")] long amt0002, [Description("투신	long	12")] long amt0003, [Description("은행	long	12")] long amt0004, [Description("종금	long	12")] long amt0005, [Description("기금	long	12")] long amt0006, [Description("기타법인	long	12")] long amt0007, [Description("개인	long	12")] long amt0008, [Description("등록외국인	long	12")] long amt0009, [Description("미등록외국인	long	12")] long amt0010, [Description("국가외	long	12")] long amt0011, [Description("기관	long	12")] long amt0018, [Description("외인계(등록+미등록)	long	12")] long amt0088, [Description("기타계(기타+국가)	long	12")] long amt0099);


/// <summary>
/// 외인기관종목별동향(t1716): t1716: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	string	1</param>
/// <param name="fromdt">시작일자	string	8</param>
/// <param name="todt">종료일자	string	8</param>
/// <param name="prapp">PR감산적용율	int	3</param>
/// <param name="prgubun">PR적용구분(0:적용안함1:적용)	string	1</param>
/// <param name="orggubun">기관적용	string	1</param>
/// <param name="frggubun">외인적용	string	1</param>
public record t1716InBlock([Description("종목코드	string	6")] string shcode, [Description("구분(0:일간순매수1:기간누적순매수)	string	1")] string gubun, [Description("시작일자	string	8")] string fromdt, [Description("종료일자	string	8")] string todt, [Description("PR감산적용율	int	3")] int prapp, [Description("PR적용구분(0:적용안함1:적용)	string	1")] string prgubun, [Description("기관적용	string	1")] string orggubun, [Description("외인적용	string	1")] string frggubun);

/// <summary>
/// 외인기관종목별동향(t1716): t1716: OutBlock
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="krx_0008">거래소_개인	long	12</param>
/// <param name="krx_0018">거래소_기관	long	12</param>
/// <param name="krx_0009">거래소_외국인	long	12</param>
/// <param name="pgmvol">프로그램	long	12</param>
/// <param name="fsc_listing">금감원_외인보유주식수	long	12</param>
/// <param name="fsc_sjrate">금감원_소진율	double	6.2</param>
/// <param name="fsc_0009">금감원_외국인	long	12</param>
/// <param name="gm_volume">공매도수량	long	12</param>
/// <param name="gm_value">공매도대금	long	12</param>
public record t1716OutBlock([Description("일자	string	8")] string date, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래소_개인	long	12")] long krx_0008, [Description("거래소_기관	long	12")] long krx_0018, [Description("거래소_외국인	long	12")] long krx_0009, [Description("프로그램	long	12")] long pgmvol, [Description("금감원_외인보유주식수	long	12")] long fsc_listing, [Description("금감원_소진율	double	6.2")] double fsc_sjrate, [Description("금감원_외국인	long	12")] long fsc_0009, [Description("공매도수량	long	12")] long gm_volume, [Description("공매도대금	long	12")] long gm_value);


/// <summary>
/// 외인기관종목별동향(t1717): t1717: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	string	1</param>
/// <param name="fromdt">시작일자(일간조회일경우는space)	string	8</param>
/// <param name="todt">종료일자	string	8</param>
public record t1717InBlock([Description("종목코드	string	6")] string shcode, [Description("구분(0:일간순매수1:기간누적순매수)	string	1")] string gubun, [Description("시작일자(일간조회일경우는space)	string	8")] string fromdt, [Description("종료일자	string	8")] string todt);

/// <summary>
/// 외인기관종목별동향(t1717): t1717: OutBlock
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="tjj0000_vol">사모펀드(순매수량)	long	12</param>
/// <param name="tjj0001_vol">증권(순매수량)	long	12</param>
/// <param name="tjj0002_vol">보험(순매수량)	long	12</param>
/// <param name="tjj0003_vol">투신(순매수량)	long	12</param>
/// <param name="tjj0004_vol">은행(순매수량)	long	12</param>
/// <param name="tjj0005_vol">종금(순매수량)	long	12</param>
/// <param name="tjj0006_vol">기금(순매수량)	long	12</param>
/// <param name="tjj0007_vol">기타법인(순매수량)	long	12</param>
/// <param name="tjj0008_vol">개인(순매수량)	long	12</param>
/// <param name="tjj0009_vol">등록외국인(순매수량)	long	12</param>
/// <param name="tjj0010_vol">미등록외국인(순매수량)	long	12</param>
/// <param name="tjj0011_vol">국가외(순매수량)	long	12</param>
/// <param name="tjj0018_vol">기관(순매수량)	long	12</param>
/// <param name="tjj0016_vol">외인계(순매수량)(등록+미등록)	long	12</param>
/// <param name="tjj0017_vol">기타계(순매수량)(기타+국가)	long	12</param>
/// <param name="tjj0000_dan">사모펀드(단가)	long	12</param>
/// <param name="tjj0001_dan">증권(단가)	long	12</param>
/// <param name="tjj0002_dan">보험(단가)	long	12</param>
/// <param name="tjj0003_dan">투신(단가)	long	12</param>
/// <param name="tjj0004_dan">은행(단가)	long	12</param>
/// <param name="tjj0005_dan">종금(단가)	long	12</param>
/// <param name="tjj0006_dan">기금(단가)	long	12</param>
/// <param name="tjj0007_dan">기타법인(단가)	long	12</param>
/// <param name="tjj0008_dan">개인(단가)	long	12</param>
/// <param name="tjj0009_dan">등록외국인(단가)	long	12</param>
/// <param name="tjj0010_dan">미등록외국인(단가)	long	12</param>
/// <param name="tjj0011_dan">국가외(단가)	long	12</param>
/// <param name="tjj0018_dan">기관(단가)	long	12</param>
/// <param name="tjj0016_dan">외인계(단가)(등록+미등록)	long	12</param>
/// <param name="tjj0017_dan">기타계(단가)(기타+국가)	long	12</param>
public record t1717OutBlock([Description("일자	string	8")] string date, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("사모펀드(순매수량)	long	12")] long tjj0000_vol, [Description("증권(순매수량)	long	12")] long tjj0001_vol, [Description("보험(순매수량)	long	12")] long tjj0002_vol, [Description("투신(순매수량)	long	12")] long tjj0003_vol, [Description("은행(순매수량)	long	12")] long tjj0004_vol, [Description("종금(순매수량)	long	12")] long tjj0005_vol, [Description("기금(순매수량)	long	12")] long tjj0006_vol, [Description("기타법인(순매수량)	long	12")] long tjj0007_vol, [Description("개인(순매수량)	long	12")] long tjj0008_vol, [Description("등록외국인(순매수량)	long	12")] long tjj0009_vol, [Description("미등록외국인(순매수량)	long	12")] long tjj0010_vol, [Description("국가외(순매수량)	long	12")] long tjj0011_vol, [Description("기관(순매수량)	long	12")] long tjj0018_vol, [Description("외인계(순매수량)(등록+미등록)	long	12")] long tjj0016_vol, [Description("기타계(순매수량)(기타+국가)	long	12")] long tjj0017_vol, [Description("사모펀드(단가)	long	12")] long tjj0000_dan, [Description("증권(단가)	long	12")] long tjj0001_dan, [Description("보험(단가)	long	12")] long tjj0002_dan, [Description("투신(단가)	long	12")] long tjj0003_dan, [Description("은행(단가)	long	12")] long tjj0004_dan, [Description("종금(단가)	long	12")] long tjj0005_dan, [Description("기금(단가)	long	12")] long tjj0006_dan, [Description("기타법인(단가)	long	12")] long tjj0007_dan, [Description("개인(단가)	long	12")] long tjj0008_dan, [Description("등록외국인(단가)	long	12")] long tjj0009_dan, [Description("미등록외국인(단가)	long	12")] long tjj0010_dan, [Description("국가외(단가)	long	12")] long tjj0011_dan, [Description("기관(단가)	long	12")] long tjj0018_dan, [Description("외인계(단가)(등록+미등록)	long	12")] long tjj0016_dan, [Description("기타계(단가)(기타+국가)	long	12")] long tjj0017_dan);


/// <summary>
/// 종목별상위회원사(t1752): t1752: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="traddate1">조회날짜1	string	8</param>
/// <param name="traddate2">조회날짜2	string	8</param>
/// <param name="fwgubun1">외국계구분	string	1</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1752InBlock([Description("종목코드	string	6")] string shcode, [Description("조회날짜1	string	8")] string traddate1, [Description("조회날짜2	string	8")] string traddate2, [Description("외국계구분	string	1")] string fwgubun1, [Description("CTSIDX	int	4")] int cts_idx);

/// <summary>
/// 종목별상위회원사(t1752): t1752: OutBlock
/// </summary>
/// <param name="fwdvl">외국계매도	long	12</param>
/// <param name="fwsvl">외국계매수	long	12</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1752OutBlock([Description("외국계매도	long	12")] long fwdvl, [Description("외국계매수	long	12")] long fwsvl, [Description("CTSIDX	int	4")] int cts_idx);

/// <summary>
/// 종목별상위회원사(t1752): t1752: OutBlock1
/// </summary>
/// <param name="tradname">회원사	string	20</param>
/// <param name="tradmdvol">매도수량	long	12</param>
/// <param name="tradmsvol">매수수량	long	12</param>
/// <param name="tradmssvol">순매수	long	12</param>
/// <param name="wintrd">창구거래	long	12</param>
/// <param name="winrat">비중	double	6.1</param>
/// <param name="tradno">회원사코드	string	3</param>
/// <param name="wgubun">외국계여부	string	1</param>
/// <param name="swinrat">순비중	double	6.1</param>
public record t1752OutBlock1([Description("회원사	string	20")] string tradname, [Description("매도수량	long	12")] long tradmdvol, [Description("매수수량	long	12")] long tradmsvol, [Description("순매수	long	12")] long tradmssvol, [Description("창구거래	long	12")] long wintrd, [Description("비중	double	6.1")] double winrat, [Description("회원사코드	string	3")] string tradno, [Description("외국계여부	string	1")] string wgubun, [Description("순비중	double	6.1")] double swinrat);


/// <summary>
/// 회원사리스트(t1764): t1764: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun1">구분1	string	1</param>
public record t1764InBlock([Description("종목코드	string	6")] string shcode, [Description("구분1	string	1")] string gubun1);

/// <summary>
/// 회원사리스트(t1764): t1764: OutBlock
/// </summary>
/// <param name="rank">순위	int	4</param>
/// <param name="tradno">거래원번호	string	3</param>
/// <param name="tradname">거래원이름	string	20</param>
public record t1764OutBlock([Description("순위	int	4")] int rank, [Description("거래원번호	string	3")] string tradno, [Description("거래원이름	string	20")] string tradname);


/// <summary>
/// 종목별회원사추이(t1771): t1771: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="tradno">거래원코드	string	3</param>
/// <param name="gubun1">구분1	string	1</param>
/// <param name="traddate1">거래원날짜1	string	8</param>
/// <param name="traddate2">거래원날짜2	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">요청건수	int	3</param>
public record t1771InBlock([Description("종목코드	string	6")] string shcode, [Description("거래원코드	string	3")] string tradno, [Description("구분1	string	1")] string gubun1, [Description("거래원날짜1	string	8")] string traddate1, [Description("거래원날짜2	string	8")] string traddate2, [Description("CTSIDX	int	4")] int cts_idx, [Description("요청건수	int	3")] int cnt);

/// <summary>
/// 종목별회원사추이(t1771): t1771: OutBlock
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1771OutBlock([Description("CTSIDX	int	4")] int cts_idx);

/// <summary>
/// 종목별회원사추이(t1771): t1771: OutBlock2
/// </summary>
/// <param name="traddate">날짜	string	8</param>
/// <param name="tradtime">시간	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="tradmdcha">매도	long	12</param>
/// <param name="tradmscha">매수	long	12</param>
/// <param name="tradmdval">매도대금	long	18</param>
/// <param name="tradmsval">매수대금	long	18</param>
/// <param name="tradmsscha">순매수	long	12</param>
/// <param name="tradmttvolume">누적순매수	long	12</param>
/// <param name="tradavg">평균단가	int	8</param>
/// <param name="tradmttavg">누적평균단가	int	8</param>
public record t1771OutBlock2([Description("날짜	string	8")] string traddate, [Description("시간	string	8")] string tradtime, [Description("현재가	int	8")] int price, [Description("대비구분	string	1")] string sign, [Description("대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("매도	long	12")] long tradmdcha, [Description("매수	long	12")] long tradmscha, [Description("매도대금	long	18")] long tradmdval, [Description("매수대금	long	18")] long tradmsval, [Description("순매수	long	12")] long tradmsscha, [Description("누적순매수	long	12")] long tradmttvolume, [Description("평균단가	int	8")] int tradavg, [Description("누적평균단가	int	8")] int tradmttavg);


/// <summary>
/// 신호조회(t1809): t1809: InBlock
/// </summary>
/// <param name="gubun">신호구분	string	1</param>
/// <param name="jmGb">종목구분	string	1</param>
/// <param name="jmcode">종목코드	string	6</param>
/// <param name="cts">NEXTKEY	string	30</param>
public record t1809InBlock([Description("신호구분	string	1")] string gubun, [Description("종목구분	string	1")] string jmGb, [Description("종목코드	string	6")] string jmcode, [Description("NEXTKEY	string	30")] string cts);

/// <summary>
/// 신호조회(t1809): t1809: OutBlock
/// </summary>
/// <param name="cts">NEXTKEY	string	30</param>
public record t1809OutBlock([Description("NEXTKEY	string	30")] string cts);

/// <summary>
/// 신호조회(t1809): t1809: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="signal_id">신호ID	string	4</param>
/// <param name="signal_desc">신호명	string	300</param>
/// <param name="point">신호강도	string	3</param>
/// <param name="keyword">뉴스신호키워드	string	40</param>
/// <param name="seq">신호별구분	string	24</param>
/// <param name="gubun">신호구분	string	2</param>
/// <param name="jmcode">신호종목	string	6</param>
/// <param name="price">종목가격	int	7</param>
/// <param name="sign">종목등락부호	string	1</param>
/// <param name="chgrate">대비등락율	double	6.2</param>
/// <param name="volume">거래량	long	9</param>
/// <param name="datetime">신호일시	string	16</param>
public record t1809OutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("신호ID	string	4")] string signal_id, [Description("신호명	string	300")] string signal_desc, [Description("신호강도	string	3")] string point, [Description("뉴스신호키워드	string	40")] string keyword, [Description("신호별구분	string	24")] string seq, [Description("신호구분	string	2")] string gubun, [Description("신호종목	string	6")] string jmcode, [Description("종목가격	int	7")] int price, [Description("종목등락부호	string	1")] string sign, [Description("대비등락율	double	6.2")] double chgrate, [Description("거래량	long	9")] long volume, [Description("신호일시	string	16")] string datetime);


/// <summary>
/// 종목Q클릭검색(씽큐스마트)(t1825): t1825: InBlock
/// </summary>
/// <param name="search_cd">검색코드	string	4</param>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t1825InBlock([Description("검색코드	string	4")] string search_cd, [Description("구분(0:전체1:코스피2:코스닥)	string	1")] string gubun);

/// <summary>
/// 종목Q클릭검색(씽큐스마트)(t1825): t1825: OutBlock
/// </summary>
/// <param name="JongCnt">검색종목수	int	4</param>
public record t1825OutBlock([Description("검색종목수	int	4")] int JongCnt);

/// <summary>
/// 종목Q클릭검색(씽큐스마트)(t1825): t1825: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="signcnt">연속봉수	int	3</param>
/// <param name="close">현재가	long	9</param>
/// <param name="change">전일대비	long	9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	10</param>
/// <param name="volumerate">거래량전일대비율	double	6.2</param>
public record t1825OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	20")] string hname, [Description("전일대비구분	string	1")] string sign, [Description("연속봉수	int	3")] int signcnt, [Description("현재가	long	9")] long close, [Description("전일대비	long	9")] long change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	10")] long volume, [Description("거래량전일대비율	double	6.2")] double volumerate);


/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826): t1826: InBlock
/// </summary>
/// <param name="search_gb">검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)	string	1</param>
public record t1826InBlock([Description("검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)	string	1")] string search_gb);

/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트)(t1826): t1826: OutBlock
/// </summary>
/// <param name="search_cd">검색코드	string	4</param>
/// <param name="search_nm">검색명	string	40</param>
public record t1826OutBlock([Description("검색코드	string	4")] string search_cd, [Description("검색명	string	40")] string search_nm);


/// <summary>
/// e종목검색(신버전API용): t1857: InBlock
/// </summary>
/// <param name="sRealFlag">실시간구분(0:조회 1:실시간)	string	1</param>
/// <param name="sSearchFlag">종목검색구분(F:파일 S:서버)	string	1</param>
/// <param name="query_index">종목검색입력값	string	256</param>
public record t1857InBlock([Description("실시간구분(0:조회 1:실시간)	string	1")] string sRealFlag, [Description("종목검색구분(F:파일 S:서버)	string	1")] string sSearchFlag, [Description("종목검색입력값	string	256")] string query_index);

/// <summary>
/// e종목검색(신버전API용): t1857: OutBlock
/// </summary>
/// <param name="result_count">검색종목수	int	5</param>
/// <param name="result_time">포착시간	string	6</param>
/// <param name="AlertNum">실시간키	string	11</param>
public record t1857OutBlock([Description("검색종목수	int	5")] int result_count, [Description("포착시간	string	6")] string result_time, [Description("실시간키	string	11")] string AlertNum);

/// <summary>
/// e종목검색(신버전API용): t1857: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	7</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="price">현재가	long	9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	long	9</param>
/// <param name="diff">등락율	double	6</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="JobFlag">종목상태(N:진입 R:재진입 O:이탈)	string	1</param>
public record t1857OutBlock1([Description("종목코드	string	7")] string shcode, [Description("종목명	string	40")] string hname, [Description("현재가	long	9")] long price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	long	9")] long change, [Description("등락율	double	6")] double diff, [Description("거래량	long	12")] long volume, [Description("종목상태(N:진입 R:재진입 O:이탈)	string	1")] string JobFlag);


/// <summary>
/// 서버저장조건리스트조회(API)(t1866): t1866: InBlock
/// </summary>
/// <param name="user_id">로그인ID	string	8</param>
/// <param name="gb">조회구분	string	1</param>
/// <param name="group_name">그룹명	string	40</param>
/// <param name="cont">연속여부	string	1</param>
/// <param name="contkey">연속키	string	40</param>
public record t1866InBlock([Description("로그인ID	string	8")] string user_id, [Description("조회구분	string	1")] string gb, [Description("그룹명	string	40")] string group_name, [Description("연속여부	string	1")] string cont, [Description("연속키	string	40")] string contkey);

/// <summary>
/// 서버저장조건리스트조회(API)(t1866): t1866: OutBlock
/// </summary>
/// <param name="result_count">저장조건수	int	5</param>
/// <param name="cont">연속여부	string	1</param>
/// <param name="contkey">연속키	string	40</param>
public record t1866OutBlock([Description("저장조건수	int	5")] int result_count, [Description("연속여부	string	1")] string cont, [Description("연속키	string	40")] string contkey);

/// <summary>
/// 서버저장조건리스트조회(API)(t1866): t1866: OutBlock1
/// </summary>
/// <param name="query_index">서버저장인덱스	string	12</param>
/// <param name="group_name">그룹명	string	40</param>
/// <param name="query_name">조건저장명	string	40</param>
public record t1866OutBlock1([Description("서버저장인덱스	string	12")] string query_index, [Description("그룹명	string	40")] string group_name, [Description("조건저장명	string	40")] string query_name);


/// <summary>
/// ETF현재가(시세)조회(t1901): t1901: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1901InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ETF현재가(시세)조회(t1901): t1901: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="avg">가중평균	int	8</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="jnilvolume">전일거래량	double	12</param>
/// <param name="volumediff">거래량차	long	12</param>
/// <param name="open">시가	int	8</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="high52w">52최고가	int	8</param>
/// <param name="high52wdate">52최고가일	string	8</param>
/// <param name="low52w">52최저가	int	8</param>
/// <param name="low52wdate">52최저가일	string	8</param>
/// <param name="exhratio">소진율	double	6.2</param>
/// <param name="flmtvol">외국인보유수량	double	12</param>
/// <param name="per">PER	double	6.2</param>
/// <param name="listing">상장주식수(천)	long	12</param>
/// <param name="jkrate">증거금율	int	8</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="value">누적거래대금	long	12</param>
/// <param name="highyear">연중최고가	int	8</param>
/// <param name="highyeardate">연중최고일자	string	8</param>
/// <param name="lowyear">연중최저가	int	8</param>
/// <param name="lowyeardate">연중최저일자	string	8</param>
/// <param name="upname">업종명	string	20</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="upprice">업종현재가	double	7.2</param>
/// <param name="upsign">업종전일비구분	string	1</param>
/// <param name="upchange">업종전일대비	double	6.2</param>
/// <param name="updiff">업종등락율	double	6.2</param>
/// <param name="futname">선물최근월물명	string	20</param>
/// <param name="futcode">선물최근월물코드	string	8</param>
/// <param name="futprice">선물현재가	double	6.2</param>
/// <param name="futsign">선물전일비구분	string	1</param>
/// <param name="futchange">선물전일대비	double	6.2</param>
/// <param name="futdiff">선물등락율	double	6.2</param>
/// <param name="nav">NAV	double	8.2</param>
/// <param name="navsign">NAV전일대비구분	string	1</param>
/// <param name="navchange">NAV전일대비	double	8.2</param>
/// <param name="navdiff">NAV등락율	double	6.2</param>
/// <param name="cocrate">추적오차율	double	6.2</param>
/// <param name="kasis">괴리율	double	6.2</param>
/// <param name="subprice">대용가	long	10</param>
/// <param name="offerno1">매도증권사코드1	string	6</param>
/// <param name="bidno1">매수증권사코드1	string	6</param>
/// <param name="dvol1">총매도수량1	int	8</param>
/// <param name="svol1">총매수수량1	int	8</param>
/// <param name="dcha1">매도증감1	int	8</param>
/// <param name="scha1">매수증감1	int	8</param>
/// <param name="ddiff1">매도비율1	double	6.2</param>
/// <param name="sdiff1">매수비율1	double	6.2</param>
/// <param name="offerno2">매도증권사코드2	string	6</param>
/// <param name="bidno2">매수증권사코드2	string	6</param>
/// <param name="dvol2">총매도수량2	int	8</param>
/// <param name="svol2">총매수수량2	int	8</param>
/// <param name="dcha2">매도증감2	int	8</param>
/// <param name="scha2">매수증감2	int	8</param>
/// <param name="ddiff2">매도비율2	double	6.2</param>
/// <param name="sdiff2">매수비율2	double	6.2</param>
/// <param name="offerno3">매도증권사코드3	string	6</param>
/// <param name="bidno3">매수증권사코드3	string	6</param>
/// <param name="dvol3">총매도수량3	int	8</param>
/// <param name="svol3">총매수수량3	int	8</param>
/// <param name="dcha3">매도증감3	int	8</param>
/// <param name="scha3">매수증감3	int	8</param>
/// <param name="ddiff3">매도비율3	double	6.2</param>
/// <param name="sdiff3">매수비율3	double	6.2</param>
/// <param name="offerno4">매도증권사코드4	string	6</param>
/// <param name="bidno4">매수증권사코드4	string	6</param>
/// <param name="dvol4">총매도수량4	int	8</param>
/// <param name="svol4">총매수수량4	int	8</param>
/// <param name="dcha4">매도증감4	int	8</param>
/// <param name="scha4">매수증감4	int	8</param>
/// <param name="ddiff4">매도비율4	double	6.2</param>
/// <param name="sdiff4">매수비율4	double	6.2</param>
/// <param name="offerno5">매도증권사코드5	string	6</param>
/// <param name="bidno5">매수증권사코드5	string	6</param>
/// <param name="dvol5">총매도수량5	int	8</param>
/// <param name="svol5">총매수수량5	int	8</param>
/// <param name="dcha5">매도증감5	int	8</param>
/// <param name="scha5">매수증감5	int	8</param>
/// <param name="ddiff5">매도비율5	double	6.2</param>
/// <param name="sdiff5">매수비율5	double	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	long	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	long	12</param>
/// <param name="ftradmddiff">외국계매도비율	double	6.2</param>
/// <param name="fwsvl">외국계매수합계수량	long	12</param>
/// <param name="ftradmscha">외국계매수직전대비	long	12</param>
/// <param name="ftradmsdiff">외국계매수비율	double	6.2</param>
/// <param name="upname2">참고지수명	string	20</param>
/// <param name="upcode2">참고지수코드	string	3</param>
/// <param name="upprice2">참고지수현재가	double	7.2</param>
/// <param name="jnilnav">전일NAV	double	8.2</param>
/// <param name="jnilnavsign">전일NAV전일대비구분	string	1</param>
/// <param name="jnilnavchange">전일NAV전일대비	double	8.2</param>
/// <param name="jnilnavdiff">전일NAV등락율	double	6.2</param>
/// <param name="etftotcap">순자산총액(억원)	long	12</param>
/// <param name="spread">스프레드	double	6.2</param>
/// <param name="leverage">레버리지	int	2</param>
/// <param name="taxgubun">과세구분	string	1</param>
/// <param name="opcom_nmk">운용사	string	20</param>
/// <param name="lp_nm1">LP1	string	20</param>
/// <param name="lp_nm2">LP2	string	20</param>
/// <param name="lp_nm3">LP3	string	20</param>
/// <param name="lp_nm4">LP4	string	20</param>
/// <param name="lp_nm5">LP5	string	20</param>
/// <param name="etf_cp">복제방법	string	10</param>
/// <param name="etf_kind">상품유형(Filler)	string	10</param>
/// <param name="vi_gubun">VI발동해제	string	10</param>
/// <param name="etn_kind_cd">ETN상품분류	string	20</param>
/// <param name="lastymd">ETN만기일	string	8</param>
/// <param name="payday">ETN지급일	string	8</param>
/// <param name="lastdate">ETN최종거래일	string	8</param>
/// <param name="issuernmk">ETN발행시장참가자	string	20</param>
/// <param name="last_sdate">ETN만기상환가격결정시작일	string	8</param>
/// <param name="last_edate">ETN만기상환가격결정종료일	string	8</param>
/// <param name="lp_holdvol">ETNLP보유수량	string	12</param>
/// <param name="listdate">상장일	string	8</param>
/// <param name="etp_gb">ETP상품구분코드	string	1</param>
/// <param name="etn_elback_yn">ETN조기상환가능여부	string	1</param>
/// <param name="settletype">최종결제	string	2</param>
/// <param name="idx_asset_class1">지수자산분류코드(대분류)	string	2</param>
/// <param name="ty_text">ETF/ETN투자유의	string	8</param>
/// <param name="leverage2">추적수익률배수	double	6.2</param>
public record t1901OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	double	12")] double volume, [Description("기준가	int	8")] int recprice, [Description("가중평균	int	8")] int avg, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("전일거래량	double	12")] double jnilvolume, [Description("거래량차	long	12")] long volumediff, [Description("시가	int	8")] int open, [Description("시가시간	string	6")] string opentime, [Description("고가	int	8")] int high, [Description("고가시간	string	6")] string hightime, [Description("저가	int	8")] int low, [Description("저가시간	string	6")] string lowtime, [Description("52최고가	int	8")] int high52w, [Description("52최고가일	string	8")] string high52wdate, [Description("52최저가	int	8")] int low52w, [Description("52최저가일	string	8")] string low52wdate, [Description("소진율	double	6.2")] double exhratio, [Description("외국인보유수량	double	12")] double flmtvol, [Description("PER	double	6.2")] double per, [Description("상장주식수(천)	long	12")] long listing, [Description("증거금율	int	8")] int jkrate, [Description("회전율	double	6.2")] double vol, [Description("단축코드	string	6")] string shcode, [Description("누적거래대금	long	12")] long value, [Description("연중최고가	int	8")] int highyear, [Description("연중최고일자	string	8")] string highyeardate, [Description("연중최저가	int	8")] int lowyear, [Description("연중최저일자	string	8")] string lowyeardate, [Description("업종명	string	20")] string upname, [Description("업종코드	string	3")] string upcode, [Description("업종현재가	double	7.2")] double upprice, [Description("업종전일비구분	string	1")] string upsign, [Description("업종전일대비	double	6.2")] double upchange, [Description("업종등락율	double	6.2")] double updiff, [Description("선물최근월물명	string	20")] string futname, [Description("선물최근월물코드	string	8")] string futcode, [Description("선물현재가	double	6.2")] double futprice, [Description("선물전일비구분	string	1")] string futsign, [Description("선물전일대비	double	6.2")] double futchange, [Description("선물등락율	double	6.2")] double futdiff, [Description("NAV	double	8.2")] double nav, [Description("NAV전일대비구분	string	1")] string navsign, [Description("NAV전일대비	double	8.2")] double navchange, [Description("NAV등락율	double	6.2")] double navdiff, [Description("추적오차율	double	6.2")] double cocrate, [Description("괴리율	double	6.2")] double kasis, [Description("대용가	long	10")] long subprice, [Description("매도증권사코드1	string	6")] string offerno1, [Description("매수증권사코드1	string	6")] string bidno1, [Description("총매도수량1	int	8")] int dvol1, [Description("총매수수량1	int	8")] int svol1, [Description("매도증감1	int	8")] int dcha1, [Description("매수증감1	int	8")] int scha1, [Description("매도비율1	double	6.2")] double ddiff1, [Description("매수비율1	double	6.2")] double sdiff1, [Description("매도증권사코드2	string	6")] string offerno2, [Description("매수증권사코드2	string	6")] string bidno2, [Description("총매도수량2	int	8")] int dvol2, [Description("총매수수량2	int	8")] int svol2, [Description("매도증감2	int	8")] int dcha2, [Description("매수증감2	int	8")] int scha2, [Description("매도비율2	double	6.2")] double ddiff2, [Description("매수비율2	double	6.2")] double sdiff2, [Description("매도증권사코드3	string	6")] string offerno3, [Description("매수증권사코드3	string	6")] string bidno3, [Description("총매도수량3	int	8")] int dvol3, [Description("총매수수량3	int	8")] int svol3, [Description("매도증감3	int	8")] int dcha3, [Description("매수증감3	int	8")] int scha3, [Description("매도비율3	double	6.2")] double ddiff3, [Description("매수비율3	double	6.2")] double sdiff3, [Description("매도증권사코드4	string	6")] string offerno4, [Description("매수증권사코드4	string	6")] string bidno4, [Description("총매도수량4	int	8")] int dvol4, [Description("총매수수량4	int	8")] int svol4, [Description("매도증감4	int	8")] int dcha4, [Description("매수증감4	int	8")] int scha4, [Description("매도비율4	double	6.2")] double ddiff4, [Description("매수비율4	double	6.2")] double sdiff4, [Description("매도증권사코드5	string	6")] string offerno5, [Description("매수증권사코드5	string	6")] string bidno5, [Description("총매도수량5	int	8")] int dvol5, [Description("총매수수량5	int	8")] int svol5, [Description("매도증감5	int	8")] int dcha5, [Description("매수증감5	int	8")] int scha5, [Description("매도비율5	double	6.2")] double ddiff5, [Description("매수비율5	double	6.2")] double sdiff5, [Description("외국계매도합계수량	long	12")] long fwdvl, [Description("외국계매도직전대비	long	12")] long ftradmdcha, [Description("외국계매도비율	double	6.2")] double ftradmddiff, [Description("외국계매수합계수량	long	12")] long fwsvl, [Description("외국계매수직전대비	long	12")] long ftradmscha, [Description("외국계매수비율	double	6.2")] double ftradmsdiff, [Description("참고지수명	string	20")] string upname2, [Description("참고지수코드	string	3")] string upcode2, [Description("참고지수현재가	double	7.2")] double upprice2, [Description("전일NAV	double	8.2")] double jnilnav, [Description("전일NAV전일대비구분	string	1")] string jnilnavsign, [Description("전일NAV전일대비	double	8.2")] double jnilnavchange, [Description("전일NAV등락율	double	6.2")] double jnilnavdiff, [Description("순자산총액(억원)	long	12")] long etftotcap, [Description("스프레드	double	6.2")] double spread, [Description("레버리지	int	2")] int leverage, [Description("과세구분	string	1")] string taxgubun, [Description("운용사	string	20")] string opcom_nmk, [Description("LP1	string	20")] string lp_nm1, [Description("LP2	string	20")] string lp_nm2, [Description("LP3	string	20")] string lp_nm3, [Description("LP4	string	20")] string lp_nm4, [Description("LP5	string	20")] string lp_nm5, [Description("복제방법	string	10")] string etf_cp, [Description("상품유형(Filler)	string	10")] string etf_kind, [Description("VI발동해제	string	10")] string vi_gubun, [Description("ETN상품분류	string	20")] string etn_kind_cd, [Description("ETN만기일	string	8")] string lastymd, [Description("ETN지급일	string	8")] string payday, [Description("ETN최종거래일	string	8")] string lastdate, [Description("ETN발행시장참가자	string	20")] string issuernmk, [Description("ETN만기상환가격결정시작일	string	8")] string last_sdate, [Description("ETN만기상환가격결정종료일	string	8")] string last_edate, [Description("ETNLP보유수량	string	12")] string lp_holdvol, [Description("상장일	string	8")] string listdate, [Description("ETP상품구분코드	string	1")] string etp_gb, [Description("ETN조기상환가능여부	string	1")] string etn_elback_yn, [Description("최종결제	string	2")] string settletype, [Description("지수자산분류코드(대분류)	string	2")] string idx_asset_class1, [Description("ETF/ETN투자유의	string	8")] string ty_text, [Description("추적수익률배수	double	6.2")] double leverage2);


/// <summary>
/// ETF시간별추이(t1902): t1902: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="time">시간	string	6</param>
public record t1902InBlock([Description("단축코드	string	6")] string shcode, [Description("시간	string	6")] string time);

/// <summary>
/// ETF시간별추이(t1902): t1902: OutBlock
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="upname">업종지수명	string	20</param>
public record t1902OutBlock([Description("시간	string	6")] string time, [Description("종목명	string	20")] string hname, [Description("업종지수명	string	20")] string upname);

/// <summary>
/// ETF시간별추이(t1902): t1902: OutBlock1
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
public record t1902OutBlock1([Description("시간	string	8")] string time, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("누적거래량	double	12")] double volume, [Description("NAV대비	double	9.2")] double navdiff, [Description("NAV	double	9.2")] double nav, [Description("전일대비	double	9.2")] double navchange, [Description("추적오차	double	9.2")] double crate, [Description("괴리	double	9.2")] double grate, [Description("지수	double	8.2")] double jisu, [Description("전일대비	double	8.2")] double jichange, [Description("전일대비율	double	8.2")] double jirate);


/// <summary>
/// ETF일별추이(t1903): t1903: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="date">일자	string	8</param>
public record t1903InBlock([Description("단축코드	string	6")] string shcode, [Description("일자	string	8")] string date);

/// <summary>
/// ETF일별추이(t1903): t1903: OutBlock
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="upname">업종지수명	string	20</param>
public record t1903OutBlock([Description("일자	string	8")] string date, [Description("종목명	string	20")] string hname, [Description("업종지수명	string	20")] string upname);

/// <summary>
/// ETF일별추이(t1903): t1903: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
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
public record t1903OutBlock1([Description("일자	string	8")] string date, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("누적거래량	double	12")] double volume, [Description("NAV대비	double	9.2")] double navdiff, [Description("NAV	double	9.2")] double nav, [Description("전일대비	double	9.2")] double navchange, [Description("추적오차	double	9.2")] double crate, [Description("괴리	double	9.2")] double grate, [Description("지수	double	8.2")] double jisu, [Description("전일대비	double	8.2")] double jichange, [Description("전일대비율	double	8.2")] double jirate);


/// <summary>
/// ETF구성종목조회(t1904): t1904: InBlock
/// </summary>
/// <param name="shcode">ETF단축코드	string	6</param>
/// <param name="date">PDF적용일자	string	8</param>
/// <param name="sgb">정렬기준(1:평가금액2:증권수)	string	1</param>
public record t1904InBlock([Description("ETF단축코드	string	6")] string shcode, [Description("PDF적용일자	string	8")] string date, [Description("정렬기준(1:평가금액2:증권수)	string	1")] string sgb);

/// <summary>
/// ETF구성종목조회(t1904): t1904: OutBlock
/// </summary>
/// <param name="chk_tday">당일구분	string	1</param>
/// <param name="date">PDF적용일자	string	8</param>
/// <param name="price">ETF현재가	int	8</param>
/// <param name="sign">ETF전일대비구분	string	1</param>
/// <param name="change">ETF전일대비	int	8</param>
/// <param name="diff">ETF등락율	double	6.2</param>
/// <param name="volume">ETF누적거래량	long	12</param>
/// <param name="nav">NAV	double	8.2</param>
/// <param name="navsign">NAV전일대비구분	string	1</param>
/// <param name="navchange">NAV전일대비	double	8.2</param>
/// <param name="navdiff">NAV등락율	double	6.2</param>
/// <param name="jnilnav">전일NAV	double	8.2</param>
/// <param name="jnilnavsign">전일NAV전일대비구분	string	1</param>
/// <param name="jnilnavchange">전일NAV전일대비	double	8.2</param>
/// <param name="jnilnavdiff">전일NAV등락율	double	6.2</param>
/// <param name="upname">업종명	string	20</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="upprice">업종현재가	double	7.2</param>
/// <param name="upsign">업종전일비구분	string	1</param>
/// <param name="upchange">업종전일대비	double	6.2</param>
/// <param name="updiff">업종등락율	double	6.2</param>
/// <param name="futname">선물최근월물명	string	20</param>
/// <param name="futcode">선물최근월물코드	string	8</param>
/// <param name="futprice">선물현재가	double	6.2</param>
/// <param name="futsign">선물전일비구분	string	1</param>
/// <param name="futchange">선물전일대비	double	6.2</param>
/// <param name="futdiff">선물등락율	double	6.2</param>
/// <param name="upname2">참고지수명	string	20</param>
/// <param name="upcode2">참고지수코드	string	3</param>
/// <param name="upprice2">참고지수현재가	double	7.2</param>
/// <param name="etftotcap">순자산총액(단위:억)	long	12</param>
/// <param name="etfnum">구성종목수	int	4</param>
/// <param name="etfcunum">CU주식수	long	12</param>
/// <param name="cash">현금	long	12</param>
/// <param name="opcom_nmk">운용사명	string	20</param>
/// <param name="tot_pval">전종목평가금액합	long	12</param>
/// <param name="tot_sigatval">전종목구성시가총액합	long	12</param>
public record t1904OutBlock([Description("당일구분	string	1")] string chk_tday, [Description("PDF적용일자	string	8")] string date, [Description("ETF현재가	int	8")] int price, [Description("ETF전일대비구분	string	1")] string sign, [Description("ETF전일대비	int	8")] int change, [Description("ETF등락율	double	6.2")] double diff, [Description("ETF누적거래량	long	12")] long volume, [Description("NAV	double	8.2")] double nav, [Description("NAV전일대비구분	string	1")] string navsign, [Description("NAV전일대비	double	8.2")] double navchange, [Description("NAV등락율	double	6.2")] double navdiff, [Description("전일NAV	double	8.2")] double jnilnav, [Description("전일NAV전일대비구분	string	1")] string jnilnavsign, [Description("전일NAV전일대비	double	8.2")] double jnilnavchange, [Description("전일NAV등락율	double	6.2")] double jnilnavdiff, [Description("업종명	string	20")] string upname, [Description("업종코드	string	3")] string upcode, [Description("업종현재가	double	7.2")] double upprice, [Description("업종전일비구분	string	1")] string upsign, [Description("업종전일대비	double	6.2")] double upchange, [Description("업종등락율	double	6.2")] double updiff, [Description("선물최근월물명	string	20")] string futname, [Description("선물최근월물코드	string	8")] string futcode, [Description("선물현재가	double	6.2")] double futprice, [Description("선물전일비구분	string	1")] string futsign, [Description("선물전일대비	double	6.2")] double futchange, [Description("선물등락율	double	6.2")] double futdiff, [Description("참고지수명	string	20")] string upname2, [Description("참고지수코드	string	3")] string upcode2, [Description("참고지수현재가	double	7.2")] double upprice2, [Description("순자산총액(단위:억)	long	12")] long etftotcap, [Description("구성종목수	int	4")] int etfnum, [Description("CU주식수	long	12")] long etfcunum, [Description("현금	long	12")] long cash, [Description("운용사명	string	20")] string opcom_nmk, [Description("전종목평가금액합	long	12")] long tot_pval, [Description("전종목구성시가총액합	long	12")] long tot_sigatval);

/// <summary>
/// ETF구성종목조회(t1904): t1904: OutBlock1
/// </summary>
/// <param name="shcode">단축코드	string	12</param>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="value">거래대금(백만)	long	12</param>
/// <param name="icux">단위증권수(계약수/원화현금/USD현금/창고증권)	long	12</param>
/// <param name="parprice">액면금액/설정현금액	long	12</param>
/// <param name="pvalue">평가금액	long	12</param>
/// <param name="sigatvalue">구성시가총액	long	12</param>
/// <param name="profitdate">PDF적용일자	string	8</param>
/// <param name="weight">비중(평가금액)	double	6.2</param>
/// <param name="diff2">ETF종목과등락차	double	6.2</param>
public record t1904OutBlock1([Description("단축코드	string	12")] string shcode, [Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("거래대금(백만)	long	12")] long value, [Description("단위증권수(계약수/원화현금/USD현금/창고증권)	long	12")] long icux, [Description("액면금액/설정현금액	long	12")] long parprice, [Description("평가금액	long	12")] long pvalue, [Description("구성시가총액	long	12")] long sigatvalue, [Description("PDF적용일자	string	8")] string profitdate, [Description("비중(평가금액)	double	6.2")] double weight, [Description("ETF종목과등락차	double	6.2")] double diff2);


/// <summary>
/// ETFLP호가(t1906): t1906: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1906InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ETFLP호가(t1906): t1906: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="lp_offerrem1">LP매도호가수량1	long	12</param>
/// <param name="lp_bidrem1">LP매수호가수량1	long	12</param>
/// <param name="lp_offerrem2">LP매도호가수량2	long	12</param>
/// <param name="lp_bidrem2">LP매수호가수량2	long	12</param>
/// <param name="lp_offerrem3">LP매도호가수량3	long	12</param>
/// <param name="lp_bidrem3">LP매수호가수량3	long	12</param>
/// <param name="lp_offerrem4">LP매도호가수량4	long	12</param>
/// <param name="lp_bidrem4">LP매수호가수량4	long	12</param>
/// <param name="lp_offerrem5">LP매도호가수량5	long	12</param>
/// <param name="lp_bidrem5">LP매수호가수량5	long	12</param>
/// <param name="lp_offerrem6">LP매도호가수량6	long	12</param>
/// <param name="lp_bidrem6">LP매수호가수량6	long	12</param>
/// <param name="lp_offerrem7">LP매도호가수량7	long	12</param>
/// <param name="lp_bidrem7">LP매수호가수량7	long	12</param>
/// <param name="lp_offerrem8">LP매도호가수량8	long	12</param>
/// <param name="lp_bidrem8">LP매수호가수량8	long	12</param>
/// <param name="lp_offerrem9">LP매도호가수량9	long	12</param>
/// <param name="lp_bidrem9">LP매수호가수량9	long	12</param>
/// <param name="lp_offerrem10">LP매도호가수량10	long	12</param>
/// <param name="lp_bidrem10">LP매수호가수량10	long	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="offerho1">매도호가1	int	8</param>
/// <param name="bidho1">매수호가1	int	8</param>
/// <param name="offerrem1">매도호가수량1	long	12</param>
/// <param name="bidrem1">매수호가수량1	long	12</param>
/// <param name="preoffercha1">직전매도대비수량1	long	12</param>
/// <param name="prebidcha1">직전매수대비수량1	long	12</param>
/// <param name="offerho2">매도호가2	int	8</param>
/// <param name="bidho2">매수호가2	int	8</param>
/// <param name="offerrem2">매도호가수량2	long	12</param>
/// <param name="bidrem2">매수호가수량2	long	12</param>
/// <param name="preoffercha2">직전매도대비수량2	long	12</param>
/// <param name="prebidcha2">직전매수대비수량2	long	12</param>
/// <param name="offerho3">매도호가3	int	8</param>
/// <param name="bidho3">매수호가3	int	8</param>
/// <param name="offerrem3">매도호가수량3	long	12</param>
/// <param name="bidrem3">매수호가수량3	long	12</param>
/// <param name="preoffercha3">직전매도대비수량3	long	12</param>
/// <param name="prebidcha3">직전매수대비수량3	long	12</param>
/// <param name="offerho4">매도호가4	int	8</param>
/// <param name="bidho4">매수호가4	int	8</param>
/// <param name="offerrem4">매도호가수량4	long	12</param>
/// <param name="bidrem4">매수호가수량4	long	12</param>
/// <param name="preoffercha4">직전매도대비수량4	long	12</param>
/// <param name="prebidcha4">직전매수대비수량4	long	12</param>
/// <param name="offerho5">매도호가5	int	8</param>
/// <param name="bidho5">매수호가5	int	8</param>
/// <param name="offerrem5">매도호가수량5	long	12</param>
/// <param name="bidrem5">매수호가수량5	long	12</param>
/// <param name="preoffercha5">직전매도대비수량5	long	12</param>
/// <param name="prebidcha5">직전매수대비수량5	long	12</param>
/// <param name="offerho6">매도호가6	int	8</param>
/// <param name="bidho6">매수호가6	int	8</param>
/// <param name="offerrem6">매도호가수량6	long	12</param>
/// <param name="bidrem6">매수호가수량6	long	12</param>
/// <param name="preoffercha6">직전매도대비수량6	long	12</param>
/// <param name="prebidcha6">직전매수대비수량6	long	12</param>
/// <param name="offerho7">매도호가7	int	8</param>
/// <param name="bidho7">매수호가7	int	8</param>
/// <param name="offerrem7">매도호가수량7	long	12</param>
/// <param name="bidrem7">매수호가수량7	long	12</param>
/// <param name="preoffercha7">직전매도대비수량7	long	12</param>
/// <param name="prebidcha7">직전매수대비수량7	long	12</param>
/// <param name="offerho8">매도호가8	int	8</param>
/// <param name="bidho8">매수호가8	int	8</param>
/// <param name="offerrem8">매도호가수량8	long	12</param>
/// <param name="bidrem8">매수호가수량8	long	12</param>
/// <param name="preoffercha8">직전매도대비수량8	long	12</param>
/// <param name="prebidcha8">직전매수대비수량8	long	12</param>
/// <param name="offerho9">매도호가9	int	8</param>
/// <param name="bidho9">매수호가9	int	8</param>
/// <param name="offerrem9">매도호가수량9	long	12</param>
/// <param name="bidrem9">매수호가수량9	long	12</param>
/// <param name="preoffercha9">직전매도대비수량9	long	12</param>
/// <param name="prebidcha9">직전매수대비수량9	long	12</param>
/// <param name="offerho10">매도호가10	int	8</param>
/// <param name="bidho10">매수호가10	int	8</param>
/// <param name="offerrem10">매도호가수량10	long	12</param>
/// <param name="bidrem10">매수호가수량10	long	12</param>
/// <param name="preoffercha10">직전매도대비수량10	long	12</param>
/// <param name="prebidcha10">직전매수대비수량10	long	12</param>
/// <param name="offer">매도호가수량합	long	12</param>
/// <param name="bid">매수호가수량합	long	12</param>
/// <param name="preoffercha">직전매도대비수량합	long	12</param>
/// <param name="prebidcha">직전매수대비수량합	long	12</param>
/// <param name="hotime">수신시간	string	8</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	long	12</param>
/// <param name="yesign">예상체결전일구분	string	1</param>
/// <param name="yechange">예상체결전일대비	int	8</param>
/// <param name="yediff">예상체결등락율	double	6.2</param>
/// <param name="tmoffer">시간외매도잔량	long	12</param>
/// <param name="tmbid">시간외매수잔량	long	12</param>
/// <param name="ho_status">동시구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
public record t1906OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("LP매도호가수량1	long	12")] long lp_offerrem1, [Description("LP매수호가수량1	long	12")] long lp_bidrem1, [Description("LP매도호가수량2	long	12")] long lp_offerrem2, [Description("LP매수호가수량2	long	12")] long lp_bidrem2, [Description("LP매도호가수량3	long	12")] long lp_offerrem3, [Description("LP매수호가수량3	long	12")] long lp_bidrem3, [Description("LP매도호가수량4	long	12")] long lp_offerrem4, [Description("LP매수호가수량4	long	12")] long lp_bidrem4, [Description("LP매도호가수량5	long	12")] long lp_offerrem5, [Description("LP매수호가수량5	long	12")] long lp_bidrem5, [Description("LP매도호가수량6	long	12")] long lp_offerrem6, [Description("LP매수호가수량6	long	12")] long lp_bidrem6, [Description("LP매도호가수량7	long	12")] long lp_offerrem7, [Description("LP매수호가수량7	long	12")] long lp_bidrem7, [Description("LP매도호가수량8	long	12")] long lp_offerrem8, [Description("LP매수호가수량8	long	12")] long lp_bidrem8, [Description("LP매도호가수량9	long	12")] long lp_offerrem9, [Description("LP매수호가수량9	long	12")] long lp_bidrem9, [Description("LP매도호가수량10	long	12")] long lp_offerrem10, [Description("LP매수호가수량10	long	12")] long lp_bidrem10, [Description("전일종가	int	8")] int jnilclose, [Description("매도호가1	int	8")] int offerho1, [Description("매수호가1	int	8")] int bidho1, [Description("매도호가수량1	long	12")] long offerrem1, [Description("매수호가수량1	long	12")] long bidrem1, [Description("직전매도대비수량1	long	12")] long preoffercha1, [Description("직전매수대비수량1	long	12")] long prebidcha1, [Description("매도호가2	int	8")] int offerho2, [Description("매수호가2	int	8")] int bidho2, [Description("매도호가수량2	long	12")] long offerrem2, [Description("매수호가수량2	long	12")] long bidrem2, [Description("직전매도대비수량2	long	12")] long preoffercha2, [Description("직전매수대비수량2	long	12")] long prebidcha2, [Description("매도호가3	int	8")] int offerho3, [Description("매수호가3	int	8")] int bidho3, [Description("매도호가수량3	long	12")] long offerrem3, [Description("매수호가수량3	long	12")] long bidrem3, [Description("직전매도대비수량3	long	12")] long preoffercha3, [Description("직전매수대비수량3	long	12")] long prebidcha3, [Description("매도호가4	int	8")] int offerho4, [Description("매수호가4	int	8")] int bidho4, [Description("매도호가수량4	long	12")] long offerrem4, [Description("매수호가수량4	long	12")] long bidrem4, [Description("직전매도대비수량4	long	12")] long preoffercha4, [Description("직전매수대비수량4	long	12")] long prebidcha4, [Description("매도호가5	int	8")] int offerho5, [Description("매수호가5	int	8")] int bidho5, [Description("매도호가수량5	long	12")] long offerrem5, [Description("매수호가수량5	long	12")] long bidrem5, [Description("직전매도대비수량5	long	12")] long preoffercha5, [Description("직전매수대비수량5	long	12")] long prebidcha5, [Description("매도호가6	int	8")] int offerho6, [Description("매수호가6	int	8")] int bidho6, [Description("매도호가수량6	long	12")] long offerrem6, [Description("매수호가수량6	long	12")] long bidrem6, [Description("직전매도대비수량6	long	12")] long preoffercha6, [Description("직전매수대비수량6	long	12")] long prebidcha6, [Description("매도호가7	int	8")] int offerho7, [Description("매수호가7	int	8")] int bidho7, [Description("매도호가수량7	long	12")] long offerrem7, [Description("매수호가수량7	long	12")] long bidrem7, [Description("직전매도대비수량7	long	12")] long preoffercha7, [Description("직전매수대비수량7	long	12")] long prebidcha7, [Description("매도호가8	int	8")] int offerho8, [Description("매수호가8	int	8")] int bidho8, [Description("매도호가수량8	long	12")] long offerrem8, [Description("매수호가수량8	long	12")] long bidrem8, [Description("직전매도대비수량8	long	12")] long preoffercha8, [Description("직전매수대비수량8	long	12")] long prebidcha8, [Description("매도호가9	int	8")] int offerho9, [Description("매수호가9	int	8")] int bidho9, [Description("매도호가수량9	long	12")] long offerrem9, [Description("매수호가수량9	long	12")] long bidrem9, [Description("직전매도대비수량9	long	12")] long preoffercha9, [Description("직전매수대비수량9	long	12")] long prebidcha9, [Description("매도호가10	int	8")] int offerho10, [Description("매수호가10	int	8")] int bidho10, [Description("매도호가수량10	long	12")] long offerrem10, [Description("매수호가수량10	long	12")] long bidrem10, [Description("직전매도대비수량10	long	12")] long preoffercha10, [Description("직전매수대비수량10	long	12")] long prebidcha10, [Description("매도호가수량합	long	12")] long offer, [Description("매수호가수량합	long	12")] long bid, [Description("직전매도대비수량합	long	12")] long preoffercha, [Description("직전매수대비수량합	long	12")] long prebidcha, [Description("수신시간	string	8")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	long	12")] long yevolume, [Description("예상체결전일구분	string	1")] string yesign, [Description("예상체결전일대비	int	8")] int yechange, [Description("예상체결등락율	double	6.2")] double yediff, [Description("시간외매도잔량	long	12")] long tmoffer, [Description("시간외매수잔량	long	12")] long tmbid, [Description("동시구분	string	1")] string ho_status, [Description("단축코드	string	6")] string shcode, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low);


/// <summary>
/// 신용거래동향(t1921): t1921: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">융자대주구분	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1921InBlock([Description("종목코드	string	6")] string shcode, [Description("융자대주구분	string	1")] string gubun, [Description("날짜	string	8")] string date, [Description("IDX	int	4")] int idx);

/// <summary>
/// 신용거래동향(t1921): t1921: OutBlock
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1921OutBlock([Description("CNT	int	4")] int cnt, [Description("날짜	string	8")] string date, [Description("IDX	int	4")] int idx);

/// <summary>
/// 신용거래동향(t1921): t1921: OutBlock1
/// </summary>
/// <param name="mmdate">날짜	string	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="jchange">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="nvolume">신규	int	8</param>
/// <param name="svolume">상환	int	8</param>
/// <param name="jvolume">잔고	int	8</param>
/// <param name="price">금액	int	8</param>
/// <param name="change">대비	int	8</param>
/// <param name="gyrate">공여율	double	6.2</param>
/// <param name="jkrate">잔고율	double	6.2</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1921OutBlock1([Description("날짜	string	8")] string mmdate, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int jchange, [Description("등락율	double	6.2")] double diff, [Description("신규	int	8")] int nvolume, [Description("상환	int	8")] int svolume, [Description("잔고	int	8")] int jvolume, [Description("금액	int	8")] int price, [Description("대비	int	8")] int change, [Description("공여율	double	6.2")] double gyrate, [Description("잔고율	double	6.2")] double jkrate, [Description("종목코드	string	6")] string shcode);


/// <summary>
/// 종목별신용정보(t1926): t1926: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1926InBlock([Description("종목코드	string	6")] string shcode);

/// <summary>
/// 종목별신용정보(t1926): t1926: OutBlock
/// </summary>
/// <param name="ynvolume">융자신규수량	int	8</param>
/// <param name="ysvolume">융자상환수량	int	8</param>
/// <param name="yjvolume">융자잔고수량	int	8</param>
/// <param name="yvchange">융자수량대비	int	8</param>
/// <param name="ygrate">융자공여율	double	9.2</param>
/// <param name="yjrate">융자잔고율	double	9.2</param>
/// <param name="ynprice">융자신규금액	int	8</param>
/// <param name="ysprice">융자상환금액	int	8</param>
/// <param name="yjprice">융자잔고금액	int	8</param>
/// <param name="yachange">융자금액대비	int	8</param>
/// <param name="dnvolume">대주신규수량	int	8</param>
/// <param name="dsvolume">대주상환수량	int	8</param>
/// <param name="djvolume">대주잔고수량	int	8</param>
/// <param name="dvchange">대주수량대비	int	8</param>
/// <param name="dgrate">대주공여율	double	9.2</param>
/// <param name="djrate">대주잔고율	double	9.2</param>
/// <param name="dnprice">대주신규금액	int	8</param>
/// <param name="dsprice">대주상환금액	int	8</param>
/// <param name="djprice">대주잔고금액	int	8</param>
/// <param name="dachange">대주금액대비	int	8</param>
/// <param name="mmdate">결제일	string	8</param>
/// <param name="close">결제일종가	int	8</param>
/// <param name="volume">결제일거래량	long	10</param>
/// <param name="value">결제일거래대금	long	12</param>
/// <param name="pr5days">주가5일증가율	double	9.2</param>
/// <param name="pr20days">주가20일증가율	double	9.2</param>
/// <param name="yj5days">융자5일증가율	double	9.2</param>
/// <param name="yj20days">융자20일증가율	double	9.2</param>
/// <param name="dj5days">대주5일증가율	double	9.2</param>
/// <param name="dj20days">대주20일증가율	double	9.2</param>
public record t1926OutBlock([Description("융자신규수량	int	8")] int ynvolume, [Description("융자상환수량	int	8")] int ysvolume, [Description("융자잔고수량	int	8")] int yjvolume, [Description("융자수량대비	int	8")] int yvchange, [Description("융자공여율	double	9.2")] double ygrate, [Description("융자잔고율	double	9.2")] double yjrate, [Description("융자신규금액	int	8")] int ynprice, [Description("융자상환금액	int	8")] int ysprice, [Description("융자잔고금액	int	8")] int yjprice, [Description("융자금액대비	int	8")] int yachange, [Description("대주신규수량	int	8")] int dnvolume, [Description("대주상환수량	int	8")] int dsvolume, [Description("대주잔고수량	int	8")] int djvolume, [Description("대주수량대비	int	8")] int dvchange, [Description("대주공여율	double	9.2")] double dgrate, [Description("대주잔고율	double	9.2")] double djrate, [Description("대주신규금액	int	8")] int dnprice, [Description("대주상환금액	int	8")] int dsprice, [Description("대주잔고금액	int	8")] int djprice, [Description("대주금액대비	int	8")] int dachange, [Description("결제일	string	8")] string mmdate, [Description("결제일종가	int	8")] int close, [Description("결제일거래량	long	10")] long volume, [Description("결제일거래대금	long	12")] long value, [Description("주가5일증가율	double	9.2")] double pr5days, [Description("주가20일증가율	double	9.2")] double pr20days, [Description("융자5일증가율	double	9.2")] double yj5days, [Description("융자20일증가율	double	9.2")] double yj20days, [Description("대주5일증가율	double	9.2")] double dj5days, [Description("대주20일증가율	double	9.2")] double dj20days);


/// <summary>
/// 공매도일별추이(t1927): t1927: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">일자	string	8</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1927InBlock([Description("종목코드	string	6")] string shcode, [Description("일자	string	8")] string date, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate);

/// <summary>
/// 공매도일별추이(t1927): t1927: OutBlock
/// </summary>
/// <param name="date">일자CTS	string	8</param>
public record t1927OutBlock([Description("일자CTS	string	8")] string date);

/// <summary>
/// 공매도일별추이(t1927): t1927: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="gm_vo">공매도수량	long	12</param>
/// <param name="gm_va">공매도대금	long	12</param>
/// <param name="gm_per">공매도거래비중	double	6.2</param>
/// <param name="gm_avg">평균공매도단가	long	12</param>
/// <param name="gm_vo_sum">누적공매도수량	long	12</param>
/// <param name="gm_vo1">업틱룰적용공매도수량	long	12</param>
/// <param name="gm_va1">업틱룰적용공매도대금	long	12</param>
/// <param name="gm_vo2">업틱룰예외공매도수량	long	12</param>
/// <param name="gm_va2">업틱룰예외공매도대금	long	12</param>
public record t1927OutBlock1([Description("일자	string	8")] string date, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래대금	long	12")] long value, [Description("공매도수량	long	12")] long gm_vo, [Description("공매도대금	long	12")] long gm_va, [Description("공매도거래비중	double	6.2")] double gm_per, [Description("평균공매도단가	long	12")] long gm_avg, [Description("누적공매도수량	long	12")] long gm_vo_sum, [Description("업틱룰적용공매도수량	long	12")] long gm_vo1, [Description("업틱룰적용공매도대금	long	12")] long gm_va1, [Description("업틱룰예외공매도수량	long	12")] long gm_vo2, [Description("업틱룰예외공매도대금	long	12")] long gm_va2);


/// <summary>
/// 종목별대차거래일간추이(t1941): t1941: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1941InBlock([Description("종목코드	string	6")] string shcode, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate);

/// <summary>
/// 종목별대차거래일간추이(t1941): t1941: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="price">종가	int	8</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="upvolume">당일체결	long	12</param>
/// <param name="dnvolume">당일상환	long	12</param>
/// <param name="tovolume">당일잔고	long	12</param>
/// <param name="tovalue">잔고금액	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="tovoldif">대차증감	long	12</param>
public record t1941OutBlock1([Description("일자	string	8")] string date, [Description("종가	int	8")] int price, [Description("대비구분	string	1")] string sign, [Description("대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("당일체결	long	12")] long upvolume, [Description("당일상환	long	12")] long dnvolume, [Description("당일잔고	long	12")] long tovolume, [Description("잔고금액	long	12")] long tovalue, [Description("종목코드	string	6")] string shcode, [Description("대차증감	long	12")] long tovoldif);


/// <summary>
/// ELW현재가(시세)조회(t1950): t1950: InBlock
/// </summary>
/// <param name="shcode">ELW단축코드	string	6</param>
public record t1950InBlock([Description("ELW단축코드	string	6")] string shcode);

/// <summary>
/// ELW현재가(시세)조회(t1950): t1950: OutBlock
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="chetime">체결시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결량	long	10</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="avg">가중평균	int	8</param>
/// <param name="jnilvolume">전일거래량	double	12</param>
/// <param name="jvolume">전일동시간거래량	double	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="volumechg">거래량차	double	12</param>
/// <param name="volumediff">거래량차등락율	double	6.2</param>
/// <param name="open">시가	int	8</param>
/// <param name="odiff">시가등락율	double	6.2</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="hdiff">고가등락율	double	6.2</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="ldiff">저가등락율	double	6.2</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="high52w">52최고가	int	8</param>
/// <param name="high52wdiff">52최고가등락율	double	6.2</param>
/// <param name="high52wdate">52최고가일	string	8</param>
/// <param name="low52w">52최저가	int	8</param>
/// <param name="low52wdiff">52최저가등락율	double	6.2</param>
/// <param name="low52wdate">52최저가일	string	8</param>
/// <param name="exhratio">소진율	double	6.2</param>
/// <param name="listing">상장주식수(천)	double	12</param>
/// <param name="memedan">수량단위	string	5</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="parity">패리티	double	8.2</param>
/// <param name="berate">손익분기	double	8.2</param>
/// <param name="gearing">기어링	double	8.2</param>
/// <param name="elwexec">행사가	double	8.2</param>
/// <param name="issueprice">발행가	int	8</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="capt">자본지지	double	8.2</param>
/// <param name="egearing">e.기어링	double	8.2</param>
/// <param name="premium">프리미엄	double	8.2</param>
/// <param name="spread">스프레드	double	6.2</param>
/// <param name="espread">최대스프레드	double	6.2</param>
/// <param name="theoryprice">이론가	double	10.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="moneyness">상태	string	1</param>
/// <param name="delt">델타	double	8.6</param>
/// <param name="gama">감마	double	8.6</param>
/// <param name="vega">베가	double	13.6</param>
/// <param name="ceta">쎄타	double	13.6</param>
/// <param name="rhox">로	double	13.6</param>
/// <param name="bjandatecnt">잔존일수	int	4</param>
/// <param name="mmsdate">행사개시일	string	8</param>
/// <param name="mmedate">행사종료일	string	8</param>
/// <param name="payday">지급일	string	8</param>
/// <param name="listdate">발행일	string	8</param>
/// <param name="lpmem">LP회원사	string	20</param>
/// <param name="lp_holdvol">LP보유수량	double	12</param>
/// <param name="bcode">기초자산코드	string	6</param>
/// <param name="bgubun">기초자산구분	string	1</param>
/// <param name="bprice">기초자산현재가	int	8</param>
/// <param name="bsign">기초자산전일비구분	string	1</param>
/// <param name="bchange">기초자산전일비	int	8</param>
/// <param name="bdiff">기초자산등락율	double	6.2</param>
/// <param name="bvolume">기초자산거래량	double	12</param>
/// <param name="info1">락구분	string	10</param>
/// <param name="info2">관리/급등구분	string	10</param>
/// <param name="info3">정지/연장구분	string	10</param>
/// <param name="info4">투자/불성실구분	string	12</param>
/// <param name="janginfo">장구분	string	10</param>
/// <param name="basketgb">바스켓구분	string	1</param>
/// <param name="basketcnt">바스켓갯수	int	3</param>
/// <param name="elwtype">ELW권리행사방식	string	2</param>
/// <param name="settletype">ELW결제방법	string	2</param>
/// <param name="lpord">LP사주문가능여부	string	2</param>
/// <param name="elwdetail">권리내용	string	100</param>
/// <param name="valuation">만기평가가격방식	string	100</param>
public record t1950OutBlock([Description("한글명	string	40")] string hname, [Description("체결시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결량	long	10")] long cvolume, [Description("누적거래량	double	12")] double volume, [Description("기준가	int	8")] int recprice, [Description("가중평균	int	8")] int avg, [Description("전일거래량	double	12")] double jnilvolume, [Description("전일동시간거래량	double	12")] double jvolume, [Description("전일종가	int	8")] int jnilclose, [Description("거래량차	double	12")] double volumechg, [Description("거래량차등락율	double	6.2")] double volumediff, [Description("시가	int	8")] int open, [Description("시가등락율	double	6.2")] double odiff, [Description("시가시간	string	6")] string opentime, [Description("고가	int	8")] int high, [Description("고가등락율	double	6.2")] double hdiff, [Description("고가시간	string	6")] string hightime, [Description("저가	int	8")] int low, [Description("저가등락율	double	6.2")] double ldiff, [Description("저가시간	string	6")] string lowtime, [Description("52최고가	int	8")] int high52w, [Description("52최고가등락율	double	6.2")] double high52wdiff, [Description("52최고가일	string	8")] string high52wdate, [Description("52최저가	int	8")] int low52w, [Description("52최저가등락율	double	6.2")] double low52wdiff, [Description("52최저가일	string	8")] string low52wdate, [Description("소진율	double	6.2")] double exhratio, [Description("상장주식수(천)	double	12")] double listing, [Description("수량단위	string	5")] string memedan, [Description("회전율	double	6.2")] double vol, [Description("패리티	double	8.2")] double parity, [Description("손익분기	double	8.2")] double berate, [Description("기어링	double	8.2")] double gearing, [Description("행사가	double	8.2")] double elwexec, [Description("발행가	int	8")] int issueprice, [Description("전환비율	double	12.4")] double convrate, [Description("최종거래일	string	8")] string lastdate, [Description("자본지지	double	8.2")] double capt, [Description("e.기어링	double	8.2")] double egearing, [Description("프리미엄	double	8.2")] double premium, [Description("스프레드	double	6.2")] double spread, [Description("최대스프레드	double	6.2")] double espread, [Description("이론가	double	10.2")] double theoryprice, [Description("내재변동성	double	6.2")] double impv, [Description("상태	string	1")] string moneyness, [Description("델타	double	8.6")] double delt, [Description("감마	double	8.6")] double gama, [Description("베가	double	13.6")] double vega, [Description("쎄타	double	13.6")] double ceta, [Description("로	double	13.6")] double rhox, [Description("잔존일수	int	4")] int bjandatecnt, [Description("행사개시일	string	8")] string mmsdate, [Description("행사종료일	string	8")] string mmedate, [Description("지급일	string	8")] string payday, [Description("발행일	string	8")] string listdate, [Description("LP회원사	string	20")] string lpmem, [Description("LP보유수량	double	12")] double lp_holdvol, [Description("기초자산코드	string	6")] string bcode, [Description("기초자산구분	string	1")] string bgubun, [Description("기초자산현재가	int	8")] int bprice, [Description("기초자산전일비구분	string	1")] string bsign, [Description("기초자산전일비	int	8")] int bchange, [Description("기초자산등락율	double	6.2")] double bdiff, [Description("기초자산거래량	double	12")] double bvolume, [Description("락구분	string	10")] string info1, [Description("관리/급등구분	string	10")] string info2, [Description("정지/연장구분	string	10")] string info3, [Description("투자/불성실구분	string	12")] string info4, [Description("장구분	string	10")] string janginfo, [Description("바스켓구분	string	1")] string basketgb, [Description("바스켓갯수	int	3")] int basketcnt, [Description("ELW권리행사방식	string	2")] string elwtype, [Description("ELW결제방법	string	2")] string settletype, [Description("LP사주문가능여부	string	2")] string lpord, [Description("권리내용	string	100")] string elwdetail, [Description("만기평가가격방식	string	100")] string valuation);

/// <summary>
/// ELW현재가(시세)조회(t1950): t1950: OutBlock1
/// </summary>
/// <param name="bskcode">기초자산코드	string	6</param>
/// <param name="bskbno">기초자산비율	int	3</param>
/// <param name="bskprice">기초자산현재가	int	8</param>
/// <param name="bsksign">기초자산전일비구분	string	1</param>
/// <param name="bskchange">기초자산전일비	int	8</param>
/// <param name="bskdiff">기초자산등락율	double	6.2</param>
/// <param name="bskvolume">기초자산거래량	double	12</param>
/// <param name="bskjnilclose">기초자산전일종가	int	8</param>
public record t1950OutBlock1([Description("기초자산코드	string	6")] string bskcode, [Description("기초자산비율	int	3")] int bskbno, [Description("기초자산현재가	int	8")] int bskprice, [Description("기초자산전일비구분	string	1")] string bsksign, [Description("기초자산전일비	int	8")] int bskchange, [Description("기초자산등락율	double	6.2")] double bskdiff, [Description("기초자산거래량	double	12")] double bskvolume, [Description("기초자산전일종가	int	8")] int bskjnilclose);


/// <summary>
/// ELW시간대별체결조회(t1951): t1951: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1951InBlock([Description("단축코드	string	6")] string shcode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string starttime, [Description("종료시간	string	4")] string endtime, [Description("시간CTS	string	8")] string cts_time);

/// <summary>
/// ELW시간대별체결조회(t1951): t1951: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1951OutBlock([Description("시간CTS	string	8")] string cts_time);

/// <summary>
/// ELW시간대별체결조회(t1951): t1951: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	12</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="mdvolume">매도체결수량	long	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	long	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="revolume">순체결량	long	12</param>
/// <param name="rechecnt">순체결건수	int	8</param>
public record t1951OutBlock1([Description("시간	string	8")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	long	12")] long cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("거래량	long	12")] long volume, [Description("매도체결수량	long	12")] long mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	long	12")] long msvolume, [Description("매수체결건수	int	8")] int mschecnt, [Description("순체결량	long	12")] long revolume, [Description("순체결건수	int	8")] int rechecnt);


/// <summary>
/// ELW일별주가(t1954): t1954: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cnt">건수	int	3</param>
public record t1954InBlock([Description("단축코드	string	6")] string shcode, [Description("날짜	string	8")] string date, [Description("건수	int	3")] int cnt);

/// <summary>
/// ELW일별주가(t1954): t1954: OutBlock
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="bsjgubun">기초자산구분	string	1</param>
/// <param name="bscode">기초자산코드(현물)	string	6</param>
/// <param name="bjcode">기초자산코드(지수)	string	3</param>
public record t1954OutBlock([Description("날짜	string	8")] string date, [Description("기초자산구분	string	1")] string bsjgubun, [Description("기초자산코드(현물)	string	6")] string bscode, [Description("기초자산코드(지수)	string	3")] string bjcode);

/// <summary>
/// ELW일별주가(t1954): t1954: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="bsprice">기초자산(현물)	int	8</param>
/// <param name="bjprice">기초자산(지수)	double	8.2</param>
/// <param name="bsign">전일대비구분	string	1</param>
/// <param name="bschange">전일대비(현물)	int	8</param>
/// <param name="bjchange">전일대비(지수)	double	8.2</param>
/// <param name="bdiff">등락율	double	6.2</param>
/// <param name="bvolume">기초자산거래량	double	12</param>
/// <param name="parity">패리티	double	6.2</param>
/// <param name="egearing">e.기어링	double	6.2</param>
/// <param name="premium">프리미엄	double	6.2</param>
/// <param name="berate">손익분기	double	6.2</param>
/// <param name="capt">자본지지	double	6.2</param>
/// <param name="gearing">기어링	double	6.2</param>
/// <param name="mness">Moneyness	string	1</param>
public record t1954OutBlock1([Description("날짜	string	8")] string date, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	double	12")] double volume, [Description("기초자산(현물)	int	8")] int bsprice, [Description("기초자산(지수)	double	8.2")] double bjprice, [Description("전일대비구분	string	1")] string bsign, [Description("전일대비(현물)	int	8")] int bschange, [Description("전일대비(지수)	double	8.2")] double bjchange, [Description("등락율	double	6.2")] double bdiff, [Description("기초자산거래량	double	12")] double bvolume, [Description("패리티	double	6.2")] double parity, [Description("e.기어링	double	6.2")] double egearing, [Description("프리미엄	double	6.2")] double premium, [Description("손익분기	double	6.2")] double berate, [Description("자본지지	double	6.2")] double capt, [Description("기어링	double	6.2")] double gearing, [Description("Moneyness	string	1")] string mness);


/// <summary>
/// ELW현재가(확정지급액)조회(t1956): t1956: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1956InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW현재가(확정지급액)조회(t1956): t1956: OutBlock
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="chetime">체결시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결량	long	10</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="avg">가중평균	int	8</param>
/// <param name="jnilvolume">전일거래량	double	12</param>
/// <param name="jvolume">전일동시간거래량	double	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="volumechg">거래량차	double	12</param>
/// <param name="volumediff">거래량차등락율	double	6.2</param>
/// <param name="open">시가	int	8</param>
/// <param name="odiff">시가등락율	double	6.2</param>
/// <param name="opentime">시가시간	string	6</param>
/// <param name="high">고가	int	8</param>
/// <param name="hdiff">고가등락율	double	6.2</param>
/// <param name="hightime">고가시간	string	6</param>
/// <param name="low">저가	int	8</param>
/// <param name="ldiff">저가등락율	double	6.2</param>
/// <param name="lowtime">저가시간	string	6</param>
/// <param name="high52w">52최고가	int	8</param>
/// <param name="high52wdiff">52최고가등락율	double	6.2</param>
/// <param name="high52wdate">52최고가일	string	8</param>
/// <param name="low52w">52최저가	int	8</param>
/// <param name="low52wdiff">52최저가등락율	double	6.2</param>
/// <param name="low52wdate">52최저가일	string	8</param>
/// <param name="exhratio">소진율	double	6.2</param>
/// <param name="listing">상장주식수(천)	double	12</param>
/// <param name="memedan">수량단위	string	5</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="parity">패리티	double	8.2</param>
/// <param name="berate">손익분기	double	8.2</param>
/// <param name="gearing">기어링	double	8.2</param>
/// <param name="elwexec">행사가	double	8.2</param>
/// <param name="issueprice">발행가	int	8</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="capt">자본지지	double	8.2</param>
/// <param name="egearing">e.기어링	double	8.2</param>
/// <param name="premium">프리미엄	double	8.2</param>
/// <param name="spread">스프레드	double	6.2</param>
/// <param name="espread">최대스프레드	double	6.2</param>
/// <param name="theoryprice">이론가	double	10.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="moneyness">상태	string	1</param>
/// <param name="delt">델타	double	8.6</param>
/// <param name="gama">감마	double	8.6</param>
/// <param name="vega">베가	double	13.6</param>
/// <param name="ceta">쎄타	double	13.6</param>
/// <param name="rhox">로	double	13.6</param>
/// <param name="bjandatecnt">잔존일수	int	4</param>
/// <param name="mmsdate">행사개시일	string	8</param>
/// <param name="mmedate">행사종료일	string	8</param>
/// <param name="payday">지급일	string	8</param>
/// <param name="listdate">발행일	string	8</param>
/// <param name="lpmem">LP회원사	string	20</param>
/// <param name="lp_holdvol">LP보유수량	double	12</param>
/// <param name="bcode">기초자산코드	string	6</param>
/// <param name="bgubun">기초자산구분	string	1</param>
/// <param name="bprice">기초자산현재가	int	8</param>
/// <param name="bsign">기초자산전일비구분	string	1</param>
/// <param name="bchange">기초자산전일비	int	8</param>
/// <param name="bdiff">기초자산등락율	double	6.2</param>
/// <param name="bvolume">기초자산거래량	double	12</param>
/// <param name="info1">락구분	string	10</param>
/// <param name="info2">관리/급등구분	string	10</param>
/// <param name="info3">정지/연장구분	string	10</param>
/// <param name="info4">투자/불성실구분	string	12</param>
/// <param name="janginfo">장구분	string	10</param>
/// <param name="basketgb">바스켓구분	string	1</param>
/// <param name="basketcnt">바스켓갯수	int	3</param>
/// <param name="elwtype">ELW권리행사방식	string	2</param>
/// <param name="settletype">ELW결제방법	string	2</param>
/// <param name="lpord">LP사주문가능여부	string	2</param>
/// <param name="elwdetail">권리내용	string	100</param>
/// <param name="valuation">만기평가가격방식	string	100</param>
/// <param name="givemoney">확정지급액	double	8.3</param>
public record t1956OutBlock([Description("한글명	string	40")] string hname, [Description("체결시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("체결량	long	10")] long cvolume, [Description("누적거래량	double	12")] double volume, [Description("기준가	int	8")] int recprice, [Description("가중평균	int	8")] int avg, [Description("전일거래량	double	12")] double jnilvolume, [Description("전일동시간거래량	double	12")] double jvolume, [Description("전일종가	int	8")] int jnilclose, [Description("거래량차	double	12")] double volumechg, [Description("거래량차등락율	double	6.2")] double volumediff, [Description("시가	int	8")] int open, [Description("시가등락율	double	6.2")] double odiff, [Description("시가시간	string	6")] string opentime, [Description("고가	int	8")] int high, [Description("고가등락율	double	6.2")] double hdiff, [Description("고가시간	string	6")] string hightime, [Description("저가	int	8")] int low, [Description("저가등락율	double	6.2")] double ldiff, [Description("저가시간	string	6")] string lowtime, [Description("52최고가	int	8")] int high52w, [Description("52최고가등락율	double	6.2")] double high52wdiff, [Description("52최고가일	string	8")] string high52wdate, [Description("52최저가	int	8")] int low52w, [Description("52최저가등락율	double	6.2")] double low52wdiff, [Description("52최저가일	string	8")] string low52wdate, [Description("소진율	double	6.2")] double exhratio, [Description("상장주식수(천)	double	12")] double listing, [Description("수량단위	string	5")] string memedan, [Description("회전율	double	6.2")] double vol, [Description("패리티	double	8.2")] double parity, [Description("손익분기	double	8.2")] double berate, [Description("기어링	double	8.2")] double gearing, [Description("행사가	double	8.2")] double elwexec, [Description("발행가	int	8")] int issueprice, [Description("전환비율	double	12.4")] double convrate, [Description("최종거래일	string	8")] string lastdate, [Description("자본지지	double	8.2")] double capt, [Description("e.기어링	double	8.2")] double egearing, [Description("프리미엄	double	8.2")] double premium, [Description("스프레드	double	6.2")] double spread, [Description("최대스프레드	double	6.2")] double espread, [Description("이론가	double	10.2")] double theoryprice, [Description("내재변동성	double	6.2")] double impv, [Description("상태	string	1")] string moneyness, [Description("델타	double	8.6")] double delt, [Description("감마	double	8.6")] double gama, [Description("베가	double	13.6")] double vega, [Description("쎄타	double	13.6")] double ceta, [Description("로	double	13.6")] double rhox, [Description("잔존일수	int	4")] int bjandatecnt, [Description("행사개시일	string	8")] string mmsdate, [Description("행사종료일	string	8")] string mmedate, [Description("지급일	string	8")] string payday, [Description("발행일	string	8")] string listdate, [Description("LP회원사	string	20")] string lpmem, [Description("LP보유수량	double	12")] double lp_holdvol, [Description("기초자산코드	string	6")] string bcode, [Description("기초자산구분	string	1")] string bgubun, [Description("기초자산현재가	int	8")] int bprice, [Description("기초자산전일비구분	string	1")] string bsign, [Description("기초자산전일비	int	8")] int bchange, [Description("기초자산등락율	double	6.2")] double bdiff, [Description("기초자산거래량	double	12")] double bvolume, [Description("락구분	string	10")] string info1, [Description("관리/급등구분	string	10")] string info2, [Description("정지/연장구분	string	10")] string info3, [Description("투자/불성실구분	string	12")] string info4, [Description("장구분	string	10")] string janginfo, [Description("바스켓구분	string	1")] string basketgb, [Description("바스켓갯수	int	3")] int basketcnt, [Description("ELW권리행사방식	string	2")] string elwtype, [Description("ELW결제방법	string	2")] string settletype, [Description("LP사주문가능여부	string	2")] string lpord, [Description("권리내용	string	100")] string elwdetail, [Description("만기평가가격방식	string	100")] string valuation, [Description("확정지급액	double	8.3")] double givemoney);

/// <summary>
/// ELW현재가(확정지급액)조회(t1956): t1956: OutBlock1
/// </summary>
/// <param name="bskcode">기초자산코드	string	6</param>
/// <param name="bskbno">기초자산비율	int	3</param>
/// <param name="bskprice">기초자산현재가	int	8</param>
/// <param name="bsksign">기초자산전일비구분	string	1</param>
/// <param name="bskchange">기초자산전일비	int	8</param>
/// <param name="bskdiff">기초자산등락율	double	6.2</param>
/// <param name="bskvolume">기초자산거래량	double	12</param>
/// <param name="bskjnilclose">기초자산전일종가	int	8</param>
public record t1956OutBlock1([Description("기초자산코드	string	6")] string bskcode, [Description("기초자산비율	int	3")] int bskbno, [Description("기초자산현재가	int	8")] int bskprice, [Description("기초자산전일비구분	string	1")] string bsksign, [Description("기초자산전일비	int	8")] int bskchange, [Description("기초자산등락율	double	6.2")] double bskdiff, [Description("기초자산거래량	double	12")] double bskvolume, [Description("기초자산전일종가	int	8")] int bskjnilclose);


/// <summary>
/// ELW종목비교(t1958): t1958: InBlock
/// </summary>
/// <param name="shcode1">종목코드1	string	6</param>
/// <param name="shcode2">종목코드2	string	6</param>
public record t1958InBlock([Description("종목코드1	string	6")] string shcode1, [Description("종목코드2	string	6")] string shcode2);

/// <summary>
/// ELW종목비교(t1958): t1958: OutBlock
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="item1">기초자산	string	12</param>
/// <param name="issuernmk">발행사	string	40</param>
/// <param name="elwopt">콜풋구분	string	2</param>
/// <param name="elwtype">행사방식	string	2</param>
/// <param name="settletype">결제방법	string	2</param>
/// <param name="elwexec">행사가	double	8.2</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="listing">발행수량	double	12</param>
/// <param name="mmsdate">행사개시일	string	8</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="nofdays">거래잔존일수	int	4</param>
/// <param name="payday">지급일	string	8</param>
/// <param name="parity">패리티	double	6.2</param>
/// <param name="premium">프리미엄	double	6.2</param>
/// <param name="berate">손익분기	double	6.2</param>
/// <param name="capt">자본지지	double	6.2</param>
/// <param name="gearing">기어링	double	6.2</param>
/// <param name="egearing">e.기어링	double	6.2</param>
/// <param name="price">가격	int	8</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="diff">등락율	double	6.2</param>
public record t1958OutBlock([Description("종목명	string	40")] string hname, [Description("기초자산	string	12")] string item1, [Description("발행사	string	40")] string issuernmk, [Description("콜풋구분	string	2")] string elwopt, [Description("행사방식	string	2")] string elwtype, [Description("결제방법	string	2")] string settletype, [Description("행사가	double	8.2")] double elwexec, [Description("전환비율	double	12.4")] double convrate, [Description("발행수량	double	12")] double listing, [Description("행사개시일	string	8")] string mmsdate, [Description("최종거래일	string	8")] string lastdate, [Description("거래잔존일수	int	4")] int nofdays, [Description("지급일	string	8")] string payday, [Description("패리티	double	6.2")] double parity, [Description("프리미엄	double	6.2")] double premium, [Description("손익분기	double	6.2")] double berate, [Description("자본지지	double	6.2")] double capt, [Description("기어링	double	6.2")] double gearing, [Description("e.기어링	double	6.2")] double egearing, [Description("가격	int	8")] int price, [Description("거래량	double	12")] double volume, [Description("등락율	double	6.2")] double diff);

/// <summary>
/// ELW종목비교(t1958): t1958: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="item1">기초자산	string	12</param>
/// <param name="issuernmk">발행사	string	40</param>
/// <param name="elwopt">콜풋구분	string	2</param>
/// <param name="elwtype">행사방식	string	2</param>
/// <param name="settletype">결제방법	string	2</param>
/// <param name="elwexec">행사가	double	8.2</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="listing">발행수량	double	12</param>
/// <param name="mmsdate">행사개시일	string	8</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="nofdays">거래잔존일수	int	4</param>
/// <param name="payday">지급일	string	8</param>
/// <param name="parity">패리티	double	6.2</param>
/// <param name="premium">프리미엄	double	6.2</param>
/// <param name="berate">손익분기	double	6.2</param>
/// <param name="capt">자본지지	double	6.2</param>
/// <param name="gearing">기어링	double	6.2</param>
/// <param name="egearing">e.기어링	double	6.2</param>
/// <param name="price">가격	int	8</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="diff">등락율	double	6.2</param>
public record t1958OutBlock1([Description("종목명	string	40")] string hname, [Description("기초자산	string	12")] string item1, [Description("발행사	string	40")] string issuernmk, [Description("콜풋구분	string	2")] string elwopt, [Description("행사방식	string	2")] string elwtype, [Description("결제방법	string	2")] string settletype, [Description("행사가	double	8.2")] double elwexec, [Description("전환비율	double	12.4")] double convrate, [Description("발행수량	double	12")] double listing, [Description("행사개시일	string	8")] string mmsdate, [Description("최종거래일	string	8")] string lastdate, [Description("거래잔존일수	int	4")] int nofdays, [Description("지급일	string	8")] string payday, [Description("패리티	double	6.2")] double parity, [Description("프리미엄	double	6.2")] double premium, [Description("손익분기	double	6.2")] double berate, [Description("자본지지	double	6.2")] double capt, [Description("기어링	double	6.2")] double gearing, [Description("e.기어링	double	6.2")] double egearing, [Description("가격	int	8")] int price, [Description("거래량	double	12")] double volume, [Description("등락율	double	6.2")] double diff);

/// <summary>
/// ELW종목비교(t1958): t1958: OutBlock2
/// </summary>
/// <param name="hnamecmp">종목명비교	string	6</param>
/// <param name="item1cmp">기초자산비교	string	6</param>
/// <param name="issuernmkcmp">발행사비교	string	6</param>
/// <param name="elwoptcmp">콜풋구분비교	string	6</param>
/// <param name="elwtypecmp">행사방식비교	string	6</param>
/// <param name="settlecmp">결제방법비교	string	6</param>
/// <param name="elwexeccmp">행사가비교	double	8.2</param>
/// <param name="convcmp">전환비율비교	double	12.4</param>
/// <param name="listingcmp">발행수량비교	double	12</param>
/// <param name="mmsdatecmp">행사개시일비교	string	6</param>
/// <param name="lastdatecmp">최종거래일비교	string	6</param>
/// <param name="nofdayscmp">거래잔존일수비교	string	6</param>
/// <param name="paydaycmp">지급일비교	string	6</param>
/// <param name="paritycmp">패리티비교	double	6.2</param>
/// <param name="premiumcmp">프리미엄비교	double	6.2</param>
/// <param name="beratecmp">손익분기비교	double	6.2</param>
/// <param name="captcmp">자본지지비교	double	6.2</param>
/// <param name="gearingcmp">기어링비교	double	6.2</param>
/// <param name="egearingcmp">e.기어링비교	double	6.2</param>
/// <param name="pricecmp">가격비교	int	8</param>
/// <param name="volumecmp">거래량비교	double	12</param>
/// <param name="diffcmp">등락율비교	double	6.2</param>
public record t1958OutBlock2([Description("종목명비교	string	6")] string hnamecmp, [Description("기초자산비교	string	6")] string item1cmp, [Description("발행사비교	string	6")] string issuernmkcmp, [Description("콜풋구분비교	string	6")] string elwoptcmp, [Description("행사방식비교	string	6")] string elwtypecmp, [Description("결제방법비교	string	6")] string settlecmp, [Description("행사가비교	double	8.2")] double elwexeccmp, [Description("전환비율비교	double	12.4")] double convcmp, [Description("발행수량비교	double	12")] double listingcmp, [Description("행사개시일비교	string	6")] string mmsdatecmp, [Description("최종거래일비교	string	6")] string lastdatecmp, [Description("거래잔존일수비교	string	6")] string nofdayscmp, [Description("지급일비교	string	6")] string paydaycmp, [Description("패리티비교	double	6.2")] double paritycmp, [Description("프리미엄비교	double	6.2")] double premiumcmp, [Description("손익분기비교	double	6.2")] double beratecmp, [Description("자본지지비교	double	6.2")] double captcmp, [Description("기어링비교	double	6.2")] double gearingcmp, [Description("e.기어링비교	double	6.2")] double egearingcmp, [Description("가격비교	int	8")] int pricecmp, [Description("거래량비교	double	12")] double volumecmp, [Description("등락율비교	double	6.2")] double diffcmp);


/// <summary>
/// LP대상종목정보조회(t1959): t1959: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1959InBlock([Description("종목코드	string	6")] string shcode);

/// <summary>
/// LP대상종목정보조회(t1959): t1959: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="price">현재가	string	12</param>
/// <param name="sign">부호	string	1</param>
/// <param name="change">대비	string	12</param>
/// <param name="rate">등락율	double	5.2</param>
/// <param name="volume">누적거래량	string	12</param>
/// <param name="value">누적거래대금	string	12</param>
/// <param name="lp_gb">LP주문가능여부	string	4</param>
/// <param name="lp_mem_nm1">LP회원사명1	string	20</param>
/// <param name="lp_mem_nm2">LP회원사명2	string	20</param>
/// <param name="lp_mem_nm3">LP회원사명3	string	20</param>
/// <param name="lp_mem_nm4">LP회원사명4	string	20</param>
/// <param name="lp_mem_nm5">LP회원사명5	string	20</param>
/// <param name="lp_min_qty">LP최소호가수량	string	10</param>
/// <param name="lp_st_date">LP시작일	string	8</param>
/// <param name="lp_end_date">LP종료일	string	8</param>
/// <param name="lp_spread">LP스프레드	double	5.2</param>
public record t1959OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	40")] string hname, [Description("현재가	string	12")] string price, [Description("부호	string	1")] string sign, [Description("대비	string	12")] string change, [Description("등락율	double	5.2")] double rate, [Description("누적거래량	string	12")] string volume, [Description("누적거래대금	string	12")] string value, [Description("LP주문가능여부	string	4")] string lp_gb, [Description("LP회원사명1	string	20")] string lp_mem_nm1, [Description("LP회원사명2	string	20")] string lp_mem_nm2, [Description("LP회원사명3	string	20")] string lp_mem_nm3, [Description("LP회원사명4	string	20")] string lp_mem_nm4, [Description("LP회원사명5	string	20")] string lp_mem_nm5, [Description("LP최소호가수량	string	10")] string lp_min_qty, [Description("LP시작일	string	8")] string lp_st_date, [Description("LP종료일	string	8")] string lp_end_date, [Description("LP스프레드	double	5.2")] double lp_spread);


/// <summary>
/// ELW등락율상위(t1960): t1960: InBlock
/// </summary>
/// <param name="gubun">상승하락(0:상승1:하락)	string	1</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	string	2</param>
/// <param name="itemcode">기초자산종목	string	12</param>
/// <param name="lastdate">조회만기일	string	8</param>
/// <param name="exgubun">대상제외	string	6</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="sjanday">잔존시작일수	int	8</param>
/// <param name="ejanday">잔존종료일수	int	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1960InBlock([Description("상승하락(0:상승1:하락)	string	1")] string gubun, [Description("권리유형구분(00:EX01:콜02:풋'':전체)	string	2")] string ggubun, [Description("기초자산종목	string	12")] string itemcode, [Description("조회만기일	string	8")] string lastdate, [Description("대상제외	string	6")] string exgubun, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("잔존시작일수	int	8")] int sjanday, [Description("잔존종료일수	int	8")] int ejanday, [Description("IDX	int	4")] int idx);

/// <summary>
/// ELW등락율상위(t1960): t1960: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1960OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// ELW등락율상위(t1960): t1960: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="elwexec">행사가	double	10.2</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="lastdate">만기일	string	8</param>
/// <param name="itemcode">기초자산종목코드	string	12</param>
/// <param name="itemshcode">기초자산단축코드	string	9</param>
/// <param name="itemname">기초자산종목명	string	20</param>
/// <param name="itemprice">기초자산현재가	string	10</param>
/// <param name="itemsign">기초자산대비구분	string	1</param>
/// <param name="itemchange">기초자산전일대비	string	10</param>
/// <param name="itemdiff">기초자산등락율	double	6.2</param>
/// <param name="elwshcode">ELW종목코드	string	6</param>
/// <param name="bepoint">손익분기점	double	12.2</param>
public record t1960OutBlock1([Description("한글명	string	40")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	double	12")] double volume, [Description("행사가	double	10.2")] double elwexec, [Description("전환비율	double	12.4")] double convrate, [Description("만기일	string	8")] string lastdate, [Description("기초자산종목코드	string	12")] string itemcode, [Description("기초자산단축코드	string	9")] string itemshcode, [Description("기초자산종목명	string	20")] string itemname, [Description("기초자산현재가	string	10")] string itemprice, [Description("기초자산대비구분	string	1")] string itemsign, [Description("기초자산전일대비	string	10")] string itemchange, [Description("기초자산등락율	double	6.2")] double itemdiff, [Description("ELW종목코드	string	6")] string elwshcode, [Description("손익분기점	double	12.2")] double bepoint);


/// <summary>
/// ELW거래량상위(t1961): t1961: InBlock
/// </summary>
/// <param name="gubun">당일전일(0:당일1:전일)	string	1</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	string	2</param>
/// <param name="itemcode">기초자산종목	string	12</param>
/// <param name="lastdate">조회만기일	string	8</param>
/// <param name="exgubun">대상제외	string	6</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="sjanday">잔존시작일수	int	8</param>
/// <param name="ejanday">잔존종료일수	int	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1961InBlock([Description("당일전일(0:당일1:전일)	string	1")] string gubun, [Description("권리유형구분(00:EX01:콜02:풋'':전체)	string	2")] string ggubun, [Description("기초자산종목	string	12")] string itemcode, [Description("조회만기일	string	8")] string lastdate, [Description("대상제외	string	6")] string exgubun, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("잔존시작일수	int	8")] int sjanday, [Description("잔존종료일수	int	8")] int ejanday, [Description("IDX	int	4")] int idx);

/// <summary>
/// ELW거래량상위(t1961): t1961: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1961OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// ELW거래량상위(t1961): t1961: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="jnilvolume">전일거래량	double	12</param>
/// <param name="elwexec">행사가	double	10.2</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="lastdate">만기일	string	8</param>
/// <param name="itemcode">기초자산종목코드	string	12</param>
/// <param name="itemshcode">기초자산단축코드	string	9</param>
/// <param name="itemname">기초자산종목명	string	20</param>
/// <param name="itemprice">기초자산현재가	string	10</param>
/// <param name="itemsign">기초자산대비구분	string	1</param>
/// <param name="itemchange">기초자산전일대비	string	10</param>
/// <param name="itemdiff">기초자산등락율	double	6.2</param>
/// <param name="elwshcode">ELW종목코드	string	6</param>
public record t1961OutBlock1([Description("한글명	string	40")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	double	12")] double volume, [Description("전일거래량	double	12")] double jnilvolume, [Description("행사가	double	10.2")] double elwexec, [Description("전환비율	double	12.4")] double convrate, [Description("만기일	string	8")] string lastdate, [Description("기초자산종목코드	string	12")] string itemcode, [Description("기초자산단축코드	string	9")] string itemshcode, [Description("기초자산종목명	string	20")] string itemname, [Description("기초자산현재가	string	10")] string itemprice, [Description("기초자산대비구분	string	1")] string itemsign, [Description("기초자산전일대비	string	10")] string itemchange, [Description("기초자산등락율	double	6.2")] double itemdiff, [Description("ELW종목코드	string	6")] string elwshcode);


/// <summary>
/// ELW전광판(t1964): t1964: InBlock
/// </summary>
/// <param name="item">기초자산코드	string	12</param>
/// <param name="issuercd">발행사	string	12</param>
/// <param name="lastmonth">만기월물	string	6</param>
/// <param name="elwopt">콜풋구분	string	1</param>
/// <param name="atmgubun">머니구분	string	1</param>
/// <param name="elwtype">권리행사방식	string	2</param>
/// <param name="settletype">결제방법	string	2</param>
/// <param name="elwexecgubun">행사기초자산구분	string	1</param>
/// <param name="fromrat">시작비율	string	5</param>
/// <param name="torat">종료비율	string	5</param>
/// <param name="volume">거래량	string	12</param>
public record t1964InBlock([Description("기초자산코드	string	12")] string item, [Description("발행사	string	12")] string issuercd, [Description("만기월물	string	6")] string lastmonth, [Description("콜풋구분	string	1")] string elwopt, [Description("머니구분	string	1")] string atmgubun, [Description("권리행사방식	string	2")] string elwtype, [Description("결제방법	string	2")] string settletype, [Description("행사기초자산구분	string	1")] string elwexecgubun, [Description("시작비율	string	5")] string fromrat, [Description("종료비율	string	5")] string torat, [Description("거래량	string	12")] string volume);

/// <summary>
/// ELW전광판(t1964): t1964: OutBlock1
/// </summary>
/// <param name="shcode">ELW코드	string	6</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="item1">기초자산코드	string	6</param>
/// <param name="itemnm">기초자산명	string	20</param>
/// <param name="issuernmk">발행사	string	40</param>
/// <param name="elwopt">콜풋구분	string	4</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="elwexec">행사가	double	10.2</param>
/// <param name="jandatecnt">잔존일수	int	8</param>
/// <param name="convrate">전환비율	double	8.4</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="mmsdate">행사개시일	string	8</param>
/// <param name="payday">지급일	string	8</param>
/// <param name="listing">발행수량	int	8</param>
/// <param name="atmgbnm">머니구분	string	10</param>
/// <param name="parity">패리티	double	6.2</param>
/// <param name="preminum">프리미엄	double	10.2</param>
/// <param name="spread">스프래드	double	3.2</param>
/// <param name="berate">손익분기율	double	6.2</param>
/// <param name="capt">자본지지율	double	6.2</param>
/// <param name="gearing">기어링	double	6.2</param>
/// <param name="egearing">e기어링	double	6.2</param>
/// <param name="itemprice">기초자산현재가	int	8</param>
/// <param name="itemsign">기초자산전일대비구분	string	1</param>
/// <param name="itemchange">기초자산전일대비	int	8</param>
/// <param name="itemdiff">기초자산등락율	double	6.2</param>
/// <param name="itemvolume">기초자산거래량	long	12</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="theoryprice">이론가	double	10.2</param>
/// <param name="lp_rate">LP보유비율	double	5.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="delta">델타	double	10.6</param>
/// <param name="theta">쎄타	double	10.6</param>
public record t1964OutBlock1([Description("ELW코드	string	6")] string shcode, [Description("종목명	string	40")] string hname, [Description("기초자산코드	string	6")] string item1, [Description("기초자산명	string	20")] string itemnm, [Description("발행사	string	40")] string issuernmk, [Description("콜풋구분	string	4")] string elwopt, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("행사가	double	10.2")] double elwexec, [Description("잔존일수	int	8")] int jandatecnt, [Description("전환비율	double	8.4")] double convrate, [Description("최종거래일	string	8")] string lastdate, [Description("행사개시일	string	8")] string mmsdate, [Description("지급일	string	8")] string payday, [Description("발행수량	int	8")] int listing, [Description("머니구분	string	10")] string atmgbnm, [Description("패리티	double	6.2")] double parity, [Description("프리미엄	double	10.2")] double preminum, [Description("스프래드	double	3.2")] double spread, [Description("손익분기율	double	6.2")] double berate, [Description("자본지지율	double	6.2")] double capt, [Description("기어링	double	6.2")] double gearing, [Description("e기어링	double	6.2")] double egearing, [Description("기초자산현재가	int	8")] int itemprice, [Description("기초자산전일대비구분	string	1")] string itemsign, [Description("기초자산전일대비	int	8")] int itemchange, [Description("기초자산등락율	double	6.2")] double itemdiff, [Description("기초자산거래량	long	12")] long itemvolume, [Description("전일거래량	long	12")] long jnilvolume, [Description("이론가	double	10.2")] double theoryprice, [Description("LP보유비율	double	5.2")] double lp_rate, [Description("내재변동성	double	6.2")] double impv, [Description("델타	double	10.6")] double delta, [Description("쎄타	double	10.6")] double theta);


/// <summary>
/// ELW거래대금상위(t1966): t1966: InBlock
/// </summary>
/// <param name="gubun">당일전일(0:당일1:전일)	string	1</param>
/// <param name="ggubun">권리유형구분(00:EX01:콜02:풋'':전체)	string	2</param>
/// <param name="itemcode">기초자산종목	string	12</param>
/// <param name="lastdate">조회만기일	string	8</param>
/// <param name="exgubun">대상제외	string	6</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="sjanday">잔존시작일수	int	8</param>
/// <param name="ejanday">잔존종료일수	int	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1966InBlock([Description("당일전일(0:당일1:전일)	string	1")] string gubun, [Description("권리유형구분(00:EX01:콜02:풋'':전체)	string	2")] string ggubun, [Description("기초자산종목	string	12")] string itemcode, [Description("조회만기일	string	8")] string lastdate, [Description("대상제외	string	6")] string exgubun, [Description("시작가격	int	8")] int sprice, [Description("종료가격	int	8")] int eprice, [Description("거래량	long	12")] long volume, [Description("잔존시작일수	int	8")] int sjanday, [Description("잔존종료일수	int	8")] int ejanday, [Description("IDX	int	4")] int idx);

/// <summary>
/// ELW거래대금상위(t1966): t1966: OutBlock
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1966OutBlock([Description("IDX	int	4")] int idx);

/// <summary>
/// ELW거래대금상위(t1966): t1966: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="value">누적거래대금	double	12</param>
/// <param name="jnilvalue">전일거래대금	double	12</param>
/// <param name="elwexec">행사가	double	10.2</param>
/// <param name="convrate">전환비율	double	12.4</param>
/// <param name="lastdate">만기일	string	8</param>
/// <param name="itemcode">기초자산종목코드	string	12</param>
/// <param name="itemshcode">기초자산단축코드	string	9</param>
/// <param name="itemname">기초자산종목명	string	20</param>
/// <param name="itemprice">기초자산현재가	string	10</param>
/// <param name="itemsign">기초자산대비구분	string	1</param>
/// <param name="itemchange">기초자산전일대비	string	10</param>
/// <param name="itemdiff">기초자산등락율	double	6.2</param>
/// <param name="elwshcode">ELW종목코드	string	6</param>
public record t1966OutBlock1([Description("한글명	string	40")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래대금	double	12")] double value, [Description("전일거래대금	double	12")] double jnilvalue, [Description("행사가	double	10.2")] double elwexec, [Description("전환비율	double	12.4")] double convrate, [Description("만기일	string	8")] string lastdate, [Description("기초자산종목코드	string	12")] string itemcode, [Description("기초자산단축코드	string	9")] string itemshcode, [Description("기초자산종목명	string	20")] string itemname, [Description("기초자산현재가	string	10")] string itemprice, [Description("기초자산대비구분	string	1")] string itemsign, [Description("기초자산전일대비	string	10")] string itemchange, [Description("기초자산등락율	double	6.2")] double itemdiff, [Description("ELW종목코드	string	6")] string elwshcode);


/// <summary>
/// ELW지표검색(t1969): t1969: InBlock
/// </summary>
/// <param name="chkitem">기초자산chk구분	string	1</param>
/// <param name="cbitem">기초자산코드	string	12</param>
/// <param name="chkissuer">발행사chk구분	string	1</param>
/// <param name="cbissuer">발행사	string	12</param>
/// <param name="chkcallput">권리chk구분	string	1</param>
/// <param name="cbcallput">권리(call:01.put:02)	string	2</param>
/// <param name="chkexec">행사가chk구분	string	1</param>
/// <param name="cbexec">행사가(>=:1.<=:2)	string	1</param>
/// <param name="chktype">행사방식chk구분	string	1</param>
/// <param name="cbtype">행사방식	string	2</param>
/// <param name="chksettle">결제방법chk구분	string	1</param>
/// <param name="cbsettle">결제방법	string	2</param>
/// <param name="chklast">만기chk구분	string	1</param>
/// <param name="cblast">만기월별	string	6</param>
/// <param name="chkelwexec">행사가격chk구분	string	1</param>
/// <param name="elwexecs">행사가이상	double	10.2</param>
/// <param name="elwexece">행사가이하	double	10.2</param>
/// <param name="chkvolume">거래량chk구분	string	1</param>
/// <param name="volumes">거래량이상	double	12</param>
/// <param name="volumee">거래량이하	double	12</param>
/// <param name="chkrate">등락율chk구분	string	1</param>
/// <param name="rates">등락율이상	double	6.2</param>
/// <param name="ratee">등락율이하	double	6.2</param>
/// <param name="chkpremium">프리미엄chk구분	string	1</param>
/// <param name="premiums">프리미엄이상	double	6.2</param>
/// <param name="premiume">프리미엄이하	double	6.2</param>
/// <param name="chkparity">패리티chk구분	string	1</param>
/// <param name="paritys">패리티이상	double	6.2</param>
/// <param name="paritye">패리티이하	double	6.2</param>
/// <param name="chkberate">손익분기chk구분	string	1</param>
/// <param name="berates">손익분기이상	double	6.2</param>
/// <param name="beratee">손익분기이하	double	6.2</param>
/// <param name="chkcapt">자본지지chk구분	string	1</param>
/// <param name="capts">자본지지이상	double	6.2</param>
/// <param name="capte">자본지지이하	double	6.2</param>
/// <param name="chkegearing">e.기어링chk구분	string	1</param>
/// <param name="egearings">e.기어링이상	double	6.2</param>
/// <param name="egearinge">e.기어링이하	double	6.2</param>
/// <param name="chkgearing">기어링chk구분	string	1</param>
/// <param name="gearings">기어링이상	double	6.2</param>
/// <param name="gearinge">기어링이하	double	6.2</param>
/// <param name="chkdelta">델타chk구분	string	1</param>
/// <param name="deltas">델타이상	double	10.6</param>
/// <param name="deltae">델타이하	double	10.6</param>
/// <param name="chktheta">쎄타chk구분	string	1</param>
/// <param name="thetas">쎄타이상	double	10.6</param>
/// <param name="thetae">쎄타이하	double	10.6</param>
/// <param name="chkduedate">최종거래일chk구분	string	1</param>
/// <param name="duedates">최종거래일이상	string	8</param>
/// <param name="duedatee">최종거래일이하	string	8</param>
/// <param name="onetickgubun">LP갭1틱	string	1</param>
/// <param name="lp_liquidity">LP유동성공급	string	1</param>
/// <param name="chklp_code">LPchk구분	string	1</param>
/// <param name="lp_code">LP회원사코드	string	3</param>
/// <param name="chkkoba">조기종료chk구분	string	1</param>
/// <param name="cbkoba">조기종료(0:전체1:KOBA2:KOBA제외)	string	1</param>
public record t1969InBlock([Description("기초자산chk구분	string	1")] string chkitem, [Description("기초자산코드	string	12")] string cbitem, [Description("발행사chk구분	string	1")] string chkissuer, [Description("발행사	string	12")] string cbissuer, [Description("권리chk구분	string	1")] string chkcallput, [Description("권리(call:01.put:02)	string	2")] string cbcallput, [Description("행사가chk구분	string	1")] string chkexec, [Description("행사가(>=:1.<=:2)	string	1")] string cbexec, [Description("행사방식chk구분	string	1")] string chktype, [Description("행사방식	string	2")] string cbtype, [Description("결제방법chk구분	string	1")] string chksettle, [Description("결제방법	string	2")] string cbsettle, [Description("만기chk구분	string	1")] string chklast, [Description("만기월별	string	6")] string cblast, [Description("행사가격chk구분	string	1")] string chkelwexec, [Description("행사가이상	double	10.2")] double elwexecs, [Description("행사가이하	double	10.2")] double elwexece, [Description("거래량chk구분	string	1")] string chkvolume, [Description("거래량이상	double	12")] double volumes, [Description("거래량이하	double	12")] double volumee, [Description("등락율chk구분	string	1")] string chkrate, [Description("등락율이상	double	6.2")] double rates, [Description("등락율이하	double	6.2")] double ratee, [Description("프리미엄chk구분	string	1")] string chkpremium, [Description("프리미엄이상	double	6.2")] double premiums, [Description("프리미엄이하	double	6.2")] double premiume, [Description("패리티chk구분	string	1")] string chkparity, [Description("패리티이상	double	6.2")] double paritys, [Description("패리티이하	double	6.2")] double paritye, [Description("손익분기chk구분	string	1")] string chkberate, [Description("손익분기이상	double	6.2")] double berates, [Description("손익분기이하	double	6.2")] double beratee, [Description("자본지지chk구분	string	1")] string chkcapt, [Description("자본지지이상	double	6.2")] double capts, [Description("자본지지이하	double	6.2")] double capte, [Description("e.기어링chk구분	string	1")] string chkegearing, [Description("e.기어링이상	double	6.2")] double egearings, [Description("e.기어링이하	double	6.2")] double egearinge, [Description("기어링chk구분	string	1")] string chkgearing, [Description("기어링이상	double	6.2")] double gearings, [Description("기어링이하	double	6.2")] double gearinge, [Description("델타chk구분	string	1")] string chkdelta, [Description("델타이상	double	10.6")] double deltas, [Description("델타이하	double	10.6")] double deltae, [Description("쎄타chk구분	string	1")] string chktheta, [Description("쎄타이상	double	10.6")] double thetas, [Description("쎄타이하	double	10.6")] double thetae, [Description("최종거래일chk구분	string	1")] string chkduedate, [Description("최종거래일이상	string	8")] string duedates, [Description("최종거래일이하	string	8")] string duedatee, [Description("LP갭1틱	string	1")] string onetickgubun, [Description("LP유동성공급	string	1")] string lp_liquidity, [Description("LPchk구분	string	1")] string chklp_code, [Description("LP회원사코드	string	3")] string lp_code, [Description("조기종료chk구분	string	1")] string chkkoba, [Description("조기종료(0:전체1:KOBA2:KOBA제외)	string	1")] string cbkoba);

/// <summary>
/// ELW지표검색(t1969): t1969: OutBlock
/// </summary>
/// <param name="cnt">종목갯수	int	4</param>
public record t1969OutBlock([Description("종목갯수	int	4")] int cnt);

/// <summary>
/// ELW지표검색(t1969): t1969: OutBlock1
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="issuernmk">발행사	string	40</param>
/// <param name="itemcode">기초자산코드	string	12</param>
/// <param name="cpgubun">콜/풋구분	string	2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="jnilvolume">전일거래량	double	12</param>
/// <param name="elwexec">행사가	double	10.2</param>
/// <param name="item">기초자산명	string	20</param>
/// <param name="bprice">기초자산가	double	10.2</param>
/// <param name="bsign">기초전일대비구분	string	1</param>
/// <param name="bchange">기초전일대비	double	10.2</param>
/// <param name="bdiff">기초등락율	double	6.2</param>
/// <param name="premium">프리미엄	double	6.2</param>
/// <param name="parity">패리티	double	6.2</param>
/// <param name="berate">손익분기	double	6.2</param>
/// <param name="capt">자본지지	double	6.2</param>
/// <param name="egearing">e.기어링	double	6.2</param>
/// <param name="gearing">기어링	double	6.2</param>
/// <param name="lastdate">최종거래일	string	8</param>
/// <param name="delta">델타	double	10.6</param>
/// <param name="theta">쎄타	double	10.6</param>
/// <param name="lpname">LP회원사	string	40</param>
/// <param name="lphold">LP보유율	double	6.2</param>
/// <param name="bjandatecnt">잔존일수	int	4</param>
/// <param name="convrate">전환비율	double	8.4</param>
/// <param name="tickvalue">1틱환산	double	10.2</param>
/// <param name="kasis">괴리율	double	6.2</param>
public record t1969OutBlock1([Description("종목명	string	40")] string hname, [Description("종목코드	string	6")] string shcode, [Description("발행사	string	40")] string issuernmk, [Description("기초자산코드	string	12")] string itemcode, [Description("콜/풋구분	string	2")] string cpgubun, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	double	12")] double volume, [Description("전일거래량	double	12")] double jnilvolume, [Description("행사가	double	10.2")] double elwexec, [Description("기초자산명	string	20")] string item, [Description("기초자산가	double	10.2")] double bprice, [Description("기초전일대비구분	string	1")] string bsign, [Description("기초전일대비	double	10.2")] double bchange, [Description("기초등락율	double	6.2")] double bdiff, [Description("프리미엄	double	6.2")] double premium, [Description("패리티	double	6.2")] double parity, [Description("손익분기	double	6.2")] double berate, [Description("자본지지	double	6.2")] double capt, [Description("e.기어링	double	6.2")] double egearing, [Description("기어링	double	6.2")] double gearing, [Description("최종거래일	string	8")] string lastdate, [Description("델타	double	10.6")] double delta, [Description("쎄타	double	10.6")] double theta, [Description("LP회원사	string	40")] string lpname, [Description("LP보유율	double	6.2")] double lphold, [Description("잔존일수	int	4")] int bjandatecnt, [Description("전환비율	double	8.4")] double convrate, [Description("1틱환산	double	10.2")] double tickvalue, [Description("괴리율	double	6.2")] double kasis);


/// <summary>
/// ELW현재가호가조회(t1971): t1971: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1971InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW현재가호가조회(t1971): t1971: OutBlock
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="offerho1">매도호가1	int	8</param>
/// <param name="bidho1">매수호가1	int	8</param>
/// <param name="offerrem1">매도호가수량1	long	12</param>
/// <param name="lp_offerrem1">LP매도호가수량1	long	12</param>
/// <param name="bidrem1">매수호가수량1	long	12</param>
/// <param name="lp_bidrem1">LP매수호가수량1	long	12</param>
/// <param name="preoffercha1">직전매도대비수량1	long	12</param>
/// <param name="prebidcha1">직전매수대비수량1	long	12</param>
/// <param name="offerho2">매도호가2	int	8</param>
/// <param name="bidho2">매수호가2	int	8</param>
/// <param name="offerrem2">매도호가수량2	long	12</param>
/// <param name="lp_offerrem2">LP매도호가수량2	long	12</param>
/// <param name="bidrem2">매수호가수량2	long	12</param>
/// <param name="lp_bidrem2">LP매수호가수량2	long	12</param>
/// <param name="preoffercha2">직전매도대비수량2	long	12</param>
/// <param name="prebidcha2">직전매수대비수량2	long	12</param>
/// <param name="offerho3">매도호가3	int	8</param>
/// <param name="bidho3">매수호가3	int	8</param>
/// <param name="offerrem3">매도호가수량3	long	12</param>
/// <param name="lp_offerrem3">LP매도호가수량3	long	12</param>
/// <param name="bidrem3">매수호가수량3	long	12</param>
/// <param name="lp_bidrem3">LP매수호가수량3	long	12</param>
/// <param name="preoffercha3">직전매도대비수량3	long	12</param>
/// <param name="prebidcha3">직전매수대비수량3	long	12</param>
/// <param name="offerho4">매도호가4	int	8</param>
/// <param name="bidho4">매수호가4	int	8</param>
/// <param name="offerrem4">매도호가수량4	long	12</param>
/// <param name="lp_offerrem4">LP매도호가수량4	long	12</param>
/// <param name="bidrem4">매수호가수량4	long	12</param>
/// <param name="lp_bidrem4">LP매수호가수량4	long	12</param>
/// <param name="preoffercha4">직전매도대비수량4	long	12</param>
/// <param name="prebidcha4">직전매수대비수량4	long	12</param>
/// <param name="offerho5">매도호가5	int	8</param>
/// <param name="bidho5">매수호가5	int	8</param>
/// <param name="offerrem5">매도호가수량5	long	12</param>
/// <param name="lp_offerrem5">LP매도호가수량5	long	12</param>
/// <param name="bidrem5">매수호가수량5	long	12</param>
/// <param name="lp_bidrem5">LP매수호가수량5	long	12</param>
/// <param name="preoffercha5">직전매도대비수량5	long	12</param>
/// <param name="prebidcha5">직전매수대비수량5	long	12</param>
/// <param name="offerho6">매도호가6	int	8</param>
/// <param name="bidho6">매수호가6	int	8</param>
/// <param name="offerrem6">매도호가수량6	long	12</param>
/// <param name="lp_offerrem6">LP매도호가수량6	long	12</param>
/// <param name="bidrem6">매수호가수량6	long	12</param>
/// <param name="lp_bidrem6">LP매수호가수량6	long	12</param>
/// <param name="preoffercha6">직전매도대비수량6	long	12</param>
/// <param name="prebidcha6">직전매수대비수량6	long	12</param>
/// <param name="offerho7">매도호가7	int	8</param>
/// <param name="bidho7">매수호가7	int	8</param>
/// <param name="offerrem7">매도호가수량7	long	12</param>
/// <param name="lp_offerrem7">LP매도호가수량7	long	12</param>
/// <param name="bidrem7">매수호가수량7	long	12</param>
/// <param name="lp_bidrem7">LP매수호가수량7	long	12</param>
/// <param name="preoffercha7">직전매도대비수량7	long	12</param>
/// <param name="prebidcha7">직전매수대비수량7	long	12</param>
/// <param name="offerho8">매도호가8	int	8</param>
/// <param name="bidho8">매수호가8	int	8</param>
/// <param name="offerrem8">매도호가수량8	long	12</param>
/// <param name="lp_offerrem8">LP매도호가수량8	long	12</param>
/// <param name="bidrem8">매수호가수량8	long	12</param>
/// <param name="lp_bidrem8">LP매수호가수량8	long	12</param>
/// <param name="preoffercha8">직전매도대비수량8	long	12</param>
/// <param name="prebidcha8">직전매수대비수량8	long	12</param>
/// <param name="offerho9">매도호가9	int	8</param>
/// <param name="bidho9">매수호가9	int	8</param>
/// <param name="offerrem9">매도호가수량9	long	12</param>
/// <param name="lp_offerrem9">LP매도호가수량9	long	12</param>
/// <param name="bidrem9">매수호가수량9	long	12</param>
/// <param name="lp_bidrem9">LP매수호가수량9	long	12</param>
/// <param name="preoffercha9">직전매도대비수량9	long	12</param>
/// <param name="prebidcha9">직전매수대비수량9	long	12</param>
/// <param name="offerho10">매도호가10	int	8</param>
/// <param name="bidho10">매수호가10	int	8</param>
/// <param name="offerrem10">매도호가수량10	long	12</param>
/// <param name="lp_offerrem10">LP매도호가수량10	long	12</param>
/// <param name="bidrem10">매수호가수량10	long	12</param>
/// <param name="lp_bidrem10">LP매수호가수량10	long	12</param>
/// <param name="preoffercha10">직전매도대비수량10	long	12</param>
/// <param name="prebidcha10">직전매수대비수량10	long	12</param>
/// <param name="offer">매도호가수량합	long	12</param>
/// <param name="bid">매수호가수량합	long	12</param>
/// <param name="preoffercha">직전매도대비수량합	long	12</param>
/// <param name="prebidcha">직전매수대비수량합	long	12</param>
/// <param name="hotime">수신시간	string	8</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yevolume">예상체결수량	double	12</param>
/// <param name="yesign">예상체결전일구분	string	1</param>
/// <param name="yechange">예상체결전일대비	int	8</param>
/// <param name="yediff">예상체결등락율	double	6.2</param>
/// <param name="tmoffer">시간외매도잔량	long	12</param>
/// <param name="tmbid">시간외매수잔량	long	12</param>
/// <param name="ho_status">동시구분	string	1</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="invidx">ELW권리형태(1:표준2:디지털3:조기종료)	string	1</param>
/// <param name="koba_stdprc">KO베리어	double	12.2</param>
/// <param name="koba_acc_rt">KO접근도	double	12.2</param>
/// <param name="koba_yn">KO발생여부(Y/N)	string	1</param>
public record t1971OutBlock([Description("한글명	string	40")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	double	12")] double volume, [Description("전일종가	int	8")] int jnilclose, [Description("매도호가1	int	8")] int offerho1, [Description("매수호가1	int	8")] int bidho1, [Description("매도호가수량1	long	12")] long offerrem1, [Description("LP매도호가수량1	long	12")] long lp_offerrem1, [Description("매수호가수량1	long	12")] long bidrem1, [Description("LP매수호가수량1	long	12")] long lp_bidrem1, [Description("직전매도대비수량1	long	12")] long preoffercha1, [Description("직전매수대비수량1	long	12")] long prebidcha1, [Description("매도호가2	int	8")] int offerho2, [Description("매수호가2	int	8")] int bidho2, [Description("매도호가수량2	long	12")] long offerrem2, [Description("LP매도호가수량2	long	12")] long lp_offerrem2, [Description("매수호가수량2	long	12")] long bidrem2, [Description("LP매수호가수량2	long	12")] long lp_bidrem2, [Description("직전매도대비수량2	long	12")] long preoffercha2, [Description("직전매수대비수량2	long	12")] long prebidcha2, [Description("매도호가3	int	8")] int offerho3, [Description("매수호가3	int	8")] int bidho3, [Description("매도호가수량3	long	12")] long offerrem3, [Description("LP매도호가수량3	long	12")] long lp_offerrem3, [Description("매수호가수량3	long	12")] long bidrem3, [Description("LP매수호가수량3	long	12")] long lp_bidrem3, [Description("직전매도대비수량3	long	12")] long preoffercha3, [Description("직전매수대비수량3	long	12")] long prebidcha3, [Description("매도호가4	int	8")] int offerho4, [Description("매수호가4	int	8")] int bidho4, [Description("매도호가수량4	long	12")] long offerrem4, [Description("LP매도호가수량4	long	12")] long lp_offerrem4, [Description("매수호가수량4	long	12")] long bidrem4, [Description("LP매수호가수량4	long	12")] long lp_bidrem4, [Description("직전매도대비수량4	long	12")] long preoffercha4, [Description("직전매수대비수량4	long	12")] long prebidcha4, [Description("매도호가5	int	8")] int offerho5, [Description("매수호가5	int	8")] int bidho5, [Description("매도호가수량5	long	12")] long offerrem5, [Description("LP매도호가수량5	long	12")] long lp_offerrem5, [Description("매수호가수량5	long	12")] long bidrem5, [Description("LP매수호가수량5	long	12")] long lp_bidrem5, [Description("직전매도대비수량5	long	12")] long preoffercha5, [Description("직전매수대비수량5	long	12")] long prebidcha5, [Description("매도호가6	int	8")] int offerho6, [Description("매수호가6	int	8")] int bidho6, [Description("매도호가수량6	long	12")] long offerrem6, [Description("LP매도호가수량6	long	12")] long lp_offerrem6, [Description("매수호가수량6	long	12")] long bidrem6, [Description("LP매수호가수량6	long	12")] long lp_bidrem6, [Description("직전매도대비수량6	long	12")] long preoffercha6, [Description("직전매수대비수량6	long	12")] long prebidcha6, [Description("매도호가7	int	8")] int offerho7, [Description("매수호가7	int	8")] int bidho7, [Description("매도호가수량7	long	12")] long offerrem7, [Description("LP매도호가수량7	long	12")] long lp_offerrem7, [Description("매수호가수량7	long	12")] long bidrem7, [Description("LP매수호가수량7	long	12")] long lp_bidrem7, [Description("직전매도대비수량7	long	12")] long preoffercha7, [Description("직전매수대비수량7	long	12")] long prebidcha7, [Description("매도호가8	int	8")] int offerho8, [Description("매수호가8	int	8")] int bidho8, [Description("매도호가수량8	long	12")] long offerrem8, [Description("LP매도호가수량8	long	12")] long lp_offerrem8, [Description("매수호가수량8	long	12")] long bidrem8, [Description("LP매수호가수량8	long	12")] long lp_bidrem8, [Description("직전매도대비수량8	long	12")] long preoffercha8, [Description("직전매수대비수량8	long	12")] long prebidcha8, [Description("매도호가9	int	8")] int offerho9, [Description("매수호가9	int	8")] int bidho9, [Description("매도호가수량9	long	12")] long offerrem9, [Description("LP매도호가수량9	long	12")] long lp_offerrem9, [Description("매수호가수량9	long	12")] long bidrem9, [Description("LP매수호가수량9	long	12")] long lp_bidrem9, [Description("직전매도대비수량9	long	12")] long preoffercha9, [Description("직전매수대비수량9	long	12")] long prebidcha9, [Description("매도호가10	int	8")] int offerho10, [Description("매수호가10	int	8")] int bidho10, [Description("매도호가수량10	long	12")] long offerrem10, [Description("LP매도호가수량10	long	12")] long lp_offerrem10, [Description("매수호가수량10	long	12")] long bidrem10, [Description("LP매수호가수량10	long	12")] long lp_bidrem10, [Description("직전매도대비수량10	long	12")] long preoffercha10, [Description("직전매수대비수량10	long	12")] long prebidcha10, [Description("매도호가수량합	long	12")] long offer, [Description("매수호가수량합	long	12")] long bid, [Description("직전매도대비수량합	long	12")] long preoffercha, [Description("직전매수대비수량합	long	12")] long prebidcha, [Description("수신시간	string	8")] string hotime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결수량	double	12")] double yevolume, [Description("예상체결전일구분	string	1")] string yesign, [Description("예상체결전일대비	int	8")] int yechange, [Description("예상체결등락율	double	6.2")] double yediff, [Description("시간외매도잔량	long	12")] long tmoffer, [Description("시간외매수잔량	long	12")] long tmbid, [Description("동시구분	string	1")] string ho_status, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("ELW권리형태(1:표준2:디지털3:조기종료)	string	1")] string invidx, [Description("KO베리어	double	12.2")] double koba_stdprc, [Description("KO접근도	double	12.2")] double koba_acc_rt, [Description("KO발생여부(Y/N)	string	1")] string koba_yn);


/// <summary>
/// ELW현재가(거래원)조회(t1972): t1972: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1972InBlock([Description("단축코드	string	6")] string shcode);

/// <summary>
/// ELW현재가(거래원)조회(t1972): t1972: OutBlock
/// </summary>
/// <param name="hname">한글명	string	40</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="shcode">단축코드	string	9</param>
/// <param name="offerno1">매도증권사코드1	string	6</param>
/// <param name="bidno1">매수증권사코드1	string	6</param>
/// <param name="dvol1">총매도수량1	long	12</param>
/// <param name="svol1">총매수수량1	long	12</param>
/// <param name="dcha1">매도증감1	long	12</param>
/// <param name="scha1">매수증감1	long	12</param>
/// <param name="ddiff1">매도비율1	double	6.2</param>
/// <param name="sdiff1">매수비율1	double	6.2</param>
/// <param name="offerno2">매도증권사코드2	string	6</param>
/// <param name="bidno2">매수증권사코드2	string	6</param>
/// <param name="dvol2">총매도수량2	long	12</param>
/// <param name="svol2">총매수수량2	long	12</param>
/// <param name="dcha2">매도증감2	long	12</param>
/// <param name="scha2">매수증감2	long	12</param>
/// <param name="ddiff2">매도비율2	double	6.2</param>
/// <param name="sdiff2">매수비율2	double	6.2</param>
/// <param name="offerno3">매도증권사코드3	string	6</param>
/// <param name="bidno3">매수증권사코드3	string	6</param>
/// <param name="dvol3">총매도수량3	long	12</param>
/// <param name="svol3">총매수수량3	long	12</param>
/// <param name="dcha3">매도증감3	long	12</param>
/// <param name="scha3">매수증감3	long	12</param>
/// <param name="ddiff3">매도비율3	double	6.2</param>
/// <param name="sdiff3">매수비율3	double	6.2</param>
/// <param name="offerno4">매도증권사코드4	string	6</param>
/// <param name="bidno4">매수증권사코드4	string	6</param>
/// <param name="dvol4">총매도수량4	long	12</param>
/// <param name="svol4">총매수수량4	long	12</param>
/// <param name="dcha4">매도증감4	long	12</param>
/// <param name="scha4">매수증감4	long	12</param>
/// <param name="ddiff4">매도비율4	double	6.2</param>
/// <param name="sdiff4">매수비율4	double	6.2</param>
/// <param name="offerno5">매도증권사코드5	string	6</param>
/// <param name="bidno5">매수증권사코드5	string	6</param>
/// <param name="dvol5">총매도수량5	long	12</param>
/// <param name="svol5">총매수수량5	long	12</param>
/// <param name="dcha5">매도증감5	long	12</param>
/// <param name="scha5">매수증감5	long	12</param>
/// <param name="ddiff5">매도비율5	double	6.2</param>
/// <param name="sdiff5">매수비율5	double	6.2</param>
/// <param name="fwdvl">외국계매도합계수량	long	12</param>
/// <param name="fwsvl">외국계매수합계수량	long	12</param>
/// <param name="ftradmdcha">외국계매도직전대비	long	12</param>
/// <param name="ftradmscha">외국계매수직전대비	long	12</param>
/// <param name="fwddiff">외국계매도합계비율	double	6.2</param>
/// <param name="fwsdiff">외국계매수합계비율	double	6.2</param>
public record t1972OutBlock([Description("한글명	string	40")] string hname, [Description("표준코드	string	12")] string expcode, [Description("단축코드	string	9")] string shcode, [Description("매도증권사코드1	string	6")] string offerno1, [Description("매수증권사코드1	string	6")] string bidno1, [Description("총매도수량1	long	12")] long dvol1, [Description("총매수수량1	long	12")] long svol1, [Description("매도증감1	long	12")] long dcha1, [Description("매수증감1	long	12")] long scha1, [Description("매도비율1	double	6.2")] double ddiff1, [Description("매수비율1	double	6.2")] double sdiff1, [Description("매도증권사코드2	string	6")] string offerno2, [Description("매수증권사코드2	string	6")] string bidno2, [Description("총매도수량2	long	12")] long dvol2, [Description("총매수수량2	long	12")] long svol2, [Description("매도증감2	long	12")] long dcha2, [Description("매수증감2	long	12")] long scha2, [Description("매도비율2	double	6.2")] double ddiff2, [Description("매수비율2	double	6.2")] double sdiff2, [Description("매도증권사코드3	string	6")] string offerno3, [Description("매수증권사코드3	string	6")] string bidno3, [Description("총매도수량3	long	12")] long dvol3, [Description("총매수수량3	long	12")] long svol3, [Description("매도증감3	long	12")] long dcha3, [Description("매수증감3	long	12")] long scha3, [Description("매도비율3	double	6.2")] double ddiff3, [Description("매수비율3	double	6.2")] double sdiff3, [Description("매도증권사코드4	string	6")] string offerno4, [Description("매수증권사코드4	string	6")] string bidno4, [Description("총매도수량4	long	12")] long dvol4, [Description("총매수수량4	long	12")] long svol4, [Description("매도증감4	long	12")] long dcha4, [Description("매수증감4	long	12")] long scha4, [Description("매도비율4	double	6.2")] double ddiff4, [Description("매수비율4	double	6.2")] double sdiff4, [Description("매도증권사코드5	string	6")] string offerno5, [Description("매수증권사코드5	string	6")] string bidno5, [Description("총매도수량5	long	12")] long dvol5, [Description("총매수수량5	long	12")] long svol5, [Description("매도증감5	long	12")] long dcha5, [Description("매수증감5	long	12")] long scha5, [Description("매도비율5	double	6.2")] double ddiff5, [Description("매수비율5	double	6.2")] double sdiff5, [Description("외국계매도합계수량	long	12")] long fwdvl, [Description("외국계매수합계수량	long	12")] long fwsvl, [Description("외국계매도직전대비	long	12")] long ftradmdcha, [Description("외국계매수직전대비	long	12")] long ftradmscha, [Description("외국계매도합계비율	double	6.2")] double fwddiff, [Description("외국계매수합계비율	double	6.2")] double fwsdiff);


/// <summary>
/// ELW시간대별예상체결조회(t1973): t1973: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1973InBlock([Description("단축코드	string	6")] string shcode, [Description("시간CTS	string	8")] string cts_time);

/// <summary>
/// ELW시간대별예상체결조회(t1973): t1973: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1973OutBlock([Description("시간CTS	string	8")] string cts_time);

/// <summary>
/// ELW시간대별예상체결조회(t1973): t1973: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	8</param>
/// <param name="yeprice">예상체결가격	int	8</param>
/// <param name="yegubun">예상체결구분	string	1</param>
/// <param name="jnilysign">전일종가대비구분	string	1</param>
/// <param name="jnilychange">전일종가대비	int	8</param>
/// <param name="yediff">예상체결등락율	double	6.2</param>
/// <param name="yevolume">예상체결량	long	12</param>
/// <param name="ymdvolume">예상매도체결량	long	12</param>
/// <param name="ymsvolume">예상매수체결량	long	12</param>
public record t1973OutBlock1([Description("시간	string	8")] string chetime, [Description("예상체결가격	int	8")] int yeprice, [Description("예상체결구분	string	1")] string yegubun, [Description("전일종가대비구분	string	1")] string jnilysign, [Description("전일종가대비	int	8")] int jnilychange, [Description("예상체결등락율	double	6.2")] double yediff, [Description("예상체결량	long	12")] long yevolume, [Description("예상매도체결량	long	12")] long ymdvolume, [Description("예상매수체결량	long	12")] long ymsvolume);


/// <summary>
/// ELW기초자산동일종목(t1974): t1974: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1974InBlock([Description("종목코드	string	6")] string shcode);

/// <summary>
/// ELW기초자산동일종목(t1974): t1974: OutBlock
/// </summary>
/// <param name="cnt">종목갯수	int	4</param>
public record t1974OutBlock([Description("종목갯수	int	4")] int cnt);

/// <summary>
/// ELW기초자산동일종목(t1974): t1974: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="cpgubun">콜/풋구분	string	2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
public record t1974OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	40")] string hname, [Description("콜/풋구분	string	2")] string cpgubun, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	double	12")] double volume);


/// <summary>
/// 기초자산리스트조회(t1988): t1988: InBlock
/// </summary>
/// <param name="mkt_gb">시장구분(0:전체1:코스피2:코스닥)	string	1</param>
/// <param name="chk_price">가격설정(0:전체1:조건설정)	string	1</param>
/// <param name="from_price">가격1	string	12</param>
/// <param name="to_price">가격2	string	12</param>
/// <param name="chk_vol">거래량설정(0:전체1:조건설정)	string	1</param>
/// <param name="from_vol">거래량1	string	12</param>
/// <param name="to_vol">거래량2	string	12</param>
/// <param name="chk_rate">등락율설정(0:전체1:조건설정)	string	1</param>
/// <param name="from_rate">등락율1	double	5.2</param>
/// <param name="to_rate">등락율2	double	5.2</param>
/// <param name="chk_amt">거래대금설정(0:전체1:조건설정)	string	1</param>
/// <param name="from_amt">거래대금1	string	12</param>
/// <param name="to_amt">거래대금2	string	12</param>
/// <param name="chk_up">양봉설정(0:전체1:조건설정)	string	1</param>
/// <param name="chk_down">음봉설정(0:전체1:조건설정)	string	1</param>
public record t1988InBlock([Description("시장구분(0:전체1:코스피2:코스닥)	string	1")] string mkt_gb, [Description("가격설정(0:전체1:조건설정)	string	1")] string chk_price, [Description("가격1	string	12")] string from_price, [Description("가격2	string	12")] string to_price, [Description("거래량설정(0:전체1:조건설정)	string	1")] string chk_vol, [Description("거래량1	string	12")] string from_vol, [Description("거래량2	string	12")] string to_vol, [Description("등락율설정(0:전체1:조건설정)	string	1")] string chk_rate, [Description("등락율1	double	5.2")] double from_rate, [Description("등락율2	double	5.2")] double to_rate, [Description("거래대금설정(0:전체1:조건설정)	string	1")] string chk_amt, [Description("거래대금1	string	12")] string from_amt, [Description("거래대금2	string	12")] string to_amt, [Description("양봉설정(0:전체1:조건설정)	string	1")] string chk_up, [Description("음봉설정(0:전체1:조건설정)	string	1")] string chk_down);

/// <summary>
/// 기초자산리스트조회(t1988): t1988: OutBlock
/// </summary>
/// <param name="ksp_cnt">코스피종목건수	string	4</param>
/// <param name="ksd_cnt">코스닥종목건수	string	4</param>
public record t1988OutBlock([Description("코스피종목건수	string	4")] string ksp_cnt, [Description("코스닥종목건수	string	4")] string ksd_cnt);

/// <summary>
/// 기초자산리스트조회(t1988): t1988: OutBlock1
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	string	12</param>
/// <param name="sign">부호	string	1</param>
/// <param name="change">대비	string	12</param>
/// <param name="rate">등락율	double	5.2</param>
/// <param name="volume">누적거래량(주)	string	12</param>
/// <param name="value">누적거래대금(백만)	string	12</param>
/// <param name="mkt_gb">시장구분	string	1</param>
/// <param name="jvolume">전일동시간대거래량(주)	string	12</param>
public record t1988OutBlock1([Description("단축코드	string	6")] string shcode, [Description("표준코드	string	12")] string expcode, [Description("종목명	string	20")] string hname, [Description("현재가	string	12")] string price, [Description("부호	string	1")] string sign, [Description("대비	string	12")] string change, [Description("등락율	double	5.2")] double rate, [Description("누적거래량(주)	string	12")] string volume, [Description("누적거래대금(백만)	string	12")] string value, [Description("시장구분	string	1")] string mkt_gb, [Description("전일동시간대거래량(주)	string	12")] string jvolume);


/// <summary>
/// 선물/옵션현재가(시세)조회(t2101): t2101: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t2101InBlock([Description("단축코드	string	8")] string focode);

/// <summary>
/// 선물/옵션현재가(시세)조회(t2101): t2101: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="mgjv">미결제량	int	8</param>
/// <param name="mgjvdiff">미결제증감	int	8</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="uplmtprice">상한가	double	6.2</param>
/// <param name="dnlmtprice">하한가	double	6.2</param>
/// <param name="high52w">52최고가	double	6.2</param>
/// <param name="low52w">52최저가	double	6.2</param>
/// <param name="basis">베이시스	double	6.2</param>
/// <param name="recprice">기준가	double	6.2</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="glyl">괴리율	double	6.3</param>
/// <param name="cbhprice">CB상한가	double	6.2</param>
/// <param name="cblprice">CB하한가	double	6.2</param>
/// <param name="lastmonth">만기일	string	8</param>
/// <param name="jandatecnt">잔여일	int	8</param>
/// <param name="pricejisu">종합지수	double	6.2</param>
/// <param name="jisusign">종합지수전일대비구분	string	1</param>
/// <param name="jisuchange">종합지수전일대비	double	6.2</param>
/// <param name="jisudiff">종합지수등락율	double	6.2</param>
/// <param name="kospijisu">KOSPI200지수	double	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	string	1</param>
/// <param name="kospichange">KOSPI200전일대비	double	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	double	6.2</param>
/// <param name="listhprice">상장최고가	double	6.2</param>
/// <param name="listlprice">상장최저가	double	6.2</param>
/// <param name="delt">델타	double	6.4</param>
/// <param name="gama">감마	double	6.4</param>
/// <param name="ceta">세타	double	6.4</param>
/// <param name="vega">베가	double	6.4</param>
/// <param name="rhox">로우	double	6.4</param>
/// <param name="gmprice">근월물현재가	double	6.2</param>
/// <param name="gmsign">근월물전일대비구분	string	1</param>
/// <param name="gmchange">근월물전일대비	double	6.2</param>
/// <param name="gmdiff">근월물등락율	double	6.2</param>
/// <param name="theorypriceg">이론가	double	6.2</param>
/// <param name="histimpv">역사적변동성	double	6.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="sbasis">시장BASIS	double	6.2</param>
/// <param name="ibasis">이론BASIS	double	6.2</param>
/// <param name="gmfutcode">근월물종목코드	string	8</param>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="greeks_time">거래소민감도수신시간	string	6</param>
/// <param name="greeks_confirm">거래소민감도확정여부	string	8</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="yeprice">예상체결가	double	6.2</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilychange">예상체결가전일종가대비	double	6.2</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
/// <param name="alloc_gubun">배분구분(1:배분개시2:배분해제0:미발생)	string	1</param>
/// <param name="bjandatecnt">잔여일(영업일)	int	8</param>
/// <param name="focode">종목코드	string	8</param>
/// <param name="dy_gubun">실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)	string	1</param>
/// <param name="dy_uplmtprice">실시간상한가	double	6.2</param>
/// <param name="dy_dnlmtprice">실시간하한가	double	6.2</param>
/// <param name="updnstep_gubun">가격제한폭확대(0:미확대1:확대2:대상아님)	string	1</param>
/// <param name="upstep">상한적용단계	string	2</param>
/// <param name="dnstep">하한적용단계	string	2</param>
/// <param name="uplmtprice_3rd">3단계상한가	double	6.2</param>
/// <param name="dnlmtprice_3rd">3단계하한가	double	6.2</param>
public record t2101OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("전일종가	double	6.2")] double jnilclose, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래대금	long	12")] long value, [Description("미결제량	int	8")] int mgjv, [Description("미결제증감	int	8")] int mgjvdiff, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("상한가	double	6.2")] double uplmtprice, [Description("하한가	double	6.2")] double dnlmtprice, [Description("52최고가	double	6.2")] double high52w, [Description("52최저가	double	6.2")] double low52w, [Description("베이시스	double	6.2")] double basis, [Description("기준가	double	6.2")] double recprice, [Description("이론가	double	6.2")] double theoryprice, [Description("괴리율	double	6.3")] double glyl, [Description("CB상한가	double	6.2")] double cbhprice, [Description("CB하한가	double	6.2")] double cblprice, [Description("만기일	string	8")] string lastmonth, [Description("잔여일	int	8")] int jandatecnt, [Description("종합지수	double	6.2")] double pricejisu, [Description("종합지수전일대비구분	string	1")] string jisusign, [Description("종합지수전일대비	double	6.2")] double jisuchange, [Description("종합지수등락율	double	6.2")] double jisudiff, [Description("KOSPI200지수	double	6.2")] double kospijisu, [Description("KOSPI200전일대비구분	string	1")] string kospisign, [Description("KOSPI200전일대비	double	6.2")] double kospichange, [Description("KOSPI200등락율	double	6.2")] double kospidiff, [Description("상장최고가	double	6.2")] double listhprice, [Description("상장최저가	double	6.2")] double listlprice, [Description("델타	double	6.4")] double delt, [Description("감마	double	6.4")] double gama, [Description("세타	double	6.4")] double ceta, [Description("베가	double	6.4")] double vega, [Description("로우	double	6.4")] double rhox, [Description("근월물현재가	double	6.2")] double gmprice, [Description("근월물전일대비구분	string	1")] string gmsign, [Description("근월물전일대비	double	6.2")] double gmchange, [Description("근월물등락율	double	6.2")] double gmdiff, [Description("이론가	double	6.2")] double theorypriceg, [Description("역사적변동성	double	6.2")] double histimpv, [Description("내재변동성	double	6.2")] double impv, [Description("시장BASIS	double	6.2")] double sbasis, [Description("이론BASIS	double	6.2")] double ibasis, [Description("근월물종목코드	string	8")] string gmfutcode, [Description("행사가	double	6.2")] double actprice, [Description("거래소민감도수신시간	string	6")] string greeks_time, [Description("거래소민감도확정여부	string	8")] string greeks_confirm, [Description("단일가호가여부	string	1")] string danhochk, [Description("예상체결가	double	6.2")] double yeprice, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	double	6.2")] double jnilychange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate, [Description("배분구분(1:배분개시2:배분해제0:미발생)	string	1")] string alloc_gubun, [Description("잔여일(영업일)	int	8")] int bjandatecnt, [Description("종목코드	string	8")] string focode, [Description("실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)	string	1")] string dy_gubun, [Description("실시간상한가	double	6.2")] double dy_uplmtprice, [Description("실시간하한가	double	6.2")] double dy_dnlmtprice, [Description("가격제한폭확대(0:미확대1:확대2:대상아님)	string	1")] string updnstep_gubun, [Description("상한적용단계	string	2")] string upstep, [Description("하한적용단계	string	2")] string dnstep, [Description("3단계상한가	double	6.2")] double uplmtprice_3rd, [Description("3단계하한가	double	6.2")] double dnlmtprice_3rd);


/// <summary>
/// 선물/옵션현재가호가조회(t2105): t2105: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t2105InBlock([Description("단축코드	string	8")] string shcode);

/// <summary>
/// 선물/옵션현재가호가조회(t2105): t2105: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="offerrem1">매도호가수량1	int	8</param>
/// <param name="bidrem1">매수호가수량1	int	8</param>
/// <param name="dcnt1">매도호가건수1	int	8</param>
/// <param name="scnt1">매수호가건수1	int	8</param>
/// <param name="offerho2">매도호가2	double	6.2</param>
/// <param name="bidho2">매수호가2	double	6.2</param>
/// <param name="offerrem2">매도호가수량2	int	8</param>
/// <param name="bidrem2">매수호가수량2	int	8</param>
/// <param name="dcnt2">매도호가건수2	int	8</param>
/// <param name="scnt2">매수호가건수2	int	8</param>
/// <param name="offerho3">매도호가3	double	6.2</param>
/// <param name="bidho3">매수호가3	double	6.2</param>
/// <param name="offerrem3">매도호가수량3	int	8</param>
/// <param name="bidrem3">매수호가수량3	int	8</param>
/// <param name="dcnt3">매도호가건수3	int	8</param>
/// <param name="scnt3">매수호가건수3	int	8</param>
/// <param name="offerho4">매도호가4	double	6.2</param>
/// <param name="bidho4">매수호가4	double	6.2</param>
/// <param name="offerrem4">매도호가수량4	int	8</param>
/// <param name="bidrem4">매수호가수량4	int	8</param>
/// <param name="dcnt4">매도호가건수4	int	8</param>
/// <param name="scnt4">매수호가건수4	int	8</param>
/// <param name="offerho5">매도호가5	double	6.2</param>
/// <param name="bidho5">매수호가5	double	6.2</param>
/// <param name="offerrem5">매도호가수량5	int	8</param>
/// <param name="bidrem5">매수호가수량5	int	8</param>
/// <param name="dcnt5">매도호가건수5	int	8</param>
/// <param name="scnt5">매수호가건수5	int	8</param>
/// <param name="dvol">매도호가총수량	int	8</param>
/// <param name="svol">매수호가총수량	int	8</param>
/// <param name="toffernum">총매도호가건수	int	8</param>
/// <param name="tbidnum">총매수호가건수	int	8</param>
/// <param name="time">수신시간	string	6</param>
/// <param name="shcode">단축코드	string	8</param>
public record t2105OutBlock([Description("종목명	string	20")] string hname, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래량전일동시간비율	double	6.2")] double stimeqrt, [Description("전일종가	double	6.2")] double jnilclose, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("매도호가수량1	int	8")] int offerrem1, [Description("매수호가수량1	int	8")] int bidrem1, [Description("매도호가건수1	int	8")] int dcnt1, [Description("매수호가건수1	int	8")] int scnt1, [Description("매도호가2	double	6.2")] double offerho2, [Description("매수호가2	double	6.2")] double bidho2, [Description("매도호가수량2	int	8")] int offerrem2, [Description("매수호가수량2	int	8")] int bidrem2, [Description("매도호가건수2	int	8")] int dcnt2, [Description("매수호가건수2	int	8")] int scnt2, [Description("매도호가3	double	6.2")] double offerho3, [Description("매수호가3	double	6.2")] double bidho3, [Description("매도호가수량3	int	8")] int offerrem3, [Description("매수호가수량3	int	8")] int bidrem3, [Description("매도호가건수3	int	8")] int dcnt3, [Description("매수호가건수3	int	8")] int scnt3, [Description("매도호가4	double	6.2")] double offerho4, [Description("매수호가4	double	6.2")] double bidho4, [Description("매도호가수량4	int	8")] int offerrem4, [Description("매수호가수량4	int	8")] int bidrem4, [Description("매도호가건수4	int	8")] int dcnt4, [Description("매수호가건수4	int	8")] int scnt4, [Description("매도호가5	double	6.2")] double offerho5, [Description("매수호가5	double	6.2")] double bidho5, [Description("매도호가수량5	int	8")] int offerrem5, [Description("매수호가수량5	int	8")] int bidrem5, [Description("매도호가건수5	int	8")] int dcnt5, [Description("매수호가건수5	int	8")] int scnt5, [Description("매도호가총수량	int	8")] int dvol, [Description("매수호가총수량	int	8")] int svol, [Description("총매도호가건수	int	8")] int toffernum, [Description("총매수호가건수	int	8")] int tbidnum, [Description("수신시간	string	6")] string time, [Description("단축코드	string	8")] string shcode);


/// <summary>
/// 선물/옵션현재가시세메모(t2106): t2106: InBlock
/// </summary>
/// <param name="code">종목코드	string	8</param>
/// <param name="nrec">건수	string	2</param>
public record t2106InBlock([Description("종목코드	string	8")] string code, [Description("건수	string	2")] string nrec);

/// <summary>
/// 선물/옵션현재가시세메모(t2106): t2106: InBlock1
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="dat1">데이타1	string	1</param>
/// <param name="dat2">데이타2	string	8</param>
public record t2106InBlock1([Description("인덱스	string	1")] string indx, [Description("조건구분	string	1")] string gubn, [Description("데이타1	string	1")] string dat1, [Description("데이타2	string	8")] string dat2);

/// <summary>
/// 선물/옵션현재가시세메모(t2106): t2106: OutBlock
/// </summary>
/// <param name="nrec">출력건수	string	2</param>
public record t2106OutBlock([Description("출력건수	string	2")] string nrec);

/// <summary>
/// 선물/옵션현재가시세메모(t2106): t2106: OutBlock1
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="vals">출력값	string	8</param>
public record t2106OutBlock1([Description("인덱스	string	1")] string indx, [Description("조건구분	string	1")] string gubn, [Description("출력값	string	8")] string vals);


/// <summary>
/// 선물옵션시간대별체결조회(t2201): t2201: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2201InBlock([Description("단축코드	string	8")] string focode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string stime, [Description("종료시간	string	4")] string etime, [Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 선물옵션시간대별체결조회(t2201): t2201: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2201OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 선물옵션시간대별체결조회(t2201): t2201: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="offerho">매도호가	double	6.2</param>
/// <param name="bidho">매수호가	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="jnilopenupdn">미결전일증감	int	8</param>
/// <param name="ibasis">이론BASIS	double	6.2</param>
/// <param name="sbasis">시장BASIS	double	6.2</param>
/// <param name="kasis">괴리율	double	6.2</param>
/// <param name="value">거래대금	double	12</param>
/// <param name="j_openupdn">미결직전증감	int	8</param>
/// <param name="n_msvolume">누적매수체결량	double	12</param>
/// <param name="n_mdvolume">누적매도체결량	double	12</param>
/// <param name="s_msvolume">누적순매수체결량	double	12</param>
/// <param name="n_mschecnt">누적매수체결건수	int	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	int	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	int	8</param>
public record t2201OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("체결수량	int	8")] int cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("매도호가	double	6.2")] double offerho, [Description("매수호가	double	6.2")] double bidho, [Description("거래량	double	12")] double volume, [Description("미결수량	int	8")] int openyak, [Description("미결전일증감	int	8")] int jnilopenupdn, [Description("이론BASIS	double	6.2")] double ibasis, [Description("시장BASIS	double	6.2")] double sbasis, [Description("괴리율	double	6.2")] double kasis, [Description("거래대금	double	12")] double value, [Description("미결직전증감	int	8")] int j_openupdn, [Description("누적매수체결량	double	12")] double n_msvolume, [Description("누적매도체결량	double	12")] double n_mdvolume, [Description("누적순매수체결량	double	12")] double s_msvolume, [Description("누적매수체결건수	int	8")] int n_mschecnt, [Description("누적매도체결건수	int	8")] int n_mdchecnt, [Description("누적순매수체결건수	int	8")] int s_mschecnt);


/// <summary>
/// 기간별주가(t2203): t2203: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t2203InBlock([Description("단축코드	string	8")] string shcode, [Description("선물최근월물	string	1")] string futcheck, [Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("조회요청건수	int	3")] int cnt);

/// <summary>
/// 기간별주가(t2203): t2203: OutBlock
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t2203OutBlock([Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("최근월선물여부	string	1")] string nowfutyn);

/// <summary>
/// 기간별주가(t2203): t2203: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="openyakupdn">미결증감	int	8</param>
/// <param name="value">거래대금	double	12</param>
public record t2203OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("미결수량	int	8")] int openyak, [Description("미결증감	int	8")] int openyakupdn, [Description("거래대금	double	12")] double value);


/// <summary>
/// 선물옵션틱분별체결조회챠트(t2209): t2209: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t2209InBlock([Description("단축코드	string	8")] string focode, [Description("챠트구분	string	1")] string cgubun, [Description("분구분	int	3")] int bgubun, [Description("조회건수	int	3")] int cnt);

/// <summary>
/// 선물옵션틱분별체결조회챠트(t2209): t2209: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="value">거래대금	double	12</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="openupdn">미결증감	int	8</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="s_mschecnt">매수순간체결건수	int	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	int	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	int	8</param>
/// <param name="s_mschevol">매수순간체결량	double	12</param>
/// <param name="s_mdchevol">매도순간체결량	double	12</param>
/// <param name="ss_mschevol">순매수순간체결량	double	12</param>
/// <param name="chdegvol">체결강도(거래량)	double	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	double	8.2</param>
public record t2209OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("거래량	double	12")] double volume, [Description("거래대금	double	12")] double value, [Description("미결수량	int	8")] int openyak, [Description("미결증감	int	8")] int openupdn, [Description("체결수량	int	8")] int cvolume, [Description("매수순간체결건수	int	8")] int s_mschecnt, [Description("매도순간체결건수	int	8")] int s_mdchecnt, [Description("순매수순간체결건수	int	8")] int ss_mschecnt, [Description("매수순간체결량	double	12")] double s_mschevol, [Description("매도순간체결량	double	12")] double s_mdchevol, [Description("순매수순간체결량	double	12")] double ss_mschevol, [Description("체결강도(거래량)	double	8.2")] double chdegvol, [Description("체결강도(건수)	double	8.2")] double chdegcnt);


/// <summary>
/// 선물옵션시간대별체결조회(단일출력용): t2210: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
public record t2210InBlock([Description("단축코드	string	8")] string focode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string stime, [Description("종료시간	string	4")] string etime);

/// <summary>
/// 선물옵션시간대별체결조회(단일출력용): t2210: OutBlock
/// </summary>
/// <param name="mdvolume">매도체결수량	int	8</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	int	8</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
public record t2210OutBlock([Description("매도체결수량	int	8")] int mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	int	8")] int msvolume, [Description("매수체결건수	int	8")] int mschecnt);


/// <summary>
/// 옵션전광판(t2301): t2301: InBlock
/// </summary>
/// <param name="yyyymm">월물	string	6</param>
/// <param name="gubun">미니구분(M:미니G:정규)	string	1</param>
public record t2301InBlock([Description("월물	string	6")] string yyyymm, [Description("미니구분(M:미니G:정규)	string	1")] string gubun);

/// <summary>
/// 옵션전광판(t2301): t2301: OutBlock
/// </summary>
/// <param name="histimpv">역사적변동성	int	4</param>
/// <param name="jandatecnt">옵션잔존일	int	4</param>
/// <param name="cimpv">콜옵션대표IV	double	6.3</param>
/// <param name="pimpv">풋옵션대표IV	double	6.3</param>
/// <param name="gmprice">근월물현재가	double	6.2</param>
/// <param name="gmsign">근월물전일대비구분	string	1</param>
/// <param name="gmchange">근월물전일대비	double	6.2</param>
/// <param name="gmdiff">근월물등락율	double	6.2</param>
/// <param name="gmvolume">근월물거래량	long	12</param>
/// <param name="gmshcode">근월물선물코드	string	8</param>
public record t2301OutBlock([Description("역사적변동성	int	4")] int histimpv, [Description("옵션잔존일	int	4")] int jandatecnt, [Description("콜옵션대표IV	double	6.3")] double cimpv, [Description("풋옵션대표IV	double	6.3")] double pimpv, [Description("근월물현재가	double	6.2")] double gmprice, [Description("근월물전일대비구분	string	1")] string gmsign, [Description("근월물전일대비	double	6.2")] double gmchange, [Description("근월물등락율	double	6.2")] double gmdiff, [Description("근월물거래량	long	12")] long gmvolume, [Description("근월물선물코드	string	8")] string gmshcode);

/// <summary>
/// 옵션전광판(t2301): t2301: OutBlock1
/// </summary>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="optcode">콜옵션코드	string	8</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="iv">IV	double	6.2</param>
/// <param name="mgjv">미결제약정	long	12</param>
/// <param name="mgjvupdn">미결제약정증감	long	12</param>
/// <param name="offerho1">매도호가	double	6.2</param>
/// <param name="bidho1">매수호가	double	6.2</param>
/// <param name="cvolume">체결량	long	12</param>
/// <param name="delt">델타	double	6.4</param>
/// <param name="gama">감마	double	6.4</param>
/// <param name="vega">베가	double	6.4</param>
/// <param name="ceta">쎄타	double	6.4</param>
/// <param name="rhox">로우	double	6.4</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="impv">내재가치	double	6.2</param>
/// <param name="timevl">시간가치	double	6.2</param>
/// <param name="jvolume">잔고수량	long	12</param>
/// <param name="parpl">평가손익	long	12</param>
/// <param name="jngo">청산가능수량	int	6</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="atmgubun">ATM구분	string	1</param>
/// <param name="jisuconv">지수환산	double	6.2</param>
/// <param name="value">거래대금	double	12</param>
public record t2301OutBlock1([Description("행사가	double	6.2")] double actprice, [Description("콜옵션코드	string	8")] string optcode, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("IV	double	6.2")] double iv, [Description("미결제약정	long	12")] long mgjv, [Description("미결제약정증감	long	12")] long mgjvupdn, [Description("매도호가	double	6.2")] double offerho1, [Description("매수호가	double	6.2")] double bidho1, [Description("체결량	long	12")] long cvolume, [Description("델타	double	6.4")] double delt, [Description("감마	double	6.4")] double gama, [Description("베가	double	6.4")] double vega, [Description("쎄타	double	6.4")] double ceta, [Description("로우	double	6.4")] double rhox, [Description("이론가	double	6.2")] double theoryprice, [Description("내재가치	double	6.2")] double impv, [Description("시간가치	double	6.2")] double timevl, [Description("잔고수량	long	12")] long jvolume, [Description("평가손익	long	12")] long parpl, [Description("청산가능수량	int	6")] int jngo, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("ATM구분	string	1")] string atmgubun, [Description("지수환산	double	6.2")] double jisuconv, [Description("거래대금	double	12")] double value);

/// <summary>
/// 옵션전광판(t2301): t2301: OutBlock2
/// </summary>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="optcode">풋옵션코드	string	8</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="iv">IV	double	6.2</param>
/// <param name="mgjv">미결제약정	long	12</param>
/// <param name="mgjvupdn">미결제약정증감	long	12</param>
/// <param name="offerho1">매도호가	double	6.2</param>
/// <param name="bidho1">매수호가	double	6.2</param>
/// <param name="cvolume">체결량	long	12</param>
/// <param name="delt">델타	double	6.4</param>
/// <param name="gama">감마	double	6.4</param>
/// <param name="vega">베가	double	6.4</param>
/// <param name="ceta">쎄타	double	6.4</param>
/// <param name="rhox">로우	double	6.4</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="impv">내재가치	double	6.2</param>
/// <param name="timevl">시간가치	double	6.2</param>
/// <param name="jvolume">잔고수량	long	12</param>
/// <param name="parpl">평가손익	long	12</param>
/// <param name="jngo">청산가능수량	int	6</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="atmgubun">ATM구분	string	1</param>
/// <param name="jisuconv">지수환산	double	6.2</param>
/// <param name="value">거래대금	double	12</param>
public record t2301OutBlock2([Description("행사가	double	6.2")] double actprice, [Description("풋옵션코드	string	8")] string optcode, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("IV	double	6.2")] double iv, [Description("미결제약정	long	12")] long mgjv, [Description("미결제약정증감	long	12")] long mgjvupdn, [Description("매도호가	double	6.2")] double offerho1, [Description("매수호가	double	6.2")] double bidho1, [Description("체결량	long	12")] long cvolume, [Description("델타	double	6.4")] double delt, [Description("감마	double	6.4")] double gama, [Description("베가	double	6.4")] double vega, [Description("쎄타	double	6.4")] double ceta, [Description("로우	double	6.4")] double rhox, [Description("이론가	double	6.2")] double theoryprice, [Description("내재가치	double	6.2")] double impv, [Description("시간가치	double	6.2")] double timevl, [Description("잔고수량	long	12")] long jvolume, [Description("평가손익	long	12")] long parpl, [Description("청산가능수량	int	6")] int jngo, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("ATM구분	string	1")] string atmgubun, [Description("지수환산	double	6.2")] double jisuconv, [Description("거래대금	double	12")] double value);


/// <summary>
/// 선물옵션호가잔량비율챠트(t2405): t2405: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="bgubun">분구분	string	1</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="hgubun">호가구분	string	1</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="cts_time">시간CTS	string	6</param>
public record t2405InBlock([Description("단축코드	string	8")] string focode, [Description("분구분	string	1")] string bgubun, [Description("N분	int	2")] int nmin, [Description("종료시간	string	4")] string etime, [Description("호가구분	string	1")] string hgubun, [Description("조회건수	int	3")] int cnt, [Description("시간CTS	string	6")] string cts_time);

/// <summary>
/// 선물옵션호가잔량비율챠트(t2405): t2405: OutBlock
/// </summary>
/// <param name="mdvolume">매도체결수량	double	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	double	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="cts_time">시간CTS	string	6</param>
public record t2405OutBlock([Description("매도체결수량	double	12")] double mdvolume, [Description("매도체결건수	int	8")] int mdchecnt, [Description("매수체결수량	double	12")] double msvolume, [Description("매수체결건수	int	8")] int mschecnt, [Description("시간CTS	string	6")] string cts_time);

/// <summary>
/// 선물옵션호가잔량비율챠트(t2405): t2405: OutBlock1
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="offerho1">매도1호가	double	6.2</param>
/// <param name="bidho1">매수1호가	double	6.2</param>
/// <param name="offerrem">매도수량	int	8</param>
/// <param name="bidrem">매수수량	int	8</param>
/// <param name="offercnt">매도건수	int	8</param>
/// <param name="bidcnt">매수건수	int	8</param>
/// <param name="c_offerrem">매도증감수량	int	8</param>
/// <param name="c_bidrem">매수증감수량	int	8</param>
/// <param name="c_offercnt">매도증감건수	int	8</param>
/// <param name="c_bidcnt">매수증감건수	int	8</param>
/// <param name="r_bidrem">매수수량비율	double	6.2</param>
/// <param name="r_bidcnt">매수건수비율	double	6.2</param>
/// <param name="r_sign">매수비율구분	string	1</param>
/// <param name="date">일자	string	8</param>
public record t2405OutBlock1([Description("시간	string	6")] string time, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("누적거래량	double	12")] double volume, [Description("체결수량	int	8")] int cvolume, [Description("매도1호가	double	6.2")] double offerho1, [Description("매수1호가	double	6.2")] double bidho1, [Description("매도수량	int	8")] int offerrem, [Description("매수수량	int	8")] int bidrem, [Description("매도건수	int	8")] int offercnt, [Description("매수건수	int	8")] int bidcnt, [Description("매도증감수량	int	8")] int c_offerrem, [Description("매수증감수량	int	8")] int c_bidrem, [Description("매도증감건수	int	8")] int c_offercnt, [Description("매수증감건수	int	8")] int c_bidcnt, [Description("매수수량비율	double	6.2")] double r_bidrem, [Description("매수건수비율	double	6.2")] double r_bidcnt, [Description("매수비율구분	string	1")] string r_sign, [Description("일자	string	8")] string date);


/// <summary>
/// 미결제약정추이(t2421): t2421: InBlock
/// </summary>
/// <param name="focode">종목코드	string	8</param>
/// <param name="bdgubun">분일구분	string	1</param>
/// <param name="nmin">N분	int	3</param>
/// <param name="tcgubun">당일연결구분	string	1</param>
/// <param name="cnt">조회건수	int	4</param>
public record t2421InBlock([Description("종목코드	string	8")] string focode, [Description("분일구분	string	1")] string bdgubun, [Description("N분	int	3")] int nmin, [Description("당일연결구분	string	1")] string tcgubun, [Description("조회건수	int	4")] int cnt);

/// <summary>
/// 미결제약정추이(t2421): t2421: OutBlock
/// </summary>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="volume">누적거래량	double	15</param>
/// <param name="openyak">미결제수량	int	8</param>
public record t2421OutBlock([Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("체결수량	int	8")] int cvolume, [Description("누적거래량	double	15")] double volume, [Description("미결제수량	int	8")] int openyak);

/// <summary>
/// 미결제약정추이(t2421): t2421: OutBlock1
/// </summary>
/// <param name="dt">일자시간	string	14</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="openopenyak">미결제시량	int	8</param>
/// <param name="highopenyak">미결제고량	int	8</param>
/// <param name="lowopenyak">미결제저량	int	8</param>
/// <param name="closeopenyak">미결제종량	int	8</param>
/// <param name="openupdn">미결증감	int	8</param>
public record t2421OutBlock1([Description("일자시간	string	14")] string dt, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("미결제시량	int	8")] int openopenyak, [Description("미결제고량	int	8")] int highopenyak, [Description("미결제저량	int	8")] int lowopenyak, [Description("미결제종량	int	8")] int closeopenyak, [Description("미결증감	int	8")] int openupdn);


/// <summary>
/// 상품선물투자자매매동향(실시간)(t2541): t2541: InBlock
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="market">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">수량구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	4</param>
public record t2541InBlock([Description("상품ID	string	2")] string eitem, [Description("시장구분	string	1")] string market, [Description("업종코드	string	3")] string upcode, [Description("수량구분	string	1")] string gubun1, [Description("전일분구분	string	1")] string gubun2, [Description("CTSTIME	string	8")] string cts_time, [Description("CTSIDX	int	4")] int cts_idx, [Description("조회건수	int	4")] int cnt);

/// <summary>
/// 상품선물투자자매매동향(실시간)(t2541): t2541: OutBlock
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="sgubun">시장구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="tjjcode_08">개인투자자코드	string	4</param>
/// <param name="ms_08">개인매수	long	12</param>
/// <param name="md_08">개인매도	long	12</param>
/// <param name="rate_08">개인증감	long	12</param>
/// <param name="svolume_08">개인순매수	long	12</param>
/// <param name="jjcode_17">외국인투자자코드	string	4</param>
/// <param name="ms_17">외국인매수	long	12</param>
/// <param name="md_17">외국인매도	long	12</param>
/// <param name="rate_17">외국인증감	long	12</param>
/// <param name="svolume_17">외국인순매수	long	12</param>
/// <param name="jjcode_18">기관계투자자코드	string	4</param>
/// <param name="ms_18">기관계매수	long	12</param>
/// <param name="md_18">기관계매도	long	12</param>
/// <param name="rate_18">기관계증감	long	12</param>
/// <param name="svolume_18">기관계순매수	long	12</param>
/// <param name="jjcode_01">증권투자자코드	string	4</param>
/// <param name="ms_01">증권매수	long	12</param>
/// <param name="md_01">증권매도	long	12</param>
/// <param name="rate_01">증권증감	long	12</param>
/// <param name="svolume_01">증권순매수	long	12</param>
/// <param name="jjcode_03">투신투자자코드	string	4</param>
/// <param name="ms_03">투신매수	long	12</param>
/// <param name="md_03">투신매도	long	12</param>
/// <param name="rate_03">투신증감	long	12</param>
/// <param name="svolume_03">투신순매수	long	12</param>
/// <param name="jjcode_04">은행투자자코드	string	4</param>
/// <param name="ms_04">은행매수	long	12</param>
/// <param name="md_04">은행매도	long	12</param>
/// <param name="rate_04">은행증감	long	12</param>
/// <param name="svolume_04">은행순매수	long	12</param>
/// <param name="jjcode_02">보험투자자코드	string	4</param>
/// <param name="ms_02">보험매수	long	12</param>
/// <param name="md_02">보험매도	long	12</param>
/// <param name="rate_02">보험증감	long	12</param>
/// <param name="svolume_02">보험순매수	long	12</param>
/// <param name="jjcode_05">종금투자자코드	string	4</param>
/// <param name="ms_05">종금매수	long	12</param>
/// <param name="md_05">종금매도	long	12</param>
/// <param name="rate_05">종금증감	long	12</param>
/// <param name="svolume_05">종금순매수	long	12</param>
/// <param name="jjcode_06">기금투자자코드	string	4</param>
/// <param name="ms_06">기금매수	long	12</param>
/// <param name="md_06">기금매도	long	12</param>
/// <param name="rate_06">기금증감	long	12</param>
/// <param name="svolume_06">기금순매수	long	12</param>
/// <param name="jjcode_07">기타투자자코드	string	4</param>
/// <param name="ms_07">기타매수	long	12</param>
/// <param name="md_07">기타매도	long	12</param>
/// <param name="rate_07">기타증감	long	12</param>
/// <param name="svolume_07">기타순매수	long	12</param>
/// <param name="jjcode_11">국가투자자코드	string	4</param>
/// <param name="ms_11">국가매수	long	12</param>
/// <param name="md_11">국가매도	long	12</param>
/// <param name="rate_11">국가증감	long	12</param>
/// <param name="svolume_11">국가순매수	long	12</param>
/// <param name="jjcode_00">사모펀드코드	string	4</param>
/// <param name="ms_00">사모펀드매수	long	12</param>
/// <param name="md_00">사모펀드매도	long	12</param>
/// <param name="rate_00">사모펀드증감	long	12</param>
/// <param name="svolume_00">사모펀드순매수	long	12</param>
public record t2541OutBlock([Description("상품ID	string	2")] string eitem, [Description("시장구분	string	1")] string sgubun, [Description("CTSTIME	string	8")] string cts_time, [Description("개인투자자코드	string	4")] string tjjcode_08, [Description("개인매수	long	12")] long ms_08, [Description("개인매도	long	12")] long md_08, [Description("개인증감	long	12")] long rate_08, [Description("개인순매수	long	12")] long svolume_08, [Description("외국인투자자코드	string	4")] string jjcode_17, [Description("외국인매수	long	12")] long ms_17, [Description("외국인매도	long	12")] long md_17, [Description("외국인증감	long	12")] long rate_17, [Description("외국인순매수	long	12")] long svolume_17, [Description("기관계투자자코드	string	4")] string jjcode_18, [Description("기관계매수	long	12")] long ms_18, [Description("기관계매도	long	12")] long md_18, [Description("기관계증감	long	12")] long rate_18, [Description("기관계순매수	long	12")] long svolume_18, [Description("증권투자자코드	string	4")] string jjcode_01, [Description("증권매수	long	12")] long ms_01, [Description("증권매도	long	12")] long md_01, [Description("증권증감	long	12")] long rate_01, [Description("증권순매수	long	12")] long svolume_01, [Description("투신투자자코드	string	4")] string jjcode_03, [Description("투신매수	long	12")] long ms_03, [Description("투신매도	long	12")] long md_03, [Description("투신증감	long	12")] long rate_03, [Description("투신순매수	long	12")] long svolume_03, [Description("은행투자자코드	string	4")] string jjcode_04, [Description("은행매수	long	12")] long ms_04, [Description("은행매도	long	12")] long md_04, [Description("은행증감	long	12")] long rate_04, [Description("은행순매수	long	12")] long svolume_04, [Description("보험투자자코드	string	4")] string jjcode_02, [Description("보험매수	long	12")] long ms_02, [Description("보험매도	long	12")] long md_02, [Description("보험증감	long	12")] long rate_02, [Description("보험순매수	long	12")] long svolume_02, [Description("종금투자자코드	string	4")] string jjcode_05, [Description("종금매수	long	12")] long ms_05, [Description("종금매도	long	12")] long md_05, [Description("종금증감	long	12")] long rate_05, [Description("종금순매수	long	12")] long svolume_05, [Description("기금투자자코드	string	4")] string jjcode_06, [Description("기금매수	long	12")] long ms_06, [Description("기금매도	long	12")] long md_06, [Description("기금증감	long	12")] long rate_06, [Description("기금순매수	long	12")] long svolume_06, [Description("기타투자자코드	string	4")] string jjcode_07, [Description("기타매수	long	12")] long ms_07, [Description("기타매도	long	12")] long md_07, [Description("기타증감	long	12")] long rate_07, [Description("기타순매수	long	12")] long svolume_07, [Description("국가투자자코드	string	4")] string jjcode_11, [Description("국가매수	long	12")] long ms_11, [Description("국가매도	long	12")] long md_11, [Description("국가증감	long	12")] long rate_11, [Description("국가순매수	long	12")] long svolume_11, [Description("사모펀드코드	string	4")] string jjcode_00, [Description("사모펀드매수	long	12")] long ms_00, [Description("사모펀드매도	long	12")] long md_00, [Description("사모펀드증감	long	12")] long rate_00, [Description("사모펀드순매수	long	12")] long svolume_00);

/// <summary>
/// 상품선물투자자매매동향(실시간)(t2541): t2541: OutBlock1
/// </summary>
/// <param name="time">시간	string	8</param>
/// <param name="sv_08">개인순매수	long	12</param>
/// <param name="sv_17">외국인순매수	long	12</param>
/// <param name="sv_18">기관계순매수	long	12</param>
/// <param name="sv_01">증권순매수	long	12</param>
/// <param name="sv_03">투신순매수	long	12</param>
/// <param name="sv_04">은행순매수	long	12</param>
/// <param name="sv_02">보험순매수	long	12</param>
/// <param name="sv_05">종금순매수	long	12</param>
/// <param name="sv_06">기금순매수	long	12</param>
/// <param name="sv_07">기타순매수	long	12</param>
/// <param name="sv_11">국가순매수	long	12</param>
/// <param name="sv_00">사모펀드순매수	long	12</param>
public record t2541OutBlock1([Description("시간	string	8")] string time, [Description("개인순매수	long	12")] long sv_08, [Description("외국인순매수	long	12")] long sv_17, [Description("기관계순매수	long	12")] long sv_18, [Description("증권순매수	long	12")] long sv_01, [Description("투신순매수	long	12")] long sv_03, [Description("은행순매수	long	12")] long sv_04, [Description("보험순매수	long	12")] long sv_02, [Description("종금순매수	long	12")] long sv_05, [Description("기금순매수	long	12")] long sv_06, [Description("기타순매수	long	12")] long sv_07, [Description("국가순매수	long	12")] long sv_11, [Description("사모펀드순매수	long	12")] long sv_00);


/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545: InBlock
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="sgubun">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="bgubun">전일분	string	1</param>
public record t2545InBlock([Description("상품ID	string	2")] string eitem, [Description("시장구분	string	1")] string sgubun, [Description("업종코드	string	3")] string upcode, [Description("N분	int	2")] int nmin, [Description("조회건수	int	3")] int cnt, [Description("전일분	string	1")] string bgubun);

/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545: OutBlock
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="sgubun">시장구분	string	1</param>
/// <param name="indcode">개인투자자코드	string	4</param>
/// <param name="forcode">외국인투자자코드	string	4</param>
/// <param name="syscode">기관계투자자코드	string	4</param>
/// <param name="stocode">증권투자자코드	string	4</param>
/// <param name="invcode">투신투자자코드	string	4</param>
/// <param name="bancode">은행투자자코드	string	4</param>
/// <param name="inscode">보험투자자코드	string	4</param>
/// <param name="fincode">종금투자자코드	string	4</param>
/// <param name="moncode">기금투자자코드	string	4</param>
/// <param name="etccode">기타투자자코드	string	4</param>
/// <param name="natcode">국가투자자코드	string	4</param>
/// <param name="pefcode">사모펀드투자자코드	string	4</param>
/// <param name="jisucd">기준지수코드	string	8</param>
/// <param name="jisunm">기준지수명	string	20</param>
public record t2545OutBlock([Description("상품ID	string	2")] string eitem, [Description("시장구분	string	1")] string sgubun, [Description("개인투자자코드	string	4")] string indcode, [Description("외국인투자자코드	string	4")] string forcode, [Description("기관계투자자코드	string	4")] string syscode, [Description("증권투자자코드	string	4")] string stocode, [Description("투신투자자코드	string	4")] string invcode, [Description("은행투자자코드	string	4")] string bancode, [Description("보험투자자코드	string	4")] string inscode, [Description("종금투자자코드	string	4")] string fincode, [Description("기금투자자코드	string	4")] string moncode, [Description("기타투자자코드	string	4")] string etccode, [Description("국가투자자코드	string	4")] string natcode, [Description("사모펀드투자자코드	string	4")] string pefcode, [Description("기준지수코드	string	8")] string jisucd, [Description("기준지수명	string	20")] string jisunm);

/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="datetime">일자시간	string	14</param>
/// <param name="indmsvol">개인순매수거래량	int	8</param>
/// <param name="indmsamt">개인순매수거래대금	double	12</param>
/// <param name="formsvol">외국인순매수거래량	int	8</param>
/// <param name="formsamt">외국인순매수거래대금	double	12</param>
/// <param name="sysmsvol">기관계순매수거래량	int	8</param>
/// <param name="sysmsamt">기관계순매수거래대금	double	12</param>
/// <param name="stomsvol">증권순매수거래량	int	8</param>
/// <param name="stomsamt">증권순매수거래대금	double	12</param>
/// <param name="invmsvol">투신순매수거래량	int	8</param>
/// <param name="invmsamt">투신순매수거래대금	double	12</param>
/// <param name="banmsvol">은행순매수거래량	int	8</param>
/// <param name="banmsamt">은행순매수거래대금	double	12</param>
/// <param name="insmsvol">보험순매수거래량	int	8</param>
/// <param name="insmsamt">보험순매수거래대금	double	12</param>
/// <param name="finmsvol">종금순매수거래량	int	8</param>
/// <param name="finmsamt">종금순매수거래대금	double	12</param>
/// <param name="monmsvol">기금순매수거래량	int	8</param>
/// <param name="monmsamt">기금순매수거래대금	double	12</param>
/// <param name="etcmsvol">기타순매수거래량	int	8</param>
/// <param name="etcmsamt">기타순매수거래대금	double	12</param>
/// <param name="natmsvol">국가순매수거래량	int	8</param>
/// <param name="natmsamt">국가순매수거래대금	double	12</param>
/// <param name="pefmsvol">사모펀드순매수거래량	int	8</param>
/// <param name="pefmsamt">사모펀드순매수거래대금	double	12</param>
/// <param name="upclose">기준지수	double	6.2</param>
/// <param name="upcvolume">기준체결거래량	int	8</param>
/// <param name="upvolume">기준누적거래량	double	12</param>
/// <param name="upvalue">기준거래대금	double	12</param>
public record t2545OutBlock1([Description("일자	string	8")] string date, [Description("시간	string	6")] string time, [Description("일자시간	string	14")] string datetime, [Description("개인순매수거래량	int	8")] int indmsvol, [Description("개인순매수거래대금	double	12")] double indmsamt, [Description("외국인순매수거래량	int	8")] int formsvol, [Description("외국인순매수거래대금	double	12")] double formsamt, [Description("기관계순매수거래량	int	8")] int sysmsvol, [Description("기관계순매수거래대금	double	12")] double sysmsamt, [Description("증권순매수거래량	int	8")] int stomsvol, [Description("증권순매수거래대금	double	12")] double stomsamt, [Description("투신순매수거래량	int	8")] int invmsvol, [Description("투신순매수거래대금	double	12")] double invmsamt, [Description("은행순매수거래량	int	8")] int banmsvol, [Description("은행순매수거래대금	double	12")] double banmsamt, [Description("보험순매수거래량	int	8")] int insmsvol, [Description("보험순매수거래대금	double	12")] double insmsamt, [Description("종금순매수거래량	int	8")] int finmsvol, [Description("종금순매수거래대금	double	12")] double finmsamt, [Description("기금순매수거래량	int	8")] int monmsvol, [Description("기금순매수거래대금	double	12")] double monmsamt, [Description("기타순매수거래량	int	8")] int etcmsvol, [Description("기타순매수거래대금	double	12")] double etcmsamt, [Description("국가순매수거래량	int	8")] int natmsvol, [Description("국가순매수거래대금	double	12")] double natmsamt, [Description("사모펀드순매수거래량	int	8")] int pefmsvol, [Description("사모펀드순매수거래대금	double	12")] double pefmsamt, [Description("기준지수	double	6.2")] double upclose, [Description("기준체결거래량	int	8")] int upcvolume, [Description("기준누적거래량	double	12")] double upvolume, [Description("기준거래대금	double	12")] double upvalue);


/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회(t2830): t2830: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t2830InBlock([Description("단축코드	string	8")] string focode);

/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회(t2830): t2830: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="recprice">기준가	double	6.2</param>
/// <param name="theoryprice">이론가	double	6.2</param>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="impv">내재가치	double	6.2</param>
/// <param name="timevl">시간가치	double	6.2</param>
/// <param name="kospijisu">KOSPI200지수	double	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	string	1</param>
/// <param name="kospichange">KOSPI200전일대비	double	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	double	6.2</param>
/// <param name="cmeprice">CME야간선물현재가	double	6.2</param>
/// <param name="cmesign">CME야간선물전일대비구분	string	1</param>
/// <param name="cmechange">CME야간선물전일대비	double	6.2</param>
/// <param name="cmediff">CME야간선물등락율	double	6.2</param>
/// <param name="cmefocode">CME야간선물종목코드	string	8</param>
/// <param name="uplmtprice">정규장적용상한가	double	6.2</param>
/// <param name="dnlmtprice">정규장적용하한가	double	6.2</param>
/// <param name="focode">단축코드	string	8</param>
/// <param name="yeprice">예상체결가	double	6.2</param>
/// <param name="ysign">전일대비구분	string	1</param>
/// <param name="ychange">전일대비	double	6.2</param>
/// <param name="ydiff">등락율	double	6.2</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="jnilvolume">전일거래량	long	12</param>
/// <param name="jnilvalue">전일거래대금	long	12</param>
/// <param name="uplmtprice_3rd">정규장3단계상한가	double	6.2</param>
/// <param name="dnlmtprice_3rd">정규장3단계하한가	double	6.2</param>
public record t2830OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("전일종가	double	6.2")] double jnilclose, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래대금	long	12")] long value, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("기준가	double	6.2")] double recprice, [Description("이론가	double	6.2")] double theoryprice, [Description("행사가	double	6.2")] double actprice, [Description("내재가치	double	6.2")] double impv, [Description("시간가치	double	6.2")] double timevl, [Description("KOSPI200지수	double	6.2")] double kospijisu, [Description("KOSPI200전일대비구분	string	1")] string kospisign, [Description("KOSPI200전일대비	double	6.2")] double kospichange, [Description("KOSPI200등락율	double	6.2")] double kospidiff, [Description("CME야간선물현재가	double	6.2")] double cmeprice, [Description("CME야간선물전일대비구분	string	1")] string cmesign, [Description("CME야간선물전일대비	double	6.2")] double cmechange, [Description("CME야간선물등락율	double	6.2")] double cmediff, [Description("CME야간선물종목코드	string	8")] string cmefocode, [Description("정규장적용상한가	double	6.2")] double uplmtprice, [Description("정규장적용하한가	double	6.2")] double dnlmtprice, [Description("단축코드	string	8")] string focode, [Description("예상체결가	double	6.2")] double yeprice, [Description("전일대비구분	string	1")] string ysign, [Description("전일대비	double	6.2")] double ychange, [Description("등락율	double	6.2")] double ydiff, [Description("단일가호가여부	string	1")] string danhochk, [Description("전일거래량	long	12")] long jnilvolume, [Description("전일거래대금	long	12")] long jnilvalue, [Description("정규장3단계상한가	double	6.2")] double uplmtprice_3rd, [Description("정규장3단계하한가	double	6.2")] double dnlmtprice_3rd);


/// <summary>
/// EUREXKOSPI200옵션선물호가조회(t2831): t2831: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t2831InBlock([Description("단축코드	string	8")] string shcode);

/// <summary>
/// EUREXKOSPI200옵션선물호가조회(t2831): t2831: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="offerho1">매도호가1	double	6.2</param>
/// <param name="bidho1">매수호가1	double	6.2</param>
/// <param name="offerrem1">매도호가수량1	int	8</param>
/// <param name="bidrem1">매수호가수량1	int	8</param>
/// <param name="dcnt1">매도호가건수1	int	8</param>
/// <param name="scnt1">매수호가건수1	int	8</param>
/// <param name="offerho2">매도호가2	double	6.2</param>
/// <param name="bidho2">매수호가2	double	6.2</param>
/// <param name="offerrem2">매도호가수량2	int	8</param>
/// <param name="bidrem2">매수호가수량2	int	8</param>
/// <param name="dcnt2">매도호가건수2	int	8</param>
/// <param name="scnt2">매수호가건수2	int	8</param>
/// <param name="offerho3">매도호가3	double	6.2</param>
/// <param name="bidho3">매수호가3	double	6.2</param>
/// <param name="offerrem3">매도호가수량3	int	8</param>
/// <param name="bidrem3">매수호가수량3	int	8</param>
/// <param name="dcnt3">매도호가건수3	int	8</param>
/// <param name="scnt3">매수호가건수3	int	8</param>
/// <param name="offerho4">매도호가4	double	6.2</param>
/// <param name="bidho4">매수호가4	double	6.2</param>
/// <param name="offerrem4">매도호가수량4	int	8</param>
/// <param name="bidrem4">매수호가수량4	int	8</param>
/// <param name="dcnt4">매도호가건수4	int	8</param>
/// <param name="scnt4">매수호가건수4	int	8</param>
/// <param name="offerho5">매도호가5	double	6.2</param>
/// <param name="bidho5">매수호가5	double	6.2</param>
/// <param name="offerrem5">매도호가수량5	int	8</param>
/// <param name="bidrem5">매수호가수량5	int	8</param>
/// <param name="dcnt5">매도호가건수5	int	8</param>
/// <param name="scnt5">매수호가건수5	int	8</param>
/// <param name="dvol">매도호가총수량	int	8</param>
/// <param name="svol">매수호가총수량	int	8</param>
/// <param name="toffernum">총매도호가건수	int	8</param>
/// <param name="tbidnum">총매수호가건수	int	8</param>
/// <param name="time">수신시간	string	6</param>
/// <param name="shcode">단축코드	string	8</param>
public record t2831OutBlock([Description("종목명	string	20")] string hname, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("전일종가	double	6.2")] double jnilclose, [Description("매도호가1	double	6.2")] double offerho1, [Description("매수호가1	double	6.2")] double bidho1, [Description("매도호가수량1	int	8")] int offerrem1, [Description("매수호가수량1	int	8")] int bidrem1, [Description("매도호가건수1	int	8")] int dcnt1, [Description("매수호가건수1	int	8")] int scnt1, [Description("매도호가2	double	6.2")] double offerho2, [Description("매수호가2	double	6.2")] double bidho2, [Description("매도호가수량2	int	8")] int offerrem2, [Description("매수호가수량2	int	8")] int bidrem2, [Description("매도호가건수2	int	8")] int dcnt2, [Description("매수호가건수2	int	8")] int scnt2, [Description("매도호가3	double	6.2")] double offerho3, [Description("매수호가3	double	6.2")] double bidho3, [Description("매도호가수량3	int	8")] int offerrem3, [Description("매수호가수량3	int	8")] int bidrem3, [Description("매도호가건수3	int	8")] int dcnt3, [Description("매수호가건수3	int	8")] int scnt3, [Description("매도호가4	double	6.2")] double offerho4, [Description("매수호가4	double	6.2")] double bidho4, [Description("매도호가수량4	int	8")] int offerrem4, [Description("매수호가수량4	int	8")] int bidrem4, [Description("매도호가건수4	int	8")] int dcnt4, [Description("매수호가건수4	int	8")] int scnt4, [Description("매도호가5	double	6.2")] double offerho5, [Description("매수호가5	double	6.2")] double bidho5, [Description("매도호가수량5	int	8")] int offerrem5, [Description("매수호가수량5	int	8")] int bidrem5, [Description("매도호가건수5	int	8")] int dcnt5, [Description("매수호가건수5	int	8")] int scnt5, [Description("매도호가총수량	int	8")] int dvol, [Description("매수호가총수량	int	8")] int svol, [Description("총매도호가건수	int	8")] int toffernum, [Description("총매수호가건수	int	8")] int tbidnum, [Description("수신시간	string	6")] string time, [Description("단축코드	string	8")] string shcode);


/// <summary>
/// EUREX야간옵션선물시간대별체결조회(t2832): t2832: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2832InBlock([Description("단축코드	string	8")] string focode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string stime, [Description("종료시간	string	4")] string etime, [Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// EUREX야간옵션선물시간대별체결조회(t2832): t2832: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2832OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// EUREX야간옵션선물시간대별체결조회(t2832): t2832: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="offerho">매도호가	double	6.2</param>
/// <param name="bidho">매수호가	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="n_msvolume">누적매수체결량	double	12</param>
/// <param name="n_mdvolume">누적매도체결량	double	12</param>
/// <param name="s_msvolume">누적순매수체결량	double	12</param>
/// <param name="n_mschecnt">누적매수체결건수	int	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	int	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	int	8</param>
public record t2832OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("체결수량	int	8")] int cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("매도호가	double	6.2")] double offerho, [Description("매수호가	double	6.2")] double bidho, [Description("거래량	double	12")] double volume, [Description("누적매수체결량	double	12")] double n_msvolume, [Description("누적매도체결량	double	12")] double n_mdvolume, [Description("누적순매수체결량	double	12")] double s_msvolume, [Description("누적매수체결건수	int	8")] int n_mschecnt, [Description("누적매도체결건수	int	8")] int n_mdchecnt, [Description("누적순매수체결건수	int	8")] int s_mschecnt);


/// <summary>
/// EUREX야간옵션선물기간별추이(t2833): t2833: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t2833InBlock([Description("단축코드	string	8")] string shcode, [Description("선물최근월물	string	1")] string futcheck, [Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("조회요청건수	int	3")] int cnt);

/// <summary>
/// EUREX야간옵션선물기간별추이(t2833): t2833: OutBlock
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t2833OutBlock([Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("최근월선물여부	string	1")] string nowfutyn);

/// <summary>
/// EUREX야간옵션선물기간별추이(t2833): t2833: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
public record t2833OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol);


/// <summary>
/// EUREX옵션선물시세전광판(t2835): t2835: InBlock
/// </summary>
/// <param name="yyyymm">월물(혹은주물WN)	string	6</param>
/// <param name="gubun">구분(G:원지수W:위클리)	string	1</param>
public record t2835InBlock([Description("월물(혹은주물WN)	string	6")] string yyyymm, [Description("구분(G:원지수W:위클리)	string	1")] string gubun);

/// <summary>
/// EUREX옵션선물시세전광판(t2835): t2835: OutBlock
/// </summary>
/// <param name="gmprice">근월물현재가	double	6.2</param>
/// <param name="gmsign">근월물전일대비구분	string	1</param>
/// <param name="gmchange">근월물전일대비	double	6.2</param>
/// <param name="gmdiff">근월물등락율	double	6.2</param>
/// <param name="gmvolume">근월물거래량	long	12</param>
/// <param name="gmshcode">근월물선물코드	string	8</param>
public record t2835OutBlock([Description("근월물현재가	double	6.2")] double gmprice, [Description("근월물전일대비구분	string	1")] string gmsign, [Description("근월물전일대비	double	6.2")] double gmchange, [Description("근월물등락율	double	6.2")] double gmdiff, [Description("근월물거래량	long	12")] long gmvolume, [Description("근월물선물코드	string	8")] string gmshcode);

/// <summary>
/// EUREX옵션선물시세전광판(t2835): t2835: OutBlock1
/// </summary>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="optcode">콜옵션코드	string	8</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="offerho1">매도호가	double	6.2</param>
/// <param name="bidho1">매수호가	double	6.2</param>
/// <param name="cvolume">체결량	long	12</param>
/// <param name="impv">내재가치	double	6.2</param>
/// <param name="timevl">시간가치	double	6.2</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="atmgubun">ATM구분	string	1</param>
/// <param name="jisuconv">지수환산	double	6.2</param>
public record t2835OutBlock1([Description("행사가	double	6.2")] double actprice, [Description("콜옵션코드	string	8")] string optcode, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("매도호가	double	6.2")] double offerho1, [Description("매수호가	double	6.2")] double bidho1, [Description("체결량	long	12")] long cvolume, [Description("내재가치	double	6.2")] double impv, [Description("시간가치	double	6.2")] double timevl, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("ATM구분	string	1")] string atmgubun, [Description("지수환산	double	6.2")] double jisuconv);

/// <summary>
/// EUREX옵션선물시세전광판(t2835): t2835: OutBlock2
/// </summary>
/// <param name="actprice">행사가	double	6.2</param>
/// <param name="optcode">풋옵션코드	string	8</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="offerho1">매도호가	double	6.2</param>
/// <param name="bidho1">매수호가	double	6.2</param>
/// <param name="cvolume">체결량	long	12</param>
/// <param name="impv">내재가치	double	6.2</param>
/// <param name="timevl">시간가치	double	6.2</param>
/// <param name="offerrem1">매도잔량	long	12</param>
/// <param name="bidrem1">매수잔량	long	12</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="atmgubun">ATM구분	string	1</param>
/// <param name="jisuconv">지수환산	double	6.2</param>
public record t2835OutBlock2([Description("행사가	double	6.2")] double actprice, [Description("풋옵션코드	string	8")] string optcode, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("매도호가	double	6.2")] double offerho1, [Description("매수호가	double	6.2")] double bidho1, [Description("체결량	long	12")] long cvolume, [Description("내재가치	double	6.2")] double impv, [Description("시간가치	double	6.2")] double timevl, [Description("매도잔량	long	12")] long offerrem1, [Description("매수잔량	long	12")] long bidrem1, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("ATM구분	string	1")] string atmgubun, [Description("지수환산	double	6.2")] double jisuconv);


/// <summary>
/// 뉴스본문(t3102): t3102: InBlock
/// </summary>
/// <param name="sNewsno">뉴스번호	string	24</param>
public record t3102InBlock([Description("뉴스번호	string	24")] string sNewsno);

/// <summary>
/// 뉴스본문(t3102): t3102: OutBlock
/// </summary>
/// <param name="sJongcode">뉴스종목	string	6</param>
public record t3102OutBlock([Description("뉴스종목	string	6")] string sJongcode);

/// <summary>
/// 뉴스본문(t3102): t3102: OutBlock1
/// </summary>
/// <param name="sBody">뉴스본문	string	100</param>
public record t3102OutBlock1([Description("뉴스본문	string	100")] string sBody);

/// <summary>
/// 뉴스본문(t3102): t3102: OutBlock2
/// </summary>
/// <param name="sTitle">뉴스타이틀	string	300</param>
public record t3102OutBlock2([Description("뉴스타이틀	string	300")] string sTitle);


/// <summary>
/// 종목별증시일정(t3202): t3202: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">조회일자	string	8</param>
public record t3202InBlock([Description("종목코드	string	6")] string shcode, [Description("조회일자	string	8")] string date);

/// <summary>
/// 종목별증시일정(t3202): t3202: OutBlock
/// </summary>
/// <param name="recdt">기준일	string	8</param>
/// <param name="tableid">테이블아이디	string	6</param>
/// <param name="upgu">업무구분	string	2</param>
/// <param name="custno">발행체번호	string	5</param>
/// <param name="custnm">발행회사명	string	80</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="upunm">업무명	string	20</param>
public record t3202OutBlock([Description("기준일	string	8")] string recdt, [Description("테이블아이디	string	6")] string tableid, [Description("업무구분	string	2")] string upgu, [Description("발행체번호	string	5")] string custno, [Description("발행회사명	string	80")] string custnm, [Description("종목코드	string	6")] string shcode, [Description("업무명	string	20")] string upunm);


/// <summary>
/// FNG_요약(t3320): t3320: InBlock
/// </summary>
/// <param name="gicode">종목코드	string	7</param>
public record t3320InBlock([Description("종목코드	string	7")] string gicode);

/// <summary>
/// FNG_요약(t3320): t3320: OutBlock
/// </summary>
/// <param name="upgubunnm">업종구분명	string	20</param>
/// <param name="sijangcd">시장구분	string	1</param>
/// <param name="marketnm">시장구분명	string	10</param>
/// <param name="company">한글기업명	string	100</param>
/// <param name="baddress">본사주소	string	100</param>
/// <param name="btelno">본사전화번호	string	20</param>
/// <param name="gsyyyy">최근결산년도	string	4</param>
/// <param name="gsmm">결산월	string	2</param>
/// <param name="gsym">최근결산년월	string	6</param>
/// <param name="lstprice">주당액면가	long	12</param>
/// <param name="gstock">주식수	long	12</param>
/// <param name="homeurl">Homepage	string	50</param>
/// <param name="grdnm">그룹명	string	30</param>
/// <param name="foreignratio">외국인	double	6.2</param>
/// <param name="irtel">주담전화	string	30</param>
/// <param name="capital">자본금	double	12</param>
/// <param name="sigavalue">시가총액	double	12</param>
/// <param name="cashsis">배당금	double	12</param>
/// <param name="cashrate">배당수익율	double	13.2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="notice1">위험고지구분1_정리매매	string	1</param>
/// <param name="notice2">위험고지구분2_투자위험	string	1</param>
/// <param name="notice3">위험고지구분3_단기과열	string	1</param>
public record t3320OutBlock([Description("업종구분명	string	20")] string upgubunnm, [Description("시장구분	string	1")] string sijangcd, [Description("시장구분명	string	10")] string marketnm, [Description("한글기업명	string	100")] string company, [Description("본사주소	string	100")] string baddress, [Description("본사전화번호	string	20")] string btelno, [Description("최근결산년도	string	4")] string gsyyyy, [Description("결산월	string	2")] string gsmm, [Description("최근결산년월	string	6")] string gsym, [Description("주당액면가	long	12")] long lstprice, [Description("주식수	long	12")] long gstock, [Description("Homepage	string	50")] string homeurl, [Description("그룹명	string	30")] string grdnm, [Description("외국인	double	6.2")] double foreignratio, [Description("주담전화	string	30")] string irtel, [Description("자본금	double	12")] double capital, [Description("시가총액	double	12")] double sigavalue, [Description("배당금	double	12")] double cashsis, [Description("배당수익율	double	13.2")] double cashrate, [Description("현재가	int	8")] int price, [Description("전일종가	int	8")] int jnilclose, [Description("위험고지구분1_정리매매	string	1")] string notice1, [Description("위험고지구분2_투자위험	string	1")] string notice2, [Description("위험고지구분3_단기과열	string	1")] string notice3);

/// <summary>
/// FNG_요약(t3320): t3320: OutBlock1
/// </summary>
/// <param name="gicode">기업코드	string	7</param>
/// <param name="gsym">결산년월	string	6</param>
/// <param name="gsgb">결산구분	string	1</param>
/// <param name="per">PER	double	13.2</param>
/// <param name="eps">EPS	double	13</param>
/// <param name="pbr">PBR	double	13.2</param>
/// <param name="roa">ROA	double	13.2</param>
/// <param name="roe">ROE	double	13.2</param>
/// <param name="ebitda">EBITDA	double	13.2</param>
/// <param name="evebitda">EVEBITDA	double	13.2</param>
/// <param name="par">액면가	double	13.2</param>
/// <param name="sps">SPS	double	13.2</param>
/// <param name="cps">CPS	double	13.2</param>
/// <param name="bps">BPS	double	13</param>
/// <param name="t_per">T.PER	double	13.2</param>
/// <param name="t_eps">T.EPS	double	13</param>
/// <param name="peg">PEG	double	13.2</param>
/// <param name="t_peg">T.PEG	double	13.2</param>
/// <param name="t_gsym">최근분기년도	string	6</param>
public record t3320OutBlock1([Description("기업코드	string	7")] string gicode, [Description("결산년월	string	6")] string gsym, [Description("결산구분	string	1")] string gsgb, [Description("PER	double	13.2")] double per, [Description("EPS	double	13")] double eps, [Description("PBR	double	13.2")] double pbr, [Description("ROA	double	13.2")] double roa, [Description("ROE	double	13.2")] double roe, [Description("EBITDA	double	13.2")] double ebitda, [Description("EVEBITDA	double	13.2")] double evebitda, [Description("액면가	double	13.2")] double par, [Description("SPS	double	13.2")] double sps, [Description("CPS	double	13.2")] double cps, [Description("BPS	double	13")] double bps, [Description("T.PER	double	13.2")] double t_per, [Description("T.EPS	double	13")] double t_eps, [Description("PEG	double	13.2")] double peg, [Description("T.PEG	double	13.2")] double t_peg, [Description("최근분기년도	string	6")] string t_gsym);


/// <summary>
/// 재무순위종합(t3341): t3341: InBlock
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="gubun1">순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)	string	1</param>
/// <param name="gubun2">대비구분	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t3341InBlock([Description("시장구분	string	1")] string gubun, [Description("순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)	string	1")] string gubun1, [Description("대비구분	string	1")] string gubun2, [Description("IDX	int	4")] int idx);

/// <summary>
/// 재무순위종합(t3341): t3341: OutBlock
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t3341OutBlock([Description("CNT	int	4")] int cnt, [Description("IDX	int	4")] int idx);

/// <summary>
/// 재무순위종합(t3341): t3341: OutBlock1
/// </summary>
/// <param name="rank">순위	int	4</param>
/// <param name="hname">기업명	string	20</param>
/// <param name="salesgrowth">매출액증가율	long	12</param>
/// <param name="operatingincomegrowt">영업이익증가율	long	12</param>
/// <param name="ordinaryincomegrowth">경상이익증가율	long	12</param>
/// <param name="liabilitytoequity">부채비율	long	12</param>
/// <param name="enterpriseratio">유보율	long	12</param>
/// <param name="eps">EPS	long	12</param>
/// <param name="bps">BPS	long	12</param>
/// <param name="roe">ROE	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="per">PER	double	13.2</param>
/// <param name="pbr">PBR	double	13.2</param>
/// <param name="peg">PEG	double	13.2</param>
public record t3341OutBlock1([Description("순위	int	4")] int rank, [Description("기업명	string	20")] string hname, [Description("매출액증가율	long	12")] long salesgrowth, [Description("영업이익증가율	long	12")] long operatingincomegrowt, [Description("경상이익증가율	long	12")] long ordinaryincomegrowth, [Description("부채비율	long	12")] long liabilitytoequity, [Description("유보율	long	12")] long enterpriseratio, [Description("EPS	long	12")] long eps, [Description("BPS	long	12")] long bps, [Description("ROE	long	12")] long roe, [Description("종목코드	string	6")] string shcode, [Description("PER	double	13.2")] double per, [Description("PBR	double	13.2")] double pbr, [Description("PEG	double	13.2")] double peg);


/// <summary>
/// 투자의견(t3401): t3401: InBlock
/// </summary>
/// <param name="shcode">종목코드	string	9</param>
/// <param name="gubun1">구분	string	1</param>
/// <param name="tradno">회원사코드	string	3</param>
/// <param name="cts_date">IDXDATE	string	8</param>
public record t3401InBlock([Description("종목코드	string	9")] string shcode, [Description("구분	string	1")] string gubun1, [Description("회원사코드	string	3")] string tradno, [Description("IDXDATE	string	8")] string cts_date);

/// <summary>
/// 투자의견(t3401): t3401: OutBlock
/// </summary>
/// <param name="cts_date">IDXDATE	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">대비속성	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t3401OutBlock([Description("IDXDATE	string	8")] string cts_date, [Description("현재가	int	8")] int price, [Description("대비속성	string	1")] string sign, [Description("대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래대금	long	12")] long value);

/// <summary>
/// 투자의견(t3401): t3401: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	9</param>
/// <param name="tradno">회원사코드	string	3</param>
/// <param name="date">의견일자	string	8</param>
/// <param name="tradname">회원사명	string	30</param>
/// <param name="bopn">투자의견변경후	string	30</param>
/// <param name="nopn">투자의견변경전	string	30</param>
/// <param name="boga">목표가변경전	long	12</param>
/// <param name="noga">목표가변경후	long	12</param>
/// <param name="close">의견일종가	int	8</param>
public record t3401OutBlock1([Description("종목코드	string	9")] string shcode, [Description("회원사코드	string	3")] string tradno, [Description("의견일자	string	8")] string date, [Description("회원사명	string	30")] string tradname, [Description("투자의견변경후	string	30")] string bopn, [Description("투자의견변경전	string	30")] string nopn, [Description("목표가변경전	long	12")] long boga, [Description("목표가변경후	long	12")] long noga, [Description("의견일종가	int	8")] int close);


/// <summary>
/// 해외실시간지수(t3518): t3518: InBlock
/// </summary>
/// <param name="kind">종목종류	string	1</param>
/// <param name="symbol">SYMBOL	string	16</param>
/// <param name="cnt">입력건수	int	4</param>
/// <param name="jgbn">조회구분	string	1</param>
/// <param name="nmin">N분	int	3</param>
/// <param name="cts_date">CTS_DATE	string	8</param>
/// <param name="cts_time">CTS_TIME	string	6</param>
public record t3518InBlock([Description("종목종류	string	1")] string kind, [Description("SYMBOL	string	16")] string symbol, [Description("입력건수	int	4")] int cnt, [Description("조회구분	string	1")] string jgbn, [Description("N분	int	3")] int nmin, [Description("CTS_DATE	string	8")] string cts_date, [Description("CTS_TIME	string	6")] string cts_time);

/// <summary>
/// 해외실시간지수(t3518): t3518: OutBlock
/// </summary>
/// <param name="cts_date">CTS_DATE	string	8</param>
/// <param name="cts_time">CTS_TIME	string	6</param>
public record t3518OutBlock([Description("CTS_DATE	string	8")] string cts_date, [Description("CTS_TIME	string	6")] string cts_time);

/// <summary>
/// 해외실시간지수(t3518): t3518: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	8</param>
/// <param name="open">시가	double	9.4</param>
/// <param name="high">고가	double	9.4</param>
/// <param name="low">저가	double	9.4</param>
/// <param name="price">현재가	double	9.4</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	9.4</param>
/// <param name="uprate">등락율	double	9.4</param>
/// <param name="volume">누적거래량	double	12</param>
/// <param name="bidho">매수호가	double	9.4</param>
/// <param name="offerho">매도호가	double	9.4</param>
/// <param name="bidrem">매수잔량	double	12</param>
/// <param name="offerrem">매도잔량	double	12</param>
/// <param name="kind">종목종류	string	1</param>
/// <param name="symbol">SYMBOL	string	16</param>
/// <param name="exid">EXID	string	4</param>
/// <param name="kodate">한국일자	string	8</param>
/// <param name="kotime">한국시간	string	8</param>
public record t3518OutBlock1([Description("일자	string	8")] string date, [Description("시간	string	8")] string time, [Description("시가	double	9.4")] double open, [Description("고가	double	9.4")] double high, [Description("저가	double	9.4")] double low, [Description("현재가	double	9.4")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	9.4")] double change, [Description("등락율	double	9.4")] double uprate, [Description("누적거래량	double	12")] double volume, [Description("매수호가	double	9.4")] double bidho, [Description("매도호가	double	9.4")] double offerho, [Description("매수잔량	double	12")] double bidrem, [Description("매도잔량	double	12")] double offerrem, [Description("종목종류	string	1")] string kind, [Description("SYMBOL	string	16")] string symbol, [Description("EXID	string	4")] string exid, [Description("한국일자	string	8")] string kodate, [Description("한국시간	string	8")] string kotime);


/// <summary>
/// 해외지수조회(API용)(t3521): t3521: InBlock
/// </summary>
/// <param name="kind">종목종류	string	1</param>
/// <param name="symbol">SYMBOL	string	16</param>
public record t3521InBlock([Description("종목종류	string	1")] string kind, [Description("SYMBOL	string	16")] string symbol);

/// <summary>
/// 해외지수조회(API용)(t3521): t3521: OutBlock
/// </summary>
/// <param name="symbol">심벌	string	16</param>
/// <param name="hname">지수명	string	20</param>
/// <param name="close">지수	double	12.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="date">일자	string	8</param>
public record t3521OutBlock([Description("심벌	string	16")] string symbol, [Description("지수명	string	20")] string hname, [Description("지수	double	12.2")] double close, [Description("대비구분	string	1")] string sign, [Description("대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("일자	string	8")] string date);


/// <summary>
/// 업종챠트(종합)(t4203): t4203: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="gubun">주기구분(0:틱1:분2:일3:주4:월)	string	1</param>
/// <param name="ncnt">틱개수	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="tdgb">당일구분(0:전체1:당일만)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분(0:연속전체1:연속당일만2:연속전일만)	string	1</param>
public record t4203InBlock([Description("단축코드	string	3")] string shcode, [Description("주기구분(0:틱1:분2:일3:주4:월)	string	1")] string gubun, [Description("틱개수	int	4")] int ncnt, [Description("건수	int	4")] int qrycnt, [Description("당일구분(0:전체1:당일만)	string	1")] string tdgb, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("연속당일구분(0:연속전체1:연속당일만2:연속전일만)	string	1")] string cts_daygb);

/// <summary>
/// 업종챠트(종합)(t4203): t4203: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="jisiga">전일시가	double	7.2</param>
/// <param name="jihigh">전일고가	double	7.2</param>
/// <param name="jilow">전일저가	double	7.2</param>
/// <param name="jiclose">전일종가	double	7.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	7.2</param>
/// <param name="dihigh">당일고가	double	7.2</param>
/// <param name="dilow">당일저가	double	7.2</param>
/// <param name="diclose">당일종가	double	7.2</param>
/// <param name="disvalue">당일거래대금	long	12</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	1</param>
public record t4203OutBlock([Description("단축코드	string	3")] string shcode, [Description("전일시가	double	7.2")] double jisiga, [Description("전일고가	double	7.2")] double jihigh, [Description("전일저가	double	7.2")] double jilow, [Description("전일종가	double	7.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	7.2")] double disiga, [Description("당일고가	double	7.2")] double dihigh, [Description("당일저가	double	7.2")] double dilow, [Description("당일종가	double	7.2")] double diclose, [Description("당일거래대금	long	12")] long disvalue, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("연속당일구분	string	1")] string cts_daygb);

/// <summary>
/// 업종챠트(종합)(t4203): t4203: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t4203OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	7.2")] double open, [Description("고가	double	7.2")] double high, [Description("저가	double	7.2")] double low, [Description("종가	double	7.2")] double close, [Description("거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value);


/// <summary>
/// 주식선물마스터조회(API용)(t8401): t8401: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8401InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// 주식선물마스터조회(API용)(t8401): t8401: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="basecode">기초자산코드	string	9</param>
public record t8401OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("기초자산코드	string	9")] string basecode);


/// <summary>
/// 주식선물현재가조회(API용)(t8402): t8402: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t8402InBlock([Description("단축코드	string	8")] string focode);

/// <summary>
/// 주식선물현재가조회(API용)(t8402): t8402: OutBlock
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	double	6.2</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="mgjv">미결제량	int	8</param>
/// <param name="mgjvdiff">미결제증감	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="high52w">52최고가	int	8</param>
/// <param name="low52w">52최저가	int	8</param>
/// <param name="basis">베이시스	double	6.2</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="theoryprice">이론가	int	8</param>
/// <param name="glyl">괴리율	double	6.3</param>
/// <param name="lastmonth">만기일	string	8</param>
/// <param name="jandatecnt">잔여일	int	8</param>
/// <param name="pricejisu">종합지수	double	6.2</param>
/// <param name="jisusign">종합지수전일대비구분	string	1</param>
/// <param name="jisuchange">종합지수전일대비	double	6.2</param>
/// <param name="jisudiff">종합지수등락율	double	6.2</param>
/// <param name="kospijisu">KOSPI200지수	double	6.2</param>
/// <param name="kospisign">KOSPI200전일대비구분	string	1</param>
/// <param name="kospichange">KOSPI200전일대비	double	6.2</param>
/// <param name="kospidiff">KOSPI200등락율	double	6.2</param>
/// <param name="listhprice">상장최고가	int	8</param>
/// <param name="listlprice">상장최저가	int	8</param>
/// <param name="delt">델타	double	6.4</param>
/// <param name="gama">감마	double	6.4</param>
/// <param name="ceta">세타	double	6.4</param>
/// <param name="vega">베가	double	6.4</param>
/// <param name="rhox">로우	double	6.4</param>
/// <param name="gmprice">근월물현재가	int	8</param>
/// <param name="gmsign">근월물전일대비구분	string	1</param>
/// <param name="gmchange">근월물전일대비	int	8</param>
/// <param name="gmdiff">근월물등락율	double	6.2</param>
/// <param name="theorypriceg">이론가	int	8</param>
/// <param name="histimpv">역사적변동성	double	6.2</param>
/// <param name="impv">내재변동성	double	6.2</param>
/// <param name="sbasis">시장BASIS	int	8</param>
/// <param name="ibasis">이론BASIS	int	8</param>
/// <param name="gmfutcode">근월물종목코드	string	8</param>
/// <param name="actprice">행사가	int	8</param>
/// <param name="shcode">기초자산단축코드	string	6</param>
/// <param name="basehname">기초자산한글명	string	20</param>
/// <param name="baseprice">기초자산현재가	int	8</param>
/// <param name="basesign">기초자산현재가대비구분	string	1</param>
/// <param name="basechange">기초자산현재가전일대비	int	8</param>
/// <param name="basediff">기초자산등락률	double	6.2</param>
/// <param name="basevol">기초자산거래량	long	12</param>
/// <param name="baseprevol">기초자산전일거래량	long	12</param>
/// <param name="basebidprc">기초자산매수호가	long	9</param>
/// <param name="baseaskprc">기초자산매도호가	long	9</param>
/// <param name="basefornetbid">기초자산외국계회원사순매수	long	12</param>
/// <param name="prodgrp">상품군	string	20</param>
/// <param name="mulcnt">승수	double	12.8</param>
/// <param name="danhochk">단일가호가여부	string	1</param>
/// <param name="yeprice">예상체결가	int	8</param>
/// <param name="jnilysign">예상체결가전일종가대비구분	string	1</param>
/// <param name="jnilychange">예상체결가전일종가대비	int	8</param>
/// <param name="jnilydrate">예상체결가전일종가등락율	double	6.2</param>
public record t8402OutBlock([Description("한글명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("전일종가	int	8")] int jnilclose, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래량전일동시간비율	double	6.2")] double stimeqrt, [Description("거래대금	long	12")] long value, [Description("미결제량	int	8")] int mgjv, [Description("미결제증감	int	8")] int mgjvdiff, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("52최고가	int	8")] int high52w, [Description("52최저가	int	8")] int low52w, [Description("베이시스	double	6.2")] double basis, [Description("기준가	int	8")] int recprice, [Description("이론가	int	8")] int theoryprice, [Description("괴리율	double	6.3")] double glyl, [Description("만기일	string	8")] string lastmonth, [Description("잔여일	int	8")] int jandatecnt, [Description("종합지수	double	6.2")] double pricejisu, [Description("종합지수전일대비구분	string	1")] string jisusign, [Description("종합지수전일대비	double	6.2")] double jisuchange, [Description("종합지수등락율	double	6.2")] double jisudiff, [Description("KOSPI200지수	double	6.2")] double kospijisu, [Description("KOSPI200전일대비구분	string	1")] string kospisign, [Description("KOSPI200전일대비	double	6.2")] double kospichange, [Description("KOSPI200등락율	double	6.2")] double kospidiff, [Description("상장최고가	int	8")] int listhprice, [Description("상장최저가	int	8")] int listlprice, [Description("델타	double	6.4")] double delt, [Description("감마	double	6.4")] double gama, [Description("세타	double	6.4")] double ceta, [Description("베가	double	6.4")] double vega, [Description("로우	double	6.4")] double rhox, [Description("근월물현재가	int	8")] int gmprice, [Description("근월물전일대비구분	string	1")] string gmsign, [Description("근월물전일대비	int	8")] int gmchange, [Description("근월물등락율	double	6.2")] double gmdiff, [Description("이론가	int	8")] int theorypriceg, [Description("역사적변동성	double	6.2")] double histimpv, [Description("내재변동성	double	6.2")] double impv, [Description("시장BASIS	int	8")] int sbasis, [Description("이론BASIS	int	8")] int ibasis, [Description("근월물종목코드	string	8")] string gmfutcode, [Description("행사가	int	8")] int actprice, [Description("기초자산단축코드	string	6")] string shcode, [Description("기초자산한글명	string	20")] string basehname, [Description("기초자산현재가	int	8")] int baseprice, [Description("기초자산현재가대비구분	string	1")] string basesign, [Description("기초자산현재가전일대비	int	8")] int basechange, [Description("기초자산등락률	double	6.2")] double basediff, [Description("기초자산거래량	long	12")] long basevol, [Description("기초자산전일거래량	long	12")] long baseprevol, [Description("기초자산매수호가	long	9")] long basebidprc, [Description("기초자산매도호가	long	9")] long baseaskprc, [Description("기초자산외국계회원사순매수	long	12")] long basefornetbid, [Description("상품군	string	20")] string prodgrp, [Description("승수	double	12.8")] double mulcnt, [Description("단일가호가여부	string	1")] string danhochk, [Description("예상체결가	int	8")] int yeprice, [Description("예상체결가전일종가대비구분	string	1")] string jnilysign, [Description("예상체결가전일종가대비	int	8")] int jnilychange, [Description("예상체결가전일종가등락율	double	6.2")] double jnilydrate);


/// <summary>
/// 주식선물호가조회(API용)(t8403): t8403: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t8403InBlock([Description("단축코드	string	8")] string shcode);

/// <summary>
/// 주식선물호가조회(API용)(t8403): t8403: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="stimeqrt">거래량전일동시간비율	double	6.2</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="offerho1">매도호가1	int	8</param>
/// <param name="bidho1">매수호가1	int	8</param>
/// <param name="offerrem1">매도호가수량1	int	8</param>
/// <param name="bidrem1">매수호가수량1	int	8</param>
/// <param name="dcnt1">매도호가건수1	int	8</param>
/// <param name="scnt1">매수호가건수1	int	8</param>
/// <param name="offerho2">매도호가2	int	8</param>
/// <param name="bidho2">매수호가2	int	8</param>
/// <param name="offerrem2">매도호가수량2	int	8</param>
/// <param name="bidrem2">매수호가수량2	int	8</param>
/// <param name="dcnt2">매도호가건수2	int	8</param>
/// <param name="scnt2">매수호가건수2	int	8</param>
/// <param name="offerho3">매도호가3	int	8</param>
/// <param name="bidho3">매수호가3	int	8</param>
/// <param name="offerrem3">매도호가수량3	int	8</param>
/// <param name="bidrem3">매수호가수량3	int	8</param>
/// <param name="dcnt3">매도호가건수3	int	8</param>
/// <param name="scnt3">매수호가건수3	int	8</param>
/// <param name="offerho4">매도호가4	int	8</param>
/// <param name="bidho4">매수호가4	int	8</param>
/// <param name="offerrem4">매도호가수량4	int	8</param>
/// <param name="bidrem4">매수호가수량4	int	8</param>
/// <param name="dcnt4">매도호가건수4	int	8</param>
/// <param name="scnt4">매수호가건수4	int	8</param>
/// <param name="offerho5">매도호가5	int	8</param>
/// <param name="bidho5">매수호가5	int	8</param>
/// <param name="offerrem5">매도호가수량5	int	8</param>
/// <param name="bidrem5">매수호가수량5	int	8</param>
/// <param name="dcnt5">매도호가건수5	int	8</param>
/// <param name="scnt5">매수호가건수5	int	8</param>
/// <param name="offerho6">매도호가6	int	8</param>
/// <param name="bidho6">매수호가6	int	8</param>
/// <param name="offerrem6">매도호가수량6	int	8</param>
/// <param name="bidrem6">매수호가수량6	int	8</param>
/// <param name="dcnt6">매도호가건수6	int	8</param>
/// <param name="scnt6">매수호가건수6	int	8</param>
/// <param name="offerho7">매도호가7	int	8</param>
/// <param name="bidho7">매수호가7	int	8</param>
/// <param name="offerrem7">매도호가수량7	int	8</param>
/// <param name="bidrem7">매수호가수량7	int	8</param>
/// <param name="dcnt7">매도호가건수7	int	8</param>
/// <param name="scnt7">매수호가건수7	int	8</param>
/// <param name="offerho8">매도호가8	int	8</param>
/// <param name="bidho8">매수호가8	int	8</param>
/// <param name="offerrem8">매도호가수량8	int	8</param>
/// <param name="bidrem8">매수호가수량8	int	8</param>
/// <param name="dcnt8">매도호가건수8	int	8</param>
/// <param name="scnt8">매수호가건수8	int	8</param>
/// <param name="offerho9">매도호가9	int	8</param>
/// <param name="bidho9">매수호가9	int	8</param>
/// <param name="offerrem9">매도호가수량9	int	8</param>
/// <param name="bidrem9">매수호가수량9	int	8</param>
/// <param name="dcnt9">매도호가건수9	int	8</param>
/// <param name="scnt9">매수호가건수9	int	8</param>
/// <param name="offerho10">매도호가10	int	8</param>
/// <param name="bidho10">매수호가10	int	8</param>
/// <param name="offerrem10">매도호가수량10	int	8</param>
/// <param name="bidrem10">매수호가수량10	int	8</param>
/// <param name="dcnt10">매도호가건수10	int	8</param>
/// <param name="scnt10">매수호가건수10	int	8</param>
/// <param name="dvol">매도호가총수량	int	8</param>
/// <param name="svol">매수호가총수량	int	8</param>
/// <param name="toffernum">총매도호가건수	int	8</param>
/// <param name="tbidnum">총매수호가건수	int	8</param>
/// <param name="time">수신시간	string	6</param>
/// <param name="shcode">단축코드	string	6</param>
public record t8403OutBlock([Description("종목명	string	20")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래량전일동시간비율	double	6.2")] double stimeqrt, [Description("전일종가	int	8")] int jnilclose, [Description("매도호가1	int	8")] int offerho1, [Description("매수호가1	int	8")] int bidho1, [Description("매도호가수량1	int	8")] int offerrem1, [Description("매수호가수량1	int	8")] int bidrem1, [Description("매도호가건수1	int	8")] int dcnt1, [Description("매수호가건수1	int	8")] int scnt1, [Description("매도호가2	int	8")] int offerho2, [Description("매수호가2	int	8")] int bidho2, [Description("매도호가수량2	int	8")] int offerrem2, [Description("매수호가수량2	int	8")] int bidrem2, [Description("매도호가건수2	int	8")] int dcnt2, [Description("매수호가건수2	int	8")] int scnt2, [Description("매도호가3	int	8")] int offerho3, [Description("매수호가3	int	8")] int bidho3, [Description("매도호가수량3	int	8")] int offerrem3, [Description("매수호가수량3	int	8")] int bidrem3, [Description("매도호가건수3	int	8")] int dcnt3, [Description("매수호가건수3	int	8")] int scnt3, [Description("매도호가4	int	8")] int offerho4, [Description("매수호가4	int	8")] int bidho4, [Description("매도호가수량4	int	8")] int offerrem4, [Description("매수호가수량4	int	8")] int bidrem4, [Description("매도호가건수4	int	8")] int dcnt4, [Description("매수호가건수4	int	8")] int scnt4, [Description("매도호가5	int	8")] int offerho5, [Description("매수호가5	int	8")] int bidho5, [Description("매도호가수량5	int	8")] int offerrem5, [Description("매수호가수량5	int	8")] int bidrem5, [Description("매도호가건수5	int	8")] int dcnt5, [Description("매수호가건수5	int	8")] int scnt5, [Description("매도호가6	int	8")] int offerho6, [Description("매수호가6	int	8")] int bidho6, [Description("매도호가수량6	int	8")] int offerrem6, [Description("매수호가수량6	int	8")] int bidrem6, [Description("매도호가건수6	int	8")] int dcnt6, [Description("매수호가건수6	int	8")] int scnt6, [Description("매도호가7	int	8")] int offerho7, [Description("매수호가7	int	8")] int bidho7, [Description("매도호가수량7	int	8")] int offerrem7, [Description("매수호가수량7	int	8")] int bidrem7, [Description("매도호가건수7	int	8")] int dcnt7, [Description("매수호가건수7	int	8")] int scnt7, [Description("매도호가8	int	8")] int offerho8, [Description("매수호가8	int	8")] int bidho8, [Description("매도호가수량8	int	8")] int offerrem8, [Description("매수호가수량8	int	8")] int bidrem8, [Description("매도호가건수8	int	8")] int dcnt8, [Description("매수호가건수8	int	8")] int scnt8, [Description("매도호가9	int	8")] int offerho9, [Description("매수호가9	int	8")] int bidho9, [Description("매도호가수량9	int	8")] int offerrem9, [Description("매수호가수량9	int	8")] int bidrem9, [Description("매도호가건수9	int	8")] int dcnt9, [Description("매수호가건수9	int	8")] int scnt9, [Description("매도호가10	int	8")] int offerho10, [Description("매수호가10	int	8")] int bidho10, [Description("매도호가수량10	int	8")] int offerrem10, [Description("매수호가수량10	int	8")] int bidrem10, [Description("매도호가건수10	int	8")] int dcnt10, [Description("매수호가건수10	int	8")] int scnt10, [Description("매도호가총수량	int	8")] int dvol, [Description("매수호가총수량	int	8")] int svol, [Description("총매도호가건수	int	8")] int toffernum, [Description("총매수호가건수	int	8")] int tbidnum, [Description("수신시간	string	6")] string time, [Description("단축코드	string	6")] string shcode);


/// <summary>
/// 주식선물시간대별체결조회(API용)(t8404): t8404: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t8404InBlock([Description("단축코드	string	8")] string focode, [Description("특이거래량	long	12")] long cvolume, [Description("시작시간	string	4")] string stime, [Description("종료시간	string	4")] string etime, [Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식선물시간대별체결조회(API용)(t8404): t8404: OutBlock
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t8404OutBlock([Description("시간CTS	string	10")] string cts_time);

/// <summary>
/// 주식선물시간대별체결조회(API용)(t8404): t8404: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	8</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="chdegree">체결강도	double	8.2</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="jnilopenupdn">미결전일증감	int	8</param>
/// <param name="ibasis">이론BASIS	int	8</param>
/// <param name="sbasis">시장BASIS	int	8</param>
/// <param name="kasis">괴리율	double	6.2</param>
/// <param name="value">거래대금	double	12</param>
/// <param name="j_openupdn">미결직전증감	int	8</param>
/// <param name="n_msvolume">누적매수체결량	double	12</param>
/// <param name="n_mdvolume">누적매도체결량	double	12</param>
/// <param name="s_msvolume">누적순매수체결량	double	12</param>
/// <param name="n_mschecnt">누적매수체결건수	int	8</param>
/// <param name="n_mdchecnt">누적매도체결건수	int	8</param>
/// <param name="s_mschecnt">누적순매수체결건수	int	8</param>
public record t8404OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	8")] double change, [Description("체결수량	int	8")] int cvolume, [Description("체결강도	double	8.2")] double chdegree, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("거래량	double	12")] double volume, [Description("미결수량	int	8")] int openyak, [Description("미결전일증감	int	8")] int jnilopenupdn, [Description("이론BASIS	int	8")] int ibasis, [Description("시장BASIS	int	8")] int sbasis, [Description("괴리율	double	6.2")] double kasis, [Description("거래대금	double	12")] double value, [Description("미결직전증감	int	8")] int j_openupdn, [Description("누적매수체결량	double	12")] double n_msvolume, [Description("누적매도체결량	double	12")] double n_mdvolume, [Description("누적순매수체결량	double	12")] double s_msvolume, [Description("누적매수체결건수	int	8")] int n_mschecnt, [Description("누적매도체결건수	int	8")] int n_mdchecnt, [Description("누적순매수체결건수	int	8")] int s_mschecnt);


/// <summary>
/// 주식선물기간별주가(API용)(t8405): t8405: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t8405InBlock([Description("단축코드	string	8")] string shcode, [Description("선물최근월물	string	1")] string futcheck, [Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("조회요청건수	int	3")] int cnt);

/// <summary>
/// 주식선물기간별주가(API용)(t8405): t8405: OutBlock
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t8405OutBlock([Description("날짜	string	8")] string date, [Description("CTS종목코드	string	8")] string cts_code, [Description("전종목만기일	string	8")] string lastdate, [Description("최근월선물여부	string	1")] string nowfutyn);

/// <summary>
/// 주식선물기간별주가(API용)(t8405): t8405: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="openyakupdn">미결증감	int	8</param>
/// <param name="value">거래대금	double	12</param>
public record t8405OutBlock1([Description("날짜	string	8")] string date, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("종가	int	8")] int close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("미결수량	int	8")] int openyak, [Description("미결증감	int	8")] int openyakupdn, [Description("거래대금	double	12")] double value);


/// <summary>
/// 주식선물틱분별체결조회(API용)(t8406): t8406: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8406InBlock([Description("단축코드	string	8")] string focode, [Description("챠트구분	string	1")] string cgubun, [Description("분구분	int	3")] int bgubun, [Description("조회건수	int	3")] int cnt);

/// <summary>
/// 주식선물틱분별체결조회(API용)(t8406): t8406: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="value">거래대금	double	12</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="openupdn">미결증감	int	8</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="s_mschecnt">매수순간체결건수	int	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	int	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	int	8</param>
/// <param name="s_mschevol">매수순간체결량	double	12</param>
/// <param name="s_mdchevol">매도순간체결량	double	12</param>
/// <param name="ss_mschevol">순매수순간체결량	double	12</param>
/// <param name="chdegvol">체결강도(거래량)	double	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	double	8.2</param>
public record t8406OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("거래량	double	12")] double volume, [Description("거래대금	double	12")] double value, [Description("미결수량	int	8")] int openyak, [Description("미결증감	int	8")] int openupdn, [Description("체결수량	int	8")] int cvolume, [Description("매수순간체결건수	int	8")] int s_mschecnt, [Description("매도순간체결건수	int	8")] int s_mdchecnt, [Description("순매수순간체결건수	int	8")] int ss_mschecnt, [Description("매수순간체결량	double	12")] double s_mschevol, [Description("매도순간체결량	double	12")] double s_mdchevol, [Description("순매수순간체결량	double	12")] double ss_mschevol, [Description("체결강도(거래량)	double	8.2")] double chdegvol, [Description("체결강도(건수)	double	8.2")] double chdegcnt);


/// <summary>
/// API용주식멀티현재가조회(t8407): t8407: InBlock
/// </summary>
/// <param name="nrec">건수	int	3</param>
/// <param name="shcode">종목코드	string	300</param>
public record t8407InBlock([Description("건수	int	3")] int nrec, [Description("종목코드	string	300")] string shcode);

/// <summary>
/// API용주식멀티현재가조회(t8407): t8407: OutBlock1
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="offerho">매도호가	int	8</param>
/// <param name="bidho">매수호가	int	8</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="chdegree">체결강도	double	9.2</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="value">거래대금(백만)	long	12</param>
/// <param name="offerrem">우선매도잔량	long	12</param>
/// <param name="bidrem">우선매수잔량	long	12</param>
/// <param name="totofferrem">총매도잔량	long	12</param>
/// <param name="totbidrem">총매수잔량	long	12</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
public record t8407OutBlock1([Description("종목코드	string	6")] string shcode, [Description("종목명	string	40")] string hname, [Description("현재가	int	8")] int price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	int	8")] int change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("매도호가	int	8")] int offerho, [Description("매수호가	int	8")] int bidho, [Description("체결수량	int	8")] int cvolume, [Description("체결강도	double	9.2")] double chdegree, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("거래대금(백만)	long	12")] long value, [Description("우선매도잔량	long	12")] long offerrem, [Description("우선매수잔량	long	12")] long bidrem, [Description("총매도잔량	long	12")] long totofferrem, [Description("총매수잔량	long	12")] long totbidrem, [Description("전일종가	int	8")] int jnilclose, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice);


/// <summary>
/// API전용주식챠트(일주월년)(t8410): t8410: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gubun">주기구분(2:일3:주4:월5:년)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
/// <param name="sujung">수정주가여부(Y:적용N:비적용)	string	1</param>
public record t8410InBlock([Description("단축코드	string	6")] string shcode, [Description("주기구분(2:일3:주4:월5:년)	string	1")] string gubun, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn, [Description("수정주가여부(Y:적용N:비적용)	string	1")] string sujung);

/// <summary>
/// API전용주식챠트(일주월년)(t8410): t8410: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="jisiga">전일시가	int	8</param>
/// <param name="jihigh">전일고가	int	8</param>
/// <param name="jilow">전일저가	int	8</param>
/// <param name="jiclose">전일종가	int	8</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	int	8</param>
/// <param name="dihigh">당일고가	int	8</param>
/// <param name="dilow">당일저가	int	8</param>
/// <param name="diclose">당일종가	int	8</param>
/// <param name="highend">상한가	int	8</param>
/// <param name="lowend">하한가	int	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="svi_uplmtprice">정적VI상한가	int	8</param>
/// <param name="svi_dnlmtprice">정적VI하한가	int	8</param>
public record t8410OutBlock([Description("단축코드	string	6")] string shcode, [Description("전일시가	int	8")] int jisiga, [Description("전일고가	int	8")] int jihigh, [Description("전일저가	int	8")] int jilow, [Description("전일종가	int	8")] int jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	int	8")] int disiga, [Description("당일고가	int	8")] int dihigh, [Description("당일저가	int	8")] int dilow, [Description("당일종가	int	8")] int diclose, [Description("상한가	int	8")] int highend, [Description("하한가	int	8")] int lowend, [Description("연속일자	string	8")] string cts_date, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count, [Description("정적VI상한가	int	8")] int svi_uplmtprice, [Description("정적VI하한가	int	8")] int svi_dnlmtprice);

/// <summary>
/// API전용주식챠트(일주월년)(t8410): t8410: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	long	12</param>
/// <param name="high">고가	long	12</param>
/// <param name="low">저가	long	12</param>
/// <param name="close">종가	long	12</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="jongchk">수정구분	long	13</param>
/// <param name="rate">수정비율	double	6.2</param>
/// <param name="pricechk">수정주가반영항목	long	13</param>
/// <param name="ratevalue">수정비율반영거래대금	long	12</param>
/// <param name="sign">종가등락구분(1:상한2:상승3:보합4:하한5:하락주식일만사용)	string	1</param>
public record t8410OutBlock1([Description("날짜	string	8")] string date, [Description("시가	long	12")] long open, [Description("고가	long	12")] long high, [Description("저가	long	12")] long low, [Description("종가	long	12")] long close, [Description("거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value, [Description("수정구분	long	13")] long jongchk, [Description("수정비율	double	6.2")] double rate, [Description("수정주가반영항목	long	13")] long pricechk, [Description("수정비율반영거래대금	long	12")] long ratevalue, [Description("종가등락구분(1:상한2:상승3:보합4:하한5:하락주식일만사용)	string	1")] string sign);


/// <summary>
/// 주식챠트(틱/n틱)(t8411): t8411: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="ncnt">단위(n틱)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8411InBlock([Description("단축코드	string	6")] string shcode, [Description("단위(n틱)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 주식챠트(틱/n틱)(t8411): t8411: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="jisiga">전일시가	int	8</param>
/// <param name="jihigh">전일고가	int	8</param>
/// <param name="jilow">전일저가	int	8</param>
/// <param name="jiclose">전일종가	int	8</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	int	8</param>
/// <param name="dihigh">당일고가	int	8</param>
/// <param name="dilow">당일저가	int	8</param>
/// <param name="diclose">당일종가	int	8</param>
/// <param name="highend">상한가	int	8</param>
/// <param name="lowend">하한가	int	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8411OutBlock([Description("단축코드	string	6")] string shcode, [Description("전일시가	int	8")] int jisiga, [Description("전일고가	int	8")] int jihigh, [Description("전일저가	int	8")] int jilow, [Description("전일종가	int	8")] int jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	int	8")] int disiga, [Description("당일고가	int	8")] int dihigh, [Description("당일저가	int	8")] int dilow, [Description("당일종가	int	8")] int diclose, [Description("상한가	int	8")] int highend, [Description("하한가	int	8")] int lowend, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 주식챠트(틱/n틱)(t8411): t8411: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	10</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="jongchk">수정구분	long	13</param>
/// <param name="rate">수정비율	double	6.2</param>
/// <param name="pricechk">수정주가반영항목	long	13</param>
public record t8411OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	10")] string time, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("종가	int	8")] int close, [Description("거래량	long	12")] long jdiff_vol, [Description("수정구분	long	13")] long jongchk, [Description("수정비율	double	6.2")] double rate, [Description("수정주가반영항목	long	13")] long pricechk);


/// <summary>
/// 주식챠트(N분)(t8412): t8412: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="ncnt">단위(n분)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8412InBlock([Description("단축코드	string	6")] string shcode, [Description("단위(n분)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 주식챠트(N분)(t8412): t8412: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="jisiga">전일시가	int	8</param>
/// <param name="jihigh">전일고가	int	8</param>
/// <param name="jilow">전일저가	int	8</param>
/// <param name="jiclose">전일종가	int	8</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	int	8</param>
/// <param name="dihigh">당일고가	int	8</param>
/// <param name="dilow">당일저가	int	8</param>
/// <param name="diclose">당일종가	int	8</param>
/// <param name="highend">상한가	int	8</param>
/// <param name="lowend">하한가	int	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8412OutBlock([Description("단축코드	string	6")] string shcode, [Description("전일시가	int	8")] int jisiga, [Description("전일고가	int	8")] int jihigh, [Description("전일저가	int	8")] int jilow, [Description("전일종가	int	8")] int jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	int	8")] int disiga, [Description("당일고가	int	8")] int dihigh, [Description("당일저가	int	8")] int dilow, [Description("당일종가	int	8")] int diclose, [Description("상한가	int	8")] int highend, [Description("하한가	int	8")] int lowend, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 주식챠트(N분)(t8412): t8412: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	10</param>
/// <param name="open">시가	int	8</param>
/// <param name="high">고가	int	8</param>
/// <param name="low">저가	int	8</param>
/// <param name="close">종가	int	8</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="jongchk">수정구분	long	13</param>
/// <param name="rate">수정비율	double	6.2</param>
/// <param name="sign">종가등락구분(1:상한2:상승3:보합4:하한5:하락)	string	1</param>
public record t8412OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	10")] string time, [Description("시가	int	8")] int open, [Description("고가	int	8")] int high, [Description("저가	int	8")] int low, [Description("종가	int	8")] int close, [Description("거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value, [Description("수정구분	long	13")] long jongchk, [Description("수정비율	double	6.2")] double rate, [Description("종가등락구분(1:상한2:상승3:보합4:하한5:하락)	string	1")] string sign);


/// <summary>
/// 선물옵션차트(틱/n틱)(t8414): t8414: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">단위(n틱)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8414InBlock([Description("단축코드	string	8")] string shcode, [Description("단위(n틱)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 선물옵션차트(틱/n틱)(t8414): t8414: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="jisiga">전일시가	double	6.2</param>
/// <param name="jihigh">전일고가	double	6.2</param>
/// <param name="jilow">전일저가	double	6.2</param>
/// <param name="jiclose">전일종가	double	6.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	6.2</param>
/// <param name="dihigh">당일고가	double	6.2</param>
/// <param name="dilow">당일저가	double	6.2</param>
/// <param name="diclose">당일종가	double	6.2</param>
/// <param name="highend">상한가	double	6.2</param>
/// <param name="lowend">하한가	double	6.2</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8414OutBlock([Description("단축코드	string	8")] string shcode, [Description("전일시가	double	6.2")] double jisiga, [Description("전일고가	double	6.2")] double jihigh, [Description("전일저가	double	6.2")] double jilow, [Description("전일종가	double	6.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	6.2")] double disiga, [Description("당일고가	double	6.2")] double dihigh, [Description("당일저가	double	6.2")] double dilow, [Description("당일종가	double	6.2")] double diclose, [Description("상한가	double	6.2")] double highend, [Description("하한가	double	6.2")] double lowend, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 선물옵션차트(틱/n틱)(t8414): t8414: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	10</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="openyak">미결제약정	long	12</param>
public record t8414OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	10")] string time, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("거래량	long	12")] long jdiff_vol, [Description("미결제약정	long	12")] long openyak);


/// <summary>
/// 선물/옵션챠트(N분)(t8415): t8415: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">단위(n분)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8415InBlock([Description("단축코드	string	8")] string shcode, [Description("단위(n분)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 선물/옵션챠트(N분)(t8415): t8415: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="jisiga">전일시가	double	6.2</param>
/// <param name="jihigh">전일고가	double	6.2</param>
/// <param name="jilow">전일저가	double	6.2</param>
/// <param name="jiclose">전일종가	double	6.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	6.2</param>
/// <param name="dihigh">당일고가	double	6.2</param>
/// <param name="dilow">당일저가	double	6.2</param>
/// <param name="diclose">당일종가	double	6.2</param>
/// <param name="highend">상한가	double	6.2</param>
/// <param name="lowend">하한가	double	6.2</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8415OutBlock([Description("단축코드	string	8")] string shcode, [Description("전일시가	double	6.2")] double jisiga, [Description("전일고가	double	6.2")] double jihigh, [Description("전일저가	double	6.2")] double jilow, [Description("전일종가	double	6.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	6.2")] double disiga, [Description("당일고가	double	6.2")] double dihigh, [Description("당일저가	double	6.2")] double dilow, [Description("당일종가	double	6.2")] double diclose, [Description("상한가	double	6.2")] double highend, [Description("하한가	double	6.2")] double lowend, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 선물/옵션챠트(N분)(t8415): t8415: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	10</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="jdiff_vol">누적거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="openyak">미결제약정	long	12</param>
public record t8415OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	10")] string time, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("누적거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value, [Description("미결제약정	long	12")] long openyak);


/// <summary>
/// 선물/옵션챠트(일주월)(t8416): t8416: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8416InBlock([Description("단축코드	string	8")] string shcode, [Description("주기구분(2:일3:주4:월)	string	1")] string gubun, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 선물/옵션챠트(일주월)(t8416): t8416: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="jisiga">전일시가	double	6.2</param>
/// <param name="jihigh">전일고가	double	6.2</param>
/// <param name="jilow">전일저가	double	6.2</param>
/// <param name="jiclose">전일종가	double	6.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	6.2</param>
/// <param name="dihigh">당일고가	double	6.2</param>
/// <param name="dilow">당일저가	double	6.2</param>
/// <param name="diclose">당일종가	double	6.2</param>
/// <param name="highend">상한가	double	6.2</param>
/// <param name="lowend">하한가	double	6.2</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8416OutBlock([Description("단축코드	string	8")] string shcode, [Description("전일시가	double	6.2")] double jisiga, [Description("전일고가	double	6.2")] double jihigh, [Description("전일저가	double	6.2")] double jilow, [Description("전일종가	double	6.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	6.2")] double disiga, [Description("당일고가	double	6.2")] double dihigh, [Description("당일저가	double	6.2")] double dilow, [Description("당일종가	double	6.2")] double diclose, [Description("상한가	double	6.2")] double highend, [Description("하한가	double	6.2")] double lowend, [Description("연속일자	string	8")] string cts_date, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 선물/옵션챠트(일주월)(t8416): t8416: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="jdiff_vol">누적거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="openyak">미결제약정	long	12</param>
public record t8416OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("누적거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value, [Description("미결제약정	long	12")] long openyak);


/// <summary>
/// 업종차트(틱/n틱)(t8417): t8417: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="ncnt">단위(n틱)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8417InBlock([Description("단축코드	string	3")] string shcode, [Description("단위(n틱)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 업종차트(틱/n틱)(t8417): t8417: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="jisiga">전일시가	double	7.2</param>
/// <param name="jihigh">전일고가	double	7.2</param>
/// <param name="jilow">전일저가	double	7.2</param>
/// <param name="jiclose">전일종가	double	7.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	7.2</param>
/// <param name="dihigh">당일고가	double	7.2</param>
/// <param name="dilow">당일저가	double	7.2</param>
/// <param name="diclose">당일종가	double	7.2</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">장시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">장종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8417OutBlock([Description("단축코드	string	3")] string shcode, [Description("전일시가	double	7.2")] double jisiga, [Description("전일고가	double	7.2")] double jihigh, [Description("전일저가	double	7.2")] double jilow, [Description("전일종가	double	7.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	7.2")] double disiga, [Description("당일고가	double	7.2")] double dihigh, [Description("당일저가	double	7.2")] double dilow, [Description("당일종가	double	7.2")] double diclose, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("장시작시간(HHMMSS)	string	6")] string s_time, [Description("장종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 업종차트(틱/n틱)(t8417): t8417: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
public record t8417OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	7.2")] double open, [Description("고가	double	7.2")] double high, [Description("저가	double	7.2")] double low, [Description("종가	double	7.2")] double close, [Description("거래량	long	12")] long jdiff_vol);


/// <summary>
/// 업종챠트(N분)(t8418): t8418: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="ncnt">단위(n분)	int	4</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="nday">조회영업일수(0:미사용1>=사용)	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="stime">시작시간(현재미사용)	string	6</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="etime">종료시간(현재미사용)	string	6</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8418InBlock([Description("단축코드	string	3")] string shcode, [Description("단위(n분)	int	4")] int ncnt, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("조회영업일수(0:미사용1>=사용)	string	1")] string nday, [Description("시작일자	string	8")] string sdate, [Description("시작시간(현재미사용)	string	6")] string stime, [Description("종료일자	string	8")] string edate, [Description("종료시간(현재미사용)	string	6")] string etime, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 업종챠트(N분)(t8418): t8418: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="jisiga">전일시가	double	7.2</param>
/// <param name="jihigh">전일고가	double	7.2</param>
/// <param name="jilow">전일저가	double	7.2</param>
/// <param name="jiclose">전일종가	double	7.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	7.2</param>
/// <param name="dihigh">당일고가	double	7.2</param>
/// <param name="dilow">당일저가	double	7.2</param>
/// <param name="diclose">당일종가	double	7.2</param>
/// <param name="disvalue">당일거래대금	long	12</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	10</param>
/// <param name="s_time">업종시작시간(HHMMSS)	string	6</param>
/// <param name="e_time">업종종료시간(HHMMSS)	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8418OutBlock([Description("단축코드	string	3")] string shcode, [Description("전일시가	double	7.2")] double jisiga, [Description("전일고가	double	7.2")] double jihigh, [Description("전일저가	double	7.2")] double jilow, [Description("전일종가	double	7.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	7.2")] double disiga, [Description("당일고가	double	7.2")] double dihigh, [Description("당일저가	double	7.2")] double dilow, [Description("당일종가	double	7.2")] double diclose, [Description("당일거래대금	long	12")] long disvalue, [Description("연속일자	string	8")] string cts_date, [Description("연속시간	string	10")] string cts_time, [Description("업종시작시간(HHMMSS)	string	6")] string s_time, [Description("업종종료시간(HHMMSS)	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 업종챠트(N분)(t8418): t8418: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t8418OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	7.2")] double open, [Description("고가	double	7.2")] double high, [Description("저가	double	7.2")] double low, [Description("종가	double	7.2")] double close, [Description("거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value);


/// <summary>
/// 업종챠트(일주월)(t8419): t8419: InBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8419InBlock([Description("단축코드	string	3")] string shcode, [Description("주기구분(2:일3:주4:월)	string	1")] string gubun, [Description("요청건수(최대-압축:2000비압축:500)	int	4")] int qrycnt, [Description("시작일자	string	8")] string sdate, [Description("종료일자	string	8")] string edate, [Description("연속일자	string	8")] string cts_date, [Description("압축여부(Y:압축N:비압축)	string	1")] string comp_yn);

/// <summary>
/// 업종챠트(일주월)(t8419): t8419: OutBlock
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="jisiga">전일시가	double	7.2</param>
/// <param name="jihigh">전일고가	double	7.2</param>
/// <param name="jilow">전일저가	double	7.2</param>
/// <param name="jiclose">전일종가	double	7.2</param>
/// <param name="jivolume">전일거래량	long	12</param>
/// <param name="disiga">당일시가	double	7.2</param>
/// <param name="dihigh">당일고가	double	7.2</param>
/// <param name="dilow">당일저가	double	7.2</param>
/// <param name="diclose">당일종가	double	7.2</param>
/// <param name="disvalue">당일거래대금	long	12</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="s_time">업종시작시간	string	6</param>
/// <param name="e_time">업종종료시간	string	6</param>
/// <param name="dshmin">동시호가처리시간(MM:분)	string	2</param>
/// <param name="rec_count">레코드카운트	int	7</param>
public record t8419OutBlock([Description("단축코드	string	3")] string shcode, [Description("전일시가	double	7.2")] double jisiga, [Description("전일고가	double	7.2")] double jihigh, [Description("전일저가	double	7.2")] double jilow, [Description("전일종가	double	7.2")] double jiclose, [Description("전일거래량	long	12")] long jivolume, [Description("당일시가	double	7.2")] double disiga, [Description("당일고가	double	7.2")] double dihigh, [Description("당일저가	double	7.2")] double dilow, [Description("당일종가	double	7.2")] double diclose, [Description("당일거래대금	long	12")] long disvalue, [Description("연속일자	string	8")] string cts_date, [Description("업종시작시간	string	6")] string s_time, [Description("업종종료시간	string	6")] string e_time, [Description("동시호가처리시간(MM:분)	string	2")] string dshmin, [Description("레코드카운트	int	7")] int rec_count);

/// <summary>
/// 업종챠트(일주월)(t8419): t8419: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t8419OutBlock1([Description("날짜	string	8")] string date, [Description("시가	double	7.2")] double open, [Description("고가	double	7.2")] double high, [Description("저가	double	7.2")] double low, [Description("종가	double	7.2")] double close, [Description("거래량	long	12")] long jdiff_vol, [Description("거래대금	long	12")] long value);


/// <summary>
/// 전체업종(t8424): t8424: InBlock
/// </summary>
/// <param name="gubun1">구분1	string	1</param>
public record t8424InBlock([Description("구분1	string	1")] string gubun1);

/// <summary>
/// 전체업종(t8424): t8424: OutBlock
/// </summary>
/// <param name="hname">업종명	string	20</param>
/// <param name="upcode">업종코드	string	3</param>
public record t8424OutBlock([Description("업종명	string	20")] string hname, [Description("업종코드	string	3")] string upcode);


/// <summary>
/// 전체테마(t8425): t8425: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8425InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// 전체테마(t8425): t8425: OutBlock
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t8425OutBlock([Description("테마명	string	36")] string tmname, [Description("테마코드	string	4")] string tmcode);


/// <summary>
/// 상품선물마스터조회(API용)(t8426): t8426: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8426InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// 상품선물마스터조회(API용)(t8426): t8426: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t8426OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode);


/// <summary>
/// 과거데이터시간대별조회(t8427): t8427: InBlock
/// </summary>
/// <param name="fo_gbn">선물옵션구분	string	1</param>
/// <param name="yyyy">조회년도	string	4</param>
/// <param name="mm">조회월	string	2</param>
/// <param name="cp_gbn">옵션콜풋구분	string	1</param>
/// <param name="actprice">옵션행사가	double	6.2</param>
/// <param name="focode">선물옵션코드	string	8</param>
/// <param name="dt_gbn">일분구분	string	1</param>
/// <param name="min_term">분간격	string	2</param>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
public record t8427InBlock([Description("선물옵션구분	string	1")] string fo_gbn, [Description("조회년도	string	4")] string yyyy, [Description("조회월	string	2")] string mm, [Description("옵션콜풋구분	string	1")] string cp_gbn, [Description("옵션행사가	double	6.2")] double actprice, [Description("선물옵션코드	string	8")] string focode, [Description("일분구분	string	1")] string dt_gbn, [Description("분간격	string	2")] string min_term, [Description("날짜	string	8")] string date, [Description("시간	string	6")] string time);

/// <summary>
/// 과거데이터시간대별조회(t8427): t8427: OutBlock
/// </summary>
/// <param name="focode">선물옵션코드	string	8</param>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
public record t8427OutBlock([Description("선물옵션코드	string	8")] string focode, [Description("날짜	string	8")] string date, [Description("시간	string	6")] string time);

/// <summary>
/// 과거데이터시간대별조회(t8427): t8427: OutBlock1
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="diff_vol">거래증가율	double	10.2</param>
/// <param name="openyak">미결수량	int	8</param>
/// <param name="openyakupdn">미결증감	int	8</param>
/// <param name="value">거래대금	double	12</param>
public record t8427OutBlock1([Description("날짜	string	8")] string date, [Description("시간	string	6")] string time, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("종가	double	6.2")] double close, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("거래증가율	double	10.2")] double diff_vol, [Description("미결수량	int	8")] int openyak, [Description("미결증감	int	8")] int openyakupdn, [Description("거래대금	double	12")] double value);


/// <summary>
/// 증시주변자금추이(t8428): t8428: InBlock
/// </summary>
/// <param name="fdate">from일자	string	8</param>
/// <param name="tdate">to일자	string	8</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="key_date">날짜	string	8</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8428InBlock([Description("from일자	string	8")] string fdate, [Description("to일자	string	8")] string tdate, [Description("구분	string	1")] string gubun, [Description("날짜	string	8")] string key_date, [Description("업종코드	string	3")] string upcode, [Description("조회건수	int	3")] int cnt);

/// <summary>
/// 증시주변자금추이(t8428): t8428: OutBlock
/// </summary>
/// <param name="date">날짜CTS	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t8428OutBlock([Description("날짜CTS	string	8")] string date, [Description("IDX	int	4")] int idx);

/// <summary>
/// 증시주변자금추이(t8428): t8428: OutBlock1
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="jisu">지수	double	7.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="custmoney">고객예탁금_억원	long	12</param>
/// <param name="yecha">예탁증감_억원	long	12</param>
/// <param name="vol">회전율	double	6.2</param>
/// <param name="outmoney">미수금_억원	long	12</param>
/// <param name="trjango">신용잔고_억원	long	12</param>
/// <param name="futymoney">선물예수금_억원	long	12</param>
/// <param name="stkmoney">주식형_억원	int	8</param>
/// <param name="mstkmoney">혼합형_억원(주식)	int	8</param>
/// <param name="mbndmoney">혼합형_억원(채권)	int	8</param>
/// <param name="bndmoney">채권형_억원	int	8</param>
/// <param name="bndsmoney">필러(구.단기채권)	int	8</param>
/// <param name="mmfmoney">MMF_억원(주식)	int	8</param>
public record t8428OutBlock1([Description("일자	string	8")] string date, [Description("지수	double	7.2")] double jisu, [Description("대비구분	string	1")] string sign, [Description("대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("거래량	long	12")] long volume, [Description("고객예탁금_억원	long	12")] long custmoney, [Description("예탁증감_억원	long	12")] long yecha, [Description("회전율	double	6.2")] double vol, [Description("미수금_억원	long	12")] long outmoney, [Description("신용잔고_억원	long	12")] long trjango, [Description("선물예수금_억원	long	12")] long futymoney, [Description("주식형_억원	int	8")] int stkmoney, [Description("혼합형_억원(주식)	int	8")] int mstkmoney, [Description("혼합형_억원(채권)	int	8")] int mbndmoney, [Description("채권형_억원	int	8")] int bndmoney, [Description("필러(구.단기채권)	int	8")] int bndsmoney, [Description("MMF_억원(주식)	int	8")] int mmfmoney);


/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트(t8429): t8429: InBlock
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8429InBlock([Description("단축코드	string	8")] string focode, [Description("챠트구분	string	1")] string cgubun, [Description("분구분	int	3")] int bgubun, [Description("조회건수	int	3")] int cnt);

/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트(t8429): t8429: OutBlock1
/// </summary>
/// <param name="chetime">시간	string	10</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="s_mschecnt">매수순간체결건수	int	8</param>
/// <param name="s_mdchecnt">매도순간체결건수	int	8</param>
/// <param name="ss_mschecnt">순매수순간체결건수	int	8</param>
/// <param name="s_mschevol">매수순간체결량	double	12</param>
/// <param name="s_mdchevol">매도순간체결량	double	12</param>
/// <param name="ss_mschevol">순매수순간체결량	double	12</param>
/// <param name="chdegvol">체결강도(거래량)	double	8.2</param>
/// <param name="chdegcnt">체결강도(건수)	double	8.2</param>
public record t8429OutBlock1([Description("시간	string	10")] string chetime, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("시가	double	6.2")] double open, [Description("고가	double	6.2")] double high, [Description("저가	double	6.2")] double low, [Description("거래량	double	12")] double volume, [Description("체결수량	int	8")] int cvolume, [Description("매수순간체결건수	int	8")] int s_mschecnt, [Description("매도순간체결건수	int	8")] int s_mdchecnt, [Description("순매수순간체결건수	int	8")] int ss_mschecnt, [Description("매수순간체결량	double	12")] double s_mschevol, [Description("매도순간체결량	double	12")] double s_mdchevol, [Description("순매수순간체결량	double	12")] double ss_mschevol, [Description("체결강도(거래량)	double	8.2")] double chdegvol, [Description("체결강도(건수)	double	8.2")] double chdegcnt);


/// <summary>
/// 주식종목조회(t8430): t8430: InBlock
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t8430InBlock([Description("구분(0:전체1:코스피2:코스닥)	string	1")] string gubun);

/// <summary>
/// 주식종목조회(t8430): t8430: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="etfgubun">ETF구분(1:ETF)	string	1</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="jnilclose">전일가	int	8</param>
/// <param name="memedan">주문수량단위	string	5</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="gubun">구분(1:코스피2:코스닥)	string	1</param>
public record t8430OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	6")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("ETF구분(1:ETF)	string	1")] string etfgubun, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("전일가	int	8")] int jnilclose, [Description("주문수량단위	string	5")] string memedan, [Description("기준가	int	8")] int recprice, [Description("구분(1:코스피2:코스닥)	string	1")] string gubun);


/// <summary>
/// ELW종목조회(t8431): t8431: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8431InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// ELW종목조회(t8431): t8431: OutBlock
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="recprice">기준가	int	8</param>
public record t8431OutBlock([Description("종목명	string	40")] string hname, [Description("단축코드	string	6")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("전일종가	int	8")] int jnilclose, [Description("기준가	int	8")] int recprice);


/// <summary>
/// 지수선물마스터조회API용(t8432): t8432: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
public record t8432InBlock([Description("구분	string	1")] string gubun);

/// <summary>
/// 지수선물마스터조회API용(t8432): t8432: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="uplmtprice">상한가	double	6.2</param>
/// <param name="dnlmtprice">하한가	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="jnilhigh">전일고가	double	6.2</param>
/// <param name="jnillow">전일저가	double	6.2</param>
/// <param name="recprice">기준가	double	6.2</param>
public record t8432OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("상한가	double	6.2")] double uplmtprice, [Description("하한가	double	6.2")] double dnlmtprice, [Description("전일종가	double	6.2")] double jnilclose, [Description("전일고가	double	6.2")] double jnilhigh, [Description("전일저가	double	6.2")] double jnillow, [Description("기준가	double	6.2")] double recprice);


/// <summary>
/// 지수옵션마스터조회API용(t8433): t8433: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8433InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// 지수옵션마스터조회API용(t8433): t8433: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="hprice">상한가	double	6.2</param>
/// <param name="lprice">하한가	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="jnilhigh">전일고가	double	6.2</param>
/// <param name="jnillow">전일저가	double	6.2</param>
/// <param name="recprice">기준가	double	6.2</param>
public record t8433OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("상한가	double	6.2")] double hprice, [Description("하한가	double	6.2")] double lprice, [Description("전일종가	double	6.2")] double jnilclose, [Description("전일고가	double	6.2")] double jnilhigh, [Description("전일저가	double	6.2")] double jnillow, [Description("기준가	double	6.2")] double recprice);


/// <summary>
/// 선물/옵션멀티현재가조회(t8434): t8434: InBlock
/// </summary>
/// <param name="qrycnt">건수	int	3</param>
/// <param name="focode">단축코드	string	400</param>
public record t8434InBlock([Description("건수	int	3")] int qrycnt, [Description("단축코드	string	400")] string focode);

/// <summary>
/// 선물/옵션멀티현재가조회(t8434): t8434: OutBlock1
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="checnt">체결건수	int	8</param>
/// <param name="focode">단축코드	string	8</param>
public record t8434OutBlock1([Description("한글명	string	20")] string hname, [Description("현재가	double	6.2")] double price, [Description("전일대비구분	string	1")] string sign, [Description("전일대비	double	6.2")] double change, [Description("등락율	double	6.2")] double diff, [Description("누적거래량	long	12")] long volume, [Description("체결건수	int	8")] int checnt, [Description("단축코드	string	8")] string focode);


/// <summary>
/// 파생종목마스터조회API용(t8435): t8435: InBlock
/// </summary>
/// <param name="gubun">구분(MF/MO)	string	2</param>
public record t8435InBlock([Description("구분(MF/MO)	string	2")] string gubun);

/// <summary>
/// 파생종목마스터조회API용(t8435): t8435: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="uplmtprice">상한가	double	6.2</param>
/// <param name="dnlmtprice">하한가	double	6.2</param>
/// <param name="jnilclose">전일종가	double	6.2</param>
/// <param name="jnilhigh">전일고가	double	6.2</param>
/// <param name="jnillow">전일저가	double	6.2</param>
/// <param name="recprice">기준가	double	6.2</param>
public record t8435OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("상한가	double	6.2")] double uplmtprice, [Description("하한가	double	6.2")] double dnlmtprice, [Description("전일종가	double	6.2")] double jnilclose, [Description("전일고가	double	6.2")] double jnilhigh, [Description("전일저가	double	6.2")] double jnillow, [Description("기준가	double	6.2")] double recprice);


/// <summary>
/// 주식종목조회 API용(t8436): t8436: InBlock
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t8436InBlock([Description("구분(0:전체1:코스피2:코스닥)	string	1")] string gubun);

/// <summary>
/// 주식종목조회 API용(t8436): t8436: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="etfgubun">ETF구분(1:ETF2:ETN)	string	1</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="jnilclose">전일가	int	8</param>
/// <param name="memedan">주문수량단위	string	5</param>
/// <param name="recprice">기준가	int	8</param>
/// <param name="gubun">구분(1:코스피2:코스닥)	string	1</param>
/// <param name="bu12gubun">증권그룹	string	2</param>
/// <param name="spac_gubun">기업인수목적회사여부(Y/N)	string	1</param>
/// <param name="filler">filler(미사용)	string	32</param>
public record t8436OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	6")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("ETF구분(1:ETF2:ETN)	string	1")] string etfgubun, [Description("상한가	int	8")] int uplmtprice, [Description("하한가	int	8")] int dnlmtprice, [Description("전일가	int	8")] int jnilclose, [Description("주문수량단위	string	5")] string memedan, [Description("기준가	int	8")] int recprice, [Description("구분(1:코스피2:코스닥)	string	1")] string gubun, [Description("증권그룹	string	2")] string bu12gubun, [Description("기업인수목적회사여부(Y/N)	string	1")] string spac_gubun, [Description("filler(미사용)	string	32")] string filler);


/// <summary>
/// CME/EUREX마스터조회(API용)(t8437): t8437: InBlock
/// </summary>
/// <param name="gubun">구분(NF/NC/NM/NO)	string	2</param>
public record t8437InBlock([Description("구분(NF/NC/NM/NO)	string	2")] string gubun);

/// <summary>
/// CME/EUREX마스터조회(API용)(t8437): t8437: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">종목코드	string	8</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="tradeunit">거래승수	double	21.8</param>
/// <param name="atmgb">ATM구분(1:ATM2:ITM3:OTM)	string	1</param>
public record t8437OutBlock([Description("종목명	string	20")] string hname, [Description("종목코드	string	8")] string shcode, [Description("표준코드	string	12")] string expcode, [Description("거래승수	double	21.8")] double tradeunit, [Description("ATM구분(1:ATM2:ITM3:OTM)	string	1")] string atmgb);


/// <summary>
/// 기초자산리스트조회(t9905): t9905: InBlock
/// </summary>
/// <param name="dummy">DUMMY	string	1</param>
public record t9905InBlock([Description("DUMMY	string	1")] string dummy);

/// <summary>
/// 기초자산리스트조회(t9905): t9905: OutBlock1
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="hname">종목명	string	20</param>
public record t9905OutBlock1([Description("단축코드	string	6")] string shcode, [Description("표준코드	string	12")] string expcode, [Description("종목명	string	20")] string hname);


/// <summary>
/// 만기월조회(t9907): t9907: InBlock
/// </summary>
/// <param name="dummy">DUMMY	string	1</param>
public record t9907InBlock([Description("DUMMY	string	1")] string dummy);

/// <summary>
/// 만기월조회(t9907): t9907: OutBlock1
/// </summary>
/// <param name="lastym">만기월	string	6</param>
/// <param name="lastnm">만기월명	string	10</param>
public record t9907OutBlock1([Description("만기월	string	6")] string lastym, [Description("만기월명	string	10")] string lastnm);


/// <summary>
/// ELW마스터조회API용(t9942): t9942: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t9942InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// ELW마스터조회API용(t9942): t9942: OutBlock
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9942OutBlock([Description("종목명	string	40")] string hname, [Description("단축코드	string	6")] string shcode, [Description("확장코드	string	12")] string expcode);


/// <summary>
/// 지수선물마스터조회API용(t9943): t9943: InBlock
/// </summary>
/// <param name="gubun">구분	string	1</param>
public record t9943InBlock([Description("구분	string	1")] string gubun);

/// <summary>
/// 지수선물마스터조회API용(t9943): t9943: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9943OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode);


/// <summary>
/// 지수옵션마스터조회API용(t9944): t9944: InBlock
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t9944InBlock([Description("Dummy	string	1")] string dummy);

/// <summary>
/// 지수옵션마스터조회API용(t9944): t9944: OutBlock
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9944OutBlock([Description("종목명	string	20")] string hname, [Description("단축코드	string	8")] string shcode, [Description("확장코드	string	12")] string expcode);

// 여기는 수동으로 추가함

/// <summary>
/// 주식마스터조회API용-종목명40bytes(t9945): t9945: InBlock
/// </summary>
/// <param name="gubun">구분(KSP:1KSD:2)	string	1</param>
public record t9945InBlock([Description("구분(KSP:1KSD:2)	string	1")] string gubun);

/// <summary>
/// 주식마스터조회API용-종목명40bytes(t9945): t9945: OutBlock
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="etfchk">ETF구분	string	1</param>
/// <param name="filler">filler	string	5</param>
public record t9945OutBlock([Description("종목명	string	40")] string hname, [Description("단축코드	string	6")] string shcode, [Description("확장코드	string	12")] string expcode, [Description("ETF구분	string	1")] string etfchk, [Description("filler	string	5")] string filler);


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
