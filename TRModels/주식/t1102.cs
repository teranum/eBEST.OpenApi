namespace eBEST.OpenApi.TRModels
{
    /// <summary>
    /// 주식현재가(시세)조회
    /// </summary>
    public class t1102
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shcode">종목코드 ex:"005930"</param>
        public record InBlock(string shcode);
        public record Request(InBlock t1102InBlock);

        public record OutBlock(
            string hname,
            double open,
            double high,
            double low,
            double price,
            double volume,

            string sign,
            double change,

            double offer,
            double bid,
            string hotime,

            string shcode
            );
        public record Response(string rsp_cd, OutBlock t1102OutBlock, string rsp_msg);
    }
}
