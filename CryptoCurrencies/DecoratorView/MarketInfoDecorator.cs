using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.DecoratorView
{
    class MarketInfoDecorator : ConsoleViewDecorator
    {
        Market.MarketAbstract marketAbstract;
        public MarketInfoDecorator(IConsoleView consoleView, Market.MarketAbstract marketAbstract) : base(consoleView)
        {
            this.marketAbstract = marketAbstract;
        }

        public override void Write()
        {
            consoleView.Write();
            Console.WriteLine("sie robi...");
        }


    }
}
