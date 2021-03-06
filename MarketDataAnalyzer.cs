﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VerySimpleContactsCRUDApp
{
    public class MarketDataAnalyzer
    {
        public List<string> getBestPerformers(List<MarketData> MarketDataList) {
            List<string> output = new List<string>();

            string topPerformer = "";
            double topDiff = 0.00;

            double diff = 0.00;

            for (var i = 0; i < MarketDataList.Count; i++) {
                double open = MarketDataList[i].Open;
                double close = MarketDataList[i].Close;

                diff = close - open;

                if (diff > topDiff) {
                    topDiff = diff;
                    topPerformer = MarketDataList[i].Ticker;
                }
            }


            output.Add(topPerformer);
            return output;
            }
         
            
           





            //output.Sort();
            //string best = output[0];
            //string worse = output[output.Count - 1];

            

            //output.Add("subjects");
            //output.Add("drinks");
            
        
        

    }
}