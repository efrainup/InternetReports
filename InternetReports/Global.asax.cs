using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace InternetReports
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Crear carpetas temporales
            string rutaRelativa = ConfigurationManager.AppSettings["RutaTemporalDescargas"];
            if (!Directory.Exists(Server.MapPath(rutaRelativa)))
            {
                Directory.CreateDirectory(Server.MapPath(rutaRelativa));
            }

        }
    }
}
