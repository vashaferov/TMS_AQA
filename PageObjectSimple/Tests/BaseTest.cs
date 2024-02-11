using OpenQA.Selenium;
using PageObjectSimple.Steps;
using PageObjectSimple.Core;
using PageObjectSimple.Helpers;
using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected LoginSteps LoginSteps;
    protected CatalogSteps CatalogSteps;

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        // Инициализация Steps
        LoginSteps = new LoginSteps(Driver);
        CatalogSteps = new CatalogSteps(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}