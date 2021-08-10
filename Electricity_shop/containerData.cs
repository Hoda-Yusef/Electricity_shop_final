﻿using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;


namespace Electricity_shop
{
    public partial class Frm_ContainerData : Form
    {
        private readonly DBSQL mySQL;
        int userRole;
        string userName;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        public Frm_ContainerData(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            userRole = role;
            userName = username;
        }

        private void Btn_ordersData_Click(object sender, EventArgs e)
        {
            Lbl_title.Text = "מידע לגבי הזמנות";
            this.Pnl_container.Controls.Clear();
            Frm_ordersData orderData = new Frm_ordersData(userName) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            orderData.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_container.Controls.Add(orderData);
            orderData.Show();
        }

        private void Btn_productsData_Click(object sender, EventArgs e)
        {
            Lbl_title.Text = "מידע לגבי מוצרים";
            this.Pnl_container.Controls.Clear();
            Frm_productsData productData = new Frm_productsData() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            productData.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_container.Controls.Add(productData);
            productData.Show();
        }

        private void Btn_incomeAndOutcome_Click(object sender, EventArgs e)
        {
            Lbl_title.Text = "רווח והפסד";
            this.Pnl_container.Controls.Clear();
            Frm_incomeAndOutcome cashData = new Frm_incomeAndOutcome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            cashData.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_container.Controls.Add(cashData);
            cashData.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main(1,userName));
        }

        private void Btn_toMain_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Upper_BluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void Upper_BluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_BluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Frm_ContainerData_Load(object sender, EventArgs e)
        {
            Lbl_userName.Text = userName;
        }
    }
}
