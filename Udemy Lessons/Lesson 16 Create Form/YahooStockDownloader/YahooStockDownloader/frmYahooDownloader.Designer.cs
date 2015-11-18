namespace YahooStockDownloader
{
    partial class frmYahooDownloader
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
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.dlComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasdaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnChooseSavePath = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboFromMonth = new System.Windows.Forms.ComboBox();
            this.nudFromDay = new System.Windows.Forms.NumericUpDown();
            this.nudFromYear = new System.Windows.Forms.NumericUpDown();
            this.cboToMonth = new System.Windows.Forms.ComboBox();
            this.nudToDay = new System.Windows.Forms.NumericUpDown();
            this.nudToYear = new System.Windows.Forms.NumericUpDown();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.lblTickers = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlComponentsToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(660, 24);
            this.mnuStrip.TabIndex = 0;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // dlComponentsToolStripMenuItem
            // 
            this.dlComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dow30ToolStripMenuItem,
            this.sP100ToolStripMenuItem,
            this.nasdaq100ToolStripMenuItem});
            this.dlComponentsToolStripMenuItem.Name = "dlComponentsToolStripMenuItem";
            this.dlComponentsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dlComponentsToolStripMenuItem.Text = "Index Components";
            // 
            // dow30ToolStripMenuItem
            // 
            this.dow30ToolStripMenuItem.Name = "dow30ToolStripMenuItem";
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            // 
            // sP100ToolStripMenuItem
            // 
            this.sP100ToolStripMenuItem.Name = "sP100ToolStripMenuItem";
            this.sP100ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sP100ToolStripMenuItem.Text = "S&&P 100";
            // 
            // nasdaq100ToolStripMenuItem
            // 
            this.nasdaq100ToolStripMenuItem.Name = "nasdaq100ToolStripMenuItem";
            this.nasdaq100ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nasdaq100ToolStripMenuItem.Text = "Nasdaq 100";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(51, 39);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(64, 13);
            this.lblFolderPath.TabIndex = 1;
            this.lblFolderPath.Text = "Folder Path:";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(146, 39);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(349, 20);
            this.txtSavePath.TabIndex = 2;
            // 
            // btnChooseSavePath
            // 
            this.btnChooseSavePath.Location = new System.Drawing.Point(520, 39);
            this.btnChooseSavePath.Name = "btnChooseSavePath";
            this.btnChooseSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSavePath.TabIndex = 4;
            this.btnChooseSavePath.Text = "Choose";
            this.btnChooseSavePath.UseVisualStyleBackColor = true;
            this.btnChooseSavePath.Click += new System.EventHandler(this.btnChooseSavePath_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(51, 96);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(51, 132);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date:";
            // 
            // cboFromMonth
            // 
            this.cboFromMonth.FormattingEnabled = true;
            this.cboFromMonth.Items.AddRange(new object[] {
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
            this.cboFromMonth.Location = new System.Drawing.Point(146, 87);
            this.cboFromMonth.Name = "cboFromMonth";
            this.cboFromMonth.Size = new System.Drawing.Size(60, 21);
            this.cboFromMonth.TabIndex = 7;
            // 
            // nudFromDay
            // 
            this.nudFromDay.Location = new System.Drawing.Point(235, 87);
            this.nudFromDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudFromDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFromDay.Name = "nudFromDay";
            this.nudFromDay.Size = new System.Drawing.Size(73, 20);
            this.nudFromDay.TabIndex = 8;
            this.nudFromDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFromYear
            // 
            this.nudFromYear.Location = new System.Drawing.Point(336, 87);
            this.nudFromYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudFromYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudFromYear.Name = "nudFromYear";
            this.nudFromYear.Size = new System.Drawing.Size(66, 20);
            this.nudFromYear.TabIndex = 9;
            this.nudFromYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cboToMonth
            // 
            this.cboToMonth.FormattingEnabled = true;
            this.cboToMonth.Items.AddRange(new object[] {
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
            this.cboToMonth.Location = new System.Drawing.Point(146, 132);
            this.cboToMonth.Name = "cboToMonth";
            this.cboToMonth.Size = new System.Drawing.Size(60, 21);
            this.cboToMonth.TabIndex = 10;
            // 
            // nudToDay
            // 
            this.nudToDay.Location = new System.Drawing.Point(235, 132);
            this.nudToDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudToDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToDay.Name = "nudToDay";
            this.nudToDay.Size = new System.Drawing.Size(73, 20);
            this.nudToDay.TabIndex = 11;
            this.nudToDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToYear
            // 
            this.nudToYear.Location = new System.Drawing.Point(336, 132);
            this.nudToYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudToYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudToYear.Name = "nudToYear";
            this.nudToYear.Size = new System.Drawing.Size(66, 20);
            this.nudToYear.TabIndex = 12;
            this.nudToYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Location = new System.Drawing.Point(430, 87);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 13;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(430, 111);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 14;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(430, 135);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 15;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(520, 85);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 16;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(146, 180);
            this.txtTicker.Multiline = true;
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(256, 96);
            this.txtTicker.TabIndex = 17;
            this.txtTicker.Text = "GOOG,AAPL,AMZN";
            // 
            // lblTickers
            // 
            this.lblTickers.AutoSize = true;
            this.lblTickers.Location = new System.Drawing.Point(51, 180);
            this.lblTickers.Name = "lblTickers";
            this.lblTickers.Size = new System.Drawing.Size(82, 13);
            this.lblTickers.TabIndex = 18;
            this.lblTickers.Text = "Ticker Symbols:";
            // 
            // frmYahooDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 314);
            this.Controls.Add(this.lblTickers);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.nudToYear);
            this.Controls.Add(this.nudToDay);
            this.Controls.Add(this.cboToMonth);
            this.Controls.Add(this.nudFromYear);
            this.Controls.Add(this.nudFromDay);
            this.Controls.Add(this.cboFromMonth);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnChooseSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmYahooDownloader";
            this.Text = "Yahoo Stock Downloader";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem dlComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sP100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasdaq100ToolStripMenuItem;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnChooseSavePath;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboFromMonth;
        private System.Windows.Forms.NumericUpDown nudFromDay;
        private System.Windows.Forms.NumericUpDown nudFromYear;
        private System.Windows.Forms.ComboBox cboToMonth;
        private System.Windows.Forms.NumericUpDown nudToDay;
        private System.Windows.Forms.NumericUpDown nudToYear;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label lblTickers;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

