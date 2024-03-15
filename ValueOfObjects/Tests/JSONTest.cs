using System.Text.Json;
using NativeSingleton.Helpers;
using NativeSingleton.Models;

namespace NativeSingleton.Tests;

public class JSONTest
{
    [Test]
    public void JsonSerializerTest()
    {
        var testObject = new JSONObject1
        {
            Name = "Test Name",
            FieldValue = 10,
            IsEnabled = true,
            AnyObject = new string("Test Object")
        };

        var jsonString = JsonSerializer.Serialize<JSONObject1>(testObject);

        Console.WriteLine(jsonString);
    }
    
    [Test]
    public void JsonSerializerHelperTest()
    {
        var testObject = new JSONObject1
        {
            Name = "Test Name",
            FieldValue = 10,
            IsEnabled = true,
            AnyObject = new string("Test Object")
        };

        Console.WriteLine(JSONHelper.SerializeHelper(testObject));
    }

    [Test]
    public void JsonDeserializerTest1()
    {
        string jsonString =
            "{\"Name\":\"Test Name\",\"FieldValue\":10,\"IsEnabled\":true,\"AnyObject\":\"Test Object\"}";
        JSONObject1 jsonObject1 = JsonSerializer.Deserialize<JSONObject1>(jsonString);

        Console.WriteLine(jsonObject1);
    }

    [Test]
    public void JsonDeserializerTest2()
    {
        using FileStream fs = new FileStream(@"Resources/testObject1.json", FileMode.Open);
        JSONObject1 jsonObject1 = JsonSerializer.Deserialize<JSONObject1>(fs);

        Console.WriteLine(jsonObject1);
    }
    
    [Test]
    public void JsonDeserializerHelperTest()
    {
        Console.WriteLine(JSONHelper.DeserializeHelper<JSONObject1>("Resources/testObject1.json"));
    }


    [Test]
    public void JsonSerializerTest1()
    {
        List<JSONObject1> objects = new List<JSONObject1>();
        
        var testObject1 = new JSONObject1
        {
            Name = "Test Name1",
            FieldValue = 10,
            IsEnabled = true,
            AnyObject = new string("Test Object1")
        };
        
        var testObject2 = new JSONObject1
        {
            Name = "Test Name2",
            FieldValue = 5,
            IsEnabled = false,
            AnyObject = new string("Test Object2")
        };
        
        objects.Add(testObject1);
        objects.Add(testObject2);
        
        string jsonString = JsonSerializer.Serialize(objects);
        
        Console.WriteLine(jsonString);
    }

    [Test]
    public void JsonDeserializerTest3()
    {
        JSONHelper.DeserializeHelper<List<JSONObject1>>("Resources/testList.json").ForEach(Console.WriteLine);
    }
    
    [Test]
    public void JsonDeserializerTest4()
    {
        Console.WriteLine(JSONHelper.DeserializeHelper<JSONObject2>("Resources/testObject2.json"));
    }
}