using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class customer
    {
        private string id;
        private string first_name;
        private string last_name;
        private string phone_number;
        private string address;

        public customer()
        {
            Id = string.Empty;
            First_name = string.Empty;
            Last_name = string.Empty;
            Phone_number = string.Empty;
            Address = string.Empty;
        }

        
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        
        public string Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
    }
}
