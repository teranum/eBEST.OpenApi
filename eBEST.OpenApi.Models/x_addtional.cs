using System.ComponentModel;

namespace eBEST.OpenApi.Models
{
    using eBEST.OpenApi.Blocks;

    /// <summary>
    /// API사용자조건검색실시간: Ys3
    /// </summary>
    [Path("/websocket/stock", Description = "API사용자조건검색실시간")]
    public class AFR
    {
        //요청
        public AFRInBlock? Ys3InBlock { get; set; }

        //응답
        public AFROutBlock? Ys3OutBlock { get; set; }
    }


    /// <summary>
    /// e종목검색(신버전API용)
    /// </summary>
    [Path("/stock/item-search", Description = "서버저장조건 조건검색")]
    public class t1859 : TrBase
    {
        /// 요청
        public t1859InBlock? t1859InBlock { get; set; }

        // 응답
        public t1859OutBlock? t1859OutBlock { get; set; }
        public t1859OutBlock1[]? t1859OutBlock1 { get; set; }
    }

    /// <summary>
    /// 서버저장조건 실시간검색
    /// </summary>
    [Path("/stock/item-search", Description = "서버저장조건 실시간검색")]
    public class t1860 : TrBase
    {
        /// 요청
        public t1860InBlock? t1860InBlock { get; set; }

        // 응답
        public t1860OutBlock? t1860OutBlock { get; set; }
    }

}


namespace eBEST.OpenApi.Blocks
{
    /// <summary>
    /// API사용자조건검색실시간	: AFR
    /// </summary>
    /// <param name="sAlertNum">실시간키	string	6</param>
    public record AFRInBlock([Description("실시간키	string	11")] string sAlertNum);

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
    public record AFROutBlock([Description("종목코드	string	9")] string gsCode, [Description("종목명	string	40")] string gshname, [Description("현재가	string	8")] string gsPrice, [Description("전일대비구분	string	1")] string gsSign, [Description("전일대비	string	8")] string gsChange, [Description("등락율	string	6")] string gsChgRate, [Description("거래량	string	9")] string gsVolume, [Description("종목상태(N:진입 R:재진입 O:이탈)	string	1")] string gsJobFlag);

    /// <summary>
    /// 서버저장조건 조건검색	t1859InBlock
    /// </summary>
    /// <param name="query_index">서버저장인덱스	string	12, t1866 TR에서 조회한 t1866OutBlock1.query_index</param>
    public record t1859InBlock([Description("서버저장인덱스	string	12")] string query_index);

    /// <summary>
    /// 서버저장조건 조건검색	t1859OutBlock
    /// </summary>
    /// <param name="result_count">검색종목수	int	5</param>
    /// <param name="result_time">포착시간	int	6</param>
    /// <param name="text">전략설명	string	200</param>
    public record t1859OutBlock(
        [Description("검색종목수	int	5")] int result_count
        , [Description("포착시간	int	6")] int result_time
        , [Description("전략설명	string	200")] string text
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
        [Description("종목코드	string	7")] string shcode
        , [Description("종목명	string	40")] string hname
        , [Description("현재가	int	7")] int price
        , [Description("전일대비구분	string	1")] string sign
        , [Description("전일대비	long	9")] long change
        , [Description("등락율	double	6.2")] double diff
        , [Description("거래량	long	12")] long volume
        );

    /// <summary>
    /// 서버저장조건 실시간검색    t1860InBlock
    /// </summary>
    /// <param name="sSysUserFlag">사용자구분	string	1 ('U' 고정)</param>
    /// <param name="sFlag">Flag	string	1 ('E:'등록, 'D':중지)</param>
    /// <param name="sAlertNum">실시간 검색키	string	11 (Flag 값: 'D':중지 일떄만 입력 - 등록 요청 시 수신받은 t1860OutBlock.sAlertNum 값)</param>
    /// <param name="query_index">서버저장인덱스	string	12	(t1866 TR에서 조회한 t1866OutBlock1.query_index)</param>
    public record t1860InBlock(
        [Description("사용자구분	string	1('U' 고정)")] string sSysUserFlag,
        [Description("Flag	string	1('E:'등록, 'D':중지)")] string sFlag,
        [Description("실시간 검색키	string	11")] string sAlertNum,
        [Description("서버저장인덱스	string	12")] string query_index
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
        [Description("사용자구분	string	1")] string sSysUserFlag,
        [Description("Flag	string	1")] string sFlag,
        [Description("결과플레그	string	1")] string sResultFlag,
        [Description("현재시간	string	6")] string sTime,
        [Description("실시간키	string	11")] string sAlertNum,
        [Description("메세지	string	40")] string Msg
        );
}