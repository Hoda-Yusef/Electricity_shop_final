﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Electricity_shop
{
    public partial class Frm_suppliersManagement : Form
    {
        Thread th;
        private DBSQL mySQL;
        private supplier[] Supplier;
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection last_nameAuto = new AutoCompleteStringCollection();
        public Frm_suppliersManagement()
        {

            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenMain(object obj)
        {
            Application.Run(new Frm_main());
        }

       

        private void Btn_updateSupplier_Click(object sender, EventArgs e)
        {
            Frm_updateSupplier uSupplier = new Frm_updateSupplier();
            uSupplier.Txt_firstName.Text = Grd_suppliers.CurrentRow.Cells[0].Value.ToString();
            uSupplier.Txt_lastName.Text = Grd_suppliers.CurrentRow.Cells[1].Value.ToString();
            uSupplier.Txt_address.Text = Grd_suppliers.CurrentRow.Cells[3].Value.ToString();
            uSupplier.Txt_phoneNumber.Text = Grd_suppliers.CurrentRow.Cells[2].Value.ToString();
            uSupplier.Txt_supplierDept.Text = Grd_suppliers.CurrentRow.Cells[5].Value.ToString();
            uSupplier.Txt_paidToSupplier.Text = Grd_suppliers.CurrentRow.Cells[4].Value.ToString();
            uSupplier.ShowDialog();

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenSelf(object obj)
        {
            Application.Run(new Frm_suppliersManagement());
        }

        private void Btn_toMainPage_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Frm_suppliersManagement_Load(object sender, EventArgs e)
        {
            supplier[] Supplier = mySQL.GetSupplierData();
            for (int i = 0; i < Supplier.Length; i++)
            {
                Grd_suppliers.Rows.Add(new object[]
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

            Txt_firstName.AutoCompleteCustomSource = firstNameAuto;
            Txt_lastName.AutoCompleteCustomSource = last_nameAuto;
        }

        private void Btn_clearTextBoxes_Click(object sender, EventArgs e)
        {
            Txt_firstName.Text = "";
            Txt_lastName.Text = "";

        }

        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Fill_grid(supplier[] Sup)
        {
            Grd_suppliers.Rows.Clear();
            if (Sup != null)
            {
                for (int i = 0; i < Sup.Length; i++)
                {
                    Grd_suppliers.Rows.Add(new object[]
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
                Grd_suppliers.Rows.Clear();
        }

        private void Fill_grid_by_firstName()
        {
            Supplier = mySQL.GetSupplierDataByFN(Txt_firstName.Text);
            Fill_grid(Supplier);
            if (Grd_suppliers.Rows.Count != 0)
                Grd_suppliers.Rows[0].Cells[0].Selected = false;
        }

        private void Fill_grid_by_lastName()
        {
            Supplier = mySQL.GetSupplierDataByLN(Txt_lastName.Text);
            Fill_grid(Supplier);
            if (Grd_suppliers.Rows.Count != 0)
                Grd_suppliers.Rows[0].Cells[0].Selected = false;
        }

        private void Txt_firstName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_firstName();
        }

        private void Txt_lastName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_lastName();
        }
    }
}
