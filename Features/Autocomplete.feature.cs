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
                    "Browser_Edge",
                    "Browser_Firefox",
                    "Browser_Chrome"};
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
 testRunner.Then("I can select autocomplete suggestion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, 1553 Shawson Drive, Mississauga, Ontario, Kanada", new string[] {
                "Browser_Edge",
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=15)]
        public virtual void AutocompleteTheValidAddress_1553ShawsonDriveMississaugaOntarioKanada()
        {
#line 9
this.AutocompleteTheValidAddress("1553 Shawson Drive, Mississauga, Ontario, Kanada", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, Dolnych Młynów 10, Kraków, Polska", new string[] {
                "Browser_Edge",
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=15)]
        public virtual void AutocompleteTheValidAddress_DolnychMlynow10KrakowPolska()
        {
#line 9
this.AutocompleteTheValidAddress("Dolnych Młynów 10, Kraków, Polska", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Autocomplete the valid address, Wuhe County, Bengbu, Chiny, 233333", new string[] {
                "Browser_Edge",
                "Browser_Firefox",
                "Browser_Chrome"}, SourceLine=15)]
        public virtual void AutocompleteTheValidAddress_WuheCountyBengbuChiny233333()
        {
#line 9
this.AutocompleteTheValidAddress("Wuhe County, Bengbu, Chiny, 233333", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
