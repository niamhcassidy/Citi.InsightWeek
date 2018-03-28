using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerySimpleContactsCRUDApp
{
    public class MarketData
    { 
        public MarketData(String ticker, String Date, double open, double high, double low, double close, int volume){
        ticker=ticker;
        Date=Date;
        open=open;
        high=high;
        low=low;
        close=close;
        volume=volume;
    }
public String ticker { get; set; }
public string Name { get; set; }
public string Email { get; set; }
public string Phone { get; set; }

}