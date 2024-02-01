using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests;

public class SauceDemoTest : BaseTest

{
    [Test]
    public void LocatorsTest()
    {
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        
        // Basic (1 из 2)
        Assert.That(Driver.FindElement(By.Id("login_button_container")).Displayed);
        Assert.That(Driver.FindElement(By.Name("user-name")).Displayed);
        Assert.That(Driver.FindElement(By.ClassName("login_logo")).Displayed);
        Assert.That(Driver.FindElement(By.TagName("input")).Displayed);
        
        // XPath
        Assert.That(Driver.FindElement(By.XPath("//input[@data-test='username']")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//div[text()='locked_out_user']")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//input[contains(@data-test,'user')]")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//div[contains(text(), 'user')]")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[text()='problem_user']//ancestor::div")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials_wrap']//descendant::div")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials']//following::div")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials']//parent::div")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials']//preceding::div")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//input[@placeholder='Password' and @type='password']")).Displayed);
        
        // CSS
        Assert.That(Driver.FindElement(By.CssSelector(".login_wrapper-inner")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector(".input_error.form_input")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector(".login_wrapper .form_column")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("#user-name")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("h4")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("div.login_logo")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[placeholder='Username']")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[autocapitalize~='none']")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class|='login']")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class^=l]")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class$=iner]")).Displayed);
        Assert.That(Driver.FindElement(By.CssSelector("[class*=_]")).Displayed);
        
        // Basic (1 из 2)
        Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
        Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
        Driver.FindElement(By.Id("login-button")).Click();
        
        Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Backpack")).Displayed);
        Assert.That(Driver.FindElement(By.PartialLinkText("Labs")).Displayed);
    }
}