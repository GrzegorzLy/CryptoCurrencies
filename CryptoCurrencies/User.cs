using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    public class User
    {
        public int Id { get; private set; }
        public string Login { get; private set;}
        public decimal ZlAmount { get; private set; }
        public decimal BitCoin { get; private set; }
        public decimal Dash { get; private set; }
        public decimal Etherum { get; private set; }
        public decimal LiteCoin { get; private set; }

        public User(string login)
        {
            this.Login = login;
            ZlAmount = 0;
            BitCoin = 0;
            Dash = 0;
            Etherum = 0;
            LiteCoin = 0;
        }
        public User(int id, string login, decimal zl, decimal bitCoin, decimal dash, decimal ethernum, decimal liteCoin)
        {
            Id = id;
            Login = login;
            ZlAmount = zl;
            BitCoin = bitCoin;
            Dash = dash;
            Etherum = ethernum;
            LiteCoin = liteCoin;

        }

        public void AddZloty(decimal amount)
        {
            ZlAmount += amount;
            update();
        }

        private void update()
        {
            GlobalConfig.globalConfig.Connections.UpdateUser(this);
        }

    }
}
