using System.Web;
using System.Web.Optimization;

namespace Bootstrap
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
                        "~/Content/Scripts/AngularJS-1.3.15/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Bootstrap").Include(
                        "~/Content/Scripts/Bootstrap-3.3.2/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/JQuery-2.1.3/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryUI").Include(
                        "~/Content/Scripts/JQueryUI-1.11.4/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/EShopper").Include(
                        "~/Content/Scripts/EShopper/contact.js", 
                        "~/Content/Scripts/EShopper/gmaps.js",
                        "~/Content/Scripts/EShopper/html5shiv.js",
                        "~/Content/Scripts/EShopper/jquery.prettyPhoto.js",
                        "~/Content/Scripts/EShopper/jquery.scrollUp.min.js",
                        "~/Content/Scripts/EShopper/main.js",
                        "~/Content/Scripts/EShopper/price-range.js"));
         
         

            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include(
                   "~/Content/Styles/Bootstrap-3.3.2/bootstrap-theme.min.css",
                   "~/Content/Styles/Bootstrap-3.3.2/bootstrap-theme.css.map",
                   "~/Content/Styles/Bootstrap-3.3.2/bootstrap.min.css",
                   "~/Content/Styles/Bootstrap-3.3.2/bootstrap.css.map"));

            /*bundles.Add(new StyleBundle("~/Content/FontAwesome").Include(
                    "~/Content/Styles/FontAwesome/font-awesome.min.css",
                    "~/Content/Styles/FontAwesome/fontawesome-webfont.svg",
                    "~/Content/Styles/FontAwesome/fontawesome-webfont.woff",
                    "~/Content/Styles/FontAwesome/FontAwesome.otf"));*/

            bundles.Add(new StyleBundle("~/Content/FontAwesome").Include(
                   "~/fonts/font-awesome.min.css",
                   "~/fonts/fontawesome-webfont.svg",
                   "~/fonts/fontawesome-webfont.woff",
                   "~/fonts/FontAwesome.otf",
                   "~/fonts/glyphicons-halflings-regular.eot",
                   "~/fonts/glyphicons-halflings-regular.svg",
                   "~/fonts/glyphicons-halflings-regular.ttf",
                   "~/fonts/glyphicons-halflings-regular.woff"));

            bundles.Add(new StyleBundle("~/Content/JQueryUI").Include(
                    "~/Content/Styles/JQueryUI-1.11.4/jquery-ui.min.css",
                    "~/Content/Styles/JQueryUI-1.11.4/jquery-ui.structure.min.css",
                    "~/Content/Styles/JQueryUI-1.11.4/jquery-ui.theme.min.css"));

            bundles.Add(new StyleBundle("~/Content/OSK").Include(
                    "~/Content/Styles/OSK/animate.css",
                    "~/Content/Styles/OSK/main.css",
                    "~/Content/Styles/OSK/prettyPhoto.css",
                    "~/Content/Styles/OSK/price-range.css",
                    "~/Content/Styles/OSK/responsive.css"));
        }
    }
}
