using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CryptoCurrencies.Market;
using System.Data;

namespace CryptoCurrencies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design patterns: 
            // creational:  abstract factory(DecoratorView.AbstractFactoryView, Market.FactoryMarket),
            //              factory method(Coin),
            //              singleton(GlobalConfig)

            // structural: adapter(AdapterTextconnector),
            //             decorator(DecoratorView),
            //             facade(Facade)

            // behavioral: strategy(GlobalConfig)
            //             observer(Market.MarketAbstract and Mediator)
            //             mediator(Mediator)
            //TODO
            //User panel
            //txt connector
            //Login class => state pattern

            //Prosze o informacje czy wzorce sa wykorzystane w dobry sposob, albo o ewentualne zmiany jakie mozna 
            //zastosowac przed koncowa faza projektu.
            //Dziekuje, z wyrazami szacunku Grzegorz Łyczak.


            Facade facade = new Facade();
            facade.StartProgram();
            Console.ReadKey();


            

        }
    }
}
