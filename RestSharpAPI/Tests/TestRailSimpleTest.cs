using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using NLog;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpAPI.Models;

namespace RestSharpAPI.Tests;

public class TestRailSimpleTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    private const string BaseRestUri = "https://vashaferov2.testrail.io";
    
    [Test]
    public void SimpleGetTest()
    {
        const string endPoint = "/index.php?/api/v2/get_user/1";
        
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("jonirz55+1@gmail.com", "Qwerty12345."),
        };
        
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        var request = new RestRequest(endPoint);
        
        // Execute Request
        var response = client.ExecuteGet(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
    
    [Test]
    public void AdvancedGetTest()
    {
        const string endPoint = "/index.php?/api/v2/get_user/{user_id}";
        
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("jonirz55+1@gmail.com", "Qwerty12345."),
        };
        
        // Setup Rest Client
        var client = new RestClient(options);
        
        // Setup Request
        var request = new RestRequest(endPoint)
            .AddUrlSegment("user_id", 1);
        
        // Execute Request
        var response = client.ExecuteGet(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
    
    [Test]
    public void SimplePostTest()
    {
        const string endPoint = "/index.php?/api/v2/add_project";

        Dictionary<string, object> json = new Dictionary<string, object>();
        json.Add("name", "Project X");
        json.Add("announcement", "Welcome to project X");
        json.Add("show_announcement", true);
        json.Add("suite_mode", 3);
        
        // Setup Rest Client
        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("jonirz55+1@gmail.com", "Qwerty12345."),
        };
        
        var client = new RestClient(options);
        
        // Setup Request
        Logger.Info(JsonSerializer.Serialize(json));
        
        var request = new RestRequest(endPoint)
            .AddJsonBody(JsonSerializer.Serialize(json));
        
        // Execute Request
        var response = client.ExecutePost(request);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        
        Logger.Info(response.Content);
        
        // Получаем тело ответа в объект JSON
        dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
        int id = jsonResponse!.id;

        Logger.Info("ID:" + id);
    }
    
    [Test]
    public void AdvancedPostTest()
    {
        const string endPoint = "/index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "Project Xx",
            Announcement = "Welcome to project X",
            IsShowAnnouncement = true,
            SuiteMode = 3
        };
        
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
        var response = client.ExecutePost<Project>(request);
        Project actualProject = response.Data;
        
        Logger.Info(actualProject);
        
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(actualProject.Name, Is.EqualTo(expectedProject.Name));
            Assert.That(actualProject.Equals(expectedProject));
        });
        
        // Получаем тело ответа в объект JSON
        
        int id = actualProject.Id;

        Logger.Info("ID:" + id);
    }
}