using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencies.Enum;

namespace CryptoCurrencies.Markets
{
    /// <summary>
    /// Abstract Factory i Singelton
    /// </summary>
    class FactoryMarket : IFactoryMarket
    {
        
        private static FactoryMarket instance = null;
        private  List<Coin> listOfCoins;
        private FactoryMarket()
        {
            listOfCoins = new List<Coin>();
        }

        public static FactoryMarket Instance { get
            {
                if(instance == null)
                {
                    instance = new FactoryMarket();
                }
                return instance;
            }           
            }

        public Market CreatMarket(MarketsEnum marketsEnum)
        {
            CreatList(marketsEnum);
            switch (marketsEnum)
            {
                case Enum.MarketsEnum.BitCoin:
                    return new Markets.MarketBitCoin(listOfCoins);
                case Enum.MarketsEnum.Bitrex:
                    return new Markets.MarketBittrex(listOfCoins);
                case Enum.MarketsEnum.Kraken:
                    return new Markets.MarketKraken(listOfCoins);
                case Enum.MarketsEnum.Nevbit:
                    return new Markets.MarketNevbit(listOfCoins);
            default:
                    return null;
            }
        }

        private void CreatList(MarketsEnum marketsEnum)
        {
            switch (marketsEnum)
            {
                case MarketsEnum.BitCoin:
                    {
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.BitCoin));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Dash));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Ripple));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Litecoin));
                        break;
                    };
                case MarketsEnum.Bitrex:
                    {
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Cardano));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Etherenum));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Dash));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Litecoin));
                        break;
                    };
                case MarketsEnum.Kraken:
                    {
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.BitCoin));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Dash));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Etherenum));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Cardano));
                        break;
                    };
                case MarketsEnum.Nevbit:
                    {
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Litecoin));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Dash));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Ripple));
                        listOfCoins.Add(Coin.CreatCoin(CoinsEnum.Litecoin));
                        break;
                    };
                default:
                    break;
            }
        }
    }
}
