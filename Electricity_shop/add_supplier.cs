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
    public partial class Frm_addSupplier : Form
    {
        private readonly DBSQL mySQL;
        Thread th;
        int count = 0;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        readonly AutoCompleteStringCollection SFirstName = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection SLastName = new AutoCompleteStringCollection();
        public Frm_addSupplier()
        {

            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
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

        private void Btn_addSupplier_Click(object sender, EventArgs e)
        {
            bool same = false;

            if ((Txt_firstName.Text != "" || Txt_lastName.Text != "") && Txt_address.Text != "" && Txt_phoneNumber.Text != ""
                && Check_phone_number() == true)
            {
                supplier[] Supplier = mySQL.GetSupplierData();
                supplier supp = new supplier();
               
                string nameTmp = Txt_phoneNumber.Text;

                for (int i = 0; i < Supplier.Length; i++)
                {
                    if (nameTmp == Supplier[i].Phone_number)
                    {
                        same = true;

                    }
                }

                if (same)
                {
                    MessageBox.Show("ספק קייםת ניתן לעדכן פרטיו");
                    
                    Frm_updateSupplier uSupplier = new Frm_updateSupplier();
                    supp = mySQL.GetSupplierDataByPhone(Txt_phoneNumber.Text);
                    uSupplier.Txt_firstName.Text = supp.FirstName;     
                    uSupplier.Txt_lastName.Text =supp.LasttName ;
                    uSupplier.Txt_address.Text =supp.Address ;
                    uSupplier.Txt_phoneNumber.Text =supp.Phone_number; 
                    uSupplier.Txt_supplierDept.Text =supp.Dept.ToString();
                    uSupplier.Txt_paidToSupplier.Text =supp.Paid.ToString();
                    uSupplier.ShowDialog();
                    this.Close();
                    uSupplier.Close();
                    
                    th = new Thread(Open_supManagment);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                   

                }
                else
                {
                    New_supplier(supp);
                   
                    this.Close();
                    th = new Thread(Open_supManagment);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("קלט לא תקין:נא לבדוק תקינות נתונים בשדות");
            }
        }

        private void Open_supManagment(object obj)
        {
            Application.Run(new Frm_suppliersManagement());
        }

        private void New_supplier(supplier supp)
        {
            if (Txt_supplierDept.Text != "" && Txt_payedForSupplier.Text != "")
            {
                supp.FirstName = Txt_firstName.Text;
                supp.LasttName = Txt_lastName.Text;
                supp.Address = Txt_address.Text;
                supp.Phone_number = Txt_phoneNumber.Text;
                supp.Dept = Convert.ToInt32(Txt_supplierDept.Text);
                supp.Paid = Convert.ToInt32(Txt_payedForSupplier.Text);
                mySQL.InsertSupplier(supp);

                MessageBox.Show("ספק הוסף בהצלחה");
                Clear_boxes();
            }
            else
            {

                if (Txt_supplierDept.Text == "" && Txt_payedForSupplier.Text == "")
                {
                    supp.FirstName = Txt_firstName.Text;
                    supp.Address = Txt_address.Text;
                    supp.Phone_number = Txt_phoneNumber.Text;
                    mySQL.InsertSupplier(supp);

                    MessageBox.Show("ספק הוסף בהצלחה");
                    Clear_boxes();
                }

                else
                {
                    if (Txt_supplierDept.Text != "" && Txt_payedForSupplier.Text == "")
                    {
                        supp.FirstName = Txt_firstName.Text;
                        supp.LasttName = Txt_lastName.Text;
                        supp.Address = Txt_address.Text;
                        supp.Phone_number = Txt_phoneNumber.Text;
                        supp.Dept = Convert.ToInt32(Txt_supplierDept.Text);
                        mySQL.InsertSupplier(supp);

                        MessageBox.Show("ספק הוסף בהצלחה");
                        Clear_boxes();
                    }

                    else
                    {
                        supp.FirstName = Txt_firstName.Text;
                        supp.LasttName = Txt_lastName.Text;
                        supp.Address = Txt_address.Text;
                        supp.Phone_number = Txt_phoneNumber.Text;
                        supp.Paid = Convert.ToInt32(Txt_payedForSupplier.Text);
                        mySQL.InsertSupplier(supp);

                        MessageBox.Show("ספק הוסף בהצלחה");
                        Clear_boxes();
                    }
                }
            }
        }

        private void Clear_boxes()
        {
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_address.Text = string.Empty;
            Txt_supplierDept.Text = string.Empty;
            Txt_payedForSupplier.Text = string.Empty;
        }

        private void Frm_addSupplier_Load(object sender, EventArgs e)
        {
            supplier[] Supplier = mySQL.GetSupplierData();


            for (int i = 0; i < Supplier.Length; i++)
            {
                SFirstName.Add(Supplier[i].FirstName);
                SLastName.Add(Supplier[i].LasttName);


            }
            Txt_firstName.AutoCompleteCustomSource = SFirstName;
            Txt_lastName.AutoCompleteCustomSource = SLastName;
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch!=8 && ch!=9 && ch!=11)
            {
                e.Handled = true;
            }
        }

        private void Txt_supplierDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_payedForSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private bool Check_phone_number()
        {
            return (this.Txt_phoneNumber.Text.Length == 10);
        }

        private void Txt_phoneNumber_Leave(object sender, EventArgs e)
        {

            // בודקים תקינות קלט
            if (Check_phone_number() == false && count == 0)
            {
                count++;
                phoneErrorProvider = new ErrorProvider();
                phoneErrorProvider.SetError(Txt_phoneNumber, "מספר פלאפון חייב להכיל בדיוק 10 ספרות");
            }
            else
            {
                if (Check_phone_number() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (Check_phone_number() == true)
                    {
                        phoneErrorProvider.SetError(Txt_phoneNumber, "");
                    }
                    else
                    {
                        phoneErrorProvider.SetError(Txt_phoneNumber, "מספר פלאפון חייב להכיל בדיוק 10 ספרות");
                    }
                }
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
