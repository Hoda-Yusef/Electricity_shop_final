//Hoda Khier + Yusef Aborokon 44/5

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
    public partial class Frm_addProductsToOrder : Form
    {
        private DBSQL mySQL;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);

        Product[] Products;
        Product Product;

        product_order[] Product_order;
        string order_number_holder;

        public Frm_addProductsToOrder()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        public Frm_addProductsToOrder(string orderNumber)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            order_number_holder = orderNumber;
        }

        private void Frm_addProductsToOrder_Load(object sender, EventArgs e)
        {
            Products = mySQL.GetProductData();

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Amount > 0)//הצגת רק את המוצרים שזמינים במלאי
                {
                    Grd_productsList.Rows.Add(new object[]
                    {
                    Products[i].Category,
                    Products[i].Manufacturer,
                    Products[i].Model,
                    Products[i].Barcode,
                    Products[i].Supplier,
                    Products[i].Amount,
                    Products[i].Cost_price,
                    Products[i].Selling_price,
                    Products[i].Product_info
                    });
                }
            }
        }

        private void Grd_productsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < Grd_productsList.Rows.Count; i++)
            {
                int amount = Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value);
                if (amount > 0 && amount <= 2)
                {
                    Grd_productsList.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;

                }

                if (amount == 0)
                {
                    Grd_productsList.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void Txt_productBarcode_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_barcode();
        }

        private void Txt_productCategory_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_category();
        }

        private void Txt_productManufacturer_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_manufacture();
        }

        private void Txt_productModel_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_model();
        }

        private void fill_grid_by_barcode()
        {
           Products = mySQL.GetProductDataFiltered("זמין במלאי",Txt_productBarcode.Text, Txt_productCategory.Text, Txt_productManufacturer.Text, Txt_productModel.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_category()
        {
            Products = mySQL.GetProductDataFiltered("זמין במלאי",Txt_productBarcode.Text, Txt_productCategory.Text, Txt_productManufacturer.Text, Txt_productModel.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_manufacture()
        {
           Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_productBarcode.Text, Txt_productCategory.Text, Txt_productManufacturer.Text, Txt_productModel.Text);

            fill_grid(Products);

            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_model()
        {
           Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_productBarcode.Text, Txt_productCategory.Text, Txt_productManufacturer.Text, Txt_productModel.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid(Product[] Product)
        {
            Grd_productsList.Rows.Clear();
            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    Grd_productsList.Rows.Add(new object[]
                    {
                    Product[i].Category,
                    Product[i].Manufacturer,
                    Product[i].Model,
                    Product[i].Barcode,
                    Product[i].Supplier,
                    Product[i].Amount,
                    Product[i].Cost_price,
                    Product[i].Selling_price,
                    Product[i].Product_info
                    });
                }
            }
            else
                Grd_productsList.Rows.Clear();
        }

        private void Upper_BluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            {
                drag = true;
                sp = new Point(e.X, e.Y);
            }
        }

        private void Upper_BluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_BluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Frm_addProductsToOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Btn_addToOrder_Click(object sender, EventArgs e)
        {
            bool same = false;
             
            if(Grd_productsList.CurrentRow.Cells[3].Value.ToString() != "")
                Product = mySQL.GetProductDataByBarcode(Grd_productsList.CurrentRow.Cells[3].Value.ToString());
            else if(Grd_productsList.CurrentRow.Cells[2].Value.ToString() != "")
                Product = mySQL.GetProductDataByModel(Grd_productsList.CurrentRow.Cells[2].Value.ToString());

            Product_order = mySQL.GetProduct_orderDataByOrderNumber(order_number_holder);

            string itemBarcode = Grd_productsList.CurrentRow.Cells[3].Value.ToString();//שולפים את הברקוד מהטבלה 
            string itemModel = Grd_productsList.CurrentRow.Cells[2].Value.ToString();
            int amount = (int)Grd_productsList.CurrentRow.Cells[5].Value;//שולפים את הכמות הקיימת למוצר הנבחר

            if (Product_order != null)
            {
                for (int i = 0; i < Product_order.Length; i++)//לולאה בודקת אם המוצר שנבחר קיים כבר להזמנה
                {
                    if (Product_order[i].Product_serial_number == Product.Product_serial_number)
                    {
                        same = true;
                    }
                }
            }
            insert_to_order(same,itemBarcode,itemModel,amount);

            
        }

        private void insert_to_order(bool same, string itemBarcode,string itemModel, int amount)
        {
            if (same)//בודקים אם המוצר הנבחר הוא כבר בהזמנה
            {
                MessageBox.Show("מוצר קיים בהזמנה", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (amount != 0)//בודק אם המלאי קיים למוצר הספיציפי
                {
                    if (amount - Convert.ToInt32(amountChoose.Value) >= 0)//בודקים אם יש מספיק מלאי לכמות המבוקשת
                    {
                        if (itemBarcode != "")
                        {
                            Product = mySQL.GetProductDataByBarcode(itemBarcode);//שולפים מידע למוצר הקיים
                            mySQL.InsertToProductOrder(Product.Product_serial_number, Convert.ToInt32(order_number_holder), Convert.ToInt32(amountChoose.Value));//מוסיפים את המוצר המובקש להזמנה
                            mySQL.UpdateProductAmountByBarcode(amount - Convert.ToInt32(amountChoose.Value), itemBarcode);//מעדכנים את הכמות של המוצר הקיים
                            MessageBox.Show("מוצר התווסף להזמנה");
                            Thread th;
                            this.Close();
                            th = new Thread(OpenSelf);
                            th.TrySetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else if(itemModel != "")
                        {
                            Product = mySQL.GetProductDataByModel(itemModel);//שולפים מידע למוצר הקיים
                            mySQL.InsertToProductOrder(Product.Product_serial_number, Convert.ToInt32(order_number_holder), Convert.ToInt32(amountChoose.Value));//מוסיפים את המוצר המובקש להזמנה
                            mySQL.UpdateProductAmountByModel(amount - Convert.ToInt32(amountChoose.Value), itemModel);//מעדכנים את הכמות של המוצר הקיים
                            MessageBox.Show("מוצר התווסף להזמנה");
                            Thread th;
                            this.Close();
                            th = new Thread(OpenSelf);
                            th.TrySetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                    else
                        MessageBox.Show("לא מספיק מלאי לכמות המבוקשת");
                }
                else
                    MessageBox.Show("מוצר אזל מהמלאי", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            amountChoose.Value = 1;
        }

        private void Btn_backToOrder_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenUpadteOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenUpadteOrder(object obj)
        {
            Application.Run(new Frm_updateOrder(order_number_holder));
        }

        private void OpenSelf(object obj)
        {
            Application.Run(new Frm_addProductsToOrder(order_number_holder));
        }

        private void Txt_productBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Btn_exitX_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Txt_productBarcode.Text = string.Empty;
            Txt_productCategory.Text = string.Empty;
            Txt_productManufacturer.Text = string.Empty;
            Txt_productModel.Text = string.Empty;
        }
    }
}
