//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_productsList : Form
    {

        private DBSQL mySQL;
        bool drag = false;
        Point sp = new Point(0, 0);
        int userRole;

        public Frm_productsList(int role)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            userRole = role;
        }

        private void Btn_goBack_Click(object sender, EventArgs e)
        {
            this.Close();//סגירה
        }


        //פאנל להזזת חלון
        private void UpperBluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void UpperBluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void UpperBluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //בעת פתיחת חלון הטבלה נטענת בפרטים של ההזמנה
        private void Frm_productsList_Load(object sender, EventArgs e)
        {
            int Total_price=0,total_amount=0;

            string show = Lbl_showOrderNumber.Text;

            product_order[] Product_order = mySQL.GetProduct_orderDataByOrderNumber(show);

            if (Product_order != null)
            {
                for (int i = 0; i < Product_order.Length; i++)
                {
                    Product Product = mySQL.GetProductDataBySerialNumber(Product_order[i].Product_serial_number.ToString());

                    Grd_productsList.Rows.Add(new object[]
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
                    Total_price += Convert.ToInt32(Product.Selling_price)* Product_order[i].Amount;
                }
            }
            else
                MessageBox.Show("אין מוצרים להזמנה");//אם אין מוצרים בהזמנה

            Lbl_showProductsNumber.Text = Grd_productsList.Rows.Count.ToString();//סופר כמות מוצרים
            Lbl_showTotalAmount.Text = total_amount.ToString();//סופר כמות היחידות של מוצרים
            Lbl_showTotalPrice.Text = Total_price.ToString();//סופר את סכום של כל המוצרים
           
        }

        private void Btn_exit_Click(object sender, EventArgs e)//סגירה
        {
            this.Close();
            
        }
    }
}
