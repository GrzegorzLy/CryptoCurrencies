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
            showCoins();
        }

        public void showCoins()
        {
            int xPositon = 10;

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Buy(zl): ");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Sell(zl): ");
            foreach (Coin coin in marketAbstract.ListOfCoins)
            {
                Console.SetCursorPosition(xPositon, 3);
                Console.WriteLine(coin.Name);
                Console.SetCursorPosition(xPositon, 4);
                Console.WriteLine(coin.buyValue);
                Console.SetCursorPosition(xPositon, 5);
                Console.WriteLine(coin.sellValue);
                xPositon += 15;
            }
        }

    }
}
