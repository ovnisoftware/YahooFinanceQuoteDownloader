using System.IO;
using System.Net;

namespace YahooStockDownloader
{
    public static class Helpers
    {
        public static string[] SplitTickers(string tickers)
        {
            tickers = tickers.Replace(" ", string.Empty);
            tickers = tickers.ToUpper();
            return tickers.Split(',');
        }
    }
}
