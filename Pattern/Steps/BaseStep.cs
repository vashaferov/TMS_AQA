using OpenQA.Selenium;
using Pattern.Pages;
using Pattern.Pages.ProjectPages;

namespace Pattern.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
    protected ProjectPage? ProjectPage { get; set; }
    protected ProjectOverviewPage? ProjectOverviewPage { get; set; }
    protected AddMilestonePage? AddMilestonePage { get; set; }
}