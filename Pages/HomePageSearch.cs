using OpenQA.Selenium;
using System;

namespace SkillSwap
{
    internal class HomePageSearch
    {
        internal void SkillSearch(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            System.Threading.Thread.Sleep(4000);
            IWebElement SearchBar = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/input[1]"));
            SearchBar.SendKeys("Cypress");

            driver.FindElement(By.XPath("//button[contains(.,'Search')]")).Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement SellerProfile = driver.FindElement(By.XPath("//p[contains(.,'Cypress')]"));
            SellerProfile.Click();
        }
    }
}