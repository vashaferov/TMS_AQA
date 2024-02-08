using OpenQA.Selenium;
using PageObjectSimple.Helpers;
using PageObjectSimple.Helpers.Configuration;

namespace PageObjectSimple.Page;

public abstract class BasePage
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    
    public BasePage(IWebDriver driver) 
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }
    
    public BasePage(IWebDriver driver, bool openPageByURL)
    {
        Driver = driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        if (openPageByURL)
        {
            OpenPageByURL();
        }
    }

    protected abstract string GetEndpoint();
    public abstract bool IsPageOpened();
    
    protected void OpenPageByURL()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
    }
}