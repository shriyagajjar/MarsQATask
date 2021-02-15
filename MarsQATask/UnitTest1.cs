using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsQATask
{
    public class Test
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //launch the browser

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
        }
        [TearDown]
            public void TeardownTest()
            {

                driver.Quit();
            }
        }
    }

