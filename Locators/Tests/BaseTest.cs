using Locators.Core;
using NUnit.Framework;
using Locators.Helpers.Configuration;
using OpenQA.Selenium;

namespace Locators.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
        // Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}