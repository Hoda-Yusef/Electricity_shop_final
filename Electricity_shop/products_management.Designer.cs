
using System;

namespace Electricity_shop
{
    partial class Frm_products_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_products_management));
            this.Grd_products = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_productManagement = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_sortByAmount = new System.Windows.Forms.Label();
            this.Cbo_sortByProductAmount = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Lbl_model = new System.Windows.Forms.Label();
            this.Txt_model = new System.Windows.Forms.TextBox();
            this.Lbl_barcode = new System.Windows.Forms.Label();
            this.Txt_barcode = new System.Windows.Forms.TextBox();
            this.Lbl_manufacturer = new System.Windows.Forms.Label();
            this.Txt_manufacturer = new System.Windows.Forms.TextBox();
            this.Btn_updateProduct = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Lbl_category = new System.Windows.Forms.Label();
            this.Txt_category = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Upper_BluePanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_products)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_products
            // 
            this.Grd_products.AllowUserToAddRows = false;
            this.Grd_products.AllowUserToDeleteRows = false;
            this.Grd_products.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Grd_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grd_products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.Grd_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grd_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grd_products.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Grd_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grd_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_products.ColumnHeadersHeight = 55;
            this.Grd_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.Grd_products.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_products.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grd_products.EnableHeadersVisualStyles = false;
            this.Grd_products.Location = new System.Drawing.Point(32, 129);
            this.Grd_products.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Grd_products.Name = "Grd_products";
            this.Grd_products.ReadOnly = true;
            this.Grd_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grd_products.RowHeadersVisible = false;
            this.Grd_products.RowHeadersWidth = 5;
            this.Grd_products.RowTemplate.Height = 40;
            this.Grd_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_products.Size = new System.Drawing.Size(1181, 685);
            this.Grd_products.TabIndex = 39;
            this.Grd_products.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grd_products_CellFormatting);
            this.Grd_products.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grd_products_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "קטגוריה";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 40F;
            this.Column2.HeaderText = "יצרן";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "דגם";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "ברקוד";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "ספק";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.FillWeight = 25F;
            this.Column6.HeaderText = "כמות מלאי";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "מחיר עלות";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "מחיר מכירה";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 120F;
            this.Column9.HeaderText = "מפרט";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Lbl_productManagement
            // 
            this.Lbl_productManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Lbl_productManagement.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_productManagement.ForeColor = System.Drawing.Color.White;
            this.Lbl_productManagement.Location = new System.Drawing.Point(609, 39);
            this.Lbl_productManagement.Name = "Lbl_productManagement";
            this.Lbl_productManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_productManagement.Size = new System.Drawing.Size(343, 64);
            this.Lbl_productManagement.TabIndex = 0;
            this.Lbl_productManagement.Text = "ניהול מוצרים";
            this.Lbl_productManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 855);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Lbl_sortByAmount);
            this.panel3.Controls.Add(this.Cbo_sortByProductAmount);
            this.panel3.Controls.Add(this.BtnExit);
            this.panel3.Controls.Add(this.Lbl_model);
            this.panel3.Controls.Add(this.Txt_model);
            this.panel3.Controls.Add(this.Lbl_barcode);
            this.panel3.Controls.Add(this.Txt_barcode);
            this.panel3.Controls.Add(this.Lbl_manufacturer);
            this.panel3.Controls.Add(this.Txt_manufacturer);
            this.panel3.Controls.Add(this.Btn_updateProduct);
            this.panel3.Controls.Add(this.Btn_clear);
            this.panel3.Controls.Add(this.Lbl_category);
            this.panel3.Controls.Add(this.Txt_category);
            this.panel3.Location = new System.Drawing.Point(1239, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 731);
            this.panel3.TabIndex = 38;
            // 
            // Lbl_sortByAmount
            // 
            this.Lbl_sortByAmount.AutoSize = true;
            this.Lbl_sortByAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_sortByAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_sortByAmount.Location = new System.Drawing.Point(86, 35);
            this.Lbl_sortByAmount.Name = "Lbl_sortByAmount";
            this.Lbl_sortByAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_sortByAmount.Size = new System.Drawing.Size(136, 28);
            this.Lbl_sortByAmount.TabIndex = 32;
            this.Lbl_sortByAmount.Text = ": הצג תוצאות";
            this.Lbl_sortByAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cbo_sortByProductAmount
            // 
            this.Cbo_sortByProductAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbo_sortByProductAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.Cbo_sortByProductAmount.DisplayMember = "כל המלאי";
            this.Cbo_sortByProductAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cbo_sortByProductAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Cbo_sortByProductAmount.FormattingEnabled = true;
            this.Cbo_sortByProductAmount.Items.AddRange(new object[] {
            "הכל",
            "זמין במלאי",
            "עומד להיגמר מהמלאי",
            "לא זמין במלאי"});
            this.Cbo_sortByProductAmount.Location = new System.Drawing.Point(19, 59);
            this.Cbo_sortByProductAmount.Name = "Cbo_sortByProductAmount";
            this.Cbo_sortByProductAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cbo_sortByProductAmount.Size = new System.Drawing.Size(217, 39);
            this.Cbo_sortByProductAmount.TabIndex = 31;
            this.Cbo_sortByProductAmount.Text = "הכל";
            this.Cbo_sortByProductAmount.SelectedIndexChanged += new System.EventHandler(this.Cbo_sortByProductAmount_SelectedIndexChanged);
            this.Cbo_sortByProductAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_sortByProductAmount_KeyPress);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(27, 662);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(199, 51);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.Text = "חזרה לראשי";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Lbl_model
            // 
            this.Lbl_model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_model.Location = new System.Drawing.Point(151, 429);
            this.Lbl_model.Name = "Lbl_model";
            this.Lbl_model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_model.Size = new System.Drawing.Size(54, 32);
            this.Lbl_model.TabIndex = 29;
            this.Lbl_model.Text = "דגם";
            // 
            // Txt_model
            // 
            this.Txt_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_model.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_model.ForeColor = System.Drawing.Color.White;
            this.Txt_model.Location = new System.Drawing.Point(19, 451);
            this.Txt_model.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_model.Name = "Txt_model";
            this.Txt_model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_model.Size = new System.Drawing.Size(217, 38);
            this.Txt_model.TabIndex = 3;
            this.Txt_model.TextChanged += new System.EventHandler(this.Txt_model_TextChanged);
            // 
            // Lbl_barcode
            // 
            this.Lbl_barcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_barcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_barcode.Location = new System.Drawing.Point(137, 168);
            this.Lbl_barcode.Name = "Lbl_barcode";
            this.Lbl_barcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_barcode.Size = new System.Drawing.Size(67, 32);
            this.Lbl_barcode.TabIndex = 27;
            this.Lbl_barcode.Text = "ברקוד";
            // 
            // Txt_barcode
            // 
            this.Txt_barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_barcode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_barcode.ForeColor = System.Drawing.Color.White;
            this.Txt_barcode.Location = new System.Drawing.Point(19, 195);
            this.Txt_barcode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_barcode.Name = "Txt_barcode";
            this.Txt_barcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_barcode.Size = new System.Drawing.Size(217, 38);
            this.Txt_barcode.TabIndex = 0;
            this.Txt_barcode.TextChanged += new System.EventHandler(this.Txt_barcode_TextChanged);
            this.Txt_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_barcode_KeyPress);
            // 
            // Lbl_manufacturer
            // 
            this.Lbl_manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_manufacturer.Location = new System.Drawing.Point(151, 345);
            this.Lbl_manufacturer.Name = "Lbl_manufacturer";
            this.Lbl_manufacturer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_manufacturer.Size = new System.Drawing.Size(54, 32);
            this.Lbl_manufacturer.TabIndex = 25;
            this.Lbl_manufacturer.Text = "יצרן";
            // 
            // Txt_manufacturer
            // 
            this.Txt_manufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_manufacturer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_manufacturer.ForeColor = System.Drawing.Color.White;
            this.Txt_manufacturer.Location = new System.Drawing.Point(19, 365);
            this.Txt_manufacturer.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_manufacturer.Name = "Txt_manufacturer";
            this.Txt_manufacturer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_manufacturer.Size = new System.Drawing.Size(217, 38);
            this.Txt_manufacturer.TabIndex = 2;
            this.Txt_manufacturer.TextChanged += new System.EventHandler(this.Txt_manufacturer_TextChanged);
            // 
            // Btn_updateProduct
            // 
            this.Btn_updateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_updateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_updateProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_updateProduct.ForeColor = System.Drawing.Color.White;
            this.Btn_updateProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_updateProduct.Location = new System.Drawing.Point(27, 593);
            this.Btn_updateProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_updateProduct.Name = "Btn_updateProduct";
            this.Btn_updateProduct.Size = new System.Drawing.Size(199, 51);
            this.Btn_updateProduct.TabIndex = 23;
            this.Btn_updateProduct.Text = "עדכון מוצר";
            this.Btn_updateProduct.UseVisualStyleBackColor = false;
            this.Btn_updateProduct.Click += new System.EventHandler(this.Btn_updateProduct_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_clear.ForeColor = System.Drawing.Color.White;
            this.Btn_clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_clear.Location = new System.Drawing.Point(27, 524);
            this.Btn_clear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(199, 51);
            this.Btn_clear.TabIndex = 22;
            this.Btn_clear.Text = "נקה חיפוש";
            this.Btn_clear.UseVisualStyleBackColor = false;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Lbl_category
            // 
            this.Lbl_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_category.Location = new System.Drawing.Point(113, 261);
            this.Lbl_category.Name = "Lbl_category";
            this.Lbl_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_category.Size = new System.Drawing.Size(91, 32);
            this.Lbl_category.TabIndex = 22;
            this.Lbl_category.Text = "קטגוריה";
            // 
            // Txt_category
            // 
            this.Txt_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_category.ForeColor = System.Drawing.Color.White;
            this.Txt_category.Location = new System.Drawing.Point(19, 284);
            this.Txt_category.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_category.Name = "Txt_category";
            this.Txt_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_category.Size = new System.Drawing.Size(217, 38);
            this.Txt_category.TabIndex = 1;
            this.Txt_category.TextChanged += new System.EventHandler(this.Txt_category_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-2, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 855);
            this.panel2.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(8, 865);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 11);
            this.panel4.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(1646, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 879);
            this.panel1.TabIndex = 41;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(8, 865);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1363, 11);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-5, 840);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1658, 15);
            this.panel6.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel7.Location = new System.Drawing.Point(8, 865);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1363, 11);
            this.panel7.TabIndex = 16;
            // 
            // Upper_BluePanel
            // 
            this.Upper_BluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Upper_BluePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Upper_BluePanel.Location = new System.Drawing.Point(0, -1);
            this.Upper_BluePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Upper_BluePanel.Name = "Upper_BluePanel";
            this.Upper_BluePanel.Size = new System.Drawing.Size(1523, 19);
            this.Upper_BluePanel.TabIndex = 43;
            this.Upper_BluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseDown);
            this.Upper_BluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseMove);
            this.Upper_BluePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseUp);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(1513, -3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(11, 856);
            this.panel9.TabIndex = 44;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel10.Location = new System.Drawing.Point(8, 865);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1363, 11);
            this.panel10.TabIndex = 16;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_exit.Image")));
            this.Btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_exit.Location = new System.Drawing.Point(1481, -5);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(43, 41);
            this.Btn_exit.TabIndex = 55;
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Frm_products_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1526, 855);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.Upper_BluePanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Grd_products);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Lbl_productManagement);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_products_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            this.Load += new System.EventHandler(this.Frm_products_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_products)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label Lbl_productManagement;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_updateProduct;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Label Lbl_category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel Upper_BluePanel;
        private System.Windows.Forms.Label Lbl_model;
        private System.Windows.Forms.Label Lbl_barcode;
        private System.Windows.Forms.Label Lbl_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_sortByAmount;
        public System.Windows.Forms.ComboBox Cbo_sortByProductAmount;
        public System.Windows.Forms.TextBox Txt_category;
        public System.Windows.Forms.TextBox Txt_model;
        public System.Windows.Forms.TextBox Txt_barcode;
        public System.Windows.Forms.TextBox Txt_manufacturer;
        public System.Windows.Forms.DataGridView Grd_products;
    }
}