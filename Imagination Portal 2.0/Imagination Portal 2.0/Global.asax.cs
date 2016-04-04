using Imagination_Portal_2._0.Controllers;
using Imagination_Portal_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace Imagination_Portal_2._0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
    public class CheckGuest : ActionFilterAttribute
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            var guestCookie = filterContext.HttpContext.Request.Cookies["guidCookie"];
            // TODO: do something with the foo cookie
            if (guestCookie == null || guestCookie.Values["GUID"] == null)
            {
                HttpCookie cookie = new HttpCookie("guidCookie");
                cookie.Values["GUID"] = Guid.NewGuid().ToString();

                filterContext.HttpContext.Response.Cookies.Add(cookie);

            }
            else if (guestCookie.Values["GUID"] != null && !filterContext.HttpContext.Request.IsAuthenticated)
            {
                var users = db.Users.ToList().Where(x => x.GUID == Guid.Parse(guestCookie.Values["GUID"]));
                if (users.Count() > 0)
                {
                    var user = users.First();
                    var userManager = filterContext.HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                    var signInManager = filterContext.HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
                    var User = userManager.FindByName(user.UserName);
                    signInManager.SignIn(User, true, true);
                }

            }
        }
    }
}
