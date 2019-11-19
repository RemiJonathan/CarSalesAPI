using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSalesAPI.Controllers
{
    public class VehicleController : ApiController
    {
        // GET api/<controller>
        [Route("api2/GetVehicles")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value9", "value10" };
        }

        // GET api/<controller>/5
        [Route("api2/GetVehicle/{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api2/AddVehicle")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("api2/UpdateVehicle/{id?}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api2/DeleteVehicle/{id?}")]
        public void Delete(int id)
        {
        }
    }
}