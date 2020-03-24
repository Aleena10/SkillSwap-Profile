using OpenQA.Selenium;
using System;

namespace SkillSwap
{
    internal class LoginPage
    {
        internal void LoginSuccess(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            IWebElement SignIn = driver.FindElement(By.XPath("//a[contains(.,'Sign In')]"));
            SignIn.Click();

            IWebElement EmailAddress = driver.FindElement(By.XPath("//input[@name='email']"));
            EmailAddress.SendKeys("mvpstudio.qa@gmail.com");

            IWebElement password = driver.FindElement(By.XPath("//input[@name='password']"));
            password.SendKeys("SydneyQa2018");

            IWebElement LoginBtn = driver.FindElement(By.XPath("//button[contains(.,'Login')]"));
            LoginBtn.Click();
       




        }
    }
}