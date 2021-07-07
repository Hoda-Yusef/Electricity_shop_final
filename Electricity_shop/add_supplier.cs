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
    public partial class add_supplier : Form
    {
        private DBSQL mySQL;
        Thread th;
        int count = 0;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        AutoCompleteStringCollection SFirstName = new AutoCompleteStringCollection();
        AutoCompleteStringCollection SLastName = new AutoCompleteStringCollection();
        public add_supplier()
        {

            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }
       
        private void opennewform(object obj)
        {
            Application.Run(new Frm_main());
        }
        

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool same = false;

            if ((firstNameTBox.Text != "" || lastNameTBox.Text != "") && addressTBox.Text != "" && phoneNumberTBox.Text != ""
                && check_phone_number() == true)
            {
                supplier[] Supplier = mySQL.GetSupplierData();
                supplier supp = new supplier();
               
                string nameTmp = phoneNumberTBox.Text;

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
                    
                    update_supplier uSupplier = new update_supplier();
                    supp = mySQL.GetSupplierDataByPhone(phoneNumberTBox.Text);
                    uSupplier.firstNameTBox.Text = supp.FirstName;     
                    uSupplier.lastNameTBox.Text =supp.LasttName ;
                    uSupplier.addressTBox.Text =supp.Address ;
                    uSupplier.phoneNumberTBox.Text =supp.Phone_number; 
                    uSupplier.deptTBox.Text =supp.Dept.ToString();
                    uSupplier.paidTBox.Text =supp.Paid.ToString();
                    uSupplier.ShowDialog();
                    this.Close();
                    uSupplier.Close();
                    
                    th = new Thread(open_supManagment);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                   

                }
                else
                {
                    new_supplier(supp);
                   
                    this.Close();
                    th = new Thread(open_supManagment);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("קלט לא תקין:נא לבדוק תקינות נתונים בשדות");
            }
        }

        private void open_supManagment(object obj)
        {
            Application.Run(new suppliers_management());
        }

        private void new_supplier(supplier supp)
        {
            if (deptTBox.Text != "" && paidTBox.Text != "")
            {
                supp.FirstName = firstNameTBox.Text;
                supp.LasttName = lastNameTBox.Text;
                supp.Address = addressTBox.Text;
                supp.Phone_number = phoneNumberTBox.Text;
                supp.Dept = Convert.ToInt32(deptTBox.Text);
                supp.Paid = Convert.ToInt32(paidTBox.Text);
                mySQL.InsertSupplier(supp);

                MessageBox.Show("ספק הוסף בהצלחה");
                clear_boxes();
            }
            else
            {

                if (deptTBox.Text == "" && paidTBox.Text == "")
                {
                    supp.FirstName = firstNameTBox.Text;
                    supp.Address = addressTBox.Text;
                    supp.Phone_number = phoneNumberTBox.Text;
                    mySQL.InsertSupplier(supp);

                    MessageBox.Show("ספק הוסף בהצלחה");
                    clear_boxes();
                }

                else
                {
                    if (deptTBox.Text != "" && paidTBox.Text == "")
                    {
                        supp.FirstName = firstNameTBox.Text;
                        supp.LasttName = lastNameTBox.Text;
                        supp.Address = addressTBox.Text;
                        supp.Phone_number = phoneNumberTBox.Text;
                        supp.Dept = Convert.ToInt32(deptTBox.Text);
                        mySQL.InsertSupplier(supp);

                        MessageBox.Show("ספק הוסף בהצלחה");
                        clear_boxes();
                    }

                    else
                    {
                        supp.FirstName = firstNameTBox.Text;
                        supp.LasttName = lastNameTBox.Text;
                        supp.Address = addressTBox.Text;
                        supp.Phone_number = phoneNumberTBox.Text;
                        supp.Paid = Convert.ToInt32(paidTBox.Text);
                        mySQL.InsertSupplier(supp);

                        MessageBox.Show("ספק הוסף בהצלחה");
                        clear_boxes();
                    }
                }
            }
        }

        private void clear_boxes()
        {
            firstNameTBox.Text = string.Empty;
            lastNameTBox.Text = string.Empty;
            phoneNumberTBox.Text = string.Empty;
            addressTBox.Text = string.Empty;
            deptTBox.Text = string.Empty;
            paidTBox.Text = string.Empty;
        }

        private void add_supplier_Load(object sender, EventArgs e)
        {
            supplier[] Supplier = mySQL.GetSupplierData();


            for (int i = 0; i < Supplier.Length; i++)
            {
                SFirstName.Add(Supplier[i].FirstName);
                SLastName.Add(Supplier[i].LasttName);


            }
            firstNameTBox.AutoCompleteCustomSource = SFirstName;
            lastNameTBox.AutoCompleteCustomSource = SLastName;
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch!=8 && ch!=9 && ch!=11)
            {
                e.Handled = true;
            }
        }

        private void dept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void firstNameTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void lastNameTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void addressTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private bool check_phone_number()
        {
            return (this.phoneNumberTBox.Text.Length == 10);
        }

        private void phoneNumberTBox_Leave(object sender, EventArgs e)
        {

            // בודקים תקינות קלט
            if (check_phone_number() == false && count == 0)
            {
                count++;
                phoneErrorProvider = new ErrorProvider();
                phoneErrorProvider.SetError(phoneNumberTBox, "מספר פלאפון חייב להכיל בדיוק 10 ספרות");
            }
            else
            {
                if (check_phone_number() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (check_phone_number() == true)
                    {
                        phoneErrorProvider.SetError(phoneNumberTBox, "");
                    }
                    else
                    {
                        phoneErrorProvider.SetError(phoneNumberTBox, "מספר פלאפון חייב להכיל בדיוק 10 ספרות");
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
