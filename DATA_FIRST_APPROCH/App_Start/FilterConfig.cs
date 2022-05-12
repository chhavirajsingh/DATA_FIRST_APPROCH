using System.Web;
using System.Web.Mvc;

namespace DATA_FIRST_APPROCH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
