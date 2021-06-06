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
    public partial class customers_management : Form
    {
        private DBSQL mySQL;
        Thread th;
        customer[] Customer;

        AutoCompleteStringCollection IdAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection phoneNumberAuto = new AutoCompleteStringCollection();
        /*
        AutoCompleteStringCollection lastNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection addressAuto = new AutoCompleteStringCollection();
        */
        public customers_management()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        }

        private void fill_grid_by_Id()
        {

            Customer = mySQL.GetCustomerDataById2(Id.Text);

            fill_grid(Customer);
            if (customers_grid.Rows.Count != 0)
                customers_grid.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_firstName()
        {
            Customer = mySQL.GetCustomerDataByFN(firstName.Text);
            fill_grid(Customer);
            if (customers_grid.Rows.Count != 0)
                customers_grid.Rows[0].Cells[0].Selected = false;
        }


        private void fill_grid_by_phoneN()
        {
            Customer = mySQL.GetCustomerDataByphoneN(phoneNumber.Text);
            fill_grid(Customer);
            if (customers_grid.Rows.Count != 0)
                customers_grid.Rows[0].Cells[0].Selected = false;
        }

        private void fill_grid(customer[] Customer)
        {
            customers_grid.Rows.Clear();
            if (Customer != null)
            {
                for (int i = 0; i < Customer.Length; i++)
                {
                    customers_grid.Rows.Add(new object[]
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
                customers_grid.Rows.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void customers_management_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();
            for(int i=0;i<Customer.Length;i++)
            {
                customers_grid.Rows.Add(new object[]
                    {
                        Customer[i].Id,
                        Customer[i].First_name,
                        Customer[i].Last_name,
                        Customer[i].Phone_number,
                        Customer[i].Address
                    });
            }

            for (int i= 0;i<Customer.Length;i++)
            {
                IdAuto.Add(Customer[i].Id.ToString());  
                firstNameAuto.Add(Customer[i].First_name.ToString());
                phoneNumberAuto.Add(Customer[i].Phone_number.ToString());
            }

            Id.AutoCompleteCustomSource = IdAuto;
            firstName.AutoCompleteCustomSource = firstNameAuto;
            phoneNumber.AutoCompleteCustomSource = phoneNumberAuto;
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_Id();
        }
       
        private void Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        
        private void firstName_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_firstName();
        }
        
        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        
        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_phoneN();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_customer uCustomer = new update_customer();
            uCustomer.id.Text= customers_grid.CurrentRow.Cells[0].Value.ToString();
            uCustomer.first_name.Text = customers_grid.CurrentRow.Cells[1].Value.ToString();
            uCustomer.last_name.Text = customers_grid.CurrentRow.Cells[2].Value.ToString();
            uCustomer.phone_number.Text = customers_grid.CurrentRow.Cells[3].Value.ToString();
            uCustomer.address.Text = customers_grid.CurrentRow.Cells[4].Value.ToString();
            uCustomer.ShowDialog();

            this.Close();
            th = new Thread(openSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openSelf(object obj)
        {
            Application.Run(new customers_management());
        }
    }
}
