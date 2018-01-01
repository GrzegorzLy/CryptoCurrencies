using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Coins
{
    class CoinLitecoin : Coin
    {
        protected override decimal Value { get; set; } = 778.03m;
        public override string Name { get; set; } = "Litecoin";
    }
}
