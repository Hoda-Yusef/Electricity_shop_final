using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Electricity_shop
{
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

        public void InsertOrder(orders Item)
        {
            string cmdStr = "INSERT INTO orders (customer_id,date,status) VALUES (@customer_id,@date,@status)";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@customer_id", Item.Customer_id);
                command.Parameters.AddWithValue("@date", Item.Date);
                command.Parameters.AddWithValue("@status", Item.Status);


                base.ExecuteSimpleQuery(command);
            }
        }

        public void InsertOrderNumberHolder(string orderNumber)
        {
            string cmdStr = "INSERT INTO order_number_holder (order_number) VALUES ("+orderNumber+")";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@order_number", orderNumber);
                
                base.ExecuteSimpleQuery(command);
            }
        }

        public void InsertToCart(string item,int amount)
        {
            string cmdStr = "INSERT INTO cart (product_barcode,amount) VALUES (" + item + ","+amount+")";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_barcode", item);
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        public void InsertToProductOrder(int product_serial, int order_serial,int amount)
        {
            string cmdStr = "INSERT INTO product_order (product_serial_number,order_serial_number,amount)" +
                " VALUES (" + product_serial + "," + order_serial + ","+amount+")";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_serial_number", product_serial);
                command.Parameters.AddWithValue("@order_serial_number", order_serial);
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

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

        public orders[] GetOrdersData()
        {
            DataSet ds = new DataSet();
            orders[] Orders = null;
            string cmdStr = "SELECT * FROM orders ORDER BY date DESC";

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
                    Orders[i].Date = dt.Rows[i][2].ToString();
                    Orders[i].Status = Convert.ToInt32(dt.Rows[i][3]);
                   
                }
            }
            return Orders;

        }

        public orders GetOrdersDataByCustomerId(string id)
        {
            DataSet ds = new DataSet();
            orders Orders = null;
            string cmdStr = "SELECT * FROM orders WHERE customer_id="+id+"";

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

        public Product GetProductDataBySerialNumber(string product_serial_number)
        {
            DataSet ds = new DataSet();
            Product Product = null;
            string cmdStr = "SELECT * FROM product WHERE product_serial_number=" + product_serial_number + "";

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

               
                    Product= new Product();
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

        public Product[] GetProductDataByOrderNumber(string orderNumber)
        {
            DataSet ds = new DataSet();
            Product[] Product = null;
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
                    cart[i].Product_barcode = dt.Rows[i][0].ToString();
                    cart[i].Amount= Convert.ToInt32(dt.Rows[i][1]);

                }
            }
            return cart;
        }

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

        public DataTable GetProductData_for_table()
        {
            DataSet ds = new DataSet();

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

            return dt;
        }

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

        public Product[] GetProductDataFiltered(string barcodeItem, string categoryItem, string manufactureItem, string modelItem)
        {
            DataSet ds = new DataSet();
            Product[] Product = null;
            string cmdStr = "SELECT * FROM product WHERE barcode LIKE '" + barcodeItem + "%'" +
                " AND product_category LIKE '" + categoryItem + "%' AND product_manufacturer LIKE '" + manufactureItem + "%'" +
                "AND product_model LIKE '" + modelItem + "%'";

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

        public customer GetCustomerDataById(string id)
        {
            DataSet ds = new DataSet();
            customer Customer = null;
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

                Customer = new customer();
                Customer.Id = dt.Rows[0][0].ToString();
                Customer.First_name = dt.Rows[0][1].ToString();
                Customer.Last_name = dt.Rows[0][2].ToString();
                Customer.Phone_number = dt.Rows[0][3].ToString();
                Customer.Address = dt.Rows[0][4].ToString();


            }
            return Customer;

        }

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
                    Customer[i].Id = dt.Rows[i][0].ToString();
                    Customer[i].First_name = dt.Rows[i][1].ToString();
                    Customer[i].Last_name = dt.Rows[i][2].ToString();
                    Customer[i].Phone_number = dt.Rows[i][3].ToString();
                    Customer[i].Address = dt.Rows[i][4].ToString();

                }
            }
            return Customer;

        }

        public customer[] GetCustomerDataByphoneN(string phone)
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
                    Customer[i].Id = dt.Rows[i][0].ToString();
                    Customer[i].First_name = dt.Rows[i][1].ToString();
                    Customer[i].Last_name = dt.Rows[i][2].ToString();
                    Customer[i].Phone_number = dt.Rows[i][3].ToString();
                    Customer[i].Address = dt.Rows[i][4].ToString();

                }
            }
            return Customer;

        }

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
                    Customer[i].Id = dt.Rows[i][0].ToString();
                    Customer[i].First_name = dt.Rows[i][1].ToString();
                    Customer[i].Last_name = dt.Rows[i][2].ToString();
                    Customer[i].Phone_number = dt.Rows[i][3].ToString();
                    Customer[i].Address = dt.Rows[i][4].ToString();

                }
            }
            return Customer;

        }

        public supplier[] GetSupplierDataByFN(string name)
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

        public order_number_holder GetorderNumberHolder()
        {
            DataSet ds = new DataSet();
            order_number_holder Order_number_holder = null;
            string cmdStr = "SELECT * FROM order_number_holder";
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

                Order_number_holder = new order_number_holder();
                Order_number_holder.Order_number = Convert.ToInt32(dt.Rows[0][0]);
             
            }
            return Order_number_holder;

        }
      /*
        public void UpdateProductByBarcode(product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE barcode=@barcode";

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
        */
        public void UpdateProductAmountBySerial(int amount,string serial)
        {
            string cmdStr = "UPDATE product SET amount="+amount+" WHERE product_serial_number="+serial+"";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);
                
                base.ExecuteSimpleQuery(command);
            }
        }



        public void UpdateProductAmountByBarcode(int amount, string barcode)
        {
            string cmdStr = "UPDATE product SET amount=" + amount + " WHERE barcode=" + barcode + "";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateProductBySerial(Product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE product_serial_number=@product_serial_number";
           
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_serial_number", Item.Product_serial_number);
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

        public void UpdateProductByModel(Product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE product_model=@product_model";

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

        public void UpdateOrderById(string id,int status)
        {
            string cmdStr = "UPDATE orders SET status="+status+" WHERE customer_id="+id+"";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@status", status);
                
                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateCustomerBySerial(customer Item)
        {
            string cmdStr = "UPDATE customer SET id=@id,first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number," +
                "address=@address WHERE serial_number =@serial_number";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@id", Item.Id);
                command.Parameters.AddWithValue("@first_name", Item.First_name);
                command.Parameters.AddWithValue("@last_name", Item.Last_name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);

                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateSupplierBySerial(supplier Item)
        {
            string cmdStr = "UPDATE supplier SET first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number,address=@address," +
                "dept=@dept,paid=@paid WHERE serial_number=@serial_number";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@first_name", Item.FirstName);
                command.Parameters.AddWithValue("@last_name", Item.LasttName);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);
                command.Parameters.AddWithValue("@dept", Item.Dept);
                command.Parameters.AddWithValue("@paid", Item.Paid);


                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateCartAmount(int productAmount,string productBarcode)
        {
            string cmdStr = "UPDATE cart SET amount=" + productAmount + " WHERE product_barcode="+ productBarcode + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", productAmount);
                
                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateProduct_orderAmount(string product_serial_number, string order_serial_number,int amount)
        {
            string cmdStr = "UPDATE product_order SET amount=" + amount + " WHERE product_serial_number=" + product_serial_number + " AND order_serial_number="+ order_serial_number + "";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@amount", amount);

                base.ExecuteSimpleQuery(command);
            }
        }

        public void clearCart()
        {
            string cmdStr = "DELETE FROM cart";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        public void clearOrderNumberHolder()
        {
            string cmdStr = "DELETE FROM order_number_holder";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        public void deleteItemFromCart(string item)
        {
            string cmdStr = "DELETE FROM cart WHERE product_barcode="+item+"";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        public void deleteProductFromProduct_cartByOrderNumberAndProductSerial(string product_serial_number,string order_serial_number)
        {
            string cmdStr = "DELETE FROM product_order WHERE product_serial_number=" + product_serial_number + " AND order_serial_number="+ order_serial_number +"";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        



        /*
        public void UpdateProductByBarcode(product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE barcode=@barcode";

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
       
        
        public void UpdateProductByModel(product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE product_model=@product_model";

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
        
        public void UpdateProductBySerial(product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category," +
                "product_model=@product_model,product_manufacturer=@product_manufacturer," +
                "product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price," +
                "amount=@amount,product_info=@product_info WHERE product_serial_number=@product_serial_number";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@product_serial_number", Item.Product_serial_number);
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

        public void UpdateCustomerBySerial(customer Item)
        {
            string cmdStr = "UPDATE customer SET id=@id,first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number," +
                "address=@address WHERE serial_number =@serial_number";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@id", Item.Id);
                command.Parameters.AddWithValue("@first_name", Item.First_name);
                command.Parameters.AddWithValue("@last_name", Item.Last_name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);

                base.ExecuteSimpleQuery(command);
            }
        }

        public void UpdateSupplierBySerial(supplier Item)
        {
            string cmdStr = "UPDATE supplier SET first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number,address=@address," +
                "dept=@dept,paid=@paid WHERE serial_number=@serial_number";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serial_number", Item.Serial_number);
                command.Parameters.AddWithValue("@first_name", Item.FirstName);
                command.Parameters.AddWithValue("@last_name", Item.LasttName);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);
                command.Parameters.AddWithValue("@dept", Item.Dept);
                command.Parameters.AddWithValue("@paid", Item.Paid);


                base.ExecuteSimpleQuery(command);
            }
        */
    }
        





    }


    



