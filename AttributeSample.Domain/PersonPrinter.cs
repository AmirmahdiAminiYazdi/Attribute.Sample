
public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void print()
    {
        PrintFullName();
        PrintAge();
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