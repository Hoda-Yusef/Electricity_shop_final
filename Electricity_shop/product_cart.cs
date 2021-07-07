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
    
    public partial class product_cart : Form
    {
        private DBSQL mySQL;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);

        Product Product;
        

        public product_cart()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mySQL.clearCart();
            Thread th;
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMain(object obj)
        {
            Application.Run(new Frm_main());
        }

        private void OpenAddOrder(object obj)
        {
            Application.Run(new add_order());
        }

        private void add_to_cart_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(openCartProductManu);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCartProductManu(object obj)
        {
            Application.Run(new cart_product_manu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(OpenAddOrder);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void product_cart_Load(object sender, EventArgs e)
        {
            Product[] Products = mySQL.GetProductData();
            Cart[] Cart = mySQL.getCartData();

            for(int i=0;i<Cart.Length;i++)
            {
                for(int j=0;j<Products.Length;j++)
                {
                    if(Cart[i].Product_barcode==Products[j].Barcode)
                    {
                        products_grid.Rows.Add(new object[]
                    {
                        Products[j].Barcode,
                    Products[j].Category,
                    Products[j].Manufacturer,
                    Products[j].Model,
                    Products[j].Selling_price,
                    Cart[i].Amount,
                    Products[j].Product_info,
                    
                    });
                    }
                }
            }

            statusBar();
            int num = mySQL.GetOrderMaxNumber();
            order_number.Text =num.ToString();
            
            
        }

        private void statusBar()//מידע שמוצג בעגלה ...מספר מוצרים וגם הסכום של המוצרים 
        {
            int sum=0,sum_products=0;

            products_count.Text = products_grid.Rows.Count.ToString();

            for(int i=0;i<products_grid.Rows.Count;i++)
            {
                sum += Convert.ToInt32(products_grid.Rows[i].Cells[4].Value.ToString());
                sum_products += Convert.ToInt32(products_grid.Rows[i].Cells[5].Value.ToString());
            }
            total.Text = sum.ToString();
            total_sum_products.Text = sum_products.ToString();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string item = products_grid.CurrentRow.Cells[0].Value.ToString();//מסיר מוצר מעגלה
            mySQL.deleteItemFromCart(item);

            Thread th;
            this.Close();
            th = new Thread(openCartProduct);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void openCartProduct(object obj)
        {
            Application.Run(new product_cart());
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void OK_Click(object sender, EventArgs e)//לחיצה על אישור
        {
            bool outOfStock = false; 

            for(int i=0;i<products_grid.Rows.Count;i++)
            {
               Product= mySQL.GetProductDataByBarcode(products_grid.Rows[i].Cells[0].Value.ToString());//  שליפת מידע של מוצרים לפי ברקוד הנמצא בעגלה

                int general_amount = Convert.ToInt32(Product.Amount);//לוקח כמות כללית מטבלת מוצרים
                int cart_amount= Convert.ToInt32(products_grid.Rows[i].Cells[5].Value.ToString());//לוקח את הכמות של מוצר שנמצא בעגלה


                if ((general_amount - cart_amount) < 0)//בודק אם ניתן לבצע הזמנה לפי הכמות הנדרשת מול הכמות הכללית של מוצר
                {
                    MessageBox.Show("לא מספיק מלאי לכמות הנדרשת למוצר בעל ברקוד  "+ Product.Barcode.ToString());//אם אין מספיק מלאי לכמות הנדרשת בעגלה מציג הודעה
                    outOfStock = true;
                }
            }

            if(!outOfStock)//אם יש מלאי לכל המוצרים בעגלה
            {
                for(int i=0;i<products_grid.Rows.Count;i++)//עובר על כל השורות בטבלת המוצרים בעגלה
                {
                    Product = mySQL.GetProductDataByBarcode(products_grid.Rows[i].Cells[0].Value.ToString());//שליפת מידע על מוצר לפי ברקוד

                    mySQL.InsertToProductOrder(Product.Product_serial_number,Convert.ToInt32(order_number.Text),
                        Convert.ToInt32(products_grid.Rows[i].Cells[5].Value));//מוסיפים את מספר הזמנה ומספר סידורי של מוצר וכמות לטבלה מקשרת

                    mySQL.UpdateProductAmountByBarcode(Product.Amount - Convert.ToInt32(products_grid.Rows[i].Cells[5].Value) , Product.Barcode);//מעדכנים את הכמות של מוצרים במלאי בהתאם
                }
                MessageBox.Show("הזמנה התווספה בהצלחה");
                mySQL.clearCart();//מרקנים את ההעגלה

                Thread th;
                this.Close();
                th = new Thread(openMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();

            }

            
        }

        private void products_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)//שיטה שמעדכנת את הכמות של מוצר בתוך העגלה
        {
            mySQL.UpdateCartAmount(Convert.ToInt32(products_grid.CurrentRow.Cells[5].Value),products_grid.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show("כמות עודכנה");
        }

        
    }
}
