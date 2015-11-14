namespace YahooDownloader
{
    partial class frmDownload
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.lblTickers = new System.Windows.Forms.Label();
            this.btnDL = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboFromMonth = new System.Windows.Forms.ComboBox();
            this.cboToMonth = new System.Windows.Forms.ComboBox();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.nudFromDay = new System.Windows.Forms.NumericUpDown();
            this.nudToDay = new System.Windows.Forms.NumericUpDown();
            this.nudFromYear = new System.Windows.Forms.NumericUpDown();
            this.nudToYear = new System.Windows.Forms.NumericUpDown();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.dLComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dow30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sP100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasdaq100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(102, 23);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(256, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(376, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(33, 26);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(64, 13);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "Folder Path:";
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(103, 125);
            this.txtTicker.Multiline = true;
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicker.Size = new System.Drawing.Size(256, 111);
            this.txtTicker.TabIndex = 3;
            this.txtTicker.Text = "GOOG, AAPL, AMZN";
            // 
            // lblTickers
            // 
            this.lblTickers.AutoSize = true;
            this.lblTickers.Location = new System.Drawing.Point(14, 128);
            this.lblTickers.Name = "lblTickers";
            this.lblTickers.Size = new System.Drawing.Size(83, 39);
            this.lblTickers.TabIndex = 4;
            this.lblTickers.Text = "Ticker symbols, \n separate with \n a comma ,";
            // 
            // btnDL
            // 
            this.btnDL.Location = new System.Drawing.Point(376, 59);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(75, 39);
            this.btnDL.TabIndex = 5;
            this.btnDL.Text = "Download to .csv";
            this.btnDL.UseVisualStyleBackColor = true;
            this.btnDL.Click += new System.EventHandler(this.btnDL_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 63);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(42, 91);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date:";
            // 
            // cboFromMonth
            // 
            this.cboFromMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboFromMonth.Location = new System.Drawing.Point(103, 59);
            this.cboFromMonth.Name = "cboFromMonth";
            this.cboFromMonth.Size = new System.Drawing.Size(50, 21);
            this.cboFromMonth.TabIndex = 8;
            // 
            // cboToMonth
            // 
            this.cboToMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboToMonth.Location = new System.Drawing.Point(103, 87);
            this.cboToMonth.Name = "cboToMonth";
            this.cboToMonth.Size = new System.Drawing.Size(50, 21);
            this.cboToMonth.TabIndex = 9;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Location = new System.Drawing.Point(300, 59);
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
            this.rbWeekly.Location = new System.Drawing.Point(300, 80);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 15;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(300, 102);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 16;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // nudFromDay
            // 
            this.nudFromDay.Location = new System.Drawing.Point(161, 59);
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
            this.nudFromDay.Size = new System.Drawing.Size(48, 20);
            this.nudFromDay.TabIndex = 17;
            this.nudFromDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToDay
            // 
            this.nudToDay.Location = new System.Drawing.Point(161, 89);
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
            this.nudToDay.Size = new System.Drawing.Size(48, 20);
            this.nudToDay.TabIndex = 18;
            this.nudToDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFromYear
            // 
            this.nudFromYear.Location = new System.Drawing.Point(216, 59);
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
            this.nudFromYear.Size = new System.Drawing.Size(67, 20);
            this.nudFromYear.TabIndex = 19;
            this.nudFromYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nudToYear
            // 
            this.nudToYear.Location = new System.Drawing.Point(216, 91);
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
            this.nudToYear.Size = new System.Drawing.Size(67, 20);
            this.nudToYear.TabIndex = 20;
            this.nudToYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dLComponentsToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(463, 24);
            this.mnuStrip.TabIndex = 21;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // dLComponentsToolStripMenuItem
            // 
            this.dLComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dow30ToolStripMenuItem,
            this.sP100ToolStripMenuItem,
            this.nasdaq100ToolStripMenuItem});
            this.dLComponentsToolStripMenuItem.Name = "dLComponentsToolStripMenuItem";
            this.dLComponentsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.dLComponentsToolStripMenuItem.Text = "Index Components";
            // 
            // dow30ToolStripMenuItem
            // 
            this.dow30ToolStripMenuItem.Name = "dow30ToolStripMenuItem";
            this.dow30ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dow30ToolStripMenuItem.Text = "Dow 30";
            this.dow30ToolStripMenuItem.Click += new System.EventHandler(this.dow30ToolStripMenuItem_Click);
            // 
            // sP100ToolStripMenuItem
            // 
            this.sP100ToolStripMenuItem.Name = "sP100ToolStripMenuItem";
            this.sP100ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sP100ToolStripMenuItem.Text = "S&&P 100";
            this.sP100ToolStripMenuItem.Click += new System.EventHandler(this.sP100ToolStripMenuItem_Click);
            // 
            // nasdaq100ToolStripMenuItem
            // 
            this.nasdaq100ToolStripMenuItem.Name = "nasdaq100ToolStripMenuItem";
            this.nasdaq100ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nasdaq100ToolStripMenuItem.Text = "Nasdaq 100";
            this.nasdaq100ToolStripMenuItem.Click += new System.EventHandler(this.nasdaq100ToolStripMenuItem_Click);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(17, 219);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(69, 17);
            this.chkMusic.TabIndex = 22;
            this.chkMusic.Text = "Music on";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // frmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 249);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.nudToYear);
            this.Controls.Add(this.nudFromYear);
            this.Controls.Add(this.nudToDay);
            this.Controls.Add(this.nudFromDay);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Controls.Add(this.cboToMonth);
            this.Controls.Add(this.cboFromMonth);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnDL);
            this.Controls.Add(this.lblTickers);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "frmDownload";
            this.Text = "Yahoo Historical Quote Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.nudFromDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToYear)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label lblTickers;
        private System.Windows.Forms.Button btnDL;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboFromMonth;
        private System.Windows.Forms.ComboBox cboToMonth;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.NumericUpDown nudFromDay;
        private System.Windows.Forms.NumericUpDown nudToDay;
        private System.Windows.Forms.NumericUpDown nudFromYear;
        private System.Windows.Forms.NumericUpDown nudToYear;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem dLComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dow30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sP100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasdaq100ToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkMusic;
    }
}

