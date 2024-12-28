using AttributeSample.CustomAttributes;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace AttributeSample.Domain;

[DebuggerDisplay("Person: {FirstName} {LastName}, Age: {Age}")]
[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
[Serializable]
[CodeChangeHistoryAttribute("Amir Mahdi",isBug:false,Description ="Add New ....")]
[CodeChangeHistoryAttribute("Amir Mahdi", isBug: true, Description = "Fix Bug.")]

public partial class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Required]
    public string FirstName { get; set; } = "Amir Mahdi";
    [StringLength(100)]
    public string LastName { get; set; } = "Amini Yazdi";
    public int Age { get; set; }
    [NonSerialized]
    private int _age;


    public void Print()
    {
        Console.WriteLine($"{FirstName}{LastName}");
    }
    public void InputPrinter (string input)
    {
        Console.WriteLine(input);
    }
}
