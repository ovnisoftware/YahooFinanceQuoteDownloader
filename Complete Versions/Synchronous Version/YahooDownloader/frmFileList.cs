using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            //clear box
            lstFiles.Items.Clear();

            //get paths and file names as list
            List<string> allFiles = Directory.GetFiles(folderPath, "*.csv").ToList();

            //search through file names, excluding paths and extensions
            var onlyFileNames = allFiles.Where(x => Path.GetFileNameWithoutExtension(x).Contains(txtSearchBox.Text.ToUpper()));

            //show reduced file set in list box
            lstFiles.Items.AddRange(onlyFileNames.ToArray());
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
