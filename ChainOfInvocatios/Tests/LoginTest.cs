using ChainOfInvocatios.Helpers.Configuration;

namespace ChainOfInvocatios.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }
}