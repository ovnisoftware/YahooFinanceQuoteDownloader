using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YahooStockDownloader
{
    public partial class frmFormList : Form
    {
        string folderPath = "";
        public frmFormList(string folder)
        {
            InitializeComponent();
            folderPath = folder;
        }

        private void frmFormList_Load(object sender, EventArgs e)
        {
            string[] csvFiles = Directory.GetFiles(folderPath, "*.csv");
            lstFileList.Items.AddRange(csvFiles); 
        }

        private void lstFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstFileList.SelectedItem!=null)
            {
                Process.Start("notepad.exe", lstFileList.SelectedItem.ToString());
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            lstFileList.Items.Clear();//clear list box
            List<string> allPathFiles = Directory.GetFiles(folderPath, "*.csv").ToList();
            //find only some file names
            var onlySomeFiles = allPathFiles.Where(x => Path.GetFileNameWithoutExtension(x).Contains(txtSearchBox.Text.ToUpper()));
            lstFileList.Items.AddRange(onlySomeFiles.ToArray());
        }
    }
}






