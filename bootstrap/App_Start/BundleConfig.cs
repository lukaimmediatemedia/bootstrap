using System.Web;
using System.Web.Optimization;

namespace bootstrap
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            
            //SASS CSS
            var bsSassCss = new StyleBundle("~/bundles/sass");
            bsSassCss.Include("~/Content/css/sass/bootstrap.css");
            bundles.Add(bsSassCss);

            //LESS CSS
            var bsLessCss = new StyleBundle("~/bundles/less");
            bsLessCss.Include("~/Content/css/less/bootstrap.css");
            bundles.Add(bsLessCss);

        }
    }
}