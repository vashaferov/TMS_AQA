using OpenQA.Selenium;

namespace SeleniumAdvanced.Tests.Howmework;

public class AdvancedTest : BaseTest
{
    [Test]
    public void ActionTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        // Task1. Context Menu
        Driver.FindElement(By.LinkText("Context Menu")).Click();
        
        
    }
}