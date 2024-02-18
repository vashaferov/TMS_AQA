using OpenQA.Selenium;

namespace PageObjectSimple.Steps;

public class CheckoutYourInformationSteps : BaseStep
{
    public CheckoutYourInformationSteps(IWebDriver driver) : base(driver)
    {
    }

    public void InputInformation()
    {
        CheckoutYourInformationPage.FirstNameInput.SendKeys("Vyacheslav");
        CheckoutYourInformationPage.LastNameInput.SendKeys("Sha");
        CheckoutYourInformationPage.PostalCodeInput.SendKeys("620");
        
        CheckoutYourInformationPage.ContinueButton.Click();
    }
}