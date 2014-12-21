using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAttributes.Attributes;

namespace WebApiAttributes.Controllers
{
    public class SimpleApiController : ApiController
    {
        // GET: api/SimpleApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/SimpleApi/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
