using System.Reflection;
using Pattern.Helpers.Configuration;
using Pattern.Models;

namespace Pattern.Tests;

public class ProjectTest : BaseTest
{
    [Test(Description = "ChainOfInvocations")]
    public void AddNewProjectTest1()
    {
        string projectName = $"TestProject_{DateTime.Now}";

        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .SidebarProjectsAddButton.Click();

        Assert.That(_projectSteps
                .SuccessfulAddProject(projectName, "Test Description", true,
                    "Use a single repository with baseline support", false).ProjectTable
                .GetCell("Project", projectName, "Project").Text.Trim(),
            Is.EqualTo(projectName));
    }

    [Test(Description = "ValueOfObjects")]
    public void AddNewProjectTest2()
    {
        Project expectedProject = new Project()
        {
            ProjectName = $"TestProject_{DateTime.Now}",
            Announcement = "Test Details",
            ShowAnnouncementFlag = false,
            ProjectType = "Use a single repository with baseline support",
            EnableTestCaseApprovalsFlag = false
        };

        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .SidebarProjectsAddButton.Click();

        Assert.That(_projectSteps
                .SuccessfulAddProjectUseObject(expectedProject).ProjectTable
                .GetCell("Project", expectedProject.ProjectName, "Project").Text.Trim(),
            Is.EqualTo(expectedProject.ProjectName));
    }

    [Test(Description = "ValueOfObjects + Builder")]
    public void AddMilestoneTest()
    {
        Milestone expectedMilestone = new Milestone()
        {
            MilestoneName = $"TestMilestone_{DateTime.Now}",
            References = $"Test References",
            Description = "Test Description",
            EndDate = "4/16/2024",
            IsMilestoneCompleted = false,
        };

        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .FirstProjectLinkClick()
            .AddNewMilestone();

        Assert.That(_projectSteps
            .AddNewMilestone(expectedMilestone)
            .FirstMilestone.Text.Trim(), Is.EqualTo(expectedMilestone.MilestoneName));
    }
}