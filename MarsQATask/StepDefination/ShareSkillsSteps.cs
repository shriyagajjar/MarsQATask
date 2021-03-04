using MarsQATask.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQATask.StepDefination
{
    [Binding]
    public class ShareSkillsSteps
    {
        ShareSkills shareskills;

        private IWebDriver webdriver;
        [Given(@"User using the Chrome browser")]
        public void GivenUserUsingTheChromeBrowser()
        {
            webdriver = new ChromeDriver();
            //shareskills = new ShareSkills(webdriver);
        }

        [Given(@"User clicks on the Share Skill button")]
        public void GivenUserClicksOnTheShareSkillButton()
        {
            shareskills.ShareSkillbtn();
        }

        [When(@"Useris  navigates to ""(.*)"" url")]
        public void WhenUserisNavigatesToUrl(string p0)
        {
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            webdriver.Manage().Window.Maximize();
            webdriver.FindElement(By.CssSelector("a[class='item']")).Click();
        }

        [When(@"User is enter the valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserIsEnterTheValidLoginCredentialsAnd(string Username, string Password)
        {
            webdriver.FindElement(By.CssSelector("input[placeholder = 'Email address']")).SendKeys(Username);
            webdriver.FindElement(By.Name("password")).SendKeys(Password);
            webdriver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button']")).Click();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"User enter the details (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*) and (.*)")]
        public void WhenUserEnterTheDetailsAnd(string Title, string Description, string Category, string Subcategory, string Tags, string ServiceType, string LocationType, string SkillTrade, string SkillExchange, string WorkSamples, string Active)
        {
            shareskills.ShareskillDetails(Title, Description, Category, Subcategory, Tags, ServiceType, LocationType, SkillTrade, SkillExchange, WorkSamples, Active);

        }

        [When(@"User entere Available Days")]
        public void WhenUserEntereAvailableDays()
        {
            shareskills.Startdate();
        }

        [Then(@"User able to log in to the application")]
        public void ThenUserAbleToLogInToTheApplication()
        {
            Thread.Sleep(5000);
            var isnamepresent = webdriver.FindElement(By.XPath("//span[text()='shriya']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");

        }

        [Then(@"that Skills should be added to the Manage Listing page")]
        public void ThenThatSkillsShouldBeAddedToTheManageListingPage()
        {
            shareskills.submit();
        }
    }
}
