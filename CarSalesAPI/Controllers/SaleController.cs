using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSalesAPI.Controllers
{
    public class SaleController : ApiController
    {
        // GET api/<controller>
        [Route("api2/GetSales")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value5", "value6" };
        }

        // GET api/<controller>/5
        [Route("api2/Sale/GetSale/{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api2/Sale/AddSale")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("api2/Sale/UpdateSale/{id?}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api2/Sale/DeleteSale/{id?}")]
        public void Delete(int id)
        {
        }
    }
}