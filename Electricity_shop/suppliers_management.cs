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
    public partial class suppliers_management : Form
    {
        Thread th;
        private DBSQL mySQL;
        private supplier[] Supplier;
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection last_nameAuto = new AutoCompleteStringCollection();
        public suppliers_management()
        {

            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_supplier uSupplier = new update_supplier();
            uSupplier.firstNameTBox.Text = suppliers_grid.CurrentRow.Cells[0].Value.ToString();
            uSupplier.lastNameTBox.Text = suppliers_grid.CurrentRow.Cells[1].Value.ToString();
            uSupplier.addressTBox.Text = suppliers_grid.CurrentRow.Cells[3].Value.ToString();
            uSupplier.phoneNumberTBox.Text = suppliers_grid.CurrentRow.Cells[2].Value.ToString();
            uSupplier.deptTBox.Text = suppliers_grid.CurrentRow.Cells[5].Value.ToString();
            uSupplier.paidTBox.Text = suppliers_grid.CurrentRow.Cells[4].Value.ToString();
            uSupplier.ShowDialog();

            this.Close();
            th = new Thread(openSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSelf(object obj)
        {
            Application.Run(new suppliers_management());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void suppliers_management_Load(object sender, EventArgs e)
        {
            supplier[] Supplier = mySQL.GetSupplierData();
            for (int i = 0; i < Supplier.Length; i++)
            {
                suppliers_grid.Rows.Add(new object[]
                    {
                        Supplier[i].FirstName,
                        Supplier[i].LasttName,
                        Supplier[i].Phone_number,
                        Supplier[i].Address,
                        Supplier[i].Dept,
                        Supplier[i].Paid
                    });
            }

            for (int i = 0; i < Supplier.Length; i++)
            {
                firstNameAuto.Add(Supplier[i].FirstName.ToString());
                last_nameAuto.Add(Supplier[i].Phone_number.ToString());
            }

            first_nameTBox.AutoCompleteCustomSource = firstNameAuto;
            last_nameTBox.AutoCompleteCustomSource = last_nameAuto;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            first_nameTBox.Text = "";
            last_nameTBox.Text = "";

        }

        private void first_nameTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void last_nameTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void fill_grid(supplier[] Sup)
        {
            suppliers_grid.Rows.Clear();
            if (Sup != null)
            {
                for (int i = 0; i < Sup.Length; i++)
                {
                    suppliers_grid.Rows.Add(new object[]
                    {
                    Sup[i].FirstName,
                    Sup[i].LasttName,
                    Sup[i].Phone_number,
                    Sup[i].Address,
                    Sup[i].Dept,
                    Sup[i].Paid
                    });
                }
            }
            else
                suppliers_grid.Rows.Clear();
        }

        private void fill_grid_by_firstName()
        {
            Supplier = mySQL.GetSupplierDataByFN(first_nameTBox.Text);
            fill_grid(Supplier);
            if (suppliers_grid.Rows.Count != 0)
                suppliers_grid.Rows[0].Cells[0].Selected = false;
        }

        private void fill_grid_by_lastName()
        {
            Supplier = mySQL.GetSupplierDataByLN(last_nameTBox.Text);
            fill_grid(Supplier);
            if (suppliers_grid.Rows.Count != 0)
                suppliers_grid.Rows[0].Cells[0].Selected = false;
        }

        private void first_nameTBox_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_firstName();
        }

        private void last_nameTBox_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_lastName();
        }
    }
}
