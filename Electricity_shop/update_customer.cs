using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Electricity_shop
{
    public partial class Frm_update_customer : Form
    {
        private System.Windows.Forms.ErrorProvider idErrorProvider;
        customer load_customers = new customer();
        readonly DBSQL mySQL;
        int count = 0;

        public Frm_update_customer()
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
            Frm_main mainForm = new Frm_main();
            mainForm.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_main mainForm = new Frm_main();
            mainForm.Show();
        }

        private void Frm_update_customer_Load(object sender, EventArgs e)
        {
            load_customers = mySQL.GetCustomerDataByID(Txt_customerId.Text);
        }


        private void Fill_obj(customer person)
        {
            person.Id = Txt_customerId.Text;
            person.First_name = Txt_firstName.Text;
            person.Last_name = Txt_lastName.Text;
            person.Phone_number = Txt_phoneNumber.Text;
            person.Address = Txt_address.Text;
        }



        private void Btn_updateCustomer_Click(object sender, EventArgs e)
        {

            if (Check_id() == true && Txt_firstName.Text != "" && Txt_lastName.Text != ""
                && Txt_phoneNumber.Text != "" && Check_phoneNumber() == true
                 && Txt_address.Text != "")
            {
                Fill_obj(load_customers);
                mySQL.UpdateCustomerBySerial(load_customers);
                MessageBox.Show("לקוח עודכן בהצלחה");
                this.Close();
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");

        }

        // פונקציה בודקת תקינות תעודת זהות של הלקוח
        private bool Check_id()
        {
            return (this.Txt_customerId.Text.Length == 9 || this.Txt_customerId.Text.Length == 0);
        }
        private void Txt_customerId_Leave(object sender, EventArgs e)
        {
            // בודקים אם הנתונים בשדה לא תקינים ופעם ראשונה פונקציה id_leave מופעלת
            if (Check_id() == false && count == 0)
            {
                // מקדמים מונה כניסות/הפעלות של פונקציה id_leave
                count++;
                // מגדירים שגאיה בהתאם
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(Txt_customerId, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
            }
            // לא פעם ראשונה id_leave מופעלת
            else
            {
                // פעם ראשונה מפעילים id_leave ונתונים בשדה תקינים
                if (Check_id() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    // לא פעם ראשונה מפעילים id_leave
                    // אם מגיעים לתנאי הזה יישארו שתי אןפציות
                    // 1) נתונים תקינים בשדה
                    if (Check_id() == true)
                    {
                        idErrorProvider.SetError(Txt_customerId, "");
                    }
                    // 2) נתונים שגויים
                    else
                    {
                        //idErrorProvider = new ErrorProvider();
                        idErrorProvider.SetError(Txt_customerId, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
                    }
                }
            }
            // בודקים אם לקוח קיים לפי תעודת זהות
            if (Txt_customerId.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                string idTmp = Txt_customerId.Text;

                for (int i = 0; i < Customer.Length; i++)
                {
                    if (idTmp == Customer[i].Id.ToString() && load_customers.Phone_number.ToString() != Customer[i].Phone_number.ToString())
                    {
                        MessageBox.Show("תעודת זהות שייכת ללקוח אחר");
                        Txt_customerId.Text = Customer[i].Id.ToString();
                        Txt_firstName.Text = Customer[i].First_name;
                        Txt_lastName.Text = Customer[i].Last_name;
                        Txt_phoneNumber.Text = Customer[i].Phone_number;
                        Txt_address.Text = Customer[i].Address;

                    }
                }
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
                // בודקים אם לקוח קיים לפי מספר פלאפון
                if (Txt_phoneNumber.Text != "")
                {
                    customer[] Customer = mySQL.GetCustomerData();
                    string phoneTmp = Txt_phoneNumber.Text;

                    for (int i = 0; i < Customer.Length; i++)
                    {
                        if (phoneTmp == Customer[i].Phone_number.ToString() && load_customers.Id.ToString() != Customer[i].Id.ToString())
                        {
                            MessageBox.Show("מספר פלאפון שייכת ללקוח אחר");
                            Txt_customerId.Text = Customer[i].Id.ToString();
                            Txt_firstName.Text = Customer[i].First_name;
                            Txt_lastName.Text = Customer[i].Last_name;
                            Txt_phoneNumber.Text = Customer[i].Phone_number;
                            Txt_address.Text = Customer[i].Address;

                        }
                    }
                }
            }
        }

        private void Frm_update_customer_MouseMove(object sender, MouseEventArgs e)
        {

            if (Check_id() == false && Check_phoneNumber() == false)
            {
                MessageBox.Show("תעודת זהות ומספר פלאפון לא תקינים");
            }
            else
            {
                if (Check_phoneNumber() == false)
                {
                    MessageBox.Show("מספר פלאפון לא תקין");
                }
                else
                {
                    if (Check_id() == false)
                        MessageBox.Show("תעודת זהות לא תקינה");
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
    }
}


