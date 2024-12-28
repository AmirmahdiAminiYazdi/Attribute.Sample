
namespace AttributeSample.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public class CodeChangeHistoryAttribute : System.Attribute
    {
        private readonly string _autorName;

        public string Description { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public bool IsBug { get; set; }

        public CodeChangeHistoryAttribute(string autorName, bool isBug)
        {
            _autorName = autorName;
            IsBug = isBug;
        }
    }
}
