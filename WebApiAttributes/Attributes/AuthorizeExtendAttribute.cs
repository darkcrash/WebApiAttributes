using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace WebApiAttributes.Attributes
{
    /// <summary>
    /// 拡張された承認フィルター
    /// </summary>
    public class AuthorizeExtendAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            System.Diagnostics.Trace.WriteLine("OnAuthorization");
            base.OnAuthorization(actionContext);
        }
        public override System.Threading.Tasks.Task OnAuthorizationAsync(System.Web.Http.Controllers.HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {
            System.Diagnostics.Trace.WriteLine("OnAuthorizationAsync");
            return base.OnAuthorizationAsync(actionContext, cancellationToken);
        }
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            System.Diagnostics.Trace.WriteLine("IsAuthorized");
            return base.IsAuthorized(actionContext);
        }
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            System.Diagnostics.Trace.WriteLine("HandleUnauthorizedRequest");
            base.HandleUnauthorizedRequest(actionContext);
        }
    }
}