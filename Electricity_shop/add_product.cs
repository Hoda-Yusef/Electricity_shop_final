//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_addProduct : Form
    {
        Product load_products;
        int count = 0;
        Thread th;
        bool drag = false;
        Point sp = new Point(0, 0);
        //int inx;
        private readonly DBSQL mySQL;
        private System.Windows.Forms.ErrorProvider barcodeErrorProvider;
        readonly AutoCompleteStringCollection barcodeAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection categoryAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection modelAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection manufacturerAuto = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection supplierAuto = new AutoCompleteStringCollection();
        int usersRole;
        public Frm_addProduct(int role)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            Set_AutoCompleteMode_text_boxes();

        }

        // השלמה אוטומטית של מאפיינים מסויימים שקבענו
        private void Set_AutoCompleteMode_text_boxes()
        {
            Txt_category.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_category.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_manufacturer.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_manufacturer.AutoCompleteSource = AutoCompleteSource.CustomSource;

            Txt_supplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            Txt_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // לחיצה על כפתור X מחזיר אותנו לדף ראשי של המערכת
        private void Btn_exitX_Click(object sender, EventArgs e)
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

        //פונקציית עזר
        //פתיחת דף ראשי במערכת
        private void Opennewform(object obj)
        {
            Application.Run(new Frm_main(usersRole));
        }
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole));
        }

        // לחיצה על כפתור ביטל
        // מידע שהוזן בכל תיבות הטקסט לא נשמר וחוזרים לדף ראשי במערכת
        private void Btn_cancel_Click(object sender, EventArgs e)
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

        // פונקציית עזר
        // בודקת תקינות ברקוד מוצר מחזירה אמת במקרה ותקין
        // אחרת יוחזר שקר
        private bool Check_barcode()
        {
            return (Txt_barcode.Text.Length == 13 || Txt_barcode.Text.Length == 12);
        }

        //פונקציית עזר
        //הגדרת כל השדות לקריאה בלבד 
        private void Read_only_true()
        {
            Txt_barcode.ReadOnly = true;
            Txt_category.ReadOnly = true;
            Txt_model.ReadOnly = true;
            Txt_manufacturer.ReadOnly = true;
            Txt_supplier.ReadOnly = true;
            Txt_costPrice.ReadOnly = true;
            Txt_sellingPrice.ReadOnly = true;
            Txt_productInformation.ReadOnly = true;
        }

        //ביטול השדות לקריאה בלבד

        private void Read_only_false()
        {
            Txt_barcode.ReadOnly = false;
            Txt_category.ReadOnly = false;
            Txt_model.ReadOnly = false;
            Txt_manufacturer.ReadOnly = false;
            Txt_supplier.ReadOnly = false;
            Txt_costPrice.ReadOnly = false;
            Txt_sellingPrice.ReadOnly = false;
            Txt_productInformation.ReadOnly = false;
        }

        //טעינת טופס
        // שומרים את המידע של כל המוצרים הקיימים במערכת במערך מסוג מוצר
        private void Frm_addProduct_Load(object sender, EventArgs e)
        {
            Product[] Product = mySQL.GetProductData();

            if (Product != null)
            {
                for (int i = 0; i < Product.Length; i++)
                {
                    barcodeAuto.Add(Product[i].Barcode);
                    categoryAuto.Add(Product[i].Category);
                    modelAuto.Add(Product[i].Model);
                    manufacturerAuto.Add(Product[i].Manufacturer);
                    supplierAuto.Add(Product[i].Supplier);
                }
                Txt_barcode.AutoCompleteCustomSource = barcodeAuto;
                Txt_supplier.AutoCompleteCustomSource = supplierAuto;
                Txt_model.AutoCompleteCustomSource = modelAuto;
                Txt_manufacturer.AutoCompleteCustomSource = manufacturerAuto;
                Txt_category.AutoCompleteCustomSource = categoryAuto;
            }
        }
        //מגדירים כל השדות ריקים
        private void Clear_boxes()
        {
            Txt_barcode.Clear();
            Txt_category.Clear();
            Txt_model.Clear();
            Txt_manufacturer.Clear();
            Txt_supplier.Clear();
            Txt_costPrice.Clear();
            Txt_sellingPrice.Clear();
            productAmount.Value = 0;
            Txt_productInformation.Clear();
        }

        // פונקציה יוצרת אוביקט חדש מסוג מוצר
        //ומוסיפה אותו לבסיס הנתונים
        private void New_product(Product Prod)
        {
            Prod.Barcode = Txt_barcode.Text;
            Prod.Category = Txt_category.Text;
            Prod.Model = Txt_model.Text;
            Prod.Manufacturer = Txt_manufacturer.Text;
            Prod.Supplier = Txt_supplier.Text;
            Prod.Cost_price = Convert.ToInt32(Txt_costPrice.Text);
            Prod.Selling_price = Convert.ToInt32(Txt_sellingPrice.Text);
            Prod.Amount = Convert.ToInt32(productAmount.Value);
            Prod.Product_info = Txt_productInformation.Text;
            mySQL.InsertProduct(Prod);

            MessageBox.Show("מוצר התווסף בהצלחה");
            Clear_boxes();

        }

        //מגדירים איזה תווים במקלגת תקבל תיבת הטקסט
        private void Txt_sellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //הזזת טופס דרך panel העליון הכחול
        private void Upper_bluePanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }
        //הזזת טופס דרך panel העליון הכחול
        private void Upper_bluePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }
        //הזזת טופס דרך panel העליון הכחול
        private void Upper_bluePanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        //מגדירים איזה תווים במקלגת תקבל תיבת הטקסט
        private void Txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        //אחרי עזיבת תיבת הטקסט של ברקוד
        //מבצעים כמה בדיקות:
        private void Txt_barcode_Leave(object sender, EventArgs e)
        {
            if (Txt_barcode.Text != "")
            {
                Product[] Product = mySQL.GetProductData();
                string temporary_barcode = Txt_barcode.Text;

                if (Product != null)
                {

                    for (int i = 0; i < Product.Length; i++)
                    {
                        if (temporary_barcode == Product[i].Barcode.ToString())
                        {
                            MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                            load_products = mySQL.GetProductDataByBarcode(Txt_barcode.Text);
                            Txt_barcode.Text = load_products.Barcode.ToString();
                            Txt_category.Text = load_products.Category.ToString();
                            Txt_model.Text = load_products.Model.ToString();
                            Txt_manufacturer.Text = load_products.Manufacturer.ToString();
                            Txt_supplier.Text = load_products.Supplier.ToString();
                            Txt_costPrice.Text = load_products.Cost_price.ToString();
                            Txt_sellingPrice.Text = load_products.Selling_price.ToString();
                            //productAmount.Value = load_products.Amount;
                            Txt_productInformation.Text = load_products.Product_info.ToString();
                            Read_only_true();

                        }
                    }
                }
            }

            if (Check_barcode() == false && count == 0)
            {
                count++;
                // מגדירים שגאיה בהתאם
                barcodeErrorProvider = new ErrorProvider();
                barcodeErrorProvider.SetError(Txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
            }
            else
            {
                if (Check_barcode() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (Check_barcode() == true)
                    {
                        barcodeErrorProvider.SetError(Txt_barcode, "");
                    }
                    else
                    {
                        barcodeErrorProvider.SetError(Txt_barcode, "ברקוד מכיל 13 או 12 ספרות");
                    }
                }
            }
        }
        //מגדירים איזה תווים במקלגת תקבל תיבת הטקסט
        private void Txt_costPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //לחיצה על כפתור הוספה
        private void Btn_addProduct_Click(object sender, EventArgs e)
        {
            bool same = false;
            //בודקים תקינות הנתונים שנקלטו בהתאם
            if ((Txt_barcode.Text !="" || Txt_model.Text != "") && Txt_productInformation.Text != ""
                && Txt_manufacturer.Text != "" && Txt_supplier.Text != "" && Txt_costPrice.Text != ""
                && Txt_sellingPrice.Text != "" && productAmount.Value != 0)
            {
                Product[] Product = mySQL.GetProductData();
                Product Prod = new Product();
                string barcodeTmp = Txt_barcode.Text;
                string modelTmp = Txt_model.Text;

                

                if (Product != null)
                {
                    if (barcodeTmp != "")
                    {

                        for (int i = 0; i < Product.Length; i++)
                        {
                            if (barcodeTmp == Product[i].Barcode.ToString())
                            {
                                //ברקוד שנקלט שייך למוצר קיים במערכת
                                same = true;
                            }
                        }
                    }
                    else if(modelTmp != "")
                    {
                        for (int i = 0; i < Product.Length; i++)
                        {
                            if (modelTmp == Product[i].Model.ToString())
                            {
                                //דגם שנקלט שייך למוצר קיים במערכת
                                same = true;
                            }
                        }
                    }
                }
                // במידה והמוצר קיים אז ניתן להוסיף כמות
                if (same)
                {
                    int new_amount = Convert.ToInt32(productAmount.Value) + load_products.Amount;

                    mySQL.UpdateProductAmountBySerial(new_amount, load_products.Product_serial_number.ToString());
                    MessageBox.Show("מוצר קיים , עודכן בהצלחה");
                    Clear_boxes();
                }
                // אחרת יוצרים אובייקט חדש מסוג מוצר ושומרים אותו בבסיס הנתונים
                else
                {
                    New_product(Prod);
                    Clear_boxes();
                }
            }
            // במידה ויש פרטים חסרים
            else
            {
                MessageBox.Show("יש למלא את כל השדות");
            }
        }
        //לחיצה על כפתור נקה
        private void Btn_clearAll_Click(object sender, EventArgs e)
        {
            Clear_boxes();
            Read_only_false();
        }

        //אחרי עזיבת תיבת הטקסט של דגם
        //מבצעים כמה בדיקות:
        private void Txt_model_Leave(object sender, EventArgs e)
        {
            if (Txt_model.Text != "")
            {
                Product[] Product = mySQL.GetProductData();
                string modelTmp = Txt_model.Text;
                string upperCaseString = modelTmp.ToUpper();

                if (Product != null)
                {

                    for (int i = 0; i < Product.Length; i++)
                    {
                        // במקרה ונתון שנקלט זהה לדגם קיים
                        if (modelTmp == Product[i].Model.ToString() || upperCaseString == Product[i].Model.ToString())
                        {
                            // מציגים הודעה מתאימה 
                            MessageBox.Show("מוצר קיים , ניתן להוסיף כמות");
                            int temporary_serial_number = Product[i].Product_serial_number;
                            load_products = mySQL.GetProductDataBySerialNumber(temporary_serial_number.ToString());
                            Txt_barcode.Text = load_products.Barcode.ToString();
                            Txt_category.Text = load_products.Category.ToString();
                            Txt_model.Text = load_products.Model.ToString();
                            Txt_manufacturer.Text = load_products.Manufacturer.ToString();
                            Txt_supplier.Text = load_products.Supplier.ToString();
                            Txt_costPrice.Text = load_products.Cost_price.ToString();
                            Txt_sellingPrice.Text = load_products.Selling_price.ToString();
                            //productAmount.Value = load_products.Amount;
                            Txt_productInformation.Text = load_products.Product_info.ToString();
                            Read_only_true();
                        }
                    }
                }
            }
        }
    }
}
    

