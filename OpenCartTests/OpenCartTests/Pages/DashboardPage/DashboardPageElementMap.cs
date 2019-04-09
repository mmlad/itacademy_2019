using OpenCartTests.Core;
using OpenQA.Selenium;

namespace OpenCartTests.Pages
{
    public class DashboardPageElementMap : BasePageElementMap
    {
        public IWebElement LoggedUserName
        {
            get
            {
                return GetElement(By.XPath("//a[contains(text(),'demo demo ')]"));
            }
        }
    }
}
