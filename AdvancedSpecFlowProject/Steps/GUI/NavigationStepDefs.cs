using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreProject.Core;
using CoreProject.Helpers.Configuration;
using CoreProject.Steps;
using TechTalk.SpecFlow;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public sealed class NavigationStepDefs : BaseGuiSteps
{
    private NavigationSteps _navigationSteps;

    public NavigationStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        
    }

    [Given("open the login page")]
    public void GivenOpenTheLoginPage()
    {
        Driver.Navigate().GoToUrl("https://vashaferov1.testrail.io/");
    }
}