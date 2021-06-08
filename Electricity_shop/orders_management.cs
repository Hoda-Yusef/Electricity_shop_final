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
    public partial class orders_management : Form
    {
        private DBSQL mySQL;
        bool drag = false;
        Point sp = new Point(0, 0);
        orders Orders;


        
        public orders_management()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        }

      


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor= Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(34, 36, 49);
        }

        

        private void orders_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void update_grid_row()
        {
           
        }

        private void update_row_Click(object sender, EventArgs e)
        {
            update_order upOr = new update_order();

            upOr.update_name.Text = orders_grid.CurrentRow.Cells[0].Value.ToString();
            upOr.update_lastName.Text = orders_grid.CurrentRow.Cells[1].Value.ToString();
            upOr.update_phone_number.Text = orders_grid.CurrentRow.Cells[2].Value.ToString();
            upOr.update_address.Text = orders_grid.CurrentRow.Cells[3].Value.ToString();
            upOr.update_total.Text = orders_grid.CurrentRow.Cells[5].Value.ToString();
            if (orders_grid.CurrentRow.Cells[6].Value.Equals(imageList1.Images[0]))
                upOr.update_status.Text = "סופק";
            else
                upOr.update_status.Text = "לא סופק";

            upOr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void orders_management_Load(object sender, EventArgs e)
        {
            orders[] Orders = mySQL.GetOrdersData();
            customer Customer;

            for(int i=0;i<Orders.Length;i++)
            {
              Customer=  mySQL.GetCustomerDataByID(Orders[i].Customer_id);

                orders_grid.Rows.Add(new object[]
                {
                    Orders[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    Orders[i].Date,
                    Orders[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                    }); ;


            }
        }

        private void update_status_Click(object sender, EventArgs e)//עדכון סטטוס
        {
            Orders = mySQL.GetOrdersDataByCustomerId(orders_grid.CurrentRow.Cells[1].Value.ToString());

            if(Orders.Status ==1)//משנים את הסטטוס לסופק
            {
                mySQL.UpdateOrderById(Orders.Customer_id, 0);
                this.Close();
                Thread th;
                th = new Thread(openSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

            if (Orders.Status == 0)//משנים את הסטטוס ללא סופק
            {
                mySQL.UpdateOrderById(Orders.Customer_id, 1);
                this.Close();
                Thread th;
                th = new Thread(openSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();

            }
        }

        private void openSelf(object obj)
        {
            Application.Run(new orders_management());
        }

        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fill_grid_by_date();
        }

        private void fill_grid_by_date()
        {
            throw new NotImplementedException();
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_last_name();
        }

        private void fill_grid_by_last_name()
        {
            throw new NotImplementedException();
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_first_name();
        }

        private void fill_grid_by_first_name()
        {
            throw new NotImplementedException();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_customer_id();
        }

        private void fill_grid_by_customer_id()
        {
            throw new NotImplementedException();
        }

        private void show_order_Click(object sender, EventArgs e)
        {
            show_products Show_order = new show_products();

            Show_order.show_order_number.Text = orders_grid.CurrentRow.Cells[0].Value.ToString();
            Show_order.ShowDialog();
        }










        //private void orders_grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //        orders_grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(0, 90, 184);
        //}

        //private void orders_grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex > -1)
        //    {
        //        orders_grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(34, 36, 70);
        //        orders_grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
        //    }
        //}
    }
}
