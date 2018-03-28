using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test3
{
    class Class1
    {
        public List<MarketData> AllMarketData()
        {
            List<MarketData> values = File.ReadAllLines("C:\\Users\\Administrator\\Documents\\Insight Challange\\Attempt 2\\Citi.InsightWeek-master (1)\\Citi.InsightWeek-master\\data.csv\\data.csv\\NASDAQ_20160314.csv")
                                             .Skip(1)
                                             .Select(v => MarketData.FromCsv(v))
                                             .ToList();

            Console.WriteLine("Hello5");
            return values;
        }
    }

    class MarketData
    {
        public MarketData(//string ticker, string date, double open, double high, double low, double close, int volume
            )
        {/*
            Ticker = ticker;
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        */}
        public string Ticker { get; set; }
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int Volume { get; set; }

        public static MarketData FromCsv(string csvLine)

        {
            string[] values = csvLine.Split(',');
            MarketData MarketData = new MarketData();
            MarketData.Ticker = Convert.ToString(values[0]);
            MarketData.Date = Convert.ToString(values[1]);
            MarketData.Open = Convert.ToDouble(values[2]);
            MarketData.High = Convert.ToDouble(values[3]);
            MarketData.Low = Convert.ToDouble(values[4]);
            MarketData.Close = Convert.ToDouble(values[5]);
            MarketData.Volume = Convert.ToInt32(values[6]);
            return MarketData;
        }
    }
}
