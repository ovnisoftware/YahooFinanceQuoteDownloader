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

        private bool DatesVerified()
        {
            try
            {
                DateTime startDate = new DateTime((int)nudFromYear.Value, cboFromMonth.SelectedIndex + 1, (int)nudFromDay.Value);
                DateTime endDate = new DateTime((int)nudToYear.Value, cboToMonth.SelectedIndex + 1, (int)nudToDay.Value);
                if(endDate<startDate)
                {
                    MessageBox.Show("End date cannot be earlier than start date.");
                    return false;
                }
                else if(endDate>DateTime.Now)
                {
                    MessageBox.Show("End date cannot be beyond today.");
                    return false;
                }
                return true;
             }
            catch
            {
                MessageBox.Show("Please enter a valid date.");
                return false;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(txtSavePath.Text))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }

            if(txtTicker.Text=="")
            {
                MessageBox.Show("Please enter a ticker symbol");
                return;
            }
        }
    }
}
