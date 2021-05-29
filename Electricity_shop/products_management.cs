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
        public products_management()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            dt = mySQL.GetProductData_for_table();

            fill_grid();

            
        }

        private void fill_grid()
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
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CONVERT(barcode, System.String) LIKE '%{0}%'", barcode.Text);
            products_grid.DataSource = dv;
            
        }

        private void category_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("product_category like '{0}%'", category.Text);
            products_grid.DataSource = dv;
        }
    }
}
