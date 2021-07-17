
namespace Electricity_shop
{
    partial class FrmCustomers_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers_management));
            this.Grd_customers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_phoneNumber = new System.Windows.Forms.Label();
            this.Txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.Lbl_firstName = new System.Windows.Forms.Label();
            this.Txt_firstName = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Btn_toMain = new System.Windows.Forms.Button();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Txt_customerId = new System.Windows.Forms.TextBox();
            this.Lbl_header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_customers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_customers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grd_customers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.Grd_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grd_customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grd_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_customers.ColumnHeadersHeight = 40;
            this.Grd_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Grd_customers.EnableHeadersVisualStyles = false;
            this.Grd_customers.Location = new System.Drawing.Point(40, 108);
            this.Grd_customers.Margin = new System.Windows.Forms.Padding(4);
            this.Grd_customers.Name = "Grd_customers";
            this.Grd_customers.RowHeadersWidth = 4;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grd_customers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grd_customers.RowTemplate.Height = 25;
            this.Grd_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_customers.Size = new System.Drawing.Size(816, 492);
            this.Grd_customers.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "תעודת זהות";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "שם פרטי";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "שם משפחה";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "מספר פלאפון";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "כתובת";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.Lbl_phoneNumber);
            this.panel1.Controls.Add(this.Txt_phoneNumber);
            this.panel1.Controls.Add(this.Lbl_firstName);
            this.panel1.Controls.Add(this.Txt_firstName);
            this.panel1.Controls.Add(this.Lbl_Id);
            this.panel1.Controls.Add(this.Btn_toMain);
            this.panel1.Controls.Add(this.Btn_update);
            this.panel1.Controls.Add(this.Txt_customerId);
            this.panel1.Location = new System.Drawing.Point(888, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 472);
            this.panel1.TabIndex = 22;
            // 
            // Lbl_phoneNumber
            // 
            this.Lbl_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_phoneNumber.Location = new System.Drawing.Point(43, 204);
            this.Lbl_phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_phoneNumber.Name = "Lbl_phoneNumber";
            this.Lbl_phoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_phoneNumber.Size = new System.Drawing.Size(132, 26);
            this.Lbl_phoneNumber.TabIndex = 32;
            this.Lbl_phoneNumber.Text = "מספר טלפון";
            // 
            // Txt_phoneNumber
            // 
            this.Txt_phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_phoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_phoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_phoneNumber.Location = new System.Drawing.Point(31, 220);
            this.Txt_phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_phoneNumber.Name = "Txt_phoneNumber";
            this.Txt_phoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_phoneNumber.Size = new System.Drawing.Size(154, 39);
            this.Txt_phoneNumber.TabIndex = 31;
            this.Txt_phoneNumber.TextChanged += new System.EventHandler(this.Txt_phoneNumber_TextChanged);
            this.Txt_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_phoneNumber_KeyPress);
            // 
            // Lbl_firstName
            // 
            this.Lbl_firstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_firstName.Location = new System.Drawing.Point(56, 114);
            this.Lbl_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_firstName.Name = "Lbl_firstName";
            this.Lbl_firstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_firstName.Size = new System.Drawing.Size(110, 27);
            this.Lbl_firstName.TabIndex = 30;
            this.Lbl_firstName.Text = "שם פרטי";
            // 
            // Txt_firstName
            // 
            this.Txt_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_firstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_firstName.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_firstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_firstName.Location = new System.Drawing.Point(31, 135);
            this.Txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_firstName.Name = "Txt_firstName";
            this.Txt_firstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_firstName.Size = new System.Drawing.Size(154, 39);
            this.Txt_firstName.TabIndex = 29;
            this.Txt_firstName.TextChanged += new System.EventHandler(this.Txt_firstName_TextChanged);
            this.Txt_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_firstName_KeyPress);
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_Id.Location = new System.Drawing.Point(46, 24);
            this.Lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Id.Size = new System.Drawing.Size(128, 26);
            this.Lbl_Id.TabIndex = 28;
            this.Lbl_Id.Text = "תעודת זהות";
            // 
            // Btn_toMain
            // 
            this.Btn_toMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_toMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_toMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_toMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_toMain.Location = new System.Drawing.Point(46, 373);
            this.Btn_toMain.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_toMain.Name = "Btn_toMain";
            this.Btn_toMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_toMain.Size = new System.Drawing.Size(139, 41);
            this.Btn_toMain.TabIndex = 11;
            this.Btn_toMain.Text = "חזרה לראשי";
            this.Btn_toMain.UseVisualStyleBackColor = false;
            this.Btn_toMain.Click += new System.EventHandler(this.Btn_toMain_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_update.Location = new System.Drawing.Point(46, 298);
            this.Btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_update.Size = new System.Drawing.Size(139, 41);
            this.Btn_update.TabIndex = 9;
            this.Btn_update.Text = "עדכן";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Txt_customerId
            // 
            this.Txt_customerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_customerId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_customerId.ForeColor = System.Drawing.Color.DimGray;
            this.Txt_customerId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Txt_customerId.Location = new System.Drawing.Point(31, 41);
            this.Txt_customerId.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_customerId.Name = "Txt_customerId";
            this.Txt_customerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_customerId.Size = new System.Drawing.Size(154, 39);
            this.Txt_customerId.TabIndex = 5;
            this.Txt_customerId.TextChanged += new System.EventHandler(this.Txt_customerId_TextChanged);
            this.Txt_customerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_customerId_KeyPress);
            // 
            // Lbl_header
            // 
            this.Lbl_header.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_header.ForeColor = System.Drawing.Color.White;
            this.Lbl_header.Location = new System.Drawing.Point(330, 14);
            this.Lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_header.Name = "Lbl_header";
            this.Lbl_header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_header.Size = new System.Drawing.Size(404, 64);
            this.Lbl_header.TabIndex = 60;
            this.Lbl_header.Text = "ניהול לקוחות";
            this.Lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 10);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(-2, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 625);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(17, 795);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1723, 15);
            this.panel4.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(1630, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 746);
            this.panel5.TabIndex = 64;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel6.Location = new System.Drawing.Point(1159, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 728);
            this.panel6.TabIndex = 65;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel7.Location = new System.Drawing.Point(12, 623);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1146, 13);
            this.panel7.TabIndex = 66;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_exit.Image")));
            this.Btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_exit.Location = new System.Drawing.Point(1133, 0);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(37, 38);
            this.Btn_exit.TabIndex = 67;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // FrmCustomers_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1170, 634);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbl_header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grd_customers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomers_management";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customers";
            this.Load += new System.EventHandler(this.FrmCustomers_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_customers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Grd_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.TextBox Txt_customerId;
        private System.Windows.Forms.Label Lbl_header;
        private System.Windows.Forms.Button Btn_toMain;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.Label Lbl_phoneNumber;
        private System.Windows.Forms.TextBox Txt_phoneNumber;
        private System.Windows.Forms.Label Lbl_firstName;
        private System.Windows.Forms.TextBox Txt_firstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Btn_exit;
    }
}