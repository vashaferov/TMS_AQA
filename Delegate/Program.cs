// See https://aka.ms/new-console-template for more information

//new Example1().Run();

//new Example2().Run();

//new Example3().Run();

//new Example4().Run();

using System.Security.Cryptography.X509Certificates;
using Delegate;
using Delegate.Task1;


bool flag = true;
string task;

while (flag)
{
    Console.Write("-------\nВведите номер задания (от 1 до 4): ");
    task = Console.ReadLine();

    switch (task)
    {
        case "1":
            {
                Console.WriteLine("ЗАДАНИЕ 1\n");

                new DelegateForRandomNumbers().Run();

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");
                               
                new CalculationFormulas().Run();

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