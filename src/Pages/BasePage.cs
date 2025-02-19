using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace hrorangeautomation.src.Pages
{
    
    public class BasePage
    {
        private IWebElement _userName => Driver.FindElement(By.XPath("//following-sibling::input[contains(@placeholder, 'Username')]"));
        private IWebElement _userPassword => Driver.FindElement(By.CssSelector("//following-sibling::input[contains(@placeholder, 'Password')]"));
        private IWebElement _loginButton => Driver.FindElement(By.Name("//button[@type='submit']"));
        private readonly IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void FillInLoginPage(string userName, string userPassword)
        {
            _userName.Clear();
            _userName.SendKeys(userName);
            _userPassword.Clear();
            _userPassword.SendKeys(userPassword);
            _loginButton.Submit();
        }
    }
}