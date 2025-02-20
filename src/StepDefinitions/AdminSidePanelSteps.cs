using hrorangeautomation.src.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace hrorangeautomation.src.StepDefinitions
{
    [Binding]
    public class AdminSidePanelSteps
    {
        private readonly AdminSidePanelComponent _adminSidePanelComponent;
        private readonly LoginPage _loginPage;

        public AdminSidePanelSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                _adminSidePanelComponent = new AdminSidePanelComponent(driver);
                _loginPage = new LoginPage(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }


        [When(@"I create an Admin user")]
        public void GivenIClickOnTheAdminSidePanelOption()
        {
            _loginPage.FillInLoginPage("Admin", "admin123");
            _adminSidePanelComponent.LoadAdminSidePanelOption();
            _adminSidePanelComponent.ClickOnAdminSidePanelOption();
            Assert.That(_adminSidePanelComponent.LoadAdminSidePanelOption() == "Admin");
            _adminSidePanelComponent.ClickOnAddButton();
        }
    }
}
