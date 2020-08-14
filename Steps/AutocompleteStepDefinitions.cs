using Formy.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Formy.Tests.Steps
{
    [Binding]
    public sealed class AutocompleteStepDefinitions
    {
        private IWebDriver driver;

        private MainPage mainPage;
        private AutocompletePage autocompletePage;

        public AutocompleteStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            this.mainPage = new MainPage(driver);
            this.autocompletePage = new AutocompletePage(driver);
        }

        [Given("I am on the Autocomplete page")]
        public void GivenIAmOnTheAutocompletePage()
        {
            mainPage.OpenPage();
            autocompletePage = mainPage.GoToAutocompletePage();
        }

        [When("I enter (.*) in address field")]
        public void GivenIEnterInAddressField(string address)
        {
            autocompletePage.EnterDataToAddressField(address);
        }

        [Then("I can select autocomplete suggestion")]
        public void GivenISelectAutocompleteSuggestion()
        {
            autocompletePage.ClickAutocompleteSuggestion();
        }
    }
}
