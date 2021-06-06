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
    public partial class update_customer : Form
    {
        private System.Windows.Forms.ErrorProvider idErrorProvider;
        customer load_customers = new customer();
        DBSQL mySQL;
        int count = 0;

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
            load_customers = mySQL.GetCustomerDataByID(Convert.ToInt32(id.Text));
        }


        private void fill_obj(customer person)
        {
            person.Id = id.Text;
            person.First_name = first_name.Text;
            person.Last_name = last_name.Text;
            person.Phone_number = phone_number.Text;
            person.Address = address.Text;
        }



        private void btn_updateCustomer_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && check_id()==true && first_name.Text != "" && last_name.Text != ""
                && phone_number.Text != "" && check_phoneNumber()==true
                 && address.Text != "")
            {
                fill_obj(load_customers);
                mySQL.UpdateCustomerBySerial(load_customers);
                MessageBox.Show("לקוח עודכן בהצלחה");
                this.Close();
            }
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");

        }

        // פונקציה בודקת תקינות תעודת זהות של הלקוח
        private bool check_id()
        {
            return (this.id.Text.Length == 9);
        }
        private void id_Leave(object sender, EventArgs e)
        {
            // בודקים אם הנתונים בשדה לא תקינים ופעם ראשונה פונקציה id_leave מופעלת
            if (check_id() == false && count == 0)
            {
                // מקדמים מונה כניסות/הפעלות של פונקציה id_leave
                count++;
                // מגדירים שגאיה בהתאם
                idErrorProvider = new ErrorProvider();
                idErrorProvider.SetError(id, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
            }
            // לא פעם ראשונה id_leave מופעלת
            else
            {
                // פעם ראשונה מפעילים id_leave ונתונים בשדה תקינים
                if (check_id() == true && count == 0)
                {
                    //לא מבצעים פעולות
                    // נשאר count=0
                }
                else
                {
                    // לא פעם ראשונה מפעילים id_leave
                    // אם מגיעים לתנאי הזה יישארו שתי אןפציות
                    // 1) נתונים תקינים בשדה
                    if (check_id() == true)
                    {
                        idErrorProvider.SetError(id, "");
                    }
                    // 2) נתונים שגויים
                    else
                    {
                        //idErrorProvider = new ErrorProvider();
                        idErrorProvider.SetError(id, "תעודת זהות חייבת להכיל בדיוק 9 ספרות");
                    }
                }
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

        private void update_customer_MouseMove(object sender, MouseEventArgs e)
        {

            if (check_id() == false && check_phoneNumber() == false)
            {
                MessageBox.Show("תעודת זהות ומספר פלאפון לא תקינים");
            }
            else
            {
                if (check_phoneNumber() == false)
                {
                    MessageBox.Show("מספר פלאפון לא תקין");
                }
                else
                {
                    if (check_id() == false)
                        MessageBox.Show("תעודת זהות לא תקינה");
                }
            }
        }

    }
}


