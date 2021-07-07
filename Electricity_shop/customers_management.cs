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
    public partial class FrmCustomers_management : Form
    {
        private readonly DBSQL mySQL;
        Thread th;
        customer[] Customer;
        readonly AutoCompleteStringCollection IdAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection firstNameAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection phoneNumberAuto = new AutoCompleteStringCollection();
        /*
        AutoCompleteStringCollection lastNameAuto = new AutoCompleteStringCollection();
        AutoCompleteStringCollection addressAuto = new AutoCompleteStringCollection();
        */
        public FrmCustomers_management()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        }

        private void Fill_grid_by_Id()
        {

            Customer = mySQL.GetCustomerDataById2(Txt_customerId.Text);

            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;

        }

        private void Fill_grid_by_firstName()
        {
            Customer = mySQL.GetCustomerDataByFN(Txt_firstName.Text);
            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;
        }


        private void Fill_grid_by_phoneN()
        {
            Customer = mySQL.GetCustomerDataByphoneN(Txt_phoneNumber.Text);
            Fill_grid(Customer);
            if (Grd_customers.Rows.Count != 0)
                Grd_customers.Rows[0].Cells[0].Selected = false;
        }

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

        private void OpenMain(object obj)
        {
            Application.Run(new main());
        }

        private void Btn_toMain_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void FrmCustomers_management_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();
            for(int i=0;i<Customer.Length;i++)
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

            for (int i= 0;i<Customer.Length;i++)
            {
                IdAuto.Add(Customer[i].Id.ToString());  
                firstNameAuto.Add(Customer[i].First_name.ToString());
                phoneNumberAuto.Add(Customer[i].Phone_number.ToString());
            }

            Txt_customerId.AutoCompleteCustomSource = IdAuto;
            Txt_firstName.AutoCompleteCustomSource = firstNameAuto;
            Txt_phoneNumber.AutoCompleteCustomSource = phoneNumberAuto;
        }

        private void Txt_customerId_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_Id();
        }
       
        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        
        private void Txt_firstName_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_firstName();
        }
        
        private void Txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only characters are welcomed :)
            char ch = e.KeyChar;

            if (char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only digits are welcomed :)
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        
        private void Txt_phoneNumber_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_phoneN();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Frm_update_customer uCustomer = new Frm_update_customer();
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

        private void OpenSelf(object obj)
        {
            Application.Run(new FrmCustomers_management());
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
