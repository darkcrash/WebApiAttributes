﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Filters;

namespace WebApiAttributes.Attributes
{
    /// <summary>
    /// no-storeヘッダーを付与
    /// </summary>
    public class NoStoreAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// アクションメソッドの実行後処理
        /// no-storeヘッダーを付与
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            System.Diagnostics.Trace.WriteLine("NoStoreAttribute.OnActionExecuted");
            base.OnActionExecuted(actionExecutedContext);
            // レスポンスがない場合は処理しない
            if (actionExecutedContext.Response == null)
                return;
            // キャッシュコントロールを必要に応じて設定
            if (actionExecutedContext.Response.Headers.CacheControl == null)
                actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue();
            // no-storeヘッダーを付与
            actionExecutedContext.Response.Headers.CacheControl.NoStore = true;

        }
    }
}