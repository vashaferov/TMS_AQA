namespace NativeSingleton.Models;

public class JSONObject1
{
    public string Name { get; set; }
    public int FieldValue { get; set; }
    public bool IsEnabled { get; set; }
    public object AnyObject { get; set; }
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(FieldValue)}: {FieldValue}, {nameof(IsEnabled)}: {IsEnabled}, {nameof(AnyObject)}: {AnyObject}";
    }
}