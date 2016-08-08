using System.Web.Optimization;
using AngularDemo.Helpers;

namespace AngularDemo
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Constants.AngularBundle)
                .Include("~/Scripts/angular.js",
                    "~/Scripts/angular-route.js",
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle(Constants.AngularBootstrap)
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(
                new AngularTemplateBundle("angularDemoApp", Constants.TemlateBundle)
                    .IncludeDirectory("~/Scripts/home/views", "*.html", true));

            bundles.Add(new ScriptBundle(Constants.ApplicationBundle)
                .IncludeDirectory("~/Scripts/home", "*.js", true));
        }
    }
}