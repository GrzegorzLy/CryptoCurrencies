using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    abstract class Coin 
    {
        public abstract decimal Value { get; set; }
        public abstract string Name { get; set; }
        public abstract SortedSet<decimal> SellList { get; set; }
        public abstract SortedSet<decimal> BuyList { get; set; }

        public Coin()
        {
            FillBuyList();
            FillSellList();
        }
        protected void FillSellList()
        {

        }
        protected void FillBuyList()
        {

        }

        

        
    }
}
