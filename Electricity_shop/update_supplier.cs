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
    public partial class Frm_updateSupplier : Form
    {
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;//סימן שגיאה
        supplier load_supplier = new supplier();
        readonly supplier updated_supplier = new supplier();
        readonly DBSQL mySQL;
        int count = 0;//מונה את הספרות במספר טלפון

        public Frm_updateSupplier()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Btn_exit_Click(object sender, EventArgs e)//יציאה
        {
            this.Close();

        }

        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים אפשר להזין
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים אפשר להזין
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_address_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים אפשר להזין
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות אפשר להזין
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_supplierDept_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות אפשר להזין
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_paidToSupplier_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות אפשר להזין
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Btn_cancelUpdating_Click(object sender, EventArgs e)//ביטול עידכון
        {
            this.Close();
            Frm_main mainForm = new Frm_main();
            mainForm.Show();
        }


        private bool Check_phone_number()//בודק אם מספר הטלפון נכון
        {
            return (this.Txt_phoneNumber.Text.Length == 10);
        }

        private void Txt_phoneNumber_Leave(object sender, EventArgs e)//בודק אם מספר הטלפון נכון בעל 10 ספרות
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

            // בודקים אם ספק קיים לפי מספר פלאפון
            if (Txt_phoneNumber.Text != "")
            {
                supplier[] Suppliers = mySQL.GetSupplierData();
                string phoneTmp = Txt_phoneNumber.Text;

                for (int i = 0; i < Suppliers.Length; i++)
                {
                    if (phoneTmp == Suppliers[i].Phone_number.ToString())
                    {
                        MessageBox.Show("ספק קיים");
                        Txt_firstName.Text = Suppliers[i].FirstName;
                        Txt_lastName.Text = Suppliers[i].LasttName;
                        Txt_phoneNumber.Text = Suppliers[i].Phone_number;
                        Txt_address.Text = Suppliers[i].Address;
                        Txt_supplierDept.Text = Suppliers[i].Dept.ToString();
                        Txt_paidToSupplier.Text = Suppliers[i].Paid.ToString();

                    }
                }
            }
        }

        private bool Check_phoneNumber()
        {
            return (Txt_phoneNumber.Text.Length == 10);
        }
       
        
        
        private void Btn_updateSupplier_Click(object sender, EventArgs e)//בעת לחיצה על עדכן
        {
            if ((Txt_firstName.Text != "" || Txt_lastName.Text != "") && Txt_address.Text != ""
                && Txt_phoneNumber.Text != "" && Check_phoneNumber() == true)//בודק אם לא נשאר שדות ריקות
            {
                Fill_obj(load_supplier);
                mySQL.UpdateSupplierBySerial(load_supplier);// אם הכל תקין  אז מעדכן את בסיסי נתונים
                MessageBox.Show("ספק עודכן בהצלחה");
                this.Close();
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");//אם לא מציג הודעה מתאימה
          
        }
       
        private void Fill_obj(supplier person)//ממילא פרטים של ספק בתוך אובייקט
        {
                person.FirstName = Txt_firstName.Text;
                person.LasttName = Txt_lastName.Text;
                person.Phone_number = Txt_phoneNumber.Text;
                person.Address = Txt_address.Text;
                person.Dept = Convert.ToInt32(Txt_supplierDept.Text);
                person.Paid = Convert.ToInt32(Txt_paidToSupplier.Text);

        }

        private void Frm_updateSupplier_Load(object sender, EventArgs e)
        {
            load_supplier = mySQL.GetSupplierDataByPhone(Txt_phoneNumber.Text);
        }
    }
}

