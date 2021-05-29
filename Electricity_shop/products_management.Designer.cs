
using System;

namespace Electricity_shop
{
    partial class products_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products_management));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button3 = new System.Windows.Forms.Button();
            this.products_grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.manufacture = new System.Windows.Forms.TextBox();
            this.update_product = new System.Windows.Forms.Button();
            this.search_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(609, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(343, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול מוצרים";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 843);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(1614, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 37);
            this.button3.TabIndex = 37;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // products_grid
            // 
            this.products_grid.AllowUserToDeleteRows = false;
            this.products_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.products_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.products_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.products_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.products_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.products_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.products_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.products_grid.ColumnHeadersHeight = 55;
            this.products_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.products_grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.products_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.products_grid.EnableHeadersVisualStyles = false;
            this.products_grid.Location = new System.Drawing.Point(27, 129);
            this.products_grid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.products_grid.Name = "products_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.products_grid.RowHeadersVisible = false;
            this.products_grid.RowHeadersWidth = 5;
            this.products_grid.RowTemplate.Height = 40;
            this.products_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_grid.Size = new System.Drawing.Size(1325, 686);
            this.products_grid.TabIndex = 39;
            this.products_grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.orders_grid_CellFormatting);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.model);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.barcode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.manufacture);
            this.panel3.Controls.Add(this.update_product);
            this.panel3.Controls.Add(this.search_order);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.category);
            this.panel3.Location = new System.Drawing.Point(1370, 129);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 686);
            this.panel3.TabIndex = 38;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(29, 601);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(199, 51);
            this.exit.TabIndex = 30;
            this.exit.Text = "יציאה";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(91, 327);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "דגם";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.model.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.model.ForeColor = System.Drawing.Color.White;
            this.model.Location = new System.Drawing.Point(27, 354);
            this.model.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.model.Name = "model";
            this.model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.model.Size = new System.Drawing.Size(199, 38);
            this.model.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(80, 49);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(102, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "ברקוד";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barcode
            // 
            this.barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.barcode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcode.ForeColor = System.Drawing.Color.White;
            this.barcode.Location = new System.Drawing.Point(27, 78);
            this.barcode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.barcode.Name = "barcode";
            this.barcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcode.Size = new System.Drawing.Size(199, 38);
            this.barcode.TabIndex = 26;
            this.barcode.TextChanged += new System.EventHandler(this.barcode_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(91, 234);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "יצרן";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufacture
            // 
            this.manufacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.manufacture.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manufacture.ForeColor = System.Drawing.Color.White;
            this.manufacture.Location = new System.Drawing.Point(29, 261);
            this.manufacture.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.manufacture.Name = "manufacture";
            this.manufacture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.manufacture.Size = new System.Drawing.Size(199, 38);
            this.manufacture.TabIndex = 24;
            // 
            // update_product
            // 
            this.update_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.update_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_product.ForeColor = System.Drawing.Color.White;
            this.update_product.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_product.Location = new System.Drawing.Point(27, 523);
            this.update_product.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.update_product.Name = "update_product";
            this.update_product.Size = new System.Drawing.Size(199, 51);
            this.update_product.TabIndex = 23;
            this.update_product.Text = "עדכון מוצר";
            this.update_product.UseVisualStyleBackColor = false;
            this.update_product.Click += new System.EventHandler(this.update_product_Click);
            // 
            // search_order
            // 
            this.search_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.search_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search_order.ForeColor = System.Drawing.Color.White;
            this.search_order.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_order.Location = new System.Drawing.Point(27, 445);
            this.search_order.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.search_order.Name = "search_order";
            this.search_order.Size = new System.Drawing.Size(199, 51);
            this.search_order.TabIndex = 22;
            this.search_order.Text = "חיפוש";
            this.search_order.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(75, 138);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "קטגוריה";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.category.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(27, 167);
            this.category.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.category.Size = new System.Drawing.Size(199, 38);
            this.category.TabIndex = 0;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-2, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 879);
            this.panel2.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(8, 865);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 10);
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
            this.panel5.Size = new System.Drawing.Size(1363, 10);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-4, 836);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1658, 10);
            this.panel6.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel7.Location = new System.Drawing.Point(8, 865);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1363, 10);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel8.Controls.Add(this.button3);
            this.panel8.Location = new System.Drawing.Point(0, -1);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2005, 35);
            this.panel8.TabIndex = 43;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseDown);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseMove);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseUp);
            // 
            // products_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1653, 843);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.products_grid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "products_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView products_grid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button update_product;
        private System.Windows.Forms.Button search_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button exit;
    }
}