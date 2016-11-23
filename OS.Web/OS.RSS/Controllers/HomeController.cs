using OS.RSS.Models;
using OS.RSS.Services;
using System.Web.Mvc;

namespace OS.RSS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new FeedModel();
            model.Items = RSSFeeds.GetFeeds();
            return View(model);
        }
    }
}
