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
        private System.Windows.Forms.ErrorProvider barcodeErrorProvider;
        product load_products;
        DBSQL mySQL;
        int count = 0;

        Point sp = new Point(0, 0);
        public update_product()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        
        }

        private void opennewform(object obj)
        {
            Application.Run(new products_management());
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            
            if ((barcode.Text != "" || model.Text!="") && category.Text != "" && manufacture.Text != "" 
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

            if (model.Text != "" && barcode.Text != "")
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
            else
            {
                if(barcode.Text=="" && model.Text!="")
                {
                    //items.Barcode = barcode.Text;
                    items.Category = category.Text;
                    items.Model = model.Text;
                    items.Manufacturer = manufacture.Text;
                    items.Supplier = supplier.Text;
                    items.Cost_price = Convert.ToInt32(cost_price.Text);
                    items.Selling_price = Convert.ToInt32(selling_price.Text);
                    items.Amount = Convert.ToInt32(amount.Text);
                    items.Product_info = productInfo.Text;
                }
                else
                {
                    items.Barcode = barcode.Text;
                    items.Category = category.Text;
                    //items.Model = model.Text;
                    items.Manufacturer = manufacture.Text;
                    items.Supplier = supplier.Text;
                    items.Cost_price = Convert.ToInt32(cost_price.Text);
                    items.Selling_price = Convert.ToInt32(selling_price.Text);
                    items.Amount = Convert.ToInt32(amount.Text);
                    items.Product_info = productInfo.Text;
                }
            }
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
            btn_exit.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void update_product_Load(object sender, EventArgs e)
        {
          load_products = mySQL.GetProductDataByBarcode(barcode.Text);
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

        private bool check_barcode()
        {
            return (barcode.Text.Length==13 || barcode.Text.Length==12 || barcode.Text.Length==0);
        }

        private void barcode_Leave(object sender, EventArgs e)
        { 
            if (check_barcode() == false && count == 0)
            {
                count++;
                // מגדירים שגאיה בהתאם
                barcodeErrorProvider = new ErrorProvider();
                barcodeErrorProvider.SetError(barcode, "ברקוד מכיל 13 או 12 ספרות");
            }
            else
            {
                if (check_barcode() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (check_barcode() == true)
                    {
                        barcodeErrorProvider.SetError(barcode, "");
                    }
                    else
                    {
                        barcodeErrorProvider.SetError(barcode, "ברקוד מכיל 13 או 12 ספרות");
                    }
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
