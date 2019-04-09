using OpenCartTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OpenCartTests.Core
{
    public class BasePage<TM> where TM : BasePageElementMap, new()
    {
        protected IWebDriver driver = Driver.Browser;

        public Header Header { get; protected set; }

        public BasePage()
        {
        }

        public BasePage(Header headerComponent)
        {
            this.Header = headerComponent;
        }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public void BrowserBackButton()
        {
            driver.Navigate().Back();
        }

        public void BrowserRefresh()
        {
            driver.Navigate().Refresh();
        }

        public void ScrollToElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public void ScrollToBottomOfPage()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
        }

        public IAlert SwitchToAlert()
        {
            return driver.SwitchTo().Alert();
        }
    }

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public BasePage()
        {
        }

        public BasePage(Header headerComponent)
        {
            this.Header = headerComponent;
        }

        public TV Validate()
        {
            return new TV();
        }
    }
}
