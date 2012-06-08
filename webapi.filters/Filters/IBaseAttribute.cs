using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace webapi.filters.Filters
{
    public interface IBaseAttribute : IFilter
    {
        int Position { get; set; }
    }
}