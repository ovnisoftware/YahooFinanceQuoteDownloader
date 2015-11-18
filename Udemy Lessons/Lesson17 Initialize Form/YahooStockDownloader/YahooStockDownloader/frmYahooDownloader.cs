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
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//get path to my docs
            txtSavePath.Text = folder;//save folder inside text box that shows the path
            folderBrowserDialog1.SelectedPath = folder;//set folder browser path to folder
            cboFromMonth.SelectedIndex = 0;//show january when program loads
            cboToMonth.SelectedIndex = 0;//show january when program loads
            interval = "d";
            SetCurrentDate();//set the current date when program loads
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
                //construct date time objects
                DateTime startDate = new DateTime((int)nudFromYear.Value, cboFromMonth.SelectedIndex + 1, (int)nudFromDay.Value);
                DateTime endDate = new DateTime((int)nudToYear.Value, cboToMonth.SelectedIndex + 1, (int)nudToDay.Value);
                if(endDate<startDate) //check if end date is before start date, logic error
                {
                    MessageBox.Show("End date cannot be earlier than start date.");
                    return false;
                }
                else if(endDate>DateTime.Now) //check if end date is beyond today, logic error
                {
                    MessageBox.Show("End date cannot be beyond today.");
                    return false;
                }
                return true;//return true, date choices are okay
             }
            catch
            {
                MessageBox.Show("Please enter a valid date.");
                return false;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //check folder exists
            if(!Directory.Exists(txtSavePath.Text))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }
            //check something is in the ticker box
            if(txtTicker.Text=="")
            {
                MessageBox.Show("Please enter a ticker symbol");
                return;
            }
            if(DatesVerified())
            {
                string tickers = txtTicker.Text;
                bool result = tickers.All((c => char.IsLetter(c) || c == ',' || c == ' '));//ensure only commas and letters
                if(!result)
                {
                    MessageBox.Show("Please enter only commas and letters:" + Environment.NewLine + "GOOG,AMZN,MSFT");
                    return;//return, since format of tickers is not correct
                }
                SetInterval();//set time interval for downloading
                string[] symbols = Helpers.SplitTickers(tickers);//split text from ticker box 

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
                frmFormList fileList = new frmFormList(folder);
                fileList.Show();
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
    }
}
