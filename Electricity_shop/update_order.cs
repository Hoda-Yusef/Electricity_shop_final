﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class update_order : Form
    {
        orders_management or = new orders_management();
        public update_order()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }
    }


}