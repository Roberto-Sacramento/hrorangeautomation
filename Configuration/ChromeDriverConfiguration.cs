using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace hrorangeautomation.Configuration
{
    public class ChromeDriverConfiguration
    {
        private IWebDriver? _driver;
        private static readonly string DriverPath = Path.Combine(Directory.GetCurrentDirectory(), "/home/karbax/Documents/GIT/hrorangeautomation/src/Drivers/chromedriver");
        public static readonly string BaseUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";


        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("start-maximized");
                _driver = new ChromeDriver(DriverPath, options);
                _driver.Navigate().GoToUrl(BaseUrl);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                _driver.Title.Equals("OrangeHRM");
            }
            return _driver;
        }

        public void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}