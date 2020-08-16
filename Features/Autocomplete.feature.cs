﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.3.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Formy.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Autocomplete", Description="\tIn fill the address form\r\n\tAs a user\r\n\tI want the webpage to autocomplete the da" +
        "ta", SourceFile="Features\\Autocomplete.feature", SourceLine=0)]
    public partial class AutocompleteFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Autocomplete.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Autocomplete", "\tIn fill the address form\r\n\tAs a user\r\n\tI want the webpage to autocomplete the da" +
                    "ta", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AutocompleteTheValidAddress(string address, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Firefox",
                    "Browser_Chrome",
                    "positive"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("address", address);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Autocomplete the valid address", null, tagsOfScenario, argumentsOfScenario);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("I am on the Autocomplete page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.When(string.Format("I enter {0} in address field", address), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And("I select first address from autosuggestion list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.Then("I should not see list with autocomplete suggestions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, 1553 Shawson Drive, Mississauga, Ontario, Kanada", new string[] {
                "Browser_Firefox",
                "Browser_Chrome",
                "positive"}, SourceLine=16)]
        public virtual void AutocompleteTheValidAddress_1553ShawsonDriveMississaugaOntarioKanada()
        {
#line 9
this.AutocompleteTheValidAddress("1553 Shawson Drive, Mississauga, Ontario, Kanada", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, Dolnych Młynów 10, Kraków, Polska", new string[] {
                "Browser_Firefox",
                "Browser_Chrome",
                "positive"}, SourceLine=16)]
        public virtual void AutocompleteTheValidAddress_DolnychMlynow10KrakowPolska()
        {
#line 9
this.AutocompleteTheValidAddress("Dolnych Młynów 10, Kraków, Polska", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, Wuhe County, Bengbu, Chiny, 233333", new string[] {
                "Browser_Firefox",
                "Browser_Chrome",
                "positive"}, SourceLine=16)]
        public virtual void AutocompleteTheValidAddress_WuheCountyBengbuChiny233333()
        {
#line 9
this.AutocompleteTheValidAddress("Wuhe County, Bengbu, Chiny, 233333", ((string[])(null)));
#line hidden
        }
        
        public virtual void AutocompleteWithOneOfProposedAddresses(string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Browser_Firefox",
                    "Browser_Chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("id", id);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Autocomplete with one of proposed addresses", null, tagsOfScenario, argumentsOfScenario);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given("I am on the Autocomplete page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.When("I enter only beginning of the address 242", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.And(string.Format("I select {0} address from autosuggestion list", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("I should not see list with autocomplete suggestions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete with one of proposed addresses, first", new string[] {
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=31)]
        public virtual void AutocompleteWithOneOfProposedAddresses_First()
        {
#line 24
this.AutocompleteWithOneOfProposedAddresses("first", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete with one of proposed addresses, second", new string[] {
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=31)]
        public virtual void AutocompleteWithOneOfProposedAddresses_Second()
        {
#line 24
this.AutocompleteWithOneOfProposedAddresses("second", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete with one of proposed addresses, third", new string[] {
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=31)]
        public virtual void AutocompleteWithOneOfProposedAddresses_Third()
        {
#line 24
this.AutocompleteWithOneOfProposedAddresses("third", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete with one of proposed addresses, fourth", new string[] {
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=31)]
        public virtual void AutocompleteWithOneOfProposedAddresses_Fourth()
        {
#line 24
this.AutocompleteWithOneOfProposedAddresses("fourth", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete with one of proposed addresses, fifth", new string[] {
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=31)]
        public virtual void AutocompleteWithOneOfProposedAddresses_Fifth()
        {
#line 24
this.AutocompleteWithOneOfProposedAddresses("fifth", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
