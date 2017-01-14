using System.Web;
using System.Web.Mvc;

namespace HelloWorld_DHEA_ARMALIVIA_09_XIRPL6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
