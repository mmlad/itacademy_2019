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
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test02AlternativeNavigateToAdminPanelDashboardPage()
        {
            var dashboardPage = LoginProvider();

            dashboardPage.Validate().SuccessfulLogin();
        }

        [TestCategory("MladenTests")]
        [TestMethod]
        public void Test003LoginAndLogout()
        {
            var dashboardPage = LoginProvider();
            dashboardPage.Validate().SuccessfulLogin();

            var loginPage = dashboardPage.Header.Logout();

            loginPage.Validate().LoginForm();
        }

        public DashboardPage LoginProvider()
        {
            var user = TestData.User;

            var loginPage = new LoginPage();
            loginPage.Navigate();
            loginPage.Validate().LoginForm();

            return loginPage.Login(user);
        }
    }
}
