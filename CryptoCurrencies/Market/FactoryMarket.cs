using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.Market
{
    class FactoryMarket : IFactoryMarket
    {

        public MarketAbstract CreatMarket()
        {
            List<Coin> listOfCoins = addCoinsToList();
            return new CryptoMarket(listOfCoins);
        }

        private List<Coin> addCoinsToList()
        {
            List<Coin> listOfCoins = new List<Coin>();
            listOfCoins.Add(Coin.CreatCoin(Enum.CoinsEnum.BitCoin));
            listOfCoins.Add(Coin.CreatCoin(Enum.CoinsEnum.Dash));
            listOfCoins.Add(Coin.CreatCoin(Enum.CoinsEnum.Etherenum));
            listOfCoins.Add(Coin.CreatCoin(Enum.CoinsEnum.Litecoin));
            return listOfCoins;
        }
    }
}
