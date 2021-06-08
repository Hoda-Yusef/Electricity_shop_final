using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class cart
    {
        private string product_barcode;
        private int amount;


        public cart()
        {
            Product_barcode = string.Empty;
            Amount = 0;
        }

        public string Product_barcode { get => product_barcode; set => product_barcode = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
