using NUnitTest.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
        IWebElement heightInput = Driver.FindElement(By.Name("height"));
        IWebElement weightInput = Driver.FindElement(By.Name("weight"));
        IWebElement calcButton = Driver.FindElement(By.Id("calc-mass-c"));

        heightInput.SendKeys("190");
        weightInput.SendKeys("70");
        calcButton.Click();

        Thread.Sleep(2000);
        IWebElement result = Driver.FindElement(By.Id("imt-result"));
        Assert.That(result.Text, Is.EqualTo("19.4 - Норма"));
    }

    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(1);
        
        IWebElement selectWebElement = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectWebElement);
        
        selectElement.SelectByIndex(1);
        Thread.Sleep(2000);
        
        selectElement.SelectByValue("mm");
        Thread.Sleep(2000);
        
        selectElement.SelectByText("мг/дл");
        Thread.Sleep(2000);
        Thread.Sleep(2000);
    }

    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("");
        Thread.Sleep(5000);
        
        Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);
    }
}