using AttributeSample.DiscoveringMetaData;
using AttributeSample.Domain;

var intPrinter = new MetaDataPrinter(typeof(int));
var personPrinter = new MetaDataPrinter(typeof(Person));

//intPrinter.Print();
//Console.WriteLine("Press any key to print INT MetaData");
//Console.ReadKey();
//Console.Clear();

personPrinter.Print();

Console.WriteLine("Press any key to print Person MetaData");
Console.ReadKey();
Console.Clear();