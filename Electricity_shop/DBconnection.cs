//Hoda Khier + Yusef Aborokon 44/5

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Electricity_shop
{
    public class DBconnection
    {
        protected static string baseDataBaseName = string.Empty;
        protected static string baseUserName = string.Empty;
        protected static string basePassword = string.Empty;

        protected static string connString = string.Empty;

        private static DBconnection _instance = null;

        private static MySqlConnection connection = null;



        protected static DBconnection Instance()
        {
            bool result = true;

            if (_instance == null)
            {
                _instance = new DBconnection();
                result = !string.IsNullOrEmpty(baseDataBaseName);

                if (result)
                {
                    connString = string.Format("Server=localhost; database={0}; UID={1}; password={2}", baseDataBaseName, baseUserName, basePassword);
                    connection = new MySqlConnection(connString);
                }
            }
            return _instance;
        }

        private bool connect()
        {
            bool result = true;

            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                result = false;
            }
            return result;
        }

        public void close()
        {
            connection.Close();
        }

        protected bool ExecuteSimpleQuery(MySqlCommand command)
        {
            bool result = true;

            lock (connection)
            {
                if (connect())
                {
                    command.Connection = connection;
                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (Exception e)
                    {
                        result = false;
                    }

                    finally
                    {
                        close();
                    }
                }
            }

            return result;
        }

        protected int ExecuteScalarIntQuery(MySqlCommand command)
        {
            int result = -1;

            lock (connection)
            {
                if (connect())
                {
                    command.Connection = connection;
                    try
                    {
                        result = Convert.ToInt32(command.ExecuteScalar());
                    }

                    catch (Exception e)
                    {
                        result = -1;
                    }

                    finally
                    {
                        close();
                    }
                }

                return result;
            }
        }

        protected DataSet GetMultipleQuery(MySqlCommand command)
        {
            DataSet dataset = new DataSet();
            lock (connection)
            {
                if (connect())
                {
                    command.Connection = connection;
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dataset);
                    }

                    catch (Exception e)
                    {
                        dataset = null;
                    }

                    finally
                    {
                        close();
                    }

                }
            }
            return dataset;
        }


    }
}
