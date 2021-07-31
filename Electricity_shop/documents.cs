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
            int price;
            int total_price = 0;
            int pure_price = 0;
            int lose = 0;
            int max_sum = 0;
            int max = 0;
            int max_id=0;

            //מקבלים את כל ההזמנות בין שני התאריכים שבחר המשתמש
            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);

            if (Orders != null)
            {
                for (int i = 0; i < Orders.Length; i++)
                {
                    Product_order = mySQL.GetProduct_orderDataByOrderNumber(Orders[i].Order_number.ToString());
                   
                    if (Product_order != null)
                    {
                        for (int j = 0; j < Product_order.Length; j++)
                        {
                            product = mySQL.GetProductDataBySerialNumber(Product_order[j].Product_serial_number.ToString());
                           
                            total_price += product.Selling_price * Product_order[j].Amount;//מחשב סכום רווח פרוטו
                            pure_price += (product.Selling_price - product.Cost_price) * Product_order[j].Amount;//מחשב סכום רווח נטו
                            lose += product.Cost_price;//מחשב סכום הפסד
                            max_sum += product.Selling_price * Product_order[j].Amount;

                        }
                        if(max_sum > max)//בודקים את העסקה הגדולה ביותר
                        {
                            max = max_sum;
                            max_id = Convert.ToInt32(Orders[i].Customer_id);

                        }

                        max_sum = 0;
                    }
                }
                Lbl_info.Text = "\nרווח פרוטו : " + total_price + "\n\nרווח נטו : " + pure_price +
                    "\n\nהפסד : "+lose+"\n\nסכום העסקה הגדולה ביותר : "+max+"\n ללקוח - "+max_id+"";
            }
            else
            MessageBox.Show("אין מידע לתאריך הזה");

            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
