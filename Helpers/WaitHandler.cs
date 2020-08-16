using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Formy.Tests.Helpers
{
    [Binding]
    public class WaitHandler
    {
        private readonly static Logger logger = LogManager.GetCurrentClassLogger();

        public static void DisableImplicitWait(IWebDriver driver)
        {
            logger.Debug("Implicit wait has been disabled.");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        public static void EnableImplicitWait(IWebDriver driver)
        {
            logger.Debug("Implicit wait has been enabled.");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
