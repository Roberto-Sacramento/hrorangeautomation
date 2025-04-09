using OpenQA.Selenium;
using TechTalk.SpecFlow;
using hrorangeautomation.src.Pages;

namespace hrorangeautomation.src.StepDefinitions.LoginSteps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly LoginPage _loginPage;

        public LoginPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

            if (!_scenarioContext.ContainsKey("WebDriver"))
            {
                throw new InvalidOperationException("WebDriver is not set in the ScenarioContext. Ensure it is initialized in a BeforeScenario hook.");
            }

            var webDriver = _scenarioContext["WebDriver"] as IWebDriver
                ?? throw new ArgumentNullException("WebDriver is not available in the scenario context.");

            _loginPage = new LoginPage(webDriver);
        }

        [Given(@"I navigate to Login page")]
        public void INavigateToLoginPage()
        {
            _loginPage.LoadUsernameElement();
            _loginPage.LoadUserPasswordElement();
        }

        [When(@"I logged on the application")]
        public void GivenINavigateToTheMainPage(string userName, string userPassword)
        {
            _loginPage.LoadUsernameElement();
            _loginPage.LoadUserPasswordElement();
            _loginPage.FillInLoginPage(userName, userPassword);
        }

        [Then(@"I should see the Home page")]
        public void ThenIShouldSeeTheHomePage()
        {
            _loginPage.LoadDashboardPage();
        }
    }
}
