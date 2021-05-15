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

            
            
                orders_grid.Rows.Add(new object[]
                {
                    "הודא",
                    "חיר",
                    "0548466521",
                    "אבו סנאן",
                    "אין",
                    "1500",
                    imageList1.Images[0]

                });

            orders_grid.Rows.Add(new object[]
                {
                    "יוסף",
                    "אבורוקן",
                    "0525487855",
                    "עיספיא",
                    "אין",
                    "2000",
                    imageList1.Images[1]

                });

            for(int i=0;i<50;i++)
            {
                orders_grid.Rows.Add(new object[]
                {
                    
                });
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orders_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
