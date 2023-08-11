using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Single.Responsibility
{
    internal class UserService
    {
        public void Register(string email, string password)
        {
            EmailService emailService = new EmailService();
            if (!emailService.ValidateEmail(email))
                //throw new ValidationException("Invalid email to register ..!");
                Console.WriteLine("Invalid email to register ..!");
            else
            {
                var user = new User(email, password);
                Console.WriteLine("User has successfully registered ..!");
                emailService.SendEmail(user);
            }
        }

        public void Login(string email, string password) => Console.WriteLine("Logged in");


    }
}
