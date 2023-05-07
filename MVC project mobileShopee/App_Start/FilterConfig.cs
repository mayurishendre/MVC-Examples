using System.Web;
using System.Web.Mvc;

namespace MVC_project_mobileShopee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
