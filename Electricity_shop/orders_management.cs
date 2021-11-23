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
        orders_customers[] relevant_orders;
        orders[] OrdersFromContainer;
        bool date_changed = false;
        int usersRole;
        string userName;
        int from_containerData = 0;
        string fromDate = string.Empty;
        string toDate = string.Empty;
        string containerPath = string.Empty;
        int biggestOrderNumber = -1;
        orders_customers biggestOrder;

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

        public Frm_ordersManagement(int role, string username,int orderNumber,int formContainer)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
            biggestOrderNumber = orderNumber;
            from_containerData = formContainer;
        }

        public Frm_ordersManagement(int role, string username,
            int from_containerData,string fromDate,string toDate,string path)
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
            this.containerPath = path;
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
                {
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
            }
            else
            {
                if (biggestOrderNumber == -1)
                {
                    relevant_orders = mySQL.GetOrdersRelevantData(containerPath, fromDate, toDate);
                    customer Customer;
                    if (Orders_customers != null && relevant_orders !=null)
                    {
                        Grd_orders.Rows.Clear();

                        for (int i = 0; i < relevant_orders.Length; i++)
                        {
                            Customer = mySQL.GetCustomerDataByID(relevant_orders[i].Customer_id);

                            Grd_orders.Rows.Add(new object[]
                            {
                    relevant_orders[i].Order_number,
                    Customer.Id,
                    Customer.First_name,
                    Customer.Last_name,
                    Customer.Phone_number,
                    Customer.Address,
                    relevant_orders[i].Date,
                    relevant_orders[i].Status==1?imageList1.Images[1]:imageList1.Images[0]
                                }); ;
                        }
                    }
                }
                else
                {
                    biggestOrder = mySQL.GetBiggestOrderData(biggestOrderNumber);
                    if (biggestOrder != null)
                    {
                        Grd_orders.Rows.Clear();

                        Grd_orders.Rows.Add(new object[]
                        {
                    biggestOrder.Order_number,
                    biggestOrder.Customer_id,
                    biggestOrder.First_name,
                    biggestOrder.Last_name,
                    biggestOrder.Phone_number,
                    biggestOrder.Address,
                    biggestOrder.Date,
                    biggestOrder.Status==1?imageList1.Images[1]:imageList1.Images[0]
                            });
                    }
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
           
            else
            {
                MessageBox.Show("הזמנה סופקה , אין לבצע שינויים");
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

        //מסנן את הטבלה לפי שם משפחה
        private void Txt_customersLastName_TextChanged(object sender, EventArgs e)
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

        //אירוע לחיצה כפולה על השורה
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

        //אין להזין דבר
        private void Cbo_sortByOrderStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //אירוע לבחירה אינדיקס בשורה
        private void Cbo_sortByOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Orders_customers = mySQL.GetOrdersDataFiltered(Cbo_sortByOrderStatus.Text,
                Txt_customerId.Text, Txt_customersFirstName.Text, Txt_customersLastName.Text, "");

            fill_grid(Orders_customers);
        }

        
    }
}
