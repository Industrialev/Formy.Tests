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
        private readonly MainPage mainPage;
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

            Assert.That(autocompletePage.GetPageTitle(), Is.EqualTo("Autocomplete"));
        }

        [When("I enter (.*) in address field")]
        [When("I enter only beginning of the address (.*)")]
        public void WhenIEnterInAddressField(string address)
        {
            autocompletePage.EnterDataToAddressField(address);
            bool IsAutocompleteListVisible = autocompletePage.IsAutocompleteListVisible();
            Assert.That(IsAutocompleteListVisible, Is.True);
        }

        [When("I select (.*) address from autosuggestion list")]
        public void ThenISelectAddressFromFiveItemsProposed(AddressItemId addressItemId = AddressItemId.First)
        {
            autocompletePage.SelectItemFromAutocompleteList((int)addressItemId);
            autocompletePage.ClickAutocompleteSuggestion();
        }

        [Then("I should not see list with autocomplete suggestions")]
        public void ThenIShouldNotSeeListWithAutocompleteSuggestions()
        {
            bool IsAutocompleteListVisible = autocompletePage.IsAutocompleteListVisible();
            Assert.That(IsAutocompleteListVisible, Is.False);
        }
    }
}
