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

       

        public void InsertProduct(product Item)
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
            string cmdStr = "INSERT INTO supplier (name,phone_number,address," +
                "dept,paid)" +
                " VALUES (@name,@phone_number,@address,@dept," +
                "@paid)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", Item.Name);
                command.Parameters.AddWithValue("@phone_number", Item.Phone_number);
                command.Parameters.AddWithValue("@address", Item.Address);
                command.Parameters.AddWithValue("@dept", Item.Dept);
                command.Parameters.AddWithValue("@paid", Item.Paid);

                base.ExecuteSimpleQuery(command);
            }
        }


        public bool checkCity(string cityName)
        {
            bool result = false;

            string cmdStr = "SELECT count(*) FROM city WHERE cityName=@cityName";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cityName", cityName);
                result = ExecuteScalarIntQuery(command) > 0;
            }

            return result;
        }


        public int GetCityMaxNumber()
        {
            int result;
            string cmdStr = "SELECT Max(cityCode) FROM city";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public product[] GetProductData()
        {
            DataSet ds = new DataSet();
            product[] Product = null;
            string cmdStr = "SELECT * FROM product";

            using(MySqlCommand command=new MySqlCommand(cmdStr))
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

            if(dt.Rows.Count>0)
            {
                Product = new product[dt.Rows.Count];

                for(int i=0;i<Product.Length;i++)
                {
                    Product[i] = new product();
                    Product[i].Barcode = Convert.ToInt64(dt.Rows[i][0]);
                    Product[i].Category = dt.Rows[i][1].ToString();
                    Product[i].Model = dt.Rows[i][2].ToString();
                    Product[i].Manufacturer = dt.Rows[i][3].ToString();
                    Product[i].Supplier = dt.Rows[i][4].ToString();
                    Product[i].Cost_price = Convert.ToInt32(dt.Rows[i][5]);
                    Product[i].Selling_price = Convert.ToInt32(dt.Rows[i][6]);
                    Product[i].Amount = Convert.ToInt32(dt.Rows[i][7]);
                    Product[i].Product_info = dt.Rows[i][8].ToString();
                }
            }
            return Product;

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
                    Customer[i].Id = dt.Rows[i][0].ToString();
                    Customer[i].First_name = dt.Rows[i][1].ToString();
                    Customer[i].Last_name = dt.Rows[i][2].ToString();
                    Customer[i].Phone_number = dt.Rows[i][3].ToString();
                    Customer[i].Address = dt.Rows[i][4].ToString();
                }
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

            if (dt.Rows.Count > 0)
            {
                Supplier = new supplier[dt.Rows.Count];

                for (int i = 0; i < Supplier.Length; i++)
                {
                    Supplier[i] = new supplier();
                    Supplier[i].Name = dt.Rows[i][0].ToString();
                    Supplier[i].Phone_number = dt.Rows[i][1].ToString();
                    Supplier[i].Address = dt.Rows[i][2].ToString();
                    Supplier[i].Dept = Convert.ToInt32(dt.Rows[i][3]);
                    Supplier[i].Paid = Convert.ToInt32(dt.Rows[i][4]);
                }
            }
            return Supplier;

        }


        public void UpdateProduct(product Item)
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

        public void UpdateCustomer(customer Item)
        {
            string cmdStr = "UPDATE customer SET id=@id,first_name=@first_name," +
                "last_name=@last_name,phone_number=@phone_number," +
                "address=@address WHERE id=@id";
                

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



    }
}
