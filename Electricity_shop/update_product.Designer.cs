
using System;
using System.Windows.Forms;

namespace Electricity_shop
{
    partial class Frm_updateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_updateProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_supplier = new System.Windows.Forms.Label();
            this.Lbl_inStock = new System.Windows.Forms.Label();
            this.Lbl_productInformation = new System.Windows.Forms.Label();
            this.Lbl_sellingPrice = new System.Windows.Forms.Label();
            this.Txt_productInfo = new System.Windows.Forms.TextBox();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_updateProduct = new System.Windows.Forms.Button();
            this.Lbl_barcode = new System.Windows.Forms.Label();
            this.Txt_barcode = new System.Windows.Forms.TextBox();
            this.Lbl_category = new System.Windows.Forms.Label();
            this.Lbl_model = new System.Windows.Forms.Label();
            this.Txt_supplier = new System.Windows.Forms.TextBox();
            this.Lbl_manufacturer = new System.Windows.Forms.Label();
            this.Lbl_costPrice = new System.Windows.Forms.Label();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.Txt_manufacturer = new System.Windows.Forms.TextBox();
            this.Txt_selling_price = new System.Windows.Forms.TextBox();
            this.Txt_model = new System.Windows.Forms.TextBox();
            this.Txt_cost_price = new System.Windows.Forms.TextBox();
            this.Txt_category = new System.Windows.Forms.TextBox();
            this.Lbl_updateProduct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel44X = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.Lbl_supplier);
            this.panel1.Controls.Add(this.Lbl_inStock);
            this.panel1.Controls.Add(this.Lbl_productInformation);
            this.panel1.Controls.Add(this.Lbl_sellingPrice);
            this.panel1.Controls.Add(this.Txt_productInfo);
            this.panel1.Controls.Add(this.Btn_cancel);
            this.panel1.Controls.Add(this.Btn_updateProduct);
            this.panel1.Controls.Add(this.Lbl_barcode);
            this.panel1.Controls.Add(this.Txt_barcode);
            this.panel1.Controls.Add(this.Lbl_category);
            this.panel1.Controls.Add(this.Lbl_model);
            this.panel1.Controls.Add(this.Txt_supplier);
            this.panel1.Controls.Add(this.Lbl_manufacturer);
            this.panel1.Controls.Add(this.Lbl_costPrice);
            this.panel1.Controls.Add(this.Txt_amount);
            this.panel1.Controls.Add(this.Txt_manufacturer);
            this.panel1.Controls.Add(this.Txt_selling_price);
            this.panel1.Controls.Add(this.Txt_model);
            this.panel1.Controls.Add(this.Txt_cost_price);
            this.panel1.Controls.Add(this.Txt_category);
            this.panel1.Location = new System.Drawing.Point(149, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 553);
            this.panel1.TabIndex = 56;
            // 
            // Lbl_supplier
            // 
            this.Lbl_supplier.AutoSize = true;
            this.Lbl_supplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_supplier.Location = new System.Drawing.Point(752, 434);
            this.Lbl_supplier.Name = "Lbl_supplier";
            this.Lbl_supplier.Size = new System.Drawing.Size(54, 28);
            this.Lbl_supplier.TabIndex = 26;
            this.Lbl_supplier.Text = "ספק";
            // 
            // Lbl_inStock
            // 
            this.Lbl_inStock.AutoSize = true;
            this.Lbl_inStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_inStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_inStock.Location = new System.Drawing.Point(215, 250);
            this.Lbl_inStock.Name = "Lbl_inStock";
            this.Lbl_inStock.Size = new System.Drawing.Size(124, 28);
            this.Lbl_inStock.TabIndex = 25;
            this.Lbl_inStock.Text = "כמות במלאי";
            // 
            // Lbl_productInformation
            // 
            this.Lbl_productInformation.AutoSize = true;
            this.Lbl_productInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_productInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_productInformation.Location = new System.Drawing.Point(216, 346);
            this.Lbl_productInformation.Name = "Lbl_productInformation";
            this.Lbl_productInformation.Size = new System.Drawing.Size(117, 28);
            this.Lbl_productInformation.TabIndex = 24;
            this.Lbl_productInformation.Text = "מפרט מוצר";
            // 
            // Lbl_sellingPrice
            // 
            this.Lbl_sellingPrice.AutoSize = true;
            this.Lbl_sellingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_sellingPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_sellingPrice.Location = new System.Drawing.Point(224, 147);
            this.Lbl_sellingPrice.Name = "Lbl_sellingPrice";
            this.Lbl_sellingPrice.Size = new System.Drawing.Size(122, 28);
            this.Lbl_sellingPrice.TabIndex = 23;
            this.Lbl_sellingPrice.Text = "מחיר מכירה";
            // 
            // Txt_productInfo
            // 
            this.Txt_productInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_productInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_productInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.Txt_productInfo.Location = new System.Drawing.Point(57, 367);
            this.Txt_productInfo.Multiline = true;
            this.Txt_productInfo.Name = "Txt_productInfo";
            this.Txt_productInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_productInfo.Size = new System.Drawing.Size(317, 38);
            this.Txt_productInfo.TabIndex = 22;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_cancel.Location = new System.Drawing.Point(57, 457);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(135, 47);
            this.Btn_cancel.TabIndex = 20;
            this.Btn_cancel.Text = "ביטול";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Btn_updateProduct
            // 
            this.Btn_updateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_updateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_updateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_updateProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_updateProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_updateProduct.Location = new System.Drawing.Point(222, 457);
            this.Btn_updateProduct.Name = "Btn_updateProduct";
            this.Btn_updateProduct.Size = new System.Drawing.Size(135, 47);
            this.Btn_updateProduct.TabIndex = 19;
            this.Btn_updateProduct.Text = "עדכן";
            this.Btn_updateProduct.UseVisualStyleBackColor = false;
            this.Btn_updateProduct.Click += new System.EventHandler(this.Btn_updateProduct_Click);
            // 
            // Lbl_barcode
            // 
            this.Lbl_barcode.AutoSize = true;
            this.Lbl_barcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_barcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_barcode.Location = new System.Drawing.Point(740, 44);
            this.Lbl_barcode.Name = "Lbl_barcode";
            this.Lbl_barcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_barcode.Size = new System.Drawing.Size(67, 28);
            this.Lbl_barcode.TabIndex = 1;
            this.Lbl_barcode.Text = "ברקוד";
            // 
            // Txt_barcode
            // 
            this.Txt_barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_barcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_barcode.ForeColor = System.Drawing.Color.White;
            this.Txt_barcode.Location = new System.Drawing.Point(575, 67);
            this.Txt_barcode.Multiline = true;
            this.Txt_barcode.Name = "Txt_barcode";
            this.Txt_barcode.Size = new System.Drawing.Size(257, 38);
            this.Txt_barcode.TabIndex = 2;
            this.Txt_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_barcode_KeyPress);
            this.Txt_barcode.Leave += new System.EventHandler(this.Txt_barcode_Leave);
            // 
            // Lbl_category
            // 
            this.Lbl_category.AutoSize = true;
            this.Lbl_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_category.Location = new System.Drawing.Point(719, 147);
            this.Lbl_category.Name = "Lbl_category";
            this.Lbl_category.Size = new System.Drawing.Size(88, 28);
            this.Lbl_category.TabIndex = 4;
            this.Lbl_category.Text = "קטגוריה";
            // 
            // Lbl_model
            // 
            this.Lbl_model.AutoSize = true;
            this.Lbl_model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_model.Location = new System.Drawing.Point(757, 251);
            this.Lbl_model.Name = "Lbl_model";
            this.Lbl_model.Size = new System.Drawing.Size(47, 28);
            this.Lbl_model.TabIndex = 7;
            this.Lbl_model.Text = "דגם";
            // 
            // Txt_supplier
            // 
            this.Txt_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_supplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_supplier.ForeColor = System.Drawing.Color.White;
            this.Txt_supplier.Location = new System.Drawing.Point(575, 457);
            this.Txt_supplier.Multiline = true;
            this.Txt_supplier.Name = "Txt_supplier";
            this.Txt_supplier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_supplier.Size = new System.Drawing.Size(257, 38);
            this.Txt_supplier.TabIndex = 11;
            // 
            // Lbl_manufacturer
            // 
            this.Lbl_manufacturer.AutoSize = true;
            this.Lbl_manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_manufacturer.Location = new System.Drawing.Point(756, 345);
            this.Lbl_manufacturer.Name = "Lbl_manufacturer";
            this.Lbl_manufacturer.Size = new System.Drawing.Size(49, 28);
            this.Lbl_manufacturer.TabIndex = 10;
            this.Lbl_manufacturer.Text = "יצרן";
            // 
            // Lbl_costPrice
            // 
            this.Lbl_costPrice.AutoSize = true;
            this.Lbl_costPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_costPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Lbl_costPrice.Location = new System.Drawing.Point(243, 45);
            this.Lbl_costPrice.Name = "Lbl_costPrice";
            this.Lbl_costPrice.Size = new System.Drawing.Size(110, 28);
            this.Lbl_costPrice.TabIndex = 18;
            this.Lbl_costPrice.Text = "מחיר עלות";
            // 
            // Txt_amount
            // 
            this.Txt_amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_amount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_amount.ForeColor = System.Drawing.Color.White;
            this.Txt_amount.Location = new System.Drawing.Point(117, 273);
            this.Txt_amount.Multiline = true;
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_amount.Size = new System.Drawing.Size(257, 38);
            this.Txt_amount.TabIndex = 13;
            this.Txt_amount.TextChanged += new System.EventHandler(this.Txt_amount_TextChanged);
            this.Txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_amount_KeyPress_1);
            // 
            // Txt_manufacturer
            // 
            this.Txt_manufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_manufacturer.ForeColor = System.Drawing.SystemColors.Window;
            this.Txt_manufacturer.Location = new System.Drawing.Point(575, 367);
            this.Txt_manufacturer.Multiline = true;
            this.Txt_manufacturer.Name = "Txt_manufacturer";
            this.Txt_manufacturer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_manufacturer.Size = new System.Drawing.Size(257, 38);
            this.Txt_manufacturer.TabIndex = 9;
            // 
            // Txt_selling_price
            // 
            this.Txt_selling_price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_selling_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_selling_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_selling_price.ForeColor = System.Drawing.Color.White;
            this.Txt_selling_price.Location = new System.Drawing.Point(117, 168);
            this.Txt_selling_price.Multiline = true;
            this.Txt_selling_price.Name = "Txt_selling_price";
            this.Txt_selling_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_selling_price.Size = new System.Drawing.Size(257, 38);
            this.Txt_selling_price.TabIndex = 14;
            this.Txt_selling_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_selling_price_KeyPress);
            // 
            // Txt_model
            // 
            this.Txt_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_model.ForeColor = System.Drawing.SystemColors.Window;
            this.Txt_model.Location = new System.Drawing.Point(575, 273);
            this.Txt_model.Multiline = true;
            this.Txt_model.Name = "Txt_model";
            this.Txt_model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_model.Size = new System.Drawing.Size(257, 38);
            this.Txt_model.TabIndex = 8;
            this.Txt_model.Leave += new System.EventHandler(this.Txt_model_Leave);
            // 
            // Txt_cost_price
            // 
            this.Txt_cost_price.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_cost_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_cost_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_cost_price.ForeColor = System.Drawing.Color.White;
            this.Txt_cost_price.Location = new System.Drawing.Point(117, 67);
            this.Txt_cost_price.Multiline = true;
            this.Txt_cost_price.Name = "Txt_cost_price";
            this.Txt_cost_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_cost_price.Size = new System.Drawing.Size(257, 38);
            this.Txt_cost_price.TabIndex = 15;
            this.Txt_cost_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cost_price_KeyPress);
            // 
            // Txt_category
            // 
            this.Txt_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Txt_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_category.ForeColor = System.Drawing.Color.White;
            this.Txt_category.Location = new System.Drawing.Point(575, 168);
            this.Txt_category.Multiline = true;
            this.Txt_category.Name = "Txt_category";
            this.Txt_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_category.Size = new System.Drawing.Size(257, 38);
            this.Txt_category.TabIndex = 3;
            // 
            // Lbl_updateProduct
            // 
            this.Lbl_updateProduct.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_updateProduct.ForeColor = System.Drawing.Color.White;
            this.Lbl_updateProduct.Location = new System.Drawing.Point(423, 36);
            this.Lbl_updateProduct.Name = "Lbl_updateProduct";
            this.Lbl_updateProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_updateProduct.Size = new System.Drawing.Size(283, 67);
            this.Lbl_updateProduct.TabIndex = 59;
            this.Lbl_updateProduct.Text = "עדכון מוצר";
            this.Lbl_updateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(-8, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 755);
            this.panel3.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(1157, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 805);
            this.panel2.TabIndex = 62;
            // 
            // panel44X
            // 
            this.panel44X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel44X.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel44X.Location = new System.Drawing.Point(-8, -5);
            this.panel44X.Name = "panel44X";
            this.panel44X.Size = new System.Drawing.Size(1180, 26);
            this.panel44X.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(-33, 763);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1201, 11);
            this.panel5.TabIndex = 64;
            // 
            // Btn_close
            // 
            this.Btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_close.Image")));
            this.Btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_close.Location = new System.Drawing.Point(-2, -6);
            this.Btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(39, 46);
            this.Btn_close.TabIndex = 65;
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Frm_updateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1175, 772);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.panel44X);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_updateProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_updateProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_product";
            this.Load += new System.EventHandler(this.update_product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_updateProduct;
        private System.Windows.Forms.Label Lbl_barcode;
        private System.Windows.Forms.Label Lbl_manufacturer;
        private System.Windows.Forms.Label Lbl_model;
        private System.Windows.Forms.Label Lbl_costPrice;
        private System.Windows.Forms.Label Lbl_category;
       // private System.Windows.Forms.Button button3;
       // private System.Windows.Forms.TextBox textBox1;
       // private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_updateProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
       // private System.Windows.Forms.Label Lbl_productInformation;
        public System.Windows.Forms.TextBox Txt_productInfo;
        public System.Windows.Forms.TextBox Txt_barcode;
        public System.Windows.Forms.TextBox Txt_supplier;
        public System.Windows.Forms.TextBox Txt_amount;
        public System.Windows.Forms.TextBox Txt_manufacturer;
        public System.Windows.Forms.TextBox Txt_selling_price;
        public System.Windows.Forms.TextBox Txt_model;
        public System.Windows.Forms.TextBox Txt_cost_price;
        public System.Windows.Forms.TextBox Txt_category;
        public System.Windows.Forms.Panel panel44X;
        private object product_serial_number;
        private Button Btn_close;
        private Label Lbl_sellingPrice;
        private Label Lbl_productInformation;
        private Label Lbl_inStock;
        private Label Lbl_supplier;
    }
}