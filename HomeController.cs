using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MarketDataDAO dao = new MarketDataDAO();
            List<MarketData> mdList = dao.AllMarketData();

            MarketDataAnalyzer marketDataAna = new MarketDataAnalyzer();
            List<string> bestPerformers = marketDataAna.getBestPerformers(mdList);
            //List<string> bestPerformers = new List<string>();
            //bestPerformers.Add("ASD");
            //bestPerformers.Add("QWE");
            //bestPerformers.Add("ZXC");

            string output = "Best Performers: " + System.Environment.NewLine;

            for (var i = 0; i < bestPerformers.Count(); i++) {
                output +=  bestPerformers[i];
            }

            ViewBag.Message = output;

            return View();

        }
        
    }
}