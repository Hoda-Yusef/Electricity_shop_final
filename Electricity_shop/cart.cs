﻿//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class Cart
    {
        private string product_barcode;
        private string product_model;
        private int amount;


        public Cart()
        {

            Product_barcode = string.Empty;
            Product_model = string.Empty;
            Amount = 0;
        }

        public int Amount { get => amount; set => amount = value; }
        public string Product_barcode { get => product_barcode; set => product_barcode = value; }
        public string Product_model { get => product_model; set => product_model = value; }
    }
}
