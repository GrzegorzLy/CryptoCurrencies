using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Coins
{
    class CoinEthereum : Coin
    {
        protected override decimal AverageValue { get; set; } = 2656m;
        public override string Name { get; set; } = "Ethernum";
    }
}
