using System.Windows.Forms;
using System;
using System.Threading;

namespace Electricity_shop
{
    //מחלקה להצגת דוח של הזמנות לפי טווח תאריכים
    public partial class Frm_ordersData : Form
    {
        private DBSQL mySQL;
        orders[] Orders;
        int orderNumber=0;
        product_order[] Product_order;
        Product product;
        customer Customer;
        string userName;
        string max_customer_name = string.Empty;
        int max_sum = 0, max_ID = 0,max_id = 0;
        int count_deliverd_orders = 0,count_waiting_orders = 0;
        public Frm_ordersData(string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            userName = username;
        }

        //פונקצייה לחישוב והצגת נתונים להזמנות
        private void getOrdersData()
        {
            max_customer_name = string.Empty;
            max_sum = 0;
            max_ID = 0;
            max_id = 0;
            count_deliverd_orders = 0;
            count_waiting_orders = 0;

            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);

            if (Orders != null)
            {
                calculateOrders();

                displayResult();
            }
            else
            {
                MessageBox.Show("אין מידע לטווח תאריכים");
                clearData();
            }
    }

        private void displayResult()
        {
            Lbl_totalPrice.Text = max_ID.ToString();
            Lbl_totalOrdersNumber.Text = Orders.Length.ToString();
            Lbl_customersName.Text = max_customer_name;
            Lbl_customersId.Text = max_id.ToString();
            Lbl_deleviredNumber.Text = count_deliverd_orders.ToString();
            Lbl_waitingOrdersNumber.Text = count_waiting_orders.ToString();
        }

        private void calculateOrders()
        {
            for (int i = 0; i < Orders.Length; i++)//לולאה עוברת על ההזמנות שבין שני התאריכים
            {
                Product_order = mySQL.GetProduct_orderDataByOrderNumber(Orders[i].Order_number.ToString());

                if (Orders[i].Status == 0)
                    count_deliverd_orders++;
                if (Orders[i].Status == 1)
                    count_waiting_orders++;

                if (Product_order != null)
                {
                    for (int j = 0; j < Product_order.Length; j++)
                    {
                        product = mySQL.GetProductDataBySerialNumber(
                            Product_order[j].Product_serial_number.ToString());

                        max_sum += product.Selling_price * Product_order[j].Amount;
                    }

                    if (max_sum > max_ID)//בודקים את העסקה הגדולה ביותר
                    {
                        orderNumber = Orders[i].Order_number;
                        max_ID = max_sum;
                        max_id = Convert.ToInt32(Orders[i].Customer_id);//שומרים את תעודת זהות של הלקוח
                        Customer = mySQL.GetCustomerDataByID(max_id.ToString());
                        max_customer_name = "" + Customer.First_name + " " + Customer.Last_name + "";

                    }

                    max_sum = 0;//איפוס

                }
            }
        }

        private void clearData()
        {
            Lbl_totalPrice.Text = "0";
            Lbl_totalOrdersNumber.Text = "0";
            Lbl_customersName.Text = "- אין מידע -";
            Lbl_customersId.Text = "- אין מידע -";
            Lbl_deleviredNumber.Text = "0";
            Lbl_waitingOrdersNumber.Text = "0";
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            getOrdersData();
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            getOrdersData();
        }

        private void Frm_ordersData_Load(object sender, EventArgs e)
        {
            clearData();
        }

        private void Pnl_biggestOrderContainer_Click(object sender, EventArgs e)
        {
            Frm_ordersManagement Fom = new Frm_ordersManagement(1, userName,orderNumber,1);
           // Fom.Txt_customerId.Text = Lbl_customersId.Text;
            Fom.ShowDialog();
        }
      
        private void Lbl_deleviredNumber_Click(object sender, EventArgs e)
        {
            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);
            if (Orders != null)
            {
                Frm_ordersManagement om = new Frm_ordersManagement(1, userName, 1,
                    dateTimePicker_from.Text, dateTimePicker_to.Text,"סופק");

                om.Cbo_sortByOrderStatus.Text = "סופק";

                om.ShowDialog();
            }
            else
                MessageBox.Show("אין מידע לטווח תאריכים");
        }

        private void Lbl_waitingOrdersNumber_Click(object sender, EventArgs e)
        {
            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);
            if (Orders != null)
            {
                Frm_ordersManagement om = new Frm_ordersManagement(1, userName, 1,
                    dateTimePicker_from.Text, dateTimePicker_to.Text,"לא סופק");

                om.Cbo_sortByOrderStatus.Text = "לא סופק";

                om.ShowDialog();
            }
            else
                MessageBox.Show("אין מידע לטווח תאריכים");
        }

        private void Lbl_totalOrdersNumber_Click(object sender, EventArgs e)
        {
            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);
            if (Orders != null)
            {
                Frm_ordersManagement om = new Frm_ordersManagement(1, userName, 1,
                    dateTimePicker_from.Text, dateTimePicker_to.Text,"");

                om.Cbo_sortByOrderStatus.Text = "הכל";

                om.ShowDialog();
            }
            else
                MessageBox.Show("אין מידע לטווח תאריכים");
        }
    }
}
  
