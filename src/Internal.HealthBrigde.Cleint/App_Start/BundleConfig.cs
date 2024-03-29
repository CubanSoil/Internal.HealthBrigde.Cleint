﻿using System.Web.Optimization;

namespace Internal.HealthBrigde.Cleint
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/DataTables/jquery.dataTables.js",
                        "~/scripts/DataTables/dataTables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/ManagePatients.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"
                       ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/bootstrap-theme.css",
                      "~/content/DataTables/css/dataTables.bootstrap.css",
                      "~/content/typeahead.css",
                      "~/content/toastr.css",
                      "~/Content/site.css"));
        }
    }
}
