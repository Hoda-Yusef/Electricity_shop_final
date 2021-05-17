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
            orders_management orders = new orders_management();
            orders.Show();
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
            Application.Run(new products());
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

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            add_order order = new add_order();
            order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            add_supplier supplier1 = new add_supplier();
            supplier1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            customers customers = new customers();
            customers.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            suppliers supManage = new suppliers();
            supManage.Show();
        }
    }
}
