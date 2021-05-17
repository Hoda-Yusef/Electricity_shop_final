using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            update_supplier supplier = new update_supplier();
            supplier.Show();
        }
    }
}
