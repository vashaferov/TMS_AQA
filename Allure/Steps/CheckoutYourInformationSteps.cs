using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace Allure.Steps;

public class CheckoutYourInformationSteps : BaseStep
{
    public CheckoutYourInformationSteps(IWebDriver driver) : base(driver)
    {
    }

    [AllureStep("Заполнение информации для заказа")]
    public void InputInformation(string firstName, string lastName, string postalCode)
    {
        CheckoutYourInformationPage.FirstNameInput.SendKeys(firstName);
        CheckoutYourInformationPage.LastNameInput.SendKeys(lastName);
        CheckoutYourInformationPage.PostalCodeInput.SendKeys(postalCode);
        
        CheckoutYourInformationPage.ContinueButton.Click();
    }
}