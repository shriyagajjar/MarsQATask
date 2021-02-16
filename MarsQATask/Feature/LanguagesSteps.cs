using MarsQAtask.Page;
using MarsQATask.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQATask.Feature
{
    [Binding]
    public class LanguagesSteps
    {
        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"Login to MarsQA with valid credential")]
        public void GivenLoginToMarsQAWithValidCredential()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //add login credentials
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }
        
        [Given(@"click Add new button to add one or more languages")]
        public void GivenClickAddNewButtonToAddOneOrMoreLanguages()
        {
            //add various language options under Profile tab
            var addLang = new AddLanguages(driver);
            addLang.ADDLanguage();
        }
        
        [Given(@"enter language in ""(.*)"" Field")]
        public void GivenEnterLanguageInField(string p0)
        {
            
        }
        
        [When(@"Choose Language Level and click ""(.*)"" button")]
        public void WhenChooseLanguageLevelAndClickButton(string p0)
        {
            
        }
        
        [Then(@"verify that language to profile page")]
        public void ThenVerifyThatLanguageToProfilePage()
        {
            //verify 'saved' language 
            Thread.Sleep(3000);
            var Langsave = driver.FindElement(By.XPath("//td[text() = 'Hindi']"));
            Assert.IsTrue(Langsave.Displayed, "the value for message is not present");

            driver.Close();
        }
    }
}
