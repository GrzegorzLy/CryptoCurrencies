using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CryptoCurrencies
{
    class SqlConnector : IDataConnection
    {

        public void CreateUser(string login, string password)
        {
            string query = "Insert into UserTable (Login, Password) values (@login, @password) ";

            using ( SqlConnection connection = new SqlConnection(GlobalConfig.globalConfig.ConnectionString))                        
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@login", SqlDbType.NVarChar ).Value = login;
                command.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
                Console.WriteLine(command.ExecuteNonQuery());                                 
            }

                      
        }

        public User LoginUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.globalConfig.ConnectionString))
            {
                connection.Open();
                string query = $"Select * From dbo.UserTable Where Login = @login and Password = @password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                
                                User user = new User((int)reader[0], login, (decimal)reader[3], (decimal)reader[4], (decimal)reader[5],
                                                            (decimal)reader[6], (decimal)reader[7]);
                                return user;
                                
                            }
                        }

                        return null;
                    }
                }
            }
        }

        public bool UpdateUser(User user)
        {
            //Update dbo.UserTable set ZlAmount = 2, BitCoin = 3 where id =  5
            using (SqlConnection connection = new SqlConnection(GlobalConfig.globalConfig.ConnectionString))
            {
                string query = "Update dbo.UserTable set Zloty = @zl, Bitcoin = @bitCoin, Dash = @dash, " +
                               "Ethereum = @ethereum, Litecoin = @litecion where Id =  @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", user.Id);
                    command.Parameters.AddWithValue("@zl", user.ZlAmount);
                    command.Parameters.AddWithValue("@bitCoin", user.BitCoin);
                    command.Parameters.AddWithValue("@dash", user.Dash);
                    command.Parameters.AddWithValue("@ethereum", user.Etherum);
                    command.Parameters.AddWithValue("@litecion", user.LiteCoin);
                    connection.Open();
                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error inserting data into Database!");
                        return false;
                    }
                }

            }

        }
    }
}
