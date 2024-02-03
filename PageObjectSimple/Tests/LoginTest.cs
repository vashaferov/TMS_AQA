using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Page;

namespace PageObjectSimple.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        
        var loginPage = new LoginPage(Driver);
        loginPage.EmailInput().SendKeys(Configurator.AppSettings.Username);
    }
}