using OpenQA.Selenium;

namespace PageObjectSimple.Page;

public class LoginPage : BasePage
{
    // Описание элементов
    private static readonly By EmailInputBy = By.Id("name");
    
    // Инициализация классов и переопределения
    public LoginPage(IWebDriver driver) : base(driver)
    {
    }
    
    // Атомарные методы
    public IWebElement EmailInput()
    {
        return Driver.FindElement(EmailInputBy);  
    }
}