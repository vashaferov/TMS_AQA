using PageObjectSimple.Helpers.Configuration;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(NavigationSteps.DashboardPage.IsPageOpened());
    }
}