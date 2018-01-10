using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencies.Market;

namespace CryptoCurrencies.DecoratorView
{
    class AbstractFactoryMenu : AbstractFactoryView
    {
        public override IConsoleView GetView(MarketAbstract marketAbstract, User user)
        {
            throw new NotImplementedException();
        }
    }
}
