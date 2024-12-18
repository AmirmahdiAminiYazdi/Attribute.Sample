
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

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

    private void PrintAge()
    {
        Console.WriteLine($"Age : {_person.Age}");
    }
}