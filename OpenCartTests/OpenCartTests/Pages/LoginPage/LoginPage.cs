using OpenCartTests.Core;
using OpenCartTests.Data.Models;

namespace OpenCartTests.Pages
{
    public class LoginPage : BasePage<LoginPageElementMap, LoginPageValidator>
    {
        private string pageURL = "https://demo.opencart.com/admin/";
    
        internal void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(pageURL);
        }

        internal void TypeUsername(string username)
        {
            var usernameElement = Map.UsernameElement;
            usernameElement.Clear();
            usernameElement.SendKeys(username);
        }

        internal void TypePassword(string password)
        {
            var passwordElement = Map.PasswordElement;
            passwordElement.Clear();
            passwordElement.SendKeys(password);
        }

        internal void ClickLoginButton()
        {
            var element = Map.LoginButton;
            // ScrollToElement(element);
            element.Click();
        }

        public DashboardPage Login(User user)
        {
            TypeUsername(user.Username);
            TypePassword(user.Password);
            ClickLoginButton();

            return new DashboardPage();
        }

        public string GetUsernameInputValue()
        {
            return Map.UsernameElement.GetAttribute("value");
        }
    }
}
