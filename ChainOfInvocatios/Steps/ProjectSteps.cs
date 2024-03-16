using ChainOfInvocatios.Pages;
using ChainOfInvocatios.Pages.ProjectPages;
using OpenQA.Selenium;

namespace ChainOfInvocatios.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectSteps(IWebDriver driver) : base(driver)
    {
        AddProjectPage addProjectPage = new AddProjectPage(Driver);
        DashboardPage dashboardPage = new DashboardPage(Driver);
    }

    public void NavigateToAddProjectPage()
    {
        new AddProjectPage(Driver, true);
    }
}