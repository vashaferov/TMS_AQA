using System.Net;
using Microsoft.Extensions.Configuration;
using NLog;
using RestSharp;
using RestSharp.Authenticators;

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
        const string endPoint = "/api/users";
        
        // Setup Rest Client
        var client = new RestClient(BaseRestUri);
        
        // Setup Request
        var request = new RestRequest(endPoint);
        request.AddJsonBody("{\"name\":\"morpheus\",\"job\":\"leader\"}");
        
        // Execute Request
        var response = client.ExecutePost(request);
        
        Logger.Info(response.Content);
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
    }
}