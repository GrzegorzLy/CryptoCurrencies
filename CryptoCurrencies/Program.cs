using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = Market.CreatMarket(Enum.MarketsEmun.BetCoin);
            Console.WriteLine(market.Name);
        }
    }
}
