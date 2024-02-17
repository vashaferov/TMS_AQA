using OpenQA.Selenium;
using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests;

public class CatalogTest : BaseTest
{
    [Test]
    public void AddProductToCart()
    {
        string productName;
        
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        CatalogSteps.ClickAddOrRemoveButton();

        productName = CatalogSteps.CatalogPage.ProductTitleLink.Text;
        
        Assert.Multiple(() =>
        {
            // Assert.That(CatalogSteps.CatalogPage.RemoveToCartButton.Text, Is.EqualTo("Remove"));
            Assert.That(CatalogSteps.CatalogPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
        });
        
        CatalogSteps.CatalogPage.ShoppingCartBadge.Click();
        
        Assert.That(CartSteps.CartPage.TitleNameProduct.Text, Is.EqualTo(productName));
    }
}