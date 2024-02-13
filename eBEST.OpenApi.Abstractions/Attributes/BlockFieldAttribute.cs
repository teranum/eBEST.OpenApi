namespace eBEST.Abstractions
{
    [AttributeUsage(AttributeTargets.All)]
    public class BlockFieldAttribute(string Description, double Size) : Attribute
    {
        public string Description = Description;
        public double Size = Size;
    }
}
