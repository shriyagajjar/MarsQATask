using Amazon.DynamoDBv2;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MarsQATask.Page
{
    class ShareSkills
    {

        public IWebDriver WebDriver { get; }
        public ShareSkills(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement clkShareSkillbtn => WebDriver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
        public IWebElement titletxtbox => WebDriver.FindElement(By.XPath("//*[@name='title']"));
        public IWebElement desctxtbox => WebDriver.FindElement(By.XPath("//*[@name='description']"));
        public IWebElement clkdrpdwn => WebDriver.FindElement(By.XPath("//*[@name='categoryId']"));
        public IWebElement clksubcdrpdwn => WebDriver.FindElement(By.XPath("//*[@name='subcategoryId']"));
        public IWebElement AddTag => WebDriver.FindElement(By.XPath("//*[@class='form-wrapper field  ']/div/div/div/input")); public IWebElement Servicetype => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[5]/div[2]/div[1]/div[1]/div/input"));
        public IWebElement Locationtype => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[6]/div[2]/div/div[2]/div/input"));
        public IWebElement startdate => WebDriver.FindElement(By.XPath("//*[@name='startDate']"));
        public IWebElement Skilltrade => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[8]/div[2]/div/div[1]/div/input"));
        public IWebElement skillExch => WebDriver.FindElement(By.XPath("//*[@class='field  ']/div/div/div/div/input"));
        public IWebElement imageUpload => WebDriver.FindElement(By.XPath("//*[@class='huge plus circle icon padding-25']"));
        public IWebElement active => WebDriver.FindElement(By.XPath("//*[@class='ui form']/div[10]/div[2]/div/div[1]/div/input"));
        public IWebElement clkSave => WebDriver.FindElement(By.XPath("//*[@class='ui teal button']"));

        public void ShareSkillbtn() => clkShareSkillbtn.Click();
        public void Startdate() => startdate.Click();

        public void ShareskillDetails(string Title, string Description, string Category, string Subcategory, string Tags, string ServiceType, string LocationType, string SkillTrade, string SkillExchange, string WorkSamples, string Active)
        {

            titletxtbox.SendKeys(Title);
            desctxtbox.SendKeys(Description);
            clkdrpdwn.SendKeys(Category);
            clksubcdrpdwn.SendKeys(Subcategory);
            AddTag.SendKeys(Tags);
            AddTag.SendKeys(Keys.Enter);
            Servicetype.SendKeys(ServiceType);
            Locationtype.SendKeys(LocationType);
            Skilltrade.SendKeys(SkillTrade);
            skillExch.SendKeys(SkillExchange);
            skillExch.SendKeys(Keys.Enter);
            //imageUpload.Click();// need to done 
            active.Click();


        }

        public void submit() => clkSave.Click();
    }
}

