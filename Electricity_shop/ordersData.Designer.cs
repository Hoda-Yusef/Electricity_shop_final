
namespace Electricity_shop
{
    partial class Frm_ordersData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ordersData));
            this.Lbl_fromDate = new System.Windows.Forms.Label();
            this.Lbl_toDate = new System.Windows.Forms.Label();
            this.Pnl_biggestOrderContainer = new System.Windows.Forms.Panel();
            this.Pic_totalPrice = new System.Windows.Forms.PictureBox();
            this.Lbl_customersId = new System.Windows.Forms.Label();
            this.Lbl_customersName = new System.Windows.Forms.Label();
            this.Lbl_forCustomer = new System.Windows.Forms.Label();
            this.Pic_moneyBag = new System.Windows.Forms.PictureBox();
            this.Lbl_totalPrice = new System.Windows.Forms.Label();
            this.Lbl_costOfBiggestOrder = new System.Windows.Forms.Label();
            this.Lbl_biggestOrder = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_totalOrdersNumber = new System.Windows.Forms.Label();
            this.Lbl_totalOrders = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_deleviredNumber = new System.Windows.Forms.Label();
            this.Lbl_deliveredOrders = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_waitingOrdersNumber = new System.Windows.Forms.Label();
            this.Lbl_waitingOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.Pnl_biggestOrderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_totalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_moneyBag)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_fromDate
            // 
            this.Lbl_fromDate.AutoSize = true;
            this.Lbl_fromDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_fromDate.Location = new System.Drawing.Point(603, 33);
            this.Lbl_fromDate.Name = "Lbl_fromDate";
            this.Lbl_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_fromDate.Size = new System.Drawing.Size(91, 25);
            this.Lbl_fromDate.TabIndex = 107;
            this.Lbl_fromDate.Text = "מתאריך :";
            // 
            // Lbl_toDate
            // 
            this.Lbl_toDate.AutoSize = true;
            this.Lbl_toDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_toDate.Location = new System.Drawing.Point(598, 85);
            this.Lbl_toDate.Name = "Lbl_toDate";
            this.Lbl_toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_toDate.Size = new System.Drawing.Size(89, 25);
            this.Lbl_toDate.TabIndex = 106;
            this.Lbl_toDate.Text = "לתאריך :";
            // 
            // Pnl_biggestOrderContainer
            // 
            this.Pnl_biggestOrderContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_biggestOrderContainer.Controls.Add(this.Pic_totalPrice);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_customersId);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_customersName);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_forCustomer);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Pic_moneyBag);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_totalPrice);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_costOfBiggestOrder);
            this.Pnl_biggestOrderContainer.Controls.Add(this.Lbl_biggestOrder);
            this.Pnl_biggestOrderContainer.Location = new System.Drawing.Point(303, 137);
            this.Pnl_biggestOrderContainer.Name = "Pnl_biggestOrderContainer";
            this.Pnl_biggestOrderContainer.Size = new System.Drawing.Size(402, 310);
            this.Pnl_biggestOrderContainer.TabIndex = 103;
            this.Pnl_biggestOrderContainer.Click += new System.EventHandler(this.Pnl_biggestOrderContainer_Click);
            // 
            // Pic_totalPrice
            // 
            this.Pic_totalPrice.Image = ((System.Drawing.Image)(resources.GetObject("Pic_totalPrice.Image")));
            this.Pic_totalPrice.Location = new System.Drawing.Point(37, 107);
            this.Pic_totalPrice.Name = "Pic_totalPrice";
            this.Pic_totalPrice.Size = new System.Drawing.Size(46, 32);
            this.Pic_totalPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_totalPrice.TabIndex = 7;
            this.Pic_totalPrice.TabStop = false;
            // 
            // Lbl_customersId
            // 
            this.Lbl_customersId.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lbl_customersId.Location = new System.Drawing.Point(102, 263);
            this.Lbl_customersId.Name = "Lbl_customersId";
            this.Lbl_customersId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_customersId.Size = new System.Drawing.Size(186, 32);
            this.Lbl_customersId.TabIndex = 6;
            this.Lbl_customersId.Text = "ת.ז";
            this.Lbl_customersId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_customersName
            // 
            this.Lbl_customersName.ForeColor = System.Drawing.Color.LimeGreen;
            this.Lbl_customersName.Location = new System.Drawing.Point(37, 231);
            this.Lbl_customersName.Name = "Lbl_customersName";
            this.Lbl_customersName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_customersName.Size = new System.Drawing.Size(314, 32);
            this.Lbl_customersName.TabIndex = 5;
            this.Lbl_customersName.Text = "שם ומשפחה";
            this.Lbl_customersName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_forCustomer
            // 
            this.Lbl_forCustomer.AutoSize = true;
            this.Lbl_forCustomer.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_forCustomer.Location = new System.Drawing.Point(284, 180);
            this.Lbl_forCustomer.Name = "Lbl_forCustomer";
            this.Lbl_forCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_forCustomer.Size = new System.Drawing.Size(76, 25);
            this.Lbl_forCustomer.TabIndex = 4;
            this.Lbl_forCustomer.Text = "ללקוח :";
            // 
            // Pic_moneyBag
            // 
            this.Pic_moneyBag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Pic_moneyBag.Image = ((System.Drawing.Image)(resources.GetObject("Pic_moneyBag.Image")));
            this.Pic_moneyBag.Location = new System.Drawing.Point(318, 89);
            this.Pic_moneyBag.Name = "Pic_moneyBag";
            this.Pic_moneyBag.Size = new System.Drawing.Size(63, 50);
            this.Pic_moneyBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_moneyBag.TabIndex = 3;
            this.Pic_moneyBag.TabStop = false;
            // 
            // Lbl_totalPrice
            // 
            this.Lbl_totalPrice.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_totalPrice.Location = new System.Drawing.Point(202, 103);
            this.Lbl_totalPrice.Name = "Lbl_totalPrice";
            this.Lbl_totalPrice.Size = new System.Drawing.Size(106, 32);
            this.Lbl_totalPrice.TabIndex = 1;
            this.Lbl_totalPrice.Text = "0";
            this.Lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_costOfBiggestOrder
            // 
            this.Lbl_costOfBiggestOrder.AutoSize = true;
            this.Lbl_costOfBiggestOrder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_costOfBiggestOrder.Location = new System.Drawing.Point(194, 46);
            this.Lbl_costOfBiggestOrder.Name = "Lbl_costOfBiggestOrder";
            this.Lbl_costOfBiggestOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_costOfBiggestOrder.Size = new System.Drawing.Size(157, 25);
            this.Lbl_costOfBiggestOrder.TabIndex = 0;
            this.Lbl_costOfBiggestOrder.Text = "עומדת על סה\"כ :";
            // 
            // Lbl_biggestOrder
            // 
            this.Lbl_biggestOrder.AutoSize = true;
            this.Lbl_biggestOrder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_biggestOrder.Location = new System.Drawing.Point(93, 14);
            this.Lbl_biggestOrder.Name = "Lbl_biggestOrder";
            this.Lbl_biggestOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_biggestOrder.Size = new System.Drawing.Size(241, 25);
            this.Lbl_biggestOrder.TabIndex = 0;
            this.Lbl_biggestOrder.Text = "עסקה הגדולה ביותר להיום";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Lbl_totalOrdersNumber);
            this.panel5.Controls.Add(this.Lbl_totalOrders);
            this.panel5.Location = new System.Drawing.Point(24, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 111);
            this.panel5.TabIndex = 102;
            // 
            // Lbl_totalOrdersNumber
            // 
            this.Lbl_totalOrdersNumber.AutoSize = true;
            this.Lbl_totalOrdersNumber.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl_totalOrdersNumber.Location = new System.Drawing.Point(181, 55);
            this.Lbl_totalOrdersNumber.Name = "Lbl_totalOrdersNumber";
            this.Lbl_totalOrdersNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_totalOrdersNumber.TabIndex = 1;
            this.Lbl_totalOrdersNumber.Text = "0";
           // this.Lbl_totalOrdersNumber.Click += new System.EventHandler(this.Lbl_totalOrdersNumber_Click);
            // 
            // Lbl_totalOrders
            // 
            this.Lbl_totalOrders.AutoSize = true;
            this.Lbl_totalOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_totalOrders.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_totalOrders.Location = new System.Drawing.Point(125, 14);
            this.Lbl_totalOrders.Name = "Lbl_totalOrders";
            this.Lbl_totalOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_totalOrders.Size = new System.Drawing.Size(110, 21);
            this.Lbl_totalOrders.TabIndex = 0;
            this.Lbl_totalOrders.Text = "סה\"כ הזמנות ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Lbl_deleviredNumber);
            this.panel4.Controls.Add(this.Lbl_deliveredOrders);
            this.panel4.Location = new System.Drawing.Point(24, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 93);
            this.panel4.TabIndex = 101;
            // 
            // Lbl_deleviredNumber
            // 
            this.Lbl_deleviredNumber.AutoSize = true;
            this.Lbl_deleviredNumber.ForeColor = System.Drawing.Color.Chartreuse;
            this.Lbl_deleviredNumber.Location = new System.Drawing.Point(41, 32);
            this.Lbl_deleviredNumber.Name = "Lbl_deleviredNumber";
            this.Lbl_deleviredNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_deleviredNumber.TabIndex = 1;
            this.Lbl_deleviredNumber.Text = "0";
            //this.Lbl_deleviredNumber.Click += new System.EventHandler(this.Lbl_deleviredNumber_Click);
            // 
            // Lbl_deliveredOrders
            // 
            this.Lbl_deliveredOrders.AutoSize = true;
            this.Lbl_deliveredOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_deliveredOrders.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_deliveredOrders.Location = new System.Drawing.Point(119, 32);
            this.Lbl_deliveredOrders.Name = "Lbl_deliveredOrders";
            this.Lbl_deliveredOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_deliveredOrders.Size = new System.Drawing.Size(123, 21);
            this.Lbl_deliveredOrders.TabIndex = 0;
            this.Lbl_deliveredOrders.Text = "הזמנות שסופקו";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Lbl_waitingOrdersNumber);
            this.panel3.Controls.Add(this.Lbl_waitingOrders);
            this.panel3.Location = new System.Drawing.Point(24, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 93);
            this.panel3.TabIndex = 100;
            // 
            // Lbl_waitingOrdersNumber
            // 
            this.Lbl_waitingOrdersNumber.AutoSize = true;
            this.Lbl_waitingOrdersNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_waitingOrdersNumber.Location = new System.Drawing.Point(41, 24);
            this.Lbl_waitingOrdersNumber.Name = "Lbl_waitingOrdersNumber";
            this.Lbl_waitingOrdersNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_waitingOrdersNumber.TabIndex = 1;
            this.Lbl_waitingOrdersNumber.Text = "0";
            // 
            // Lbl_waitingOrders
            // 
            this.Lbl_waitingOrders.AutoSize = true;
            this.Lbl_waitingOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_waitingOrders.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_waitingOrders.Location = new System.Drawing.Point(87, 24);
            this.Lbl_waitingOrders.Name = "Lbl_waitingOrders";
            this.Lbl_waitingOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_waitingOrders.Size = new System.Drawing.Size(148, 21);
            this.Lbl_waitingOrders.TabIndex = 0;
            this.Lbl_waitingOrders.Text = "הזמנות שלא סופקו";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 12);
            this.panel1.TabIndex = 108;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.CalendarFont = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_from.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker_from.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker_from.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker_from.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker_from.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_from.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_from.Location = new System.Drawing.Point(392, 33);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_from.TabIndex = 109;
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.CalendarFont = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_to.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker_to.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker_to.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker_to.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker_to.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_to.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_to.Location = new System.Drawing.Point(392, 85);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_to.TabIndex = 110;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // Frm_ordersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(733, 475);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_fromDate);
            this.Controls.Add(this.Lbl_toDate);
            this.Controls.Add(this.Pnl_biggestOrderContainer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ordersData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ordersData";
            this.Load += new System.EventHandler(this.Frm_ordersData_Load);
            this.Pnl_biggestOrderContainer.ResumeLayout(false);
            this.Pnl_biggestOrderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_totalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_moneyBag)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_fromDate;
        private System.Windows.Forms.Label Lbl_toDate;
        private System.Windows.Forms.Panel Pnl_biggestOrderContainer;
        public System.Windows.Forms.Label Lbl_customersId;
        public System.Windows.Forms.Label Lbl_customersName;
        private System.Windows.Forms.Label Lbl_forCustomer;
        private System.Windows.Forms.PictureBox Pic_moneyBag;
        public System.Windows.Forms.Label Lbl_totalPrice;
        private System.Windows.Forms.Label Lbl_costOfBiggestOrder;
        private System.Windows.Forms.Label Lbl_biggestOrder;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label Lbl_totalOrdersNumber;
        private System.Windows.Forms.Label Lbl_totalOrders;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label Lbl_deleviredNumber;
        private System.Windows.Forms.Label Lbl_deliveredOrders;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label Lbl_waitingOrdersNumber;
        private System.Windows.Forms.Label Lbl_waitingOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.PictureBox Pic_totalPrice;
    }
}