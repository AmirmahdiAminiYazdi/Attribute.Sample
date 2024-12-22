using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

[DebuggerDisplay("Person: {FirstName} {LastName}, Age: {Age}")]
[DebuggerTypeProxy(typeof(PersonDebuggerTypeProxy))]
public class Person
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Required]
    public string FirstName { get; set; }
    [StringLength(100)]
    public string LastName { get; set; }
    public int Age { get; set; }

    public class PersonDebuggerTypeProxy
    {
        private readonly Person _person;

        public PersonDebuggerTypeProxy(Person person)
        {
            _person = person;
        }
        public string FullName => $"{_person.FirstName} , {_person.LastName}";
        public int Age => _person.Age;
    }
}
