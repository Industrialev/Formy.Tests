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

        [FindsBy(How = How.Id, Using = "street_number")]
        [CacheLookup]
        private IWebElement streetAddress1Field;

        [FindsBy(How = How.ClassName, Using = "pac-item")]
        private IList<IWebElement> autocompleteItems;

        public AutocompletePage(IWebDriver driver): base(driver)
        {
        }

        public void EnterDataToAddressField(string address)
        {
            addressField.Click();
            addressField.SendKeys(address);
        }

        public void ClickAutocompleteSuggestion(int itemId)
        {
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click ()", autocompleteItems[itemId]);
        }

        public bool IsPageShown()
        {
            return pageTitle.Displayed;
        }
    }
}
