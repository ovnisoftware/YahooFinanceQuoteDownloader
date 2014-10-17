namespace YahooDownloader
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTicker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromMonth = new System.Windows.Forms.ComboBox();
            this.toMonth = new System.Windows.Forms.ComboBox();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.fromDay = new System.Windows.Forms.NumericUpDown();
            this.toDay = new System.Windows.Forms.NumericUpDown();
            this.fromYear = new System.Windows.Forms.NumericUpDown();
            this.toYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fromDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toYear)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(102, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(256, 20);
            this.txtPath.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Path:";
            // 
            // textBoxTicker
            // 
            this.textBoxTicker.Location = new System.Drawing.Point(103, 112);
            this.textBoxTicker.Multiline = true;
            this.textBoxTicker.Name = "textBoxTicker";
            this.textBoxTicker.Size = new System.Drawing.Size(256, 86);
            this.textBoxTicker.TabIndex = 3;
            this.textBoxTicker.Text = "goog, aapl, amzn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ticker symbols, \n separate with \n a comma ,";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Download to .csv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date:";
            // 
            // fromMonth
            // 
            this.fromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromMonth.FormattingEnabled = true;
            this.fromMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.fromMonth.Location = new System.Drawing.Point(103, 46);
            this.fromMonth.Name = "fromMonth";
            this.fromMonth.Size = new System.Drawing.Size(50, 21);
            this.fromMonth.TabIndex = 8;
            // 
            // toMonth
            // 
            this.toMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toMonth.FormattingEnabled = true;
            this.toMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.toMonth.Location = new System.Drawing.Point(103, 74);
            this.toMonth.Name = "toMonth";
            this.toMonth.Size = new System.Drawing.Size(50, 21);
            this.toMonth.TabIndex = 9;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Location = new System.Drawing.Point(300, 46);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 14;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(300, 67);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 15;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(300, 89);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 16;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // fromDay
            // 
            this.fromDay.Location = new System.Drawing.Point(161, 46);
            this.fromDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.fromDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromDay.Name = "fromDay";
            this.fromDay.Size = new System.Drawing.Size(48, 20);
            this.fromDay.TabIndex = 17;
            this.fromDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // toDay
            // 
            this.toDay.Location = new System.Drawing.Point(161, 76);
            this.toDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.toDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toDay.Name = "toDay";
            this.toDay.Size = new System.Drawing.Size(48, 20);
            this.toDay.TabIndex = 18;
            this.toDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fromYear
            // 
            this.fromYear.Location = new System.Drawing.Point(216, 46);
            this.fromYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.fromYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.fromYear.Name = "fromYear";
            this.fromYear.Size = new System.Drawing.Size(67, 20);
            this.fromYear.TabIndex = 19;
            this.fromYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // toYear
            // 
            this.toYear.Location = new System.Drawing.Point(216, 78);
            this.toYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.toYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.toYear.Name = "toYear";
            this.toYear.Size = new System.Drawing.Size(67, 20);
            this.toYear.TabIndex = 20;
            this.toYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 227);
            this.Controls.Add(this.toYear);
            this.Controls.Add(this.fromYear);
            this.Controls.Add(this.toDay);
            this.Controls.Add(this.fromDay);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.toMonth);
            this.Controls.Add(this.fromMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Yahoo Historical Quote Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.fromDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fromMonth;
        private System.Windows.Forms.ComboBox toMonth;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.NumericUpDown fromDay;
        private System.Windows.Forms.NumericUpDown toDay;
        private System.Windows.Forms.NumericUpDown fromYear;
        private System.Windows.Forms.NumericUpDown toYear;
    }
}

