using System.Text.Json;


namespace NativeSingleton.Helpers;

public class JSONHelper
{
    public static string SerializeHelper(object obj)
    {
        return JsonSerializer.Serialize(obj);
    }

    public static T DeserializeHelper<T>(string path)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        return JsonSerializer.Deserialize<T>(fs);
    }

}