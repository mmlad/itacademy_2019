using OpenCartTests.Core;

namespace OpenCartTests.Pages
{
    public class DashboardPage : BasePage<DashboardPageElementMap, DashboardPageValidator>
    {
        public DashboardPage() : base(new Header())
        {
        }

        public string GetLoggedUserFullName()
        {
            var loggedUserName = Map.LoggedUserName;
            return loggedUserName.Text;
        }
    }
}
