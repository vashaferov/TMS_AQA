using OpenQA.Selenium;

namespace PageObjectSimple.Pages;

public class CheckoutYourInformationPage : BasePage
{
    private static string END_POINT = "checkout-step-one.html";
    
    private static readonly By ContinueButtonBy = By.Id("continue");
    private static readonly By CancelButtonBy = By.Id("cancel");
    private static readonly By FirstNameInputBy = By.Id("first-name");
    private static readonly By LastNameInputBy = By.Id("last-name");
    private static readonly By PostalCodeInputBy = By.Id("postal-code");
    
    public CheckoutYourInformationPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CheckoutYourInformationPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return ContinueButton.Displayed;
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
    
    public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
    public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);
    public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
    public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
    public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
}