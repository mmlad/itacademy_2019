using OpenCartTests.Core;
using OpenQA.Selenium;

namespace OpenCartTests.Pages
{
    public class DashboardPage
    {
        public string GetLoggedUserFullName()
        {
            var loggedUserName = Driver.Browser.FindElement(By.XPath("//a[contains(text(),'demo demo ')]"));
            return loggedUserName.Text;
        }
    }
}
