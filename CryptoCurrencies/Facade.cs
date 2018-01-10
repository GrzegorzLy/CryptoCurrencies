using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencies.DecoratorView;
namespace CryptoCurrencies
{
    public class Facade
    {
        User user;
        Market.IFactoryMarket factoryMarket;
        Market.MarketAbstract market;
        AbstractFactoryView factoryView;
        IConsoleView consoleView;


        public Facade()
        {
            factoryMarket = new Market.FactoryMarket();
        }

        public void StartProgram()
        {
            user = Login.start();
            market = factoryMarket.CreatMarket();
            CreatView(Enum.ViewEnum.MainWindow);
            if(consoleView != null)
            {
                consoleView.Write();
            }
                    
        }

        public void CreatView(Enum.ViewEnum viewEnum)
        {
            factoryView = AbstractFactoryView.getFactory(viewEnum);
            if (market != null && user != null)
            {
                consoleView = factoryView.GetView(market, user);

            }
            else
            {
                Console.WriteLine("Something goes wrong...");
                Environment.Exit(0);
            }
        }
    }
}
