using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Widgets.PromoSlider.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            ViewEngines.Engines.Insert(0, new PromoViewEngine());

            routes.MapRoute("Plugin.Widgets.PromoSlider.License",
                 "PromoSliderLicense",
                 new { controller = "PromoSlider", action = "License" },
                 new[] { "Nop.Plugin.Widgets.PromoSlider.Controllers" }
            );

            routes.MapRoute("Plugin.Widgets.PromoSlider.Blog",
                 "blog",
                 new { controller = "PromoSlider", action = "Blog" },
                 new[] { "Nop.Plugin.Widgets.PromoSlider.Controllers" }
            );
        }

        public int Priority
        {
            get { return 1; }
        }
    }
}
