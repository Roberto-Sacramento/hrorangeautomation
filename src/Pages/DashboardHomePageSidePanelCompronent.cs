using OpenQA.Selenium;

namespace hrorangeautomation.src.Pages
{
    public class DashboardHomePageSidePanelCompronent
    {
        #region selectors🔧
        private IWebElement _adminSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Admin')]//span"));
        private IWebElement _PIMSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'PIM')]//span"));
        private IWebElement _leaveSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Leave')]//span"));
        private IWebElement _timeSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Time')]//span"));
        private IWebElement _recruitmentSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Recruitment')]//span"));
        private IWebElement _myInfoSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'My Info')]//span"));
        private IWebElement _performanceSidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Performance')]//span"));
        private IWebElement _directorySidePanelOption => Driver.FindElement(By.XPath("//a[contains(span, 'Directory')]//span"));
        #endregion

        private readonly IWebDriver Driver;
        public DashboardHomePageSidePanelCompronent(IWebDriver driver)
        {
            Driver = driver;
        }

        public string LoadAdminSidePanelOption()
        {
            return _adminSidePanelOption.Text;
        }

        public string LoadPIMSidePanelOption()
        {
            return _PIMSidePanelOption.Text;
        }

        public string LoadLeaveSidePanelOption()
        {
            return _leaveSidePanelOption.Text;
        }

        public string LoadTimeSidePanelOption()
        {
            return _timeSidePanelOption.Text;
        }

        public string LoadRecruitmentSidePanelOption()
        {
            return _recruitmentSidePanelOption.Text;
        }

        public string LoadMyInfoSidePanelOption()
        {
            return _myInfoSidePanelOption.Text;
        }

        public string LoadPerformanceSidePanelOption()
        {
            return _performanceSidePanelOption.Text;
        }

        public string LoadDirectorySidePanelOption()
        {
            return _directorySidePanelOption.Text;
        }

        public void ClickOnAdminSidePanelOption()
        {
            _adminSidePanelOption.Click();
        }

        public void ClickOnPIMSidePanelOption()
        {
            _PIMSidePanelOption.Click();
        }

        public void ClickOnLeaveSidePanelOption()
        {
            _leaveSidePanelOption.Click();
        }

        public void ClickOnTimeSidePanelOption()
        {
            _timeSidePanelOption.Click();
        }

        public void ClickOnRecruitmentSidePanelOption()
        {
            _recruitmentSidePanelOption.Click();
        }

        public void ClickOnMyInfoSidePanelOption()
        {
            _myInfoSidePanelOption.Click();
        }

        public void ClickOnPerformanceSidePanelOption()
        {
            _performanceSidePanelOption.Click();
        }

        public void ClickOnCloseSidePanelOption()
        {
            _directorySidePanelOption.Click();
        }
    }
}
