//Hoda Khier + Yusef Aborokon 44/5

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Electricity_shop
{
    public partial class Frm_login : Form
    {
        Thread th;
        user[] Users=null;
        private DBSQL mySQL;
        // מגדירים התחברות כמנהל
        int currentUsersRole = 1;

        public Frm_login()
        {
            InitializeComponent();
            DBSQL.DaseDataBaseName = "electricity_shop";
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

       

        private void Btn_exit_MouseHover(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        private void Btn_exit_MouseLeave(object sender, EventArgs e)
        {
            Btn_exit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void Btn_entry_Click(object sender, EventArgs e)
        {
            //בודק אם המשתמש הזין את שם משתמש וסיסמה
            if (Txt_username.Text != "" && Txt_username.Text != "שם משתמש" && Txt_password.Text != "" && Txt_password.Text != "סיסמה")
            {
                Users = mySQL.GetUsersData();
                //בודק אם שם משתמש וסיסימה תואמים ממה שמוגדר בבסיס נתונים
                for (int rows = 0; rows < Users.Length; rows++)
                {
                    if (Txt_username.Text == Users[rows].Username && Txt_password.Text == Users[rows].Password)
                    {//אם כן עוברים לחלון ראשי
                        if (Users[rows].Role == 1)
                        {
                            //מתחברים כמנהל
                            
                            this.Close();
                            th = new Thread(opennewform);
                            th.TrySetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else
                        {
                            //מתחברים כעובד
                            currentUsersRole = 0;
                            this.Close();
                            th = new Thread(OpenEmployeesMain);
                            th.TrySetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                    else
                      Lbl_wrongPasswordMessage.Text = "* סיסמה או שם משתמש שגויים";
                }
            }
              else
                  Lbl_wrongPasswordMessage.Text="* נא להזין שם משתמש וסיסמה תקינים";
        }

        private void opennewform(object obj)
        {
            Application.Run(new Frm_main(currentUsersRole));//פתיחת חלון ראשי
        }

        private void OpenEmployeesMain(object obj)
        {
            Application.Run(new Frm_mainForEmployees(currentUsersRole));//פתיחת חלון ראשי
        }

        private void Btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_exit.BackColor = Color.White;
        }

        private void Txt_username_Click(object sender, EventArgs e)
        {
            if (Txt_username.Text == "שם משתמש")
                Txt_username.Clear();

            panel.BackColor = Color.FromArgb(0, 113, 184);
            panel1.BackColor = Color.White;
        }

        private void Txt_password_Click(object sender, EventArgs e)
        {
            Txt_password.Clear();

            if (Txt_username.Text == "")
            {
                Txt_username.Text = "שם משתמש";
            }

            Txt_password.PasswordChar = '*';
            panel1.BackColor = Color.FromArgb(0, 113, 184);
            panel.BackColor = Color.White;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            Users = mySQL.GetUsersData();//טעינת שמות משתמשים וסיסמאות
        }

        
    }
}
