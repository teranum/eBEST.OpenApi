namespace eBEST.OpenApi.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PathAttribute(string path) : Attribute
    {
        public string Path { get; } = path;
        public string TRCode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
    }
}
