using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjectSimple.Steps;

public class CatalogSteps : BaseStep
{
    public CatalogSteps(IWebDriver driver) : base(driver)
    {
    }
    
    public void ClickAddOrRemoveButton()
    {
        CatalogPage.AddToCartButton.Click();
    }
    
    public void ChangeSortSelect(string textValue)
    {
        SelectElement sortSelect = new SelectElement(CatalogPage.SprtSelect);
        sortSelect.SelectByText(textValue);
    }
}