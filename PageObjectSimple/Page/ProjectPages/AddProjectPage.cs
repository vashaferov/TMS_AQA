using OpenQA.Selenium;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Page;

public class AddProjectPage : BasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    
    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    public IWebElement TitleLabel() => WaitsHelper.WaitForExists(TitleLabelBy);
    
    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }


    
}