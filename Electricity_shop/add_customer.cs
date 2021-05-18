using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }
    }
}
