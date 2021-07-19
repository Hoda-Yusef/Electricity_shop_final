//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    public class order_number_holder
    {
        private int order_number;


        public order_number_holder()
        {
            Order_number = 0;
        }

        public int Order_number { get => order_number; set => order_number = value; }
    }
}
