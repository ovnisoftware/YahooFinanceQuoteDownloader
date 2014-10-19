YahooFinanceQuoteDownloader
===========================

Winforms app in C# to download historical stock quote information (in .CSV format) from Yahoo Finance

This program is helpful for downloading .CSV files for stocks from Finance.Yahoo.com.

Here's what the information looks like:
http://www.ovnisoftware.com/Images/CSV.png

Here's what the program looks like:
http://ovnisoftware.com/Images/Yahoo_Downloader.png

Yahoo will only let you download the stock information for one stock at a time on their site, but you can download multiple stocks at the same time with this program.  You can get the data in daily, weekly, or monthly format and then analyze it at your convenience.

This was built with Visual Studio 2013, I included all the files in the solution folder.  It is built for .NET 4 so it will work on Windows XP, Vista, Windows 7 and Windows 8 as long as .NET 4 is installed.

If you just want to see the logic without the all the windows form stuff, the C# code is in the YahooDownloader\Form1.cs file.