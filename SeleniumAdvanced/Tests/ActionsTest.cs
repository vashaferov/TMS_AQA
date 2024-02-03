using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvanced.Tests;

public class ActionsTest : BaseTest
{
    [Test]
    public void HoverTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

        var targetElement = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.CssSelector(".figure"));

        var actions = new Actions(Driver);

        actions
            .MoveToElement(targetElement[0], 10, 10)
            .Click(WaitsHelper.WaitForExists(By.CssSelector("[href=\"/users/1\"]")))
            .Build()
            .Perform();
        
        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForElementInvisible(targetElement[0]));
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("h1")).Text, Is.EqualTo("Not Found"));
        });
    }
    
    [Test]
    public void DragAndDropTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");

        var targetElementA = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-a"));
        var targetElementB = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-b"));

        var actions = new Actions(Driver);

        actions
            .DragAndDrop(targetElementA, targetElementB)
            .Build()
            .Perform();
    }
    
    [Test]
    public void FileUploadTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

        var fileUploadPath = WaitsHelper.WaitForExists(By.Id("file-upload"));
        // Получаем путь к исполняемому файлу (exe)
        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Конструируем путь к файлу внутри проекта
        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");
        Console.WriteLine(filePath);
        
        fileUploadPath.SendKeys(filePath);
        
        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();
        Thread.Sleep(5000);
    }
}