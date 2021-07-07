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
    
    public partial class Frm_addCustomer : Form
    {
        private readonly DBSQL mySQL;
        Thread th;
        int count = 0;
        private ErrorProvider idErrorProvider;
        readonly AutoCompleteStringCollection id1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection firstName1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection lastName1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection addrees1 = new AutoCompleteStringCollection();

        public Frm_addCustomer()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }
        
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenMain(object obj)
        {
            Application.Run(new main());
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            th = new Thread(OpenMain);
            th.TrySetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            bool same = false;

            if(Txt_customerId.Text!="" && Check_id()==true && Txt_firstName.Text!=""&&Txt_lastName.Text!=""
                &&Txt_phoneNumber.Text!="" && Check_phoneNumber()==true && Txt_address.Text!="")
            {
                customer[] Customer = mySQL.GetCustomerData();
                customer cust = new customer();
                string idTmp = Txt_customerId.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString())
                    {
                        same = true;
                        
                    }
                }

                if(same)
                {
                    Same_customer(cust);
                }
                else
                {
                    New_customer(cust);
                }
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות,יש למלא את כל השדות");
         
        }

      
        private void New_customer(customer cust)
        {
            cust.Id =Txt_customerId.Text;
            cust.First_name = Txt_firstName.Text;
            cust.Last_name = Txt_lastName.Text;
            cust.Phone_number = Txt_phoneNumber.Text;
            cust.Address = Txt_address.Text;
            mySQL.InsertCustomer(cust);

            MessageBox.Show("לקוח הוסף בהצלחה");
            Clear_boxes();
        }

        private void Same_customer(customer cust)
        {
            cust.Id= Txt_customerId.Text;
            cust.First_name = Txt_firstName.Text;
            cust.Last_name = Txt_lastName.Text;
            cust.Phone_number= Txt_phoneNumber.Text;
            cust.Address = Txt_address.Text;
            mySQL.UpdateCustomer(cust);

            MessageBox.Show("לקוח קיים , עודכן בהצלחה");
            Clear_boxes();
        }

        private void Clear_boxes()
        {
            Txt_customerId.Text = string.Empty;
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_address.Text = string.Empty;
        }

        private void Frm_addCustomer_Load(object sender, EventArgs e)
        {
            customer[] Customer = mySQL.GetCustomerData();


            for (int i = 0; i < Customer.Length; i++)
            {
                id1.Add(Customer[i].Id.ToString());
                firstName1.Add(Customer[i].First_name);
                lastName1.Add(Customer[i].Last_name);
                addrees1.Add(Customer[i].Address);

            }
            Txt_customerId.AutoCompleteCustomSource = id1;
            Txt_firstName.AutoCompleteCustomSource = firstName1;
            Txt_lastName.AutoCompleteCustomSource = lastName1;
            Txt_address.AutoCompleteCustomSource = addrees1;
        }

        private bool Check_id()
        {
            return (this.Txt_customerId.Text.Length == 9);
        }
        private void Txt_customerId_Leave(object sender, EventArgs e)
        {
            // בודקים תקינות קלט
            if (Check_id() == false && count == 0)
            {
                count++;
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(Txt_customerId, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
            }
            else
            {
                if (Check_id() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    if (Check_id() == true)
                    {
                        idErrorProvider.SetError(Txt_customerId, "");
                    }
                    else
                    {
                        idErrorProvider.SetError(Txt_customerId, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
                    }
                }
                // בודקים אם לקוח קיים לפי תעודת זהות
                if (Txt_customerId.Text != "")
                {
                    customer[] Customer = mySQL.GetCustomerData();
                    string idTmp = Txt_customerId.Text;

                    for (int i = 0; i < Customer.Length; i++)
                    {
                        if (idTmp == Customer[i].Id.ToString())
                        {
                            Txt_customerId.Text = Customer[i].Id.ToString();
                            Txt_firstName.Text = Customer[i].First_name;
                            Txt_lastName.Text = Customer[i].Last_name;
                            Txt_phoneNumber.Text = Customer[i].Phone_number;
                            Txt_address.Text = Customer[i].Address;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");
                }
            }
        }

        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private bool Check_phoneNumber()
        {
            return (Txt_phoneNumber.Text.Length == 10);
        }


        private void Txt_phoneNumber_Leave(object sender, EventArgs e)
        {

            // בודקים אם הנתונים בשדה לא תקינים ופעם ראשונה פונקציה phone_number_leave מופעלת
            if (Check_phoneNumber() == false && count == 0)
            {
                // מקדמים מונה כניסות/הפעלות של פונקציה phone_number_leave
                count++;
                // מגדירים שגאיה בהתאם
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(Txt_phoneNumber, "מספר פלאפון חייב להכיל 10 ספרות");
            }
            // לא פעם ראשונה phone_number_leave מופעלת
            else
            {
                // פעם ראשונה מפעילים phone_number_leave ונתונים בשדה תקינים
                if (Check_phoneNumber() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    // לא פעם ראשונה מפעילים phone_number_leave
                    // אם מגיעים לתנאי הזה יישארו שתי אןפציות
                    // 1) נתונים תקינים בשדה
                    if (Check_phoneNumber() == true)
                    {
                        idErrorProvider.SetError(Txt_phoneNumber, "");
                    }
                    // 2) נתונים שגויים
                    else
                    {
                        idErrorProvider.SetError(Txt_phoneNumber, "מספר פלאפון חייב להכיל 10 ספרות");
                    }
                }
            }
        }
    }
}
