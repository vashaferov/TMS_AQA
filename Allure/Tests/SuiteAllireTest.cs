using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureParentSuite("Web interface")]
[AllureSuite("Integration feature")]
public class SuiteAllireTest : BaseTest
{
    [Test]
    [AllureSubSuite("SubSuite1")]
    public void SuiteTest()
    {
        Assert.That(true);
    }
}