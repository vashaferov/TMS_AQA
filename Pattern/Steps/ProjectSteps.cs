using OpenQA.Selenium;
using Pattern.Models;
using Pattern.Pages;
using Pattern.Pages.ProjectPages;

namespace Pattern.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectSteps(IWebDriver driver) : base(driver)
    {
    }

    public ProjectPage SuccessfulAddProject(string projectName, string projectDescription, bool showAnnouncement,
        string projectType, bool enableApproval) => AddProject<ProjectPage>(projectName, projectDescription,
        showAnnouncement, projectType, enableApproval);

    public ProjectPage SuccessfulAddProjectUseObject(Project project) => AddProjectUseObject<ProjectPage>(project);
    public ProjectOverviewPage AddNewMilestone(Milestone milestone) => AddMilestone<ProjectOverviewPage>(milestone);

    private T AddProject<T>(string projectName, string projectDescription, bool showAnnouncement, string projectType,
        bool enableApproval) where T : BasePage
    {
        AddProjectPage = new AddProjectPage(Driver);

        AddProjectPage.NameProjectInput.SendKeys(projectName);
        AddProjectPage.AnnouncementTextarea.SendKeys(projectDescription);
        AddProjectPage.ShowAnnouncementCheckbox.SelectCheckBoxStatus(showAnnouncement);
        AddProjectPage.ProjectTypeRB.SelectByText(projectType);
        AddProjectPage.EnableTestCaseApprovalsCheckbox.SelectCheckBoxStatus(enableApproval);
        AddProjectPage.AddProjectButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }

    private T AddProjectUseObject<T>(Project project) where T : BasePage
    {
        AddProjectPage = new AddProjectPage(Driver, true);

        AddProjectPage.NameProjectInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextarea.SendKeys(project.Announcement);
        AddProjectPage.ShowAnnouncementCheckbox.SelectCheckBoxStatus(project.ShowAnnouncementFlag);
        AddProjectPage.ProjectTypeRB.SelectByText(project.ProjectType);
        AddProjectPage.EnableTestCaseApprovalsCheckbox.SelectCheckBoxStatus(project.EnableTestCaseApprovalsFlag);
        AddProjectPage.AddProjectButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }

    private T AddMilestone<T>(Milestone milestone) where T : BasePage
    {
        AddMilestonePage = new AddMilestonePage(Driver, false);

        AddMilestonePage.NameMilestoneInput.SendKeys(milestone.MilestoneName);
        AddMilestonePage.ReferencesInput.SendKeys(milestone.References);
        AddMilestonePage.DescriptionInput.SendKeys(milestone.Description);
        AddMilestonePage.EndDateInput.SendKeys(milestone.EndDate);

        AddMilestonePage.AddButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}