using Allure.Pages;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace Allure.Steps;

public class LoginSteps : BaseStep
{
    public LoginSteps(IWebDriver driver) : base(driver)
    {
    }
    
    [AllureStep("Переход на страницу ввода логина")]
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }
    
    [AllureStep("Успешный вход в систему")]
    public CatalogPage SuccessfulLogin(string username, string psw)
    {
        Login(username, psw);
        return CatalogPage;
    }

    [AllureStep("Неуспешный вход в систему")]
    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        return LoginPage;
    }
    
    [AllureStep("Получение ошибки")]
    public string ErorrText()
    {
        return LoginPage.ErrorContainer.Text;
    }

    private void Login(string username, string psw)
    {
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(psw);
        LoginPage.LoginButtonClick();
    }
}