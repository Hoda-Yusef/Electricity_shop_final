using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class orders
    {
        private string customer_id;
        private string date;
        private bool status;
        //private product[] productList;
        //private bool status;
       


        public orders()
        {
            //Custome_id = string.Empty;
            //ProductList = null;
            //Status = true;

            Customer_id = string.Empty;
            Date = string.Empty;
            Status = false;


        }

        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }


        //public string Custome_id { get => custome_id; set => custome_id = value; }
        //public product[] ProductList { get => productList; set => productList = value; }
        //public bool Status { get => status; set => status = value; }
    }
}
