using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSeleniumProject.Utilities;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace BasicSeleniumProject
{
    [TestFixture()]
    class ParallelTesting
    {
        private IWebDriver m_WebDriver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void T01()
        {
            BrowserUtility browserUtility = new BrowserUtility();
            var webDriver = browserUtility.Init(m_WebDriver);
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");

            webDriver.Close();
        }
        
        [Test, Category("UAT Testing"), Category("Module1")]
        public void T02()
        {
            BrowserUtility browserUtility = new BrowserUtility();
            var webDriver = browserUtility.Init(m_WebDriver);
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");

            webDriver.Close();
        }
        
        [Test, Category("UAT Testing"), Category("Module1")]
        public void T03()
        {
            BrowserUtility browserUtility = new BrowserUtility();
            var webDriver = browserUtility.Init(m_WebDriver);
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");

            webDriver.Close();
        }
        
        [Test, Category("UAT Testing"), Category("Module1")]
        public void T04()
        {
            BrowserUtility browserUtility = new BrowserUtility();
            var webDriver = browserUtility.Init(m_WebDriver);
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");

            webDriver.Close();
        }
        
        [Test, Category("UAT Testing"), Category("Module1")]
        public void T05()
        {
            BrowserUtility browserUtility = new BrowserUtility();
            var webDriver = browserUtility.Init(m_WebDriver);
            IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");

            webDriver.Close();
        }
    }
}
