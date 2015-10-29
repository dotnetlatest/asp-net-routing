using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingDemo.Site.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        [Route("{id:int}/grades",Name = "Student grades Home")]
        public IEnumerable<string> Get()
        {
            return new[] { "Grade 1 : 40%", "Grade 2 : 60%" };
        }
    }
}
