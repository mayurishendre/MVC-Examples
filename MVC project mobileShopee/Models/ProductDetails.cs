using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_project_mobileShopee.Models
{
    public class ProductDetails
    {
        public int? SLNo { get; set; }     //? is required Field
        public string MobileName { get; set; }
        public double price { get; set; }
        public string Url { get; set; }
        public string Features { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
        public string SimType { get; set; }
    }
}