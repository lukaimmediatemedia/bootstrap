using System.Web;
using System.Web.Optimization;

namespace bootstrap
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //jQuery
            var jquery = new ScriptBundle("~/bundles/jquery");
            jquery.Include("~/Scripts/js/jquery/jquery-{version}.js");
            bundles.Add(jquery);

            //Modernizr
            var modernizr = new ScriptBundle("~/bundles/modernizr");
            modernizr.Include("~/Scripts/js/modernizr/modernizr-{version}.js");
            bundles.Add(modernizr);

            //SASS CSS
            var bsSassCss = new StyleBundle("~/bundles/sass");
            bsSassCss.Include("~/Content/css/sass/bootstrap.css");
            bundles.Add(bsSassCss);

            //SASS JS
            var bsSassJs = new ScriptBundle("~/bundles/sass-js");
            bsSassJs.Include(
                "~/Scripts/js/sass/bootstrap/affix.js",
                "~/Scripts/js/sass/bootstrap/alert.js",
                "~/Scripts/js/sass/bootstrap/button.js",
                "~/Scripts/js/sass/bootstrap/carousel.js",
                "~/Scripts/js/sass/bootstrap/collapse.js",
                "~/Scripts/js/sass/bootstrap/dropdown.js",
                "~/Scripts/js/sass/bootstrap/tab.js",
                "~/Scripts/js/sass/bootstrap/transition.js",
                "~/Scripts/js/sass/bootstrap/scrollspy.js",
                "~/Scripts/js/sass/bootstrap/modal.js",
                "~/Scripts/js/sass/bootstrap/tooltip.js",
                "~/Scripts/js/sass/bootstrap/popover.js"
                );
            bundles.Add(bsSassJs);

            //LESS CSS
            var bsLessCss = new StyleBundle("~/bundles/less");
            bsLessCss.Include("~/Content/css/less/bootstrap.css");
            bundles.Add(bsLessCss);

        }
    }
}