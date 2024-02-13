namespace eBEST.Abstractions;

/// <summary>
/// 요청/응답 베이스 레코드
/// </summary>
/// <param name="tr_cont">연속거래 여부 Y:연속○ N:연속×</param>
/// <param name="tr_cont_key">연속일 경우 그전에 내려온 연속키 값 올림</param>
/// <param name="rsp_cd">응답 코드</param>
/// <param name="rsp_msg">응답 메시지</param>
public abstract class TrBase(string tr_cont = "N", string tr_cont_key = "", string rsp_cd = "", string rsp_msg = "")
{
    public string tr_cont { get; set; } = tr_cont;
    public string tr_cont_key { get; set; } = tr_cont_key;
    public string rsp_cd { get; set; } = rsp_cd;
    public string rsp_msg { get; set; } = rsp_msg;
}
