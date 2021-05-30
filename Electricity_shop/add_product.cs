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
    public partial class add_product : Form
    {
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        int inx;
        private DBSQL mySQL;
        AutoCompleteStringCollection bar = new AutoCompleteStringCollection();
        AutoCompleteStringCollection cat = new AutoCompleteStringCollection();
        string mod;
        AutoCompleteStringCollection factory = new AutoCompleteStringCollection();
        AutoCompleteStringCollection supp = new AutoCompleteStringCollection();

        public add_product()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            set_AutoCompleteMode_text_boxes();

        }

        private void set_AutoCompleteMode_text_boxes()
        {
            barcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            barcode.AutoCompleteSource = AutoCompleteSource.CustomSource;

            category.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //modell.AutoCompleteMode = AutoCompleteMode.Suggest;
            //modell.AutoCompleteSource = AutoCompleteSource.CustomSource;

            manufature.AutoCompleteMode = AutoCompleteMode.Suggest;
            manufature.AutoCompleteSource = AutoCompleteSource.CustomSource;

            supplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {
            Application.Run(new main());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool same = false;
            
            if (barcode.Text != "" && category.Text != "" && productInfo.Text != "" && modell.Text != ""
                && manufature.Text != "" && supplier.Text != "" && costPrice.Text != ""
                && sellingPrice.Text != "" && amount.Value != 0)
            {
                product[] Product = mySQL.GetProductData();
                product Prod = new product();
                string barcodeTmp = barcode.Text;

                for(int i=0;i<Product.Length;i++)
                {
                    if (barcodeTmp == Product[i].Barcode.ToString())
                    {
                        same = true;
                        inx = i;
                    }
                
                }

                if(same)
                {
                    same_product(Prod,Product[inx]);
                    read_only_false();
                }
                else
                {
                    new_product(Prod);
                    read_only_false();
                    
                }
            }
            else
                MessageBox.Show("יש למלא את כל השדות");

        }

        

        private void barcode_Leave(object sender, EventArgs e)
        {
            if (barcode.Text != "")
            {
                product[] Product = mySQL.GetProductData();
                string barcodeTmp = barcode.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (barcodeTmp == Product[i].Barcode.ToString())
                    {
                        
                        
                        barcode.Text = Product[i].Barcode.ToString();
                        category.Text = Product[i].Category;
                        modell.Text = Product[i].Model;
                        manufature.Text = Product[i].Manufacturer;
                        supplier.Text = Product[i].Supplier;
                        costPrice.Text = Product[i].Cost_price.ToString();
                        sellingPrice.Text = Product[i].Selling_price.ToString();
                        productInfo.Text = Product[i].Product_info;
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        read_only_true();

                    }

                }
            }
        }

        private void read_only_true()
        {
            barcode.ReadOnly = true;
            category.ReadOnly = true;
            modell.ReadOnly = true;
            manufature.ReadOnly = true;
            supplier.ReadOnly = true;
            costPrice.ReadOnly = true;
            sellingPrice.ReadOnly = true;
            productInfo.ReadOnly = true;
        }

        private void add_product_Load(object sender, EventArgs e)
        {
          
            product[] Product = mySQL.GetProductData();


            for (int i = 0; i < Product.Length; i++)
            {
                bar.Add(Product[i].Barcode.ToString());
                cat.Add(Product[i].Category);
                mod = Product[i].Model;
                factory.Add(Product[i].Manufacturer);
                supp.Add(Product[i].Supplier);

            }
            barcode.AutoCompleteCustomSource = bar;
            supplier.AutoCompleteCustomSource = supp;
            manufature.AutoCompleteCustomSource = factory;
            category.AutoCompleteCustomSource = cat;
        }

        private void clear_boxes()
        {
            barcode.Clear();
            category.Clear();
            modell.Clear();
            manufature.Clear();
            supplier.Clear();
            costPrice.Clear();
            sellingPrice.Clear();
            amount.Value = 0;
            productInfo.Clear();
        }

        private void same_product(product Prod, product Product)
        {
           
            Prod.Barcode = Convert.ToInt64(barcode.Text);
            Prod.Category = category.Text;
            Prod.Model = modell.Text;
            Prod.Manufacturer = manufature.Text;
            Prod.Supplier = supplier.Text;
            Prod.Cost_price = Convert.ToInt32(costPrice.Text);
            Prod.Selling_price = Convert.ToInt32(sellingPrice.Text);
            Prod.Amount = Convert.ToInt32(amount.Value)+Product.Amount;
            Prod.Product_info = productInfo.Text;
            mySQL.UpdateProductByBarcode(Prod);

            MessageBox.Show("מוצר קיים , עודכן בהצלחה");
            clear_boxes();
            
        }

        private void read_only_false()
        {
            barcode.ReadOnly = false;
            category.ReadOnly = false;
            modell.ReadOnly = false;
            manufature.ReadOnly = false;
            supplier.ReadOnly = false;
            costPrice.ReadOnly = false;
            sellingPrice.ReadOnly = false;
            productInfo.ReadOnly = false;
        }

        private void new_product(product Prod)
        {
            Prod.Barcode = Convert.ToInt64(barcode.Text);
            Prod.Category = category.Text;
            Prod.Model = modell.Text;
            Prod.Manufacturer = manufature.Text;
            Prod.Supplier = supplier.Text;
            Prod.Cost_price = Convert.ToInt32(costPrice.Text);
            Prod.Selling_price = Convert.ToInt32(sellingPrice.Text);
            Prod.Amount = Convert.ToInt32(amount.Value);
            Prod.Product_info = productInfo.Text;
            mySQL.InsertProduct(Prod);

            MessageBox.Show("מוצר הוסף בהצלחה");
            clear_boxes();
            
        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void costPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            clear_boxes();
        }

        private void modell_Leave(object sender, EventArgs e)
        {
            if (modell.Text != "")
            {
                product[] Product = mySQL.GetProductData();
                string modelTmp = modell.Text;

                for (int i = 0; i < Product.Length; i++)
                {
                    if (modelTmp == Product[i].Model.ToString())
                    {


                        barcode.Text = Product[i].Barcode.ToString();
                        category.Text = Product[i].Category;
                        modell.Text = Product[i].Model;
                        manufature.Text = Product[i].Manufacturer;
                        supplier.Text = Product[i].Supplier;
                        costPrice.Text = Product[i].Cost_price.ToString();
                        sellingPrice.Text = Product[i].Selling_price.ToString();
                        productInfo.Text = Product[i].Product_info;
                        MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                        read_only_true();

                    }

                }
            }
        }
    }
}
