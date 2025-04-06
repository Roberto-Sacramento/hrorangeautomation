using TechTalk.SpecFlow;
using hrorangeautomation.src.Pages;
using hrorangeautomation.src.Utils;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using hrorangeautomation.src.Pages.DashboardHomePage;
using hrorangeautomation.src.Pages.PIMSidePanelComponent;



namespace hrorangeautomation.src.PIMSidePainelSteps
{
    [Binding]
    public class PIMSidePanelSteps
    {
        private readonly PIMSidePanelComponentPage pIMSidePanelComponent;
        private readonly ToasterMessagens toasterMessagens;
        public PIMSidePanelSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                pIMSidePanelComponent = new PIMSidePanelComponentPage(driver);
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
            pIMSidePanelComponent.ClickOnSaveButton();
        }

        [Then("The system should display a sucefully message")]
        public void ThenTheSystemShouldDisplayTheFollowingMessage()
        {
            
            string actual = toasterMessagens.SucessfulMessage();
            ClassicAssert.AreEqual(actual,"Success\nSuccessfully Saved\n×");         
            
        }
    }
}
