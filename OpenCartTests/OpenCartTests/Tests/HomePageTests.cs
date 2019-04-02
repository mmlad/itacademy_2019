using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using OpenCartTests.Core;

namespace OpenCartTests.Tests
{
    [TestClass]
    public class HomePageTests : BaseTest
    {

        [TestCategory("HomePageTests")]
        [TestMethod]
        public void Test01NavigateToHomePage()
        {
            var driver = Driver.Browser;

            driver.Navigate().GoToUrl(@"https://www.opencart.com");

            Thread.Sleep(1000);
    
            var homePageHeading = driver.FindElement(By.CssSelector("h1"));

            var expectedHeadingText = "The best FREE and open-source eCommerce platform";

            var actualHeadingText = homePageHeading.Text;

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }

        
    }
}
