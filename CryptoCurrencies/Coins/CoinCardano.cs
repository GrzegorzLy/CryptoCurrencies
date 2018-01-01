﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Coins
{
    class CoinCardano : Coin
    {
        protected override decimal Value { get; set; } = 2.43m;
        public override string Name { get; set; } = "Cardano";
    }
}
