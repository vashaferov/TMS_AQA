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
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        Assert.That(LoginSteps.CatalogPage.IsPageOpened());
        
        CatalogSteps.ClickAddOrRemoveButton();
        
        Assert.Multiple(() =>
        {
            Assert.That(CatalogSteps.CatalogPage.RemoveToCartButton.Text, Is.EqualTo("Remove"));
            Assert.That(CatalogSteps.CatalogPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
        });
        
    }
}