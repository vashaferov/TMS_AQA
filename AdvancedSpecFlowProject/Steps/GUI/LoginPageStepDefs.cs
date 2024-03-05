using CoreProject.Core;
using CoreProject.Pages;
using NUnit.Framework;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public class LoginPageStepDefs : BaseGuiSteps
{
    private readonly LoginPage _loginPage;

    public LoginPageStepDefs(Browser browser, ScenarioContext context) : base(browser, context)
    {
        _loginPage = new LoginPage(Driver);
    }

    [When(@"user enter ""(.*)"" to the email field")]
    public void EnterEmail(string email)
    {
        _loginPage.SetEmail(email);
    }

    [When(@"user enter ""(.*)"" password field")]
    public void EnterPassword(string password)
    {
        _loginPage.SetPassword(password);
    }

    [When(@"user click the log in button")]
    public void ClickTheLogInButton()
    {
        _loginPage.LoginInButton.Click();
    }

    [Then("user is successful logged in")]
    public void IsSuccessfulLoggedIn()
    {
        Assert.That(new DashboardPage(Driver).SidebarProjectsAddButton.Displayed);
    }

    [Then(@"error ""(.*)"" is displayed")]
    public void IsErrorDisplayed(string error)
    {
        Assert.That(_loginPage.ErrorLabel.Text.Trim(), Is.EqualTo(error));
    }
}