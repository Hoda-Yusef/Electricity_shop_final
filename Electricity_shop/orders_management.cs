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
    public partial class orders_management : Form
    {
        Thread th;
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
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void opennewform(object obj)
        {
            Application.Run(new main());
            //throw new NotImplementedException();
        }
    }
}
