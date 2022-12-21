using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserInfoService
    {

        public static void RegisterUser()
        {
            Console.Write("Enter your username: ");
            string _username = Console.ReadLine();
            Console.Write("Enter your email: ");
            string _email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string _password = Console.ReadLine();

            Account account = new Account();

            account.Register(_username, _email, _password);

            
        }
    }
}
