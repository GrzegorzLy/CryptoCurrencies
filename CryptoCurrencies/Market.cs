using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    abstract class Market
    {
        public abstract string Name { get;}
        public List<Coin> ListOfCoins { get; set; }


        public Market(List<Coin> ListOfCoins)
        {
            this.ListOfCoins = ListOfCoins;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
