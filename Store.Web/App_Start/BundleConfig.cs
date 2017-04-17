using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Store.Web.App_Start {
    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new ScriptBundle("~/Content/js").Include("~/Content/js/bootstrap.js", "~/Content/js/custom.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/bootstrap.css", "~/Content/css/custom.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}