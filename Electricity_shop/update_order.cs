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
    public partial class update_order : Form
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
        public update_order()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
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

        private void update_order_Load(object sender, EventArgs e)
        {
            int Total_price = 0, total_amount = 0;

            ONH = mySQL.GetorderNumberHolder();
            show_order_number.Text = ONH.Order_number.ToString();

            Orderss = mySQL.GetOrdersDataByOrderNumber(ONH.Order_number.ToString());

            product_order[] Product_order = mySQL.GetProduct_orderDataByOrderNumber(ONH.Order_number.ToString());

            if (Product_order != null)
            {
                for (int i = 0; i < Product_order.Length; i++)
                {
                    Product Product = mySQL.GetProductDataBySerialNumber(Product_order[i].Product_serial_number.ToString());

                    product_grid.Rows.Add(new object[]
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
                    Total_price += Convert.ToInt32(Product.Selling_price);
                }
            }
            else
                MessageBox.Show("אין מוצרים להזמנה");
            if (order_status != null)
            {
                if (Orderss.Status == 1)
                    order_status.Text = "לא סופק";
                if (Orderss.Status == 0)
                    order_status.Text = "סופק";
            }

            products_count.Text = product_grid.Rows.Count.ToString();
            total_sum_products.Text = total_amount.ToString();
            total_price.Text = Total_price.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
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
            Application.Run(new orders_management());
        }

        private void order_status_Format(object sender, ListControlConvertEventArgs e)
        {
            //מגדירים צבע כתב תלוי בסטטוס
            if (order_status.Text == "לא סופק")
                order_status.ForeColor = Color.Orange;

            if (order_status.Text == "סופק")
                order_status.ForeColor = Color.FromArgb(0,255,0);

        }

        private void remove_Click(object sender, EventArgs e)
        {
            Orderss = mySQL.GetOrdersDataByOrderNumber(Orderss.Order_number.ToString());//שולפים מידע להזמנה נוכחית

            if (Orderss.Status == 1)//בודק אם ההזמנה לא סופקה אז אפשר להסיר מוצרים
            {

                if (product_grid.Rows.Count != 0)//אם הטבלה לא ריקה
                {
                    Product Product = mySQL.GetProductDataByBarcode(product_grid.CurrentRow.Cells[0].Value.ToString());//מקבל מפרט של מוצר לפי ברקוד

                    mySQL.deleteProductFromProduct_cartByOrderNumberAndProductSerial(Product.Product_serial_number.ToString(), show_order_number.Text);//מסירים את המוצר הנבחר מההזמנה

                    if (Orderss.Status == 1)//בודקים אם ההזמנה במצב לא סופק אז ניתן להחזיר כמות למוצר קיים
                    {
                        int sum = Product.Amount + Convert.ToInt32(product_grid.CurrentRow.Cells[5].Value);//מחבר הכמות של המוצר שהוסר למוצר הקיים 
                        mySQL.UpdateProductAmountByBarcode(sum, Product.Barcode);//מוסיפים את כמות של המוצר שהוסר לכמות של המוצר הקיים במערכת
                    }

                    this.Close();
                    Thread th;
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
            Application.Run(new update_order());
        }

        private void add_to_cart_Click(object sender, EventArgs e)
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
            Application.Run(new add_products_to_order());
        }

        private void UPDATE_Click(object sender, EventArgs e)//לחיצה על עדכן מעדכן הסטטוס של ההזמנה
        {
            Orderss = mySQL.GetOrdersDataByOrderNumber(ONH.Order_number.ToString());
            if (order_status != null)
            {
                if (order_status.Text == "לא סופק")
                {
                    mySQL.UpdateOrderById(Orderss.Customer_id, 1);
                }

                if(order_status.Text=="סופק")
                {
                    mySQL.UpdateOrderById(Orderss.Customer_id, 0);
                }
            }

            mySQL.clearOrderNumberHolder();

            Thread th;
            this.Close();
            th = new Thread(OpenOrderManagement);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenOrderManagement(object obj)
        {
            Application.Run(new orders_management());
        }

        private void product_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;

            Product_order = mySQL.GetProduct_orderDataByOrderNumber(ONH.Order_number.ToString());
            Product = mySQL.GetProductDataByBarcode(product_grid.CurrentRow.Cells[0].Value.ToString());

            for(int i=0;i<Product_order.Length;i++)
            {
                if(Product_order[i].Product_serial_number == Product.Product_serial_number)
                {
                    if((Product.Amount+previosAmount)-Convert.ToInt32(product_grid.CurrentRow.Cells[5].Value)>=0)
                    {
                        sum += (Product.Amount + previosAmount) - Convert.ToInt32(product_grid.CurrentRow.Cells[5].Value);
                        mySQL.UpdateProduct_orderAmount(Product.Product_serial_number.ToString(),ONH.Order_number.ToString(), Convert.ToInt32(product_grid.CurrentRow.Cells[5].Value));
                        mySQL.UpdateProductAmountByBarcode(sum, Product.Barcode);

                        MessageBox.Show("כמות עודכנה");

                    }
                    else
                        MessageBox.Show("לא מספיק מלאי לכמות המבוקשת");
                }
            }
        }

        private void product_grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            previosAmount = Convert.ToInt32(product_grid.CurrentRow.Cells[5].Value);
        }
    }


}
