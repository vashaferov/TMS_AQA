using Exceptions;

//ExcUsage excUsage = new ExcUsage();
////excUsage.Template();
//excUsage.ManyCatch();
//excUsage.FilterCatch(0, 1);

//ThrowExceptions throwExceptions = new ThrowExceptions();
//throwExceptions.CheckUsername();

//CustomExceptionUsage customExceptionUsage = new CustomExceptionUsage();
////customExceptionUsage.Run();
////customExceptionUsage.ProcessInput("  ");
//customExceptionUsage.UseCustomArgumentException();

bool flag = true;
string task;

while (flag)
{
    Console.Write("-------\nВведите номер задания (от 1 до 2): ");
    task = Console.ReadLine();
    Console.Clear();

    switch (task)
    {
        case "1":
            {
                Console.WriteLine("ЗАДАНИЕ 1\n");

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");

                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 3)");

                break;
            }
    }
}