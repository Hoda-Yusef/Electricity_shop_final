//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה שמוסיפה ספק לבסיסי נתונים
    public partial class Frm_addSupplier : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);
        private readonly DBSQL mySQL;
        Thread th;
        int count = 0;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        readonly AutoCompleteStringCollection SFirstName = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection SLastName = new AutoCompleteStringCollection();
        int usersRole;
        string userName;

        public Frm_addSupplier(int role,string username)
        {

            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }

        private void Opennewform(object obj)//פותח חלון ראשי
        {
            Application.Run(new Frm_main(usersRole,userName));
        }
        private void OpenEmployeesMainForm(object obj)//פותח חלון ראשי
        {
            Application.Run(new Frm_mainForEmployees(usersRole,userName));
        }


        private void Btn_cancel_Click(object sender, EventArgs e)//לחיצת ביטול
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(Opennewform);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMainForm);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }

        private void Btn_addSupplier_Click(object sender, EventArgs e)//לחיצת הוספה 
        {
            bool same = false;

            if ((Txt_firstName.Text != "" || Txt_lastName.Text != "") && Txt_address.Text != "" && Txt_phoneNumber.Text != ""
                && Check_phone_number() == true)//אם אין שדות ריקות
            {
                supplier[] Supplier = mySQL.GetSupplierData();
                supplier supp = new supplier();

                string nameTmp = Txt_phoneNumber.Text;

                if (Supplier != null)
                {
                    for (int i = 0; i < Supplier.Length; i++)//לולאה בודקת אם ספק קיים במערכת 
                    {
                        if (nameTmp == Supplier[i].Phone_number)
                        {
                            same = true;

                        }
                    }
                }
                ifSupplierExist(same,supp);
                
            }
            else
            {
                MessageBox.Show("קלט לא תקין:נא לבדוק תקינות נתונים בשדות");
            }
        }

        private void ifSupplierExist(bool same ,supplier supp)
        {
            if (same)//אם ספק קיים 
            {
                MessageBox.Show("ספק קיים. ניתן לעדכן פרטים");

                Frm_updateSupplier uSupplier = new Frm_updateSupplier(usersRole, userName);
                supp = mySQL.GetSupplierDataByPhone(Txt_phoneNumber.Text);//שולף מידע על ספק לפי מספר טלפון
                uSupplier.Txt_firstName.Text = supp.FirstName;
                uSupplier.Txt_lastName.Text = supp.LasttName;
                uSupplier.Txt_address.Text = supp.Address;
                uSupplier.Txt_phoneNumber.Text = supp.Phone_number;
                uSupplier.Txt_supplierDept.Text = supp.Dept.ToString();
                uSupplier.Txt_paidToSupplier.Text = supp.Paid.ToString();
                uSupplier.ShowDialog();
                this.Close();
                uSupplier.Close();

                th = new Thread(Open_supManagment);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                New_supplier(supp);//אם ספק חדש

                this.Close();
                th = new Thread(Open_supManagment);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Open_supManagment(object obj)
        {
            Application.Run(new Frm_suppliersManagement(usersRole,userName));
        }

        private void New_supplier(supplier supp)//אם ספק חדש יבדוק אם המשתמש הזין חוב וגם את התשלום
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
                    supp.LasttName = Txt_lastName.Text;
                    supp.Address = Txt_address.Text;
                    supp.Phone_number = Txt_phoneNumber.Text;
                    mySQL.InsertSupplier(supp);

                    MessageBox.Show("ספק הוסף בהצלחה");
                    Clear_boxes();
                }
                else
                {
                    checkExistingSupplier(supp);
                }
            }
        }

        private void checkExistingSupplier(supplier supp)
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

        private void Clear_boxes()//ניקוי שדות
        {
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_address.Text = string.Empty;
            Txt_supplierDept.Text = string.Empty;
            Txt_payedForSupplier.Text = string.Empty;
        }

        private void Frm_addSupplier_Load(object sender, EventArgs e)//מילוי שדות אוטומטי
        {
            supplier[] Supplier = mySQL.GetSupplierData();

            if (Supplier != null)
            {
                for (int i = 0; i < Supplier.Length; i++)
                {
                    SFirstName.Add(Supplier[i].FirstName);
                    SLastName.Add(Supplier[i].LasttName);


                }
                Txt_firstName.AutoCompleteCustomSource = SFirstName;
                Txt_lastName.AutoCompleteCustomSource = SLastName;
            }
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים בשדה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_supplierDept_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים בשדה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_payedForSupplier_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים בשדה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות בשדה
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_lastName_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות בשדה
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_address_KeyPress(object sender, KeyPressEventArgs e)//רק אותיות בשדה
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

            // בודקים אם ספק קיים לפי מספר פלאפון
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
                            Txt_payedForSupplier.Text = Suppliers[i].Paid.ToString();

                        }
                    }
                }
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)//יציאה
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(Opennewform);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMainForm);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)//ניקוי שדות
        {
            Txt_address.Text = string.Empty;
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_supplierDept.Text = string.Empty;
            Txt_payedForSupplier.Text = string.Empty;
        }

        private void UpperBluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void UpperBluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void UpperBluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
