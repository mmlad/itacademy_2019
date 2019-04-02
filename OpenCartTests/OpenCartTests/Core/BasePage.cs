using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartTests.Core
{
    public class BasePage<TM> where TM : BasePageElementMap, new()
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }
}
