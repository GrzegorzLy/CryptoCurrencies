using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    public interface IDataConnection
    {
        void CreateUser(string login, string password);
        User LoginUser(string login, string paswordd);

        bool UpdateUser(User user);


    }
}
