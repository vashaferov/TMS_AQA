using OpenQA.Selenium;

namespace Allure.Pages;

public class CartPage : BasePage
{
    private static string END_POINT = "cart.html";
    
    private static readonly By CheckoutButtonBy = By.Id("checkout");
    private static readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");
    private static readonly By EmptyCatrItemBy = By.ClassName("removed_cart_item");
    private static readonly By TitleNameProductBy = By.XPath("//*[@id='item_0_title_link']/div");
    private static readonly By RemoveButtonBy = By.XPath("//*[@id='item_0_title_link']/parent::div/div[@class='item_pricebar']/button");
    
    public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CartPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return CheckoutButton.Displayed;
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
    
    public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
    public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(ContinueShoppingButtonBy);
    public IWebElement TitleNameProduct => WaitsHelper.WaitForExists(TitleNameProductBy);
    public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
    public IWebElement EmptyCartItem => WaitsHelper.WaitForExists(EmptyCatrItemBy);
}