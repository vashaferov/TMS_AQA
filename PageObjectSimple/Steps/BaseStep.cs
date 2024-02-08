using OpenQA.Selenium;

namespace PageObjectSimple.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}