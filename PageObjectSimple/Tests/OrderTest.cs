using OpenQA.Selenium;
using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests;

public class OrderTest : BaseTest
{
    [Test]
    public void SuccessfulAddProductToCartTest()
    {
        string productName;
        
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.CatalogPage.AddToCartButton.Click();

        productName = OrderSteps.CatalogPage.ProductTitleLink.Text;
        
        Assert.Multiple(() =>
        {
            Assert.That(OrderSteps.CatalogPage.AddToCartButton.Text, Is.EqualTo("Remove"));
            Assert.That(OrderSteps.CatalogPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
        });
        
        OrderSteps.CatalogPage.ShoppingCartBadge.Click();
        
        Assert.That(OrderSteps.CartPage.TitleNameProduct.Text, Is.EqualTo(productName));
    }

    [Test]
    public void SuccessfulRemoveProductToCartTest()
    {
        
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.AddProductToCart();
        OrderSteps.CartPage.RemoveButton.Click();
        
        Assert.That(!OrderSteps.CartPage.EmptyCartItem.Displayed);
        
        OrderSteps.CartPage.ContinueShoppingButton.Click();
        
        Assert.That(OrderSteps.CatalogPage.AddToCartButton.Text, Is.EqualTo("Add to cart"));
    }
    
    [Test]
    public void MakingOrderTest()
    {
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.AddProductToCart();
        OrderSteps.CartPage.CheckoutButton.Click();
        CheckoutYourInformationSteps.InputInformation();
        
        Assert.That(OrderSteps.CheckoutOverviewPage.TitleNameProduct.Text.Trim(), Is.EqualTo("Sauce Labs Bike Light"));
        
        OrderSteps.CheckoutOverviewPage.FinishButton.Click();
        
        Assert.Multiple(() =>
        {
            Assert.That(OrderSteps.CheckoutCompletePage.CompleteInfo.Text.Trim(), Is.EqualTo("Thank you for your order!"));
            Assert.That(OrderSteps.CheckoutCompletePage.CompleteText.Text.Trim(), Is.EqualTo("Your order has been dispatched, and will arrive just as fast as the pony can get there!"));
        });
        
        
    }
}