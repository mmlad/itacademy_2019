using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenCartTests.Core
{
    public class BaseTest
    {
        [TestInitialize]
        public void TestSetup()
        {
            Driver.StartBrowserChrome();
        }

        [TestCleanup]
        public void TestTeardown()
        {
            Driver.StopBrowser();
        }
    }
}
