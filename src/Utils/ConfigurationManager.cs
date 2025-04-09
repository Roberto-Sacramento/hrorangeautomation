using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

class ConfigurationManager
{
    private IConfiguration Configuration { get; }

    public ConfigurationManager()
    {
        // Load configuration from appsettings.json
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }

    public IWebDriver SetupDriver()
    {
        try
        {
            // Retrieve settings from the configuration file
            string? chromeDriverPath = Configuration["SeleniumSettings:ChromeDriverPath"];
            string? browserType = Configuration["SeleniumSettings:BrowserType"];
            string? baseUrl = Configuration["SeleniumSettings:BaseUrl"];
            string? UserName = Configuration["SeleniumSettings:Username"];
            string? UserPassword = Configuration["SeleniumSettings:Password"];

            // Validate retrieved paths
            if (string.IsNullOrWhiteSpace(chromeDriverPath) || !Directory.Exists(chromeDriverPath))
            {
                throw new ArgumentException("Invalid ChromeDriver path.");
            }

            // Initialize Chrome options
            var chromeOptions = new ChromeOptions();

            IWebDriver driver;

            // Initialize WebDriver based on the browser type
            if (!string.IsNullOrEmpty(browserType) && browserType.Equals("Headless", StringComparison.OrdinalIgnoreCase))
            {
                chromeOptions.AddArgument("--headless");
                driver = new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            else if (browserType.Equals("Normal", StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            
            // Default to Chrome if no specific type is provided
            else if (string.IsNullOrWhiteSpace(browserType) || browserType.Equals("Default", StringComparison.OrdinalIgnoreCase))
            {
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            else if (browserType.Equals("Maximized", StringComparison.OrdinalIgnoreCase))
            {
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            if (browserType.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver(chromeDriverPath, chromeOptions);
            }
            else
            {
                throw new NotSupportedException($"Browser type {browserType} is not supported.");
            }

            // Navigate to the base URL
            if (!string.IsNullOrWhiteSpace(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
                Console.WriteLine($"Page Title: {driver.Title}");
            }
            else
            {
                Console.WriteLine("Base URL is not configured.");
            }

            return driver;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing WebDriver: {ex.Message}");
            throw;
        }
    }

    public void CleanupDriver(IWebDriver driver)
    {
        // Safely quit WebDriver
        driver?.Quit();
        Console.WriteLine("Driver cleanup complete.");
    }
}