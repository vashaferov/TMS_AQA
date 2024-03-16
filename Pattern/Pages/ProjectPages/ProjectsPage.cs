using OpenQA.Selenium;
using Pattern.Elements;

namespace Pattern.Pages.ProjectPages;

public class ProjectPage : BasePage
{
    private static string END_POINT = "index.php?/admin/projects/overview";
    
    private static readonly By MessageStatusBy = By.ClassName("message");
    private static readonly By ProjectTableBy = By.ClassName("grid");
    
    public ProjectPage(IWebDriver driver) : base(driver)
    {
    }

    public ProjectPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }
    
    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        try
        {
            return ProjectTable.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    public UIElement MessageStatus => new (Driver, MessageStatusBy);
    public Table ProjectTable => new (Driver, ProjectTableBy);
}