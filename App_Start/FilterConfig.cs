using System.Web;
using System.Web.Mvc;

namespace u23717662_INF272Prac3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
