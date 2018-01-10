using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.DecoratorView
{
    abstract class ConsoleViewDecorator : IConsoleView
    {
        protected IConsoleView consoleView;
        public ConsoleViewDecorator(IConsoleView consoleView)
        {
            this.consoleView = consoleView;
        }
        public abstract void Write();

    }
}
