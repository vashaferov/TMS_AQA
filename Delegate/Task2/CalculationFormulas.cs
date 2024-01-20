namespace Delegate;

public class CalculationFormulas
{
    public delegate double Formula(double r);

    public void Run()
    {
        Console.Write("Введите радиус: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Formula formula1 = Circumference;
        Formula formula2 = Area;
        Formula formula3 = Volume;

        Console.WriteLine($"Длина окружности: {formula1(r)}");
        Console.WriteLine($"Площадь круга: {formula2(r)}");
        Console.WriteLine($"Объем шара: {formula3(r)}");
    }

    public double Circumference(double r)
    {
        return 2*Math.PI*r;
    } 

    public double Area(double r)
    {
        return Math.PI*Math.Pow(r, 2);
    } 

    public double Volume(double r)
    {
        return 4.0*Math.PI*Math.Pow(r, 3)/3.0;
    } 
}
