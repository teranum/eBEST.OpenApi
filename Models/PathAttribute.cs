namespace eBEST.OpenApi.Models
{
    [AttributeUsage(AttributeTargets.All)]
    public class PathAttribute(string path) : Attribute
    {
        public string Path { get; } = path;
    }
}
