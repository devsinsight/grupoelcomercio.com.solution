using System.Web.Mvc;

namespace grupoelcomercio.com.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilter(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}