using hrorangeautomation.src.Pages;
using hrorangeautomation.src.Pages.AdminSidePanelComponent;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace hrorangeautomation.src.StepDefinitions.AdminSidePanelSteps
{
    [Binding]
    public class AdminSidePanelSteps
    {
        private readonly AdminSidePanelComponentPage adminSidePanelComponent;
        private readonly LoginPage loginPage;

        public AdminSidePanelSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                adminSidePanelComponent = new AdminSidePanelComponentPage(driver);
                loginPage = new LoginPage(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }


        [When(@"I create an Admin user")]
        public void GivenIClickOnTheAdminSidePanelOption()
        {
            loginPage.FillInLoginPage("Admin", "admin123");
            adminSidePanelComponent.LoadAdminSidePanelOption();
            adminSidePanelComponent.ClickOnAdminSidePanelOption();
            Assert.That(adminSidePanelComponent.LoadAdminSidePanelOption() == "Admin");
            adminSidePanelComponent.ClickOnAddButton();
        }
    }
}
