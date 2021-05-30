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
    public partial class products_management : Form
    {
        private DBSQL mySQL;
        DataTable dt;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        product[] Product;

        AutoCompleteStringCollection barcodeAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection categoryAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection modelAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection manufactureAuto = new AutoCompleteStringCollection();
        
        public products_management()
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

            category.AutoCompleteMode = AutoCompleteMode.Suggest;
            category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            model.AutoCompleteMode = AutoCompleteMode.Suggest;
            model.AutoCompleteSource = AutoCompleteSource.CustomSource;

            manufacture.AutoCompleteMode = AutoCompleteMode.Suggest;
            manufacture.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
        }

        private void fill_grid_by_barcode()
        {
            Product = mySQL.GetProductDataFiltered(barcode.Text,category.Text,manufacture.Text,model.Text);

            fill_grid(Product);
            if(products_grid.Rows.Count!=0)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }


        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(34, 36, 49);
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

        private void orders_grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           for(int i=0;i<products_grid.Rows.Count;i++)
            {
                int amount = Convert.ToInt32(products_grid.Rows[i].Cells[5].Value);
                if(amount>0 && amount<=2)
                {
                    products_grid.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                   
                }

                if(amount==0)
                {
                    products_grid.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }


        }

        private void update_product_Click(object sender, EventArgs e)
        {
            update_product updateProduct = new update_product();

            updateProduct.category.Text = products_grid.CurrentRow.Cells[0].Value.ToString();
            updateProduct.manufacture.Text = products_grid.CurrentRow.Cells[1].Value.ToString();
            updateProduct.model.Text = products_grid.CurrentRow.Cells[2].Value.ToString();
            updateProduct.barcode.Text = products_grid.CurrentRow.Cells[3].Value.ToString();
            updateProduct.supplier.Text = products_grid.CurrentRow.Cells[4].Value.ToString();
            updateProduct.amount.Text = products_grid.CurrentRow.Cells[5].Value.ToString();
            updateProduct.cost_price.Text = products_grid.CurrentRow.Cells[6].Value.ToString();
            updateProduct.selling_price.Text = products_grid.CurrentRow.Cells[7].Value.ToString();
            updateProduct.productInfo.Text = products_grid.CurrentRow.Cells[8].Value.ToString();

            updateProduct.ShowDialog();

            this.Close();
            th = new Thread(openSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openSelf(object obj)
        {
            Application.Run(new products_management());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
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

        private void products_management_Load(object sender, EventArgs e)
        {
            product[] Product = mySQL.GetProductData();

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

            
            for (int i = 0; i < Product.Length; i++)
            {
                barcodeAuto.Add(Product[i].Barcode.ToString());
                categoryAuto.Add(Product[i].Category);
                modelAuto.Add(Product[i].Model);
                manufactureAuto.Add(Product[i].Manufacturer);
                

            }
            if (products_grid.Rows.Count != 0)
                products_grid.Rows[0].Cells[0].Selected = false;
           
            barcode.AutoCompleteCustomSource = barcodeAuto;
            manufacture.AutoCompleteCustomSource = manufactureAuto;
            model.AutoCompleteCustomSource = modelAuto;
            category.AutoCompleteCustomSource = categoryAuto;
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
    }
}
