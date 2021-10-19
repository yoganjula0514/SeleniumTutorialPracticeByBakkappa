using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicSeleniumProject
{
    [TestFixture]
    class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Yoganjula Reddy Gangarapu", "yoganjula.g@hotmail.com")]
        public void T01_Tutorial04()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.facebook.com/";
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");
            webDriver.Quit();
        }

        [Test]
        [Author("Yoganjula Reddy Gangarapu", "yoganjula.g@hotmail.com")]
        public void T02_Tutorial04()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.facebook.com/";
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");
            webDriver.Quit();
        }
    }
}
