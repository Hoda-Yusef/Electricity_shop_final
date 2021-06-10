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
    public partial class cart_product_manu : Form
    {

        private DBSQL mySQL;
        DataTable dt;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        product[] Product;

        
        public cart_product_manu()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            
        }

        private void cart_product_manu_Load(object sender, EventArgs e)
        {
            Product = mySQL.GetProductData();

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

        

        private void fill_grid_by_barcode()
        {
            Product = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Product);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_category()
        {
            Product = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Product);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_manufacture()
        {
            Product = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Product);

            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_model()
        {
            Product = mySQL.GetProductDataFiltered(barcode.Text, category.Text, manufacture.Text, model.Text);

            fill_grid(Product);
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid(product[] Product)
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
            drag = true;
            sp = new Point(e.X, e.Y);
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

        private void clear_Click(object sender, EventArgs e)
        {
            barcode.Text = "";
            category.Text = "";
            model.Text = "";
            manufacture.Text = "";
        }

        private void barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

       
        private void OpenProductCart(object obj)
        {
            Application.Run(new product_cart());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenProductCart);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void add_to_cart_Click(object sender, EventArgs e)
        {
            bool same = false;
            string item = products_grid.CurrentRow.Cells[3].Value.ToString();
            int amount = (int)products_grid.CurrentRow.Cells[5].Value;
            cart[] Cart = mySQL.getCartData();

            for (int i = 0; i < Cart.Length; i++)
            {
                if (Cart[i].Product_barcode == item)
                {
                    same = true;
                }
            }

            if (same)
            {
                MessageBox.Show("מוצר קיים בעגלה", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (amount != 0)
                {
                    mySQL.InsertToCart(item,Convert.ToInt32(amountChoose.Value));
                    MessageBox.Show("מוצר התווסף לעגלה");
                }
                else
                    MessageBox.Show("מוצר אזל מהמלאי", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            amountChoose.Value = 1;
        }
    }
}
