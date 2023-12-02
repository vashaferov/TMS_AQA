using System.Diagnostics;

namespace OOP;

public class Client
{
    public int Id;
    public string PhoneNumber;
    public string Email;

    public void Activate(){}
    public void Pause(){}
    public void Deactivate(){}

    public Client(int id)
    {
        Id = id;
    }

    // Перегрузка
    public void CountBill(int hours, int rate)
    {
        int result = hours * rate;
        Console.WriteLine("void CountBill: "+ result);
    }

    public void CountBill(int hours, int rate, int debit)
    {
        int result = hours * rate + debit;
        Console.WriteLine("void CountBill: " + result);
    }

    // Переопределение  
    public virtual void SendNotification()
    {
        Console.WriteLine("Base notification...");
    }
}                 