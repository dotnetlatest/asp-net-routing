using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Site.Controllers
{
    //Controller
    [RoutePrefix("blog")]
    public class BlogController : Controller
    {
        [Route("~/")]
        [Route("blog")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("{blogtitle}")]
        public ActionResult Post(string blogtitle)
        {
            ViewBag.Title = blogtitle;
            return View();
        }

        [Route("{id:int}")]
        public ActionResult Post(int id)
        {
            ViewBag.Title = id;
            return View();
        }
        
    }
}
