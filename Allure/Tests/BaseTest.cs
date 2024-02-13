using System.Text;
using Allure.Core;
using Allure.Helpers;
using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Allure.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps NavigationSteps;
    protected ProjectSteps ProjectSteps;
    protected AllureSteps AllureSteps;

    [OneTimeSetUp]
    public static void GlobalSetup()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        // Инициализация Steps
        NavigationSteps = new NavigationSteps(Driver);
        ProjectSteps = new ProjectSteps(Driver);
        AllureSteps = new AllureSteps(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        {
            // IWebElement test = Driver.FindElement(By.Id("sss"));
            // Screenshot screenshotElement = ((ITakesScreenshot)test).GetScreenshot();
            // byte[] scrEBytes = screenshot.AsByteArray;
            
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] scrBytes = screenshot.AsByteArray;
            
            // Вариант 1 
            // AllureLifecycle.Instance.AddAttachment("scr","image/png", scrEBytes);
            
            // Вариант 2
            AllureApi.AddAttachment("scr","image/png", scrBytes);
            AllureApi.AddAttachment("data.txt", "text/plain", Encoding.UTF8.GetBytes("asd")); // так можно добавить и другие файлы
        }
        
        Driver.Quit();
    }
}