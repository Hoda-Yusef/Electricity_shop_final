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
            this.UpperBluePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_inStockDocument = new System.Windows.Forms.Label();
            this.Lbl_info = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.Btn_search = new System.Windows.Forms.Button();
            this.Lbl_fromDate = new System.Windows.Forms.Label();
            this.Lbl_toDate = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.Pic_createPDF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_createPDF)).BeginInit();
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
            this.Btn_exit.Location = new System.Drawing.Point(798, 0);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(34, 28);
            this.Btn_exit.TabIndex = 38;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // UpperBluePanel
            // 
            this.UpperBluePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.UpperBluePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.UpperBluePanel.Location = new System.Drawing.Point(-4, -2);
            this.UpperBluePanel.Name = "UpperBluePanel";
            this.UpperBluePanel.Size = new System.Drawing.Size(843, 16);
            this.UpperBluePanel.TabIndex = 39;
            this.UpperBluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpperBluePanel_MouseDown);
            this.UpperBluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpperBluePanel_MouseMove);
            this.UpperBluePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpperBluePanel_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel3.Location = new System.Drawing.Point(-2, 812);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 10);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(826, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 830);
            this.panel2.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(-2, -4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 826);
            this.panel4.TabIndex = 42;
            // 
            // Lbl_inStockDocument
            // 
            this.Lbl_inStockDocument.AutoSize = true;
            this.Lbl_inStockDocument.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_inStockDocument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_inStockDocument.Location = new System.Drawing.Point(344, 18);
            this.Lbl_inStockDocument.Name = "Lbl_inStockDocument";
            this.Lbl_inStockDocument.Size = new System.Drawing.Size(128, 47);
            this.Lbl_inStockDocument.TabIndex = 43;
            this.Lbl_inStockDocument.Text = "דו\"חות";
            // 
            // Lbl_info
            // 
            this.Lbl_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(90)))));
            this.Lbl_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_info.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_info.Location = new System.Drawing.Point(170, 117);
            this.Lbl_info.Name = "Lbl_info";
            this.Lbl_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_info.Size = new System.Drawing.Size(581, 652);
            this.Lbl_info.TabIndex = 44;
            this.Lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.dateTimePicker_from.Location = new System.Drawing.Point(489, 82);
            this.dateTimePicker_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(154, 32);
            this.dateTimePicker_from.TabIndex = 45;
            // 
            // Btn_search
            // 
            this.Btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(184)))));
            this.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_search.Location = new System.Drawing.Point(39, 75);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(102, 38);
            this.Btn_search.TabIndex = 46;
            this.Btn_search.Text = "חפש";
            this.Btn_search.UseVisualStyleBackColor = false;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Lbl_fromDate
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(756, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "מ-תאריך :";
            // 
            // Lbl_toDate
            // 
            this.Lbl_toDate.AutoSize = true;
            this.Lbl_toDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_toDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_toDate.Location = new System.Drawing.Point(365, 82);
            this.Lbl_toDate.Name = "Lbl_toDate";
            this.Lbl_toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_toDate.Size = new System.Drawing.Size(105, 25);
            this.Lbl_toDate.TabIndex = 48;
            this.Lbl_toDate.Text = "עד תאריך :";
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
            this.dateTimePicker_to.Location = new System.Drawing.Point(192, 82);
            this.dateTimePicker_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(156, 32);
            this.dateTimePicker_to.TabIndex = 49;
            // 
            // Pic_createPDF
            // 
            this.Pic_createPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_createPDF.Image = global::Electricity_shop.Properties.Resources.doc;
            this.Pic_createPDF.Location = new System.Drawing.Point(694, 420);
            this.Pic_createPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_createPDF.Name = "Pic_createPDF";
            this.Pic_createPDF.Size = new System.Drawing.Size(126, 129);
            this.Pic_createPDF.TabIndex = 51;
            this.Pic_createPDF.TabStop = false;
            this.Pic_createPDF.MouseLeave += new System.EventHandler(this.Pic_createPDF_MouseLeave);
            this.Pic_createPDF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_createPDF_MouseMove);
            // 
            // Frm_documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(952, 820);
            this.Controls.Add(this.Pic_createPDF);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.Lbl_toDate);
            this.Controls.Add(this.Lbl_fromDate);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.Lbl_info);
            this.Controls.Add(this.Lbl_inStockDocument);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.UpperBluePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "documents";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_createPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Panel UpperBluePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_inStockDocument;
        private System.Windows.Forms.Label Lbl_info;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.Label Lbl_fromDate;
        private System.Windows.Forms.Label Lbl_toDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.PictureBox Pic_createPDF;
    }
}