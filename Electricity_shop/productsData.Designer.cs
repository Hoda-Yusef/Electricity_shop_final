
namespace Electricity_shop
{
    partial class Frm_productsData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_fromDate = new System.Windows.Forms.Label();
            this.Lbl_toDate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Lbl_categoryName = new System.Windows.Forms.Label();
            this.Lbl_mostSailedCategory = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_totalProductsNumber = new System.Windows.Forms.Label();
            this.Lbl_totalSoldProducts = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_aboutToRunOutNumber = new System.Windows.Forms.Label();
            this.Lbl_aboutToRunOutOFStock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_outOfStockNumber = new System.Windows.Forms.Label();
            this.Lbl_ranOutOfStock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_productCount = new System.Windows.Forms.Label();
            this.Lbl_productCountNumber = new System.Windows.Forms.Label();
            this.Lbl_productCategory = new System.Windows.Forms.Label();
            this.Lbl_productModel = new System.Windows.Forms.Label();
            this.Lbl_productBarcode = new System.Windows.Forms.Label();
            this.Lbl_mostSailedProduct = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.Btn_ordersDataSearch = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 12);
            this.panel1.TabIndex = 117;
            // 
            // Lbl_fromDate
            // 
            this.Lbl_fromDate.AutoSize = true;
            this.Lbl_fromDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_fromDate.Location = new System.Drawing.Point(604, 20);
            this.Lbl_fromDate.Name = "Lbl_fromDate";
            this.Lbl_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_fromDate.Size = new System.Drawing.Size(114, 32);
            this.Lbl_fromDate.TabIndex = 116;
            this.Lbl_fromDate.Text = "מתאריך :";
            // 
            // Lbl_toDate
            // 
            this.Lbl_toDate.AutoSize = true;
            this.Lbl_toDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_toDate.Location = new System.Drawing.Point(599, 72);
            this.Lbl_toDate.Name = "Lbl_toDate";
            this.Lbl_toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_toDate.Size = new System.Drawing.Size(111, 32);
            this.Lbl_toDate.TabIndex = 115;
            this.Lbl_toDate.Text = "לתאריך :";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Lbl_categoryName);
            this.panel6.Controls.Add(this.Lbl_mostSailedCategory);
            this.panel6.Location = new System.Drawing.Point(316, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 112);
            this.panel6.TabIndex = 112;
            // 
            // Lbl_categoryName
            // 
            this.Lbl_categoryName.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_categoryName.Location = new System.Drawing.Point(64, 59);
            this.Lbl_categoryName.Name = "Lbl_categoryName";
            this.Lbl_categoryName.Size = new System.Drawing.Size(260, 32);
            this.Lbl_categoryName.TabIndex = 1;
            this.Lbl_categoryName.Text = "שם קטגוריה";
            this.Lbl_categoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_mostSailedCategory
            // 
            this.Lbl_mostSailedCategory.AutoSize = true;
            this.Lbl_mostSailedCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_mostSailedCategory.Location = new System.Drawing.Point(108, 10);
            this.Lbl_mostSailedCategory.Name = "Lbl_mostSailedCategory";
            this.Lbl_mostSailedCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_mostSailedCategory.Size = new System.Drawing.Size(266, 32);
            this.Lbl_mostSailedCategory.TabIndex = 0;
            this.Lbl_mostSailedCategory.Text = "קטגוריה נמכרת ביותר :";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Lbl_totalProductsNumber);
            this.panel5.Controls.Add(this.Lbl_totalSoldProducts);
            this.panel5.Location = new System.Drawing.Point(37, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 111);
            this.panel5.TabIndex = 111;
            // 
            // Lbl_totalProductsNumber
            // 
            this.Lbl_totalProductsNumber.AutoSize = true;
            this.Lbl_totalProductsNumber.ForeColor = System.Drawing.Color.GreenYellow;
            this.Lbl_totalProductsNumber.Location = new System.Drawing.Point(139, 57);
            this.Lbl_totalProductsNumber.Name = "Lbl_totalProductsNumber";
            this.Lbl_totalProductsNumber.Size = new System.Drawing.Size(28, 32);
            this.Lbl_totalProductsNumber.TabIndex = 1;
            this.Lbl_totalProductsNumber.Text = "0";
            // 
            // Lbl_totalSoldProducts
            // 
            this.Lbl_totalSoldProducts.AutoSize = true;
            this.Lbl_totalSoldProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_totalSoldProducts.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_totalSoldProducts.Location = new System.Drawing.Point(48, 13);
            this.Lbl_totalSoldProducts.Name = "Lbl_totalSoldProducts";
            this.Lbl_totalSoldProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_totalSoldProducts.Size = new System.Drawing.Size(214, 28);
            this.Lbl_totalSoldProducts.TabIndex = 0;
            this.Lbl_totalSoldProducts.Text = "סה\"כ מוצרים שנמכרו ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Lbl_aboutToRunOutNumber);
            this.panel4.Controls.Add(this.Lbl_aboutToRunOutOFStock);
            this.panel4.Location = new System.Drawing.Point(37, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 93);
            this.panel4.TabIndex = 110;
            // 
            // Lbl_aboutToRunOutNumber
            // 
            this.Lbl_aboutToRunOutNumber.AutoSize = true;
            this.Lbl_aboutToRunOutNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_aboutToRunOutNumber.Location = new System.Drawing.Point(139, 45);
            this.Lbl_aboutToRunOutNumber.Name = "Lbl_aboutToRunOutNumber";
            this.Lbl_aboutToRunOutNumber.Size = new System.Drawing.Size(28, 32);
            this.Lbl_aboutToRunOutNumber.TabIndex = 1;
            this.Lbl_aboutToRunOutNumber.Text = "0";
            // 
            // Lbl_aboutToRunOutOFStock
            // 
            this.Lbl_aboutToRunOutOFStock.AutoSize = true;
            this.Lbl_aboutToRunOutOFStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_aboutToRunOutOFStock.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_aboutToRunOutOFStock.Location = new System.Drawing.Point(31, 6);
            this.Lbl_aboutToRunOutOFStock.Name = "Lbl_aboutToRunOutOFStock";
            this.Lbl_aboutToRunOutOFStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_aboutToRunOutOFStock.Size = new System.Drawing.Size(231, 28);
            this.Lbl_aboutToRunOutOFStock.TabIndex = 0;
            this.Lbl_aboutToRunOutOFStock.Text = "עומדים להיגמר מהמלאי";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Lbl_outOfStockNumber);
            this.panel3.Controls.Add(this.Lbl_ranOutOfStock);
            this.panel3.Location = new System.Drawing.Point(37, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 93);
            this.panel3.TabIndex = 109;
            // 
            // Lbl_outOfStockNumber
            // 
            this.Lbl_outOfStockNumber.AutoSize = true;
            this.Lbl_outOfStockNumber.ForeColor = System.Drawing.Color.Red;
            this.Lbl_outOfStockNumber.Location = new System.Drawing.Point(139, 47);
            this.Lbl_outOfStockNumber.Name = "Lbl_outOfStockNumber";
            this.Lbl_outOfStockNumber.Size = new System.Drawing.Size(28, 32);
            this.Lbl_outOfStockNumber.TabIndex = 1;
            this.Lbl_outOfStockNumber.Text = "0";
            // 
            // Lbl_ranOutOfStock
            // 
            this.Lbl_ranOutOfStock.AutoSize = true;
            this.Lbl_ranOutOfStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ranOutOfStock.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_ranOutOfStock.Location = new System.Drawing.Point(87, 11);
            this.Lbl_ranOutOfStock.Name = "Lbl_ranOutOfStock";
            this.Lbl_ranOutOfStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_ranOutOfStock.Size = new System.Drawing.Size(127, 28);
            this.Lbl_ranOutOfStock.TabIndex = 0;
            this.Lbl_ranOutOfStock.Text = "אזל מהמלאי";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Lbl_productCount);
            this.panel2.Controls.Add(this.Lbl_productCountNumber);
            this.panel2.Controls.Add(this.Lbl_productCategory);
            this.panel2.Controls.Add(this.Lbl_productModel);
            this.panel2.Controls.Add(this.Lbl_productBarcode);
            this.panel2.Controls.Add(this.Lbl_mostSailedProduct);
            this.panel2.Location = new System.Drawing.Point(316, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 192);
            this.panel2.TabIndex = 118;
            // 
            // Lbl_productCount
            // 
            this.Lbl_productCount.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productCount.Location = new System.Drawing.Point(134, 151);
            this.Lbl_productCount.Name = "Lbl_productCount";
            this.Lbl_productCount.Size = new System.Drawing.Size(86, 32);
            this.Lbl_productCount.TabIndex = 5;
            this.Lbl_productCount.Text = "יחידות";
            this.Lbl_productCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_productCountNumber
            // 
            this.Lbl_productCountNumber.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productCountNumber.Location = new System.Drawing.Point(217, 151);
            this.Lbl_productCountNumber.Name = "Lbl_productCountNumber";
            this.Lbl_productCountNumber.Size = new System.Drawing.Size(33, 32);
            this.Lbl_productCountNumber.TabIndex = 4;
            this.Lbl_productCountNumber.Text = "0";
            this.Lbl_productCountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_productCategory
            // 
            this.Lbl_productCategory.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productCategory.Location = new System.Drawing.Point(25, 116);
            this.Lbl_productCategory.Name = "Lbl_productCategory";
            this.Lbl_productCategory.Size = new System.Drawing.Size(340, 32);
            this.Lbl_productCategory.TabIndex = 3;
            this.Lbl_productCategory.Text = "קטגוריה";
            this.Lbl_productCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_productModel
            // 
            this.Lbl_productModel.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productModel.Location = new System.Drawing.Point(46, 79);
            this.Lbl_productModel.Name = "Lbl_productModel";
            this.Lbl_productModel.Size = new System.Drawing.Size(290, 32);
            this.Lbl_productModel.TabIndex = 2;
            this.Lbl_productModel.Text = "דגם";
            this.Lbl_productModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_productBarcode
            // 
            this.Lbl_productBarcode.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productBarcode.Location = new System.Drawing.Point(37, 41);
            this.Lbl_productBarcode.Name = "Lbl_productBarcode";
            this.Lbl_productBarcode.Size = new System.Drawing.Size(315, 32);
            this.Lbl_productBarcode.TabIndex = 1;
            this.Lbl_productBarcode.Text = "ברקוד";
            this.Lbl_productBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_mostSailedProduct
            // 
            this.Lbl_mostSailedProduct.AutoSize = true;
            this.Lbl_mostSailedProduct.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_mostSailedProduct.Location = new System.Drawing.Point(161, 5);
            this.Lbl_mostSailedProduct.Name = "Lbl_mostSailedProduct";
            this.Lbl_mostSailedProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_mostSailedProduct.Size = new System.Drawing.Size(209, 32);
            this.Lbl_mostSailedProduct.TabIndex = 0;
            this.Lbl_mostSailedProduct.Text = "מוצר נמכר ביותר :";
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
            this.dateTimePicker_from.Location = new System.Drawing.Point(390, 20);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(203, 38);
            this.dateTimePicker_from.TabIndex = 63;
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
            this.dateTimePicker_to.Location = new System.Drawing.Point(390, 72);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(203, 38);
            this.dateTimePicker_to.TabIndex = 119;
            // 
            // Btn_ordersDataSearch
            // 
            this.Btn_ordersDataSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_ordersDataSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ordersDataSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_ordersDataSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_ordersDataSearch.Location = new System.Drawing.Point(160, 35);
            this.Btn_ordersDataSearch.Name = "Btn_ordersDataSearch";
            this.Btn_ordersDataSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_ordersDataSearch.Size = new System.Drawing.Size(173, 55);
            this.Btn_ordersDataSearch.TabIndex = 120;
            this.Btn_ordersDataSearch.Text = "קבל מידע";
            this.Btn_ordersDataSearch.UseVisualStyleBackColor = false;
            this.Btn_ordersDataSearch.Click += new System.EventHandler(this.Btn_ordersDataSearch_Click);
            // 
            // Frm_productsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.Btn_ordersDataSearch);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_fromDate);
            this.Controls.Add(this.Lbl_toDate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_productsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productsData";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_fromDate;
        private System.Windows.Forms.Label Lbl_toDate;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label Lbl_categoryName;
        private System.Windows.Forms.Label Lbl_mostSailedCategory;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label Lbl_totalProductsNumber;
        private System.Windows.Forms.Label Lbl_totalSoldProducts;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label Lbl_aboutToRunOutNumber;
        private System.Windows.Forms.Label Lbl_aboutToRunOutOFStock;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label Lbl_outOfStockNumber;
        private System.Windows.Forms.Label Lbl_ranOutOfStock;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Lbl_productCategory;
        public System.Windows.Forms.Label Lbl_productModel;
        public System.Windows.Forms.Label Lbl_productBarcode;
        private System.Windows.Forms.Label Lbl_mostSailedProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Button Btn_ordersDataSearch;
        public System.Windows.Forms.Label Lbl_productCount;
        public System.Windows.Forms.Label Lbl_productCountNumber;
    }
}