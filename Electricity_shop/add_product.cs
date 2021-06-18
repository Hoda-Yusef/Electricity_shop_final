using iTextSharp.text.pdf;
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
    public partial class Frm_addProduct : Form
    {
        Product load_products;
        int count = 0;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        //int inx;
        private readonly DBSQL mySQL;
        private System.Windows.Forms.ErrorProvider barcodeErrorProvider;
        readonly AutoCompleteStringCollection barcode = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection category = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection model = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection manufacturer = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection supplier = new AutoCompleteStringCollection();

        public Frm_addProduct()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            Set_AutoCompleteMode_text_boxes();

        }

        private void Set_AutoCompleteMode_text_boxes()
        {
            txt_category.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_manufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_manufacturer.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_supplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btn_exitX_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Opennewform(object obj)
        {
            Application.Run(new main());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void Open_proManagment(object obj)
        {
            Application.Run(new Frm_products_management());
        }

        private bool Check_barcode()
        {
            return (txt_barcode.Text.Length == 13 || txt_barcode.Text.Length == 12 || txt_barcode.Text.Length == 0);
        }


        private void Read_only_true()
        {
            txt_barcode.ReadOnly = true;
            txt_category.ReadOnly = true;
            txt_model.ReadOnly = true;
            txt_manufacturer.ReadOnly = true;
            txt_supplier.ReadOnly = true;
            txt_costPrice.ReadOnly = true;
            txt_sellingPrice.ReadOnly = true;
            txt_productInformation.ReadOnly = true;
        }

        private void Frm_addProduct_Load(object sender, EventArgs e)
        {
            Product[] Product = mySQL.GetProductData();


            for (int i = 0; i < Product.Length; i++)
            {
                barcode.Add(Product[i].Barcode);
                category.Add(Product[i].Category);
                model.Add(Product[i].Model);
                manufacturer.Add(Product[i].Manufacturer);
                supplier.Add(Product[i].Supplier);

            }
            txt_barcode.AutoCompleteCustomSource = barcode;
            txt_supplier.AutoCompleteCustomSource = supplier;
            txt_model.AutoCompleteCustomSource = model;
            txt_manufacturer.AutoCompleteCustomSource = manufacturer;
            txt_category.AutoCompleteCustomSource = category;
        }

        private void Clear_boxes()
        {
            txt_barcode.Clear();
            txt_category.Clear();
            txt_model.Clear();
            txt_manufacturer.Clear();
            txt_supplier.Clear();
            txt_costPrice.Clear();
            txt_sellingPrice.Clear();
            productAmount.Value = 0;
            txt_productInformation.Clear();
        }



        private void fill_obj(Product items)
        {
            if (txt_model.Text != "" && txt_barcode.Text != "")
            {
                items.Barcode = txt_barcode.Text;
                items.Category = txt_category.Text;
                items.Model = txt_model.Text;
                items.Manufacturer = txt_manufacturer.Text;
                items.Supplier = txt_supplier.Text;
                items.Cost_price = Convert.ToInt32(txt_costPrice.Text);
                items.Selling_price = Convert.ToInt32(txt_sellingPrice.Text);
                items.Amount = Convert.ToInt32(productAmount.Text);
                items.Product_info = txt_productInformation.Text;
            }
            else
            {
                if (txt_barcode.Text == "" && txt_model.Text != "")
                {
                    //items.Barcode = barcode.Text;
                    items.Category = txt_category.Text;
                    items.Model = txt_model.Text;
                    items.Manufacturer = txt_manufacturer.Text;
                    items.Supplier = txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(txt_costPrice.Text);
                    items.Selling_price = Convert.ToInt32(txt_sellingPrice.Text);
                    items.Amount = Convert.ToInt32(productAmount.Text);
                    items.Product_info = txt_productInformation.Text;
                }
                else
                {
                    items.Barcode = txt_barcode.Text;
                    items.Category = txt_category.Text;
                    //items.Model = model.Text;
                    items.Manufacturer = txt_manufacturer.Text;
                    items.Supplier = txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(txt_costPrice.Text);
                    items.Selling_price = Convert.ToInt32(txt_sellingPrice.Text);
                    items.Amount = Convert.ToInt32(productAmount.Text);
                    items.Product_info = txt_productInformation.Text;
                }
            }
        }


        private void Same_product(Product Product)
        {
            fill_obj(Product);

            mySQL.UpdateProductAmountByBarcode(Convert.ToInt32(productAmount.Value), Product.Barcode.ToString());
            MessageBox.Show("מוצר קיים , עודכן בהצלחה");
            Clear_boxes();

        }

        private void Read_only_false()
        {
            txt_barcode.ReadOnly = false;
            txt_category.ReadOnly = false;
            txt_model.ReadOnly = false;
            txt_manufacturer.ReadOnly = false;
            txt_supplier.ReadOnly = false;
            txt_costPrice.ReadOnly = false;
            txt_sellingPrice.ReadOnly = false;
            txt_productInformation.ReadOnly = false;
        }

        private void New_product(Product Prod)
        {
            Prod.Barcode = txt_barcode.Text;
            Prod.Category = txt_category.Text;
            Prod.Model = txt_model.Text;
            Prod.Manufacturer = txt_manufacturer.Text;
            Prod.Supplier = txt_supplier.Text;
            Prod.Cost_price = Convert.ToInt32(txt_costPrice.Text);
            Prod.Selling_price = Convert.ToInt32(txt_sellingPrice.Text);
            Prod.Amount = Convert.ToInt32(productAmount.Value);
            Prod.Product_info = txt_productInformation.Text;
            mySQL.InsertProduct(Prod);

            MessageBox.Show("מוצר התווסף בהצלחה");
            Clear_boxes();

        }


        private void txt_sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void frameColorUp_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void frameColorUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void frameColorUp_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }



        private void txt_barcode_Leave(object sender, EventArgs e)
        {
            // בודקים אם לקוח קיים לפי תעודת זהות
            if (txt_barcode.Text != "")
            {
                //product Prod = new product();
                Product[] Product = mySQL.GetProductData();
                string temporary_barcode = txt_barcode.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (temporary_barcode == Product[i].Barcode.ToString())
                    {
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        load_products = mySQL.GetProductDataByBarcode(txt_barcode.Text);
                        txt_barcode.Text = load_products.Barcode.ToString();
                        txt_category.Text = load_products.Category.ToString();
                        txt_model.Text = load_products.Model.ToString();
                        txt_manufacturer.Text = load_products.Manufacturer.ToString();
                        txt_supplier.Text = load_products.Supplier.ToString();
                        txt_costPrice.Text = load_products.Cost_price.ToString();
                        txt_sellingPrice.Text = load_products.Selling_price.ToString();
                        //productAmount.Value = load_products.Amount;
                        txt_productInformation.Text = load_products.Product_info.ToString();
                        Read_only_true();

                    }
                }
            }

            if (Check_barcode() == false && count == 0)
            {
                count++;
                // מגדירים שגאיה בהתאם
                barcodeErrorProvider = new ErrorProvider();
                barcodeErrorProvider.SetError(txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
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
                        barcodeErrorProvider.SetError(txt_barcode, "");
                    }
                    else
                    {
                        barcodeErrorProvider.SetError(txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
                    }
                }
            }
        }

        private void txt_costPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            bool same = false;

            if ((Check_barcode() || txt_model.Text != "") && txt_category.Text != "" && txt_productInformation.Text != ""
                && txt_manufacturer.Text != "" && txt_supplier.Text != "" && txt_costPrice.Text != ""
                && txt_sellingPrice.Text != "" && productAmount.Value != 0)
            {
                Product[] Product = mySQL.GetProductData();
                Product Prod = new Product();
                string barcodeTmp = txt_barcode.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (barcodeTmp == Product[i].Barcode.ToString())
                    {
                        same = true;
                    }
                }

                if (same)
                {
                    int new_amount = Convert.ToInt32(productAmount.Value) + load_products.Amount;

                    mySQL.UpdateProductAmountBySerial(new_amount, load_products.Product_serial_number.ToString());
                    MessageBox.Show("מוצר קיים , עודכן בהצלחה");
                    Clear_boxes();
                }
                else
                {
                    New_product(Prod);
                    Clear_boxes();
                }
            }
            else
            {
                MessageBox.Show("יש למלא את כל השדות");
            }
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            Clear_boxes();
        }

        private void txt_model_Leave(object sender, EventArgs e)
        {
            if (txt_model.Text != "")
            {
                Product[] Product = mySQL.GetProductData();
                string modelTmp = txt_model.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (modelTmp == Product[i].Model.ToString())
                    {
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        int temporary_serial_number = Product[i].Product_serial_number;
                        load_products = mySQL.GetProductDataBySerialNumber(temporary_serial_number.ToString());
                        txt_barcode.Text = load_products.Barcode.ToString();
                        txt_category.Text = load_products.Category.ToString();
                        txt_model.Text = load_products.Model.ToString();
                        txt_manufacturer.Text = load_products.Manufacturer.ToString();
                        txt_supplier.Text = load_products.Supplier.ToString();
                        txt_costPrice.Text = load_products.Cost_price.ToString();
                        txt_sellingPrice.Text = load_products.Selling_price.ToString();
                        //productAmount.Value = load_products.Amount;
                        txt_productInformation.Text = load_products.Product_info.ToString();
                        Read_only_true();

                    }

                }
            }
        }
    }
}
