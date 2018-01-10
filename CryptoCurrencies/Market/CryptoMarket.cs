using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoCurrencies.Market
{
    class CryptoMarket : MarketAbstract
    {
        private decimal fluctuationPrecentage = 20M;
        Random random;
        public CryptoMarket(List<Coin> listOfCoins) : base(listOfCoins)
        {
            random = new Random();
            Task.Factory.StartNew(UpdateCoinsValue);
        }
        // Symulacja zmiany kursu walut 
        private void UpdateCoinsValue()
        {
            while (true)
            {
                Thread.Sleep(10000);
                foreach (Coin coin in ListOfCoins)
                {
                    coin.updateAvargeValue(randomFluctuation());
                }

            }
        }

        private decimal randomFluctuation()
        {
           int ram = random.Next((int)-fluctuationPrecentage, (int)fluctuationPrecentage);
            return (ram * 0.001M);
        }
    }

    
}
