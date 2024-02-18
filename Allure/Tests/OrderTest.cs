using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using OpenQA.Selenium;
using Allure.Pages;
using Allure.Steps;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureSuite("Тесты на проверку возможностей работы с заказом")]
[AllureOwner("vashaferov")]
public class OrderTest : BaseTest
{
    [Test]
    [Description("Тест на успешное добавление закза в корзину")]
    public void SuccessfulAddProductToCartTest()
    {
        string productName;
        
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.CatalogPage.AddToCartButton.Click();

        productName = OrderSteps.CatalogPage.ProductTitleLink.Text;
        AllureApi.Step("Добавлен продукт в заказ: {productName}");
        
        Assert.Multiple(() =>
        {
            Assert.That(OrderSteps.CatalogPage.AddToCartButton.Text, Is.EqualTo("Remove"));
            Assert.That(OrderSteps.CatalogPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
        });
        StepAndScreenshot("Кнопка сменила свой текст на 'Remove', у значка корзины добавилась '1'");
        
        OrderSteps.CatalogPage.ShoppingCartBadge.Click();
        
        Assert.That(OrderSteps.CartPage.TitleNameProduct.Text, Is.EqualTo(productName));
        StepAndScreenshot("Продукт присутствует в корзине");
    }

    [Test]
    [Description("Тест на успешное удаление закза из корзину")]
    public void SuccessfulRemoveProductToCartTest()
    {
        
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.AddProductToCart();
        OrderSteps.CartPage.RemoveButton.Click();
        AllureApi.Step("Нажата кнопка удаления товара");
        
        Assert.That(!OrderSteps.CartPage.EmptyCartItem.Displayed);
        StepAndScreenshot("Корзина пуста");
        
        OrderSteps.CartPage.ContinueShoppingButton.Click();
        
        Assert.That(OrderSteps.CatalogPage.AddToCartButton.Text, Is.EqualTo("Add to cart"));
        StepAndScreenshot("Кнопка добавления сменила свой текс на 'Add to cart'");
    }
    
    [Test]
    [Description("Тест на полный заказ с оплатой")]
    [AllureSeverity(SeverityLevel.critical)]
    public void MakingOrderTest()
    {
        LoginSteps.NavigateToLoginPage();
        LoginSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        OrderSteps.AddProductToCart();
        OrderSteps.CartPage.CheckoutButton.Click();
        CheckoutYourInformationSteps.InputInformation("Viacheslav", "Sh", "123");
        
        Assert.That(OrderSteps.CheckoutOverviewPage.TitleNameProduct.Text.Trim(), Is.EqualTo("Sauce Labs Bike Light"));
        AllureApi.Step("Товар присутствует в информации о заказе");
        
        OrderSteps.CheckoutOverviewPage.FinishButton.Click();
        
        Assert.Multiple(() =>
        {
            Assert.That(OrderSteps.CheckoutCompletePage.CompleteInfo.Text.Trim(), Is.EqualTo("Thank you for your order!"));
            Assert.That(OrderSteps.CheckoutCompletePage.CompleteText.Text.Trim(), Is.EqualTo("Your order has been dispatched, and will arrive just as fast as the pony can get there!"));
        });
        StepAndScreenshot("Заказ выполнен успешно");
    }
}