namespace OOP;

public class Corporate : Client
{
    public int INN;
    public int UNP;

    public Corporate(int id) : base(id)
    {
    }

    public override void SendNotification()
    {
        base.SendNotification(); // вызов из баз. класса (можно убрать если нужно)
        Console.WriteLine("Corp Notification...");
    }
}