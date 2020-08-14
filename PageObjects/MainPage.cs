using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formy.Tests.PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base (driver)
        {
        }

        private Uri pageUrl = new Uri("https://formy-project.herokuapp.com/");

        [FindsBy(How = How.CssSelector, Using = ".display-3")]
        private IWebElement welcomeTitle;

        [FindsBy(How = How.ClassName, Using = "btn-lg")]
        [CacheLookup]
        private IWebElement autocompleteLink;

        private IWebElement buttonsLink;

        private IWebElement checkboxLink;

        private IWebElement datepickerLink;

        private IWebElement dragAndDropLink;

        private IWebElement dropdownLink;

        private IWebElement enabledAndDisabledElements;

        private IWebElement fileUploadLink;

        private IWebElement keyAndMousePressLink;

        private IWebElement modalLink;

        private IWebElement pageScrollLink;

        private IWebElement radioButtonLink;

        private IWebElement switchWindowLink;

        private IWebElement completeWebFormLink;

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(pageUrl);
        }

        public AutocompletePage GoToAutocompletePage()
        {
            autocompleteLink.Click();

            return new AutocompletePage(driver);
        }
    }
}
