using hrorangeautomation.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace hrorangeautomation.src.Hooks
{
    
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ChromeDriverConfiguration _chromeDriverConfig;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _chromeDriverConfig = new ChromeDriverConfiguration();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver driver = _chromeDriverConfig.GetDriver();
            _scenarioContext["WebDriver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _chromeDriverConfig.QuitDriver();
        }
    }
    
}