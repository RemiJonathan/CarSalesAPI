﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSalesAPI.Controllers
{
    public class SalespersonController : ApiController
    {
        // GET api/<controller>
        [Route("api2/GetSalespersons")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value7", "value8" };
        }

        // GET api/<controller>/5
        [Route("api2/GetSalesperson/{id?}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("api2/AddSalesperson")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [Route("api2/UpdateSalesperson/{id?}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [Route("api2/DeleteSalesperson/{id?}")]
        public void Delete(int id)
        {
        }
    }
}