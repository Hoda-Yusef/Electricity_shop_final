//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה שמציגה מוצרים שניתן להוסיף לעגלה
    public partial class Frm_cartProductMenu : Form
    {
        //Thread th;
        private readonly DBSQL mySQL;
        readonly DataTable dt;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        Product[] Products;
        Product Product;
        readonly Cart Cart;
        private readonly string product_barcode;
        int usersRole;
        string userName;

        public Frm_cartProductMenu(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }

        private void Frm_cartProductMenu_Load(object sender, EventArgs e)//בעת פתיחה חלון נטען במוצרים
        {
            Products = mySQL.GetProductData();

            if (Products != null)
            {

                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i].Amount > 0)
                    {
                        Grd_productsList.Rows.Add(new object[]
                        {
                    Products[i].Category,
                    Products[i].Manufacturer,
                    Products[i].Model,
                    Products[i].Barcode,
                    Products[i].Supplier,
                    Products[i].Amount,
                    Products[i].Cost_price,
                    Products[i].Selling_price,
                    Products[i].Product_info
                        });
                    }
                }
            }
        }

        private void fill_grid_by_barcode()//מסנן לפי ברקוד
        {
            Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_category()//מסנן לפי קטגוריה
        {
            Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_manufacture()//מסנן לפי יצרן
        {
            Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            fill_grid(Products);

            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid_by_model()//מסנן לפי מודל
        {
            Products = mySQL.GetProductDataFiltered("זמין במלאי", Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            fill_grid(Products);
            if (Grd_productsList.Rows.Count != 0)
                Grd_productsList.Rows[0].Cells[0].Selected = false;

        }

        private void fill_grid(Product[] Product)//מתרענן בכל חיפוש במוצרים
        {
            Grd_productsList.Rows.Clear();
            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    Grd_productsList.Rows.Add(new object[]
                    {
                    Product[i].Category,
                    Product[i].Manufacturer,
                    Product[i].Model,
                    Product[i].Barcode,
                    Product[i].Supplier,
                    Product[i].Amount,
                    Product[i].Cost_price,
                    Product[i].Selling_price,
                    Product[i].Product_info
                    });
                }
            }
            else
                Grd_productsList.Rows.Clear();
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        //הזזת החלון באמצע לחיצה על הפאנל באמצעות העכבר
        private void UpperBluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        //משנים צבע שורה של פריט לפי כמות המלאי
        private void Grd_productsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < Grd_productsList.Rows.Count; i++)
            {
                int amount = Convert.ToInt32(Grd_productsList.Rows[i].Cells[5].Value);
                if (amount > 0 && amount <= 2)
                {
                    Grd_productsList.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;

                }

                if (amount == 0)
                {
                    Grd_productsList.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        //בעת שנוי בשדה
        private void Txt_barcode_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_barcode();
        }

        //בעת שנוי בשדה
        private void Txt_category_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_category();
        }

        //בעת שנוי בשדה
        private void Txt_manufacturer_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_manufacture();
        }

        //בעת שנוי בשדה
        private void Txt_model_TextChanged(object sender, EventArgs e)
        {
            fill_grid_by_model();
        }

        private void Btn_clear_Click(object sender, EventArgs e)//ניקוי שדות
        {
            Txt_barcode.Text = "";
            Txt_category.Text = "";
            Txt_model.Text = "";
            Txt_manufacturer.Text = "";
        }

        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)//רק מספרים להזנה
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }


        private void OpenProductCart(object obj)//פותח חלון העגלה
        {
            Application.Run(new Frm_productsInCart(usersRole,userName));
        }

        private void Btn_toCart_Click(object sender, EventArgs e)//יציאה
        {
            Thread th;
            this.Close();
            th = new Thread(OpenProductCart);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Btn_addToCart_Click(object sender, EventArgs e)//בעת לחיצה על הוספת מוצר
        {
            bool same = false;
            string itemBarcode = Grd_productsList.CurrentRow.Cells[3].Value.ToString();
            string itemModel = Grd_productsList.CurrentRow.Cells[2].Value.ToString();
            int amount = (int)Grd_productsList.CurrentRow.Cells[5].Value;
            Cart[] Cart = mySQL.getCartData();

            if (Cart != null)
            {
                if (Grd_productsList.CurrentRow.Cells[3].Value.ToString() != "")
                {
                    for (int i = 0; i < Cart.Length; i++)//לולאה בודקת אם מוצר קיים כבר בעגלה
                    {
                        if (Cart[i].Product_barcode == itemBarcode)
                        {
                            same = true;
                        }
                    }
                }
                if (Grd_productsList.CurrentRow.Cells[2].Value.ToString() != "")
                {
                    for (int i = 0; i < Cart.Length; i++)//לולאה בודקת אם מוצר קיים כבר בעגלה
                    {
                        if (Cart[i].Product_model == itemModel)
                        {
                            same = true;
                        }
                    }
                }
            }
            checkIfproductSelected(same,amount,itemBarcode,itemModel);
            
        }

        private void checkIfproductSelected(bool same, int amount, string itemBarcode, string itemModel)
        {
            if (same)//בודקים אם קיים
            {
                MessageBox.Show("מוצר קיים בעגלה", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (amount != 0)//אם מוצר לא קיים בעגלה אז מוסיפים אותו
                {
                    if (Grd_productsList.CurrentRow.Cells[3].Value.ToString() != "")
                        Product = mySQL.GetProductDataByBarcode(Grd_productsList.CurrentRow.Cells[3].Value.ToString());
                    else if (Grd_productsList.CurrentRow.Cells[2].Value.ToString() != "")
                        Product = mySQL.GetProductDataByModel(Grd_productsList.CurrentRow.Cells[2].Value.ToString());

                    if (Product.Amount - Convert.ToInt32(amountChoose.Value) >= 0)//בודקים אם יש הכמות הנדרשת במלאי
                    {
                        mySQL.InsertToCart(itemBarcode, itemModel, Convert.ToInt32(amountChoose.Value));
                        MessageBox.Show("מוצר התווסף לעגלה");
                    }
                    else
                        MessageBox.Show("אין מספיק מלאי להכמות המבוקשת");
                }
                else
                    MessageBox.Show("מוצר אזל מהמלאי", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            amountChoose.Value = 1;//מחזירים את כמות הבחירה ל 1
        }

        //פותח חלון ראשי
        private void OpenMain(object obj)
        {
            Application.Run(new Frm_main(usersRole, userName));
        }
        //פןתח חלון ראשי של עובד
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole, userName));
        }
        //כפתור יציאה בודק אם המשתמש הוא מנהל או עובד
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }
    }
}
