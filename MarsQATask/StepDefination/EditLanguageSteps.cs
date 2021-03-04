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
    public class EditLanguageSteps
    {
        private ChromeDriver webdriver;
        Languages languages;
        [Given(@"using chrome browser")]
        public void GivenUsingChromeBrowser()
        {
            webdriver = new ChromeDriver();
            languages = new Languages(webdriver);
        }
        
        [Given(@"User is  click on the Languages tab in profile page")]
        public void GivenUserIsClickOnTheLanguagesTabInProfilePage()
        {
            languages.ClickLanguage();
        }
        
        [Given(@"User is click on Edit button")]
        public void GivenUserIsClickOnEditButton()
        {
            languages.ClickEdit();
         
        }
        
        [When(@"User navigate to ""(.*)"" url")]
        public void WhenUserNavigateToUrl(string p0)
        {
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            webdriver.Manage().Window.Maximize();
            webdriver.FindElement(By.CssSelector("a[class='item']")).Click();
        }
        
        [When(@"User is Enter the valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenUserIsEnterTheValidLoginCredentialsAnd(string Username, string Password)
        {

            webdriver.FindElement(By.CssSelector("input[placeholder = 'Email address']")).SendKeys(Username);
            webdriver.FindElement(By.Name("password")).SendKeys(Password);
            webdriver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button']")).Click();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"User update Language information (.*)")]
        public void WhenUserUpdateLanguageInformation(string LanguageLevel)
        {
            languages.UpdateLang(LanguageLevel);
        }
        
        [Then(@"verify user to logged in")]
        public void ThenVerifyUserToLoggedIn()
        {
            Thread.Sleep(5000);
            var isnamepresent = webdriver.FindElement(By.XPath("//span[text()='shriya']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");
        }
        
        [Then(@"updated detail should be visible on the Languages page")]
        public void ThenUpdatedDetailShouldBeVisibleOnTheLanguagesPage()
        {
            languages.ClickUpdate();
        }
    }
}
