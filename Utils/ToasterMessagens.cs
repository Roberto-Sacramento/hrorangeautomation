using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace hrorangeautomation.Utils;

    public class ToasterMessagens
    {
       // private IWebElement _sucessfulMessage => Driver.FindElement(By.Id("[id='oxd-toaster_1']"));
        private IWebElement _sucessfulMessage => Driver.WaitUtilElementBeVisible(By.Id("oxd-toaster_1"), TimeSpan.FromSeconds(10));

        private readonly IWebDriver Driver;
    public ToasterMessagens(IWebDriver driver)
    {
        Driver = driver;
            
    }

    public string SucessfulMessage()
        {
            return _sucessfulMessage.Text;
        }
    }
