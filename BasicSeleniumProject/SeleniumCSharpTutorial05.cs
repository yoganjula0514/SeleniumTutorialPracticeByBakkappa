using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicSeleniumProject
{
    [TestFixture]
    class SeleniumCSharpTutorial05
    {
        IExtentReports 
        [OneTimeSetUp]
        public void ExtentStart()
        {

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {

        }

        [Test]
        public void T01_Tutorial_05_TakeScreenshot()
        {
            IWebDriver webDriver=null;
            try
            {
                webDriver = new ChromeDriver();
                webDriver.Manage().Window.Maximize();
                webDriver.Url = "https://www.facebook.com/";
                IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
                emailWebElement.SendKeys("Selenium C#");
                webDriver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot takesScreenshot = webDriver as ITakesScreenshot;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile(@"filepath\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                webDriver?.Quit();
            }
        }


        [Test]
        public void T02_Tutorial_05()
        {
            IWebDriver webDriver = null;
            try
            {
                webDriver = new ChromeDriver();
                webDriver.Manage().Window.Maximize();
                webDriver.Url = "https://www.facebook.com/";
                IWebElement emailWebElement = webDriver.FindElement(By.XPath(".//*[@id='email']"));
                emailWebElement.SendKeys("Selenium C#");
                webDriver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot takesScreenshot = webDriver as ITakesScreenshot;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile(@"filepath\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                webDriver?.Quit();
            }

        }
    }
}
