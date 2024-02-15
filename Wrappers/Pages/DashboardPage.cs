using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages
{
    public class DashboardPage : BasePage
    {
        private static string END_POINT = "index.php?/dashboard";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");
        
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

        public Button SidebarProjectsAddButton => new(Driver, SidebarProjectsAddButtonBy);
    }
}