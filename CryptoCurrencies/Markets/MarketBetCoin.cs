using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketBetCoin : Market
    {
        public override string Name { get; } = "BetCoin Market";
        public override List<Coin> ListOfCoins { get; set; }
    }
}
