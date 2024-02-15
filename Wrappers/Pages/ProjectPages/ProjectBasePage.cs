using System.Data;
using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages;

public class ProjectBasePage : BasePage
{
    private static readonly By NameInputBy = By.Id("name");
    private static readonly By ProjectTypeRBBy = By.Id("suite_name");
    
    public ProjectBasePage(IWebDriver driver) : base(driver)
    {
    }

    public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    public RadioButton ProjectTypeRB => new RadioButton(Driver, ProjectTypeRBBy);
}