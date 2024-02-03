using OpenQA.Selenium;

namespace PageObjectSimple.Page;

public class BasePage
{
    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }
    
    protected IWebDriver Driver { get; private set; }
}