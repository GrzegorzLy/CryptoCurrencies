using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    abstract class Market
    {
        public abstract string Name { get;}
        public abstract List<Coin> ListOfCoins { get; set; }


        public Market()
        {
            fillListOFCoins();
        }

        /// <summary>
        /// Metoda Wytworcza tworzaca wybrana gielde
        /// </summary>
        /// <param name="marketsEmun"></param>
        /// <returns>Lista typow gieldy</returns>
        public static Market CreatMarket(Enum.MarketsEmun marketsEmun)
        {
            switch (marketsEmun)
            {
                case Enum.MarketsEmun.BetCoin:
                    return new Markets.MarketBetCoin();
                case Enum.MarketsEmun.Bitrex:
                    return new Markets.MarketBittrex();
                case Enum.MarketsEmun.Kraken:
                    return new Markets.MarketKraken();
                case Enum.MarketsEmun.Nevbit:
                    return new Markets.MarketNevbit();
                default:
                    return null;
            }
        }

        // TODO
        protected void fillListOFCoins()
        {

        }





    }
}
