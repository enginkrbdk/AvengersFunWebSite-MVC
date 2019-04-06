using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.XPath;

namespace AvengersMVC.Models.RSS
{
    public class RSSHelper
    {
        public static List<RssItem> ReadList(string url) { 
        List<RssItem> list = new List<RssItem>();
            try
            {
                XPathDocument doc = new XPathDocument(url);
                XPathNavigator navigator = doc.CreateNavigator();
                XPathNodeIterator nodes = navigator.Select("//item");
                while (nodes.MoveNext())
                {
                    XPathNavigator node = nodes.Current;
                    list.Add(new RssItem
                    {
                        Title = node.SelectSingleNode("title").Value,
                        Description = node.SelectSingleNode("description").Value,
                        Category = node.SelectSingleNode("category").Value,
                        Link = node.SelectSingleNode("link").Value,
                        PubDate = node.SelectSingleNode("pubDate").Value




                    });

                }
            }
            catch (Exception ex)
            {

                list = null;
            }
            return list;
}
    }
}