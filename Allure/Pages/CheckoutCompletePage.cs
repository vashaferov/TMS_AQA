using OpenQA.Selenium;

namespace Allure.Pages;

public class CheckoutCompletePage : BasePage
{
    private static string END_POINT = "checkout-complete.html";
    
    private static readonly By BackButtonBy = By.Id("back-to-products");
    private static readonly By CompleteInfoBy = By.ClassName("complete-header");
    private static readonly By CompleteTextBy = By.ClassName("complete-text");
    
    public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CheckoutCompletePage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return BackButton.Displayed;
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
    
    public IWebElement BackButton => WaitsHelper.WaitForExists(BackButtonBy);
    public IWebElement CompleteInfo => WaitsHelper.WaitForExists(CompleteInfoBy);
    public IWebElement CompleteText => WaitsHelper.WaitForExists(CompleteTextBy);
}