using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SkillSwap.Hookup
{
    [Binding]
    public class ProfileCreationSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"the new user registers successfuly")]
        public void GivenTheNewUserRegistersSuccessfuly()
        {
            SignUpPage signup = new SignUpPage();
            signup.ClickJoin(driver);
            signup.ClickRegisterBtn(driver);
        }
        
        [Given(@"logs in with the same credentials")]
        public void GivenLogsInWithTheSameCredentials()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }
    }
}
