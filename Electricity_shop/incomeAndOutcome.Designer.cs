
namespace Electricity_shop
{
    partial class Frm_incomeAndOutcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_incomeAndOutcome));
            this.Lbl_vat = new System.Windows.Forms.Label();
            this.Txt_vat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_shekelsLost = new System.Windows.Forms.PictureBox();
            this.Lbl_totalOutcome = new System.Windows.Forms.Label();
            this.Pic_minus2 = new System.Windows.Forms.PictureBox();
            this.Lbl_outcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pic_shekelsBruto = new System.Windows.Forms.PictureBox();
            this.Lbl_brutoEarnings = new System.Windows.Forms.Label();
            this.Pic_moneyBag = new System.Windows.Forms.PictureBox();
            this.Lbl_totalEarnings = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pic_shekelsVat = new System.Windows.Forms.PictureBox();
            this.Lbl_vatTotal = new System.Windows.Forms.Label();
            this.Pic_minus1 = new System.Windows.Forms.PictureBox();
            this.Lbl_totalVat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pic_shekelsEarnings = new System.Windows.Forms.PictureBox();
            this.Lbl_totalIncome = new System.Windows.Forms.Label();
            this.Pic_plus = new System.Windows.Forms.PictureBox();
            this.Lbl_income = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Lbl_fromDate = new System.Windows.Forms.Label();
            this.Lbl_toDate = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_changeVAT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsLost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minus2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_moneyBag)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minus1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsEarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_plus)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_vat
            // 
            this.Lbl_vat.AutoSize = true;
            this.Lbl_vat.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_vat.Location = new System.Drawing.Point(352, 141);
            this.Lbl_vat.Name = "Lbl_vat";
            this.Lbl_vat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_vat.Size = new System.Drawing.Size(124, 25);
            this.Lbl_vat.TabIndex = 0;
            this.Lbl_vat.Text = "שיעור מע\"מ :";
            // 
            // Txt_vat
            // 
            this.Txt_vat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Txt_vat.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_vat.Location = new System.Drawing.Point(263, 138);
            this.Txt_vat.Name = "Txt_vat";
            this.Txt_vat.Size = new System.Drawing.Size(69, 33);
            this.Txt_vat.TabIndex = 1;
            this.Txt_vat.Text = "17";
            this.Txt_vat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_vat_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Pic_shekelsLost);
            this.panel1.Controls.Add(this.Lbl_totalOutcome);
            this.panel1.Controls.Add(this.Pic_minus2);
            this.panel1.Controls.Add(this.Lbl_outcome);
            this.panel1.Location = new System.Drawing.Point(72, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 118);
            this.panel1.TabIndex = 2;
            // 
            // Pic_shekelsLost
            // 
            this.Pic_shekelsLost.Image = ((System.Drawing.Image)(resources.GetObject("Pic_shekelsLost.Image")));
            this.Pic_shekelsLost.Location = new System.Drawing.Point(19, 65);
            this.Pic_shekelsLost.Name = "Pic_shekelsLost";
            this.Pic_shekelsLost.Size = new System.Drawing.Size(46, 32);
            this.Pic_shekelsLost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_shekelsLost.TabIndex = 4;
            this.Pic_shekelsLost.TabStop = false;
            // 
            // Lbl_totalOutcome
            // 
            this.Lbl_totalOutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_totalOutcome.Location = new System.Drawing.Point(10, 65);
            this.Lbl_totalOutcome.Name = "Lbl_totalOutcome";
            this.Lbl_totalOutcome.Size = new System.Drawing.Size(205, 32);
            this.Lbl_totalOutcome.TabIndex = 3;
            this.Lbl_totalOutcome.Text = "סכום בשקלים";
            this.Lbl_totalOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pic_minus2
            // 
            this.Pic_minus2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_minus2.Image")));
            this.Pic_minus2.Location = new System.Drawing.Point(221, 53);
            this.Pic_minus2.Name = "Pic_minus2";
            this.Pic_minus2.Size = new System.Drawing.Size(41, 50);
            this.Pic_minus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_minus2.TabIndex = 2;
            this.Pic_minus2.TabStop = false;
            // 
            // Lbl_outcome
            // 
            this.Lbl_outcome.AutoSize = true;
            this.Lbl_outcome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_outcome.Location = new System.Drawing.Point(41, 9);
            this.Lbl_outcome.Name = "Lbl_outcome";
            this.Lbl_outcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_outcome.Size = new System.Drawing.Size(184, 25);
            this.Lbl_outcome.TabIndex = 1;
            this.Lbl_outcome.Text = "הוצאות / תשלומים :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Pic_shekelsBruto);
            this.panel2.Controls.Add(this.Lbl_brutoEarnings);
            this.panel2.Controls.Add(this.Pic_moneyBag);
            this.panel2.Controls.Add(this.Lbl_totalEarnings);
            this.panel2.Location = new System.Drawing.Point(355, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 118);
            this.panel2.TabIndex = 2;
            // 
            // Pic_shekelsBruto
            // 
            this.Pic_shekelsBruto.Image = ((System.Drawing.Image)(resources.GetObject("Pic_shekelsBruto.Image")));
            this.Pic_shekelsBruto.Location = new System.Drawing.Point(7, 59);
            this.Pic_shekelsBruto.Name = "Pic_shekelsBruto";
            this.Pic_shekelsBruto.Size = new System.Drawing.Size(46, 32);
            this.Pic_shekelsBruto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_shekelsBruto.TabIndex = 4;
            this.Pic_shekelsBruto.TabStop = false;
            // 
            // Lbl_brutoEarnings
            // 
            this.Lbl_brutoEarnings.ForeColor = System.Drawing.Color.Olive;
            this.Lbl_brutoEarnings.Location = new System.Drawing.Point(7, 59);
            this.Lbl_brutoEarnings.Name = "Lbl_brutoEarnings";
            this.Lbl_brutoEarnings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_brutoEarnings.Size = new System.Drawing.Size(205, 32);
            this.Lbl_brutoEarnings.TabIndex = 3;
            this.Lbl_brutoEarnings.Text = "סכום ברוטו";
            this.Lbl_brutoEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pic_moneyBag
            // 
            this.Pic_moneyBag.Image = ((System.Drawing.Image)(resources.GetObject("Pic_moneyBag.Image")));
            this.Pic_moneyBag.Location = new System.Drawing.Point(220, 48);
            this.Pic_moneyBag.Name = "Pic_moneyBag";
            this.Pic_moneyBag.Size = new System.Drawing.Size(39, 50);
            this.Pic_moneyBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_moneyBag.TabIndex = 2;
            this.Pic_moneyBag.TabStop = false;
            // 
            // Lbl_totalEarnings
            // 
            this.Lbl_totalEarnings.AutoSize = true;
            this.Lbl_totalEarnings.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_totalEarnings.Location = new System.Drawing.Point(17, 10);
            this.Lbl_totalEarnings.Name = "Lbl_totalEarnings";
            this.Lbl_totalEarnings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_totalEarnings.Size = new System.Drawing.Size(203, 25);
            this.Lbl_totalEarnings.TabIndex = 0;
            this.Lbl_totalEarnings.Text = "רווח ברוטו כולל מע\"מ:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Pic_shekelsVat);
            this.panel3.Controls.Add(this.Lbl_vatTotal);
            this.panel3.Controls.Add(this.Pic_minus1);
            this.panel3.Controls.Add(this.Lbl_totalVat);
            this.panel3.Location = new System.Drawing.Point(355, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 118);
            this.panel3.TabIndex = 2;
            // 
            // Pic_shekelsVat
            // 
            this.Pic_shekelsVat.Image = ((System.Drawing.Image)(resources.GetObject("Pic_shekelsVat.Image")));
            this.Pic_shekelsVat.Location = new System.Drawing.Point(7, 65);
            this.Pic_shekelsVat.Name = "Pic_shekelsVat";
            this.Pic_shekelsVat.Size = new System.Drawing.Size(46, 32);
            this.Pic_shekelsVat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_shekelsVat.TabIndex = 4;
            this.Pic_shekelsVat.TabStop = false;
            // 
            // Lbl_vatTotal
            // 
            this.Lbl_vatTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Lbl_vatTotal.Location = new System.Drawing.Point(14, 65);
            this.Lbl_vatTotal.Name = "Lbl_vatTotal";
            this.Lbl_vatTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_vatTotal.Size = new System.Drawing.Size(194, 32);
            this.Lbl_vatTotal.TabIndex = 3;
            this.Lbl_vatTotal.Text = "סכום מע\"מ";
            this.Lbl_vatTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pic_minus1
            // 
            this.Pic_minus1.Image = ((System.Drawing.Image)(resources.GetObject("Pic_minus1.Image")));
            this.Pic_minus1.Location = new System.Drawing.Point(217, 53);
            this.Pic_minus1.Name = "Pic_minus1";
            this.Pic_minus1.Size = new System.Drawing.Size(41, 50);
            this.Pic_minus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_minus1.TabIndex = 2;
            this.Pic_minus1.TabStop = false;
            // 
            // Lbl_totalVat
            // 
            this.Lbl_totalVat.AutoSize = true;
            this.Lbl_totalVat.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_totalVat.Location = new System.Drawing.Point(171, 9);
            this.Lbl_totalVat.Name = "Lbl_totalVat";
            this.Lbl_totalVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_totalVat.Size = new System.Drawing.Size(69, 25);
            this.Lbl_totalVat.TabIndex = 1;
            this.Lbl_totalVat.Text = "מע\"מ :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Pic_shekelsEarnings);
            this.panel4.Controls.Add(this.Lbl_totalIncome);
            this.panel4.Controls.Add(this.Pic_plus);
            this.panel4.Controls.Add(this.Lbl_income);
            this.panel4.Location = new System.Drawing.Point(72, 194);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 118);
            this.panel4.TabIndex = 2;
            // 
            // Pic_shekelsEarnings
            // 
            this.Pic_shekelsEarnings.Image = ((System.Drawing.Image)(resources.GetObject("Pic_shekelsEarnings.Image")));
            this.Pic_shekelsEarnings.Location = new System.Drawing.Point(10, 66);
            this.Pic_shekelsEarnings.Name = "Pic_shekelsEarnings";
            this.Pic_shekelsEarnings.Size = new System.Drawing.Size(46, 32);
            this.Pic_shekelsEarnings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_shekelsEarnings.TabIndex = 4;
            this.Pic_shekelsEarnings.TabStop = false;
            // 
            // Lbl_totalIncome
            // 
            this.Lbl_totalIncome.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_totalIncome.Location = new System.Drawing.Point(10, 59);
            this.Lbl_totalIncome.Name = "Lbl_totalIncome";
            this.Lbl_totalIncome.Size = new System.Drawing.Size(198, 32);
            this.Lbl_totalIncome.TabIndex = 3;
            this.Lbl_totalIncome.Text = "רווח בשקלים";
            this.Lbl_totalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pic_plus
            // 
            this.Pic_plus.Image = ((System.Drawing.Image)(resources.GetObject("Pic_plus.Image")));
            this.Pic_plus.Location = new System.Drawing.Point(217, 48);
            this.Pic_plus.Name = "Pic_plus";
            this.Pic_plus.Size = new System.Drawing.Size(45, 50);
            this.Pic_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_plus.TabIndex = 2;
            this.Pic_plus.TabStop = false;
            // 
            // Lbl_income
            // 
            this.Lbl_income.AutoSize = true;
            this.Lbl_income.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_income.Location = new System.Drawing.Point(46, 10);
            this.Lbl_income.Name = "Lbl_income";
            this.Lbl_income.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_income.Size = new System.Drawing.Size(179, 25);
            this.Lbl_income.TabIndex = 1;
            this.Lbl_income.Text = "רווח נטו ללא מע\"מ:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(184)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(667, 12);
            this.panel5.TabIndex = 110;
            // 
            // Lbl_fromDate
            // 
            this.Lbl_fromDate.AutoSize = true;
            this.Lbl_fromDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_fromDate.Location = new System.Drawing.Point(534, 18);
            this.Lbl_fromDate.Name = "Lbl_fromDate";
            this.Lbl_fromDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_fromDate.Size = new System.Drawing.Size(91, 25);
            this.Lbl_fromDate.TabIndex = 113;
            this.Lbl_fromDate.Text = "מתאריך :";
            // 
            // Lbl_toDate
            // 
            this.Lbl_toDate.AutoSize = true;
            this.Lbl_toDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lbl_toDate.Location = new System.Drawing.Point(534, 76);
            this.Lbl_toDate.Name = "Lbl_toDate";
            this.Lbl_toDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_toDate.Size = new System.Drawing.Size(89, 25);
            this.Lbl_toDate.TabIndex = 113;
            this.Lbl_toDate.Text = "לתאריך :";
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
            this.dateTimePicker_from.Location = new System.Drawing.Point(311, 12);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_from.TabIndex = 114;
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
            this.dateTimePicker_to.Location = new System.Drawing.Point(311, 76);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_to.TabIndex = 115;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(300, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 26);
            this.textBox1.TabIndex = 117;
            this.textBox1.Text = "%";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_changeVAT
            // 
            this.Btn_changeVAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Btn_changeVAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_changeVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_changeVAT.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_changeVAT.Location = new System.Drawing.Point(114, 133);
            this.Btn_changeVAT.Name = "Btn_changeVAT";
            this.Btn_changeVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_changeVAT.Size = new System.Drawing.Size(115, 40);
            this.Btn_changeVAT.TabIndex = 118;
            this.Btn_changeVAT.Text = "שינוי מע\"מ";
            this.Btn_changeVAT.UseVisualStyleBackColor = false;
            this.Btn_changeVAT.Click += new System.EventHandler(this.Btn_changeVAT_Click);
            // 
            // Frm_incomeAndOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(667, 467);
            this.Controls.Add(this.Btn_changeVAT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.Lbl_toDate);
            this.Controls.Add(this.Lbl_fromDate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_vat);
            this.Controls.Add(this.Lbl_vat);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_incomeAndOutcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "incomeAndOutcome";
            this.Load += new System.EventHandler(this.Frm_incomeAndOutcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsLost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minus2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_moneyBag)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_minus1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_shekelsEarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_plus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_vat;
        public System.Windows.Forms.TextBox Txt_vat;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Lbl_totalOutcome;
        private System.Windows.Forms.PictureBox Pic_minus2;
        private System.Windows.Forms.Label Lbl_outcome;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Lbl_brutoEarnings;
        private System.Windows.Forms.PictureBox Pic_moneyBag;
        private System.Windows.Forms.Label Lbl_totalEarnings;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label Lbl_vatTotal;
        private System.Windows.Forms.PictureBox Pic_minus1;
        private System.Windows.Forms.Label Lbl_totalVat;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label Lbl_totalIncome;
        private System.Windows.Forms.PictureBox Pic_plus;
        private System.Windows.Forms.Label Lbl_income;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_fromDate;
        private System.Windows.Forms.Label Lbl_toDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Pic_shekelsLost;
        private System.Windows.Forms.PictureBox Pic_shekelsBruto;
        private System.Windows.Forms.PictureBox Pic_shekelsVat;
        private System.Windows.Forms.PictureBox Pic_shekelsEarnings;
        private System.Windows.Forms.Button Btn_changeVAT;
    }
}