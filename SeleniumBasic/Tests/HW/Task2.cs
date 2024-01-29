using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class Task2 : BaseTest
{
    private string lengthRoom;
    private string widthRoom;
    private string lengthLaminate;
    private string widthLaminate;
    private string laminateInPackage;
    private string packingArea;
    private string indent;
    private string result;
    
    [SetUp]
    public void SetUp()
    {
        lengthRoom = "500";
        widthRoom = "400";
        lengthLaminate = "1220";
        widthLaminate = "280";
        laminateInPackage = "15";
        packingArea = "14,64";
        indent = "8";
        
        Console.WriteLine($"{DateTime.Now}: Успешно установлены значения ТД.");
    }
    
    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
        Thread.Sleep(3000);
        Console.WriteLine($"{DateTime.Now}: Сайт открыт успешно.");
        
        // Поля блоков для ввода
        IWebElement lnRoomElement = Driver.FindElement(By.Id("ln_room_id")); //Поле "Длина комнаты"
        IWebElement wdRoomElement = Driver.FindElement(By.Id("wd_room_id")); //Поле "Ширина комнаты"
        IWebElement lnLamElement = Driver.FindElement(By.Id("ln_lam_id")); //Поле "Длина плашки"
        IWebElement wdLamElement = Driver.FindElement(By.Id("wd_lam_id")); //Поле "Ширина плашки"
        IWebElement nPackingElement = Driver.FindElement(By.Id("n_packing")); //Поле "Число плашек в упаковке"
        IWebElement areaElement = Driver.FindElement(By.Id("area")); //Поле "Площадь упаковки"
        IWebElement angleElement = Driver.FindElement(By.Id("direction-laminate-id1")); //RB "Направление укладки ламината"
        IWebElement indentElement = Driver.FindElement(By.Id("indent_walls_id")); //Поле "Отступ от стен"
        IWebElement buttonCalc = Driver.FindElement(By.Id("btn_calculate")); //Кнопка "Рассчитать"
        
        IWebElement selectLayingMethodWebElement = Driver.FindElement(By.Id("laying_method_laminate")); //Селект "Способ укладки ламината"
        SelectElement selectLayingMethodElement = new SelectElement(selectLayingMethodWebElement);
        
        
        // Очистка полей
        lnRoomElement.Clear();
        wdRoomElement.Clear();
        lnLamElement.Clear();
        wdLamElement.Clear();
        nPackingElement.Clear();
        areaElement.Clear();
        Thread.Sleep(3000);
        
        //Устанавливаем значения
        lnRoomElement.SendKeys(lengthRoom);
        wdRoomElement.SendKeys(widthRoom);
        lnLamElement.SendKeys(lengthLaminate);
        wdLamElement.SendKeys(widthLaminate);
        nPackingElement.SendKeys(laminateInPackage);
        areaElement.SendKeys(packingArea);
        angleElement.Click();
        indentElement.SendKeys(Keys.Backspace);
        indentElement.SendKeys(indent);
        selectLayingMethodElement.SelectByValue("2");
        buttonCalc.Click();
        Thread.Sleep(10000);

        result = Driver.FindElement(By.ClassName("calc-result")).Text;
        Console.WriteLine($"{DateTime.Now}: Получен результат:\n{result}");
        
        
        if(result.Contains("Требуемое количество плашек ламината: 60"))
            if(result.Contains("Количество упаковок ламината: 4"))
               Assert.Pass($"PASS: Поля содержат всю нужную информцию\n");
            else
                Assert.Fail($"FAIL: Отсутствует строка: Количество упаковок ламината: 4\n");
        else
            Assert.Fail($"FAIL: Требуемое количество плашек ламината: 60\n");
    }
}