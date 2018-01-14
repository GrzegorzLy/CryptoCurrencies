using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencies.Enum;

namespace CryptoCurrencies.Market
{
    abstract class MarketAbstract : ISubject
    {
        public List<Coin> ListOfCoins { get; set; }
        public string Name { get; set; }

        
        public MarketAbstract(List<Coin> listOfCoins)
        {
            this.ListOfCoins = listOfCoins;
        }
        public override string ToString()
        {
            return Name.ToString();
        }

        public abstract void addObserver(IObserver observer);


        public abstract void removeObserver(IObserver observer);


        public abstract void execute();
      
    }
}
