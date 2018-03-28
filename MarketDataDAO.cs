using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Test
{ 
    public class MarketDataDAO
    {

        public List<MarketData> AllMarketData()
        {
            Console.WriteLine("hello1");
            Thread.Sleep(1000);
            List<MarketData> values = File.ReadAllLines("C:\\Users\\Administrator\\Desktop\\marketData\\NASDAQ_20160314.csv")
                                             .Skip(1)
                                             .Select(v => MarketData.FromCsv(v))
                                             .ToList();

            Console.WriteLine("Hello5");
            Thread.Sleep(1000);
            return values;
        }
    }


}