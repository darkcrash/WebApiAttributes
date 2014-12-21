using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using WebApiAttributes.Attributes;

namespace WebApiAttributes.Controllers
{
    [AuthorizeExtend]
    [NoCache]
    [NoStore]
    public class SessionStateApiController : ApiController
    {
        // GET: api/SessionStateApi
        public IEnumerable<string> Get()
        {
            IHttpSessionState session = SessionStateUtility.GetHttpSessionStateFromContext(HttpContext.Current);
            foreach (string key in session.Keys)
            {
                yield return key + ":" + session[key].ToString();
            }
        }

        // GET: api/SessionStateApi/5
        public string Get(string id)
        {
            IHttpSessionState session = SessionStateUtility.GetHttpSessionStateFromContext(HttpContext.Current);
            return session[id].ToString();
        }
    }
}
