using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    abstract class Coin 
    {
        protected abstract decimal Value { get; set; }
        
        public abstract string Name { get; set; }
        public  SortedList<decimal, double> SellList { get; set; }
        public SortedList<decimal, double> BuyList { get; set; }
        protected Random random = new Random();

        protected int RandomAvailibeCoins { get
            {
                return 50000 -(int)Value;
            }
        }


        public Coin()
        {
            SellList = new SortedList<decimal, double>();
            BuyList = new SortedList<decimal, double>();

            FillBuyList();
            FillSellList();
        }

        /// <summary>
        /// Metoda wytworcza, zwraca wybrana kryptowalute
        /// </summary>
        /// <param name="coinsEnum"></param>
        /// <returns>typy kryptowalut</returns>
        public static Coin CreatCoin(Enum.CoinsEnum coinsEnum)
        {
            switch (coinsEnum)
            {
                case Enum.CoinsEnum.BitCoin:
                    return new Coins.CoinBitCoin();
                case Enum.CoinsEnum.Cardano:
                    return new Coins.CoinCardano();
                case Enum.CoinsEnum.Dash:
                    return new Coins.CoinDash();
                case Enum.CoinsEnum.Etherenum:
                    return new Coins.CoinEthereum();
                case Enum.CoinsEnum.Litecoin:
                    return new Coins.CoinLitecoin();
                case Enum.CoinsEnum.Ripple:
                    return new Coins.CoinRipple();
                default:
                    return null;
            }
        }
        /// <summary>
        /// metoda wypelnia liste aktualnie dostepnymi ofertami sprzedazy
        /// </summary>
        protected void FillSellList()
        {
            decimal SellValue = Value * 1.1m;
            fillList(SellValue, SellList);
        }

        /// <summary>
        /// metoda wypelnia liste aktualnie dostepnymi ofertami kupna
        /// </summary>
        protected void FillBuyList()
        {
            decimal BuyValue = Value * 0.9m;
            fillList(BuyValue, BuyList);
        }

        /// <summary>
        /// metoda pomocnicza do wypelniania 
        /// </summary>
        protected void fillList(decimal value, SortedList<decimal, double> sortedList)
        {

            decimal fluctuations = 0;
            double availabeCoins = 0;
            for (int i = 0; i < 10; i++)
            {
                availabeCoins = random.Next(1, RandomAvailibeCoins) * 0.1;
                fluctuations = (value * random.Next(-999, 999)) * 0.00001m;
                decimal TKey = this.Value + fluctuations;

                //sprawdzam czy klucz sie nie powtarza
                while (sortedList.Keys.Contains(TKey))
                {
                    TKey += 0.01m;
                }
                sortedList.Add(TKey, availabeCoins);
            }
        }

        public void addCoin(Enum.SortedListEnum sortedListEnum)
        {
            SortedList<decimal, double> sortedList = sortedListEnum == Enum.SortedListEnum.buy ? BuyList : SellList;
            if (sortedList.Count < 10)
            {
               double temp = (sortedListEnum == Enum.SortedListEnum.buy ? 0.9 : 1.1);
               double availabeCoins = random.Next(1, RandomAvailibeCoins) * 0.1;
               decimal fluctuations = (((decimal)temp * this.Value) * random.Next(-999, 999)) * 0.00001m;
               decimal TKey = this.Value + fluctuations;
                //sprawdzam czy klucz sie nie powtarza
                while (sortedList.Keys.Contains(TKey))
                {
                    TKey += 0.01m;
                }
                sortedList.Add(TKey, availabeCoins);
            }
        }

        public void removeCoin(Enum.SortedListEnum sortedListEnum, int value)
        {
            SortedList<decimal, double> sortedList = sortedListEnum == Enum.SortedListEnum.buy ? BuyList : SellList;
            sortedList.RemoveAt(value);
        }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
