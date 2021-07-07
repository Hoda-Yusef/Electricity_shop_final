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
            Txt_category.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_manufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_manufacturer.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_supplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Btn_exitX_Click(object sender, EventArgs e)
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

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        /*
        private void Open_proManagment(object obj)
        {
            Application.Run(new Frm_products_management());
        }
        */
        private bool Check_barcode()
        {
            return (Txt_barcode.Text.Length == 13 || Txt_barcode.Text.Length == 12 || Txt_barcode.Text.Length == 0);
        }


        private void Read_only_true()
        {
            Txt_barcode.ReadOnly = true;
            Txt_category.ReadOnly = true;
            Txt_model.ReadOnly = true;
            Txt_manufacturer.ReadOnly = true;
            Txt_supplier.ReadOnly = true;
            Txt_costPrice.ReadOnly = true;
            Txt_sellingPrice.ReadOnly = true;
            Txt_productInformation.ReadOnly = true;
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
            Txt_barcode.AutoCompleteCustomSource = barcode;
            Txt_supplier.AutoCompleteCustomSource = supplier;
            Txt_model.AutoCompleteCustomSource = model;
            Txt_manufacturer.AutoCompleteCustomSource = manufacturer;
            Txt_category.AutoCompleteCustomSource = category;
        }

        private void Clear_boxes()
        {
            Txt_barcode.Clear();
            Txt_category.Clear();
            Txt_model.Clear();
            Txt_manufacturer.Clear();
            Txt_supplier.Clear();
            Txt_costPrice.Clear();
            Txt_sellingPrice.Clear();
            productAmount.Value = 0;
            Txt_productInformation.Clear();
        }


        /*
        private void Fill_obj(Product items)
        {
            if (Txt_model.Text != "" && Txt_barcode.Text != "")
            {
                items.Barcode = Txt_barcode.Text;
                items.Category = Txt_category.Text;
                items.Model = Txt_model.Text;
                items.Manufacturer = Txt_manufacturer.Text;
                items.Supplier = Txt_supplier.Text;
                items.Cost_price = Convert.ToInt32(Txt_costPrice.Text);
                items.Selling_price = Convert.ToInt32(Txt_sellingPrice.Text);
                items.Amount = Convert.ToInt32(productAmount.Text);
                items.Product_info = Txt_productInformation.Text;
            }
            else
            {
                if (Txt_barcode.Text == "" && Txt_model.Text != "")
                {
                    //items.Barcode = barcode.Text;
                    items.Category = Txt_category.Text;
                    items.Model = Txt_model.Text;
                    items.Manufacturer = Txt_manufacturer.Text;
                    items.Supplier = Txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(Txt_costPrice.Text);
                    items.Selling_price = Convert.ToInt32(Txt_sellingPrice.Text);
                    items.Amount = Convert.ToInt32(productAmount.Text);
                    items.Product_info = Txt_productInformation.Text;
                }
                else
                {
                    items.Barcode = Txt_barcode.Text;
                    items.Category = Txt_category.Text;
                    //items.Model = model.Text;
                    items.Manufacturer = Txt_manufacturer.Text;
                    items.Supplier = Txt_supplier.Text;
                    items.Cost_price = Convert.ToInt32(Txt_costPrice.Text);
                    items.Selling_price = Convert.ToInt32(Txt_sellingPrice.Text);
                    items.Amount = Convert.ToInt32(productAmount.Text);
                    items.Product_info = Txt_productInformation.Text;
                }
            }
        }*/

        /*
        private void Same_product(Product Product)
        {
            Fill_obj(Product);

            mySQL.UpdateProductAmountByBarcode(Convert.ToInt32(productAmount.Value), Product.Barcode.ToString());
            MessageBox.Show("מוצר קיים , עודכן בהצלחה");
            Clear_boxes();

        }*/
        /*
        private void Read_only_false()
        {
            Txt_barcode.ReadOnly = false;
            Txt_category.ReadOnly = false;
            Txt_model.ReadOnly = false;
            Txt_manufacturer.ReadOnly = false;
            Txt_supplier.ReadOnly = false;
            Txt_costPrice.ReadOnly = false;
            Txt_sellingPrice.ReadOnly = false;
            Txt_productInformation.ReadOnly = false;
        }*/

        private void New_product(Product Prod)
        {
            Prod.Barcode = Txt_barcode.Text;
            Prod.Category = Txt_category.Text;
            Prod.Model = Txt_model.Text;
            Prod.Manufacturer = Txt_manufacturer.Text;
            Prod.Supplier = Txt_supplier.Text;
            Prod.Cost_price = Convert.ToInt32(Txt_costPrice.Text);
            Prod.Selling_price = Convert.ToInt32(Txt_sellingPrice.Text);
            Prod.Amount = Convert.ToInt32(productAmount.Value);
            Prod.Product_info = Txt_productInformation.Text;
            mySQL.InsertProduct(Prod);

            MessageBox.Show("מוצר התווסף בהצלחה");
            Clear_boxes();

        }


        private void Txt_sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Upper_bluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void Upper_bluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_bluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }



        private void Txt_barcode_Leave(object sender, EventArgs e)
        {
            // בודקים אם לקוח קיים לפי תעודת זהות
            if (Txt_barcode.Text != "")
            {
                //product Prod = new product();
                Product[] Product = mySQL.GetProductData();
                string temporary_barcode = Txt_barcode.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (temporary_barcode == Product[i].Barcode.ToString())
                    {
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        load_products = mySQL.GetProductDataByBarcode(Txt_barcode.Text);
                        Txt_barcode.Text = load_products.Barcode.ToString();
                        Txt_category.Text = load_products.Category.ToString();
                        Txt_model.Text = load_products.Model.ToString();
                        Txt_manufacturer.Text = load_products.Manufacturer.ToString();
                        Txt_supplier.Text = load_products.Supplier.ToString();
                        Txt_costPrice.Text = load_products.Cost_price.ToString();
                        Txt_sellingPrice.Text = load_products.Selling_price.ToString();
                        //productAmount.Value = load_products.Amount;
                        Txt_productInformation.Text = load_products.Product_info.ToString();
                        Read_only_true();

                    }
                }
            }

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

        private void Txt_costPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Btn_addProduct_Click(object sender, EventArgs e)
        {
            bool same = false;

            if ((Check_barcode() || Txt_model.Text != "") && Txt_category.Text != "" && Txt_productInformation.Text != ""
                && Txt_manufacturer.Text != "" && Txt_supplier.Text != "" && Txt_costPrice.Text != ""
                && Txt_sellingPrice.Text != "" && productAmount.Value != 0)
            {
                Product[] Product = mySQL.GetProductData();
                Product Prod = new Product();
                string barcodeTmp = Txt_barcode.Text;

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

        private void Btn_clearAll_Click(object sender, EventArgs e)
        {
            Clear_boxes();
        }

        private void Txt_model_Leave(object sender, EventArgs e)
        {
            if (Txt_model.Text != "")
            {
                Product[] Product = mySQL.GetProductData();
                string modelTmp = Txt_model.Text;
                string upperCaseString = modelTmp.ToUpper();

                for (int i = 0; i < Product.Length; i++)
                {
                    if (modelTmp == Product[i].Model.ToString() || upperCaseString == Product[i].Model.ToString())
                    {
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        int temporary_serial_number = Product[i].Product_serial_number;
                        load_products = mySQL.GetProductDataBySerialNumber(temporary_serial_number.ToString());
                        Txt_barcode.Text = load_products.Barcode.ToString();
                        Txt_category.Text = load_products.Category.ToString();
                        Txt_model.Text = load_products.Model.ToString();
                        Txt_manufacturer.Text = load_products.Manufacturer.ToString();
                        Txt_supplier.Text = load_products.Supplier.ToString();
                        Txt_costPrice.Text = load_products.Cost_price.ToString();
                        Txt_sellingPrice.Text = load_products.Selling_price.ToString();
                        //productAmount.Value = load_products.Amount;
                        Txt_productInformation.Text = load_products.Product_info.ToString();
                        Read_only_true();
                    }

                    }

                }
            }
    }
    }

