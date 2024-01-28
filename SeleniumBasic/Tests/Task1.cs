using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class Task1 : BaseTest
{
    private string age;
    private string sex;
    private string race;
    private string mass;
    private string grow;
    private string mdrd_result;
    private string ckd_epi_result;
    private string cge_result;
    private string schwartz_result;
    
    [SetUp]
    public void SetUp()
    {
        age = "20";
        mass = "75";
        grow = "190";
        sex = "M";
        race = "Другая";
        mdrd_result = "183.88";
        ckd_epi_result = "148.29";
        cge_result = "221";
        schwartz_result = "235.6";
        
        Console.WriteLine($"{DateTime.Now}: Успешно установлены значения ТД.");
    }
    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(0);
        Console.WriteLine($"{DateTime.Now}: Сайт открыт успешно.");
        
        IWebElement ageElement = Driver.FindElement(By.Id("age")); //Поле "Возраст"
        
        IWebElement selectSexWebElement = Driver.FindElement(By.Id("sex")); //Селект "Пол"
        SelectElement selectSexElement = new SelectElement(selectSexWebElement);
        
        IWebElement selectCrWebElement = Driver.FindElement(By.Id("cr-size")); //Селект "Кератин"
        SelectElement selectCrElement = new SelectElement(selectCrWebElement);
        
        IWebElement crElement = Driver.FindElement(By.Id("cr")); //Поле "Кератин"
        
        IWebElement selectRaceWebElement = Driver.FindElement(By.Id("race")); //Селект "Раса"
        SelectElement selectRaceElement = new SelectElement(selectRaceWebElement);
        
        IWebElement massElement = Driver.FindElement(By.Id("mass")); //Поле "Масса тела"
        
        IWebElement growElement = Driver.FindElement(By.Id("grow")); //Поле "Рост"

        IWebElement buttonCalc = Driver.FindElement(By.XPath("//p/button[contains(., 'Рассчитать')]")); //Кнопка "Рассчитать"

        //Поля блока результатов
        IWebElement mdrd_resElement = Driver.FindElement(By.Id("mdrd_res"));
        IWebElement ckd_epi_resElement = Driver.FindElement(By.Id("ckd_epi_res"));
        IWebElement cge_resElement = Driver.FindElement(By.Id("cge_res"));
        IWebElement schwartz_resElement = Driver.FindElement(By.Id("schwartz_res"));
        
        //Устанавливаем значения
        ageElement.SendKeys(age);
        selectSexElement.SelectByValue(sex);
        selectCrElement.SelectByValue("mm");
        crElement.SendKeys("0,05");
        selectRaceElement.SelectByText(race);
        massElement.SendKeys(mass);
        growElement.SendKeys(grow);
        
        Console.WriteLine($"{DateTime.Now}: На форме успешно устновлены значения.");
        Thread.Sleep(2000);
        
        //Нажимаем на кнопку
        buttonCalc.Click();
        Console.WriteLine($"{DateTime.Now}: Нажата кнопка 'Рассчитать.'");
        Thread.Sleep(2000);
        
        //Проверка значений
        Assert.That(mdrd_resElement.Text, Is.EqualTo(mdrd_result));
        Console.WriteLine($"{DateTime.Now}: MDRD = {mdrd_result}.");
        
        Assert.That(ckd_epi_resElement.Text, Is.EqualTo(ckd_epi_result));
        Console.WriteLine($"{DateTime.Now}: CKD-EPI = {ckd_epi_result}.");
        
        Assert.That(cge_resElement.Text, Is.EqualTo(cge_result));
        Console.WriteLine($"{DateTime.Now}: Формула Кокрофта-Голта = {cge_result}.");
        
        Assert.That(schwartz_resElement.Text, Is.EqualTo(schwartz_result));
        Console.WriteLine($"{DateTime.Now}: Формула Шварца = {schwartz_result}.");
    }
}