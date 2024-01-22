namespace Delegate;

public class Calendar
{
    public delegate void NotificationEvent(Event _event);
    public event NotificationEvent Notify;

    public void Notification(Event _event)
    {       
        if(DateTime.Now.Date.CompareTo(_event.DateEvent.Date) == 0)
        {
            Console.WriteLine($"!!!Название: {_event.Title}, Дата: {_event.DateEvent}, Описание: {_event.Description}!!!");
        } else
            Console.WriteLine($"Название: {_event.Title}, Дата: {_event.DateEvent}, Описание: {_event.Description}");            
    }
}
