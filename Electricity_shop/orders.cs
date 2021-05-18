//??????????

using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    class orders
    {
        private string name;
        private string last_name;
        private string phone_number;
        private string address;
        private int summ;
        private bool status;


        public orders(string name,string last_name,string phone_number,string address,int sum,bool status)
        {
            this.name = name;
            this.Last_name = last_name;
            this.Phone_number = phone_number;
            this.Address = address;
            this.Summ = sum;
            this.Status = status;

        }

        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
       
       
        public bool Status { get => status; set => status = value; }
        public int Summ { get => summ; set => summ = value; }
    }
}
