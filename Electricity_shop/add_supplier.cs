using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    public partial class add_supplier : Form
    {
        private DBSQL mySQL;
        Thread th;
        AutoCompleteStringCollection Snumber = new AutoCompleteStringCollection();
        AutoCompleteStringCollection Saddress = new AutoCompleteStringCollection();
        public add_supplier()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

            set_AutoCompleteMode_text_boxes();
        }

        private void set_AutoCompleteMode_text_boxes()
        {
            address.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            address.AutoCompleteSource = AutoCompleteSource.CustomSource;

            phoneNumber.AutoCompleteMode = AutoCompleteMode.Suggest;
            phoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void opennewform(object obj)
        {
            Application.Run(new main());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool same = false;

            if (name.Text != "" && address.Text != "" && phoneNumber.Text != "")
            {
                supplier[] Supplier = mySQL.GetSupplierData();
                supplier supp = new supplier();
                string nameTmp = phoneNumber.Text;

                for (int i = 0; i < Supplier.Length; i++)
                {
                    if (nameTmp == Supplier[i].Phone_number)
                    {
                        same = true;

                    }
                }

                if (same)
                {
                    MessageBox.Show("ספק קיים");
                }
                else
                {
                    new_supplier(supp);
                }
            }
            else
                MessageBox.Show(" (חובה למלא את כל השדות (למעט חוב,שולם ");
        }


        private void new_supplier(supplier supp)
        {
            if (dept.Text != "" && paid.Text != "")
            {
                supp.Name = name.Text;
                supp.Address = address.Text;
                supp.Phone_number = phoneNumber.Text;
                supp.Dept = Convert.ToInt32(dept.Text);
                supp.Paid = Convert.ToInt32(paid.Text);
                mySQL.InsertSupplier(supp);

                MessageBox.Show("ספק הוסף בהצלחה");
                clear_boxes();
            }

            if(dept.Text==""&& paid.Text=="")
            {
                supp.Name = name.Text;
                supp.Address = address.Text;
                supp.Phone_number = phoneNumber.Text;
                mySQL.InsertSupplier(supp);

                MessageBox.Show("ספק הוסף בהצלחה");
                clear_boxes();
            }

            if(dept.Text!=""&&paid.Text=="")
            {
                supp.Name = name.Text;
                supp.Address = address.Text;
                supp.Phone_number = phoneNumber.Text;
                supp.Dept = Convert.ToInt32(dept.Text);
                mySQL.InsertSupplier(supp);

                MessageBox.Show("ספק הוסף בהצלחה");
                clear_boxes();
            }

        }

        private void clear_boxes()
        {
            name.Text = string.Empty;
            phoneNumber.Text = string.Empty;
            address.Text = string.Empty;
            dept.Text = string.Empty;
            paid.Text = string.Empty;
        }

        private void add_supplier_Load(object sender, EventArgs e)
        {
            supplier[] Supplier = mySQL.GetSupplierData();


            for (int i = 0; i < Supplier.Length; i++)
            {
                Saddress.Add(Supplier[i].Address);
                Snumber.Add(Supplier[i].Phone_number);


            }
            address.AutoCompleteCustomSource = Saddress;
            phoneNumber.AutoCompleteCustomSource = Snumber;
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!char.IsDigit(ch) && ch!=8 && ch!=9 && ch!=11)
            {
                e.Handled = true;
            }
        }

        private void dept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
    }
}
