//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Windows.Forms;



namespace Electricity_shop
{
    public partial class Frm_update_customer : Form
    {
        private System.Windows.Forms.ErrorProvider idErrorProvider;
        customer load_customers = new customer();
        readonly DBSQL mySQL;
        int count = 0;
        bool drag = false;
        Point sp = new Point(0, 0);
        int usersRole;

        public Frm_update_customer(int role)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
        }
        //לחיצה על כפתור ביטול
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                Frm_main mainForm = new Frm_main(usersRole);
                mainForm.Show();
            }
            else
            {
                this.Close();
                Frm_mainForEmployees mainForm = new Frm_mainForEmployees(usersRole);
                mainForm.Show();
            }

        }
        //לחיצה על כפתור X
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                Frm_main mainForm = new Frm_main(usersRole);
                mainForm.Show();
            }
            else
            {
                this.Close();
                Frm_mainForEmployees mainForm = new Frm_mainForEmployees(usersRole);
                mainForm.Show();
            }
        }
        //טעינת טופס נוכחי
        private void Frm_update_customer_Load(object sender, EventArgs e)
        {
            load_customers = mySQL.GetCustomerDataByID(Txt_customerId.Text);
        }

        //הגדרת תכונות אובייקט שמועבר לפונקציה לפי ערכים בשדות הטקסט בהתאמה
        private void Fill_obj(customer person)
        {
            person.Id = Txt_customerId.Text;
            person.First_name = Txt_firstName.Text;
            person.Last_name = Txt_lastName.Text;
            person.Phone_number = Txt_phoneNumber.Text;
            person.Address = Txt_address.Text;
        }


        //לחיצה על כפתור עדכן
        private void Btn_updateCustomer_Click(object sender, EventArgs e)
        {
            //בודקים תקינות קלט בכל השדות
            if (Check_id() == true && Txt_firstName.Text != "" && Txt_lastName.Text != ""
                && Txt_phoneNumber.Text != "" && Check_phoneNumber() == true
                 && Txt_address.Text != "")
            {
                //מוסיפים לקוח 
                Fill_obj(load_customers);
                mySQL.UpdateCustomerBySerial(load_customers);
                MessageBox.Show("לקוח עודכן בהצלחה");
                this.Close();
            }
            //קלט לא תקין
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

                if (Customer != null)
                {
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
        }
        //פונקציה בודקת תקינות מספר פלאפון
        private bool Check_phoneNumber()
        {
            return (Txt_phoneNumber.Text.Length == 10);
        }
        //עזיבת שדה מספר פלאפון
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

                    if (Customer != null)
                    {

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
        }

        //הזזת עכבר על פני הטופס
        private void Frm_update_customer_MouseMove(object sender, MouseEventArgs e)
        {
            //בודקים תקינות תעודת זהות ומספר פלאפון
            if (Check_id() == false && Check_phoneNumber() == false)
            {
                //שניהם לא תקינים
                MessageBox.Show("תעודת זהות ומספר פלאפון לא תקינים");
            }
            else
            {
                if (Check_phoneNumber() == false)
                {
                    //מספר פלאפון לא תקין
                    MessageBox.Show("מספר פלאפון לא תקין");
                }
                else
                {
                    //ת.ז לא תקינה
                    if (Check_id() == false)
                        MessageBox.Show("תעודת זהות לא תקינה");
                }
            }
        }

        //הגדרת סוג תו שניתן לכתוב בשדה תעודת זהות של הלקוח
        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}


