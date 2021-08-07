
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_totalProductsNumber = new System.Windows.Forms.Label();
            this.Lbl_totalSoldProducts = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_aboutToRunOutNumber = new System.Windows.Forms.Label();
            this.Lbl_aboutToRunOutOFStock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_outOfStockNumber = new System.Windows.Forms.Label();
            this.Lbl_ranOutOfStock = new System.Windows.Forms.Label();
            this.Lbl_mostSailedCategory = new System.Windows.Forms.Label();
            this.Lbl_categoryName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_mostSailedProduct = new System.Windows.Forms.Label();
            this.Lbl_productBarcode = new System.Windows.Forms.Label();
            this.Lbl_productModel = new System.Windows.Forms.Label();
            this.Lbl_productCategory = new System.Windows.Forms.Label();
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
            this.Lbl_fromDate.Size = new System.Drawing.Size(91, 25);
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
            this.Lbl_toDate.Size = new System.Drawing.Size(89, 25);
            this.Lbl_toDate.TabIndex = 115;
            this.Lbl_toDate.Text = "לתאריך :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 33);
            this.dateTimePicker1.TabIndex = 114;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(378, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 33);
            this.dateTimePicker2.TabIndex = 113;
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
            this.Lbl_totalProductsNumber.Location = new System.Drawing.Point(181, 55);
            this.Lbl_totalProductsNumber.Name = "Lbl_totalProductsNumber";
            this.Lbl_totalProductsNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_totalProductsNumber.TabIndex = 1;
            this.Lbl_totalProductsNumber.Text = "0";
            // 
            // Lbl_totalSoldProducts
            // 
            this.Lbl_totalSoldProducts.AutoSize = true;
            this.Lbl_totalSoldProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_totalSoldProducts.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_totalSoldProducts.Location = new System.Drawing.Point(100, 13);
            this.Lbl_totalSoldProducts.Name = "Lbl_totalSoldProducts";
            this.Lbl_totalSoldProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_totalSoldProducts.Size = new System.Drawing.Size(167, 21);
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
            this.Lbl_aboutToRunOutNumber.Location = new System.Drawing.Point(41, 34);
            this.Lbl_aboutToRunOutNumber.Name = "Lbl_aboutToRunOutNumber";
            this.Lbl_aboutToRunOutNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_aboutToRunOutNumber.TabIndex = 1;
            this.Lbl_aboutToRunOutNumber.Text = "0";
            // 
            // Lbl_aboutToRunOutOFStock
            // 
            this.Lbl_aboutToRunOutOFStock.AutoSize = true;
            this.Lbl_aboutToRunOutOFStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_aboutToRunOutOFStock.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_aboutToRunOutOFStock.Location = new System.Drawing.Point(86, 34);
            this.Lbl_aboutToRunOutOFStock.Name = "Lbl_aboutToRunOutOFStock";
            this.Lbl_aboutToRunOutOFStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_aboutToRunOutOFStock.Size = new System.Drawing.Size(181, 21);
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
            this.Lbl_outOfStockNumber.Location = new System.Drawing.Point(41, 24);
            this.Lbl_outOfStockNumber.Name = "Lbl_outOfStockNumber";
            this.Lbl_outOfStockNumber.Size = new System.Drawing.Size(23, 25);
            this.Lbl_outOfStockNumber.TabIndex = 1;
            this.Lbl_outOfStockNumber.Text = "0";
            // 
            // Lbl_ranOutOfStock
            // 
            this.Lbl_ranOutOfStock.AutoSize = true;
            this.Lbl_ranOutOfStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ranOutOfStock.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_ranOutOfStock.Location = new System.Drawing.Point(167, 28);
            this.Lbl_ranOutOfStock.Name = "Lbl_ranOutOfStock";
            this.Lbl_ranOutOfStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_ranOutOfStock.Size = new System.Drawing.Size(100, 21);
            this.Lbl_ranOutOfStock.TabIndex = 0;
            this.Lbl_ranOutOfStock.Text = "אזל מהמלאי";
            // 
            // Lbl_mostSailedCategory
            // 
            this.Lbl_mostSailedCategory.AutoSize = true;
            this.Lbl_mostSailedCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_mostSailedCategory.Location = new System.Drawing.Point(160, 10);
            this.Lbl_mostSailedCategory.Name = "Lbl_mostSailedCategory";
            this.Lbl_mostSailedCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_mostSailedCategory.Size = new System.Drawing.Size(211, 25);
            this.Lbl_mostSailedCategory.TabIndex = 0;
            this.Lbl_mostSailedCategory.Text = "קטגוריה נמכרת ביותר :";
            // 
            // Lbl_categoryName
            // 
            this.Lbl_categoryName.AutoSize = true;
            this.Lbl_categoryName.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_categoryName.Location = new System.Drawing.Point(135, 71);
            this.Lbl_categoryName.Name = "Lbl_categoryName";
            this.Lbl_categoryName.Size = new System.Drawing.Size(119, 25);
            this.Lbl_categoryName.TabIndex = 1;
            this.Lbl_categoryName.Text = "שם קטגוריה";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Lbl_productCategory);
            this.panel2.Controls.Add(this.Lbl_productModel);
            this.panel2.Controls.Add(this.Lbl_productBarcode);
            this.panel2.Controls.Add(this.Lbl_mostSailedProduct);
            this.panel2.Location = new System.Drawing.Point(316, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 192);
            this.panel2.TabIndex = 118;
            // 
            // Lbl_mostSailedProduct
            // 
            this.Lbl_mostSailedProduct.AutoSize = true;
            this.Lbl_mostSailedProduct.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_mostSailedProduct.Location = new System.Drawing.Point(205, 12);
            this.Lbl_mostSailedProduct.Name = "Lbl_mostSailedProduct";
            this.Lbl_mostSailedProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_mostSailedProduct.Size = new System.Drawing.Size(166, 25);
            this.Lbl_mostSailedProduct.TabIndex = 0;
            this.Lbl_mostSailedProduct.Text = "מוצר נמכר ביותר :";
            // 
            // Lbl_productBarcode
            // 
            this.Lbl_productBarcode.AutoSize = true;
            this.Lbl_productBarcode.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productBarcode.Location = new System.Drawing.Point(172, 67);
            this.Lbl_productBarcode.Name = "Lbl_productBarcode";
            this.Lbl_productBarcode.Size = new System.Drawing.Size(64, 25);
            this.Lbl_productBarcode.TabIndex = 1;
            this.Lbl_productBarcode.Text = "ברקוד";
            // 
            // Lbl_productModel
            // 
            this.Lbl_productModel.AutoSize = true;
            this.Lbl_productModel.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productModel.Location = new System.Drawing.Point(181, 110);
            this.Lbl_productModel.Name = "Lbl_productModel";
            this.Lbl_productModel.Size = new System.Drawing.Size(46, 25);
            this.Lbl_productModel.TabIndex = 2;
            this.Lbl_productModel.Text = "דגם";
            // 
            // Lbl_productCategory
            // 
            this.Lbl_productCategory.AutoSize = true;
            this.Lbl_productCategory.ForeColor = System.Drawing.Color.MediumPurple;
            this.Lbl_productCategory.Location = new System.Drawing.Point(160, 147);
            this.Lbl_productCategory.Name = "Lbl_productCategory";
            this.Lbl_productCategory.Size = new System.Drawing.Size(85, 25);
            this.Lbl_productCategory.TabIndex = 3;
            this.Lbl_productCategory.Text = "קטגוריה";
            // 
            // Frm_productsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_fromDate);
            this.Controls.Add(this.Lbl_toDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
    }
}