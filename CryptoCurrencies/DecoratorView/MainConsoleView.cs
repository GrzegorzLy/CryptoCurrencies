using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies.DecoratorView
{
    class MainConsoleView : IConsoleView
    {
        private User user;
        public void Write()
        {
            Console.Clear();
            writeData();

        }

        private void writeData()
        {
            Console.Write($"User {user.Login}       Zloty: {user.ZlAmount}  BitCoin: {user.BitCoin}  " +
                          $"Dash: {user.Dash}  Ethereum: {user.Etherum}  liteCoin: {user.LiteCoin}");
            Console.WriteLine();
        }

        public MainConsoleView(User user)
        {
            this.user = user;
        }
    }
}
