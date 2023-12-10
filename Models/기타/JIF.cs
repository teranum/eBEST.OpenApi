using System.Text.Json.Serialization;

namespace eBEST.OpenApi.Models
{
    /// <summary>
    /// [기타] 실시간 시세 : 장운영정보
    /// </summary>
    /// <param name="jangubun">장구분</param>
    /// <param name="jstatus">장상태</param>
    public record JIF(string jangubun, string jstatus);
}
