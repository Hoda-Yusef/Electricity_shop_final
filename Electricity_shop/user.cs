using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class user
    {
        private string username;
        private string password;

        public user()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
