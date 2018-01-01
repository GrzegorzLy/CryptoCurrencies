﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    class MarketBittrex :Market
    {
        public MarketBittrex(List<Coin> ListOfCoins) : base(ListOfCoins)
        {
        }

        public override string Name { get; } = "Bittrex Market";


    }
}
