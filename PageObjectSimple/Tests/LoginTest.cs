using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Page;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        Assert.That(new LoginPage(Driver).SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .IsPageOpened);
        
        Assert.That(UserSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password).TitleLabel().Text.Trim(), Is.EqualTo("All Projects"));
    }
}