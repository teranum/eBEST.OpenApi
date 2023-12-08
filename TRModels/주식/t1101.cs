namespace eBEST.OpenApi.TRModels
{
    /// <summary>
    /// 주식현재가호가조회
    /// </summary>
    public class t1101
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shcode">종목코드 ex:"005930"</param>
        public record InBlock(string shcode);
        public record Request(InBlock t1101InBlock);

        public record OutBlock(
            string hname,
            double open,
            double high,
            double low,
            double price,
            double volume,

            string sign,
            double change,

            double offerho10,
            double offerho9,
            double offerho8,
            double offerho7,
            double offerho6,
            double offerho5,
            double offerho4,
            double offerho3,
            double offerho2,
            double offerho1,
            double bidho1,
            double bidho2,
            double bidho3,
            double bidho4,
            double bidho5,
            double bidho6,
            double bidho7,
            double bidho8,
            double bidho9,
            double bidho10,

            double offer,
            double bid,
            string hotime,

            string shcode
            );
        public record Response(string rsp_cd, OutBlock t1101OutBlock, string rsp_msg);
    }
}
