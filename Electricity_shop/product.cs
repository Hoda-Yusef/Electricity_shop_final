using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class product
    {
        private long barcode;
        private string category;
        private string model;
        private string manufacturer;
        private string supplier;
        private int cost_price;
        private int selling_price;
        private int amount;
        private string product_info;


        public product()
        {
            Barcode = 0;
            Category = string.Empty;
            Model = string.Empty;
            Manufacturer = string.Empty;
            Supplier = string.Empty;
            Cost_price = 0;
            Selling_price = 0;
            Amount = 0;
            Product_info = string.Empty;
        }

        public long Barcode { get => barcode; set => barcode = value; }
        public string Category { get => category; set => category = value; }
        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public int Cost_price { get => cost_price; set => cost_price = value; }
        public int Selling_price { get => selling_price; set => selling_price = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Product_info { get => product_info; set => product_info = value; }
    }
}
