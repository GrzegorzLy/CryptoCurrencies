using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Coins
{
    class CoinDash : Coin
    {
        protected override decimal Value { get; set; } = 3967m;
        public override string Name { get; set; } = "Dash";
    }
}
