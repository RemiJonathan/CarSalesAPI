using DatabaseEntitiesLibrary;
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
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // GET api/<controller>/5
        [Route("api2/GetCustomer/{id?}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/<controller>
        [Route("api2/AddCustomer")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT api/<controller>/5
        [Route("api2/UpdateCustomer/{id?}")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]ApiCustomer newCustomer)
        {/*
            var entity = dbContext.Customer.FirstOrDefault(x => x.CustomerId == id);
            if (entity == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "Customer with Id " + id.ToString() + " not found to update");
            }

            PropertyCopier<Customer, ApiCustomer>.Copy(entity, newCustomer);
            dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, entity);
            */
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE api/<controller>/5
        [Route("api2/DeleteCustomer/{id?}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}