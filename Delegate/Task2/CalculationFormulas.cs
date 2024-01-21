namespace Delegate;

public class CalculationFormulas
{
    public delegate double Formula(double r);

    public void Run()
    {
        FormulaType formulaType = new FormulaType();

        Console.Write("Введите радиус: ");
        double r = Convert.ToDouble(Console.ReadLine());

        if(r > 0)
        {
            Formula formula1 = formulaType.Circumference;
            Formula formula2 = formulaType.Area;
            Formula formula3 = formulaType.Volume;

            Console.WriteLine($"Длина окружности: {formula1(r)}");
            Console.WriteLine($"Площадь круга: {formula2(r)}");
            Console.WriteLine($"Объем шара: {formula3(r)}");
        } else
            Console.WriteLine($"Введите радиус больше {r}");

        
    }

    
}
