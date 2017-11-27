using System.Web;
using System.Web.Mvc;
using Bullboard.Filters;

namespace Bullboard
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
            filters.Add(new CultureAttribute());
        }
    }
}
