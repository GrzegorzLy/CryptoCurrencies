using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    /// <summary>
    /// Singleton Pattern zastosowany przy globalnej konfiguracji polaczen z baza danych i plikiem tekstowym
    /// Strategy Pattern zastosowany przy wyborze typu polaczenia
    /// </summary>
    public class GlobalConfig
    { //
        private static GlobalConfig _globalConfig; //|DataDirectory|
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\grzegorz\source\repos\CryptoCurrencies\CryptoCurrencies\Database.mdf;Integrated Security=True";
        public IDataConnection Connections;

        private GlobalConfig()
        {
             //  default config
            Connections = new SqlConnector();
        }
        public static GlobalConfig globalConfig {
            get
            {
                if(_globalConfig == null)
                {
                    _globalConfig = new GlobalConfig();
                }
                return _globalConfig;
            }
        }

        public void ChangeConnection(IDataConnection dataConnection)
        {
            Connections = dataConnection;
        }

    }
}
