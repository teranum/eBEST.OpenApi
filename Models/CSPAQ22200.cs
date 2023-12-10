namespace eBEST.OpenApi.Models
{
    /// <summary>
    /// 현물계좌예수금 주문가능금액 총평가2
    /// </summary>
    [Path("/stock/accno")]
    public class CSPAQ22200
    {
        public record InBlock(string BalCreTp);
        public record Request(InBlock CSPAQ22200InBlock1);

        public record CSPAQ22200OutBlock1(
            int RecCnt, // 레코드갯수   Number Y  5	
            string MgmtBrnNo, // 관리지점번호  String Y 3	
            string AcntNo, // 계좌번호    String Y    20	
            string Pwd, // 비밀번호    String Y   8	
            string BalCreTp // 잔고생성구분  String Y	1	
            );
        public record CSPAQ22200OutBlock2(
            int RecCnt, // 레코드갯수   Number Y   5	
            string BrnNm, // 지점명 String Y 40	
            string AcntNm, // 계좌명 String Y    40	
            double MnyOrdAbleAmt, // 현금주문가능금액    Number Y 16	
            double SubstOrdAbleAmt, // 대용주문가능금액    Number Y	16	
            double SeOrdAbleAmt, // 거래소금액   Number Y	16	
            double KdqOrdAbleAmt, // 코스닥금액   Number Y	16	
            double CrdtPldgOrdAmt, // 신용담보주문금액    Number Y	16	
            double MgnRat100pctOrdAbleAmt, // 증거금률100퍼센트주문가능금액    Number Y	16	
            double MgnRat35ordAbleAmt, // 증거금률35%주문가능금액 Number  Y   16	
            double MgnRat50ordAbleAmt, // 증거금률50%주문가능금액 Number  Y   16	
            double CrdtOrdAbleAmt, // 신용주문가능금액    Number Y	16	
            double Dps, // 예수금 Number Y	16	
            double SubstAmt, // 대용금액    Number Y	16	
            double MgnMny, // 증거금현금   Number Y	16	
            double MgnSubst, // 증거금대용   Number Y	16	
            double D1Dps, // D1예수금   Number Y	16	
            double D2Dps, // D2예수금   Number Y	16	
            double RcvblAmt, // 미수금액    Number Y	16	
            double D1ovdRepayRqrdAmt, // D1연체변제소요금액  Number Y	16	
            double D2ovdRepayRqrdAmt, // D2연체변제소요금액  Number Y	16	
            double MloanAmt, // 융자금액    Number Y	16	
            string ChgAfPldgRat, // 변경후담보비율 Number Y  9.3	
            double RqrdPldgAmt, // 소요담보금액  Number Y   16	
            double PdlckAmt, // 담보부족금액  Number Y  16	
            double OrgPldgSumAmt, // 원담보합계금액 Number Y 16	
            double SubPldgSumAmt, // 부담보합계금액 Number Y 16	
            double CrdtPldgAmtMny, // 신용담보금현금 Number Y    16	
            double CrdtPldgSubstAmt, // 신용담보대용금액    Number Y  16	
            double Imreq, // 신용설정보증금 Number Y 16	
            double CrdtPldgRuseAmt, // 신용담보재사용금액   Number Y   16	
            double DpslRestrcAmt, // 처분제한금액  Number Y 16	
            double PrdaySellAdjstAmt, // 전일매도정산금액    Number Y 16	
            double PrdayBuyAdjstAmt, // 전일매수정산금액    Number Y  16	
            double CrdaySellAdjstAmt, // 금일매도정산금액    Number Y 16	
            double CrdayBuyAdjstAmt, // 금일매수정산금액    Number Y  16	
            double CslLoanAmtdt1 // 매도대금담보대출금액  Number Y	16	
            );
        public record Response(string rsp_cd, string rsp_msg,
            CSPAQ22200OutBlock1 CSPAQ22200OutBlock1,
            CSPAQ22200OutBlock2 CSPAQ22200OutBlock2);
    }
}
