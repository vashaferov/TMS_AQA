using OpenQA.Selenium;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    public CatalogPage CatalogPage => new CatalogPage(Driver, true);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}