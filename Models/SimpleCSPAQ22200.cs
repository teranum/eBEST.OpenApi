namespace eBEST.OpenApi.Models
{
    /// <summary>
    /// 현물계좌예수금 주문가능금액 총평가2 (rsp_msg 이용)
    /// </summary>
    [Path("/stock/accno", TRName = "CSPAQ22200")]
    public class SimpleCSPAQ22200
    {
        public record InBlock(string BalCreTp);
        public record Request(InBlock CSPAQ22200InBlock1);

        public record Response(string rsp_cd, string rsp_msg);
    }
}
