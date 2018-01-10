using System;
using System.Collections.Generic;

namespace CryptoCurrencies
{
    public class Wallet
    {
        public Guid UserID { get; set; }
        private Guid WaletID { get; set; }
        private decimal AccountBalanceOfZloty { get; set; }

        private List<Coin> AvailibeCoins { get; set; }

        public Wallet(Guid userID)
        {
            UserID = userID;
            WaletID = Guid.NewGuid();
        }
    }
}