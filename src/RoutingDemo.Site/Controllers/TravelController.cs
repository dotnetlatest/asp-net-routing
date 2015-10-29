using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Site.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        public ActionResult Story(string item)
        {
            ViewBag.Story = item;
            return View();
        }

        public ActionResult Destinations(string destination)
        {
            ViewBag.Destination = destination;
            return View();
        }
    }
}