namespace eBEST.OpenApi.TRModels
{
    /// <summary>
    /// 주식현재가(시세)조회
    /// </summary>
    public class t1104
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shcode">종목코드 ex:"005930"</param>
        public record InBlock(string code, string nrec);
        public record InBlock1(string indx, string gubn, string dat1, string dat2);
        public record Request(InBlock t1104InBlock, List<InBlock1> t1104InBlock1);

        public record OutBlock(string nrec);
        public record OutBlock1(string indx, string gubn, string vals);
        public record Response(string rsp_cd, OutBlock t1104OutBlock, List<OutBlock1> t1104OutBlock1, string rsp_msg);
    }
}
