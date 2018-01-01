using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketNevbit : Market
    {
        public MarketNevbit(List<Coin> ListOfCoins) : base(ListOfCoins)
        {
        }

        public override string Name { get; } = "Nevbit Market";


    }
}
