using System.Web;
using System.Web.Mvc;

namespace HBSIS_Test_Clients
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
