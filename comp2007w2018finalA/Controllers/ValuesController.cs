using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace comp2007w2018finalA.Controllers
{
    [System.Web.Mvc.Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [System.Web.Http.HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [System.Web.Http.HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [System.Web.Http.HttpPost]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [System.Web.Http.HttpPost]
        public void Delete(int id)
        {
        }
    }
}
