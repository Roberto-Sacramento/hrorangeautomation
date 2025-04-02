using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace hrorangeautomation.src.Pages.DashboardHomePage
{
    
    public class PIMSidePanelComponentPage : DashboardHomeSidePanelCompronentPage
    {
        private IWebElement _addEmployee => Driver.FindElement(By.XPath("//li[contains(a, 'Add Employee')]//a"));
        private IWebElement _addEmployeeContainerLoad => Driver.FindElement(By.XPath("//div[contains(h6, 'Add Employee')]"));
        private IWebElement _firstName => Driver.FindElement(By.Name("firstName"));
        private IWebElement _middleName => Driver.FindElement(By.Name("middleName"));
        private IWebElement _lastName => Driver.FindElement(By.Name("lastName"));
        private IWebElement _cancelButton => Driver.FindElement(By.XPath("//div[2]/button[1]"));
        private IWebElement _saveButton => Driver.FindElement(By.XPath("//div[2]/button[2]"));

        private readonly IWebDriver Driver;

        public PIMSidePanelComponentPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public void ClickOnAddEmployeeOpption()
        {
            _addEmployee.Click();
        }

        public void FillInEmployeeForm(string firstName, string middleName, string lastName)
        {
            _firstName.Clear();
            _firstName.SendKeys(firstName);
            _middleName.Clear();
            _middleName.SendKeys(middleName);
            _lastName.Clear();
            _lastName.SendKeys(lastName);
        }

        public void ClickOnSaveButton()
        {
            _saveButton.Click();
        }

        public void ClickOnCancelButton()
        {
            _cancelButton.Click();
        }

        public void LoadAddEmployeeContainer()
        {
            _addEmployeeContainerLoad.Click();
        }

    }
}
