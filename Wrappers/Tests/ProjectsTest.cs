using WebDriverManager;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Tests;

public class ProjectsTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        ProjectSteps.NavigateToAddProjectPage();

        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        
        addProjectPage.ProjectTypeRB.SelectByIndex(1);
        addProjectPage.ProjectTypeRB.SelectByValue("3");
    }
}