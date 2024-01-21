namespace Delegate;

public class FormulaType
{
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
