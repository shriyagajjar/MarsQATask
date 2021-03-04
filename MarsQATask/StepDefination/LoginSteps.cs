using MarsQATask.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQATask.StepDefination
{
    [Binding]
    public partial class LoginSteps
    {
        Login login = null;
        [Given(@"User is navigate the URL")]
        public void GivenUserIsNavigateTheURL()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            webdriver.Manage().Window.Maximize();
            //login = new Login(webdriver);
        }

        [Given(@"click on Sign in button to login")]
        public void GivenClickOnSignInButtonToLogin()
        {
            login.ClickLogin();
        }

        [When(@"User enters (.*) and (.*)")]
        public void WhenUserEntersAnd(string Username, string Password)
        {

            login.LoginPage(Username, Password);
        }

        [Then(@"click on login button")]
        public void ThenClickOnLoginButton()
        {
            login.ClickLoginButton();
            login.Closebrowser();
        }
    }
}
