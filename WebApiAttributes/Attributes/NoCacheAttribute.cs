using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Filters;

namespace WebApiAttributes.Attributes
{
    /// <summary>
    /// no-cacheヘッダーを付与
    /// </summary>
    public class NoCacheAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// アクションメソッドの実行後処理
        /// no-cacheヘッダーを付与
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            System.Diagnostics.Trace.WriteLine("NoCacheAttribute.OnActionExecuted");
            base.OnActionExecuted(actionExecutedContext);
            // レスポンスがない場合は処理しない
            if (actionExecutedContext.Response == null)
                return;
            // キャッシュコントロールを必要に応じて設定
            if (actionExecutedContext.Response.Headers.CacheControl == null)
                actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue();
            // no-cacheヘッダーを付与
            actionExecutedContext.Response.Headers.CacheControl.NoCache = true;
        }

    }
}