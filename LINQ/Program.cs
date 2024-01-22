// See https://aka.ms/new-console-template for more information
using LINQ;
using System.Net.Http.Headers;

//TestTask testTask= new TestTask();
//testTask.Solve();

//BaseSyntax baseSyntax= new BaseSyntax();
//baseSyntax.RunQuerySyntax();
//baseSyntax.RunMethodSyntax();

//new Where().RunQuerySyntax();
//new Where().RunMethodSyntax();

//new Select().RunQuerySyntax();
//new Select().RunMethodSyntax();

//new TwoInOne().run();

//new Variables().RunQuerySyntax();
//new Variables().RunMethodSyntax();

//new DataAggregation().RunQuerySyntax();
//new DataAggregation().RunMethodSyntax();

//new OrderBy().RunQuerySyntax();

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

                int[] numbers = {3, 2, 3, 6, 7, 5, 2, 9, 2, 6, 9};

                Console.WriteLine("Последовательность ДО: ");
                foreach(var num in numbers)
                    Console.Write(num + " ");

                IEnumerable<int> numQuery =
                    (from num in numbers
                    where num % 2 != 0 
                    select num).Distinct();

                Console.WriteLine("\nПоследовательность ПОСЛЕ: ");
                foreach(var num in numQuery)
                    Console.Write(num + " ");
                Console.WriteLine();

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");

                List<Client> clientList = new List<Client>();
                clientList.Add(new Client(1, 2024, 5, 10));
                clientList.Add(new Client(2, 2024, 10, 30));
                clientList.Add(new Client(3, 2024, 8, 16));
                clientList.Add(new Client(4, 2024, 3, 10));

                foreach(var c in clientList)
                    Console.WriteLine($"Код клиента: {c.Code}, Год: {c.Year}, Месяц: {c.Month}, Продолжительность: {c.Duration}");

                Client result = clientList.GroupBy(x => x.Duration).Select(g => g.Last()).MinBy(x => x.Duration);

                Console.WriteLine($"\nПродолжительность: {result.Duration}, Год: {result.Year}, Месяц: {result.Month}");

                break;
            }
        case "3":
            {
                Console.WriteLine("ЗАДАНИЕ 3\n");

                List<string> strings = new List<string>()
                {
                    "ASDASDAS",
                    "ASDASEEWRSA",
                    "PKSDLFDPLSMF",
                    "OPKA",
                    "OEKRTOIRE",
                    "ASDASEEWTSA"
                };

                Console.WriteLine("Исходная последовательность:");
                foreach(var s in strings)
                    Console.WriteLine(s);

                var result = strings.OrderBy(s => s.Length).ThenByDescending(s => s).ToList();

                Console.WriteLine("Последовательность после сортировки:");
                foreach(var r in result)
                    Console.WriteLine(r);

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