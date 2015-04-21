using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;

namespace YahooDownloader
{
    public partial class Form1 : Form
    {
        string folder = "";
        string interval = "";
        public Form1()
        {
            InitializeComponent();
            folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            txtPath.Text = folder;
            folderBrowserDialog1.SelectedPath = folder;
            fromMonth.SelectedIndex = 0;
            toMonth.SelectedIndex = 0;
            interval = "d";
            setCurrentDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Verify folderPath
            if (Directory.Exists(txtPath.Text))
            {
                if (datesVerified())
                {
                    string tickers = textBoxTicker.Text;
                    //verifies symbols are only letters and commas
                    bool result = tickers.All((c => Char.IsLetter(c) || c == ',' || c == ' '));
                    if (result)
                    {
                        setInterval();
                        //removes white space, converts to uppercase & splits symbols
                        tickers = tickers.Replace(" ", string.Empty);
                        tickers = tickers.ToUpper();
                        string[] symbols = tickers.Split(',');
                        foreach (string symbol in symbols)
                        {
                            string path = Path.Combine(folder, symbol + ".csv");
                            string url = "http://real-chart.finance.yahoo.com/table.csv?s=" + symbol + "&a=" + fromMonth.SelectedIndex + "&b=" +
                                fromDay.Value + "&c=" + fromYear.Value + "&d=" + toMonth.SelectedIndex + "&e=" + toDay.Value + "&f" + toYear.Value + "&g=" + interval + "&ignore=.csv";
                            try
                            {
                                using (WebClient Client = new WebClient())
                                {
                                    Client.DownloadFile(url, path);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Could not locate " + symbol);
                            }

                        }
                    }
                    else
                        MessageBox.Show("Please enter only letters and commas, ex:" + Environment.NewLine + "GOOG, AMZN, MSFT");
                }
            }
            else
                MessageBox.Show("Please enter a valid folder");
        }

        private void setInterval()
        {
            if (rbDaily.Checked)
                interval = "d";
            if (rbWeekly.Checked)
                interval = "w";
            if (rbMonthly.Checked)
                interval = "m";
        }

        private bool datesVerified() 
        {
            //year, month, day
            DateTime startDate = new DateTime((int)fromYear.Value, (int)fromMonth.SelectedIndex + 1, (int)fromDay.Value);
            DateTime endDate = new DateTime((int)toYear.Value, (int)toMonth.SelectedIndex + 1, (int)toDay.Value);

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
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                folder = folderBrowserDialog1.SelectedPath;
            }
        }

        private void setCurrentDate()
        {
            DateTime asdf = DateTime.Today;
            toMonth.SelectedIndex = asdf.Month - 1;
            toDay.Value = asdf.Day;
            toYear.Value = asdf.Year;
            fromYear.Value = asdf.Year;
        }

        private void dow30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Access barchart.com to get Dow 30 components
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.barchart.com/stocks/industrials.php?view=main");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to webPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf(",,");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");

            textBoxTicker.Text += webPageInfo;
        }

        private void sP100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Access barchart.com to get S&P 100 components
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.barchart.com/stocks/sp100.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to webPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf("\"");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");

            textBoxTicker.Text += webPageInfo;
        }

        private void nasdaq100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Access barchart.com to get NASDAQ 100 components
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.barchart.com/stocks/nasdaq100.php");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Read source of request to webPageInfo string
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string webPageInfo = stream.ReadToEnd();

            //Trim returned text to get tickers
            int index = webPageInfo.IndexOf("\"symbols\"");
            webPageInfo = webPageInfo.Substring(index + 9);

            index = webPageInfo.IndexOf("=\"");
            webPageInfo = webPageInfo.Substring(index + 2);

            index = webPageInfo.IndexOf("\"");
            webPageInfo = webPageInfo.Substring(0, index);

            webPageInfo = webPageInfo.Replace(",", ", ");

            textBoxTicker.Text += webPageInfo;
        }
    }
}
