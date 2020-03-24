using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SkillSwap
{
    internal class UpdateProfile
    {
        internal void AddDescription(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement DescEditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
            DescEditIcon.Click();

            System.Threading.Thread.Sleep(4000);
            IWebElement DescriptionBox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            DescriptionBox.SendKeys("I am tester");

            IWebElement DescSaveBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
            DescSaveBtn.Click();
        }

        internal void AddLanguage(IWebDriver driver)
        {
            IWebElement AddNewBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewBtn.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
            AddNewLanguage.SendKeys("English");

            System.Threading.Thread.Sleep(5000);
            SelectElement SE = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            SE.SelectByText("Fluent");

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }

        internal void AddSkills(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement Profile = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/div[1]/a[2]"));
            Profile.Click();

            IWebElement skills = driver.FindElement(By.XPath("(//a[@class='item'])[14]"));
            skills.Click();

            System.Threading.Thread.Sleep(1000);
            IWebElement AddNewBtn = driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));
            AddNewBtn.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement AddSkill = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));
            AddSkill.SendKeys("Coding");

            System.Threading.Thread.Sleep(5000);
            SelectElement se = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            se.SelectByText("Expert");

            IWebElement AddBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddBtn.Click();
        }

        internal void AddEducation(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(4000);
            IWebElement EducationTab = driver.FindElement(By.XPath("(//a[contains(.,'Education')])[1]"));
            EducationTab.Click();

            IWebElement AddNewBtn = driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[21]"));
            AddNewBtn.Click();

            IWebElement CollegeName = driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
            CollegeName.SendKeys("Wellington Institute Of Technology");

            System.Threading.Thread.Sleep(2000);
            SelectElement sCountry = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']")));
            sCountry.SelectByText("New Zealand");

            System.Threading.Thread.Sleep(5000);
            SelectElement sTitle = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']")));
            sTitle.SelectByText("M.Tech");

            IWebElement Degree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            Degree.SendKeys("Mastors in Information Technology");

            System.Threading.Thread.Sleep(5000);
            SelectElement sYearOgrad = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")));
            sYearOgrad.SelectByText("2017");


            IWebElement AddBtn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddBtn.Click();
        }

        internal void Signout(IWebDriver driver)
        {
            IWebElement signout = driver.FindElement(By.XPath("//button[@class='ui green basic button'][contains(.,'Sign Out')]"));
            signout.Click();
        }
    }
}