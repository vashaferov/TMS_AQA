using Allure.Helpers.Configuration;
using Allure.Pages;
using Allure.Steps;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureSuite("Логин тесты")]
[AllureOwner("vashaferov")]
public class LoginTest : BaseTest
{
    [TestCase("standard_user")]
    [TestCase("problem_user")]
    [TestCase("performance_glitch_user")]
    [TestCase("error_user")]
    [TestCase("visual_user")]
    [Description("Проверка успешного входа")]
    public void SuccessLoginTest(string login)
    {
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(login, Configurator.AppSettings.Password);

        Assert.That(LoginSteps.CatalogPage.IsPageOpened());
    }
    
    [Test]
    [Description("Проверка входа без указания пароля")]
    public void IncorrectNoPasswordLoginTest()
    {
        LoginSteps.NavigateToLoginPage();
        LoginSteps.IncorrectLogin(Configurator.AppSettings.Username, "");

        Assert.That(LoginSteps.ErorrText(), Is.EqualTo("Epic sadface: Password is required"));
        StepAndScreenshot("Получена нужная ошибка");
    }
    
    [Test]
    [Description("Проверка входа c логином у которого закрыт доступ")]
    public void IncorrectLockedUserLoginTest()
    {
        LoginSteps.NavigateToLoginPage();
        LoginSteps.IncorrectLogin("locked_out_user", Configurator.AppSettings.Password);

        Assert.That(LoginSteps.ErorrText(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        StepAndScreenshot("Получена нужная ошибка");
    }
}