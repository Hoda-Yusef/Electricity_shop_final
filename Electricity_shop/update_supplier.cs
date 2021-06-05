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
    public partial class update_supplier : Form
    {
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        supplier load_supplier = new supplier();
        supplier updated_supplier = new supplier();
        DBSQL mySQL;
        Thread th;
        int count = 0;
        public update_supplier()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void phoneNumberTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void deptTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void paidTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
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

        private bool check_phoneNumber()
        {
            return (phoneNumberTBox.Text.Length == 10);
        }
       
        
        
        private void update_button_Click(object sender, EventArgs e)
        {
            if ((firstNameTBox.Text != "" || lastNameTBox.Text != "") && addressTBox.Text != ""
                && phoneNumberTBox.Text != "" && check_phoneNumber() == true)
            {
                fill_obj(load_supplier);
                mySQL.UpdateSupplierBySerial(load_supplier);
                MessageBox.Show("ספק עודכן בהצלחה");
                this.Close();
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");
          
        }
        /*
        private void openManagement(object obj)
        {
            Application.Run(new suppliers_management());
        }
        */
        private void fill_obj(supplier person)
        {
                person.FirstName = firstNameTBox.Text;
                person.LasttName = lastNameTBox.Text;
                person.Phone_number = phoneNumberTBox.Text;
                person.Address = addressTBox.Text;
                person.Dept = Convert.ToInt32(deptTBox.Text);
                person.Paid = Convert.ToInt32(paidTBox.Text);

        }

        private void update_supplier_Load(object sender, EventArgs e)
        {
            load_supplier = mySQL.GetSupplierDataByPhone(phoneNumberTBox.Text);
        }
    }
}

