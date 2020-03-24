using OpenQA.Selenium;
using System;

namespace SkillSwap
{
    internal class SignUpPage
    {
        internal void ClickJoin(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            IWebElement Join = driver.FindElement(By.XPath("//button[contains(.,'Join')]"));
            Join.Click();
        }

        internal void ClickRegisterBtn(IWebDriver driver)
        {
            IWebElement FirstName = driver.FindElement(By.XPath("//input[@name='firstName']"));
            FirstName.SendKeys("Mvp");

            IWebElement LastName = driver.FindElement(By.XPath("//input[@name='lastName']"));
            LastName.SendKeys("Studio");

            IWebElement EmailID = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailID.SendKeys("mvpstudio.qa@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("SydneyQa2018");

            IWebElement ConfirmPassword = driver.FindElement(By.XPath("//input[@name='confirmPassword']"));
            ConfirmPassword.SendKeys("SydneyQa2018");

            IWebElement TnCcheckbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            TnCcheckbox.Click();

            IWebElement Register = driver.FindElement(By.XPath("//div[@id='submit-btn']"));
            Register.Click();
            System.Threading.Thread.Sleep(4000);

        }
    }
}