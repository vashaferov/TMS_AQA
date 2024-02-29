using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NativeSingleton;

public class BrowserSingleton
{
    private static BrowserSingleton _instance;
    private static IWebDriver _driver;

    private BrowserSingleton()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);
        
        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver();
    }

    public static BrowserSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new BrowserSingleton();
        }

        return _instance;
    }

    public IWebDriver GrtDriver()
    {
        return _driver;
    }

    public void CloseDriver()
    {
        _driver.Quit();
    }
}