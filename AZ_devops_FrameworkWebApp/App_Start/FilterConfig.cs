using System.Web;
using System.Web.Mvc;

namespace AZ_devops_FrameworkWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
