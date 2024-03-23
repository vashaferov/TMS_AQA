using System.Net;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpAPI.Models;

namespace RestSharpAPI.Tests;

public class SchemaTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    private const string BaseRestUri = "https://vashaferov2.testrail.io";
    
    [Test]
    public void JsonSchemaTest()
    {
        const string endPoint = "/index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "Project Xx",
            Announcement = "Welcome to project X",
            IsShowAnnouncement = true,
            SuiteMode = 3
        };
        
        //Загрузка и создание Json схемы из файла
        string schemaJson = File.ReadAllText(@"Resources/schema.json");
        
        JSchema schema = JSchema.Parse(schemaJson);
        
        // Setup Rest Client
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("jonirz55+1@gmail.com", "Qwerty12345."),
        };
        
        var client = new RestClient(options);
        
        // Setup Request
        Logger.Info("expectedProject: " + JsonSerializer.Serialize(expectedProject));
        
        var request = new RestRequest(endPoint)
            .AddJsonBody(expectedProject);
        
        // Execute Request
        var response = client.ExecutePost(request);
        
        Logger.Info("response: " + JsonSerializer.Serialize(response.Content));

        if (response.StatusCode == HttpStatusCode.OK)
        {
            // Получаем тело ответа в виде JObject
            JObject responseData = JObject.Parse(response.Content);
            
            Assert.That(responseData.IsValid(schema));
        }
    }
}