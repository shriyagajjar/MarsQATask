using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQATask.Page
{
    class Login
    {
        IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NavigateTO()
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
        }

        public void join(string value)
        {
            driver.FindElement(By.ClassName("ui green basic button")).SendKeys(value);
        }
        public void FirstName(string value)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(value);
        }
        public void LastName(string value)
        {
            driver.FindElement(By.Name("lastName")).SendKeys(value);
        }
        public void Email(string value)
        {
            driver.FindElement(By.Name("email")).SendKeys(value);
        }
        public void Password(string value)
        {
            driver.FindElement(By.Name("password")).SendKeys(value);
        }
        public void ConfirmPassword(string value)
        {
            driver.FindElement(By.Name("confirmPassword")).SendKeys(value);
        }
    }
}
       /* public void checkbox(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys(value);
        }*/
        