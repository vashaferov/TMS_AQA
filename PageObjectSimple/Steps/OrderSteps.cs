using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObjectSimple.Helpers.Configuration;

namespace PageObjectSimple.Steps;

public class OrderSteps : BaseStep
{
    public OrderSteps(IWebDriver driver) : base(driver)
    {
    }
    
    public void AddProductToCart()
    {
        CatalogPage.AddToCartButton.Click();
        CatalogPage.ShoppingCartBadge.Click();
    }
    
    public void ChangeSortSelect(string textValue)
    {
        SelectElement sortSelect = new SelectElement(CatalogPage.SortSelect);
        sortSelect.SelectByText(textValue);
    }
}