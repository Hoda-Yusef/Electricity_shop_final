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
    public partial class update_product : Form
    {
        product load_products = new product();
        DBSQL mySQL;

        bool drag = false;
        Point sp = new Point(0, 0);
        public update_product()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void opennewform(object obj)
        {
            Application.Run(new products_management());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            if (barcode.Text != "" && category.Text != "" && manufacture.Text != "" && model.Text != ""
                 && cost_price.Text != "" && selling_price.Text != "" && amount.Text != "")
            {
                    fill_obj(load_products);

                    mySQL.UpdateProductBySerial(load_products);

                    MessageBox.Show("מוצר עודכן בהצלחה");
                    this.Close();
               
            }
            else
                MessageBox.Show("יש למלא את כל השדות");




        }

        private void fill_obj(product items)
        {
            
            items.Barcode = barcode.Text;
            items.Category = category.Text;
            items.Model = model.Text;
            items.Manufacturer = manufacture.Text;
            items.Supplier = supplier.Text;
            items.Cost_price = Convert.ToInt32(cost_price.Text);
            items.Selling_price = Convert.ToInt32(selling_price.Text);
            items.Amount = Convert.ToInt32(amount.Text);
            items.Product_info = productInfo.Text;
        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void cost_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void selling_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void update_product_Load(object sender, EventArgs e)
        {
          load_products = mySQL.GetProductDataByBarcode(Convert.ToInt32(barcode.Text));
        }

        private void amount_TextChanged(object sender, EventArgs e)
        {
            if (amount.Text != "")
            {
                if (Convert.ToInt32(amount.Text) > 0 && Convert.ToInt32(amount.Text) <= 2)
                    amount.ForeColor = Color.Orange;

                if (Convert.ToInt32(amount.Text) == 0)
                    amount.ForeColor = Color.Red;

                if (Convert.ToInt32(amount.Text) > 2)
                    amount.ForeColor = Color.White;
            }

        }
    }
}
