using System.Diagnostics;
using System.Web.Optimization;

namespace GestaoComercial.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/js/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/js/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            #region [ Bootstrap ]

            bundles.Add(new StyleBundle("~/css/bootstrap")
               .Include("~/Content/bootstrap.css")
               );

            bundles.Add(new ScriptBundle("~/js/bootstrap")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/respond.js")
                );

            #endregion

            bundles.Add(new StyleBundle("~/css/site")
                .Include("~/Content/site.css")
                );

            BundleTable.EnableOptimizations = !Debugger.IsAttached;
        }
    }
}
