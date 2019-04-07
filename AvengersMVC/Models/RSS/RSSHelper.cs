using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
namespace AvengersMVC.Models.RSS
{
    public class RSSHelper
    {
       //   string html = @"https://www.ranker.com/list/avengers-trivia-facts/ranker-comics";
       

        public static List<RssItem> ReadList(string url)
        {
          
            List<RssItem> list = new List<RssItem>();
    
         
             RssItem r = new RssItem();
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            //var h = htmlDoc.DocumentNode.SelectSingleNode("//div/h2");
            //var p = htmlDoc.DocumentNode.SelectSingleNode("//div/p");
            //var img = htmlDoc.DocumentNode.SelectSingleNode("//div/figure/img");

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//div/h2");

            foreach (var node in htmlNodes)
            {

                r.Title = node.InnerText;
            }

            var p = htmlDoc.DocumentNode.SelectNodes("//div/p");

            foreach (var node in htmlNodes)
            {

                r.Description  = node.InnerText;list.Add(r);
            }



            // = h.InnerText;
          

            
            return list;
        }
      
    }
  


}

