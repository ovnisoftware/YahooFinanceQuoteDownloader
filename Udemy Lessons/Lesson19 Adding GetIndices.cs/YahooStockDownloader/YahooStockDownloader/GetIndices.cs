using System.IO;
using System.Net;

namespace YahooStockDownloader
{
    public static class GetIndices
    {
         public static string GetDow30()
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

              return webPageInfo;
         }
    }
}

