using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicSeleniumProject.Base
{
    public class BaseTestWithOneTimeSetUpAndTearDown
    {
        public IWebDriver WebDriver;
        [OneTimeSetUp]
        public void Open()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Url = "https://www.facebook.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            WebDriver.Quit();
        }
    }
}
