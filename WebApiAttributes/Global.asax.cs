using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiAttributes
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_Start");
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_AcquireRequestState");
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Session_Start");
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_BeginRequest");
        }
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_AuthenticateRequest");
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_Error");
        }
        protected void Session_End(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Session_End");
        }
        protected void Application_End(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Application_End");
        }
    }
}