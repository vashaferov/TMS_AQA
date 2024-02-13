using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

public class AllureTest : BaseTest
{
    [Test(Description = "Some detailed test description")]
    public void TestDescription()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    public void TestSeverity()
    {
        Assert.That(true);
    }

    [Test]
    [AllureIssue("TMS-123")]
    public void TestIssue()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureTms("Req-123")]
    public void TestTMS()
    {
        Assert.That(true);
    }
    
    [Test]
    [AllureLink("website", "http://aaa.ru")]
    public void TestLink()
    {
        Assert.That(true);
    }
}