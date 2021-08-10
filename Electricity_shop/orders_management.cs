//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
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
        int usersRole;
        string userName;


        public Frm_ordersManagement(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;

        }


        //private void Btn_exit_Click(object sender, EventArgs e)//יציאה
        //{
        //    if (usersRole == 1)
        //    {
        //        this.Close();
        //        Thread th;
        //        th = new Thread(openMain);
        //        th.TrySetApartmentState(ApartmentState.STA);
        //        th.Start();
        //    }
        //    else
        //    {
        //        this.Close();
        //        Thread th;
        //        th = new Thread(openEmployeesMain);
        //        th.TrySetApartmentState(ApartmentState.STA);
        //        th.Start();
        //    }
        //}

        private void openMain(object obj)
        {
            Application.Run(new Frm_main(usersRole,userName));//חזרה לחלון ראשי
        }
        private void openEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole,userName));//חזרה לחלון ראשי
        }

        //פאנל להזזת חלון
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

        //פנל להזזת חלון
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

        private void Btn_backToMain_Click(object sender, EventArgs e)//יציאה לחלון ראשי
        {
            if (usersRole == 1)
            {
                this.Close();
                Thread th;
                th = new Thread(openMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                Thread th;
                th = new Thread(openEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Frm_ordersManagement_Load(object sender, EventArgs e)//בעת פתיחת חלון טוען את הטבלה הזמנות מבסיס נתונים
        {
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

            customer Customer;
            if (Orders_customers != null)

                Grd_orders.Rows.Clear();

                for (int i = 0; i < Orders_customers.Length; i++)
                {
                    Customer = mySQL.GetCustomerDataByID(Orders_customers[i].Customer_id);

                    Grd_orders.Rows.Add(new object[]
                    {
                    Orders_customers[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    Orders_customers[i].Date,
                    Orders_customers[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                        }); ;


                }
        }

        private void Btn_updateStatus_Click(object sender, EventArgs e)//עדכון סטטוס
        {
            Orders = mySQL.GetOrdersDataByOrderNumber(Grd_orders.CurrentRow.Cells[0].Value.ToString());

            if (Orders.Status == 1)//משנים את הסטטוס לסופק
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
            Application.Run(new Frm_ordersManagement(usersRole,userName));
        }

        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים להזנה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)//מסנון את הטבלה לפי הגדרת התאריך
        {
            date_changed = true;
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);
            fill_grid(Orders_customers);
        }

        private void Txt_customersLastName_TextChanged(object sender, EventArgs e)//מסנן את הטבלה לפי שם משפחה
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }


        private void Txt_customersFirstName_TextChanged(object sender, EventArgs e)//מסנן טבלה לפי שם פרטי
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }


        private void Txt_customerId_TextChanged(object sender, EventArgs e)//מסנן טבלה לפי תעודת זהות
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }

        }



        private void fill_grid(orders_customers[] Orders_customers)//טוען את הטבלה בפרטים חדשים לפי שדות החיפוש
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

        private void Btn_updateOrder_Click(object sender, EventArgs e)//כפתור לעידכון הזמנה
        {

            // mySQL.InsertOrderNumberHolder(Grd_orders.CurrentRow.Cells[0].Value.ToString());
            order_number_holder = Grd_orders.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            Thread th;
            th = new Thread(openUpdateOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openUpdateOrder(object obj)
        {

            Application.Run(new Frm_updateOrder(order_number_holder, usersRole,userName));//פתחית חלון עידכון של הזמנה


        }

        private void BtnClear_Click(object sender, EventArgs e)//ניקוי שדות
        {
            if (!date_changed)
            {
                Txt_customerId.Text = string.Empty;
                Txt_customersFirstName.Text = string.Empty;
                Txt_customersLastName.Text = string.Empty;
                date_changed = false;
            }
            else
            {
                this.Close();
                Thread th;
                th = new Thread(openSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }

        private void Grd_orders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Frm_productsList Show_order = new Frm_productsList(usersRole);

            Show_order.Lbl_showOrderNumber.Text = Grd_orders.CurrentRow.Cells[0].Value.ToString();
            Show_order.ShowDialog();
        }

        private void Btn_leave_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                Thread th;
                th = new Thread(openMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                Thread th;
                th = new Thread(openEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Cbo_sortByOrderStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cbo_sortByOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text, Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

            fill_grid(Orders_customers);
        }

        
    }
}
