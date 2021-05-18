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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openOrderManagement(object obj)
        {
            Application.Run(new orders_management());
        }

        private void entry_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openProductManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openProductManagement(object obj)
        {
            Application.Run(new products_management());
            //throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Thread th;
            this.Close();
            th = new Thread(openProductAdd);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
           
        }

        private void openProductAdd(object obj)
        {
            Application.Run(new add_product());
            //throw new NotImplementedException();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openAddSupplier);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddSupplier(object obj)
        {
            Application.Run(new add_supplier());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openCustomeMmanagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openCustomeMmanagement(object obj)
        {
            Application.Run(new customers_management());
        }

        private void openAddCustomer(object obj)
        {
            Application.Run(new add_customer());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openSupplierManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSupplierManagement(object obj)
        {
            Application.Run(new suppliers_management());
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openAddCustomer);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        
    }
}
