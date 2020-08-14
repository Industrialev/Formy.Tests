using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Formy.Tests.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
        private IObjectContainer objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = new ChromeDriver(@"D:\webdrivers");
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterScenario]
        public void CleanupDriver()
        {
            var driver = objectContainer.Resolve<IWebDriver>();
            driver.Close();
            driver.Dispose();
            objectContainer.Dispose();
        }
    }
}
