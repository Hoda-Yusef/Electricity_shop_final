﻿namespace Electricity_shop
{
    //מחלקה לשמירת פרטים של משתמשים
    public class user
    {
        private string username;
        private string password;
        private int role;

        public user()
        {
            username = string.Empty;
            password = string.Empty;
            role = 0;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
}
