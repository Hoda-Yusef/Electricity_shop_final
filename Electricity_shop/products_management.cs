//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_products_management : Form
    {
        private readonly DBSQL mySQL;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        Product[] product;
        readonly AutoCompleteStringCollection barcodeAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection categoryAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection modelAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection manufactureAuto = new AutoCompleteStringCollection();
        int usersRole;
        string userName;
        int from_contianer = 0;
        public Frm_products_management(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;

            Set_AutoCompleteMode_text_boxes();

        }

        public Frm_products_management(int role, string username,int from_contianer)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
            this.from_contianer = from_contianer;

            Set_AutoCompleteMode_text_boxes();

        }
        // השלמת תיבות טקסט בצורה אוטומטית
        private void Set_AutoCompleteMode_text_boxes()
        {
            Txt_barcode.AutoCompleteMode = AutoCompleteMode.None;
            Txt_barcode.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_category.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_model.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_model.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_manufacturer.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_manufacturer.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        //לצורך חיפוש לפי ברקוד
        // למלא טבלה בטופס לפי ברקוד
        private void Fill_grid_by_barcode()
        {
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            Fill_grid(product);
            if (Grd_products.Rows.Count != 0)
                Grd_products.Rows[0].Cells[0].Selected = false;

        }
        //לצורך חיפוש לפי קטגוריה
        // למלא טבלה בטופס לפי קטגוריה
        private void Fill_grid_by_category()
        {
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            Fill_grid(product);
            if (Grd_products.Rows.Count != 0)
                Grd_products.Rows[0].Cells[0].Selected = false;

        }
        //לצורך חיפוש לפי יצרן
        //למלא טבלה בטופס לפי יצרן
        private void Fill_grid_by_manufacture()
        {
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            Fill_grid(product);

            if (Grd_products.Rows.Count != 0)
                Grd_products.Rows[0].Cells[0].Selected = false;
        }
        //לצורך חיפוש לפי דגם
        //למלא טבלה בטופס לפי דגם מוצר
        private void Fill_grid_by_model()
        {
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            Fill_grid(product);
            if (Grd_products.Rows.Count != 0)
                Grd_products.Rows[0].Cells[0].Selected = false;

        }

        private void Cbo_sortByProductAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            Fill_grid(product);
            if (Grd_products.Rows.Count != 0)
                Grd_products.Rows[0].Cells[0].Selected = false;
        }

        // מילוי טבלה בטופס לפי רשימת מוצרים שמקבלת הפונקציה כפרמטר
        private void Fill_grid(Product[] Product)
        {
            Grd_products.Rows.Clear();
            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    Grd_products.Rows.Add(new object[]
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
                Grd_products.Rows.Clear();
        }
        //פונקציה פותחת טופס ראשי במערכת
        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main(usersRole,userName));
        }
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole,userName));
        }
        //הזזת טופס
        private void Upper_BluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }
        //הזזת טופס
        private void Upper_BluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }
        //הזזת טופס
        private void Upper_BluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //צובעים שורה לפי כמות מוצר במלאי 
        //צבע רגיל הוא לבן
        private void Grd_products_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //עוברים על כל המוצרים במערכת
            for (int i = 0; i < Grd_products.Rows.Count; i++)
            {
                int amount = Convert.ToInt32(Grd_products.Rows[i].Cells[5].Value);
                if (amount > 0 && amount <= 2)
                {
                    //מוצרים שהכמות שלהם גדולה מ 0 וקטנה או שווה ל2 תהיה בצבע כתום 
                    Grd_products.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;

                }

                if (amount == 0)
                {
                    //מוצר שאזל מהמלאי נצבע שורה באדום
                    Grd_products.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        //בחירת מוצר ולחיצה על כפתור עדכן
        private void Btn_updateProduct_Click(object sender, EventArgs e)
        {
            if (Grd_products.CurrentRow != null)
            {
                //עוברים לטופס עדכון מוצר
                Frm_updateProduct updateProduct = new Frm_updateProduct(usersRole,userName);
                //מילוי תיבות הטקסט בנתוני מוצר שנבחר בהתאמה
                updateProduct.Txt_category.Text = Grd_products.CurrentRow.Cells[0].Value.ToString();
                updateProduct.Txt_manufacturer.Text = Grd_products.CurrentRow.Cells[1].Value.ToString();
                updateProduct.Txt_model.Text = Grd_products.CurrentRow.Cells[2].Value.ToString();
                updateProduct.Txt_barcode.Text = Grd_products.CurrentRow.Cells[3].Value.ToString();
                updateProduct.Txt_supplier.Text = Grd_products.CurrentRow.Cells[4].Value.ToString();
                updateProduct.Txt_amount.Text = Grd_products.CurrentRow.Cells[5].Value.ToString();
                updateProduct.Txt_cost_price.Text = Grd_products.CurrentRow.Cells[6].Value.ToString();
                updateProduct.Txt_selling_price.Text = Grd_products.CurrentRow.Cells[7].Value.ToString();
                updateProduct.Txt_productInfo.Text = Grd_products.CurrentRow.Cells[8].Value.ToString();

                updateProduct.ShowDialog();

                this.Close();
                th = new Thread(OpenSelf);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                MessageBox.Show("מוצר לא נבחר");

        }
        //פותחים טופס נוכחי בחזרה
        private void OpenSelf(object obj)
        {
            Application.Run(new Frm_products_management(usersRole,userName));
        }
        //לחיצה על כפתור חזרה לראשי
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (from_contianer == 0)
            {
                if (usersRole == 1)
                {
                    this.Close();
                    th = new Thread(Opennewform);
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
            else if (from_contianer == 1)
            {
                this.Close();
            }

        }
        //חיפוש לפי ברקוד
        private void Txt_barcode_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_barcode();
        }
        //חיפוש לפי כטגוריה
        private void Txt_category_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_category();
        }
        //חיפוש לפי יצרן
        private void Txt_manufacturer_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_manufacture();
        }
        //ליפוש לפי דגם
        private void Txt_model_TextChanged(object sender, EventArgs e)
        {
            Fill_grid_by_model();
        }



        //טעינת טופס נוכחי
        private void Frm_products_management_Load(object sender, EventArgs e)
        {
            //שומרים נתוני כל המוצרים שקיימים במערכת
            //Product[] Product = mySQL.GetProductData();
            product = mySQL.GetProductDataFiltered(Cbo_sortByProductAmount.Text, Txt_barcode.Text, Txt_category.Text, Txt_manufacturer.Text, Txt_model.Text);

            //מציגים אותם בטבלה

            if (product != null)
            {
                Grd_products.Rows.Clear();

                for (int i = 0; i < product.Length; i++)
                {
                    Grd_products.Rows.Add(new object[]
                    {
                    product[i].Category,
                    product[i].Manufacturer,
                    product[i].Model,
                    product[i].Barcode,
                    product[i].Supplier,
                    product[i].Amount,
                    product[i].Cost_price,
                    product[i].Selling_price,
                    product[i].Product_info
                    });
                }

                //אופציות לטיבות הטקסט מצד ימין -חיפושים
                for (int i = 0; i < product.Length; i++)
                {
                    barcodeAuto.Add(product[i].Barcode.ToString());
                    categoryAuto.Add(product[i].Category);
                    modelAuto.Add(product[i].Model);
                    manufactureAuto.Add(product[i].Manufacturer);
                }

                if (Grd_products.Rows.Count != 0)
                    Grd_products.Rows[0].Cells[0].Selected = false;

                Txt_barcode.AutoCompleteCustomSource = barcodeAuto;
                Txt_manufacturer.AutoCompleteCustomSource = manufactureAuto;
                Txt_model.AutoCompleteCustomSource = modelAuto;
                Txt_category.AutoCompleteCustomSource = categoryAuto;
            }
        }
        //לחיצה על כפתור נקה
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Txt_barcode.Text = "";
            Txt_category.Text = "";
            Txt_model.Text = "";
            Txt_manufacturer.Text = "";
        }
        //הגדרת תווים שאפשר להקליד בתיבת טקסט של ברקוד מוצר
        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        // Xלחיצה על כפתור
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (from_contianer == 0)
            {
                if (usersRole == 1)
                {
                    this.Close();
                    th = new Thread(Opennewform);
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
            else if(from_contianer ==1)
            {
                this.Close();
            }
        }

        //כאשר לוחצים לחיצה כפולה עוברים לעידכון מוצר ספציפי
        private void Grd_products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //עוברים לטופס עדכון מוצר
            Frm_updateProduct updateProduct = new Frm_updateProduct(usersRole,userName);
            //מילוי תיבות הטקסט בנתוני מוצר שנבחר בהתאמה
            updateProduct.Txt_category.Text = Grd_products.CurrentRow.Cells[0].Value.ToString();
            updateProduct.Txt_manufacturer.Text = Grd_products.CurrentRow.Cells[1].Value.ToString();
            updateProduct.Txt_model.Text = Grd_products.CurrentRow.Cells[2].Value.ToString();
            updateProduct.Txt_barcode.Text = Grd_products.CurrentRow.Cells[3].Value.ToString();
            updateProduct.Txt_supplier.Text = Grd_products.CurrentRow.Cells[4].Value.ToString();
            updateProduct.Txt_amount.Text = Grd_products.CurrentRow.Cells[5].Value.ToString();
            updateProduct.Txt_cost_price.Text = Grd_products.CurrentRow.Cells[6].Value.ToString();
            updateProduct.Txt_selling_price.Text = Grd_products.CurrentRow.Cells[7].Value.ToString();
            updateProduct.Txt_productInfo.Text = Grd_products.CurrentRow.Cells[8].Value.ToString();

            updateProduct.ShowDialog();

            this.Close();
            th = new Thread(OpenSelf);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Cbo_sortByProductAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
