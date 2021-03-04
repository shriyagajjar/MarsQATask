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
    public class DeleteLanguagesSteps
    {
        private ChromeDriver webdriver;
        Languages languages;
        [Given(@"open chrome browser")]
        public void GivenOpenChromeBrowser()
        {
            webdriver = new ChromeDriver();
            languages = new Languages(webdriver);
        }
        
        [Given(@"User is click on the Languages tab in profile page")]
        public void GivenUserIsClickOnTheLanguagesTabInProfilePage()
        {
            languages.ClickLanguage();
        }
        
        [When(@"User is navigates to ""(.*)"" url")]
        public void WhenUserIsNavigatesToUrl(string p0)
        {

            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            webdriver.Manage().Window.Maximize();
            webdriver.FindElement(By.CssSelector("a[class='item']")).Click();
        }
        
        [When(@"Enter the valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenEnterTheValidLoginCredentialsAnd(string Username, string Password)
        {
            webdriver.FindElement(By.CssSelector("input[placeholder = 'Email address']")).SendKeys(Username);
            webdriver.FindElement(By.Name("password")).SendKeys(Password);
            webdriver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button']")).Click();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"User is click on the Delete button")]
        public void WhenUserIsClickOnTheDeleteButton()
        {
            languages.ClickDelete();
        }
        
        [Then(@"verify user is able to logged in")]
        public void ThenVerifyUserIsAbleToLoggedIn()
        {
            Thread.Sleep(5000);
            var isnamepresent = webdriver.FindElement(By.XPath("//span[text()='shriya']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");
        }
        
        [Then(@"Languages should be deleted on the Languages page")]
        public void ThenLanguagesShouldBeDeletedOnTheLanguagesPage()
        {
            
        }
    }
}
