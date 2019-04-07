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

        string url = "https://www.inverse.com/article/44332-avengers-infinity-war-6-deleted-scenes-trailers";

        public static async void ReadList(string url)
        {
          
            List<RssItem> list = new List<RssItem>();
            //try
            //{
            //    XPathDocument doc = new XPathDocument(url);
            //    XPathNavigator navigator = doc.CreateNavigator();
            //    XPathNodeIterator nodes = navigator.Select("//item");
            //    while (nodes.MoveNext())
            //    {
            //        XPathNavigator node = nodes.Current;
            //        list.Add(new RssItem
            //        {
            //            Title = node.SelectSingleNode("title").Value,
            //            Description = node.SelectSingleNode("description").Value,
            //            Category = node.SelectSingleNode("category").Value,
            //            Link = node.SelectSingleNode("link").Value,
            //            PubDate = node.SelectSingleNode("pubDate").Value




            //        });

            //    }
            //}
            //catch (Exception ex)
            //{

            //    list = null;
            //}
            var html = @"https://www.ranker.com/list/avengers-trivia-facts/ranker-comics";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var p = htmlDoc.DocumentNode.SelectSingleNode("//div/h2");
          	var node = htmlDoc.DocumentNode.SelectSingleNode("//section/h2");
            var img = htmlDoc.DocumentNode.SelectSingleNode("//div/figure/img");
            RssItem r = new RssItem();
            r.Link = img.OuterHtml;
            r.Description = p.InnerText;
        
     
        }
    }



}
    }
}