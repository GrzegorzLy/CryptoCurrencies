using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketNevbit : Market
    {
        public override string Name { get; } = "Nevbit Market";
        public override List<Coin> ListOfCoins { get; set; }

    }
}
