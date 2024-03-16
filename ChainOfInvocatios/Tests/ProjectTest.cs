using ChainOfInvocatios.Helpers.Configuration;

namespace ChainOfInvocatios.Tests;

public class ProjectTest: BaseTest
{
    [Test]
    public void AddProjectTest()
    {
        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .SidebarProjectsAddButton.Click();
        Thread.Sleep(2000);
    }
}