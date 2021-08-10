using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_incomeAndOutcome : Form
    {
        private DBSQL mySQL;
        orders[] Orders;
        product_order[] Product_order;
        Product product;
        public Frm_incomeAndOutcome()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Btn_ordersDataSearch_Click(object sender, EventArgs e)
        {
            double VATnum= (double)Convert.ToInt32(Txt_vat.Text) / 100;
            int brutoEarnings = 0;
            double pure_price = 0;
            int lose = 0;
            double VAT = 0;

            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);

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

                            brutoEarnings += product.Selling_price * Product_order[j].Amount;//מחשב סכום רווח פרוטו
                            pure_price += ((product.Selling_price - product.Cost_price) -
                                ((product.Selling_price - product.Cost_price) * VATnum)) *
                                Product_order[j].Amount;//מחשב סכום רווח נטו

                            VAT += ((product.Selling_price - product.Cost_price) * VATnum) * Product_order[j].Amount;
                            lose += product.Cost_price;//מחשב סכום הפסד

                        }
                    }
                }
                Lbl_brutoEarnings.Text = brutoEarnings.ToString();
                Lbl_totalIncome.Text = Math.Round(pure_price, 2).ToString();
                Lbl_vatTotal.Text = Math.Round(VAT, 2).ToString();
                Lbl_totalOutcome.Text = lose.ToString();
            }
            else
                MessageBox.Show("אין מידע לטווח תאריכים");
        }

        private void Txt_vat_Leave(object sender, EventArgs e)
        {
            int vat = Convert.ToInt32(Txt_vat.Text);
            if(!(vat > 0 && vat < 50))
            {
                MessageBox.Show("ערך מעמ לא תקין", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_vat.Text = "17";
            }

        }

        private void Txt_vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
    }
}
