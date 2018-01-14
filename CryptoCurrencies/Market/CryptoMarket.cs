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
        private List<IObserver> observerList = new List<IObserver>();

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
                execute();

            }
        }

        private decimal randomFluctuation()
        {
           int ram = random.Next((int)-fluctuationPrecentage, (int)fluctuationPrecentage);
            return (ram * 0.001M);
        }

        public override void addObserver(IObserver observer)
        {
            if(observerList != null)
            {
                observerList.Add(observer);
            }
        }

        public override void removeObserver(IObserver observer)
        {
            if (observerList.Contains(observer))
            {
                observerList.Remove(observer);
            }
        }

        public override void execute()
        {
            if (observerList != null)
            {
                observerList.ForEach(observer => observer.update());
            }
        }
    }

    
}
