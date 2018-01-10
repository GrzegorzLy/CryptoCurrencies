using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.DecoratorView
{
    class AbstractFactoryMainWindow : AbstractFactoryView
    {

        public override IConsoleView GetView(Market.MarketAbstract marketAbstract, User user)
        {
            return new MarketInfoDecorator(new MainConsoleView(user), marketAbstract);
        }

    }
}
