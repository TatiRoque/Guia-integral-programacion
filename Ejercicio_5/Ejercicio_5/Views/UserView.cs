using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class UserView
    {
        public void ShowUsers(List<User> users)
        {
            foreach (var user in users)
                Console.WriteLine(user);
        }

        public User CreateUser()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = IsEmail();
            return new User { Name = name, Email = email };
        }

        public string GetEmail()
        {
            Console.Write("Enter Email: ");
            return Console.ReadLine();
        }
        public string IsEmail()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (!input.Contains("@") && string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The email must contain '@'. Please enter a valid email:");
                }
                else
                {
                    break;
                }
            }while(input.Contains("@"));
            return input;
        }
    }
}
