using Domain.Models;
using Service.Helpers;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                //user1.Email.Contains("@")

                Regex emailRegex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,4}\b");

                if (emailRegex.IsMatch(user1.Email))
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
