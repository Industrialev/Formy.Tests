using Formy.Tests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
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
        public void GivenIEnterInAddressField(string address)
        {
            autocompletePage.EnterDataToAddressField(address);
        }

        [Then("I can select autocomplete suggestion")]
        [Then("I can select (.*) address from five proposed")]
        public void GivenISelectAutocompleteSuggestion(ItemId itemId = ItemId.First)
        {
            autocompletePage.ClickAutocompleteSuggestion((int)itemId);
            Thread.Sleep(1000);
        }
    }

    /// <summary>
    /// Enum used when selecting item from autocomplete list.
    /// </summary>
    public enum ItemId
    {
        First = 0,
        Second = 1,
        Third = 2,
        Fourth = 3,
        Fifth = 4,
    }
}
