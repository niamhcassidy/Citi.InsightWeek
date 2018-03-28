using System;
class MarketData
{
    public MarketData(string ticker, string date, double open, double high, double low, double close, int volume
        )
    {
        Ticker = ticker;
        Date = date;
        Open = open;
        High = high;
        Low = low;
        Close = close;
        Volume = volume;
    }
    public string Ticker;
    public string Date;
    public double Open;
    public double High;
    public double Low;
    public double Close;
    public int Volume;

    public static MarketData FromCsv(string csvLine)

    {
        string[] values = csvLine.Split(',');
        MarketData MarketData = new MarketData(Convert.ToString(values[0]), Convert.ToString(values[1]), Convert.ToDouble(values[2]), Convert.ToDouble(values[3]),
        Convert.ToDouble(values[4]), Convert.ToDouble(values[5]), Convert.ToInt32(values[6]));
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
