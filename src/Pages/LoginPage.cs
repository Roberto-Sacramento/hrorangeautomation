using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace hrorangeautomation.src.Pages
{
    [Binding]
    public class LoginPage
    {
        private IWebElement _userName => Driver.FindElement(By.XPath("//following-sibling::input[contains(@placeholder, 'Username')]"));
        private IWebElement _userPassword => Driver.FindElement(By.XPath("//following-sibling::input[contains(@placeholder, 'Password')]"));
        private IWebElement _loginButton => Driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement dashboardPage => Driver.FindElement(By.XPath("//span[text()='Dashboard']"));

        private readonly IWebDriver Driver;
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string LoadUsernameElement()
        {
            return _userName.Text;

        }

        public string LoadUserPasswordElement()
        {
            return _userPassword.Text;

        }

        public string LoadDashboardPage()
        {
            return dashboardPage.Text;
        }

       
        public void FillInLoginPage(string userName, string userPassword)
        {
            _userName.Clear();
            _userName.SendKeys(userName);
            _userPassword.Clear();
            _userPassword.SendKeys(userPassword);
            _loginButton.Submit();
        }

        public void ClickOnDashboardOption()
        {
            dashboardPage.Click();
        }
    }
}