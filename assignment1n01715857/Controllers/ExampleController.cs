using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1n01715857.Controllers
{
    public class ExampleController : ApiController
    {

        //We have the ability to listen to http request
        // and provide response to those requests

        // GET : localhost:xx/api/Example -> "A differnt welcome!"
        public string Get ()
        {
            string response = " A GET request";

            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Post()
        {
            string response = " A POST request";
            
            return response;
            
        }
    }
}
