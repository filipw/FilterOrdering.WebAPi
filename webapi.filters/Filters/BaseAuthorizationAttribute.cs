using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace webapi.filters.Filters
{
    public class BaseAuthorizationAttribute : AuthorizationFilterAttribute, IBaseAttribute
    {
        public int Position { get; set; }

        public BaseAuthorizationAttribute()
        {
            this.Position = 0;
        }
        public BaseAuthorizationAttribute(int positon)
        {
            this.Position = positon;
        }
    }
}