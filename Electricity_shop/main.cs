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

        private void main_Load(object sender, EventArgs e)
        {
            
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

        
    }
}
