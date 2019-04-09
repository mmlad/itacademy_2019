using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTests.Core;
using OpenCartTests.Data;
using OpenCartTests.Pages;
using OpenCartTests.Utils;

namespace OpenCartTests.Tests
{
    [TestClass]
    public class AdminDemoDashboardPage :BaseTest
    {
        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test01NavigateToAdminPanelDashboardPage()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();

            loginPage.Validate().LoginForm();

            var user = TestData.User;

            loginPage.TypeUsername(user.Username);
            loginPage.TypePassword(user.Password);
            loginPage.ClickLoginButton();

            var dashboardPage = new DashboardPage();

            //Assert.AreEqual(TestData.UserFullName, dashboardPage.GetLoggedUserFullName());
            dashboardPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test02AlternativeNavigateToAdminPanelDashboardPage()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            dashboardPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test003LoginAndLogout()
        {
            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            var user = TestData.User;

            var dashboardPage = loginPage.Login(user);

            dashboardPage.Validate().SuccessfulLogin();

            loginPage = dashboardPage.Header.Logout();
            loginPage.Validate().LoginForm();
        }
    }
}
