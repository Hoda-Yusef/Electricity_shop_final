
namespace Electricity_shop
{
    partial class add_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(323, 72);
            this.label1.TabIndex = 21;
            this.label1.Text = "הוספת ספק";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(-5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 667);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(5, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 11);
            this.panel3.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dept);
            this.panel5.Controls.Add(this.cancel);
            this.panel5.Controls.Add(this.add_button);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.paid);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.phoneNumber);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.address);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.name);
            this.panel5.Location = new System.Drawing.Point(43, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(896, 501);
            this.panel5.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(200, 50);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(113, 27);
            this.label7.TabIndex = 50;
            this.label7.Text = "חוב לספק";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dept
            // 
            this.dept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dept.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept.ForeColor = System.Drawing.Color.White;
            this.dept.Location = new System.Drawing.Point(66, 75);
            this.dept.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dept.Name = "dept";
            this.dept.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dept.Size = new System.Drawing.Size(257, 38);
            this.dept.TabIndex = 49;
            this.dept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dept_KeyPress);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel.Location = new System.Drawing.Point(48, 367);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(133, 51);
            this.cancel.TabIndex = 48;
            this.cancel.Text = "ביטול";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_button.Location = new System.Drawing.Point(200, 367);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(133, 51);
            this.add_button.TabIndex = 47;
            this.add_button.Text = "הוספה";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label6.Location = new System.Drawing.Point(181, 188);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "שולם לספק";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paid
            // 
            this.paid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.paid.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paid.ForeColor = System.Drawing.Color.White;
            this.paid.Location = new System.Drawing.Point(66, 211);
            this.paid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paid.Name = "paid";
            this.paid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paid.Size = new System.Drawing.Size(257, 38);
            this.paid.TabIndex = 60;
            this.paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(690, 342);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 43;
            this.label5.Text = "מספר טלפון";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.ForeColor = System.Drawing.Color.White;
            this.phoneNumber.Location = new System.Drawing.Point(593, 367);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneNumber.Size = new System.Drawing.Size(257, 38);
            this.phoneNumber.TabIndex = 42;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(735, 190);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "כתובת";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.address.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(593, 211);
            this.address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address.Name = "address";
            this.address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address.Size = new System.Drawing.Size(257, 38);
            this.address.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(701, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "שם ספק";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(593, 75);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(257, 38);
            this.name.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(951, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 51);
            this.button3.TabIndex = 51;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(987, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 667);
            this.panel2.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(0, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(991, 11);
            this.panel4.TabIndex = 43;
            // 
            // add_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(993, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_supplier";
            this.Load += new System.EventHandler(this.add_supplier_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox dept;
    }
}