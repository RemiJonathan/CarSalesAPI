using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSalesAPI.Controllers
{
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        [Route("api2/GetCustomers")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route("api2/GetCustomer/{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api2/AddCustomer")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("api2/UpdateCustomer/{id?}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api2/DeleteCustomer/{id?}")]
        public void Delete(int id)
        {
        }
    }
}