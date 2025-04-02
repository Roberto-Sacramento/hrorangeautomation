using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using hrorangeautomation.src.Pages.DashboardHomePage;

namespace hrorangeautomation.src.Pages.AdminSidePanelComponent
{
    [Binding]
     public class AdminSidePanelComponentPage : DashboardHomeSidePanelCompronentPage
    {
        private IWebElement _addButton => Driver.FindElement(By.XPath("//div[contains(button, 'Add')]//button"));

        private readonly IWebDriver Driver;

        public AdminSidePanelComponentPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickOnAddButton()
        {
            _addButton.Click();
        }


    }
}
