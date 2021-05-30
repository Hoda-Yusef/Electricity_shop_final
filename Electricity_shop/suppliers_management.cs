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
    public partial class suppliers_management : Form
    {
        public suppliers_management()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            update_supplier supplier = new update_supplier();
            supplier.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

      
    }
}
