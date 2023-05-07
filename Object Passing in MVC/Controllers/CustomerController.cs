using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Object_Passing_in_MVC.Models;

namespace Object_Passing_in_MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            return View();
        }

        List<Customer> Customers = new List<Customer>();
        public CustomerController()
        {
            Customer obj = new Customer();
            obj.ID = 12;
            obj.Code = "C-1001";
            obj.Amount = 5000;

            Customers.Add(obj);

            obj = new Customer();
            obj.ID = 10;
            obj.Code = "C101";
            obj.Amount = 10000;

            Customers.Add(obj);

        }
       
    }
}