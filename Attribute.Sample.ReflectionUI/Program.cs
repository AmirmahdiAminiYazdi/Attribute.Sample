using AttributeSample.Domain;

Person _person = new Person();
Type personType01= _person.GetType();
Console.WriteLine(personType01.FullName);

Type personType02= typeof(Person);
Console.WriteLine(personType02.FullName);

Type personType03 = Type.GetType("AttributeSample.ReflectionUI.Teacher, AttributeSample.ReflectionUI", true,true);
Console.WriteLine(personType03.FullName);

Type personType04 = Type.GetType("AttributeSample.Domain.Person, AttributeSample.Domain", true, true);
Console.WriteLine(personType04.FullName);
Console.ReadLine();
