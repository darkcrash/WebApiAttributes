using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using WebApiAttributes.Attributes;

namespace WebApiAttributes
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // フィルター属性追加
            config.Filters.Add(new AuthorizeExtendAttribute());
            config.Filters.Add(new NoCacheAttribute());
            config.Filters.Add(new NoStoreAttribute());
        }
    }
}
