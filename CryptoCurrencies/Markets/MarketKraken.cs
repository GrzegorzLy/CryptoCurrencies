using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketKraken : Market
    {
        public override string Name { get; } = "Kraken Market";
        public override List<Coin> ListOfCoins { get; set; }

    }
}
