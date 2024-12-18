

using System.Diagnostics;

public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void print()
    {
        ShowDebugData();
        ShowDeveloperName();
        PrintFullName();
        PrintAge();
    }

    [Conditional("DEBUG")]
    private void ShowDebugData()
    {
        Console.WriteLine("This Apllication has been DEBUG MODE");
    }
    [Conditional("AM4")]
    private void ShowDeveloperName()
    {
        Console.WriteLine("Developer Name is AM4");
    }

    private void PrintFullName()
    {
        Console.WriteLine($"FullName:{_person.FirstName},{_person.LastName}");
    }

    [Obsolete("printAge() will remove soon"/*,error:true*/)]
    public void PrintAge()
    {
        Console.WriteLine($"Age : {_person.Age}");
    }
}