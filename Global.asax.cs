using ProductStore.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace ProductStore
{

    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register); //ToDo: Tener en cuenta que: Es necesario configurar la api primero, ahí se registran las rutas y como son mas especificas que las de los controladores MVC deben ir primero.
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Data.Entity.Database.SetInitializer(
            new ProductStore.Models.OrdersContextInitializer());
        }

    }

}
