using System;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class Frm_productsData : Form
    {
        private DBSQL mySQL;
        orders[] Orders;
        int totalProducts = 0;
        string mostSailedCategory = string.Empty;
        Product most_SailedProduct=new Product();

        public Frm_productsData()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }
       
        private void clearLabels()
        {
            Lbl_categoryName.Text ="- אין מידע -";
            Lbl_productBarcode.Text = "- אין מידע -";
            Lbl_productModel.Text = "- אין מידע -";
            Lbl_productCategory.Text = "- אין מידע -";
            Lbl_totalProductsNumber.Text = "0";
            Lbl_aboutToRunOutNumber.Text = "0";
            Lbl_outOfStockNumber.Text = "0";
        }

     
        private void getDataByTwoDates()
        {
            Orders = mySQL.GetOredrsDataByTwoDates(dateTimePicker1.Text, dateTimePicker2.Text);
            product_order[] order;
            product_order[] tmporder;
            Product currentProduct;
            Product temporaryProduct;
            Product resultProduct = new Product();
            Product result = new Product();
            string currentCategory = string.Empty;
            int max_category = 0, max_product = 0;
            int sum_category = 0, sum_product = 0;
            totalProducts = 0;

            if (Orders != null)
            {
                for (int i = 0; i < Orders.Length; i++)
                {

                    sum_category = 0;
                    order = mySQL.GetProductsByOrderNumber(Orders[i].Order_number);
                    for (int j = 0; j < order.Length; j++)
                    {
                        sum_product = 0;
                        // כמות מוצרים שנמכרה בין שני התאריכים
                        totalProducts += order[j].Amount;

                        //קטגוריה נמכרת ביותר
                        currentProduct = mySQL.GetProductDataBySerialNumber(order[j].Product_serial_number.ToString());
                        currentCategory = currentProduct.Category;

                        for (int i2 = 0; i2 < Orders.Length; i2++)
                        {
                            tmporder = mySQL.GetProductsByOrderNumber(Orders[i2].Order_number);
                            for (int j2 = 0; j2 < tmporder.Length; j2++)
                            {
                                temporaryProduct = mySQL.GetProductDataBySerialNumber(tmporder[j2].Product_serial_number.ToString());
                                if (currentCategory == temporaryProduct.Category)
                                {
                                    sum_category += tmporder[j2].Amount;
                                    //בודקים אם זה אותו מוצר
                                    if (currentProduct.Barcode == temporaryProduct.Barcode
                                        || currentProduct.Model == temporaryProduct.Model)
                                    {
                                        sum_product += tmporder[j2].Amount;
                                    }
                                }
                            }
                        }
                        if (sum_product > max_product)
                        {
                            max_product = sum_product;
                            most_SailedProduct = currentProduct;
                        }
                        if (sum_category > max_category)
                        {
                            max_category = sum_category;
                            mostSailedCategory = currentCategory;
                        }
                    }
                }


                // כמות מוצרים שנמכרה בין שני התאריכים
                Lbl_totalProductsNumber.Text = totalProducts.ToString();
                // מספר מוצרים שעומדים להיגמר מהמלאי
                Lbl_aboutToRunOutNumber.Text = mySQL.countAboutToEnd().ToString();
                //מוצרים שאזלו מהמלאי
                Lbl_outOfStockNumber.Text = mySQL.countOutStockProducts().ToString();
                Lbl_categoryName.Text = mostSailedCategory;
                Lbl_productBarcode.Text = most_SailedProduct.Barcode;
                Lbl_productModel.Text = most_SailedProduct.Model;
                Lbl_productCategory.Text = most_SailedProduct.Category;
            }
            else
            {
                MessageBox.Show("אין מידע לטווח תאריכים");
                clearLabels();
            }
        }
       
        private void Frm_productsData_Load(object sender, EventArgs e)
        {
            clearLabels();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getDataByTwoDates();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            getDataByTwoDates();
        }
    }
}
