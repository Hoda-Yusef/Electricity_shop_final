//Hoda Khier + Yusef Aborokon 44/5

namespace Electricity_shop
{
    public class supplier
    {
        private int serial_number;
        private string first_name;
        private string last_name;
        private string phone_number;
        private string address;
        private int dept;
        private int paid;

        public supplier()
        {
            serial_number = 0;
            first_name = string.Empty;
            last_name = string.Empty;
            Phone_number = string.Empty;
            Address = string.Empty;
            Dept = 0;
            Paid = 0;
        }

        public string FirstName { get => first_name; set => first_name = value; }
        public string LasttName { get => last_name; set => last_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public int Dept { get => dept; set => dept = value; }
        public int Paid { get => paid; set => paid = value; }
        public int Serial_number { get => serial_number; set => serial_number = value; }
    }


}
