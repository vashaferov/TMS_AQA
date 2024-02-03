using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using LogLevel = OpenQA.Selenium.LogLevel;

namespace SeleniumAdvanced.Core;

public class DriverFactory
{
    public IWebDriver? GetChromeDriver()
    {
        string downloadDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources");
        
        var chromeOptions = new ChromeOptions();
        // chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        chromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
        chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
        //chromeOptions.AddArguments("--headless");

        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        new DriverManager().SetUpDriver(new ChromeConfig());
        return new ChromeDriver(chromeOptions);
    }
}