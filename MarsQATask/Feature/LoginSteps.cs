using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQATask.Feature
{
    [Binding]
    public class LoginSteps
    {
        String test_url = "http://localhost:5000";
        IWebDriver driver;

        [Given(@"Navigate to Given URL")]
        public void GivenNavigateToGivenURL()
        {
            driver = new FirefoxDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"Navigate to the Login page")]
        public void GivenNavigateToTheLoginPage()
        {
            
        }
        
        [When(@"Login with valid Username,Password")]
        public void WhenLoginWithValidUsernamePassword()
        {
            
        }
        
        [When(@"Login with invalid Username,password")]
        public void WhenLoginWithInvalidUsernamePassword()
        {
            
        }
        
        [Then(@"user create an account with valid details")]
        public void ThenUserCreateAnAccountWithValidDetails()
        {
           
        }
        
        [Then(@"User should be sign in")]
        public void ThenUserShouldBeSignIn()
        {
            
        }
        
        [Then(@"seller Name should be seen on the profile Page")]
        public void ThenSellerNameShouldBeSeenOnTheProfilePage()
        {
            
        }
        
        [Then(@"User Should not able to sign in")]
        public void ThenUserShouldNotAbleToSignIn()
        {
            
        }
        
        [Then(@"shows error message")]
        public void ThenShowsErrorMessage()
        {
         
        }
    }
}
