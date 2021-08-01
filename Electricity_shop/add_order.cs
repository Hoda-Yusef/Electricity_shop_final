//Hoda Khier + Yusef Aborokon 44/5

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
    public partial class Frm_addOrder : Form
    {
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        private DBSQL mySQL;

        //מילוי אוטומטי
        AutoCompleteStringCollection idAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection lastNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection addressAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection phoneAuto = new AutoCompleteStringCollection();


        public Frm_addOrder()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            set_AutoCompleteMode_text_boxes();


        }


        private void set_AutoCompleteMode_text_boxes()//מילוי אוטומטי
        {
            Txt_customerId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_customerId.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_customersFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_customersFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_customersLastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_customersLastName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_customersAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_customersAddress.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_customersPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Txt_customersPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void Btn_exit_Click(object sender, EventArgs e)//יציאה
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main());
        }


        private void Btn_cancel_Click(object sender, EventArgs e)//ביטול
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים להזנה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים להזנה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }



        private void Upper_BluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void Upper_BluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_BluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

       

        private void new_customer(customer cust)//אם לקוח חדש 
        {
            cust.Id = Txt_customerId.Text;
            cust.First_name = Txt_customersFirstName.Text;
            cust.Last_name = Txt_customersLastName.Text;
            cust.Phone_number = Txt_customersPhoneNumber.Text;
            cust.Address = Txt_customersAddress.Text;
            mySQL.InsertCustomer(cust);//מכניס לקוח ל בסיסי נתונים
            MessageBox.Show("לקוח חדש ,עובר לבחירת מוצרים");

            orders Orders = new orders();
            Orders.Customer_id = Txt_customerId.Text;
            Orders.Date = dateTimePicker.Text;
            Orders.Status = Convert.ToInt32(delivery.Checked);
            mySQL.InsertOrder(Orders);
        }

        private void same_customer(customer cust)//אם לקוח קיים
        {
            orders Orders = new orders();
            Orders.Customer_id = Txt_customerId.Text;
            Orders.Date = dateTimePicker.Text;
            Orders.Status = Convert.ToInt32(delivery.Checked);
            mySQL.InsertOrder(Orders);//מכניס לקוח לבסיסי נתונים
            MessageBox.Show("לקוח קיים ,עובר לבחירת מוצרים");
        }

        private void openProductCartManu(object obj)
        {
            Application.Run(new Frm_cartProductMenu());
        }

        private void Btn_ok_Click(object sender, EventArgs e)//בעת לחיצה על אישור
        {
            bool same = false;

            if (Txt_customerId.Text != "" && Txt_customersFirstName.Text != "" && Txt_customersLastName.Text != "" && Txt_customersPhoneNumber.Text != "" && Txt_customersAddress.Text != "")
            {//אם אין שדות ריקות 
                customer[] Customer = mySQL.GetCustomerData();
                customer Cust = new customer();
                string idTmp = Txt_customerId.Text;

                for (int i = 0; i < Customer.Length; i++)//לולאה בודקת אם לקוח קיים
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {
                        same = true;

                    }

                }

                if (same)//אם לקוח קיים
                {
                    same_customer(Cust);
                    read_only_false();
                }
                else
                {
                    //אם לקוח חדש
                    new_customer(Cust);
                    read_only_false();

                }


                Thread th;
                this.Close();
                th = new Thread(openProductCartManu);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("נא למלא כל השדות");
        }

            private void Frm_addOrder_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();

            if (Customer != null)
            {

                for (int i = 0; i < Customer.Length; i++)
                {
                    idAuto.Add(Customer[i].Id);
                    firstNameAuto.Add(Customer[i].First_name);
                    lastNameAuto.Add(Customer[i].Last_name);
                    addressAuto.Add(Customer[i].Address);
                    phoneAuto.Add(Customer[i].Phone_number);


                }
                Txt_customerId.AutoCompleteCustomSource = idAuto;
                Txt_customersFirstName.AutoCompleteCustomSource = firstNameAuto;
                Txt_customersLastName.AutoCompleteCustomSource = lastNameAuto;
                Txt_customersAddress.AutoCompleteCustomSource = addressAuto;
                Txt_customersPhoneNumber.AutoCompleteCustomSource = phoneAuto;
            }
        }

        private void Txt_customerId_Leave(object sender, EventArgs e)//כשעוזבים את שדה התעודת זהות המערכת בודקת אם לקוח קיים אם כן ממלא של שאר השדות בפרטים של אותו לקוח
        {
            if (Txt_customerId.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                string idTmp = Txt_customerId.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {


                        Txt_customerId.Text = Customer[i].Id.ToString();
                        Txt_customersFirstName.Text = Customer[i].First_name;
                        Txt_customersLastName.Text = Customer[i].Last_name;
                        Txt_customersAddress.Text = Customer[i].Address;
                        Txt_customersPhoneNumber.Text = Customer[i].Phone_number;

                        MessageBox.Show("לקוח קיים");
                        read_only_true();

                    }

                }
            }
        }

        private void read_only_true()//נועל את השדות לקתיבה
        {
            Txt_customerId.ReadOnly = true;
            Txt_customersFirstName.ReadOnly = true;
            Txt_customersLastName.ReadOnly = true;
            Txt_customersPhoneNumber.ReadOnly = true;
            Txt_customersAddress.ReadOnly = true;
        }

        private void read_only_false()//משחרר את השדות לכתיבה
        {
            Txt_customerId.ReadOnly = false;
            Txt_customersFirstName.ReadOnly = false;
            Txt_customersLastName.ReadOnly = false;
            Txt_customersPhoneNumber.ReadOnly = false;
            Txt_customersAddress.ReadOnly = false;
        }

        private void Btn_clear_Click(object sender, EventArgs e)//ניקוי שדות
        {
            Txt_customerId.Text = string.Empty;
            Txt_customersFirstName.Text = string.Empty;
            Txt_customersLastName.Text = string.Empty;
            Txt_customersPhoneNumber.Text = string.Empty;
            Txt_customersAddress.Text = string.Empty;
            read_only_false();
        }

        private void Txt_customersPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים להזנה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Txt_customersPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (Txt_customersPhoneNumber.Text != "")
            {
                customer Customer = mySQL.GetCustomerDataByphoneN(Txt_customersPhoneNumber.Text);

                if (Customer != null)
                {

                    Txt_customerId.Text = Customer.Id.ToString();
                    Txt_customersFirstName.Text = Customer.First_name;
                    Txt_customersLastName.Text = Customer.Last_name;
                    Txt_customersAddress.Text = Customer.Address;
                    Txt_customersPhoneNumber.Text = Customer.Phone_number;

                    MessageBox.Show("לקוח קיים");
                    read_only_true();

                }  
            }
        }
    }
}
