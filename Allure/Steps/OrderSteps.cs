using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Allure.Helpers.Configuration;
using NUnit.Allure.Attributes;

namespace Allure.Steps;

public class OrderSteps : BaseStep
{
    public OrderSteps(IWebDriver driver) : base(driver)
    {
    }
    [AllureStep("Добавление продукта в корзину")]
    public void AddProductToCart()
    {
        CatalogPage.AddToCartButton.Click();
        CatalogPage.ShoppingCartBadge.Click();
    }
    
    [AllureStep("Смена категории сортировки на {textValue}")]
    public void ChangeSortSelect(string textValue)
    {
        SelectElement sortSelect = new SelectElement(CatalogPage.SortSelect);
        sortSelect.SelectByText(textValue);
    }
}