﻿//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{

    //מחלקה שמציגה את המוצרים שנמצאים בעגלה
    public partial class Frm_productsInCart : Form
    {
        private DBSQL mySQL;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        Product Product;
        int usersRole;
        string userName;
        int orderNumber;

        public Frm_productsInCart(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }
       
        private void Btn_cancel_Click(object sender, EventArgs e)//ביטול
        {
            Exitting();
        }

        private void openMain(object obj)
        {
            Application.Run(new Frm_main(usersRole, userName));
        }
        private void openEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole, userName));
        }

        private void OpenAddOrder(object obj)
        {
            Application.Run(new Frm_addOrder(usersRole, userName));
        }

        private void Btn_AddToCart_Click(object sender, EventArgs e)//כפתור הוספת מוצר
        {
            Thread th;
            this.Close();
            th = new Thread(openCartProductManu);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCartProductManu(object obj)
        {
            Application.Run(new Frm_cartProductMenu(usersRole,userName));//פותח רשימת מוצרים
        }

        //בעת פתיחת החלון מציגים את כל המוצרים בעגלה
        private void Frm_productsInCart_Load(object sender, EventArgs e)
        {
            Product[] Products = mySQL.GetProductData();
            Cart[] Cart = mySQL.getCartData();

            if (Products != null && Cart != null)
            {
                for (int i = 0; i < Cart.Length; i++)
                {
                    for (int j = 0; j < Products.Length; j++)
                    {
                        loudProductsInGrid(Products,Cart,i, j);
                        
                    }
                }
            }

            statusBar();
            int num = mySQL.GetOrderMaxNumber();
            Lbl_showOrderNumber.Text = num.ToString();


        }

        //ממלא טבלה בנתונים
        private void loudProductsInGrid(Product[] Products, Cart[] Cart, int i, int j)
        {
            if (Cart[i].Product_barcode != "" && Cart[i].Product_barcode == Products[j].Barcode)
            {
                Grd_productsList.Rows.Add(new object[]
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
            else if (Cart[i].Product_model != "" && Cart[i].Product_model == Products[j].Model)
            {
                Grd_productsList.Rows.Add(new object[]
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

        private void statusBar()//מידע שמוצג בעגלה ...מספר מוצרים וגם הסכום של המוצרים 
        {
            int sum = 0, sum_products = 0;

            Lbl_showNumberOfProducts.Text = Grd_productsList.Rows.Count.ToString();

            for (int i = 0; i < Grd_productsList.Rows.Count; i++)
            {
                sum_products += Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value.ToString());
                sum += Convert.ToInt32(Grd_productsList.Rows[i].Cells[4].Value.ToString())
                    * Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value.ToString());

            }
            Lbl_showTotalPrice.Text = sum.ToString();
            Lbl_showTotalNumberOfProducts.Text = sum_products.ToString();
        }

        //כפתור להסרה
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string itemBarcode = string.Empty;
            string itemModel = string.Empty;


            if (Grd_productsList.CurrentRow.Cells[0].Value.ToString() != "")
            {
                itemBarcode = Grd_productsList.CurrentRow.Cells[0].Value.ToString();
                mySQL.deleteItemFromCartByBarcode(itemBarcode);//מסיר מוצר מעגלה

            }
            else if (Grd_productsList.CurrentRow.Cells[3].Value.ToString() != "")
            {
                itemModel = Grd_productsList.CurrentRow.Cells[3].Value.ToString();
                mySQL.deleteItemFromCartByModel(itemModel);//מסיר מוצר מעגלה

            }

            Thread th;
            this.Close();
            th = new Thread(openCartProduct);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCartProduct(object obj)
        {
            Application.Run(new Frm_productsInCart(usersRole,userName));
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

        private void Btn_ok_Click(object sender, EventArgs e)//לחיצה על אישור
        {
            bool outOfStock = false;

            for (int i = 0; i < Grd_productsList.Rows.Count; i++)
            {
                if (Grd_productsList.Rows[i].Cells[0].Value.ToString() != "")
                    //  שליפת מידע של מוצרים לפי ברקוד הנמצא בעגלה
                    Product = mySQL.GetProductDataByBarcode(Grd_productsList.Rows[i].Cells[0].Value.ToString());
                else if (Grd_productsList.Rows[i].Cells[3].Value.ToString() != "")
                    //  שליפת מידע של מוצרים לפי דגם הנמצא בעגלה
                    Product = mySQL.GetProductDataByModel(Grd_productsList.Rows[i].Cells[3].Value.ToString());

                //לוקח כמות כללית מטבלת מוצרים
                int general_amount = Convert.ToInt32(Product.Amount);
                //לוקח את הכמות של מוצר שנמצא בעגלה
                int cart_amount = Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value.ToString());

                //בודק אם ניתן לבצע הזמנה לפי הכמות הנדרשת מול הכמות הכללית של מוצר
                if ((general_amount - cart_amount) < 0)
                {
                    //אם אין מספיק מלאי לכמות הנדרשת בעגלה מציג הודעה
                    MessageBox.Show("לא מספיק מלאי לכמות הנדרשת למוצר בעל ברקוד  " + Product.Barcode.ToString());
                    outOfStock = true;
                }
            }
            if (!outOfStock)//אם יש מלאי לכל המוצרים בעגלה
            {
                inStock();
                displayMessageAndClose();
            }
        }

        private void displayMessageAndClose()
        {
            MessageBox.Show("הזמנה התווספה בהצלחה");
            mySQL.clearCart();//מרקנים את ההעגלה

            Thread th;
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(openMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(openEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void inStock()
        {
            for (int i = 0; i < Grd_productsList.Rows.Count; i++)//עובר על כל השורות בטבלת המוצרים בעגלה
            {
                if (Grd_productsList.Rows[i].Cells[0].Value.ToString() != "")
                {
                    //שליפת מידע על מוצר לפי ברקוד
                    Product = mySQL.GetProductDataByBarcode(Grd_productsList.Rows[i].Cells[0].Value.ToString());
                    //מוסיפים את מספר הזמנה ומספר סידורי של מוצר וכמות לטבלה מקשרת
                    mySQL.InsertToProductOrder(Product.Product_serial_number, Convert.ToInt32(Lbl_showOrderNumber.Text),
                        Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value));
                    //מעדכנים את הכמות של מוצרים במלאי בהתאם
                    mySQL.UpdateProductAmountByBarcode(Product.Amount -
                        Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value), Product.Barcode);
                }
                else if (Grd_productsList.Rows[i].Cells[3].Value.ToString() != "")
                {
                    //שליפת מידע על מוצר לפי דגם
                    Product = mySQL.GetProductDataByModel(Grd_productsList.Rows[i].Cells[3].Value.ToString());
                    //מוסיפים את מספר הזמנה ומספר סידורי של מוצר וכמות לטבלה מקשרת
                    mySQL.InsertToProductOrder(Product.Product_serial_number, Convert.ToInt32(Lbl_showOrderNumber.Text),
                        Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value));
                    //מעדכנים את הכמות של מוצרים במלאי בהתאם
                    mySQL.UpdateProductAmountByModel(Product.Amount - Convert.ToInt32(
                        Grd_productsList.Rows[i].Cells[5].Value), Product.Model);
                }
            }
        }

        //שיטה שמעדכנת את הכמות של מוצר בתוך העגלה
        private void Grd_productsList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Grd_productsList.CurrentRow.Cells[0].Value.ToString() != "")
                mySQL.UpdateCartAmountByBarcode(Convert.ToInt32(Grd_productsList.CurrentRow.Cells[5].Value),
                    Grd_productsList.CurrentRow.Cells[0].Value.ToString());
            else if (Grd_productsList.CurrentRow.Cells[3].Value.ToString() != "")
                mySQL.UpdateCartAmountByModel(Convert.ToInt32(Grd_productsList.CurrentRow.Cells[5].Value),
                    Grd_productsList.CurrentRow.Cells[3].Value.ToString());

            MessageBox.Show("כמות עודכנה");
            this.Close();
            th = new Thread(openSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openSelf(object obj)
        {
            Application.Run(new Frm_productsInCart(usersRole,userName));
        }

        //יציאה
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Exitting();
        }

        private void Exitting()
        {
            if (usersRole == 1)
            {
                mySQL.clearCart();
                int currentOrderNumber = mySQL.GetOrderMaxNumber();
                mySQL.DeleteOrder(currentOrderNumber);
                this.Close();
                th = new Thread(openMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                mySQL.clearCart();
                int currentOrderNumber = mySQL.GetOrderMaxNumber();
                mySQL.DeleteOrder(currentOrderNumber);
                this.Close();
                th = new Thread(openEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}
