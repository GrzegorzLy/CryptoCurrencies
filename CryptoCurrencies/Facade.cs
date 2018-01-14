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
        Mediator mediator;

        /// <summary>
        /// design pattern facade
        /// </summary>
        public Facade()
        {
            factoryMarket = new Market.FactoryMarket();
            
        }


        /// <summary>
        /// Start program - creat market, view...
        /// </summary>
        public void StartProgram()
        {
            user = Login.start();

            //designe pattern abstract factory
            market = factoryMarket.CreatMarket();

            //design pattern abstract factory and decorator
            CreatView(Enum.ViewEnum.MainWindow);
            if(consoleView != null)
            {
                consoleView.Write();
            }
            mediator = new Mediator(consoleView);
            market.addObserver(mediator);
                    
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

        /// <summary>
        /// Change connection type
        /// Designe pattenrs Singleton, strategy, adapter
        /// </summary>
        public void ChangeConnection()
        {
            GlobalConfig.globalConfig.ChangeConnection();
        }
    }
}
