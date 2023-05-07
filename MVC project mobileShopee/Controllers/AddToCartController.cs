using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MobileDAL;//class library add
using MVC_project_mobileShopee.Models;//add model prduct detail refereence


namespace MVC_project_mobileShopee.Controllers
{
    public class AddToCartController : Controller
    {
        // GET: AddToCart

        DataTable dt;
        MobiledetailDAL mdal = new MobiledetailDAL();

        public ActionResult Add(Mobiles mo)
        {
            if(Session["cart"]==null)
            {
                List<Mobiles> li = new List<Mobiles>();
                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();

                Session["Count"] = 1;
            }
            else
            {
                List<Mobiles> li = (List<Mobiles>)Session["cart"];
                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult MyOrder()
        {
           
                return View((List<Mobiles>)Session["cart"]);
        }

        public ActionResult Remove(Mobiles mob)
        {
                List<Mobiles> li = (List<Mobiles>)Session["cart"];
                li.RemoveAll(x => x.slNo == mob.slNo);
                Session["cart"] = li;
                Session["count"] = Convert.ToInt32(Session["count"]) - 1;
                return RedirectToAction("Myorder", "AddToCart");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}