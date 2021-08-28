//Hoda Khier + Yusef Aborokon 44/5

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Electricity_shop
{
    //מחלקה שתפקידה לקבל נתונים מהמערכת ומעדכנת את בסיסי נתונים בהתאם דרך שאילתות
    public class DBSQL : DBconnection
    {
        private static DBSQL instance;

        private DBSQL()
        {
            baseDataBaseName = "electricity_shop";
            baseUserName = "root";
            basePassword = string.Empty;
        }

        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    DBconnection connection = DBconnection.Instance();
                    instance = new DBSQL();
                }
                return instance;
            }
        }

        public static string DaseDataBaseName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseDataBaseName = value;
                }
            }
            get
            {
                return baseDataBaseName;
            }
        }

        public static string UserName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseUserName = value;
                }
            }
            get
            {
                return baseUserName;
            }
        }


        public static string Password
        {
            set
            {
                if (value != string.Empty)
                {
                    basePassword = value;
                }
            }
            get
            {
                return basePassword;
            }
        }

        //פונקצייה שמקבלת אובייקט מסוג מוצר ומכניסה פרטים של אובייקט לתוך בסיסי נתונים 
        public void InsertProduct(Product Item)
        {
            string cmdStr = "INSERT INTO product (barcode,product_category,product_model," +
                "product_manufacturer,product_supplier,cost_price,selling_price,amount,product_info)" +
                " VALUES (@barcode,@product_category,@product_model,@product_manufacturer," +
                "@product_supplier,@cost_price,@selling_price,@amount,@product_info)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@barcode", Item.Barcode);
                command.Parameters.AddWithValue("@product_category", Item.Category);
                command.Parameters.AddWithValue("@product_model", Item.Model);
                command.Parameters.AddWithValue("@product_manufacturer", Item.Manufacturer);
                command.Parameters.AddWithValue("@product_supplier", Item.Supplier);
                command.Parameters.AddWithValue("@cost_price", Item.Cost_price);
                command.Parameters.AddWithValue("@selling_price", Item.Selling_price);
                command.Parameters.AddWithValue("@amount", Item.Amount);
                command.Parameters.AddWithValue("@product_info", Item.Product_info);

                base.ExecuteSimpleQuery(command);
            }
        }


        //פונקצייה שמקבלת אובייקט מסוג לקוח ומכניסה פרטים של אובייקט לתוך בסיסי נתונים 
        public void InsertCustomer(customer Item)
        {
            string cmdStr = "INSERT INTO customer (id,first_name,last_name," +
                "phone_number,address)" +
                " VALUES (@id,@first_name,@last_name,@phone_number," +
                "@address)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.Id);
                command.Parameters.AddWithValue("@first_name", Item.First_name);
                command.Parameters.AddWithValue("@last_name", Item.Last_name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה שמקבלת אובייקט מסוג ספק ומכניסה פרטים של אובייקט לתוך בסיסי נתונים 
        public void InsertSupplier(supplier Item)
        {
            string cmdStr = "INSERT INTO supplier (first_name,last_name,phone_number,address," +
                "dept,paid)" +
                " VALUES (@first_name,@last_name,@phone_number,@address,@dept," +
                "@paid)";

            using MySqlCommand command = new MySqlCommand(cmdStr);
            command.Parameters.AddWithValue("@first_name", Item.FirstName);
            command.Parameters.AddWithValue("@last_name", Item.LasttName);
            command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
            command.Parameters.AddWithValue("@address", Item.Address);
            command.Parameters.AddWithValue("@dept", Item.Dept);
            command.Parameters.AddWithValue("@paid", Item.Paid);

            base.ExecuteSimpleQuery(command);
        }

        //פונקצייה שמקבלת אובייקט מסוג הזמנה ומכניסה פרטים של אובייקט לתוך בסיסי נתונים 
        public void InsertOrder(orders Item)
        {
            string cmdStr = "INSERT INTO orders (customer_id,date,status)" +
                " VALUES (@customer_id,STR_TO_DATE(@date,' %d -%m -%Y'),@status)";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@customer_id", Item.Customer_id);
                command.Parameters.AddWithValue("@date", Item.Date);
                command.Parameters.AddWithValue("@status", Item.Status);


                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה שמקבלת ערכים של מוצר ומכניסה את הערכים לתוך בסיסי נתונים
        public void InsertToCart(string itemBarcode, string itemModel, int amount)
        {
            string cmdStr = "INSERT INTO cart (product_barcode,product_model,amount)" +
                " VALUES ('" + itemBarcode + "','" + itemModel + "'," + amount + ")";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה שמקבלת ערכים של מוצר ומכניסה את הערכים לתוך בסיסי נתונים
        public void InsertToProductOrder(int product_serial, int order_serial, int amount)
        {
            string cmdStr = "INSERT INTO product_order (product_serial_number,order_serial_number,amount)" +
                " VALUES (" + product_serial + "," + order_serial + "," + amount + ")";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_serial_number", product_serial);
                command.Parameters.AddWithValue("@order_serial_number", order_serial);
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מחזירה המספר המקסימלי ממספר ההזמנות
        public int GetOrderMaxNumber()
        {
            int result;
            string cmdStr = "SELECT Max(order_number) FROM orders";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה את פרטים של ההזמנות
        public orders[] GetOrdersData()
        {
            DataSet ds = new DataSet();
            orders[] Orders = null;
            string cmdStr = "SELECT *, DATE_FORMAT(date,'%d-%m-%Y') AS" +
                " date_string FROM orders ORDER BY order_number DESC";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders = new orders[dt.Rows.Count];

                for (int i = 0; i < Orders.Length; i++)
                {
                    Orders[i] = new orders();
                    Orders[i].Order_number = Convert.ToInt32(dt.Rows[i][0]);
                    Orders[i].Customer_id = dt.Rows[i][1].ToString();
                    Orders[i].Date = dt.Rows[i][4].ToString();
                    Orders[i].Status = Convert.ToInt32(dt.Rows[i][3]);

                }
            }
            return Orders;

        }


        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של המשתמשים
        public user[] GetUsersData()
        {
            DataSet ds = new DataSet();
            user[] User = null;
            string cmdStr = "SELECT * FROM user";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                User = new user[dt.Rows.Count];

                for (int i = 0; i < User.Length; i++)
                {
                    User[i] = new user();
                    User[i].Username = dt.Rows[i][0].ToString();
                    User[i].Password = dt.Rows[i][1].ToString();
                    User[i].Role = Convert.ToInt32(dt.Rows[i][2]);


                }
            }
            return User;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של הזמנות לפי טווח תאריכים
        public orders[] GetOredrsDataByTwoDates(string date1, string date2)
        {
            DataSet ds = new DataSet();
            orders[] Orders = null;


            string cmdStr = "SELECT *, DATE_FORMAT(date,'%d-%m-%Y')" +
                "AS date_string FROM orders WHERE date BETWEEN " +
                "STR_TO_DATE('" + date1 + "','%d-%m-%Y') " +
                "AND STR_TO_DATE('" + date2 + "','%d-%m-%Y')";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders = new orders[dt.Rows.Count];
                for (int i = 0; i < Orders.Length; i++)
                {
                    Orders[i] = new orders();
                    Orders[i].Order_number = Convert.ToInt32(dt.Rows[i][0]);
                    Orders[i].Customer_id = dt.Rows[i][1].ToString();
                    Orders[i].Status = Convert.ToInt32(dt.Rows[i][3]);
                    Orders[i].Date = dt.Rows[i][4].ToString();
                }
            }
            return Orders;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של ערך מעמ
        public vat Getvat()
        {
            DataSet ds = new DataSet();
            vat vatWorth = null;


            string cmdStr = "SELECT * FROM vat";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {
            }

            if (dt.Rows.Count > 0)
            {
                vatWorth = new vat();
                vatWorth.Vat =Convert.ToDouble(dt.Rows[0][0]);
                

            }
            return vatWorth;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצרים לפי מספר הזמנה
        public product_order[] GetProductsByOrderNumber(int orderNumber)
        {
            DataSet ds = new DataSet();
            product_order[] Orders = null;

            string cmdStr = "SELECT * FROM product_order WHERE order_serial_number="+orderNumber+"";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders = new product_order[dt.Rows.Count];
                for (int i = 0; i < Orders.Length; i++)
                {
                    Orders[i] = new product_order();
                    Orders[i].Id = Convert.ToInt32(dt.Rows[i][0]);
                    Orders[i].Product_serial_number = Convert.ToInt32(dt.Rows[i][1]);
                    Orders[i].Order_serial_number = Convert.ToInt32(dt.Rows[i][2]);
                    Orders[i].Amount = Convert.ToInt32(dt.Rows[i][3]);
                }
            }
            return Orders;
            }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של הזמנה לפי מספר הזמנה
        public orders GetOrdersDataByOrderNumber(string order_number)
        {
            DataSet ds = new DataSet();
            orders Orders = null;
            string cmdStr = "SELECT * FROM orders WHERE order_number=" + order_number + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders = new orders();

                Orders = new orders();
                Orders.Order_number = Convert.ToInt32(dt.Rows[0][0]);
                Orders.Customer_id = dt.Rows[0][1].ToString();
                Orders.Date = dt.Rows[0][2].ToString();
                Orders.Status = Convert.ToInt32(dt.Rows[0][3]);


            }
            return Orders;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצרים
        public Product[] GetProductData()
        {
            DataSet ds = new DataSet();
            Product[] Product = null;
            string cmdStr = "SELECT * FROM product ORDER BY product_category";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Product = new Product[dt.Rows.Count];

                for (int i = 0; i < Product.Length; i++)
                {
                    Product[i] = new Product();
                    Product[i].Product_serial_number = Convert.ToInt32(dt.Rows[i][0]);
                    Product[i].Barcode = dt.Rows[i][1].ToString();
                    Product[i].Category = dt.Rows[i][2].ToString();
                    Product[i].Model = dt.Rows[i][3].ToString();
                    Product[i].Manufacturer = dt.Rows[i][4].ToString();
                    Product[i].Supplier = dt.Rows[i][5].ToString();
                    Product[i].Cost_price = Convert.ToInt32(dt.Rows[i][6]);
                    Product[i].Selling_price = Convert.ToInt32(dt.Rows[i][7]);
                    Product[i].Amount = Convert.ToInt32(dt.Rows[i][8]);
                    Product[i].Product_info = dt.Rows[i][9].ToString();
                }
            }
            return Product;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצר לפי מספר סידורי של מוצר
        public Product GetProductDataBySerialNumber(string product_serial_number)
        {
            DataSet ds = new DataSet();
            Product Product = null;
            string cmdStr = "SELECT * FROM product WHERE product_serial_number="
                + product_serial_number + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Product = new Product();


                Product = new Product();
                Product.Product_serial_number = Convert.ToInt32(dt.Rows[0][0]);
                Product.Barcode = dt.Rows[0][1].ToString();
                Product.Category = dt.Rows[0][2].ToString();
                Product.Model = dt.Rows[0][3].ToString();
                Product.Manufacturer = dt.Rows[0][4].ToString();
                Product.Supplier = dt.Rows[0][5].ToString();
                Product.Cost_price = Convert.ToInt32(dt.Rows[0][6]);
                Product.Selling_price = Convert.ToInt32(dt.Rows[0][7]);
                Product.Amount = Convert.ToInt32(dt.Rows[0][8]);
                Product.Product_info = dt.Rows[0][9].ToString();

            }
            return Product;

        }

       

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצרים בעגלה
        public Cart[] getCartData()
        {
            DataSet ds = new DataSet();
            Cart[] cart = null;
            string cmdStr = "SELECT * FROM cart";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count >= 0)
            {
                cart = new Cart[dt.Rows.Count];

                for (int i = 0; i < cart.Length; i++)
                {
                    cart[i] = new Cart();
                    cart[i].Product_barcode = dt.Rows[i][1].ToString();
                    cart[i].Product_model = dt.Rows[i][2].ToString();
                    cart[i].Amount = Convert.ToInt32(dt.Rows[i][3]);

                }
            }
            return cart;
        }


        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצר לפי ברקוד שמקבלת
        public Product GetProductDataByBarcode(string barcode)
        {
            DataSet ds = new DataSet();
            Product Product = null;
            string cmdStr = "SELECT * FROM product WHERE barcode=" + barcode + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }
            if (dt.Rows.Count > 0)
            {

                Product = new Product();
                Product.Product_serial_number = Convert.ToInt32(dt.Rows[0][0]);
                Product.Barcode = dt.Rows[0][1].ToString();
                Product.Category = dt.Rows[0][2].ToString();
                Product.Model = dt.Rows[0][3].ToString();
                Product.Manufacturer = dt.Rows[0][4].ToString();
                Product.Supplier = dt.Rows[0][5].ToString();
                Product.Cost_price = Convert.ToInt32(dt.Rows[0][6]);
                Product.Selling_price = Convert.ToInt32(dt.Rows[0][7]);
                Product.Amount = Convert.ToInt32(dt.Rows[0][8]);
                Product.Product_info = dt.Rows[0][9].ToString();

            }
            return Product;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצר לפי מודל שמקבלת
        public Product GetProductDataByModel(string model)
        {
            DataSet ds = new DataSet();
            Product Product = null;
            string cmdStr = "SELECT * FROM product WHERE product_model='" + model + "'";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }
            if (dt.Rows.Count > 0)
            {

                Product = new Product();
                Product.Product_serial_number = Convert.ToInt32(dt.Rows[0][0]);
                Product.Barcode = dt.Rows[0][1].ToString();
                Product.Category = dt.Rows[0][2].ToString();
                Product.Model = dt.Rows[0][3].ToString();
                Product.Manufacturer = dt.Rows[0][4].ToString();
                Product.Supplier = dt.Rows[0][5].ToString();
                Product.Cost_price = Convert.ToInt32(dt.Rows[0][6]);
                Product.Selling_price = Convert.ToInt32(dt.Rows[0][7]);
                Product.Amount = Convert.ToInt32(dt.Rows[0][8]);
                Product.Product_info = dt.Rows[0][9].ToString();

            }
            return Product;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוחות
        public customer[] GetCustomerData()
        {
            DataSet ds = new DataSet();
            customer[] Customer = null;
            string cmdStr = "SELECT * FROM customer";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Customer = new customer[dt.Rows.Count];
                for (int i = 0; i < Customer.Length; i++)
                {
                    Customer[i] = new customer();
                    Customer[i].Id = dt.Rows[i][1].ToString();
                    Customer[i].First_name = dt.Rows[i][2].ToString();
                    Customer[i].Last_name = dt.Rows[i][3].ToString();
                    Customer[i].Phone_number = dt.Rows[i][4].ToString();
                    Customer[i].Address = dt.Rows[i][5].ToString();

                }
            }
            return Customer;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוח לפי דעודת זהות שמקבלת
        public customer GetCustomerDataByID(string id)
        {
            DataSet ds = new DataSet();
            customer Customer = null;
            string cmdStr = "SELECT * FROM customer WHERE id=" + id + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {

                Customer = new customer();
                Customer.Serial_number = Convert.ToInt32(dt.Rows[0][0]);
                Customer.Id = dt.Rows[0][1].ToString();
                Customer.First_name = dt.Rows[0][2].ToString();
                Customer.Last_name = dt.Rows[0][3].ToString();
                Customer.Phone_number = dt.Rows[0][4].ToString();
                Customer.Address = dt.Rows[0][5].ToString();

            }
            return Customer;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של ספקים
        public supplier[] GetSupplierData()
        {
            DataSet ds = new DataSet();
            supplier[] Supplier = null;
            string cmdStr = "SELECT * FROM supplier";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count >= 0)
            {
                Supplier = new supplier[dt.Rows.Count];

                for (int i = 0; i < Supplier.Length; i++)
                {
                    Supplier[i] = new supplier();
                    Supplier[i].Serial_number = Convert.ToInt32(dt.Rows[i][0]);
                    Supplier[i].FirstName = dt.Rows[i][1].ToString();
                    Supplier[i].LasttName = dt.Rows[i][2].ToString();
                    Supplier[i].Phone_number = dt.Rows[i][3].ToString();
                    Supplier[i].Address = dt.Rows[i][4].ToString();
                    Supplier[i].Dept = Convert.ToInt32(dt.Rows[i][5]);
                    Supplier[i].Paid = Convert.ToInt32(dt.Rows[i][6]);
                }
            }
            return Supplier;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצרים לפי פרטים שהיא מקבלת
        public Product[] GetProductDataFiltered(string stock_amount, string barcodeItem,
            string categoryItem, string manufactureItem, string modelItem)
        {
            string cmdStr;
            DataSet ds = new DataSet();
            Product[] Product = null;

            if (stock_amount == "הכל")
            {
                cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                   " AND product_category LIKE '" + categoryItem + "%'" +
                   " AND product_manufacturer LIKE '" + manufactureItem + "%'" +
                   "AND product_model LIKE '" + modelItem + "%'";
            }
            else
                if (stock_amount == "זמין במלאי")
            {
                cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                   " AND product_category LIKE '" + categoryItem + "%'" +
                   " AND product_manufacturer LIKE '" + manufactureItem + "%'" +
                   "AND product_model LIKE '" + modelItem + "%' AND amount > 2";
            }
            else
                if (stock_amount == "לא זמין במלאי")
            {
                cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                   " AND product_category LIKE '" + categoryItem + "%' AND product_manufacturer" +
                   " LIKE '" + manufactureItem + "%'" +
                   "AND product_model LIKE '" + modelItem + "%' AND amount = 0";
            }
            else
                if (stock_amount == "עומד להיגמר מהמלאי")
            {
                cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                   " AND product_category LIKE '" + categoryItem + "%' AND product_manufacturer" +
                   " LIKE '" + manufactureItem + "%'" +
                   "AND product_model LIKE '" + modelItem + "%' AND amount <= 2 && amount>0";
            }
            else
            {

                cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                   " AND product_category LIKE '" + categoryItem + "%' AND product_manufacturer" +
                   " LIKE '" + manufactureItem + "%'" +
                   "AND product_model LIKE '" + modelItem + "%'";
            }



            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Product = new Product[dt.Rows.Count];

                for (int i = 0; i < Product.Length; i++)
                {
                    Product[i] = new Product();
                    Product[i].Barcode = dt.Rows[i][1].ToString();
                    Product[i].Category = dt.Rows[i][2].ToString();
                    Product[i].Model = dt.Rows[i][3].ToString();
                    Product[i].Manufacturer = dt.Rows[i][4].ToString();
                    Product[i].Supplier = dt.Rows[i][5].ToString();
                    Product[i].Cost_price = Convert.ToInt32(dt.Rows[i][6]);
                    Product[i].Selling_price = Convert.ToInt32(dt.Rows[i][7]);
                    Product[i].Amount = Convert.ToInt32(dt.Rows[i][8]);
                    Product[i].Product_info = dt.Rows[i][9].ToString();
                }
            }
            return Product;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של הזמנות לפי פרטים שהיא מקבלת
        public orders_customers[] GetOrdersDataFiltered(string status,string customerID,
            string firstName, string lastName, string date)
        {
            string cmdStr = string.Empty;
            DataSet ds = new DataSet();
            orders_customers[] Orders_customers = null;

            if (status == "הכל")
            {
                if (date != "")
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                       "customer.phone_number,customer.address,orders.date,orders.status," +
                       "DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                       "FROM orders INNER JOIN " +
                       "customer ON orders.customer_id = customer.id" +
                       " WHERE customer.id LIKE '" + customerID + "%' AND" +
                       " customer.first_name LIKE '" + firstName + "%'" +
                       "AND customer.last_name LIKE '" + lastName + "%'" +
                       " AND orders.date=STR_TO_DATE('" + date + "','%d-%m-%Y') ORDER BY orders.date DESC";
                }
                else
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                        "customer.phone_number,customer.address,orders.date," +
                        "orders.status,DATE_FORMAT(date,'%d-%m-%Y') AS date_string FROM orders INNER JOIN " +
                        "customer ON orders.customer_id = customer.id" +
                        " WHERE customer.id LIKE '" + customerID + "%' AND" +
                        " customer.first_name LIKE '" + firstName + "%'" +
                        "AND customer.last_name LIKE '" + lastName + "%' ORDER BY orders.date DESC";
                }
            }else if(status == "סופק")
            {
                if (date != "")
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                       "customer.phone_number,customer.address,orders.date," +
                       "orders.status,DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                       "FROM orders INNER JOIN " +
                       "customer ON orders.customer_id = customer.id" +
                       " WHERE orders.status=0 AND customer.id LIKE '" + customerID + "%'" +
                       " AND customer.first_name LIKE '" + firstName + "%'" +
                       "AND customer.last_name LIKE '" + lastName + "%' AND" +
                       " orders.date=STR_TO_DATE('" + date + "','%d-%m-%Y') ORDER BY orders.date DESC";
                }
                else
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                        "customer.phone_number,customer.address,orders.date," +
                        "orders.status,DATE_FORMAT(date,'%d-%m-%Y') AS date_string FROM orders INNER JOIN " +
                        "customer ON orders.customer_id = customer.id" +
                        " WHERE orders.status=0 AND customer.id LIKE '" + customerID + "%'" +
                        " AND customer.first_name LIKE '" + firstName + "%'" +
                        "AND customer.last_name LIKE '" + lastName + "%' ORDER BY orders.date DESC";
                }
            }
            else if(status == "לא סופק")
            {
                if (date != "")
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                       "customer.phone_number,customer.address,orders.date," +
                       "orders.status,DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                       "FROM orders INNER JOIN " +
                       "customer ON orders.customer_id = customer.id" +
                       " WHERE orders.status=1 AND customer.id LIKE '" + customerID + "%'" +
                       " AND customer.first_name LIKE '" + firstName + "%'" +
                       "AND customer.last_name LIKE '" + lastName + "%'" +
                       " AND orders.date=STR_TO_DATE('" + date + "','%d-%m-%Y') ORDER BY orders.date DESC";
                }
                else
                {
                    cmdStr = "SELECT orders.order_number,orders.customer_id," +
                        "customer.first_name,customer.last_name," +
                        "customer.phone_number,customer.address,orders.date," +
                        "orders.status,DATE_FORMAT(date,'%d-%m-%Y') AS" +
                        " date_string FROM orders INNER JOIN " +
                        "customer ON orders.customer_id = customer.id" +
                        " WHERE orders.status=1 AND customer.id LIKE '" + customerID + "%'" +
                        " AND customer.first_name LIKE '" + firstName + "%'" +
                        "AND customer.last_name LIKE '" + lastName + "%' ORDER BY orders.date DESC";
                }
            }


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders_customers = new orders_customers[dt.Rows.Count];

                for (int i = 0; i < Orders_customers.Length; i++)
                {
                    Orders_customers[i] = new orders_customers();
                    Orders_customers[i].Order_number = Convert.ToInt32(dt.Rows[i][0]);
                    Orders_customers[i].Customer_id = dt.Rows[i][1].ToString();
                    Orders_customers[i].First_name = dt.Rows[i][2].ToString();
                    Orders_customers[i].Last_name = dt.Rows[i][3].ToString();
                    Orders_customers[i].Phone_number = dt.Rows[i][4].ToString();
                    Orders_customers[i].Address = dt.Rows[i][5].ToString();
                    Orders_customers[i].Date = dt.Rows[i][8].ToString();
                    Orders_customers[i].Status = Convert.ToInt32(dt.Rows[i][7]);

                }
            }
            return Orders_customers;

        }

        public orders_customers[] GetOrdersRelevantData(string status, string date1, string date2)
        {
            string cmdStr = string.Empty;
            DataSet ds = new DataSet();
            orders_customers[] Orders_customers = null;
            if (status == "")
            {
                cmdStr = "SELECT orders.order_number,orders.customer_id," +
                    "customer.first_name,customer.last_name," +
                   "customer.phone_number,customer.address,orders.date,orders.status," +
                   "DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                   "FROM orders INNER JOIN " +
                   "customer ON orders.customer_id = customer.id" +
                   " WHERE orders.date BETWEEN STR_TO_DATE('" + date1 + "','%d-%m-%Y') AND STR_TO_DATE('" + date2 + "','%d-%m-%Y') ORDER BY orders.date DESC";
            }
            else if (status == "סופק")
            {
                cmdStr = "SELECT orders.order_number,orders.customer_id," +
                  "customer.first_name,customer.last_name," +
                 "customer.phone_number,customer.address,orders.date,orders.status," +
                 "DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                 "FROM orders INNER JOIN " +
                 "customer ON orders.customer_id = customer.id" +
                 " WHERE orders.status=0 AND orders.date BETWEEN STR_TO_DATE('" + date1 + "','%d-%m-%Y') AND STR_TO_DATE('" + date2 + "','%d-%m-%Y') ORDER BY orders.date DESC";
            }
            else if (status == "לא סופק")
            {
                cmdStr = "SELECT orders.order_number,orders.customer_id," +
                  "customer.first_name,customer.last_name," +
                 "customer.phone_number,customer.address,orders.date,orders.status," +
                 "DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                 "FROM orders INNER JOIN " +
                 "customer ON orders.customer_id = customer.id" +
                 " WHERE orders.status=1 AND orders.date BETWEEN STR_TO_DATE('" + date1 + "','%d-%m-%Y') AND STR_TO_DATE('" + date2 + "','%d-%m-%Y') ORDER BY orders.date DESC";
            }


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders_customers = new orders_customers[dt.Rows.Count];

                for (int i = 0; i < Orders_customers.Length; i++)
                {
                    Orders_customers[i] = new orders_customers();
                    Orders_customers[i].Order_number = Convert.ToInt32(dt.Rows[i][0]);
                    Orders_customers[i].Customer_id = dt.Rows[i][1].ToString();
                    Orders_customers[i].First_name = dt.Rows[i][2].ToString();
                    Orders_customers[i].Last_name = dt.Rows[i][3].ToString();
                    Orders_customers[i].Phone_number = dt.Rows[i][4].ToString();
                    Orders_customers[i].Address = dt.Rows[i][5].ToString();
                    Orders_customers[i].Date = dt.Rows[i][8].ToString();
                    Orders_customers[i].Status = Convert.ToInt32(dt.Rows[i][7]);

                }
            }
            return Orders_customers;

        }


        public orders_customers GetBiggestOrderData(int orderNumber)
        {
            string cmdStr = string.Empty;
            DataSet ds = new DataSet();
            orders_customers Orders_customers = null;
          
                cmdStr = "SELECT orders.order_number,orders.customer_id," +
                    "customer.first_name,customer.last_name," +
                   "customer.phone_number,customer.address,orders.date,orders.status," +
                   "DATE_FORMAT(date,'%d-%m-%Y') AS date_string " +
                   "FROM orders INNER JOIN " +
                   "customer ON orders.customer_id = customer.id" +
                   " WHERE orders.order_number="+orderNumber+"";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Orders_customers = new orders_customers();

                    Orders_customers = new orders_customers();
                    Orders_customers.Order_number = Convert.ToInt32(dt.Rows[0][0]);
                    Orders_customers.Customer_id = dt.Rows[0][1].ToString();
                    Orders_customers.First_name = dt.Rows[0][2].ToString();
                    Orders_customers.Last_name = dt.Rows[0][3].ToString();
                    Orders_customers.Phone_number = dt.Rows[0][4].ToString();
                    Orders_customers.Address = dt.Rows[0][5].ToString();
                    Orders_customers.Date = dt.Rows[0][8].ToString();
                    Orders_customers.Status = Convert.ToInt32(dt.Rows[0][7]);
            }
            return Orders_customers;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של ספק לפי מספר טלפון שמקבלת
        public supplier GetSupplierDataByPhone(string phone)
        {
            DataSet ds = new DataSet();
            supplier sup = null;
            string cmdStr = "SELECT * FROM supplier WHERE phone_number LIKE '" + phone + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {

                sup = new supplier();
                sup.Serial_number = Convert.ToInt32(dt.Rows[0][0]);
                sup.FirstName = dt.Rows[0][1].ToString();
                sup.LasttName = dt.Rows[0][2].ToString();
                sup.Phone_number = dt.Rows[0][3].ToString();
                sup.Address = dt.Rows[0][4].ToString();
                sup.Paid = Convert.ToInt32(dt.Rows[0][5]);
                sup.Dept = Convert.ToInt32(dt.Rows[0][6]);


            }
            return sup;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוחות לפי תעודת זהות שמקבלת
        public customer[] GetCustomerDataById2(string id)
        {
            DataSet ds = new DataSet();
            customer[] Customer = null;
            string cmdStr = "SELECT * FROM customer WHERE id LIKE '" + id + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Customer = new customer[dt.Rows.Count];

                for (int i = 0; i < Customer.Length; i++)
                {
                    Customer[i] = new customer();
                    Customer[i].Id = dt.Rows[i][1].ToString();
                    Customer[i].First_name = dt.Rows[i][2].ToString();
                    Customer[i].Last_name = dt.Rows[i][3].ToString();
                    Customer[i].Phone_number = dt.Rows[i][4].ToString();
                    Customer[i].Address = dt.Rows[i][5].ToString();

                }
            }
            return Customer;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוח לפי מספר טלפון שמקבלת
        public customer GetCustomerDataByphoneN(string phone)
        {
            DataSet ds = new DataSet();
            customer Customer = null;
            string cmdStr = "SELECT * FROM customer WHERE phone_number=" + phone + "";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {

                Customer = new customer();
                Customer.Id = dt.Rows[0][1].ToString();
                Customer.First_name = dt.Rows[0][2].ToString();
                Customer.Last_name = dt.Rows[0][3].ToString();
                Customer.Phone_number = dt.Rows[0][4].ToString();
                Customer.Address = dt.Rows[0][5].ToString();


            }
            return Customer;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוחות לפי מספר טלפון שמקבלת
        public customer[] GetCustomerDataByphoneNumber(string phone)
        {
            DataSet ds = new DataSet();
            customer[] Customer = null;
            string cmdStr = "SELECT * FROM customer WHERE phone_number LIKE '" + phone + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Customer = new customer[dt.Rows.Count];

                for (int i = 0; i < Customer.Length; i++)
                {
                    Customer[i] = new customer();
                    Customer[i].Id = dt.Rows[i][1].ToString();
                    Customer[i].First_name = dt.Rows[i][2].ToString();
                    Customer[i].Last_name = dt.Rows[i][3].ToString();
                    Customer[i].Phone_number = dt.Rows[i][4].ToString();
                    Customer[i].Address = dt.Rows[i][5].ToString();
                }

            }
            return Customer;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של לקוחות לפי שם פרטי
        public customer[] GetCustomerDataByFN(string name)
        {
            DataSet ds = new DataSet();
            customer[] Customer = null;
            string cmdStr = "SELECT * FROM customer WHERE first_name LIKE '" + name + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Customer = new customer[dt.Rows.Count];

                for (int i = 0; i < Customer.Length; i++)
                {
                    Customer[i] = new customer();
                    Customer[i].Id = dt.Rows[i][1].ToString();
                    Customer[i].First_name = dt.Rows[i][2].ToString();
                    Customer[i].Last_name = dt.Rows[i][3].ToString();
                    Customer[i].Phone_number = dt.Rows[i][4].ToString();
                    Customer[i].Address = dt.Rows[i][5].ToString();

                }
            }
            return Customer;

        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של ספקים לפי שם פרטי
        public supplier[] GetSupplierDataByFN(string name)
        {
            DataSet ds = new DataSet();
            supplier[] Suppliers = null;
            string cmdStr = "SELECT * FROM supplier WHERE first_name LIKE '" + name + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Suppliers = new supplier[dt.Rows.Count];

                for (int i = 0; i < Suppliers.Length; i++)
                {
                    Suppliers[i] = new supplier();
                    Suppliers[i].FirstName = dt.Rows[i][1].ToString();
                    Suppliers[i].LasttName = dt.Rows[i][2].ToString();
                    Suppliers[i].Phone_number = dt.Rows[i][3].ToString();
                    Suppliers[i].Address = dt.Rows[i][4].ToString();
                    Suppliers[i].Dept = Convert.ToInt32(dt.Rows[i][5].ToString());
                    Suppliers[i].Paid = Convert.ToInt32(dt.Rows[i][6].ToString());

                }
            }
            return Suppliers;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של ספקים לפי שם משפחה שמקבלת
        public supplier[] GetSupplierDataByLN(string name)
        {
            DataSet ds = new DataSet();
            supplier[] Suppliers = null;
            string cmdStr = "SELECT * FROM supplier WHERE last_name LIKE '" + name + "%'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Suppliers = new supplier[dt.Rows.Count];

                for (int i = 0; i < Suppliers.Length; i++)
                {
                    Suppliers[i] = new supplier();
                    Suppliers[i].FirstName = dt.Rows[i][1].ToString();
                    Suppliers[i].LasttName = dt.Rows[i][2].ToString();
                    Suppliers[i].Phone_number = dt.Rows[i][3].ToString();
                    Suppliers[i].Address = dt.Rows[i][4].ToString();
                    Suppliers[i].Dept = Convert.ToInt32(dt.Rows[i][5].ToString());
                    Suppliers[i].Paid = Convert.ToInt32(dt.Rows[i][6].ToString());

                }
            }
            return Suppliers;
        }

        //פונקצייה שולפת מבסיסי נתונים ומחזירה פרטים של מוצרים בהזמנה לפי מספר הזמנה
        public product_order[] GetProduct_orderDataByOrderNumber(string orderNumber)
        {
            DataSet ds = new DataSet();
            product_order[] Product_order = null;
            string cmdStr = "SELECT * FROM product_order WHERE order_serial_number=" + orderNumber + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }

            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }

            catch
            {

            }

            if (dt.Rows.Count > 0)
            {
                Product_order = new product_order[dt.Rows.Count];

                for (int i = 0; i < Product_order.Length; i++)
                {
                    Product_order[i] = new product_order();
                    Product_order[i].Id = Convert.ToInt32(dt.Rows[i][0]);
                    Product_order[i].Product_serial_number = Convert.ToInt32(dt.Rows[i][1]);
                    Product_order[i].Order_serial_number = Convert.ToInt32(dt.Rows[i][2]);
                    Product_order[i].Amount = Convert.ToInt32(dt.Rows[i][3]);

                }
            }
            return Product_order;

        }

        //פונקצייה מעדכנת בסיסי נתונים לכמות מלאי של מוצר לפי מספר מוצר והכמות שמקבלת
        public void UpdateProductAmountBySerial(int amount, string serial)
        {
            string cmdStr = "UPDATE product SET amount=" + amount + "" +
                " WHERE product_serial_number=" + serial + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }


        //פונקצייה מעדכנת בסיסי נתונים לכמות מלאי של מוצר לפי ברקוד מוצר והכמות שמקבלת
        public void UpdateProductAmountByBarcode(int amount, string barcode)
        {
            string cmdStr = "UPDATE product SET amount=" + amount + " WHERE barcode=" + barcode + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים לערך של מעמ לפי ערך שמקבלת
        public void updateVat(double Item)
        {
            string cmdStr = "UPDATE vat SET vat_percentage=" + Item + "";
           

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            { 
                command.Parameters.AddWithValue("@vat_percentage", Item);
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים לכמות מלאי של מוצר לפי מודל מוצר והכמות שמקבלת
        public void UpdateProductAmountByModel(int amount, string model)
        {
            string cmdStr = "UPDATE product SET amount=" + amount + " WHERE product_model='" + model + "'";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים לפרטים של מוצר לפי הערכים באובייקט שמקבלת
        public void UpdateProductBySerial(Product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE" +
                " product_serial_number=" + Item.Product_serial_number + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                // command.Parameters.AddWithValue("@product_serial_number", Item.Product_serial_number);
                command.Parameters.AddWithValue("@barcode", Item.Barcode);
                command.Parameters.AddWithValue("@product_category", Item.Category);
                command.Parameters.AddWithValue("@product_model", Item.Model);
                command.Parameters.AddWithValue("@product_manufacturer", Item.Manufacturer);
                command.Parameters.AddWithValue("@product_supplier", Item.Supplier);
                command.Parameters.AddWithValue("@cost_price", Item.Cost_price);
                command.Parameters.AddWithValue("@selling_price", Item.Selling_price);
                command.Parameters.AddWithValue("@amount", Item.Amount);
                command.Parameters.AddWithValue("@product_info", Item.Product_info);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים לפרטים של לקוח לפי ערכים של אובייקט שמקבלת
        public void UpdateCustomer(customer Item)
        {
            string cmdStr = "UPDATE customer SET id=@id,first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number," +
                "address=@address WHERE phone_number=@phone_number";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", Item.Id);
                command.Parameters.AddWithValue("@first_name", Item.First_name);
                command.Parameters.AddWithValue("@last_name", Item.Last_name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים של הזמנה לפי מספר הזמנה
        public void UpdateOrderByOrderNumber(string orderNumber, int status)
        {
            string cmdStr = "UPDATE orders SET status=" + status + " WHERE order_number=" + orderNumber + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@status", status);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים של לקוח לפי מספר לקוח והאובייקט שמקבלת
        public void UpdateCustomerBySerial(customer Item)
        {
            string cmdStr = "UPDATE customer SET id=@id,first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number," +
                "address=@address WHERE customer_serial_number=" + Item.Serial_number + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@customer_serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@id", Item.Id);
                command.Parameters.AddWithValue("@first_name", Item.First_name);
                command.Parameters.AddWithValue("@last_name", Item.Last_name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים של ספק לפי מספר ספק והאובייקט שמקבלת
        public void UpdateSupplierBySerial(supplier Item)
        {
            string cmdStr = "UPDATE supplier SET first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number,address=@address," +
                "dept=@dept,paid=@paid WHERE supplier_serial_number=" + Item.Serial_number + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@supplier_serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@first_name", Item.FirstName);
                command.Parameters.AddWithValue("@last_name", Item.LasttName);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);
                command.Parameters.AddWithValue("@dept", Item.Dept);
                command.Parameters.AddWithValue("@paid", Item.Paid);


                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים של עגלה לפי ברקוד והערכים שמקבלת
        public void UpdateCartAmountByBarcode(int productAmount, string productBarcode)
        {
            string cmdStr = "UPDATE cart SET amount=" + productAmount + "" +
                " WHERE product_barcode='"+ productBarcode + "'";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", productAmount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים של כמות של מוצר בעגלה לפי מודל שמקבלת
        public void UpdateCartAmountByModel(int productAmount, string productModel)
        {
            string cmdStr = "UPDATE cart SET amount=" + productAmount + "" +
                " WHERE product_model=" + productModel + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", productAmount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מעדכנת בסיסי נתונים לכמות של מוצר בהזמנה לפי ערכים שמקבלת
        public void UpdateProduct_orderAmount(string product_serial_number,
            string order_serial_number, int amount)
        {
            string cmdStr = "UPDATE product_order SET amount=" + amount + "" +
                " WHERE product_serial_number=" + product_serial_number + " AND" +
                " order_serial_number=" + order_serial_number + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מוחקת מבסיסי נתונים את כל שנמצא בטבלת העגלה
        public void clearCart()
        {
            string cmdStr = "DELETE FROM cart";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מוחת מבסיסי נתונים את הזמנה לפי מספר הזמנה
        public void deleteOrderByOrderNumber(string orderNumber)
        {
            string cmdStr = "DELETE FROM orders WHERE order_number=" + orderNumber + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //מחיקת מבסיסי נתונים מוצר שנמצא בעגלה לפי ברקוד שמקבלת
        public void deleteItemFromCartByBarcode(string item)
        {
            string cmdStr = "DELETE FROM cart WHERE product_barcode=" + item + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מחוקת מבסיסי נתונים מוצר בעגלה לפי מודל שמקבלת
        public void deleteItemFromCartByModel(string item)
        {
            string cmdStr = "DELETE FROM cart WHERE product_Model='" + item + "'";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה מחוקת מבסיסי נתונים מוצר של הזמנה לפי מספר הזמנה ומספר של המוצר
        public void deleteProductFromProduct_cartByOrderNumberAndProductSerial(
            string product_serial_number, string order_serial_number)
        {
            string cmdStr = "DELETE FROM product_order WHERE " +
                "product_serial_number=" + product_serial_number + " " +
                "AND order_serial_number=" + order_serial_number + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        //פונקצייה סופרת מבסיסי נתונים את כמות המוצרים שאזלו מהמלאי
        public int countOutStockProducts()
        {
            int result;

            string cmdStr = "SELECT count(*) FROM product WHERE amount=0";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        //פונקצייה סופרת מבסיסי נתונים את כמות המוצרים שעומדים להיגמר מהמלאי
        public int countAboutToEnd()
        {
            int result;

            string cmdStr = "SELECT count(*) FROM product WHERE amount>0 AND amount <=2";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        //פונקצייה סופרת מבסיסי נתונים את כמות הלקוחות 
        public int countCustomers()
        {
            int result;

            string cmdStr = "SELECT count(*) FROM customer";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        //פונקצייה סופרת מבסיסי נתונים את כמות הספקים
        public int countSupplies()
        {
            int result;

            string cmdStr = "SELECT count(*) FROM supplier";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }

        //פונקצייה סופרת מבסיסי נתונים את כמות ההזמנות שלא סופקו
        public int countWaitingOrders()
        {
            int result;

            string cmdStr = "SELECT count(*) FROM orders WHERE status=1";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }

            return result;
        }
    }
}






