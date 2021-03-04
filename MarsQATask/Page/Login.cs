using OpenQA.Selenium;

namespace MarsQATask.Page
{
    class Login
    {

        public IWebDriver WebDriver { get; }

        public Login(IWebDriver webDriver)
        {
            WebDriver = webDriver;

        }

        public IWebElement lnkLogin => WebDriver.FindElement(By.CssSelector("a[class='item']"));
        public IWebElement txtEmail => WebDriver.FindElement(By.CssSelector("input[placeholder = 'Email address']"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button']"));

        public void ClickLogin() => lnkLogin.Click();

        public void LoginPage(string Username, string Password)
        {
            txtEmail.SendKeys(Username);
            txtPassword.SendKeys(Password);
        }


        public void ClickLoginButton() => btnLogin.Submit();


        public void Closebrowser() => WebDriver.Close();


    }
}


