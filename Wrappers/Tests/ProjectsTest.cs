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

    [Test]
    public void TestTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        Driver.Navigate().GoToUrl("https://vashaferov1.testrail.io/index.php?/cases/add/1");
        
        AddTestCasePage addTestCasePage = new AddTestCasePage(Driver);
        addTestCasePage.TemplateDropDown.SelectValue("Test Case (Steps)");
        Thread.Sleep(5000);
    }
}