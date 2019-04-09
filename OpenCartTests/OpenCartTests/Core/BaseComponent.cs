using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OpenCartTests.Core
{
    public class BaseComponent<TM> where TM : BasePageElementMap, new()
    {
        protected IWebDriver driver = Driver.Browser;

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }

    public class BaseComponent<TM, TV> : BaseComponent<TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
    }
}
