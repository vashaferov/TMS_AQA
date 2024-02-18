using OpenQA.Selenium;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    public CatalogPage CatalogPage => new CatalogPage(Driver);
    public CartPage CartPage => new CartPage(Driver);
    public CheckoutYourInformationPage CheckoutYourInformationPage => new CheckoutYourInformationPage(Driver);
    public CheckoutOverviewPage CheckoutOverviewPage => new CheckoutOverviewPage(Driver);
    public CheckoutCompletePage CheckoutCompletePage => new CheckoutCompletePage(Driver);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}