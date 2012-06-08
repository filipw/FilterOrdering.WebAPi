using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi.filters.Controllers
{
    [CustomAttribute2(Position = 2)]
    public class ValuesController : ApiController
    {
        [CustomAttribute(Position = 1)]
        [CustomAttribute3(Position = 3)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}