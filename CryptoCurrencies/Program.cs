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
            Market market = Markets.FactoryMarket.Instance.CreatMarket(Enum.MarketsEnum.BitCoin);
            Console.WriteLine(market);
        }
    }
}
