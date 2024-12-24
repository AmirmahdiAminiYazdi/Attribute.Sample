namespace AttributeSample.DiscoveringMetaData
{
    public class MetaDataPrinter
    {
        private readonly Type _type;

        public MetaDataPrinter(Type type)
        {
            _type = type;
        }
        public void Print()
        {
            PrintMainInfo();
            PrintMethodInfo();
            PrintPropertyInfo();
            PrintFieldInfo();
           

        }

        private void PrintFieldInfo()
        {
            Console.WriteLine($"************ Fields information of type {_type.Name} ************");
            var fieldInfos = _type.GetFields();
            foreach (var fieldInfo in fieldInfos)
            {
                Console.WriteLine($"{fieldInfo.FieldType} {fieldInfo.Name}");
            }
        }

        private void PrintPropertyInfo()
        {

            Console.WriteLine($"************ Properties information of type {_type.Name} ************");
            var propetyInfos = _type.GetProperties();
            foreach (var propetyInfo in propetyInfos)
            {
                Console.WriteLine($"{propetyInfo.PropertyType} {propetyInfo.Name}");
            }
        }

        private void PrintMethodInfo()
        {
            Console.WriteLine($"************ Methods information of type {_type.Name} ************");
            var methodInfo = _type.GetMethods();
            foreach (var method in methodInfo)
            {
                Console.Write($"{method.Name}(");
                var parameters = method.GetParameters();
                foreach (var param in parameters)
                {
                    Console.Write($"{param.ParameterType} {param.Name},");
                }


                Console.WriteLine(")");
            }
        }

        private void PrintMainInfo()
        {
            Console.WriteLine($"************ Information of type {_type.Name} ************");
            Console.WriteLine($"FullName: {_type.FullName}");
            Console.WriteLine($"AssemblyQualifiedName: {_type.AssemblyQualifiedName}");
            Console.WriteLine($"BaseType: {_type.BaseType}");
            Console.WriteLine($"Namespace: {_type.Namespace}");
            Console.WriteLine($"IsAbstract: {_type.IsAbstract}");
            Console.WriteLine($"IsEnum: {_type.IsEnum}");
            Console.WriteLine($"IsNotPublic: {_type.IsNotPublic}");
        }
    }
}
