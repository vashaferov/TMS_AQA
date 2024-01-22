namespace LINQ;

public class Sheet
{
    public string Lastname {get; set;}
    public int Salary {get; set;}

    public Sheet(string lastname, int salary)
    {
        Lastname = lastname;
        Salary = salary;
    }
}
