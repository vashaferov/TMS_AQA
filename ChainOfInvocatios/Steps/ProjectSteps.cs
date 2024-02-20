using ChainOfInvocatios.Pages.ProjectPages;
using OpenQA.Selenium;

namespace ChainOfInvocatios.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectSteps(IWebDriver driver) : base(driver)
    {
    }

    public void NavigateToAddProjectPage()
    {
        new AddProjectPage(Driver, true);
    }
}