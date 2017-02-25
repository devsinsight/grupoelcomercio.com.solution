
using System.Web.Optimization;

namespace grupoelcomercio.com.web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/bundles/style")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap.theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/script")
                .Include("~/Scripts/jquery-1.9.1.js")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js"));
        }
    }
}