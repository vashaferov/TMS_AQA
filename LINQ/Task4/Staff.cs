namespace LINQ;

public class Staff
{
    public string Lastname {get; set;}
    public string Specialty {get; set;}

    public Staff(string lastname, string specialty)
    {
        Lastname = lastname;
        Specialty = specialty;
    }
}
