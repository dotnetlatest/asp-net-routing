using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Site.Controllers
{
    //Controller
    // Using Route Prefix attribute
    [RoutePrefix("blog")]
    public class BlogController : Controller
    {
        //Multiple Route attributes
        [Route("~/", Name = "Blog Home")]
        [Route("blog", Name = "BlogHome")]
        public ActionResult Index()
        {
            return View();
        }

        //Route Constraints 
        [Route("{year:int}/{month:int}/{day:int}/{blogtitle}", Name = "BlogArticle")]
        public ActionResult Article(string blogtitle)
        {
            ViewBag.Title = blogtitle;
            return View();
        }

        
    }
}
