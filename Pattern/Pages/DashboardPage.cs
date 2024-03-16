using OpenQA.Selenium;
using Pattern.Elements;
using Pattern.Pages.ProjectPages;

namespace Pattern.Pages
{
    public class DashboardPage : BasePage
    {
        private static string END_POINT = "index.php?/dashboard";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");
        private static readonly By FirstProjectLinkBy = By.XPath("//*[@id='content_container']/descendant::a[3]");
        
        public DashboardPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public UIElement SidebarProjectsAddButton => new(Driver, SidebarProjectsAddButtonBy);
        public UIElement FirstProjectLink => new(Driver, FirstProjectLinkBy);

        public ProjectOverviewPage FirstProjectLinkClick()
        {
            FirstProjectLink.Click();
            return new ProjectOverviewPage(Driver);
        }
    }
}