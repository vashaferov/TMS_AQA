
//SimplePerson simplePerson = new SimplePerson(546, "Tom");
//ObjectPerson objectPerson = new ObjectPerson("asd", "Bob");

//GenericPerson<Guid> genericPerson = new GenericPerson<Guid>(Guid.NewGuid(), "Slava");
//GenericPerson<int> genericPerson1 = new GenericPerson<int>(1, "Slava");

//Company<GenericPerson<int>> mtsCompany = new Company<GenericPerson<int>>(genericPerson1);

//StaticPerson<int>.code = 123;
//StaticPerson<string>.code = "abc";

//Person<Guid, string> person = new Person<Guid, string>(Guid.NewGuid(), "wp", "Slava");
//Person<int, int> person1 = new Person<int, int>(1, 2, "Slava");

using Generic.Task1;
using Generic.Task2;
using System.Drawing;

bool flag = true;
string task;

while (flag)
{
    Console.Write("-------\nВведите номер задания (от 1 до 3): ");
    task = Console.ReadLine();
    Console.Clear();

    switch (task)
    {
        case "1":
            {
                Console.WriteLine("ЗАДАНИЕ 1\n");
                
                int x1 = 5;
                int y1 = 3;
                string x2 = "10";
                string y2 = "15";

                Point<int> pointInt = new Point<int>(x1, y1);
                Point<string> pointString = new Point<string>(x2, y2);

                Console.WriteLine("В формате 'int': ");
                pointInt.Print();
                Console.WriteLine("В формате 'string': ");
                pointString.Print();

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");

                Console.Write("Введите размер массива: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n1) int\n2) double\nВведите номер нужного типа данных: ");
                string operation = Console.ReadLine();

                if (operation == "1")
                    GenericArray<int> genericArrayInt = new GenericArray<int>(length);
                else
                    GenericArray<double> genericArrayString = new GenericArray<double>(length);

                Console.WriteLine("\n1) Добавить в массив\n2) Удалить из массива\n3) Получить элемент массива по индексу\n4) Длина массива\nВведите номер операции: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            

                            break;
                        }
                    case "2":
                        {


                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка!");

                            break;
                        }
                }

                break;
            }
        case "3":
            {
                Console.WriteLine("ЗАДАНИЕ 3\n");

                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 3)");

                break;
            }
    }
}