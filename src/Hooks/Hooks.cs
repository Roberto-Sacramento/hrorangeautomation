// filepath: /home/robert/Documents/GIT/hrorangeautomation/src/Hooks/Hooks.cs
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;
    private IWebDriver _webDriver;
    private readonly IConfiguration configuration;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;

        // Load configuration
        configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        // Get ChromeDriver path and BaseUrl from configuration
        string chromeDriverPath = configuration["SeleniumSettings:ChromeDriverPath"];
        string baseUrl = configuration["SeleniumSettings:BaseUrl"];

        // Initialize WebDriver
        _webDriver = new ChromeDriver(chromeDriverPath);
        _scenarioContext["WebDriver"] = _webDriver;

        // Navigate to BaseUrl
        if (!string.IsNullOrWhiteSpace(baseUrl))
        {
            _webDriver.Navigate().GoToUrl(baseUrl);
            Console.WriteLine($"Navigated to BaseUrl: {baseUrl}");
        }
        else
        {
            throw new InvalidOperationException("BaseUrl is not configured in appsettings.json.");
        }
    }

    [AfterScenario]
    public void AfterScenario()
    {
        // Cleanup WebDriver
        _webDriver?.Quit();
    }
}