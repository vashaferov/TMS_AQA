using OpenQA.Selenium;
using Pattern.Elements;

namespace Pattern.Pages.ProjectPages;

public class AddMilestonePage : BasePage
{
    private static readonly By NameMilestoneInputBy = By.Id("name");
    private static readonly By ReferencesInputBy = By.Id("reference");
    private static readonly By ParentDropMenuBy = By.Id("parent_id_chzn");
    private static readonly By DescriptionInputBy = By.Id("description_display");
    private static readonly By StartDateInputBy = By.Id("start_on");
    private static readonly By EndDateInputBy = By.Id("due_on");
    private static readonly By IsCompletedCBBy = By.Id("is_completed");
    private static readonly By CancelButtonBy = By.ClassName("button-cancel");
    private static readonly By AddButtonBy = By.Id("accept");
    private static readonly By AddFileBy = By.Id("entityAttachmentList");
    private static readonly By UploadFileBy = By.Id("attachmentsNewList");
    private static readonly By AttachmentButtonBy = By.Id("attachmentNewSubmit");
    
    public AddMilestonePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public AddMilestonePage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }
    
    public Input NameMilestoneInput => new(Driver, NameMilestoneInputBy);
    public Input ReferencesInput => new(Driver, ReferencesInputBy);
    public Input DescriptionInput => new(Driver, DescriptionInputBy);
    public Input StartDateInput => new(Driver, StartDateInputBy);
    public Input EndDateInput => new(Driver, EndDateInputBy);
    public DropDownMenu ParentDropMenu => new(Driver, ParentDropMenuBy);
    public Checkbox IsCompletedCB => new(Driver, IsCompletedCBBy);
    public Button AddButton => new(Driver, AddButtonBy);
    public Button CancelButton => new(Driver, CancelButtonBy);
    public Button AttachmentButton => new(Driver, AttachmentButtonBy);
    public UIElement AddFile => new(Driver, AddFileBy);
    public UIElement UploadFile => new(Driver, UploadFileBy);
}