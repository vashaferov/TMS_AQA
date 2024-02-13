using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureEpic("Web interface")]
[AllureFeature("Essential feature", "Integration feature")]
public class BDDAllureTest : BaseTest
{
    [Test]
    [AllureStory("Story1")]
    public void Story1Test()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureStory("Story2")]
    public void Story2Test()
    {
        Assert.That(true);
    }
}