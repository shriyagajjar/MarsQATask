using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQATask.Page
{
    class Languages
    {
        public IWebDriver WebDriver { get; }
        public Languages(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement ClkLangTab => WebDriver.FindElement(By.CssSelector("a[class='item active']"));
        public IWebElement Addnewbtn => WebDriver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        public IWebElement AddLanguage => WebDriver.FindElement(By.CssSelector("input[placeholder='Add Language']")); 
        public IWebElement SelectLevel => WebDriver.FindElement(By.CssSelector("select[name='level']"));
        public IWebElement BtnADD => WebDriver.FindElement(By.CssSelector("input[value='Add']"));
        public IWebElement Editbtn => WebDriver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
        public IWebElement Deltbtn => WebDriver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='remove icon']"));
        public IWebElement Updatebtn => WebDriver.FindElement(By.XPath("//input[@class='ui teal button']"));


        public void ClickLanguage() => ClkLangTab.Click();
        public void ClickAddbtn() => Addnewbtn.Click();
        public void ClkAddLangbtn() => BtnADD.Click();
        public void ClickEdit() => Editbtn.Click();
        public void ClickDelete() => Deltbtn.Click();
        public void ClickUpdate() => Updatebtn.Click();
        
        public void AddLang(string Language, string LanguageLevel)
        {
            AddLanguage.SendKeys(Language);
            SelectLevel.SendKeys(LanguageLevel);
        }

        public void UpdateLang(string LanguageLevel)
        {
            SelectLevel.SendKeys(LanguageLevel);
        }
    }
}

