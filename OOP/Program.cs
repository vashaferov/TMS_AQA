using OOP.Task1;
using System.Numerics;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//-------- Наследование 
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
            person.Age = "25";*/

            bool flag = true;
            string task;

            while (flag)
            {
                Console.Write("-------\nВведите номер задания (от 1 до 4): ");
                task = Console.ReadLine();
                Console.Clear();

                switch (task)
                {
                    case "1":
                        {
                            Console.WriteLine("ЗАДАНИЕ 1\n");

                            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(5, 3);
                            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(5);

                            Console.WriteLine(isoscelesTriangle.AreaOfTriangle());
                            Console.WriteLine(equilateralTriangle.AreaOfTriangle());
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("ЗАДАНИЕ 2\n");

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("ЗАДАНИЕ 3\n");                        

                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("ЗАДАНИЕ 4\n");

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 4)");

                            break;
                        }
                }
            }

        }
    }
}