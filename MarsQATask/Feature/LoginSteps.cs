using MarsQAtask.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQATask.Feature
{
    [Binding]
    public class LoginSteps
    {
        readonly IWebDriver driver = new ChromeDriver();


        [Given(@"Navigate to given URL")]
        public void GivenNavigateToGivenURL()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");
        }
        
        [Given(@"click sign in to open login")]
        public void GivenClickSignInToOpenLogin()
        {
            //go to LoginPage 
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }
        
        [When(@"Login with valid Username,Password")]
        public void WhenLoginWithValidUsernamePassword()
        {
           
        }
        
        [When(@"verify user name should be seen on the profilePage")]
        public void WhenVerifyUserNameShouldBeSeenOnTheProfilePage()
        {
            //verify name on profile page
            Thread.Sleep(3000);
            var isnamepresent = driver.FindElement(By.XPath("//span[text()='shriya']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");
            driver.Close();

        }
    }
}
