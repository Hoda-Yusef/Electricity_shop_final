//Hoda Khier + Yusef Aborokon 44/5

namespace Electricity_shop
{
    //מחלקה של עגלה
    public class Cart
    {
        private int id;
        private string product_barcode;
        private string product_model;
        private int amount;


        public Cart()
        {
            id = 0;
            Product_barcode = string.Empty;
            Product_model = string.Empty;
            Amount = 0;
        }

        public int Id { get => id; set => amount = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Product_barcode { get => product_barcode; set => product_barcode = value; }
        public string Product_model { get => product_model; set => product_model = value; }
    }
}
