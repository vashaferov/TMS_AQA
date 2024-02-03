using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests.Howmework;

public class AdvancedTest : BaseTest
{
    [Test]
    [Description("Task1. Context Menu")]
    public void ContextMenu()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        Driver.FindElement(By.LinkText("Context Menu")).Click();
        
        IWebElement box = WaitsHelper.FluentWaitForElement(By.Id("hot-spot"));
        var actions = new Actions(Driver);
        
        actions
            .MoveToElement(box, 10, 10)
            .ContextClick()
            .Build()
            .Perform();
        
        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
        alert.Accept();
    }
}