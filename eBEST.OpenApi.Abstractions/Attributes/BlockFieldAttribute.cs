namespace eBEST.OpenApi
{
    /// <summary>
    /// InOutBlock Field Attribute
    /// </summary>
    /// <param name="Description">Description</param>
    /// <param name="Size">Size</param>
    [AttributeUsage(AttributeTargets.All)]
    public class BlockFieldAttribute(string Description, double Size) : Attribute
    {
        /// <summary>
        /// Description
        /// </summary>
        public string Description = Description;

        /// <summary>
        /// Size
        /// </summary>
        public double Size = Size;
    }
}
