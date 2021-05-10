using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class orders_management : Form
    {
        public orders_management()
        {
            InitializeComponent();

            for(int i=0;i<100;i++)
            {
                orders_grid.Rows.Add(new object[]{

                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
