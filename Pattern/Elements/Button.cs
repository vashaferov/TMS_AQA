using OpenQA.Selenium;

namespace Pattern.Elements;

public class Button
{
    private UIElement _uiElement;
        
    public Button(IWebDriver driver, By by)
    {
        _uiElement = new UIElement(driver, by);
    }
    
    public Button(IWebDriver driver, IWebElement webElement)
    {
        _uiElement = new UIElement(driver, webElement);
    }

    public void Click() => _uiElement.Click();
        
    public string Text => _uiElement.Text;
        
    public void Submit() => _uiElement.Submit();
    
    public bool Displayed => _uiElement.Displayed;
}