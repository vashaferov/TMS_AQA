using Generic;

SimplePerson simplePerson = new SimplePerson(546, "Tom");
ObjectPerson objectPerson = new ObjectPerson("asd", "Bob");

GenericPerson<Guid> genericPerson = new GenericPerson<Guid>(Guid.NewGuid(), "Slava");
GenericPerson<int> genericPerson1 = new GenericPerson<int>(1, "Slava");

Company<GenericPerson<int>> mtsCompany = new Company<GenericPerson<int>>(genericPerson1);

StaticPerson<int>.code = 123;
StaticPerson<string>.code = "abc";

Person<Guid, string> person = new Person<Guid, string>(Guid.NewGuid(), "wp", "Slava");
Person<int, int> person1 = new Person<int, int>(1, 2, "Slava");