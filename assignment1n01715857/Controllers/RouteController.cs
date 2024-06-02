using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1n01715857.Controllers
{
    public class RouteController : ApiController
    {
        // GET: api/Route/Method1 -> "method1"
        [HttpGet]
        [Route("api/Route/Method1")]
        
        public string Method1()
        {
            return "method1";
        }
    }
}
