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
    public partial class Frm_ordersManagement : Form
    {
        private DBSQL mySQL;
        bool drag = false;
        Point sp = new Point(0, 0);
        orders Orders;
        string order_number_holder;
        orders_customers[] Orders_customers;
        bool date_changed = false;




        public Frm_ordersManagement()
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

       

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openMain(object obj)
        {
            Application.Run(new Frm_main());
        }

        private void Upper_BluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void Upper_BluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void Upper_BluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        private void Btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void Btn_backToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th;
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Frm_ordersManagement_Load(object sender, EventArgs e)
        {
            orders[] Orders = mySQL.GetOrdersData();
            customer Customer;
            if(Orders!=null)
            for(int i=0;i<Orders.Length;i++)
            {
              Customer=  mySQL.GetCustomerDataByID(Orders[i].Customer_id);

                Grd_orders.Rows.Add(new object[]
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

        private void Btn_updateStatus_Click(object sender, EventArgs e)//עדכון סטטוס
        {
            Orders = mySQL.GetOrdersDataByOrderNumber(Grd_orders.CurrentRow.Cells[0].Value.ToString());

            if(Orders.Status ==1)//משנים את הסטטוס לסופק
            {
                mySQL.UpdateOrderByOrderNumber(Orders.Order_number.ToString(), 0);
                this.Close();
                Thread th;
                th = new Thread(openSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

            if (Orders.Status == 0)//משנים את הסטטוס ללא סופק
            {
                mySQL.UpdateOrderByOrderNumber(Orders.Order_number.ToString(), 1);
                this.Close();
                Thread th;
                th = new Thread(openSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();

            }
        }

        private void openSelf(object obj)
        {
            Application.Run(new Frm_ordersManagement());
        }

        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date_changed = true;
            Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);
            fill_grid(Orders_customers);
        }

        private void Txt_customersLastName_TextChanged(object sender, EventArgs e)
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }

        private void fill_grid_by_last_name()
        {
            Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

            fill_grid(Orders_customers);
        }

        private void Txt_customersFirstName_TextChanged(object sender, EventArgs e)
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }

       
        private void Txt_customerId_TextChanged(object sender, EventArgs e)
        {
            if(date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
            
        }

        

        private void fill_grid(orders_customers[] Orders_customers)
        {
            Grd_orders.Rows.Clear();
            if (Orders_customers != null)
            {
                for (int i = 0; i < Orders_customers.Length; i++)
                {
                    Grd_orders.Rows.Add(new object[]
                    {
                    Orders_customers[i].Order_number,
                    Orders_customers[i].Customer_id,
                    Orders_customers[i].First_name,
                    Orders_customers[i].Last_name,
                    Orders_customers[i].Phone_number,
                    Orders_customers[i].Address,
                    Orders_customers[i].Date,
                    Orders_customers[i].Status==1?imageList1.Images[1]:imageList1.Images[0]

                    });
                }
            }
            else
                Grd_orders.Rows.Clear();
        }

        private void Btn_showOrder_Click(object sender, EventArgs e)
        {
            Frm_productsList Show_order = new Frm_productsList();

            Show_order.Lbl_showOrderNumber.Text = Grd_orders.CurrentRow.Cells[0].Value.ToString();
            Show_order.ShowDialog();
        }

        private void Btn_updateOrder_Click(object sender, EventArgs e)
        {
            //update_order update_Order = new update_order();

            //update_Order.show_order_number.Text = orders_grid.CurrentRow.Cells[0].Value.ToString();
            //update_Order.ShowDialog();

             mySQL.InsertOrderNumberHolder(Grd_orders.CurrentRow.Cells[0].Value.ToString());
            order_number_holder=Grd_orders.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            Thread th;
            th = new Thread(openUpdateOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openUpdateOrder(object obj)
        {

            Application.Run(new Frm_updateOrder(order_number_holder));


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Txt_customerId.Text = string.Empty;
            Txt_customersFirstName.Text = string.Empty;
            Txt_customersLastName.Text = string.Empty;
            date_changed = false;
            /*
            this.Close();
            Thread th;
            th = new Thread(openSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();*/

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
