using System;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_productsData : Form
    {
        private DBSQL mySQL;
        orders[] Orders;
        product_order[] Product_order;
        Product product;
        Product[] Products;
        public Frm_productsData()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void Btn_ordersDataSearch_Click(object sender, System.EventArgs e)
        {
            int max_PRODUCTcount = 0;
            int max_product_amount = 0;
            int count = 0;
            int total_count = 0;
            string max_product_category=string.Empty;
            string max_product_model=string.Empty;
            string max_product_bacode = string.Empty;

            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker_from.Text, dateTimePicker_to.Text);

            if (Orders != null)
            {
                Products = mySQL.GetProductData();//קבלת מידע על כל המוצרים לעבור עליהם אחד אחד
                if (Products != null)
                {
                    for (int i = 0; i < Products.Length; i++)//לולאה עוברת על כל המוצרים
                    {
                        for (int j = 0; j < Orders.Length; j++)//לולאה עוברת על ההזמנות שבין שני התאריכים
                        {
                            Product_order = mySQL.GetProduct_orderDataByOrderNumber(Orders[j].Order_number.ToString());

                            if (Product_order != null)
                            {
                                for (int k = 0; k < Product_order.Length; k++)//לולאה עוברת על המוצרים שנמצאים בהזמנה
                                {
                                    product = mySQL.GetProductDataBySerialNumber(Product_order[k].Product_serial_number.ToString());
                                    if (Products[i].Product_serial_number == product.Product_serial_number)//בודקים אם מוצר בהזמנה שווה למוצר קיים במלאי
                                    {
                                        count += Product_order[k].Amount;//סופר כמה יחידות יש מהמוצר גם לפי כמות
                                        total_count+= Product_order[k].Amount;

                                    }
                                }
                            }
                        }
                        if (count > max_PRODUCTcount)//בודקים אם המוצר נמכר הכי הרבה ואז מציבים את כל הפרטים שלו
                        {
                            max_PRODUCTcount = count;
                            max_product_category = Products[i].Category;
                            max_product_model = Products[i].Model;
                            //max_product_amount = max_PRODUCTcount;
                            max_product_bacode = Products[i].Barcode;
                        }
                        count = 0;//מאפסים את המונה

                    }

                    displayResult(max_product_category, max_product_bacode,
                        max_product_model, max_PRODUCTcount,total_count);
                    
                }
            }
            else
                MessageBox.Show("אין מידע לטווח תאריכים");
        }

        private void displayResult(string max_product_category, string max_product_bacode,
            string max_product_model, int max_PRODUCTcount,int totalCount)
        {
            Lbl_categoryName.Text = max_product_category;

            if(max_product_bacode !="")
                Lbl_productBarcode.Text = max_product_bacode;
            else
                Lbl_productBarcode.Text = "--אין ברקוד--";

            if(max_product_model != "")
                Lbl_productModel.Text = max_product_model;
            else
                Lbl_productModel.Text = "--אין דגם--";

            Lbl_productCategory.Text = max_product_category;
            Lbl_productCountNumber.Text = max_PRODUCTcount.ToString();
            Lbl_totalProductsNumber.Text = totalCount.ToString();
            Lbl_aboutToRunOutNumber.Text= mySQL.countAboutToEnd().ToString();
            Lbl_outOfStockNumber.Text= mySQL.countOutStockProducts().ToString();
        }
    }
}
