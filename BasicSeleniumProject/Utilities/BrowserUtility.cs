using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicSeleniumProject.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.facebook.com/";
            webDriver.Manage().Window.Maximize();

            return webDriver;
        }
    }
}
