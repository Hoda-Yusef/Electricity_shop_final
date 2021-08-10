
using System;
using System.Windows.Forms;

namespace Electricity_shop
{
    partial class Frm_ContainerData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ContainerData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_products = new System.Windows.Forms.PictureBox();
            this.Pic_contact = new System.Windows.Forms.PictureBox();
            this.Pic_orders = new System.Windows.Forms.PictureBox();
            this.Btn_toMain = new System.Windows.Forms.Button();
            this.Btn_incomeAndOutcome = new System.Windows.Forms.Button();
            this.Btn_productsData = new System.Windows.Forms.Button();
            this.Btn_ordersData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_userName = new System.Windows.Forms.Label();
            this.Pic_userIcon = new System.Windows.Forms.PictureBox();
            this.Upper_BluePanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Pnl_container = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_contact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_orders)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_userIcon)).BeginInit();
            this.Upper_BluePanel.SuspendLayout();
            this.Pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Pic_products);
            this.panel1.Controls.Add(this.Pic_contact);
            this.panel1.Controls.Add(this.Pic_orders);
            this.panel1.Controls.Add(this.Btn_toMain);
            this.panel1.Controls.Add(this.Btn_incomeAndOutcome);
            this.panel1.Controls.Add(this.Btn_productsData);
            this.panel1.Controls.Add(this.Btn_ordersData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 609);
            this.panel1.TabIndex = 0;
            // 
            // Pic_products
            // 
            this.Pic_products.Image = ((System.Drawing.Image)(resources.GetObject("Pic_products.Image")));
            this.Pic_products.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_products.InitialImage")));
            this.Pic_products.Location = new System.Drawing.Point(183, 280);
            this.Pic_products.Name = "Pic_products";
            this.Pic_products.Size = new System.Drawing.Size(58, 50);
            this.Pic_products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_products.TabIndex = 1;
            this.Pic_products.TabStop = false;
            // 
            // Pic_contact
            // 
            this.Pic_contact.Image = ((System.Drawing.Image)(resources.GetObject("Pic_contact.Image")));
            this.Pic_contact.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_contact.InitialImage")));
            this.Pic_contact.Location = new System.Drawing.Point(183, 344);
            this.Pic_contact.Name = "Pic_contact";
            this.Pic_contact.Size = new System.Drawing.Size(58, 50);
            this.Pic_contact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_contact.TabIndex = 1;
            this.Pic_contact.TabStop = false;
            // 
            // Pic_orders
            // 
            this.Pic_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Pic_orders.Image = ((System.Drawing.Image)(resources.GetObject("Pic_orders.Image")));
            this.Pic_orders.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pic_orders.InitialImage")));
            this.Pic_orders.Location = new System.Drawing.Point(183, 218);
            this.Pic_orders.Name = "Pic_orders";
            this.Pic_orders.Size = new System.Drawing.Size(58, 50);
            this.Pic_orders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_orders.TabIndex = 1;
            this.Pic_orders.TabStop = false;
            // 
            // Btn_toMain
            // 
            this.Btn_toMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_toMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_toMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_toMain.Location = new System.Drawing.Point(0, 545);
            this.Btn_toMain.Name = "Btn_toMain";
            this.Btn_toMain.Size = new System.Drawing.Size(247, 64);
            this.Btn_toMain.TabIndex = 1;
            this.Btn_toMain.Text = "חזרה לראשי";
            this.Btn_toMain.UseVisualStyleBackColor = true;
            this.Btn_toMain.Click += new System.EventHandler(this.Btn_toMain_Click);
            // 
            // Btn_incomeAndOutcome
            // 
            this.Btn_incomeAndOutcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_incomeAndOutcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_incomeAndOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_incomeAndOutcome.Location = new System.Drawing.Point(0, 338);
            this.Btn_incomeAndOutcome.Name = "Btn_incomeAndOutcome";
            this.Btn_incomeAndOutcome.Size = new System.Drawing.Size(247, 64);
            this.Btn_incomeAndOutcome.TabIndex = 1;
            this.Btn_incomeAndOutcome.Text = "רווח והפסד";
            this.Btn_incomeAndOutcome.UseVisualStyleBackColor = true;
            this.Btn_incomeAndOutcome.Click += new System.EventHandler(this.Btn_incomeAndOutcome_Click);
            // 
            // Btn_productsData
            // 
            this.Btn_productsData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_productsData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_productsData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_productsData.Location = new System.Drawing.Point(0, 274);
            this.Btn_productsData.Name = "Btn_productsData";
            this.Btn_productsData.Size = new System.Drawing.Size(247, 64);
            this.Btn_productsData.TabIndex = 1;
            this.Btn_productsData.Text = "מוצרים";
            this.Btn_productsData.UseVisualStyleBackColor = true;
            this.Btn_productsData.Click += new System.EventHandler(this.Btn_productsData_Click);
            // 
            // Btn_ordersData
            // 
            this.Btn_ordersData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_ordersData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_ordersData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ordersData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_ordersData.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_ordersData.Location = new System.Drawing.Point(0, 210);
            this.Btn_ordersData.Name = "Btn_ordersData";
            this.Btn_ordersData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_ordersData.Size = new System.Drawing.Size(247, 64);
            this.Btn_ordersData.TabIndex = 1;
            this.Btn_ordersData.Text = "הזמנות";
            this.Btn_ordersData.UseVisualStyleBackColor = false;
            this.Btn_ordersData.Click += new System.EventHandler(this.Btn_ordersData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_userName);
            this.panel2.Controls.Add(this.Pic_userIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 210);
            this.panel2.TabIndex = 0;
            // 
            // Lbl_userName
            // 
            this.Lbl_userName.AutoSize = true;
            this.Lbl_userName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Lbl_userName.Location = new System.Drawing.Point(73, 133);
            this.Lbl_userName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_userName.Name = "Lbl_userName";
            this.Lbl_userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_userName.Size = new System.Drawing.Size(129, 25);
            this.Lbl_userName.TabIndex = 1;
            this.Lbl_userName.Text = "שם המשתמש";
            this.Lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_userIcon
            // 
            this.Pic_userIcon.Image = ((System.Drawing.Image)(resources.GetObject("Pic_userIcon.Image")));
            this.Pic_userIcon.Location = new System.Drawing.Point(41, 14);
            this.Pic_userIcon.Margin = new System.Windows.Forms.Padding(5);
            this.Pic_userIcon.Name = "Pic_userIcon";
            this.Pic_userIcon.Size = new System.Drawing.Size(152, 114);
            this.Pic_userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_userIcon.TabIndex = 0;
            this.Pic_userIcon.TabStop = false;
            // 
            // Upper_BluePanel
            // 
            this.Upper_BluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Upper_BluePanel.Controls.Add(this.button5);
            this.Upper_BluePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Upper_BluePanel.Location = new System.Drawing.Point(246, 0);
            this.Upper_BluePanel.Name = "Upper_BluePanel";
            this.Upper_BluePanel.Size = new System.Drawing.Size(693, 11);
            this.Upper_BluePanel.TabIndex = 68;
            this.Upper_BluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseDown);
            this.Upper_BluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseMove);
            this.Upper_BluePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(1412, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 28);
            this.button5.TabIndex = 37;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(957, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 609);
            this.panel7.TabIndex = 69;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_exit.Image")));
            this.Btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_exit.Location = new System.Drawing.Point(933, 0);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(35, 32);
            this.Btn_exit.TabIndex = 98;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Lbl_title
            // 
            this.Lbl_title.AutoSize = true;
            this.Lbl_title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_title.Location = new System.Drawing.Point(491, 31);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(0, 40);
            this.Lbl_title.TabIndex = 100;
            // 
            // Pnl_container
            // 
            this.Pnl_container.Controls.Add(this.panel3);
            this.Pnl_container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_container.Location = new System.Drawing.Point(247, 86);
            this.Pnl_container.Name = "Pnl_container";
            this.Pnl_container.Size = new System.Drawing.Size(710, 523);
            this.Pnl_container.TabIndex = 101;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 12);
            this.panel3.TabIndex = 109;
            // 
            // Frm_ContainerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(967, 609);
            this.Controls.Add(this.Pnl_container);
            this.Controls.Add(this.Lbl_title);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Upper_BluePanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ContainerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tmp";
            this.Load += new System.EventHandler(this.Frm_ContainerData_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_contact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_orders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_userIcon)).EndInit();
            this.Upper_BluePanel.ResumeLayout(false);
            this.Pnl_container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_products;
        private System.Windows.Forms.PictureBox Pic_contact;
        private System.Windows.Forms.PictureBox Pic_orders;
        private System.Windows.Forms.Button Btn_toMain;
        private System.Windows.Forms.Button Btn_incomeAndOutcome;
        private System.Windows.Forms.Button Btn_productsData;
        private System.Windows.Forms.Button Btn_ordersData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_userName;
        private System.Windows.Forms.PictureBox Pic_userIcon;
        private System.Windows.Forms.Panel Upper_BluePanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_title;
        public System.Windows.Forms.Panel Pnl_container;
        private System.Windows.Forms.Panel panel3;
    }
}