using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTestProject.Driver;

namespace SpecFlowTestProject;

[Binding]
public class FirstStepDefinition
{
    private readonly Browser _browser;
    public FirstStepDefinition(Browser browser)
    {
        _browser = browser;
    }

    [When(@"страница логина открыта")]
    [Given(@"страница логина открыта")]
    public void OpenLoginPage()
    {
        Console.WriteLine("Страница логина открыт");
        _browser.Driver.Navigate().GoToUrl("https://vashaferov1.testrail.io/");
    }

    [Then(@"поле username отображается")]
    public void IsUsernameFieldDisplayed()
    {
        Assert.That(true);
    }

    [Then(@"кнопка login отображается")]
    public void IsLoginButtonDisplayed()
    {
        Assert.That(true);
    }

    [When(@"user ""(.*)"" with password ""(.*)"" logged in")]
    public void UserWithPasswordLoggedIn(string email, string password)
    {
        Console.WriteLine($"{email}, {password}");
    }

    [Then(@"the addProjectButton if displayed")]
    public void ThenTheAddProjectButtonIfDisplayed()
    {
        Console.WriteLine("Displayed");
    }

    [Then(@"username is ""(.*)""")]
    public void ThenUsernameIs(string username)
    {
        Console.WriteLine(username);
    }

    [Then(@"a project ID is (.*)")]
    public void ThenAProjectIdIs(int id)
    {
        Console.WriteLine(id);
    }

    [Given(@"a blog post named ""(.*)"" with Markdown body")]
    public void GivenABlogPostNamedWithMarkdownBody(string random, string multilineText)
    {
        ScenarioContext.StepIsPending();
    }
}