using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileDAL;//1 include this
using System.Data;
using MVC_project_mobileShopee.Models;

namespace MVC_project_mobileShopee.Controllers
{
    public class HomeController : Controller
    {
        
            //step 2
            MobiledetailDAL mdal = new MobiledetailDAL();
            DataTable dt;
        


        public ActionResult Index()
        {
            //step3
            string mycmd = "select * from tblMobiles";
            dt = new DataTable();
            dt = mdal.SelectAll(mycmd);

            List<Mobiles> list = new List<Mobiles>();

            for(int i=0;i<dt.Rows.Count;i++)
            {
                Mobiles mob = new Mobiles();
                mob.slNo = Convert.ToInt32(dt.Rows[i]["slNo"]);
                mob.MobileName = dt.Rows[i]["MobileName"].ToString();
                mob.Price =  Convert.ToInt32( dt.Rows[i]["Price"]);
                mob.Url = dt.Rows[i]["Url"].ToString();
                mob.ZoomUrl = dt.Rows[i]["ZoomUrl"].ToString();

                list.Add(mob);

            }
            return View(list);
        }

        public ActionResult EachProductDetails(Mobiles m)
        {
            string mycmd = "select m.slNo,m.MobileName,m.Price,m.Url,md.Features,md.Model,md.Color,md.SimType " +
                "from tblMobiles m inner join MobileDetails md on m.slNo=md.MobileId where m.slNo=" + m.slNo + "";
                
                dt = new DataTable();

            dt = mdal.SelectAll(mycmd);
            List<ProductDetails> list = new List<ProductDetails>();

            for(int i=0;i<dt.Rows.Count;i++)
            {
                ProductDetails mob = new ProductDetails();
                mob.SLNo = Convert.ToInt32(dt.Rows[i]["slNo"]);
                mob.MobileName = dt.Rows[i]["MobileName"].ToString();
                mob.price =Convert.ToInt32( dt.Rows[i]["Price"].ToString());
                mob.Url = dt.Rows[i]["Url"].ToString();
                mob.Features = dt.Rows[i]["Features"].ToString();
                mob.color = dt.Rows[i]["color"].ToString();
                mob.SimType = dt.Rows[i]["SimType"].ToString();


                list.Add(mob);
            }
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}