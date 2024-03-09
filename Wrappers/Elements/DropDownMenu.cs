using OpenQA.Selenium;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements;

public class DropDownMenu
{
    private UIElement _mainElement;
    private List<UIElement> _uiElements;
    private List<string> _texts;

    public DropDownMenu(IWebDriver driver, By by)
    {
        _mainElement = new UIElement(driver, by);
        _uiElements = new List<UIElement>();
        _texts = new List<string>();

        _mainElement.Click();
        foreach (var webElement in _mainElement.FindUIElements(By.XPath("descendant::li")))
        {
            _uiElements.Add(webElement);
            _texts.Add(webElement.Text.Trim());
        }
        _mainElement.Click();
    }

    public void SelectText(string text)
    {
        _mainElement.Click();
        try
        {
            _uiElements[_texts.IndexOf(text)].Click();
        }
        catch (Exception e)
        {
            throw new AssertionException("По искомому тексту не найден элемент");
        }
    }
    
    public void SelectIndex(int index)
    {
        _mainElement.Click();
        try
        {
            _uiElements[index].Click();
        }
        catch (Exception e)
        {
            throw new AssertionException("По искомому индексу не найден элемент");
        }
    }
    
    public bool Displayed => _mainElement.Displayed;
}