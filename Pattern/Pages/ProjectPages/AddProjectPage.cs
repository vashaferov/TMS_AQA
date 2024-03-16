using OpenQA.Selenium;
using Pattern.Elements;

namespace Pattern.Pages.ProjectPages;

public class AddProjectPage : BasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    // Описание элементов
    private static readonly By NameProjectInputBy = By.Id("name");
    private static readonly By AnnouncementTextareaBy = By.Id("announcement_display");
    private static readonly By ShowAnnouncementCheckboxBy = By.Id("show_announcement");
    private static readonly By ProjectTypeRBBy = By.Name("suite_mode");
    private static readonly By EnableTestCaseApprovalsCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By AddProjectButtonBy = By.Id("accept");
    private static readonly By CancelButtonBy = By.Id("admin-integration-form-cancel");
    
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
    public Input NameProjectInput => new(Driver, NameProjectInputBy); 
    public Input AnnouncementTextarea => new(Driver, AnnouncementTextareaBy);
    public Checkbox ShowAnnouncementCheckbox => new(Driver, ShowAnnouncementCheckboxBy);
    public Checkbox EnableTestCaseApprovalsCheckbox => new(Driver, EnableTestCaseApprovalsCheckboxBy);
    public RadioButton ProjectTypeRB => new RadioButton(Driver, ProjectTypeRBBy);
    public Button AddProjectButton => new (Driver, AddProjectButtonBy);
    public Button CancelButton => new (Driver, CancelButtonBy);
}