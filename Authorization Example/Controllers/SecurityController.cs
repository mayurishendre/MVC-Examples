using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Authorization_Example.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        [Authorize]  //only for About
        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult CheckUser()
        {
            if(Request.Form["textUsername"] =="Mayuri" && Request.Form["txtPassword"] =="12345")
            {
                //use Form Autthentication class to set the cookies and redirect to about view page
                FormsAuthentication.SetAuthCookie(Request.Form["textUsername"], true);
                return View("About");

            }
            else
            {
                return View("Login");
            }
        }
    }
}