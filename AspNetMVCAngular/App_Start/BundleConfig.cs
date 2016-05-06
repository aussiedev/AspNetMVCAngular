﻿using System.Web;
using System.Web.Optimization;

namespace AspNetMVCAngular
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/AspNetMVCAngular")
                    .IncludeDirectory("~/Scripts/controllers", "*.js")
                    .Include("~/Scripts/AspNetMVCAngular.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
