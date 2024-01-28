using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class Task2 : BaseTest
{
    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
        Thread.Sleep(5000);
        
        Console.WriteLine(Driver.FindElement(By.ClassName("calc-result")).Text);
    }
}