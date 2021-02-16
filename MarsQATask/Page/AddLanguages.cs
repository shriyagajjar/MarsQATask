﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQATask.Page
{
    class AddLanguages

    {
        readonly IWebDriver driver;

        public AddLanguages(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void ADDLanguage()
        {
            //click on the 'Language' tab
            driver.FindElement(By.XPath("//div/a[text()='Languages']")).Click();

            //add details under language tab
            var langDetails = driver.FindElement(By.XPath("//tr/th[text()='Language']//following-sibling::th/div[text()='Add New']"));
            langDetails.Click();

            //add first language
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            driver.FindElement(By.XPath("//select/option[@value='Basic']")).Click();

            driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

            //click add new button to add second language
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//tr/th[text()='Language']//following-sibling::th/div[text()='Add New']")).Click();

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Hindi");

            driver.FindElement(By.XPath("//select/option[@value='Fluent']")).Click();

            driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

            //click add new button to add third language and then 'cancel'
            Thread.Sleep(5000);

           driver.FindElement(By.XPath("//tr/th[text()='Language']//following-sibling::th/div[text()='Add New']")).Click();

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("Gujarati");

            driver.FindElement(By.XPath("//select/option[@value='Conversational']")).Click();

            driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']")).Click();






        }
    }
}

