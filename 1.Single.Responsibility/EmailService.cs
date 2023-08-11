using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Single.Responsibility
{
    internal class EmailService
    {
        public virtual bool ValidateEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else return false;
        }
        public void SendEmail(User message) => Console.WriteLine("Email has been sent");
    }
}
