using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OpenCartTests.Core
{
    public static class Driver
    {
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("Webdriver is not started! Call StartBrowser method first!");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static void StartBrowser()

        {
            Browser = new ChromeDriver();
            Browser.Manage().Window.Maximize();
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
        }
    }
}
