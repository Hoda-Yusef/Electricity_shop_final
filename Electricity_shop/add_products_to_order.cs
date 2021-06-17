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
    public partial class add_products_to_order : Form
    {
        private DBSQL mySQL;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        product[] Products;
        product Product;
        //order_number_holder ONH;
        product_order[] Product_order;
        string order_number_holder;

        public add_products_to_order()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        }

        public add_products_to_order(string orderNumber)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            order_number_holder = orderNumber;
        }

        private void add_products_to_order_Load(object sender, EventArgs e)
        {
            Products = mySQL.GetProductData();

            for (int i = 0; i < Products.Length; i++)
            {
                products_grid.Rows.Add(new object[]
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

        private void products_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < products_grid.Rows.Count; i++)
            {
                int amount = Convert.ToInt32(products_grid.Rows[i].Cells[5].Value);
                if (amount > 0 && amount <= 2)
                {
                    products_grid.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;

                }

                if (amount == 0)
                {
                    products_grid.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_barcode();
        }

        private void category_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_category();
        }

        private void manufacture_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_manufacture();
        }

        private void model_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_model();
        }

        private void fill_grid_by_barcode()
        {
            Products = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Products);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_category()
        {
            Products = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Products);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_manufacture()
        {
            Products = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Products);

            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_model()
        {
            Products = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Products);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid(Product[] Product)
        {
            products_grid.Rows.Clear();
            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    products_grid.Rows.Add(new object[]
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
                products_grid.Rows.Clear();
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            {
                drag = true;
                sp = new Point(e.X, e.Y);
            }
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void add_products_to_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void add_to_order_Click(object sender, EventArgs e)
        {
            bool same = false;
            //ONH = mySQL.GetorderNumberHolder();//שולפים את מספר ההזמנה
                                             
            Product = mySQL.GetProductDataByBarcode(products_grid.CurrentRow.Cells[3].Value.ToString());
            Product_order = mySQL.GetProduct_orderDataByOrderNumber(order_number_holder);

            string item = products_grid.CurrentRow.Cells[3].Value.ToString();//שולפים את הברקוד מהטבלה 
            int amount = (int)products_grid.CurrentRow.Cells[5].Value;//שולפים את הכמות הקיימת למוצר הנבחר


            for (int i = 0; i < Product_order.Length; i++)//לולאה בודקת אם המוצר שנבחר קיים כבר להזמנה
            {
                if (Product_order[i].Product_serial_number == Product.Product_serial_number)
                {
                    same = true;
                }
            }

            insert_to_order(same,item,amount);

            
        }

        private void insert_to_order(bool same, string item, int amount)
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
                        Product = mySQL.GetProductDataByBarcode(item);//שולפים מידע למוצר הקיים
                        mySQL.InsertToProductOrder(Product.Product_serial_number, Convert.ToInt32(order_number_holder), Convert.ToInt32(amountChoose.Value));//מוסיפים את המוצר המובקש להזמנה
                        mySQL.UpdateProductAmountByBarcode(amount - Convert.ToInt32(amountChoose.Value), item);//מעדכנים את הכמות של המוצר הקיים
                        MessageBox.Show("מוצר התווסף להזמנה");
                        Thread th;
                        this.Close();
                        th = new Thread(OpenSelf);
                        th.TrySetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                        MessageBox.Show("לא מספיק מלאי לכמות המבוקשת");
                }
                else
                    MessageBox.Show("מוצר אזל מהמלאי", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            amountChoose.Value = 1;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenUpadteOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenUpadteOrder(object obj)
        {
            Application.Run(new update_order(order_number_holder));
        }

        private void OpenSelf(object obj)
        {
            Application.Run(new add_products_to_order(order_number_holder));
        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
    }
}
