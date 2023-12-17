namespace eBEST.OpenApi.DevCenter.Models
{
    public class PropertyItem
    {
        public enum VALUE_TYPE
        {
            VALUE_STRING,
            VALUE_LONG
        }

        public PropertyItem(int N, string Name, string Value, string Desc, VALUE_TYPE type = VALUE_TYPE.VALUE_STRING, bool IsValueReadOnly = false)
        {
            this.N = N;
            this.Name = Name;
            this.Value = Value;
            this.Desc = Desc;
            this.type = type;
            this.IsValueReadOnly = IsValueReadOnly;
        }
        public int N { get; }
        public string Name { get; }
        public string Value { get; set; }
        public string Desc { get; }

        public VALUE_TYPE type;
        public bool IsValueReadOnly { get; }
    }
}
