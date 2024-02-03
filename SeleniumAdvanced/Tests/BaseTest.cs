using AngleSharp;
using NUnit.Framework;
using SeleniumAdvanced.Core;
using SeleniumAdvanced.Helpers.Configuration;
using OpenQA.Selenium;
using SeleniumAdvanced.Helpers;

namespace SeleniumAdvanced.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    protected WaitsHelper WaitsHelper { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}