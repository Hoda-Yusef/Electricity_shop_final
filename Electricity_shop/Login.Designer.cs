
using System;

namespace Electricity_shop
{
    partial class Frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.PictureBox();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.PictureBox();
            this.Btn_entry = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.password_user_wrong_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_exit
            // 
            resources.ApplyResources(this.Btn_exit, "Btn_exit");
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            this.Btn_exit.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.Btn_exit.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.Btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // user
            // 
            resources.ApplyResources(this.user, "user");
            this.user.Name = "user";
            this.user.TabStop = false;
            // 
            // Txt_username
            // 
            this.Txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Txt_username, "Txt_username");
            this.Txt_username.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Click += new System.EventHandler(this.Txt_username_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // Txt_password
            // 
            this.Txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Txt_password, "Txt_password");
            this.Txt_password.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Click += new System.EventHandler(this.Txt_password_Click);
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.TabStop = false;
            // 
            // Btn_entry
            // 
            this.Btn_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_entry.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Btn_entry, "Btn_entry");
            this.Btn_entry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_entry.Name = "Btn_entry";
            this.Btn_entry.UseVisualStyleBackColor = false;
            this.Btn_entry.Click += new System.EventHandler(this.entry_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // password_user_wrong_message
            // 
            resources.ApplyResources(this.password_user_wrong_message, "password_user_wrong_message");
            this.password_user_wrong_message.ForeColor = System.Drawing.Color.Red;
            this.password_user_wrong_message.Name = "password_user_wrong_message";
            // 
            // Frm_login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.password_user_wrong_message);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.Btn_entry);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.PictureBox password;
        private System.Windows.Forms.Button Btn_entry;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label password_user_wrong_message;
    }
}

