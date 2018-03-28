using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerySimpleContactsCRUDApp
{
    public class MarketData
    {
        public MarketData(string ticker, string date, double open, double high, double low, double close, int volume)
        {
            Ticker = ticker;
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }
        public string Ticker { get; set; }
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int Volume { get; set; }

    }
}