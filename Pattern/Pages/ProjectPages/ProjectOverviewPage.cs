using OpenQA.Selenium;
using Pattern.Elements;

namespace Pattern.Pages.ProjectPages;

public class ProjectOverviewPage : BasePage
{
    private static readonly By MilestonesLinkBy = By.Id("sidebar-milestones-overview");
    private static readonly By AddMilestonesLinkBy = By.Id("navigation-milestones-add");
    private static readonly By MessageStatusBy = By.ClassName("message");
    private static readonly By FirstMilestoneBy = By.XPath("//*[@id='active_block']/descendant::a[1]");
    
    public ProjectOverviewPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public ProjectOverviewPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return MilestonesLink.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }
    
    public UIElement MilestonesLink => new (Driver, MilestonesLinkBy);
    public UIElement AddMilestonesLink => new (Driver, AddMilestonesLinkBy);
    public UIElement MessageStatus => new (Driver, MessageStatusBy);
    public UIElement FirstMilestone => new (Driver, FirstMilestoneBy);

    public void AddNewMilestone()
    {
        MilestonesLink.Click();
        AddMilestonesLink.Click();
    }
}