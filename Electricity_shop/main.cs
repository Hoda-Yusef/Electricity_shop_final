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
    public partial class Frm_main : Form
    {

        bool drag = false;
        Point sp = new Point(0, 0);

        public Frm_main()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Btn_exit_MouseHover_1(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        private void Btn_exit_MouseLeave_1(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void Btn_manageOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(OpenOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenOrderManagement(object obj)
        {
            Application.Run(new orders_management());
        }

        private void Btn_manageProducts_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenProductManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenProductManagement(object obj)
        {
            Application.Run(new Frm_products_management());
            
        }

        private void Btn_addProduct_Click(object sender, EventArgs e)
        {
            
            Thread th;
            this.Close();
            th = new Thread(OpenProductAdd);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
           
        }

        private void OpenProductAdd(object obj)
        {
            Application.Run(new Frm_addProduct());
            
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Btn_addSupplier_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddSupplier);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAddSupplier(object obj)
        {
            Application.Run(new Frm_addSupplier());
        }

        private void Btn_manageCustomers_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenCustomeMmanagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void OpenCustomeMmanagement(object obj)
        {
            Application.Run(new FrmCustomers_management());
        }

        private void OpenAddCustomer(object obj)
        {
            Application.Run(new Frm_addCustomer());
        }

        private void Btn_manageSuppliers_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenSupplierManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenSupplierManagement(object obj)
        {
            Application.Run(new Frm_suppliersManagement());
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {

        }

        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddCustomer);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Btn_addOrder_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddOorder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAddOorder(object obj)
        {
            Application.Run(new add_order());
        }

        private void Upper_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void Upper_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
