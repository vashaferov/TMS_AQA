using System.Net;
using NLog;
using RestSharp;

namespace RestSharpAPI.Tests;

public class ReqresinTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    private const string BaseRestUri = "https://reqres.in";
    
    [Test]
    public void SimpleGetTest()
    {
        const string endPoint = "/api/users/2";
        
        // Setup Rest Client
        var client = new RestClient(BaseRestUri);
        
        // Setup Request
        var request = new RestRequest(endPoint);
        
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