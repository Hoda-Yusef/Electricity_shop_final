using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_shop
{
    class orders
    {
        private string custome_id;
        private product[] productList;
        private bool status;
       


        public orders()
        {
            Custome_id = string.Empty;
            ProductList = null;
            Status = true;

        }

        public string Custome_id { get => custome_id; set => custome_id = value; }
        public product[] ProductList { get => productList; set => productList = value; }
        public bool Status { get => status; set => status = value; }
    }
}
