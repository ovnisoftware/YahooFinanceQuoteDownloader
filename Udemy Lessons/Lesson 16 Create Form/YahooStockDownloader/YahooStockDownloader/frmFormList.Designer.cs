namespace YahooStockDownloader
{
    partial class frmFormList
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
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Location = new System.Drawing.Point(13, 13);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(62, 13);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "Search For:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(82, 13);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(423, 20);
            this.txtSearchBox.TabIndex = 1;
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.Location = new System.Drawing.Point(16, 46);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(489, 433);
            this.lstFileList.TabIndex = 2;
            // 
            // frmFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 492);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearchFor);
            this.Name = "frmFormList";
            this.Text = "CSV Files Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ListBox lstFileList;
    }
}