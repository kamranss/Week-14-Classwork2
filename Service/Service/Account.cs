using Domain.Models;
using Service.Helpers;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class Account : IAccount
    {
        public void Register(string username, string email, string password)
        {
			try
			{
				User user1 = new()
				{
					Username = username,
					Email = email,
					Password = password
				};

				if (user1.Email.Contains("@"))
				{
					Console.WriteLine("Register Succesed");
				}
				else
				{
					throw new RegisterException(UserCredentialMessage.UserEmailWrong);
				}
				
				
			}
			catch (RegisterException message)
			{
				Console.WriteLine(message.Message);
				
			}
        }
    }
}
