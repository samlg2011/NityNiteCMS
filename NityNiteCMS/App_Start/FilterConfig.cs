using System.Web;
using System.Web.Mvc;
using NityNiteCMS.Filters;

namespace NityNiteCMS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionFilter());
        }
    }
}
