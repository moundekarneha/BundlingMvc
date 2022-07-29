using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundlingMvc.App_Start
{
    public class BundleCongig2
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/cssStyle").Include("~/Content/Paragraphs.css", "~/Content/Headings.css"));


        }
    }
}