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
    public class BaseTestWithSetUpAndTearDown
    {
        public IWebDriver WebDriver;
        [SetUp]
        public void Open()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Url = "https://www.facebook.com/";
        }

        [TearDown]
        public void Close()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}
