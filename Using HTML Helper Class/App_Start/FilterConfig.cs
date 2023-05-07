using System.Web;
using System.Web.Mvc;

namespace Using_HTML_Helper_Class
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
