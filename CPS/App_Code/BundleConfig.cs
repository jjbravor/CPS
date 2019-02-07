using System.Web.Optimization;
public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        //Styles
        //  APP style
        bundles.Add(new StyleBundle("~/bundles/app-styles").Include(
               "~/Content/font-awesome.css",
            "~/Content/metisMenu.css",
            "~/Content/bootstrap.css",
            "~/Content/animate.css",
            "~/Content/jquery.mCustomScrollbar.css",
            "~/Content/icheck-bootstrap.css",
            "~/Content/app-styles/style.css",
            "~/Content/app-styles/style-old.css",
            "~/Content/app-styles/open-sans.css",
            "~/Content/app-styles/ajax-control-toolkit.css"
        ));

        // LOgin Style
        bundles.Add(new StyleBundle("~/bundles/login-styles").Include(
            "~/Content/font-awesome.css",
            "~/Content/bootstrap.css",
            "~/Content/app-styles/pages/login.css"
        ));

        //Scripts
        bundles.Add(new ScriptBundle("~/bundles/app").Include(
              "~/Scripts/jquery-{version}.js",
            "~/Scripts/jquery.validate.js",
            "~/Scripts/jquery.validate.min.js",
            "~/Scripts/bootstrap.js",
            "~/Scripts/metisMenu.js",
            "~/Scripts/jquery.mCustomScrollbar.js",
            "~/Scripts/app/homer.js",
            "~/Scripts/app/helper.js",
            "~/Scripts/app/validacion.js",
            "~/Scripts/app/formatea_fecha.js"
        ));

        bundles.Add(new ScriptBundle("~/bundles/login").Include(
            "~/Scripts/jquery-{version}.js"
        ));
        BundleTable.EnableOptimizations = true;
    }
}
