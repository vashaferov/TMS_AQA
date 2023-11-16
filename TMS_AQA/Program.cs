// See https://aka.ms/new-console-template for more information

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

