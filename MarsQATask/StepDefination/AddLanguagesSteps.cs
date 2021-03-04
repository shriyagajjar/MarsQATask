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
    public class AddLanguagesSteps
    {
        private ChromeDriver webdriver;
        Languages languages;

        [Given(@"User is using chrome browser")]
        public void GivenUserIsUsingChromeBrowser()
        {
            webdriver = new ChromeDriver();
            languages = new Languages(webdriver);
        }

        [Given(@"User click Languages tab in profile page")]
        public void GivenUserClickLanguagesTabInProfilePage()
        {
            languages.ClickLanguage();
        }
        
        [Given(@"User click Add New button")]
        public void GivenUserClickAddNewButton()
        {
            languages.ClickAddbtn();
        }
        
        [When(@"Navigate to ""(.*)"" url")]
        public void WhenNavigateToUrl(string p0)
        {
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            webdriver.Manage().Window.Maximize();
            webdriver.FindElement(By.CssSelector("a[class='item']")).Click();

        }

        [When(@"Enter valid login credentials ""(.*)"" and ""(.*)""")]
        public void WhenEnterValidLoginCredentialsAnd(string Username, string Password)
        {
            webdriver.FindElement(By.CssSelector("input[placeholder = 'Email address']")).SendKeys(Username);
            webdriver.FindElement(By.Name("password")).SendKeys(Password);
            webdriver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button']")).Click();
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"add new language (.*) and (.*)")]
        public void WhenAddNewLanguageAnd(string Language, string LanguageLevel)
        {
            languages.AddLang(Language,LanguageLevel);
        }
        
        [Then(@"verify user is logged in")]
        public void ThenVerifyUserIsLoggedIn()
        {
            Thread.Sleep(5000);
            var isnamepresent = webdriver.FindElement(By.XPath("//span[text()='shriya']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");

        }


        [Then(@"language should be added")]
        public void ThenLanguageShouldBeAdded()
        {
            languages.ClkAddLangbtn();
        }
    }
}
