using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace YahooDownloader
{
    public partial class frmFileList : Form
    {
        string folderPath = "";
        public frmFileList(string folder)
        {
            InitializeComponent();
            folderPath = folder;
        }

        private void frmFileList_Load(object sender, EventArgs e)
        {
            string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");
            lstFiles.Items.AddRange(csvFiles);
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                Process.Start(@"notepad.exe", lstFiles.SelectedItem.ToString());
            }
        }
    }
}
