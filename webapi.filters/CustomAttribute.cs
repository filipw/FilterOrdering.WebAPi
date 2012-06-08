using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using webapi.filters.Filters;

namespace webapi.filters
{
    public class CustomAttribute : BaseActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            HttpContext.Current.Response.Write(" filter1 ");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            HttpContext.Current.Response.Write(" filter1 ");
        }
    }

    public class CustomAttribute2 : BaseActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            HttpContext.Current.Response.Write(" filter2 ");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            HttpContext.Current.Response.Write(" filter2 ");
        }
    }

    public class CustomAttribute3 : BaseActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            HttpContext.Current.Response.Write(" filter3 ");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            HttpContext.Current.Response.Write(" filter3 ");
        }
    }

    public class CustomAuthorizationAttribute1 : BaseAuthorizationAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            HttpContext.Current.Response.Write(" auth1 ");
        }
    }

    public class CustomAuthorizationAttribute2 : BaseAuthorizationAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            HttpContext.Current.Response.Write(" auth2 ");
        }
    }
}