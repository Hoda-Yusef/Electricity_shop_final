using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    
    public partial class Frm_documents : Form
    {
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        private DBSQL mySQL;
        orders[] Orders;
        product_order[] Product_order;
        Product product;
        
        public Frm_documents()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main());
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            int total_price = 0;
            int pure_price = 0;
            int lose = 0;

            Orders = mySQL.GetOrdersDataByDate(dateTimePicker1.Text);

            if (Orders != null)
            {
                for (int i = 0; i < Orders.Length; i++)
                {
                    Product_order = mySQL.GetProduct_orderDataByOrderNumber(Orders[i].Order_number.ToString());
                    for (int j = 0; j < Product_order.Length; j++)
                    {
                        product = mySQL.GetProductDataBySerialNumber(Product_order[j].Product_serial_number.ToString());
                        total_price += product.Selling_price * Product_order[j].Amount;
                        pure_price += (product.Selling_price - product.Cost_price) * Product_order[j].Amount;
                        lose += product.Cost_price;

                    }
                }
                Lbl_info.Text = "רווח פרוטו : " + total_price + "\n\nרווח נטו : " + pure_price + "\n\nהפסד : "+lose+"";
            }
            else
            MessageBox.Show("אין מידע לתאריך הזה");

            
        }
    }
}
