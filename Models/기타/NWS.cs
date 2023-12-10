namespace eBEST.OpenApi.Models.기타
{
    /// <summary>
    /// [기타] 실시간 시세 : 실시간뉴스제목패킷
    /// </summary>
    /// <param name="date">날짜</param>
    /// <param name="time">시간</param>
    /// <param name="id">뉴스구분자</param>
    /// <param name="realkey">키값</param>
    /// <param name="title">제목</param>
    /// <param name="code">단축종목코드</param>
    /// <param name="bodysize">BODY길이</param>
    public record NWS(string date, string time, string id, string realkey, string title, string code, string bodysize);
}
