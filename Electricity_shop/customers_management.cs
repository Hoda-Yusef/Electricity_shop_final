﻿using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Electricity_shop
{
    public partial class FrmCustomers_management : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);
        private readonly DBSQL mySQL;
        Thread th;
        customer[] Customer;
        readonly AutoCompleteStringCollection IdAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection phoneNumberAuto = new AutoCompleteStringCollection();
        int usersRole;
        public FrmCustomers_management(int role)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;

        }
        //למלא טבלה בטופס לפי תעודת זהות של הלקוח
        //נציג פרטי לקוח בטבלה בעל תעודת זהות הנקלטת
        private void Fill_grid_by_Id()
        {

            Customer = mySQL.GetCustomerDataById2(Txt_customerId.Text);

            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;

        }
        //למלא טבלה לפי שם פרטי של הלקוח
        private void Fill_grid_by_firstName()
        {
            Customer = mySQL.GetCustomerDataByFN(Txt_firstName.Text);
            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;
        }

        //למלא טבלה לפי מספר פלאפון של הלקוח
        private void Fill_grid_by_phoneN()
        {
            Customer = mySQL.GetCustomerDataByphoneNumber(Txt_phoneNumber.Text);
            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;
        }
        //למלא טבלה לפי לקוח המועבר לפונקציה
        private void Fill_grid(customer[] Customer)
        {
            Grd_customers.Rows.Clear();
            if (Customer != null)
            {
                for (int i = 0; i < Customer.Length; i++)
                {
                    Grd_customers.Rows.Add(new object[]
                    {
                    Customer[i].Id,
                    Customer[i].First_name,
                    Customer[i].Last_name,
                    Customer[i].Phone_number,
                    Customer[i].Address
                    });
                }
            }
            else
                Grd_customers.Rows.Clear();
        }
        //פתיחת טופס ראשי
        private void OpenMain(object obj)
        {
            Application.Run(new Frm_main(usersRole));
        }
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole));
        }
        //לחיצה על כפתור חזרה לראשי
        private void Btn_toMain_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            { 
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
          
        }
        //טעינת טופס נוכחי
        private void FrmCustomers_management_Load(object sender, EventArgs e)
        {
            Grd_customers.RowTemplate.Height = 35;
            //שומרים את המידע של כל הלקוחות הקיימים במערכת
            customer[] Customer = mySQL.GetCustomerData();

            if (Customer != null)
            {
                for (int i = 0; i < Customer.Length; i++)
                {
                    //מציגים אותם בטבלה
                    Grd_customers.Rows.Add(new object[]
                        {
                        Customer[i].Id,
                        Customer[i].First_name,
                        Customer[i].Last_name,
                        Customer[i].Phone_number,
                        Customer[i].Address
                        });
                }

                for (int i = 0; i < Customer.Length; i++)
                {
                    IdAuto.Add(Customer[i].Id.ToString());
                    firstNameAuto.Add(Customer[i].First_name.ToString());
                    phoneNumberAuto.Add(Customer[i].Phone_number.ToString());
                }
                // הגדרת שדות החיפוש למילוי אוטומטי
                Txt_customerId.AutoCompleteCustomSource = IdAuto;
                Txt_firstName.AutoCompleteCustomSource = firstNameAuto;
                Txt_phoneNumber.AutoCompleteCustomSource = phoneNumberAuto;
            }
        }
        // שינוי בקלט בשדה תעודת זהות של הלקוח
        private void Txt_customerId_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_Id();
        }
       //הגדרת איזה סוג של תו ניתן לכתוב לשדה תעודת זהות
        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //התאמת תוצאה בטבלה לפי שם שנקלט בשדה שם פרטי
        private void Txt_firstName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_firstName();
        }
        //הגדרת איזה סוג של תו ניתן לכתוב לשדה שם פרטי
        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //הגדרת איזה סוג של תו ניתן לכתוב לשדה מספר פלאפון
        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //התאמת תוצאה בטבלה לפי שם שנקלט בשדה מספר פלאפון
        private void Txt_phoneNumber_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_phoneN();
        }
        //לחיצה על כפתור עדכון
        private void Btn_update_Click(object sender, EventArgs e)
        {
            Frm_update_customer uCustomer = new Frm_update_customer(usersRole);
            uCustomer.Txt_customerId.Text= Grd_customers.CurrentRow.Cells[0].Value.ToString();
            uCustomer.Txt_firstName.Text = Grd_customers.CurrentRow.Cells[1].Value.ToString();
            uCustomer.Txt_lastName.Text = Grd_customers.CurrentRow.Cells[2].Value.ToString();
            uCustomer.Txt_phoneNumber.Text = Grd_customers.CurrentRow.Cells[3].Value.ToString();
            uCustomer.Txt_address.Text = Grd_customers.CurrentRow.Cells[4].Value.ToString();
            uCustomer.ShowDialog();

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }
        // פתיחת טופס נוכחי בחזרה
        private void OpenSelf(object obj)
        {
            Application.Run(new FrmCustomers_management(usersRole));
        }
        //לחיצה על כפתור X
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Txt_firstName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_customerId.Text = string.Empty;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Grd_customers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frm_update_customer uCustomer = new Frm_update_customer(usersRole);
            uCustomer.Txt_customerId.Text = Grd_customers.CurrentRow.Cells[0].Value.ToString();
            uCustomer.Txt_firstName.Text = Grd_customers.CurrentRow.Cells[1].Value.ToString();
            uCustomer.Txt_lastName.Text = Grd_customers.CurrentRow.Cells[2].Value.ToString();
            uCustomer.Txt_phoneNumber.Text = Grd_customers.CurrentRow.Cells[3].Value.ToString();
            uCustomer.Txt_address.Text = Grd_customers.CurrentRow.Cells[4].Value.ToString();
            uCustomer.ShowDialog();

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
