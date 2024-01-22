// See https://aka.ms/new-console-template for more information

//new Example1().Run();

//new Example2().Run();

//new Example3().Run();

//new Example4().Run();

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

                new Sorts().Run();

                break;
            }
        case "4":
            {
                Console.WriteLine("ЗАДАНИЕ 4\n");

                Calendar calendar = new Calendar();
                calendar.Notify += calendar.Notification;

                List<Event> events = new List<Event>();
                events.Add(new Event("Title1", DateTime.Now, "Description1"));
                events.Add(new Event("Title2", DateTime.Now.AddDays(1), "Description2"));
                events.Add(new Event("Title3", DateTime.Now.AddDays(-1), "Description3"));

                foreach(var item in events)
                    calendar.Notification(item);

                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 4)");

                break;
            }
    }
}