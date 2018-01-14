using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencies.DecoratorView;

namespace CryptoCurrencies
{
    public class Mediator : IObserver
    {
        IConsoleView consoleViewMarket;

        public Mediator(IConsoleView consoleViewMarket)
        {
            this.consoleViewMarket = consoleViewMarket;
        }

        public void update()
        {
            consoleViewMarket.Write();
        }

       
    }
}
