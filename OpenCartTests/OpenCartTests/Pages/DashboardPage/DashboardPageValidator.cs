using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCartTests.Core;
using OpenCartTests.Data;

namespace OpenCartTests.Pages
{
    public class DashboardPageValidator : BasePageValidator<DashboardPageElementMap>
    {
        internal void SuccessfulLogin()
        {
            Assert.AreEqual(TestData.UserFullName, Map.LoggedUserName.Text);
        }
    }
}
