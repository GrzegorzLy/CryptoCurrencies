using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using CryptoCurrencies.Market;
using System.Data;

namespace CryptoCurrencies
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();
            facade.StartProgram();
            Console.ReadKey();


            

        }
    }
}
