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
    public class DescriptionSteps
    {

        readonly IWebDriver driver = new ChromeDriver();

        [Given(@"Login with given Url")]
        public void GivenLoginWithGivenUrl()
        {
            // navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //go to LoginPage to add credentials
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [Given(@"click description Add/Edit icon on profile page")]
        public void GivenClickDescriptionAddEditIconOnProfilePage()
        {
            // verify that the login is successfull and add description on the profile tab
            var profilePage = new ProfilePageDescription(driver);
            profilePage.Profile1();
        }

        [Given(@"Enter description about (.*) or less characters")]
        public void GivenEnterDescriptionAboutOrLessCharacters(int p0)
        {


        }

        [When(@"click save button to save and display saved description")]
        public void WhenClickSaveButtonToSaveAndDisplaySavedDescription()
        {
            //verify that the 'saved' message is displayed
            Thread.Sleep(3000);
            var isdescpresent = driver.FindElement(By.XPath("//span[contains(text(),'ABCDEFGH')]"));
            Assert.IsTrue(isdescpresent.Displayed, "the value for name is not present");
            driver.Close();
           
        }
    }
}
