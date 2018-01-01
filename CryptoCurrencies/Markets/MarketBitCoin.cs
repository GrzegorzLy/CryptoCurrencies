using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketBitCoin : Market
    {
        public MarketBitCoin(List<Coin> ListOfCoins) : base(ListOfCoins)
        {
        }

        public override string Name { get; } = "BitCoin Market";
   
    }
}
