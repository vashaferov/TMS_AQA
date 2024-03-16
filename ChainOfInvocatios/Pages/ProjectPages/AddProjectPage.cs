using OpenQA.Selenium;

namespace ChainOfInvocatios.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    // Описание элементов
    private static readonly By NameProjectInputBy = By.Id("name");
    private static readonly By AnnouncementTextareaBy = By.Id("announcement_display");
    
    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    // Атомарные Методы
    public IWebElement NameProjectInput => Driver.FindElement(NameProjectInputBy); 
    public IWebElement AnnouncementTextarea => Driver.FindElement(AnnouncementTextareaBy); 
}