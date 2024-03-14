namespace eBEST.OpenApi
{
    /// <summary>
    /// InOutBlock Field Attribute
    /// </summary>
    /// <param name="Attr">Attr</param>
    /// <param name="Size">Size</param>
    [AttributeUsage(AttributeTargets.All)]
    public class BlockInfoAttribute(bool Attr, int Size) : Attribute
    {
        /// <summary>
        /// Attr
        /// </summary>
        public bool Attr = Attr;

        /// <summary>
        /// Size
        /// </summary>
        public int Size = Size;
    }
}
