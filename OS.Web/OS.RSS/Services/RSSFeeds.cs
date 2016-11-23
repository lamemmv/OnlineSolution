using OS.RSS.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace OS.RSS.Services
{
    public static class RSSFeeds
    {
        public static IEnumerable<FeedItem> GetFeeds()
        {
            string RSSFeedUrl = @"http://sxp.microsoft.com/stream/item?channelid=msdntn&feedid=msdnmagazine_enus&v=3";
            List<FeedItem> feeds = new List<FeedItem>();
            try
            {
                XDocument xdoc = new XDocument();
                xdoc = XDocument.Load(RSSFeedUrl);
                var items = xdoc.Descendants("item");
                foreach (var item in items)
                {
                    var feed = new FeedItem();
                    feed.Title = item.Element("title").Value;
                    feed.Description = item.Element("description").Value;
                    feed.PublishDate = item.Element("pubDate").Value;
                    feed.Link = item.Element("link").Value;
                    feed.Author = item.Element("author").Value;
                    feeds.Add(feed);                    
                }

                return feeds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}