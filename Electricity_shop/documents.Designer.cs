﻿
namespace Electricity_shop
{
    partial class Frm_documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_documents));
            this.Btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_inStockDocument = new System.Windows.Forms.Label();
            this.Lbl_info = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Btn_search = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pic_pdf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.Btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_exit.Image")));
            this.Btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_exit.Location = new System.Drawing.Point(1205, -3);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(34, 28);
            this.Btn_exit.TabIndex = 38;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 17);
            this.panel1.TabIndex = 39;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(-2, 676);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 13);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(1234, -6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 683);
            this.panel2.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(-2, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 691);
            this.panel4.TabIndex = 42;
            // 
            // Lbl_inStockDocument
            // 
            this.Lbl_inStockDocument.AutoSize = true;
            this.Lbl_inStockDocument.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_inStockDocument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_inStockDocument.Location = new System.Drawing.Point(538, 52);
            this.Lbl_inStockDocument.Name = "Lbl_inStockDocument";
            this.Lbl_inStockDocument.Size = new System.Drawing.Size(199, 47);
            this.Lbl_inStockDocument.TabIndex = 43;
            this.Lbl_inStockDocument.Text = "רווח והפסד";
            // 
            // Lbl_info
            // 
            this.Lbl_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(90)))));
            this.Lbl_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_info.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_info.Location = new System.Drawing.Point(26, 132);
            this.Lbl_info.Name = "Lbl_info";
            this.Lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_info.Size = new System.Drawing.Size(660, 531);
            this.Lbl_info.TabIndex = 44;
            this.Lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Showcard Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(820, 227);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(257, 29);
            this.dateTimePicker.TabIndex = 45;
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_search.Location = new System.Drawing.Point(859, 374);
            this.Btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(181, 51);
            this.Btn_search.TabIndex = 46;
            this.Btn_search.Text = "חפש";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Location = new System.Drawing.Point(1204, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 711);
            this.panel5.TabIndex = 47;
            // 
            // pic_pdf
            // 
            this.pic_pdf.Image = global::Electricity_shop.Properties.Resources.doc;
            this.pic_pdf.Location = new System.Drawing.Point(1011, 504);
            this.pic_pdf.Name = "pic_pdf";
            this.pic_pdf.Size = new System.Drawing.Size(140, 136);
            this.pic_pdf.TabIndex = 48;
            this.pic_pdf.TabStop = false;
            // 
            // Frm_documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1215, 683);
            this.Controls.Add(this.pic_pdf);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Lbl_info);
            this.Controls.Add(this.Lbl_inStockDocument);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "documents";
            ((System.ComponentModel.ISupportInitialize)(this.pic_pdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_inStockDocument;
        private System.Windows.Forms.Label Lbl_info;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pic_pdf;
    }
}