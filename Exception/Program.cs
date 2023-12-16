using Exceptions;
using Exceptions.Task1;
using Exceptions.Task2;
using Exceptions.Task2.ExceptionsOrder;

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

                AuthorizationData authorizationData = new AuthorizationData();

                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                Console.Write("Подтвердите пароль: ");
                string confirmPassword = Console.ReadLine();

                if (AuthorizationData.CheckData(login, password, confirmPassword))
                {
                    authorizationData.Login = login;
                    authorizationData.Password = password;
                    Console.WriteLine("Регистрация прошла успешно!");
                }
                else
                    Console.WriteLine("Ошибка!");
                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");

                Order order = new Order();

                try
                {
                    Console.Write("Введите номер заказа: ");
                    order.NumberOrder = Convert.ToInt32(Console.ReadLine());
                }
                catch (InvalidOrderNumberException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message); 
                }
                try
                {
                    Console.Write("Введите список товаров: ");
                    order.Products = Console.ReadLine();
                }
                catch (EmptyOrderException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                try
                {
                    Console.Write("Введите данные для доставки: ");
                    order.DeliveryAddress = Console.ReadLine();
                }
                catch (DeliveryInformationMissingException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 2)");

                break;
            }
    }
}