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
            cboFromMonth.SelectedIndex = 0;
            cboToMonth.SelectedIndex = 0;
            interval = "d";
        }
    }
}
