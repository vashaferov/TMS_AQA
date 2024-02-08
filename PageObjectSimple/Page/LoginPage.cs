using OpenQA.Selenium;

namespace PageObjectSimple.Page;

public class LoginPage : BasePage
{
    private static string END_POINT;
    
    // Описание элементов
    private static readonly By UsernameInputBy = By.Id("name");
    private static readonly By PasswordInputBy = By.Id("password");
    private static readonly By LoginButtonBy = By.Id("button_primary");
    private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
    
    // Инициализация классов и переопределения
    public LoginPage(IWebDriver driver) : base(driver)
    {
    }
    
    // Атомарные методы
    public IWebElement UsernameInput => WaitsHelper.WaitForExists(UsernameInputBy);
    public IWebElement PasswordInput => WaitsHelper.WaitForExists(PasswordInputBy);
    public IWebElement LoginButton => WaitsHelper.WaitForExists(LoginButtonBy);
    public IWebElement RememberMeCheckbox => WaitsHelper.WaitForExists(RememberMeCheckboxBy);

    public DashboardPage SuccessfulLogin(string username, string password)
    {
        UsernameInput.SendKeys(username);
        PasswordInput.SendKeys(password);
        LoginButton.Click();

        return new DashboardPage(Driver);
    }
    
    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return LoginButton.Displayed;
    }
}