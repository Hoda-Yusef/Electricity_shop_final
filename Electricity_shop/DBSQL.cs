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

        public void InsertProduct(product Item)
        {
            string cmdStr = "INSERT INTO product (barcode,product_category,product_model,product_manufacturer,product_supplier,cost_price,selling_price,amount,product_info) VALUES (@barcode,@product_category,@product_model,@product_manufacturer,@product_supplier,@cost_price,@selling_price,@amount,@product_info)";

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


        public void UpdateProduct(product Item)
        {
            string cmdStr = "UPDATE product SET barcode=@barcode,product_category=@product_category,product_model=@product_model,product_manufacturer=@product_manufacturer,product_supplier=@product_supplier,cost_price=@cost_price,selling_price=@selling_price,amount=@amount,product_info=@product_info WHERE barcode=@barcode";

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



    }
}
