using OpenCartTests.Core;

namespace OpenCartTests.Pages
{
    public class Header : BaseComponent<HeaderElementMap, HeaderValidator>
    {
        public DashboardPage NavigateToDashboardPage()
        {
            Map.CompanyLogo.Click();

            return new DashboardPage();
        }

        public LoginPage Logout()
        {
            Map.LogoutButton.Click();

            return new LoginPage();
        }

        public void OpenProfileMenu()
        {
            Map.UserProfileName.Click();
        }

        //public ProfilePage NavigateToUserProfile()
        //{
        //    OpenProfileMenu();
        //    Map.YourProfileLink.Click();

        //    return new ProfilePage()
        //}

    }
}
