using OpenQA.Selenium;

namespace Wrappers.Elements;

public class Checkbox 
{
    private UIElement _uiElement;
    public Checkbox(IWebDriver driver, By by)
    {
        _uiElement = new UIElement(driver, by);
    }
    
    // Метод принемает нужный статус для checkbox'а
    public void SelectCheckBoxStatus(bool flag)
    {
        if(string.IsNullOrEmpty(_uiElement.GetAttribute("::after")) == flag)
            _uiElement.Click();
    }

    public bool Displayed => _uiElement.Displayed;
}