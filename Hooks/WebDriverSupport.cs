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

namespace Formy.Tests.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
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
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs(webDriver);
        }

        [AfterScenario]
        public void CleanupDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();
            driver.Close();
            driver.Dispose();
            objectContainer.Dispose();
        }

        private IWebDriver GetWebDriver()
        {
            return (Environment.GetEnvironmentVariable("Test_Browser")) switch
            {
                "Edge" => new EdgeDriver(new EdgeOptions { UseChromium = true, UseInPrivateBrowsing = true }),
                "Chrome" => new ChromeDriver(),
                "Firefox" => new FirefoxDriver(),
                string browser => throw new NotSupportedException($"{browser} is not a supported browser"),
                _ => throw new NotSupportedException("not supported browser: <null>"),
            };
        }
    }
}
