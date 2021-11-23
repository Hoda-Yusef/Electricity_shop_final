using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה שמציגה דוח על רווח והפסד דרך טווח תאריכים
    public partial class Frm_incomeAndOutcome : Form
    {
        private DBSQL mySQL;
        orders[] Orders;
        product_order[] Product_order;
        Product product;
        vat VatPercentage=new vat();
        vat currentVat = new vat();
        string userName;

        public Frm_incomeAndOutcome(string userName)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            this.userName = userName;
        }
       
        //פונקצייה מקבלת ערך מעמ
        private double getVatData()
        {
            VatPercentage =mySQL.Getvat();
            return VatPercentage.Vat;
        }
       

        //פונקצייה מציגה מידע
        private void getData()
        {
            int brutoEarnings = 0;
            double pure_price = 0;
            int lose = 0;
            double VAT=0,vatPercentage=0;
            vatPercentage = getVatData();

            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);

            if (Orders != null)
            {
                calculateIncomeOutcome(brutoEarnings, pure_price, VAT, lose, vatPercentage);
            }
            else
            {
                MessageBox.Show("אין מידע לטווח תאריכים");
                clearData();
            }
        }

        //חישוב רווח והפסד
        private void calculateIncomeOutcome(int brutoEarnings, double pure_price,
            double VAT, double lose, double vatPercentage)
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
                        pure_price += (product.Selling_price - product.Cost_price) * Product_order[j].Amount;
                            //מחשב סכום רווח נטו

                        VAT += (product.Cost_price * (double)vatPercentage / 100) * Product_order[j].Amount;
                        lose += (product.Cost_price - (product.Cost_price * (double)vatPercentage / 100)) * Product_order[j].Amount;//מחשב סכום הפסד

                    }
                }
            }
            //מציג נתונים בשדות
            Lbl_brutoEarnings.Text = brutoEarnings.ToString();
            Lbl_totalIncome.Text = Math.Round(pure_price, 2).ToString();
            Lbl_vatTotal.Text = Math.Round(VAT, 2).ToString("0.00");
            Lbl_totalOutcome.Text = lose.ToString("0.00");
        }

        //מנקה נתונים
        private void clearData()
        {
            currentVat = mySQL.Getvat();
            Lbl_brutoEarnings.Text = "0";
            Lbl_totalIncome.Text = "0";
            Lbl_vatTotal.Text = "0";
            Lbl_totalOutcome.Text = "0";
            Txt_vat.Text = currentVat.Vat.ToString();
        }
        
        //בעת עזיבת שדה המעמ
        private void Txt_vat_Leave(object sender, EventArgs e)
        {
            //mySQL.InsertVat(VatPercentage);
            double vat = Convert.ToDouble(Txt_vat.Text);
            if(!(vat >= 0 && vat < 50))
            {
                MessageBox.Show("ערך מעמ לא תקין", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_vat.Text = "17";
            }
            else
            {
                Txt_vat.Text =vat.ToString();
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

        //אירוע שינוי תאריך
        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            getData();
        }

        //אירוע שינוי תאריך
        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void Frm_incomeAndOutcome_Load(object sender, EventArgs e)
        {
            clearData();
        }

        
        //כפתור שינוי ערך מעמ
        private void Btn_changeVAT_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(Txt_vat.Text) >= 0 && Convert.ToDouble(Txt_vat.Text) <50)
            {
                mySQL.updateVat(Convert.ToDouble(Txt_vat.Text));
                getData();
            }
            else
                MessageBox.Show("מעמ לא תקין", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
