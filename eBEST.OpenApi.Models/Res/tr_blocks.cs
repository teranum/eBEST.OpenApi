// [2024-02-13 오후 9:25:02]
// 이 파일은 ResToModel 에 의해 자동으로 만들어졌습니다.
// XingAPI Res폴더의 .res 파일에서 변환되었습니다.
namespace eBEST.OpenApi.Models;

/// <summary>
/// 계좌 거래내역: CDPCQ04700
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
public record CDPCQ04700InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("시작번호", 10)] long SrtNo,
    [BlockField("상품유형코드", 2)] string PdptnCode,
    [BlockField("종목대분류코드", 2)] string IsuLgclssCode,
    [BlockField("종목번호", 12)] string IsuNo
    );

/// <summary>
/// 계좌 거래내역: CDPCQ04700
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
public record CDPCQ04700OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("시작번호", 10)] long SrtNo,
    [BlockField("상품유형코드", 2)] string PdptnCode,
    [BlockField("종목대분류코드", 2)] string IsuLgclssCode,
    [BlockField("종목번호", 12)] string IsuNo
    );

/// <summary>
/// 계좌 거래내역: CDPCQ04700
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
public record CDPCQ04700OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm
    );

/// <summary>
/// 계좌 거래내역: CDPCQ04700
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
public record CDPCQ04700OutBlock3(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("거래일자", 8)] string TrdDt,
    [BlockField("거래번호", 10)] long TrdNo,
    [BlockField("구분코드명", 50)] string TpCodeNm,
    [BlockField("적요번호", 4)] string SmryNo,
    [BlockField("적요명", 40)] string SmryNm,
    [BlockField("취소구분", 20)] string CancTpNm,
    [BlockField("거래수량", 16)] long TrdQty,
    [BlockField("거래세", 16)] long Trtax,
    [BlockField("외화정산금액", 25.4)] double FcurrAdjstAmt,
    [BlockField("정산금액", 16)] long AdjstAmt,
    [BlockField("연체합", 16)] long OvdSum,
    [BlockField("예수금전잔금액", 16)] long DpsBfbalAmt,
    [BlockField("매도담보상환금", 16)] long SellPldgRfundAmt,
    [BlockField("예탁담보대출전잔금액", 16)] long DpspdgLoanBfbalAmt,
    [BlockField("거래매체명", 40)] string TrdmdaNm,
    [BlockField("원거래번호", 10)] long OrgTrdNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("거래단가", 13.2)] double TrdUprc,
    [BlockField("수수료", 16)] long CmsnAmt,
    [BlockField("외화수수료금액", 15.2)] double FcurrCmsnAmt,
    [BlockField("상환차이금액", 16)] long RfundDiffAmt,
    [BlockField("변제금합계", 16)] long RepayAmtSum,
    [BlockField("유가증권금잔수량", 16)] long SecCrbalQty,
    [BlockField("매도대금담보대출상환이자금액", 16)] long CslLoanRfundIntrstAmt,
    [BlockField("예탁담보대출금잔금액", 16)] long DpspdgLoanCrbalAmt,
    [BlockField("처리시각", 9)] string TrxTime,
    [BlockField("출납번호", 10)] long Inouno,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("거래금액", 16)] long TrdAmt,
    [BlockField("수표금액", 16)] long ChckAmt,
    [BlockField("세금합계금액", 16)] long TaxSumAmt,
    [BlockField("외화세금합계금액", 26.6)] double FcurrTaxSumAmt,
    [BlockField("이자이용료", 16)] long IntrstUtlfee,
    [BlockField("배당금액", 16)] long MnyDvdAmt,
    [BlockField("미수발생금액", 16)] long RcvblOcrAmt,
    [BlockField("처리지점번호", 3)] string TrxBrnNo,
    [BlockField("처리지점명", 40)] string TrxBrnNm,
    [BlockField("예탁담보대출금액", 16)] long DpspdgLoanAmt,
    [BlockField("예탁담보대출상환금액", 16)] long DpspdgLoanRfundAmt,
    [BlockField("기준가", 13.2)] double BasePrc,
    [BlockField("예수금금잔금액", 16)] long DpsCrbalAmt,
    [BlockField("과표", 16)] long BoaAmt,
    [BlockField("출금가능금액", 16)] long MnyoutAbleAmt,
    [BlockField("수익증권담보대출발생금", 16)] long BcrLoanOcrAmt,
    [BlockField("수익증권담보대출전잔금", 16)] long BcrLoanBfbalAmt,
    [BlockField("매매기준가", 20.1)] double BnsBasePrc,
    [BlockField("과세기준가", 20.1)] double TaxchrBasePrc,
    [BlockField("거래좌수", 16)] long TrdUnit,
    [BlockField("잔고좌수", 16)] long BalUnit,
    [BlockField("제세금", 16)] long EvrTax,
    [BlockField("평가금액", 16)] long EvalAmt,
    [BlockField("수익증권담보대출상환금", 16)] long BcrLoanRfundAmt,
    [BlockField("수익증권담보대출금잔금", 16)] long BcrLoanCrbalAmt,
    [BlockField("추가증거금발생총액", 16)] long AddMgnOcrTotamt,
    [BlockField("추가현금증거금발생금액", 16)] long AddMnyMgnOcrAmt,
    [BlockField("추가증거금납부총액", 16)] long AddMgnDfryTotamt,
    [BlockField("추가현금증거금납부금액", 16)] long AddMnyMgnDfryAmt,
    [BlockField("매매손익금액", 16)] long BnsplAmt,
    [BlockField("소득세", 16)] long Ictax,
    [BlockField("주민세", 16)] long Ihtax,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("통화코드", 3)] string CrcyCode,
    [BlockField("외화금액", 24.4)] double FcurrAmt,
    [BlockField("외화거래금액", 24.4)] double FcurrTrdAmt,
    [BlockField("외화예수금", 21.4)] double FcurrDps,
    [BlockField("외화예수금전잔금액", 21.4)] double FcurrDpsBfbalAmt,
    [BlockField("상대계좌명", 40)] string OppAcntNm,
    [BlockField("상대계좌번호", 20)] string OppAcntNo,
    [BlockField("대출상환금액", 16)] long LoanRfundAmt,
    [BlockField("대출이자금액", 16)] long LoanIntrstAmt,
    [BlockField("의뢰인명", 40)] string AskpsnNm,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("거래환율", 15.4)] double TrdXchrat,
    [BlockField("감면수수료", 21.4)] double RdctCmsn,
    [BlockField("외화인지세", 21.4)] double FcurrStmpTx,
    [BlockField("외화전자금융거래세", 21.4)] double FcurrElecfnTrtax,
    [BlockField("외화증권거래세", 21.4)] double FcstckTrtax
    );

/// <summary>
/// 계좌 거래내역: CDPCQ04700
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="PnlSumAmt">손익합계금액	long	16</param>
/// <param name="CtrctAsm">약정누계	long	16</param>
/// <param name="CmsnAmtSumAmt">수수료합계금액	long	16</param>
public record CDPCQ04700OutBlock4(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("손익합계금액", 16)] long PnlSumAmt,
    [BlockField("약정누계", 16)] long CtrctAsm,
    [BlockField("수수료합계금액", 16)] long CmsnAmtSumAmt
    );

/// <summary>
/// 계좌 거래내역: CDPCQ04700
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
public record CDPCQ04700OutBlock5(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("입금금액", 16)] long MnyinAmt,
    [BlockField("입고금액", 16)] long SecinAmt,
    [BlockField("출금금액", 16)] long MnyoutAmt,
    [BlockField("출고금액", 16)] long SecoutAmt,
    [BlockField("차이금액", 16)] long DiffAmt,
    [BlockField("차이금액0", 16)] long DiffAmt0,
    [BlockField("매도수량", 16)] long SellQty,
    [BlockField("매도금액", 16)] long SellAmt,
    [BlockField("매도수수료", 16)] long SellCmsn,
    [BlockField("제세금", 19)] long EvrTax,
    [BlockField("외화매도정산금액", 25.4)] double FcurrSellAdjstAmt,
    [BlockField("매수수량", 16)] long BuyQty,
    [BlockField("매수금액", 16)] long BuyAmt,
    [BlockField("매수수수료", 16)] long BuyCmsn,
    [BlockField("체결세금", 16)] long ExecTax,
    [BlockField("외화매수정산금액", 25.4)] double FcurrBuyAdjstAmt
    );


/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">지점번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ21100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("선택입력구분", 1)] string ChoicInptTpCode,
    [BlockField("지점번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp
    );

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="ChoicInptTpCode">선택입력구분	string	1</param>
/// <param name="AcntNo">지점번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="PrdtExecTpCode">체결구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
public record CEXAQ21100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("선택입력구분", 1)] string ChoicInptTpCode,
    [BlockField("지점번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp
    );

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="ExecQty">체결수량	long	16</param>
public record CEXAQ21100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("체결수량", 16)] long ExecQty
    );

/// <summary>
/// 유렉스 주문체결내역조회: CEXAQ21100
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
public record CEXAQ21100OutBlock3(
    [BlockField("계좌번호1", 20)] string AcntNo1,
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("정정취소구분명", 10)] string MrcTpNm,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode,
    [BlockField("선물옵션호가유형명", 40)] string FnoOrdprcPtnNm,
    [BlockField("주문조건가격", 25.8)] double OrdCndiPrc,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문구분명", 10)] string OrdTpNm,
    [BlockField("체결가", 13.2)] double ExecPrc,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("통신매체명", 40)] string CommdaNm
    );


/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200
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
public record CEXAQ21200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("비율값", 19.8)] double RatVal,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode
    );

/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200
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
public record CEXAQ21200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("비율값", 19.8)] double RatVal,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode
    );

/// <summary>
/// 유렉스 주문가능 수량/금액 조회: CEXAQ21200
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
public record CEXAQ21200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("조회일", 8)] string QryDt,
    [BlockField("현재가", 15.2)] double NowPrc,
    [BlockField("주문가능수량", 16)] long OrdAbleQty,
    [BlockField("신규주문가능수량", 16)] long NewOrdAbleQty,
    [BlockField("청산주문가능수량", 16)] long LqdtOrdAbleQty,
    [BlockField("사용예정증거금액", 16)] long UsePreargMgn,
    [BlockField("사용예정현금증거금액", 16)] long UsePreargMnyMgn,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt
    );


/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuCode">종목코드	string	12</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목코드", 12)] string IsuCode,
    [BlockField("잔고평가구분", 1)] string BalEvalTp,
    [BlockField("선물가격평가구분", 1)] string FutsPrcEvalTp
    );

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuCode">종목코드	string	12</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목코드", 12)] string IsuCode,
    [BlockField("잔고평가구분", 1)] string BalEvalTp,
    [BlockField("선물가격평가구분", 1)] string FutsPrcEvalTp
    );

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="BnsplAmt">매매손익금액	long	16</param>
/// <param name="AdjstDfamt">정산차금	long	16</param>
/// <param name="TotEvalAmt">총평가금액	long	16</param>
/// <param name="TotPnlAmt">총손익금액	long	16</param>
public record CEXAQ31100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("매매손익금액", 16)] long BnsplAmt,
    [BlockField("정산차금", 16)] long AdjstDfamt,
    [BlockField("총평가금액", 16)] long TotEvalAmt,
    [BlockField("총손익금액", 16)] long TotPnlAmt
    );

/// <summary>
/// 유렉스 야간장잔고및 평가현황: CEXAQ31100
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
public record CEXAQ31100OutBlock3(
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("미결제수량", 16)] long UnsttQty,
    [BlockField("청산가능수량", 16)] long LqdtAbleQty,
    [BlockField("평균가", 19.8)] double FnoAvrPrc,
    [BlockField("기준가", 30.1)] double BasePrc,
    [BlockField("현재가", 13.2)] double NowPrc,
    [BlockField("대비가", 13.2)] double CmpPrc,
    [BlockField("평가금액", 16)] long EvalAmt,
    [BlockField("평가손익", 16)] long EvalPnl,
    [BlockField("손익률", 12.6)] double PnlRat,
    [BlockField("미결제금액", 16)] long UnsttAmt,
    [BlockField("매매손익금액", 16)] long BnsplAmt
    );


/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("잔고평가구분", 1)] string BalEvalTp,
    [BlockField("선물가격평가구분", 1)] string FutsPrcEvalTp
    );

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="BalEvalTp">잔고평가구분	string	1</param>
/// <param name="FutsPrcEvalTp">선물가격평가구분	string	1</param>
public record CEXAQ31200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("잔고평가구분", 1)] string BalEvalTp,
    [BlockField("선물가격평가구분", 1)] string FutsPrcEvalTp
    );

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200
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
public record CEXAQ31200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("평가예탁금총액", 15)] long EvalDpsamtTotamt,
    [BlockField("현금평가예탁금액", 15)] long MnyEvalDpstgAmt,
    [BlockField("예탁금총액", 16)] long DpsamtTotamt,
    [BlockField("예탁현금", 16)] long DpstgMny,
    [BlockField("인출가능총금액", 15)] long PsnOutAbleTotAmt,
    [BlockField("인출가능현금액", 16)] long PsnOutAbleCurAmt,
    [BlockField("주문가능총금액", 15)] long OrdAbleTotAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("위탁증거금총액", 16)] long CsgnMgnTotamt,
    [BlockField("현금위탁증거금액", 16)] long MnyCsgnMgn,
    [BlockField("추가증거금총액", 15)] long AddMgnTotamt,
    [BlockField("현금추가증거금액", 16)] long MnyAddMgn,
    [BlockField("수수료", 16)] long CmsnAmt,
    [BlockField("선물평가손익금액", 16)] long FutsEvalPnlAmt,
    [BlockField("옵션평가손익금액", 16)] long OptEvalPnlAmt,
    [BlockField("옵션평가금액", 16)] long OptEvalAmt,
    [BlockField("옵션매매손익금액", 16)] long OptBnsplAmt,
    [BlockField("선물정산차금", 16)] long FutsAdjstDfamt,
    [BlockField("총손익금액", 16)] long TotPnlAmt,
    [BlockField("순손익금액", 16)] long NetPnlAmt,
    [BlockField("총평가금액", 16)] long TotEvalAmt,
    [BlockField("입금금액", 16)] long MnyinAmt,
    [BlockField("출금금액", 16)] long MnyoutAmt,
    [BlockField("선물수수료금액", 16)] long FutsCmsnAmt
    );

/// <summary>
/// 유렉스 예탁금 및 통합잔고조회: CEXAQ31200
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
public record CEXAQ31200OutBlock3(
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("미결제수량", 16)] long UnsttQty,
    [BlockField("평균가", 19.8)] double FnoAvrPrc,
    [BlockField("현재가", 13.2)] double NowPrc,
    [BlockField("대비가", 13.2)] double CmpPrc,
    [BlockField("평가손익", 16)] long EvalPnl,
    [BlockField("손익률", 12.6)] double PnlRat,
    [BlockField("평가금액", 16)] long EvalAmt,
    [BlockField("청산가능수량", 16)] long LqdtAbleQty
    );


/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200
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
public record CEXAQ44200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("선택입력구분", 1)] string ChoicInptTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("선물옵션거래유형코드", 2)] string FnoTrdPtnCode,
    [BlockField("시작주문번호2", 10)] long SrtOrdNo2,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp
    );

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200
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
public record CEXAQ44200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("선택입력구분", 1)] string ChoicInptTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("선물옵션거래유형코드", 2)] string FnoTrdPtnCode,
    [BlockField("시작주문번호2", 10)] long SrtOrdNo2,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp
    );

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="ExecQty">체결수량	long	16</param>
/// <param name="UnercQty">미체결수량	long	16</param>
/// <param name="ExecPrc">체결가	double	15.2</param>
public record CEXAQ44200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("체결가", 15.2)] double ExecPrc
    );

/// <summary>
/// EUREX 야간옵션 기간주문체결조회: CEXAQ44200
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
public record CEXAQ44200OutBlock3(
    [BlockField("계좌번호1", 20)] string AcntNo1,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("유렉스호가구분코드", 1)] string ErxOrdprcTpCode,
    [BlockField("정정취소구분명", 10)] string MrcTpNm,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode,
    [BlockField("코드명", 40)] string CodeNm,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("선물옵션거부사유코드", 3)] string FnoRjtRsnCode,
    [BlockField("주문구분명", 10)] string OrdTpNm,
    [BlockField("체결구분명", 10)] string ExecTpNm,
    [BlockField("체결가", 13.2)] double ExecPrc,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("체결시각", 9)] string ExecTime,
    [BlockField("체결번호", 10)] long ExecNo,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("사용자ID", 16)] string UserId,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("통신매체코드명", 40)] string CommdaCodeNm,
    [BlockField("IP주소", 16)] string IpAddr,
    [BlockField("거래유형구분", 20)] string TrdPtnTpNm,
    [BlockField("유렉스주문상태코드", 1)] string ErxOrdStatCode,
    [BlockField("코드명0", 40)] string CodeNm0,
    [BlockField("거래소접수시각", 30)] string ExchRcptTime
    );


/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="ErxPrcCndiTpCode">유렉스가격조건구분코드	string	1</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CEXAT11100InBlock1(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("주문수량", 16)] long OrdQty
    );

/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100
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
public record CEXAT11100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문조건가격", 25.8)] double OrdCndiPrc,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 유렉스 매수/매도주문: CEXAT11100
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
public record CEXAT11100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금", 16)] long OrdMgn,
    [BlockField("현금주문증거금", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 유렉스 정정주문: CEXAT11200
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
public record CEXAT11200InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("주문가격", 15.2)] double OrdPrc
    );

/// <summary>
/// 유렉스 정정주문: CEXAT11200
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
public record CEXAT11200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("유렉스가격조건구분코드", 1)] string ErxPrcCndiTpCode,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("정정수량", 16)] long MdfyQty,
    [BlockField("주문조건가격", 25.8)] double OrdCndiPrc,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 유렉스 정정주문: CEXAT11200
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
public record CEXAT11200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금액", 16)] long OrdMgn,
    [BlockField("현금주문증거금액", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 유렉스 취소주문: CEXAT11300
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
public record CEXAT11300InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo
    );

/// <summary>
/// 유렉스 취소주문: CEXAT11300
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="CancQty">취소수량	long	16</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CEXAT11300OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("취소수량", 16)] long CancQty,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 유렉스 취소주문: CEXAT11300
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
public record CEXAT11300OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금액", 16)] long OrdMgn,
    [BlockField("현금주문증거금액", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600
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
public record CFOAQ00600InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("선물옵션분류코드", 2)] string FnoClssCode,
    [BlockField("상품군코드", 2)] string PrdgrpCode,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600
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
public record CFOAQ00600OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("선물옵션분류코드", 2)] string FnoClssCode,
    [BlockField("상품군코드", 2)] string PrdgrpCode,
    [BlockField("체결구분", 1)] string PrdtExecTpCode,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="FutsOrdQty">선물주문수량	long	16</param>
/// <param name="FutsExecQty">선물체결수량	long	16</param>
/// <param name="OptOrdQty">옵션주문수량	long	16</param>
/// <param name="OptExecQty">옵션체결수량	long	16</param>
public record CFOAQ00600OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("선물주문수량", 16)] long FutsOrdQty,
    [BlockField("선물체결수량", 16)] long FutsExecQty,
    [BlockField("옵션주문수량", 16)] long OptOrdQty,
    [BlockField("옵션체결수량", 16)] long OptExecQty
    );

/// <summary>
/// 선물옵션 계좌주문체결내역조회: CFOAQ00600
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
public record CFOAQ00600OutBlock3(
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("정정취소구분명", 10)] string MrcTpNm,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode,
    [BlockField("선물옵션호가유형명", 40)] string FnoOrdprcPtnNm,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문구분명", 10)] string OrdTpNm,
    [BlockField("체결구분명", 10)] string ExecTpNm,
    [BlockField("체결가", 13.2)] double ExecPrc,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("약정시각", 9)] string CtrctTime,
    [BlockField("약정번호", 10)] long CtrctNo,
    [BlockField("체결번호", 10)] long ExecNo,
    [BlockField("매매손익금액", 16)] long BnsplAmt,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("사용자ID", 16)] string UserId,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("통신매체코드명", 40)] string CommdaCodeNm
    );


/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100
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
public record CFOAQ10100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("비율값", 19.8)] double RatVal,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode
    );

/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100
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
public record CFOAQ10100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("주문금액", 16)] long OrdAmt,
    [BlockField("비율값", 19.8)] double RatVal,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode
    );

/// <summary>
/// 선물옵션 주문가능수량조회: CFOAQ10100
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
public record CFOAQ10100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("조회일", 8)] string QryDt,
    [BlockField("선물옵션현재가", 27.8)] double FnoNowPrc,
    [BlockField("주문가능수량", 16)] long OrdAbleQty,
    [BlockField("신규주문가능수량", 16)] long NewOrdAbleQty,
    [BlockField("청산주문가능수량", 16)] long LqdtOrdAbleQty,
    [BlockField("사용예정증거금액", 16)] long UsePreargMgn,
    [BlockField("사용예정현금증거금액", 16)] long UsePreargMnyMgn,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt
    );


/// <summary>
/// 선물옵션 정상주문: CFOAT00100
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CFOAT00100InBlock1(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty
    );

/// <summary>
/// 선물옵션 정상주문: CFOAT00100
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
public record CFOAT00100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("선물옵션주문유형코드", 2)] string FnoOrdPtnCode,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode,
    [BlockField("선물옵션거래유형코드", 2)] string FnoTrdPtnCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("협의매매완료시각", 9)] string DscusBnsCmpltTime,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("주문일련번호", 10)] long OrdSeqno,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("항목번호", 16)] long ItemNo,
    [BlockField("운용지시번호", 12)] string OpDrtnNo,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("펀드ID", 12)] string FundId,
    [BlockField("펀드주문번호", 10)] long FundOrdNo
    );

/// <summary>
/// 선물옵션 정상주문: CFOAT00100
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
public record CFOAT00100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금", 16)] long OrdMgn,
    [BlockField("현금주문증거금", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 선물옵션 정정주문: CFOAT00200
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="FnoOrdprcPtnCode">선물옵션호가유형코드	string	2</param>
/// <param name="FnoOrdPrc">선물옵션주문가격	double	27.8</param>
/// <param name="MdfyQty">정정수량	long	16</param>
public record CFOAT00200InBlock1(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("정정수량", 16)] long MdfyQty
    );

/// <summary>
/// 선물옵션 정정주문: CFOAT00200
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
public record CFOAT00200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("선물옵션주문유형코드", 2)] string FnoOrdPtnCode,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("선물옵션호가유형코드", 2)] string FnoOrdprcPtnCode,
    [BlockField("선물옵션주문가격", 27.8)] double FnoOrdPrc,
    [BlockField("정정수량", 16)] long MdfyQty,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("협의매매완료시각", 9)] string DscusBnsCmpltTime,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("주문일련번호", 10)] long OrdSeqno,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("아이템번호", 10)] long ItemNo,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("펀드ID", 12)] string FundId,
    [BlockField("펀드원주문번호", 10)] long FundOrgOrdNo,
    [BlockField("펀드주문번호", 10)] long FundOrdNo
    );

/// <summary>
/// 선물옵션 정정주문: CFOAT00200
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
public record CFOAT00200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금액", 16)] long OrdMgn,
    [BlockField("현금주문증거금액", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 선물옵션 취소주문: CFOAT00300
/// </summary>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="FnoIsuNo">선물옵션종목번호	string	12</param>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="CancQty">취소수량	long	16</param>
public record CFOAT00300InBlock1(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("취소수량", 16)] long CancQty
    );

/// <summary>
/// 선물옵션 취소주문: CFOAT00300
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
public record CFOAT00300OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("선물옵션주문유형코드", 2)] string FnoOrdPtnCode,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("취소수량", 16)] long CancQty,
    [BlockField("통신매체코드", 2)] string CommdaCode,
    [BlockField("협의매매완료시각", 9)] string DscusBnsCmpltTime,
    [BlockField("그룹ID", 20)] string GrpId,
    [BlockField("주문일련번호", 10)] long OrdSeqno,
    [BlockField("포트폴리오번호", 10)] long PtflNo,
    [BlockField("바스켓번호", 10)] long BskNo,
    [BlockField("트렌치번호", 10)] long TrchNo,
    [BlockField("아이템번호", 10)] long ItemNo,
    [BlockField("관리사원번호", 9)] string MgempNo,
    [BlockField("펀드ID", 12)] string FundId,
    [BlockField("펀드원주문번호", 10)] long FundOrgOrdNo,
    [BlockField("펀드주문번호", 10)] long FundOrdNo
    );

/// <summary>
/// 선물옵션 취소주문: CFOAT00300
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
public record CFOAT00300OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문증거금액", 16)] long OrdMgn,
    [BlockField("현금주문증거금액", 16)] long MnyOrdMgn,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
public record CFOBQ10500InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd
    );

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
public record CFOBQ10500OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd
    );

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500
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
public record CFOBQ10500OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("예탁금총액", 16)] long DpsamtTotamt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("대용금액", 16)] long SubstAmt,
    [BlockField("충당예탁금총액", 16)] long FilupDpsamtTotamt,
    [BlockField("충당예수금", 16)] long FilupDps,
    [BlockField("선물손익금액", 16)] long FutsPnlAmt,
    [BlockField("인출가능금액", 16)] long WthdwAbleAmt,
    [BlockField("인출가능현금액", 16)] long PsnOutAbleCurAmt,
    [BlockField("인출가능대용금액", 16)] long PsnOutAbleSubstAmt,
    [BlockField("증거금액", 16)] long Mgn,
    [BlockField("현금증거금액", 16)] long MnyMgn,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("추가증거금액", 16)] long AddMgn,
    [BlockField("현금추가증거금액", 16)] long MnyAddMgn,
    [BlockField("금전일수표입금액", 16)] long AmtPrdayChckInAmt,
    [BlockField("선물옵션전일대용매도금액", 16)] long FnoPrdaySubstSellAmt,
    [BlockField("선물옵션금일대용매도금액", 16)] long FnoCrdaySubstSellAmt,
    [BlockField("선물옵션전일가입금액", 16)] long FnoPrdayFdamt,
    [BlockField("선물옵션금일가입금액", 16)] long FnoCrdayFdamt,
    [BlockField("외화대용금액", 16)] long FcurrSubstAmt,
    [BlockField("선물옵션계좌사후증거금명", 20)] string FnoAcntAfmgnNm
    );

/// <summary>
/// 선물옵션 계좌예탁금증거금조회: CFOBQ10500
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
public record CFOBQ10500OutBlock3(
    [BlockField("상품군코드명", 20)] string PdGrpCodeNm,
    [BlockField("순위험증거금액", 16)] long NetRiskMgn,
    [BlockField("가격증거금액", 16)] long PrcMgn,
    [BlockField("스프레드증거금액", 16)] long SprdMgn,
    [BlockField("가격변동증거금액", 16)] long PrcFlctMgn,
    [BlockField("최소증거금액", 16)] long MinMgn,
    [BlockField("주문증거금액", 16)] long OrdMgn,
    [BlockField("옵션순매수금액", 16)] long OptNetBuyAmt,
    [BlockField("위탁증거금액", 16)] long CsgnMgn,
    [BlockField("유지증거금액", 16)] long MaintMgn,
    [BlockField("선물매수체결금액", 16)] long FutsBuyExecAmt,
    [BlockField("선물매도체결금액", 16)] long FutsSellExecAmt,
    [BlockField("옵션매수체결금액", 16)] long OptBuyExecAmt,
    [BlockField("옵션매도체결금액", 16)] long OptSellExecAmt,
    [BlockField("선물손익금액", 16)] long FutsPnlAmt,
    [BlockField("총위험위탁증거금", 16)] long TotRiskCsgnMgn,
    [BlockField("인수도위탁증거금", 16)] long UndCsgnMgn,
    [BlockField("증거금감면금액", 16)] long MgnRdctAmt
    );


/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
/// <param name="IsuSmclssCode">종목소분류코드	string	3</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="SettWklyCnt">결제주간수	string	2</param>
/// <param name="SpclDtPtnCode">특별일자유형코드	string	3</param>
public record CFOBQ10800InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("종목중분류코드", 2)] string IsuMdclssCode,
    [BlockField("종목소분류코드", 3)] string IsuSmclssCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("결제주간수", 2)] string SettWklyCnt,
    [BlockField("특별일자유형코드", 3)] string SpclDtPtnCode
    );

/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
/// <param name="IsuSmclssCode">종목소분류코드	string	3</param>
/// <param name="DueYymm">만기년월	string	6</param>
/// <param name="SettWklyCnt">결제주간수	string	2</param>
/// <param name="SpclDtPtnCode">특별일자유형코드	string	3</param>
public record CFOBQ10800OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("종목중분류코드", 2)] string IsuMdclssCode,
    [BlockField("종목소분류코드", 3)] string IsuSmclssCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("결제주간수", 2)] string SettWklyCnt,
    [BlockField("특별일자유형코드", 3)] string SpclDtPtnCode
    );

/// <summary>
/// 선물옵션 옵션매도시 주문증거금조회: CFOBQ10800
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
public record CFOBQ10800OutBlock2(
    [BlockField("행사가", 13.2)] double ElwXrcPrc,
    [BlockField("선물옵션종목번호", 12)] string FnoIsuNo,
    [BlockField("한글종목명1", 40)] string HanglIsuNm1,
    [BlockField("구분명1", 40)] string TpNm1,
    [BlockField("상승옵션조정이론가", 27.8)] double UpOptRegulThrprc,
    [BlockField("이론가1", 19.8)] double Thrprc1,
    [BlockField("기준가1", 13.2)] double BasePrc1,
    [BlockField("주문증거금액1", 16)] long OrdMgn1,
    [BlockField("선물옵션종목번호0", 12)] string FnoIsuNo0,
    [BlockField("한글종목명2", 40)] string HanglIsuNm2,
    [BlockField("구분명2", 40)] string TpNm2,
    [BlockField("하락옵션조정이론가", 27.8)] double DownOptRegulThrprc,
    [BlockField("이론가2", 19.8)] double Thrprc2,
    [BlockField("기준가2", 13.2)] double BasePrc2,
    [BlockField("주문증거금액2", 16)] long OrdMgn2
    );


/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BnsDt">매매일	string	8</param>
public record CFOEQ11100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("매매일", 8)] string BnsDt
    );

/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BnsDt">매매일	string	8</param>
public record CFOEQ11100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("매매일", 8)] string BnsDt
    );

/// <summary>
/// 선물옵션가정산예탁금상세: CFOEQ11100
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
public record CFOEQ11100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("개장시예탁금총액", 16)] long OpnmkDpsamtTotamt,
    [BlockField("개장시예수금", 16)] long OpnmkDps,
    [BlockField("개장시현금미수금", 16)] long OpnmkMnyrclAmt,
    [BlockField("개장시대용금액", 16)] long OpnmkSubstAmt,
    [BlockField("총금액", 16)] long TotAmt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("현금미수금액", 16)] long MnyrclAmt,
    [BlockField("대용지정금액", 16)] long SubstDsgnAmt,
    [BlockField("위탁증거금액", 16)] long CsgnMgn,
    [BlockField("현금위탁증거금액", 16)] long MnyCsgnMgn,
    [BlockField("유지증거금액", 16)] long MaintMgn,
    [BlockField("현금유지증거금액", 16)] long MnyMaintMgn,
    [BlockField("출금가능총액", 16)] long OutAbleAmt,
    [BlockField("출금가능금액", 16)] long MnyoutAbleAmt,
    [BlockField("출금가능대용", 16)] long SubstOutAbleAmt,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("추가증거금구분", 1)] string AddMgnOcrTpCode,
    [BlockField("추가증거금액", 16)] long AddMgn,
    [BlockField("현금추가증거금액", 16)] long MnyAddMgn,
    [BlockField("익일예탁총액", 16)] long NtdayTotAmt,
    [BlockField("익일예탁현금", 16)] long NtdayDps,
    [BlockField("익일미수금", 16)] long NtdayMnyrclAmt,
    [BlockField("익일예탁대용", 16)] long NtdaySubstAmt,
    [BlockField("익일위탁증거금", 16)] long NtdayCsgnMgn,
    [BlockField("익일위탁증거금현금", 16)] long NtdayMnyCsgnMgn,
    [BlockField("익일유지증거금", 16)] long NtdayMaintMgn,
    [BlockField("익일유지증거금현금", 16)] long NtdayMnyMaintMgn,
    [BlockField("익일인출가능금액", 16)] long NtdayOutAbleAmt,
    [BlockField("익일인출가능금액", 16)] long NtdayMnyoutAbleAmt,
    [BlockField("익일인출가능대용", 16)] long NtdaySubstOutAbleAmt,
    [BlockField("익일주문가능금액", 16)] long NtdayOrdAbleAmt,
    [BlockField("익일주문가능현금", 16)] long NtdayMnyOrdAbleAmt,
    [BlockField("익일추가증거금구분", 1)] string NtdayAddMgnTp,
    [BlockField("익일추가증거금", 16)] long NtdayAddMgn,
    [BlockField("익일추가증거금현금", 16)] long NtdayMnyAddMgn,
    [BlockField("익일결제금액", 16)] long NtdaySettAmt,
    [BlockField("평가예탁금총액", 15)] long EvalDpsamtTotamt,
    [BlockField("현금평가예탁금액", 15)] long MnyEvalDpstgAmt,
    [BlockField("예탁금이용료지급예정금액", 16)] long DpsamtUtlfeeGivPrergAmt,
    [BlockField("세금", 16)] long TaxAmt,
    [BlockField("위탁증거금 비율", 7.2)] double CsgnMgnrat,
    [BlockField("위탁증거금현금비율", 7.2)] double CsgnMnyMgnrat,
    [BlockField("예탁총액부족금액(위탁증거금기준)", 16)] long DpstgTotamtLackAmt,
    [BlockField("예탁현금부족금액(위탁증거금기준)", 16)] long DpstgMnyLackAmt,
    [BlockField("실입금액", 16)] long RealInAmt,
    [BlockField("입금액", 16)] long InAmt,
    [BlockField("출금액", 16)] long OutAmt,
    [BlockField("선물정산차금", 16)] long FutsAdjstDfamt,
    [BlockField("선물당일차금", 16)] long FutsThdayDfamt,
    [BlockField("선물갱신차금", 16)] long FutsUpdtDfamt,
    [BlockField("선물최종결제차금", 16)] long FutsLastSettDfamt,
    [BlockField("옵션결제차금", 16)] long OptSettDfamt,
    [BlockField("옵션매수금액", 16)] long OptBuyAmt,
    [BlockField("옵션매도금액", 16)] long OptSellAmt,
    [BlockField("옵션행사차금", 16)] long OptXrcDfamt,
    [BlockField("옵션배정차금", 16)] long OptAsgnDfamt,
    [BlockField("실물인수도금액", 16)] long RealGdsUndAmt,
    [BlockField("실물인수도배정대금", 16)] long RealGdsUndAsgnAmt,
    [BlockField("실물인수도행사대금", 16)] long RealGdsUndXrcAmt,
    [BlockField("수수료", 16)] long CmsnAmt,
    [BlockField("선물수수료", 16)] long FutsCmsn,
    [BlockField("옵션수수료", 16)] long OptCmsn,
    [BlockField("선물약정수량", 16)] long FutsCtrctQty,
    [BlockField("선물약정금액", 16)] long FutsCtrctAmt,
    [BlockField("옵션약정수량", 16)] long OptCtrctQty,
    [BlockField("옵션약정금액", 16)] long OptCtrctAmt,
    [BlockField("선물미결제수량", 16)] long FutsUnsttQty,
    [BlockField("선물미결제금액", 16)] long FutsUnsttAmt,
    [BlockField("옵션미결제수량", 16)] long OptUnsttQty,
    [BlockField("옵션미결제금액", 16)] long OptUnsttAmt,
    [BlockField("선물매수미결제수량", 16)] long FutsBuyUnsttQty,
    [BlockField("선물매수미결제금액", 16)] long FutsBuyUnsttAmt,
    [BlockField("선물매도미결제수량", 16)] long FutsSellUnsttQty,
    [BlockField("선물매도미결제금액", 16)] long FutsSellUnsttAmt,
    [BlockField("옵션매수미결제수량", 16)] long OptBuyUnsttQty,
    [BlockField("옵션매수미결제금액", 16)] long OptBuyUnsttAmt,
    [BlockField("옵션매도미결제수량", 16)] long OptSellUnsttQty,
    [BlockField("옵션매도미결제금액", 16)] long OptSellUnsttAmt,
    [BlockField("선물매수약정수량", 16)] long FutsBuyctrQty,
    [BlockField("선물매수약정금액", 16)] long FutsBuyctrAmt,
    [BlockField("선물매도약정수량", 16)] long FutsSlctrQty,
    [BlockField("선물매도약정금액", 16)] long FutsSlctrAmt,
    [BlockField("옵션매수약정수량", 16)] long OptBuyctrQty,
    [BlockField("옵션매수약정금액", 16)] long OptBuyctrAmt,
    [BlockField("옵션매도약정수량", 16)] long OptSlctrQty,
    [BlockField("옵션매도약정금액", 16)] long OptSlctrAmt,
    [BlockField("선물매매손익금액", 16)] long FutsBnsplAmt,
    [BlockField("옵션매매손익금액", 16)] long OptBnsplAmt,
    [BlockField("선물평가손익금액", 16)] long FutsEvalPnlAmt,
    [BlockField("옵션평가손익금액", 16)] long OptEvalPnlAmt,
    [BlockField("선물평가금액", 16)] long FutsEvalAmt,
    [BlockField("옵션평가금액", 16)] long OptEvalAmt,
    [BlockField("장종료후현금입금금액", 16)] long MktEndAfMnyInAmt,
    [BlockField("장종료후현금출금금액", 16)] long MktEndAfMnyOutAmt,
    [BlockField("장종료후대용지정금액", 16)] long MktEndAfSubstDsgnAmt,
    [BlockField("장종료후대용해지금액", 16)] long MktEndAfSubstAbndAmt
    );


/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	string	1</param>
public record CFOEQ82600InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp,
    [BlockField("선물옵션잔고평가구분코드", 1)] string FnoBalEvalTpCode
    );

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="StnlnSeqTp">정렬순서구분	string	1</param>
/// <param name="FnoBalEvalTpCode">선물옵션잔고평가구분코드	string	1</param>
public record CFOEQ82600OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("정렬순서구분", 1)] string StnlnSeqTp,
    [BlockField("선물옵션잔고평가구분코드", 1)] string FnoBalEvalTpCode
    );

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="FutsAdjstDfamt">선물정산차금	long	16</param>
/// <param name="OptBnsplAmt">옵션매매손익금액	long	16</param>
/// <param name="FnoCmsnAmt">선물옵션수수료	long	16</param>
/// <param name="PnlSumAmt">손익합계금액	long	16</param>
/// <param name="MnyinSumAmt">입금합계금액	long	16</param>
/// <param name="MnyoutSumAmt">출금합계금액	long	16</param>
/// <param name="AcntNm">계좌명	string	40</param>
public record CFOEQ82600OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("선물정산차금", 16)] long FutsAdjstDfamt,
    [BlockField("옵션매매손익금액", 16)] long OptBnsplAmt,
    [BlockField("선물옵션수수료", 16)] long FnoCmsnAmt,
    [BlockField("손익합계금액", 16)] long PnlSumAmt,
    [BlockField("입금합계금액", 16)] long MnyinSumAmt,
    [BlockField("출금합계금액", 16)] long MnyoutSumAmt,
    [BlockField("계좌명", 40)] string AcntNm
    );

/// <summary>
/// 선물옵션 일별 계좌손익내역: CFOEQ82600
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
public record CFOEQ82600OutBlock3(
    [BlockField("조회일", 8)] string QryDt,
    [BlockField("예탁총액", 16)] long DpstgTotamt,
    [BlockField("예탁현금", 16)] long DpstgMny,
    [BlockField("선물옵션증거금액", 16)] long FnoMgn,
    [BlockField("선물손익금액", 16)] long FutsPnlAmt,
    [BlockField("옵션매매손익금액", 16)] long OptBsnPnlAmt,
    [BlockField("옵션평가손익금액", 16)] long OptEvalPnlAmt,
    [BlockField("수수료", 16)] long CmsnAmt,
    [BlockField("합계금액1", 16)] long SumAmt1,
    [BlockField("합계금액", 16)] long SumAmt2,
    [BlockField("손익합계금액", 16)] long PnlSumAmt,
    [BlockField("선물매수금액", 16)] long FutsBuyAmt,
    [BlockField("선물매도금액", 16)] long FutsSellAmt,
    [BlockField("옵션매수금액", 16)] long OptBuyAmt,
    [BlockField("옵션매도금액", 16)] long OptSellAmt,
    [BlockField("입금액", 16)] long InAmt,
    [BlockField("출금액", 16)] long OutAmt,
    [BlockField("평가금액", 16)] long EvalAmt,
    [BlockField("합산평가금액", 16)] long AddupEvalAmt,
    [BlockField("금액2", 16)] long Amt2
    );


/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="RegMktCode">등록시장코드	string	2</param>
/// <param name="BuyDt">매수일자	string	8</param>
public record CFOFQ02400InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("등록시장코드", 2)] string RegMktCode,
    [BlockField("매수일자", 8)] string BuyDt
    );

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="RegMktCode">등록시장코드	string	2</param>
/// <param name="BuyDt">매수일자	string	8</param>
public record CFOFQ02400OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("등록시장코드", 2)] string RegMktCode,
    [BlockField("매수일자", 8)] string BuyDt
    );

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
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
public record CFOFQ02400OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("선물약정수량", 16)] long FutsCtrctQty,
    [BlockField("옵션약정수량", 16)] long OptCtrctQty,
    [BlockField("약정수량", 16)] long CtrctQty,
    [BlockField("선물약정금액", 16)] long FutsCtrctAmt,
    [BlockField("선물매수약정금액", 16)] long FutsBuyctrAmt,
    [BlockField("선물매도약정금액", 16)] long FutsSlctrAmt,
    [BlockField("콜옵션약정금액", 16)] long CalloptCtrctAmt,
    [BlockField("콜매수금액", 16)] long CallBuyAmt,
    [BlockField("콜매도금액", 16)] long CallSellAmt,
    [BlockField("풋옵션약정금액", 16)] long PutoptCtrctAmt,
    [BlockField("풋매수금액", 16)] long PutBuyAmt,
    [BlockField("풋매도금액", 16)] long PutSellAmt,
    [BlockField("전체약정금액", 16)] long AllCtrctAmt,
    [BlockField("매수약정누계금액", 16)] long BuyctrAsmAmt,
    [BlockField("매도약정누계금액", 16)] long SlctrAsmAmt,
    [BlockField("선물손익합계", 16)] long FutsPnlSum,
    [BlockField("옵션손익합계", 16)] long OptPnlSum,
    [BlockField("전체손익합계", 16)] long AllPnlSum
    );

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
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
public record CFOFQ02400OutBlock3(
    [BlockField("선물옵션품목구분", 1)] string FnoClssCode,
    [BlockField("선물매도수량", 16)] long FutsSellQty,
    [BlockField("선물매도손익", 16)] long FutsSellPnl,
    [BlockField("선물매수수량", 16)] long FutsBuyQty,
    [BlockField("선물매수손익", 16)] long FutsBuyPnl,
    [BlockField("콜매도수량", 16)] long CallSellQty,
    [BlockField("콜매도손익", 16)] long CallSellPnl,
    [BlockField("콜매수수량", 16)] long CallBuyQty,
    [BlockField("콜매수손익", 16)] long CallBuyPnl,
    [BlockField("풋매도수량", 16)] long PutSellQty,
    [BlockField("풋매도손익", 16)] long PutSellPnl,
    [BlockField("풋매수수량", 16)] long PutBuyQty,
    [BlockField("풋매수손익", 16)] long PutBuyPnl
    );

/// <summary>
/// 계좌 미결제 약정현황(평균가): CFOFQ02400
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
public record CFOFQ02400OutBlock4(
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("잔고수량", 16)] long BalQty,
    [BlockField("평균가", 19.8)] double FnoAvrPrc,
    [BlockField("당초금액", 16)] long BgnAmt,
    [BlockField("당일청산수량", 16)] long ThdayLqdtQty,
    [BlockField("현재가", 13.2)] double Curprc,
    [BlockField("평가금액", 16)] long EvalAmt,
    [BlockField("평가손익금액", 16)] long EvalPnlAmt,
    [BlockField("평가수익률", 12.6)] double EvalErnrat
    );


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
public record ChartExcelInBlock(
    [BlockField("지표ID", 10)] long indexid,
    [BlockField("지표명", 40)] string indexname,
    [BlockField("지표조건설정", 40)] string indexparam,
    [BlockField("결과데이터 구분", 1)] string indexouttype,
    [BlockField("시장구분", 1)] string market,
    [BlockField("주기구분", 1)] string period,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("결과 지표데이터 엑셀표시 여부", 1)] string isexcelout,
    [BlockField("엑셀데이터 파일명", 256)] string excelfilename,
    [BlockField("실시간 데이터수신 자동등록 여부", 1)] string IsReal
    );

/// <summary>
/// 챠트엑셀데이터조회: CHARTEXCEL
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="rec_cnt">레코드갯수	int	5</param>
/// <param name="validdata_cnt">유효 데이터 컬럼 갯수	int	2</param>
public record ChartExcelOutBlock(
    [BlockField("지표ID", 10)] long indexid,
    [BlockField("레코드갯수", 5)] int rec_cnt,
    [BlockField("유효 데이터 컬럼 갯수", 2)] int validdata_cnt
    );

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
public record ChartExcelOutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 10)] double open,
    [BlockField("고가", 10)] double high,
    [BlockField("저가", 10)] double low,
    [BlockField("종가", 10)] double close,
    [BlockField("거래량", 12)] double volume,
    [BlockField("지표값1", 10)] double value1,
    [BlockField("지표값2", 10)] double value2,
    [BlockField("지표값3", 10)] double value3,
    [BlockField("지표값4", 10)] double value4,
    [BlockField("지표값5", 10)] double value5,
    [BlockField("위치", 8)] int pos
    );


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
public record ChartIndexInBlock(
    [BlockField("지표ID", 10)] long indexid,
    [BlockField("지표명", 40)] string indexname,
    [BlockField("지표조건설정", 40)] string indexparam,
    [BlockField("시장구분", 1)] string market,
    [BlockField("주기구분", 1)] string period,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("요청건수(최대 500개)", 4)] int qrycnt,
    [BlockField("단위(n틱/n분)", 4)] int ncnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("수정주가 반영 여부", 1)] string Isamend,
    [BlockField("갭보정 여부", 1)] string Isgab,
    [BlockField("실시간 데이터수신 자동등록 여부", 1)] string IsReal
    );

/// <summary>
/// 챠트지표데이터조회: CHARTINDEX
/// </summary>
/// <param name="indexid">지표ID	long	10</param>
/// <param name="rec_cnt">레코드갯수	int	5</param>
/// <param name="validdata_cnt">유효 데이터 컬럼 갯수	int	2</param>
public record ChartIndexOutBlock(
    [BlockField("지표ID", 10)] long indexid,
    [BlockField("레코드갯수", 5)] int rec_cnt,
    [BlockField("유효 데이터 컬럼 갯수", 2)] int validdata_cnt
    );

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
public record ChartIndexOutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 10)] double open,
    [BlockField("고가", 10)] double high,
    [BlockField("저가", 10)] double low,
    [BlockField("종가", 10)] double close,
    [BlockField("거래량", 12)] double volume,
    [BlockField("지표값1", 10)] double value1,
    [BlockField("지표값2", 10)] double value2,
    [BlockField("지표값3", 10)] double value3,
    [BlockField("지표값4", 10)] double value4,
    [BlockField("지표값5", 10)] double value5,
    [BlockField("위치", 8)] int pos
    );


/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
public record CIDBQ01400InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode
    );

/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTpCode">조회구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="IsuCodeVal">종목코드값	string	30</param>
/// <param name="BnsTpCode">매매구분코드	string	1</param>
/// <param name="OvrsDrvtOrdPrc">해외파생주문가격	double	30.11</param>
/// <param name="AbrdFutsOrdPtnCode">해외선물주문유형코드	string	1</param>
public record CIDBQ01400OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode
    );

/// <summary>
/// 해외선물 체결내역개별 조회: CIDBQ01400
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OrdAbleQty">주문가능수량	long	16</param>
public record CIDBQ01400OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문가능수량", 16)] long OrdAbleQty
    );


/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryDt">조회일자	string	8</param>
/// <param name="BalTpCode">잔고구분코드	string	1</param>
public record CIDBQ01500InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌구분코드", 1)] string AcntTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회일자", 8)] string QryDt,
    [BlockField("잔고구분코드", 1)] string BalTpCode
    );

/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QryDt">조회일자	string	8</param>
/// <param name="BalTpCode">잔고구분코드	string	1</param>
public record CIDBQ01500OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌구분코드", 1)] string AcntTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회일자", 8)] string QryDt,
    [BlockField("잔고구분코드", 1)] string BalTpCode
    );

/// <summary>
/// 해외선물 미결제 잔고내역: CIDBQ01500
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
public record CIDBQ01500OutBlock2(
    [BlockField("기준일자", 8)] string BaseDt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("청산손익금액", 19.2)] double LpnlAmt,
    [BlockField("선물만기전청산손익금액", 23.2)] double FutsDueBfLpnlAmt,
    [BlockField("선물만기전수수료", 23.2)] double FutsDueBfCmsn,
    [BlockField("위탁증거금액", 16)] long CsgnMgn,
    [BlockField("유지증거금", 16)] long MaintMgn,
    [BlockField("신용한도금액", 23.2)] double CtlmtAmt,
    [BlockField("추가증거금액", 16)] long AddMgn,
    [BlockField("마진콜율", 27.1)] double MgnclRat,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("인출가능금액", 16)] long WthdwAbleAmt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("통화코드값", 3)] string CrcyCodeVal,
    [BlockField("해외파생상품코드", 10)] string OvrsDrvtPrdtCode,
    [BlockField("해외파생옵션구분코드", 1)] string OvrsDrvtOptTpCode,
    [BlockField("만기일자", 8)] string DueDt,
    [BlockField("해외파생행사가격", 30.11)] double OvrsDrvtXrcPrc,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("공통코드명", 100)] string CmnCodeNm,
    [BlockField("구분코드명", 50)] string TpCodeNm,
    [BlockField("잔고수량", 16)] long BalQty,
    [BlockField("매입가격", 30.11)] double PchsPrc,
    [BlockField("해외파생현재가", 30.11)] double OvrsDrvtNowPrc,
    [BlockField("해외선물평가손익금액", 19.2)] double AbrdFutsEvalPnlAmt,
    [BlockField("위탁수수료", 19.2)] double CsgnCmsn,
    [BlockField("포지션번호", 13)] string PosNo,
    [BlockField("거래소비용1수수료금액", 19.2)] double EufOneCmsnAmt,
    [BlockField("거래소비용2수수료금액", 19.2)] double EufTwoCmsnAmt
    );


/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800
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
public record CIDBQ01800InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("당일구분코드", 1)] string ThdayTpCode,
    [BlockField("주문상태코드", 1)] string OrdStatCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("해외파생선물옵션구분코드", 1)] string OvrsDrvtFnoTpCode
    );

/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800
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
public record CIDBQ01800OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("당일구분코드", 1)] string ThdayTpCode,
    [BlockField("주문상태코드", 1)] string OrdStatCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("해외파생선물옵션구분코드", 1)] string OvrsDrvtFnoTpCode
    );

/// <summary>
/// 해외선물 주문체결내역 조회: CIDBQ01800
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
public record CIDBQ01800OutBlock2(
    [BlockField("해외선물주문번호", 10)] string OvrsFutsOrdNo,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("FCM주문번호", 15)] string FcmOrdNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("해외선물행사가격", 30.11)] double AbrdFutsXrcPrc,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("매매구분명", 10)] string BnsTpNm,
    [BlockField("선물주문상태코드", 1)] string FutsOrdStatCode,
    [BlockField("구분코드명", 50)] string TpCodeNm,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("거래구분명", 20)] string TrdTpNm,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode,
    [BlockField("주문유형명", 40)] string OrdPtnNm,
    [BlockField("주문유형기간구분코드", 2)] string OrdPtnTermTpCode,
    [BlockField("공통코드명", 100)] string CmnCodeNm,
    [BlockField("적용시작일자", 8)] string AppSrtDt,
    [BlockField("적용종료일자", 8)] string AppEndDt,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("해외파생체결종목코드", 30)] string OvrsDrvtExecIsuCode,
    [BlockField("체결종목명", 50)] string ExecIsuNm,
    [BlockField("체결매매구분코드", 1)] string ExecBnsTpCode,
    [BlockField("체결매매구분명", 10)] string ExecBnsTpNm,
    [BlockField("해외선물체결가격", 30.11)] double AbrdFutsExecPrc,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("주문조건가격", 30.11)] double OrdCndiPrc,
    [BlockField("해외파생현재가", 30.11)] double OvrsDrvtNowPrc,
    [BlockField("정정수량", 16)] long MdfyQty,
    [BlockField("취소수량", 16)] long CancQty,
    [BlockField("거부수량", 13)] long RjtQty,
    [BlockField("확인수량", 16)] long CnfQty,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("반대매매여부", 1)] string CvrgYn,
    [BlockField("등록단말번호", 3)] string RegTmnlNo,
    [BlockField("등록지점번호", 3)] string RegBrnNo,
    [BlockField("등록사용자ID", 16)] string RegUserId,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("해외옵션행사예약구분코드", 1)] string OvrsOptXrcRsvTpCode,
    [BlockField("해외파생옵션구분코드", 1)] string OvrsDrvtOptTpCode,
    [BlockField("스프레드기준종목여부", 1)] string SprdBaseIsuYn,
    [BlockField("해외선물주문일자", 8)] string OvrsFutsOrdDt,
    [BlockField("해외선물주문번호2", 10)] string OvrsFutsOrdNo2,
    [BlockField("해외선물원주문번호2", 10)] string OvrsFutsOrgOrdNo2,
    [BlockField("해외파생종목코드2", 30)] string OvrsDrvtIsuCode2
    );


/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400
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
public record CIDBQ02400InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("조회시작일자", 8)] string QrySrtDt,
    [BlockField("조회종료일자", 8)] string QryEndDt,
    [BlockField("당일구분코드", 1)] string ThdayTpCode,
    [BlockField("주문상태코드", 1)] string OrdStatCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("해외파생선물옵션구분코드", 1)] string OvrsDrvtFnoTpCode
    );

/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400
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
public record CIDBQ02400OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("조회시작일자", 8)] string QrySrtDt,
    [BlockField("조회종료일자", 8)] string QryEndDt,
    [BlockField("당일구분코드", 1)] string ThdayTpCode,
    [BlockField("주문상태코드", 1)] string OrdStatCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("조회구분코드", 1)] string QryTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("해외파생선물옵션구분코드", 1)] string OvrsDrvtFnoTpCode
    );

/// <summary>
/// 해외선물 주문체결내역 상세 조회: CIDBQ02400
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
public record CIDBQ02400OutBlock2(
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("해외선물주문번호", 10)] string OvrsFutsOrdNo,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("FCM주문번호", 15)] string FcmOrdNo,
    [BlockField("체결일자", 8)] string ExecDt,
    [BlockField("해외선물체결번호", 10)] string OvrsFutsExecNo,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("해외선물행사가격", 30.11)] double AbrdFutsXrcPrc,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("매매구분명", 10)] string BnsTpNm,
    [BlockField("선물주문상태코드", 1)] string FutsOrdStatCode,
    [BlockField("구분코드명", 50)] string TpCodeNm,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("거래구분명", 20)] string TrdTpNm,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode,
    [BlockField("주문유형명", 40)] string OrdPtnNm,
    [BlockField("주문유형기간구분코드", 2)] string OrdPtnTermTpCode,
    [BlockField("공통코드명", 100)] string CmnCodeNm,
    [BlockField("적용시작일자", 8)] string AppSrtDt,
    [BlockField("적용종료일자", 8)] string AppEndDt,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("해외파생체결종목코드", 30)] string OvrsDrvtExecIsuCode,
    [BlockField("체결종목명", 50)] string ExecIsuNm,
    [BlockField("체결매매구분코드", 1)] string ExecBnsTpCode,
    [BlockField("체결매매구분명", 10)] string ExecBnsTpNm,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("해외선물체결가격", 30.11)] double AbrdFutsExecPrc,
    [BlockField("주문조건가격", 30.11)] double OrdCndiPrc,
    [BlockField("해외파생현재가", 30.11)] double OvrsDrvtNowPrc,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("처리상태코드", 2)] string TrxStatCode,
    [BlockField("처리상태코드명", 40)] string TrxStatCodeNm,
    [BlockField("위탁수수료", 19.2)] double CsgnCmsn,
    [BlockField("FCM수수료", 21.4)] double FcmCmsn,
    [BlockField("당사수수료", 19.2)] double ThcoCmsn,
    [BlockField("매체코드", 2)] string MdaCode,
    [BlockField("매체코드명", 40)] string MdaCodeNm,
    [BlockField("등록단말번호", 3)] string RegTmnlNo,
    [BlockField("등록사용자ID", 16)] string RegUserId,
    [BlockField("주문발송일시", 17)] string OrdSndDttm,
    [BlockField("체결일시", 17)] string ExecDttm,
    [BlockField("거래소비용1수수료금액", 19.2)] double EufOneCmsnAmt,
    [BlockField("거래소비용2수수료금액", 19.2)] double EufTwoCmsnAmt,
    [BlockField("런던청산소1수수료금액", 19.2)] double LchOneCmsnAmt,
    [BlockField("런던청산소2수수료금액", 19.2)] double LchTwoCmsnAmt,
    [BlockField("거래1수수료금액", 19.2)] double TrdOneCmsnAmt,
    [BlockField("거래2수수료금액", 19.2)] double TrdTwoCmsnAmt,
    [BlockField("거래3수수료금액", 19.2)] double TrdThreeCmsnAmt,
    [BlockField("단기1수수료금액", 19.2)] double StrmOneCmsnAmt,
    [BlockField("단기2수수료금액", 19.2)] double StrmTwoCmsnAmt,
    [BlockField("단기3수수료금액", 19.2)] double StrmThreeCmsnAmt,
    [BlockField("전달1수수료금액", 19.2)] double TransOneCmsnAmt,
    [BlockField("전달2수수료금액", 19.2)] double TransTwoCmsnAmt,
    [BlockField("전달3수수료금액", 19.2)] double TransThreeCmsnAmt,
    [BlockField("전달4수수료금액", 19.2)] double TransFourCmsnAmt,
    [BlockField("해외옵션행사예약구분코드", 1)] string OvrsOptXrcRsvTpCode,
    [BlockField("해외파생옵션구분코드", 1)] string OvrsDrvtOptTpCode,
    [BlockField("스프레드기준종목여부", 1)] string SprdBaseIsuYn,
    [BlockField("해외파생종목코드2", 30)] string OvrsDrvtIsuCode2
    );


/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDBQ03000InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌구분코드", 1)] string AcntTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("거래일자", 8)] string TrdDt
    );

/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntTpCode">계좌구분코드	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDBQ03000OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌구분코드", 1)] string AcntTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("거래일자", 8)] string TrdDt
    );

/// <summary>
/// 해외선물 예수금/잔고현황: CIDBQ03000
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
public record CIDBQ03000OutBlock2(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("거래일자", 8)] string TrdDt,
    [BlockField("통화대상코드", 12)] string CrcyObjCode,
    [BlockField("해외선물예수금", 23.2)] double OvrsFutsDps,
    [BlockField("고객입출금금액", 19.2)] double CustmMnyioAmt,
    [BlockField("해외선물청산손익금액", 19.2)] double AbrdFutsLqdtPnlAmt,
    [BlockField("해외선물수수료금액", 19.2)] double AbrdFutsCmsnAmt,
    [BlockField("가환전예수금", 19.2)] double PrexchDps,
    [BlockField("평가자산금액", 19.2)] double EvalAssetAmt,
    [BlockField("해외선물위탁증거금액", 19.2)] double AbrdFutsCsgnMgn,
    [BlockField("해외선물추가증거금액", 19.2)] double AbrdFutsAddMgn,
    [BlockField("해외선물인출가능금액", 19.2)] double AbrdFutsWthdwAbleAmt,
    [BlockField("해외선물주문가능금액", 19.2)] double AbrdFutsOrdAbleAmt,
    [BlockField("해외선물평가손익금액", 19.2)] double AbrdFutsEvalPnlAmt,
    [BlockField("최종결제손익금액", 19.2)] double LastSettPnlAmt,
    [BlockField("해외옵션결제금액", 19.2)] double OvrsOptSettAmt,
    [BlockField("해외옵션잔고평가금액", 19.2)] double OvrsOptBalEvalAmt
    );


/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	string	1</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="CrcyCode">통화코드	string	3</param>
public record CIDBQ05300InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("해외계좌구분코드", 1)] string OvrsAcntTpCode,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("통화코드", 3)] string CrcyCode
    );

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="OvrsAcntTpCode">해외계좌구분코드	string	1</param>
/// <param name="FcmAcntNo">FCM계좌번호	string	20</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="CrcyCode">통화코드	string	3</param>
public record CIDBQ05300OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("해외계좌구분코드", 1)] string OvrsAcntTpCode,
    [BlockField("FCM계좌번호", 20)] string FcmAcntNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("통화코드", 3)] string CrcyCode
    );

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300
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
public record CIDBQ05300OutBlock2(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("통화코드", 3)] string CrcyCode,
    [BlockField("해외선물예수금", 23.2)] double OvrsFutsDps,
    [BlockField("해외선물위탁증거금액", 19.2)] double AbrdFutsCsgnMgn,
    [BlockField("해외선물추가증거금", 23.2)] double OvrsFutsSplmMgn,
    [BlockField("고객청산손익금액", 19.2)] double CustmLpnlAmt,
    [BlockField("해외선물평가손익금액", 19.2)] double AbrdFutsEvalPnlAmt,
    [BlockField("해외선물수수료금액", 19.2)] double AbrdFutsCmsnAmt,
    [BlockField("해외선물평가예탁총금액", 19.2)] double AbrdFutsEvalDpstgTotAmt,
    [BlockField("환율", 15.4)] double Xchrat,
    [BlockField("외화실환전금액", 19.2)] double FcurrRealMxchgAmt,
    [BlockField("해외선물인출가능금액", 19.2)] double AbrdFutsWthdwAbleAmt,
    [BlockField("해외선물주문가능금액", 19.2)] double AbrdFutsOrdAbleAmt,
    [BlockField("선물만기미도래청산손익금액", 19.2)] double FutsDueNarrvLqdtPnlAmt,
    [BlockField("선물만기미도래수수료", 19.2)] double FutsDueNarrvCmsn,
    [BlockField("해외선물청산손익금액", 19.2)] double AbrdFutsLqdtPnlAmt,
    [BlockField("해외선물만기수수료", 19.2)] double OvrsFutsDueCmsn,
    [BlockField("해외선물옵션매수금액", 23.2)] double OvrsFutsOptBuyAmt,
    [BlockField("해외선물옵션매도금액", 23.2)] double OvrsFutsOptSellAmt,
    [BlockField("옵션매수시장가치금액", 19.2)] double OptBuyMktWrthAmt,
    [BlockField("옵션매도시장가치금액", 19.2)] double OptSellMktWrthAmt
    );

/// <summary>
/// 해외선물 계좌예탁자산조회: CIDBQ05300
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
public record CIDBQ05300OutBlock3(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("해외선물예수금", 23.2)] double OvrsFutsDps,
    [BlockField("해외선물청산손익금액", 19.2)] double AbrdFutsLqdtPnlAmt,
    [BlockField("선물만기미도래청산손익금액", 19.2)] double FutsDueNarrvLqdtPnlAmt,
    [BlockField("해외선물평가손익금액", 19.2)] double AbrdFutsEvalPnlAmt,
    [BlockField("해외선물평가예탁총금액", 19.2)] double AbrdFutsEvalDpstgTotAmt,
    [BlockField("고객청산손익금액", 19.2)] double CustmLpnlAmt,
    [BlockField("해외선물만기수수료", 19.2)] double OvrsFutsDueCmsn,
    [BlockField("외화실환전금액", 19.2)] double FcurrRealMxchgAmt,
    [BlockField("해외선물수수료금액", 19.2)] double AbrdFutsCmsnAmt,
    [BlockField("선물만기미도래수수료", 19.2)] double FutsDueNarrvCmsn,
    [BlockField("해외선물위탁증거금액", 19.2)] double AbrdFutsCsgnMgn,
    [BlockField("해외선물유지증거금", 19.2)] double OvrsFutsMaintMgn,
    [BlockField("해외선물옵션매수금액", 23.2)] double OvrsFutsOptBuyAmt,
    [BlockField("해외선물옵션매도금액", 23.2)] double OvrsFutsOptSellAmt,
    [BlockField("신용한도금액", 23.2)] double CtlmtAmt,
    [BlockField("해외선물추가증거금", 23.2)] double OvrsFutsSplmMgn,
    [BlockField("마진콜율", 27.1)] double MgnclRat,
    [BlockField("해외선물주문가능금액", 19.2)] double AbrdFutsOrdAbleAmt,
    [BlockField("해외선물인출가능금액", 19.2)] double AbrdFutsWthdwAbleAmt,
    [BlockField("옵션매수시장가치금액", 19.2)] double OptBuyMktWrthAmt,
    [BlockField("옵션매도시장가치금액", 19.2)] double OptSellMktWrthAmt,
    [BlockField("해외옵션결제금액", 19.2)] double OvrsOptSettAmt,
    [BlockField("해외옵션잔고평가금액", 19.2)] double OvrsOptBalEvalAmt
    );


/// <summary>
/// 해외선물신규주문: CIDBT00100
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
public record CIDBT00100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("지점코드", 7)] string BrnCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode,
    [BlockField("통화코드", 3)] string CrcyCode,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("조건주문가격", 30.11)] double CndiOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("상품코드", 6)] string PrdtCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물신규주문: CIDBT00100
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
public record CIDBT00100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("지점코드", 7)] string BrnCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("해외선물주문유형코드", 1)] string AbrdFutsOrdPtnCode,
    [BlockField("통화코드", 3)] string CrcyCode,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("조건주문가격", 30.11)] double CndiOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("상품코드", 6)] string PrdtCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물신규주문: CIDBT00100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
public record CIDBT00100OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("해외선물주문번호", 10)] string OvrsFutsOrdNo
    );


/// <summary>
/// 해외선물정정주문: CIDBT00900
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
public record CIDBT00900InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("등록지점번호", 3)] string RegBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("선물주문유형코드", 1)] string FutsOrdPtnCode,
    [BlockField("통화코드값", 3)] string CrcyCodeVal,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("조건주문가격", 30.11)] double CndiOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("해외파생상품코드", 10)] string OvrsDrvtPrdtCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물정정주문: CIDBT00900
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
public record CIDBT00900OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("등록지점번호", 3)] string RegBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("매매구분코드", 1)] string BnsTpCode,
    [BlockField("선물주문유형코드", 1)] string FutsOrdPtnCode,
    [BlockField("통화코드값", 3)] string CrcyCodeVal,
    [BlockField("해외파생주문가격", 30.11)] double OvrsDrvtOrdPrc,
    [BlockField("조건주문가격", 30.11)] double CndiOrdPrc,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("해외파생상품코드", 10)] string OvrsDrvtPrdtCode,
    [BlockField("만기년월", 6)] string DueYymm,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물정정주문: CIDBT00900
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	string	80</param>
public record CIDBT00900OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("해외선물주문번호", 10)] string OvrsFutsOrdNo,
    [BlockField("내부메시지내용", 80)] string InnerMsgCnts
    );


/// <summary>
/// 해외선물취소주문: CIDBT01000
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
public record CIDBT01000InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("지점번호", 3)] string BrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("상품구분코드", 2)] string PrdtTpCode,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물취소주문: CIDBT01000
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
public record CIDBT01000OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("주문일자", 8)] string OrdDt,
    [BlockField("지점번호", 3)] string BrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("해외선물원주문번호", 10)] string OvrsFutsOrgOrdNo,
    [BlockField("선물주문구분코드", 1)] string FutsOrdTpCode,
    [BlockField("상품구분코드", 2)] string PrdtTpCode,
    [BlockField("거래소코드", 10)] string ExchCode
    );

/// <summary>
/// 해외선물취소주문: CIDBT01000
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="OvrsFutsOrdNo">해외선물주문번호	string	10</param>
/// <param name="InnerMsgCnts">내부메시지내용	string	80</param>
public record CIDBT01000OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("해외선물주문번호", 10)] string OvrsFutsOrdNo,
    [BlockField("내부메시지내용", 80)] string InnerMsgCnts
    );


/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDEQ00800InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("거래일자", 8)] string TrdDt
    );

/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="AcntPwd">계좌비밀번호	string	8</param>
/// <param name="TrdDt">거래일자	string	8</param>
public record CIDEQ00800OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("계좌비밀번호", 8)] string AcntPwd,
    [BlockField("거래일자", 8)] string TrdDt
    );

/// <summary>
/// 일자별 미결제 잔고내역: CIDEQ00800
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
public record CIDEQ00800OutBlock2(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("거래일자", 8)] string TrdDt,
    [BlockField("종목코드값", 30)] string IsuCodeVal,
    [BlockField("매매구분명", 10)] string BnsTpNm,
    [BlockField("잔고수량", 16)] long BalQty,
    [BlockField("청산가능수량", 16)] long LqdtAbleQty,
    [BlockField("매입가격", 30.11)] double PchsPrc,
    [BlockField("해외파생현재가", 30.11)] double OvrsDrvtNowPrc,
    [BlockField("해외선물평가손익금액", 19.2)] double AbrdFutsEvalPnlAmt,
    [BlockField("고객잔고금액", 19.2)] double CustmBalAmt,
    [BlockField("외화평가금액", 21.4)] double FcurrEvalAmt,
    [BlockField("종목명", 50)] string IsuNm,
    [BlockField("통화코드값", 3)] string CrcyCodeVal,
    [BlockField("해외파생상품코드", 10)] string OvrsDrvtPrdtCode,
    [BlockField("만기일자", 8)] string DueDt,
    [BlockField("계약당금액", 19.2)] double PrcntrAmt,
    [BlockField("외화평가손익금액", 21.4)] double FcurrEvalPnlAmt
    );


/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="SecTpCode">유가증권구분	string	1</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	string	2</param>
/// <param name="LoanTp">대출구분	string	1</param>
public record CLNAQ00100InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("유가증권구분", 1)] string SecTpCode,
    [BlockField("대출이자등급코드", 2)] string LoanIntrstGrdCode,
    [BlockField("대출구분", 1)] string LoanTp
    );

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="QryTp">조회구분	string	1</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="SecTpCode">유가증권구분	string	1</param>
/// <param name="LoanIntrstGrdCode">대출이자등급코드	string	2</param>
/// <param name="LoanTp">대출구분	string	1</param>
public record CLNAQ00100OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("유가증권구분", 1)] string SecTpCode,
    [BlockField("대출이자등급코드", 2)] string LoanIntrstGrdCode,
    [BlockField("대출구분", 1)] string LoanTp
    );

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100
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
public record CLNAQ00100OutBlock2(
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("액면가", 13.2)] double Parprc,
    [BlockField("전일종가", 13.2)] double PrdayCprc,
    [BlockField("비율값", 19.8)] double RatVal,
    [BlockField("대용가", 13.2)] double SubstPrc,
    [BlockField("등록구분", 20)] string RegTpNm,
    [BlockField("현물증거금징수분류명", 40)] string SpotMgnLevyClssNm,
    [BlockField("거래정지사유", 40)] string FnoTrdStopRsnCnts,
    [BlockField("요주의유형명", 40)] string DgrsPtnNm,
    [BlockField("사고유형", 40)] string AcdPtnNm,
    [BlockField("시장구분", 20)] string MktTpNm,
    [BlockField("한도값", 18)] long LmtVal,
    [BlockField("계좌한도값", 18)] long AcntLmtVal,
    [BlockField("대출등급코드", 2)] string LoanGrdCode,
    [BlockField("대출금액", 16)] long LoanAmt,
    [BlockField("대출가능율", 26.9)] double LoanAbleRat,
    [BlockField("대출이율1", 14.4)] double LoanIntrat1,
    [BlockField("등록자ID", 16)] string RegPsnId,
    [BlockField("비율값", 19.8)] double Rat01,
    [BlockField("비율값", 19.8)] double Rat02
    );

/// <summary>
/// 예탁담보융자가능종목현황조회: CLNAQ00100
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="LrgMnyoutSumAmt">대출금합계금액	long	16</param>
public record CLNAQ00100OutBlock3(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("대출금합계금액", 16)] long LrgMnyoutSumAmt
    );


/// <summary>
/// 계좌별신용한도조회: CSPAQ00600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CSPAQ00600InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("대출상세분류코드", 2)] string LoanDtlClssCode,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 계좌별신용한도조회: CSPAQ00600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="LoanDtlClssCode">대출상세분류코드	string	2</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
/// <param name="CommdaCode">통신매체코드	string	2</param>
public record CSPAQ00600OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("대출상세분류코드", 2)] string LoanDtlClssCode,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("통신매체코드", 2)] string CommdaCode
    );

/// <summary>
/// 계좌별신용한도조회: CSPAQ00600
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
public record CSPAQ00600OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("주문가", 13.2)] double OrdPrc,
    [BlockField("대주한도", 16)] long SloanLmtAmt,
    [BlockField("대주금액합계", 16)] long SloanAmtSum,
    [BlockField("대주신규금액", 16)] long SloanNewAmt,
    [BlockField("대주상환금액", 16)] long SloanRfundAmt,
    [BlockField("유통융자한도금액", 16)] long MktcplMloanLmtAmt,
    [BlockField("유통융자금액합계", 16)] long MktcplMloanAmtSum,
    [BlockField("유통융자신규금액", 16)] long MktcplMloanNewAmt,
    [BlockField("유통융자상환금액", 16)] long MktcplMloanRfundAmt,
    [BlockField("자기융자한도금액", 16)] long SfaccMloanLmtAmt,
    [BlockField("자기융자금액합계", 16)] long SfaccMloanAmtSum,
    [BlockField("자기융자신규금액", 16)] long SfaccMloanNewAmt,
    [BlockField("자기융자상환금액", 16)] long SfaccMloanRfundAmt,
    [BlockField("지점유통융자한도금액", 16)] long BrnMktcplMloanLmtAmt,
    [BlockField("지점유통융자신규금액", 16)] long BrnMktcplMloanNewAmt,
    [BlockField("지점유통융자상환금액", 16)] long BrnMktcplMloanRfundAmt,
    [BlockField("지점유통융자사용금액", 16)] long BrnMktcplMloanUseAmt,
    [BlockField("지점자기융자한도금액", 16)] long BrnSfaccMloanLmtAmt,
    [BlockField("지점자기융자신규금액", 16)] long BrnSfaccMloanNewAmt,
    [BlockField("지점자기융자상환금액", 16)] long BrnSfaccMloanRfundAmt,
    [BlockField("지점자기융자사용금액", 16)] long BrnSfaccMloanUseAmt,
    [BlockField("이용사융자한도관리여부", 1)] string FirmMloanLmtMgmtYn,
    [BlockField("이용사신용종목제한구분", 1)] string FirmCrdtIsuRestrcTp,
    [BlockField("담보유지비율", 7.4)] double PldgMaintRat,
    [BlockField("이용사명", 50)] string FirmNm,
    [BlockField("담보비율", 7.4)] double PldgRat,
    [BlockField("예탁자산합계", 17)] long DpsastSum,
    [BlockField("한도변경가능금액", 16)] long LmtChgAbleAmt,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("주문가능수량", 16)] long OrdAbleQty,
    [BlockField("미수불가주문가능수량", 16)] long RcvblUablOrdAbleQty
    );


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ12200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("관리지점번호", 3)] string MgmtBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp
    );

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ12200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("관리지점번호", 3)] string MgmtBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp
    );

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가 조회: CSPAQ12200
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
public record CSPAQ12200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("출금가능금액", 16)] long MnyoutAbleAmt,
    [BlockField("거래소금액", 16)] long SeOrdAbleAmt,
    [BlockField("코스닥금액", 16)] long KdqOrdAbleAmt,
    [BlockField("잔고평가금액", 16)] long BalEvalAmt,
    [BlockField("미수금액", 16)] long RcvblAmt,
    [BlockField("예탁자산총액", 16)] long DpsastTotamt,
    [BlockField("손익율", 18.6)] double PnlRat,
    [BlockField("투자원금", 20)] long InvstOrgAmt,
    [BlockField("투자손익금액", 16)] long InvstPlAmt,
    [BlockField("신용담보주문금액", 16)] long CrdtPldgOrdAmt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("대용금액", 16)] long SubstAmt,
    [BlockField("D1예수금", 16)] long D1Dps,
    [BlockField("D2예수금", 16)] long D2Dps,
    [BlockField("현금미수금액", 16)] long MnyrclAmt,
    [BlockField("증거금현금", 16)] long MgnMny,
    [BlockField("증거금대용", 16)] long MgnSubst,
    [BlockField("수표금액", 16)] long ChckAmt,
    [BlockField("대용주문가능금액", 16)] long SubstOrdAbleAmt,
    [BlockField("증거금률100퍼센트주문가능금액", 16)] long MgnRat100pctOrdAbleAmt,
    [BlockField("증거금률35%주문가능금액", 16)] long MgnRat35ordAbleAmt,
    [BlockField("증거금률50%주문가능금액", 16)] long MgnRat50ordAbleAmt,
    [BlockField("전일매도정산금액", 16)] long PrdaySellAdjstAmt,
    [BlockField("전일매수정산금액", 16)] long PrdayBuyAdjstAmt,
    [BlockField("금일매도정산금액", 16)] long CrdaySellAdjstAmt,
    [BlockField("금일매수정산금액", 16)] long CrdayBuyAdjstAmt,
    [BlockField("D1연체변제소요금액", 16)] long D1ovdRepayRqrdAmt,
    [BlockField("D2연체변제소요금액", 16)] long D2ovdRepayRqrdAmt,
    [BlockField("D1추정인출가능금액", 16)] long D1PrsmptWthdwAbleAmt,
    [BlockField("D2추정인출가능금액", 16)] long D2PrsmptWthdwAbleAmt,
    [BlockField("예탁담보대출금액", 16)] long DpspdgLoanAmt,
    [BlockField("신용설정보증금", 16)] long Imreq,
    [BlockField("융자금액", 16)] long MloanAmt,
    [BlockField("변경후담보비율", 9.3)] double ChgAfPldgRat,
    [BlockField("원담보금액", 16)] long OrgPldgAmt,
    [BlockField("부담보금액", 16)] long SubPldgAmt,
    [BlockField("소요담보금액", 16)] long RqrdPldgAmt,
    [BlockField("원담보부족금액", 16)] long OrgPdlckAmt,
    [BlockField("담보부족금액", 16)] long PdlckAmt,
    [BlockField("추가담보현금", 16)] long AddPldgMny,
    [BlockField("D1주문가능금액", 16)] long D1OrdAbleAmt,
    [BlockField("신용이자미납금액", 16)] long CrdtIntdltAmt,
    [BlockField("기타대여금액", 16)] long EtclndAmt,
    [BlockField("익일추정반대매매금액", 16)] long NtdayPrsmptCvrgAmt,
    [BlockField("원담보합계금액", 16)] long OrgPldgSumAmt,
    [BlockField("신용주문가능금액", 16)] long CrdtOrdAbleAmt,
    [BlockField("부담보합계금액", 16)] long SubPldgSumAmt,
    [BlockField("신용담보금현금", 16)] long CrdtPldgAmtMny,
    [BlockField("신용담보대용금액", 16)] long CrdtPldgSubstAmt,
    [BlockField("추가신용담보현금", 16)] long AddCrdtPldgMny,
    [BlockField("신용담보재사용금액", 16)] long CrdtPldgRuseAmt,
    [BlockField("추가신용담보대용", 16)] long AddCrdtPldgSubst,
    [BlockField("매도대금담보대출금액", 16)] long CslLoanAmtdt1,
    [BlockField("처분제한금액", 16)] long DpslRestrcAmt
    );


/// <summary>
/// BEP단가조회: CSPAQ12300
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
/// <param name="CmsnAppTpCode">수수료적용구분	string	1</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	string	1</param>
/// <param name="UprcTpCode">단가구분	string	1</param>
public record CSPAQ12300InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp,
    [BlockField("수수료적용구분", 1)] string CmsnAppTpCode,
    [BlockField("D2잔고기준조회구분", 1)] string D2balBaseQryTp,
    [BlockField("단가구분", 1)] string UprcTpCode
    );

/// <summary>
/// BEP단가조회: CSPAQ12300
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
/// <param name="CmsnAppTpCode">수수료적용구분	string	1</param>
/// <param name="D2balBaseQryTp">D2잔고기준조회구분	string	1</param>
/// <param name="UprcTpCode">단가구분	string	1</param>
public record CSPAQ12300OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp,
    [BlockField("수수료적용구분", 1)] string CmsnAppTpCode,
    [BlockField("D2잔고기준조회구분", 1)] string D2balBaseQryTp,
    [BlockField("단가구분", 1)] string UprcTpCode
    );

/// <summary>
/// BEP단가조회: CSPAQ12300
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
public record CSPAQ12300OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("출금가능금액", 16)] long MnyoutAbleAmt,
    [BlockField("거래소금액", 16)] long SeOrdAbleAmt,
    [BlockField("코스닥금액", 16)] long KdqOrdAbleAmt,
    [BlockField("HTS주문가능금액", 16)] long HtsOrdAbleAmt,
    [BlockField("증거금률100퍼센트주문가능금액", 16)] long MgnRat100pctOrdAbleAmt,
    [BlockField("잔고평가금액", 16)] long BalEvalAmt,
    [BlockField("매입금액", 16)] long PchsAmt,
    [BlockField("미수금액", 16)] long RcvblAmt,
    [BlockField("손익율", 18.6)] double PnlRat,
    [BlockField("투자원금", 20)] long InvstOrgAmt,
    [BlockField("투자손익금액", 16)] long InvstPlAmt,
    [BlockField("신용담보주문금액", 16)] long CrdtPldgOrdAmt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("D1예수금", 16)] long D1Dps,
    [BlockField("D2예수금", 16)] long D2Dps,
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("현금증거금액", 16)] long MnyMgn,
    [BlockField("대용증거금액", 16)] long SubstMgn,
    [BlockField("대용금액", 16)] long SubstAmt,
    [BlockField("전일매수체결금액", 16)] long PrdayBuyExecAmt,
    [BlockField("전일매도체결금액", 16)] long PrdaySellExecAmt,
    [BlockField("금일매수체결금액", 16)] long CrdayBuyExecAmt,
    [BlockField("금일매도체결금액", 16)] long CrdaySellExecAmt,
    [BlockField("평가손익합계", 15)] long EvalPnlSum,
    [BlockField("예탁자산총액", 16)] long DpsastTotamt,
    [BlockField("제비용", 19)] long Evrprc,
    [BlockField("재사용금액", 16)] long RuseAmt,
    [BlockField("기타대여금액", 16)] long EtclndAmt,
    [BlockField("가정산금액", 16)] long PrcAdjstAmt,
    [BlockField("D1수수료", 16)] long D1CmsnAmt,
    [BlockField("D2수수료", 16)] long D2CmsnAmt,
    [BlockField("D1제세금", 16)] long D1EvrTax,
    [BlockField("D2제세금", 16)] long D2EvrTax,
    [BlockField("D1결제예정금액", 16)] long D1SettPrergAmt,
    [BlockField("D2결제예정금액", 16)] long D2SettPrergAmt,
    [BlockField("전일KSE현금증거금", 16)] long PrdayKseMnyMgn,
    [BlockField("전일KSE대용증거금", 16)] long PrdayKseSubstMgn,
    [BlockField("전일KSE신용현금증거금", 16)] long PrdayKseCrdtMnyMgn,
    [BlockField("전일KSE신용대용증거금", 16)] long PrdayKseCrdtSubstMgn,
    [BlockField("금일KSE현금증거금", 16)] long CrdayKseMnyMgn,
    [BlockField("금일KSE대용증거금", 16)] long CrdayKseSubstMgn,
    [BlockField("금일KSE신용현금증거금", 16)] long CrdayKseCrdtMnyMgn,
    [BlockField("금일KSE신용대용증거금", 16)] long CrdayKseCrdtSubstMgn,
    [BlockField("전일코스닥현금증거금", 16)] long PrdayKdqMnyMgn,
    [BlockField("전일코스닥대용증거금", 16)] long PrdayKdqSubstMgn,
    [BlockField("전일코스닥신용현금증거금", 16)] long PrdayKdqCrdtMnyMgn,
    [BlockField("전일코스닥신용대용증거금", 16)] long PrdayKdqCrdtSubstMgn,
    [BlockField("금일코스닥현금증거금", 16)] long CrdayKdqMnyMgn,
    [BlockField("금일코스닥대용증거금", 16)] long CrdayKdqSubstMgn,
    [BlockField("금일코스닥신용현금증거금", 16)] long CrdayKdqCrdtMnyMgn,
    [BlockField("금일코스닥신용대용증거금", 16)] long CrdayKdqCrdtSubstMgn,
    [BlockField("전일프리보드현금증거금", 16)] long PrdayFrbrdMnyMgn,
    [BlockField("전일프리보드대용증거금", 16)] long PrdayFrbrdSubstMgn,
    [BlockField("금일프리보드현금증거금", 16)] long CrdayFrbrdMnyMgn,
    [BlockField("금일프리보드대용증거금", 16)] long CrdayFrbrdSubstMgn,
    [BlockField("전일장외현금증거금", 16)] long PrdayCrbmkMnyMgn,
    [BlockField("전일장외대용증거금", 16)] long PrdayCrbmkSubstMgn,
    [BlockField("금일장외현금증거금", 16)] long CrdayCrbmkMnyMgn,
    [BlockField("금일장외대용증거금", 16)] long CrdayCrbmkSubstMgn,
    [BlockField("예탁담보수량", 16)] long DpspdgQty,
    [BlockField("매수정산금(D+2)", 16)] long BuyAdjstAmtD2,
    [BlockField("매도정산금(D+2)", 16)] long SellAdjstAmtD2,
    [BlockField("변제소요금(D+1)", 16)] long RepayRqrdAmtD1,
    [BlockField("변제소요금(D+2)", 16)] long RepayRqrdAmtD2,
    [BlockField("대출금액", 16)] long LoanAmt
    );

/// <summary>
/// BEP단가조회: CSPAQ12300
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
public record CSPAQ12300OutBlock3(
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("유가증권잔고유형코드", 2)] string SecBalPtnCode,
    [BlockField("유가증권잔고유형명", 40)] string SecBalPtnNm,
    [BlockField("잔고수량", 16)] long BalQty,
    [BlockField("매매기준잔고수량", 16)] long BnsBaseBalQty,
    [BlockField("금일매수체결수량", 16)] long CrdayBuyExecQty,
    [BlockField("금일매도체결수량", 16)] long CrdaySellExecQty,
    [BlockField("매도가", 21.4)] double SellPrc,
    [BlockField("매수가", 21.4)] double BuyPrc,
    [BlockField("매도손익금액", 16)] long SellPnlAmt,
    [BlockField("손익율", 18.6)] double PnlRat,
    [BlockField("현재가", 15.2)] double NowPrc,
    [BlockField("신용금액", 16)] long CrdtAmt,
    [BlockField("만기일", 8)] string DueDt,
    [BlockField("전일매도체결가", 13.2)] double PrdaySellExecPrc,
    [BlockField("전일매도수량", 16)] long PrdaySellQty,
    [BlockField("전일매수체결가", 13.2)] double PrdayBuyExecPrc,
    [BlockField("전일매수수량", 16)] long PrdayBuyQty,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("평균단가", 13.2)] double AvrUprc,
    [BlockField("매도가능수량", 16)] long SellAbleQty,
    [BlockField("매도주문수량", 16)] long SellOrdQty,
    [BlockField("금일매수체결금액", 16)] long CrdayBuyExecAmt,
    [BlockField("금일매도체결금액", 16)] long CrdaySellExecAmt,
    [BlockField("전일매수체결금액", 16)] long PrdayBuyExecAmt,
    [BlockField("전일매도체결금액", 16)] long PrdaySellExecAmt,
    [BlockField("잔고평가금액", 16)] long BalEvalAmt,
    [BlockField("평가손익", 16)] long EvalPnl,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt,
    [BlockField("매도미체결수량", 16)] long SellUnercQty,
    [BlockField("매도미결제수량", 16)] long SellUnsttQty,
    [BlockField("매수미체결수량", 16)] long BuyUnercQty,
    [BlockField("매수미결제수량", 16)] long BuyUnsttQty,
    [BlockField("미결제수량", 16)] long UnsttQty,
    [BlockField("미체결수량", 16)] long UnercQty,
    [BlockField("전일종가", 15.2)] double PrdayCprc,
    [BlockField("매입금액", 16)] long PchsAmt,
    [BlockField("등록시장코드", 2)] string RegMktCode,
    [BlockField("대출상세분류코드", 2)] string LoanDtlClssCode,
    [BlockField("예탁담보대출수량", 16)] long DpspdgLoanQty
    );


/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700
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
public record CSPAQ13700InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("체결여부", 1)] string ExecYn,
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("시작주문번호2", 10)] long SrtOrdNo2,
    [BlockField("역순구분", 1)] string BkseqTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode
    );

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700
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
public record CSPAQ13700OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("체결여부", 1)] string ExecYn,
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("시작주문번호2", 10)] long SrtOrdNo2,
    [BlockField("역순구분", 1)] string BkseqTpCode,
    [BlockField("주문유형코드", 2)] string OrdPtnCode
    );

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="SellExecAmt">매도체결금액	long	16</param>
/// <param name="BuyExecAmt">매수체결금액	long	16</param>
/// <param name="SellExecQty">매도체결수량	long	16</param>
/// <param name="BuyExecQty">매수체결수량	long	16</param>
/// <param name="SellOrdQty">매도주문수량	long	16</param>
/// <param name="BuyOrdQty">매수주문수량	long	16</param>
public record CSPAQ13700OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("매도체결금액", 16)] long SellExecAmt,
    [BlockField("매수체결금액", 16)] long BuyExecAmt,
    [BlockField("매도체결수량", 16)] long SellExecQty,
    [BlockField("매수체결수량", 16)] long BuyExecQty,
    [BlockField("매도주문수량", 16)] long SellOrdQty,
    [BlockField("매수주문수량", 16)] long BuyOrdQty
    );

/// <summary>
/// 현물계좌주문체결내역조회: CSPAQ13700
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
public record CSPAQ13700OutBlock3(
    [BlockField("주문일", 8)] string OrdDt,
    [BlockField("관리지점번호", 3)] string MgmtBrnNo,
    [BlockField("주문시장코드", 2)] string OrdMktCode,
    [BlockField("주문번호", 10)] long OrdNo,
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("매매구분", 10)] string BnsTpNm,
    [BlockField("주문유형코드", 2)] string OrdPtnCode,
    [BlockField("주문유형명", 40)] string OrdPtnNm,
    [BlockField("주문처리유형코드", 9)] long OrdTrxPtnCode,
    [BlockField("주문처리유형명", 50)] string OrdTrxPtnNm,
    [BlockField("정정취소구분", 1)] string MrcTpCode,
    [BlockField("정정취소구분명", 10)] string MrcTpNm,
    [BlockField("정정취소수량", 16)] long MrcQty,
    [BlockField("정정취소가능수량", 16)] long MrcAbleQty,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("체결수량", 16)] long ExecQty,
    [BlockField("체결가", 15.2)] double ExecPrc,
    [BlockField("체결처리시각", 9)] string ExecTrxTime,
    [BlockField("최종체결시각", 9)] string LastExecTime,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("호가유형명", 40)] string OrdprcPtnNm,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode,
    [BlockField("전체체결수량", 16)] long AllExecQty,
    [BlockField("통신매체코드", 2)] string RegCommdaCode,
    [BlockField("통신매체명", 40)] string CommdaNm,
    [BlockField("회원번호", 3)] string MbrNo,
    [BlockField("예약주문여부", 1)] string RsvOrdYn,
    [BlockField("대출일", 8)] string LoanDt,
    [BlockField("주문시각", 9)] string OrdTime,
    [BlockField("운용지시번호", 12)] string OpDrtnNo,
    [BlockField("주문자ID", 16)] string OdrrId
    );


/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ22200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("관리지점번호", 3)] string MgmtBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp
    );

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="MgmtBrnNo">관리지점번호	string	3</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="BalCreTp">잔고생성구분	string	1</param>
public record CSPAQ22200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("관리지점번호", 3)] string MgmtBrnNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("잔고생성구분", 1)] string BalCreTp
    );

/// <summary>
/// 현물계좌예수금 주문가능금액 총평가2: CSPAQ22200
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
public record CSPAQ22200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("지점명", 40)] string BrnNm,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("대용주문가능금액", 16)] long SubstOrdAbleAmt,
    [BlockField("거래소금액", 16)] long SeOrdAbleAmt,
    [BlockField("코스닥금액", 16)] long KdqOrdAbleAmt,
    [BlockField("신용담보주문금액", 16)] long CrdtPldgOrdAmt,
    [BlockField("증거금률100퍼센트주문가능금액", 16)] long MgnRat100pctOrdAbleAmt,
    [BlockField("증거금률35%주문가능금액", 16)] long MgnRat35ordAbleAmt,
    [BlockField("증거금률50%주문가능금액", 16)] long MgnRat50ordAbleAmt,
    [BlockField("신용주문가능금액", 16)] long CrdtOrdAbleAmt,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("대용금액", 16)] long SubstAmt,
    [BlockField("증거금현금", 16)] long MgnMny,
    [BlockField("증거금대용", 16)] long MgnSubst,
    [BlockField("D1예수금", 16)] long D1Dps,
    [BlockField("D2예수금", 16)] long D2Dps,
    [BlockField("미수금액", 16)] long RcvblAmt,
    [BlockField("D1연체변제소요금액", 16)] long D1ovdRepayRqrdAmt,
    [BlockField("D2연체변제소요금액", 16)] long D2ovdRepayRqrdAmt,
    [BlockField("융자금액", 16)] long MloanAmt,
    [BlockField("변경후담보비율", 9.3)] double ChgAfPldgRat,
    [BlockField("소요담보금액", 16)] long RqrdPldgAmt,
    [BlockField("담보부족금액", 16)] long PdlckAmt,
    [BlockField("원담보합계금액", 16)] long OrgPldgSumAmt,
    [BlockField("부담보합계금액", 16)] long SubPldgSumAmt,
    [BlockField("신용담보금현금", 16)] long CrdtPldgAmtMny,
    [BlockField("신용담보대용금액", 16)] long CrdtPldgSubstAmt,
    [BlockField("신용설정보증금", 16)] long Imreq,
    [BlockField("신용담보재사용금액", 16)] long CrdtPldgRuseAmt,
    [BlockField("처분제한금액", 16)] long DpslRestrcAmt,
    [BlockField("전일매도정산금액", 16)] long PrdaySellAdjstAmt,
    [BlockField("전일매수정산금액", 16)] long PrdayBuyAdjstAmt,
    [BlockField("금일매도정산금액", 16)] long CrdaySellAdjstAmt,
    [BlockField("금일매수정산금액", 16)] long CrdayBuyAdjstAmt,
    [BlockField("매도대금담보대출금액", 16)] long CslLoanAmtdt1
    );


/// <summary>
/// 현물주문: CSPAT00600
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
public record CSPAT00600InBlock1(
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
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
/// 현물주문: CSPAT00600
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
public record CSPAT00600OutBlock1(
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
    [BlockField("반대매매구분", 1)] string CvrgTpCode
    );

/// <summary>
/// 현물주문: CSPAT00600
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
public record CSPAT00600OutBlock2(
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
    [BlockField("종목명", 40)] string IsuNm
    );


/// <summary>
/// 현물정정주문: CSPAT00700
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
/// <param name="OrdprcPtnCode">호가유형코드	string	2</param>
/// <param name="OrdCndiTpCode">주문조건구분	string	1</param>
/// <param name="OrdPrc">주문가	double	13.2</param>
public record CSPAT00700InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty,
    [BlockField("호가유형코드", 2)] string OrdprcPtnCode,
    [BlockField("주문조건구분", 1)] string OrdCndiTpCode,
    [BlockField("주문가", 13.2)] double OrdPrc
    );

/// <summary>
/// 현물정정주문: CSPAT00700
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
public record CSPAT00700OutBlock1(
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
/// 현물정정주문: CSPAT00700
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
public record CSPAT00700OutBlock2(
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


/// <summary>
/// 현물취소주문: CSPAT00800
/// </summary>
/// <param name="OrgOrdNo">원주문번호	long	10</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdQty">주문수량	long	16</param>
public record CSPAT00800InBlock1(
    [BlockField("원주문번호", 10)] long OrgOrdNo,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문수량", 16)] long OrdQty
    );

/// <summary>
/// 현물취소주문: CSPAT00800
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
public record CSPAT00800OutBlock1(
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
/// 현물취소주문: CSPAT00800
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
public record CSPAT00800OutBlock2(
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


/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="RegCommdaCode">통신매체코드	string	2</param>
public record CSPBQ00200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("통신매체코드", 2)] string RegCommdaCode
    );

/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="BnsTpCode">매매구분	string	1</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="InptPwd">입력비밀번호	string	8</param>
/// <param name="IsuNo">종목번호	string	12</param>
/// <param name="OrdPrc">주문가격	double	15.2</param>
/// <param name="RegCommdaCode">통신매체코드	string	2</param>
public record CSPBQ00200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("매매구분", 1)] string BnsTpCode,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("입력비밀번호", 8)] string InptPwd,
    [BlockField("종목번호", 12)] string IsuNo,
    [BlockField("주문가격", 15.2)] double OrdPrc,
    [BlockField("통신매체코드", 2)] string RegCommdaCode
    );

/// <summary>
/// 현물계좌증거금률별주문가능수량조회: CSPBQ00200
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
public record CSPBQ00200OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("종목명", 40)] string IsuNm,
    [BlockField("예수금", 16)] long Dps,
    [BlockField("대용금액", 16)] long SubstAmt,
    [BlockField("신용담보재사용금액", 16)] long CrdtPldgRuseAmt,
    [BlockField("현금주문가능금액", 16)] long MnyOrdAbleAmt,
    [BlockField("대용주문가능금액", 16)] long SubstOrdAbleAmt,
    [BlockField("현금증거금액", 16)] long MnyMgn,
    [BlockField("대용증거금액", 16)] long SubstMgn,
    [BlockField("거래소금액", 16)] long SeOrdAbleAmt,
    [BlockField("코스닥금액", 16)] long KdqOrdAbleAmt,
    [BlockField("추정예수금(D+1)", 16)] long PrsmptDpsD1,
    [BlockField("추정예수금(D+2)", 16)] long PrsmptDpsD2,
    [BlockField("출금가능금액", 16)] long MnyoutAbleAmt,
    [BlockField("미수금액", 16)] long RcvblAmt,
    [BlockField("수수료율", 15.5)] double CmsnRat,
    [BlockField("추가징수금액", 16)] long AddLevyAmt,
    [BlockField("재사용대상금액", 16)] long RuseObjAmt,
    [BlockField("현금재사용대상금액", 16)] long MnyRuseObjAmt,
    [BlockField("이용사증거금률", 7.4)] double FirmMgnRat,
    [BlockField("대용재사용대상금액", 16)] long SubstRuseObjAmt,
    [BlockField("종목증거금률", 7.4)] double IsuMgnRat,
    [BlockField("계좌증거금률", 7.4)] double AcntMgnRat,
    [BlockField("거래증거금률", 7.4)] double TrdMgnrt,
    [BlockField("수수료", 16)] long Cmsn,
    [BlockField("증거금률20퍼센트주문가능금액", 16)] long MgnRat20pctOrdAbleAmt,
    [BlockField("증거금률100퍼센트현금주문가능수량?", 16)] long MgnRat20OrdAbleQty,
    [BlockField("증거금률30퍼센트주문가능금액", 16)] long MgnRat30pctOrdAbleAmt,
    [BlockField("증거금률30퍼센트주문가능수량??", 16)] long MgnRat30OrdAbleQty,
    [BlockField("증거금률40퍼센트주문가능금액", 16)] long MgnRat40pctOrdAbleAmt,
    [BlockField("증거금률40퍼센트주문가능수량??", 16)] long MgnRat40OrdAbleQty,
    [BlockField("증거금률100퍼센트주문가능금액", 16)] long MgnRat100pctOrdAbleAmt,
    [BlockField("증거금률100퍼센트주문가능수량??", 16)] long MgnRat100OrdAbleQty,
    [BlockField("증거금률100퍼센트현금주문가능금액?", 16)] long MgnRat100MnyOrdAbleAmt,
    [BlockField("증거금률100퍼센트현금주문가능수량", 16)] long MgnRat100MnyOrdAbleQty,
    [BlockField("증거금률20퍼센트재사용가능금액", 16)] long MgnRat20pctRuseAbleAmt,
    [BlockField("증거금률30퍼센트재사용가능금액", 16)] long MgnRat30pctRuseAbleAmt,
    [BlockField("증거금률40퍼센트재사용가능금액", 16)] long MgnRat40pctRuseAbleAmt,
    [BlockField("증거금률100퍼센트재사용가능금액", 16)] long MgnRat100pctRuseAbleAmt,
    [BlockField("주문가능수량", 16)] long OrdAbleQty,
    [BlockField("주문가능금액", 16)] long OrdAbleAmt
    );


/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="TermTp">기간구분	string	1</param>
public record FOCCQ33600InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("기간구분", 1)] string TermTp
    );

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNo">계좌번호	string	20</param>
/// <param name="Pwd">비밀번호	string	8</param>
/// <param name="QrySrtDt">조회시작일	string	8</param>
/// <param name="QryEndDt">조회종료일	string	8</param>
/// <param name="TermTp">기간구분	string	1</param>
public record FOCCQ33600OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("기간구분", 1)] string TermTp
    );

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="AcntNm">계좌명	string	40</param>
/// <param name="BnsctrAmt">매매약정금액	long	16</param>
/// <param name="MnyinAmt">입금금액	long	16</param>
/// <param name="MnyoutAmt">출금금액	long	16</param>
/// <param name="InvstAvrbalPramt">투자원금평잔금액	long	16</param>
/// <param name="InvstPlAmt">투자손익금액	long	16</param>
/// <param name="InvstErnrat">투자수익률	double	9.2</param>
public record FOCCQ33600OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("매매약정금액", 16)] long BnsctrAmt,
    [BlockField("입금금액", 16)] long MnyinAmt,
    [BlockField("출금금액", 16)] long MnyoutAmt,
    [BlockField("투자원금평잔금액", 16)] long InvstAvrbalPramt,
    [BlockField("투자손익금액", 16)] long InvstPlAmt,
    [BlockField("투자수익률", 9.2)] double InvstErnrat
    );

/// <summary>
/// 주식계좌 기간별수익률 상세: FOCCQ33600
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
public record FOCCQ33600OutBlock3(
    [BlockField("기준일", 8)] string BaseDt,
    [BlockField("기초평가금액", 19)] long FdEvalAmt,
    [BlockField("기말평가금액", 19)] long EotEvalAmt,
    [BlockField("투자원금평잔금액", 16)] long InvstAvrbalPramt,
    [BlockField("매매약정금액", 16)] long BnsctrAmt,
    [BlockField("입금고액", 16)] long MnyinSecinAmt,
    [BlockField("출금고액", 16)] long MnyoutSecoutAmt,
    [BlockField("평가손익금액", 16)] long EvalPnlAmt,
    [BlockField("기간수익률", 11.3)] double TermErnrat,
    [BlockField("지수", 13.2)] double Idx
    );


/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700
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
public record FOCCQ33700InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("기준금액구분", 1)] string BaseAmtTp,
    [BlockField("조회기간구분", 1)] string QryTermTp,
    [BlockField("손익산출구분코드", 1)] string PnlCalcTpCode
    );

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700
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
public record FOCCQ33700OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌번호", 20)] string AcntNo,
    [BlockField("비밀번호", 8)] string Pwd,
    [BlockField("조회시작일", 8)] string QrySrtDt,
    [BlockField("조회종료일", 8)] string QryEndDt,
    [BlockField("조회구분", 1)] string QryTp,
    [BlockField("기준금액구분", 1)] string BaseAmtTp,
    [BlockField("조회기간구분", 1)] string QryTermTp,
    [BlockField("손익산출구분코드", 1)] string PnlCalcTpCode
    );

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700
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
public record FOCCQ33700OutBlock2(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("계좌명", 40)] string AcntNm,
    [BlockField("입금액", 16)] long InAmt,
    [BlockField("출금액", 16)] long OutAmt,
    [BlockField("선물옵션약정금액", 16)] long FnoCtrctAmt,
    [BlockField("투자원금평잔금액", 16)] long InvstPramtAvrbalAmt,
    [BlockField("선물정산차금", 16)] long FutsAdjstDfamt,
    [BlockField("옵션매매손익금액", 16)] long OptBsnPnlAmt,
    [BlockField("옵션평가손익금액", 16)] long OptEvalPnlAmt,
    [BlockField("투자손익금액", 16)] long InvstPlAmt,
    [BlockField("수익률", 12.6)] double ErnRat
    );

/// <summary>
/// 선물옵션 기간별 계좌 수익률 현황: FOCCQ33700
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
public record FOCCQ33700OutBlock3(
    [BlockField("거래일", 8)] string TrdDt,
    [BlockField("기초예탁자산금액", 16)] long FdDpsastAmt,
    [BlockField("기말예탁자산금액", 16)] long EotDpsastAmt,
    [BlockField("입금액", 16)] long InAmt,
    [BlockField("출금액", 16)] long OutAmt,
    [BlockField("투자원금평잔금액", 16)] long InvstAvrbalPramt,
    [BlockField("투자손익금액", 16)] long InvstPlAmt,
    [BlockField("수익률", 12.6)] double Ernrat,
    [BlockField("선물옵션약정금액", 16)] long FnoCtrctAmt,
    [BlockField("회전율", 12.6)] double Trnrat,
    [BlockField("선물정산차금", 16)] long FutsAdjstDfamt,
    [BlockField("옵션매매손익금액", 16)] long OptBsnPnlAmt,
    [BlockField("옵션평가손익금액", 16)] long OptEvalPnlAmt
    );


/// <summary>
/// 파생상품증거금율조회: MMDAQ91200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
public record MMDAQ91200InBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("종목대분류코드", 2)] string IsuLgclssCode,
    [BlockField("종목중분류코드", 2)] string IsuMdclssCode
    );

/// <summary>
/// 파생상품증거금율조회: MMDAQ91200
/// </summary>
/// <param name="RecCnt">레코드갯수	int	5</param>
/// <param name="IsuLgclssCode">종목대분류코드	string	2</param>
/// <param name="IsuMdclssCode">종목중분류코드	string	2</param>
public record MMDAQ91200OutBlock1(
    [BlockField("레코드갯수", 5)] int RecCnt,
    [BlockField("종목대분류코드", 2)] string IsuLgclssCode,
    [BlockField("종목중분류코드", 2)] string IsuMdclssCode
    );

/// <summary>
/// 파생상품증거금율조회: MMDAQ91200
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
public record MMDAQ91200OutBlock2(
    [BlockField("종목소분류코드", 3)] string IsuSmclssCode,
    [BlockField("종목중분류코드", 2)] string IsuMdclssCode,
    [BlockField("종목대중분류명", 40)] string IsuLrgMdclssNm,
    [BlockField("종목대중소분류명", 40)] string IsuLrgMidSmclssNm,
    [BlockField("단축한글종목명", 40)] string ShtnHanglIsuNm,
    [BlockField("위탁증거금율", 26.9)] double CsgnMgnrt,
    [BlockField("유지증거금율", 26.9)] double MaintMgnrt,
    [BlockField("현금증거금율", 26.9)] double MnyMgnrt,
    [BlockField("잔여일수", 6)] int RmndDays,
    [BlockField("1계약당주문증거금", 17)] long OnePrcntrOrdMgn
    );


/// <summary>
/// 해외선물마스터조회-API용: o3101
/// </summary>
/// <param name="gubun">입력구분(예비)	string	1</param>
public record o3101InBlock(
    [BlockField("입력구분(예비)", 1)] string gubun
    );

/// <summary>
/// 해외선물마스터조회-API용: o3101
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
public record o3101OutBlock(
    [BlockField("종목코드", 8)] string Symbol,
    [BlockField("종목명", 50)] string SymbolNm,
    [BlockField("종목배치수신일(한국일자)", 8)] string ApplDate,
    [BlockField("기초상품코드", 10)] string BscGdsCd,
    [BlockField("기초상품명", 40)] string BscGdsNm,
    [BlockField("거래소코드", 10)] string ExchCd,
    [BlockField("거래소명", 40)] string ExchNm,
    [BlockField("기준통화코드", 3)] string CrncyCd,
    [BlockField("진법구분코드", 3)] string NotaCd,
    [BlockField("호가단위가격", 15.9)] double UntPrc,
    [BlockField("최소가격변동금액", 15.9)] double MnChgAmt,
    [BlockField("가격조정계수", 15.1)] double RgltFctr,
    [BlockField("계약당금액", 15.2)] double CtrtPrAmt,
    [BlockField("상품구분코드", 3)] string GdsCd,
    [BlockField("월물(년)", 4)] string LstngYr,
    [BlockField("월물(월)", 1)] string LstngM,
    [BlockField("정산가격", 15.9)] double EcPrc,
    [BlockField("거래시작시간", 6)] string DlStrtTm,
    [BlockField("거래종료시간", 6)] string DlEndTm,
    [BlockField("거래가능구분코드", 1)] string DlPsblCd,
    [BlockField("증거금징수구분코드", 1)] string MgnCltCd,
    [BlockField("개시증거금", 15.2)] double OpngMgn,
    [BlockField("유지증거금", 15.2)] double MntncMgn,
    [BlockField("개시증거금율", 7.3)] double OpngMgnR,
    [BlockField("유지증거금율", 7.3)] double MntncMgnR,
    [BlockField("유효소수점자리수", 2)] int DotGb
    );


/// <summary>
/// 해외선물차트(분)-API용: o3103
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">N분주기	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3103InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("N분주기", 4)] int ncnt,
    [BlockField("조회건수", 4)] int readcnt,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 6)] string cts_time
    );

/// <summary>
/// 해외선물차트(분)-API용: o3103
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="timediff">시차	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3103OutBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("시차", 4)] int timediff,
    [BlockField("조회건수", 4)] int readcnt,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 6)] string cts_time
    );

/// <summary>
/// 해외선물차트(분)-API용: o3103
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">현지시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3103OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("현지시간", 6)] string time,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물일별체결조회-API용: o3104
/// </summary>
/// <param name="gubun">조회구분	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="date">조회일자	string	8</param>
public record o3104InBlock(
    [BlockField("조회구분", 1)] string gubun,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("조회일자", 8)] string date
    );

/// <summary>
/// 해외선물일별체결조회-API용: o3104
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
public record o3104OutBlock1(
    [BlockField("일자", 8)] string chedate,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("체결구분", 1)] string cgubun,
    [BlockField("누적거래량", 10)] long volume
    );


/// <summary>
/// 해외선물현재가(종목정보)조회-API용: o3105
/// </summary>
/// <param name="symbol">종목코드	string	8</param>
public record o3105InBlock(
    [BlockField("종목코드", 8)] string symbol
    );

/// <summary>
/// 해외선물현재가(종목정보)조회-API용: o3105
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
public record o3105OutBlock(
    [BlockField("종목코드", 8)] string Symbol,
    [BlockField("종목명", 50)] string SymbolNm,
    [BlockField("종목배치수신일", 8)] string ApplDate,
    [BlockField("기초상품코드", 10)] string BscGdsCd,
    [BlockField("기초상품명", 40)] string BscGdsNm,
    [BlockField("거래소코드", 10)] string ExchCd,
    [BlockField("거래소명", 40)] string ExchNm,
    [BlockField("정산구분코드", 1)] string EcCd,
    [BlockField("기준통화코드", 3)] string CrncyCd,
    [BlockField("진법구분코드", 3)] string NotaCd,
    [BlockField("호가단위가격", 15.9)] double UntPrc,
    [BlockField("최소가격변동금액", 15.9)] double MnChgAmt,
    [BlockField("가격조정계수", 15.1)] double RgltFctr,
    [BlockField("계약당금액", 15.2)] double CtrtPrAmt,
    [BlockField("상장개월수", 2)] int LstngMCnt,
    [BlockField("상품구분코드", 3)] string GdsCd,
    [BlockField("시장구분코드", 3)] string MrktCd,
    [BlockField("Emini구분코드", 1)] string EminiCd,
    [BlockField("상장년", 4)] string LstngYr,
    [BlockField("상장월", 1)] string LstngM,
    [BlockField("월물순서", 5)] int SeqNo,
    [BlockField("상장일자", 8)] string LstngDt,
    [BlockField("최종거래가능일", 8)] string MtrtDt,
    [BlockField("최종거래일", 8)] string FnlDlDt,
    [BlockField("최초인도통지일자", 8)] string FstTrsfrDt,
    [BlockField("정산가격", 15.9)] double EcPrc,
    [BlockField("거래시작일자(한국)", 8)] string DlDt,
    [BlockField("거래시작시간(한국)", 6)] string DlStrtTm,
    [BlockField("거래종료시간(한국)", 6)] string DlEndTm,
    [BlockField("거래시작일자(현지)", 8)] string OvsStrDay,
    [BlockField("거래시작시간(현지)", 6)] string OvsStrTm,
    [BlockField("거래종료일자(현지)", 8)] string OvsEndDay,
    [BlockField("거래종료시간(현지)", 6)] string OvsEndTm,
    [BlockField("거래가능구분코드", 1)] string DlPsblCd,
    [BlockField("증거금징수구분코드", 1)] string MgnCltCd,
    [BlockField("개시증거금", 15.2)] double OpngMgn,
    [BlockField("유지증거금", 15.2)] double MntncMgn,
    [BlockField("개시증거금율", 7.3)] double OpngMgnR,
    [BlockField("유지증거금율", 7.3)] double MntncMgnR,
    [BlockField("유효소수점자리수", 2)] int DotGb,
    [BlockField("시차", 5)] int TimeDiff,
    [BlockField("현지체결일자", 8)] string OvsDate,
    [BlockField("한국체결일자", 8)] string KorDate,
    [BlockField("현지체결시간", 6)] string TrdTm,
    [BlockField("한국체결시각", 6)] string RcvTm,
    [BlockField("체결가격", 15.9)] double TrdP,
    [BlockField("체결수량", 10)] long TrdQ,
    [BlockField("누적거래량", 15)] long TotQ,
    [BlockField("체결거래대금", 15.2)] double TrdAmt,
    [BlockField("누적거래대금", 15.2)] double TotAmt,
    [BlockField("시가", 15.9)] double OpenP,
    [BlockField("고가", 15.9)] double HighP,
    [BlockField("저가", 15.9)] double LowP,
    [BlockField("전일종가", 15.9)] double CloseP,
    [BlockField("전일대비", 15.9)] double YdiffP,
    [BlockField("전일대비구분", 1)] string YdiffSign,
    [BlockField("체결구분", 1)] string Cgubun,
    [BlockField("등락율", 6.2)] double Diff
    );


/// <summary>
/// 해외선물현재가호가조회-API용: o3106
/// </summary>
/// <param name="symbol">단축코드	string	8</param>
public record o3106InBlock(
    [BlockField("단축코드", 8)] string symbol
    );

/// <summary>
/// 해외선물현재가호가조회-API용: o3106
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
public record o3106OutBlock(
    [BlockField("종목코드", 8)] string symbol,
    [BlockField("종목명", 50)] string symbolname,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("전일종가", 15.9)] double jnilclose,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("호가수신시간", 6)] string hotime,
    [BlockField("매도호가1", 15.9)] double offerho1,
    [BlockField("매수호가1", 15.9)] double bidho1,
    [BlockField("매도호가건수1", 10)] long offercnt1,
    [BlockField("매수호가건수1", 10)] long bidcnt1,
    [BlockField("매도호가수량1", 10)] long offerrem1,
    [BlockField("매수호가수량1", 10)] long bidrem1,
    [BlockField("매도호가2", 15.9)] double offerho2,
    [BlockField("매수호가2", 15.9)] double bidho2,
    [BlockField("매도호가건수2", 10)] long offercnt2,
    [BlockField("매수호가건수2", 10)] long bidcnt2,
    [BlockField("매도호가수량2", 10)] long offerrem2,
    [BlockField("매수호가수량2", 10)] long bidrem2,
    [BlockField("매도호가3", 15.9)] double offerho3,
    [BlockField("매수호가3", 15.9)] double bidho3,
    [BlockField("매도호가건수3", 10)] long offercnt3,
    [BlockField("매수호가건수3", 10)] long bidcnt3,
    [BlockField("매도호가수량3", 10)] long offerrem3,
    [BlockField("매수호가수량3", 10)] long bidrem3,
    [BlockField("매도호가4", 15.9)] double offerho4,
    [BlockField("매수호가4", 15.9)] double bidho4,
    [BlockField("매도호가건수4", 10)] long offercnt4,
    [BlockField("매수호가건수4", 10)] long bidcnt4,
    [BlockField("매도호가수량4", 10)] long offerrem4,
    [BlockField("매수호가수량4", 10)] long bidrem4,
    [BlockField("매도호가5", 15.9)] double offerho5,
    [BlockField("매수호가5", 15.9)] double bidho5,
    [BlockField("매도호가건수5", 10)] long offercnt5,
    [BlockField("매수호가건수5", 10)] long bidcnt5,
    [BlockField("매도호가수량5", 10)] long offerrem5,
    [BlockField("매수호가수량5", 10)] long bidrem5,
    [BlockField("매도호가건수합", 10)] long offercnt,
    [BlockField("매수호가건수합", 10)] long bidcnt,
    [BlockField("매도호가수량합", 10)] long offer,
    [BlockField("매수호가수량합", 10)] long bid
    );


/// <summary>
/// 해외선물관심종목조회-API용: o3107
/// </summary>
/// <param name="symbol">종목심볼	string	8</param>
public record o3107InBlock(
    [BlockField("종목심볼", 8)] string symbol
    );

/// <summary>
/// 해외선물관심종목조회-API용: o3107
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
public record o3107OutBlock(
    [BlockField("종목코드", 8)] string symbol,
    [BlockField("종목명", 50)] string symbolname,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("전일종가", 15.9)] double jnilclose,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("매도호가1", 15.9)] double offerho1,
    [BlockField("매수호가1", 15.9)] double bidho1,
    [BlockField("매도호가건수1", 10)] long offercnt1,
    [BlockField("매수호가건수1", 10)] long bidcnt1,
    [BlockField("매도호가수량1", 10)] long offerrem1,
    [BlockField("매수호가수량1", 10)] long bidrem1,
    [BlockField("매도호가건수합", 10)] long offercnt,
    [BlockField("매수호가건수합", 10)] long bidcnt,
    [BlockField("매도호가수량합", 10)] long offer,
    [BlockField("매수호가수량합", 10)] long bid
    );


/// <summary>
/// 해외선물차트(일주월)-API용: o3108
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="gubun">주기구분	string	1</param>
/// <param name="qrycnt">요청건수	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
public record o3108InBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("주기구분", 1)] string gubun,
    [BlockField("요청건수", 4)] int qrycnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date
    );

/// <summary>
/// 해외선물차트(일주월)-API용: o3108
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
public record o3108OutBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("전일시가", 15.9)] double jisiga,
    [BlockField("전일고가", 15.9)] double jihigh,
    [BlockField("전일저가", 15.9)] double jilow,
    [BlockField("전일종가", 15.9)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 15.9)] double disiga,
    [BlockField("당일고가", 15.9)] double dihigh,
    [BlockField("당일저가", 15.9)] double dilow,
    [BlockField("당일종가", 15.9)] double diclose,
    [BlockField("장시작시간", 6)] string mk_stime,
    [BlockField("장마감시간", 6)] string mk_etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 해외선물차트(일주월)-API용: o3108
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3108OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물시간대별(Tick)체결-API용: o3116
/// </summary>
/// <param name="gubun">조회구분(0:당일1:전일)	string	1</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="readcnt">조회갯수	int	4</param>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3116InBlock(
    [BlockField("조회구분(0:당일1:전일)", 1)] string gubun,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("조회갯수", 4)] int readcnt,
    [BlockField("순번CTS", 8)] int cts_seq
    );

/// <summary>
/// 해외선물시간대별(Tick)체결-API용: o3116
/// </summary>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3116OutBlock(
    [BlockField("순번CTS", 8)] int cts_seq
    );

/// <summary>
/// 해외선물시간대별(Tick)체결-API용: o3116
/// </summary>
/// <param name="ovsdate">현지일자	string	8</param>
/// <param name="ovstime">현지시간	string	6</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	10</param>
/// <param name="volume">누적거래량	long	10</param>
public record o3116OutBlock1(
    [BlockField("현지일자", 8)] string ovsdate,
    [BlockField("현지시간", 6)] string ovstime,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 10)] long cvolume,
    [BlockField("누적거래량", 10)] long volume
    );


/// <summary>
/// 해외선물차트용NTick-API용: o3117
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3117InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("단위", 4)] int ncnt,
    [BlockField("건수", 4)] int qrycnt,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb
    );

/// <summary>
/// 해외선물차트용NTick-API용: o3117
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3117OutBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("레코드카운트", 7)] int rec_count,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb
    );

/// <summary>
/// 해외선물차트용NTick-API용: o3117
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3117OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물옵션마스터조회-API용: o3121
/// </summary>
/// <param name="MktGb">시장구분	string	1</param>
/// <param name="BscGdsCd">옵션기초상품코드	string	10</param>
public record o3121InBlock(
    [BlockField("시장구분", 1)] string MktGb,
    [BlockField("옵션기초상품코드", 10)] string BscGdsCd
    );

/// <summary>
/// 해외선물옵션마스터조회-API용: o3121
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
public record o3121OutBlock(
    [BlockField("종목코드", 16)] string Symbol,
    [BlockField("종목명", 50)] string SymbolNm,
    [BlockField("종목배치수신일(한국일자)", 8)] string ApplDate,
    [BlockField("기초상품코드", 10)] string BscGdsCd,
    [BlockField("기초상품명", 40)] string BscGdsNm,
    [BlockField("거래소코드", 10)] string ExchCd,
    [BlockField("거래소명", 40)] string ExchNm,
    [BlockField("기준통화코드", 3)] string CrncyCd,
    [BlockField("진법구분코드", 3)] string NotaCd,
    [BlockField("호가단위가격", 15.9)] double UntPrc,
    [BlockField("최소가격변동금액", 15.9)] double MnChgAmt,
    [BlockField("가격조정계수", 15.1)] double RgltFctr,
    [BlockField("계약당금액", 15.2)] double CtrtPrAmt,
    [BlockField("상품구분코드", 3)] string GdsCd,
    [BlockField("월물(년)", 4)] string LstngYr,
    [BlockField("월물(월)", 1)] string LstngM,
    [BlockField("정산가격", 15.9)] double EcPrc,
    [BlockField("거래시작시간", 6)] string DlStrtTm,
    [BlockField("거래종료시간", 6)] string DlEndTm,
    [BlockField("거래가능구분코드", 1)] string DlPsblCd,
    [BlockField("증거금징수구분코드", 1)] string MgnCltCd,
    [BlockField("개시증거금", 15.2)] double OpngMgn,
    [BlockField("유지증거금", 15.2)] double MntncMgn,
    [BlockField("개시증거금율", 7.3)] double OpngMgnR,
    [BlockField("유지증거금율", 7.3)] double MntncMgnR,
    [BlockField("유효소수점자리수", 2)] int DotGb,
    [BlockField("옵션행사가", 15)] string XrcPrc,
    [BlockField("기초자산기준가격", 15)] string FdasBasePrc,
    [BlockField("옵션콜풋구분", 1)] string OptTpCode,
    [BlockField("권리행사구분코드", 1)] string RgtXrcPtnCode,
    [BlockField("ATM구분", 1)] string Moneyness,
    [BlockField("해외파생기초자산종목코드", 30)] string LastSettPtnCode,
    [BlockField("해외옵션최소호가", 15)] string OptMinOrcPrc,
    [BlockField("해외옵션최소기준호가", 15)] string OptMinBaseOrcPrc
    );


/// <summary>
/// 해외선물옵션차트(분)-API용: o3123
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">N분주기	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3123InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("N분주기", 4)] int ncnt,
    [BlockField("조회건수", 4)] int readcnt,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 6)] string cts_time
    );

/// <summary>
/// 해외선물옵션차트(분)-API용: o3123
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="timediff">시차	int	4</param>
/// <param name="readcnt">조회건수	int	4</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="cts_time">연속시간	string	6</param>
public record o3123OutBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("시차", 4)] int timediff,
    [BlockField("조회건수", 4)] int readcnt,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 6)] string cts_time
    );

/// <summary>
/// 해외선물옵션차트(분)-API용: o3123
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">현지시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3123OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("현지시간", 6)] string time,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물옵션현재가(종목정보)조회-API용: o3125
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">종목코드	string	16</param>
public record o3125InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("종목코드", 16)] string symbol
    );

/// <summary>
/// 해외선물옵션현재가(종목정보)조회-API용: o3125
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
public record o3125OutBlock(
    [BlockField("종목코드", 16)] string Symbol,
    [BlockField("종목명", 50)] string SymbolNm,
    [BlockField("종목배치수신일", 8)] string ApplDate,
    [BlockField("기초상품코드", 10)] string BscGdsCd,
    [BlockField("기초상품명", 40)] string BscGdsNm,
    [BlockField("거래소코드", 10)] string ExchCd,
    [BlockField("거래소명", 40)] string ExchNm,
    [BlockField("정산구분코드", 1)] string EcCd,
    [BlockField("기준통화코드", 3)] string CrncyCd,
    [BlockField("진법구분코드", 3)] string NotaCd,
    [BlockField("호가단위가격", 15.9)] double UntPrc,
    [BlockField("최소가격변동금액", 15.9)] double MnChgAmt,
    [BlockField("가격조정계수", 15.1)] double RgltFctr,
    [BlockField("계약당금액", 15.2)] double CtrtPrAmt,
    [BlockField("상장개월수", 2)] int LstngMCnt,
    [BlockField("상품구분코드", 3)] string GdsCd,
    [BlockField("시장구분코드", 3)] string MrktCd,
    [BlockField("Emini구분코드", 1)] string EminiCd,
    [BlockField("상장년", 4)] string LstngYr,
    [BlockField("상장월", 1)] string LstngM,
    [BlockField("월물순서", 5)] int SeqNo,
    [BlockField("상장일자", 8)] string LstngDt,
    [BlockField("최종거래가능일", 8)] string MtrtDt,
    [BlockField("최종거래일", 8)] string FnlDlDt,
    [BlockField("최초인도통지일자", 8)] string FstTrsfrDt,
    [BlockField("정산가격", 15.9)] double EcPrc,
    [BlockField("거래시작일자(한국)", 8)] string DlDt,
    [BlockField("거래시작시간(한국)", 6)] string DlStrtTm,
    [BlockField("거래종료시간(한국)", 6)] string DlEndTm,
    [BlockField("거래시작일자(현지)", 8)] string OvsStrDay,
    [BlockField("거래시작시간(현지)", 6)] string OvsStrTm,
    [BlockField("거래종료일자(현지)", 8)] string OvsEndDay,
    [BlockField("거래종료시간(현지)", 6)] string OvsEndTm,
    [BlockField("거래가능구분코드", 1)] string DlPsblCd,
    [BlockField("증거금징수구분코드", 1)] string MgnCltCd,
    [BlockField("개시증거금", 15.2)] double OpngMgn,
    [BlockField("유지증거금", 15.2)] double MntncMgn,
    [BlockField("개시증거금율", 7.3)] double OpngMgnR,
    [BlockField("유지증거금율", 7.3)] double MntncMgnR,
    [BlockField("유효소수점자리수", 2)] int DotGb,
    [BlockField("시차", 5)] int TimeDiff,
    [BlockField("현지체결일자", 8)] string OvsDate,
    [BlockField("한국체결일자", 8)] string KorDate,
    [BlockField("현지체결시간", 6)] string TrdTm,
    [BlockField("한국체결시각", 6)] string RcvTm,
    [BlockField("체결가격", 15.9)] double TrdP,
    [BlockField("체결수량", 10)] long TrdQ,
    [BlockField("누적거래량", 15)] long TotQ,
    [BlockField("체결거래대금", 15.2)] double TrdAmt,
    [BlockField("누적거래대금", 15.2)] double TotAmt,
    [BlockField("시가", 15.9)] double OpenP,
    [BlockField("고가", 15.9)] double HighP,
    [BlockField("저가", 15.9)] double LowP,
    [BlockField("전일종가", 15.9)] double CloseP,
    [BlockField("전일대비", 15.9)] double YdiffP,
    [BlockField("전일대비구분", 1)] string YdiffSign,
    [BlockField("체결구분", 1)] string Cgubun,
    [BlockField("등락율", 6.2)] double Diff,
    [BlockField("최소호가", 15.9)] double MinOrcPrc,
    [BlockField("최소기준호가", 15.9)] double MinBaseOrcPrc
    );


/// <summary>
/// 해외선물옵션현재가호가조회-API용: o3126
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">단축코드	string	16</param>
public record o3126InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string symbol
    );

/// <summary>
/// 해외선물옵션현재가호가조회-API용: o3126
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
public record o3126OutBlock(
    [BlockField("종목코드", 16)] string symbol,
    [BlockField("종목명", 50)] string symbolname,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("전일종가", 15.9)] double jnilclose,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("호가수신시간", 6)] string hotime,
    [BlockField("매도호가1", 15.9)] double offerho1,
    [BlockField("매수호가1", 15.9)] double bidho1,
    [BlockField("매도호가건수1", 10)] long offercnt1,
    [BlockField("매수호가건수1", 10)] long bidcnt1,
    [BlockField("매도호가수량1", 10)] long offerrem1,
    [BlockField("매수호가수량1", 10)] long bidrem1,
    [BlockField("매도호가2", 15.9)] double offerho2,
    [BlockField("매수호가2", 15.9)] double bidho2,
    [BlockField("매도호가건수2", 10)] long offercnt2,
    [BlockField("매수호가건수2", 10)] long bidcnt2,
    [BlockField("매도호가수량2", 10)] long offerrem2,
    [BlockField("매수호가수량2", 10)] long bidrem2,
    [BlockField("매도호가3", 15.9)] double offerho3,
    [BlockField("매수호가3", 15.9)] double bidho3,
    [BlockField("매도호가건수3", 10)] long offercnt3,
    [BlockField("매수호가건수3", 10)] long bidcnt3,
    [BlockField("매도호가수량3", 10)] long offerrem3,
    [BlockField("매수호가수량3", 10)] long bidrem3,
    [BlockField("매도호가4", 15.9)] double offerho4,
    [BlockField("매수호가4", 15.9)] double bidho4,
    [BlockField("매도호가건수4", 10)] long offercnt4,
    [BlockField("매수호가건수4", 10)] long bidcnt4,
    [BlockField("매도호가수량4", 10)] long offerrem4,
    [BlockField("매수호가수량4", 10)] long bidrem4,
    [BlockField("매도호가5", 15.9)] double offerho5,
    [BlockField("매수호가5", 15.9)] double bidho5,
    [BlockField("매도호가건수5", 10)] long offercnt5,
    [BlockField("매수호가건수5", 10)] long bidcnt5,
    [BlockField("매도호가수량5", 10)] long offerrem5,
    [BlockField("매수호가수량5", 10)] long bidrem5,
    [BlockField("매도호가건수합", 10)] long offercnt,
    [BlockField("매수호가건수합", 10)] long bidcnt,
    [BlockField("매도호가수량합", 10)] long offer,
    [BlockField("매수호가수량합", 10)] long bid
    );


/// <summary>
/// 해외선물옵션관심종목조회-API용: o3127
/// </summary>
/// <param name="nrec">건수	int	4</param>
public record o3127InBlock(
    [BlockField("건수", 4)] int nrec
    );

/// <summary>
/// 해외선물옵션관심종목조회-API용: o3127
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="symbol">종목심볼	string	16</param>
public record o3127InBlock1(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("종목심볼", 16)] string symbol
    );

/// <summary>
/// 해외선물옵션관심종목조회-API용: o3127
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
public record o3127OutBlock(
    [BlockField("종목코드", 16)] string symbol,
    [BlockField("종목명", 50)] string symbolname,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 10)] long volume,
    [BlockField("전일종가", 15.9)] double jnilclose,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("매도호가1", 15.9)] double offerho1,
    [BlockField("매수호가1", 15.9)] double bidho1,
    [BlockField("매도호가건수1", 10)] long offercnt1,
    [BlockField("매수호가건수1", 10)] long bidcnt1,
    [BlockField("매도호가수량1", 10)] long offerrem1,
    [BlockField("매수호가수량1", 10)] long bidrem1,
    [BlockField("매도호가건수합", 10)] long offercnt,
    [BlockField("매수호가건수합", 10)] long bidcnt,
    [BlockField("매도호가수량합", 10)] long offer,
    [BlockField("매수호가수량합", 10)] long bid
    );


/// <summary>
/// 해외선물옵션차트일주월-API용: o3128
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="gubun">주기구분	string	1</param>
/// <param name="qrycnt">요청건수	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
public record o3128InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("주기구분", 1)] string gubun,
    [BlockField("요청건수", 4)] int qrycnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date
    );

/// <summary>
/// 해외선물옵션차트일주월-API용: o3128
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
public record o3128OutBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("전일시가", 15.9)] double jisiga,
    [BlockField("전일고가", 15.9)] double jihigh,
    [BlockField("전일저가", 15.9)] double jilow,
    [BlockField("전일종가", 15.9)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 15.9)] double disiga,
    [BlockField("당일고가", 15.9)] double dihigh,
    [BlockField("당일저가", 15.9)] double dilow,
    [BlockField("당일종가", 15.9)] double diclose,
    [BlockField("장시작시간", 6)] string mk_stime,
    [BlockField("장마감시간", 6)] string mk_etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 해외선물옵션차트일주월-API용: o3128
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3128OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물옵션시간대별(Tick)체결-API용: o3136
/// </summary>
/// <param name="gubun">조회구분(0:당일1:전일)	string	1</param>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="readcnt">조회갯수	int	4</param>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3136InBlock(
    [BlockField("조회구분(0:당일1:전일)", 1)] string gubun,
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("조회갯수", 4)] int readcnt,
    [BlockField("순번CTS", 8)] int cts_seq
    );

/// <summary>
/// 해외선물옵션시간대별(Tick)체결-API용: o3136
/// </summary>
/// <param name="cts_seq">순번CTS	int	8</param>
public record o3136OutBlock(
    [BlockField("순번CTS", 8)] int cts_seq
    );

/// <summary>
/// 해외선물옵션시간대별(Tick)체결-API용: o3136
/// </summary>
/// <param name="ovsdate">현지일자	string	8</param>
/// <param name="ovstime">현지시간	string	6</param>
/// <param name="price">현재가	double	15.9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	15.9</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	long	10</param>
/// <param name="volume">누적거래량	long	10</param>
public record o3136OutBlock1(
    [BlockField("현지일자", 8)] string ovsdate,
    [BlockField("현지시간", 6)] string ovstime,
    [BlockField("현재가", 15.9)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 15.9)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 10)] long cvolume,
    [BlockField("누적거래량", 10)] long volume
    );


/// <summary>
/// 해외선물옵션차트용NTick-API용: o3137
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3137InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("단위", 4)] int ncnt,
    [BlockField("건수", 4)] int qrycnt,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb
    );

/// <summary>
/// 해외선물옵션차트용NTick-API용: o3137
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3137OutBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("레코드카운트", 7)] int rec_count,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb
    );

/// <summary>
/// 해외선물옵션차트용NTick-API용: o3137
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.9</param>
/// <param name="high">고가	double	15.9</param>
/// <param name="low">저가	double	15.9</param>
/// <param name="close">종가	double	15.9</param>
/// <param name="volume">거래량	long	12</param>
public record o3137OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 15.9)] double open,
    [BlockField("고가", 15.9)] double high,
    [BlockField("저가", 15.9)] double low,
    [BlockField("종가", 15.9)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 해외선물옵션차트용NTick(고정형)-API용: o3139
/// </summary>
/// <param name="mktgb">시장구분	string	1</param>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="ncnt">단위	int	4</param>
/// <param name="qrycnt">건수	int	4</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
public record o3139InBlock(
    [BlockField("시장구분", 1)] string mktgb,
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("단위", 4)] int ncnt,
    [BlockField("건수", 4)] int qrycnt,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb
    );

/// <summary>
/// 해외선물옵션차트용NTick(고정형)-API용: o3139
/// </summary>
/// <param name="shcode">단축코드	string	16</param>
/// <param name="rec_count">레코드카운트	int	7</param>
/// <param name="cts_seq">연속시간	string	10</param>
/// <param name="cts_daygb">연속당일구분	string	2</param>
/// <param name="last_count">마지막Tick건수	int	4</param>
public record o3139OutBlock(
    [BlockField("단축코드", 16)] string shcode,
    [BlockField("레코드카운트", 7)] int rec_count,
    [BlockField("연속시간", 10)] string cts_seq,
    [BlockField("연속당일구분", 2)] string cts_daygb,
    [BlockField("마지막Tick건수", 4)] int last_count
    );

/// <summary>
/// 해외선물옵션차트용NTick(고정형)-API용: o3139
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	15.8</param>
/// <param name="high">고가	double	15.8</param>
/// <param name="low">저가	double	15.8</param>
/// <param name="close">종가	double	15.8</param>
/// <param name="volume">거래량	long	12</param>
public record o3139OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 15.8)] double open,
    [BlockField("고가", 15.8)] double high,
    [BlockField("저가", 15.8)] double low,
    [BlockField("종가", 15.8)] double close,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 주식당일매매일지/수수료: t0150
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0150InBlock(
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("CTS_매매구분", 1)] string cts_medosu,
    [BlockField("CTS_종목번호", 12)] string cts_expcode,
    [BlockField("CTS_단가", 9)] string cts_price,
    [BlockField("CTS_매체", 2)] string cts_middiv
    );

/// <summary>
/// 주식당일매매일지/수수료: t0150
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
public record t0150OutBlock(
    [BlockField("매도수량", 9)] long mdqty,
    [BlockField("매도약정금액", 18)] long mdamt,
    [BlockField("매도수수료", 18)] long mdfee,
    [BlockField("매도거래세", 18)] long mdtax,
    [BlockField("매도농특세", 18)] long mdargtax,
    [BlockField("매도제비용합", 18)] long tmdtax,
    [BlockField("매도정산금액", 18)] long mdadjamt,
    [BlockField("매수수량", 9)] long msqty,
    [BlockField("매수약정금액", 18)] long msamt,
    [BlockField("매수수수료", 18)] long msfee,
    [BlockField("매수제비용합", 18)] long tmstax,
    [BlockField("매수정산금액", 18)] long msadjamt,
    [BlockField("합계수량", 9)] long tqty,
    [BlockField("합계약정금액", 18)] long tamt,
    [BlockField("합계수수료", 18)] long tfee,
    [BlockField("합계거래세", 18)] long tottax,
    [BlockField("합계농특세", 18)] long targtax,
    [BlockField("합계제비용합", 18)] long ttax,
    [BlockField("합계정산금액", 18)] long tadjamt,
    [BlockField("CTS_매매구분", 1)] string cts_medosu,
    [BlockField("CTS_종목번호", 12)] string cts_expcode,
    [BlockField("CTS_단가", 9)] string cts_price,
    [BlockField("CTS_매체", 2)] string cts_middiv
    );

/// <summary>
/// 주식당일매매일지/수수료: t0150
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
public record t0150OutBlock1(
    [BlockField("매매구분", 10)] string medosu,
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("수량", 9)] long qty,
    [BlockField("단가", 9)] long price,
    [BlockField("약정금액", 18)] long amt,
    [BlockField("수수료", 18)] long fee,
    [BlockField("거래세", 18)] long tax,
    [BlockField("농특세", 18)] long argtax,
    [BlockField("정산금액", 18)] long adjamt,
    [BlockField("매체", 20)] string middiv
    );


/// <summary>
/// 주식당일매매일지/수수료(전일): t0151
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="cts_medosu">CTS_매매구분	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	12</param>
/// <param name="cts_price">CTS_단가	string	9</param>
/// <param name="cts_middiv">CTS_매체	string	2</param>
public record t0151InBlock(
    [BlockField("일자", 8)] string date,
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("CTS_매매구분", 1)] string cts_medosu,
    [BlockField("CTS_종목번호", 12)] string cts_expcode,
    [BlockField("CTS_단가", 9)] string cts_price,
    [BlockField("CTS_매체", 2)] string cts_middiv
    );

/// <summary>
/// 주식당일매매일지/수수료(전일): t0151
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
public record t0151OutBlock(
    [BlockField("매도수량", 9)] long mdqty,
    [BlockField("매도약정금액", 18)] long mdamt,
    [BlockField("매도수수료", 18)] long mdfee,
    [BlockField("매도거래세", 18)] long mdtax,
    [BlockField("매도농특세", 18)] long mdargtax,
    [BlockField("매도제비용합", 18)] long tmdtax,
    [BlockField("매도정산금액", 18)] long mdadjamt,
    [BlockField("매수수량", 9)] long msqty,
    [BlockField("매수약정금액", 18)] long msamt,
    [BlockField("매수수수료", 18)] long msfee,
    [BlockField("매수제비용합", 18)] long tmstax,
    [BlockField("매수정산금액", 18)] long msadjamt,
    [BlockField("합계수량", 9)] long tqty,
    [BlockField("합계약정금액", 18)] long tamt,
    [BlockField("합계수수료", 18)] long tfee,
    [BlockField("합계거래세", 18)] long tottax,
    [BlockField("합계농특세", 18)] long targtax,
    [BlockField("합계제비용합", 18)] long ttax,
    [BlockField("합계정산금액", 18)] long tadjamt,
    [BlockField("CTS_매매구분", 1)] string cts_medosu,
    [BlockField("CTS_종목번호", 12)] string cts_expcode,
    [BlockField("CTS_단가", 9)] string cts_price,
    [BlockField("CTS_매체", 2)] string cts_middiv
    );

/// <summary>
/// 주식당일매매일지/수수료(전일): t0151
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
public record t0151OutBlock1(
    [BlockField("매매구분", 10)] string medosu,
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("수량", 9)] long qty,
    [BlockField("단가", 9)] long price,
    [BlockField("약정금액", 18)] long amt,
    [BlockField("수수료", 18)] long fee,
    [BlockField("거래세", 18)] long tax,
    [BlockField("농특세", 18)] long argtax,
    [BlockField("정산금액", 18)] long adjamt,
    [BlockField("매체", 20)] string middiv
    );


/// <summary>
/// 서버시간조회: t0167
/// </summary>
/// <param name="id">id	string	8</param>
public record t0167InBlock(
    [BlockField("id", 8)] string id
    );

/// <summary>
/// 서버시간조회: t0167
/// </summary>
/// <param name="dt">일자(YYYYMMDD)	string	8</param>
/// <param name="time">시간(HHMMSSssssss)	string	12</param>
public record t0167OutBlock(
    [BlockField("일자(YYYYMMDD)", 8)] string dt,
    [BlockField("시간(HHMMSSssssss)", 12)] string time
    );


/// <summary>
/// 주식잔고2: t0424
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="prcgb">단가구분	string	1</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="dangb">단일가구분	string	1</param>
/// <param name="charge">제비용포함여부	string	1</param>
/// <param name="cts_expcode">CTS_종목번호	string	22</param>
public record t0424InBlock(
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("비밀번호", 8)] string passwd,
    [BlockField("단가구분", 1)] string prcgb,
    [BlockField("체결구분", 1)] string chegb,
    [BlockField("단일가구분", 1)] string dangb,
    [BlockField("제비용포함여부", 1)] string charge,
    [BlockField("CTS_종목번호", 22)] string cts_expcode
    );

/// <summary>
/// 주식잔고2: t0424
/// </summary>
/// <param name="sunamt">추정순자산	long	18</param>
/// <param name="dtsunik">실현손익	long	18</param>
/// <param name="mamt">매입금액	long	18</param>
/// <param name="sunamt1">추정D2예수금	long	18</param>
/// <param name="cts_expcode">CTS_종목번호	string	22</param>
/// <param name="tappamt">평가금액	long	18</param>
/// <param name="tdtsunik">평가손익	long	18</param>
public record t0424OutBlock(
    [BlockField("추정순자산", 18)] long sunamt,
    [BlockField("실현손익", 18)] long dtsunik,
    [BlockField("매입금액", 18)] long mamt,
    [BlockField("추정D2예수금", 18)] long sunamt1,
    [BlockField("CTS_종목번호", 22)] string cts_expcode,
    [BlockField("평가금액", 18)] long tappamt,
    [BlockField("평가손익", 18)] long tdtsunik
    );

/// <summary>
/// 주식잔고2: t0424
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
public record t0424OutBlock1(
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("잔고구분", 10)] string jangb,
    [BlockField("잔고수량", 18)] long janqty,
    [BlockField("매도가능수량", 18)] long mdposqt,
    [BlockField("평균단가", 18)] long pamt,
    [BlockField("매입금액", 18)] long mamt,
    [BlockField("대출금액", 18)] long sinamt,
    [BlockField("만기일자", 8)] string lastdt,
    [BlockField("당일매수금액", 18)] long msat,
    [BlockField("당일매수단가", 18)] long mpms,
    [BlockField("당일매도금액", 18)] long mdat,
    [BlockField("당일매도단가", 18)] long mpmd,
    [BlockField("전일매수금액", 18)] long jsat,
    [BlockField("전일매수단가", 18)] long jpms,
    [BlockField("전일매도금액", 18)] long jdat,
    [BlockField("전일매도단가", 18)] long jpmd,
    [BlockField("처리순번", 10)] long sysprocseq,
    [BlockField("대출일자", 8)] string loandt,
    [BlockField("종목명", 20)] string hname,
    [BlockField("시장구분", 1)] string marketgb,
    [BlockField("종목구분", 1)] string jonggb,
    [BlockField("보유비중", 10.2)] double janrt,
    [BlockField("현재가", 8)] int price,
    [BlockField("평가금액", 18)] long appamt,
    [BlockField("평가손익", 18)] long dtsunik,
    [BlockField("수익율", 10.2)] double sunikrt,
    [BlockField("수수료", 10)] long fee,
    [BlockField("제세금", 10)] long tax,
    [BlockField("신용이자", 10)] long sininter
    );


/// <summary>
/// 주식체결/미체결: t0425
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="expcode">종목번호	string	12</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="medosu">매매구분	string	1</param>
/// <param name="sortgb">정렬순서	string	1</param>
/// <param name="cts_ordno">주문번호	string	10</param>
public record t0425InBlock(
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("비밀번호", 8)] string passwd,
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("체결구분", 1)] string chegb,
    [BlockField("매매구분", 1)] string medosu,
    [BlockField("정렬순서", 1)] string sortgb,
    [BlockField("주문번호", 10)] string cts_ordno
    );

/// <summary>
/// 주식체결/미체결: t0425
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
public record t0425OutBlock(
    [BlockField("총주문수량", 18)] long tqty,
    [BlockField("총체결수량", 18)] long tcheqty,
    [BlockField("총미체결수량", 18)] long tordrem,
    [BlockField("추정수수료", 18)] long cmss,
    [BlockField("총주문금액", 18)] long tamt,
    [BlockField("총매도체결금액", 18)] long tmdamt,
    [BlockField("총매수체결금액", 18)] long tmsamt,
    [BlockField("추정제세금", 18)] long tax,
    [BlockField("주문번호", 10)] string cts_ordno
    );

/// <summary>
/// 주식체결/미체결: t0425
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
public record t0425OutBlock1(
    [BlockField("주문번호", 10)] long ordno,
    [BlockField("종목번호", 12)] string expcode,
    [BlockField("구분", 10)] string medosu,
    [BlockField("주문수량", 9)] long qty,
    [BlockField("주문가격", 9)] long price,
    [BlockField("체결수량", 9)] long cheqty,
    [BlockField("체결가격", 9)] long cheprice,
    [BlockField("미체결잔량", 9)] long ordrem,
    [BlockField("확인수량", 9)] long cfmqty,
    [BlockField("상태", 10)] string status,
    [BlockField("원주문번호", 10)] long orgordno,
    [BlockField("유형", 20)] string ordgb,
    [BlockField("주문시간", 8)] string ordtime,
    [BlockField("주문매체", 10)] string ordermtd,
    [BlockField("처리순번", 10)] long sysprocseq,
    [BlockField("호가유형", 2)] string hogagb,
    [BlockField("현재가", 8)] int price1,
    [BlockField("주문구분", 2)] string orggb,
    [BlockField("신용구분", 2)] string singb,
    [BlockField("대출일자", 8)] string loandt
    );


/// <summary>
/// 선물/옵션체결/미체결: t0434
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="expcode">종목번호	string	8</param>
/// <param name="chegb">체결구분	string	1</param>
/// <param name="sortgb">정렬순서	string	1</param>
/// <param name="cts_ordno">CTS_주문번호	string	7</param>
public record t0434InBlock(
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("비밀번호", 8)] string passwd,
    [BlockField("종목번호", 8)] string expcode,
    [BlockField("체결구분", 1)] string chegb,
    [BlockField("정렬순서", 1)] string sortgb,
    [BlockField("CTS_주문번호", 7)] string cts_ordno
    );

/// <summary>
/// 선물/옵션체결/미체결: t0434
/// </summary>
/// <param name="cts_ordno">CTS_주문번호	string	7</param>
public record t0434OutBlock(
    [BlockField("CTS_주문번호", 7)] string cts_ordno
    );

/// <summary>
/// 선물/옵션체결/미체결: t0434
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
public record t0434OutBlock1(
    [BlockField("주문번호", 7)] int ordno,
    [BlockField("원주문번호", 7)] int orgordno,
    [BlockField("구분", 10)] string medosu,
    [BlockField("유형", 20)] string ordgb,
    [BlockField("주문수량", 9)] long qty,
    [BlockField("주문가격", 9.2)] double price,
    [BlockField("체결수량", 9)] long cheqty,
    [BlockField("체결가격", 9.2)] double cheprice,
    [BlockField("미체결잔량", 9)] long ordrem,
    [BlockField("상태", 10)] string status,
    [BlockField("주문시간", 8)] string ordtime,
    [BlockField("주문매체", 10)] string ordermtd,
    [BlockField("종목번호", 8)] string expcode,
    [BlockField("사유코드", 3)] string rtcode,
    [BlockField("처리순번", 10)] long sysprocseq,
    [BlockField("호가타입", 1)] string hogatype
    );


/// <summary>
/// 선물/옵션잔고평가(이동평균): t0441
/// </summary>
/// <param name="accno">계좌번호	string	11</param>
/// <param name="passwd">비밀번호	string	8</param>
/// <param name="cts_expcode">CTS_종목번호	string	8</param>
/// <param name="cts_medocd">CTS_매매구분	string	1</param>
public record t0441InBlock(
    [BlockField("계좌번호", 11)] string accno,
    [BlockField("비밀번호", 8)] string passwd,
    [BlockField("CTS_종목번호", 8)] string cts_expcode,
    [BlockField("CTS_매매구분", 1)] string cts_medocd
    );

/// <summary>
/// 선물/옵션잔고평가(이동평균): t0441
/// </summary>
/// <param name="tdtsunik">매매손익합계	long	18</param>
/// <param name="cts_expcode">CTS_종목번호	string	8</param>
/// <param name="cts_medocd">CTS_매매구분	string	1</param>
/// <param name="tappamt">평가금액	long	18</param>
/// <param name="tsunik">평가손익	long	18</param>
public record t0441OutBlock(
    [BlockField("매매손익합계", 18)] long tdtsunik,
    [BlockField("CTS_종목번호", 8)] string cts_expcode,
    [BlockField("CTS_매매구분", 1)] string cts_medocd,
    [BlockField("평가금액", 18)] long tappamt,
    [BlockField("평가손익", 18)] long tsunik
    );

/// <summary>
/// 선물/옵션잔고평가(이동평균): t0441
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
public record t0441OutBlock1(
    [BlockField("종목번호", 8)] string expcode,
    [BlockField("구분", 4)] string medosu,
    [BlockField("잔고수량", 10)] long jqty,
    [BlockField("청산가능수량", 10)] long cqty,
    [BlockField("평균단가", 10.2)] double pamt,
    [BlockField("총매입금액", 18)] long mamt,
    [BlockField("매매구분", 1)] string medocd,
    [BlockField("매매손익", 18)] long dtsunik,
    [BlockField("처리순번", 10)] long sysprocseq,
    [BlockField("현재가", 9.2)] double price,
    [BlockField("평가금액", 18)] long appamt,
    [BlockField("평가손익", 18)] long dtsunik1,
    [BlockField("수익율", 10.2)] double sunikrt
    );


/// <summary>
/// 주식현재가호가조회: t1101
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1101InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// 주식현재가호가조회: t1101
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
public record t1101OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("매도호가1", 8)] int offerho1,
    [BlockField("매수호가1", 8)] int bidho1,
    [BlockField("매도호가수량1", 12)] long offerrem1,
    [BlockField("매수호가수량1", 12)] long bidrem1,
    [BlockField("직전매도대비수량1", 12)] long preoffercha1,
    [BlockField("직전매수대비수량1", 12)] long prebidcha1,
    [BlockField("매도호가2", 8)] int offerho2,
    [BlockField("매수호가2", 8)] int bidho2,
    [BlockField("매도호가수량2", 12)] long offerrem2,
    [BlockField("매수호가수량2", 12)] long bidrem2,
    [BlockField("직전매도대비수량2", 12)] long preoffercha2,
    [BlockField("직전매수대비수량2", 12)] long prebidcha2,
    [BlockField("매도호가3", 8)] int offerho3,
    [BlockField("매수호가3", 8)] int bidho3,
    [BlockField("매도호가수량3", 12)] long offerrem3,
    [BlockField("매수호가수량3", 12)] long bidrem3,
    [BlockField("직전매도대비수량3", 12)] long preoffercha3,
    [BlockField("직전매수대비수량3", 12)] long prebidcha3,
    [BlockField("매도호가4", 8)] int offerho4,
    [BlockField("매수호가4", 8)] int bidho4,
    [BlockField("매도호가수량4", 12)] long offerrem4,
    [BlockField("매수호가수량4", 12)] long bidrem4,
    [BlockField("직전매도대비수량4", 12)] long preoffercha4,
    [BlockField("직전매수대비수량4", 12)] long prebidcha4,
    [BlockField("매도호가5", 8)] int offerho5,
    [BlockField("매수호가5", 8)] int bidho5,
    [BlockField("매도호가수량5", 12)] long offerrem5,
    [BlockField("매수호가수량5", 12)] long bidrem5,
    [BlockField("직전매도대비수량5", 12)] long preoffercha5,
    [BlockField("직전매수대비수량5", 12)] long prebidcha5,
    [BlockField("매도호가6", 8)] int offerho6,
    [BlockField("매수호가6", 8)] int bidho6,
    [BlockField("매도호가수량6", 12)] long offerrem6,
    [BlockField("매수호가수량6", 12)] long bidrem6,
    [BlockField("직전매도대비수량6", 12)] long preoffercha6,
    [BlockField("직전매수대비수량6", 12)] long prebidcha6,
    [BlockField("매도호가7", 8)] int offerho7,
    [BlockField("매수호가7", 8)] int bidho7,
    [BlockField("매도호가수량7", 12)] long offerrem7,
    [BlockField("매수호가수량7", 12)] long bidrem7,
    [BlockField("직전매도대비수량7", 12)] long preoffercha7,
    [BlockField("직전매수대비수량7", 12)] long prebidcha7,
    [BlockField("매도호가8", 8)] int offerho8,
    [BlockField("매수호가8", 8)] int bidho8,
    [BlockField("매도호가수량8", 12)] long offerrem8,
    [BlockField("매수호가수량8", 12)] long bidrem8,
    [BlockField("직전매도대비수량8", 12)] long preoffercha8,
    [BlockField("직전매수대비수량8", 12)] long prebidcha8,
    [BlockField("매도호가9", 8)] int offerho9,
    [BlockField("매수호가9", 8)] int bidho9,
    [BlockField("매도호가수량9", 12)] long offerrem9,
    [BlockField("매수호가수량9", 12)] long bidrem9,
    [BlockField("직전매도대비수량9", 12)] long preoffercha9,
    [BlockField("직전매수대비수량9", 12)] long prebidcha9,
    [BlockField("매도호가10", 8)] int offerho10,
    [BlockField("매수호가10", 8)] int bidho10,
    [BlockField("매도호가수량10", 12)] long offerrem10,
    [BlockField("매수호가수량10", 12)] long bidrem10,
    [BlockField("직전매도대비수량10", 12)] long preoffercha10,
    [BlockField("직전매수대비수량10", 12)] long prebidcha10,
    [BlockField("매도호가수량합", 12)] long offer,
    [BlockField("매수호가수량합", 12)] long bid,
    [BlockField("직전매도대비수량합", 12)] long preoffercha,
    [BlockField("직전매수대비수량합", 12)] long prebidcha,
    [BlockField("수신시간", 8)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] long yevolume,
    [BlockField("예상체결전일구분", 1)] string yesign,
    [BlockField("예상체결전일대비", 8)] int yechange,
    [BlockField("예상체결등락율", 6.2)] double yediff,
    [BlockField("시간외매도잔량", 12)] long tmoffer,
    [BlockField("시간외매수잔량", 12)] long tmbid,
    [BlockField("동시구분", 1)] string ho_status,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low
    );


/// <summary>
/// 주식현재가(시세)조회: t1102
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1102InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// 주식현재가(시세)조회: t1102
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
public record t1102OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("기준가(평가가격)", 8)] int recprice,
    [BlockField("가중평균", 8)] int avg,
    [BlockField("상한가(최고호가가격)", 8)] int uplmtprice,
    [BlockField("하한가(최저호가가격)", 8)] int dnlmtprice,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("거래량차", 12)] long volumediff,
    [BlockField("시가", 8)] int open,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가", 8)] int high,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가", 8)] int low,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("52최고가", 8)] int high52w,
    [BlockField("52최고가일", 8)] string high52wdate,
    [BlockField("52최저가", 8)] int low52w,
    [BlockField("52최저가일", 8)] string low52wdate,
    [BlockField("소진율", 6.2)] double exhratio,
    [BlockField("PER", 6.2)] double per,
    [BlockField("PBRX", 6.2)] double pbrx,
    [BlockField("상장주식수(천)", 12)] long listing,
    [BlockField("증거금율", 8)] int jkrate,
    [BlockField("수량단위", 5)] string memedan,
    [BlockField("매도증권사코드1", 3)] string offernocd1,
    [BlockField("매수증권사코드1", 3)] string bidnocd1,
    [BlockField("매도증권사명1", 6)] string offerno1,
    [BlockField("매수증권사명1", 6)] string bidno1,
    [BlockField("총매도수량1", 8)] int dvol1,
    [BlockField("총매수수량1", 8)] int svol1,
    [BlockField("매도증감1", 8)] int dcha1,
    [BlockField("매수증감1", 8)] int scha1,
    [BlockField("매도비율1", 6.2)] double ddiff1,
    [BlockField("매수비율1", 6.2)] double sdiff1,
    [BlockField("매도증권사코드2", 3)] string offernocd2,
    [BlockField("매수증권사코드2", 3)] string bidnocd2,
    [BlockField("매도증권사명2", 6)] string offerno2,
    [BlockField("매수증권사명2", 6)] string bidno2,
    [BlockField("총매도수량2", 8)] int dvol2,
    [BlockField("총매수수량2", 8)] int svol2,
    [BlockField("매도증감2", 8)] int dcha2,
    [BlockField("매수증감2", 8)] int scha2,
    [BlockField("매도비율2", 6.2)] double ddiff2,
    [BlockField("매수비율2", 6.2)] double sdiff2,
    [BlockField("매도증권사코드3", 3)] string offernocd3,
    [BlockField("매수증권사코드3", 3)] string bidnocd3,
    [BlockField("매도증권사명3", 6)] string offerno3,
    [BlockField("매수증권사명3", 6)] string bidno3,
    [BlockField("총매도수량3", 8)] int dvol3,
    [BlockField("총매수수량3", 8)] int svol3,
    [BlockField("매도증감3", 8)] int dcha3,
    [BlockField("매수증감3", 8)] int scha3,
    [BlockField("매도비율3", 6.2)] double ddiff3,
    [BlockField("매수비율3", 6.2)] double sdiff3,
    [BlockField("매도증권사코드4", 3)] string offernocd4,
    [BlockField("매수증권사코드4", 3)] string bidnocd4,
    [BlockField("매도증권사명4", 6)] string offerno4,
    [BlockField("매수증권사명4", 6)] string bidno4,
    [BlockField("총매도수량4", 8)] int dvol4,
    [BlockField("총매수수량4", 8)] int svol4,
    [BlockField("매도증감4", 8)] int dcha4,
    [BlockField("매수증감4", 8)] int scha4,
    [BlockField("매도비율4", 6.2)] double ddiff4,
    [BlockField("매수비율4", 6.2)] double sdiff4,
    [BlockField("매도증권사코드5", 3)] string offernocd5,
    [BlockField("매수증권사코드5", 3)] string bidnocd5,
    [BlockField("매도증권사명5", 6)] string offerno5,
    [BlockField("매수증권사명5", 6)] string bidno5,
    [BlockField("총매도수량5", 8)] int dvol5,
    [BlockField("총매수수량5", 8)] int svol5,
    [BlockField("매도증감5", 8)] int dcha5,
    [BlockField("매수증감5", 8)] int scha5,
    [BlockField("매도비율5", 6.2)] double ddiff5,
    [BlockField("매수비율5", 6.2)] double sdiff5,
    [BlockField("외국계매도합계수량", 12)] long fwdvl,
    [BlockField("외국계매도직전대비", 12)] long ftradmdcha,
    [BlockField("외국계매도비율", 6.2)] double ftradmddiff,
    [BlockField("외국계매수합계수량", 12)] long fwsvl,
    [BlockField("외국계매수직전대비", 12)] long ftradmscha,
    [BlockField("외국계매수비율", 6.2)] double ftradmsdiff,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("전일동시간거래량", 12)] long jvolume,
    [BlockField("연중최고가", 8)] int highyear,
    [BlockField("연중최고일자", 8)] string highyeardate,
    [BlockField("연중최저가", 8)] int lowyear,
    [BlockField("연중최저일자", 8)] string lowyeardate,
    [BlockField("목표가", 8)] int target,
    [BlockField("자본금", 12)] long capital,
    [BlockField("유동주식수", 12)] long abscnt,
    [BlockField("액면가", 8)] int parprice,
    [BlockField("결산월", 2)] string gsmm,
    [BlockField("대용가", 8)] int subprice,
    [BlockField("시가총액", 12)] long total,
    [BlockField("상장일", 8)] string listdate,
    [BlockField("전분기명", 10)] string name,
    [BlockField("전분기매출액", 12)] long bfsales,
    [BlockField("전분기영업이익", 12)] long bfoperatingincome,
    [BlockField("전분기경상이익", 12)] long bfordinaryincome,
    [BlockField("전분기순이익", 12)] long bfnetincome,
    [BlockField("전분기EPS", 13.2)] double bfeps,
    [BlockField("전전분기명", 10)] string name2,
    [BlockField("전전분기매출액", 12)] long bfsales2,
    [BlockField("전전분기영업이익", 12)] long bfoperatingincome2,
    [BlockField("전전분기경상이익", 12)] long bfordinaryincome2,
    [BlockField("전전분기순이익", 12)] long bfnetincome2,
    [BlockField("전전분기EPS", 13.2)] double bfeps2,
    [BlockField("전년대비매출액", 7.2)] double salert,
    [BlockField("전년대비영업이익", 7.2)] double opert,
    [BlockField("전년대비경상이익", 7.2)] double ordrt,
    [BlockField("전년대비순이익", 7.2)] double netrt,
    [BlockField("전년대비EPS", 7.2)] double epsrt,
    [BlockField("락구분", 10)] string info1,
    [BlockField("관리/급등구분", 10)] string info2,
    [BlockField("정지/연장구분", 10)] string info3,
    [BlockField("투자/불성실구분", 12)] string info4,
    [BlockField("장구분", 10)] string janginfo,
    [BlockField("T.PER", 6.2)] double t_per,
    [BlockField("통화ISO코드", 3)] string tonghwa,
    [BlockField("총매도대금1", 18)] long dval1,
    [BlockField("총매수대금1", 18)] long sval1,
    [BlockField("총매도대금2", 18)] long dval2,
    [BlockField("총매수대금2", 18)] long sval2,
    [BlockField("총매도대금3", 18)] long dval3,
    [BlockField("총매수대금3", 18)] long sval3,
    [BlockField("총매도대금4", 18)] long dval4,
    [BlockField("총매수대금4", 18)] long sval4,
    [BlockField("총매도대금5", 18)] long dval5,
    [BlockField("총매수대금5", 18)] long sval5,
    [BlockField("총매도평단가1", 8)] int davg1,
    [BlockField("총매수평단가1", 8)] int savg1,
    [BlockField("총매도평단가2", 8)] int davg2,
    [BlockField("총매수평단가2", 8)] int savg2,
    [BlockField("총매도평단가3", 8)] int davg3,
    [BlockField("총매수평단가3", 8)] int savg3,
    [BlockField("총매도평단가4", 8)] int davg4,
    [BlockField("총매수평단가4", 8)] int savg4,
    [BlockField("총매도평단가5", 8)] int davg5,
    [BlockField("총매수평단가5", 8)] int savg5,
    [BlockField("외국계매도대금", 18)] long ftradmdval,
    [BlockField("외국계매수대금", 18)] long ftradmsval,
    [BlockField("외국계매도평단가", 8)] int ftradmdvag,
    [BlockField("외국계매수평단가", 8)] int ftradmsvag,
    [BlockField("투자주의환기", 8)] string info5,
    [BlockField("기업인수목적회사여부", 1)] string spac_gubun,
    [BlockField("발행가격", 8)] int issueprice,
    [BlockField("배분적용구분코드(1:배분발생2:배분해제그외:미발생)", 1)] string alloc_gubun,
    [BlockField("배분적용구분", 8)] string alloc_text,
    [BlockField("단기과열/VI발동", 10)] string shterm_text,
    [BlockField("정적VI상한가", 8)] int svi_uplmtprice,
    [BlockField("정적VI하한가", 8)] int svi_dnlmtprice,
    [BlockField("저유동성종목여부", 1)] string low_lqdt_gu,
    [BlockField("이상급등종목여부", 1)] string abnormal_rise_gu,
    [BlockField("대차불가표시", 8)] string lend_text,
    [BlockField("ETF/ETN투자유의", 8)] string ty_text
    );


/// <summary>
/// 주식현재가시세메모: t1104
/// </summary>
/// <param name="code">종목코드	string	6</param>
/// <param name="nrec">건수	string	2</param>
public record t1104InBlock(
    [BlockField("종목코드", 6)] string code,
    [BlockField("건수", 2)] string nrec
    );

/// <summary>
/// 주식현재가시세메모: t1104
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="dat1">데이타1	string	1</param>
/// <param name="dat2">데이타2	string	8</param>
public record t1104InBlock1(
    [BlockField("인덱스", 1)] string indx,
    [BlockField("조건구분", 1)] string gubn,
    [BlockField("데이타1", 1)] string dat1,
    [BlockField("데이타2", 8)] string dat2
    );

/// <summary>
/// 주식현재가시세메모: t1104
/// </summary>
/// <param name="nrec">출력건수	string	2</param>
public record t1104OutBlock(
    [BlockField("출력건수", 2)] string nrec
    );

/// <summary>
/// 주식현재가시세메모: t1104
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="vals">출력값	string	8</param>
public record t1104OutBlock1(
    [BlockField("인덱스", 1)] string indx,
    [BlockField("조건구분", 1)] string gubn,
    [BlockField("출력값", 8)] string vals
    );


/// <summary>
/// 주식피못/디마크조회: t1105
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1105InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// 주식피못/디마크조회: t1105
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
public record t1105OutBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("피봇", 8)] int pbot,
    [BlockField("1차저항", 8)] int offer1,
    [BlockField("1차지지", 8)] int supp1,
    [BlockField("2차저항", 8)] int offer2,
    [BlockField("2차지지", 8)] int supp2,
    [BlockField("기준가격", 8)] int stdprc,
    [BlockField("D저항", 8)] int offerd,
    [BlockField("D지지", 8)] int suppd
    );


/// <summary>
/// 시간외체결량: t1109
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="dan_chetime">체결cts	string	10</param>
/// <param name="idx">IDX	int	4</param>
public record t1109InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("체결cts", 10)] string dan_chetime,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외체결량: t1109
/// </summary>
/// <param name="ctsshcode">종목cts	string	6</param>
/// <param name="ctschetime">체결cts	string	10</param>
/// <param name="idx">IDX	int	4</param>
public record t1109OutBlock(
    [BlockField("종목cts", 6)] string ctsshcode,
    [BlockField("체결cts", 10)] string ctschetime,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외체결량: t1109
/// </summary>
/// <param name="dan_chetime">시간	string	10</param>
/// <param name="dan_price">현재가	int	8</param>
/// <param name="dan_sign">전일대비구분	string	1</param>
/// <param name="dan_change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="dan_cvolume">체결량	int	8</param>
/// <param name="chdegree">체결강도	double	9.2</param>
/// <param name="dan_volume">누적거래량	long	12</param>
public record t1109OutBlock1(
    [BlockField("시간", 10)] string dan_chetime,
    [BlockField("현재가", 8)] int dan_price,
    [BlockField("전일대비구분", 1)] string dan_sign,
    [BlockField("전일대비", 8)] int dan_change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결량", 8)] int dan_cvolume,
    [BlockField("체결강도", 9.2)] double chdegree,
    [BlockField("누적거래량", 12)] long dan_volume
    );


/// <summary>
/// 주식시간대별체결조회: t1301
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1301InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string starttime,
    [BlockField("종료시간", 4)] string endtime,
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식시간대별체결조회: t1301
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1301OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식시간대별체결조회: t1301
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
public record t1301OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 12)] long cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도체결수량", 12)] long mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 12)] long msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("순체결량", 12)] long revolume,
    [BlockField("순체결건수", 8)] int rechecnt
    );


/// <summary>
/// 주식분별주가조회: t1302
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gubun">작업구분	string	1</param>
/// <param name="time">시간	string	6</param>
/// <param name="cnt">건수	int	3</param>
public record t1302InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("작업구분", 1)] string gubun,
    [BlockField("시간", 6)] string time,
    [BlockField("건수", 3)] int cnt
    );

/// <summary>
/// 주식분별주가조회: t1302
/// </summary>
/// <param name="cts_time">시간CTS	string	6</param>
public record t1302OutBlock(
    [BlockField("시간CTS", 6)] string cts_time
    );

/// <summary>
/// 주식분별주가조회: t1302
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
public record t1302OutBlock1(
    [BlockField("시간", 6)] string chetime,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("매도체결수량", 12)] long mdvolume,
    [BlockField("매수체결수량", 12)] long msvolume,
    [BlockField("순매수체결량", 12)] long revolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("순체결건수", 8)] int rechecnt,
    [BlockField("거래량", 12)] long volume,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("체결량", 12)] long cvolume,
    [BlockField("매도체결건수(시간)", 8)] int mdchecnttm,
    [BlockField("매수체결건수(시간)", 8)] int mschecnttm,
    [BlockField("매도잔량", 12)] long totofferrem,
    [BlockField("매수잔량", 12)] long totbidrem,
    [BlockField("시간별매도체결량", 12)] long mdvolumetm,
    [BlockField("시간별매수체결량", 12)] long msvolumetm
    );


/// <summary>
/// 기간별주가: t1305
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="dwmcode">일주월구분	int	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="cnt">건수	int	4</param>
public record t1305InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("일주월구분", 1)] int dwmcode,
    [BlockField("날짜", 8)] string date,
    [BlockField("IDX", 4)] int idx,
    [BlockField("건수", 4)] int cnt
    );

/// <summary>
/// 기간별주가: t1305
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1305OutBlock(
    [BlockField("CNT", 4)] int cnt,
    [BlockField("날짜", 8)] string date,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 기간별주가: t1305
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
public record t1305OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("체결강도", 6.2)] double chdegree,
    [BlockField("소진율", 6.2)] double sojinrate,
    [BlockField("회전율", 6.2)] double changerate,
    [BlockField("외인순매수", 12)] long fpvolume,
    [BlockField("기관순매수", 12)] long covolume,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("누적거래대금(단위:백만)", 12)] long value,
    [BlockField("개인순매수", 12)] long ppvolume,
    [BlockField("시가대비구분", 1)] string o_sign,
    [BlockField("시가대비", 8)] int o_change,
    [BlockField("시가기준등락율", 6.2)] double o_diff,
    [BlockField("고가대비구분", 1)] string h_sign,
    [BlockField("고가대비", 8)] int h_change,
    [BlockField("고가기준등락율", 6.2)] double h_diff,
    [BlockField("저가대비구분", 1)] string l_sign,
    [BlockField("저가대비", 8)] int l_change,
    [BlockField("저가기준등락율", 6.2)] double l_diff,
    [BlockField("시가총액(단위:백만)", 12)] long marketcap
    );


/// <summary>
/// 주식시간대별체결조회챠트: t1308
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="bun_term">분간격	string	2</param>
public record t1308InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("시작시간", 4)] string starttime,
    [BlockField("종료시간", 4)] string endtime,
    [BlockField("분간격", 2)] string bun_term
    );

/// <summary>
/// 주식시간대별체결조회챠트: t1308
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
public record t1308OutBlock1(
    [BlockField("시간", 8)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("체결강도(거래량)", 8.2)] double chdegvol,
    [BlockField("체결강도(건수)", 8.2)] double chdegcnt,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도체결수량", 12)] long mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 12)] long msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low
    );


/// <summary>
/// 주식당일전일분틱조회: t1310
/// </summary>
/// <param name="daygb">당일전일구분	string	1</param>
/// <param name="timegb">분틱구분	string	1</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1310InBlock(
    [BlockField("당일전일구분", 1)] string daygb,
    [BlockField("분틱구분", 1)] string timegb,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("종료시간", 4)] string endtime,
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식당일전일분틱조회: t1310
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1310OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식당일전일분틱조회: t1310
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
public record t1310OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 12)] long cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도체결수량", 12)] long mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 12)] long msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("순체결량", 12)] long revolume,
    [BlockField("순체결건수", 8)] int rechecnt
    );


/// <summary>
/// 신규상장종목조회: t1403
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="styymm">시작상장월	string	6</param>
/// <param name="enyymm">종료상장월	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1403InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("시작상장월", 6)] string styymm,
    [BlockField("종료상장월", 6)] string enyymm,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 신규상장종목조회: t1403
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1403OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 신규상장종목조회: t1403
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
public record t1403OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("공모가", 8)] int kmprice,
    [BlockField("등록일", 8)] string date,
    [BlockField("등록일기준가", 8)] int recprice,
    [BlockField("기준가등락율", 6.2)] double kmdiff,
    [BlockField("등록일종가", 8)] int close,
    [BlockField("등록일등락율", 6.2)] double recdiff,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 관리/불성실/투자유의조회: t1404
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1404InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("종목체크", 1)] string jongchk,
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 관리/불성실/투자유의조회: t1404
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1404OutBlock(
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 관리/불성실/투자유의조회: t1404
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
public record t1404OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("지정일", 8)] string date,
    [BlockField("지정일주가", 8)] int tprice,
    [BlockField("지정일대비", 8)] int tchange,
    [BlockField("대비율", 6.2)] double tdiff,
    [BlockField("사유", 4)] string reason,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("해제일", 8)] string edate
    );


/// <summary>
/// 투자경고/매매정지/정리매매조회: t1405
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1405InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("종목체크", 1)] string jongchk,
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 투자경고/매매정지/정리매매조회: t1405
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1405OutBlock(
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 투자경고/매매정지/정리매매조회: t1405
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
public record t1405OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("지정일", 8)] string date,
    [BlockField("해제일", 8)] string edate,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 초저유동성조회: t1410
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1410InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 초저유동성조회: t1410
/// </summary>
/// <param name="cts_shcode">종목코드_CTS	string	6</param>
public record t1410OutBlock(
    [BlockField("종목코드_CTS", 6)] string cts_shcode
    );

/// <summary>
/// 초저유동성조회: t1410
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1410OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 증거금율별종목조회: t1411
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="jongchk">위탁신용구분	string	1</param>
/// <param name="jkrate">증거금율구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1411InBlock(
    [BlockField("시장구분", 1)] string gubun,
    [BlockField("위탁신용구분", 1)] string jongchk,
    [BlockField("증거금율구분", 1)] string jkrate,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 증거금율별종목조회: t1411
/// </summary>
/// <param name="jkrate">위탁증거금율	int	3</param>
/// <param name="sjkrate">신용증거금율	int	3</param>
/// <param name="idx">IDX	int	4</param>
public record t1411OutBlock(
    [BlockField("위탁증거금율", 3)] int jkrate,
    [BlockField("신용증거금율", 3)] int sjkrate,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 증거금율별종목조회: t1411
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
public record t1411OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("위탁증거금율", 3)] int jkrate,
    [BlockField("신용증거금율", 3)] int sjkrate,
    [BlockField("대용가", 8)] int subprice,
    [BlockField("전일종가", 8)] int recprice,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume
    );


/// <summary>
/// 상/하한: t1422
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
public record t1422InBlock(
    [BlockField("조회구분", 1)] string qrygb,
    [BlockField("구분", 1)] string gubun,
    [BlockField("전일구분", 1)] string jnilgubun,
    [BlockField("상하한구분", 1)] string sign,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 상/하한: t1422
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t1422OutBlock(
    [BlockField("CNT", 4)] int cnt,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 상/하한: t1422
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
public record t1422OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("최종진입", 6)] string last,
    [BlockField("연속", 8)] int lmtdaycnt,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 상/하한가직전: t1427
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
public record t1427InBlock(
    [BlockField("조회구분", 1)] string qrygb,
    [BlockField("구분", 1)] string gubun,
    [BlockField("상하한가구분", 1)] string signgubun,
    [BlockField("등락율", 3)] int diff,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx,
    [BlockField("전일상하한제외", 1)] string jshex
    );

/// <summary>
/// 상/하한가직전: t1427
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t1427OutBlock(
    [BlockField("CNT", 4)] int cnt,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 상/하한가직전: t1427
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
public record t1427OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("상한가/하한가", 8)] int lmtprice,
    [BlockField("대비율", 12.2)] double rate,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("연속", 8)] int lmtdaycnt,
    [BlockField("거래대금", 12)] long value,
    [BlockField("시가총액", 12)] long total
    );


/// <summary>
/// 등락율상위: t1441
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
public record t1441InBlock(
    [BlockField("구분", 1)] string gubun1,
    [BlockField("상승하락", 1)] string gubun2,
    [BlockField("당일전일", 1)] string gubun3,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx,
    [BlockField("대상제외2", 12)] long jc_num2
    );

/// <summary>
/// 등락율상위: t1441
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1441OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 등락율상위: t1441
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
public record t1441OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매도호가", 12)] long offerho1,
    [BlockField("매수호가", 12)] long bidho1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("연속", 4)] int updaycnt,
    [BlockField("전일등락율", 6.2)] double jnildiff,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("거래량대비율", 8.2)] double voldiff,
    [BlockField("거래대금", 15)] long value,
    [BlockField("시가총액", 12)] long total
    );


/// <summary>
/// 신고/신저가: t1442
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
public record t1442InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("신고신저", 1)] string type1,
    [BlockField("기간", 1)] string type2,
    [BlockField("유지여부", 1)] string type3,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx,
    [BlockField("대상제외2", 12)] long jc_num2
    );

/// <summary>
/// 신고/신저가: t1442
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1442OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 신고/신저가: t1442
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
public record t1442OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("이전가", 8)] int pastprice,
    [BlockField("이전가대비구분", 1)] string pastsign,
    [BlockField("이전가대비", 8)] int pastchange,
    [BlockField("이전가대비율", 6.2)] double pastdiff
    );


/// <summary>
/// 시가총액상위: t1444
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="idx">IDX	int	4</param>
public record t1444InBlock(
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시가총액상위: t1444
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1444OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시가총액상위: t1444
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
public record t1444OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래비중", 6.2)] double vol_rate,
    [BlockField("시가총액", 12)] long total,
    [BlockField("비중", 6.2)] double rate,
    [BlockField("외인비중", 6.2)] double for_rate
    );


/// <summary>
/// 가격대별매매비중조회: t1449
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="dategb">일자구분	string	1</param>
public record t1449InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("일자구분", 1)] string dategb
    );

/// <summary>
/// 가격대별매매비중조회: t1449
/// </summary>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="msvolume">매수체결량	long	12</param>
/// <param name="mdvolume">매도체결량	long	12</param>
public record t1449OutBlock(
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매수체결량", 12)] long msvolume,
    [BlockField("매도체결량", 12)] long mdvolume
    );

/// <summary>
/// 가격대별매매비중조회: t1449
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
public record t1449OutBlock1(
    [BlockField("체결가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double tickdiff,
    [BlockField("체결수량", 12)] long cvolume,
    [BlockField("비중", 6.2)] double diff,
    [BlockField("매도체결량", 12)] long mdvolume,
    [BlockField("매수체결량", 12)] long msvolume,
    [BlockField("매수비율", 6.2)] double msdiff
    );


/// <summary>
/// 거래량상위: t1452
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
public record t1452InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("전일구분", 1)] string jnilgubun,
    [BlockField("시작등락율", 3)] int sdiff,
    [BlockField("종료등락율", 3)] int ediff,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 거래량상위: t1452
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1452OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 거래량상위: t1452
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
public record t1452OutBlock1(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("전일비", 10.2)] double bef_diff,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 거래대금상위: t1463
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jnilgubun">전일구분	string	1</param>
/// <param name="jc_num">대상제외	long	12</param>
/// <param name="sprice">시작가격	int	8</param>
/// <param name="eprice">종료가격	int	8</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="jc_num2">대상제외2	long	12</param>
public record t1463InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("전일구분", 1)] string jnilgubun,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx,
    [BlockField("대상제외2", 12)] long jc_num2
    );

/// <summary>
/// 거래대금상위: t1463
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1463OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 거래대금상위: t1463
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
public record t1463OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래대금", 12)] long value,
    [BlockField("전일거래대금", 12)] long jnilvalue,
    [BlockField("전일비", 10.2)] double bef_diff,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("filler", 1)] string filler,
    [BlockField("전일거래량", 12)] long jnilvolume
    );


/// <summary>
/// 전일동시간대비거래급증: t1466
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
public record t1466InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("전일거래량", 1)] string type1,
    [BlockField("거래급등율", 1)] string type2,
    [BlockField("대상제외", 12)] long jc_num,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IDX", 4)] int idx,
    [BlockField("대상제외2", 12)] long jc_num2
    );

/// <summary>
/// 전일동시간대비거래급증: t1466
/// </summary>
/// <param name="hhmm">현재시분	string	5</param>
/// <param name="idx">IDX	int	4</param>
public record t1466OutBlock(
    [BlockField("현재시분", 5)] string hhmm,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 전일동시간대비거래급증: t1466
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
public record t1466OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("전일거래량", 12)] long stdvolume,
    [BlockField("당일거래량", 12)] long volume,
    [BlockField("거래급등율", 8.2)] double voldiff,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low
    );


/// <summary>
/// 시간대별호가잔량추이: t1471
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">분구분	string	2</param>
/// <param name="time">시간	string	6</param>
/// <param name="cnt">자료개수	string	3</param>
public record t1471InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("분구분", 2)] string gubun,
    [BlockField("시간", 6)] string time,
    [BlockField("자료개수", 3)] string cnt
    );

/// <summary>
/// 시간대별호가잔량추이: t1471
/// </summary>
/// <param name="time">시간CTS	string	6</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
public record t1471OutBlock(
    [BlockField("시간CTS", 6)] string time,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume
    );

/// <summary>
/// 시간대별호가잔량추이: t1471
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
public record t1471OutBlock1(
    [BlockField("체결시간", 6)] string time,
    [BlockField("메도증감", 12)] long preoffercha1,
    [BlockField("매도우선잔량", 12)] long offerrem1,
    [BlockField("매도우선호가", 8)] int offerho1,
    [BlockField("매수우선호가", 8)] int bidho1,
    [BlockField("매수우선잔량", 12)] long bidrem1,
    [BlockField("매수증감", 12)] long prebidcha1,
    [BlockField("총매도", 12)] long totofferrem,
    [BlockField("총매수", 12)] long totbidrem,
    [BlockField("순매수", 12)] long totsun,
    [BlockField("매수비율", 6.2)] double msrate,
    [BlockField("종가", 8)] int close
    );


/// <summary>
/// 체결강도추이: t1475
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="vptype">상승하락	string	1</param>
/// <param name="datacnt">데이터개수	int	4</param>
/// <param name="date">기준일자	int	8</param>
/// <param name="time">기준시간	int	6</param>
/// <param name="rankcnt">랭크카운터	int	3</param>
/// <param name="gubun">조회구분	string	1</param>
public record t1475InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("상승하락", 1)] string vptype,
    [BlockField("데이터개수", 4)] int datacnt,
    [BlockField("기준일자", 8)] int date,
    [BlockField("기준시간", 6)] int time,
    [BlockField("랭크카운터", 3)] int rankcnt,
    [BlockField("조회구분", 1)] string gubun
    );

/// <summary>
/// 체결강도추이: t1475
/// </summary>
/// <param name="date">기준일자	int	8</param>
/// <param name="time">기준시간	int	6</param>
/// <param name="rankcnt">랭크카운터	int	3</param>
public record t1475OutBlock(
    [BlockField("기준일자", 8)] int date,
    [BlockField("기준시간", 6)] int time,
    [BlockField("랭크카운터", 3)] int rankcnt
    );

/// <summary>
/// 체결강도추이: t1475
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
public record t1475OutBlock1(
    [BlockField("일자", 10)] string datetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("당일VP", 8.2)] double todayvp,
    [BlockField("5일MAVP", 8.2)] double ma5vp,
    [BlockField("20일MAVP", 8.2)] double ma20vp,
    [BlockField("60일MAVP", 8.2)] double ma60vp
    );


/// <summary>
/// 시간외등락율상위: t1481
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="gubun2">상승하락	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="volume">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1481InBlock(
    [BlockField("구분", 1)] string gubun1,
    [BlockField("상승하락", 1)] string gubun2,
    [BlockField("종목체크", 1)] string jongchk,
    [BlockField("거래량", 1)] string volume,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외등락율상위: t1481
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1481OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외등락율상위: t1481
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
public record t1481OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("매도호가", 12)] long offerho1,
    [BlockField("매수호가", 12)] long bidho1,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("누적거래대금", 12)] long value
    );


/// <summary>
/// 시간외거래량상위: t1482
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="jongchk">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1482InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("거래량", 1)] string jongchk,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외거래량상위: t1482
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1482OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간외거래량상위: t1482
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
public record t1482OutBlock1(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("누적거래대금", 12)] long value
    );


/// <summary>
/// 예상지수: t1485
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun">조회구분	string	1</param>
public record t1485InBlock(
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("조회구분", 1)] string gubun
    );

/// <summary>
/// 예상지수: t1485
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
public record t1485OutBlock(
    [BlockField("현재지수", 10.2)] double pricejisu,
    [BlockField("지수전일대비구분", 1)] string sign,
    [BlockField("전일대비", 10.2)] double change,
    [BlockField("거래량", 12)] long volume,
    [BlockField("상승종목수", 4)] int yhighjo,
    [BlockField("상한종목수", 4)] int yupjo,
    [BlockField("보합종목수", 4)] int yunchgjo,
    [BlockField("하락종목수", 4)] int ylowjo,
    [BlockField("하한종목수", 4)] int ydownjo,
    [BlockField("거래형성수", 4)] int ytrajo
    );

/// <summary>
/// 예상지수: t1485
/// </summary>
/// <param name="chetime">시간	string	6</param>
/// <param name="jisu">예상지수	double	10.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	10.2</param>
/// <param name="volume">예상체결량	long	12</param>
/// <param name="volcha">예상체결량직전대비	long	12</param>
/// <param name="diff">예상등락율	double	6.2</param>
public record t1485OutBlock1(
    [BlockField("시간", 6)] string chetime,
    [BlockField("예상지수", 10.2)] double jisu,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 10.2)] double change,
    [BlockField("예상체결량", 12)] long volume,
    [BlockField("예상체결량직전대비", 12)] long volcha,
    [BlockField("예상등락율", 6.2)] double diff
    );


/// <summary>
/// 시간별예상체결가: t1486
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cts_time">시간CTS	string	10</param>
/// <param name="cnt">조회건수	int	4</param>
public record t1486InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("시간CTS", 10)] string cts_time,
    [BlockField("조회건수", 4)] int cnt
    );

/// <summary>
/// 시간별예상체결가: t1486
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t1486OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 시간별예상체결가: t1486
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
public record t1486OutBlock1(
    [BlockField("시간", 8)] string chetime,
    [BlockField("예상체결가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("예상체결량", 12)] long cvolume,
    [BlockField("매도호가", 8)] int offerho1,
    [BlockField("매수호가", 8)] int bidho1,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1
    );


/// <summary>
/// 예상체결가등락율상위조회: t1488
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
public record t1488InBlock(
    [BlockField("거래소구분", 1)] string gubun,
    [BlockField("상하락구분", 1)] string sign,
    [BlockField("장구분", 1)] string jgubun,
    [BlockField("종목체크", 12)] string jongchk,
    [BlockField("IDX", 4)] int idx,
    [BlockField("거래량", 1)] string volume,
    [BlockField("예상체결시작가격", 8)] int yesprice,
    [BlockField("예상체결종료가격", 8)] int yeeprice,
    [BlockField("예상체결량", 12)] long yevolume
    );

/// <summary>
/// 예상체결가등락율상위조회: t1488
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1488OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 예상체결가등락율상위조회: t1488
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
public record t1488OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("매도잔량", 12)] long offerrem,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("매수잔량", 12)] long bidrem,
    [BlockField("연속일수", 4)] int cnt,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("증거금율", 3)] string jkrate,
    [BlockField("전일거래량", 12)] long jnilvolume
    );


/// <summary>
/// 예상체결량상위조회: t1489
/// </summary>
/// <param name="gubun">거래소구분	string	1</param>
/// <param name="jgubun">장구분	string	1</param>
/// <param name="jongchk">종목체크	string	12</param>
/// <param name="idx">IDX	int	4</param>
/// <param name="yesprice">예상체결시작가격	int	8</param>
/// <param name="yeeprice">예상체결종료가격	int	8</param>
/// <param name="yevolume">예상체결량	long	12</param>
public record t1489InBlock(
    [BlockField("거래소구분", 1)] string gubun,
    [BlockField("장구분", 1)] string jgubun,
    [BlockField("종목체크", 12)] string jongchk,
    [BlockField("IDX", 4)] int idx,
    [BlockField("예상체결시작가격", 8)] int yesprice,
    [BlockField("예상체결종료가격", 8)] int yeeprice,
    [BlockField("예상체결량", 12)] long yevolume
    );

/// <summary>
/// 예상체결량상위조회: t1489
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1489OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 예상체결량상위조회: t1489
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
public record t1489OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("예상거래량", 12)] long volume,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("전일거래량", 12)] long jnilvolume
    );


/// <summary>
/// 단일가예상등락율상위: t1492
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="gubun2">상승하락	string	1</param>
/// <param name="jongchk">종목체크	string	1</param>
/// <param name="volume">거래량	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t1492InBlock(
    [BlockField("구분", 1)] string gubun1,
    [BlockField("상승하락", 1)] string gubun2,
    [BlockField("종목체크", 1)] string jongchk,
    [BlockField("거래량", 1)] string volume,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 단일가예상등락율상위: t1492
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1492OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 단일가예상등락율상위: t1492
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
public record t1492OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("예상체결가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("예상체결량", 12)] long yevolume,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("매도호가", 12)] long offerho1,
    [BlockField("매수호가", 12)] long bidho1,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("누적거래대금", 12)] long value
    );


/// <summary>
/// 업종현재가: t1511
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
public record t1511InBlock(
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 업종현재가: t1511
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
public record t1511OutBlock(
    [BlockField("업종구분", 1)] string gubun,
    [BlockField("업종명", 20)] string hname,
    [BlockField("현재지수", 7.2)] double pricejisu,
    [BlockField("전일지수", 7.2)] double jniljisu,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 7.2)] double change,
    [BlockField("지수등락율", 6.2)] double diffjisu,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("당일거래량", 12)] long volume,
    [BlockField("거래량전일대비", 12)] long volumechange,
    [BlockField("거래량비율", 6.2)] double volumerate,
    [BlockField("전일거래대금", 12)] long jnilvalue,
    [BlockField("당일거래대금", 12)] long value,
    [BlockField("거래대금전일대비", 12)] long valuechange,
    [BlockField("거래대금비율", 6.2)] double valuerate,
    [BlockField("시가지수", 7.2)] double openjisu,
    [BlockField("시가등락율", 6.2)] double opendiff,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가지수", 7.2)] double highjisu,
    [BlockField("고가등락율", 6.2)] double highdiff,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가지수", 7.2)] double lowjisu,
    [BlockField("저가등락율", 6.2)] double lowdiff,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("52주최고지수", 7.2)] double whjisu,
    [BlockField("52주최고현재가대비", 7.2)] double whchange,
    [BlockField("52주최고지수일자", 8)] string whjday,
    [BlockField("52주최저지수", 7.2)] double wljisu,
    [BlockField("52주최저현재가대비", 7.2)] double wlchange,
    [BlockField("52주최저지수일자", 8)] string wljday,
    [BlockField("연중최고지수", 7.2)] double yhjisu,
    [BlockField("연중최고현재가대비", 7.2)] double yhchange,
    [BlockField("연중최고지수일자", 8)] string yhjday,
    [BlockField("연중최저지수", 7.2)] double yljisu,
    [BlockField("연중최저현재가대비", 7.2)] double ylchange,
    [BlockField("연중최저지수일자", 8)] string yljday,
    [BlockField("첫번째지수코드", 3)] string firstjcode,
    [BlockField("첫번째지수명", 20)] string firstjname,
    [BlockField("첫번째지수", 7.2)] double firstjisu,
    [BlockField("첫번째대비구분", 1)] string firsign,
    [BlockField("첫번째전일대비", 7.2)] double firchange,
    [BlockField("첫번째등락율", 6.2)] double firdiff,
    [BlockField("두번째지수코드", 3)] string secondjcode,
    [BlockField("두번째지수명", 20)] string secondjname,
    [BlockField("두번째지수", 7.2)] double secondjisu,
    [BlockField("두번째대비구분", 1)] string secsign,
    [BlockField("두번째전일대비", 7.2)] double secchange,
    [BlockField("두번째등락율", 6.2)] double secdiff,
    [BlockField("세번째지수코드", 3)] string thirdjcode,
    [BlockField("세번째지수명", 20)] string thirdjname,
    [BlockField("세번째지수", 7.2)] double thirdjisu,
    [BlockField("세번째대비구분", 1)] string thrsign,
    [BlockField("세번째전일대비", 7.2)] double thrchange,
    [BlockField("세번째등락율", 6.2)] double thrdiff,
    [BlockField("네번째지수코드", 3)] string fourthjcode,
    [BlockField("네번째지수명", 20)] string fourthjname,
    [BlockField("네번째지수", 7.2)] double fourthjisu,
    [BlockField("네번째대비구분", 1)] string forsign,
    [BlockField("네번째전일대비", 7.2)] double forchange,
    [BlockField("네번째등락율", 6.2)] double fordiff,
    [BlockField("상승종목수", 4)] int highjo,
    [BlockField("상한종목수", 4)] int upjo,
    [BlockField("보합종목수", 4)] int unchgjo,
    [BlockField("하락종목수", 4)] int lowjo,
    [BlockField("하한종목수", 4)] int downjo
    );


/// <summary>
/// 업종기간별추이: t1514
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">구분1	string	1</param>
/// <param name="gubun2">구분2	string	1</param>
/// <param name="cts_date">CTS_일자	string	8</param>
/// <param name="cnt">조회건수	int	4</param>
/// <param name="rate_gbn">비중구분	string	1</param>
public record t1514InBlock(
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("구분1", 1)] string gubun1,
    [BlockField("구분2", 1)] string gubun2,
    [BlockField("CTS_일자", 8)] string cts_date,
    [BlockField("조회건수", 4)] int cnt,
    [BlockField("비중구분", 1)] string rate_gbn
    );

/// <summary>
/// 업종기간별추이: t1514
/// </summary>
/// <param name="cts_date">CTS_일자	string	8</param>
public record t1514OutBlock(
    [BlockField("CTS_일자", 8)] string cts_date
    );

/// <summary>
/// 업종기간별추이: t1514
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
public record t1514OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("지수", 12.2)] double jisu,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 7.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래증가율", 12.2)] double diff_vol,
    [BlockField("거래대금1", 12)] long value1,
    [BlockField("상승", 4)] int high,
    [BlockField("보합", 4)] int unchg,
    [BlockField("하락", 4)] int low,
    [BlockField("상승종목비율", 6.2)] double uprate,
    [BlockField("외인순매수", 8)] int frgsvolume,
    [BlockField("시가", 12.2)] double openjisu,
    [BlockField("고가", 12.2)] double highjisu,
    [BlockField("저가", 12.2)] double lowjisu,
    [BlockField("거래대금2", 12)] long value2,
    [BlockField("상한", 4)] int up,
    [BlockField("하한", 4)] int down,
    [BlockField("종목수", 4)] int totjo,
    [BlockField("기관순매수", 8)] int orgsvolume,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("거래비중", 7.2)] double rate,
    [BlockField("업종배당수익률", 7.2)] double divrate
    );


/// <summary>
/// 업종별종목시세: t1516
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
public record t1516InBlock(
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("구분", 1)] string gubun,
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// 업종별종목시세: t1516
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="pricejisu">지수	double	12.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	7.2</param>
/// <param name="jdiff">등락율	double	6.2</param>
public record t1516OutBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("지수", 12.2)] double pricejisu,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 7.2)] double change,
    [BlockField("등락율", 6.2)] double jdiff
    );

/// <summary>
/// 업종별종목시세: t1516
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
public record t1516OutBlock1(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("소진율", 6.2)] double sojinrate,
    [BlockField("베타계수", 6.5)] double beta,
    [BlockField("PER", 8.2)] double perx,
    [BlockField("외인순매수", 12)] long frgsvolume,
    [BlockField("기관순매수", 12)] long orgsvolume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("시가총액", 12)] long total,
    [BlockField("거래대금", 12)] long value
    );


/// <summary>
/// 테마별종목: t1531
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1531InBlock(
    [BlockField("테마명", 36)] string tmname,
    [BlockField("테마코드", 4)] string tmcode
    );

/// <summary>
/// 테마별종목: t1531
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="avgdiff">평균등락율	double	6.2</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1531OutBlock(
    [BlockField("테마명", 36)] string tmname,
    [BlockField("평균등락율", 6.2)] double avgdiff,
    [BlockField("테마코드", 4)] string tmcode
    );


/// <summary>
/// 종목별테마: t1532
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1532InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// 종목별테마: t1532
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="avgdiff">평균등락율	double	6.2</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t1532OutBlock(
    [BlockField("테마명", 36)] string tmname,
    [BlockField("평균등락율", 6.2)] double avgdiff,
    [BlockField("테마코드", 4)] string tmcode
    );


/// <summary>
/// 특이테마: t1533
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="chgdate">대비일자	int	2</param>
public record t1533InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("대비일자", 2)] int chgdate
    );

/// <summary>
/// 특이테마: t1533
/// </summary>
/// <param name="bdate">일자	string	8</param>
public record t1533OutBlock(
    [BlockField("일자", 8)] string bdate
    );

/// <summary>
/// 특이테마: t1533
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
public record t1533OutBlock1(
    [BlockField("테마명", 36)] string tmname,
    [BlockField("전체", 4)] int totcnt,
    [BlockField("상승", 4)] int upcnt,
    [BlockField("하락", 4)] int dncnt,
    [BlockField("상승비율", 6.2)] double uprate,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("평균등락율", 6.2)] double avgdiff,
    [BlockField("대비등락율", 6.2)] double chgdiff,
    [BlockField("테마코드", 4)] string tmcode
    );


/// <summary>
/// 테마종목별시세조회: t1537
/// </summary>
/// <param name="tmcode">테마코드	string	4</param>
public record t1537InBlock(
    [BlockField("테마코드", 4)] string tmcode
    );

/// <summary>
/// 테마종목별시세조회: t1537
/// </summary>
/// <param name="upcnt">상승종목수	int	4</param>
/// <param name="tmcnt">테마종목수	int	4</param>
/// <param name="uprate">상승종목비율	int	4</param>
/// <param name="tmname">테마명	string	36</param>
public record t1537OutBlock(
    [BlockField("상승종목수", 4)] int upcnt,
    [BlockField("테마종목수", 4)] int tmcnt,
    [BlockField("상승종목비율", 4)] int uprate,
    [BlockField("테마명", 36)] string tmname
    );

/// <summary>
/// 테마종목별시세조회: t1537
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
public record t1537OutBlock1(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("전일동시간", 9.2)] double jniltime,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("예상체결가", 8)] int yeprice,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("누적거래대금(단위:백만)", 12)] long value,
    [BlockField("시가총액(단위:백만)", 12)] long marketcap
    );


/// <summary>
/// 투자자별종합: t1601
/// </summary>
/// <param name="gubun1">주식금액수량구분1	string	1</param>
/// <param name="gubun2">옵션금액수량구분2	string	1</param>
/// <param name="gubun3">금액단위	string	1</param>
/// <param name="gubun4">선물금액수량구분4	string	1</param>
public record t1601InBlock(
    [BlockField("주식금액수량구분1", 1)] string gubun1,
    [BlockField("옵션금액수량구분2", 1)] string gubun2,
    [BlockField("금액단위", 1)] string gubun3,
    [BlockField("선물금액수량구분4", 1)] string gubun4
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock1(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock2(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock3(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock4(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock5(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 투자자별종합: t1601
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
public record t1601OutBlock6(
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("국가투자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("사모펀드투자자코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );


/// <summary>
/// 시간대별투자자매매추이: t1602
/// </summary>
/// <param name="market">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">수량구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	4</param>
/// <param name="gubun3">직전대비구분(C:직전대비)	string	1</param>
public record t1602InBlock(
    [BlockField("시장구분", 1)] string market,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("수량구분", 1)] string gubun1,
    [BlockField("전일분구분", 1)] string gubun2,
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("조회건수", 4)] int cnt,
    [BlockField("직전대비구분(C:직전대비)", 1)] string gubun3
    );

/// <summary>
/// 시간대별투자자매매추이: t1602
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
public record t1602OutBlock(
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("국가투자자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("사모펀드코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 시간대별투자자매매추이: t1602
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
public record t1602OutBlock1(
    [BlockField("시간", 8)] string time,
    [BlockField("개인순매수", 12)] long sv_08,
    [BlockField("외국인순매수", 12)] long sv_17,
    [BlockField("기관계순매수", 12)] long sv_18,
    [BlockField("증권순매수", 12)] long sv_01,
    [BlockField("투신순매수", 12)] long sv_03,
    [BlockField("은행순매수", 12)] long sv_04,
    [BlockField("보험순매수", 12)] long sv_02,
    [BlockField("종금순매수", 12)] long sv_05,
    [BlockField("기금순매수", 12)] long sv_06,
    [BlockField("기타순매수", 12)] long sv_07,
    [BlockField("국가순매수", 12)] long sv_11,
    [BlockField("사모펀드순매수", 12)] long sv_00
    );


/// <summary>
/// 시간대별투자자매매추이상세: t1603
/// </summary>
/// <param name="market">시장구분	string	1</param>
/// <param name="gubun1">투자자구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="upcode">업종코드	string	3</param>
public record t1603InBlock(
    [BlockField("시장구분", 1)] string market,
    [BlockField("투자자구분", 1)] string gubun1,
    [BlockField("전일분구분", 1)] string gubun2,
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("조회건수", 3)] int cnt,
    [BlockField("업종코드", 3)] string upcode
    );

/// <summary>
/// 시간대별투자자매매추이상세: t1603
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cts_time">CTSTIME	string	8</param>
public record t1603OutBlock(
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("CTSTIME", 8)] string cts_time
    );

/// <summary>
/// 시간대별투자자매매추이상세: t1603
/// </summary>
/// <param name="time">시간	string	8</param>
/// <param name="tjjcode">투자자구분	string	4</param>
/// <param name="msvolume">매수수량	int	8</param>
/// <param name="mdvolume">매도수량	int	8</param>
/// <param name="msvalue">매수금액	long	12</param>
/// <param name="mdvalue">매도금액	long	12</param>
/// <param name="svolume">순매수수량	int	8</param>
/// <param name="svalue">순매수금액	long	12</param>
public record t1603OutBlock1(
    [BlockField("시간", 8)] string time,
    [BlockField("투자자구분", 4)] string tjjcode,
    [BlockField("매수수량", 8)] int msvolume,
    [BlockField("매도수량", 8)] int mdvolume,
    [BlockField("매수금액", 12)] long msvalue,
    [BlockField("매도금액", 12)] long mdvalue,
    [BlockField("순매수수량", 8)] int svolume,
    [BlockField("순매수금액", 12)] long svalue
    );


/// <summary>
/// 투자자매매종합1: t1615
/// </summary>
/// <param name="gubun1">주식구분	string	1</param>
/// <param name="gubun2">옵션구분	string	1</param>
public record t1615InBlock(
    [BlockField("주식구분", 1)] string gubun1,
    [BlockField("옵션구분", 1)] string gubun2
    );

/// <summary>
/// 투자자매매종합1: t1615
/// </summary>
/// <param name="dwvolume">위탁매도수량	long	12</param>
/// <param name="dwvalue">위탁매도금액	long	12</param>
/// <param name="djvolume">자기매도수량	long	12</param>
/// <param name="djvalue">자기매도금액	long	12</param>
/// <param name="sum_volume">합계수량	long	12</param>
/// <param name="sum_value">합계금액	long	12</param>
public record t1615OutBlock(
    [BlockField("위탁매도수량", 12)] long dwvolume,
    [BlockField("위탁매도금액", 12)] long dwvalue,
    [BlockField("자기매도수량", 12)] long djvolume,
    [BlockField("자기매도금액", 12)] long djvalue,
    [BlockField("합계수량", 12)] long sum_volume,
    [BlockField("합계금액", 12)] long sum_value
    );

/// <summary>
/// 투자자매매종합1: t1615
/// </summary>
/// <param name="hname">시장명	string	20</param>
/// <param name="sv_08">개인	long	12</param>
/// <param name="sv_17">외국인	long	12</param>
/// <param name="sv_18">기관계	long	12</param>
/// <param name="sv_07">증권	long	12</param>
public record t1615OutBlock1(
    [BlockField("시장명", 20)] string hname,
    [BlockField("개인", 12)] long sv_08,
    [BlockField("외국인", 12)] long sv_17,
    [BlockField("기관계", 12)] long sv_18,
    [BlockField("증권", 12)] long sv_07
    );


/// <summary>
/// 투자자매매종합2: t1617
/// </summary>
/// <param name="gubun1">시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)	string	1</param>
/// <param name="gubun2">수량금액구분(1:수량2:금액)	string	1</param>
/// <param name="gubun3">일자구분(1:시간대별2:일별)	string	1</param>
/// <param name="cts_date">CTSDATE(연속키값-일자)	string	8</param>
/// <param name="cts_time">CTSTIME(연속키값-시간)	string	8</param>
public record t1617InBlock(
    [BlockField("시장구분(1:코스피2:코스닥3:선물4:콜옵션5:풋옵션6:주식선물)", 1)] string gubun1,
    [BlockField("수량금액구분(1:수량2:금액)", 1)] string gubun2,
    [BlockField("일자구분(1:시간대별2:일별)", 1)] string gubun3,
    [BlockField("CTSDATE(연속키값-일자)", 8)] string cts_date,
    [BlockField("CTSTIME(연속키값-시간)", 8)] string cts_time
    );

/// <summary>
/// 투자자매매종합2: t1617
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
public record t1617OutBlock(
    [BlockField("CTSDATE", 8)] string cts_date,
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인순매수", 12)] long sv_08,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인순매수", 12)] long sv_17,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계순매수", 12)] long sv_18,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권순매수", 12)] long sv_01
    );

/// <summary>
/// 투자자매매종합2: t1617
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	8</param>
/// <param name="sv_08">개인	long	12</param>
/// <param name="sv_17">외국인	long	12</param>
/// <param name="sv_18">기관계	long	12</param>
/// <param name="sv_01">증권	long	12</param>
public record t1617OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 8)] string time,
    [BlockField("개인", 12)] long sv_08,
    [BlockField("외국인", 12)] long sv_17,
    [BlockField("기관계", 12)] long sv_18,
    [BlockField("증권", 12)] long sv_01
    );


/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621
/// </summary>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="bgubun">전일분	string	1</param>
public record t1621InBlock(
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("N분", 2)] int nmin,
    [BlockField("조회건수", 3)] int cnt,
    [BlockField("전일분", 1)] string bgubun
    );

/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621
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
public record t1621OutBlock(
    [BlockField("개인투자자코드", 4)] string indcode,
    [BlockField("외국인투자자코드", 4)] string forcode,
    [BlockField("기관계투자자코드", 4)] string syscode,
    [BlockField("증권투자자코드", 4)] string stocode,
    [BlockField("투신투자자코드", 4)] string invcode,
    [BlockField("은행투자자코드", 4)] string bancode,
    [BlockField("보험투자자코드", 4)] string inscode,
    [BlockField("종금투자자코드", 4)] string fincode,
    [BlockField("기금투자자코드", 4)] string moncode,
    [BlockField("기타투자자코드", 4)] string etccode,
    [BlockField("국가투자자코드", 4)] string natcode,
    [BlockField("사모펀드투자자코드", 4)] string pefcode,
    [BlockField("기준지수코드", 8)] string jisucd,
    [BlockField("기준지수명", 20)] string jisunm
    );

/// <summary>
/// 업종별분별투자자매매동향(챠트용): t1621
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
public record t1621OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("일자시간", 14)] string datetime,
    [BlockField("개인순매수거래량", 8)] int indmsvol,
    [BlockField("개인순매수거래대금", 12)] double indmsamt,
    [BlockField("외국인순매수거래량", 8)] int formsvol,
    [BlockField("외국인순매수거래대금", 12)] double formsamt,
    [BlockField("기관계순매수거래량", 8)] int sysmsvol,
    [BlockField("기관계순매수거래대금", 12)] double sysmsamt,
    [BlockField("증권순매수거래량", 8)] int stomsvol,
    [BlockField("증권순매수거래대금", 12)] double stomsamt,
    [BlockField("투신순매수거래량", 8)] int invmsvol,
    [BlockField("투신순매수거래대금", 12)] double invmsamt,
    [BlockField("은행순매수거래량", 8)] int banmsvol,
    [BlockField("은행순매수거래대금", 12)] double banmsamt,
    [BlockField("보험순매수거래량", 8)] int insmsvol,
    [BlockField("보험순매수거래대금", 12)] double insmsamt,
    [BlockField("종금순매수거래량", 8)] int finmsvol,
    [BlockField("종금순매수거래대금", 12)] double finmsamt,
    [BlockField("기금순매수거래량", 8)] int monmsvol,
    [BlockField("기금순매수거래대금", 12)] double monmsamt,
    [BlockField("기타순매수거래량", 8)] int etcmsvol,
    [BlockField("기타순매수거래대금", 12)] double etcmsamt,
    [BlockField("국가순매수거래량", 8)] int natmsvol,
    [BlockField("국가순매수거래대금", 12)] double natmsamt,
    [BlockField("사모펀드순매수거래량", 8)] int pefmsvol,
    [BlockField("사모펀드순매수거래대금", 12)] double pefmsamt,
    [BlockField("기준지수", 6.2)] double upclose,
    [BlockField("기준체결거래량", 8)] int upcvolume,
    [BlockField("기준누적거래량", 12)] double upvolume,
    [BlockField("기준거래대금", 12)] double upvalue
    );


/// <summary>
/// 프로그램매매종합조회: t1631
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="dgubun">일자구분	string	1</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1631InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("일자구분", 1)] string dgubun,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate
    );

/// <summary>
/// 프로그램매매종합조회: t1631
/// </summary>
/// <param name="cdhrem">매도차익미체결잔량	int	8</param>
/// <param name="bdhrem">매도비차익미체결잔량	int	8</param>
/// <param name="tcdrem">매도차익주문수량	int	8</param>
/// <param name="tbdrem">매도비차익주문수량	int	8</param>
/// <param name="cshrem">매수차익미체결잔량	int	8</param>
/// <param name="bshrem">매수비차익미체결잔량	int	8</param>
/// <param name="tcsrem">매수차익주문수량	int	8</param>
/// <param name="tbsrem">매수비차익주문수량	int	8</param>
public record t1631OutBlock(
    [BlockField("매도차익미체결잔량", 8)] int cdhrem,
    [BlockField("매도비차익미체결잔량", 8)] int bdhrem,
    [BlockField("매도차익주문수량", 8)] int tcdrem,
    [BlockField("매도비차익주문수량", 8)] int tbdrem,
    [BlockField("매수차익미체결잔량", 8)] int cshrem,
    [BlockField("매수비차익미체결잔량", 8)] int bshrem,
    [BlockField("매수차익주문수량", 8)] int tcsrem,
    [BlockField("매수비차익주문수량", 8)] int tbsrem
    );

/// <summary>
/// 프로그램매매종합조회: t1631
/// </summary>
/// <param name="offervolume">매도수량	int	8</param>
/// <param name="offervalue">매도금액	long	12</param>
/// <param name="bidvolume">매수수량	int	8</param>
/// <param name="bidvalue">매수금액	long	12</param>
/// <param name="volume">순매수수량	int	8</param>
/// <param name="value">순매수금액	long	12</param>
public record t1631OutBlock1(
    [BlockField("매도수량", 8)] int offervolume,
    [BlockField("매도금액", 12)] long offervalue,
    [BlockField("매수수량", 8)] int bidvolume,
    [BlockField("매수금액", 12)] long bidvalue,
    [BlockField("순매수수량", 8)] int volume,
    [BlockField("순매수금액", 12)] long value
    );


/// <summary>
/// 시간대별프로그램매매추이: t1632
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">직전대비증감	string	1</param>
/// <param name="gubun3">전일구분	string	1</param>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
public record t1632InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("금액수량구분", 1)] string gubun1,
    [BlockField("직전대비증감", 1)] string gubun2,
    [BlockField("전일구분", 1)] string gubun3,
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time
    );

/// <summary>
/// 시간대별프로그램매매추이: t1632
/// </summary>
/// <param name="date">날짜CTS	string	8</param>
/// <param name="time">시간CTS	string	6</param>
/// <param name="idx">IDX	int	4</param>
public record t1632OutBlock(
    [BlockField("날짜CTS", 8)] string date,
    [BlockField("시간CTS", 6)] string time,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 시간대별프로그램매매추이: t1632
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
public record t1632OutBlock1(
    [BlockField("시간", 6)] string time,
    [BlockField("KP200", 6.2)] double k200jisu,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 6.2)] double change,
    [BlockField("BASIS", 6.2)] double k200basis,
    [BlockField("전체순매수", 12)] long tot3,
    [BlockField("전체매수", 12)] long tot1,
    [BlockField("전체매도", 12)] long tot2,
    [BlockField("차익순매수", 12)] long cha3,
    [BlockField("차익매수", 12)] long cha1,
    [BlockField("차익매도", 12)] long cha2,
    [BlockField("비차익순매수", 12)] long bcha3,
    [BlockField("비차익매수", 12)] long bcha1,
    [BlockField("비차익매도", 12)] long bcha2
    );


/// <summary>
/// 기간별프로그램매매추이: t1633
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">수치누적구분	string	1</param>
/// <param name="gubun3">일주월구분	string	1</param>
/// <param name="fdate">from일자	string	8</param>
/// <param name="tdate">to일자	string	8</param>
/// <param name="gubun4">직전대비증감구분	string	1</param>
/// <param name="date">날짜	string	8</param>
public record t1633InBlock(
    [BlockField("시장구분", 1)] string gubun,
    [BlockField("금액수량구분", 1)] string gubun1,
    [BlockField("수치누적구분", 1)] string gubun2,
    [BlockField("일주월구분", 1)] string gubun3,
    [BlockField("from일자", 8)] string fdate,
    [BlockField("to일자", 8)] string tdate,
    [BlockField("직전대비증감구분", 1)] string gubun4,
    [BlockField("날짜", 8)] string date
    );

/// <summary>
/// 기간별프로그램매매추이: t1633
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1633OutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 기간별프로그램매매추이: t1633
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
public record t1633OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("KP200", 6.2)] double jisu,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 6.2)] double change,
    [BlockField("전체순매수", 12)] long tot3,
    [BlockField("전체매수", 12)] long tot1,
    [BlockField("전체매도", 12)] long tot2,
    [BlockField("차익순매수", 12)] long cha3,
    [BlockField("차익매수", 12)] long cha1,
    [BlockField("차익매도", 12)] long cha2,
    [BlockField("비차익순매수", 12)] long bcha3,
    [BlockField("비차익매수", 12)] long bcha1,
    [BlockField("비차익매도", 12)] long bcha2,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 종목별프로그램매매동향: t1636
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun2">정렬기준	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1636InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("금액수량구분", 1)] string gubun1,
    [BlockField("정렬기준", 1)] string gubun2,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("IDXCTS", 4)] int cts_idx
    );

/// <summary>
/// 종목별프로그램매매동향: t1636
/// </summary>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1636OutBlock(
    [BlockField("IDXCTS", 4)] int cts_idx
    );

/// <summary>
/// 종목별프로그램매매동향: t1636
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
public record t1636OutBlock1(
    [BlockField("순위", 8)] int rank,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("순매수금액", 12)] long svalue,
    [BlockField("매도금액", 12)] long offervalue,
    [BlockField("매수금액", 12)] long stksvalue,
    [BlockField("순매수수량", 12)] long svolume,
    [BlockField("매도수량", 12)] long offervolume,
    [BlockField("매수수량", 12)] long stksvolume,
    [BlockField("시가총액", 15)] long sgta,
    [BlockField("비중", 6.2)] double rate,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 종목별프로그램매매추이: t1637
/// </summary>
/// <param name="gubun1">수량금액구분(0:수량1:금액)	string	1</param>
/// <param name="gubun2">시간일별구분(0:시간1:일자)	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">일자	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="cts_idx">IDXCTS(9999:차트)	int	4</param>
public record t1637InBlock(
    [BlockField("수량금액구분(0:수량1:금액)", 1)] string gubun1,
    [BlockField("시간일별구분(0:시간1:일자)", 1)] string gubun2,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("IDXCTS(9999:차트)", 4)] int cts_idx
    );

/// <summary>
/// 종목별프로그램매매추이: t1637
/// </summary>
/// <param name="cts_idx">IDXCTS	int	4</param>
public record t1637OutBlock(
    [BlockField("IDXCTS", 4)] int cts_idx
    );

/// <summary>
/// 종목별프로그램매매추이: t1637
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
public record t1637OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("현재가", 8)] int price,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("순매수금액", 15)] long svalue,
    [BlockField("매도금액", 15)] long offervalue,
    [BlockField("매수금액", 15)] long stksvalue,
    [BlockField("순매수수량", 12)] long svolume,
    [BlockField("매도수량", 12)] long offervolume,
    [BlockField("매수수량", 12)] long stksvolume,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 종목별잔량/사전공시: t1638
/// </summary>
/// <param name="gubun1">구분	string	1</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun2">정렬	string	1</param>
public record t1638InBlock(
    [BlockField("구분", 1)] string gubun1,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("정렬", 1)] string gubun2
    );

/// <summary>
/// 종목별잔량/사전공시: t1638
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
public record t1638OutBlock(
    [BlockField("순위", 4)] int rank,
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("시총비중", 6.2)] double sigatotrt,
    [BlockField("순매수잔량", 12)] long obuyvol,
    [BlockField("매수잔량", 12)] long buyrem,
    [BlockField("매수공시수량", 12)] long psgvolume,
    [BlockField("매도잔량", 12)] long sellrem,
    [BlockField("매도공시수량", 12)] long pdgvolume,
    [BlockField("시가총액", 20)] long sigatot,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 프로그램매매종합조회(미니): t1640
/// </summary>
/// <param name="gubun">구분	string	2</param>
public record t1640InBlock(
    [BlockField("구분", 2)] string gubun
    );

/// <summary>
/// 프로그램매매종합조회(미니): t1640
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
public record t1640OutBlock(
    [BlockField("매도수량", 8)] int offervolume,
    [BlockField("매수수량", 8)] int bidvolume,
    [BlockField("순매수수량", 8)] int volume,
    [BlockField("매도증감", 8)] int offerdiff,
    [BlockField("매수증감", 8)] int biddiff,
    [BlockField("순매수증감", 8)] int sundiff,
    [BlockField("베이시스", 6.2)] double basis,
    [BlockField("매도금액", 12)] double offervalue,
    [BlockField("매수금액", 12)] double bidvalue,
    [BlockField("순매수금액", 12)] double value,
    [BlockField("매도금액증감", 12)] double offervaldiff,
    [BlockField("매수금액증감", 12)] double bidvaldiff,
    [BlockField("순매수증감", 12)] double sunvaldiff
    );


/// <summary>
/// 시간대별프로그램매매추이(차트): t1662
/// </summary>
/// <param name="gubun">구분	string	1</param>
/// <param name="gubun1">금액수량구분	string	1</param>
/// <param name="gubun3">전일구분	string	1</param>
public record t1662InBlock(
    [BlockField("구분", 1)] string gubun,
    [BlockField("금액수량구분", 1)] string gubun1,
    [BlockField("전일구분", 1)] string gubun3
    );

/// <summary>
/// 시간대별프로그램매매추이(차트): t1662
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
public record t1662OutBlock(
    [BlockField("시간", 6)] string time,
    [BlockField("KP200", 6.2)] double k200jisu,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 6.2)] double change,
    [BlockField("BASIS", 6.2)] double k200basis,
    [BlockField("전체순매수", 12)] long tot3,
    [BlockField("전체매수", 12)] long tot1,
    [BlockField("전체매도", 12)] long tot2,
    [BlockField("차익순매수", 12)] long cha3,
    [BlockField("차익매수", 12)] long cha1,
    [BlockField("차익매도", 12)] long cha2,
    [BlockField("비차익순매수", 12)] long bcha3,
    [BlockField("비차익매수", 12)] long bcha1,
    [BlockField("비차익매도", 12)] long bcha2,
    [BlockField("거래량", 12)] long volume
    );


/// <summary>
/// 투자자매매종합(챠트): t1664
/// </summary>
/// <param name="mgubun">시장구분	string	1</param>
/// <param name="vagubun">금액수량구분	string	1</param>
/// <param name="bdgubun">시간일별구분	string	1</param>
/// <param name="cnt">조회건수	int	3</param>
public record t1664InBlock(
    [BlockField("시장구분", 1)] string mgubun,
    [BlockField("금액수량구분", 1)] string vagubun,
    [BlockField("시간일별구분", 1)] string bdgubun,
    [BlockField("조회건수", 3)] int cnt
    );

/// <summary>
/// 투자자매매종합(챠트): t1664
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
public record t1664OutBlock1(
    [BlockField("일자시간", 8)] string dt,
    [BlockField("증권순매수", 12)] double tjj01,
    [BlockField("보험순매수", 12)] double tjj02,
    [BlockField("투신순매수", 12)] double tjj03,
    [BlockField("은행순매수", 12)] double tjj04,
    [BlockField("종금순매수", 12)] double tjj05,
    [BlockField("기금순매수", 12)] double tjj06,
    [BlockField("기타순매수", 12)] double tjj07,
    [BlockField("개인순매수", 12)] double tjj08,
    [BlockField("외국인순매수", 12)] double tjj17,
    [BlockField("기관순매수", 12)] double tjj18,
    [BlockField("차익순매수", 12)] double cha,
    [BlockField("비차익순매수", 12)] double bicha,
    [BlockField("종합순매수", 12)] double totcha,
    [BlockField("베이시스", 6.2)] double basis
    );


/// <summary>
/// 기간별투자자매매추이(챠트): t1665
/// </summary>
/// <param name="market">시장구분(1:kospi2:kp2003:kosdaq4:선물5:풋옵션6:콜옵션)	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun2">수치구분(1:수치2:누적)	string	1</param>
/// <param name="gubun3">단위구분(1:일2:주3:월)	string	1</param>
/// <param name="from_date">시작날짜	string	8</param>
/// <param name="to_date">종료날짜	string	8</param>
public record t1665InBlock(
    [BlockField("시장구분(1:kospi2:kp2003:kosdaq4:선물5:풋옵션6:콜옵션)", 1)] string market,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("수치구분(1:수치2:누적)", 1)] string gubun2,
    [BlockField("단위구분(1:일2:주3:월)", 1)] string gubun3,
    [BlockField("시작날짜", 8)] string from_date,
    [BlockField("종료날짜", 8)] string to_date
    );

/// <summary>
/// 기간별투자자매매추이(챠트): t1665
/// </summary>
/// <param name="mcode">시장코드	string	8</param>
/// <param name="mname">시장명	string	20</param>
public record t1665OutBlock(
    [BlockField("시장코드", 8)] string mcode,
    [BlockField("시장명", 20)] string mname
    );

/// <summary>
/// 기간별투자자매매추이(챠트): t1665
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
public record t1665OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("개인수량", 12)] long sv_08,
    [BlockField("외인계수량(등록+미등록)", 12)] long sv_17,
    [BlockField("기관계수량", 12)] long sv_18,
    [BlockField("증권수량", 12)] long sv_01,
    [BlockField("투신수량", 12)] long sv_03,
    [BlockField("은행수량", 12)] long sv_04,
    [BlockField("보험수량", 12)] long sv_02,
    [BlockField("종금수량", 12)] long sv_05,
    [BlockField("기금수량", 12)] long sv_06,
    [BlockField("기타수량", 12)] long sv_07,
    [BlockField("사모펀드수량", 12)] long sv_00,
    [BlockField("등록외국인수량", 12)] long sv_09,
    [BlockField("미등록외국인수량", 12)] long sv_10,
    [BlockField("국가수량", 12)] long sv_11,
    [BlockField("기타계수량(기타+국가)", 12)] long sv_99,
    [BlockField("개인금액", 12)] double sa_08,
    [BlockField("외인계금액(등록+미등록)", 12)] double sa_17,
    [BlockField("기관계금액", 12)] double sa_18,
    [BlockField("증권금액", 12)] double sa_01,
    [BlockField("투신금액", 12)] double sa_03,
    [BlockField("은행금액", 12)] double sa_04,
    [BlockField("보험금액", 12)] double sa_02,
    [BlockField("종금금액", 12)] double sa_05,
    [BlockField("기금금액", 12)] double sa_06,
    [BlockField("기타금액", 12)] double sa_07,
    [BlockField("사모펀드금액", 12)] double sa_00,
    [BlockField("등록외국인금액", 12)] double sa_09,
    [BlockField("미등록외국인금액", 12)] double sa_10,
    [BlockField("국가금액", 12)] double sa_11,
    [BlockField("기타계금액(기타+국가)", 12)] double sa_99,
    [BlockField("시장지수", 7.2)] double jisu
    );


/// <summary>
/// 외인기관종목별동향: t1702
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="todt">종료일자	string	8</param>
/// <param name="volvalgb">금액수량구분(0:금액1:수량2:단가)	string	1</param>
/// <param name="msmdgb">매수매도구분(0:순매수1:매수2:매도)	string	1</param>
/// <param name="cumulgb">누적구분(0:일간1:누적)	string	1</param>
/// <param name="cts_date">CTSDATE	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1702InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종료일자", 8)] string todt,
    [BlockField("금액수량구분(0:금액1:수량2:단가)", 1)] string volvalgb,
    [BlockField("매수매도구분(0:순매수1:매수2:매도)", 1)] string msmdgb,
    [BlockField("누적구분(0:일간1:누적)", 1)] string cumulgb,
    [BlockField("CTSDATE", 8)] string cts_date,
    [BlockField("CTSIDX", 4)] int cts_idx
    );

/// <summary>
/// 외인기관종목별동향: t1702
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cts_date">CTSDATE	string	8</param>
public record t1702OutBlock(
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("CTSDATE", 8)] string cts_date
    );

/// <summary>
/// 외인기관종목별동향: t1702
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
public record t1702OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("사모펀드", 12)] long amt0000,
    [BlockField("증권", 12)] long amt0001,
    [BlockField("보험", 12)] long amt0002,
    [BlockField("투신", 12)] long amt0003,
    [BlockField("은행", 12)] long amt0004,
    [BlockField("종금", 12)] long amt0005,
    [BlockField("기금", 12)] long amt0006,
    [BlockField("기타법인", 12)] long amt0007,
    [BlockField("개인", 12)] long amt0008,
    [BlockField("등록외국인", 12)] long amt0009,
    [BlockField("미등록외국인", 12)] long amt0010,
    [BlockField("국가외", 12)] long amt0011,
    [BlockField("기관", 12)] long amt0018,
    [BlockField("외인계(등록+미등록)", 12)] long amt0088,
    [BlockField("기타계(기타+국가)", 12)] long amt0099
    );


/// <summary>
/// 외인기관종목별동향: t1716
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	string	1</param>
/// <param name="fromdt">시작일자	string	8</param>
/// <param name="todt">종료일자	string	8</param>
/// <param name="prapp">PR감산적용율	int	3</param>
/// <param name="prgubun">PR적용구분(0:적용안함1:적용)	string	1</param>
/// <param name="orggubun">기관적용	string	1</param>
/// <param name="frggubun">외인적용	string	1</param>
public record t1716InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("구분(0:일간순매수1:기간누적순매수)", 1)] string gubun,
    [BlockField("시작일자", 8)] string fromdt,
    [BlockField("종료일자", 8)] string todt,
    [BlockField("PR감산적용율", 3)] int prapp,
    [BlockField("PR적용구분(0:적용안함1:적용)", 1)] string prgubun,
    [BlockField("기관적용", 1)] string orggubun,
    [BlockField("외인적용", 1)] string frggubun
    );

/// <summary>
/// 외인기관종목별동향: t1716
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
public record t1716OutBlock(
    [BlockField("일자", 8)] string date,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래소_개인", 12)] long krx_0008,
    [BlockField("거래소_기관", 12)] long krx_0018,
    [BlockField("거래소_외국인", 12)] long krx_0009,
    [BlockField("프로그램", 12)] long pgmvol,
    [BlockField("금감원_외인보유주식수", 12)] long fsc_listing,
    [BlockField("금감원_소진율", 6.2)] double fsc_sjrate,
    [BlockField("금감원_외국인", 12)] long fsc_0009,
    [BlockField("공매도수량", 12)] long gm_volume,
    [BlockField("공매도대금", 12)] long gm_value
    );


/// <summary>
/// 외인기관종목별동향: t1717
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">구분(0:일간순매수1:기간누적순매수)	string	1</param>
/// <param name="fromdt">시작일자(일간조회일경우는space)	string	8</param>
/// <param name="todt">종료일자	string	8</param>
public record t1717InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("구분(0:일간순매수1:기간누적순매수)", 1)] string gubun,
    [BlockField("시작일자(일간조회일경우는space)", 8)] string fromdt,
    [BlockField("종료일자", 8)] string todt
    );

/// <summary>
/// 외인기관종목별동향: t1717
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
public record t1717OutBlock(
    [BlockField("일자", 8)] string date,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("사모펀드(순매수량)", 12)] long tjj0000_vol,
    [BlockField("증권(순매수량)", 12)] long tjj0001_vol,
    [BlockField("보험(순매수량)", 12)] long tjj0002_vol,
    [BlockField("투신(순매수량)", 12)] long tjj0003_vol,
    [BlockField("은행(순매수량)", 12)] long tjj0004_vol,
    [BlockField("종금(순매수량)", 12)] long tjj0005_vol,
    [BlockField("기금(순매수량)", 12)] long tjj0006_vol,
    [BlockField("기타법인(순매수량)", 12)] long tjj0007_vol,
    [BlockField("개인(순매수량)", 12)] long tjj0008_vol,
    [BlockField("등록외국인(순매수량)", 12)] long tjj0009_vol,
    [BlockField("미등록외국인(순매수량)", 12)] long tjj0010_vol,
    [BlockField("국가외(순매수량)", 12)] long tjj0011_vol,
    [BlockField("기관(순매수량)", 12)] long tjj0018_vol,
    [BlockField("외인계(순매수량)(등록+미등록)", 12)] long tjj0016_vol,
    [BlockField("기타계(순매수량)(기타+국가)", 12)] long tjj0017_vol,
    [BlockField("사모펀드(단가)", 12)] long tjj0000_dan,
    [BlockField("증권(단가)", 12)] long tjj0001_dan,
    [BlockField("보험(단가)", 12)] long tjj0002_dan,
    [BlockField("투신(단가)", 12)] long tjj0003_dan,
    [BlockField("은행(단가)", 12)] long tjj0004_dan,
    [BlockField("종금(단가)", 12)] long tjj0005_dan,
    [BlockField("기금(단가)", 12)] long tjj0006_dan,
    [BlockField("기타법인(단가)", 12)] long tjj0007_dan,
    [BlockField("개인(단가)", 12)] long tjj0008_dan,
    [BlockField("등록외국인(단가)", 12)] long tjj0009_dan,
    [BlockField("미등록외국인(단가)", 12)] long tjj0010_dan,
    [BlockField("국가외(단가)", 12)] long tjj0011_dan,
    [BlockField("기관(단가)", 12)] long tjj0018_dan,
    [BlockField("외인계(단가)(등록+미등록)", 12)] long tjj0016_dan,
    [BlockField("기타계(단가)(기타+국가)", 12)] long tjj0017_dan
    );


/// <summary>
/// 종목별상위회원사: t1752
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="traddate1">조회날짜1	string	8</param>
/// <param name="traddate2">조회날짜2	string	8</param>
/// <param name="fwgubun1">외국계구분	string	1</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1752InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("조회날짜1", 8)] string traddate1,
    [BlockField("조회날짜2", 8)] string traddate2,
    [BlockField("외국계구분", 1)] string fwgubun1,
    [BlockField("CTSIDX", 4)] int cts_idx
    );

/// <summary>
/// 종목별상위회원사: t1752
/// </summary>
/// <param name="fwdvl">외국계매도	long	12</param>
/// <param name="fwsvl">외국계매수	long	12</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1752OutBlock(
    [BlockField("외국계매도", 12)] long fwdvl,
    [BlockField("외국계매수", 12)] long fwsvl,
    [BlockField("CTSIDX", 4)] int cts_idx
    );

/// <summary>
/// 종목별상위회원사: t1752
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
public record t1752OutBlock1(
    [BlockField("회원사", 20)] string tradname,
    [BlockField("매도수량", 12)] long tradmdvol,
    [BlockField("매수수량", 12)] long tradmsvol,
    [BlockField("순매수", 12)] long tradmssvol,
    [BlockField("창구거래", 12)] long wintrd,
    [BlockField("비중", 6.1)] double winrat,
    [BlockField("회원사코드", 3)] string tradno,
    [BlockField("외국계여부", 1)] string wgubun,
    [BlockField("순비중", 6.1)] double swinrat
    );


/// <summary>
/// 회원사리스트: t1764
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun1">구분1	string	1</param>
public record t1764InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("구분1", 1)] string gubun1
    );

/// <summary>
/// 회원사리스트: t1764
/// </summary>
/// <param name="rank">순위	int	4</param>
/// <param name="tradno">거래원번호	string	3</param>
/// <param name="tradname">거래원이름	string	20</param>
public record t1764OutBlock(
    [BlockField("순위", 4)] int rank,
    [BlockField("거래원번호", 3)] string tradno,
    [BlockField("거래원이름", 20)] string tradname
    );


/// <summary>
/// 종목별회원사추이: t1771
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="tradno">거래원코드	string	3</param>
/// <param name="gubun1">구분1	string	1</param>
/// <param name="traddate1">거래원날짜1	string	8</param>
/// <param name="traddate2">거래원날짜2	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">요청건수	int	3</param>
public record t1771InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("거래원코드", 3)] string tradno,
    [BlockField("구분1", 1)] string gubun1,
    [BlockField("거래원날짜1", 8)] string traddate1,
    [BlockField("거래원날짜2", 8)] string traddate2,
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("요청건수", 3)] int cnt
    );

/// <summary>
/// 종목별회원사추이: t1771
/// </summary>
/// <param name="cts_idx">CTSIDX	int	4</param>
public record t1771OutBlock(
    [BlockField("CTSIDX", 4)] int cts_idx
    );

/// <summary>
/// 종목별회원사추이: t1771
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
public record t1771OutBlock2(
    [BlockField("날짜", 8)] string traddate,
    [BlockField("시간", 8)] string tradtime,
    [BlockField("현재가", 8)] int price,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도", 12)] long tradmdcha,
    [BlockField("매수", 12)] long tradmscha,
    [BlockField("매도대금", 18)] long tradmdval,
    [BlockField("매수대금", 18)] long tradmsval,
    [BlockField("순매수", 12)] long tradmsscha,
    [BlockField("누적순매수", 12)] long tradmttvolume,
    [BlockField("평균단가", 8)] int tradavg,
    [BlockField("누적평균단가", 8)] int tradmttavg
    );


/// <summary>
/// 신호조회: t1809
/// </summary>
/// <param name="gubun">신호구분	string	1</param>
/// <param name="jmGb">종목구분	string	1</param>
/// <param name="jmcode">종목코드	string	6</param>
/// <param name="cts">NEXTKEY	string	30</param>
public record t1809InBlock(
    [BlockField("신호구분", 1)] string gubun,
    [BlockField("종목구분", 1)] string jmGb,
    [BlockField("종목코드", 6)] string jmcode,
    [BlockField("NEXTKEY", 30)] string cts
    );

/// <summary>
/// 신호조회: t1809
/// </summary>
/// <param name="cts">NEXTKEY	string	30</param>
public record t1809OutBlock(
    [BlockField("NEXTKEY", 30)] string cts
    );

/// <summary>
/// 신호조회: t1809
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
public record t1809OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("신호ID", 4)] string signal_id,
    [BlockField("신호명", 300)] string signal_desc,
    [BlockField("신호강도", 3)] string point,
    [BlockField("뉴스신호키워드", 40)] string keyword,
    [BlockField("신호별구분", 24)] string seq,
    [BlockField("신호구분", 2)] string gubun,
    [BlockField("신호종목", 6)] string jmcode,
    [BlockField("종목가격", 7)] int price,
    [BlockField("종목등락부호", 1)] string sign,
    [BlockField("대비등락율", 6.2)] double chgrate,
    [BlockField("거래량", 9)] long volume,
    [BlockField("신호일시", 16)] string datetime
    );


/// <summary>
/// 종목Q클릭검색(씽큐스마트): t1825
/// </summary>
/// <param name="search_cd">검색코드	string	4</param>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t1825InBlock(
    [BlockField("검색코드", 4)] string search_cd,
    [BlockField("구분(0:전체1:코스피2:코스닥)", 1)] string gubun
    );

/// <summary>
/// 종목Q클릭검색(씽큐스마트): t1825
/// </summary>
/// <param name="JongCnt">검색종목수	int	4</param>
public record t1825OutBlock(
    [BlockField("검색종목수", 4)] int JongCnt
    );

/// <summary>
/// 종목Q클릭검색(씽큐스마트): t1825
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
public record t1825OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("연속봉수", 3)] int signcnt,
    [BlockField("현재가", 9)] long close,
    [BlockField("전일대비", 9)] long change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 10)] long volume,
    [BlockField("거래량전일대비율", 6.2)] double volumerate
    );


/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트): t1826
/// </summary>
/// <param name="search_gb">검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)	string	1</param>
public record t1826InBlock(
    [BlockField("검색구분(0:핵심검색1:지표검색2:시세동향3:투자자동향)", 1)] string search_gb
    );

/// <summary>
/// 종목Q클릭검색리스트조회(씽큐스마트): t1826
/// </summary>
/// <param name="search_cd">검색코드	string	4</param>
/// <param name="search_nm">검색명	string	40</param>
public record t1826OutBlock(
    [BlockField("검색코드", 4)] string search_cd,
    [BlockField("검색명", 40)] string search_nm
    );


/// <summary>
/// e종목검색(신버전API용): t1857
/// </summary>
/// <param name="sRealFlag">실시간구분(0:조회 1:실시간)	string	1</param>
/// <param name="sSearchFlag">종목검색구분(F:파일 S:서버)	string	1</param>
/// <param name="query_index">종목검색입력값	string	256</param>
public record t1857InBlock(
    [BlockField("실시간구분(0:조회 1:실시간)", 1)] string sRealFlag,
    [BlockField("종목검색구분(F:파일 S:서버)", 1)] string sSearchFlag,
    [BlockField("종목검색입력값", 256)] string query_index
    );

/// <summary>
/// e종목검색(신버전API용): t1857
/// </summary>
/// <param name="result_count">검색종목수	int	5</param>
/// <param name="result_time">포착시간	string	6</param>
/// <param name="AlertNum">실시간키	string	11</param>
public record t1857OutBlock(
    [BlockField("검색종목수", 5)] int result_count,
    [BlockField("포착시간", 6)] string result_time,
    [BlockField("실시간키", 11)] string AlertNum
    );

/// <summary>
/// e종목검색(신버전API용): t1857
/// </summary>
/// <param name="shcode">종목코드	string	7</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="price">현재가	long	9</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	long	9</param>
/// <param name="diff">등락율	double	6</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="JobFlag">종목상태(N:진입 R:재진입 O:이탈)	string	1</param>
public record t1857OutBlock1(
    [BlockField("종목코드", 7)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("현재가", 9)] long price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 9)] long change,
    [BlockField("등락율", 6)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("종목상태(N:진입 R:재진입 O:이탈)", 1)] string JobFlag
    );


/// <summary>
/// 서버저장조건리스트조회(API): t1866
/// </summary>
/// <param name="user_id">로그인ID	string	8</param>
/// <param name="gb">조회구분	string	1</param>
/// <param name="group_name">그룹명	string	40</param>
/// <param name="cont">연속여부	string	1</param>
/// <param name="contkey">연속키	string	40</param>
public record t1866InBlock(
    [BlockField("로그인ID", 8)] string user_id,
    [BlockField("조회구분", 1)] string gb,
    [BlockField("그룹명", 40)] string group_name,
    [BlockField("연속여부", 1)] string cont,
    [BlockField("연속키", 40)] string contkey
    );

/// <summary>
/// 서버저장조건리스트조회(API): t1866
/// </summary>
/// <param name="result_count">저장조건수	int	5</param>
/// <param name="cont">연속여부	string	1</param>
/// <param name="contkey">연속키	string	40</param>
public record t1866OutBlock(
    [BlockField("저장조건수", 5)] int result_count,
    [BlockField("연속여부", 1)] string cont,
    [BlockField("연속키", 40)] string contkey
    );

/// <summary>
/// 서버저장조건리스트조회(API): t1866
/// </summary>
/// <param name="query_index">서버저장인덱스	string	12</param>
/// <param name="group_name">그룹명	string	40</param>
/// <param name="query_name">조건저장명	string	40</param>
public record t1866OutBlock1(
    [BlockField("서버저장인덱스", 12)] string query_index,
    [BlockField("그룹명", 40)] string group_name,
    [BlockField("조건저장명", 40)] string query_name
    );


/// <summary>
/// ETF현재가(시세)조회: t1901
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1901InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ETF현재가(시세)조회: t1901
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
public record t1901OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("가중평균", 8)] int avg,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("전일거래량", 12)] double jnilvolume,
    [BlockField("거래량차", 12)] long volumediff,
    [BlockField("시가", 8)] int open,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가", 8)] int high,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가", 8)] int low,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("52최고가", 8)] int high52w,
    [BlockField("52최고가일", 8)] string high52wdate,
    [BlockField("52최저가", 8)] int low52w,
    [BlockField("52최저가일", 8)] string low52wdate,
    [BlockField("소진율", 6.2)] double exhratio,
    [BlockField("외국인보유수량", 12)] double flmtvol,
    [BlockField("PER", 6.2)] double per,
    [BlockField("상장주식수(천)", 12)] long listing,
    [BlockField("증거금율", 8)] int jkrate,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("누적거래대금", 12)] long value,
    [BlockField("연중최고가", 8)] int highyear,
    [BlockField("연중최고일자", 8)] string highyeardate,
    [BlockField("연중최저가", 8)] int lowyear,
    [BlockField("연중최저일자", 8)] string lowyeardate,
    [BlockField("업종명", 20)] string upname,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("업종현재가", 7.2)] double upprice,
    [BlockField("업종전일비구분", 1)] string upsign,
    [BlockField("업종전일대비", 6.2)] double upchange,
    [BlockField("업종등락율", 6.2)] double updiff,
    [BlockField("선물최근월물명", 20)] string futname,
    [BlockField("선물최근월물코드", 8)] string futcode,
    [BlockField("선물현재가", 6.2)] double futprice,
    [BlockField("선물전일비구분", 1)] string futsign,
    [BlockField("선물전일대비", 6.2)] double futchange,
    [BlockField("선물등락율", 6.2)] double futdiff,
    [BlockField("NAV", 8.2)] double nav,
    [BlockField("NAV전일대비구분", 1)] string navsign,
    [BlockField("NAV전일대비", 8.2)] double navchange,
    [BlockField("NAV등락율", 6.2)] double navdiff,
    [BlockField("추적오차율", 6.2)] double cocrate,
    [BlockField("괴리율", 6.2)] double kasis,
    [BlockField("대용가", 10)] long subprice,
    [BlockField("매도증권사코드1", 6)] string offerno1,
    [BlockField("매수증권사코드1", 6)] string bidno1,
    [BlockField("총매도수량1", 8)] int dvol1,
    [BlockField("총매수수량1", 8)] int svol1,
    [BlockField("매도증감1", 8)] int dcha1,
    [BlockField("매수증감1", 8)] int scha1,
    [BlockField("매도비율1", 6.2)] double ddiff1,
    [BlockField("매수비율1", 6.2)] double sdiff1,
    [BlockField("매도증권사코드2", 6)] string offerno2,
    [BlockField("매수증권사코드2", 6)] string bidno2,
    [BlockField("총매도수량2", 8)] int dvol2,
    [BlockField("총매수수량2", 8)] int svol2,
    [BlockField("매도증감2", 8)] int dcha2,
    [BlockField("매수증감2", 8)] int scha2,
    [BlockField("매도비율2", 6.2)] double ddiff2,
    [BlockField("매수비율2", 6.2)] double sdiff2,
    [BlockField("매도증권사코드3", 6)] string offerno3,
    [BlockField("매수증권사코드3", 6)] string bidno3,
    [BlockField("총매도수량3", 8)] int dvol3,
    [BlockField("총매수수량3", 8)] int svol3,
    [BlockField("매도증감3", 8)] int dcha3,
    [BlockField("매수증감3", 8)] int scha3,
    [BlockField("매도비율3", 6.2)] double ddiff3,
    [BlockField("매수비율3", 6.2)] double sdiff3,
    [BlockField("매도증권사코드4", 6)] string offerno4,
    [BlockField("매수증권사코드4", 6)] string bidno4,
    [BlockField("총매도수량4", 8)] int dvol4,
    [BlockField("총매수수량4", 8)] int svol4,
    [BlockField("매도증감4", 8)] int dcha4,
    [BlockField("매수증감4", 8)] int scha4,
    [BlockField("매도비율4", 6.2)] double ddiff4,
    [BlockField("매수비율4", 6.2)] double sdiff4,
    [BlockField("매도증권사코드5", 6)] string offerno5,
    [BlockField("매수증권사코드5", 6)] string bidno5,
    [BlockField("총매도수량5", 8)] int dvol5,
    [BlockField("총매수수량5", 8)] int svol5,
    [BlockField("매도증감5", 8)] int dcha5,
    [BlockField("매수증감5", 8)] int scha5,
    [BlockField("매도비율5", 6.2)] double ddiff5,
    [BlockField("매수비율5", 6.2)] double sdiff5,
    [BlockField("외국계매도합계수량", 12)] long fwdvl,
    [BlockField("외국계매도직전대비", 12)] long ftradmdcha,
    [BlockField("외국계매도비율", 6.2)] double ftradmddiff,
    [BlockField("외국계매수합계수량", 12)] long fwsvl,
    [BlockField("외국계매수직전대비", 12)] long ftradmscha,
    [BlockField("외국계매수비율", 6.2)] double ftradmsdiff,
    [BlockField("참고지수명", 20)] string upname2,
    [BlockField("참고지수코드", 3)] string upcode2,
    [BlockField("참고지수현재가", 7.2)] double upprice2,
    [BlockField("전일NAV", 8.2)] double jnilnav,
    [BlockField("전일NAV전일대비구분", 1)] string jnilnavsign,
    [BlockField("전일NAV전일대비", 8.2)] double jnilnavchange,
    [BlockField("전일NAV등락율", 6.2)] double jnilnavdiff,
    [BlockField("순자산총액(억원)", 12)] long etftotcap,
    [BlockField("스프레드", 6.2)] double spread,
    [BlockField("레버리지", 2)] int leverage,
    [BlockField("과세구분", 1)] string taxgubun,
    [BlockField("운용사", 20)] string opcom_nmk,
    [BlockField("LP1", 20)] string lp_nm1,
    [BlockField("LP2", 20)] string lp_nm2,
    [BlockField("LP3", 20)] string lp_nm3,
    [BlockField("LP4", 20)] string lp_nm4,
    [BlockField("LP5", 20)] string lp_nm5,
    [BlockField("복제방법", 10)] string etf_cp,
    [BlockField("상품유형(Filler)", 10)] string etf_kind,
    [BlockField("VI발동해제", 10)] string vi_gubun,
    [BlockField("ETN상품분류", 20)] string etn_kind_cd,
    [BlockField("ETN만기일", 8)] string lastymd,
    [BlockField("ETN지급일", 8)] string payday,
    [BlockField("ETN최종거래일", 8)] string lastdate,
    [BlockField("ETN발행시장참가자", 20)] string issuernmk,
    [BlockField("ETN만기상환가격결정시작일", 8)] string last_sdate,
    [BlockField("ETN만기상환가격결정종료일", 8)] string last_edate,
    [BlockField("ETNLP보유수량", 12)] string lp_holdvol,
    [BlockField("상장일", 8)] string listdate,
    [BlockField("ETP상품구분코드", 1)] string etp_gb,
    [BlockField("ETN조기상환가능여부", 1)] string etn_elback_yn,
    [BlockField("최종결제", 2)] string settletype,
    [BlockField("지수자산분류코드(대분류)", 2)] string idx_asset_class1,
    [BlockField("ETF/ETN투자유의", 8)] string ty_text,
    [BlockField("추적수익률배수", 6.2)] double leverage2
    );


/// <summary>
/// ETF시간별추이: t1902
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="time">시간	string	6</param>
public record t1902InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("시간", 6)] string time
    );

/// <summary>
/// ETF시간별추이: t1902
/// </summary>
/// <param name="time">시간	string	6</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="upname">업종지수명	string	20</param>
public record t1902OutBlock(
    [BlockField("시간", 6)] string time,
    [BlockField("종목명", 20)] string hname,
    [BlockField("업종지수명", 20)] string upname
    );

/// <summary>
/// ETF시간별추이: t1902
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
public record t1902OutBlock1(
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
    [BlockField("전일대비율", 8.2)] double jirate
    );


/// <summary>
/// ETF일별추이: t1903
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="date">일자	string	8</param>
public record t1903InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("일자", 8)] string date
    );

/// <summary>
/// ETF일별추이: t1903
/// </summary>
/// <param name="date">일자	string	8</param>
/// <param name="hname">종목명	string	20</param>
/// <param name="upname">업종지수명	string	20</param>
public record t1903OutBlock(
    [BlockField("일자", 8)] string date,
    [BlockField("종목명", 20)] string hname,
    [BlockField("업종지수명", 20)] string upname
    );

/// <summary>
/// ETF일별추이: t1903
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
public record t1903OutBlock1(
    [BlockField("일자", 8)] string date,
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
    [BlockField("전일대비율", 8.2)] double jirate
    );


/// <summary>
/// ETF구성종목조회: t1904
/// </summary>
/// <param name="shcode">ETF단축코드	string	6</param>
/// <param name="date">PDF적용일자	string	8</param>
/// <param name="sgb">정렬기준(1:평가금액2:증권수)	string	1</param>
public record t1904InBlock(
    [BlockField("ETF단축코드", 6)] string shcode,
    [BlockField("PDF적용일자", 8)] string date,
    [BlockField("정렬기준(1:평가금액2:증권수)", 1)] string sgb
    );

/// <summary>
/// ETF구성종목조회: t1904
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
public record t1904OutBlock(
    [BlockField("당일구분", 1)] string chk_tday,
    [BlockField("PDF적용일자", 8)] string date,
    [BlockField("ETF현재가", 8)] int price,
    [BlockField("ETF전일대비구분", 1)] string sign,
    [BlockField("ETF전일대비", 8)] int change,
    [BlockField("ETF등락율", 6.2)] double diff,
    [BlockField("ETF누적거래량", 12)] long volume,
    [BlockField("NAV", 8.2)] double nav,
    [BlockField("NAV전일대비구분", 1)] string navsign,
    [BlockField("NAV전일대비", 8.2)] double navchange,
    [BlockField("NAV등락율", 6.2)] double navdiff,
    [BlockField("전일NAV", 8.2)] double jnilnav,
    [BlockField("전일NAV전일대비구분", 1)] string jnilnavsign,
    [BlockField("전일NAV전일대비", 8.2)] double jnilnavchange,
    [BlockField("전일NAV등락율", 6.2)] double jnilnavdiff,
    [BlockField("업종명", 20)] string upname,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("업종현재가", 7.2)] double upprice,
    [BlockField("업종전일비구분", 1)] string upsign,
    [BlockField("업종전일대비", 6.2)] double upchange,
    [BlockField("업종등락율", 6.2)] double updiff,
    [BlockField("선물최근월물명", 20)] string futname,
    [BlockField("선물최근월물코드", 8)] string futcode,
    [BlockField("선물현재가", 6.2)] double futprice,
    [BlockField("선물전일비구분", 1)] string futsign,
    [BlockField("선물전일대비", 6.2)] double futchange,
    [BlockField("선물등락율", 6.2)] double futdiff,
    [BlockField("참고지수명", 20)] string upname2,
    [BlockField("참고지수코드", 3)] string upcode2,
    [BlockField("참고지수현재가", 7.2)] double upprice2,
    [BlockField("순자산총액(단위:억)", 12)] long etftotcap,
    [BlockField("구성종목수", 4)] int etfnum,
    [BlockField("CU주식수", 12)] long etfcunum,
    [BlockField("현금", 12)] long cash,
    [BlockField("운용사명", 20)] string opcom_nmk,
    [BlockField("전종목평가금액합", 12)] long tot_pval,
    [BlockField("전종목구성시가총액합", 12)] long tot_sigatval
    );

/// <summary>
/// ETF구성종목조회: t1904
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
public record t1904OutBlock1(
    [BlockField("단축코드", 12)] string shcode,
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("거래대금(백만)", 12)] long value,
    [BlockField("단위증권수(계약수/원화현금/USD현금/창고증권)", 12)] long icux,
    [BlockField("액면금액/설정현금액", 12)] long parprice,
    [BlockField("평가금액", 12)] long pvalue,
    [BlockField("구성시가총액", 12)] long sigatvalue,
    [BlockField("PDF적용일자", 8)] string profitdate,
    [BlockField("비중(평가금액)", 6.2)] double weight,
    [BlockField("ETF종목과등락차", 6.2)] double diff2
    );


/// <summary>
/// ETFLP호가: t1906
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1906InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ETFLP호가: t1906
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
public record t1906OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("LP매도호가수량1", 12)] long lp_offerrem1,
    [BlockField("LP매수호가수량1", 12)] long lp_bidrem1,
    [BlockField("LP매도호가수량2", 12)] long lp_offerrem2,
    [BlockField("LP매수호가수량2", 12)] long lp_bidrem2,
    [BlockField("LP매도호가수량3", 12)] long lp_offerrem3,
    [BlockField("LP매수호가수량3", 12)] long lp_bidrem3,
    [BlockField("LP매도호가수량4", 12)] long lp_offerrem4,
    [BlockField("LP매수호가수량4", 12)] long lp_bidrem4,
    [BlockField("LP매도호가수량5", 12)] long lp_offerrem5,
    [BlockField("LP매수호가수량5", 12)] long lp_bidrem5,
    [BlockField("LP매도호가수량6", 12)] long lp_offerrem6,
    [BlockField("LP매수호가수량6", 12)] long lp_bidrem6,
    [BlockField("LP매도호가수량7", 12)] long lp_offerrem7,
    [BlockField("LP매수호가수량7", 12)] long lp_bidrem7,
    [BlockField("LP매도호가수량8", 12)] long lp_offerrem8,
    [BlockField("LP매수호가수량8", 12)] long lp_bidrem8,
    [BlockField("LP매도호가수량9", 12)] long lp_offerrem9,
    [BlockField("LP매수호가수량9", 12)] long lp_bidrem9,
    [BlockField("LP매도호가수량10", 12)] long lp_offerrem10,
    [BlockField("LP매수호가수량10", 12)] long lp_bidrem10,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("매도호가1", 8)] int offerho1,
    [BlockField("매수호가1", 8)] int bidho1,
    [BlockField("매도호가수량1", 12)] long offerrem1,
    [BlockField("매수호가수량1", 12)] long bidrem1,
    [BlockField("직전매도대비수량1", 12)] long preoffercha1,
    [BlockField("직전매수대비수량1", 12)] long prebidcha1,
    [BlockField("매도호가2", 8)] int offerho2,
    [BlockField("매수호가2", 8)] int bidho2,
    [BlockField("매도호가수량2", 12)] long offerrem2,
    [BlockField("매수호가수량2", 12)] long bidrem2,
    [BlockField("직전매도대비수량2", 12)] long preoffercha2,
    [BlockField("직전매수대비수량2", 12)] long prebidcha2,
    [BlockField("매도호가3", 8)] int offerho3,
    [BlockField("매수호가3", 8)] int bidho3,
    [BlockField("매도호가수량3", 12)] long offerrem3,
    [BlockField("매수호가수량3", 12)] long bidrem3,
    [BlockField("직전매도대비수량3", 12)] long preoffercha3,
    [BlockField("직전매수대비수량3", 12)] long prebidcha3,
    [BlockField("매도호가4", 8)] int offerho4,
    [BlockField("매수호가4", 8)] int bidho4,
    [BlockField("매도호가수량4", 12)] long offerrem4,
    [BlockField("매수호가수량4", 12)] long bidrem4,
    [BlockField("직전매도대비수량4", 12)] long preoffercha4,
    [BlockField("직전매수대비수량4", 12)] long prebidcha4,
    [BlockField("매도호가5", 8)] int offerho5,
    [BlockField("매수호가5", 8)] int bidho5,
    [BlockField("매도호가수량5", 12)] long offerrem5,
    [BlockField("매수호가수량5", 12)] long bidrem5,
    [BlockField("직전매도대비수량5", 12)] long preoffercha5,
    [BlockField("직전매수대비수량5", 12)] long prebidcha5,
    [BlockField("매도호가6", 8)] int offerho6,
    [BlockField("매수호가6", 8)] int bidho6,
    [BlockField("매도호가수량6", 12)] long offerrem6,
    [BlockField("매수호가수량6", 12)] long bidrem6,
    [BlockField("직전매도대비수량6", 12)] long preoffercha6,
    [BlockField("직전매수대비수량6", 12)] long prebidcha6,
    [BlockField("매도호가7", 8)] int offerho7,
    [BlockField("매수호가7", 8)] int bidho7,
    [BlockField("매도호가수량7", 12)] long offerrem7,
    [BlockField("매수호가수량7", 12)] long bidrem7,
    [BlockField("직전매도대비수량7", 12)] long preoffercha7,
    [BlockField("직전매수대비수량7", 12)] long prebidcha7,
    [BlockField("매도호가8", 8)] int offerho8,
    [BlockField("매수호가8", 8)] int bidho8,
    [BlockField("매도호가수량8", 12)] long offerrem8,
    [BlockField("매수호가수량8", 12)] long bidrem8,
    [BlockField("직전매도대비수량8", 12)] long preoffercha8,
    [BlockField("직전매수대비수량8", 12)] long prebidcha8,
    [BlockField("매도호가9", 8)] int offerho9,
    [BlockField("매수호가9", 8)] int bidho9,
    [BlockField("매도호가수량9", 12)] long offerrem9,
    [BlockField("매수호가수량9", 12)] long bidrem9,
    [BlockField("직전매도대비수량9", 12)] long preoffercha9,
    [BlockField("직전매수대비수량9", 12)] long prebidcha9,
    [BlockField("매도호가10", 8)] int offerho10,
    [BlockField("매수호가10", 8)] int bidho10,
    [BlockField("매도호가수량10", 12)] long offerrem10,
    [BlockField("매수호가수량10", 12)] long bidrem10,
    [BlockField("직전매도대비수량10", 12)] long preoffercha10,
    [BlockField("직전매수대비수량10", 12)] long prebidcha10,
    [BlockField("매도호가수량합", 12)] long offer,
    [BlockField("매수호가수량합", 12)] long bid,
    [BlockField("직전매도대비수량합", 12)] long preoffercha,
    [BlockField("직전매수대비수량합", 12)] long prebidcha,
    [BlockField("수신시간", 8)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] long yevolume,
    [BlockField("예상체결전일구분", 1)] string yesign,
    [BlockField("예상체결전일대비", 8)] int yechange,
    [BlockField("예상체결등락율", 6.2)] double yediff,
    [BlockField("시간외매도잔량", 12)] long tmoffer,
    [BlockField("시간외매수잔량", 12)] long tmbid,
    [BlockField("동시구분", 1)] string ho_status,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low
    );


/// <summary>
/// 신용거래동향: t1921
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="gubun">융자대주구분	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1921InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("융자대주구분", 1)] string gubun,
    [BlockField("날짜", 8)] string date,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 신용거래동향: t1921
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="date">날짜	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t1921OutBlock(
    [BlockField("CNT", 4)] int cnt,
    [BlockField("날짜", 8)] string date,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 신용거래동향: t1921
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
public record t1921OutBlock1(
    [BlockField("날짜", 8)] string mmdate,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int jchange,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("신규", 8)] int nvolume,
    [BlockField("상환", 8)] int svolume,
    [BlockField("잔고", 8)] int jvolume,
    [BlockField("금액", 8)] int price,
    [BlockField("대비", 8)] int change,
    [BlockField("공여율", 6.2)] double gyrate,
    [BlockField("잔고율", 6.2)] double jkrate,
    [BlockField("종목코드", 6)] string shcode
    );


/// <summary>
/// 종목별신용정보: t1926
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1926InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// 종목별신용정보: t1926
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
public record t1926OutBlock(
    [BlockField("융자신규수량", 8)] int ynvolume,
    [BlockField("융자상환수량", 8)] int ysvolume,
    [BlockField("융자잔고수량", 8)] int yjvolume,
    [BlockField("융자수량대비", 8)] int yvchange,
    [BlockField("융자공여율", 9.2)] double ygrate,
    [BlockField("융자잔고율", 9.2)] double yjrate,
    [BlockField("융자신규금액", 8)] int ynprice,
    [BlockField("융자상환금액", 8)] int ysprice,
    [BlockField("융자잔고금액", 8)] int yjprice,
    [BlockField("융자금액대비", 8)] int yachange,
    [BlockField("대주신규수량", 8)] int dnvolume,
    [BlockField("대주상환수량", 8)] int dsvolume,
    [BlockField("대주잔고수량", 8)] int djvolume,
    [BlockField("대주수량대비", 8)] int dvchange,
    [BlockField("대주공여율", 9.2)] double dgrate,
    [BlockField("대주잔고율", 9.2)] double djrate,
    [BlockField("대주신규금액", 8)] int dnprice,
    [BlockField("대주상환금액", 8)] int dsprice,
    [BlockField("대주잔고금액", 8)] int djprice,
    [BlockField("대주금액대비", 8)] int dachange,
    [BlockField("결제일", 8)] string mmdate,
    [BlockField("결제일종가", 8)] int close,
    [BlockField("결제일거래량", 10)] long volume,
    [BlockField("결제일거래대금", 12)] long value,
    [BlockField("주가5일증가율", 9.2)] double pr5days,
    [BlockField("주가20일증가율", 9.2)] double pr20days,
    [BlockField("융자5일증가율", 9.2)] double yj5days,
    [BlockField("융자20일증가율", 9.2)] double yj20days,
    [BlockField("대주5일증가율", 9.2)] double dj5days,
    [BlockField("대주20일증가율", 9.2)] double dj20days
    );


/// <summary>
/// 공매도일별추이: t1927
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">일자	string	8</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1927InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("일자", 8)] string date,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate
    );

/// <summary>
/// 공매도일별추이: t1927
/// </summary>
/// <param name="date">일자CTS	string	8</param>
public record t1927OutBlock(
    [BlockField("일자CTS", 8)] string date
    );

/// <summary>
/// 공매도일별추이: t1927
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
public record t1927OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래대금", 12)] long value,
    [BlockField("공매도수량", 12)] long gm_vo,
    [BlockField("공매도대금", 12)] long gm_va,
    [BlockField("공매도거래비중", 6.2)] double gm_per,
    [BlockField("평균공매도단가", 12)] long gm_avg,
    [BlockField("누적공매도수량", 12)] long gm_vo_sum,
    [BlockField("업틱룰적용공매도수량", 12)] long gm_vo1,
    [BlockField("업틱룰적용공매도대금", 12)] long gm_va1,
    [BlockField("업틱룰예외공매도수량", 12)] long gm_vo2,
    [BlockField("업틱룰예외공매도대금", 12)] long gm_va2
    );


/// <summary>
/// 종목별대차거래일간추이: t1941
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
public record t1941InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate
    );

/// <summary>
/// 종목별대차거래일간추이: t1941
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
public record t1941OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("종가", 8)] int price,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("당일체결", 12)] long upvolume,
    [BlockField("당일상환", 12)] long dnvolume,
    [BlockField("당일잔고", 12)] long tovolume,
    [BlockField("잔고금액", 12)] long tovalue,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("대차증감", 12)] long tovoldif
    );


/// <summary>
/// ELW현재가(시세)조회: t1950
/// </summary>
/// <param name="shcode">ELW단축코드	string	6</param>
public record t1950InBlock(
    [BlockField("ELW단축코드", 6)] string shcode
    );

/// <summary>
/// ELW현재가(시세)조회: t1950
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
public record t1950OutBlock(
    [BlockField("한글명", 40)] string hname,
    [BlockField("체결시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결량", 10)] long cvolume,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("가중평균", 8)] int avg,
    [BlockField("전일거래량", 12)] double jnilvolume,
    [BlockField("전일동시간거래량", 12)] double jvolume,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("거래량차", 12)] double volumechg,
    [BlockField("거래량차등락율", 6.2)] double volumediff,
    [BlockField("시가", 8)] int open,
    [BlockField("시가등락율", 6.2)] double odiff,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가", 8)] int high,
    [BlockField("고가등락율", 6.2)] double hdiff,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가", 8)] int low,
    [BlockField("저가등락율", 6.2)] double ldiff,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("52최고가", 8)] int high52w,
    [BlockField("52최고가등락율", 6.2)] double high52wdiff,
    [BlockField("52최고가일", 8)] string high52wdate,
    [BlockField("52최저가", 8)] int low52w,
    [BlockField("52최저가등락율", 6.2)] double low52wdiff,
    [BlockField("52최저가일", 8)] string low52wdate,
    [BlockField("소진율", 6.2)] double exhratio,
    [BlockField("상장주식수(천)", 12)] double listing,
    [BlockField("수량단위", 5)] string memedan,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("패리티", 8.2)] double parity,
    [BlockField("손익분기", 8.2)] double berate,
    [BlockField("기어링", 8.2)] double gearing,
    [BlockField("행사가", 8.2)] double elwexec,
    [BlockField("발행가", 8)] int issueprice,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("자본지지", 8.2)] double capt,
    [BlockField("e.기어링", 8.2)] double egearing,
    [BlockField("프리미엄", 8.2)] double premium,
    [BlockField("스프레드", 6.2)] double spread,
    [BlockField("최대스프레드", 6.2)] double espread,
    [BlockField("이론가", 10.2)] double theoryprice,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("상태", 1)] string moneyness,
    [BlockField("델타", 8.6)] double delt,
    [BlockField("감마", 8.6)] double gama,
    [BlockField("베가", 13.6)] double vega,
    [BlockField("쎄타", 13.6)] double ceta,
    [BlockField("로", 13.6)] double rhox,
    [BlockField("잔존일수", 4)] int bjandatecnt,
    [BlockField("행사개시일", 8)] string mmsdate,
    [BlockField("행사종료일", 8)] string mmedate,
    [BlockField("지급일", 8)] string payday,
    [BlockField("발행일", 8)] string listdate,
    [BlockField("LP회원사", 20)] string lpmem,
    [BlockField("LP보유수량", 12)] double lp_holdvol,
    [BlockField("기초자산코드", 6)] string bcode,
    [BlockField("기초자산구분", 1)] string bgubun,
    [BlockField("기초자산현재가", 8)] int bprice,
    [BlockField("기초자산전일비구분", 1)] string bsign,
    [BlockField("기초자산전일비", 8)] int bchange,
    [BlockField("기초자산등락율", 6.2)] double bdiff,
    [BlockField("기초자산거래량", 12)] double bvolume,
    [BlockField("락구분", 10)] string info1,
    [BlockField("관리/급등구분", 10)] string info2,
    [BlockField("정지/연장구분", 10)] string info3,
    [BlockField("투자/불성실구분", 12)] string info4,
    [BlockField("장구분", 10)] string janginfo,
    [BlockField("바스켓구분", 1)] string basketgb,
    [BlockField("바스켓갯수", 3)] int basketcnt,
    [BlockField("ELW권리행사방식", 2)] string elwtype,
    [BlockField("ELW결제방법", 2)] string settletype,
    [BlockField("LP사주문가능여부", 2)] string lpord,
    [BlockField("권리내용", 100)] string elwdetail,
    [BlockField("만기평가가격방식", 100)] string valuation
    );

/// <summary>
/// ELW현재가(시세)조회: t1950
/// </summary>
/// <param name="bskcode">기초자산코드	string	6</param>
/// <param name="bskbno">기초자산비율	int	3</param>
/// <param name="bskprice">기초자산현재가	int	8</param>
/// <param name="bsksign">기초자산전일비구분	string	1</param>
/// <param name="bskchange">기초자산전일비	int	8</param>
/// <param name="bskdiff">기초자산등락율	double	6.2</param>
/// <param name="bskvolume">기초자산거래량	double	12</param>
/// <param name="bskjnilclose">기초자산전일종가	int	8</param>
public record t1950OutBlock1(
    [BlockField("기초자산코드", 6)] string bskcode,
    [BlockField("기초자산비율", 3)] int bskbno,
    [BlockField("기초자산현재가", 8)] int bskprice,
    [BlockField("기초자산전일비구분", 1)] string bsksign,
    [BlockField("기초자산전일비", 8)] int bskchange,
    [BlockField("기초자산등락율", 6.2)] double bskdiff,
    [BlockField("기초자산거래량", 12)] double bskvolume,
    [BlockField("기초자산전일종가", 8)] int bskjnilclose
    );


/// <summary>
/// ELW시간대별체결조회: t1951
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="starttime">시작시간	string	4</param>
/// <param name="endtime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1951InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string starttime,
    [BlockField("종료시간", 4)] string endtime,
    [BlockField("시간CTS", 8)] string cts_time
    );

/// <summary>
/// ELW시간대별체결조회: t1951
/// </summary>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1951OutBlock(
    [BlockField("시간CTS", 8)] string cts_time
    );

/// <summary>
/// ELW시간대별체결조회: t1951
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
public record t1951OutBlock1(
    [BlockField("시간", 8)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 12)] long cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도체결수량", 12)] long mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 12)] long msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("순체결량", 12)] long revolume,
    [BlockField("순체결건수", 8)] int rechecnt
    );


/// <summary>
/// ELW일별주가: t1954
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cnt">건수	int	3</param>
public record t1954InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("날짜", 8)] string date,
    [BlockField("건수", 3)] int cnt
    );

/// <summary>
/// ELW일별주가: t1954
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="bsjgubun">기초자산구분	string	1</param>
/// <param name="bscode">기초자산코드(현물)	string	6</param>
/// <param name="bjcode">기초자산코드(지수)	string	3</param>
public record t1954OutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("기초자산구분", 1)] string bsjgubun,
    [BlockField("기초자산코드(현물)", 6)] string bscode,
    [BlockField("기초자산코드(지수)", 3)] string bjcode
    );

/// <summary>
/// ELW일별주가: t1954
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
public record t1954OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] double volume,
    [BlockField("기초자산(현물)", 8)] int bsprice,
    [BlockField("기초자산(지수)", 8.2)] double bjprice,
    [BlockField("전일대비구분", 1)] string bsign,
    [BlockField("전일대비(현물)", 8)] int bschange,
    [BlockField("전일대비(지수)", 8.2)] double bjchange,
    [BlockField("등락율", 6.2)] double bdiff,
    [BlockField("기초자산거래량", 12)] double bvolume,
    [BlockField("패리티", 6.2)] double parity,
    [BlockField("e.기어링", 6.2)] double egearing,
    [BlockField("프리미엄", 6.2)] double premium,
    [BlockField("손익분기", 6.2)] double berate,
    [BlockField("자본지지", 6.2)] double capt,
    [BlockField("기어링", 6.2)] double gearing,
    [BlockField("Moneyness", 1)] string mness
    );


/// <summary>
/// ELW현재가(확정지급액)조회: t1956
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1956InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW현재가(확정지급액)조회: t1956
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
public record t1956OutBlock(
    [BlockField("한글명", 40)] string hname,
    [BlockField("체결시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결량", 10)] long cvolume,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("가중평균", 8)] int avg,
    [BlockField("전일거래량", 12)] double jnilvolume,
    [BlockField("전일동시간거래량", 12)] double jvolume,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("거래량차", 12)] double volumechg,
    [BlockField("거래량차등락율", 6.2)] double volumediff,
    [BlockField("시가", 8)] int open,
    [BlockField("시가등락율", 6.2)] double odiff,
    [BlockField("시가시간", 6)] string opentime,
    [BlockField("고가", 8)] int high,
    [BlockField("고가등락율", 6.2)] double hdiff,
    [BlockField("고가시간", 6)] string hightime,
    [BlockField("저가", 8)] int low,
    [BlockField("저가등락율", 6.2)] double ldiff,
    [BlockField("저가시간", 6)] string lowtime,
    [BlockField("52최고가", 8)] int high52w,
    [BlockField("52최고가등락율", 6.2)] double high52wdiff,
    [BlockField("52최고가일", 8)] string high52wdate,
    [BlockField("52최저가", 8)] int low52w,
    [BlockField("52최저가등락율", 6.2)] double low52wdiff,
    [BlockField("52최저가일", 8)] string low52wdate,
    [BlockField("소진율", 6.2)] double exhratio,
    [BlockField("상장주식수(천)", 12)] double listing,
    [BlockField("수량단위", 5)] string memedan,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("패리티", 8.2)] double parity,
    [BlockField("손익분기", 8.2)] double berate,
    [BlockField("기어링", 8.2)] double gearing,
    [BlockField("행사가", 8.2)] double elwexec,
    [BlockField("발행가", 8)] int issueprice,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("자본지지", 8.2)] double capt,
    [BlockField("e.기어링", 8.2)] double egearing,
    [BlockField("프리미엄", 8.2)] double premium,
    [BlockField("스프레드", 6.2)] double spread,
    [BlockField("최대스프레드", 6.2)] double espread,
    [BlockField("이론가", 10.2)] double theoryprice,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("상태", 1)] string moneyness,
    [BlockField("델타", 8.6)] double delt,
    [BlockField("감마", 8.6)] double gama,
    [BlockField("베가", 13.6)] double vega,
    [BlockField("쎄타", 13.6)] double ceta,
    [BlockField("로", 13.6)] double rhox,
    [BlockField("잔존일수", 4)] int bjandatecnt,
    [BlockField("행사개시일", 8)] string mmsdate,
    [BlockField("행사종료일", 8)] string mmedate,
    [BlockField("지급일", 8)] string payday,
    [BlockField("발행일", 8)] string listdate,
    [BlockField("LP회원사", 20)] string lpmem,
    [BlockField("LP보유수량", 12)] double lp_holdvol,
    [BlockField("기초자산코드", 6)] string bcode,
    [BlockField("기초자산구분", 1)] string bgubun,
    [BlockField("기초자산현재가", 8)] int bprice,
    [BlockField("기초자산전일비구분", 1)] string bsign,
    [BlockField("기초자산전일비", 8)] int bchange,
    [BlockField("기초자산등락율", 6.2)] double bdiff,
    [BlockField("기초자산거래량", 12)] double bvolume,
    [BlockField("락구분", 10)] string info1,
    [BlockField("관리/급등구분", 10)] string info2,
    [BlockField("정지/연장구분", 10)] string info3,
    [BlockField("투자/불성실구분", 12)] string info4,
    [BlockField("장구분", 10)] string janginfo,
    [BlockField("바스켓구분", 1)] string basketgb,
    [BlockField("바스켓갯수", 3)] int basketcnt,
    [BlockField("ELW권리행사방식", 2)] string elwtype,
    [BlockField("ELW결제방법", 2)] string settletype,
    [BlockField("LP사주문가능여부", 2)] string lpord,
    [BlockField("권리내용", 100)] string elwdetail,
    [BlockField("만기평가가격방식", 100)] string valuation,
    [BlockField("확정지급액", 8.3)] double givemoney
    );

/// <summary>
/// ELW현재가(확정지급액)조회: t1956
/// </summary>
/// <param name="bskcode">기초자산코드	string	6</param>
/// <param name="bskbno">기초자산비율	int	3</param>
/// <param name="bskprice">기초자산현재가	int	8</param>
/// <param name="bsksign">기초자산전일비구분	string	1</param>
/// <param name="bskchange">기초자산전일비	int	8</param>
/// <param name="bskdiff">기초자산등락율	double	6.2</param>
/// <param name="bskvolume">기초자산거래량	double	12</param>
/// <param name="bskjnilclose">기초자산전일종가	int	8</param>
public record t1956OutBlock1(
    [BlockField("기초자산코드", 6)] string bskcode,
    [BlockField("기초자산비율", 3)] int bskbno,
    [BlockField("기초자산현재가", 8)] int bskprice,
    [BlockField("기초자산전일비구분", 1)] string bsksign,
    [BlockField("기초자산전일비", 8)] int bskchange,
    [BlockField("기초자산등락율", 6.2)] double bskdiff,
    [BlockField("기초자산거래량", 12)] double bskvolume,
    [BlockField("기초자산전일종가", 8)] int bskjnilclose
    );


/// <summary>
/// ELW종목비교: t1958
/// </summary>
/// <param name="shcode1">종목코드1	string	6</param>
/// <param name="shcode2">종목코드2	string	6</param>
public record t1958InBlock(
    [BlockField("종목코드1", 6)] string shcode1,
    [BlockField("종목코드2", 6)] string shcode2
    );

/// <summary>
/// ELW종목비교: t1958
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
public record t1958OutBlock(
    [BlockField("종목명", 40)] string hname,
    [BlockField("기초자산", 12)] string item1,
    [BlockField("발행사", 40)] string issuernmk,
    [BlockField("콜풋구분", 2)] string elwopt,
    [BlockField("행사방식", 2)] string elwtype,
    [BlockField("결제방법", 2)] string settletype,
    [BlockField("행사가", 8.2)] double elwexec,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("발행수량", 12)] double listing,
    [BlockField("행사개시일", 8)] string mmsdate,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("거래잔존일수", 4)] int nofdays,
    [BlockField("지급일", 8)] string payday,
    [BlockField("패리티", 6.2)] double parity,
    [BlockField("프리미엄", 6.2)] double premium,
    [BlockField("손익분기", 6.2)] double berate,
    [BlockField("자본지지", 6.2)] double capt,
    [BlockField("기어링", 6.2)] double gearing,
    [BlockField("e.기어링", 6.2)] double egearing,
    [BlockField("가격", 8)] int price,
    [BlockField("거래량", 12)] double volume,
    [BlockField("등락율", 6.2)] double diff
    );

/// <summary>
/// ELW종목비교: t1958
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
public record t1958OutBlock1(
    [BlockField("종목명", 40)] string hname,
    [BlockField("기초자산", 12)] string item1,
    [BlockField("발행사", 40)] string issuernmk,
    [BlockField("콜풋구분", 2)] string elwopt,
    [BlockField("행사방식", 2)] string elwtype,
    [BlockField("결제방법", 2)] string settletype,
    [BlockField("행사가", 8.2)] double elwexec,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("발행수량", 12)] double listing,
    [BlockField("행사개시일", 8)] string mmsdate,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("거래잔존일수", 4)] int nofdays,
    [BlockField("지급일", 8)] string payday,
    [BlockField("패리티", 6.2)] double parity,
    [BlockField("프리미엄", 6.2)] double premium,
    [BlockField("손익분기", 6.2)] double berate,
    [BlockField("자본지지", 6.2)] double capt,
    [BlockField("기어링", 6.2)] double gearing,
    [BlockField("e.기어링", 6.2)] double egearing,
    [BlockField("가격", 8)] int price,
    [BlockField("거래량", 12)] double volume,
    [BlockField("등락율", 6.2)] double diff
    );

/// <summary>
/// ELW종목비교: t1958
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
public record t1958OutBlock2(
    [BlockField("종목명비교", 6)] string hnamecmp,
    [BlockField("기초자산비교", 6)] string item1cmp,
    [BlockField("발행사비교", 6)] string issuernmkcmp,
    [BlockField("콜풋구분비교", 6)] string elwoptcmp,
    [BlockField("행사방식비교", 6)] string elwtypecmp,
    [BlockField("결제방법비교", 6)] string settlecmp,
    [BlockField("행사가비교", 8.2)] double elwexeccmp,
    [BlockField("전환비율비교", 12.4)] double convcmp,
    [BlockField("발행수량비교", 12)] double listingcmp,
    [BlockField("행사개시일비교", 6)] string mmsdatecmp,
    [BlockField("최종거래일비교", 6)] string lastdatecmp,
    [BlockField("거래잔존일수비교", 6)] string nofdayscmp,
    [BlockField("지급일비교", 6)] string paydaycmp,
    [BlockField("패리티비교", 6.2)] double paritycmp,
    [BlockField("프리미엄비교", 6.2)] double premiumcmp,
    [BlockField("손익분기비교", 6.2)] double beratecmp,
    [BlockField("자본지지비교", 6.2)] double captcmp,
    [BlockField("기어링비교", 6.2)] double gearingcmp,
    [BlockField("e.기어링비교", 6.2)] double egearingcmp,
    [BlockField("가격비교", 8)] int pricecmp,
    [BlockField("거래량비교", 12)] double volumecmp,
    [BlockField("등락율비교", 6.2)] double diffcmp
    );


/// <summary>
/// LP대상종목정보조회: t1959
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1959InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// LP대상종목정보조회: t1959
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
public record t1959OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("현재가", 12)] string price,
    [BlockField("부호", 1)] string sign,
    [BlockField("대비", 12)] string change,
    [BlockField("등락율", 5.2)] double rate,
    [BlockField("누적거래량", 12)] string volume,
    [BlockField("누적거래대금", 12)] string value,
    [BlockField("LP주문가능여부", 4)] string lp_gb,
    [BlockField("LP회원사명1", 20)] string lp_mem_nm1,
    [BlockField("LP회원사명2", 20)] string lp_mem_nm2,
    [BlockField("LP회원사명3", 20)] string lp_mem_nm3,
    [BlockField("LP회원사명4", 20)] string lp_mem_nm4,
    [BlockField("LP회원사명5", 20)] string lp_mem_nm5,
    [BlockField("LP최소호가수량", 10)] string lp_min_qty,
    [BlockField("LP시작일", 8)] string lp_st_date,
    [BlockField("LP종료일", 8)] string lp_end_date,
    [BlockField("LP스프레드", 5.2)] double lp_spread
    );


/// <summary>
/// ELW등락율상위: t1960
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
public record t1960InBlock(
    [BlockField("상승하락(0:상승1:하락)", 1)] string gubun,
    [BlockField("권리유형구분(00:EX01:콜02:풋'':전체)", 2)] string ggubun,
    [BlockField("기초자산종목", 12)] string itemcode,
    [BlockField("조회만기일", 8)] string lastdate,
    [BlockField("대상제외", 6)] string exgubun,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("잔존시작일수", 8)] int sjanday,
    [BlockField("잔존종료일수", 8)] int ejanday,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW등락율상위: t1960
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1960OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW등락율상위: t1960
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
public record t1960OutBlock1(
    [BlockField("한글명", 40)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("행사가", 10.2)] double elwexec,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("만기일", 8)] string lastdate,
    [BlockField("기초자산종목코드", 12)] string itemcode,
    [BlockField("기초자산단축코드", 9)] string itemshcode,
    [BlockField("기초자산종목명", 20)] string itemname,
    [BlockField("기초자산현재가", 10)] string itemprice,
    [BlockField("기초자산대비구분", 1)] string itemsign,
    [BlockField("기초자산전일대비", 10)] string itemchange,
    [BlockField("기초자산등락율", 6.2)] double itemdiff,
    [BlockField("ELW종목코드", 6)] string elwshcode,
    [BlockField("손익분기점", 12.2)] double bepoint
    );


/// <summary>
/// ELW거래량상위: t1961
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
public record t1961InBlock(
    [BlockField("당일전일(0:당일1:전일)", 1)] string gubun,
    [BlockField("권리유형구분(00:EX01:콜02:풋'':전체)", 2)] string ggubun,
    [BlockField("기초자산종목", 12)] string itemcode,
    [BlockField("조회만기일", 8)] string lastdate,
    [BlockField("대상제외", 6)] string exgubun,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("잔존시작일수", 8)] int sjanday,
    [BlockField("잔존종료일수", 8)] int ejanday,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW거래량상위: t1961
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1961OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW거래량상위: t1961
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
public record t1961OutBlock1(
    [BlockField("한글명", 40)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("전일거래량", 12)] double jnilvolume,
    [BlockField("행사가", 10.2)] double elwexec,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("만기일", 8)] string lastdate,
    [BlockField("기초자산종목코드", 12)] string itemcode,
    [BlockField("기초자산단축코드", 9)] string itemshcode,
    [BlockField("기초자산종목명", 20)] string itemname,
    [BlockField("기초자산현재가", 10)] string itemprice,
    [BlockField("기초자산대비구분", 1)] string itemsign,
    [BlockField("기초자산전일대비", 10)] string itemchange,
    [BlockField("기초자산등락율", 6.2)] double itemdiff,
    [BlockField("ELW종목코드", 6)] string elwshcode
    );


/// <summary>
/// ELW전광판: t1964
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
public record t1964InBlock(
    [BlockField("기초자산코드", 12)] string item,
    [BlockField("발행사", 12)] string issuercd,
    [BlockField("만기월물", 6)] string lastmonth,
    [BlockField("콜풋구분", 1)] string elwopt,
    [BlockField("머니구분", 1)] string atmgubun,
    [BlockField("권리행사방식", 2)] string elwtype,
    [BlockField("결제방법", 2)] string settletype,
    [BlockField("행사기초자산구분", 1)] string elwexecgubun,
    [BlockField("시작비율", 5)] string fromrat,
    [BlockField("종료비율", 5)] string torat,
    [BlockField("거래량", 12)] string volume
    );

/// <summary>
/// ELW전광판: t1964
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
public record t1964OutBlock1(
    [BlockField("ELW코드", 6)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("기초자산코드", 6)] string item1,
    [BlockField("기초자산명", 20)] string itemnm,
    [BlockField("발행사", 40)] string issuernmk,
    [BlockField("콜풋구분", 4)] string elwopt,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("행사가", 10.2)] double elwexec,
    [BlockField("잔존일수", 8)] int jandatecnt,
    [BlockField("전환비율", 8.4)] double convrate,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("행사개시일", 8)] string mmsdate,
    [BlockField("지급일", 8)] string payday,
    [BlockField("발행수량", 8)] int listing,
    [BlockField("머니구분", 10)] string atmgbnm,
    [BlockField("패리티", 6.2)] double parity,
    [BlockField("프리미엄", 10.2)] double preminum,
    [BlockField("스프래드", 3.2)] double spread,
    [BlockField("손익분기율", 6.2)] double berate,
    [BlockField("자본지지율", 6.2)] double capt,
    [BlockField("기어링", 6.2)] double gearing,
    [BlockField("e기어링", 6.2)] double egearing,
    [BlockField("기초자산현재가", 8)] int itemprice,
    [BlockField("기초자산전일대비구분", 1)] string itemsign,
    [BlockField("기초자산전일대비", 8)] int itemchange,
    [BlockField("기초자산등락율", 6.2)] double itemdiff,
    [BlockField("기초자산거래량", 12)] long itemvolume,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("이론가", 10.2)] double theoryprice,
    [BlockField("LP보유비율", 5.2)] double lp_rate,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("델타", 10.6)] double delta,
    [BlockField("쎄타", 10.6)] double theta
    );


/// <summary>
/// ELW거래대금상위: t1966
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
public record t1966InBlock(
    [BlockField("당일전일(0:당일1:전일)", 1)] string gubun,
    [BlockField("권리유형구분(00:EX01:콜02:풋'':전체)", 2)] string ggubun,
    [BlockField("기초자산종목", 12)] string itemcode,
    [BlockField("조회만기일", 8)] string lastdate,
    [BlockField("대상제외", 6)] string exgubun,
    [BlockField("시작가격", 8)] int sprice,
    [BlockField("종료가격", 8)] int eprice,
    [BlockField("거래량", 12)] long volume,
    [BlockField("잔존시작일수", 8)] int sjanday,
    [BlockField("잔존종료일수", 8)] int ejanday,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW거래대금상위: t1966
/// </summary>
/// <param name="idx">IDX	int	4</param>
public record t1966OutBlock(
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// ELW거래대금상위: t1966
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
public record t1966OutBlock1(
    [BlockField("한글명", 40)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래대금", 12)] double value,
    [BlockField("전일거래대금", 12)] double jnilvalue,
    [BlockField("행사가", 10.2)] double elwexec,
    [BlockField("전환비율", 12.4)] double convrate,
    [BlockField("만기일", 8)] string lastdate,
    [BlockField("기초자산종목코드", 12)] string itemcode,
    [BlockField("기초자산단축코드", 9)] string itemshcode,
    [BlockField("기초자산종목명", 20)] string itemname,
    [BlockField("기초자산현재가", 10)] string itemprice,
    [BlockField("기초자산대비구분", 1)] string itemsign,
    [BlockField("기초자산전일대비", 10)] string itemchange,
    [BlockField("기초자산등락율", 6.2)] double itemdiff,
    [BlockField("ELW종목코드", 6)] string elwshcode
    );


/// <summary>
/// ELW지표검색: t1969
/// </summary>
/// <param name="chkitem">기초자산chk구분	string	1</param>
/// <param name="cbitem">기초자산코드	string	12</param>
/// <param name="chkissuer">발행사chk구분	string	1</param>
/// <param name="cbissuer">발행사	string	12</param>
/// <param name="chkcallput">권리chk구분	string	1</param>
/// <param name="cbcallput">권리(call:01.put:02)	string	2</param>
/// <param name="chkexec">행사가chk구분	string	1</param>
/// <param name="cbexec">행사가	string	1</param>
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
public record t1969InBlock(
    [BlockField("기초자산chk구분", 1)] string chkitem,
    [BlockField("기초자산코드", 12)] string cbitem,
    [BlockField("발행사chk구분", 1)] string chkissuer,
    [BlockField("발행사", 12)] string cbissuer,
    [BlockField("권리chk구분", 1)] string chkcallput,
    [BlockField("권리(call:01.put:02)", 2)] string cbcallput,
    [BlockField("행사가chk구분", 1)] string chkexec,
    [BlockField("행사가(>=:1.<=:2)", 1)] string cbexec,
    [BlockField("행사방식chk구분", 1)] string chktype,
    [BlockField("행사방식", 2)] string cbtype,
    [BlockField("결제방법chk구분", 1)] string chksettle,
    [BlockField("결제방법", 2)] string cbsettle,
    [BlockField("만기chk구분", 1)] string chklast,
    [BlockField("만기월별", 6)] string cblast,
    [BlockField("행사가격chk구분", 1)] string chkelwexec,
    [BlockField("행사가이상", 10.2)] double elwexecs,
    [BlockField("행사가이하", 10.2)] double elwexece,
    [BlockField("거래량chk구분", 1)] string chkvolume,
    [BlockField("거래량이상", 12)] double volumes,
    [BlockField("거래량이하", 12)] double volumee,
    [BlockField("등락율chk구분", 1)] string chkrate,
    [BlockField("등락율이상", 6.2)] double rates,
    [BlockField("등락율이하", 6.2)] double ratee,
    [BlockField("프리미엄chk구분", 1)] string chkpremium,
    [BlockField("프리미엄이상", 6.2)] double premiums,
    [BlockField("프리미엄이하", 6.2)] double premiume,
    [BlockField("패리티chk구분", 1)] string chkparity,
    [BlockField("패리티이상", 6.2)] double paritys,
    [BlockField("패리티이하", 6.2)] double paritye,
    [BlockField("손익분기chk구분", 1)] string chkberate,
    [BlockField("손익분기이상", 6.2)] double berates,
    [BlockField("손익분기이하", 6.2)] double beratee,
    [BlockField("자본지지chk구분", 1)] string chkcapt,
    [BlockField("자본지지이상", 6.2)] double capts,
    [BlockField("자본지지이하", 6.2)] double capte,
    [BlockField("e.기어링chk구분", 1)] string chkegearing,
    [BlockField("e.기어링이상", 6.2)] double egearings,
    [BlockField("e.기어링이하", 6.2)] double egearinge,
    [BlockField("기어링chk구분", 1)] string chkgearing,
    [BlockField("기어링이상", 6.2)] double gearings,
    [BlockField("기어링이하", 6.2)] double gearinge,
    [BlockField("델타chk구분", 1)] string chkdelta,
    [BlockField("델타이상", 10.6)] double deltas,
    [BlockField("델타이하", 10.6)] double deltae,
    [BlockField("쎄타chk구분", 1)] string chktheta,
    [BlockField("쎄타이상", 10.6)] double thetas,
    [BlockField("쎄타이하", 10.6)] double thetae,
    [BlockField("최종거래일chk구분", 1)] string chkduedate,
    [BlockField("최종거래일이상", 8)] string duedates,
    [BlockField("최종거래일이하", 8)] string duedatee,
    [BlockField("LP갭1틱", 1)] string onetickgubun,
    [BlockField("LP유동성공급", 1)] string lp_liquidity,
    [BlockField("LPchk구분", 1)] string chklp_code,
    [BlockField("LP회원사코드", 3)] string lp_code,
    [BlockField("조기종료chk구분", 1)] string chkkoba,
    [BlockField("조기종료(0:전체1:KOBA2:KOBA제외)", 1)] string cbkoba
    );

/// <summary>
/// ELW지표검색: t1969
/// </summary>
/// <param name="cnt">종목갯수	int	4</param>
public record t1969OutBlock(
    [BlockField("종목갯수", 4)] int cnt
    );

/// <summary>
/// ELW지표검색: t1969
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
public record t1969OutBlock1(
    [BlockField("종목명", 40)] string hname,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("발행사", 40)] string issuernmk,
    [BlockField("기초자산코드", 12)] string itemcode,
    [BlockField("콜/풋구분", 2)] string cpgubun,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] double volume,
    [BlockField("전일거래량", 12)] double jnilvolume,
    [BlockField("행사가", 10.2)] double elwexec,
    [BlockField("기초자산명", 20)] string item,
    [BlockField("기초자산가", 10.2)] double bprice,
    [BlockField("기초전일대비구분", 1)] string bsign,
    [BlockField("기초전일대비", 10.2)] double bchange,
    [BlockField("기초등락율", 6.2)] double bdiff,
    [BlockField("프리미엄", 6.2)] double premium,
    [BlockField("패리티", 6.2)] double parity,
    [BlockField("손익분기", 6.2)] double berate,
    [BlockField("자본지지", 6.2)] double capt,
    [BlockField("e.기어링", 6.2)] double egearing,
    [BlockField("기어링", 6.2)] double gearing,
    [BlockField("최종거래일", 8)] string lastdate,
    [BlockField("델타", 10.6)] double delta,
    [BlockField("쎄타", 10.6)] double theta,
    [BlockField("LP회원사", 40)] string lpname,
    [BlockField("LP보유율", 6.2)] double lphold,
    [BlockField("잔존일수", 4)] int bjandatecnt,
    [BlockField("전환비율", 8.4)] double convrate,
    [BlockField("1틱환산", 10.2)] double tickvalue,
    [BlockField("괴리율", 6.2)] double kasis
    );


/// <summary>
/// ELW현재가호가조회: t1971
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1971InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW현재가호가조회: t1971
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
public record t1971OutBlock(
    [BlockField("한글명", 40)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("매도호가1", 8)] int offerho1,
    [BlockField("매수호가1", 8)] int bidho1,
    [BlockField("매도호가수량1", 12)] long offerrem1,
    [BlockField("LP매도호가수량1", 12)] long lp_offerrem1,
    [BlockField("매수호가수량1", 12)] long bidrem1,
    [BlockField("LP매수호가수량1", 12)] long lp_bidrem1,
    [BlockField("직전매도대비수량1", 12)] long preoffercha1,
    [BlockField("직전매수대비수량1", 12)] long prebidcha1,
    [BlockField("매도호가2", 8)] int offerho2,
    [BlockField("매수호가2", 8)] int bidho2,
    [BlockField("매도호가수량2", 12)] long offerrem2,
    [BlockField("LP매도호가수량2", 12)] long lp_offerrem2,
    [BlockField("매수호가수량2", 12)] long bidrem2,
    [BlockField("LP매수호가수량2", 12)] long lp_bidrem2,
    [BlockField("직전매도대비수량2", 12)] long preoffercha2,
    [BlockField("직전매수대비수량2", 12)] long prebidcha2,
    [BlockField("매도호가3", 8)] int offerho3,
    [BlockField("매수호가3", 8)] int bidho3,
    [BlockField("매도호가수량3", 12)] long offerrem3,
    [BlockField("LP매도호가수량3", 12)] long lp_offerrem3,
    [BlockField("매수호가수량3", 12)] long bidrem3,
    [BlockField("LP매수호가수량3", 12)] long lp_bidrem3,
    [BlockField("직전매도대비수량3", 12)] long preoffercha3,
    [BlockField("직전매수대비수량3", 12)] long prebidcha3,
    [BlockField("매도호가4", 8)] int offerho4,
    [BlockField("매수호가4", 8)] int bidho4,
    [BlockField("매도호가수량4", 12)] long offerrem4,
    [BlockField("LP매도호가수량4", 12)] long lp_offerrem4,
    [BlockField("매수호가수량4", 12)] long bidrem4,
    [BlockField("LP매수호가수량4", 12)] long lp_bidrem4,
    [BlockField("직전매도대비수량4", 12)] long preoffercha4,
    [BlockField("직전매수대비수량4", 12)] long prebidcha4,
    [BlockField("매도호가5", 8)] int offerho5,
    [BlockField("매수호가5", 8)] int bidho5,
    [BlockField("매도호가수량5", 12)] long offerrem5,
    [BlockField("LP매도호가수량5", 12)] long lp_offerrem5,
    [BlockField("매수호가수량5", 12)] long bidrem5,
    [BlockField("LP매수호가수량5", 12)] long lp_bidrem5,
    [BlockField("직전매도대비수량5", 12)] long preoffercha5,
    [BlockField("직전매수대비수량5", 12)] long prebidcha5,
    [BlockField("매도호가6", 8)] int offerho6,
    [BlockField("매수호가6", 8)] int bidho6,
    [BlockField("매도호가수량6", 12)] long offerrem6,
    [BlockField("LP매도호가수량6", 12)] long lp_offerrem6,
    [BlockField("매수호가수량6", 12)] long bidrem6,
    [BlockField("LP매수호가수량6", 12)] long lp_bidrem6,
    [BlockField("직전매도대비수량6", 12)] long preoffercha6,
    [BlockField("직전매수대비수량6", 12)] long prebidcha6,
    [BlockField("매도호가7", 8)] int offerho7,
    [BlockField("매수호가7", 8)] int bidho7,
    [BlockField("매도호가수량7", 12)] long offerrem7,
    [BlockField("LP매도호가수량7", 12)] long lp_offerrem7,
    [BlockField("매수호가수량7", 12)] long bidrem7,
    [BlockField("LP매수호가수량7", 12)] long lp_bidrem7,
    [BlockField("직전매도대비수량7", 12)] long preoffercha7,
    [BlockField("직전매수대비수량7", 12)] long prebidcha7,
    [BlockField("매도호가8", 8)] int offerho8,
    [BlockField("매수호가8", 8)] int bidho8,
    [BlockField("매도호가수량8", 12)] long offerrem8,
    [BlockField("LP매도호가수량8", 12)] long lp_offerrem8,
    [BlockField("매수호가수량8", 12)] long bidrem8,
    [BlockField("LP매수호가수량8", 12)] long lp_bidrem8,
    [BlockField("직전매도대비수량8", 12)] long preoffercha8,
    [BlockField("직전매수대비수량8", 12)] long prebidcha8,
    [BlockField("매도호가9", 8)] int offerho9,
    [BlockField("매수호가9", 8)] int bidho9,
    [BlockField("매도호가수량9", 12)] long offerrem9,
    [BlockField("LP매도호가수량9", 12)] long lp_offerrem9,
    [BlockField("매수호가수량9", 12)] long bidrem9,
    [BlockField("LP매수호가수량9", 12)] long lp_bidrem9,
    [BlockField("직전매도대비수량9", 12)] long preoffercha9,
    [BlockField("직전매수대비수량9", 12)] long prebidcha9,
    [BlockField("매도호가10", 8)] int offerho10,
    [BlockField("매수호가10", 8)] int bidho10,
    [BlockField("매도호가수량10", 12)] long offerrem10,
    [BlockField("LP매도호가수량10", 12)] long lp_offerrem10,
    [BlockField("매수호가수량10", 12)] long bidrem10,
    [BlockField("LP매수호가수량10", 12)] long lp_bidrem10,
    [BlockField("직전매도대비수량10", 12)] long preoffercha10,
    [BlockField("직전매수대비수량10", 12)] long prebidcha10,
    [BlockField("매도호가수량합", 12)] long offer,
    [BlockField("매수호가수량합", 12)] long bid,
    [BlockField("직전매도대비수량합", 12)] long preoffercha,
    [BlockField("직전매수대비수량합", 12)] long prebidcha,
    [BlockField("수신시간", 8)] string hotime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결수량", 12)] double yevolume,
    [BlockField("예상체결전일구분", 1)] string yesign,
    [BlockField("예상체결전일대비", 8)] int yechange,
    [BlockField("예상체결등락율", 6.2)] double yediff,
    [BlockField("시간외매도잔량", 12)] long tmoffer,
    [BlockField("시간외매수잔량", 12)] long tmbid,
    [BlockField("동시구분", 1)] string ho_status,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("ELW권리형태(1:표준2:디지털3:조기종료)", 1)] string invidx,
    [BlockField("KO베리어", 12.2)] double koba_stdprc,
    [BlockField("KO접근도", 12.2)] double koba_acc_rt,
    [BlockField("KO발생여부(Y/N)", 1)] string koba_yn
    );


/// <summary>
/// ELW현재가(거래원)조회: t1972
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
public record t1972InBlock(
    [BlockField("단축코드", 6)] string shcode
    );

/// <summary>
/// ELW현재가(거래원)조회: t1972
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
public record t1972OutBlock(
    [BlockField("한글명", 40)] string hname,
    [BlockField("표준코드", 12)] string expcode,
    [BlockField("단축코드", 9)] string shcode,
    [BlockField("매도증권사코드1", 6)] string offerno1,
    [BlockField("매수증권사코드1", 6)] string bidno1,
    [BlockField("총매도수량1", 12)] long dvol1,
    [BlockField("총매수수량1", 12)] long svol1,
    [BlockField("매도증감1", 12)] long dcha1,
    [BlockField("매수증감1", 12)] long scha1,
    [BlockField("매도비율1", 6.2)] double ddiff1,
    [BlockField("매수비율1", 6.2)] double sdiff1,
    [BlockField("매도증권사코드2", 6)] string offerno2,
    [BlockField("매수증권사코드2", 6)] string bidno2,
    [BlockField("총매도수량2", 12)] long dvol2,
    [BlockField("총매수수량2", 12)] long svol2,
    [BlockField("매도증감2", 12)] long dcha2,
    [BlockField("매수증감2", 12)] long scha2,
    [BlockField("매도비율2", 6.2)] double ddiff2,
    [BlockField("매수비율2", 6.2)] double sdiff2,
    [BlockField("매도증권사코드3", 6)] string offerno3,
    [BlockField("매수증권사코드3", 6)] string bidno3,
    [BlockField("총매도수량3", 12)] long dvol3,
    [BlockField("총매수수량3", 12)] long svol3,
    [BlockField("매도증감3", 12)] long dcha3,
    [BlockField("매수증감3", 12)] long scha3,
    [BlockField("매도비율3", 6.2)] double ddiff3,
    [BlockField("매수비율3", 6.2)] double sdiff3,
    [BlockField("매도증권사코드4", 6)] string offerno4,
    [BlockField("매수증권사코드4", 6)] string bidno4,
    [BlockField("총매도수량4", 12)] long dvol4,
    [BlockField("총매수수량4", 12)] long svol4,
    [BlockField("매도증감4", 12)] long dcha4,
    [BlockField("매수증감4", 12)] long scha4,
    [BlockField("매도비율4", 6.2)] double ddiff4,
    [BlockField("매수비율4", 6.2)] double sdiff4,
    [BlockField("매도증권사코드5", 6)] string offerno5,
    [BlockField("매수증권사코드5", 6)] string bidno5,
    [BlockField("총매도수량5", 12)] long dvol5,
    [BlockField("총매수수량5", 12)] long svol5,
    [BlockField("매도증감5", 12)] long dcha5,
    [BlockField("매수증감5", 12)] long scha5,
    [BlockField("매도비율5", 6.2)] double ddiff5,
    [BlockField("매수비율5", 6.2)] double sdiff5,
    [BlockField("외국계매도합계수량", 12)] long fwdvl,
    [BlockField("외국계매수합계수량", 12)] long fwsvl,
    [BlockField("외국계매도직전대비", 12)] long ftradmdcha,
    [BlockField("외국계매수직전대비", 12)] long ftradmscha,
    [BlockField("외국계매도합계비율", 6.2)] double fwddiff,
    [BlockField("외국계매수합계비율", 6.2)] double fwsdiff
    );


/// <summary>
/// ELW시간대별예상체결조회: t1973
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1973InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("시간CTS", 8)] string cts_time
    );

/// <summary>
/// ELW시간대별예상체결조회: t1973
/// </summary>
/// <param name="cts_time">시간CTS	string	8</param>
public record t1973OutBlock(
    [BlockField("시간CTS", 8)] string cts_time
    );

/// <summary>
/// ELW시간대별예상체결조회: t1973
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
public record t1973OutBlock1(
    [BlockField("시간", 8)] string chetime,
    [BlockField("예상체결가격", 8)] int yeprice,
    [BlockField("예상체결구분", 1)] string yegubun,
    [BlockField("전일종가대비구분", 1)] string jnilysign,
    [BlockField("전일종가대비", 8)] int jnilychange,
    [BlockField("예상체결등락율", 6.2)] double yediff,
    [BlockField("예상체결량", 12)] long yevolume,
    [BlockField("예상매도체결량", 12)] long ymdvolume,
    [BlockField("예상매수체결량", 12)] long ymsvolume
    );


/// <summary>
/// ELW기초자산동일종목: t1974
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
public record t1974InBlock(
    [BlockField("종목코드", 6)] string shcode
    );

/// <summary>
/// ELW기초자산동일종목: t1974
/// </summary>
/// <param name="cnt">종목갯수	int	4</param>
public record t1974OutBlock(
    [BlockField("종목갯수", 4)] int cnt
    );

/// <summary>
/// ELW기초자산동일종목: t1974
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="hname">종목명	string	40</param>
/// <param name="cpgubun">콜/풋구분	string	2</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	double	12</param>
public record t1974OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("콜/풋구분", 2)] string cpgubun,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] double volume
    );


/// <summary>
/// 기초자산리스트조회: t1988
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
public record t1988InBlock(
    [BlockField("시장구분(0:전체1:코스피2:코스닥)", 1)] string mkt_gb,
    [BlockField("가격설정(0:전체1:조건설정)", 1)] string chk_price,
    [BlockField("가격1", 12)] string from_price,
    [BlockField("가격2", 12)] string to_price,
    [BlockField("거래량설정(0:전체1:조건설정)", 1)] string chk_vol,
    [BlockField("거래량1", 12)] string from_vol,
    [BlockField("거래량2", 12)] string to_vol,
    [BlockField("등락율설정(0:전체1:조건설정)", 1)] string chk_rate,
    [BlockField("등락율1", 5.2)] double from_rate,
    [BlockField("등락율2", 5.2)] double to_rate,
    [BlockField("거래대금설정(0:전체1:조건설정)", 1)] string chk_amt,
    [BlockField("거래대금1", 12)] string from_amt,
    [BlockField("거래대금2", 12)] string to_amt,
    [BlockField("양봉설정(0:전체1:조건설정)", 1)] string chk_up,
    [BlockField("음봉설정(0:전체1:조건설정)", 1)] string chk_down
    );

/// <summary>
/// 기초자산리스트조회: t1988
/// </summary>
/// <param name="ksp_cnt">코스피종목건수	string	4</param>
/// <param name="ksd_cnt">코스닥종목건수	string	4</param>
public record t1988OutBlock(
    [BlockField("코스피종목건수", 4)] string ksp_cnt,
    [BlockField("코스닥종목건수", 4)] string ksd_cnt
    );

/// <summary>
/// 기초자산리스트조회: t1988
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
public record t1988OutBlock1(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("표준코드", 12)] string expcode,
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 12)] string price,
    [BlockField("부호", 1)] string sign,
    [BlockField("대비", 12)] string change,
    [BlockField("등락율", 5.2)] double rate,
    [BlockField("누적거래량(주)", 12)] string volume,
    [BlockField("누적거래대금(백만)", 12)] string value,
    [BlockField("시장구분", 1)] string mkt_gb,
    [BlockField("전일동시간대거래량(주)", 12)] string jvolume
    );


/// <summary>
/// 선물/옵션현재가(시세)조회: t2101
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t2101InBlock(
    [BlockField("단축코드", 8)] string focode
    );

/// <summary>
/// 선물/옵션현재가(시세)조회: t2101
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
public record t2101OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래대금", 12)] long value,
    [BlockField("미결제량", 8)] int mgjv,
    [BlockField("미결제증감", 8)] int mgjvdiff,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("상한가", 6.2)] double uplmtprice,
    [BlockField("하한가", 6.2)] double dnlmtprice,
    [BlockField("52최고가", 6.2)] double high52w,
    [BlockField("52최저가", 6.2)] double low52w,
    [BlockField("베이시스", 6.2)] double basis,
    [BlockField("기준가", 6.2)] double recprice,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("괴리율", 6.3)] double glyl,
    [BlockField("CB상한가", 6.2)] double cbhprice,
    [BlockField("CB하한가", 6.2)] double cblprice,
    [BlockField("만기일", 8)] string lastmonth,
    [BlockField("잔여일", 8)] int jandatecnt,
    [BlockField("종합지수", 6.2)] double pricejisu,
    [BlockField("종합지수전일대비구분", 1)] string jisusign,
    [BlockField("종합지수전일대비", 6.2)] double jisuchange,
    [BlockField("종합지수등락율", 6.2)] double jisudiff,
    [BlockField("KOSPI200지수", 6.2)] double kospijisu,
    [BlockField("KOSPI200전일대비구분", 1)] string kospisign,
    [BlockField("KOSPI200전일대비", 6.2)] double kospichange,
    [BlockField("KOSPI200등락율", 6.2)] double kospidiff,
    [BlockField("상장최고가", 6.2)] double listhprice,
    [BlockField("상장최저가", 6.2)] double listlprice,
    [BlockField("델타", 6.4)] double delt,
    [BlockField("감마", 6.4)] double gama,
    [BlockField("세타", 6.4)] double ceta,
    [BlockField("베가", 6.4)] double vega,
    [BlockField("로우", 6.4)] double rhox,
    [BlockField("근월물현재가", 6.2)] double gmprice,
    [BlockField("근월물전일대비구분", 1)] string gmsign,
    [BlockField("근월물전일대비", 6.2)] double gmchange,
    [BlockField("근월물등락율", 6.2)] double gmdiff,
    [BlockField("이론가", 6.2)] double theorypriceg,
    [BlockField("역사적변동성", 6.2)] double histimpv,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("시장BASIS", 6.2)] double sbasis,
    [BlockField("이론BASIS", 6.2)] double ibasis,
    [BlockField("근월물종목코드", 8)] string gmfutcode,
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("거래소민감도수신시간", 6)] string greeks_time,
    [BlockField("거래소민감도확정여부", 8)] string greeks_confirm,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("예상체결가", 6.2)] double yeprice,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 6.2)] double jnilychange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate,
    [BlockField("배분구분(1:배분개시2:배분해제0:미발생)", 1)] string alloc_gubun,
    [BlockField("잔여일(영업일)", 8)] int bjandatecnt,
    [BlockField("종목코드", 8)] string focode,
    [BlockField("실시간가격제한여부(0:대상아님1:적용중2:미적용중3:일시해제)", 1)] string dy_gubun,
    [BlockField("실시간상한가", 6.2)] double dy_uplmtprice,
    [BlockField("실시간하한가", 6.2)] double dy_dnlmtprice,
    [BlockField("가격제한폭확대(0:미확대1:확대2:대상아님)", 1)] string updnstep_gubun,
    [BlockField("상한적용단계", 2)] string upstep,
    [BlockField("하한적용단계", 2)] string dnstep,
    [BlockField("3단계상한가", 6.2)] double uplmtprice_3rd,
    [BlockField("3단계하한가", 6.2)] double dnlmtprice_3rd
    );


/// <summary>
/// 선물/옵션현재가호가조회: t2105
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t2105InBlock(
    [BlockField("단축코드", 8)] string shcode
    );

/// <summary>
/// 선물/옵션현재가호가조회: t2105
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
public record t2105OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래량전일동시간비율", 6.2)] double stimeqrt,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("매도호가수량1", 8)] int offerrem1,
    [BlockField("매수호가수량1", 8)] int bidrem1,
    [BlockField("매도호가건수1", 8)] int dcnt1,
    [BlockField("매수호가건수1", 8)] int scnt1,
    [BlockField("매도호가2", 6.2)] double offerho2,
    [BlockField("매수호가2", 6.2)] double bidho2,
    [BlockField("매도호가수량2", 8)] int offerrem2,
    [BlockField("매수호가수량2", 8)] int bidrem2,
    [BlockField("매도호가건수2", 8)] int dcnt2,
    [BlockField("매수호가건수2", 8)] int scnt2,
    [BlockField("매도호가3", 6.2)] double offerho3,
    [BlockField("매수호가3", 6.2)] double bidho3,
    [BlockField("매도호가수량3", 8)] int offerrem3,
    [BlockField("매수호가수량3", 8)] int bidrem3,
    [BlockField("매도호가건수3", 8)] int dcnt3,
    [BlockField("매수호가건수3", 8)] int scnt3,
    [BlockField("매도호가4", 6.2)] double offerho4,
    [BlockField("매수호가4", 6.2)] double bidho4,
    [BlockField("매도호가수량4", 8)] int offerrem4,
    [BlockField("매수호가수량4", 8)] int bidrem4,
    [BlockField("매도호가건수4", 8)] int dcnt4,
    [BlockField("매수호가건수4", 8)] int scnt4,
    [BlockField("매도호가5", 6.2)] double offerho5,
    [BlockField("매수호가5", 6.2)] double bidho5,
    [BlockField("매도호가수량5", 8)] int offerrem5,
    [BlockField("매수호가수량5", 8)] int bidrem5,
    [BlockField("매도호가건수5", 8)] int dcnt5,
    [BlockField("매수호가건수5", 8)] int scnt5,
    [BlockField("매도호가총수량", 8)] int dvol,
    [BlockField("매수호가총수량", 8)] int svol,
    [BlockField("총매도호가건수", 8)] int toffernum,
    [BlockField("총매수호가건수", 8)] int tbidnum,
    [BlockField("수신시간", 6)] string time,
    [BlockField("단축코드", 8)] string shcode
    );


/// <summary>
/// 선물/옵션현재가시세메모: t2106
/// </summary>
/// <param name="code">종목코드	string	8</param>
/// <param name="nrec">건수	string	2</param>
public record t2106InBlock(
    [BlockField("종목코드", 8)] string code,
    [BlockField("건수", 2)] string nrec
    );

/// <summary>
/// 선물/옵션현재가시세메모: t2106
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="dat1">데이타1	string	1</param>
/// <param name="dat2">데이타2	string	8</param>
public record t2106InBlock1(
    [BlockField("인덱스", 1)] string indx,
    [BlockField("조건구분", 1)] string gubn,
    [BlockField("데이타1", 1)] string dat1,
    [BlockField("데이타2", 8)] string dat2
    );

/// <summary>
/// 선물/옵션현재가시세메모: t2106
/// </summary>
/// <param name="nrec">출력건수	string	2</param>
public record t2106OutBlock(
    [BlockField("출력건수", 2)] string nrec
    );

/// <summary>
/// 선물/옵션현재가시세메모: t2106
/// </summary>
/// <param name="indx">인덱스	string	1</param>
/// <param name="gubn">조건구분	string	1</param>
/// <param name="vals">출력값	string	8</param>
public record t2106OutBlock1(
    [BlockField("인덱스", 1)] string indx,
    [BlockField("조건구분", 1)] string gubn,
    [BlockField("출력값", 8)] string vals
    );


/// <summary>
/// 선물옵션시간대별체결조회: t2201
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2201InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string stime,
    [BlockField("종료시간", 4)] string etime,
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 선물옵션시간대별체결조회: t2201
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2201OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 선물옵션시간대별체결조회: t2201
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
public record t2201OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("매도호가", 6.2)] double offerho,
    [BlockField("매수호가", 6.2)] double bidho,
    [BlockField("거래량", 12)] double volume,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결전일증감", 8)] int jnilopenupdn,
    [BlockField("이론BASIS", 6.2)] double ibasis,
    [BlockField("시장BASIS", 6.2)] double sbasis,
    [BlockField("괴리율", 6.2)] double kasis,
    [BlockField("거래대금", 12)] double value,
    [BlockField("미결직전증감", 8)] int j_openupdn,
    [BlockField("누적매수체결량", 12)] double n_msvolume,
    [BlockField("누적매도체결량", 12)] double n_mdvolume,
    [BlockField("누적순매수체결량", 12)] double s_msvolume,
    [BlockField("누적매수체결건수", 8)] int n_mschecnt,
    [BlockField("누적매도체결건수", 8)] int n_mdchecnt,
    [BlockField("누적순매수체결건수", 8)] int s_mschecnt
    );


/// <summary>
/// 기간별주가: t2203
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t2203InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("선물최근월물", 1)] string futcheck,
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("조회요청건수", 3)] int cnt
    );

/// <summary>
/// 기간별주가: t2203
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t2203OutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("최근월선물여부", 1)] string nowfutyn
    );

/// <summary>
/// 기간별주가: t2203
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
public record t2203OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결증감", 8)] int openyakupdn,
    [BlockField("거래대금", 12)] double value
    );


/// <summary>
/// 선물옵션틱분별체결조회챠트: t2209
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t2209InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("챠트구분", 1)] string cgubun,
    [BlockField("분구분", 3)] int bgubun,
    [BlockField("조회건수", 3)] int cnt
    );

/// <summary>
/// 선물옵션틱분별체결조회챠트: t2209
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
public record t2209OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("거래량", 12)] double volume,
    [BlockField("거래대금", 12)] double value,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결증감", 8)] int openupdn,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("매수순간체결건수", 8)] int s_mschecnt,
    [BlockField("매도순간체결건수", 8)] int s_mdchecnt,
    [BlockField("순매수순간체결건수", 8)] int ss_mschecnt,
    [BlockField("매수순간체결량", 12)] double s_mschevol,
    [BlockField("매도순간체결량", 12)] double s_mdchevol,
    [BlockField("순매수순간체결량", 12)] double ss_mschevol,
    [BlockField("체결강도(거래량)", 8.2)] double chdegvol,
    [BlockField("체결강도(건수)", 8.2)] double chdegcnt
    );


/// <summary>
/// 선물옵션시간대별체결조회(단일출력용): t2210
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
public record t2210InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string stime,
    [BlockField("종료시간", 4)] string etime
    );

/// <summary>
/// 선물옵션시간대별체결조회(단일출력용): t2210
/// </summary>
/// <param name="mdvolume">매도체결수량	int	8</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	int	8</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
public record t2210OutBlock(
    [BlockField("매도체결수량", 8)] int mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 8)] int msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt
    );


/// <summary>
/// 옵션전광판: t2301
/// </summary>
/// <param name="yyyymm">월물	string	6</param>
/// <param name="gubun">미니구분(M:미니G:정규)	string	1</param>
public record t2301InBlock(
    [BlockField("월물", 6)] string yyyymm,
    [BlockField("미니구분(M:미니G:정규)", 1)] string gubun
    );

/// <summary>
/// 옵션전광판: t2301
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
public record t2301OutBlock(
    [BlockField("역사적변동성", 4)] int histimpv,
    [BlockField("옵션잔존일", 4)] int jandatecnt,
    [BlockField("콜옵션대표IV", 6.3)] double cimpv,
    [BlockField("풋옵션대표IV", 6.3)] double pimpv,
    [BlockField("근월물현재가", 6.2)] double gmprice,
    [BlockField("근월물전일대비구분", 1)] string gmsign,
    [BlockField("근월물전일대비", 6.2)] double gmchange,
    [BlockField("근월물등락율", 6.2)] double gmdiff,
    [BlockField("근월물거래량", 12)] long gmvolume,
    [BlockField("근월물선물코드", 8)] string gmshcode
    );

/// <summary>
/// 옵션전광판: t2301
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
public record t2301OutBlock1(
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("콜옵션코드", 8)] string optcode,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IV", 6.2)] double iv,
    [BlockField("미결제약정", 12)] long mgjv,
    [BlockField("미결제약정증감", 12)] long mgjvupdn,
    [BlockField("매도호가", 6.2)] double offerho1,
    [BlockField("매수호가", 6.2)] double bidho1,
    [BlockField("체결량", 12)] long cvolume,
    [BlockField("델타", 6.4)] double delt,
    [BlockField("감마", 6.4)] double gama,
    [BlockField("베가", 6.4)] double vega,
    [BlockField("쎄타", 6.4)] double ceta,
    [BlockField("로우", 6.4)] double rhox,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("내재가치", 6.2)] double impv,
    [BlockField("시간가치", 6.2)] double timevl,
    [BlockField("잔고수량", 12)] long jvolume,
    [BlockField("평가손익", 12)] long parpl,
    [BlockField("청산가능수량", 6)] int jngo,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("ATM구분", 1)] string atmgubun,
    [BlockField("지수환산", 6.2)] double jisuconv,
    [BlockField("거래대금", 12)] double value
    );

/// <summary>
/// 옵션전광판: t2301
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
public record t2301OutBlock2(
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("풋옵션코드", 8)] string optcode,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("IV", 6.2)] double iv,
    [BlockField("미결제약정", 12)] long mgjv,
    [BlockField("미결제약정증감", 12)] long mgjvupdn,
    [BlockField("매도호가", 6.2)] double offerho1,
    [BlockField("매수호가", 6.2)] double bidho1,
    [BlockField("체결량", 12)] long cvolume,
    [BlockField("델타", 6.4)] double delt,
    [BlockField("감마", 6.4)] double gama,
    [BlockField("베가", 6.4)] double vega,
    [BlockField("쎄타", 6.4)] double ceta,
    [BlockField("로우", 6.4)] double rhox,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("내재가치", 6.2)] double impv,
    [BlockField("시간가치", 6.2)] double timevl,
    [BlockField("잔고수량", 12)] long jvolume,
    [BlockField("평가손익", 12)] long parpl,
    [BlockField("청산가능수량", 6)] int jngo,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("ATM구분", 1)] string atmgubun,
    [BlockField("지수환산", 6.2)] double jisuconv,
    [BlockField("거래대금", 12)] double value
    );


/// <summary>
/// 선물옵션호가잔량비율챠트: t2405
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="bgubun">분구분	string	1</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="hgubun">호가구분	string	1</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="cts_time">시간CTS	string	6</param>
public record t2405InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("분구분", 1)] string bgubun,
    [BlockField("N분", 2)] int nmin,
    [BlockField("종료시간", 4)] string etime,
    [BlockField("호가구분", 1)] string hgubun,
    [BlockField("조회건수", 3)] int cnt,
    [BlockField("시간CTS", 6)] string cts_time
    );

/// <summary>
/// 선물옵션호가잔량비율챠트: t2405
/// </summary>
/// <param name="mdvolume">매도체결수량	double	12</param>
/// <param name="mdchecnt">매도체결건수	int	8</param>
/// <param name="msvolume">매수체결수량	double	12</param>
/// <param name="mschecnt">매수체결건수	int	8</param>
/// <param name="cts_time">시간CTS	string	6</param>
public record t2405OutBlock(
    [BlockField("매도체결수량", 12)] double mdvolume,
    [BlockField("매도체결건수", 8)] int mdchecnt,
    [BlockField("매수체결수량", 12)] double msvolume,
    [BlockField("매수체결건수", 8)] int mschecnt,
    [BlockField("시간CTS", 6)] string cts_time
    );

/// <summary>
/// 선물옵션호가잔량비율챠트: t2405
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
public record t2405OutBlock1(
    [BlockField("시간", 6)] string time,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("매도1호가", 6.2)] double offerho1,
    [BlockField("매수1호가", 6.2)] double bidho1,
    [BlockField("매도수량", 8)] int offerrem,
    [BlockField("매수수량", 8)] int bidrem,
    [BlockField("매도건수", 8)] int offercnt,
    [BlockField("매수건수", 8)] int bidcnt,
    [BlockField("매도증감수량", 8)] int c_offerrem,
    [BlockField("매수증감수량", 8)] int c_bidrem,
    [BlockField("매도증감건수", 8)] int c_offercnt,
    [BlockField("매수증감건수", 8)] int c_bidcnt,
    [BlockField("매수수량비율", 6.2)] double r_bidrem,
    [BlockField("매수건수비율", 6.2)] double r_bidcnt,
    [BlockField("매수비율구분", 1)] string r_sign,
    [BlockField("일자", 8)] string date
    );


/// <summary>
/// 미결제약정추이: t2421
/// </summary>
/// <param name="focode">종목코드	string	8</param>
/// <param name="bdgubun">분일구분	string	1</param>
/// <param name="nmin">N분	int	3</param>
/// <param name="tcgubun">당일연결구분	string	1</param>
/// <param name="cnt">조회건수	int	4</param>
public record t2421InBlock(
    [BlockField("종목코드", 8)] string focode,
    [BlockField("분일구분", 1)] string bdgubun,
    [BlockField("N분", 3)] int nmin,
    [BlockField("당일연결구분", 1)] string tcgubun,
    [BlockField("조회건수", 4)] int cnt
    );

/// <summary>
/// 미결제약정추이: t2421
/// </summary>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="cvolume">체결수량	int	8</param>
/// <param name="volume">누적거래량	double	15</param>
/// <param name="openyak">미결제수량	int	8</param>
public record t2421OutBlock(
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("누적거래량", 15)] double volume,
    [BlockField("미결제수량", 8)] int openyak
    );

/// <summary>
/// 미결제약정추이: t2421
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
public record t2421OutBlock1(
    [BlockField("일자시간", 14)] string dt,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("미결제시량", 8)] int openopenyak,
    [BlockField("미결제고량", 8)] int highopenyak,
    [BlockField("미결제저량", 8)] int lowopenyak,
    [BlockField("미결제종량", 8)] int closeopenyak,
    [BlockField("미결증감", 8)] int openupdn
    );


/// <summary>
/// 상품선물투자자매매동향(실시간): t2541
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="market">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="gubun1">수량구분	string	1</param>
/// <param name="gubun2">전일분구분	string	1</param>
/// <param name="cts_time">CTSTIME	string	8</param>
/// <param name="cts_idx">CTSIDX	int	4</param>
/// <param name="cnt">조회건수	int	4</param>
public record t2541InBlock(
    [BlockField("상품ID", 2)] string eitem,
    [BlockField("시장구분", 1)] string market,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("수량구분", 1)] string gubun1,
    [BlockField("전일분구분", 1)] string gubun2,
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("CTSIDX", 4)] int cts_idx,
    [BlockField("조회건수", 4)] int cnt
    );

/// <summary>
/// 상품선물투자자매매동향(실시간): t2541
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
public record t2541OutBlock(
    [BlockField("상품ID", 2)] string eitem,
    [BlockField("시장구분", 1)] string sgubun,
    [BlockField("CTSTIME", 8)] string cts_time,
    [BlockField("개인투자자코드", 4)] string tjjcode_08,
    [BlockField("개인매수", 12)] long ms_08,
    [BlockField("개인매도", 12)] long md_08,
    [BlockField("개인증감", 12)] long rate_08,
    [BlockField("개인순매수", 12)] long svolume_08,
    [BlockField("외국인투자자코드", 4)] string jjcode_17,
    [BlockField("외국인매수", 12)] long ms_17,
    [BlockField("외국인매도", 12)] long md_17,
    [BlockField("외국인증감", 12)] long rate_17,
    [BlockField("외국인순매수", 12)] long svolume_17,
    [BlockField("기관계투자자코드", 4)] string jjcode_18,
    [BlockField("기관계매수", 12)] long ms_18,
    [BlockField("기관계매도", 12)] long md_18,
    [BlockField("기관계증감", 12)] long rate_18,
    [BlockField("기관계순매수", 12)] long svolume_18,
    [BlockField("증권투자자코드", 4)] string jjcode_01,
    [BlockField("증권매수", 12)] long ms_01,
    [BlockField("증권매도", 12)] long md_01,
    [BlockField("증권증감", 12)] long rate_01,
    [BlockField("증권순매수", 12)] long svolume_01,
    [BlockField("투신투자자코드", 4)] string jjcode_03,
    [BlockField("투신매수", 12)] long ms_03,
    [BlockField("투신매도", 12)] long md_03,
    [BlockField("투신증감", 12)] long rate_03,
    [BlockField("투신순매수", 12)] long svolume_03,
    [BlockField("은행투자자코드", 4)] string jjcode_04,
    [BlockField("은행매수", 12)] long ms_04,
    [BlockField("은행매도", 12)] long md_04,
    [BlockField("은행증감", 12)] long rate_04,
    [BlockField("은행순매수", 12)] long svolume_04,
    [BlockField("보험투자자코드", 4)] string jjcode_02,
    [BlockField("보험매수", 12)] long ms_02,
    [BlockField("보험매도", 12)] long md_02,
    [BlockField("보험증감", 12)] long rate_02,
    [BlockField("보험순매수", 12)] long svolume_02,
    [BlockField("종금투자자코드", 4)] string jjcode_05,
    [BlockField("종금매수", 12)] long ms_05,
    [BlockField("종금매도", 12)] long md_05,
    [BlockField("종금증감", 12)] long rate_05,
    [BlockField("종금순매수", 12)] long svolume_05,
    [BlockField("기금투자자코드", 4)] string jjcode_06,
    [BlockField("기금매수", 12)] long ms_06,
    [BlockField("기금매도", 12)] long md_06,
    [BlockField("기금증감", 12)] long rate_06,
    [BlockField("기금순매수", 12)] long svolume_06,
    [BlockField("기타투자자코드", 4)] string jjcode_07,
    [BlockField("기타매수", 12)] long ms_07,
    [BlockField("기타매도", 12)] long md_07,
    [BlockField("기타증감", 12)] long rate_07,
    [BlockField("기타순매수", 12)] long svolume_07,
    [BlockField("국가투자자코드", 4)] string jjcode_11,
    [BlockField("국가매수", 12)] long ms_11,
    [BlockField("국가매도", 12)] long md_11,
    [BlockField("국가증감", 12)] long rate_11,
    [BlockField("국가순매수", 12)] long svolume_11,
    [BlockField("사모펀드코드", 4)] string jjcode_00,
    [BlockField("사모펀드매수", 12)] long ms_00,
    [BlockField("사모펀드매도", 12)] long md_00,
    [BlockField("사모펀드증감", 12)] long rate_00,
    [BlockField("사모펀드순매수", 12)] long svolume_00
    );

/// <summary>
/// 상품선물투자자매매동향(실시간): t2541
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
public record t2541OutBlock1(
    [BlockField("시간", 8)] string time,
    [BlockField("개인순매수", 12)] long sv_08,
    [BlockField("외국인순매수", 12)] long sv_17,
    [BlockField("기관계순매수", 12)] long sv_18,
    [BlockField("증권순매수", 12)] long sv_01,
    [BlockField("투신순매수", 12)] long sv_03,
    [BlockField("은행순매수", 12)] long sv_04,
    [BlockField("보험순매수", 12)] long sv_02,
    [BlockField("종금순매수", 12)] long sv_05,
    [BlockField("기금순매수", 12)] long sv_06,
    [BlockField("기타순매수", 12)] long sv_07,
    [BlockField("국가순매수", 12)] long sv_11,
    [BlockField("사모펀드순매수", 12)] long sv_00
    );


/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545
/// </summary>
/// <param name="eitem">상품ID	string	2</param>
/// <param name="sgubun">시장구분	string	1</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="nmin">N분	int	2</param>
/// <param name="cnt">조회건수	int	3</param>
/// <param name="bgubun">전일분	string	1</param>
public record t2545InBlock(
    [BlockField("상품ID", 2)] string eitem,
    [BlockField("시장구분", 1)] string sgubun,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("N분", 2)] int nmin,
    [BlockField("조회건수", 3)] int cnt,
    [BlockField("전일분", 1)] string bgubun
    );

/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545
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
public record t2545OutBlock(
    [BlockField("상품ID", 2)] string eitem,
    [BlockField("시장구분", 1)] string sgubun,
    [BlockField("개인투자자코드", 4)] string indcode,
    [BlockField("외국인투자자코드", 4)] string forcode,
    [BlockField("기관계투자자코드", 4)] string syscode,
    [BlockField("증권투자자코드", 4)] string stocode,
    [BlockField("투신투자자코드", 4)] string invcode,
    [BlockField("은행투자자코드", 4)] string bancode,
    [BlockField("보험투자자코드", 4)] string inscode,
    [BlockField("종금투자자코드", 4)] string fincode,
    [BlockField("기금투자자코드", 4)] string moncode,
    [BlockField("기타투자자코드", 4)] string etccode,
    [BlockField("국가투자자코드", 4)] string natcode,
    [BlockField("사모펀드투자자코드", 4)] string pefcode,
    [BlockField("기준지수코드", 8)] string jisucd,
    [BlockField("기준지수명", 20)] string jisunm
    );

/// <summary>
/// 상품선물투자자매매동향(챠트용): t2545
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
public record t2545OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("일자시간", 14)] string datetime,
    [BlockField("개인순매수거래량", 8)] int indmsvol,
    [BlockField("개인순매수거래대금", 12)] double indmsamt,
    [BlockField("외국인순매수거래량", 8)] int formsvol,
    [BlockField("외국인순매수거래대금", 12)] double formsamt,
    [BlockField("기관계순매수거래량", 8)] int sysmsvol,
    [BlockField("기관계순매수거래대금", 12)] double sysmsamt,
    [BlockField("증권순매수거래량", 8)] int stomsvol,
    [BlockField("증권순매수거래대금", 12)] double stomsamt,
    [BlockField("투신순매수거래량", 8)] int invmsvol,
    [BlockField("투신순매수거래대금", 12)] double invmsamt,
    [BlockField("은행순매수거래량", 8)] int banmsvol,
    [BlockField("은행순매수거래대금", 12)] double banmsamt,
    [BlockField("보험순매수거래량", 8)] int insmsvol,
    [BlockField("보험순매수거래대금", 12)] double insmsamt,
    [BlockField("종금순매수거래량", 8)] int finmsvol,
    [BlockField("종금순매수거래대금", 12)] double finmsamt,
    [BlockField("기금순매수거래량", 8)] int monmsvol,
    [BlockField("기금순매수거래대금", 12)] double monmsamt,
    [BlockField("기타순매수거래량", 8)] int etcmsvol,
    [BlockField("기타순매수거래대금", 12)] double etcmsamt,
    [BlockField("국가순매수거래량", 8)] int natmsvol,
    [BlockField("국가순매수거래대금", 12)] double natmsamt,
    [BlockField("사모펀드순매수거래량", 8)] int pefmsvol,
    [BlockField("사모펀드순매수거래대금", 12)] double pefmsamt,
    [BlockField("기준지수", 6.2)] double upclose,
    [BlockField("기준체결거래량", 8)] int upcvolume,
    [BlockField("기준누적거래량", 12)] double upvolume,
    [BlockField("기준거래대금", 12)] double upvalue
    );


/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회: t2830
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t2830InBlock(
    [BlockField("단축코드", 8)] string focode
    );

/// <summary>
/// EUREXKOSPI200옵션선물현재가(시세)조회: t2830
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
public record t2830OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래대금", 12)] long value,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("기준가", 6.2)] double recprice,
    [BlockField("이론가", 6.2)] double theoryprice,
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("내재가치", 6.2)] double impv,
    [BlockField("시간가치", 6.2)] double timevl,
    [BlockField("KOSPI200지수", 6.2)] double kospijisu,
    [BlockField("KOSPI200전일대비구분", 1)] string kospisign,
    [BlockField("KOSPI200전일대비", 6.2)] double kospichange,
    [BlockField("KOSPI200등락율", 6.2)] double kospidiff,
    [BlockField("CME야간선물현재가", 6.2)] double cmeprice,
    [BlockField("CME야간선물전일대비구분", 1)] string cmesign,
    [BlockField("CME야간선물전일대비", 6.2)] double cmechange,
    [BlockField("CME야간선물등락율", 6.2)] double cmediff,
    [BlockField("CME야간선물종목코드", 8)] string cmefocode,
    [BlockField("정규장적용상한가", 6.2)] double uplmtprice,
    [BlockField("정규장적용하한가", 6.2)] double dnlmtprice,
    [BlockField("단축코드", 8)] string focode,
    [BlockField("예상체결가", 6.2)] double yeprice,
    [BlockField("전일대비구분", 1)] string ysign,
    [BlockField("전일대비", 6.2)] double ychange,
    [BlockField("등락율", 6.2)] double ydiff,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("전일거래량", 12)] long jnilvolume,
    [BlockField("전일거래대금", 12)] long jnilvalue,
    [BlockField("정규장3단계상한가", 6.2)] double uplmtprice_3rd,
    [BlockField("정규장3단계하한가", 6.2)] double dnlmtprice_3rd
    );


/// <summary>
/// EUREXKOSPI200옵션선물호가조회: t2831
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t2831InBlock(
    [BlockField("단축코드", 8)] string shcode
    );

/// <summary>
/// EUREXKOSPI200옵션선물호가조회: t2831
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
public record t2831OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("매도호가1", 6.2)] double offerho1,
    [BlockField("매수호가1", 6.2)] double bidho1,
    [BlockField("매도호가수량1", 8)] int offerrem1,
    [BlockField("매수호가수량1", 8)] int bidrem1,
    [BlockField("매도호가건수1", 8)] int dcnt1,
    [BlockField("매수호가건수1", 8)] int scnt1,
    [BlockField("매도호가2", 6.2)] double offerho2,
    [BlockField("매수호가2", 6.2)] double bidho2,
    [BlockField("매도호가수량2", 8)] int offerrem2,
    [BlockField("매수호가수량2", 8)] int bidrem2,
    [BlockField("매도호가건수2", 8)] int dcnt2,
    [BlockField("매수호가건수2", 8)] int scnt2,
    [BlockField("매도호가3", 6.2)] double offerho3,
    [BlockField("매수호가3", 6.2)] double bidho3,
    [BlockField("매도호가수량3", 8)] int offerrem3,
    [BlockField("매수호가수량3", 8)] int bidrem3,
    [BlockField("매도호가건수3", 8)] int dcnt3,
    [BlockField("매수호가건수3", 8)] int scnt3,
    [BlockField("매도호가4", 6.2)] double offerho4,
    [BlockField("매수호가4", 6.2)] double bidho4,
    [BlockField("매도호가수량4", 8)] int offerrem4,
    [BlockField("매수호가수량4", 8)] int bidrem4,
    [BlockField("매도호가건수4", 8)] int dcnt4,
    [BlockField("매수호가건수4", 8)] int scnt4,
    [BlockField("매도호가5", 6.2)] double offerho5,
    [BlockField("매수호가5", 6.2)] double bidho5,
    [BlockField("매도호가수량5", 8)] int offerrem5,
    [BlockField("매수호가수량5", 8)] int bidrem5,
    [BlockField("매도호가건수5", 8)] int dcnt5,
    [BlockField("매수호가건수5", 8)] int scnt5,
    [BlockField("매도호가총수량", 8)] int dvol,
    [BlockField("매수호가총수량", 8)] int svol,
    [BlockField("총매도호가건수", 8)] int toffernum,
    [BlockField("총매수호가건수", 8)] int tbidnum,
    [BlockField("수신시간", 6)] string time,
    [BlockField("단축코드", 8)] string shcode
    );


/// <summary>
/// EUREX야간옵션선물시간대별체결조회: t2832
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2832InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string stime,
    [BlockField("종료시간", 4)] string etime,
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// EUREX야간옵션선물시간대별체결조회: t2832
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t2832OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// EUREX야간옵션선물시간대별체결조회: t2832
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
public record t2832OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("매도호가", 6.2)] double offerho,
    [BlockField("매수호가", 6.2)] double bidho,
    [BlockField("거래량", 12)] double volume,
    [BlockField("누적매수체결량", 12)] double n_msvolume,
    [BlockField("누적매도체결량", 12)] double n_mdvolume,
    [BlockField("누적순매수체결량", 12)] double s_msvolume,
    [BlockField("누적매수체결건수", 8)] int n_mschecnt,
    [BlockField("누적매도체결건수", 8)] int n_mdchecnt,
    [BlockField("누적순매수체결건수", 8)] int s_mschecnt
    );


/// <summary>
/// EUREX야간옵션선물기간별추이: t2833
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t2833InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("선물최근월물", 1)] string futcheck,
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("조회요청건수", 3)] int cnt
    );

/// <summary>
/// EUREX야간옵션선물기간별추이: t2833
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t2833OutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("최근월선물여부", 1)] string nowfutyn
    );

/// <summary>
/// EUREX야간옵션선물기간별추이: t2833
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
public record t2833OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol
    );


/// <summary>
/// EUREX옵션선물시세전광판: t2835
/// </summary>
/// <param name="yyyymm">월물(혹은주물WN)	string	6</param>
/// <param name="gubun">구분(G:원지수W:위클리)	string	1</param>
public record t2835InBlock(
    [BlockField("월물(혹은주물WN)", 6)] string yyyymm,
    [BlockField("구분(G:원지수W:위클리)", 1)] string gubun
    );

/// <summary>
/// EUREX옵션선물시세전광판: t2835
/// </summary>
/// <param name="gmprice">근월물현재가	double	6.2</param>
/// <param name="gmsign">근월물전일대비구분	string	1</param>
/// <param name="gmchange">근월물전일대비	double	6.2</param>
/// <param name="gmdiff">근월물등락율	double	6.2</param>
/// <param name="gmvolume">근월물거래량	long	12</param>
/// <param name="gmshcode">근월물선물코드	string	8</param>
public record t2835OutBlock(
    [BlockField("근월물현재가", 6.2)] double gmprice,
    [BlockField("근월물전일대비구분", 1)] string gmsign,
    [BlockField("근월물전일대비", 6.2)] double gmchange,
    [BlockField("근월물등락율", 6.2)] double gmdiff,
    [BlockField("근월물거래량", 12)] long gmvolume,
    [BlockField("근월물선물코드", 8)] string gmshcode
    );

/// <summary>
/// EUREX옵션선물시세전광판: t2835
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
public record t2835OutBlock1(
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("콜옵션코드", 8)] string optcode,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도호가", 6.2)] double offerho1,
    [BlockField("매수호가", 6.2)] double bidho1,
    [BlockField("체결량", 12)] long cvolume,
    [BlockField("내재가치", 6.2)] double impv,
    [BlockField("시간가치", 6.2)] double timevl,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("ATM구분", 1)] string atmgubun,
    [BlockField("지수환산", 6.2)] double jisuconv
    );

/// <summary>
/// EUREX옵션선물시세전광판: t2835
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
public record t2835OutBlock2(
    [BlockField("행사가", 6.2)] double actprice,
    [BlockField("풋옵션코드", 8)] string optcode,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("매도호가", 6.2)] double offerho1,
    [BlockField("매수호가", 6.2)] double bidho1,
    [BlockField("체결량", 12)] long cvolume,
    [BlockField("내재가치", 6.2)] double impv,
    [BlockField("시간가치", 6.2)] double timevl,
    [BlockField("매도잔량", 12)] long offerrem1,
    [BlockField("매수잔량", 12)] long bidrem1,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("ATM구분", 1)] string atmgubun,
    [BlockField("지수환산", 6.2)] double jisuconv
    );


/// <summary>
/// 뉴스본문: t3102
/// </summary>
/// <param name="sNewsno">뉴스번호	string	24</param>
public record t3102InBlock(
    [BlockField("뉴스번호", 24)] string sNewsno
    );

/// <summary>
/// 뉴스본문: t3102
/// </summary>
/// <param name="sJongcode">뉴스종목	string	6</param>
public record t3102OutBlock(
    [BlockField("뉴스종목", 6)] string sJongcode
    );

/// <summary>
/// 뉴스본문: t3102
/// </summary>
/// <param name="sBody">뉴스본문	string	100</param>
public record t3102OutBlock1(
    [BlockField("뉴스본문", 100)] string sBody
    );

/// <summary>
/// 뉴스본문: t3102
/// </summary>
/// <param name="sTitle">뉴스타이틀	string	300</param>
public record t3102OutBlock2(
    [BlockField("뉴스타이틀", 300)] string sTitle
    );


/// <summary>
/// 종목별증시일정: t3202
/// </summary>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="date">조회일자	string	8</param>
public record t3202InBlock(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("조회일자", 8)] string date
    );

/// <summary>
/// 종목별증시일정: t3202
/// </summary>
/// <param name="recdt">기준일	string	8</param>
/// <param name="tableid">테이블아이디	string	6</param>
/// <param name="upgu">업무구분	string	2</param>
/// <param name="custno">발행체번호	string	5</param>
/// <param name="custnm">발행회사명	string	80</param>
/// <param name="shcode">종목코드	string	6</param>
/// <param name="upunm">업무명	string	20</param>
public record t3202OutBlock(
    [BlockField("기준일", 8)] string recdt,
    [BlockField("테이블아이디", 6)] string tableid,
    [BlockField("업무구분", 2)] string upgu,
    [BlockField("발행체번호", 5)] string custno,
    [BlockField("발행회사명", 80)] string custnm,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("업무명", 20)] string upunm
    );


/// <summary>
/// FNG_요약: t3320
/// </summary>
/// <param name="gicode">종목코드	string	7</param>
public record t3320InBlock(
    [BlockField("종목코드", 7)] string gicode
    );

/// <summary>
/// FNG_요약: t3320
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
public record t3320OutBlock(
    [BlockField("업종구분명", 20)] string upgubunnm,
    [BlockField("시장구분", 1)] string sijangcd,
    [BlockField("시장구분명", 10)] string marketnm,
    [BlockField("한글기업명", 100)] string company,
    [BlockField("본사주소", 100)] string baddress,
    [BlockField("본사전화번호", 20)] string btelno,
    [BlockField("최근결산년도", 4)] string gsyyyy,
    [BlockField("결산월", 2)] string gsmm,
    [BlockField("최근결산년월", 6)] string gsym,
    [BlockField("주당액면가", 12)] long lstprice,
    [BlockField("주식수", 12)] long gstock,
    [BlockField("Homepage", 50)] string homeurl,
    [BlockField("그룹명", 30)] string grdnm,
    [BlockField("외국인", 6.2)] double foreignratio,
    [BlockField("주담전화", 30)] string irtel,
    [BlockField("자본금", 12)] double capital,
    [BlockField("시가총액", 12)] double sigavalue,
    [BlockField("배당금", 12)] double cashsis,
    [BlockField("배당수익율", 13.2)] double cashrate,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("위험고지구분1_정리매매", 1)] string notice1,
    [BlockField("위험고지구분2_투자위험", 1)] string notice2,
    [BlockField("위험고지구분3_단기과열", 1)] string notice3
    );

/// <summary>
/// FNG_요약: t3320
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
public record t3320OutBlock1(
    [BlockField("기업코드", 7)] string gicode,
    [BlockField("결산년월", 6)] string gsym,
    [BlockField("결산구분", 1)] string gsgb,
    [BlockField("PER", 13.2)] double per,
    [BlockField("EPS", 13)] double eps,
    [BlockField("PBR", 13.2)] double pbr,
    [BlockField("ROA", 13.2)] double roa,
    [BlockField("ROE", 13.2)] double roe,
    [BlockField("EBITDA", 13.2)] double ebitda,
    [BlockField("EVEBITDA", 13.2)] double evebitda,
    [BlockField("액면가", 13.2)] double par,
    [BlockField("SPS", 13.2)] double sps,
    [BlockField("CPS", 13.2)] double cps,
    [BlockField("BPS", 13)] double bps,
    [BlockField("T.PER", 13.2)] double t_per,
    [BlockField("T.EPS", 13)] double t_eps,
    [BlockField("PEG", 13.2)] double peg,
    [BlockField("T.PEG", 13.2)] double t_peg,
    [BlockField("최근분기년도", 6)] string t_gsym
    );


/// <summary>
/// 재무순위종합: t3341
/// </summary>
/// <param name="gubun">시장구분	string	1</param>
/// <param name="gubun1">순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)	string	1</param>
/// <param name="gubun2">대비구분	string	1</param>
/// <param name="idx">IDX	int	4</param>
public record t3341InBlock(
    [BlockField("시장구분", 1)] string gubun,
    [BlockField("순위구분(1:매출액증가율2:영업이익증가율3:세전계속이익증가율4:부채비율5:유보율6:EPS7:BPS8:ROE9:PERa:PBRb:PEG)", 1)] string gubun1,
    [BlockField("대비구분", 1)] string gubun2,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 재무순위종합: t3341
/// </summary>
/// <param name="cnt">CNT	int	4</param>
/// <param name="idx">IDX	int	4</param>
public record t3341OutBlock(
    [BlockField("CNT", 4)] int cnt,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 재무순위종합: t3341
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
public record t3341OutBlock1(
    [BlockField("순위", 4)] int rank,
    [BlockField("기업명", 20)] string hname,
    [BlockField("매출액증가율", 12)] long salesgrowth,
    [BlockField("영업이익증가율", 12)] long operatingincomegrowt,
    [BlockField("경상이익증가율", 12)] long ordinaryincomegrowth,
    [BlockField("부채비율", 12)] long liabilitytoequity,
    [BlockField("유보율", 12)] long enterpriseratio,
    [BlockField("EPS", 12)] long eps,
    [BlockField("BPS", 12)] long bps,
    [BlockField("ROE", 12)] long roe,
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("PER", 13.2)] double per,
    [BlockField("PBR", 13.2)] double pbr,
    [BlockField("PEG", 13.2)] double peg
    );


/// <summary>
/// 투자의견: t3401
/// </summary>
/// <param name="shcode">종목코드	string	9</param>
/// <param name="gubun1">구분	string	1</param>
/// <param name="tradno">회원사코드	string	3</param>
/// <param name="cts_date">IDXDATE	string	8</param>
public record t3401InBlock(
    [BlockField("종목코드", 9)] string shcode,
    [BlockField("구분", 1)] string gubun1,
    [BlockField("회원사코드", 3)] string tradno,
    [BlockField("IDXDATE", 8)] string cts_date
    );

/// <summary>
/// 투자의견: t3401
/// </summary>
/// <param name="cts_date">IDXDATE	string	8</param>
/// <param name="price">현재가	int	8</param>
/// <param name="sign">대비속성	string	1</param>
/// <param name="change">대비	int	8</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t3401OutBlock(
    [BlockField("IDXDATE", 8)] string cts_date,
    [BlockField("현재가", 8)] int price,
    [BlockField("대비속성", 1)] string sign,
    [BlockField("대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래대금", 12)] long value
    );

/// <summary>
/// 투자의견: t3401
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
public record t3401OutBlock1(
    [BlockField("종목코드", 9)] string shcode,
    [BlockField("회원사코드", 3)] string tradno,
    [BlockField("의견일자", 8)] string date,
    [BlockField("회원사명", 30)] string tradname,
    [BlockField("투자의견변경후", 30)] string bopn,
    [BlockField("투자의견변경전", 30)] string nopn,
    [BlockField("목표가변경전", 12)] long boga,
    [BlockField("목표가변경후", 12)] long noga,
    [BlockField("의견일종가", 8)] int close
    );


/// <summary>
/// 해외실시간지수: t3518
/// </summary>
/// <param name="kind">종목종류	string	1</param>
/// <param name="symbol">SYMBOL	string	16</param>
/// <param name="cnt">입력건수	int	4</param>
/// <param name="jgbn">조회구분	string	1</param>
/// <param name="nmin">N분	int	3</param>
/// <param name="cts_date">CTS_DATE	string	8</param>
/// <param name="cts_time">CTS_TIME	string	6</param>
public record t3518InBlock(
    [BlockField("종목종류", 1)] string kind,
    [BlockField("SYMBOL", 16)] string symbol,
    [BlockField("입력건수", 4)] int cnt,
    [BlockField("조회구분", 1)] string jgbn,
    [BlockField("N분", 3)] int nmin,
    [BlockField("CTS_DATE", 8)] string cts_date,
    [BlockField("CTS_TIME", 6)] string cts_time
    );

/// <summary>
/// 해외실시간지수: t3518
/// </summary>
/// <param name="cts_date">CTS_DATE	string	8</param>
/// <param name="cts_time">CTS_TIME	string	6</param>
public record t3518OutBlock(
    [BlockField("CTS_DATE", 8)] string cts_date,
    [BlockField("CTS_TIME", 6)] string cts_time
    );

/// <summary>
/// 해외실시간지수: t3518
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
public record t3518OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("시간", 8)] string time,
    [BlockField("시가", 9.4)] double open,
    [BlockField("고가", 9.4)] double high,
    [BlockField("저가", 9.4)] double low,
    [BlockField("현재가", 9.4)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 9.4)] double change,
    [BlockField("등락율", 9.4)] double uprate,
    [BlockField("누적거래량", 12)] double volume,
    [BlockField("매수호가", 9.4)] double bidho,
    [BlockField("매도호가", 9.4)] double offerho,
    [BlockField("매수잔량", 12)] double bidrem,
    [BlockField("매도잔량", 12)] double offerrem,
    [BlockField("종목종류", 1)] string kind,
    [BlockField("SYMBOL", 16)] string symbol,
    [BlockField("EXID", 4)] string exid,
    [BlockField("한국일자", 8)] string kodate,
    [BlockField("한국시간", 8)] string kotime
    );


/// <summary>
/// 해외지수조회(API용): t3521
/// </summary>
/// <param name="kind">종목종류	string	1</param>
/// <param name="symbol">SYMBOL	string	16</param>
public record t3521InBlock(
    [BlockField("종목종류", 1)] string kind,
    [BlockField("SYMBOL", 16)] string symbol
    );

/// <summary>
/// 해외지수조회(API용): t3521
/// </summary>
/// <param name="symbol">심벌	string	16</param>
/// <param name="hname">지수명	string	20</param>
/// <param name="close">지수	double	12.2</param>
/// <param name="sign">대비구분	string	1</param>
/// <param name="change">대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="date">일자	string	8</param>
public record t3521OutBlock(
    [BlockField("심벌", 16)] string symbol,
    [BlockField("지수명", 20)] string hname,
    [BlockField("지수", 12.2)] double close,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("일자", 8)] string date
    );


/// <summary>
/// 업종챠트(종합): t4203
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
public record t4203InBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("주기구분(0:틱1:분2:일3:주4:월)", 1)] string gubun,
    [BlockField("틱개수", 4)] int ncnt,
    [BlockField("건수", 4)] int qrycnt,
    [BlockField("당일구분(0:전체1:당일만)", 1)] string tdgb,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("연속당일구분(0:연속전체1:연속당일만2:연속전일만)", 1)] string cts_daygb
    );

/// <summary>
/// 업종챠트(종합): t4203
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
public record t4203OutBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("전일시가", 7.2)] double jisiga,
    [BlockField("전일고가", 7.2)] double jihigh,
    [BlockField("전일저가", 7.2)] double jilow,
    [BlockField("전일종가", 7.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 7.2)] double disiga,
    [BlockField("당일고가", 7.2)] double dihigh,
    [BlockField("당일저가", 7.2)] double dilow,
    [BlockField("당일종가", 7.2)] double diclose,
    [BlockField("당일거래대금", 12)] long disvalue,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("연속당일구분", 1)] string cts_daygb
    );

/// <summary>
/// 업종챠트(종합): t4203
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t4203OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 7.2)] double open,
    [BlockField("고가", 7.2)] double high,
    [BlockField("저가", 7.2)] double low,
    [BlockField("종가", 7.2)] double close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value
    );


/// <summary>
/// 주식선물마스터조회(API용): t8401
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8401InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// 주식선물마스터조회(API용): t8401
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="basecode">기초자산코드	string	9</param>
public record t8401OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("기초자산코드", 9)] string basecode
    );


/// <summary>
/// 주식선물현재가조회(API용): t8402
/// </summary>
/// <param name="focode">단축코드	string	8</param>
public record t8402InBlock(
    [BlockField("단축코드", 8)] string focode
    );

/// <summary>
/// 주식선물현재가조회(API용): t8402
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
public record t8402OutBlock(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래량전일동시간비율", 6.2)] double stimeqrt,
    [BlockField("거래대금", 12)] long value,
    [BlockField("미결제량", 8)] int mgjv,
    [BlockField("미결제증감", 8)] int mgjvdiff,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("52최고가", 8)] int high52w,
    [BlockField("52최저가", 8)] int low52w,
    [BlockField("베이시스", 6.2)] double basis,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("이론가", 8)] int theoryprice,
    [BlockField("괴리율", 6.3)] double glyl,
    [BlockField("만기일", 8)] string lastmonth,
    [BlockField("잔여일", 8)] int jandatecnt,
    [BlockField("종합지수", 6.2)] double pricejisu,
    [BlockField("종합지수전일대비구분", 1)] string jisusign,
    [BlockField("종합지수전일대비", 6.2)] double jisuchange,
    [BlockField("종합지수등락율", 6.2)] double jisudiff,
    [BlockField("KOSPI200지수", 6.2)] double kospijisu,
    [BlockField("KOSPI200전일대비구분", 1)] string kospisign,
    [BlockField("KOSPI200전일대비", 6.2)] double kospichange,
    [BlockField("KOSPI200등락율", 6.2)] double kospidiff,
    [BlockField("상장최고가", 8)] int listhprice,
    [BlockField("상장최저가", 8)] int listlprice,
    [BlockField("델타", 6.4)] double delt,
    [BlockField("감마", 6.4)] double gama,
    [BlockField("세타", 6.4)] double ceta,
    [BlockField("베가", 6.4)] double vega,
    [BlockField("로우", 6.4)] double rhox,
    [BlockField("근월물현재가", 8)] int gmprice,
    [BlockField("근월물전일대비구분", 1)] string gmsign,
    [BlockField("근월물전일대비", 8)] int gmchange,
    [BlockField("근월물등락율", 6.2)] double gmdiff,
    [BlockField("이론가", 8)] int theorypriceg,
    [BlockField("역사적변동성", 6.2)] double histimpv,
    [BlockField("내재변동성", 6.2)] double impv,
    [BlockField("시장BASIS", 8)] int sbasis,
    [BlockField("이론BASIS", 8)] int ibasis,
    [BlockField("근월물종목코드", 8)] string gmfutcode,
    [BlockField("행사가", 8)] int actprice,
    [BlockField("기초자산단축코드", 6)] string shcode,
    [BlockField("기초자산한글명", 20)] string basehname,
    [BlockField("기초자산현재가", 8)] int baseprice,
    [BlockField("기초자산현재가대비구분", 1)] string basesign,
    [BlockField("기초자산현재가전일대비", 8)] int basechange,
    [BlockField("기초자산등락률", 6.2)] double basediff,
    [BlockField("기초자산거래량", 12)] long basevol,
    [BlockField("기초자산전일거래량", 12)] long baseprevol,
    [BlockField("기초자산매수호가", 9)] long basebidprc,
    [BlockField("기초자산매도호가", 9)] long baseaskprc,
    [BlockField("기초자산외국계회원사순매수", 12)] long basefornetbid,
    [BlockField("상품군", 20)] string prodgrp,
    [BlockField("승수", 12.8)] double mulcnt,
    [BlockField("단일가호가여부", 1)] string danhochk,
    [BlockField("예상체결가", 8)] int yeprice,
    [BlockField("예상체결가전일종가대비구분", 1)] string jnilysign,
    [BlockField("예상체결가전일종가대비", 8)] int jnilychange,
    [BlockField("예상체결가전일종가등락율", 6.2)] double jnilydrate
    );


/// <summary>
/// 주식선물호가조회(API용): t8403
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
public record t8403InBlock(
    [BlockField("단축코드", 8)] string shcode
    );

/// <summary>
/// 주식선물호가조회(API용): t8403
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
public record t8403OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래량전일동시간비율", 6.2)] double stimeqrt,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("매도호가1", 8)] int offerho1,
    [BlockField("매수호가1", 8)] int bidho1,
    [BlockField("매도호가수량1", 8)] int offerrem1,
    [BlockField("매수호가수량1", 8)] int bidrem1,
    [BlockField("매도호가건수1", 8)] int dcnt1,
    [BlockField("매수호가건수1", 8)] int scnt1,
    [BlockField("매도호가2", 8)] int offerho2,
    [BlockField("매수호가2", 8)] int bidho2,
    [BlockField("매도호가수량2", 8)] int offerrem2,
    [BlockField("매수호가수량2", 8)] int bidrem2,
    [BlockField("매도호가건수2", 8)] int dcnt2,
    [BlockField("매수호가건수2", 8)] int scnt2,
    [BlockField("매도호가3", 8)] int offerho3,
    [BlockField("매수호가3", 8)] int bidho3,
    [BlockField("매도호가수량3", 8)] int offerrem3,
    [BlockField("매수호가수량3", 8)] int bidrem3,
    [BlockField("매도호가건수3", 8)] int dcnt3,
    [BlockField("매수호가건수3", 8)] int scnt3,
    [BlockField("매도호가4", 8)] int offerho4,
    [BlockField("매수호가4", 8)] int bidho4,
    [BlockField("매도호가수량4", 8)] int offerrem4,
    [BlockField("매수호가수량4", 8)] int bidrem4,
    [BlockField("매도호가건수4", 8)] int dcnt4,
    [BlockField("매수호가건수4", 8)] int scnt4,
    [BlockField("매도호가5", 8)] int offerho5,
    [BlockField("매수호가5", 8)] int bidho5,
    [BlockField("매도호가수량5", 8)] int offerrem5,
    [BlockField("매수호가수량5", 8)] int bidrem5,
    [BlockField("매도호가건수5", 8)] int dcnt5,
    [BlockField("매수호가건수5", 8)] int scnt5,
    [BlockField("매도호가6", 8)] int offerho6,
    [BlockField("매수호가6", 8)] int bidho6,
    [BlockField("매도호가수량6", 8)] int offerrem6,
    [BlockField("매수호가수량6", 8)] int bidrem6,
    [BlockField("매도호가건수6", 8)] int dcnt6,
    [BlockField("매수호가건수6", 8)] int scnt6,
    [BlockField("매도호가7", 8)] int offerho7,
    [BlockField("매수호가7", 8)] int bidho7,
    [BlockField("매도호가수량7", 8)] int offerrem7,
    [BlockField("매수호가수량7", 8)] int bidrem7,
    [BlockField("매도호가건수7", 8)] int dcnt7,
    [BlockField("매수호가건수7", 8)] int scnt7,
    [BlockField("매도호가8", 8)] int offerho8,
    [BlockField("매수호가8", 8)] int bidho8,
    [BlockField("매도호가수량8", 8)] int offerrem8,
    [BlockField("매수호가수량8", 8)] int bidrem8,
    [BlockField("매도호가건수8", 8)] int dcnt8,
    [BlockField("매수호가건수8", 8)] int scnt8,
    [BlockField("매도호가9", 8)] int offerho9,
    [BlockField("매수호가9", 8)] int bidho9,
    [BlockField("매도호가수량9", 8)] int offerrem9,
    [BlockField("매수호가수량9", 8)] int bidrem9,
    [BlockField("매도호가건수9", 8)] int dcnt9,
    [BlockField("매수호가건수9", 8)] int scnt9,
    [BlockField("매도호가10", 8)] int offerho10,
    [BlockField("매수호가10", 8)] int bidho10,
    [BlockField("매도호가수량10", 8)] int offerrem10,
    [BlockField("매수호가수량10", 8)] int bidrem10,
    [BlockField("매도호가건수10", 8)] int dcnt10,
    [BlockField("매수호가건수10", 8)] int scnt10,
    [BlockField("매도호가총수량", 8)] int dvol,
    [BlockField("매수호가총수량", 8)] int svol,
    [BlockField("총매도호가건수", 8)] int toffernum,
    [BlockField("총매수호가건수", 8)] int tbidnum,
    [BlockField("수신시간", 6)] string time,
    [BlockField("단축코드", 6)] string shcode
    );


/// <summary>
/// 주식선물시간대별체결조회(API용): t8404
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cvolume">특이거래량	long	12</param>
/// <param name="stime">시작시간	string	4</param>
/// <param name="etime">종료시간	string	4</param>
/// <param name="cts_time">시간CTS	string	10</param>
public record t8404InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("특이거래량", 12)] long cvolume,
    [BlockField("시작시간", 4)] string stime,
    [BlockField("종료시간", 4)] string etime,
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식선물시간대별체결조회(API용): t8404
/// </summary>
/// <param name="cts_time">시간CTS	string	10</param>
public record t8404OutBlock(
    [BlockField("시간CTS", 10)] string cts_time
    );

/// <summary>
/// 주식선물시간대별체결조회(API용): t8404
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
public record t8404OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] double change,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("체결강도", 8.2)] double chdegree,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("거래량", 12)] double volume,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결전일증감", 8)] int jnilopenupdn,
    [BlockField("이론BASIS", 8)] int ibasis,
    [BlockField("시장BASIS", 8)] int sbasis,
    [BlockField("괴리율", 6.2)] double kasis,
    [BlockField("거래대금", 12)] double value,
    [BlockField("미결직전증감", 8)] int j_openupdn,
    [BlockField("누적매수체결량", 12)] double n_msvolume,
    [BlockField("누적매도체결량", 12)] double n_mdvolume,
    [BlockField("누적순매수체결량", 12)] double s_msvolume,
    [BlockField("누적매수체결건수", 8)] int n_mschecnt,
    [BlockField("누적매도체결건수", 8)] int n_mdchecnt,
    [BlockField("누적순매수체결건수", 8)] int s_mschecnt
    );


/// <summary>
/// 주식선물기간별주가(API용): t8405
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="futcheck">선물최근월물	string	1</param>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="cnt">조회요청건수	int	3</param>
public record t8405InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("선물최근월물", 1)] string futcheck,
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("조회요청건수", 3)] int cnt
    );

/// <summary>
/// 주식선물기간별주가(API용): t8405
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="cts_code">CTS종목코드	string	8</param>
/// <param name="lastdate">전종목만기일	string	8</param>
/// <param name="nowfutyn">최근월선물여부	string	1</param>
public record t8405OutBlock(
    [BlockField("날짜", 8)] string date,
    [BlockField("CTS종목코드", 8)] string cts_code,
    [BlockField("전종목만기일", 8)] string lastdate,
    [BlockField("최근월선물여부", 1)] string nowfutyn
    );

/// <summary>
/// 주식선물기간별주가(API용): t8405
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
public record t8405OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("종가", 8)] int close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결증감", 8)] int openyakupdn,
    [BlockField("거래대금", 12)] double value
    );


/// <summary>
/// 주식선물틱분별체결조회(API용): t8406
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8406InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("챠트구분", 1)] string cgubun,
    [BlockField("분구분", 3)] int bgubun,
    [BlockField("조회건수", 3)] int cnt
    );

/// <summary>
/// 주식선물틱분별체결조회(API용): t8406
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
public record t8406OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("거래량", 12)] double volume,
    [BlockField("거래대금", 12)] double value,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결증감", 8)] int openupdn,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("매수순간체결건수", 8)] int s_mschecnt,
    [BlockField("매도순간체결건수", 8)] int s_mdchecnt,
    [BlockField("순매수순간체결건수", 8)] int ss_mschecnt,
    [BlockField("매수순간체결량", 12)] double s_mschevol,
    [BlockField("매도순간체결량", 12)] double s_mdchevol,
    [BlockField("순매수순간체결량", 12)] double ss_mschevol,
    [BlockField("체결강도(거래량)", 8.2)] double chdegvol,
    [BlockField("체결강도(건수)", 8.2)] double chdegcnt
    );


/// <summary>
/// API용주식멀티현재가조회: t8407
/// </summary>
/// <param name="nrec">건수	int	3</param>
/// <param name="shcode">종목코드	string	300</param>
public record t8407InBlock(
    [BlockField("건수", 3)] int nrec,
    [BlockField("종목코드", 300)] string shcode
    );

/// <summary>
/// API용주식멀티현재가조회: t8407
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
public record t8407OutBlock1(
    [BlockField("종목코드", 6)] string shcode,
    [BlockField("종목명", 40)] string hname,
    [BlockField("현재가", 8)] int price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 8)] int change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("매도호가", 8)] int offerho,
    [BlockField("매수호가", 8)] int bidho,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("체결강도", 9.2)] double chdegree,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("거래대금(백만)", 12)] long value,
    [BlockField("우선매도잔량", 12)] long offerrem,
    [BlockField("우선매수잔량", 12)] long bidrem,
    [BlockField("총매도잔량", 12)] long totofferrem,
    [BlockField("총매수잔량", 12)] long totbidrem,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice
    );


/// <summary>
/// API전용주식챠트(일주월년): t8410
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="gubun">주기구분(2:일3:주4:월5:년)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
/// <param name="sujung">수정주가여부(Y:적용N:비적용)	string	1</param>
public record t8410InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("주기구분(2:일3:주4:월5:년)", 1)] string gubun,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn,
    [BlockField("수정주가여부(Y:적용N:비적용)", 1)] string sujung
    );

/// <summary>
/// API전용주식챠트(일주월년): t8410
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
public record t8410OutBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("전일시가", 8)] int jisiga,
    [BlockField("전일고가", 8)] int jihigh,
    [BlockField("전일저가", 8)] int jilow,
    [BlockField("전일종가", 8)] int jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 8)] int disiga,
    [BlockField("당일고가", 8)] int dihigh,
    [BlockField("당일저가", 8)] int dilow,
    [BlockField("당일종가", 8)] int diclose,
    [BlockField("상한가", 8)] int highend,
    [BlockField("하한가", 8)] int lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count,
    [BlockField("정적VI상한가", 8)] int svi_uplmtprice,
    [BlockField("정적VI하한가", 8)] int svi_dnlmtprice
    );

/// <summary>
/// API전용주식챠트(일주월년): t8410
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
public record t8410OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 12)] long open,
    [BlockField("고가", 12)] long high,
    [BlockField("저가", 12)] long low,
    [BlockField("종가", 12)] long close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value,
    [BlockField("수정구분", 13)] long jongchk,
    [BlockField("수정비율", 6.2)] double rate,
    [BlockField("수정주가반영항목", 13)] long pricechk,
    [BlockField("수정비율반영거래대금", 12)] long ratevalue,
    [BlockField("종가등락구분(1:상한2:상승3:보합4:하한5:하락주식일만사용)", 1)] string sign
    );


/// <summary>
/// 주식챠트(틱/n틱): t8411
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
public record t8411InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("단위(n틱)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 주식챠트(틱/n틱): t8411
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
public record t8411OutBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("전일시가", 8)] int jisiga,
    [BlockField("전일고가", 8)] int jihigh,
    [BlockField("전일저가", 8)] int jilow,
    [BlockField("전일종가", 8)] int jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 8)] int disiga,
    [BlockField("당일고가", 8)] int dihigh,
    [BlockField("당일저가", 8)] int dilow,
    [BlockField("당일종가", 8)] int diclose,
    [BlockField("상한가", 8)] int highend,
    [BlockField("하한가", 8)] int lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 주식챠트(틱/n틱): t8411
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
public record t8411OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 10)] string time,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("종가", 8)] int close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("수정구분", 13)] long jongchk,
    [BlockField("수정비율", 6.2)] double rate,
    [BlockField("수정주가반영항목", 13)] long pricechk
    );


/// <summary>
/// 주식챠트(N분): t8412
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
public record t8412InBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("단위(n분)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 주식챠트(N분): t8412
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
public record t8412OutBlock(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("전일시가", 8)] int jisiga,
    [BlockField("전일고가", 8)] int jihigh,
    [BlockField("전일저가", 8)] int jilow,
    [BlockField("전일종가", 8)] int jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 8)] int disiga,
    [BlockField("당일고가", 8)] int dihigh,
    [BlockField("당일저가", 8)] int dilow,
    [BlockField("당일종가", 8)] int diclose,
    [BlockField("상한가", 8)] int highend,
    [BlockField("하한가", 8)] int lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 주식챠트(N분): t8412
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
public record t8412OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 10)] string time,
    [BlockField("시가", 8)] int open,
    [BlockField("고가", 8)] int high,
    [BlockField("저가", 8)] int low,
    [BlockField("종가", 8)] int close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value,
    [BlockField("수정구분", 13)] long jongchk,
    [BlockField("수정비율", 6.2)] double rate,
    [BlockField("종가등락구분(1:상한2:상승3:보합4:하한5:하락)", 1)] string sign
    );


/// <summary>
/// 선물옵션차트(틱/n틱): t8414
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
public record t8414InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("단위(n틱)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 선물옵션차트(틱/n틱): t8414
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
public record t8414OutBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("전일시가", 6.2)] double jisiga,
    [BlockField("전일고가", 6.2)] double jihigh,
    [BlockField("전일저가", 6.2)] double jilow,
    [BlockField("전일종가", 6.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 6.2)] double disiga,
    [BlockField("당일고가", 6.2)] double dihigh,
    [BlockField("당일저가", 6.2)] double dilow,
    [BlockField("당일종가", 6.2)] double diclose,
    [BlockField("상한가", 6.2)] double highend,
    [BlockField("하한가", 6.2)] double lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 선물옵션차트(틱/n틱): t8414
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	10</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="openyak">미결제약정	long	12</param>
public record t8414OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 10)] string time,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("미결제약정", 12)] long openyak
    );


/// <summary>
/// 선물/옵션챠트(N분): t8415
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
public record t8415InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("단위(n분)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 선물/옵션챠트(N분): t8415
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
public record t8415OutBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("전일시가", 6.2)] double jisiga,
    [BlockField("전일고가", 6.2)] double jihigh,
    [BlockField("전일저가", 6.2)] double jilow,
    [BlockField("전일종가", 6.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 6.2)] double disiga,
    [BlockField("당일고가", 6.2)] double dihigh,
    [BlockField("당일저가", 6.2)] double dilow,
    [BlockField("당일종가", 6.2)] double diclose,
    [BlockField("상한가", 6.2)] double highend,
    [BlockField("하한가", 6.2)] double lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 선물/옵션챠트(N분): t8415
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
public record t8415OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 10)] string time,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("누적거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value,
    [BlockField("미결제약정", 12)] long openyak
    );


/// <summary>
/// 선물/옵션챠트(일주월): t8416
/// </summary>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8416InBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("주기구분(2:일3:주4:월)", 1)] string gubun,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 선물/옵션챠트(일주월): t8416
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
public record t8416OutBlock(
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("전일시가", 6.2)] double jisiga,
    [BlockField("전일고가", 6.2)] double jihigh,
    [BlockField("전일저가", 6.2)] double jilow,
    [BlockField("전일종가", 6.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 6.2)] double disiga,
    [BlockField("당일고가", 6.2)] double dihigh,
    [BlockField("당일저가", 6.2)] double dilow,
    [BlockField("당일종가", 6.2)] double diclose,
    [BlockField("상한가", 6.2)] double highend,
    [BlockField("하한가", 6.2)] double lowend,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 선물/옵션챠트(일주월): t8416
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	6.2</param>
/// <param name="high">고가	double	6.2</param>
/// <param name="low">저가	double	6.2</param>
/// <param name="close">종가	double	6.2</param>
/// <param name="jdiff_vol">누적거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
/// <param name="openyak">미결제약정	long	12</param>
public record t8416OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("누적거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value,
    [BlockField("미결제약정", 12)] long openyak
    );


/// <summary>
/// 업종차트(틱/n틱): t8417
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
public record t8417InBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("단위(n틱)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 업종차트(틱/n틱): t8417
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
public record t8417OutBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("전일시가", 7.2)] double jisiga,
    [BlockField("전일고가", 7.2)] double jihigh,
    [BlockField("전일저가", 7.2)] double jilow,
    [BlockField("전일종가", 7.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 7.2)] double disiga,
    [BlockField("당일고가", 7.2)] double dihigh,
    [BlockField("당일저가", 7.2)] double dilow,
    [BlockField("당일종가", 7.2)] double diclose,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("장시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("장종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 업종차트(틱/n틱): t8417
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
public record t8417OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 7.2)] double open,
    [BlockField("고가", 7.2)] double high,
    [BlockField("저가", 7.2)] double low,
    [BlockField("종가", 7.2)] double close,
    [BlockField("거래량", 12)] long jdiff_vol
    );


/// <summary>
/// 업종챠트(N분): t8418
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
public record t8418InBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("단위(n분)", 4)] int ncnt,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("조회영업일수(0:미사용1>=사용)", 1)] string nday,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("시작시간(현재미사용)", 6)] string stime,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("종료시간(현재미사용)", 6)] string etime,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 업종챠트(N분): t8418
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
public record t8418OutBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("전일시가", 7.2)] double jisiga,
    [BlockField("전일고가", 7.2)] double jihigh,
    [BlockField("전일저가", 7.2)] double jilow,
    [BlockField("전일종가", 7.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 7.2)] double disiga,
    [BlockField("당일고가", 7.2)] double dihigh,
    [BlockField("당일저가", 7.2)] double dilow,
    [BlockField("당일종가", 7.2)] double diclose,
    [BlockField("당일거래대금", 12)] long disvalue,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("연속시간", 10)] string cts_time,
    [BlockField("업종시작시간(HHMMSS)", 6)] string s_time,
    [BlockField("업종종료시간(HHMMSS)", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 업종챠트(N분): t8418
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t8418OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 7.2)] double open,
    [BlockField("고가", 7.2)] double high,
    [BlockField("저가", 7.2)] double low,
    [BlockField("종가", 7.2)] double close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value
    );


/// <summary>
/// 업종챠트(일주월): t8419
/// </summary>
/// <param name="shcode">단축코드	string	3</param>
/// <param name="gubun">주기구분(2:일3:주4:월)	string	1</param>
/// <param name="qrycnt">요청건수(최대-압축:2000비압축:500)	int	4</param>
/// <param name="sdate">시작일자	string	8</param>
/// <param name="edate">종료일자	string	8</param>
/// <param name="cts_date">연속일자	string	8</param>
/// <param name="comp_yn">압축여부(Y:압축N:비압축)	string	1</param>
public record t8419InBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("주기구분(2:일3:주4:월)", 1)] string gubun,
    [BlockField("요청건수(최대-압축:2000비압축:500)", 4)] int qrycnt,
    [BlockField("시작일자", 8)] string sdate,
    [BlockField("종료일자", 8)] string edate,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("압축여부(Y:압축N:비압축)", 1)] string comp_yn
    );

/// <summary>
/// 업종챠트(일주월): t8419
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
public record t8419OutBlock(
    [BlockField("단축코드", 3)] string shcode,
    [BlockField("전일시가", 7.2)] double jisiga,
    [BlockField("전일고가", 7.2)] double jihigh,
    [BlockField("전일저가", 7.2)] double jilow,
    [BlockField("전일종가", 7.2)] double jiclose,
    [BlockField("전일거래량", 12)] long jivolume,
    [BlockField("당일시가", 7.2)] double disiga,
    [BlockField("당일고가", 7.2)] double dihigh,
    [BlockField("당일저가", 7.2)] double dilow,
    [BlockField("당일종가", 7.2)] double diclose,
    [BlockField("당일거래대금", 12)] long disvalue,
    [BlockField("연속일자", 8)] string cts_date,
    [BlockField("업종시작시간", 6)] string s_time,
    [BlockField("업종종료시간", 6)] string e_time,
    [BlockField("동시호가처리시간(MM:분)", 2)] string dshmin,
    [BlockField("레코드카운트", 7)] int rec_count
    );

/// <summary>
/// 업종챠트(일주월): t8419
/// </summary>
/// <param name="date">날짜	string	8</param>
/// <param name="open">시가	double	7.2</param>
/// <param name="high">고가	double	7.2</param>
/// <param name="low">저가	double	7.2</param>
/// <param name="close">종가	double	7.2</param>
/// <param name="jdiff_vol">거래량	long	12</param>
/// <param name="value">거래대금	long	12</param>
public record t8419OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시가", 7.2)] double open,
    [BlockField("고가", 7.2)] double high,
    [BlockField("저가", 7.2)] double low,
    [BlockField("종가", 7.2)] double close,
    [BlockField("거래량", 12)] long jdiff_vol,
    [BlockField("거래대금", 12)] long value
    );


/// <summary>
/// 전체업종: t8424
/// </summary>
/// <param name="gubun1">구분1	string	1</param>
public record t8424InBlock(
    [BlockField("구분1", 1)] string gubun1
    );

/// <summary>
/// 전체업종: t8424
/// </summary>
/// <param name="hname">업종명	string	20</param>
/// <param name="upcode">업종코드	string	3</param>
public record t8424OutBlock(
    [BlockField("업종명", 20)] string hname,
    [BlockField("업종코드", 3)] string upcode
    );


/// <summary>
/// 전체테마: t8425
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8425InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// 전체테마: t8425
/// </summary>
/// <param name="tmname">테마명	string	36</param>
/// <param name="tmcode">테마코드	string	4</param>
public record t8425OutBlock(
    [BlockField("테마명", 36)] string tmname,
    [BlockField("테마코드", 4)] string tmcode
    );


/// <summary>
/// 상품선물마스터조회(API용): t8426
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8426InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// 상품선물마스터조회(API용): t8426
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t8426OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode
    );


/// <summary>
/// 과거데이터시간대별조회: t8427
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
public record t8427InBlock(
    [BlockField("선물옵션구분", 1)] string fo_gbn,
    [BlockField("조회년도", 4)] string yyyy,
    [BlockField("조회월", 2)] string mm,
    [BlockField("옵션콜풋구분", 1)] string cp_gbn,
    [BlockField("옵션행사가", 6.2)] double actprice,
    [BlockField("선물옵션코드", 8)] string focode,
    [BlockField("일분구분", 1)] string dt_gbn,
    [BlockField("분간격", 2)] string min_term,
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time
    );

/// <summary>
/// 과거데이터시간대별조회: t8427
/// </summary>
/// <param name="focode">선물옵션코드	string	8</param>
/// <param name="date">날짜	string	8</param>
/// <param name="time">시간	string	6</param>
public record t8427OutBlock(
    [BlockField("선물옵션코드", 8)] string focode,
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time
    );

/// <summary>
/// 과거데이터시간대별조회: t8427
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
public record t8427OutBlock1(
    [BlockField("날짜", 8)] string date,
    [BlockField("시간", 6)] string time,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("종가", 6.2)] double close,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("거래증가율", 10.2)] double diff_vol,
    [BlockField("미결수량", 8)] int openyak,
    [BlockField("미결증감", 8)] int openyakupdn,
    [BlockField("거래대금", 12)] double value
    );


/// <summary>
/// 증시주변자금추이: t8428
/// </summary>
/// <param name="fdate">from일자	string	8</param>
/// <param name="tdate">to일자	string	8</param>
/// <param name="gubun">구분	string	1</param>
/// <param name="key_date">날짜	string	8</param>
/// <param name="upcode">업종코드	string	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8428InBlock(
    [BlockField("from일자", 8)] string fdate,
    [BlockField("to일자", 8)] string tdate,
    [BlockField("구분", 1)] string gubun,
    [BlockField("날짜", 8)] string key_date,
    [BlockField("업종코드", 3)] string upcode,
    [BlockField("조회건수", 3)] int cnt
    );

/// <summary>
/// 증시주변자금추이: t8428
/// </summary>
/// <param name="date">날짜CTS	string	8</param>
/// <param name="idx">IDX	int	4</param>
public record t8428OutBlock(
    [BlockField("날짜CTS", 8)] string date,
    [BlockField("IDX", 4)] int idx
    );

/// <summary>
/// 증시주변자금추이: t8428
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
public record t8428OutBlock1(
    [BlockField("일자", 8)] string date,
    [BlockField("지수", 7.2)] double jisu,
    [BlockField("대비구분", 1)] string sign,
    [BlockField("대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("거래량", 12)] long volume,
    [BlockField("고객예탁금_억원", 12)] long custmoney,
    [BlockField("예탁증감_억원", 12)] long yecha,
    [BlockField("회전율", 6.2)] double vol,
    [BlockField("미수금_억원", 12)] long outmoney,
    [BlockField("신용잔고_억원", 12)] long trjango,
    [BlockField("선물예수금_억원", 12)] long futymoney,
    [BlockField("주식형_억원", 8)] int stkmoney,
    [BlockField("혼합형_억원(주식)", 8)] int mstkmoney,
    [BlockField("혼합형_억원(채권)", 8)] int mbndmoney,
    [BlockField("채권형_억원", 8)] int bndmoney,
    [BlockField("필러(구.단기채권)", 8)] int bndsmoney,
    [BlockField("MMF_억원(주식)", 8)] int mmfmoney
    );


/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트: t8429
/// </summary>
/// <param name="focode">단축코드	string	8</param>
/// <param name="cgubun">챠트구분	string	1</param>
/// <param name="bgubun">분구분	int	3</param>
/// <param name="cnt">조회건수	int	3</param>
public record t8429InBlock(
    [BlockField("단축코드", 8)] string focode,
    [BlockField("챠트구분", 1)] string cgubun,
    [BlockField("분구분", 3)] int bgubun,
    [BlockField("조회건수", 3)] int cnt
    );

/// <summary>
/// EUREX야간옵션선물틱분별체결조회챠트: t8429
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
public record t8429OutBlock1(
    [BlockField("시간", 10)] string chetime,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("시가", 6.2)] double open,
    [BlockField("고가", 6.2)] double high,
    [BlockField("저가", 6.2)] double low,
    [BlockField("거래량", 12)] double volume,
    [BlockField("체결수량", 8)] int cvolume,
    [BlockField("매수순간체결건수", 8)] int s_mschecnt,
    [BlockField("매도순간체결건수", 8)] int s_mdchecnt,
    [BlockField("순매수순간체결건수", 8)] int ss_mschecnt,
    [BlockField("매수순간체결량", 12)] double s_mschevol,
    [BlockField("매도순간체결량", 12)] double s_mdchevol,
    [BlockField("순매수순간체결량", 12)] double ss_mschevol,
    [BlockField("체결강도(거래량)", 8.2)] double chdegvol,
    [BlockField("체결강도(건수)", 8.2)] double chdegcnt
    );


/// <summary>
/// 주식종목조회: t8430
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t8430InBlock(
    [BlockField("구분(0:전체1:코스피2:코스닥)", 1)] string gubun
    );

/// <summary>
/// 주식종목조회: t8430
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
public record t8430OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("ETF구분(1:ETF)", 1)] string etfgubun,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("전일가", 8)] int jnilclose,
    [BlockField("주문수량단위", 5)] string memedan,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("구분(1:코스피2:코스닥)", 1)] string gubun
    );


/// <summary>
/// ELW종목조회: t8431
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8431InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// ELW종목조회: t8431
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="uplmtprice">상한가	int	8</param>
/// <param name="dnlmtprice">하한가	int	8</param>
/// <param name="jnilclose">전일종가	int	8</param>
/// <param name="recprice">기준가	int	8</param>
public record t8431OutBlock(
    [BlockField("종목명", 40)] string hname,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("전일종가", 8)] int jnilclose,
    [BlockField("기준가", 8)] int recprice
    );


/// <summary>
/// 지수선물마스터조회API용: t8432
/// </summary>
/// <param name="gubun">구분	string	1</param>
public record t8432InBlock(
    [BlockField("구분", 1)] string gubun
    );

/// <summary>
/// 지수선물마스터조회API용: t8432
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
public record t8432OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("상한가", 6.2)] double uplmtprice,
    [BlockField("하한가", 6.2)] double dnlmtprice,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("전일고가", 6.2)] double jnilhigh,
    [BlockField("전일저가", 6.2)] double jnillow,
    [BlockField("기준가", 6.2)] double recprice
    );


/// <summary>
/// 지수옵션마스터조회API용: t8433
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t8433InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// 지수옵션마스터조회API용: t8433
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
public record t8433OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("상한가", 6.2)] double hprice,
    [BlockField("하한가", 6.2)] double lprice,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("전일고가", 6.2)] double jnilhigh,
    [BlockField("전일저가", 6.2)] double jnillow,
    [BlockField("기준가", 6.2)] double recprice
    );


/// <summary>
/// 선물/옵션멀티현재가조회: t8434
/// </summary>
/// <param name="qrycnt">건수	int	3</param>
/// <param name="focode">단축코드	string	400</param>
public record t8434InBlock(
    [BlockField("건수", 3)] int qrycnt,
    [BlockField("단축코드", 400)] string focode
    );

/// <summary>
/// 선물/옵션멀티현재가조회: t8434
/// </summary>
/// <param name="hname">한글명	string	20</param>
/// <param name="price">현재가	double	6.2</param>
/// <param name="sign">전일대비구분	string	1</param>
/// <param name="change">전일대비	double	6.2</param>
/// <param name="diff">등락율	double	6.2</param>
/// <param name="volume">누적거래량	long	12</param>
/// <param name="checnt">체결건수	int	8</param>
/// <param name="focode">단축코드	string	8</param>
public record t8434OutBlock1(
    [BlockField("한글명", 20)] string hname,
    [BlockField("현재가", 6.2)] double price,
    [BlockField("전일대비구분", 1)] string sign,
    [BlockField("전일대비", 6.2)] double change,
    [BlockField("등락율", 6.2)] double diff,
    [BlockField("누적거래량", 12)] long volume,
    [BlockField("체결건수", 8)] int checnt,
    [BlockField("단축코드", 8)] string focode
    );


/// <summary>
/// 파생종목마스터조회API용: t8435
/// </summary>
/// <param name="gubun">구분(MF/MO)	string	2</param>
public record t8435InBlock(
    [BlockField("구분(MF/MO)", 2)] string gubun
    );

/// <summary>
/// 파생종목마스터조회API용: t8435
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
public record t8435OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("상한가", 6.2)] double uplmtprice,
    [BlockField("하한가", 6.2)] double dnlmtprice,
    [BlockField("전일종가", 6.2)] double jnilclose,
    [BlockField("전일고가", 6.2)] double jnilhigh,
    [BlockField("전일저가", 6.2)] double jnillow,
    [BlockField("기준가", 6.2)] double recprice
    );


/// <summary>
/// 주식종목조회 API용: t8436
/// </summary>
/// <param name="gubun">구분(0:전체1:코스피2:코스닥)	string	1</param>
public record t8436InBlock(
    [BlockField("구분(0:전체1:코스피2:코스닥)", 1)] string gubun
    );

/// <summary>
/// 주식종목조회 API용: t8436
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
public record t8436OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("ETF구분(1:ETF2:ETN)", 1)] string etfgubun,
    [BlockField("상한가", 8)] int uplmtprice,
    [BlockField("하한가", 8)] int dnlmtprice,
    [BlockField("전일가", 8)] int jnilclose,
    [BlockField("주문수량단위", 5)] string memedan,
    [BlockField("기준가", 8)] int recprice,
    [BlockField("구분(1:코스피2:코스닥)", 1)] string gubun,
    [BlockField("증권그룹", 2)] string bu12gubun,
    [BlockField("기업인수목적회사여부(Y/N)", 1)] string spac_gubun,
    [BlockField("filler(미사용)", 32)] string filler
    );


/// <summary>
/// CME/EUREX마스터조회(API용): t8437
/// </summary>
/// <param name="gubun">구분(NF/NC/NM/NO)	string	2</param>
public record t8437InBlock(
    [BlockField("구분(NF/NC/NM/NO)", 2)] string gubun
    );

/// <summary>
/// CME/EUREX마스터조회(API용): t8437
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">종목코드	string	8</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="tradeunit">거래승수	double	21.8</param>
/// <param name="atmgb">ATM구분(1:ATM2:ITM3:OTM)	string	1</param>
public record t8437OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("종목코드", 8)] string shcode,
    [BlockField("표준코드", 12)] string expcode,
    [BlockField("거래승수", 21.8)] double tradeunit,
    [BlockField("ATM구분(1:ATM2:ITM3:OTM)", 1)] string atmgb
    );


/// <summary>
/// 기초자산리스트조회: t9905
/// </summary>
/// <param name="dummy">DUMMY	string	1</param>
public record t9905InBlock(
    [BlockField("DUMMY", 1)] string dummy
    );

/// <summary>
/// 기초자산리스트조회: t9905
/// </summary>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">표준코드	string	12</param>
/// <param name="hname">종목명	string	20</param>
public record t9905OutBlock1(
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("표준코드", 12)] string expcode,
    [BlockField("종목명", 20)] string hname
    );


/// <summary>
/// 만기월조회: t9907
/// </summary>
/// <param name="dummy">DUMMY	string	1</param>
public record t9907InBlock(
    [BlockField("DUMMY", 1)] string dummy
    );

/// <summary>
/// 만기월조회: t9907
/// </summary>
/// <param name="lastym">만기월	string	6</param>
/// <param name="lastnm">만기월명	string	10</param>
public record t9907OutBlock1(
    [BlockField("만기월", 6)] string lastym,
    [BlockField("만기월명", 10)] string lastnm
    );


/// <summary>
/// ELW마스터조회API용: t9942
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t9942InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// ELW마스터조회API용: t9942
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9942OutBlock(
    [BlockField("종목명", 40)] string hname,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("확장코드", 12)] string expcode
    );


/// <summary>
/// 지수선물마스터조회API용: t9943
/// </summary>
/// <param name="gubun">구분	string	1</param>
public record t9943InBlock(
    [BlockField("구분", 1)] string gubun
    );

/// <summary>
/// 지수선물마스터조회API용: t9943
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9943OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode
    );


/// <summary>
/// 지수옵션마스터조회API용: t9944
/// </summary>
/// <param name="dummy">Dummy	string	1</param>
public record t9944InBlock(
    [BlockField("Dummy", 1)] string dummy
    );

/// <summary>
/// 지수옵션마스터조회API용: t9944
/// </summary>
/// <param name="hname">종목명	string	20</param>
/// <param name="shcode">단축코드	string	8</param>
/// <param name="expcode">확장코드	string	12</param>
public record t9944OutBlock(
    [BlockField("종목명", 20)] string hname,
    [BlockField("단축코드", 8)] string shcode,
    [BlockField("확장코드", 12)] string expcode
    );


/// <summary>
/// 주식마스터조회API용-종목명40bytes: t9945
/// </summary>
/// <param name="gubun">구분(KSP:1KSD:2)	string	1</param>
public record t9945InBlock(
    [BlockField("구분(KSP:1KSD:2)", 1)] string gubun
    );

/// <summary>
/// 주식마스터조회API용-종목명40bytes: t9945
/// </summary>
/// <param name="hname">종목명	string	40</param>
/// <param name="shcode">단축코드	string	6</param>
/// <param name="expcode">확장코드	string	12</param>
/// <param name="etfchk">ETF구분	string	1</param>
/// <param name="filler">filler	string	5</param>
public record t9945OutBlock(
    [BlockField("종목명", 40)] string hname,
    [BlockField("단축코드", 6)] string shcode,
    [BlockField("확장코드", 12)] string expcode,
    [BlockField("ETF구분", 1)] string etfchk,
    [BlockField("filler", 5)] string filler
    );


