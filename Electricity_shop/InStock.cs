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
    public partial class Frm_InStock : Form
    {
        Thread th;
        public Frm_InStock()
        {
            InitializeComponent();
        }

        private void opennewform(object obj)
        {
            Application.Run(new Frm_main());
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
