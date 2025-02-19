using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace hrorangeautomation.src.Pages
{
    [Binding]
    class AdminSidePanelComponent : DashboardHomePageSidePanelCompronent
    {
        private IWebElement addButton => Driver.FindElement(By.XPath(""));

        private readonly IWebDriver Driver;

        public AdminSidePanelComponent(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickOnAddButton()
        {
            addButton.Click();
        }


    }
}
