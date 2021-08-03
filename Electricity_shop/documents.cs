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
        Product[] Products;
        int max_PRODUCT = 0, max_product_amount = 0;
        string max_product_category, max_product_model;

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

        private void Btn_search_Click(object sender, EventArgs e)//כפתור לקבלת מידע
        {
            int total_price = 0;
            int pure_price = 0;
            int lose = 0;
            int max_sum = 0;
            int max_ID = 0;
            int max_id = 0;
            int count = 0;

            Orders = mySQL.GetOrdersDataByDate(dateTimePicker.Text);

            if (Orders != null)
            {
                for (int i = 0; i < Orders.Length; i++)//לולאה עוברת על ההזמנות שבין שני התאריכים
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
                        if(max_sum > max_ID)//בודקים את העסקה הגדולה ביותר
                        {
                            max_ID = max_sum;
                            max_id = Convert.ToInt32(Orders[i].Customer_id);//שומרים את תעודת זהות של הלקוח

                        }

                        max_sum = 0;//איפוס

                    }
                }
                best_selling_product(count);

                Lbl_info.Text = "\nרווח פרוטו : " + total_price + "\n\nרווח נטו : " + pure_price +
                    "\n\nהפסד : "+lose+"\n\nסכום העסקה הגדולה ביותר : "+max_ID+"\n ללקוח - "+max_id+" " +
                    "\n\nמוצר הנמכר ביותר :- "+max_product_category+" - "+max_product_model+"\nכמות יחידות שנמכרו : " +
                    ""+max_product_amount+"";
            }
            else
            MessageBox.Show("אין מידע לטווח תאריכים");

            
        }

        private void best_selling_product(int count)
        {
            
            Products = mySQL.GetProductData();//קבלת מידע על כל המוצרים לעבור עליהם אחד אחד
            if (Products != null)
            {
                for (int i = 0; i < Products.Length; i++)//לולאה עוברת על כל המוצרים
                {
                    for (int j = 0; j < Orders.Length; j++)//לולאה עוברת על ההזמנות שבין שני התאריכים
                    {
                        Product_order = mySQL.GetProduct_orderDataByOrderNumber(Orders[j].Order_number.ToString());

                        if (Product_order != null)
                        {
                            for (int k = 0; k < Product_order.Length; k++)//לולאה עוברת על המוצרים שנמצאים בהזמנה
                            {
                                product = mySQL.GetProductDataBySerialNumber(Product_order[k].Product_serial_number.ToString());
                                if (Products[i].Product_serial_number == product.Product_serial_number)//בודקים אם מוצר בהזמנה שווה למוצר קיים במלאי
                                {
                                    count += Product_order[k].Amount;//סופר כמה יחידות יש מהמוצר גם לפי כמות

                                }
                            }
                        }
                    }
                    if (count > max_PRODUCT)//בודקים אם המוצר נמכר הכי הרבה ואז מציבים את כל הפרטים שלו
                    {
                        max_PRODUCT = count;
                        max_product_category = Products[i].Category;
                        max_product_model = Products[i].Model;
                        max_product_amount = max_PRODUCT;
                    }
                    count = 0;//מאפסים את המונה

                }
            }
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
