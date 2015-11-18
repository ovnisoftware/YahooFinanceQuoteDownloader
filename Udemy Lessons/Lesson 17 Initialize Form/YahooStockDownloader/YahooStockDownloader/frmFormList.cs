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
    }
}




