using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahooStockDownloader
{
    public partial class frmYahooDownloader : Form
    {
        string folder = "";
        string interval = "";
        public frmYahooDownloader()
        {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            txtSavePath.Text = folder;
            folderBrowserDialog1.SelectedPath = folder;
            cboFromMonth.SelectedIndex = 0;
            cboToMonth.SelectedIndex = 0;
            interval = "d";
            SetCurrentDate();
        }
        private void SetCurrentDate()
        {
            DateTime currentDate = DateTime.Today;
            cboToMonth.SelectedIndex = currentDate.Month-1;
            nudToDay.Value = currentDate.Day;
            nudToYear.Value = currentDate.Year;
            nudFromYear.Value = currentDate.Year;
        }

        private void btnChooseSavePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                txtSavePath.Text = folderBrowserDialog1.SelectedPath;
                folder = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
