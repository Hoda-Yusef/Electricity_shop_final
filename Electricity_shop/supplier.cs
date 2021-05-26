using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class supplier
    {
        private string name;
        private string phone_number;
        private string address;
        private int dept;
        private int paid;

        public supplier()
        {
            Name = string.Empty;
            Phone_number = string.Empty;
            Address = string.Empty;
            Dept = 0;
            Paid = 0;
        }

        public string Name { get => name; set => name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public int Dept { get => dept; set => dept = value; }
        public int Paid { get => paid; set => paid = value; }
    }

    
}
