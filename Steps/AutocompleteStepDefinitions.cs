using Formy.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Formy.Tests.Steps
{
    [Binding]
    public sealed class AutocompleteStepDefinitions
    {
        private MainPage mainPage;
        private AutocompletePage autocompletePage;

        public AutocompleteStepDefinitions(IWebDriver driver)
        {
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
        [When("I enter only beginning of the address (.*)")]
        public void WhenIEnterInAddressField(string address)
        {
            autocompletePage.EnterDataToAddressField(address);
            bool AutocompleteListIsVisible = autocompletePage.IsAutocompleteListVisible();
            Assert.That(AutocompleteListIsVisible, Is.True);
        }

        [When("I select autocomplete suggestion")]
        [When("I select (.*) address from five items proposed")]
        public void WhenISelectAutocompleteSuggestion(AddressItemId addressItemId = AddressItemId.First)
        {
            autocompletePage.SelectItemFromAutocompleteList((int)addressItemId);
            autocompletePage.ClickAutocompleteSuggestion();
            Thread.Sleep(1000);
        }

        [Then("I should not see list with autocomplete suggestions")]
        public void ThenICannotSeeListWithAutocompleteSuggestions(string condition)
        {
            bool AutocompleteListIsVisible = autocompletePage.IsAutocompleteListVisible();
            Assert.That(AutocompleteListIsVisible, Is.False);
        }
    }
}
