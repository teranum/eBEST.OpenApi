namespace eBEST.OpenApi;

/// <summary>
/// 요청/응답 베이스 레코드
/// </summary>
public abstract class TrBase()
{
    /// <summary>
    /// 연속거래 여부 Y:연속○ N:연속×
    /// </summary>
    public string tr_cont { get; set; } = "N";

    /// <summary>
    /// 연속일 경우 그전에 내려온 연속키 값 올림
    /// </summary>
    public string tr_cont_key { get; set; } = string.Empty;

    /// <summary>
    /// 응답 코드
    /// </summary>
    public string rsp_cd { get; set; } = string.Empty;

    /// <summary>
    /// 응답 메시지
    /// </summary>
    public string rsp_msg { get; set; } = string.Empty;
}
