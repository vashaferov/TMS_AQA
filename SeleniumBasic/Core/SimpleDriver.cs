using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumBasic.Core;

public class SimpleDriver
{
    public IWebDriver Driver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return new ChromeDriver(basePath + @"/Resources/");
        }
    }
}