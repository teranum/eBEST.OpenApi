namespace eBEST.Abstractions
{
    /// <summary>
    /// TR 요청 속성
    /// </summary>
    /// <param name="path">URL경로</param>
    [AttributeUsage(AttributeTargets.Class)]
    public class PathAttribute(string path) : Attribute
    {
        /// <summary>
        /// URL경로
        /// </summary>
        public string Path { get; } = path;

        /// <summary>
        /// 이베스트증권 거래코드
        /// </summary>
        public string TRCode { get; set; } = string.Empty;

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; } = string.Empty;
    }
}
