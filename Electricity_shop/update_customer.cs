using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class update_customer : Form
    {
       // customer first_load = new customer();
        customer load_customers = new customer();
        //private static int serial_number=0;
        DBSQL mySQL;

        //bool drag = false;
        //Point sp = new Point(0, 0);

        public update_customer()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            main mainForm = new main();
            mainForm.Show();
        }

        private void update_customer_Load(object sender, EventArgs e)
        {
            //fill_obj(first_load);
              load_customers = mySQL.GetCustomerDataByID(Convert.ToInt32(id.Text));
        }


        private void fill_obj(customer person)
        {
            person.Id =Convert.ToInt32(id.Text);
            person.First_name = first_name.Text;
            person.Last_name = last_name.Text;
            person.Phone_number = phone_number.Text;
            person.Address = address.Text;
        }

        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {

            if (id.Text != "" && first_name.Text != "" && last_name.Text != "" 
                && phone_number.Text != ""
                 && address.Text != "")
            {
                fill_obj(load_customers);
                 mySQL.UpdateCustomerBySerial(load_customers);
                 MessageBox.Show("מוצר עודכן בהצלחה");
                 this.Close();
            }
            else
                MessageBox.Show("יש למלא את כל השדות");

        }
        /*
        private int ID_serial()
        {
            customer[] Customer = mySQL.GetCustomerData();
            // שומרים תעודת זהות נוכחית
            string idTmp = id.Text;

            for (int i = 0; i < Customer.Length; i++)
            {
                if (idTmp == Customer[i].Id.ToString())
                {
                    serial_number = mySQL.getSerialNumber(idTmp);
                    break;
                }
            }
            return serial_number;
        }
        */
    }
}

