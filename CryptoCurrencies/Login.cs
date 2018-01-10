using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencies
{
    static class Login
    {
        private static string login;
        private static string password;

        
        public static User start()
        {
            bool decision = questionCreatNewAccount();
            if (decision)
            {
                Console.Clear();
                Console.WriteLine("Creat new Account: ");

                validate();
                createNewAccount();               
            }
            validate();
            User user = loginUser();
            return user;

        }

        private static bool questionCreatNewAccount()
        {
            Console.Write("Create new account?  Y/N   ");

            var answer = Console.ReadLine();
            char charAnswer;
            if (char.TryParse(answer, out charAnswer))
            {
                charAnswer = Char.ToLowerInvariant(charAnswer);
                if (charAnswer == 'y')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }
        private static void createNewAccount()
        {
            GlobalConfig.globalConfig.Connections.CreateUser(login, password);
        }

        private static User loginUser()
        {
            User user = GlobalConfig.globalConfig.Connections.LoginUser(login, password);
            
            if (user == null)
            {
                WrongLoginOrPassword();
            }
            return user;
        }
        private static void validate()
        {
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Passowrd: ");
            password = Console.ReadLine();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                WrongLoginOrPassword();
            }
            if(login.Length  < 3 || password.Length < 3) 
            {
                WrongLoginOrPassword();
            }
        }

        private static void WrongLoginOrPassword()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Login or Password");
            Console.ResetColor();
            start();
        }
    }
}
