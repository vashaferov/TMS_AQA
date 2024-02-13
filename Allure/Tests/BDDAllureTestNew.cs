using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class BDDAllureTestNew : BaseTest
{
    [Test]
    public void Story3Test()
    {
        AllureApi.AddEpic("Web interface");
        AllureApi.AddFeature("Essential feature");
        AllureApi.AddStory("Story3");
        
        Assert.That(true);
    }
}