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
    public partial class Frm_updateProduct : Form
    {
        private System.Windows.Forms.ErrorProvider barcodeErrorProvider;
        Product load_products;
        DBSQL mySQL;
        int count = 0;
        private Point sp = new Point(0, 0);

        public Frm_updateProduct()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }
        /*
        private void Opennewform(object obj)
        {
            Application.Run(new Frm_products_management());
            
        }
        */
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_updateProduct_Click(object sender, EventArgs e)
        {
            if (((Check_barcode() == true || Txt_model.Text != "") || (Txt_barcode.Text.Length == 0 && Txt_model.Text != "")) && Txt_category.Text != "" && Txt_manufacturer.Text != ""
                 && Txt_cost_price.Text != "" && Txt_selling_price.Text != "" && Txt_amount.Text != "")
            {
                Fill_obj(load_products);

                mySQL.UpdateProductBySerial(load_products);

                MessageBox.Show("מוצר עודכן בהצלחה");
                this.Close();

            }
            else
                MessageBox.Show("יש למלא את כל השדות");
        }

        private void Fill_obj(Product items)
        {
            if (Txt_model.Text != "" && Txt_barcode.Text != "")
            {
                items.Barcode = Txt_barcode.Text;
                items.Category = Txt_category.Text;
                items.Model = Txt_model.Text;
                items.Manufacturer = Txt_manufacturer.Text;
                items.Supplier = Txt_supplier.Text;
                items.Cost_price = Convert.ToInt32(Txt_cost_price.Text);
                items.Selling_price = Convert.ToInt32(Txt_selling_price.Text);
                items.Amount = Convert.ToInt32(Txt_amount.Text);
                items.Product_info = Txt_productInfo.Text;
            }
            else
            {
                if (Txt_barcode.Text == "" && Txt_model.Text != "")
                {
                    items.Barcode = "";
                    items.Category = Txt_category.Text;
                    items.Model = Txt_model.Text;
                    items.Manufacturer = Txt_manufacturer.Text;
                    items.Supplier = Txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(Txt_cost_price.Text);
                    items.Selling_price = Convert.ToInt32(Txt_selling_price.Text);
                    items.Amount = Convert.ToInt32(Txt_amount.Text);
                    items.Product_info = Txt_productInfo.Text;
                }
                else
                {
                    items.Barcode = Txt_barcode.Text;
                    items.Category = Txt_category.Text;
                    items.Model = "";
                    items.Manufacturer = Txt_manufacturer.Text;
                    items.Supplier = Txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(Txt_cost_price.Text);
                    items.Selling_price = Convert.ToInt32(Txt_selling_price.Text);
                    items.Amount = Convert.ToInt32(Txt_amount.Text);
                    items.Product_info = Txt_productInfo.Text;
                }
            }
        }

        private void Txt_cost_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_selling_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        /*
        private void Btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        private void Btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }
        */

        private void update_product_Load(object sender, EventArgs e)
        {
            load_products = mySQL.GetProductDataByBarcode(Txt_barcode.Text);
        }

        private void Txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (Txt_amount.Text != "")
            {
                if (Convert.ToInt32(Txt_amount.Text) > 0 && Convert.ToInt32(Txt_amount.Text) <= 2)
                    Txt_amount.ForeColor = Color.Orange;

                if (Convert.ToInt32(Txt_amount.Text) == 0)
                    Txt_amount.ForeColor = Color.Red;

                if (Convert.ToInt32(Txt_amount.Text) > 2)
                    Txt_amount.ForeColor = Color.White;
            }

        }

        private bool Check_barcode()
        {
            return (Txt_barcode.Text.Length == 13 || Txt_barcode.Text.Length == 12);
        }

        private void Txt_barcode_Leave(object sender, EventArgs e)
        {
            if (Check_barcode() == false && count == 0)
            {
                count++;
                // מגדירים שגאיה בהתאם
                barcodeErrorProvider = new ErrorProvider();
                barcodeErrorProvider.SetError(Txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
            }
            else
            {
                if (Check_barcode() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (Check_barcode() == true)
                    {
                        barcodeErrorProvider.SetError(Txt_barcode, "");
                    }
                    else
                    {
                        barcodeErrorProvider.SetError(Txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
                    }
                }
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_amount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
    }
}
