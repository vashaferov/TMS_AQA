using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace NUnitTest.Core;

public class AdvancedDriver
{
    private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    
    public IWebDriver GetChromeDriver()
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArguments("--incognito");
        chromeOptions.AddArguments("--disable-gpu");
        chromeOptions.AddArguments("--disable-extensions");
        //chromeOptions.AddArguments("--headless");
            
        chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
        chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

        return new ChromeDriver(path + @"/Resources/", chromeOptions);
    }
}