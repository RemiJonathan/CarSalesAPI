using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSalesAPI.Controllers
{
    public class LocationController : ApiController
    {
        // GET api/<controller>
        [Route("api2/GetLocations")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }

        // GET api/<controller>/5
        [Route("api2/GetLocation/{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api2/AddLocation")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("api2/UpdateLocation/{id?}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api2/DeleteLocation/{id?}")]
        public void Delete(int id)
        {
        }
    }
}