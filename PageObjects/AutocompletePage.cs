using Formy.Tests.Helpers;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Formy.Tests.PageObjects
{
    public class AutocompletePage : BasePage
    {
        private readonly static Logger logger = LogManager.GetCurrentClassLogger();

        // TODO: Is there a way to check content of each text field?
        [FindsBy(How = How.XPath, Using = "//div/h1")]
        [CacheLookup]
        private IWebElement pageTitle;

        public AutocompletePage(IWebDriver driver): base(driver)
        {
            PageName = "Autocomplete";
        }

        public AutocompletePage SearchAddress(string address)
        {
            var addressField = driver.FindElement(By.Id("autocomplete"));
            addressField.Click();
            addressField.SendKeys(address);
            logger.Info($"{address} has been entered to address field.");
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("pac-item")));

            return this;
        }

        public AutocompletePage SelectAddress(int itemId)
        {
            var addressField = driver.FindElement(By.Id("autocomplete"));
            for (int keyDownStep = 0; keyDownStep < itemId; keyDownStep++)
            {
                addressField.SendKeys(Keys.Down);
            }

            addressField.SendKeys(Keys.Enter);
            logger.Info("Autocomplete suggestion has been selected from the list.");

            return this;
        }

        public bool IsAutocompleteListVisible(bool disableImplicitWait)
        {
            if (disableImplicitWait == true) driver.DisableImplicitWait();
            var isVisible = driver.FindElements(By.ClassName("pac-item")).Count != 0;
            if (disableImplicitWait == true) driver.EnableImplicitWait();

            return isVisible;
        }
    }
}
