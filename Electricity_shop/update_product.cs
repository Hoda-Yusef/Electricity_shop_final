//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_updateProduct : Form
    {
        
        private System.Windows.Forms.ErrorProvider barcodeErrorProvider;
        Product load_products;
        DBSQL mySQL;
        int count = 0;

        public Frm_updateProduct()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        //לחיצה על כפתור עדכן
        private void Btn_updateProduct_Click(object sender, EventArgs e)
        {
            //בודקים תקינות נתוהים שנקלטו
            if ( (Txt_model.Text != "" || Txt_barcode.Text != "") && Txt_category.Text != "" && Txt_manufacturer.Text != ""
                 && Txt_cost_price.Text != "" && Txt_selling_price.Text != "" && Txt_amount.Text != "")
            {
                //במידה ותקינים אז מעדכנים אותם בבסיס נתונים והשינויים נשמרים
                Fill_obj(load_products);

                mySQL.UpdateProductBySerial(load_products);

                MessageBox.Show("מוצר עודכן בהצלחה");
                this.Close();

            }
            //אחרת נציג הודעה מתאימה
            else
                MessageBox.Show("יש למלא את כל השדות");
        }

        //נמלא תכונות אובייקט שקיבלנו כפרמטר בערכי תיבות הטקסט בהתאמה 
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
        //הגדרת סוג תו
        private void Txt_cost_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //הגדרת סוג תו
        private void Txt_selling_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //טעינת טופס נוכחי
        private void update_product_Load(object sender, EventArgs e)
        {
            if (Txt_barcode.Text != "")
            {
                load_products = mySQL.GetProductDataByBarcode(Txt_barcode.Text);
            }
            else
                load_products = mySQL.GetProductDataByModel(Txt_model.Text);
        }
        //שינוי כמות מוצר
        private void Txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (Txt_amount.Text != "")
            {
                //כמות>0 וגם קטן או שווה ל2 צובעים כתום
                if (Convert.ToInt32(Txt_amount.Text) > 0 && Convert.ToInt32(Txt_amount.Text) <= 2)
                    Txt_amount.ForeColor = Color.Orange;
                //כמות שווה לאפס צובעים אדום
                if (Convert.ToInt32(Txt_amount.Text) == 0)
                    Txt_amount.ForeColor = Color.Red;
                //אחרת לבן
                if (Convert.ToInt32(Txt_amount.Text) > 2)
                    Txt_amount.ForeColor = Color.White;
            }

        }
        //פונקציה בודקת אם ברקוד תקין מחזירה אמת
        //אחרת מחזירה שקר
        private bool Check_barcode()
        {
            return (Txt_barcode.Text.Length == 13 || Txt_barcode.Text.Length == 12);
        }
        //עזיבת תיבת טקסט של ברקוד מוצר
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

            // בודקים אם מוצר קיים לפי ברקוד
            if (Txt_barcode.Text != "")
            {
                Product[] product = mySQL.GetProductData();
                string barcodeTmp = Txt_barcode.Text;

                for (int i = 0; i < product.Length; i++)
                {
                    if (barcodeTmp == product[i].Barcode.ToString())
                    {
                        
                        Txt_barcode.Text = product[i].Barcode.ToString();
                        Txt_category.Text = product[i].Category;
                        Txt_model.Text = product[i].Model;
                        Txt_manufacturer.Text = product[i].Manufacturer;
                        Txt_supplier.Text = product[i].Supplier;
                        Txt_cost_price.Text = product[i].Cost_price.ToString();
                        Txt_selling_price.Text = product[i].Selling_price.ToString();
                        Txt_amount.Text = product[i].Amount.ToString();
                        Txt_productInfo.Text = product[i].Product_info;

                    }
                }
            }
        }
        //לחיצה על כפתור ביטול
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //הגדרת סוג תו שברצוננו לקלוט
        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //הגדרת סוג תו שברצוננו לקלוט
        private void Txt_amount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_model_Leave(object sender, EventArgs e)
        {
            // בודקים אם מוצר קיים לפי דגם

            if (Txt_model.Text != "")
            {
                Product[] Product = mySQL.GetProductData();
                string modelTmp = Txt_model.Text;
                string upperCaseString = modelTmp.ToUpper();

                for (int i = 0; i < Product.Length; i++)
                {
                    // במקרה ונתון שנקלט זהה לדגם קיים
                    if (modelTmp == Product[i].Model.ToString() || upperCaseString == Product[i].Model.ToString())
                    {
                        int temporary_serial_number = Product[i].Product_serial_number;
                        load_products = mySQL.GetProductDataBySerialNumber(temporary_serial_number.ToString());
                        Txt_barcode.Text = load_products.Barcode.ToString();
                        Txt_category.Text = load_products.Category.ToString();
                        Txt_model.Text = load_products.Model.ToString();
                        Txt_manufacturer.Text = load_products.Manufacturer.ToString();
                        Txt_supplier.Text = load_products.Supplier.ToString();
                        Txt_cost_price.Text = load_products.Cost_price.ToString();
                        Txt_selling_price.Text = load_products.Selling_price.ToString();
                        Txt_amount.Text = load_products.Amount.ToString();
                        Txt_productInfo.Text = load_products.Product_info.ToString();
                    }

                }

            }
        }
        // לחיצה על כפתור X
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_products_management mainForm = new Frm_products_management();
            mainForm.Show();
        }

        
    }
}
