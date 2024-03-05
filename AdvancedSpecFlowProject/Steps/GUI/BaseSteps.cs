using CoreProject.Core;
using OpenQA.Selenium;

namespace AdvancedSpecFlowProject.Steps;

public class BaseGuiSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext Context { get; }

    public BaseGuiSteps(Browser browser, ScenarioContext context)
    {
        Driver = browser.Driver;
        Context = context;
    }
}