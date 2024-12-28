
using System.Reflection;

var assembly = Assembly.LoadFrom(@"D:\Users\mashadservice\source\repos\Attribute.Sample\AttributeSample.Domain\bin\Debug\net8.0\AttributeSample.Domain.dll");    

var types = assembly.GetTypes();
Console.WriteLine($"********* {assembly.FullName}*********");
foreach (var type in types)
{
    Console.WriteLine($"Type's name :{type.Name}");
}
Console.ReadLine();