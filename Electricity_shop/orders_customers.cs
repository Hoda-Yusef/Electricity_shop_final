using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class orders_customers
    {
        private int order_number;
        private string customer_id;
        private string first_name;
        private string last_name;
        private string phone_number;
        private string address;
        private string date;
        private int status;

        public orders_customers()
        {
            Order_number = 0;
            Customer_id = string.Empty;
            First_name = string.Empty;
            Last_name = string.Empty;
            Phone_number = string.Empty;
            Address = string.Empty;
            Date = string.Empty;
            Status = 0;
        }

        public int Order_number { get => order_number; set => order_number = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public string Date { get => date; set => date = value; }
        public int Status { get => status; set => status = value; }
    }
}
