
namespace AttributeSample.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class AutoScanForDependencyAttribute : System.Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public class CodeChangeHistory : System.Attribute
    {
        private readonly string _autorName;

        public string Description { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public bool IsBug { get; set; }

        public CodeChangeHistory(string autorName, bool isBug)
        {
            _autorName = autorName;
            IsBug = isBug;
        }
    }
}
