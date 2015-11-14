using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YahooDownloader
{
    public partial class frmDownload : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Contra);
        bool musicOn = false;
        string folder = "";
        string interval = "";

        public frmDownload()
        {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            txtPath.Text = folder;
            folderBrowserDialog.SelectedPath = folder;
            cboFromMonth.SelectedIndex = 0;
            cboToMonth.SelectedIndex = 0;
            interval = "d";
            SetCurrentDate();
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            //Verify folderPath
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Please enter a valid folder");
                return;
            }

            //Verify tickers are entered
            if (txtTicker.Text == "")
            {
                MessageBox.Show("Please enter a ticker symbol");
                return;
            }

            //Verify dates are valid
            if (DatesVerified())
            {
                string tickers = txtTicker.Text;

                //Verify symbols are only letters and commas
                bool result = tickers.All((c => Char.IsLetter(c) || c == ',' || c == ' '));
                if (!result)
                {
                    MessageBox.Show("Please enter only letters and commas, ex:" + Environment.NewLine + "GOOG, AMZN, MSFT");
                    return;
                }
                //Selects daily, weekly or monthly quotes
                SetInterval();

                //Removes white space, converts to uppercase & splits symbols
                string[] symbols = Helpers.SplitTickers(tickers);

                foreach (string symbol in symbols)
                {
                    //Constructs Yahoo's URL to request data from
                    string path = Path.Combine(folder, symbol + ".csv");
                    string url = "http://real-chart.finance.yahoo.com/table.csv?s=" + symbol + "&a=" + cboFromMonth.SelectedIndex + "&b=" +
                        nudFromDay.Value + "&c=" + nudFromYear.Value + "&d=" + cboToMonth.SelectedIndex + "&e=" + nudToDay.Value + "&f" + nudToYear.Value + "&g=" + interval + "&ignore=.csv";
                    try
                    {
                        Helpers.DownloadSymbolsToCSV(url, path, folder, symbol);
                    }
                    catch
                    {
                        MessageBox.Show("Could not locate " + symbol);
                    }
                }
                frmFileList fileList = new frmFileList(folder);
                fileList.Show();
                //Process.Start("explorer.exe", folder);
                //MessageBox.Show("All tickers processed to: " + folder);
            }
        }

        private void SetInterval()
        {
            if (rbDaily.Checked)
                interval = "d";
            if (rbWeekly.Checked)
                interval = "w";
            if (rbMonthly.Checked)
                interval = "m";
        }

        private bool DatesVerified()
        {
            try
            {
                //year, month, day
                DateTime startDate = new DateTime((int)nudFromYear.Value, (int)cboFromMonth.SelectedIndex + 1, (int)nudFromDay.Value);
                DateTime endDate = new DateTime((int)nudToYear.Value, (int)cboToMonth.SelectedIndex + 1, (int)nudToDay.Value);

                if (endDate < startDate)
                {
                    MessageBox.Show("End date can not be earlier than the start date");
                    return false;
                }
                else if (endDate > DateTime.Now)
                {
                    MessageBox.Show("End date can not be beyond today's date");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid date");
                return false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
                folder = folderBrowserDialog.SelectedPath;
            }
        }

        private void SetCurrentDate()
        {
            DateTime curDay = DateTime.Today;
            cboToMonth.SelectedIndex = curDay.Month - 1;
            nudToDay.Value = curDay.Day;
            nudToYear.Value = curDay.Year;
            nudFromYear.Value = curDay.Year;
        }

        private void dow30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTicker.Text += GetIndices.GetDow30();
        }

        private void sP100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTicker.Text += GetIndices.GetSAndP100();
        }

        private void nasdaq100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTicker.Text += GetIndices.GetNasdaq100();
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (musicOn)
            {
                musicOn = false;
                sp.Stop();
            }
            else
            {
                musicOn = true;
                sp.PlayLooping();
            }
        }
    }
}