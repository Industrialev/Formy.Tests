using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Formy.Tests.PageObjects
{
    public class AutocompletePage : BasePage
    {
        // TODO: Is there a way to check content of each text field?
        [FindsBy(How = How.Name, Using = "Autocomplete")]
        [CacheLookup]
        private IWebElement pageTitle;

        [FindsBy(How = How.Id, Using = "autocomplete")]
        [CacheLookup]
        private IWebElement addressField;

        [FindsBy(How = How.ClassName, Using = "pac-logo")]
        private IWebElement autocompleteList;

        public AutocompletePage(IWebDriver driver): base(driver)
        {
        }

        public void EnterDataToAddressField(string address)
        {
            addressField.SendKeys(address);
        }

        public void ClickAutocompleteSuggestion()
        {
            streetAddress1Field.Click();
            addressField.Click();
            
            wait.Until<ExpectedConditions.ElementToBeClickable(By.)>
            autocompleteList.Click();
        }

        public bool IsPageShown()
        {
            return pageTitle.Displayed;
        }
    }
}
