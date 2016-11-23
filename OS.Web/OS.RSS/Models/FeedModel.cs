using System.Collections.Generic;
using System.Linq;

namespace OS.RSS.Models
{
    public class FeedModel
    {
        public IEnumerable<FeedItem> Items { get; set; }
    }
}