using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using OpenCartTests.Core;
using OpenCartTests.Pages;
using OpenCartTests.Data;

namespace OpenCartTests.Tests
{
    [TestClass]
    public class AdminLoginPageTests : BaseTest
    {
        [TestCategory("AdminLoginPageTests")]
        [TestMethod]
        public void Test01NavigateToAdminDemo()
        {
            var driver = Driver.Browser;

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

        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test02VerifyDefaultUsernameValue()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            Assert.AreEqual(TestData.UsernameDefaultValue, loginPage.GetUsernameInputValue());
        }
    }
}
