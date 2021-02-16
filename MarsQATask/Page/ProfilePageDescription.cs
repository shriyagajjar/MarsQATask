using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQATask.Page
{
    class ProfilePageDescription
    { 
        readonly IWebDriver driver;

    public ProfilePageDescription(IWebDriver driver)
    {
        this.driver = driver;
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }
    
        public void Profile1()
        {
            //click on "Description edit" button and add description
            Thread.Sleep(5000);
          driver.FindElement(By.XPath("//i[@class='outline write icon']/ancestor::span[@class='button']")).Click();

            //enter description
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//textarea[@name='value']")).SendKeys("ABCDEFGH");

            //save description
            driver.FindElement(By.XPath("//button[@class='ui teal button' and @type='button']")).Click();
    }
}

}

 
