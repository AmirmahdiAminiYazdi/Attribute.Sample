using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json.Serialization;

[DebuggerDisplay("Person: {FirstName} {LastName}, Age: {Age}")]
[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
[Serializable]
public partial class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Required]
    public string FirstName { get; set; }
    [StringLength(100)]
    public string LastName { get; set; }
    public int Age { get; set; }
    [NonSerialized]
    private int _age;
}
