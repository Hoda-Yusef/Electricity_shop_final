﻿using System;
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

        bool drag = false;
        Point sp = new Point(0, 0);

        public main()
        {
            InitializeComponent();
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
            this.Close();
            Thread th;
            th = new Thread(openOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openOrderManagement(object obj)
        {
            Application.Run(new orders_management());
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
            Application.Run(new Frm_products_management());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Thread th;
            this.Close();
            th = new Thread(openProductAdd);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
           
        }

        private void openProductAdd(object obj)
        {
            Application.Run(new Frm_addProduct());
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openAddSupplier);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddSupplier(object obj)
        {
            Application.Run(new add_supplier());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openCustomeMmanagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openCustomeMmanagement(object obj)
        {
            Application.Run(new FrmCustomers_management());
        }

        private void openAddCustomer(object obj)
        {
            Application.Run(new Frm_addCustomer());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openSupplierManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSupplierManagement(object obj)
        {
            Application.Run(new suppliers_management());
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openAddCustomer);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void make_order_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openAddOorder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAddOorder(object obj)
        {
            Application.Run(new add_order());
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
