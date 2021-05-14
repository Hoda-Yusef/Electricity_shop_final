using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void products_Load(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
