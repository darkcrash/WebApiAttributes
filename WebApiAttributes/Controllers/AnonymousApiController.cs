using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAttributes.Attributes;

namespace WebApiAttributes.Controllers
{
    [AuthorizeExtend]
    [NoCache]
    [NoStore]
    public class AnonymousApiController : ApiController
    {
        // GET: api/AnonymousApi
        [AllowAnonymous]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/AnonymousApi/5
        [AllowAnonymous]
        public string Get(int id)
        {
            return "value";
        }
    }
}
