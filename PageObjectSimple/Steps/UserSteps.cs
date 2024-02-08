using OpenQA.Selenium;
using PageObjectSimple.Page;

namespace PageObjectSimple.Steps;

public class UserSteps : BaseStep
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.UsernameInput.SendKeys(username);
        _loginPage.PasswordInput.SendKeys(password);
        _loginPage.LoginButton.Click();

        return new DashboardPage(Driver);
    }
}