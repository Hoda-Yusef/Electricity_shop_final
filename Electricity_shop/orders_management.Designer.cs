namespace Electricity_shop
{
    partial class Frm_ordersManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ordersManagement));
            this.Grd_orders = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Upper_BluePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_ordersManagement = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_sortByAmount = new System.Windows.Forms.Label();
            this.Cbo_sortByOrderStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnClear = new System.Windows.Forms.Button();
            this.Lbl_customersLastName = new System.Windows.Forms.Label();
            this.Txt_customersLastName = new System.Windows.Forms.TextBox();
            this.Lbl_customersFirstName = new System.Windows.Forms.Label();
            this.Txt_customersFirstName = new System.Windows.Forms.TextBox();
            this.Btn_backToMain = new System.Windows.Forms.Button();
            this.Btn_updateStatus = new System.Windows.Forms.Button();
            this.Btn_updateOrder = new System.Windows.Forms.Button();
            this.Lbl_customerId = new System.Windows.Forms.Label();
            this.Txt_customerId = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Btn_leave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_orders)).BeginInit();
            this.Upper_BluePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_orders
            // 
            this.Grd_orders.AllowUserToAddRows = false;
            this.Grd_orders.AllowUserToResizeColumns = false;
            this.Grd_orders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Grd_orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grd_orders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.Grd_orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grd_orders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grd_orders.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Grd_orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grd_orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_orders.ColumnHeadersHeight = 55;
            this.Grd_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.Grd_orders.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_orders.DefaultCellStyle = dataGridViewCellStyle5;
            this.Grd_orders.EnableHeadersVisualStyles = false;
            this.Grd_orders.Location = new System.Drawing.Point(27, 131);
            this.Grd_orders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Grd_orders.Name = "Grd_orders";
            this.Grd_orders.ReadOnly = true;
            this.Grd_orders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grd_orders.RowHeadersVisible = false;
            this.Grd_orders.RowHeadersWidth = 4;
            this.Grd_orders.RowTemplate.Height = 40;
            this.Grd_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grd_orders.Size = new System.Drawing.Size(1149, 655);
            this.Grd_orders.TabIndex = 21;
            this.Grd_orders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grd_orders_CellMouseDoubleClick);
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "מספר הזמנה";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 90F;
            this.Column8.HeaderText = "ת.ז";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "שם פרטי";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "שם משפחה";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 90F;
            this.Column3.HeaderText = "מספר טלפון";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 90F;
            this.Column4.HeaderText = "כתובת";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "תאריך";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "סטטוס הזמנה";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "green_check");
            this.imageList1.Images.SetKeyName(1, "check.png");
            // 
            // Upper_BluePanel
            // 
            this.Upper_BluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Upper_BluePanel.Controls.Add(this.panel6);
            this.Upper_BluePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Upper_BluePanel.Location = new System.Drawing.Point(-88, 0);
            this.Upper_BluePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Upper_BluePanel.Name = "Upper_BluePanel";
            this.Upper_BluePanel.Size = new System.Drawing.Size(1561, 25);
            this.Upper_BluePanel.TabIndex = 15;
            this.Upper_BluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseDown);
            this.Upper_BluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseMove);
            this.Upper_BluePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Upper_BluePanel_MouseUp);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(1414, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 908);
            this.panel6.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel9.Location = new System.Drawing.Point(8, 865);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1363, 11);
            this.panel9.TabIndex = 16;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_exit.Image")));
            this.Btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_exit.Location = new System.Drawing.Point(1618, 0);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(55, 51);
            this.Btn_exit.TabIndex = 53;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.MouseLeave += new System.EventHandler(this.Btn_exit_MouseLeave);
            this.Btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_exit_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(-2, 1516);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2010, 20);
            this.panel1.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel7.Location = new System.Drawing.Point(1995, -7);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 879);
            this.panel7.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 820);
            this.panel2.TabIndex = 18;
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
            // Lbl_ordersManagement
            // 
            this.Lbl_ordersManagement.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ordersManagement.ForeColor = System.Drawing.Color.White;
            this.Lbl_ordersManagement.Location = new System.Drawing.Point(533, 43);
            this.Lbl_ordersManagement.Name = "Lbl_ordersManagement";
            this.Lbl_ordersManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_ordersManagement.Size = new System.Drawing.Size(323, 72);
            this.Lbl_ordersManagement.TabIndex = 19;
            this.Lbl_ordersManagement.Text = "ניהול הזמנות";
            this.Lbl_ordersManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Lbl_sortByAmount);
            this.panel3.Controls.Add(this.Cbo_sortByOrderStatus);
            this.panel3.Controls.Add(this.dateTimePicker);
            this.panel3.Controls.Add(this.BtnClear);
            this.panel3.Controls.Add(this.Lbl_customersLastName);
            this.panel3.Controls.Add(this.Txt_customersLastName);
            this.panel3.Controls.Add(this.Lbl_customersFirstName);
            this.panel3.Controls.Add(this.Txt_customersFirstName);
            this.panel3.Controls.Add(this.Btn_backToMain);
            this.panel3.Controls.Add(this.Btn_updateStatus);
            this.panel3.Controls.Add(this.Btn_updateOrder);
            this.panel3.Controls.Add(this.Lbl_customerId);
            this.panel3.Controls.Add(this.Txt_customerId);
            this.panel3.Location = new System.Drawing.Point(1191, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 720);
            this.panel3.TabIndex = 20;
            // 
            // Lbl_sortByAmount
            // 
            this.Lbl_sortByAmount.AutoSize = true;
            this.Lbl_sortByAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_sortByAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_sortByAmount.Location = new System.Drawing.Point(79, 18);
            this.Lbl_sortByAmount.Name = "Lbl_sortByAmount";
            this.Lbl_sortByAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_sortByAmount.Size = new System.Drawing.Size(136, 28);
            this.Lbl_sortByAmount.TabIndex = 35;
            this.Lbl_sortByAmount.Text = ": הצג תוצאות";
            this.Lbl_sortByAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cbo_sortByOrderStatus
            // 
            this.Cbo_sortByOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbo_sortByOrderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.Cbo_sortByOrderStatus.DisplayMember = "כל המלאי";
            this.Cbo_sortByOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cbo_sortByOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Cbo_sortByOrderStatus.FormattingEnabled = true;
            this.Cbo_sortByOrderStatus.Items.AddRange(new object[] {
            "הכל",
            "סופק",
            "לא סופק"});
            this.Cbo_sortByOrderStatus.Location = new System.Drawing.Point(22, 42);
            this.Cbo_sortByOrderStatus.Name = "Cbo_sortByOrderStatus";
            this.Cbo_sortByOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cbo_sortByOrderStatus.Size = new System.Drawing.Size(199, 39);
            this.Cbo_sortByOrderStatus.TabIndex = 34;
            this.Cbo_sortByOrderStatus.Text = "הכל";
            this.Cbo_sortByOrderStatus.SelectedIndexChanged += new System.EventHandler(this.Cbo_sortByOrderStatus_SelectedIndexChanged);
            this.Cbo_sortByOrderStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_sortByOrderStatus_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(22, 392);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(199, 34);
            this.dateTimePicker.TabIndex = 33;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClear.Location = new System.Drawing.Point(22, 466);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(199, 51);
            this.BtnClear.TabIndex = 32;
            this.BtnClear.Text = "נקה";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Lbl_customersLastName
            // 
            this.Lbl_customersLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_customersLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_customersLastName.Location = new System.Drawing.Point(71, 299);
            this.Lbl_customersLastName.Name = "Lbl_customersLastName";
            this.Lbl_customersLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_customersLastName.Size = new System.Drawing.Size(127, 32);
            this.Lbl_customersLastName.TabIndex = 30;
            this.Lbl_customersLastName.Text = "שם משפחה";
            // 
            // Txt_customersLastName
            // 
            this.Txt_customersLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_customersLastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_customersLastName.ForeColor = System.Drawing.Color.White;
            this.Txt_customersLastName.Location = new System.Drawing.Point(22, 324);
            this.Txt_customersLastName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_customersLastName.Name = "Txt_customersLastName";
            this.Txt_customersLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_customersLastName.Size = new System.Drawing.Size(199, 38);
            this.Txt_customersLastName.TabIndex = 29;
            this.Txt_customersLastName.TextChanged += new System.EventHandler(this.Txt_customersLastName_TextChanged);
            // 
            // Lbl_customersFirstName
            // 
            this.Lbl_customersFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_customersFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_customersFirstName.Location = new System.Drawing.Point(87, 211);
            this.Lbl_customersFirstName.Name = "Lbl_customersFirstName";
            this.Lbl_customersFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_customersFirstName.Size = new System.Drawing.Size(95, 32);
            this.Lbl_customersFirstName.TabIndex = 28;
            this.Lbl_customersFirstName.Text = "שם פרטי";
            // 
            // Txt_customersFirstName
            // 
            this.Txt_customersFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_customersFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_customersFirstName.ForeColor = System.Drawing.Color.White;
            this.Txt_customersFirstName.Location = new System.Drawing.Point(22, 235);
            this.Txt_customersFirstName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_customersFirstName.Name = "Txt_customersFirstName";
            this.Txt_customersFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_customersFirstName.Size = new System.Drawing.Size(199, 38);
            this.Txt_customersFirstName.TabIndex = 27;
            this.Txt_customersFirstName.TextChanged += new System.EventHandler(this.Txt_customersFirstName_TextChanged);
            // 
            // Btn_backToMain
            // 
            this.Btn_backToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_backToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_backToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_backToMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_backToMain.ForeColor = System.Drawing.Color.White;
            this.Btn_backToMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_backToMain.Location = new System.Drawing.Point(22, 650);
            this.Btn_backToMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_backToMain.Name = "Btn_backToMain";
            this.Btn_backToMain.Size = new System.Drawing.Size(199, 51);
            this.Btn_backToMain.TabIndex = 25;
            this.Btn_backToMain.Text = "חזרה לראשי";
            this.Btn_backToMain.UseVisualStyleBackColor = false;
            this.Btn_backToMain.Click += new System.EventHandler(this.Btn_backToMain_Click);
            // 
            // Btn_updateStatus
            // 
            this.Btn_updateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_updateStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_updateStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_updateStatus.ForeColor = System.Drawing.Color.White;
            this.Btn_updateStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_updateStatus.Location = new System.Drawing.Point(22, 589);
            this.Btn_updateStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_updateStatus.Name = "Btn_updateStatus";
            this.Btn_updateStatus.Size = new System.Drawing.Size(199, 51);
            this.Btn_updateStatus.TabIndex = 24;
            this.Btn_updateStatus.Text = "עדכון סטטוס";
            this.Btn_updateStatus.UseVisualStyleBackColor = false;
            this.Btn_updateStatus.Click += new System.EventHandler(this.Btn_updateStatus_Click);
            // 
            // Btn_updateOrder
            // 
            this.Btn_updateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_updateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_updateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_updateOrder.ForeColor = System.Drawing.Color.White;
            this.Btn_updateOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_updateOrder.Location = new System.Drawing.Point(22, 527);
            this.Btn_updateOrder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_updateOrder.Name = "Btn_updateOrder";
            this.Btn_updateOrder.Size = new System.Drawing.Size(199, 51);
            this.Btn_updateOrder.TabIndex = 23;
            this.Btn_updateOrder.Text = "עדכון הזמנה";
            this.Btn_updateOrder.UseVisualStyleBackColor = false;
            this.Btn_updateOrder.Click += new System.EventHandler(this.Btn_updateOrder_Click);
            // 
            // Lbl_customerId
            // 
            this.Lbl_customerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_customerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_customerId.Location = new System.Drawing.Point(70, 124);
            this.Lbl_customerId.Name = "Lbl_customerId";
            this.Lbl_customerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_customerId.Size = new System.Drawing.Size(126, 32);
            this.Lbl_customerId.TabIndex = 22;
            this.Lbl_customerId.Text = "תעודת זהות";
            // 
            // Txt_customerId
            // 
            this.Txt_customerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Txt_customerId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_customerId.ForeColor = System.Drawing.Color.White;
            this.Txt_customerId.Location = new System.Drawing.Point(22, 147);
            this.Txt_customerId.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Txt_customerId.Name = "Txt_customerId";
            this.Txt_customerId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_customerId.Size = new System.Drawing.Size(199, 38);
            this.Txt_customerId.TabIndex = 0;
            this.Txt_customerId.TextChanged += new System.EventHandler(this.Txt_customerId_TextChanged);
            this.Txt_customerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_customerId_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(3, 815);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2005, 13);
            this.panel5.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(1462, -3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 820);
            this.panel8.TabIndex = 54;
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
            // Btn_leave
            // 
            this.Btn_leave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_leave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_leave.Image = ((System.Drawing.Image)(resources.GetObject("Btn_leave.Image")));
            this.Btn_leave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_leave.Location = new System.Drawing.Point(1432, -1);
            this.Btn_leave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_leave.Name = "Btn_leave";
            this.Btn_leave.Size = new System.Drawing.Size(42, 41);
            this.Btn_leave.TabIndex = 55;
            this.Btn_leave.UseVisualStyleBackColor = true;
            this.Btn_leave.Click += new System.EventHandler(this.Btn_leave_Click);
            // 
            // Frm_ordersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1473, 824);
            this.Controls.Add(this.Btn_leave);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Upper_BluePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Grd_orders);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_ordersManagement);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_ordersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orders_management";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Frm_ordersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_orders)).EndInit();
            this.Upper_BluePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Upper_BluePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_ordersManagement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_customerId;
        private System.Windows.Forms.Label Lbl_customerId;
        private System.Windows.Forms.Button Btn_updateStatus;
        private System.Windows.Forms.Button Btn_updateOrder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_backToMain;
        private System.Windows.Forms.DataGridView Grd_orders;
        private System.Windows.Forms.Label Lbl_customersLastName;
        private System.Windows.Forms.TextBox Txt_customersLastName;
        private System.Windows.Forms.Label Lbl_customersFirstName;
        private System.Windows.Forms.TextBox Txt_customersFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button Btn_leave;
        private System.Windows.Forms.Label Lbl_sortByAmount;
        public System.Windows.Forms.ComboBox Cbo_sortByOrderStatus;
    }
}