using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OS.RSS.Models
{
    public class FeedItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
    }
}