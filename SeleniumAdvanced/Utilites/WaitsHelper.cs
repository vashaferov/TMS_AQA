using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAdvanced.Utilites;

public class WaitsHelper(IWebDriver driver, TimeSpan timeout)
{
    private readonly WebDriverWait _wait = new WebDriverWait(driver, timeout);
    
    public IWebElement WaitForExists(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementExists(locator));
    }
    
    public ReadOnlyCollection<IWebElement> WaitForAllVisibleElementsLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
    }
    
    // Ожидание видимости элемента
    public IWebElement WaitForVisibilityLocatedBy(By locator)
    {
        return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }
    
    // Ожидание невидимости элемента
    public bool WaitForElementInvisible(IWebElement element)
    {
        try
        {
            // Проверка, видим ли элемент
            return _wait.Until(d => !element.Displayed);
        }
        catch (NoSuchElementException)
        {
            // Если элемент не найден, считаем его невидимым
            return true;
        }
        catch (StaleElementReferenceException)
        {
            // Если элемент устарел, считаем его невидимым
            return true;
        }
        catch (WebDriverTimeoutException)
        {
            // Если время истекло, можно сделать что-то в этом случае, например, вывести сообщение об ошибке
            throw new WebDriverTimeoutException("Элемент не стал невидимым в течение заданного времени");
        }
    }
    
    public bool WaitForVisibility(IWebElement element)
    {
        return _wait.Until(_ => element.Displayed);
    }

    public IWebElement FluentWaitForElement(By locator)
    {
        WebDriverWait fluentWait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
        {
            PollingInterval = TimeSpan.FromMilliseconds(50),
        };
        fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

        return fluentWait.Until(d => driver.FindElement(locator));
    }
}