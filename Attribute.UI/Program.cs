Person AmirMahdi = new()
{
    FirstName ="Amir Mahdi ",
    LastName = "Amini Yazdi",
    Age = 28
};
PersonPrinter p1 = new(AmirMahdi);
p1.print();
Console.ReadLine();
p1.PrintAge();
Console.ReadLine();
