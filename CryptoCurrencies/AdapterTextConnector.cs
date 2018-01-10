using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    class AdapterTextConnector : IDataConnection
    {
        OldTextConnector OldTextConnector;
        public AdapterTextConnector()
        {
            OldTextConnector = new OldTextConnector();
        }
        public void CreateUser(string login, string password)
        {
            OldTextConnector.CreateUserInTxtFile(login, password);
        }

        public User LoginUser(string login, string password)
        {
            return OldTextConnector.LoginUserFromTxtFile(login, password);
        }

        public bool UpdateUser(User user)
        {
            return OldTextConnector.UpdateUserInTxtFile(user);
        }
    }
}
