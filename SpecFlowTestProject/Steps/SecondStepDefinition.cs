using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTestProject.Driver;

namespace SpecFlowTestProject;

[Binding]
public class SecondStepDefinition
{
    private readonly Browser _browser;
    public SecondStepDefinition(Browser browser)
    {
        _browser = browser;
    }
        
    [Given(@"открыт браузер")]
    public void OpenBrowser()
    {
        Console.WriteLine("Браузер открыт");
        _browser.Driver = new ChromeDriver();
    }
}