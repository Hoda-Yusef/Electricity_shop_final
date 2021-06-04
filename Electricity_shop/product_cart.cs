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
    
    public partial class product_cart : Form
    {
        Thread th;
        
        public product_cart()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAddOrder(object obj)
        {
            Application.Run(new add_order());
        }

        private void add_to_cart_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openCartProductManu);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCartProductManu(object obj)
        {
            Application.Run(new cart_product_manu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
