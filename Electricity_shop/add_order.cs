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
    public partial class add_order : Form
    {
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        private DBSQL mySQL;

        AutoCompleteStringCollection idAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection lastNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection addressAuto = new AutoCompleteStringCollection();


        public add_order()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            set_AutoCompleteMode_text_boxes();


        }


        private void set_AutoCompleteMode_text_boxes()
        {
            id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            id.AutoCompleteSource = AutoCompleteSource.CustomSource;

            firstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            firstName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            lastName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lastName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            address.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            address.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void button3_Click(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }



        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

       

        private void new_customer(customer cust)
        {
            cust.Id = id.Text;
            cust.First_name = firstName.Text;
            cust.Last_name = lastName.Text;
            cust.Phone_number = phoneNumber.Text;
            cust.Address = address.Text;
            mySQL.InsertCustomer(cust);
            MessageBox.Show("לקוח חדש ,עובר לבחירת מוצרים");

            orders Orders = new orders();
            Orders.Customer_id = id.Text;
            Orders.Date = dateTimePicker.Text;
            Orders.Status = Convert.ToInt32(delivery.Checked);
            mySQL.InsertOrder(Orders);
        }

        private void same_customer(customer cust)
        {
            orders Orders = new orders();
            Orders.Customer_id = id.Text;
            Orders.Date = dateTimePicker.Text;
            Orders.Status = Convert.ToInt32(delivery.Checked);
            mySQL.InsertOrder(Orders);
            MessageBox.Show("לקוח קיים ,עובר לבחירת מוצרים");
        }

        private void openProductCartManu(object obj)
        {
            Application.Run(new cart_product_manu());
        }

        private void OK_Click(object sender, EventArgs e)
        {
            bool same = false;

            if (id.Text != "" && firstName.Text != "" && lastName.Text != "" && phoneNumber.Text != "" && address.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                customer Cust = new customer();
                string idTmp = id.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {
                        same = true;

                    }

                }

                if (same)
                {
                    same_customer(Cust);
                    read_only_false();
                }
                else
                {
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

            private void add_order_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();


            for (int i = 0; i < Customer.Length; i++)
            {
                idAuto.Add(Customer[i].Id);
                firstNameAuto.Add(Customer[i].First_name);
                lastNameAuto.Add(Customer[i].Last_name);
                addressAuto.Add(Customer[i].Address);


            }
            id.AutoCompleteCustomSource = idAuto;
            firstName.AutoCompleteCustomSource = firstNameAuto;
            lastName.AutoCompleteCustomSource = lastNameAuto;
            address.AutoCompleteCustomSource = addressAuto;
        }

        private void id_Leave(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                string idTmp = id.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {


                        id.Text = Customer[i].Id.ToString();
                        firstName.Text = Customer[i].First_name;
                        lastName.Text = Customer[i].Last_name;
                        address.Text = Customer[i].Address;
                        phoneNumber.Text = Customer[i].Phone_number;

                        MessageBox.Show("לקוח קיים");
                        read_only_true();

                    }

                }
            }
        }

        private void read_only_true()
        {
            id.ReadOnly = true;
            firstName.ReadOnly = true;
            lastName.ReadOnly = true;
            phoneNumber.ReadOnly = true;
            address.ReadOnly = true;
        }

        private void read_only_false()
        {
            id.ReadOnly = false;
            firstName.ReadOnly = false;
            lastName.ReadOnly = false;
            phoneNumber.ReadOnly = false;
            address.ReadOnly = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            id.Text = string.Empty;
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            phoneNumber.Text = string.Empty;
            address.Text = string.Empty;
            read_only_false();
        }

       
    }
}
