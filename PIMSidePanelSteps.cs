using System;
using SpecFlow;
using TechTalk.SpecFlow;
using hrorangeautomation.src.Pages;
using hrorangeautomation.Utils;
using OpenQA.Selenium;
using NUnit.Framework;

namespace hrorangeautomation
{
    [Binding]
    public class PIMSidePanelSteps
    {
        private readonly PIMSidePanelComponent pIMSidePanelComponent;
        private readonly ToasterMessagens toasterMessagens;
        public PIMSidePanelSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                pIMSidePanelComponent = new PIMSidePanelComponent(driver);
                toasterMessagens = new ToasterMessagens(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }

        [When("I create an ESS user with the informations: (.*), (.*), (.*)")]
        public void WhenICreateAnESSUser(string firsName, string middleName, string lastName)
        {
            pIMSidePanelComponent.LoadPIMSidePanelOption();
            pIMSidePanelComponent.ClickOnPIMSidePanelOption();
            pIMSidePanelComponent.ClickOnAddEmployeeOpption();
            pIMSidePanelComponent.LoadAddEmployeeContainer();
            pIMSidePanelComponent.FillInEmployeeForm(firsName, middleName, lastName);
            
            

        }

        [Then("The system should display the following message: (.*)")]
        public void ThenTheSystemShouldDisplayTheFollowingMessage(string message)
        {

            Assert.Pass(toasterMessagens.SucessfulMessage(message));
        }
    }
}
