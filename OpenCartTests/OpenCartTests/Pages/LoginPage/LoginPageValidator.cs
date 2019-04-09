using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTests.Core;

namespace OpenCartTests.Pages
{
    public class LoginPageValidator : BasePageValidator<LoginPageElementMap>
    {
        public void LoginForm()
        {
            Assert.IsTrue(Map.UsernameElement.Displayed, "Username input is not displayed!");
            Assert.IsTrue(Map.PasswordElement.Displayed, "Password input is not displayed!");
            Assert.IsTrue(Map.LoginButton.Displayed, "Login button is not displayed!");
        }
    }
}
