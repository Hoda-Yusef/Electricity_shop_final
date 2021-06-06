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
    
    public partial class add_customer : Form
    {
        private DBSQL mySQL;
        Thread th;
        int count = 0;
        private System.Windows.Forms.ErrorProvider idErrorProvider;
        AutoCompleteStringCollection id1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection firstName1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection lastName1 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection addrees1 = new AutoCompleteStringCollection();

        public add_customer()
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
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openMain(object obj)
        {
            Application.Run(new main());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(openMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool same = false;

            if(ID_text.Text!=""&& check_id()==true && first_name.Text!=""&&last_name.Text!=""
                &&phone_number.Text!="" && check_phoneNumber()==true && address.Text!="")
            {
                customer[] Customer = mySQL.GetCustomerData();
                customer cust = new customer();
                string idTmp = ID_text.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {
                        same = true;
                        
                    }
                }

                if(same)
                {
                    same_customer(cust); 
                }
                else
                {
                    new_customer(cust);
                }
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדותיש למלא את כל השדות");
        }

        private void new_customer(customer cust)
        {
            cust.Id =ID_text.Text;
            cust.First_name = first_name.Text;
            cust.Last_name = last_name.Text;
            cust.Phone_number = phone_number.Text;
            cust.Address = address.Text;
            mySQL.InsertCustomer(cust);

            MessageBox.Show("לקוח הוסף בהצלחה");
            clear_boxes();
        }

        private void same_customer(customer cust)
        {
            cust.Id= ID_text.Text;
            cust.First_name = first_name.Text;
            cust.Last_name = last_name.Text;
            cust.Phone_number= phone_number.Text;
            cust.Address = address.Text;
            mySQL.UpdateCustomer(cust);

            MessageBox.Show("לקוח קיים , עודכן בהצלחה");
            clear_boxes();
        }

        private void clear_boxes()
        {
            ID_text.Text = string.Empty;
            first_name.Text = string.Empty;
            last_name.Text = string.Empty;
            phone_number.Text = string.Empty;
            address.Text = string.Empty;
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();


            for (int i = 0; i < Customer.Length; i++)
            {
                id1.Add(Customer[i].Id.ToString());
                firstName1.Add(Customer[i].First_name);
                lastName1.Add(Customer[i].Last_name);
                addrees1.Add(Customer[i].Address);

            }
            ID_text.AutoCompleteCustomSource = id1;
            first_name.AutoCompleteCustomSource = firstName1;
            last_name.AutoCompleteCustomSource = lastName1;
            address.AutoCompleteCustomSource = addrees1;
        }

        private bool check_id()
        {
            return (this.ID_text.Text.Length == 9);
        }
        private void ID_text_Leave(object sender, EventArgs e)
        {
            // בודקים תקינות קלט
            if (check_id() == false && count == 0)
            {
                count++;
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(ID_text, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
            }
            else
            {
                if (check_id() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (check_id() == true)
                    {
                        idErrorProvider.SetError(ID_text, "");
                    }
                    else
                    {
                        idErrorProvider.SetError(ID_text, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
                    }
                }
                // בודקים אם לקוח קיים לפי תעודת זהות
                if (ID_text.Text != "")
                {
                    customer[] Customer = mySQL.GetCustomerData();
                    string idTmp = ID_text.Text;

                    for (int i = 0; i < Customer.Length; i++)
                    {
                        if (idTmp == Customer[i].Id.ToString())
                        {
                            ID_text.Text = Customer[i].Id.ToString();
                            first_name.Text = Customer[i].First_name;
                            last_name.Text = Customer[i].Last_name;
                            phone_number.Text = Customer[i].Phone_number;
                            address.Text = Customer[i].Address;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");
                }
            }
        }

        private void ID_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private bool check_phoneNumber()
        {
            return (phone_number.Text.Length == 10);
        }


        private void phone_number_Leave(object sender, EventArgs e)
        {

            // בודקים אם הנתונים בשדה לא תקינים ופעם ראשונה פונקציה phone_number_leave מופעלת
            if (check_phoneNumber() == false && count == 0)
            {
                // מקדמים מונה כניסות/הפעלות של פונקציה phone_number_leave
                count++;
                // מגדירים שגאיה בהתאם
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(phone_number, "מספר פלאפון חייב להכיל 10 ספרות");
            }
            // לא פעם ראשונה phone_number_leave מופעלת
            else
            {
                // פעם ראשונה מפעילים phone_number_leave ונתונים בשדה תקינים
                if (check_phoneNumber() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    // לא פעם ראשונה מפעילים phone_number_leave
                    // אם מגיעים לתנאי הזה יישארו שתי אןפציות
                    // 1) נתונים תקינים בשדה
                    if (check_phoneNumber() == true)
                    {
                        idErrorProvider.SetError(phone_number, "");
                    }
                    // 2) נתונים שגויים
                    else
                    {
                        idErrorProvider.SetError(phone_number, "מספר פלאפון חייב להכיל 10 ספרות");
                    }
                }
            }
        }
    }
}
