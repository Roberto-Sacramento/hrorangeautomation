using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrorangeautomation.Utils;

    public class ToasterMessagens
    {
       // private IWebElement _sucessfulMessage => Driver.FindElement(By.Id("[id='oxd-toaster_1']"));
        private IWebElement _sucessfulMessage => Driver.WaitUtilElementBeVisible(By.Id("[id='oxd-toaster_1']"), TimeSpan.FromSeconds(10));

        private readonly IWebDriver Driver;
    public ToasterMessagens(IWebDriver driver)
    {
        Driver = driver;
            
    }

    public string SucessfulMessage(string message)
        {
            return _sucessfulMessage.Text;
        }
    }
