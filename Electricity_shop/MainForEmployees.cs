using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה מציגה חלון העובד הראשי של המערכת 

    public partial class Frm_mainForEmployees : Form
    {
        private int mostSailedProductCounter = 0;
        private readonly DBSQL mySQL;
        bool drag = false;
        Point sp = new Point(0, 0);
        orders[] Orders;
        customer[] Customers;
        int userRole;
        string userName;
        public Frm_mainForEmployees(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            userRole = role;
            userName = username;
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void Upper_panel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void Upper_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void Upper_panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //בעת לחיצה על יציאה
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //שינוי צבע
        private void Btn_exit_MouseHover(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        //שינוי צבע
        private void Btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }

        //לחיצה על כפתור ניהול מוצרים
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
            Application.Run(new Frm_products_management(userRole,userName));

        }

        //לחיצה על כפתור הוספת מוצר
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
            Application.Run(new Frm_addProduct(userRole,userName));

        }

        //לחיצה על כפתור ניהול לקוחות
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
            Application.Run(new FrmCustomers_management(userRole,userName));
        }

        private void OpenAddCustomer(object obj)
        {
            Application.Run(new Frm_addCustomer(userRole,userName));
        }

        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddCustomer);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //לחיצה על כפתור ניהול ספקים
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
            Application.Run(new Frm_suppliersManagement(userRole,userName));
        }

        //לחיצה על כפתור הוספת ספק
        private void Btn_addSupplier_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddSupplier);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //לחיצה על כפתור הוספת ספק
        private void OpenAddSupplier(object obj)
        {
            Application.Run(new Frm_addSupplier(userRole,userName));
        }

        //לחיצה על כפתור ניהול הזמנות
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
            Application.Run(new Frm_ordersManagement(userRole,userName));
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
            Application.Run(new Frm_addOrder(userRole,userName));
        }

        //בעת הפתיחה החלון נטען בנתונים שונים
        private void Frm_mainForEmployees_Load(object sender, EventArgs e)
        {
            int count = 0;
            int countMany = 0;
            displayData();
            
            Orders = mySQL.GetOrdersData();
            Customers = mySQL.GetCustomerData();

            if (Orders != null && Customers != null)
            {
                for (int i = 0; i < Customers.Length; i++)
                {
                    for (int j = 0; j < Orders.Length; j++)
                    {
                        if (Customers[i].Id == Orders[j].Customer_id)
                        {
                            count++;
                        }
                    }
                    if (count > 3)
                    {
                        countMany++;
                    }
                    count = 0;
                }
            }
            Lbl_active_customers_number.Text = countMany.ToString();
        }

        //הצגת מידע בחלון ראשי
        private void displayData()
        {
            Lbl_out_of_stock_number.Text = mySQL.countOutStockProducts().ToString();

            Lbl_about_to_end_number.Text = mySQL.countAboutToEnd().ToString();

            Lbl_customers_number.Text = mySQL.countCustomers().ToString();

            Lbl_suppliers_number.Text = mySQL.countSupplies().ToString();

            Lbl_orders_wait_number.Text = mySQL.countWaitingOrders().ToString();
        }

        //אירוע לחיצה על אזל מהמלאי
        private void Lbl_out_of_stock_Click(object sender, EventArgs e)
        {
            Frm_products_management Fpm = new Frm_products_management(userRole, userName);

            Fpm.Cbo_sortByProductAmount.Text = "לא זמין במלאי";

            Fpm.ShowDialog();
            this.Close();
        }

        //אירוע לחיצה על אזל מהמלאי
        private void Lbl_out_of_stock_number_Click(object sender, EventArgs e)
        {
            Frm_products_management Fpm = new Frm_products_management(userRole, userName);

            Fpm.Cbo_sortByProductAmount.Text = "לא זמין במלאי";

            Fpm.ShowDialog();
            this.Close();
        }

        //אירוע לחיצה על עומד להיגמר מהמלאי
        private void Lbl_about_to_end_Click(object sender, EventArgs e)
        {
            Frm_products_management Fpm = new Frm_products_management(userRole, userName);

            Fpm.Cbo_sortByProductAmount.Text = "עומד להיגמר מהמלאי";

            Fpm.ShowDialog();
            this.Close();
        }

        //אירוע לחיצה על עומד להיגמר מהמלאי
        private void Lbl_about_to_end_number_Click(object sender, EventArgs e)
        {
            Frm_products_management Fpm = new Frm_products_management(userRole, userName);

            Fpm.Cbo_sortByProductAmount.Text = "עומד להיגמר מהמלאי";

            Fpm.ShowDialog();
            this.Close();
        }

        //אירוע לחיצה על הזמנות לא סופקו
        private void Lbl_orders_wait_Click(object sender, EventArgs e)
        {
            Frm_ordersManagement Fom = new Frm_ordersManagement(userRole, userName);

            Fom.Cbo_sortByOrderStatus.Text = "לא סופק";

            Fom.ShowDialog();
            this.Close();
        }

        //אירוע לחיצה על הזמנות לא סופקו
        private void Lbl_orders_wait_number_Click(object sender, EventArgs e)
        {
            Frm_ordersManagement Fom = new Frm_ordersManagement(userRole, userName);

            Fom.Cbo_sortByOrderStatus.Text = "לא סופק";

            Fom.ShowDialog();
            this.Close();
        }
    }
}
