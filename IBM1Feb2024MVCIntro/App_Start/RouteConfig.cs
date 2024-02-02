using IBM1Feb2024MVCIntro.Infra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace IBM1Feb2024MVCIntro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {


            #region Coustom Route
            var constraintsResolver = new DefaultInlineConstraintResolver();

            constraintsResolver.ConstraintMap.Add("Contains", typeof(Infra.ContainValuesConstraint));

            routes.MapMvcAttributeRoutes(constraintsResolver);
            #endregion


            //routes.MapMvcAttributeRoutes();


            //   routes.MapRoute(
            //    "DefaultNoAdmin",
            //    "{controller}/{action}/{id}",
            //    new { controller = "Home", action = "Index", id = "" },
            //    new { controller = new NotEqual("Admin") }
            //);


            //   routes.MapRoute(
            //      "ProductInsert",
            //      "Product/Insert",
            //       new { controller = "Product", action = "Insert" },
            //       new { method = new HttpMethodConstraint("POST") }
            //  );



            //   routes.MapRoute(
            //  name: "BlogArchive",
            //  url: "Archive/{entryDate}",
            //  defaults: new { controller = "Blog", action = "Archive" },
            //  constraints: new { entryDate = @"\d{2}-\d{2}-\d{4}" }

            // );


            //   routes.MapRoute(
            //       "SortRoute",
            //       "Sortdemo/{*values}",
            //       new { controller = "sort", action = "Index" }
            //   );



            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "employeegen", action = "Index", id = UrlParameter.Optional }
            //);







        }
    }
}
