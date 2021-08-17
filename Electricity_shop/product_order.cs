//Hoda Khier + Yusef Aborokon 44/5

namespace Electricity_shop
{
    //מחלקה ששומרת פרטי מוצרים ששייכים להזמנות
    public class product_order
    {
        private int id;
        private int product_serial_number;
        private int order_serial_number;
        private int amount;

        public product_order()
        {
            Id = 0;
            Product_serial_number = 0;
            Order_serial_number = 0;
            Amount = 0;
        }

        public int Id { get => id; set => id = value; }
        public int Product_serial_number { get => product_serial_number; set => product_serial_number = value; }
        public int Order_serial_number { get => order_serial_number; set => order_serial_number = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
