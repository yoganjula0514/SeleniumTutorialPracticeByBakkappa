// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using BasicSeleniumProject.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BasicSeleniumProject
{
    [TestFixture] // Representation of the class
    public class TestClass : BaseTestWithSetUpAndTearDown
    {
        [Test] // Refer the below method is one Test
        [Category("Smoke Testing")]
        public void T01_TestMethod_FindEmailWebElementAndEnterText()
        {
            IWebElement emailWebElement = WebDriver.FindElement(By.XPath(".//*[@id='email']"));
            emailWebElement.SendKeys("Selenium C#");
        }

        [Test] // Refer the below method is one Test
        [Category("Smoke Testing")]
        public void T02_TestMethod_FindPasswordWebElementAndEnterText()
        {
            IWebElement passwordWebElement = WebDriver.FindElement(By.XPath(".//*[@id='pass']"));
            passwordWebElement.SendKeys("Welcome@1234");
        }

        [Test, Category("Regression Testing")] // Refer the below method is one Test
        public void T03_TestMethod_FindLoginWebElementAndEnterText()
        {
            IWebElement loginWebElement = WebDriver.FindElement(By.XPath(".//*[@name='login']"));
            loginWebElement.Click();
        }
    }
}
