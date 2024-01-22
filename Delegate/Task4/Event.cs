namespace Delegate;

public class Event
{
    public string Title {get; set;}
    public DateTime DateEvent {get; set;}
    public string Description {get; set;}

    public Event (string title, DateTime dateTime, string description)
    {
        Title = title;
        DateEvent = dateTime;
        Description = description;
    }
}
