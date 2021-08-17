//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה לניהול ולהצגת פרטים של ההזמנות
    public partial class Frm_ordersManagement : Form
    {
        private DBSQL mySQL;
        bool drag = false;
        Point sp = new Point(0, 0);
        orders Orders;
        string order_number_holder;
        customer Customer;
        orders_customers[] Orders_customers;
        orders[] OrdersFromContainer;
        bool date_changed = false;
        int usersRole;
        string userName;
        int from_containerData = 0;
        string fromDate = string.Empty;
        string toDate = string.Empty;

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

        public Frm_ordersManagement(int role, string username,
            int from_containerData,string fromDate,string toDate)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
            this.from_containerData = from_containerData;
            this.fromDate = fromDate;
            this.toDate = toDate;

        }



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
            if (from_containerData == 0)
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
            else if (from_containerData == 1)
            {

                this.Close();
            }
        }

        //בעת פתיחת חלון טוען את הטבלה הזמנות מבסיס נתונים
        private void Frm_ordersManagement_Load(object sender, EventArgs e)
        {
            if (from_containerData == 0)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

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
            else if(from_containerData ==1)//אם נפתח מדוחות
            {
                loadFromContainer();
            }
        }

        private void loadFromContainer()
        {
            OrdersFromContainer = mySQL.GetOredrsDataByTwoDates(fromDate, toDate);

            if (Cbo_sortByOrderStatus.Text == "לא סופק")
            {
                Grd_orders.Rows.Clear();

                for (int i = 0; i < OrdersFromContainer.Length; i++)
                {
                    if (OrdersFromContainer[i].Status == 1)
                    {
                        Customer = mySQL.GetCustomerDataByID(OrdersFromContainer[i].Customer_id);

                        Grd_orders.Rows.Add(new object[]
                        {
                    OrdersFromContainer[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    OrdersFromContainer[i].Date,
                    OrdersFromContainer[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                            });
                    }
                }
            }else if(Cbo_sortByOrderStatus.Text == "סופק")
            {
                fromContainerOrdersWaiting();
            }
            else if(Cbo_sortByOrderStatus.Text == "הכל")
            {
                fromContainerAll();
            }
        }

        private void fromContainerAll()
        {
            Grd_orders.Rows.Clear();

            for (int i = 0; i < OrdersFromContainer.Length; i++)
            {
                
                    Customer = mySQL.GetCustomerDataByID(OrdersFromContainer[i].Customer_id);

                    Grd_orders.Rows.Add(new object[]
                    {
                    OrdersFromContainer[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    OrdersFromContainer[i].Date,
                    OrdersFromContainer[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                        });
                
            }
        }

        private void fromContainerOrdersWaiting()
        {
            Grd_orders.Rows.Clear();

            for (int i = 0; i < OrdersFromContainer.Length; i++)
            {
                if (OrdersFromContainer[i].Status == 0)
                {
                    Customer = mySQL.GetCustomerDataByID(OrdersFromContainer[i].Customer_id);

                    Grd_orders.Rows.Add(new object[]
                    {
                    OrdersFromContainer[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    OrdersFromContainer[i].Date,
                    OrdersFromContainer[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                        });
                }
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

        //מסנון את הטבלה לפי הגדרת התאריך
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date_changed = true;
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);
            fill_grid(Orders_customers);
        }

        private void Txt_customersLastName_TextChanged(object sender, EventArgs e)//מסנן את הטבלה לפי שם משפחה
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }


        private void Txt_customersFirstName_TextChanged(object sender, EventArgs e)//מסנן טבלה לפי שם פרטי
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

                fill_grid(Orders_customers);
            }
        }


        private void Txt_customerId_TextChanged(object sender, EventArgs e)//מסנן טבלה לפי תעודת זהות
        {
            if (date_changed)
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, dateTimePicker.Text);

                fill_grid(Orders_customers);
            }
            else
            {
                Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                    Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

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
            //פתחית חלון עידכון של הזמנה
            Application.Run(new Frm_updateOrder(order_number_holder, usersRole,userName));


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
            if (from_containerData == 0)
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
            else if(from_containerData ==1)
            {
               
                this.Close();
            }
        }

        private void Cbo_sortByOrderStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cbo_sortByOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

            fill_grid(Orders_customers);
        }

        
    }
}
