using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Formy.Tests.Helpers
{
    public static class WaitHandler
    {
        private readonly static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly static TimeSpan WaitTime = TimeSpan.FromSeconds(10);

        public static void DisableImplicitWait(this IWebDriver driver)
        {
            logger.Debug("Implicit wait has been disabled.");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }

        public static void EnableImplicitWait(this IWebDriver driver)
        {
            logger.Debug("Implicit wait has been enabled.");
            driver.Manage().Timeouts().ImplicitWait = WaitTime;
        }

        public static void WaitUntilElementValuesEqual(this IWebDriver driver, IWebElement element, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(x => element.GetAttribute("innerText") == value);
        }
    }
}
