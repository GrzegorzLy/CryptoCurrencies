﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Market
{
    interface IFactoryMarket
    {
        MarketAbstract CreatMarket();
    }
}
