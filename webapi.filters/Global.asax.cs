using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http.Filters;
using webapi.filters.Filters;

namespace webapi.filters
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Services.Add(typeof(System.Web.Http.Filters.IFilterProvider), new CustomFilterProvider());
            var providers = GlobalConfiguration.Configuration.Services.GetFilterProviders();
            var defaultprovider = providers.First(i => i is ActionDescriptorFilterProvider);
            
            GlobalConfiguration.Configuration.Services.Remove(typeof(System.Web.Http.Filters.IFilterProvider), defaultprovider);

        }
    }
}