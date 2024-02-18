using System.Text;
using Allure.Core;
using Allure.Helpers;
using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using OpenQA.Selenium;
using Allure.Pages;
using NUnit.Allure.Core;
using NUnit.Framework.Interfaces;

namespace Allure.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected LoginSteps LoginSteps;
    protected OrderSteps OrderSteps;
    protected CheckoutYourInformationSteps CheckoutYourInformationSteps;

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
        LoginSteps = new LoginSteps(Driver);
        OrderSteps = new OrderSteps(Driver);
        CheckoutYourInformationSteps = new CheckoutYourInformationSteps(Driver);
    }

    public void StepAndScreenshot(string stepText)
    {
        AllureApi.Step(stepText);
        
        Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
        byte[] scrBytes = screenshot.AsByteArray;
        
        AllureApi.AddAttachment($"Шаг: {stepText}","image/png", scrBytes);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] scrBytes = screenshot.AsByteArray;
            
            AllureApi.AddAttachment("error","image/png", scrBytes);
        }
        
        Driver.Quit();
    }
}