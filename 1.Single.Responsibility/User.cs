﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Single.Responsibility
{
    internal class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
