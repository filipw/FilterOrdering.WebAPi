using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Reflection;

namespace webapi.filters.Filters
{
    public class CustomFilterProvider : IFilterProvider
    {
        public IEnumerable<FilterInfo> GetFilters(HttpConfiguration configuration, HttpActionDescriptor actionDescriptor)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("Configuration is null");                
            }

            if (actionDescriptor == null)
            {
                throw new ArgumentNullException("ActionDescriptor is null");
            }

            IEnumerable<CustomFilterInfo> customActionFilters = actionDescriptor.GetFilters().Select(i => new CustomFilterInfo(i, FilterScope.Controller));
            IEnumerable<CustomFilterInfo> customControllerFilters = actionDescriptor.ControllerDescriptor.GetFilters().Select(i => new CustomFilterInfo(i, FilterScope.Controller));

            return customControllerFilters.Concat(customActionFilters).OrderBy(i => i).Select(i => i.ConvertToFilterInfo());
        }
    }
}