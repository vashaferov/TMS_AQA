using OpenQA.Selenium;

namespace Locators.Tests;

public class CssSelectorTest : BaseTest
{
    [Test]
    public void CssSelectorTest1()
    {
        Driver.Navigate().GoToUrl(@"file:C:\Users\vashaferov\source\repos\TMS_AQA\Locators\Resources\index.html");
        Thread.Sleep(2000);
        
        //по id
        Assert.That(Driver.FindElement(By.CssSelector("#my-Address")).Displayed);
        //по class name
        Assert.That(Driver.FindElement(By.CssSelector(".newsletter")).Displayed);
        //по нескольким class name
        Assert.That(Driver.FindElement(By.CssSelector(".noSel.newsletter")).Displayed);
        //по tag name
        Assert.That(Driver.FindElement(By.CssSelector("h1")).Displayed);
        //по tag и значению из аттрибута class
        Assert.That(Driver.FindElement(By.CssSelector("div.intro")).Displayed);
        //
        
    }
}