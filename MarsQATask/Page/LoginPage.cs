using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQAtask.Page
{
    public class LoginPage
    {
        readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Login()
        {
            //navigate to the Url
            //driver.Navigate().GoToUrl("http://localhost:5000");

            //explicit wait
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //click thsign in button
            var signIn = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            signIn.Click();

            //enter username and password

            driver.FindElement(By.XPath("//input[@placeholder = 'Email address']")).SendKeys("shriya1.gajjar@gmail.com");

            driver.FindElement(By.XPath("//input[@placeholder = 'Password']")).SendKeys("Shriya@2906");

            //click the Login button

            driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();

           }
    }
}