using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    abstract class Coin 
    {
        protected abstract decimal AverageValue { get; set; }

        public decimal sellValue
        { 
            get
            {
                return AverageValue * (decimal)1.1;
            }
        } 
        public decimal buyValue
        {
            get
            {
                return AverageValue * (decimal)0.9;
            }
        }

        public abstract string Name { get; set; }



        public void updateAvargeValue(decimal value)
        {
            AverageValue = AverageValue + value;
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
                case Enum.CoinsEnum.Dash:
                    return new Coins.CoinDash();
                case Enum.CoinsEnum.Etherenum:
                    return new Coins.CoinEthereum();
                case Enum.CoinsEnum.Litecoin:
                    return new Coins.CoinLitecoin();
                default:
                    return null;
            }
        }      
        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
