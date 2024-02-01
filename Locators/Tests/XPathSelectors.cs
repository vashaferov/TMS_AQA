using OpenQA.Selenium;
using SauceDemo.Helpers.Configuration;

namespace SauceDemo.Tests;

public class XPathSelectors : BaseTest
{
    [Test]
    public void BasicXPathSelectors()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Абсолютный XPath
        Assert.That(Driver.FindElement(By.XPath("/html/body/div[4]/div/div[1]/div[1]/div/div[2]")).Displayed);

        // Все эелемнты на странице начина с HTML
        Driver.FindElements(By.XPath("//*"));

        // Аналог поиска по tagName
        Assert.That(Driver.FindElement(By.XPath("//h1")).Displayed);

        // Аналог родительского div и на один уровень ниже р1
        Assert.That(Driver.FindElement(By.XPath("//div/h1")).Displayed);

        // Аналог родительского div и на любом уровене ниже div
        Assert.That(Driver.FindElement(By.XPath("//div//div")).Displayed);

        // Поиск элемента с тэгом div у которого есть аьттрибут id
        Assert.That(Driver.FindElement(By.XPath("//div[@id]")).Displayed);

        // Поиск элемента у которого есть аттрибут id cо значением top-logo
        Assert.That(Driver.FindElement(By.XPath("//*[@id = 'top-logo']")).Displayed);

        // Поиск элемента у которого есть аттрибут method cо значением и фттрибут target со значением
        Assert.That(Driver.FindElement(By.XPath("//*[@method='post' and @target='_blank']")).Displayed);

        // Поиск элемента у которого значение аттрибута начинается с
        Assert.That(Driver.FindElement(By.XPath("//*[starts-with(@id, 'new')]")).Displayed);

        // Поиск элемента у которого значение аттрибута содержит подстроку
        Assert.That(Driver.FindElement(By.XPath("//div[contains(@id, 'Template')]")).Displayed);

        // Поиск элемента у которого текстовое значение содержит равно
        Assert.That(Driver.FindElement(By.XPath("//div[text() = 'All Projects']")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//*[. = 'Todos']")).Displayed);

        // Поиск элемента у которого текстовое значение содержит подстроку
        Assert.That(Driver.FindElement(By.XPath("//*[contains(text(), 'All Projects')]")).Displayed);

        // Поиск элемента по индексу
        Assert.That(Driver.FindElement(By.XPath("//div[@class = 'summary-links text-secondary']/a[2]"))
            .Displayed);
    }

    [Test]
    public void AxesXPathTest()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

        // Поиск родителя у элемента с тэгом h1
        Assert.That(Driver.FindElement(By.XPath("//h1/..")).Displayed);
        Assert.That(Driver.FindElement(By.XPath("//h1/parent::div")).Displayed);

        // Поиск всех предков с тэгом div у элемента с тэгом h1
        Assert.That(Driver.FindElement(By.XPath("//h1/ancestor::div")).Displayed);

        // Использование child - все дочерние элементы с тэго a от div
        Assert.That(Driver.FindElement(By.XPath("//div/child::a")).Displayed);

        // Использование child - все дочерние элементы с тэго a от div
        Assert.That(Driver.FindElement(By.XPath("//div/descendant::a")).Displayed);

        //Использование following - Выбирает всё в документе после закрытия тэга текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/following::form")).Displayed);

        //Использование following-sibling - Выбирает все узлы одного уровня после текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/following-sibling::form"))
            .Displayed);

        //Использование preceding- Выбирает все узлы, которые появляются перед текущим узлом в документе
        Assert.That(Driver.FindElement(By.XPath("//*[@class=\"dialog-title\"]/preceding::form")).Displayed);

        //Использование preceding-sibling - Выбирает все узлы одного уровня до текущего узла
        Assert.That(Driver.FindElement(By.XPath("//*[@class='dialog-title']/preceding-sibling::form"))
            .Displayed);
    }
}