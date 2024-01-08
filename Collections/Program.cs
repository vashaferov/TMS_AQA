// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.IDictionary;
using Collections.IList;
using Collections.ISet;
using System.Collections;


//new ArrayListExample().Run();

//new ListExample().Run();

//new LinkedListExample().Run();

//new DictionaryExample().Run();

//new SortedListExample().Run();

//new SortedDictionaryExample().Run();

//new HashSetExample().Run();

//new StackExample().Run();

//new QueueExample().Run();

Persons persons1 = new Persons()
{
    FirstName = "A",
    LasttName = "B"
};

Persons persons2 = new Persons()
{
    FirstName = "A",
    LasttName = "B"
};

Console.WriteLine(persons1.Equals(persons2));

IEnumerable<int> GeneratrNum(int count)
{
    for(int i = 0; i < count; i++)
    {
        yield return i;
    }
}

foreach(var number in GeneratrNum(5))
{
    Console.WriteLine(number);
    Console.WriteLine(number);
}