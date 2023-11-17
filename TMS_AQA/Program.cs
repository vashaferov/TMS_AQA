// See https://aka.ms/new-console-template for more information
/*
const int MINUTS_IN_HOUER = 60;
string name;

Console.Write("Hello, World! Hi, ");
name = "Bob";
Console.WriteLine(name + ".");

// Подготовка данных

bool isWhiteBreadFresh = true;
ushort whiteBreadPrice = 50;
ushort butterPrice = 70;
ushort milkPrice = 60;
float milkFatPrec = 1.2F;
ushort icecreaPrec = 250;

Console.Write("Ввелите начальную сумму: ");
string? sumString = Console.ReadLine();
short sum = Convert.ToInt16(sumString);

string slip = "ЧЕК:\n";

if (sum > 0)
{
    if (isWhiteBreadFresh)
        if (sum >= whiteBreadPrice)
        {
            sum -= (short)whiteBreadPrice;
            slip += $"Батон - {whiteBreadPrice}\n";
        }
    else
        Console.WriteLine("Батон не свежый");

    if (sum >= butterPrice)
    {
        sum -= (short)butterPrice;
        slip += $"Масло - {butterPrice}\n";
    }

    if (milkFatPrec == 1.2F)
    {
        if (sum >= milkPrice)
        {
            sum -= (short)milkPrice;
            slip += $"Молоко - {milkPrice}\n";
        }
    }    
    else
        Console.WriteLine("Молоко не той жирности");

    if (sum >= icecreaPrec)
        Console.WriteLine($"{slip}Мороженое - {icecreaPrec}\nИтого: {(short)(sum-icecreaPrec)}"); 
    else
        Console.WriteLine($"{slip}\nИтого: {sum}");
}
else
    Console.WriteLine("Не дали ничего(");
*/

bool flag = true;

while (flag)
{
    Console.Write("Введите номер задания (от 1 до 4): ");
    string task = Console.ReadLine();
    Console.Clear();

    switch (task)
    {
        case "1":
            {
                try
                {
                    Console.WriteLine("ЗАДАНИЕ 1. Консольный калькулятор");
                    Console.Write("Введите первое число: ");
                    double firstNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("(\"+\" - сложение\n\"-\" - вычетание\n\"*\" - умножение\n\"/\" - деление)\nВыберите символ нужной операции: ");
                    string operatinMark = Console.ReadLine();
                    Console.Write("Введите второе число: ");
                    double secondNum = Convert.ToDouble(Console.ReadLine());

                    switch (operatinMark)
                    {
                        case "+":
                        {
                            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                            Console.ReadLine();
                            break;
                        }
                        case "-":
                        {
                            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                            Console.ReadLine();
                            break;
                        }
                        case "*":
                        {
                            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                            Console.ReadLine();
                            break;
                        }
                        case "/":
                        {
                            if (secondNum == 0)
                            {
                                Console.WriteLine($"{firstNum} / {secondNum} = Ошибка! Делить на ноль нельзя!\n");
                            }
                            else
                            {
                                Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
                            }
                            break;
                        } 
                        default: 
                        {
                            Console.WriteLine("Ошибка! Неизвестная операция!\n");

                            break;
                        }
                    }
                }
                catch 
                {
                    Console.WriteLine("Ошибка! Неверный формат ввода, введите число!\n");
                }

                break;
            }
        case "2":
            {
                bool checkRange = true;

                Console.WriteLine("ЗАДАНИЕ 2. Проверка попадания числа в промежуток");
                try
                {
                    while (checkRange)
                    {
                        Console.Write("Введите любое число от 50 до -50: ");
                        double numberForCheck = Convert.ToDouble(Console.ReadLine());
                        if (numberForCheck > 50 || numberForCheck < -50)
                        {
                            Console.WriteLine("Ошибка! Число не попало в исходный диапозн\n");
                            checkRange = false;
                        }
                        else
                        {
                            if (numberForCheck > 40 || numberForCheck < -40)
                                Console.WriteLine("Число не входит в промежутки\n");
                            else if (numberForCheck <= -10)
                                Console.WriteLine("Число входит в промежуток [-40; -10]\n");
                            else if (numberForCheck <= 0)
                                Console.WriteLine("Число входит в промежуток [-9; 0]\n");
                            else if (numberForCheck <= 10)
                                Console.WriteLine("Число входит в промежуток [1; 10]\n");
                            else
                                Console.WriteLine("Число входит в промежуток [10; 40]\n");
                        }
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Неверный формат ввода, введите число!\n");
                }

                break;
            }
        case "3":
            {
                bool flagAvailability = false;

                Console.WriteLine("ЗАДАНИЕ 3. Переводчик");
                Console.Write("Введите слово для перевода: ");
                string wordToTranslate = Console.ReadLine().ToLower().Trim();
                string[,] dictionaryToTranslate = new string[2, 10]{
                    {"cold", "warm", "hot", "sunny", "clear", "cloudy", "fog", "rain", "snow", "wind"},
                    {"холодно", "тепло", "жарко", "солнечно", "ясно", "облачно", "туман", "дождь", "снег", "ветер"}
                };
                for (int i = 0; i < dictionaryToTranslate.GetLength(1); i++)
                {
                    if (dictionaryToTranslate[1, i] == wordToTranslate)
                    {
                        Console.WriteLine("Перевод: " + wordToTranslate + " - " + dictionaryToTranslate[0, i]);
                        flagAvailability = true;
                    }
                } 
                if (!flagAvailability)
                    Console.WriteLine($"Перевод слова \"{wordToTranslate}\" отсутствует в словаре, попробуйте другое слово");

                break;
            }
        case "4":
            {
                Console.WriteLine("ЗАДАНИЕ 4. Проверка числа на четность");
                try
                {
                    Console.Write("Введите любое число: ");
                    int numberForCheck = Convert.ToInt32(Console.ReadLine());
                    //Первый метод
                    if (numberForCheck % 2 == 0)
                        Console.WriteLine("Число " + numberForCheck + " четное");
                    else
                        Console.WriteLine("Число " + numberForCheck + " нечетное");
                    //Второй метод
                    if (numberForCheck / 2.0 == Math.Round(numberForCheck / 2.0))
                        Console.WriteLine("Число " + numberForCheck + " четное");
                    else
                        Console.WriteLine("Число " + numberForCheck + " нечетное");
                }
                catch
                {
                    Console.WriteLine("Ошибка! Неверный формат ввода, введите число!\n");
                }

                break;
            }
        default:
            {
                Console.WriteLine("Не распознан номер задания, попробуйте снова.");
                break;
            }
    }
}