
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

                Random random = new Random();
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                bool flagExit = true;

                Console.Write("Введите размер массива: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n1) int\n2) double\nВведите номер нужного типа данных: ");
                string operation = Console.ReadLine();

                GenericArray<int> genericArrayInt = new GenericArray<int>(length);
                GenericArray<double> genericArrayDouble = new GenericArray<double>(length);
                GenericArray<string> genericArrayString = new GenericArray<string>(length);

                Console.Write("Массив: ");
                if (operation == "1")
                    for (int i = 0; i < length; i++)
                    {
                        genericArrayInt.ArrayGeneric[i] = random.Next(10);
                        Console.Write(" " + genericArrayInt.ArrayGeneric[i]);
                    }                       
                else if (operation == "2")
                    for (int i = 0; i < length; i++)
                    {
                        genericArrayDouble.ArrayGeneric[i] = random.NextDouble();
                        Console.Write(" " + genericArrayDouble.ArrayGeneric[i]);
                    }
                else
                    for(int i = 0; i < length; i++)
                    {
                        genericArrayString.ArrayGeneric[i] = chars[random.Next(chars.Length)].ToString();
                        Console.Write(" " + genericArrayString.ArrayGeneric[i]);
                    }

                while (flagExit)
                {
                    Console.Write("\n1) Добавить в массив\n2) Удалить из массива\n3) Получить элемент массива по индексу\n4) Длина массива\nВведите номер операции: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                Console.Write("Добавить в массив: ");

                                if (operation == "1")
                                {
                                    genericArrayInt.Add(Convert.ToInt32(Console.ReadLine()));
                                    genericArrayInt.Print();
                                }
                                else if (operation == "2")
                                {
                                    genericArrayDouble.Add(Convert.ToDouble(Console.ReadLine()));
                                    genericArrayDouble.Print();
                                }
                                else
                                {
                                    genericArrayString.Add(Console.ReadLine());
                                    genericArrayString.Print();
                                }

                                break;
                            }
                        case "2":
                            {
                                Console.Write("Индекс удаляемого элемента из массива: ");

                                if (operation == "1")
                                {
                                    genericArrayInt.Remove(Convert.ToInt32(Console.ReadLine()));
                                    genericArrayInt.Print();
                                }
                                else if (operation == "2")
                                {
                                    genericArrayDouble.Remove(Convert.ToInt32(Console.ReadLine()));
                                    genericArrayDouble.Print();
                                }
                                else
                                {
                                    genericArrayString.Remove(Convert.ToInt32(Console.ReadLine()));
                                    genericArrayString.Print();
                                }

                                break;
                            }
                        case "3":
                            {
                                Console.Write("Индекс искомого элемента из массива: ");

                                if (operation == "1")
                                {
                                    genericArrayInt.Print();
                                    genericArrayInt.Find(Convert.ToInt32(Console.ReadLine()));  
                                }
                                else if (operation == "2")
                                {
                                    genericArrayDouble.Print();
                                    genericArrayDouble.Find(Convert.ToInt32(Console.ReadLine()));
                                }
                                else
                                {
                                    genericArrayString.Print();
                                    genericArrayString.Find(Convert.ToInt32(Console.ReadLine()));                                    
                                }

                                break;
                            }
                        case "4":
                            {
                                Console.Write("Индекс удаляемого элемента из массива: ");

                                if (operation == "1")
                                    genericArrayInt.Length();
                                else if (operation == "2")
                                    genericArrayDouble.Length();
                                else
                                    genericArrayString.Length();

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Ошибка!");
                                flagExit = false;

                                break;
                            }
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