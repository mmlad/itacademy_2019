using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace OpenCartTests
{
    [TestClass]
    public class HomePageTests
    {
        IWebDriver driver;

        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TestTeardown()
        {
            driver.Quit();
        }

        [TestCategory("HomePageTests")]
        [TestMethod]
        public void Test01NavigateToHomePage()
        {
            driver.Navigate().GoToUrl(@"https://www.opencart.com");

            Thread.Sleep(1000);
    
            var homePageHeading = driver.FindElement(By.CssSelector("h1"));

            var expectedHeadingText = "The best FREE and open-source eCommerce platform";

            var actualHeadingText = homePageHeading.Text;

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }

        [TestCategory("HomePageTests")]
        [TestMethod]
        public void Test02NavigateToDemo()
        {
            driver.Navigate().GoToUrl(@"https://demo.opencart.com/admin/");

            Thread.Sleep(1000);
            
            var userName = driver.FindElement(By.Id("input-username"));

            var password = driver.FindElement(By.Id("input-password"));
            
            var loginButton = driver.FindElement(By.CssSelector("button.btn"));

            userName.Clear();
            userName.SendKeys("demo");

            password.Clear();
            password.SendKeys("demo");

            loginButton.Click();
            Thread.Sleep(2000);
            
            var loggedUserName = driver.FindElement(By.XPath("//a[contains(text(),'demo demo ')]"));

            Assert.AreEqual("demo demo", loggedUserName.Text);
        }
    }
}
