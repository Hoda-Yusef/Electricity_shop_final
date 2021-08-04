
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
            this.Pic_login = new System.Windows.Forms.PictureBox();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Pic_user = new System.Windows.Forms.PictureBox();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.Pic_password = new System.Windows.Forms.PictureBox();
            this.Btn_entry = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_wrongPasswordMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_password)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_login
            // 
            resources.ApplyResources(this.Pic_login, "Pic_login");
            this.Pic_login.Name = "Pic_login";
            this.Pic_login.TabStop = false;
            this.Pic_login.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_exit
            // 
            resources.ApplyResources(this.Btn_exit, "Btn_exit");
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            this.Btn_exit.MouseLeave += new System.EventHandler(this.Btn_exit_MouseLeave);
            this.Btn_exit.MouseHover += new System.EventHandler(this.Btn_exit_MouseHover);
            this.Btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_exit_MouseMove);
            // 
            // Pic_user
            // 
            resources.ApplyResources(this.Pic_user, "Pic_user");
            this.Pic_user.Name = "Pic_user";
            this.Pic_user.TabStop = false;
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
            // Pic_password
            // 
            resources.ApplyResources(this.Pic_password, "Pic_password");
            this.Pic_password.Name = "Pic_password";
            this.Pic_password.TabStop = false;
            // 
            // Btn_entry
            // 
            this.Btn_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_entry.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Btn_entry, "Btn_entry");
            this.Btn_entry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_entry.Name = "Btn_entry";
            this.Btn_entry.UseVisualStyleBackColor = false;
            this.Btn_entry.Click += new System.EventHandler(this.Btn_entry_Click);
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
            // Lbl_wrongPasswordMessage
            // 
            resources.ApplyResources(this.Lbl_wrongPasswordMessage, "Lbl_wrongPasswordMessage");
            this.Lbl_wrongPasswordMessage.ForeColor = System.Drawing.Color.Red;
            this.Lbl_wrongPasswordMessage.Name = "Lbl_wrongPasswordMessage";
            // 
            // Frm_login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.Lbl_wrongPasswordMessage);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.Btn_entry);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.Pic_password);
            this.Controls.Add(this.Pic_user);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Pic_login);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_login;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.PictureBox Pic_user;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox Txt_password;
        private System.Windows.Forms.PictureBox Pic_password;
        private System.Windows.Forms.Button Btn_entry;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_wrongPasswordMessage;
    }
}

