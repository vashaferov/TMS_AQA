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
        _texts = new List<string>();
        
        WaitsHelper _waitsHelper = new WaitsHelper(driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        foreach (var webElement in _waitsHelper.WaitForAllPresenceElementsLocatedBy(by))
        {
            UIElement uiElement = new UIElement(driver, webElement);
            // _uiElements.Add(uiElement.FindUIElement(By.XPath("//*[@id=\"template_id_chzn_o_0\"]")));
            _texts.Add(uiElement.FindUIElement(By.XPath("descendant::li")).Text.Trim());
            Console.WriteLine(uiElement.FindUIElement(By.XPath("descendant::li")).Text.Trim());
        }
    }

    public void SelectValue(string text)
    {
        _mainElement.Click();
        try
        {
            _uiElements[_texts.IndexOf(text)].Click();
        }
        catch (Exception e)
        {
            throw new AssertionException("Привышен индекс");
        }
    }
}