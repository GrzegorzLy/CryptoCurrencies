using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Markets
{
    interface IFactoryMarket
    {
        Market CreatMarket(Enum.MarketsEnum marketsEmun);
    }
}
