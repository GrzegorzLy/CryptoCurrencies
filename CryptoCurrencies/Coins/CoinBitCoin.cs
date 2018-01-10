using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Coins
{
    class CoinBitCoin : Coin
    {
        protected override decimal AverageValue { get; set; } = 47000m;
        public override string Name { get; set; } = "BitCoin";

       public void updateVargeValue(decimal value)
        {
            AverageValue = AverageValue* value;
        }
    }
}
