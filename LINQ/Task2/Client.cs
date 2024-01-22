namespace LINQ;

public class Client
{
    public int Code {get; set;}
    public int Year {get; set;}
    public int Month {get; set;}
    public int Duration {get; set;}

    public Client(int code, int year, int month, int duration)
    {
        Code = code;
        Year = year;
        Month = month;
        Duration = duration;
    }
}
