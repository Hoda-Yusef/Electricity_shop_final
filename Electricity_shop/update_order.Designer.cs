
namespace Electricity_shop
{
    partial class update_order
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
            this.order_status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.total_sum_products = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.show_order_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.total_price = new System.Windows.Forms.Label();
            this.products_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.add_to_cart = new System.Windows.Forms.Button();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // order_status
            // 
            this.order_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.order_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.order_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.order_status.ForeColor = System.Drawing.Color.White;
            this.order_status.FormattingEnabled = true;
            this.order_status.Items.AddRange(new object[] {
            "סופק",
            "לא סופק"});
            this.order_status.Location = new System.Drawing.Point(32, 739);
            this.order_status.Name = "order_status";
            this.order_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.order_status.Size = new System.Drawing.Size(151, 36);
            this.order_status.TabIndex = 112;
            this.order_status.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.order_status_Format);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 804);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(1322, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 811);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(0, 792);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1435, 13);
            this.panel3.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(0, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1359, 25);
            this.panel4.TabIndex = 56;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // total_sum_products
            // 
            this.total_sum_products.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_sum_products.ForeColor = System.Drawing.Color.White;
            this.total_sum_products.Location = new System.Drawing.Point(380, 739);
            this.total_sum_products.Name = "total_sum_products";
            this.total_sum_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_sum_products.Size = new System.Drawing.Size(111, 25);
            this.total_sum_products.TabIndex = 110;
            this.total_sum_products.Text = "0";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.label12.Location = new System.Drawing.Point(510, 738);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 109;
            this.label12.Text = "כמות כללית :";
            // 
            // show_order_number
            // 
            this.show_order_number.ForeColor = System.Drawing.Color.White;
            this.show_order_number.Location = new System.Drawing.Point(1058, 76);
            this.show_order_number.Name = "show_order_number";
            this.show_order_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.show_order_number.Size = new System.Drawing.Size(120, 20);
            this.show_order_number.TabIndex = 108;
            this.show_order_number.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1184, 76);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "מספר הזמנה :";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(26)))));
            this.remove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.remove.Location = new System.Drawing.Point(861, 696);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(134, 51);
            this.remove.TabIndex = 106;
            this.remove.Text = "הסרה";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // total_price
            // 
            this.total_price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_price.ForeColor = System.Drawing.Color.White;
            this.total_price.Location = new System.Drawing.Point(30, 688);
            this.total_price.Name = "total_price";
            this.total_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.total_price.Size = new System.Drawing.Size(158, 25);
            this.total_price.TabIndex = 105;
            this.total_price.Text = "0";
            // 
            // products_count
            // 
            this.products_count.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.products_count.ForeColor = System.Drawing.Color.White;
            this.products_count.Location = new System.Drawing.Point(340, 689);
            this.products_count.Name = "products_count";
            this.products_count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.products_count.Size = new System.Drawing.Size(151, 25);
            this.products_count.TabIndex = 104;
            this.products_count.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(167, 687);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "סכום :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(508, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 102;
            this.label2.Text = ": מספר מוצרים ";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel.Location = new System.Drawing.Point(708, 696);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 51);
            this.cancel.TabIndex = 101;
            this.cancel.Text = "ביטול";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.UPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UPDATE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UPDATE.ForeColor = System.Drawing.Color.White;
            this.UPDATE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UPDATE.Location = new System.Drawing.Point(1166, 696);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(134, 51);
            this.UPDATE.TabIndex = 100;
            this.UPDATE.Text = "עדכן";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // add_to_cart
            // 
            this.add_to_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.add_to_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_to_cart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_to_cart.ForeColor = System.Drawing.Color.White;
            this.add_to_cart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_to_cart.Location = new System.Drawing.Point(1014, 696);
            this.add_to_cart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_to_cart.Name = "add_to_cart";
            this.add_to_cart.Size = new System.Drawing.Size(134, 51);
            this.add_to_cart.TabIndex = 99;
            this.add_to_cart.Text = "הוספה מוצר";
            this.add_to_cart.UseVisualStyleBackColor = false;
            this.add_to_cart.Click += new System.EventHandler(this.add_to_cart_Click);
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.AllowUserToDeleteRows = false;
            this.product_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.product_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.product_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.product_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_grid.ColumnHeadersHeight = 55;
            this.product_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column9});
            this.product_grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_grid.EnableHeadersVisualStyles = false;
            this.product_grid.Location = new System.Drawing.Point(32, 127);
            this.product_grid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.product_grid.Name = "product_grid";
            this.product_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.product_grid.RowHeadersVisible = false;
            this.product_grid.RowHeadersWidth = 5;
            this.product_grid.RowTemplate.Height = 40;
            this.product_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_grid.Size = new System.Drawing.Size(1268, 544);
            this.product_grid.TabIndex = 98;
            this.product_grid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.product_grid_CellBeginEdit);
            this.product_grid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellEndEdit);
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "ברקוד";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
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
            // Column8
            // 
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "מחיר";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "כמות";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 120F;
            this.Column9.HeaderText = "מפרט";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(437, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(466, 64);
            this.label1.TabIndex = 97;
            this.label1.Text = "עדכון הזמנה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(185, 738);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 111;
            this.label5.Text = "סטטוס הזמנה :";
            // 
            // update_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1329, 799);
            this.Controls.Add(this.order_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_sum_products);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.show_order_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.total_price);
            this.Controls.Add(this.products_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.add_to_cart);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_order";
            this.Load += new System.EventHandler(this.update_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label total_sum_products;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Label products_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button add_to_cart;
        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label show_order_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox order_status;
    }
}