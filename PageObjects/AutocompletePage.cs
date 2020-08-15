using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [FindsBy(How = How.Id, Using = "street_number")]
        [CacheLookup]
        private IWebElement streetAddress1Field;

        public AutocompletePage(IWebDriver driver): base(driver)
        {
        }

        public void EnterDataToAddressField(string address)
        {
            addressField.Click();
            addressField.SendKeys(address);
            Thread.Sleep(4000);
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
        }

        public bool IsAutocompleteListVisible()
        {
            return driver.FindElements(By.ClassName("pac-item")).Count != 0;
        }

        public bool IsPageShown()
        {
            return pageTitle.Displayed;
        }
    }
}
