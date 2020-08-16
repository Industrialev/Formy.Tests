using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using System.Security.Policy;
using System.Reflection;
using System.IO;
using Formy.Tests.Helpers;
using NLog;

namespace Formy.Tests.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly static Logger logger = LogManager.GetCurrentClassLogger();
        
        private IObjectContainer objectContainer;
        private string BaseUrl = "https://formy-project.herokuapp.com/";

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = GetWebDriver();
            webDriver.Navigate().GoToUrl(BaseUrl);
            webDriver.Manage().Window.Maximize();
            WaitHandler.EnableImplicitWait(webDriver);
            logger.Info("Webdriver has been initialized");

            objectContainer.RegisterInstanceAs(webDriver);
        }

        [AfterScenario]
        public void CleanupDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();
            driver.Quit();
            driver.Dispose();
            logger.Debug("Webdriver has been disposed.");
            objectContainer.Dispose();
        }

        private IWebDriver GetWebDriver()
        {
            var webDriverLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var browserName = Environment.GetEnvironmentVariable("Test_Browser");

            logger.Info($"{browserName} has been selected as WebDriver Browser");
            return (browserName) switch
            {
                "Edge" => new EdgeDriver(webDriverLocation, new EdgeOptions { UseChromium = true, UseInPrivateBrowsing = true }),
                "Chrome" => new ChromeDriver(webDriverLocation),
                "Firefox" => new FirefoxDriver(webDriverLocation),
                string browser => throw new NotSupportedException($"{browser} is not a supported browser"),
                _ => throw new NotSupportedException("not supported browser: <null>"),
            };
        }
    }
}
