using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BasicSeleniumProject
{
    [TestFixture]
    class DropdownListTest
    {
        private IWebDriver m_WebDriver;

        [SetUp]
        public void SetUp()
        {
            m_WebDriver = new ChromeDriver();
            m_WebDriver.Url =
                "https://www.facebook.com/reg/?privacy_mutation_token=eyJ0eXBlIjowLCJjcmVhdGlvbl90aW1lIjoxNjM0MjI5OTkyLCJjYWxsc2l0ZV9pZCI6MzYzOTY5MDQ0ODc4OTI4fQ%3D%3D";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            m_WebDriver.Quit();
            m_WebDriver.Dispose();
        }

        [Test]
        public void SelectDropdownTest()
        {
            IWebElement monthWebElement = m_WebDriver.FindElement(By.XPath(".//*[@id = 'month']"));
            SelectElement selectElement = new SelectElement(monthWebElement);
            selectElement.SelectByIndex(2);
            selectElement.SelectByText("Dec");
            selectElement.SelectByValue("8");

            Thread.Sleep(10000);
        }
    }
}
