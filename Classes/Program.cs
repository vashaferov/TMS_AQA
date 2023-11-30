

using Classes.Task1;
using Classes.Task2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=================================\\
            //============= Методы ==============\\
            //=====================================\\
            /* int[] array = { 1, 8, 14, -4, 0, 7 };

             DisplayGreeting("Hello");
             DisplayGreeting("Hello", "Slava");

             Console.WriteLine(GetInfo());

             PrintArrayWithoutParameters();

             Array.Reverse(array);

             PrintArrayParameters(array);


             void PrintArrayWithoutParameters()
             {
                 foreach (var i in array)
                 {
                     Console.Write($"{i}\t");
                 }
                 Console.WriteLine();
             }

             void PrintArrayParameters(int[] arrayParameters)
             {
                 foreach (var i in arrayParameters)
                 {
                     Console.Write($"{i}\t");
                 }
                 Console.WriteLine();
             }

             string GetInfo()
             {
                 return "Reverse:";
             }

             void DisplayGreeting(string message, string name = "Гость") // с параметром по умолчанию
             {
                 Console.WriteLine(message + ", " + name);
             }

             // =============== Передача параметров по ссылке

             static void OutAdd (int x, int y, out int ans)              // out
             {
                 ans = x + y;
             }

             OutAdd(90, 90, out int ans);                                // ref
             Console.WriteLine("Out: " + ans);

             void ModifyValue(ref int value)
             {
                 value = value * 2;
             }

             int mainValue = 5;
             Console.WriteLine("Ref: " + mainValue);

             // =============== Возврат нескольких значений (кортеж)

             (string, int) GetPersonInfo()
             {
                 return ("Slava", 25);
             }

             var person1 = GetPersonInfo();
             Console.WriteLine($"Name: {person1.Item1}, Age: {person1.Item2}");

             // =============== Рекурсия

             int Factorial(int n)
             {
                 if (n == 1) return 1;

                 return n * Factorial(n - 1);
             }

             int factorial4 = Factorial(4);

               //=================================\\
              //============= Классы ==============\\
             //=====================================\\

             EmptyClass emptyClass = new EmptyClass();
             Person person = new Person();

             person.Print();

             person.name = "Slava";
             person.age = 25;
             person.Print();

             // =============== Конструктор

             PersonWithConstructor personWithConstructor = new PersonWithConstructor();
             personWithConstructor.Print();

             CustomConstructor customConstructor1 = new CustomConstructor(10);
             CustomConstructor customConstructor2 = new CustomConstructor("text");
             customConstructor1 = new CustomConstructor("newText");

             PersonThis personThis = new PersonThis();

             // Цепочки

             PersonChain personChain1 = new PersonChain();
             PersonChain personChain2 = new PersonChain("Slava");
             PersonChain personChain3 = new PersonChain("Slava", 25);

             personChain1.Print();
             personChain2.Print();
             personChain3.Print();*/

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

                            Phone phone1 = new Phone();
                            Phone phone2 = new Phone("79505633035", "Samsung");
                            Phone phone3 = new Phone("79196783923", "Apple", 205.3f);

                            Console.WriteLine("Проверка первого телефона:\n");
                            ShowInfoForFirstTask(phone1);

                            Console.WriteLine("\nПроверка второго телефона:\n");
                            ShowInfoForFirstTask(phone2);

                            Console.WriteLine("\nПроверка третьего телефона:\n");
                            ShowInfoForFirstTask(phone3);

                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("ЗАДАНИЕ 2\n");

                            bool session = true;
                            CreditCard creditCard1 = new CreditCard("23432523412542");
                            CreditCard creditCard2 = new CreditCard("67864654645645", 500.5f);
                            CreditCard creditCard3 = new CreditCard("89978435636345", 3842);

                            while (session)
                            {
                                Console.WriteLine("------\nВаши счета: ");
                                Console.Write("1) ");
                                creditCard1.GetInfoAccount();
                                Console.Write("2) ");
                                creditCard2.GetInfoAccount();
                                Console.Write("3) ");
                                creditCard3.GetInfoAccount();

                                Console.Write("\nВведите порядковый номер счета (чтобы завершить работу введите \"q\"): ");
                                string sequenceNumber = Console.ReadLine();

                                if (sequenceNumber == "1")
                                    OperationCreditCard(creditCard1);
                                else if (sequenceNumber == "2")
                                    OperationCreditCard(creditCard2);
                                else if (sequenceNumber == "3")
                                    OperationCreditCard(creditCard3);
                                else if (sequenceNumber == "q")
                                    break;
                            }

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

        // Методы для первой задачи
        static void ShowInfoForFirstTask (Phone phone)
        {
            string[] nameForReceiveCall = {"Иван", "Петр", "Семен", "Лена", "Катя", "Ирина"};
            string[] numberForSendMessage2 = {"79540982716", "79769062896"};
            string[] numberForSendMessage5 = {"79196784920", "79196487960", "79176754523", "79196704769", "79857484920"};
            Random rand = new Random();

            phone.Print();
            phone.receiveCall(nameForReceiveCall[rand.Next(nameForReceiveCall.Length)]);
            Console.WriteLine($"на номер телефона: {phone.getNumber()}. Звонок прошел.");
            phone.sendMessage(numberForSendMessage2);
            phone.sendMessage(numberForSendMessage5);
        }

        // Методы для второй задачи
        static void OperationCreditCard(CreditCard creditCard)
        {
            float amount;

            Console.Write("\nОперации:\n1) Пополнить счет;\n2) Снять со счета;\nВведите номер операции: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Write("Введите сумму для пополнения: ");
                        amount = Convert.ToSingle(Console.ReadLine());
                        creditCard.AddAmountToAccount(amount);
                        break;
                    }

                case "2":
                    {
                        Console.Write("Введите сумму для снятия: ");
                        amount = Convert.ToSingle(Console.ReadLine());
                        creditCard.TakeAmountToAccount(amount);
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка. Неверный номер операции! ");
                        break;
                    }
            }
        }
    }
}