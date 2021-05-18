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
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="שם משתמש")
                textBox1.Clear();

            panel.BackColor = Color.FromArgb(0, 113, 184);
            panel1.BackColor = Color.White;

           


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           
                textBox2.Clear();

            if (textBox1.Text == "")
            {
                textBox1.Text = "שם משתמש";
            }

            textBox2.PasswordChar = '*';
            panel1.BackColor = Color.FromArgb(0, 113, 184);
            panel.BackColor = Color.White;

            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void entry_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "שם משתמש" && textBox2.Text != "" && textBox2.Text != "סיסמה")
            {
                if (textBox1.Text == "yusef123" && textBox2.Text == "y123")
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.TrySetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                    password_user_wrong_message.Text = "* סיסמה או שם משתמש שגויים";

            }
            else
                password_user_wrong_message.Text="* כתוב שם משתמש או סיסמה";


        }

        private void opennewform(object obj)
        {
            Application.Run(new main());
        }
    }
}
