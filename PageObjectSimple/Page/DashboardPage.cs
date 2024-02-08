using OpenQA.Selenium;

namespace PageObjectSimple.Page;

public class DashboardPage : BasePage
{
    private static string END_POINT;
    
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    
    public DashboardPage(IWebDriver driver) : base(driver)
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