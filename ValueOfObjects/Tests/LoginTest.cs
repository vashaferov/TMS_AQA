using NativeSingleton.Helpers.Configuration;
using NativeSingleton.Pages;

namespace NativeSingleton.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        Assert.That(_navigationSteps.SuccessfulLogin(Admin).SidebarProjectsAddButton.Displayed);
    }
}