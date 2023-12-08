namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------- Наследование 
            Client client1 = new Client(1);
            client1.Id = 1;
            client1.PhoneNumber = "79126784609";
            client1.Email = "test@test.com";

            Corporate corporate1 = new Corporate(1);
            corporate1.Id = 1;
            corporate1.INN = 4523434;
            corporate1.UNP = 3234324;

            Individuals individual1 = new Individuals(1);
            individual1.Firstname = "Aaa";
            individual1.Lastname = "Bbb";
            individual1.Id = 10;
            individual1.PhoneNumber = "79373892819";
            individual1.Email = "test1@test.com";

            //-------- Свойства
            Person person = new Person("yyy - 715");
            person.Name = "Test";
            person.Age = "25";
            person.Age = "25";

        }
    }
}