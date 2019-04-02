using OpenCartTests.Core;
using OpenCartTests.Data.Models;
using OpenQA.Selenium;
using System;

namespace OpenCartTests.Pages
{
    public class LoginPage
    {
        private string pageURL = "https://demo.opencart.com/admin/";

        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        internal void TypeUsername(string username)
        {
            var usernameElement = Driver.Browser.FindElement(By.Id("input-username"));
            usernameElement.Clear();
            usernameElement.SendKeys(username);
        }

        internal void TypePassword(string password)
        {
            var passwordElement = Driver.Browser.FindElement(By.Id("input-password"));
            passwordElement.Clear();
            passwordElement.SendKeys(password);
        }

        internal void ClickLoginButton()
        {
            var loginButton = Driver.Browser.FindElement(By.CssSelector("button.btn"));
            loginButton.Click();
        }

        public void Login(User user)
        {
            TypeUsername(user.Username);
            TypePassword(user.Password);
            ClickLoginButton();
        }
    }
}
