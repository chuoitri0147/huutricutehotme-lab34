using System.Web;
using System.Web.Mvc;

namespace nguyenhuutri_lab34
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
