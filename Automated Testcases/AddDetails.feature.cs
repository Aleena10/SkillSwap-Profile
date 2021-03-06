// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SkillSwap.AutomatedTestcases
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute(TestName="AddDetails")]
    [NUnit.Framework.DescriptionAttribute("\tIn order to login to the Skillswap website\r\n\tAs a new user\r\n\tUpdate my profile a" +
        "s a skill seeker\r\n    check the profile of a skill trader")]
    public partial class AddDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AddDetails.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddDetails", "\tIn order to login to the Skillswap website\r\n\tAs a new user\r\n\tUpdate my profile a" +
                    "s a skill seeker\r\n    check the profile of a skill trader", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Non-logged-in skill seeker views Traders profile detials and updaes his/her profi" +
            "le.")]
        [NUnit.Framework.DescriptionAttribute("Non-logged-in skill seeker views Traders profile detials and updaes his/her profi" +
            "le.")]
        [NUnit.Framework.CategoryAttribute("User")]
        [NUnit.Framework.CategoryAttribute("Updates")]
        [NUnit.Framework.CategoryAttribute("own")]
        [NUnit.Framework.CategoryAttribute("Profile")]
        [NUnit.Framework.CategoryAttribute("and")]
        [NUnit.Framework.CategoryAttribute("views")]
        [NUnit.Framework.CategoryAttribute("sellers")]
        [NUnit.Framework.CategoryAttribute("profile")]
        public virtual void Non_Logged_InSkillSeekerViewsTradersProfileDetialsAndUpdaesHisHerProfile_()
        {
            string[] tagsOfScenario = new string[] {
                    "User",
                    "Updates",
                    "own",
                    "Profile",
                    "and",
                    "views",
                    "sellers",
                    "profile"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Non-logged-in skill seeker views Traders profile detials and updaes his/her profi" +
                    "le.", null, new string[] {
                        "User",
                        "Updates",
                        "own",
                        "Profile",
                        "and",
                        "views",
                        "sellers",
                        "profile"});
#line 8
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
#line 9
 testRunner.Given("a user views traders profile by seeking skill from homepage search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("he logs into his account to update his profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("a user clicks on Profile Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("he is navigated to his profile section to update and eventually logs out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
