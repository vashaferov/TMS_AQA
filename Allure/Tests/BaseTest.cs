using Allure.Core;
using Allure.Helpers;
using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using NUnit.Allure.Core;
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
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}