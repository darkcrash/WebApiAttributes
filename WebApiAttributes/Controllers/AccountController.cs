using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;
using WebApiAttributes.Models;

namespace WebApiAttributes.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View("Index", model);
            }

            // フォーム認証のチケット発行
            FormsAuthentication.SetAuthCookie(model.UserName, false);

            // SessionStateに情報を格納
            this.Session["セッションその１キー"] = "セッションその１値";
            this.Session["セッションその２キー"] = "セッションその２値";

            return this.Redirect("~/");
        }

        // GET: /Account/Logout
        public ActionResult Logout()
        {
            // フォーム認証のチケット削除
            FormsAuthentication.SignOut();

            return this.Redirect("~/");
        }
    }
}