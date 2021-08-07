//Hoda Khier + Yusef Aborokon 44/5

namespace Electricity_shop
{
    public class orders
    {
        private int order_number;
        private string customer_id;
        private string date;
        private int status;


        public orders()
        {
            Order_number = 0;
            customer_id = string.Empty;
            date = string.Empty;
            status = 0;
        }

        public string Customer_id { get => customer_id; set => customer_id = value; }
        public string Date { get => date; set => date = value; }
        public int Order_number { get => order_number; set => order_number = value; }
        public int Status { get => status; set => status = value; }
    }
}
