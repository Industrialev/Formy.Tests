using Formy.Tests.Helpers;
using NLog;
using OpenQA.Selenium;
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

        [FindsBy(How = How.Id, Using = "autocomplete")]
        [CacheLookup]
        private IWebElement addressField;

        public AutocompletePage(IWebDriver driver): base(driver)
        {
        }

        public void EnterDataToAddressField(string address)
        {
            addressField.Click();
            addressField.SendKeys(address);
            logger.Info($"{address} has been entered to address field.");
        }

        public void SelectItemFromAutocompleteList(int itemId)
        {
            for (int keyDownStep = 0; keyDownStep < itemId; keyDownStep++)
            {
                addressField.SendKeys(Keys.Down);
            }
        }

        public void ClickAutocompleteSuggestion()
        {
            addressField.SendKeys(Keys.Enter);
            logger.Info("Autocomplete suggestion has been selected from the list.");
        }

        public string GetPageTitle()
        {
            return pageTitle.Text;
        }

        public bool IsAutocompleteListVisible()
        {
            WaitHandler.DisableImplicitWait(driver);
            var isVisible = driver.FindElements(By.ClassName("pac-item")).Count != 0;
            WaitHandler.EnableImplicitWait(driver);

            return isVisible;
        }
    }
}
