//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה להצגת ועדכון פרטים של ספק
    public partial class Frm_updateSupplier : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;//סימן שגיאה
        supplier load_supplier = new supplier();
        readonly supplier updated_supplier = new supplier();
        readonly DBSQL mySQL;
        int count = 0;//מונה את הספרות במספר טלפון
        int usersRole;
        string userName;
        public Frm_updateSupplier(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }

        //יציאה
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //רק מספרים אפשר להזין
        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //רק אותיות אפשר להזין
        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //רק אותיות אפשר להזין
        private void Txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //רק אותיות אפשר להזין
        private void Txt_supplierDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //רק אותיות אפשר להזין
        private void Txt_paidToSupplier_KeyPress(object sender, KeyPressEventArgs e)
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
            Frm_suppliersManagement mainForm = new Frm_suppliersManagement(usersRole,userName);
            mainForm.Show();
        }


        private bool Check_phone_number()//בודק אם מספר הטלפון נכון
        {
            return (this.Txt_phoneNumber.Text.Length == 10);
        }

        //בודק אם מספר הטלפון נכון בעל 10 ספרות
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
                checkValidPhone();
            }

            // בודקים אם ספק קיים לפי מספר פלאפון
            checkExistingPhoneNumber();
        }

        // בודקים אם ספק קיים לפי מספר פלאפון
        private void checkExistingPhoneNumber()
        {
            if (Txt_phoneNumber.Text != "")
            {
                supplier[] Suppliers = mySQL.GetSupplierData();
                string phoneTmp = Txt_phoneNumber.Text;

                if (Suppliers != null)
                {

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
        }

        private void checkValidPhone()
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

        private bool Check_phoneNumber()
        {
            return (Txt_phoneNumber.Text.Length == 10);
        }



        //בעת לחיצה על עדכן
        private void Btn_updateSupplier_Click(object sender, EventArgs e)
        {
            //בודק אם לא נשאר שדות ריקות
            if ((Txt_firstName.Text != "" || Txt_lastName.Text != "") && Txt_address.Text != ""
                && Txt_phoneNumber.Text != "" && Check_phoneNumber() == true)
            {
                Fill_obj(load_supplier);
                // אם הכל תקין  אז מעדכן את בסיסי נתונים
                mySQL.UpdateSupplierBySerial(load_supplier);
                MessageBox.Show("ספק עודכן בהצלחה");
                this.Close();
            }
            else
                //אם לא מציג הודעה מתאימה
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");

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
        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }
        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }
        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}

