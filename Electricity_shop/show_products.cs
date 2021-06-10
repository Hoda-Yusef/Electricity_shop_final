using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class show_products : Form
    {

        private DBSQL mySQL;
       
        bool drag = false;
        Point sp = new Point(0, 0);
        public show_products()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void show_products_Load(object sender, EventArgs e)
        {
            int Total_price=0,total_amount=0;

            string show = show_order_number.Text;

            product_order[] Product_order = mySQL.GetProduct_orderDataByOrderNumber(show);

            if (Product_order != null)
            {
                for (int i = 0; i < Product_order.Length; i++)
                {
                    product Product = mySQL.GetProductDataBySerialNumber(Product_order[i].Product_serial_number.ToString());

                    product_grid.Rows.Add(new object[]
                    {
                    Product.Barcode,
                    Product.Category,
                    Product.Manufacturer,
                    Product.Model,
                    Product.Selling_price,
                    Product_order[i].Amount,
                    Product.Product_info
                    });

                    total_amount += Convert.ToInt32(Product_order[i].Amount);
                    Total_price += Convert.ToInt32(Product.Selling_price);
                }
            }
            else
                MessageBox.Show("אין מוצרים להזמנה");

            products_amount.Text = product_grid.Rows.Count.ToString();
            total_sum_products.Text = total_amount.ToString();
            total_price.Text = Total_price.ToString();
           
        }
    }
}
