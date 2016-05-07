#region

using System.Web.Optimization;

#endregion

namespace WebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles( BundleCollection bundles )
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js"
             ));

            bundles.Add(new ScriptBundle("~/bundles/otherjs").Include(
                "~/Scripts/respond.js",
                "~/Scripts/html5shiv.js",
                "~/Scripts/jquery.isotope.min.js",
                "~/Scripts/jquery.prettyPhoto.js",
                "~/Scripts/respond.min.js",
                "~/Scripts/wow.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/own").Include(
             "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //"~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/othercss").Include(
              "~/Content/css/font-awesome.css",
              "~/Content/css/responsive.css",
              "~/Content/css/animate.min.css",
              "~/Content/css/prettyPhoto.css",
              "~/Content/css/main.css"));
        }
    }
}