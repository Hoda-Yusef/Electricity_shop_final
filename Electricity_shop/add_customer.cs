//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Electricity_shop
{
    //מחלקה שמוסיפה לקוח לבסיס נתונים
    public partial class Frm_addCustomer : Form
    {
        bool drag = false;
        Point sp = new Point(0, 0);
        private readonly DBSQL mySQL;
        Thread th;
        int count = 0;
        private ErrorProvider idErrorProvider;
        readonly AutoCompleteStringCollection id1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection firstName1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection lastName1 = new AutoCompleteStringCollection();
        readonly AutoCompleteStringCollection addrees1 = new AutoCompleteStringCollection();
        int usersRole;
        string userName;
        public Frm_addCustomer(int role,string username)
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            usersRole = role;
            userName = username;
        }
        //לחיצה על כפתור ביטול
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(usersRole,userName));
        }
        //פתיחת טופס ראשי
        private void OpenMain(object obj)
        {
            Application.Run(new Frm_main(usersRole, userName));
        }
        //לחיצה על כפתור X
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            if (usersRole == 1)
            {
                this.Close();
                th = new Thread(OpenMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                this.Close();
                th = new Thread(OpenEmployeesMain);
                th.TrySetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        //לחיצה על כפתור הוספה
        private void Btn_addCustomer_Click(object sender, EventArgs e)
        {
            bool same = false;
            //בודקים תקינות קלט
            if (Txt_customerId.Text != "" && Check_id() == true && Txt_firstName.Text != "" && Txt_lastName.Text != ""
                && Txt_phoneNumber.Text != "" && Check_phoneNumber() == true && Txt_address.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                customer cust = new customer();
                string idTmp = Txt_customerId.Text;

                if (Customer != null)
                {
                    for (int i = 0; i < Customer.Length; i++)
                    {
                        //בודקים אם הלקוח קיים
                        if (idTmp == Customer[i].Id.ToString())
                        {
                            same = true;
                        }
                    }
                }
                checkIfSameCustomer(same,cust);
                
            }
            //חסר נתונים או נתונים לא תקינים
            else
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות,יש למלא את כל השדות");

        }

        private void checkIfSameCustomer(bool same, customer cust)
        {
            if (same)
            {
                //לקוח קיים מציגים את פרטיו בתיבות הטקסט בהתאם
                Same_customer(cust);
            }
            else
            {
                //לקוח חדש
                New_customer(cust);
            }
        }



        //פונקציה יוצרת לקוח חדש
        private void New_customer(customer cust)
        {
            cust.Id = Txt_customerId.Text;
            cust.First_name = Txt_firstName.Text;
            cust.Last_name = Txt_lastName.Text;
            cust.Phone_number = Txt_phoneNumber.Text;
            cust.Address = Txt_address.Text;
            mySQL.InsertCustomer(cust);

            MessageBox.Show("לקוח הוסף בהצלחה");
            Clear_boxes();
        }
        //פונקציה מציגה פרטי לקוח קייםבתיבות טקסט המתאימות
        //אפשר לעדכן פרטים אלה 
        private void Same_customer(customer cust)
        {
            cust.Id = Txt_customerId.Text;
            cust.First_name = Txt_firstName.Text;
            cust.Last_name = Txt_lastName.Text;
            cust.Phone_number = Txt_phoneNumber.Text;
            cust.Address = Txt_address.Text;
            mySQL.UpdateCustomer(cust);

            MessageBox.Show("לקוח קיים , עודכן בהצלחה");
            Clear_boxes();
        }
        //פונקציה מנקה את כל השדות
        private void Clear_boxes()
        {
            Txt_customerId.Text = string.Empty;
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
            Txt_address.Text = string.Empty;
        }
        //טעינת טופס נוכחי
        private void Frm_addCustomer_Load(object sender, EventArgs e)
        {
            //שומרים נתוני כל הלקוחות הקיימים במערכת
            customer[] Customer = mySQL.GetCustomerData();

            if (Customer != null)
            {
                //מגדירים אופציות בשדות למילוי אוטומטי
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
        }
        //פונקציה בודקת תעודת זהות של הלקוח
        //מחזירה אמת אם תקינה ושקר אחרת
        private bool Check_id()
        {
            return (this.Txt_customerId.Text.Length == 9);
        }
        //עזיבת שדה תעודת זהות של הלקוח
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
                checkExistingCustomerById();
                
            }
        }
        // בודקים אם לקוח קיים לפי תעודת זהות

        private void checkExistingCustomerById()
        {
            if (Txt_customerId.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                string idTmp = Txt_customerId.Text;

                if (Customer != null)
                {

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
            }
            else
            {
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");
            }
        }

        private void checkExistingCustomerByPhone()
        {
            if (Txt_phoneNumber.Text != "")
            {
                customer[] Customer = mySQL.GetCustomerData();
                string phoneTmp = Txt_phoneNumber.Text;

                if (Customer != null)
                {

                    for (int i = 0; i < Customer.Length; i++)
                    {
                        if (phoneTmp == Customer[i].Phone_number.ToString())
                        {
                            Txt_customerId.Text = Customer[i].Id.ToString();
                            Txt_firstName.Text = Customer[i].First_name;
                            Txt_lastName.Text = Customer[i].Last_name;
                            Txt_phoneNumber.Text = Customer[i].Phone_number;
                            Txt_address.Text = Customer[i].Address;

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("קלט לא תקין: נא לבדוק תקינות נתונים בשדות");
            }
        }

        //הגדרת סוג תו שאפשר לקלוט
        private void Txt_customerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //הגדרת סוג תו שאפשר לקלוט
        private void Txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //רק מספרים
            if (!char.IsDigit(ch) && ch != 8 && ch != 9 && ch != 11)
            {
                e.Handled = true;
            }
        }
        //פונקציה בודקת תקינות מספר פלאפון של הלקוח
        //אם תקין תחזיר אמת ושקר אחרת
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
                    checkExistingCustomerByPhone();
                }
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Txt_address.Text = string.Empty;
            Txt_customerId.Text = string.Empty;
            Txt_firstName.Text = string.Empty;
            Txt_lastName.Text = string.Empty;
            Txt_phoneNumber.Text = string.Empty;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            sp = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - sp.X, p.Y - sp.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
