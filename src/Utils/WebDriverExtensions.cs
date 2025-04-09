using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using hrorangeautomation.src.Utils;

namespace hrorangeautomation.src.Utils
{
    public static class WebDriverExtensions
    {
        public static IWebElement WaitUtilElementBeVisible(this IWebDriver driver, By by, TimeSpan timeout)
        {
            var wait = new WebDriverWait(driver, timeout);
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
