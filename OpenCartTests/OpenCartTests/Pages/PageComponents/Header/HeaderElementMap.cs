using OpenCartTests.Core;
using OpenQA.Selenium;

namespace OpenCartTests.Pages
{
    public class HeaderElementMap : BasePageElementMap
    {
        public IWebElement CompanyLogo { get; internal set; }
        public IWebElement LogoutButton
        {
            get
            {
                return GetElement(By.CssSelector(".fa-sign-out"));
            }

        }
        public IWebElement UserProfileName { get; internal set; }
        public IWebElement YourProfileLink { get; internal set; }
    }
}
