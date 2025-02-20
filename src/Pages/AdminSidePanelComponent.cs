using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace hrorangeautomation.src.Pages
{
    [Binding]
     public class AdminSidePanelComponent : DashboardHomePageSidePanelCompronent
    {
        private IWebElement _addButton => Driver.FindElement(By.XPath("//div[contains(button, 'Add')]//button"));

        private readonly IWebDriver Driver;

        public AdminSidePanelComponent(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickOnAddButton()
        {
            _addButton.Click();
        }


    }
}
