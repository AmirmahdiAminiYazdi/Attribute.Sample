using System.Reflection;

var assembly = Assembly.LoadFrom(@"D:\Users\mashadservice\source\repos\Attribute.Sample\AttributeSample.Domain\bin\Debug\net8.0\AttributeSample.Domain.dll");
var personType = assembly.GetType("AttributeSample.Domain.Person");
var person = Activator.CreateInstance(personType);
Console.WriteLine($"My object Type is {person}.");

// var personMethods= personType.GetMethods();
//foreach (var method in personMethods)
//{
//    Console.WriteLine(method.Name);
//}

var printMethod = personType.GetMethod("Print");
printMethod.Invoke(person, null);

var inputPrinterMethod = personType.GetMethod("InputPrinter");
inputPrinterMethod.Invoke(person, new object[] {"This is input Parameter" });


Console.ReadKey();