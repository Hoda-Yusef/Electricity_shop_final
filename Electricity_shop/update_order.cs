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
    public partial class Frm_updateOrder : Form
    {
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        private DBSQL mySQL;
        orders Orderss;
        order_number_holder ONH;
        product_order[] Product_order;
        Product Product;
        int previosAmount;
        string order_number_holder;
        public Frm_updateOrder()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        public Frm_updateOrder(string order_number)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            order_number_holder = order_number;


        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Frm_updateOrder_Load(object sender, EventArgs e)
        {
            int Total_price = 0, total_amount = 0;

            Txt_show_order_number.Text = order_number_holder;

            Orderss = mySQL.GetOrdersDataByOrderNumber(order_number_holder);

            product_order[] Product_order = mySQL.GetProduct_orderDataByOrderNumber(order_number_holder);

            

            if (Product_order != null)
            {
                for (int i = 0; i < Product_order.Length; i++)
                {
                    Product Product = mySQL.GetProductDataBySerialNumber(Product_order[i].Product_serial_number.ToString());

                    Grd_allOrders.Rows.Add(new object[]
                    {
                    Product.Barcode,
                    Product.Category,
                    Product.Manufacturer,
                    Product.Model,
                    Product.Selling_price,
                    Product_order[i].Amount,
                    Product.Product_info
                    });

                    total_amount += Convert.ToInt32(Product_order[i].Amount);
                    Total_price += Convert.ToInt32(Product.Selling_price)*total_amount;
                }
            }
            else
                MessageBox.Show("אין מוצרים להזמנה");
            if (Cbo_orderStatus != null)
            {
                if (Orderss.Status == 1)
                    Cbo_orderStatus.Text = "לא סופק";
                if (Orderss.Status == 0)
                    Cbo_orderStatus.Text = "סופק";
            }

            if (Orderss.Status == 0)
                Grd_allOrders.Columns[5].ReadOnly = true;

            Lbl_showProducts_count.Text = Grd_allOrders.Rows.Count.ToString();
            Lbl_showTotalProductsAmount.Text = total_amount.ToString();
            Lbl_showingTotalPrice.Text = Total_price.ToString();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            mySQL.clearOrderNumberHolder();
            this.Close();
            Thread th;
            th = new Thread(openOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openOrderManagement(object obj)
        {
            Application.Run(new Frm_ordersManagement());
        }

        private void Cbo_orderStatus_Format(object sender, ListControlConvertEventArgs e)
        {
            //מגדירים צבע כתב תלוי בסטטוס
            if (Cbo_orderStatus.Text == "לא סופק")
                Cbo_orderStatus.ForeColor = Color.Orange;

            if (Cbo_orderStatus.Text == "סופק")
                Cbo_orderStatus.ForeColor = Color.FromArgb(0,255,0);

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            Orderss = mySQL.GetOrdersDataByOrderNumber(Orderss.Order_number.ToString());//שולפים מידע להזמנה נוכחית

            if (Orderss.Status == 1)//בודק אם ההזמנה לא סופקה אז אפשר להסיר מוצרים
            {

                if (Grd_allOrders.Rows.Count != 0)//אם הטבלה לא ריקה
                {
                    Product Product = mySQL.GetProductDataByBarcode(Grd_allOrders.CurrentRow.Cells[0].Value.ToString());//מקבל מפרט של מוצר לפי ברקוד

                    mySQL.deleteProductFromProduct_cartByOrderNumberAndProductSerial(Product.Product_serial_number.ToString(), Txt_show_order_number.Text);//מסירים את המוצר הנבחר מההזמנה

                    if (Orderss.Status == 1)//בודקים אם ההזמנה במצב לא סופק אז ניתן להחזיר כמות למוצר קיים
                    {
                        int sum = Product.Amount + Convert.ToInt32(Grd_allOrders.CurrentRow.Cells[5].Value);//מחבר הכמות של המוצר שהוסר למוצר הקיים 
                        mySQL.UpdateProductAmountByBarcode(sum, Product.Barcode);//מוסיפים את כמות של המוצר שהוסר לכמות של המוצר הקיים במערכת
                    }

                    this.Close();
                    
                    th = new Thread(openself);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
                MessageBox.Show("הזמנה סופקה , אין להסיר מוצרים");
            
                


        }

        private void openself(object obj)
        {
            Application.Run(new Frm_updateOrder(order_number_holder));
        }

        private void Btn_add_to_cart_Click(object sender, EventArgs e)
        {
            Orderss = mySQL.GetOrdersDataByOrderNumber(Orderss.Order_number.ToString());//שולפים מידע להזמנה נוכחית

            if(Orderss.Status==1)
            {
                Thread th;
                this.Close();
                th = new Thread(OpenAddProductToOrder);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("הזמנה סופקה , אין להוסיף מוצרים");
        }

        private void OpenAddProductToOrder(object obj)
        {
            Application.Run(new Frm_addProductsToOrder(order_number_holder));
        }

        private void Btn_updateOrder_Click(object sender, EventArgs e)//לחיצה על עדכן מעדכן הסטטוס של ההזמנה
        {
            Orderss = mySQL.GetOrdersDataByOrderNumber(order_number_holder);
            if (Cbo_orderStatus != null)
            {
                if (Cbo_orderStatus.Text == "לא סופק")
                {
                    mySQL.UpdateOrderByOrderNumber(Orderss.Order_number.ToString(), 1);
                }

                if(Cbo_orderStatus.Text=="סופק")
                {
                    mySQL.UpdateOrderByOrderNumber(Orderss.Order_number.ToString(), 0);
                }
            }
            Thread th;
            this.Close();
            th = new Thread(OpenOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenOrderManagement(object obj)
        {
            Application.Run(new Frm_ordersManagement());
        }

        private void Grd_allOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;

            Product_order = mySQL.GetProduct_orderDataByOrderNumber(order_number_holder);
            Product = mySQL.GetProductDataByBarcode(Grd_allOrders.CurrentRow.Cells[0].Value.ToString());

            for(int i=0;i<Product_order.Length;i++)
            {
                if(Product_order[i].Product_serial_number == Product.Product_serial_number)
                {
                    if ((Product.Amount + previosAmount) - Convert.ToInt32(Grd_allOrders.CurrentRow.Cells[5].Value) >= 0)
                    {
                        sum += (Product.Amount + previosAmount) - Convert.ToInt32(Grd_allOrders.CurrentRow.Cells[5].Value);
                        mySQL.UpdateProduct_orderAmount(Product.Product_serial_number.ToString(), order_number_holder, Convert.ToInt32(Grd_allOrders.CurrentRow.Cells[5].Value));
                        mySQL.UpdateProductAmountByBarcode(sum, Product.Barcode);

                        MessageBox.Show("כמות עודכנה");
                        
                        this.Close();
                        th = new Thread(openself);
                        th.TrySetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                    else
                    {
                        MessageBox.Show("לא מספיק מלאי לכמות המבוקשת");
                        this.Close();
                        th = new Thread(openself);
                        th.TrySetApartmentState(ApartmentState.STA);
                        th.Start();

                    }

                }
            }
        }

        private void Grd_allOrders_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            previosAmount = Convert.ToInt32(Grd_allOrders.CurrentRow.Cells[5].Value);
        }
    }


}
