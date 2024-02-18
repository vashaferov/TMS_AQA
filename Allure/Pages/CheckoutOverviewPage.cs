using OpenQA.Selenium;

namespace Allure.Pages;

public class CheckoutOverviewPage : BasePage
{
    private static string END_POINT = "checkout-step-two.html";
    
    private static readonly By FinishButtonBy = By.Id("finish");
    private static readonly By CancelButtonBy = By.Id("cancel");
    private static readonly By TitleNameProductBy = By.XPath("//*[@id='item_0_title_link']/div");
    
    public CheckoutOverviewPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CheckoutOverviewPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return FinishButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
    public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);
    public IWebElement TitleNameProduct => WaitsHelper.WaitForExists(TitleNameProductBy);
}