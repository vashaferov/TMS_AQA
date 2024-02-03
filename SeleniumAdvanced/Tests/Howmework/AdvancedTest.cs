using System.Net;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests.Howmework;

public class AdvancedTest : BaseTest
{
    [Test]
    [Description("Task1. Context Menu")]
    public void ContextMenuTest()
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
    
    [Test]
    [Description("Task2. Dynamic Controls")]
    public void DynamicControlsTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        Driver.FindElement(By.LinkText("Dynamic Controls")).Click();
        
        IWebElement removeButton = Driver.FindElement(By.XPath("//button[. = 'Remove']"));
        IWebElement checkboxElement = Driver.FindElement(By.Id("checkbox"));
        IWebElement elementInput = Driver.FindElement(By.XPath("//input[@type = 'text']"));
        IWebElement enableButton = Driver.FindElement(By.XPath("//button[. = 'Enable']"));
        
        var actions = new Actions(Driver);
        
        actions
            .Click(removeButton)
            .Build()
            .Perform();

        IWebElement messageRemoveElement = WaitsHelper.FluentWaitForElement(By.XPath("//form[1]/p"));
        Assert.That(messageRemoveElement.Text, Is.EqualTo("It's gone!"));
        Assert.That(WaitsHelper.WaitForElementInvisible(checkboxElement));
        
        Assert.That(!elementInput.Enabled);
        
        enableButton.Click();
        
        IWebElement messageEnableElement = WaitsHelper.FluentWaitForElement(By.XPath("//form[2]/p"));
        Assert.That(messageEnableElement.Text, Is.EqualTo("It's enabled!"));
        Assert.That(elementInput.Enabled);
    }
    
    [Test]
    [Description("Task3. File Upload")]
    public void FileUploadTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        Driver.FindElement(By.LinkText("File Upload")).Click();

        var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
        
        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
        
        fileUploadPath.SendKeys(filePath);
        
        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
    }
    
    [Test]
    [Description("Task4. Frames")]
    public void FramesTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        Driver.FindElement(By.LinkText("Frames")).Click();
        Driver.FindElement(By.LinkText("iFrame")).Click();

        Driver.SwitchTo().Frame("mce_0_ifr");
        
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//*[@id='tinymce']/p")).Text, Is.EqualTo("Your content goes here."));
    }
    
    [Test]
    [Description("Task5. File Download")]
    public void FileDownloadTest()
    {
        string downloadDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "LambdaTest.txt");
        
        if(File.Exists(downloadDirectory))
            File.Delete(downloadDirectory);
        
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/ ");
        
        Driver.FindElement(By.LinkText("File Download")).Click();
        Driver.FindElement(By.LinkText("LambdaTest.txt")).Click();
        
        Thread.Sleep(10000);

        Assert.That(File.Exists(downloadDirectory));
    }
}