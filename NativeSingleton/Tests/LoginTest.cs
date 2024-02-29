using OpenQA.Selenium;

namespace NativeSingleton.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        IWebDriver driver = BrowserSingleton.GetInstance().GrtDriver();
        driver.Navigate().GoToUrl("http://google.com");
    }
}